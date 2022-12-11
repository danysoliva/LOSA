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

namespace LOSA.MigracionACS.Forecast
{
    public partial class FCT_Show_DPI : DevExpress.XtraEditors.XtraForm
    {
        public DataSet datos;

        public FCT_Show_DPI()
        {
            InitializeComponent();
        }

        private void FCT_Show_DPI_Load(object sender, EventArgs e)
        {
            grd_data.DataSource = datos.Tables[0];
        }

        private void btn_ok_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}