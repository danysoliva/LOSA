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

namespace LOSA.MigracionACS.SAR
{
    public partial class SAR_capitulos : Form
    {
        DataOperations dp;
        DateTime fechaini;
        DateTime fechafin;
        public SAR_capitulos(DateTime dtini, DateTime dtfin)
        {
            InitializeComponent();
            dp = new DataOperations();
            fechaini = dtini;
            fechafin = dtfin;
            load_data();
        }
        public void load_data()
        {
            string query = @"Select Sum(T1.Totallinea) as total
                ,(Coalesce(( Select T2.Code  
				from [AQFSVR006\AQFSVR006].[AQUA][dbo].[@AQUA_CAEX] T2 where T1.capitulo = T2.Code COLLATE SQL_Latin1_General_CP850_CI_AS),'N/D')) as codigo
				,(Coalesce(( Select T2.[U_AQUA_Desc]   
				from [AQFSVR006\AQFSVR006].[AQUA][dbo].[@AQUA_CAEX] T2 where T1.capitulo = T2.Code COLLATE SQL_Latin1_General_CP850_CI_AS),'No seleccionado')) as nombre
           from dbo.SAR_Order_H T0 Join dbo.SAR_Order_D T1 ON T0.id = T1.idH
             where   T0.DocDate >= '03-17-2019' and T0.DocDate <= '03-16-2020' and T1.capitulo is not null
            group by T1.capitulo";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dS_SAR.saldocap.Clear();
                da.Fill(dS_SAR.saldocap);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            
        }
        public void load_data_parm()
        {
            DateTime fechainicial;
            DateTime fechafinal;
            fechainicial = dtinicial.DateTime;
            fechafinal = dtfinal.DateTime;
            if (fechainicial.Date > fechafinal.Date)
            {
                CajaDialogo.Error("No es posible generar un reporte con la fecha final menor a la fecha inicial.");
                return;
            }
            string query = @"Select Sum(T1.Totallinea) as total
                ,(Coalesce(( Select T2.Code  
				from [AQFSVR006\AQFSVR006].[AQUA][dbo].[@AQUA_CAEX] T2 where T1.capitulo = T2.Code COLLATE SQL_Latin1_General_CP850_CI_AS),'N/D')) as codigo
				,(Coalesce(( Select T2.[U_AQUA_Desc]   
				from [AQFSVR006\AQFSVR006].[AQUA][dbo].[@AQUA_CAEX] T2 where T1.capitulo = T2.Code COLLATE SQL_Latin1_General_CP850_CI_AS),'No seleccionado')) as nombre
              from dbo.SAR_Order_H T0 Join dbo.SAR_Order_D T1 ON T0.id = T1.idH
              where   T0.DocDate >= @dtini and T0.DocDate <= @dtfin and T1.capitulo is not null
				group by T1.capitulo";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@dtini", SqlDbType.DateTime).Value =    fechainicial.Date.ToString();
                cmd.Parameters.Add("@dtfin", SqlDbType.DateTime).Value =     fechafinal.Date.ToString();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dS_SAR.saldocap.Clear();
                da.Fill(dS_SAR.saldocap);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btngenerar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_data_parm();
        }

        private void SAR_capitulos_Load(object sender, EventArgs e)
        {

        }

        private void btnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_main.ExportToXlsx(dialog.FileName);
                //gridControl2.ExportToXlsx(dialog.FileName);
            }
        }
    }
}
