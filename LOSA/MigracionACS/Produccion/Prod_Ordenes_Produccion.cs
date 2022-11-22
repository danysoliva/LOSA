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
using LOSA.MigracionACS.Formulas;
using LOSA.MigracionACS.PT;

namespace LOSA.MigracionACS.Produccion
{
    public partial class Prod_Ordenes_Produccion : DevExpress.XtraEditors.XtraForm
    {
        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;
        string selOrderID;

        public Prod_Ordenes_Produccion(string ActiveUserCode, string ActiveUserName, string ActiveUserType)
        {
            InitializeComponent();

            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.ActiveUserType = ActiveUserType;
        }

        public Prod_Ordenes_Produccion(string ActiveUserCode, string ActiveUserName, string ActiveUserType, string selOrderID)
        {
            InitializeComponent();

            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.selOrderID = selOrderID;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_ProdPlan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //try
            //{
            //    PP_Nuevo_Plan pp = new PP_Nuevo_Plan(ActiveUserCode, ActiveUserName, "new", ActiveUserType);
            //    pp.MdiParent = this;
            //    pp.Show();
            //}
            //catch { }
            try
            {
             
                PP_Nuevo_Plan_full pp = new PP_Nuevo_Plan_full(ActiveUserCode, ActiveUserName, "new", ActiveUserType);
                //pp.MdiParent = this;
                pp.Show();

            }
            catch { }
        }

        private void btn_ViewActivePlans_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PP_Active_Plans plan = new PP_Active_Plans(ActiveUserCode, ActiveUserName, "edit", ActiveUserType);
            //plan.MdiParent = this;
            plan.ShowDialog();
        }

        private void btn_ViewPlanProceso_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PP_Actual_Running_Orders op = new PP_Actual_Running_Orders();
            op.MdiParent = this;
            op.Show();
        }

        private void btn_formulas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FML_Formulas_v2 fm = new Formulas.FML_Formulas_v2(ActiveUserCode, ActiveUserName, ActiveUserType, null);
            fm.ShowDialog();
        }

        private void btn_pts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PT_Productos prod = new PT_Productos(ActiveUserCode, ActiveUserName, ActiveUserType);
            prod.MdiParent = this;
            prod.Show();
        }
    }
}