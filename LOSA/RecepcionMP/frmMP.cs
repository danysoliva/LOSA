using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
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

namespace LOSA.RecepcionMP
{
    public partial class frmMP : Form
    {
        public string idProveedor,MateriaPrima,NombreProveedor,ItemCode;
        public frmMP()
        {
            InitializeComponent();
            cargarDatos();
        }
        DataOperations dp = new DataOperations();
        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void cargarDatos()
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL = @"exec sp_get_MP";

                dsRecepcionMPx.Materia_Prima.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);

                adat.Fill(dsRecepcionMPx.Materia_Prima);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void GvMP_DoubleClick(object sender, EventArgs e)
        {
            //Seleccion del lote
            //bib
            var gridView = (GridView)gcMP.FocusedView;
            var row = (dsRecepcionMPx.Materia_PrimaRow)gridView.GetFocusedDataRow();

            this.idProveedor = row.carcode;
            this.NombreProveedor = row.cardname;
            this.MateriaPrima = row.itemdescrip;
            this.ItemCode = row.itemcode;
            //this.lote = row.lote_materia_prima;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
