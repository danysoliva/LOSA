using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LOSA.Utileria
{
    public partial class frmMensaje : DevExpress.XtraEditors.XtraForm
    {
        public enum TipoMsj
        {
            error = 1,
            info = 2
        }
        TipoMsj TipoMensajeActual;
        public frmMensaje(TipoMsj ptipo, string msj)
        {
            InitializeComponent();
            labelControl1.Text = msj;
            TipoMensajeActual = ptipo;
            switch (ptipo)
            {
                case TipoMsj.error:
                    msjBoxIcon.Image = pictureBoxError.Image;
                    break;
                case TipoMsj.info:
                    msjBoxIcon.Image = pictureBoxInfomation.Image;
                    break;
            }




        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}