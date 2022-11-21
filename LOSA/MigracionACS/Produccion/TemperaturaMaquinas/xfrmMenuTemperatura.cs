using DevExpress.XtraEditors;
using LOSA.MigracionACS.Produccion.Molinos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MigracionACS.Produccion.TemperaturaMaquinas
{
    public partial class xfrmMenuTemperatura : DevExpress.XtraEditors.XtraForm
    {
        public xfrmMenuTemperatura()
        {
            InitializeComponent();
        }

        private void btnExtrusora_Click(object sender, EventArgs e)
        {
            xfrmTemperaturaExtusora frm = new xfrmTemperaturaExtusora();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnPellet1_Click(object sender, EventArgs e)
        {
            xfrmTemperaturaPellet_1 frm = new xfrmTemperaturaPellet_1();

            frm.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            xfrmTemperaturaPellet_2 frm = new xfrmTemperaturaPellet_2();

            frm.Show();
        }

        private void btnMolinosTilapia_Click(object sender, EventArgs e)
        {
           xfrmTemperaturaMolinosTilapia frm = new xfrmTemperaturaMolinosTilapia();

            frm.Show();
        }

        private void btnCamaron_Click(object sender, EventArgs e)
        {
            xfrmTemperaturaMolinosCamaron frm = new xfrmTemperaturaMolinosCamaron();

            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            xfrmEficienciaMolinos frm = new xfrmEficienciaMolinos();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}