using ACS.Classes;
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

namespace LOSA.RecepcionMP
{
    public partial class frmEditLoteExterno : DevExpress.XtraEditors.XtraForm
    {
        string OldLote;
        public string NewLoteSet_user;
        public frmEditLoteExterno(string pLoteOld)
        {
            InitializeComponent();
            txtLoteOld.Text = OldLote = pLoteOld;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNuevoLote.Text))
            {
                CajaDialogo.Error("No se permite dejar el nuevo Lote en blanco!");
                return;
            }

            NewLoteSet_user = txtNuevoLote.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmEditLoteExterno_Activated(object sender, EventArgs e)
        {
            txtNuevoLote.Focus();
        }
    }
}