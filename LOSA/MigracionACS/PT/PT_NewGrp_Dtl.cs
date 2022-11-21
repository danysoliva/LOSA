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
using ACS.Classes;

namespace LOSA.MigracionACS.PT
{
    public partial class PT_NewGrp_Dtl : DevExpress.XtraEditors.XtraForm
    {
        public string action;
        public string group;
        public string groupid;

        #region Developer Defined Fuctions

        //For Desingn to be inherited
        protected override bool GetAllowSkin()
        {
            if (this.DesignMode) return false;
            return true;
        }

        private void SaveData()
        {
            try
            {
                string Query = "";

                if (action == "group")
                {
                    Query = @"  INSERT INTO [PT_Gastos_Grupos]
		                                    ([Descripcion])
	                                 VALUES ('" + txt_detail.Text.ToString() + "');";
                }
                else if (action == "detail")
                {
                    Query = @"  INSERT INTO [PT_Gastos_Detalle]
		                                    ([Descripcion],[idGrupo])
	                                 VALUES ('" + txt_detail.Text.ToString() + "', " + groupid + ");";
                }

                DataOperations dp = new DataOperations();

                dp.ACS_DoSmallDBOperation(Query);

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        public PT_NewGrp_Dtl()
        {
            InitializeComponent();
            GetAllowSkin();
        }

        private void PT_NewGrp_Dtl_Load(object sender, EventArgs e)
        {
            if (action == "group") 
            {
                this.Text = "Nuevo Grupo de Costos";
                grp_detail.Text = "Ingrese el nombre del nuevo grupo";
            }
            else if (action == "detail") 
            {
                this.Text = "Nuevo Costo";
                grp_detail.Text = "Nombre Costo para el Grupo: " + group;
            }
        }

        private void txt_detail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveData();
            }
            else if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}