using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Calidad
{
    public partial class frmNoConfirmidadMP : DevExpress.XtraEditors.XtraForm
    {
        private int id_lote;
        NoConformidad Document;
        

        public frmNoConfirmidadMP(int Pid_lote)
        {
            InitializeComponent();
            Id_lote = Pid_lote;
            Document = new NoConformidad(Id_lote);
            Inizalidar();
        }

        public void Inizalidar()
        {
            dt_fecha.DateTime = Document.Fecha_documento;
            txtAcciones.Text = Document.acciones;
            txtCorrelativo.Text = Document.No_correlativo.ToString();
            txtDescripcion.Text = Document.Motivo;
            txtkg.Text = Document.Cantidad_kg.ToString();
            txtsacos.Text = Document.Cantidad_sacos.ToString();
            txtplaca.Text = Document.Placa;
            txtoc.Text = Document.Oc.ToString();
            txttrasportista.Text = Document.Trasportistas;
            txtTransporte.Text = Document.Trasporte;
            txt_proveedor.Text = Document.Proveedor;
            txt_mp.Text = Document.MaterialMp;
            txtingreso.Text = Document.Numero_referencia.ToString();

        }
        public int Id_lote { get => id_lote; set => id_lote = value; }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDescripcion_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Escribe el motivo...")
            {
                txtDescripcion.SelectAll();
            }
        }

        private void txtAcciones_Click(object sender, EventArgs e)
        {
            if (txtAcciones.Text == "Escribe la accion correctiva...")
            {
                txtAcciones.SelectAll();
            }
        }
    }
}