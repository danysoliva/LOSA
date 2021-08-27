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
using ACS.Classes;
using LOSA.Clases;

namespace LOSA.Calidad
{
    public partial class frmOlorMantenimiento : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmOlorMantenimiento(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
        }

        public void load_data()
        {

        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}