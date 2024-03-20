using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using ACS.Classes;
using LOSA.Clases;
using LOSA.FromAMS;

namespace AMS.Compras.ControlInv
{
    public partial class frmrequisa_devolucion : DevExpress.XtraEditors.XtraForm
    {
        Requisicion RequisicionActual = new Requisicion();
        DataOperations dp = new DataOperations();
        RequisaArticulos requisicion = new RequisaArticulos();
        UserLogin UsuarioLogeado;
        public int VarId;
        string Msj;
        int hasError;

        public frmrequisa_devolucion(UserLogin Puser, int id_req)
        {                    
            InitializeComponent();
            UsuarioLogeado = Puser;
            requisicion.RecuperarRegistro(id_req);
            load_informacion(id_req);
            load_details(id_req);
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (!string.IsNullOrEmpty(txtcodigo.Text))
            //    {
            //        if (RequisicionActual.RecuperarRegistroFromBarcode(txtcodigo.Text.Trim()))
            //        {
            //            //pictureBoxIndicadorOk.Visible = true;
            //            //txtReq.Text = RequisicionActual.IdRequisicion.ToString();
            //            VarId = RequisicionActual.IdRequisicion;
            //            load_informacion(RequisicionActual.IdRequisicion);
            //            load_details(VarId);
            //        }
            //        else
            //        {
            //            CajaDialogo.Error("No se ha encontrado ninguna requisa.");
            //            txtcodigo.Focus();
            //        }
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("Informacion de Requsa no disponible.");
            //        txtcodigo.Focus();
            //    }
            //}
        }

        public void load_details(int id_req)
        {
            string Query = @"[dbo].[sp_load_componentes_of_req_d_V2]";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_req", id_req);
                dsControlInv_AMS1.req_devolucion.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsControlInv_AMS1.req_devolucion);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_informacion(int id)
        {
            string Query = @"[dbo].[sp_load_informacion_req]";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_req", id);
                dsControlInv_AMS1.informacion.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsControlInv_AMS1.informacion);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frm_buscar_req frm = new frm_buscar_req();

            if (frm.ShowDialog()== DialogResult.OK)
            {
              
            }
        }

        private void btnsave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //foreach (dsControlInv.componentes2Row row in dsControlInv.componentes.Rows)
                foreach (dsControlInv_AMS.req_devolucionRow row in dsControlInv_AMS1.req_devolucion.Rows)
                {
                    if (row.entregado < row.devolucion)
                    {
                        Msj = "Una de las lineas la cantidad a enviar es Mayor que la existencia.";
                        hasError = 1;
                        break;
                    }
                }
              
                string query = @"dbo.uspInsertDevolucionRequisa";
                bool guadado = false;
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
                this.labelControl1.Focus();
                cn.Open();
                foreach (dsControlInv_AMS.req_devolucionRow row2 in dsControlInv_AMS1.req_devolucion.Rows)
                {
                    if (row2.devolucion != 0)
                    {
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ItemCode", row2.ItemCode);
                        cmd.Parameters.AddWithValue("@cantidad", row2.devolucion);
                        cmd.Parameters.AddWithValue("@id_req_articulos", row2.id);
                        cmd.Parameters.AddWithValue("@id_user", UsuarioLogeado.UserId);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                        cmd.Parameters.AddWithValue("@tipo_transaccion", 2);
                        cmd.ExecuteNonQuery();
                        guadado = true;
                }

            }
                cn.Close();
                if (guadado==true)
                {
                    CajaDialogo.Information("Se ha entregado exitosamente los articulos o repuestos.");
                }
                else
                {

                    CajaDialogo.Information("No se pudo guardar la devolucion");
                }
                this.Close();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdv_repuestos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_repuestos.FocusedView;
                var row = (dsControlInv_AMS.req_devolucionRow)gridView.GetFocusedDataRow();
                if (e.Column.FieldName == "devolucion")
                {
                    if (row.entregado==0)
                    {
                        row.devolucion = 0;
                        CajaDialogo.Error("No se puede realizar la devolucion del repuesto ya que no se ha entregado ningun repuesto a esta requisa");
                    }

                    if (row.devolucion > row.entregado)
                    {
                        row.devolucion = 0;
                        dsControlInv_AMS1.req_devolucion.AcceptChanges();
                        CajaDialogo.Error("Lo devuelto no puede ser mayor que lo entregado");
                        return;
                    }

                }
                dsControlInv_AMS1.req_devolucion.AcceptChanges();
                }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void frmrequisa_devolucion_Load(object sender, EventArgs e)
        {
            //txtReq.Text = requisicion.ID.ToString();
            //VarId = RequisicionActual.IdRequisicion;
            //load_informacion(RequisicionActual.IdRequisicion);
            //load_details(VarId);
        }

        private void grdv_repuestos_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_repuestos.FocusedView;
                var row = (dsControlInv_AMS.req_devolucionRow)gridView.GetFocusedDataRow();
                if (e.Column.FieldName == "devolucion")
                {
                    if (row.entregado == 0)
                    {
                        row.devolucion = 0;
                        CajaDialogo.Error("No se puede realizar la devolucion del repuesto ya que no se ha entregado ningun repuesto a esta requisa");
                    }

                    if (row.devolucion > row.entregado)
                    {
                        row.devolucion = 0;
                        dsControlInv_AMS1.req_devolucion.AcceptChanges();
                        CajaDialogo.Error("Lo devuelto no puede ser mayor que lo entregado");
                        return;
                    }

                }
                dsControlInv_AMS1.req_devolucion.AcceptChanges();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}