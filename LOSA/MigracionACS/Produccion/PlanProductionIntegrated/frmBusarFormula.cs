using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MigracionACS.Produccion.PlanProductionIntegrated
{
    public partial class frmBusarFormula : DevExpress.XtraEditors.XtraForm
    {
        public int IdFormula;
        public string codigoF;
        public int VersionF;
        public frmBusarFormula()
        {
            InitializeComponent();
            LoadFormulas();
        }

        private void LoadFormulas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("[FM_FL_Get_By_Statusv2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@min_status", 50);
                if(toggleSwitch1.IsOn)//ver descontinuadas
                    cmd.Parameters.AddWithValue("@max_status", 90);
                else
                    cmd.Parameters.AddWithValue("@max_status", 80);

                cmd.Parameters.AddWithValue("@especie", radioGroup1.EditValue);
                dsPlanPRD1.formula_list.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPlanPRD1.formula_list);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            LoadFormulas();
        }

        private void cmdSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //seleccionar formula
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsPlanPRD.formula_listRow)gridView.GetFocusedDataRow();
            IdFormula = row.id;
            codigoF = row.codigo;
            VersionF = row.version;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFormulas();
        }
    }
}