using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.Calidad.Parametros
{
    public partial class frmPickParametrs : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int Id_pt;
        public frmPickParametrs(int ParametroId_PT, bool ParametroCalidad)
        {
            InitializeComponent();
            Id_pt = ParametroId_PT;
            load_data(ParametroCalidad);
        }
        public void load_data(bool pParametroCalidad)
        {
            string query = @"[sp_load_parametros_excluyendo_configurados_by_ptV2]";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", Id_pt);
                cmd.Parameters.AddWithValue("@parametro_calidad", pParametroCalidad);
                dsParametros1.parametroToPick.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsParametros1.parametroToPick);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var Cantidad = (from num in dsParametros1.parametroToPick
                            where num.Selected == true
                            select num).Count();
            if (Cantidad == 0)
            {
                CajaDialogo.Error("Debe seleccionar al menos un parametro.");
                return;
            }
            // good to go.

            string query = @"sp_insert_into_parametros_pt";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);

                foreach (dsParametros.parametroToPickRow row in dsParametros1.parametroToPick.Rows)
                {
                    if (row.Selected)
                    {
                        cmd = new SqlCommand(query,cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_parametros", row.id);
                        cmd.Parameters.AddWithValue("@id_pt", Id_pt);
                        cmd.ExecuteNonQuery();
                    }
                }
                CajaDialogo.Information("Ajuste Realizado!");
                this.DialogResult = DialogResult.OK;


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}