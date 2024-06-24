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
using DevExpress.XtraEditors;
using ACS.Classes;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using System.IO;
using LOSA.Clases;
using LOSA.MigracionACS.Formulas.Reports;

namespace LOSA.MigracionACS.Formulas
{
    public partial class FML_FF_Main_PanelV2 : DevExpress.XtraEditors.XtraForm
    {
        #region Form - Global Variables

        FMOP fmop = new FMOP();
        DataOperations dp = new DataOperations();
        DataTable formulas;

        /******Datos Usuario*******/
        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;

        DataTable UserGroups;

        int selected_formula;
        int selected_status;

        int selected_rm_line;

        UserLogin UsuarioLogeado;

        #endregion

        public FML_FF_Main_PanelV2(string ActiveUserCode, string ActiveUserName, string ActiveUserType, DataTable UserGroups, UserLogin pUserLogin)
        {
            InitializeComponent();
            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.ActiveUserType = ActiveUserType;
            UsuarioLogeado = pUserLogin;
        }

        private void barCargarXML_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargarXML XmL = new CargarXML();
            XmL.ActiveUserCode = this.ActiveUserCode;
            XmL.ActiveUserName = this.ActiveUserName;
            XmL.ActiveUserType = this.ActiveUserType;
            if (XmL.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                load_data();
            }
        }

        private void load_data()
        {
            try
            {
                int pEspecie = Convert.ToInt32(radioBtnEspecie.EditValue);
                #region Load Main
                if (chk_descontinuadas.Checked)
                    formulas = fmop.ext_formula_get_by_status(90, 95, pEspecie);
                else
                    formulas = fmop.ext_formula_get_by_status(1, 50, pEspecie);

                grd_main.DataSource = formulas;

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_descontinuadas_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_data();
        }

        private void btn_LoadXML_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargarXML XmL = new CargarXML();
            XmL.ActiveUserCode = this.ActiveUserCode;
            XmL.ActiveUserName = this.ActiveUserName;
            XmL.ActiveUserType = this.ActiveUserType;
            if (XmL.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                load_data();
            }
        }
    }
}