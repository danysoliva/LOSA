using LOSA.Calidad;
using LOSA.Clases;
using LOSA.Logistica;
using LOSA.Mantenimientos;
using LOSA.Produccion;
using LOSA.RecepcionMP;
using LOSA.TransaccionesMP;
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
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Calidad
{
    public partial class frmcalidadcausas : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmcalidadcausas()
        {
            InitializeComponent();
            load_data();

        }

        public void load_data()
        {
            string query = @"EXEC ps_get_causas_calidad";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                dsCalidad.causas.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCalidad.causas);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
          
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmaddcausa frm = new frmaddcausa();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_data.FocusedView;
                var row = (dsCalidad.causasRow)gridview.GetFocusedDataRow();
                frmaddcausa frm = new frmaddcausa(row.id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    load_data();
                }
            }
            catch (Exception)
            {

               
            }
        }
    }
}