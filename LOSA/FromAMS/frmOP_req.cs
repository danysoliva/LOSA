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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraReports.UI;
using ACS.Classes;
using LOSA.Clases;
using LOSA.FromAMS;
namespace AMS.Compras.ControlInv
{
    public partial class frmOP_req : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        int Varid;
        public int typeop = 1;

        public frmOP_req(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            load_codigo();
            load_data();
            grd_usuarios.EditValue = Puser.Id;
            txtsolicitanteManual.Text = Puser.Nombre;
            dtsolicitud.EditValue = DateTime.Now;
        }
        public void load_codigo()
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
        public void load_requisa()
        {
            try
            {
                string query = @"sp_load_req_h";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Varid);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    chManual.Checked = dr.IsDBNull(2) ? true : false;
                    if (chManual.Checked)
                    {
                        txtsolicitanteManual.Text = dr.IsDBNull(0) ? "" : dr.GetString(0);
                        txtsolicitanteManual.Visible = true;
                        grd_usuarios.Visible = false;
                    }
                    else
                    {
                        grd_usuarios.EditValue = dr.IsDBNull(2) ? 0 : dr.GetInt32(2);
                        grd_usuarios.Visible = true;
                        txtsolicitanteManual.Visible = false;
                    }

                    dtsolicitud.EditValue = dr.IsDBNull(3) ? DateTime.Now : dr.GetDateTime(3);
                    txtcomentario.Text = dr.IsDBNull(6) ? "" : dr.GetString(6);
                    txtcodigo.Text = dr.IsDBNull(8) ? "Imposible" : dr.GetString(8);
                    tggenable.IsOn = dr.IsDBNull(5) ? false : dr.GetBoolean(5);
                }
                dr.Close();
                cn.Close();
                cn.Open();
                query = @"sp_load_req_d_V2";
                cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Varid);
                dsControlInv_AMS1.req_detalle.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsControlInv_AMS1.req_detalle);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_data()
        {
            string Query = @"sp_load_user";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsControlInv_AMS1.usuario.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsControlInv_AMS1.usuario);
                cn.Close(); 
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public frmOP_req(UserLogin Puser, int id_req)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            Varid = id_req;
            load_data();
            load_requisa();
            lblenable.Visible = true;
            tggenable.Visible = true;
            typeop = 2;
        }

        private void btncerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void chManual_CheckedChanged(object sender, EventArgs e)
        {
            if (chManual.Checked)
            {
                //grd_usuarios.Visible = false;
                txtsolicitanteManual.Visible = true;
                txtsolicitanteManual.ReadOnly = true;
                txtsolicitanteManual.Text = UsuarioLogeado.Nombre;
                txtsolicitanteManual.Focus();
            }
            else
            {
                grd_usuarios.Visible = true;
                txtsolicitanteManual.Visible = false;
                txtsolicitanteManual.Text = "";
                grd_usuarios.ShowPopup();
            }
        }

        private void grdv_data_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsControlInv_AMS.req_detalleRow)gridView.GetFocusedDataRow();
                if (e.Column.Name == "colcantidad")
                {
                    row.cantidad = Convert.ToDouble(e.Value);
                    dsControlInv_AMS1.req_detalle.AcceptChanges();
                    if (e.Value.ToString() == "0")
                    {
                        row.cantidad = Convert.ToDouble(e.Value);
                        dsControlInv_AMS1.req_detalle.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {


            }
        }
        private bool IsNotActive(GridView view, int row)
        {
            GridColumn col = view.Columns["activo"];
            bool val = Convert.ToBoolean(view.GetRowCellValue(row, col));
            if (val)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void grdv_data_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.FocusedColumn.FieldName == "cantidad" && IsNotActive(view, view.FocusedRowHandle))
            {
                e.Cancel = true;
            }
        }

        private void grdv_data_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool category = Convert.ToBoolean(View.GetRowCellValue(e.RowHandle, View.Columns["activo"]));
                if (!category)
                {
                    e.Appearance.BackColor = Color.FromArgb(62, 62, 66);
                }
            }
        }

        private void btnguardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (dsControlInv_AMS.req_detalleRow row in dsControlInv_AMS1.req_detalle.Rows)
            {
                if (row.existencia == 0)
                {
                    CajaDialogo.Error("Para hacer una requisa con este articulo: " + row.itemname + " la cantidad requerida debe ser menor a la existencia.");
                    return ;
                }
            }
            if (txtcodigo.Text == "")
            {
                CajaDialogo.Error("Mmm... Esto nunca tiene que pasar xd");
                return;
            }
            if (!chManual.Checked)
            {
                if (grd_usuarios.EditValue == null || Convert.ToInt32(grd_usuarios.EditValue) == 0)
                {
                    CajaDialogo.Error("No se ha seleccionado ningun solicitante. Por favor indicarlo!");
                    grd_usuarios.ShowPopup();
                    return;
                }
            }
            else
            {
                if (txtsolicitanteManual.Text == "")
                {
                    CajaDialogo.Error("No se ha destrito ningun solicitante. Por favor indicarlo!");
                    txtsolicitanteManual.Focus();
                    return;
                }
            }
            if (tggenable.IsOn)
            {
                int countItems;
                countItems = grdv_data.RowCount;
                if (countItems == 0)
                {
                    CajaDialogo.Error("Debe de ingresar al menos un articulo para realizar esta operacion");
                    frmpickItems frm = new frmpickItems(1);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        DataRow dr = dsControlInv_AMS1.req_detalle.NewRow();
                        dr[0] = 0;
                        dr[1] = frm.ItemCode;
                        dr[2] = frm.ItemName;
                        dr[3] = 1;
                        dr[4] = 0;
                        dr[5] = true;
                        dsControlInv_AMS1.req_detalle.Rows.Add(dr);
                        dsControlInv_AMS1.req_detalle.AcceptChanges();
                    }
                    return;
                }
            } 
            
            if (txtcomentario.Text == "")
            {
                CajaDialogo.Error("El comentario de la requisa no puede quedar vacio.");
                txtcomentario.Focus();
                return;
            }
            if (typeop == 1) // SUpongamos que es Insertar
            {
                string query = @"sp_insert_req_h";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@solicitante", chManual.Checked ? txtsolicitanteManual.Text : grd_usuarios.Text);
                    cmd.Parameters.AddWithValue("@id_user", UsuarioLogeado.UserId);
                    cmd.Parameters.AddWithValue("@id_solicitante_user", tggcontratista.IsOn ? (object)DBNull.Value :  chManual.Checked ? (object)DBNull.Value : grd_usuarios.EditValue);
                    cmd.Parameters.AddWithValue("@date", dtsolicitud.EditValue);
                    cmd.Parameters.AddWithValue("@info", (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@barcode", txtcodigo.Text);
                    cmd.Parameters.AddWithValue("@comentario", txtcomentario.Text);
                    cmd.Parameters.AddWithValue("@id_contratista", tggcontratista.IsOn ? chManual.Checked ? (object)DBNull.Value : grd_usuarios.EditValue : (object)DBNull.Value);
                    long ResultScalar = 0;
                    ResultScalar = Convert.ToInt64(cmd.ExecuteScalar());
                    if (ResultScalar != 0)
                    {
                        foreach (dsControlInv_AMS.req_detalleRow row in dsControlInv_AMS1.req_detalle.Rows)
                        {
                            query = @"sp_req_insert_details";
                            cmd = new SqlCommand(query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_h", ResultScalar);
                            cmd.Parameters.AddWithValue("@ItemCode", row.itemcode);
                            cmd.Parameters.AddWithValue("@Descripcion", row.itemname);
                            cmd.Parameters.AddWithValue("@Cantidad", row.cantidad);
                            cmd.ExecuteNonQuery();

                        }
                    }

                    CajaDialogo.Information("Transaccion Exitosa!");
                    rpt_requisas report = new rpt_requisas(ResultScalar);
                    report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    ReportPrintTool printReport = new ReportPrintTool(report);
                    printReport.ShowPreview();

                    this.DialogResult = DialogResult.OK;
                    this.Close();


                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }
            }
            else  // Y el ese es update.
            {
                string query = @"sp_update_req_h";
                try
                {
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@solicitante", chManual.Checked ? txtsolicitanteManual.Text : grd_usuarios.Text);
                    cmd.Parameters.AddWithValue("@id_solicitante", tggcontratista.IsOn ? (object)DBNull.Value : chManual.Checked ? (object)DBNull.Value : grd_usuarios.EditValue);
                    cmd.Parameters.AddWithValue("@date_solitud", dtsolicitud.EditValue);
                    cmd.Parameters.AddWithValue("@comentario", txtcomentario.Text);
                    cmd.Parameters.AddWithValue("@enable", tggenable.IsOn ? true : false);
                    cmd.Parameters.AddWithValue("@id_contratista", tggcontratista.IsOn ? chManual.Checked ? (object)DBNull.Value : grd_usuarios.EditValue : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", Varid);
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    query = @"sp_update_req_d";
                    cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_h", Varid);
                    cmd.ExecuteNonQuery();
                    foreach (dsControlInv_AMS.req_detalleRow row in dsControlInv_AMS1.req_detalle.Rows)
                    {

                        if (row.activo)
                        {
                            query = @"sp_req_insert_details";
                            cmd = new SqlCommand(query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_h", Varid);
                            cmd.Parameters.AddWithValue("@ItemCode", row.itemcode);
                            cmd.Parameters.AddWithValue("@Descripcion", row.itemname);
                            cmd.Parameters.AddWithValue("@Cantidad", row.cantidad);
                            cmd.ExecuteNonQuery();
                        }



                    }

                    CajaDialogo.Information("Transaccion Exitosa!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            frmpickItems frm = new frmpickItems(1);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataRow dr = dsControlInv_AMS1.req_detalle.NewRow();
                dr[0] = 0;
                dr[1] = frm.ItemCode;
                dr[2] = frm.ItemName;
                dr[3] = 1;
                dr[4] = true;
                dr[5] = frm.existencia;
                //dr[5] = Obtener_Existencia(frm.ItemCode); ---Asi se consultaba anteriormente
                dsControlInv_AMS1.req_detalle.Rows.Add(dr);
                dsControlInv_AMS1.req_detalle.AcceptChanges();
            }
        }
        public int Obtener_Existencia(string Pitem)
        {
            int result = 0;
            string query = @"sp_obtener_existencia_from_itemcode";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@itemcode", Pitem);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    result = Convert.ToInt32(dr.GetDecimal(0));
                }
                return result;

            }
            catch (Exception ex)
            {
                return 0;                        
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsControlInv_AMS.req_detalleRow)gridView.GetFocusedDataRow();
                if (row.id != 0)
                {
                    if (row.activo)
                    {
                        grdv_data.DeleteRow(grdv_data.FocusedRowHandle);
                        dsControlInv_AMS1.req_detalle.AcceptChanges();
                    }
                    else
                    {
                        if (MessageBox.Show("No se puede eliminar un articulo ya entregado, sin embargo puede pedir autorizacion para hacerlo. \n Desea solicitar autorizacion? ", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            frmUserAuth frm = new frmUserAuth();
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                string Query = @"[dbo].[sp_devolver_inventario]";
                                SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
                                cn.Open();
                                SqlCommand cmd = new SqlCommand(Query, cn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_req", row.id);
                                cmd.Parameters.AddWithValue("@useraut", frm.UserAuth.UserId);
                                cmd.ExecuteNonQuery();
                                grdv_data.DeleteRow(grdv_data.FocusedRowHandle);
                            }
                        }
                    }
                }
                else
                {
                    grdv_data.DeleteRow(grdv_data.FocusedRowHandle);
                }

            }
            catch (Exception ex)
            {


            }
        }
           public void load_contratistas()
        {
            try
            {

                string Query = @"sp_load_contratistas";
                try
                {
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dsControlInv_AMS1.usuario.Clear();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsControlInv_AMS1.usuario);
                    cn.Close();

                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void tggcontratista_Toggled(object sender, EventArgs e)
        {
            if (tggcontratista.IsOn)
            {                     //Si
                load_contratistas();
            }
            else //no
            {
                load_data();
            }
        }

        private void grd_data_Click(object sender, EventArgs e)
        {

        }

        private void frmOP_req_Load(object sender, EventArgs e)
        {

        }

        private void cmdGuardarPoder_Click(object sender, EventArgs e)
        {
            foreach (dsControlInv_AMS.req_detalleRow row in dsControlInv_AMS1.req_detalle.Rows)
            {
                if (row.existencia == 0)
                {
                    CajaDialogo.Error("Para hacer una requisa con este articulo: " + row.itemname + " la cantidad requerida debe ser menor a la existencia.");
                    return;
                }
            }
            if (txtcodigo.Text == "")
            {
                CajaDialogo.Error("Mmm... Esto nunca tiene que pasar xd");
                return;
            }
            if (!chManual.Checked)
            {
                if (grd_usuarios.EditValue == null || Convert.ToInt32(grd_usuarios.EditValue) == 0)
                {
                    CajaDialogo.Error("No se ha seleccionado ningun solicitante. Por favor indicarlo!");
                    grd_usuarios.ShowPopup();
                    return;
                }
            }
            else
            {
                if (txtsolicitanteManual.Text == "")
                {
                    CajaDialogo.Error("No se ha destrito ningun solicitante. Por favor indicarlo!");
                    txtsolicitanteManual.Focus();
                    return;
                }
            }
            if (tggenable.IsOn)
            {
                int countItems;
                countItems = grdv_data.RowCount;
                if (countItems == 0)
                {
                    CajaDialogo.Error("Debe de ingresar al menos un articulo para realizar esta operacion");
                    frmpickItems frm = new frmpickItems(1);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        DataRow dr = dsControlInv_AMS1.req_detalle.NewRow();
                        dr[0] = 0;
                        dr[1] = frm.ItemCode;
                        dr[2] = frm.ItemName;
                        dr[3] = 1;
                        dr[4] = 0;
                        dr[5] = true;
                        dsControlInv_AMS1.req_detalle.Rows.Add(dr);
                        dsControlInv_AMS1.req_detalle.AcceptChanges();
                    }
                    return;
                }
            }

            if (txtcomentario.Text == "")
            {
                CajaDialogo.Error("El comentario de la requisa no puede quedar vacio.");
                txtcomentario.Focus();
                return;
            }
            if (typeop == 1) // SUpongamos que es Insertar
            {
                string query = @"sp_insert_req_h";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@solicitante", chManual.Checked ? txtsolicitanteManual.Text : grd_usuarios.Text);
                    cmd.Parameters.AddWithValue("@id_user", UsuarioLogeado.UserId);
                    cmd.Parameters.AddWithValue("@id_solicitante_user", tggcontratista.IsOn ? (object)DBNull.Value : chManual.Checked ? (object)DBNull.Value : grd_usuarios.EditValue);
                    cmd.Parameters.AddWithValue("@date", dtsolicitud.EditValue);
                    cmd.Parameters.AddWithValue("@info", (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@barcode", txtcodigo.Text);
                    cmd.Parameters.AddWithValue("@comentario", txtcomentario.Text);
                    cmd.Parameters.AddWithValue("@id_contratista", tggcontratista.IsOn ? chManual.Checked ? (object)DBNull.Value : grd_usuarios.EditValue : (object)DBNull.Value);
                    long ResultScalar = 0;
                    ResultScalar = Convert.ToInt64(cmd.ExecuteScalar());
                    if (ResultScalar != 0)
                    {
                        foreach (dsControlInv_AMS.req_detalleRow row in dsControlInv_AMS1.req_detalle.Rows)
                        {
                            query = @"sp_req_insert_details";
                            cmd = new SqlCommand(query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_h", ResultScalar);
                            cmd.Parameters.AddWithValue("@ItemCode", row.itemcode);
                            cmd.Parameters.AddWithValue("@Descripcion", row.itemname);
                            cmd.Parameters.AddWithValue("@Cantidad", row.cantidad);
                            cmd.ExecuteNonQuery();

                        }
                    }

                    CajaDialogo.Information("Transaccion Exitosa!");
                    rpt_requisas report = new rpt_requisas(ResultScalar);
                    report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    ReportPrintTool printReport = new ReportPrintTool(report);
                    printReport.ShowPreview();

                    this.DialogResult = DialogResult.OK;
                    this.Close();


                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }
            }
            else  // Y el ese es update.
            {
                string query = @"sp_update_req_h";
                try
                {
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@solicitante", chManual.Checked ? txtsolicitanteManual.Text : grd_usuarios.Text);
                    cmd.Parameters.AddWithValue("@id_solicitante", tggcontratista.IsOn ? (object)DBNull.Value : chManual.Checked ? (object)DBNull.Value : grd_usuarios.EditValue);
                    cmd.Parameters.AddWithValue("@date_solitud", dtsolicitud.EditValue);
                    cmd.Parameters.AddWithValue("@comentario", txtcomentario.Text);
                    cmd.Parameters.AddWithValue("@enable", tggenable.IsOn ? true : false);
                    cmd.Parameters.AddWithValue("@id_contratista", tggcontratista.IsOn ? chManual.Checked ? (object)DBNull.Value : grd_usuarios.EditValue : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", Varid);
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    query = @"sp_update_req_d";
                    cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_h", Varid);
                    cmd.ExecuteNonQuery();
                    foreach (dsControlInv_AMS.req_detalleRow row in dsControlInv_AMS1.req_detalle.Rows)
                    {

                        if (row.activo)
                        {
                            query = @"sp_req_insert_details";
                            cmd = new SqlCommand(query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_h", Varid);
                            cmd.Parameters.AddWithValue("@ItemCode", row.itemcode);
                            cmd.Parameters.AddWithValue("@Descripcion", row.itemname);
                            cmd.Parameters.AddWithValue("@Cantidad", row.cantidad);
                            cmd.ExecuteNonQuery();
                        }



                    }

                    CajaDialogo.Information("Transaccion Exitosa!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}