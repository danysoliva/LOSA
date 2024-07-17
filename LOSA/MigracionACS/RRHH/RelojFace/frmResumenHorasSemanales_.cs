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

namespace LOSA.MigracionACS.RRHH.RelojFace
{
    
    public partial class frmResumenHorasSemanales_ : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmResumenHorasSemanales_(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
        }
    }
}