using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
using ACS.Classes;

using System.Data.SqlClient;
using System.Data.Linq;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using LOSA.Clases;

namespace LOSA.MigracionACS.Produccion.Reports
{
    public partial class Rep_Fml_Uso : DevExpress.XtraEditors.XtraForm
    {
        #region Variables Globales
        // string ActiveUserCode;
        DataOperations dp = new DataOperations();
        DataTable dtDatos;
        
        FMOP fmop = new FMOP();
        #endregion

        public Rep_Fml_Uso()
        {
            InitializeComponent();

            #region Screen Selection
            if (Screen.AllScreens.Count() > 1)
            {
                switch (Screen.AllScreens.Count())
                {
                    case 2:
                        this.Location = Screen.AllScreens[1].WorkingArea.Location;
                        break;
                    case 3:
                        this.Location = Screen.AllScreens[2].WorkingArea.Location;
                        break;
                    case 4:
                        this.Location = Screen.AllScreens[3].WorkingArea.Location;
                        break;
                    case 5:
                        this.Location = Screen.AllScreens[5].WorkingArea.Location;
                        break;
                    case 6://Configuración Actual Consola
                        this.Location = Screen.AllScreens[4].WorkingArea.Location;
                        break;
                }
            }
            #endregion
        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btn_GenReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(pnl_fechas.Visible)
                if (Convert.ToDateTime(dt_hasta.EditValue) < Convert.ToDateTime(dt_desde.EditValue)) {
                    MessageBox.Show("Rango de fecha no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            if (pnl_Textbox.Visible) {
                if (txt_Textbox.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar el número de orden a busar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Textbox.Focus();
                    return;
                }
            }

            cargar_grid();
        }


        void cargar_grid(){
            try
            {
                String sp = "";
                if (pnl_fechas.Visible)
                {
                    #region Reporte por Fecha
                    if (dt_desde.EditValue == null || dt_hasta.EditValue == null) return;
                    #region Parametros_SP_Entrada
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@fecha_desde", SqlDbType.DateTime));
                    cmd.Parameters.Add(new SqlParameter("@fecha_hasta", SqlDbType.DateTime));
                    cmd.Parameters["@fecha_desde"].Value = string.Format("{0:dd/MM/yyyy HH:mm}", dt_desde.EditValue);// Convert.ToDateTime(dt_desde.EditValue);
                    cmd.Parameters["@fecha_hasta"].Value = string.Format("{0:dd/MM/yyyy HH:mm}", dt_hasta.EditValue); //Convert.ToDateTime(dt_hasta.EditValue);
                    #endregion

                    if (grp_tipoReporte.SelectedIndex == 0)
                    {
                        //dtDatos = dp.APMS_Exec_SP_Get_Data("Intake_Get_SumaryRM_by_date", cmd);
                        dtDatos = dp.APMS_Exec_SP_Get_Data("Intake_Get_SumaryRM_by_date_v2", cmd);
                        //try
                        //{
                        //    SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                        //    conn.Open();

                        //    string sql = @"EXEC	[dbo].[Intake_Get_SumaryRM_by_date]
                        //                  @fecha_desde = N'" + string.Format("{0:MM/dd/yyyy HH:mm:ss}", dt_desde.EditValue) + "'," +
                        //                      " @fecha_hasta = N'" + string.Format("{0:MM/dd/yyyy HH:mm:ss}", dt_hasta.EditValue) + "'";
                        //    SqlCommand cmdx = new SqlCommand(sql, conn);
                        //    SqlDataAdapter adat = new SqlDataAdapter(cmdx);
                        //    dtDatos = new DataTable();
                        //    adat.Fill(dtDatos);
                        //}
                        //catch (Exception ec)
                        //{
                        //    CajaDialogo.Error(ec.Message);
                        //}
                    }
                    else
                    {
                        dtDatos = dp.APMS_Exec_SP_Get_Data("Intake_Get_SumaryRM_NC_by_date", cmd);
                    }
                    #endregion
                }
                else
                {
                    #region Reporte por Fecha
                    #region Parametros_SP_Entrada
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@order", SqlDbType.Char));
                    cmd.Parameters["@order"].Value = "PP-"+ txt_Textbox.Text.PadLeft(7,'0') ;
                    #endregion
                    if (grp_tipoReporte.SelectedIndex == 0)
                        dtDatos = dp.APMS_Exec_SP_Get_Data("Intake_Get_SumaryRM_by_order", cmd);
                    else
                        dtDatos = dp.APMS_Exec_SP_Get_Data("Intake_Get_SumaryRM_NC_by_order", cmd);
                    #endregion                
                }
                grd_data.DataSource = dtDatos;
            }
            catch (Exception ec) { CajaDialogo.Error(ec.Message); }       
        }

        private void btn_bajarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //grd_data.ExportToXlsx(dialog.FileName);
                Impresion().ExportToXlsx(dialog.FileName);
            }

        }


