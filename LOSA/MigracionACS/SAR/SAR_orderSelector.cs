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

namespace LOSA.MigracionACS.SAR
{
    public partial class SAR_orderSelector : Form
    {
        DataOperations dp = new DataOperations();
        public SAR_orderSelector()
        {
            InitializeComponent();
            load_data();
        }
        public void load_data()
        {
            string query = @"SELECT [id]
                                      ,[DocNum] as DocEntry
                                      ,[CardCode]
                                      ,[CardName]
                                      ,[moneda]
                                      ,[Tasa]
                                      ,[datadoc]
                                      ,[id_tipo]
                                      ,[comment]
                                      ,[totaldoc],
	                                  Case when MONTH([datadoc])= 1 then 'Enero'
			                                when MONTH([datadoc])= 2 then 'Febrero'
			                                when MONTH(datadoc)= 3 then 'Marzo'
			                                when MONTH(datadoc)= 4 then 'Abril'
			                                when MONTH(datadoc)= 5 then 'Mayo'
			                                when MONTH(datadoc)= 6 then 'Junio'
			                                when MONTH(datadoc)= 7 then 'Julio'
			                                when MONTH(datadoc)= 8 then 'Agosto'
			                                when MONTH(datadoc)= 9 then 'Septiembre'
			                                when MONTH(datadoc)= 10 then 'Octubre'
			                                when MONTH(datadoc)= 11 then 'Noviembre'
			                                when MONTH(datadoc)= 12 then 'Diciembre'
			                                end as mes
                                  FROM [dbo].[SAR_Order_H]X
                                  where enable = 1
								  and cast(X.datadoc as date) between (
																		SELECT top 1 A.inicio
																	  FROM [AQFSVR006\AQFSVR006].[ACS].[dbo].[SAR_presupuesto_h] A
																	 WHERE A.enable = 1
																	 and A.cerrado = 0
																	 order by 1 desc
																	) and (
																			SELECT top 1 A.final
																			  FROM [AQFSVR006\AQFSVR006].[ACS].[dbo].[SAR_presupuesto_h] A
																			 WHERE A.enable = 1
																			 and A.cerrado = 0
																			 order by 1 desc
																			)
																			ORDER BY x.datadoc DESC";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dS_SAR.OCH.Clear();
                da.Fill(dS_SAR.OCH);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_main.FocusedView;
                var row = (dS_SAR.OCHRow)gridview.GetFocusedDataRow();
                SAR_Orden_detalle detalle = new SAR_Orden_detalle(row.id);
                if (detalle.ShowDialog() == DialogResult.OK)
                {
                    load_data();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnclose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bttnactualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_data();
        }

        private void btnagregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SAR_Orden_detalle ocd = new SAR_Orden_detalle();
            if (ocd.ShowDialog() == DialogResult.OK)
            {

                load_data();
            }
        }
    }
}
