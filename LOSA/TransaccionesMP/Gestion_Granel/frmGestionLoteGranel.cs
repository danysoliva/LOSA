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
            LoadLotesSoya();
        }

        private void LoadLotesTrigo()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_select_lista_graneles_gestion_lotes_", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@type_id", 0);//0=Trigo, 1=Soya
                dsGestionGranel1.Trigo_Lotes.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsGestionGranel1.Trigo_Lotes);
                con.Close();
                //UpdatePriority();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void LoadLotesSoya()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_select_lista_graneles_gestion_lotes_", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@type_id", 1);//0=Trigo, 1=Soya
                dsGestionGranel1.Soya_Lotes.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsGestionGranel1.Soya_Lotes);
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

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            int id_indexTab = xtraTabControl1.SelectedTabPageIndex;
            int _IdMP;
            if (id_indexTab == 0)
                _IdMP = 12;//Trigo
            else
                _IdMP = 14;//Harina de Soya

            frmAddLoteMP_GranelGestion frm = new frmAddLoteMP_GranelGestion(this.UsuarioLogeado, _IdMP);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                if (xtraTabControl1.SelectedTabPageIndex == 0)
                    LoadLotesTrigo();
                else
                    LoadLotesTrigo();

            }
        }

        void UpdateFilaRowLoteGranel(Int64 pId, int pFila)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_update_lote_activo_orden_priority", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                cmd.Parameters.AddWithValue("@fila", pFila);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdSubir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Subir
            //Recorremos todos para actualizar los priority index
            foreach(dsGestionGranel.Trigo_LotesRow rowi in dsGestionGranel1.Trigo_Lotes)
            {
                UpdateFilaRowLoteGranel(rowi.id, rowi.Linea);
            }

            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsGestionGranel.Trigo_LotesRow)gridView.GetFocusedDataRow();
            int index = gridView.FocusedRowHandle;

            switch (row.Linea)
            {
                case 1:

                    break;
                default:
                    //Row Posterior
                    var rowPrev = (dsGestionGranel.Trigo_LotesRow)gridView.GetDataRow(index - 1);
                    rowPrev.Linea = row.Linea;
                    row.Linea--;
                    UpdateFilaRowLoteGranel(rowPrev.id, rowPrev.Linea);
                    UpdateFilaRowLoteGranel(row.id, row.Linea);
                    LoadLotesTrigo();
                    break;
            }
        }

        private void cmdBajar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Bajar
            //Recorremos todos para actualizar los priority index
            foreach (dsGestionGranel.Trigo_LotesRow rowi in dsGestionGranel1.Trigo_Lotes)
            {
                UpdateFilaRowLoteGranel(rowi.id, rowi.Linea);
            }

            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsGestionGranel.Trigo_LotesRow)gridView.GetFocusedDataRow();
            int index = gridView.FocusedRowHandle;
            if(row.Linea < (dsGestionGranel1.Trigo_Lotes.Count))
            {
                //Row Posterior
                var rowPrev = (dsGestionGranel.Trigo_LotesRow)gridView.GetDataRow(index + 1);
                rowPrev.Linea = row.Linea;
                row.Linea++;
                UpdateFilaRowLoteGranel(rowPrev.id, rowPrev.Linea);
                UpdateFilaRowLoteGranel(row.id, row.Linea);
                LoadLotesTrigo();
            }
        }

        private void cmdSubir_Soya_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Subir Soya
            //Recorremos todos para actualizar los priority index
            foreach (dsGestionGranel.Soya_LotesRow rowi in dsGestionGranel1.Soya_Lotes)
            {
                UpdateFilaRowLoteGranel(rowi.id, rowi.Linea);
            }

            var gridView = (GridView)gridControl2.FocusedView;
            var row = (dsGestionGranel.Soya_LotesRow)gridView.GetFocusedDataRow();
            int index = gridView.FocusedRowHandle;

            switch (row.Linea)
            {
                case 1:

                    break;
                default:
                    //Row Posterior
                    var rowPrev = (dsGestionGranel.Soya_LotesRow)gridView.GetDataRow(index - 1);
                    rowPrev.Linea = row.Linea;
                    row.Linea--;
                    UpdateFilaRowLoteGranel(rowPrev.id, rowPrev.Linea);
                    UpdateFilaRowLoteGranel(row.id, row.Linea);
                    LoadLotesSoya();
                    break;
            }
        }

        private void cmdBajar_Soya_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Bajar Soya
            //Recorremos todos para actualizar los priority index
            foreach (dsGestionGranel.Soya_LotesRow rowi in dsGestionGranel1.Soya_Lotes)
            {
                UpdateFilaRowLoteGranel(rowi.id, rowi.Linea);
            }

            var gridView = (GridView)gridControl2.FocusedView;
            var row = (dsGestionGranel.Soya_LotesRow)gridView.GetFocusedDataRow();
            int index = gridView.FocusedRowHandle;
            if (row.Linea < (dsGestionGranel1.Trigo_Lotes.Count))
            {
                //Row Posterior
                var rowPrev = (dsGestionGranel.Soya_LotesRow)gridView.GetDataRow(index + 1);
                rowPrev.Linea = row.Linea;
                row.Linea++;
                UpdateFilaRowLoteGranel(rowPrev.id, rowPrev.Linea);
                UpdateFilaRowLoteGranel(row.id, row.Linea);
                LoadLotesSoya();
            }
        }

        private void cmdDesactivar_Soya_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Desactivar
            //Eliminar row del grid
            DialogResult r = MessageBox.Show("¿Desea desactivar ésta linea?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes)
                return;

            var gridView1 = (GridView)gridControl2.FocusedView;
            var row = (dsGestionGranel.Soya_LotesRow)gridView1.GetFocusedDataRow();
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
                    gridView2.DeleteRow(gridView1.FocusedRowHandle);
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }
    }
}