        private void btn_bajarPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF File (.pdf)|*.pdf";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //grdv_data.ExportToPdf(dialog.FileName);
                Impresion().ExportToPdf(dialog.FileName);
            }
        }
        
        //ALGO
        private void btn_Imprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //grdv_data.PrintDialog();
            Impresion().PrintDlg();
        }

        private void btn_ImprimirPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //grdv_data.ShowPrintPreview();
            Impresion().ShowPreviewDialog();
        }

        private void grdv_data_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            #region AutorRow_Color_Diferente
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                e.Appearance.BackColor = Color.FromArgb(200, 255, 255, 204);
            }
            #endregion
        }




        // Metodos para Impresión Personalizada (Encabezados) desde Grid: ----------------------------------
        CompositeLink Impresion()
        {
            #region Impresion Personalizada (Headers & Footers)
            // Colocando titulos a reportes:------------- -----------------------------------------
            CompositeLink compLink = new CompositeLink(new PrintingSystem());
            compLink = new CompositeLink(new PrintingSystem());
            PrintableComponentLink gridLink = new PrintableComponentLink();
            gridLink.Component = grd_data; // gridControl1;

            // Creando contenedor Header ...
            Link headerLink = new Link();    // Header - Linea 1
            headerLink.CreateDetailArea += new CreateAreaEventHandler(headerLink_CreateDetailArea);
            Link headerLink2 = new Link();   // Header - Linea 2
            headerLink2.CreateDetailArea += new CreateAreaEventHandler(headerLink_CreateDetailArea2);

            // Creando contenedor Footer ...          
            Link footerLink = new Link();
            footerLink.CreateDetailArea += new CreateAreaEventHandler(footerLink_CreateDetailArea);

            compLink.Links.Add(headerLink);
            compLink.Links.Add(headerLink2);
            compLink.Links.Add(gridLink);
            //compLink.Links.Add(footerLink);   // Aun sin terminar

            //compLink.ShowPreviewDialog();
            // ----------------------------------------- -----------------------------------------        
            #endregion
            return compLink;
        }

        void footerLink_CreateDetailArea(object sender, CreateAreaEventArgs e)  // Footer
        {
            #region Pie de pagina (aun sin terminar)
            //Ejemplo A: Usando "TextBrick" (otra forma)
            string reportFooter = String.Format(@"{0} / {1}", PageInfo.Number, PageInfo.NumberOfTotal);

            DevExpress.XtraPrinting.TextBrick brick = new TextBrick(BorderSide.None, 0, Color.Black, Color.White, Color.Blue);
            brick.Text = reportFooter ;
            brick.Rect = new RectangleF(0, 0, 400, 20);
            e.Graph.DrawBrick(brick);
            #endregion
        }
        void headerLink_CreateDetailArea(object sender, CreateAreaEventArgs e)      // Header - Linea 1
        {
            #region Encabezado Linea-1
            //Ejemplo B: Usando solo 
            //e.Graph.DrawString("Some header text", new RectangleF(0, 0, 400, 20));

            //Ejemplo 3: Usando "BrickStringFormat"  -- ok!!
            /*string reportHeader = String.Format(@"Reporte de Consumos");
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 14, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None); */

            //Ejemplo: 4 Usando "TextBrick" -- ok!!!
            TextBrick brick1     = e.Graph.DrawString("Reporte de Consumos", Color.Black, new RectangleF(0, 0, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick1.HorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            brick1.Font          = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
            #endregion
        }

        void headerLink_CreateDetailArea2(object sender, CreateAreaEventArgs e)     // Header - Linea 2
        {
            #region Encabezado Linea-2
            string reportHeader  = String.Format(@"Datos Desde: [{0}]  Hasta:[{1}]",dt_desde.EditValue, dt_hasta.EditValue);

            TextBrick brick2     = e.Graph.DrawString(reportHeader, Color.Black, new RectangleF(0, 0, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
            brick2.HorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            brick2.Font          = new Font(FontFamily.GenericSansSerif, 08, FontStyle.Regular);
            #endregion
        }

        private void chk_porfecha_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (chk_porfecha.Checked){
                chk_porfecha.Caption = "Por Fecha";
                pnl_fechas.Visible = true; dt_desde.Focus();
                pnl_Textbox.Visible = false;
                pnl_opciones.Dock = DockStyle.Fill;
            }
            else {
                chk_porfecha.Caption = "Por Número Orden";
                pnl_fechas.Visible = false; 
                pnl_Textbox.Visible = true; txt_Textbox.Focus();
                pnl_Textbox.Dock = DockStyle.Left;
                pnl_opciones.Dock = DockStyle.Fill;
            }
        }

        private void Rep_Fml_Uso_Load(object sender, EventArgs e)
        {
            pnl_opciones.Dock = DockStyle.Fill;
        }
        // ------------------------------------------------------------------------------------------------


    }
}