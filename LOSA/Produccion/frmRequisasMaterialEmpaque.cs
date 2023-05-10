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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;
using LOSA.Produccion;

namespace LOSA.Produccion
{
    public partial class frmRequisasMaterialEmpaque : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmRequisasMaterialEmpaque(UserLogin puserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = puserLogin;
            cargarData();
        }

        private void cargarData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAMS);
                conn.Open();

                string sql = "[sp_req_me_load_header]";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@view_disables", tsVerTodas.IsOn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsMaterialEmpaque1.requisas_h.Clear();
                da.Fill(dsMaterialEmpaque1.requisas_h);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reposPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview1 = (GridView)grd_data.FocusedView;
            var row = (dsMaterialEmpaque.requisas_hRow)grdv_data.GetFocusedDataRow();

            //xrlblNumRequisa reportRequisa = new xrlblNumRequisa(row.id);
            //reportRequisa.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            //ReportPrintTool printOrden = new DevExpress.XtraReports.UI.ReportPrintTool(reportRequisa);
            //printOrden.ShowPreview();
        }
    }
}