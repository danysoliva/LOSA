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
using LOSA.Clases;
using LOSA.RecepcionMP;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.RecepcionMP
{
    public partial class FrmBoleta : DevExpress.XtraEditors.XtraForm
    {

        DataOperations dp = new DataOperations();
        SqlConnection cnn1 = new SqlConnection();
        private int _idSerie;
        private int _NumBoleta;

        public int IdSerie { get => _idSerie; set => _idSerie = value; }
        public int NumBoleta { get => _NumBoleta; set => _NumBoleta = value; }

        public FrmBoleta()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

       void cargarDatos()
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);

                string SQL = @"exec sp_getBoletasBascula";

                dsRecepcionMP.Bascula.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);
                adat.Fill(dsRecepcionMP.Bascula);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvBascula_DoubleClick(object sender, EventArgs e)
        {
            //Seleccion del lote
            //bib
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMP.BasculaRow)gridView.GetFocusedDataRow();

            this.IdSerie = row.IDSerie;
            this.NumBoleta = row.NBoleta;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}