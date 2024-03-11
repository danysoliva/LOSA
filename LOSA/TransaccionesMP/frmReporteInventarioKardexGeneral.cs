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
using DevExpress.XtraGrid.Views.Grid;
using System.Threading;
using LOSA.Calidad.LoteConfConsumo;
using LOSA.TransaccionesMP.Reportes;

namespace LOSA.TransaccionesMP
{
    public partial class frmReporteInventarioKardexGeneral : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        MateriaPrima MateriaPrimaAllBodegas;
        int IdMateriaPrimaTab_MP_por_Bodega;
        public frmReporteInventarioKardexGeneral(UserLogin pUserLogin)
        {
            InitializeComponent();
            MateriaPrimaAllBodegas = new MateriaPrima();

            switch (pUserLogin.Idnivel)
            {
                case 1://Basic View
                    btnAjustePorLote.Visible = false;
                    break;
                case 2://Basic No Autorization
                    btnAjustePorLote.Visible = false;
                    break;
                case 3://Medium Autorization

                    break;
                case 4://Depth With Delta
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }
            load_dataPorLotes();
            load_data_totales();
            Load_dataReprocesoPorLote();
            //load_dataPRD();
            //backgroundWorkerResumenMP.RunWorkerAsync();
            //backgroundWorkerPRD.RunWorkerAsync();
            UsuarioLogeado = pUserLogin;
        }

