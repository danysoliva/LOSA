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
using DevExpress.XtraGrid.Views.Grid;
using LOSA.MigracionACS.DataSetx;
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.MigracionACS.Produccion.Eficiencia
{
    public partial class frmPresentacionLotes : DevExpress.XtraEditors.XtraForm
    {
        public int IdPresentacionSeleccionada;
        public decimal Valor;
        public frmPresentacionLotes()
        {
            InitializeComponent();
            LoadPresentacionLotes();
        }

        private void LoadPresentacionLotes()
        {
            try
            {
                string query = @"sp_get_presentaciones_from_lote_prb_reporte";
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                prBdata1.presentacion_lote.Clear();
                da.Fill(prBdata1.presentacion_lote);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar los datos, contacte con el administrador", "Error");

            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //Doble click en el row
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (PRBdata.presentacion_loteRow)gridView.GetFocusedDataRow();

            IdPresentacionSeleccionada = row.id;
            Valor = row.valor;

            this.DialogResult = DialogResult.OK;

        }
    }
}