using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MigracionACS.RRHH.Vacaciones
{
    public partial class frmVacacionesHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmVacacionesHome()
        {
            InitializeComponent();
            LoadDatos();
        }

        public frmVacacionesHome(UserLogin pUsuario)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuario;
            LoadDatos();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_vacaciones_web_rrhh", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsReportesVacaciones1.resumen_vacaciones.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesVacaciones1.resumen_vacaciones);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdVerDetalles_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Ver detalle
            var row = (dsReportesVacaciones.resumen_vacacionesRow)gridView1.GetFocusedDataRow();
            frmVacacionesDetalles frm = new frmVacacionesDetalles(row.id, row.name, row.dias_pendientes_stand.ToString());
            frm.ShowDialog();
        }
    }
}