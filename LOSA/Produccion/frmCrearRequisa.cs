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
using ACS.Classes;
using LOSA.Produccion;
using LOSA.Clases;
using System.Data.SqlClient;
using LOSA.Calidad.LoteConfConsumo;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Produccion
{
    public partial class frmCrearRequisa : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        int id_requisa = 0;

        public frmCrearRequisa(UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLog;
            load_codigo();

            dtsolicitud.EditValue = dp.Now();
        }

        private void load_codigo()
        {
            SqlConnection con = new SqlConnection(dp.ConnectionStringAMS);
            con.Open();
            SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", con);
            cmm.CommandType = CommandType.StoredProcedure;
            cmm.Parameters.AddWithValue("@tipo_Equipo", 2);
            string barcode = cmm.ExecuteScalar().ToString();
            txtcodigo.Text = barcode;
            con.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            //int TipoRequisa = 2; //Reuisa de Material de Empaque
            frmSearchMP frm = new frmSearchMP(frmSearchMP.TipoBusqueda.MaterialEmpaque);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataRow dr = dsMaterialEmpaque1.req_detalle.NewRow();
                dr[0] = 0;
                dr[1] = frm.ItemSeleccionado.ItemCode;
                dr[2] = frm.ItemSeleccionado.ItemName;
                dr[3] = 1;
                dr[4] = true;
                dr[5] = obtener_existencia_en_almacen(frm.ItemSeleccionado.ItemCode);
                dsMaterialEmpaque1.req_detalle.Rows.Add(dr);
                dsMaterialEmpaque1.req_detalle.AcceptChanges();
            }
        }

        private object obtener_existencia_en_almacen(string pitemCode)
        {
            int result = 0;
            string sql = @"sp_get_kardex_me_for_itemcode";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@itemcode", pitemCode);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    result = Convert.ToInt32(dr.GetInt32(0));
                }
                return result;

            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        private void btn_eliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsMaterialEmpaque.req_detalleRow)gridView.GetFocusedDataRow();
            
            try
            {
                grdv_data.DeleteRow(grdv_data.FocusedRowHandle);
                dsMaterialEmpaque1.req_detalle.AcceptChanges();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCrearRequisa_Click(object sender, EventArgs e)
        {
            foreach (dsMaterialEmpaque.req_detalleRow item in dsMaterialEmpaque1.req_detalle.Rows)
            {
                if (item.existencia < item.cantidad)
                {
                    CajaDialogo.Error("No puede requisar mas de lo existente, ME: " + item.itemcode);
                    return;
                }
            }

            if (string.IsNullOrEmpty(txtsolicitanteManual.Text))
            {
                CajaDialogo.Error("Debe especificar el solicitante de la Requisa");
                return;
            }

            if (comboTurno.Text == "")
            {
                CajaDialogo.Error("Debe seleccionar un Turno");
                return;
            }

            SqlTransaction TransactionIngreso = null;
            SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
            bool Guardo = false;

            try
            {
                cn.Open();
                TransactionIngreso = cn.BeginTransaction("Transction Order");

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "sp_insert_requisa_h_me";
                cmd.Connection = cn;
                cmd.Transaction = TransactionIngreso;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_user_create", UsuarioLogeado.UserId);
                cmd.Parameters.AddWithValue("@comentario", txtcomentario.Text);
                //cmd.Parameters.AddWithValue("@id_user_solicitante", grd_usuarios.EditValue);
                cmd.Parameters.AddWithValue("@fecha_solicitud", dtsolicitud.EditValue);
                cmd.Parameters.AddWithValue("@codigo_barra", txtcodigo.Text.Trim());
                cmd.Parameters.AddWithValue("@turno", comboTurno.Text.Trim());
                cmd.Parameters.AddWithValue("@solicitante_prd", txtsolicitanteManual.Text);
                int IdHeaderInserted = Convert.ToInt32(cmd.ExecuteScalar());

                foreach (dsMaterialEmpaque.req_detalleRow item in dsMaterialEmpaque1.req_detalle.Rows)
                {
                    string query2 = @"sp_insert_requisa_d_me";
                    SqlCommand cmd2 = cn.CreateCommand();
                    cmd2.CommandText = query2;
                    cmd2.Connection = cn;
                    cmd2.Transaction = TransactionIngreso;
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@id_requisa_h", IdHeaderInserted);
                    cmd2.Parameters.AddWithValue("@id_me", item.id);
                    cmd2.Parameters.AddWithValue("@itemcode", item.itemcode);
                    cmd2.Parameters.AddWithValue("@cantidad", item.cantidad);
                    //cmd2.Parameters.AddWithValue("@lote", );
                    cmd2.ExecuteNonQuery();
                }

                string code_update = @"sp_update_me_requisicion_code_bar";
                SqlCommand cmd3 = cn.CreateCommand();
                cmd3.CommandText = code_update;
                cmd3.Connection = cn;
                cmd3.Transaction = TransactionIngreso;
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.ExecuteNonQuery();

                TransactionIngreso.Commit();
                Guardo = true;

            }
            catch (Exception ec)
            {
                TransactionIngreso.Rollback();
                CajaDialogo.Error(ec.Message);
                Guardo = false;
            }

            cn.Close();

            if (Guardo)
            {
                CajaDialogo.Information("Requisa Creada!");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}