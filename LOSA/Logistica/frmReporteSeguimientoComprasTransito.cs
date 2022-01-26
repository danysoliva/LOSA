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

namespace LOSA.Logistica
{
    public partial class frmReporteSeguimientoComprasTransito : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmReporteSeguimientoComprasTransito()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}