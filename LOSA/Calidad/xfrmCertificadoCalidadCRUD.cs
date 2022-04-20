using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Calidad.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Calidad
{
    public partial class xfrmCertificadoCalidadCRUD : DevExpress.XtraEditors.XtraForm
    {
        public enum Transaccion
        {
            Nuevo=1,
            Editar=2
        }

        int tipoTransaccion;
        FFIF_D item;

        public xfrmCertificadoCalidadCRUD(int transaccion_p,FFIF_D item_p)
        {
            InitializeComponent();

            tipoTransaccion = transaccion_p;
            loadFormulas();
            item = item_p;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xfrmCertificadoCalidadCRUD_Load(object sender, EventArgs e)
        {

            if (tipoTransaccion==2)
            {
                txtFFIF.Text = item.FFIF.ToString();
                slueFormula.EditValue = item.FormulaID;
                txtVersionForanea.Text = item.VersionForanea.ToString();
            }

          
        }

        private void loadFormulas()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.get_formulas", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //da.SelectCommand.Parameters.Add("@id_h", SqlDbType.Int).Value = id_h;

                    dsMantenimientoC.Formula.Clear();
                    da.Fill(dsMantenimientoC.Formula);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();

                switch (tipoTransaccion)
                {
                    case 1:

                        if (string.IsNullOrEmpty( txtFFIF.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR UN FFIF");
                            return;
                        }

                        if (string.IsNullOrEmpty(txtVersionForanea.Text))
                        {
                            CajaDialogo.Error("DEBE INGRESAR UNA VERSIÓN FORÁNEA");
                            return;
                        }

                        if (string.IsNullOrEmpty(slueFormula.Text))
                        {
                            CajaDialogo.Error("DEBE SELECCIONAR UNA FÓRMULA");
                            return;
                        }

                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                        {
                            cnx.Open();

                            SqlCommand cmd = new SqlCommand("dbo.sp_insert_FFIF_Formula_d",cnx);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@FFIF",SqlDbType.Decimal).Value=txtFFIF.Text;
                            cmd.Parameters.Add("@id_formula", SqlDbType.Int).Value = slueFormula.EditValue ;
                            cmd.Parameters.Add("@version_foranea", SqlDbType.Int).Value = txtVersionForanea.Text ;
                            cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                            cmd.Parameters.Add("@id_h", SqlDbType.Int).Value = item.ID_H;

                            cmd.ExecuteNonQuery();

                            cnx.Close();

                            CajaDialogo.Information("DATOS GUARDADOS");
                            this.DialogResult = DialogResult.OK;

                        }
                        break;


                    case 2:
                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                        {
                            cnx.Open();

                            SqlCommand cmd = new SqlCommand("dbo.sp_update_FFIF_Formula_d", cnx);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@FFIF", SqlDbType.Decimal).Value = txtFFIF.Text;
                            cmd.Parameters.Add("@id_formula", SqlDbType.Int).Value = slueFormula.EditValue;
                            cmd.Parameters.Add("@version_foranea", SqlDbType.Int).Value = txtVersionForanea.Text;
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = item.ID;

                            cmd.ExecuteNonQuery();

                            cnx.Close();

                            CajaDialogo.Information("DATOS ACTUALIZADOS");
                            this.DialogResult = DialogResult.OK;

                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

       
    }
}