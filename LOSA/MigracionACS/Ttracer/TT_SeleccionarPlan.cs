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

namespace LOSA.MigracionACS.Ttracer
{
    public partial class TT_SeleccionarPlan : Form
    {
        public int IdSelected;

        DataOperations dp = new DataOperations();
        public TT_SeleccionarPlan()
        {
            InitializeComponent();
            load_data();
        }
        public void load_data()
        {
            string Query = @"Select T0.id
	                           ,T0.codigo
	                           ,T0.date_inicio
	                           ,t0.date_fin
	                           ,T0.comment
	                           ,Coalesce((Select T2.descripcion 
                        from TS_ship_h T1 join M_ship T2 on T1.shipid = T2.id
                        where T1.id = T0.shipid),'Sin barco') as barco
                        ,Case when (Select COUNT(T4.id) as Arribos 
			                        from DC_workplan_d t4 where t4.idh = T0.id and t4.enable = 1 ) = 0 then '0'
	                         when (Select COUNT(T4.id) as Arribos 
			                        from DC_workplan_d t4 where t4.idh = T0.id and t4.enable = 1 ) <> 0 then (Select COUNT(T4.id) as Arribos
																							                         from DC_workplan_d t4
																							                          where t4.idh = T0.id AND t4.enable = 1 ) end as Cantidad
                        From DC_workplan_h t0 
                        where T0.[close] = 0 and  T0.enable = 1 ";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
            cn.Open();
            SqlCommand cmd = new SqlCommand(Query, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dSTtracer.planselect.Clear();
            da.Fill(dSTtracer.planselect);
            cn.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_seleccion.FocusedView;
                var row = (dSTtracer.planselectRow)gridview.GetFocusedDataRow();
                IdSelected = row.id;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {

             
            }
        }

        private void grdv_seleccion_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_seleccion.FocusedView;
                var row = (dSTtracer.planselectRow)gridview.GetFocusedDataRow();
                IdSelected = row.id;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {


            }
        }

        private void btncloseplan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cerrar el plan? Si no se han cerrado todos lo arribos la configuracion se perderá.", "Advertencia!",MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var gridview = (GridView)grd_seleccion.FocusedView;
                var row = (dSTtracer.planselectRow)gridview.GetFocusedDataRow();
                IdSelected = row.id;
                string query = @"UPDATE [dbo].[DC_workplan_h]
                                   SET [close] = 0
                                 WHERE id =" + IdSelected;
                SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                load_data();
            }
            else
            {

            }
        }
    }
}
