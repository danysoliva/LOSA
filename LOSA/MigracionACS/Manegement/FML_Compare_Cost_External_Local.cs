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

namespace LOSA.MigracionACS.Management
{
    public partial class FML_Compare_Cost_External_Local : DevExpress.XtraEditors.XtraForm
    {
        public FML_Compare_Cost_External_Local()
        {
            InitializeComponent();
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 0)
            {
                grp_status.Enabled = true;
                grp_dates.Enabled = false;
            }
            else 
            {
                grp_status.Enabled = false;
                grp_dates.Enabled = true;
            }
        }
    }
}