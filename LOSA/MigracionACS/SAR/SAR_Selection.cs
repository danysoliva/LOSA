using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;

namespace LOSA.MigracionACS.SAR
{
    public partial class SAR_Selection : Form
    {
        DataOperations dp = new DataOperations();
        public int idSelected= 0;
        public DateTime inicio;
        public DateTime final; UserLogin Puser;
        int VerEnable = 0;
        public SAR_Selection(UserLogin user)
        {
            InitializeComponent();
            Puser = user;
            load_data();
        }
        public void load_data()
        {
            string Query = @"SELECT [id]
                                    ,[anio]
                                    ,[inicio]
                                    ,[final]
                                    , Case when cerrado = 1 then 'Cerrado'
                                        when cerrado = 0 then 'Abierto'
                                        end as cerrado
                                FROM[dbo].[SAR_presupuesto_h]
                                where enable = 1 ";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dS_SAR.exoneracion.Clear();
                da.Fill(dS_SAR.exoneracion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void btnclose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_exoneracion.FocusedView;
                var row = (dS_SAR.exoneracionRow)gridview.GetFocusedDataRow();
                idSelected = row.id;
                inicio = row.inicio;
                final = row.final;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                
            }
        }

        private void grdv_exoneracion_RowClick(object sender, RowClickEventArgs e)
        {

        }

        private void grdv_exoneracion_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_exoneracion.FocusedView;
                var row = (dS_SAR.exoneracionRow)gridview.GetFocusedDataRow();
                idSelected = row.id;
                inicio = row.inicio;
                final = row.final;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {

            }
        }

        private void btnnueva_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SAR_exoneracionNueva nueva = new SAR_exoneracionNueva(Puser, 0, 0);
            if (nueva.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }
         }

        private void btneditar_Click(object sender, EventArgs e)
        {

            try
            {
                var gridview = (GridView)grd_exoneracion.FocusedView;
                var row = (dS_SAR.exoneracionRow)gridview.GetFocusedDataRow();
                SAR_exoneracionNueva btn = new SAR_exoneracionNueva(Puser, 1, row.id);
                if (btn.ShowDialog() == DialogResult.OK)
                {
                    load_data();
                }
            }
            catch (Exception ex)
            {
                
            }
         }
        public void load_datas(int ParEnable)
        {
            if (ParEnable == 1)
            {//Ver Deshabilitados
                string Query = @"SELECT [id]
                                    ,[anio]
                                    ,[inicio]
                                    ,[final]
                                    , Case when cerrado = 1 then 'Cerrado'
                                        when cerrado = 0 then 'Abierto'
                                        end as cerrado
                                FROM[dbo].[SAR_presupuesto_h]";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dS_SAR.exoneracion.Clear();
                    da.Fill(dS_SAR.exoneracion);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {//Solo habilitados
                string Query = @"SELECT [id]
                                    ,[anio]
                                    ,[inicio]
                                    ,[final]
                                    , Case when cerrado = 1 then 'Cerrado'
                                        when cerrado = 0 then 'Abierto'
                                        end as cerrado
                                FROM[dbo].[SAR_presupuesto_h]
                                where enable = 1 ";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dS_SAR.exoneracion.Clear();
                    da.Fill(dS_SAR.exoneracion);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void tgghabilitados_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tgghabilitados.Checked == true)
            {
                VerEnable = 1;
            }
            else
            {
                VerEnable = 0;
            }
            load_datas(VerEnable);
        }
    }
}
