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

namespace LOSA.TransaccionesMP
{
    public partial class frmReporteInventarioKardexGeneral : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmReporteInventarioKardexGeneral()
        {
            InitializeComponent();
            load_data();
            load_data_totales();
        }
        public void load_data()
        {
            string query = @"sp_obtener_inventario_general_por_lote";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTarima.informacion.Clear();
                da.Fill(dsTarima.informacion);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_data_totales()
        {
            string query = @"sp_obtener_inventario_general";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTarima.totales.Clear();
                da.Fill(dsTarima.totales);
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(tabPane1.SelectedPageIndex == 0)
            {
                if (dsTarima.informacion.Rows.Count > 0)
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                    dialog.FilterIndex = 0;

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        grd_data.ExportToXlsx(dialog.FileName);
                }
                else
                {
                    CajaDialogo.Error("No hay datos para exportar!");
                }
            }
            else
            {
                if (dsTarima.totales.Rows.Count > 0)
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                    dialog.FilterIndex = 0;

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        grd_data_resumen.ExportToXlsx(dialog.FileName);
                }
                else
                {
                    CajaDialogo.Error("No hay datos para exportar!");
                }
            }
        }
    }
}