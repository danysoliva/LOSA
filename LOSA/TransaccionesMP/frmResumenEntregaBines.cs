using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACS.Classes;
using LOSA.Clases;
using System.Data;
using System.Data.SqlClient;

namespace LOSA.TransaccionesMP
{
    public partial class frmResumenEntregaBines : DevExpress.XtraEditors.XtraForm
    {
        public int id_tarima;
        public frmResumenEntregaBines(DataTable dt_tarima, int pid_tarima)
        {
            InitializeComponent();
            id_tarima = pid_tarima;
            vGridControl1.DataSource = dt_tarima;

            Tarima tm = new Tarima();
            tm.RecuperarRegistro(id_tarima, "");
            lblMPExistencia.Text = tm.ItemCode+"-"+ tm.MateriaPrima;
            txtTarimaExistencia.EditValue = tm.Peso;
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntregaPRD_Click(object sender, EventArgs e)
        {
            if (vGridControl1.DataSource == null)
            {
                CajaDialogo.Error("No se encontro la tarima");
            }
            if (txtTarimaExistencia.Text == "0")
            {
                CajaDialogo.Error("No se encontro la tarima");
            }
            try
            {
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}