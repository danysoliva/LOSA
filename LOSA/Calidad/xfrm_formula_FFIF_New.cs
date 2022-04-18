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
    public partial class xfrm_formula_FFIF_New : DevExpress.XtraEditors.XtraForm
    {
        public enum Transaccion
        {
            Nuevo=1,
            Editar=2
        }

        int tipoTransaccion = 0;

        FFIF_H item = new FFIF_H();

        public xfrm_formula_FFIF_New(int transaccion_p, FFIF_H item_p)
        {
            InitializeComponent();

            tipoTransaccion = transaccion_p;
            item = item_p;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                switch (tipoTransaccion)
                {
                    case 1:
                        if (valida_existe_certificado(Mes.SelectedIndex + 1, deAnio.DateTime.Date.Year))
                        {
                            CajaDialogo.Error("Ya existe un certificado para este mes y año");
                            return;
                        }
                        else
                        {
                            cnx.Open();
                            SqlCommand cmd = new SqlCommand("dbo.sp_insert_formula_FFIF_H", cnx);

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("mes", SqlDbType.Int).Value = Mes.SelectedIndex + 1;
                            cmd.Parameters.Add("anio", SqlDbType.Int).Value = deAnio.DateTime.Date.Year;
                            cmd.Parameters.Add("fecha_i", SqlDbType.Date).Value = deFechaInicio.EditValue;
                            cmd.Parameters.Add("fecha_f", SqlDbType.Date).Value = deFechaFin.EditValue;
                            cmd.Parameters.Add("comentario", SqlDbType.VarChar).Value = txtComentario.Text;

                            cmd.ExecuteNonQuery();

                            cnx.Close();

                            CajaDialogo.Information("DATOS GUARDADOS");
                            this.DialogResult = DialogResult.OK;
                        }
                            break;

                    case 2:
                        cnx.Open();
                        SqlCommand cmd2 = new SqlCommand("dbo.sp_update_Formla_FFIF_h", cnx);

                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.Add("id_h", SqlDbType.Int).Value = item.ID;
                        //cmd.Parameters.Add("anio", SqlDbType.Int).Value = deAnio.DateTime.Date.Year;
                        cmd2.Parameters.Add("fecha_i", SqlDbType.Date).Value = deFechaInicio.EditValue;
                        cmd2.Parameters.Add("fecha_f", SqlDbType.Date).Value = deFechaFin.EditValue;
                        cmd2.Parameters.Add("comentario", SqlDbType.VarChar).Value = txtComentario.Text;

                        cmd2.ExecuteNonQuery();

                        cnx.Close();

                        CajaDialogo.Information("DATOS ACTUALIZADOS");
                        this.DialogResult = DialogResult.OK;
                        break;

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private Boolean valida_existe_certificado(int mes,int anio)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("dbo.sp_validar_existe_formula_FFIF_H", cnx);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@mes", SqlDbType.Int).Value = mes;
                    cmd.Parameters.Add("@anio", SqlDbType.Int).Value = anio;

                    Boolean existe_certificado = Convert.ToBoolean(cmd.ExecuteScalar());
                    cnx.Close();

                    return existe_certificado;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        private void xfrm_formula_FFIF_New_Load(object sender, EventArgs e)
        {
            if (tipoTransaccion==2)
            {
                txtComentario.Text = item.Comentario;
                deFechaInicio.EditValue = item.FechaInicial;
                deFechaFin.EditValue = item.FechaFinal;
                Mes.SelectedIndex = item.Mes-1;
                deAnio.EditValue = item.Anio;
            }
        }
    }
}
