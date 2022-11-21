using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;

namespace LOSA.MigracionACS.Produccion
{
    public partial class PP_reserva : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int cantidad;
        UserLogin UsuarioLogeado;
        public PP_reserva(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            load_data();
        }
        public void load_data()
        {
            cantidad = Convert.ToInt32(txtlote.Value);
            string query = @"sp_load_lotes_to_reservar";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cant", cantidad);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsLotes.reservar.Clear();
                da.Fill(dsLotes.reservar);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Information(ex.Message);
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dsLotes.reservar.Count < 0)
            {
                CajaDialogo.Error("Debe especificar al menos la cantidad de un lote a reservar.");
                return;
            }

            if (MessageBox.Show("Desea reservar estos lotes?", "Desea reservar estos lotes?",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                foreach (dsLotes.reservarRow row in dsLotes.reservar.Rows)
                {
                   
                    try
                    {
                        string query = @"sp_insert_lotes_reservados";
                        
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@lote", row.lote);
                        cmd.Parameters.AddWithValue("@user", UsuarioLogeado.UserId);
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {

                        CajaDialogo.Error(ex.Message);
                    }
                }
                cn.Close();
                CajaDialogo.Information("Transaccion Exitosa!");
                return;
            }
        }

        private void txtlote_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            
        }

        private void txtlote_EditValueChanged(object sender, EventArgs e)
        {
            load_data();
        }
    }
}