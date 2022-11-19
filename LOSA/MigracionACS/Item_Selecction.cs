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
using LOSA.MigracionACS.Formulas;

namespace LOSA.MigracionACS
{
    public partial class Item_Selecction : DevExpress.XtraEditors.XtraForm
    {
        public string FormHeader;

        public string col1Header;
        public string col2Header;
        
        /*Para el Forecast - Proyeccion de ventas*/
        public string action;
        public DataSet ProyDetail;
        DataOperations dp = new DataOperations();


        public string SVid { get; set; }
        public string SVCol1 { get; set; }
        public string SVCol2 { get; set; }
        public string SVGrupo { get; set; }

        public string Query;

        public Item_Selecction()
        {
            InitializeComponent();
        }

        private void UpdateProy() 
        {
            try 
            {
                Forecast.FCT_Proyeccion_Copy copy = new Forecast.FCT_Proyeccion_Copy();
                copy.action = "proy";
                copy.textBoxData = SVCol1;
                if (copy.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Double Porcentaje = (copy.Porcentaje / 100);

                    dp.ACS_DoSmallDBOperation(@"DELETE FROM [dbo].[FCT_Proyecciones_Venta_D_v2] WHERE [id_proy] = " + SVid + @"");

                    foreach (DataRow row in ProyDetail.Tables[0].Rows)
                    {
                        string query = @"INSERT INTO [dbo].[FCT_Proyecciones_Venta_D_v2]
			                            ([id_proy]
				                        ,[id_form]
				                        ,[ene]
				                        ,[feb]
				                        ,[mar]
				                        ,[abr]
				                        ,[may]
				                        ,[jun]
				                        ,[jul]
				                        ,[ago]
				                        ,[sep]
				                        ,[oct]
				                        ,[nov]
				                        ,[dic])
		                         VALUES (" + SVid + @"
				                        ," + row["id_form"].ToString() + @"
				                        ," + (Convert.ToDouble(row["ene"].ToString()) * (Porcentaje)).ToString() + @"
				                        ," + (Convert.ToDouble(row["feb"].ToString()) * (Porcentaje)).ToString() + @"
				                        ," + (Convert.ToDouble(row["mar"].ToString()) * (Porcentaje)).ToString() + @"
				                        ," + (Convert.ToDouble(row["abr"].ToString()) * (Porcentaje)).ToString() + @"
				                        ," + (Convert.ToDouble(row["may"].ToString()) * (Porcentaje)).ToString() + @"
				                        ," + (Convert.ToDouble(row["jun"].ToString()) * (Porcentaje)).ToString() + @"
				                        ," + (Convert.ToDouble(row["jul"].ToString()) * (Porcentaje)).ToString() + @"
				                        ," + (Convert.ToDouble(row["ago"].ToString()) * (Porcentaje)).ToString() + @"
				                        ," + (Convert.ToDouble(row["sep"].ToString()) * (Porcentaje)).ToString() + @"
				                        ," + (Convert.ToDouble(row["oct"].ToString()) * (Porcentaje)).ToString() + @"
				                        ," + (Convert.ToDouble(row["nov"].ToString()) * (Porcentaje)).ToString() + @"
				                        ," + (Convert.ToDouble(row["dic"].ToString()) * (Porcentaje)).ToString() + @");";

                        dp.ACS_DoSmallDBOperation(query);
                    }

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proceso ha fallado por completo.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btn_acceptar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (action == "proy")
            {
                UpdateProy();
            }
            else 
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void Item_Selecction_Load(object sender, EventArgs e)
        {
            if (action == "proy" || action == "mp" || action == "cts" || action == "prod") 
            {
                btn_Detail.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            DataOperations dp = new DataOperations();

            this.Text = FormHeader;
            col1.Caption = col1Header;
            col2.Caption = col2Header;

            if (action == "cts" || action == "prod") 
            {
                col_grupo.Visible = true;
                col_grupo.GroupIndex = 0;
            }

            grd_data.DataSource = dp.ACS_GetSelectData(Query).Tables[0];
        }

        private void grdv_data_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                SVid = grdv_data.GetRowCellValue(e.FocusedRowHandle, "id").ToString();
                SVCol1 = grdv_data.GetRowCellValue(e.FocusedRowHandle, "col1").ToString();
                SVCol2 = grdv_data.GetRowCellValue(e.FocusedRowHandle, "col2").ToString();
                SVGrupo = grdv_data.GetRowCellValue(e.FocusedRowHandle, "grupo").ToString();
            }
            catch { }
        }

        private void grd_data_DoubleClick(object sender, EventArgs e)
        {
            if (action == "proy")
            {
                UpdateProy();
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void btn_Detail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FML_NewFormula fm = new FML_NewFormula();
            fm.action = "view";
            fm.selectedID = SVid;
            fm.ShowDialog();
        }
    }
}