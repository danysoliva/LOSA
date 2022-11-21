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

namespace LOSA.MigracionACS.Produccion.Configuraciones
{
    public partial class xfrmMainConfiguracion : DevExpress.XtraEditors.XtraForm
    {
        public xfrmMainConfiguracion()
        {
            InitializeComponent();
        }

        private void btnMaquinaDado_Click(object sender, EventArgs e)
        {
            xfrmMaquinasDadoMain frm = new xfrmMaquinasDadoMain();

            frm.Show();
        }

        private void btnTipoMaquinaDado_Click(object sender, EventArgs e)
        {
            xfrmTipoMaquina frm = new xfrmTipoMaquina();

                frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}