using ACS.Classes;
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

namespace LOSA.MigracionACS.Ttracer.ViewLogistica
{
    public partial class frmCamionesEnPredio : Form
    {
        UserLogin UsuarioLogeado;
        public frmCamionesEnPredio(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
        }
    }
}
