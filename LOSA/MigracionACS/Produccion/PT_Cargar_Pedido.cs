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
using System.Data.Sql;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.MigracionACS.DataSetx;

namespace LOSA.MigracionACS.Produccion
{
    public partial class PT_Cargar_Pedido : DevExpress.XtraBars.Ribbon.RibbonForm
    { DataOperations dp;
        int id_Pedido;

        public int Id_Pedido
        {
            get { return id_Pedido; }
            set { id_Pedido = value; }
        }

        public PT_Cargar_Pedido()
        {
            InitializeComponent();
            refresh_grid();


        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();

        }

        private void PT_Cargar_Pedido_Load(object sender, EventArgs e)
        {

        }
   

        private void gridView_Click(object sender, EventArgs e)
        {
            //var GridView = (GridView)gridControl.FocusedView;
            //var row = (DSProductos.PedidoRow)GridView.GetFocusedDataRow();
            //int id = Convert.ToInt32(row.id_Pedido);
            //labelPedido.Text = Convert.ToString(id);
        }

        private void gridView_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                var GridView = (GridView)gridControl.FocusedView;
                var row = (DSProductos.PedidoRow)GridView.GetFocusedDataRow();
                int id = Convert.ToInt32(row.id_Pedido);
                labelPedido.Text = Convert.ToString(id);
            }
            catch (Exception)
            {

            
            }
          
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            refresh_grid();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Id_Pedido = Convert.ToInt32(labelPedido.Text); 
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void barToggleMostar_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Tooglerefell();
          
            
        }
        void Tooglerefell()
        {
            refresh_grid();
        }
        void refresh_grid()
        {
            
            if (barToggleMostar.Checked == true)
            {
                try
                {
                    string FixedQuery = @"SELECT [id_Pedido]
                              ,[fecha_ini] 
                              ,[fecha_fin]
                              ,coalesce ([Numero] , ' ') as Numero
                              ,[enable]
							  , CASE WHEN	[enable] = 1 Then
								'Habilitado'
								else
								'Inhabilitado'
								end as Estado
                              ,coalesce ([semana_num] , 0) as semana_num
                          FROM [dbo].[PT_Pedido]
                            order by 1 desc";



                    DataOperations dp = new DataOperations();
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                    conn.Open();
                    SqlDataAdapter Da = new SqlDataAdapter(FixedQuery, conn);
                  dSProductos.Pedido.Clear();
                    Da.Fill(dSProductos.Pedido);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (barToggleMostar.Checked == false)
            {
                try
                {
                    string FixedQuery = @"SELECT [id_Pedido]
                              ,[fecha_ini] 
                              ,[fecha_fin]
                              ,coalesce ([Numero] , ' ') as Numero
                              ,[enable]
							  , CASE WHEN	[enable] = 1 Then
								'Habilitado'
								else
								'Inhabilitado'
								end as Estado
                              ,coalesce ([semana_num] , 0) as semana_num
                          FROM [dbo].[PT_Pedido]
                            where  enable = 1
                            order by 1 desc";



                    DataOperations dp = new DataOperations();
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                    conn.Open();
                    SqlDataAdapter Da = new SqlDataAdapter(FixedQuery, conn);
                    dSProductos.Pedido.Clear();
                    Da.Fill(dSProductos.Pedido);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void barToggleMostar_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            Tooglerefell();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            var GridView = (GridView)gridControl.FocusedView;
            var row = (DSProductos.PedidoRow)GridView.GetFocusedDataRow();
            int id = Convert.ToInt32(row.id_Pedido);
            labelPedido.Text = Convert.ToString(id);
            try
            {
                Id_Pedido = Convert.ToInt32(labelPedido.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


        }
    }
}