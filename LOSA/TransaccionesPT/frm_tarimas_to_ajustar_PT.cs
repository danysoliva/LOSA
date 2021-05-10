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
using ACS.Classes;
using LOSA.Clases;

namespace LOSA.TransaccionesPT
{
    
    public partial class frm_tarimas_to_ajustar_PT : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int id_ajuste;
        UserLogin UsuarioLogeado;
        public enum TipoOp
        {
                Nuevo,
                Editar
        }
        TipoOp Op;
        public frm_tarimas_to_ajustar_PT(UserLogin Puser, int Pid, TipoOp Pop)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            id_ajuste = Pid;
            Op = Pop;
            load_presentacion();
            load_informacion();

            if (Op == TipoOp.Nuevo)
            {
                load_data();

            }
            else
            {
                load_data();
            }

        }
        
        public void load_presentacion() 
        {
            string query = @"sp_get_presentaciones_activas";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsPT.presentacion.Clear();
                da.Fill(dsPT.presentacion);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_informacion() 
        {
            string query = @"sp_obtener_pt_in_inventario";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsPT.ProductoPT.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPT.ProductoPT);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_prev_confi()
        {
            string query = @"sp_load_tarimas_pt_to_ajustar_edit";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsPT.AjusteInv_Detalle.Clear();
                da.Fill(dsPT.AjusteInv_Detalle);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }
        public  void load_data() 
        {
            string query = @"sp_load_tarimas_pt_to_ajustar_new";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsPT.AjusteInv_Detalle.Clear();
                da.Fill(dsPT.AjusteInv_Detalle);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message) ;
            }
        }
        private void frm_tarimas_to_ajustar_PT_Load(object sender, EventArgs e)
        {

        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                grdv_data.FindFilterText = txtubicacion.Text;
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {

        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            grdv_data.FindFilterText = txtubicacion.Text;
        }

        private void grd_producto_EditValueChanged(object sender, EventArgs e)
        {
            //grdv_data.FindFilterText = grd_producto.EditValue.ToString();
        }

        private void grdv_data_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "colid_presentacion":    //presentacion
                    break;
                case "coldel":                                    //eliminar
                    break;
                case "colPor_lote":
                    break;
                case "colcantidad":
                    break;
                case "colpeso":
                    break;
                default:
                    break;
            }
        }
    }
}