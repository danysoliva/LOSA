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
using LOSA.AlmacenesExterno.Reporteria;
using DevExpress.XtraReports.UI;

namespace LOSA.AlmacenesExterno
{
    public partial class xfrmAlmacenesExternos_Main : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;

        public xfrmAlmacenesExternos_Main(UserLogin pUser)
        {
            InitializeComponent();
            LoadIngresosExternos();
            UsuarioLogueado = pUser;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            xfrmRevisarOC frm = new xfrmRevisarOC(UsuarioLogueado);

            if (frm.ShowDialog()== DialogResult.OK)
            {
                LoadIngresosExternos();
            }
        }


        private void LoadIngresosExternos()
        {
            DataOperations dp = new DataOperations();

            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
            {
                cnx.Open();

                dsAlmacenesExternos.ingreso_externo_h.Clear();

                SqlDataAdapter da = new SqlDataAdapter("sp_get_ingresos_almacenes_externos", cnx);
                da.Fill(dsAlmacenesExternos.ingreso_externo_h);
                cnx.Close();

            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnver_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gv = (GridView)grd_ingreso.FocusedView;
            var row = (dsAlmacenesExternos.ingreso_externo_hRow)gv.GetDataRow(gv.FocusedRowHandle);

            xfrmDetalleIngresoAlmacenExterno frm = new xfrmDetalleIngresoAlmacenExterno(row.id);

            frm.Show();
        }

        private void btnprint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gv = (GridView)grd_ingreso.FocusedView;
            var row = (dsAlmacenesExternos.ingreso_externo_hRow)gv.GetDataRow(gv.FocusedRowHandle);

             xrptAlmacenesExternos report = new xrptAlmacenesExternos(row.id);

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Send the report to the default printer.
                printTool.ShowPreviewDialog();
            }
        }
    }
}