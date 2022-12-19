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
using LOSA.Clases;

namespace LOSA.MigracionACS.SAR
{
    public partial class SAR_Saldo : Form
    {
        UserLogin User;
        int IdExoneracio = 0;
        DateTime dtini, dtfin;
        DataOperations dp = new DataOperations();
        public SAR_Saldo(UserLogin usuario)
        {
            InitializeComponent();
            User = usuario;
            get_exoneracion_activa();
            load_data(IdExoneracio);
        }
        public void get_exoneracion_activa()
        {
            string Query = @"Select T0.id --0
		                        ,T0.inicio --1
		                        ,T0.final --2
		                         from dbo.SAR_presupuesto_h T0 
                        where t0.enable = 1 and t0.cerrado = 0";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdExoneracio = Convert.ToInt32(dr[0].ToString());
                    dtini = Convert.ToDateTime(dr[1].ToString());
                    dtfin = Convert.ToDateTime(dr[2].ToString());
                }
                else
                {
                    CajaDialogo.Information("Debe crear o activar una nueva exoneracion.");
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_data(int IDExonerada)
        {
            //string Query = @"Select Sum(T1.LineTotal) as total
            //                              , T2.Code
            //                              , T2.Name
            //                              , T3.monto as presupuesto
            //                                    , T3.id as idregistro
            //                              ,t3.monto - Sum(T1.LineTotal)  as diferencia
            //                            from [AQFSVR006].[AQUA][dbo].[OPOR] T0 Join [AQFSVR006].[AQUA][dbo].POR1 T1 ON T0.DocEntry = T1.DocEntry
            //                                join [AQFSVR006].[AQUA][dbo].[@RUBRO] T2 ON T1.U_Rubro = T2.Code
            //                                join dbo.SAR_presupuesto_d T3 ON t3.code = T2.Code
            //                                join dbo.SAR_presupuesto_h T4 ON T3.idh = T4.id
            //                            where T0.CANCELED = 'N' and T1.TargetType <> -1 and T0.DocCur = 'LPS'
            //                            and T1.U_Rubro <> '' and T0.DocDate >= '" + dtini.ToString("MM-dd-yyy") + @"' and T0.DocDate <= '" + dtfin.ToString("MM-dd-yyy") + @"' AND T4.enable = 1 AND t4.id = @ParId
            //                            group by T2.Code, T2.Name, T3.monto, t3.id
            //                            order by cast(T2.Code as int)";
            string Query = @"sp_sar_load_saldos";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ParId", SqlDbType.Int).Value = IDExonerada;
                cmd.Parameters.AddWithValue("@dtini", dtini.ToString("MM-dd-yyy"));
                cmd.Parameters.AddWithValue("@dtfin", dtfin.ToString("MM-dd-yyy"));
                dS_SAR.rubrosmana.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dS_SAR.rubrosmana);
                cn.Close();
                
            }
            catch (Exception ex)
            {

                CajaDialogo.Error("Error al cargar los datos." +ex.Message);
            }
        }

        private void grdv_saldos_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                GridView View = sender as GridView;
                string Estado = View.GetRowCellDisplayText(e.RowHandle, View.Columns["diferencia"]);
                string total = View.GetRowCellDisplayText(e.RowHandle, View.Columns["total"]); // COns umo
                string presupuesto = View.GetRowCellDisplayText(e.RowHandle, View.Columns["presupuesto"]); // presupuesto;
                Double Parpresupuesto = Convert.ToDouble(presupuesto);
                Double TotalSAP = Convert.ToDouble(total);
                Double pocentaje = TotalSAP / Parpresupuesto;
                if (e.RowHandle >= 0)
                {
                    if (pocentaje >= 0.90)
                    {

                        e.Appearance.BackColor = Color.FromArgb(255, 0, 0);//rojo
                    }
                    else
                    {
                        if (pocentaje >= 0.80 && pocentaje >= 0.89)
                        {

                            e.Appearance.BackColor = Color.FromArgb(217, 100, 1);//anaranjado
                        }
                        else
                        {
                            if (pocentaje >= 0.40 && pocentaje <= 0.79)
                            {

                                e.Appearance.BackColor = Color.FromArgb(239, 242, 132); // amarillo
                            }
                            else
                            {
                                e.Appearance.BackColor = Color.FromArgb(70, 147, 76); // verde
                            }
                        }
                      
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void btncambiomonto_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_saldos.FocusedView;
                var row = (dS_SAR.rubrosmanaRow)gridview.GetFocusedDataRow();
                SAR_mantimientoXRubro rubro = new SAR_mantimientoXRubro(row.Code, row.Name, row.idregistro, row.presupuesto, dtini, dtfin);
                if (rubro.ShowDialog() == DialogResult.OK)
                {
                    load_data(IdExoneracio);
                }
            }
            catch (Exception ex)
            {

                
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SAR_Selection select = new SAR_Selection(User);
            if (select.ShowDialog() == DialogResult.OK)
            {
                IdExoneracio = select.idSelected;
                dtini = select.inicio;
                dtfin = select.final;
                load_data(IdExoneracio);
            }
        }

        private void btnclose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnedit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SAR_exoneracionNueva btn = new SAR_exoneracionNueva(User,1,IdExoneracio);
            if (btn.ShowDialog() == DialogResult.OK)
            {
                IdExoneracio = btn.idH;
                get_exoneracion_activa();
                load_data(IdExoneracio);

            }
            if (IdExoneracio == 0)
            {
                dS_SAR.rubrosmana.Clear();

            }
            else
            {
                load_data(IdExoneracio);
            }
        }

        private void btndetails_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_saldos.FocusedView;
                var row = (dS_SAR.rubrosmanaRow)gridview.GetFocusedDataRow();
                SAR_Details rubro = new SAR_Details(row.Code, dtini, dtfin);
                if (rubro.ShowDialog() == DialogResult.OK)
                {
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnexport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdv_saldos.ExportToXlsx(dialog.FileName);
            }
        }

        private void barcapitulos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SAR_capitulos dtr = new SAR_capitulos(dtini, dtfin);
            dtr.Show();
        }

        private void btnrubrocap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SAR_DASHBOARD report = new SAR_DASHBOARD();
            report.Show();
        }

        private void btnactualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_data(IdExoneracio);
        }

        private void btnnueva_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SAR_exoneracionNueva nueva = new SAR_exoneracionNueva(User,0,0);
            if (nueva.ShowDialog() == DialogResult.OK)
            {
                IdExoneracio = nueva.idH;
                get_exoneracion_activa();
                load_data(IdExoneracio);

            }
            if (IdExoneracio == 0)
            {


            }
            else
            {
                load_data(IdExoneracio);
            }
        }
    }
}
