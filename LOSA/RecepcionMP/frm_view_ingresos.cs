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
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.RecepcionMP
{
   
    public partial class frm_view_ingresos : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frm_view_ingresos(UserLogin userLogin)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
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
                    SqlCommand cmm2 = new SqlCommand("sp_load_reporte_ingreso_granel", con);
                    cmm2.CommandType = CommandType.StoredProcedure;
                    cmm2.Parameters.AddWithValue("@fdesde", dtFechaDesde.EditValue);
                    cmm2.Parameters.AddWithValue("@fhasta", dtFechaHasta.EditValue);

                    dsingresos.granel.Clear();
                    SqlDataAdapter adat = new SqlDataAdapter(cmm2);
                    adat.Fill(dsingresos.granel);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsingresos.granelRow)gridView.GetFocusedDataRow();

                frmCambioIngreso frm = new frmCambioIngreso(row.ingreso ,row.id);
                   if (frm.ShowDialog() == DialogResult.OK)
                    {
                        load_data();
                    }
            }
            catch (Exception ex)
            {

                
            }
        }
    }
}