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
    public partial class frmTarimas : Form
    {
        DataOperations dp = new DataOperations();
        int OpcionVentana = 0;
        
        
        int _idTarima;
        public int idTarima { get { return _idTarima; } set { _idTarima=value; } }
        public string nombreTarima { get; set; }
        public string proveedor { get; set; }

        public string lote { get; set; }
        public string presentacion { get; set; }
        public frmTarimas(int pOpcionVentana)
        {
            InitializeComponent();           
            OpcionVentana = pOpcionVentana;
            cargarDatos();
        }

        void cargarDatos()
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL="";

                if (OpcionVentana == 1)//se abre de ventana desde ubicar tarima
                    SQL = @"exec sp_obtener_tarimas_sin_ubicacion @codigo_barra";
                else
                    if (OpcionVentana == 2)//Se abre de venatana desde reubicar tarima
                    SQL = @"exec sp_obtener_tarimas_con_ubicacion @codigo_barra";
                else
                     if (OpcionVentana == 3)//Se abre de ventana desde devoluciones
                    SQL = @"exec sp_getTarimas_without_filters @codigo_barra";

                dsRecepcionMP.DetalleTarima.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);

                adat.SelectCommand.Parameters.AddWithValue("@codigo_barra", "");

                adat.Fill(dsRecepcionMP.DetalleTarima);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }



        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GvTarimas_DoubleClick(object sender, EventArgs e)
        {
            //Seleccion del lote
            //bib
            var gridView = (GridView)gcTarima.FocusedView;
            var row = (dsRecepcionMPx.DetalleTarimaRow)gridView.GetFocusedDataRow();

            this.idTarima = row.id;
            this.nombreTarima = row.nombreTarima;
            this.proveedor = row.nombreProveedor;
            this.presentacion = row.presentacion;
            this.lote = row.lote_materia_prima;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

       
        private void BtnSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Seleccion del lote
            //bib
            var gridView = (GridView)gcTarima.FocusedView;
            var row = (dsRecepcionMPx.DetalleTarimaRow)gridView.GetFocusedDataRow();

            this.idTarima = row.id;
            this.nombreTarima = row.nombreTarima;
            this.proveedor = row.nombreProveedor;
            this.presentacion = row.presentacion;
            this.lote = row.lote_materia_prima;
            //this.NumBoleta = row.NBoleta;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

       
    }
}
