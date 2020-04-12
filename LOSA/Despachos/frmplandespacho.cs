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
using ACS.Classes;

namespace LOSA.Despachos
{
    public partial class frmplandespacho : DevExpress.XtraEditors.XtraForm
    {
        int ParId; //Este id nos hace la operacion de crear el plan de la orden de venta.
        DataOperations dp = new DataOperations();
        public frmplandespacho(int IdOrdendeVenta)
        {
            InitializeComponent();
            ParId = IdOrdendeVenta;
        }
        public void create_plan()
        {
        }
    }
}