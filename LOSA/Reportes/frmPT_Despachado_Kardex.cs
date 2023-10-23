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
using LOSA.Clases;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.TransaccionesPT;

namespace LOSA.Reportes
{
    public partial class frmPT_Despachado_Kardex : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        int Especie;
        DataOperations dp = new DataOperations();

        public frmPT_Despachado_Kardex(UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLog;
            Especie = 2;

            get_inventario();

        }

        private void get_inventario()
        {
            try
            {
                string query = @"sp_get_inventario_pt_por_especie_y_tarima";
                dsReportesInventario1.inventario_tarimas.Clear();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesInventario1.inventario_tarimas);
                if (dsReportesInventario1.inventario_tarimas.Rows.Count == 0)
                {

                }
                else
                {
                    query = @"sp_get_despachos_por_lote_pt";
                    cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    adat = new SqlDataAdapter(cmd);
                    dsReportesInventario1.detalle_despacho_lote.Clear();
                    adat.Fill(dsReportesInventario1.detalle_despacho_lote);  
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 0) // Camaron
            {
                Especie = 2;
            }
            else
            {
                Especie = 1;
            }
            get_inventario();
        }
    }
}