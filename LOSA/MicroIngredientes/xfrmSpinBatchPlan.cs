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

namespace LOSA.MicroIngredientes
{
    public partial class xfrmSpinBatchPlan : DevExpress.XtraEditors.XtraForm
    {
        public int cantBatch = 0;
        public xfrmSpinBatchPlan()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            cantBatch =Convert.ToInt32( seBatch.EditValue);
            this.DialogResult = DialogResult.OK;
        }
    }
}