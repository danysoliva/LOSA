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
using DevExpress.XtraSplashScreen;
using ACS.Classes;
using LOSA.Clases;

namespace LOSA.MigracionACS.Produccion
{
    public partial class PP_Actual_Running_Orders : DevExpress.XtraEditors.XtraForm
    {

        public string Action_Step;

        private string ActiveUserCode;
        private string ActiveUserType;

        DataOperations dp = new DataOperations();

        public PP_Actual_Running_Orders()
        {
            InitializeComponent();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PP_Actual_Running_Orders_Load(object sender, EventArgs e)
        {
            try
            {
                //SplashScreenManager.ShowForm(typeof(WaitForm_GMReport));

                //SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SecOps sec = new SecOps();

                //sec.SendEmail_EX();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}