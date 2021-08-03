﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Trazabilidad
{
    public partial class frmTrazabilidadOpciones : DevExpress.XtraEditors.XtraForm
    {
        public frmTrazabilidadOpciones()
        {
            InitializeComponent();
        }

        private void cmdProveedores_Click(object sender, EventArgs e)
        {
            frmMantoProveedoresMP frm = new frmMantoProveedoresMP();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}