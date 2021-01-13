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

namespace LOSA.Calidad
{
    public partial class frmcalidad : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmcalidad()
        {
            InitializeComponent();
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
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}