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

namespace LOSA.TransaccionesPT
{
    public partial class frmLotesxPT : DevExpress.XtraEditors.XtraForm
    {
        public string code_sap, Descripcion;
        public int id_pt, lot_number;

        public frmLotesxPT(int pid_pt)
        {
            InitializeComponent();
            id_pt = pid_pt;
            //Load_Data();
        }
    }
}