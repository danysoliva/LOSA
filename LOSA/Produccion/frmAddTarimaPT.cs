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

namespace LOSA.Produccion
{
    public partial class frmAddTarimaPT : Form
    {
        UserLogin UsuarioLogeado;
        int Lote;
        int IdProd;
        public frmAddTarimaPT(UserLogin UsuarioLogeado, int plote, int pidProd)
        {
            InitializeComponent();
            Lote = plote;
            IdProd = pidProd;
        }











    }
}
