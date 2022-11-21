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
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;

namespace LOSA.MigracionACS.Produccion
{
    public partial class PP_Gestion_lote : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        public PP_Gestion_lote(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            load_data();
        }
        public void load_data()
        {
            string query = @"sp_pp_load_gestion_lote";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsLotes.gestionlotes.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsLotes.gestionlotes);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btncerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PP_reserva frm = new PP_reserva(UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();

            }
        }

        private void grdv_data_RowStyle(object sender, RowStyleEventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsLotes.gestionlotesRow)gridView.GetDataRow(e.RowHandle);
            if (e.RowHandle >= 0)
            {

                if (row.reservado)
                {
                    e.Appearance.BackColor = Color.FromArgb(128, 151, 48);

                }
                else
                {
                    e.Appearance.BackColor = Color.FromArgb(255, 218, 0);
                }
            }
        }
    }
}