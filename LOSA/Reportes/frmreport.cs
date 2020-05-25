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
using LOSA.Logistica;
using LOSA.Produccion;

namespace LOSA.Reportes
{
    public partial class frmreport : DevExpress.XtraEditors.XtraForm
    {
        public frmreport()
        {
            InitializeComponent();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void cmdHome_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void cmdRegistroLote_Click(object sender, EventArgs e)
        {
            frmtarimasporbodega frm = new frmtarimasporbodega();
            frm.Show();
        }

        private void btnLotesXMP_Click(object sender, EventArgs e)
        {
            frmLotesXMP frm = new frmLotesXMP();
            frm.Show();
        }

        private void btnCantidadMP_Click(object sender, EventArgs e)
        {
            frmCantidadMP frm = new frmCantidadMP();
            frm.Show();
        }

        private void btnLotes_Click(object sender, EventArgs e)
        {
            frmLotes frm = new frmLotes();
            frm.Show();
        }

        private void btnTrazabilidad_Click(object sender, EventArgs e)
        {
            frmTrazabilidadLote frm = new frmTrazabilidadLote();
            frm.Show();
        }

        private void btnLotesPorProveedor_Click(object sender, EventArgs e)
        {
            frmLotesXProveedor frm = new frmLotesXProveedor();
            frm.Show();
        }
    }
}