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
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.RecepcionMP
{
    public partial class frmGestionIngresos : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin Usuariologeado;
        public frmGestionIngresos(UserLogin pUser)
        {
            InitializeComponent();
            Usuariologeado = pUser;
            Load_Info();
        }

        public void Load_Info()
        {
            string query = @"ps_load_ingresos_from_tarimas";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsRecepcionMPx1.IngresosMP.Clear();
                da.Fill(dsRecepcionMPx1.IngresosMP);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error al cargar la informacion: " + ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnver_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //ver detalle de tarimas
            var gridView = (GridView)grd_ingreso.FocusedView;
            var row = (dsRecepcionMPx.IngresosMPRow)gridView.GetFocusedDataRow();

            frmGestionIngresosTarimas frm = new frmGestionIngresosTarimas(row.Ningreso);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}