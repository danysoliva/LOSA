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

namespace LOSA.Despachos
{
    public partial class frm_view_entrega_despacho : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int Pid;
        public frm_view_entrega_despacho(int id_despacho)
        {
            InitializeComponent();
            Pid = id_despacho;
            load_informacion();
            load_filas();
        }
        public void load_filas()
        {
            string query = @"sp_load_tarimas_to_orden_despacho";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", Pid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.producto_carga.Clear();
                da.Fill(ds_despachos.producto_carga);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
       
        public void load_informacion()
        {
            string query = @"sp_load_informacion_despacho_entregado";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_despacho", Pid);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtconductor.Text = dr.IsDBNull(6) ? "" : dr.GetString(6);
                    txtplaca.Text = dr.IsDBNull(3) ? " " : dr.GetString(3);
                    txtoc.Text = dr.IsDBNull(5) ? " " : dr.GetString(5);
                    txtfurgon.Text = dr.IsDBNull(4) ? "" : dr.GetString(4);
                    dtFecha.EditValue = dr.IsDBNull(1) ? DateTime.Now : dr.GetDateTime(1);   
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}