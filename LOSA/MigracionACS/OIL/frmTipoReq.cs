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

namespace LOSA.MigracionACS.OIL
{
    public partial class frmTipoReq : DevExpress.XtraEditors.XtraForm
    {
        public frmTipoReq()
        {
            InitializeComponent();
        }

        public int tipo = 0;//0 No definido
                            //1 Normal
                            //2 Mix
        private void cmdNormal_Click(object sender, EventArgs e)
        {
            tipo = 1;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void cmdMix_Click(object sender, EventArgs e)
        {
            tipo = 2;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}