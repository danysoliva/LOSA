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

namespace LOSA.MigracionACS.SAR
{
    public partial class SAR_DASHBOARD : Form
    {
        DataOperations dp = new DataOperations();
        public SAR_DASHBOARD()
        {
            InitializeComponent();

            dtfin.EditValue = dp.Now();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        public void load_informacion()
        {
            DateTime fechainicial;
            DateTime fechafinal;
            if (dtini.EditValue == null)
            {
                CajaDialogo.Error("Seleccione una fecha inicial.");
                dtini.Focus();
                return;
            }
            fechainicial = dtini.DateTime;
            if (dtfin.EditValue == null)
            {
                CajaDialogo.Error("Seleccione una fecha final.");
                dtfin.Focus();
                return;
            }
            fechafinal = dtfin.DateTime;
            if (fechainicial >= fechafinal)
            {
                CajaDialogo.Error("La fecha inicial no puede ser menor a la fecha final.");
                dtfin.Focus();
                return;
            }
            string query = @"sp_sar_load_consumo";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@dtini", SqlDbType.DateTime).Value = fechainicial;
                cmd.Parameters.Add("@dtfin", SqlDbType.DateTime).Value = fechafinal;
                dS_SAR.rubro_capitulo.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dS_SAR.rubro_capitulo);
                cn.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btngenerar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_informacion();
        }

        private void btnexportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdv_report.ExportToXlsx(dialog.FileName);
                //gridControl2.ExportToXlsx(dialog.FileName);
            }
        }

        private void btnactualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_informacion();
        }

        private void btnPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF File (.pdf)|*.pdf";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdv_report.ExportToPdf(dialog.FileName);
                //gridControl2.ExportToXlsx(dialog.FileName);
            }
        }
    }
}
