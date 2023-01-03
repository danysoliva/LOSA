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
    public partial class TT_conductor : Form
    {
        int IdOfCompany;
        public int IdSelected;
        public string Cedula;
        public string Nombre;
        DataOperations dp = new DataOperations();
       
        public TT_conductor(int IdEmpresa)
        {
            InitializeComponent();
            IdOfCompany = IdEmpresa;
            if (IdEmpresa == 0)
            {
                conductor(0);
            }
            else
            {
            conductor(IdEmpresa);
            }
            
        }
        
        public void conductor(int idempre)
        {
            string query = "";
            if (idempre == 0)
            {
                query = @"SELECT  T0.[id]
                      ,CONCAT(T0.name, ' ',T0.lastname) AS Name
                      ,T1.name as empresa
	                  ,T0.Codigo
	                  ,T0.identidad
                  FROM [dbo].[M_Conductor] T0 join M_compania T1 on T0.companyid = t1.id";
            }
            else
            {
                query = @"SELECT  T0.[id]
                              ,CONCAT(T0.name, ' ',T0.lastname) AS Name
                              ,T1.name as empresa
	                          ,T0.Codigo
	                          ,T0.identidad
                          FROM [dbo].[M_Conductor] T0 join M_compania T1 on T0.companyid = t1.id
                          where T0.companyid = "+idempre;
            }
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dSTtracer.conductor.Clear();
                da.Fill(dSTtracer.conductor);
                cn.Close();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRecargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            conductor(IdOfCompany);
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_conductor.FocusedView;
                var row = (dSTtracer.conductorRow)gridview.GetFocusedDataRow();
                Cedula = row.identidad;
                IdSelected = row.id;
                Nombre = row.Name;
                this.DialogResult = DialogResult.OK;
                this.Close();


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

        private void grdv_conductor_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_conductor.FocusedView;
                var row = (dSTtracer.conductorRow)gridview.GetFocusedDataRow();
                Cedula = row.identidad;
                IdSelected = row.id;
                Nombre = row.Name;
                this.DialogResult = DialogResult.OK;
                this.Close();


            }
            catch (Exception)
            {

            }
        }

        private void grdv_conductor_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_conductor.FocusedView;
                var row = (dSTtracer.conductorRow)gridview.GetFocusedDataRow();
                Cedula = row.identidad;
                IdSelected = row.id;
                Nombre = row.Name;
                


            }
            catch (Exception)
            {

            }
        }
    }
}
