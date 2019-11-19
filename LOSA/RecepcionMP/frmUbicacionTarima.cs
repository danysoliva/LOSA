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
    public partial class frmUbicacionTarima : Form
    {
        DataOperations dp = new DataOperations();

        private int _idbicacion;
        private string _rack, _altura, _profundidad,_pasillo;
        public int idUbicacion { get { return _idbicacion; } set { _idbicacion = value; } }

        public string altura { get { return _altura; } set { _altura = value; } }

        public string profundidad { get { return _profundidad; } set { _profundidad = value; } }

        public string rack { get { return _rack; } set { _rack = value; } }

        public string pasillo { get { return _pasillo; } set { _pasillo = value; } }
        public frmUbicacionTarima()
        {
            InitializeComponent();
            cargarDatos();
        }


        void cargarDatos()
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);

                string SQL = @"exec obtenerUbicacionTarima @codigo_barra";

                dsRecepcionMPx.Ubicaciones.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);

                adat.SelectCommand.Parameters.AddWithValue("@codigo_barra", "");

          
                adat.Fill(dsRecepcionMPx.Ubicaciones);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void GvUbicacion_DoubleClick(object sender, EventArgs e)
        {
            //Seleccion del lote
            //bib
            var gridView = (GridView)gcUbicacion.FocusedView;
            var row = (dsRecepcionMPx.UbicacionesRow)gridView.GetFocusedDataRow();

            this.idUbicacion = row.id;
            this.altura = row.altura;
            this.profundidad = row.profundidad;
            this.rack = row.rack;
            this.pasillo = row.pasillo;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            //Seleccion del lote
            //bib
            var gridView = (GridView)gcUbicacion.FocusedView;
            var row = (dsRecepcionMPx.UbicacionesRow)gridView.GetFocusedDataRow();

            this.idUbicacion = row.id;
            this.altura = row.altura;
            this.profundidad = row.profundidad;
            this.rack = row.rack;
            this.pasillo = row.pasillo;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
