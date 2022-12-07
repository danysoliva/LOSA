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
using LOSA.Clases;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.RecepcionMP
{
    public partial class frm_edit_data : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int Id_ingreso;
        public string Itemcode;
        public string Dscripcion;
        public string pv;
        public string cardcode;
        public DateTime fecha_creacion;
        UserLogin UsuarioLogeado;
        public frm_edit_data(int Pingreso, DateTime pfecha_creacion, UserLogin pUserLogin, int pid_traslado)
        {
            InitializeComponent();
            if (pid_traslado == 0)
            {
                btnfindMP.Visible = true;
                buttonEdit1.Visible = true;
            }
            UsuarioLogeado = pUserLogin;
            Id_ingreso = Pingreso;
            load_data();
            load_detalle_lote();
            fecha_creacion = pfecha_creacion;
        }

        public void load_detalle_lote()
        {
            string query = @"sp_load_lotes_ingresos";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsingresos.detalle_lote.Clear();
                da.Fill(dsingresos.detalle_lote);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_data()
        {
            string query = @"sp_load_info_ingreso_to_edit";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso" , Id_ingreso);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Itemcode = dr.GetString(1);
                    Dscripcion = dr.GetString(2);
                    pv = dr.GetString(3);
                    cardcode = dr.GetString(4);
                    txtBoleta.Text = dr.GetInt32(5).ToString();
                    txtmp.Text = Dscripcion;
                    txtproveedor.Text = pv;
                }

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfindMP_EditValueChanged(object sender, EventArgs e)
        {
            frmMP frm = new frmMP();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Itemcode = frm.ItemCode;
                Dscripcion = frm.MateriaPrima;
                txtmp.Text = Dscripcion;
            }
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {
            frm_select_pv frm = new frm_select_pv();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                pv = frm.pv;
                cardcode = frm.Cardcode;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmp.Text == "")
                {
                    CajaDialogo.Error("Debe seleccionar una materia prima.");
                    return;
                }
                if (txtproveedor.Text == "")
                {
                    CajaDialogo.Error("Debe seleccionar un proveedor.");
                    return;
                }
                if (txtBoleta.Text == "")
                {
                    CajaDialogo.Error("La boleta no puede quedar vacia.");
                    return;
                }

                string query = @"sp_update_data_ingreso_header";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn );
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id" , Id_ingreso);
                cmd.Parameters.AddWithValue("@itemcode", Itemcode);
                cmd.Parameters.AddWithValue("@dscripcion", Dscripcion);
                cmd.Parameters.AddWithValue("@pv", pv);
                cmd.Parameters.AddWithValue("@cardcode", cardcode);
                cmd.Parameters.AddWithValue("@boleta", txtBoleta.Text);
                cmd.ExecuteNonQuery();

                foreach (dsingresos.detalle_loteRow row in dsingresos.detalle_lote.Rows)
                {
                    if (row.seleccionado)
                    {
                        query = @"sp_update_todas_las_tarimas";
                        cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_ingreso_d", row.id);
                        cmd.Parameters.AddWithValue("@itemcode", Itemcode);
                        cmd.Parameters.AddWithValue("@dscripcion", Dscripcion);
                        cmd.Parameters.AddWithValue("@cardcode", cardcode);
                        cmd.Parameters.AddWithValue("@boleta", txtBoleta.Text);
                        cmd.ExecuteNonQuery();
                    }

                }
                //

                CajaDialogo.Information("Cambio realizado.!");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnfindMP_Click(object sender, EventArgs e)
        {
            frmMP frm = new frmMP();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Itemcode = frm.ItemCode;
                Dscripcion = frm.MateriaPrima;
                txtmp.Text = Dscripcion;
            }
        }

        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            frm_select_pv frm = new frm_select_pv();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                pv = frm.pv;
                cardcode = frm.Cardcode;
            }
        }

        private void tgTodos_Toggled(object sender, EventArgs e)
        {
            if (tgTodos.IsOn)
            {
                foreach (dsingresos.detalle_loteRow row in dsingresos.detalle_lote.Rows)
                {
                    row.seleccionado = false;
                }
                dsingresos.detalle_lote.AcceptChanges();
            }
            else
            {
                foreach (dsingresos.detalle_loteRow row in dsingresos.detalle_lote.Rows)
                {
                    row.seleccionado = true;
                }
                dsingresos.detalle_lote.AcceptChanges();
            }
        }

        private void grdv_data_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsingresos.detalle_loteRow)gridView.GetFocusedDataRow();
                if (e.Column.Name == "colseleccionado")
                {
                    row.seleccionado = Convert.ToBoolean(e.Value);
                }
                row.AcceptChanges();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void repositoryItemButtonEditarLote_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grd_data.FocusedView;
            var row = (dsingresos.detalle_loteRow)gridview.GetFocusedDataRow();

            TimeSpan diasaprox = dp.Now() - fecha_creacion;

            int Dias = Convert.ToInt32(diasaprox.Days);

            if (Dias > 5)//Si es mayor que 1, la tarima lleve mas de dos dias en la bodega.
            {
                CajaDialogo.Error("No puede editar lote que tengan mas de dos dias de ingreso.");
                return;
            }

            try
            {
                frm_edit_lote frm = new frm_edit_lote(row.lote, row.numero_transaccion, UsuarioLogeado);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    load_data();
                    load_detalle_lote();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}