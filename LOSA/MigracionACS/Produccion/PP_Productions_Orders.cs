using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using ACS.Classes;
using System.Data.SqlClient;
using System.Data.Sql;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.MigracionACS.DataSetx;

namespace LOSA.MigracionACS.Produccion
{
    public partial class PP_Productions_Orders : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataOperations dp;
      string Codigo, Especie, Descripcion;
        public string ProCodigo
        {
            get {return Codigo;}
            set { Codigo = value; }
        }

        public string EspecieX
        {
            get
            {
                return Especie;
            }
            set
            {
                Especie = value;
            }
        }

        public PP_Productions_Orders()
        {
            InitializeComponent();
            Fill_Data();
            


        }
        public void Fill_Data()
        {
            dp = new DataOperations();
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            string Qry;
            Qry = @"SELECT 
                          Codigo
                         ,Descripcion
                         ,Especie
                    FROM [dbo].[PT_Productos]
                    WHERE Estado = 'a'";
            SqlCommand cmd = new SqlCommand(Qry, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dSProductos.Producto.Clear();
            da.Fill(dSProductos.Producto);

        }


        private void PP_Productions_Orders_Load(object sender, EventArgs e)
        {

        }

        private void gridView_Click(object sender, EventArgs e)
        {
            //var GridView = (GridView)gridControl.FocusedView;
            //var Row = (DSProductos.ProductoRow)GridView.GetFocusedDataRow();
            //ProCodigo = Row.Codigo;
            //EspecieX = Row.especie;
            //Descripcion = Row.Descripcion;
            //labelCodigo.Text = ProCodigo;
            //if (EspecieX == "1")
            //{
            //    labelEspe.Text = "Tilapia";
            //}
            //else
            //{
            //    labelEspe.Text = "Camaron";
            //}

           
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void barCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barEnvioCodigo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (labelCodigo.Text == "...")
            {
                CajaDialogo.Error("Seleccione un producto");
                return;
            }
            else
            {
                ProCodigo = labelCodigo.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void gridView_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
            var GridView = (GridView)gridControl.FocusedView;
            var Row = (DSProductos.ProductoRow)GridView.GetFocusedDataRow();
            ProCodigo = Row.Codigo;
            EspecieX = Row.especie;
            Descripcion = Row.Descripcion;
            labelCodigo.Text = ProCodigo;
                if (EspecieX == "1")
                {
                    labelEspe.Text = "Tilapia";
                }
                else
                {
                    labelEspe.Text = "Camaron";
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            ProCodigo = labelCodigo.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gridControl_Click(object sender, EventArgs e)
        {

        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Fill_Data();
        }
    }
}