using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MigracionACS.Ttracer
{
    public partial class TT_Nuevo : Form
    {
         public int idofshipP;
        public int IdGenerado;
        string usercode;
        public TT_Nuevo(string usercode)
        {
            InitializeComponent();
            this.usercode = usercode;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            
            TT_Shipselect Already = new TT_Shipselect(usercode);
            if (Already.ShowDialog() == DialogResult.OK)
            {
                idofshipP = Already.Selectid;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            TT_newPlan tt = new TT_newPlan(usercode);
            if (tt.ShowDialog() == DialogResult.OK)
            {
                IdGenerado = tt.IdGenerado;
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }
    }
}
