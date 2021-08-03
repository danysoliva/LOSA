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

namespace LOSA.Trazabilidad
{
    public partial class frmMantoProveedoresMP : DevExpress.XtraEditors.XtraForm
    {
        public frmMantoProveedoresMP()
        {
            InitializeComponent();
        }

        private void cmdBuscarProveedores_Click(object sender, EventArgs e)
        {
            frmBuscarProvMP frm = new frmBuscarProvMP();
            if(frm.ShowDialog()== DialogResult.OK)
            {
                txtCodigo.Text = frm.ProveedorRow.Codigo;
                txtNombre.Text = frm.ProveedorRow.Nombre;
                txtNombreF.Text = frm.ProveedorRow.NombreF;
                txtRTN.Text = frm.ProveedorRow.RTN;
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}