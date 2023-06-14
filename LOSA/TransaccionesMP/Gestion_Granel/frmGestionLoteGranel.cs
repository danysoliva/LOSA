using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.TransaccionesMP.Gestion_Granel;
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

namespace JAGUAR_APP.TransaccionesMP.Gestion_Granel
{
    public partial class frmGestionLoteGranel : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmGestionLoteGranel(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            LoadLotesTrigo();
        }

        private void LoadLotesTrigo()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                //dsPresupuesto1.estados.Clear();
                //SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //adat.Fill(dsPresupuesto1.estados);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdDesactivar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Eliminar row del grid
            DialogResult r = MessageBox.Show("¿Desea desactivar ésta linea?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes)
                return;

            var gridView1 = (GridView)gridControl1.FocusedView;
            var row = (dsGestionGranel.Trigo_LotesRow)gridView1.GetFocusedDataRow();
            int value_res = 0;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_update_lote_granel_consumo_auto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.Parameters.AddWithValue("@id_estado", 3);
                //1     Habilitado     
                //2     En Consumo      
                //3     Desactivado     
                value_res = Convert.ToInt32(cmd.ExecuteScalar());

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            if (value_res == 1)
            {
                try
                {
                    gridView1.DeleteRow(gridView1.FocusedRowHandle);
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }
    }
}