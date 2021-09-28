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
using ACS.Classes;
using LOSA.Clases;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Nir
{
    public partial class frmLecturas : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int ligado = 0;
        UserLogin UsuarioLogeado;
        public frmLecturas(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            load_Data();
        }

        public void load_Data()
        {
            string Query = @"sp_load_lecturas_nir_header";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bit_ligada", ligado);
                dsNir.header_nir.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsNir.header_nir);
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

        private void tggligadura_Toggled(object sender, EventArgs e)
        {
            if (tggligadura.IsOn)
            {
                ligado = 1;
                load_Data();
            }
            else
            {
                ligado = 0;
                load_Data();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frm_cargar_lecturas frm = new frm_cargar_lecturas(UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_Data();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsNir.header_nirRow)gridView.GetFocusedDataRow();
                frm_cargar_lecturas frm = new frm_cargar_lecturas(UsuarioLogeado, row.id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    load_Data();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsNir.header_nirRow)gridView.GetFocusedDataRow();
                if (row.ligada)
                {
                    CajaDialogo.Error("No se puede eliminar una lectura que se ha empezado a utilizar.");
                    return;
                }
                else
                {
                    if (MessageBox.Show("Desea eliminar esta lectura?", "Desea eliminar esta lectura?", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        string query = @"sp_unable_lectura_nir";
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(query,cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id",row.id);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        load_Data();
                    }
                }
               
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btn_ligar_Click(object sender, EventArgs e)
        {
            frmLigarLecturas frm = new frmLigarLecturas(UsuarioLogeado);
            frm.Show();
        }
    }
}