using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
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
using LOSA.Clases;
namespace LOSA.Calidad
{
    public partial class frmLotesStatus : Form
    {
        int gridActual = 1;
        UserLogin UsuarioLogeado;
        public frmLotesStatus(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            LoadTarimasAvailables();
            LoadTarimasObs();
            LoadTarimasRet();
           
        }

        private void LoadTarimasAvailables()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tarimas_habilitadas_calidad", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dsCalidad1.tarimas_disponibles.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCalidad1.tarimas_disponibles);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadTarimasObs()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tarimas_obs_calidad", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dsCalidad1.tarimas_obs.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCalidad1.tarimas_obs);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadTarimasRet()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tarimas_ret_calidad", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dsCalidad1.tarimas_ret.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCalidad1.tarimas_ret);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //click en editar

        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //habilitado
            UpdateEstado(1);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Observacion
            UpdateEstado(2);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Retenido
            //UpdateEstado(3);
            var gridView = (GridView)grDisponibles.FocusedView;
            var row = (dsCalidad.tarimas_disponiblesRow)gridView.GetFocusedDataRow();
             int  id = row.id;
            frm_asiganacion_causas frm = new frm_asiganacion_causas(UsuarioLogeado, id );
            if (frm.ShowDialog() == DialogResult.OK)
            {

                LoadTarimasAvailables();
                LoadTarimasObs();
                LoadTarimasRet();
            }
        }

        void UpdateEstado(int pIdEstadoNew)
        {
            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                int id = 0;
                switch(gridActual)
                {
                    case 1:
                        var gridView = (GridView)grDisponibles.FocusedView;
                        var row = (dsCalidad.tarimas_disponiblesRow)gridView.GetFocusedDataRow();
                        id = row.id;
                       
                        break;
                    case 2:
                        var gridView1 = (GridView)gridObservacion.FocusedView;
                        var row1 = (dsCalidad.tarimas_obsRow)gridView1.GetFocusedDataRow();
                        id = row1.id;
                        break;
                    case 3:
                        var gridView2 = (GridView)gridRetenidos.FocusedView;
                        var row2 = (dsCalidad.tarimas_retRow)gridView2.GetFocusedDataRow();
                        id = row2.id;
                        break;
                    default:
                        break;
                }

                if (pIdEstadoNew == 1)
                {
                    SqlCommand command = new SqlCommand("sp_update_calidad_tarimas", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_tarima", id);
                    command.Parameters.AddWithValue("@user", UsuarioLogeado.Id);
                    command.ExecuteNonQuery();
                }

                SqlCommand cmd = new SqlCommand("sp_set_update_tarima_estado_calidad", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_estado", pIdEstadoNew);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadTarimasAvailables();
                LoadTarimasObs();
                LoadTarimasRet();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gvMateriaPrima_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Cursor.Position);
                gridActual = 1;
            }
        }

        private void gvMateriaPrima_DoubleClick(object sender, EventArgs e)
        {
            popupMenu1.ShowPopup(Cursor.Position);
            gridActual = 1;
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Cursor.Position);
                gridActual = 2;
            }
        }

        private void gridView2_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Cursor.Position);
                gridActual = 3;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            popupMenu1.ShowPopup(Cursor.Position);
            gridActual = 2;
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            popupMenu1.ShowPopup(Cursor.Position);
            gridActual = 3;
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView2 = (GridView)gridRetenidos.FocusedView;
                var row2 = (dsCalidad.tarimas_retRow)gridView2.GetFocusedDataRow();
                frmview frm = new frmview(row2.id, row2.mp, UsuarioLogeado);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadTarimasAvailables();
                    LoadTarimasObs();
                    LoadTarimasRet();

                }
            }
            catch (Exception ex)
            {
                
            }

        }

        private void btndetalle_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView2 = (GridView)grDisponibles.FocusedView;
                var row2 = (dsCalidad.tarimas_disponiblesRow)gridView2.GetFocusedDataRow();
                frmview frm = new frmview(row2.id, row2.mp, UsuarioLogeado);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadTarimasAvailables();
                    LoadTarimasObs();
                    LoadTarimasRet();

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btndetalle3_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView2 = (GridView)gridObservacion.FocusedView;
                var row2 = (dsCalidad.tarimas_obsRow)gridView2.GetFocusedDataRow();
                frmview frm = new frmview(row2.id, row2.mp, UsuarioLogeado);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadTarimasAvailables();
                    LoadTarimasObs();
                    LoadTarimasRet();

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnhabilitarL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateStatusLote(1);
        }

        private void btnObservarL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateStatusLote(2);
        }

        private void btnRetenerL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateStatusLote(3);
        }
        public void UpdateStatusLote( int Estado)
        {

            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                string lote = "";
                switch (gridActual)
                {
                    case 1:
                        var gridView = (GridView)grDisponibles.FocusedView;
                        var row = (dsCalidad.tarimas_disponiblesRow)gridView.GetFocusedDataRow();
                        lote = row.lote;

                        break;
                    case 2:
                        var gridView1 = (GridView)gridObservacion.FocusedView;
                        var row1 = (dsCalidad.tarimas_obsRow)gridView1.GetFocusedDataRow();
                        lote = row1.lote;
                        break;
                    case 3:
                        var gridView2 = (GridView)gridRetenidos.FocusedView;
                        var row2 = (dsCalidad.tarimas_retRow)gridView2.GetFocusedDataRow();
                        lote = row2.lote;
                        break;
                    default:
                        break;
                }
                switch (Estado)
                {
                    case 1: // Habilitado
                        var gridView = (GridView)grDisponibles.FocusedView;
                        var row = (dsCalidad.tarimas_disponiblesRow)gridView.GetFocusedDataRow();
                        lote = row.lote;

                        break;
                    case 2: //Observacion
                        var gridView1 = (GridView)gridObservacion.FocusedView;
                        var row1 = (dsCalidad.tarimas_obsRow)gridView1.GetFocusedDataRow();
                        lote = row1.lote;
                        break;
                    case 3: // Retenido
                        frm_asiganacion_causas frm = new frm_asiganacion_causas(UsuarioLogeado, lote);
                        if (frm.ShowDialog() == DialogResult.OK)
                        {

                            LoadTarimasAvailables();
                            LoadTarimasObs();
                            LoadTarimasRet();
                        }
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
