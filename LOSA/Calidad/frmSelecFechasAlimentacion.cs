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
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Calidad
{
    public partial class frmSelecFechasAlimentacion : DevExpress.XtraEditors.XtraForm
    {
        public DateTime dtDesde, dtHasta;

        DataOperations dp = new DataOperations();

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (datDesde.DateTime > datHasta.DateTime)
            {
                CajaDialogo.Error("Debe seleccionar una rango de fecha coherente!");
            }

            dtDesde = datDesde.DateTime;
            dtHasta = datHasta.DateTime;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public frmSelecFechasAlimentacion()
        {

            InitializeComponent();

            datDesde.DateTime = dp.Now().AddDays(-1);
            datHasta.DateTime = dp.Now();
        }
    }
}