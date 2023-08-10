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

namespace LOSA.Calidad
{
    public partial class ConfiguracionMP : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public ConfiguracionMP(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            load_data();
        }

        public void load_data()
        {
            string query = @"sp_load_mp_to_seleccion";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsMantenimientoC.mp.Clear();
                da.Fill(dsMantenimientoC.mp);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsMantenimientoC.mpRow)gridView.GetFocusedDataRow();
                frmMateriaPrimaAjuste frm = new frmMateriaPrimaAjuste(row.id, row.descripcion, UsuarioLogeado);
                frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdv_data_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsMantenimientoC.mpRow)gridView.GetFocusedDataRow();
                frmMateriaPrimaAjuste frm = new frmMateriaPrimaAjuste(row.id, row.descripcion, UsuarioLogeado);
                frm.Show();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}