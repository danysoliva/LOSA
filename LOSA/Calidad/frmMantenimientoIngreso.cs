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
    public partial class frmMantenimientoIngreso : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmMantenimientoIngreso(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
        }

       
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}