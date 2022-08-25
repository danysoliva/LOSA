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
using DevExpress.XtraReports.UI;

namespace LOSA.Produccion
{
    public partial class frmRequisasManuales : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmRequisasManuales(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            load_data();
        }

        DataOperations dp = new DataOperations();

        public void load_data() 
        {
            string query = @"sp_obtener_requisas_to_get_rm_manualv2";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsProduccion.requisas_toadd.Clear();
                da.Fill(dsProduccion.requisas_toadd);
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

        private void btn_reqmanual_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)grd_data.FocusedView;
                var row = (dsProduccion.requisas_toaddRow)gridView.GetFocusedDataRow();

                frm_requisaManual frm = new frm_requisaManual(row.id, UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            //Indica el numero de copias de la boleta que seran impresas
            e.PrintDocument.PrinterSettings.Copies = 1;
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)grd_data.FocusedView;
                var row = (dsProduccion.requisas_toaddRow)gridView.GetFocusedDataRow();

                string query = @"sp_load_requisa_manual";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_req", row.id);
                int Id_RequsaManual = Convert.ToInt32(cmd.ExecuteScalar());
                
                if (Id_RequsaManual > 0)
                {
                    Requisiciones.Reportes.lblNumeroReq report = new Requisiciones.Reportes.lblNumeroReq(Id_RequsaManual, row.Lote);
                    report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    report.ShowPrintMarginsWarning = false;
                    report.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                    report.Print();
                }
                else
                {
                    CajaDialogo.Error("Esta requisa aun no tiene lineas de detalle!");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnImprimirprevisualizacion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)grd_data.FocusedView;
                var row = (dsProduccion.requisas_toaddRow)gridView.GetFocusedDataRow();

                string query = @"sp_load_requisa_manual";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_req", row.id);
                int Id_RequsaManual = Convert.ToInt32(cmd.ExecuteScalar());

                if (Id_RequsaManual > 0)
                {
                    Requisiciones.Reportes.lblNumeroReq report = new Requisiciones.Reportes.lblNumeroReq(Id_RequsaManual, row.Lote);
                    report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    report.ShowPrintMarginsWarning = false;
                    report.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                    report.ShowPreviewDialog();
                }
                else
                {
                    CajaDialogo.Error("Esta requisa aun no tiene lineas de detalle!");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}