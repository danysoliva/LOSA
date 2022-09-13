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
using LOSA.Clases;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Despachos;
using DevExpress.XtraReports.UI;
using LOSA.Reportes;

namespace LOSA.TransaccionesPT
{
    public partial class frmdespacho : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frmdespacho(UserLogin Puser)
        {
            InitializeComponent();
            switch (Puser.Idnivel)
            {
                case 1://Basic View
                    cmdAddOrdeCargaManual.Visible = false;
                    break;
                case 2://Basic No Autorization
                    cmdAddOrdeCargaManual.Visible = false;
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
            UsuarioLogeado = Puser;
            load_desicion();
        }

        public void load_despachos_terminados() 
        {
            string Query = @"sp_load_informacion_despachos_only_open";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(Query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            dsPT.Load_despachos.Clear();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsPT.Load_despachos);
            cn.Close();
        }
        public void load_despachos()
        {
            string Query = @"sp_load_informacion_despachos_v2";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(Query,cn);
            cmd.CommandType = CommandType.StoredProcedure;
            dsPT.Load_despachos.Clear();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsPT.Load_despachos);
            cn.Close();
        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea marcar como finalizada este despacho? No podra seguir recibiendo tarimas.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    var gridView = (GridView)grd_data.FocusedView;
                    var row = (dsPT.Load_despachosRow)gridView.GetFocusedDataRow();
                    string query = @"sp_finalizar_despacho";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query,cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", row.id);
                    cmd.ExecuteNonQuery();
                    CajaDialogo.Error("Se finalizo correctamente este despacho.");
                    cn.Close();
                    load_desicion();

                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsPT.Load_despachosRow)gridView.GetFocusedDataRow();

            if (row.bit_abierto == false)
            {
                CajaDialogo.Error("No puede eliminar una Despacho Cerrado! Contacte a su Administrador!");
                return;
            }

            if (MessageBox.Show("Desea eliminar este despacho? No podra hacer ninguna otra transaccion de el y las tarimas recibidas volveran al inventario.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                   
                    string query = @"sp_eliminar_despacho";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", row.id);
                    cmd.ExecuteNonQuery();
                    CajaDialogo.Error("Se elimino correctamente este despacho.");
                    cn.Close();
                    load_desicion();

                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsPT.Load_despachosRow)gridView.GetFocusedDataRow();
                frm_generar_despacho frm = new frm_generar_despacho(row.id, this.UsuarioLogeado);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    load_desicion();
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsPT.Load_despachosRow)gridView.GetFocusedDataRow();
            frm_view_entrega_despacho frm = new frm_view_entrega_despacho(row.id, this.UsuarioLogeado);
            frm.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Desea imprimir el reporte de detalle de carga?", "Pregunta" , MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            //{
                try
                {
                    var gridView = (GridView)grd_data.FocusedView;
                    var row = (dsPT.Load_despachosRow)gridView.GetFocusedDataRow();
                    rpt_despacho frm = new rpt_despacho(row.id);
                    frm.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    ReportPrintTool printReport = new ReportPrintTool(frm);
                    printReport.ShowPreview();
                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }
            //}
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            frm_nueva_orden frm = new frm_nueva_orden(UsuarioLogeado);
            frm.Show();
        }

        private void btn_ligar_oc_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsPT.Load_despachosRow)gridView.GetFocusedDataRow();

                frm_Unir frm = new frm_Unir(row.id);
                frm.Show();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_desicion()
        {
            if (tggOpen.IsOn)
            {
                load_despachos();
            }
            else
            {
                load_despachos_terminados();
            }

        }
        private void tggOpen_Toggled(object sender, EventArgs e)
        {
            load_desicion();
        }

        private void grdv_data_RowStyle(object sender, RowStyleEventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsPT.Load_despachosRow)gridView.GetDataRow(e.RowHandle);
            if (e.RowHandle >= 0)
            {

                if (row.bit_abierto)
                {
                    e.Appearance.BackColor = Color.FromArgb(172, 172, 172);

                }
                else
                {
                    e.Appearance.BackColor = Color.FromArgb(77, 201, 176);
                }
            }
        }

        private void cmdImprimirPlanDespachoPreliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsPT.Load_despachosRow)gridView.GetFocusedDataRow();
            Despachos.Reportes.frm_plan cp = new Despachos.Reportes.frm_plan(row.NumID, this.UsuarioLogeado);

            cp.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(cp);
            printReport.ShowPreview();
        }
    }
}