        private void Load_dataReprocesoPorLote()
        {
            
            string query = @"sp_get_kardex_by_lot_reproceso";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTarima1.kardex_by_Reproceso.Clear();
                da.Fill(dsTarima1.kardex_by_Reproceso);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_dataPorLotes()
        {
            //string query = @"sp_obtener_inventario_general_por_lotev2";
            string query = @"sp_get_kardex_by_lot";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //dsTarima1.informacion.Clear();
                //da.Fill(dsTarima1.informacion);
                dsTarima1.kardex_by_lot.Clear();
                da.Fill(dsTarima1.kardex_by_lot);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
            //backgroundWorkerResumenMP.CancelAsync();
            //backgroundWorkerResumenMP.Dispose();
        }

        public void load_dataPRD()
        {
            string query = @"sp_get_detalle_lotes_entregados_a_prd";
            try
            {
                DataOperations dp1 = new DataOperations();
                SqlConnection cn = new SqlConnection(dp1.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTarima1.informacionPRD.Clear();
                da.Fill(dsTarima1.informacionPRD);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            //backgroundWorkerPRD.CancelAsync();
            //backgroundWorkerPRD.Dispose();
        }

        public void load_dataResumenMP_por_bodega()
        {
            //string query = @"[sp_obtener_inventario_general_por_bodega]";
            string query = @"[sp_obtener_inventario_general_por_bodega_v2]";
            try
            {
                DataOperations dp1 = new DataOperations();
                SqlConnection cn = new SqlConnection(dp1.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTarima1.totales_bodegav2.Clear();
                da.Fill(dsTarima1.totales_bodegav2);
                cn.Close();
                //gridControl2.au
                //gridControl2.Views[0].
                gridView2.ExpandAllGroups();
                //var row = (dsMensualidades.mensualidadesRow)gridView.GetFocusedDataRow();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            //backgroundWorkerPRD.CancelAsync();
            //backgroundWorkerPRD.Dispose();
        }

        public void load_data_totales()
        {
            //string query = @"sp_obtener_inventario_general";
            string query = @"[sp_obtener_inventario_general_v2]";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTarima1.totales.Clear();
                da.Fill(dsTarima1.totales);
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 0)
            {//Resumen por lote
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grd_data.ExportToXlsx(dialog.FileName);
                }
            }
            if (tabPane1.SelectedPageIndex == 1)
            {//Resumen por Mp y Bodega
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grd_data_resumen.ExportToXlsx(dialog.FileName);
                }
            }
            if (tabPane1.SelectedPageIndex == 2)
            {//Resumen por Mp y Bodega
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    gridControl1.ExportToXlsx(dialog.FileName);
                }
            }
            if (tabPane1.SelectedPageIndex == 3)
            {//Resumen por lote
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    gridControl2.ExportToXlsx(dialog.FileName);
                }
            }
            if (tabPane1.SelectedPageIndex == 5)//Materia Prima por Bodega
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grdMPBodega.ExportToXlsx(dialog.FileName);
                }
            }
            else
            {//Totales
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    gridReproceso.ExportToXlsx(dialog.FileName);
                }
            }

            
        }

        private void btn_logmovimiento_Click(object sender, EventArgs e)
        {

        }

        private void btnAjustePorLote_Click(object sender, EventArgs e)
        {
            //switch (UsuarioLogeado.GrupoUsuario.GrupoUsuarioActivo)
            //{
              
            //    case GrupoUser.GrupoUsuario.Administradores:
            //        frmAsjuteInventarioPorLote frm1 = new frmAsjuteInventarioPorLote(UsuarioLogeado);
            //        if (frm1.ShowDialog() == DialogResult.OK)
            //        {
            //            load_dataPorLotes();
            //        }
            //        break;

            //    default:
                    Funciones fn1 = new Funciones();
                    if (fn1.GetRutaAjustesInventario() == 1)
                    {
                        frmAsjuteInventarioPorLoteWithAutorization frm = new frmAsjuteInventarioPorLoteWithAutorization(UsuarioLogeado);
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            load_dataPorLotes();
                        }
                    }
                    else
                    {
                        frmAsjuteInventarioPorLote frm = new frmAsjuteInventarioPorLote(UsuarioLogeado);
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            load_dataPorLotes();
                        }
                    }
                    //break;
            //}
           
            
        }

        private void buttonEdit_AjusteINV_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //AJUSTE de KARDEX General
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsTarima.kardex_by_lotRow)gridView.GetFocusedDataRow();

            //frmAsjuteInventarioPorLote frm = new frmAsjuteInventarioPorLote(UsuarioLogeado, row.id_mp, 0, row.lote);
            frmAsjuteInventarioPorLoteWithAutorization frm = new frmAsjuteInventarioPorLoteWithAutorization(UsuarioLogeado, row.id_mp, 0, row.lote);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_dataPorLotes();
            }
        }

        private void grdv_data_RowStyle(object sender, RowStyleEventArgs e)
        {
            //if (e.RowHandle >= 0)
            //{
            //    var gridView = (GridView)grd_data.FocusedView;
            //    //var row = (dsNotas.notas_resumenRow)gridView.GetFocusedDataRow();
            //    var row = (dsTarima.kardex_by_lotRow)gridView.GetDataRow(e.RowHandle);
            //    if (row != null)
            //    {
            //        if (row.existencia>0)
            //            e.Appearance.BackColor = Color.FromArgb(255, 255, 255);//verde
            //        else
            //            e.Appearance.BackColor = Color.FromArgb(255, 102, 102);//rojo

            //    }
            //}
        }

        private void backgroundWorkerPRD_DoWork(object sender, DoWorkEventArgs e)
        {
            //load_dataPRD();
            //load_data_totales();
            //load_data();
            //backgroundWorkerPRD.CancelAsync();

            BackgroundWorker worker = sender as BackgroundWorker;

            if (worker.CancellationPending == true)
            {
                e.Cancel = true;                
            }
            else
            {
                load_dataPRD();
                worker.CancelAsync();
            }
            
        }

        private void backgroundWorkerResumenMP_DoWork(object sender, DoWorkEventArgs e)
        {
            //load_data_totales();
            //load_dataPRD();
            //load_data();
            //backgroundWorkerResumenMP.CancelAsync();
            BackgroundWorker worker = sender as BackgroundWorker;

            if (worker.CancellationPending == true)
            {
                e.Cancel = true;
            }
            else
            {
                load_dataPorLotes();
                worker.CancelAsync();
            }
        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            //if (backgroundWorkerPRD.IsBusy || backgroundWorkerResumenMP.IsBusy)
            //{
            switch (e.Page.Caption)
            {
                case "Resumen por materia prima":
                    if (dsTarima1.totales.Count == 0)
                        load_data_totales();
                    break;
                case "En Bodega PRD":
                    if(dsTarima1.informacionPRD.Count==0)
                        load_dataPRD();
                    break;
                case "Resumen por lote":
                    if (dsTarima1.informacion.Count == 0)
                        load_dataPorLotes();
                    break;
                case "Resumen por MP y Bodega":
                    if (dsTarima1.totales_bodega.Count == 0)
                        load_dataResumenMP_por_bodega();
                    break;
            }
            //}
        }

        private void repositoryAjuste_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridReproceso.FocusedView;
            var row = (dsTarima.kardex_by_ReprocesoRow)gridView.GetFocusedDataRow();

            //frmAsjuteInventarioPorLote frm = new frmAsjuteInventarioPorLote(UsuarioLogeado, row.id_mp, 0, row.lote, row.id_bodega, frmAsjuteInventarioPorLote.Comportamiento.);
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    Load_dataReprocesoPorLote();
            //}
        }

        private void btnSearchMP_Click(object sender, EventArgs e)
        {
            LoadLotesBG();
        }

        private void LoadLotesBG()
        {
            if (tggMostrarTotasInv_por_mp_y_bodega.IsOn)//Mostrar Todos
            {
                LoadBodegaMP(0);
            }
            else//Mostrar solo MP Seleccionada
            {
                frmSearchMP frm = new frmSearchMP(frmSearchMP.TipoBusqueda.MateriaPrima);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadBodegaMP(frm.ItemSeleccionado.id);
                    txtTitulo_Inv_Por_MPyBodega.Text = frm.ItemSeleccionado.ItemCode + " " + frm.ItemSeleccionado.ItemName;
                    MateriaPrimaAllBodegas.RecuperarRegistroFromID_RM(frm.ItemSeleccionado.id);
                    IdMateriaPrimaTab_MP_por_Bodega = frm.ItemSeleccionado.id;
                }
            }
        }

        private void LoadBodegaMP(int pidRM)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_obtener_inventario_general_por_bodega_for_MP_v2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", pidRM);
                dsTarima1.mp_bodega_lote.Clear();
                //dsPresupuesto1.estados.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTarima1.mp_bodega_lote);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void repositoryItemLogKardex_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var GridView = (GridView)grdMPBodega.FocusedView;
            var row = (dsTarima.mp_bodega_loteRow)GridView.GetFocusedDataRow();

            frmLogKardex frm = new frmLogKardex(row.id_mp, row.lote, row.id_bodega);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadLotesBG();
            }
        }

        private void repositoryItemAjuste_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var GridView = (GridView)grdMPBodega.FocusedView;
            var row = (dsTarima.mp_bodega_loteRow)GridView.GetFocusedDataRow();

            if (row.existencia > 0)
            {
                CajaDialogo.Error("Esta funcion esta solo activa para ajustar valores menores que 0");
                return;
            }
            else
            {
                if(row.TipoId == 1)//Externo
                {
                    CajaDialogo.Error("Esta funcion no puede ajustar negativos de inventarios de Bodegas Externas!");
                    return;
                }
                else
                {
                    decimal Existencia_Positiva = 0;
                    decimal Unidades_Positiva = 0;
                    Existencia_Positiva = Math.Abs(row.existencia);
                    Unidades_Positiva = Math.Abs(row.existencia_ud);

                    DialogResult r = CajaDialogo.Pregunta("Se va ajustar el Lote: " + row.lote + " Desea continuar? Cantidad a Ajustar: " + Existencia_Positiva);
                    if (r != System.Windows.Forms.DialogResult.Yes)
                        return;

                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                        con.Open();

                        SqlCommand cmd = new SqlCommand("sp_insert_kardex_ajuste", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@entrada", Existencia_Positiva);
                        //cmd.Parameters.AddWithValue("@id_referencia_operacion", );
                        //cmd.Parameters.AddWithValue("@id_lote_alosy",  );
                        cmd.Parameters.AddWithValue("@lote", row.lote);
                        cmd.Parameters.AddWithValue("@id_mp", row.id_mp);
                        cmd.Parameters.AddWithValue("@itemcode", row.code_sap);
                        cmd.Parameters.AddWithValue("@id_bodega", row.id_bodega);
                        cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@ud_entrada", Unidades_Positiva);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        LoadBodegaMP(row.id_mp);
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                }
                
            }

        }

        private void cmdActualizarResumenPorLote_Click(object sender, EventArgs e)
        {
            load_dataPorLotes();
        }

        private void btnRefreshRptMP_Click(object sender, EventArgs e)
        {
            load_data_totales();
        }

        private void btnRptPRD_Click(object sender, EventArgs e)
        {
            load_dataPRD();
        }

        private void btnRptMPyBod_Click(object sender, EventArgs e)
        {
            load_dataResumenMP_por_bodega();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //if (MateriaPrimaAllBodegas != null)
            //{
            //    if (MateriaPrimaAllBodegas.Recuperado)
            //    {
            //        LoadBodegaMP(MateriaPrimaAllBodegas.IdMP_ACS);
            //        txtTitulo_Inv_Por_MPyBodega.Text = MateriaPrimaAllBodegas.CodeMP_SAP + " " + MateriaPrimaAllBodegas.NameComercial;// frm.ItemSeleccionado.ItemName;
            //    }
            //}
            if (tggMostrarTotasInv_por_mp_y_bodega.IsOn)//Mostrar Todos
            {
                btnSearchMP.Enabled = txtTitulo_Inv_Por_MPyBodega.Enabled = false;
                LoadLotesBG();
            }
            else//Mostrar solo MP Seleccionada
            {
                btnSearchMP.Enabled = txtTitulo_Inv_Por_MPyBodega.Enabled = true;
                if (IdMateriaPrimaTab_MP_por_Bodega > 0)
                    LoadBodegaMP(IdMateriaPrimaTab_MP_por_Bodega);
            }
        }

        private void tggMostrarTotasInv_por_mp_y_bodega_Toggled(object sender, EventArgs e)
        {
            if (tggMostrarTotasInv_por_mp_y_bodega.IsOn)//Mostrar Todos
            {
                btnSearchMP.Enabled = txtTitulo_Inv_Por_MPyBodega.Enabled = false;
                LoadLotesBG();
            }
            else//Mostrar solo MP Seleccionada
            {
                btnSearchMP.Enabled = txtTitulo_Inv_Por_MPyBodega.Enabled = true;
            }
        }

        private void btnActReproceso_Click(object sender, EventArgs e)
        {
            Load_dataReprocesoPorLote();
        }

        private void btnTrasladoKardex_Click(object sender, EventArgs e)
        {
            //Aqui ira un Permiso

            frmTrasladoKardexMP frm = new frmTrasladoKardexMP(UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_dataPorLotes();
            }
            
        }

        private void cmdVerBorradorDeAjustes_Click(object sender, EventArgs e)
        {
            frmVerAjustesBorradorAproved frm = new frmVerAjustesBorradorAproved(UsuarioLogeado);
            frm.Show();
        }

        private void cmAjusteReproceso_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridReproceso.FocusedView;
            var row = (dsTarima.kardex_by_ReprocesoRow)gridView.GetFocusedDataRow();

            frmAsjuteInventarioPorLote frm = new frmAsjuteInventarioPorLote(UsuarioLogeado, row.id_mp, 0, row.lote, row.id_bodega, frmAsjuteInventarioPorLote.Comportamiento.Reproceso);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Load_dataReprocesoPorLote();
            }
        }
    }
}