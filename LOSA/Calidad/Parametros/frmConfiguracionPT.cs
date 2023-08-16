using DevExpress.XtraEditors;
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
using LOSA.Clases;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Calidad.Parametros
{
    
    public partial class frmConfiguracionPT : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmConfiguracionPT()
        {
            InitializeComponent();
            load_data();
        }
        public void load_data()
        {
            string Query = @"sp_get_finish_product_enables";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsParametros.producto.Clear();
                da.Fill(dsParametros.producto);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadParametros_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsParametros.productoRow)gridView.GetFocusedDataRow();
                int Id_pt;
                string descripcion;
                string codigo;
                Id_pt = row.id;
                descripcion = row.descripcion;
                codigo = row.codigo;
                frmParametrosProducto frm =new frmParametrosProducto(Id_pt,descripcion,codigo);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    load_data();
                }

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void repostDoc_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}