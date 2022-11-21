using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DevExpress.XtraEditors;

namespace LOSA.MigracionACS.Controles
{
    public partial class xCheckBox : UserControl
    {
        bool v = false;
        public bool Value
        {
            get { return v; }
            set { v = value;
                  if(v)
                      pColor.Visible = true;
                  else
                      pColor.Visible = false;
                }
        }
        public event EventHandler OnCheckedChanged;
        public xCheckBox()
        {
            InitializeComponent();
        }

        public void xCheckBox_Click(object sender, EventArgs e)
        {
            if (Value)
            {
                Value = false;
                pColor.Visible = false;
                OnCheckedChanged.Invoke(sender, e);
            }
            else
            {
                Value = true;
                pColor.Visible = true;
                OnCheckedChanged.Invoke(sender, e);
            }
        }

        private void pColor_Click(object sender, EventArgs e)
        {
            xCheckBox_Click(sender, e);
        }

        private void xCheckBox_Load(object sender, EventArgs e)
        {

        }
    }
}
