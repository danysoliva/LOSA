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
    public partial class PT_NuevoProducto : DevExpress.XtraEditors.XtraForm
    {
        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;

        public string ProductID;
        public string Action;

        private string SelectedCosto;
        //private DataSet DataGastos;

        #region Developer Defined Functions

        //For Desingn to be inherited
        protected override bool GetAllowSkin()
        {
            if (this.DesignMode) return false;
            return true;
        }

        private void GetGastos() 
        {
            try
            {
                string query = @"SELECT A.[id]
                                       ,C.[Descripcion] AS 'Grupo'
                                       ,B.[Descripcion] AS 'Gasto'
                                       ,A.[costo]
                                   FROM [PT_Gastos_Valor] A
                             INNER JOIN [PT_Gastos_Detalle] B ON A.[idGasto] = B.[id]
                             INNER JOIN [PT_Gastos_Grupos] C ON B.[idGrupo] = C.[id]
                                  WHERE A.[idProducto] = " + ProductID + "";
                
                DataOperations dp = new DataOperations();
                grd_gastos.DataSource = dp.ACS_GetSelectData(query).Tables[0];

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetEspecies()
        {
            try
            {
                string query = @"SELECT [id]
                                       ,[Descripcion]
                                   FROM [Conf_Especies]";

                DataOperations dp = new DataOperations();
                cmb_Especies.Properties.DataSource = dp.ACS_GetSelectData(query).Tables[0];
                //cmb_Especies.Properties.DisplayMember = "Descripcion";
                //cmb_Especies.Properties.ValueMember = "id";
                //cmb_Especies.Properties.Columns["id"].Visible = false;

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
                string Query = @"  INSERT INTO [PT_Productos]
	                                           ([Codigo]
                                               ,[Serie]
                                               ,[Descripcion]
                                               ,[Proteina]
                                               ,[Grasa]
                                               ,[TamPellet]
                                               ,[PesoSaco]
                                               ,[Especie]
                                               ,[Fecha]
                                               ,[Hora]
                                               ,[Estado])
                                        VALUES ('" + txt_Codigo.Text.ToString() + @"'
	                                           ," + txt_serie.Text.ToString() + @"
	                                           ,'" + txt_Descripcion.Text.ToString() + @"'
	                                           ," + txt_Proteina.Text.ToString() + @"
	                                           ," + txt_Grasa.Text.ToString() + @"
	                                           ," + txt_TamPellet.Text.ToString() + @"
	                                           ," + txt_PesoSaco.Text.ToString() + @"
	                                           ," + cmb_Especies.EditValue.ToString() + @"
	                                           ,SYSDATETIME()
	                                           ,SYSDATETIME()
	                                           ,'a')";

                DataOperations dp = new DataOperations();

                dp.ACS_DoSmallDBOperation(Query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                string query = @"SELECT [Codigo]
                                       ,[Serie]
                                       ,[Descripcion]
                                       ,[Proteina]
                                       ,[Grasa]
                                       ,[TamPellet]
                                       ,[PesoSaco]
                                       ,[Especie]
                                   FROM [PT_Productos]
                                  WHERE [id] = " + ProductID + "";

                DataOperations dp = new DataOperations();
                DataSet product = new DataSet();
                product = dp.ACS_GetSelectData(query);

                txt_Codigo.Text = product.Tables[0].Rows[0]["Codigo"].ToString();
                txt_serie.Text = product.Tables[0].Rows[0]["Serie"].ToString();
                txt_Descripcion.Text = product.Tables[0].Rows[0]["Descripcion"].ToString();
                txt_Proteina.Text = product.Tables[0].Rows[0]["Proteina"].ToString();
                txt_Grasa.Text = product.Tables[0].Rows[0]["Grasa"].ToString();
                txt_TamPellet.Text = product.Tables[0].Rows[0]["TamPellet"].ToString();
                txt_PesoSaco.Text = product.Tables[0].Rows[0]["PesoSaco"].ToString();
                cmb_Especies.EditValue = product.Tables[0].Rows[0]["Especie"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteData() 
        {
            try
            {
                string Query = @"DELETE FROM [PT_Gastos_Valor]
                                       WHERE [id] = " + SelectedCosto + "";

                DataOperations dp = new DataOperations();

                dp.ACS_DoSmallDBOperation(Query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateData()
        {
            try
            {
                string Query = @"   UPDATE [PT_Productos]
                                       SET [Codigo] = '" + txt_Codigo.Text.ToString() + @"'
	                                      ,[Serie] = " + txt_serie.Text.ToString() + @"
                                          ,[Descripcion] = '" + txt_Descripcion.Text.ToString() + @"'
                                          ,[Proteina] = " + txt_Proteina.Text.ToString() + @"
                                          ,[Grasa] = " + txt_Grasa.Text.ToString() + @"
                                          ,[TamPellet] = " + txt_TamPellet.Text.ToString() + @"
                                          ,[PesoSaco] = " + txt_PesoSaco.Text.ToString() + @"
                                          ,[Especie] = " + cmb_Especies.EditValue.ToString() + @"
                                     WHERE [id] = " + ProductID + " ";

                DataOperations dp = new DataOperations();

                dp.ACS_DoSmallDBOperation(Query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        public PT_NuevoProducto(string ActiveUserCode, string ActiveUserName, string ActiveUserType)
        {
            InitializeComponent();

            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.ActiveUserType = ActiveUserType;
        }

        private void PT_NuevoProducto_Load(object sender, EventArgs e)
        {
            if (Action == "edit")
            {
                btn_GuardarCambios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.Text = "Editar Producto";
                if (ActiveUserType == "pr")
                {
                    grp_Info.Size = new Size(507, 194);
                    this.Size = new Size(535, 276);
                }
                else 
                {
                    this.Size = new Size(535, 585);   
                }
                GetGastos();
                LoadData();
            }
            else 
            {
                btn_Guardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                grp_detalleGastos.Visible = false;
                grp_Info.Size = new Size(507, 194);
                this.Size = new Size(535, 276);
            }
            GetEspecies();
        }

        private void btn_Cancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void PT_NuevoProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == System.Windows.Forms.DialogResult.Cancel) 
            {
                if (MessageBox.Show("¿Seguro que desea Cancelar?, todo cambio realizado se perdera.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btn_AddGasto_Click(object sender, EventArgs e)
        {
            PT_AgregarGasto gasto = new PT_AgregarGasto();
            gasto.ProductID = ProductID;
            if (gasto.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                GetGastos();
            }
        }

        private void btn_Guardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btn_removeGasto_Click(object sender, EventArgs e)
        {
            DeleteData();
            GetGastos();
        }

        private void grdv_gastos_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SelectedCosto = grdv_gastos.GetDataRow(e.FocusedRowHandle)["id"].ToString();
        }

        private void btn_GuardarCambios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateData();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}