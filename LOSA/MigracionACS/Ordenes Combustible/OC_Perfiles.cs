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

namespace LOSA.MigracionACS.Ordenes_Combustible
{
    public partial class OC_Perfiles : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        int estado = 0;

        public OC_Perfiles(UserLogin pUserC)
        {
            InitializeComponent();
            LoadPerfiles();
            UsuarioLogeado = pUserC;
        }

        void LoadPerfiles()
        {
            //Perfiles Activos
            if (TSPerfiles.IsOn == true)
            {
                estado = 1;
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("FuelOrderToggledPerfil", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@estado", estado);
                    dsOrdenesCombustible1.grPerfiles.Clear();
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    adat.Fill(dsOrdenesCombustible1.grPerfiles);

                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            else
            {
                try
                {
                    estado = 0;
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("FuelOrderToggledPerfil", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@estado", estado);
                    dsOrdenesCombustible1.grPerfiles.Clear();
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    adat.Fill(dsOrdenesCombustible1.grPerfiles);

                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            
        }

        private void TSPerfiles_Toggled(object sender, EventArgs e)
        {
            if (TSPerfiles.IsOn == true)
            {
                LoadPerfiles();
            }
            else
            {
                LoadPerfiles();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void repositoryButtonEditPerfiles_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView1 = (GridView)grPerfiles.FocusedView;
            var row = (dsOrdenesCombustible.grPerfilesRow)gridView1.GetFocusedDataRow();
            OC_NewEditPerfiles ordenes = new OC_NewEditPerfiles(row.id);
            if (ordenes.ShowDialog() == DialogResult.OK)
            {
                LoadPerfiles();
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            OC_NewEditPerfiles frm = new OC_NewEditPerfiles();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadPerfiles();
            }
        }

        private void repositoryItemOrdenManual_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView1 = (GridView)grPerfiles.FocusedView;
            var row = (dsOrdenesCombustible.grPerfilesRow)gridView1.GetFocusedDataRow();
            OC_OrdenManual frm = new OC_OrdenManual(UsuarioLogeado,row.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void cmdExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                grPerfiles.ExportToXlsx(dialog.FileName);
        }
    }
}