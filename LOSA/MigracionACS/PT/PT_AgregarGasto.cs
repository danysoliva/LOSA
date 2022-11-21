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
    public partial class PT_AgregarGasto : DevExpress.XtraEditors.XtraForm
    {
        public string ProductID;

        #region Developer defined Functions

        private void LoadGroups() 
        {
            try
            {
                string Query = @"SELECT [id]
	                                   ,[Descripcion]
                                   FROM [PT_Gastos_Grupos]";
                DataOperations dp = new DataOperations();

                cmb_grupo.Properties.DataSource = dp.ACS_GetSelectData(Query).Tables[0];
                cmb_grupo.ItemIndex = 0;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDetails()
        {
            try
            {
                string Query = @"SELECT [id]
                                       ,[Descripcion]
                                   FROM [PT_Gastos_Detalle]
                                  WHERE [idGrupo] = " + cmb_grupo.EditValue.ToString() + "";
                DataOperations dp = new DataOperations();

                cmb_detalle.Properties.DataSource = dp.ACS_GetSelectData(Query).Tables[0];
                cmb_detalle.ItemIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveData() 
        {
            try
            {
                string Query = @"INSERT INTO [PT_Gastos_Valor]
		                                     ([idGasto],[idProducto],[costo])
                                      VALUES (" + cmb_detalle.EditValue.ToString() + "," + ProductID + "," + txt_costo.Text.ToString() + ")";
                DataOperations dp = new DataOperations();

                dp.ACS_DoSmallDBOperation(Query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        public PT_AgregarGasto()
        {
            InitializeComponent();
        }

        private void PT_AgregarGasto_Load(object sender, EventArgs e)
        {
            LoadGroups();
            //LoadDetails();
        }

        private void btn_cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btn_Aceptar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void cmb_grupo_EditValueChanged(object sender, EventArgs e)
        {
            LoadDetails();
        }

        private void btn_NuevoGrupo_Click(object sender, EventArgs e)
        {
            PT_NewGrp_Dtl grp = new PT_NewGrp_Dtl();
            grp.action = "group";
            //grp.group = cmb_grupo.Text.ToString();

            if (grp.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                LoadGroups();
                LoadDetails();
            }
        }

        private void btn_NuevoGasto_Click(object sender, EventArgs e)
        {
            PT_NewGrp_Dtl grp = new PT_NewGrp_Dtl();
            grp.action = "detail";
            grp.group = cmb_grupo.Text.ToString();
            grp.groupid = cmb_grupo.EditValue.ToString();

            if (grp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadGroups();
                LoadDetails();
            }
        }
    }
}