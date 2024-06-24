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
using ACS.Classes;

namespace ACS.MP
{
    public partial class MP_MnY : DevExpress.XtraEditors.XtraForm
    {

        #region Developer Defined Functions

        //For Desingn to be inherited
        protected override bool GetAllowSkin()
        {
            if (this.DesignMode) return false;
            return true;
        }

        #endregion

        public MP_MnY()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();

        }
    }
}