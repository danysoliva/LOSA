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

namespace LOSA.TransaccionesMP
{
    public partial class frmSeleccionTarimaMP : DevExpress.XtraEditors.XtraForm
    {
        public frmSeleccionTarimaMP()
        {
            InitializeComponent();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}