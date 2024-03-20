using AMS.Compras.ControlInv;
using LOSA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.FromAMS
{
    public partial class frmShowControlUser : Form
    {
        UserLogin pUsuarioLogeado;
        public frmShowControlUser(UserLogin pUser)
        {
            InitializeComponent();
         

            frmrequisascs uc = new frmrequisascs();
            this.pUsuarioLogeado = pUser;
            uc.UsuarioLogeado = pUser;
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }
    }
}
