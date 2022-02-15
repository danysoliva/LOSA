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

namespace LOSA.Calidad
{
    public partial class frmSeguimientoDespachos : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmSeguimientoDespachos()
        {
            InitializeComponent();
            dtdesde.DateTime = DateTime.Now.AddDays(-1);
            dthasta.DateTime = DateTime.Now;
            get_data();
        }

        public void get_data()
        {
            int specie;
            specie = Convert.ToInt32(rdEspecie.EditValue);
            string query = @"sp_get_despachos_with_date_p_and_especie";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date_deste", dtdesde.DateTime);
                cmd.Parameters.AddWithValue("@date_hasta", dthasta.DateTime);
                cmd.Parameters.AddWithValue("@specie", specie);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCalidad.despachoView.Clear();
                da.Fill(dsCalidad.despachoView);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            get_data();
        }

        private void rdEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_data();
        }

        private void dthasta_EditValueChanged(object sender, EventArgs e)
        {
            get_data();
        }

        private void btnExcel_Click(object sender, EventArgs e)
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