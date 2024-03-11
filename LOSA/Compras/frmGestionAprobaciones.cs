using DevExpress.XtraEditors;
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

namespace LOSA.Compras
{
    public partial class frmGestionAprobaciones : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmGestionAprobaciones(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
        }
    }
}