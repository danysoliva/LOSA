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
using System.Data.SqlClient;

namespace LOSA.MigracionACS.RRHH.Liquidaciones
{
    public partial class frmConfPorcentajeLiquiOP : DevExpress.XtraEditors.XtraForm
    {

        public enum tipotrans
        {
            insert = 1,
            update = 2
        }

        tipotrans vtipotrans;

        public frmConfPorcentajeLiquiOP()
        {
            InitializeComponent();
            vtipotrans = tipotrans.insert;
            lblPorcentaje.Text = "Crear Porcentaje";

        }

        public frmConfPorcentajeLiquiOP(int pid)
        {
            InitializeComponent();
            vtipotrans = tipotrans.update;
            lblPorcentaje.Text = "Editar Porcentaje";

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            switch (vtipotrans)
            {
                case tipotrans.insert:
                    break;
                case tipotrans.update:
                    break;
                default:
                    break;
            }
        }
    }
}