using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LOSA.Mantenimientos
{
    public partial class frmubicacion_tarima : DevExpress.XtraEditors.XtraUserControl
    {
        public frmubicacion_tarima()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lOSA_ubicacion_tarimaTableAdapter.FillBy(this.dsMantenimiento.LOSA_ubicacion_tarima);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
