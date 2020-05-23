using ACS.Classes;
using Core.Clases.Herramientas;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RecepcionMP
{
    public partial class frm_ingresos : DevExpress.XtraEditors.XtraForm
    {

        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        public frm_ingresos(UserLogin User)
        {
            InitializeComponent();
            UsuarioLogeado = User;
            Load_Info();
        }
        public void Load_Info()
        {
            string query = @"EXEC dbo.ps_load_ingresos_from_tarimas";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsRecepcionMPx.IngresosMP.Clear();
                da.Fill(dsRecepcionMPx.IngresosMP);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error("Error al cargar la informacion: " + ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmTarima frm = new frmTarima(UsuarioLogeado);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_ingreso.FocusedView;
                var row = (dsRecepcionMPx.IngresosMPRow)gridview.GetFocusedDataRow();

                frm_ingresos_lotes frmDetalle = new frm_ingresos_lotes(1, row.Ningreso, UsuarioLogeado);
                if (frmDetalle.ShowDialog() == DialogResult.OK)
                {
                    Load_Info();
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}