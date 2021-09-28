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
using ACS.Classes;
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Nir
{
    public partial class frmSeleccionarLectura : DevExpress.XtraEditors.XtraForm
    {
        public int id_lectura;
        public int id_h;
        public int id_lote;
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        public frmSeleccionarLectura(UserLogin Puser, int pid_lote)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            id_lote = pid_lote;
            load_Data();
        }

        public void load_Data() 
        {
            string Query = @"sp_load_lecturas_to_pick";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsNir.seleccion_lectura.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsNir.seleccion_lectura);
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

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsNir.seleccion_lecturaRow)gridView.GetFocusedDataRow();
                id_lectura = row.id;
                id_h = row.id_h;
                if (CajaDialogo.Pregunta("Desea ligar esta lectura a este ingreso?") == DialogResult.Yes)
                {
                    string query = @"sp_insert_in_trz_nir_ingreso";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query,cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_lectura", id_lectura);
                    cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                    cmd.Parameters.AddWithValue("@id_ingreso", id_lote);
                    cmd.Parameters.AddWithValue("@id_h_lectura", id_h);
                    cmd.ExecuteNonQuery();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void grdv_data_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsNir.seleccion_lecturaRow)gridView.GetFocusedDataRow();
                id_lectura = row.id;
                id_h = row.id_h;
                if (CajaDialogo.Pregunta("Desea ligar esta lectura a este ingreso?") == DialogResult.Yes)
                {
                    string query = @"sp_insert_in_trz_nir_ingreso";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_lectura", id_lectura);
                    cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                    cmd.Parameters.AddWithValue("@id_ingreso", id_lote);
                    cmd.Parameters.AddWithValue("@id_h_lectura", id_h);
                    cmd.ExecuteNonQuery();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}