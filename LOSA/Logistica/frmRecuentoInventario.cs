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
using System.Data.SqlClient;

namespace LOSA.Logistica
{
    public partial class frmRecuentoInventario : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;

        public frmRecuentoInventario(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
        }
    }
}