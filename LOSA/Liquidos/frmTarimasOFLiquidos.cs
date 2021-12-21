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
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.Liquidos
{
    
    public partial class frmTarimasOFLiquidos : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int IngresoKey;
        int Default_value = 0;

        public frmTarimasOFLiquidos(int idIngresoSeleccionado)
        {
            InitializeComponent();
            IngresoKey = idIngresoSeleccionado;
        }

        private void frmTarimasOFLiquidos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}