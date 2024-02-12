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
using LOSA.MigracionACS.PT;

namespace LOSA.MigracionACS.Tickets.EndUser
{
    public partial class PT_Producto_Borrador : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        
        public PT_Producto_Borrador(UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLog;
            toggleSwitchVerTodos.IsOn = true;
            LoadData();

        }

        private void LoadData()
        {
            throw new NotImplementedException();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCRUDProductoTerminado frm = new frmCRUDProductoTerminado(UsuarioLogueado, frmCRUDProductoTerminado.TipoOperacion.SolicitudInsert, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void toggleSwitchVerTodos_Toggled(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}