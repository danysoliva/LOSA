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
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.TransaccionesPT
{
    public partial class frmdespacho : DevExpress.XtraEditors.XtraForm
    {
        public frmdespacho()
        {
            InitializeComponent();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}