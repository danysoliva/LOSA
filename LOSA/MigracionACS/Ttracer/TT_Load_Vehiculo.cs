using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.Ttracer
{
    public partial class TT_Load_Vehiculo : Form
    {
        DataOperations dp = new DataOperations();
        public string placa;
        public string furgon;
        public int company;
        public int idConfVehiculo;
        public TT_Load_Vehiculo()
        {
            InitializeComponent();
            load_data();
            
        }
        public void load_data()
    {
            string query = @"SELECT T0.[id]
                                    ,T0.[idvehiculo]
	                                ,T1.placa
                                    ,coalesce((Select Top 1 T2.container 
					                            FROM dbo.M_furgon T2 
					                            where T2.id = T0.idfurgon
					                                and T2.enable = 1),'N/A')  as Furgon
                                    ,T0.[enable]
                                    ,COALESCE(T0.idcompany, 0) AS posibleId
                            FROM [dbo].[conf_vehiculos] T0 Join dbo.M_vehiculo T1 On T0.idvehiculo = T1.id
                            where T0.enable = 1
					          --                  FROM [dbo].[DC_entrada] T5 
					            --                Where T5.[enable] = 1 
					              --              and T5.[fechain] <=  SYSDATETIME() and t5.[Exit] = 0) 
					                            --and T0.id not in (Select T4.idconfvehi 
									                               -- from DC_workplan_d T4 
										                            --Where (T4.status > 39 AND T4.status < 59) 
										                            --and T4.enable = 1)";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dSTtracer.seleccionvehi.Clear();
                da.Fill(dSTtracer.seleccionvehi);
                cn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
    }
       
        private void btnseleccion_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_vehi.FocusedView;
                var row = (dSTtracer.seleccionvehiRow)gridview.GetFocusedDataRow();
                placa = row.placa;
                furgon = row.Furgon;
                idConfVehiculo = row.id;
                company = row.posibleId;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {

              
            }
        }

        private void grdv_vehi_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_vehi.FocusedView;
                var row = (dSTtracer.seleccionvehiRow)gridview.GetFocusedDataRow();
                placa = row.placa;
                furgon = row.Furgon;

                company = row.posibleId;
                idConfVehiculo = row.id;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {


            }
        }

        private void btnclose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void grdv_vehi_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_vehi.FocusedView;
                var row = (dSTtracer.seleccionvehiRow)gridview.GetFocusedDataRow();
                placa = row.placa;
                furgon = row.Furgon;

                company = row.posibleId;
                idConfVehiculo = row.id;
               
            }
            catch (Exception)
            {


            }
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnrecargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_data();
        }
    }
   
}
