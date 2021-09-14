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

namespace LOSA.Produccion.BannerTV
{
    public partial class frmBannerMainTV_PRD : DevExpress.XtraEditors.XtraForm
    {
        public frmBannerMainTV_PRD()
        {
            InitializeComponent();
        }

        private void timerNextPage_Tick(object sender, EventArgs e)
        {
            navigationFrame1.SelectNextPage();
        }

        private void timerRefreshData_Tick(object sender, EventArgs e)
        {
            switch (navigationFrame1.SelectedPageIndex)
            {
                case 0://navigationPage1
                    
                    break;
                case 1://navigationPage2
                    
                    break;
                default://Si hay un problema de index

                    break;
            }
        }
    }
}