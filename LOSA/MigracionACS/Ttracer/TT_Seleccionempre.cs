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
    public partial class TT_Seleccionempre : Form
    {
        DataOperations dp = new DataOperations();
        public int IdSelected;
        public  string codigo = "";
        public string name = "";
        public string Descripcion;
        public TT_Seleccionempre()
        {
            InitializeComponent();
            load_resourse();
        }
        public TT_Seleccionempre(int Id_selected)
        {
            InitializeComponent();
            load_resourse();
            load_data_allready_selected(Id_selected);


        }
        public void load_data_allready_selected(int Idcompany)
        {
            foreach (DataRow row in dSTtracer.seleccionempresa.Rows)
            {

                if (row["id"].ToString() == Idcompany.ToString())
                {
                    Descripcion = "(" +row["Codigo"].ToString() + ") - " + row["name"].ToString();
                    codigo = row["Codigo"].ToString();
                    name = row["name"].ToString();
                }
            }
        }
        public void load_resourse()
        {
            string Query = @"SELECT [id]
                  ,[name]
                  ,[Codigo]
              FROM [dbo].[M_compania]
              Where enable = 1";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dSTtracer.seleccionempresa.Clear();
                da.Fill(dSTtracer.seleccionempresa);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grdv_empresa_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_empresa.FocusedView;
                var row = (dSTtracer.seleccionempresaRow)gridview.GetFocusedDataRow();
                IdSelected = row.id;
                Descripcion = "("+row.Codigo+") - "+row.name;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnrecargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_resourse();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_empresa.FocusedView;
                var row = (dSTtracer.seleccionempresaRow)gridview.GetFocusedDataRow();
                IdSelected = row.id;
                Descripcion = "(" + row.Codigo + ") -" + row.name;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void grdv_empresa_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_empresa.FocusedView;
                var row = (dSTtracer.seleccionempresaRow)gridview.GetFocusedDataRow();
                IdSelected = row.id;
                Descripcion = "(" + row.Codigo + ") - " + row.name;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btncerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
