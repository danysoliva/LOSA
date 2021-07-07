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

namespace LOSA.TransaccionesPT
{
    public partial class frm_rpt_productoT : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frm_rpt_productoT()
        {
            InitializeComponent();
            dtFechaDesde.EditValue = DateTime.Now.AddDays(-1);
            dtFechaHasta.EditValue = DateTime.Now;

            load_data();
        }

        public void load_data()
        {
            if (dtFechaDesde.EditValue != null && dtFechaHasta.EditValue != null)
            {
                try
                {

                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();
                    SqlCommand cmm2 = new SqlCommand("sp_rpt_tarimas_activadas_pt", con);
                    cmm2.CommandType = CommandType.StoredProcedure;
                    cmm2.Parameters.AddWithValue("@dtdesde", dtFechaDesde.EditValue);
                    cmm2.Parameters.AddWithValue("@dthasta", dtFechaHasta.EditValue);

                    dsPT.rpt_ingresoPT.Clear();
                    SqlDataAdapter adat = new SqlDataAdapter(cmm2);
                    adat.Fill(dsPT.rpt_ingresoPT);
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }

        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtFechaDesde_EditValueChanged(object sender, EventArgs e)
        {
            load_data();
        }

        private void dtFechaHasta_EditValueChanged(object sender, EventArgs e)
        {
            load_data();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_data.ExportToXlsx(dialog.FileName);
            }
        }
    }
}