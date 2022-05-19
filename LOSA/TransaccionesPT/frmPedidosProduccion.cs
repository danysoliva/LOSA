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

namespace LOSA.TransaccionesPT
{
    public partial class frmPedidosProduccion : DevExpress.XtraEditors.XtraForm
    {

        DataOperations dp = new DataOperations();
        string Codigo, Especie;
        int ID_Pedido;
        string file_name;
        string ActiveUserCode, ActiveUserName, ActiveUserType;
        string SAPuser, sappass = "";
        int id, type;

        public frmPedidosProduccion()
        {
            InitializeComponent();
            load_data();
        }
        public void load_data()
        {
            try
            {
                string FixedQuery = @"sp_get_pedidos_of_data";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(FixedQuery, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                dsProductos.Pedido.Clear();
                Da.Fill(dsProductos.Pedido);
                conn.Close();
            }  
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void frmPedidosProduccion_Load(object sender, EventArgs e)
        {

        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadClasesAdicional()
        {
            try
            {
                string Qry = @"select 1 as id,
                               'Si' as descripcion
                        union all

                        select 0 as id,
                              'No' as descripcion;";
                SqlConnection CN = new SqlConnection(dp.ConnectionStringCostos);
                CN.Open();
                SqlCommand cmd = new SqlCommand(Qry, CN);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProductos.clase.Clear();
                adat.Fill(dsProductos.clase);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_load_presentacion_pt]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsProductos.presentaciones.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductos.presentaciones);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        
        public void load_EditTilapia()
        {
            dp = new DataOperations();
            string Query;
            Query = @"EXEC [dbo].[LlenadoDePedidoTilapia] @Id_Pedido = " + ID_Pedido;

            SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dsProductos.PedidoDetalleTilapia.Clear();
            da.Fill(dsProductos.PedidoDetalleTilapia);
            con.Close();
        }
        public void load_EditCamaron()
        {
            dp = new DataOperations();
            string Query;
            Query = @"EXEC [dbo].[LlenadoDePedidoCamaron] @Id_Pedido = " + ID_Pedido;

            SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dsProductos.PedidoDetalle.Clear();
            da.Fill(dsProductos.PedidoDetalle);
            con.Close();
        }
        private void grd_select_pedido_EditValueChanged(object sender, EventArgs e)
        {
            if (grd_select_pedido.EditValue != null)
            {

                ID_Pedido = Convert.ToInt32(grd_select_pedido.EditValue);
                load_EditCamaron();
                load_EditTilapia();
            }
        }
    }
}