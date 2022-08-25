using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.RecepcionMP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Logistica
{
    public partial class xfrmMP_Reproceso : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLogueado;
        private string ItemCode;

        public xfrmMP_Reproceso(UserLogin pUse)
        {
            InitializeComponent();
            usuarioLogueado = pUse;

            CargarMP();
            cargarDatosProveedor();
            LoadPresentaciones();
            LoadNumeroTransaccion();
            LoadTipoTransaccion();
        }

        private void CargarMP()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();
                    dsLogistica2.MP_Reproceso.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_MP_reproceso", cnx);

                    da.Fill(dsLogistica2.MP_Reproceso);

                    cnx.Close();
                }
            }
            catch (Exception error)
            {
                CajaDialogo.Error(error.Message);
            }
        }

        private void cargarDatosProveedor()
        {
            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL = @"exec sp_get_providersv2";


                dsLogistica2.Proveedores.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);
                adat.Fill(dsLogistica2.Proveedores);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_presentaciones_activas_v3]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRecepcionMPx1.presentaciones.Clear();
                adat.Fill(dsRecepcionMPx1.presentaciones);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadNumeroTransaccion()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                SqlCommand cmm2 = new SqlCommand("dbo.sp_generar_codigo_from_tables_id_V3", con);
                cmm2.CommandType = CommandType.StoredProcedure;
                cmm2.Parameters.AddWithValue("@id", 7);/*-- 7 es Reproceso*/
                string num_ingreso = cmm2.ExecuteScalar().ToString();
                txtNumIngreso.Text = num_ingreso;
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadTipoTransaccion()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tipo_transaccion_kardex", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRecepcionMPx1.Tipo_transacciones_kardex.Clear();
                adat.Fill(dsRecepcionMPx1.Tipo_transacciones_kardex);
                glTipoTransaccion.EditValue = 1;
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(slueMP.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar la Materia Prima!");
                return;
            }


            if (Convert.ToDecimal(txtCantidadT.Text) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una tarima con cantidad de materia en cero (0)!");
                return;
            }

            if (string.IsNullOrEmpty(gridLookUpEditPresentacion.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar la presentacion de la Materia Prima!");
                return;
            }

        
            if (string.IsNullOrEmpty(dtFechaVencimiento.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la fecha de vencimiento de la materia prima!");
                return;
            }


            int cantTarimas = 0;
            try
            {
                cantTarimas = Convert.ToInt32(txtCantidadTarimasTotal.Text);
            }
            catch
            {
            }

            if (cantTarimas <= 0)
            {
                CajaDialogo.Error("La cantidad minima de tarimas debe ser uno(1)!");
                return;
            }


            //generar string de lote
            string lote_string = "Lote(s) PT:";
            foreach (dsLogistica2.lote_selectedRow row in dsLogistica2.lote_selected.Rows)
            {
                lote_string += "  " + row.lote.ToString();
            }


            SqlTransaction transaction;
            int CantGuardo = 0;

            DataOperations dp = new DataOperations();
            SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA);

            connection.Open();

            transaction = connection.BeginTransaction("SampleTransaction");
            //ArrayList Lista = new ArrayList();



            SqlCommand cmd_header = new SqlCommand("sp_insert_ingresos_mp_h_reproceso", transaction.Connection);
            cmd_header.CommandType = CommandType.StoredProcedure;
            cmd_header.Transaction = transaction;
            cmd_header.Parameters.AddWithValue("@numero_transaccion", dp.ValidateNumberInt32(txtNumIngreso.Text));
            cmd_header.Parameters.AddWithValue("@itemcode",this.ItemCode);
            cmd_header.Parameters.AddWithValue("@itemname", slueMP.Text);
            cmd_header.Parameters.AddWithValue("@id_usuario",usuarioLogueado.Id);
            cmd_header.Parameters.AddWithValue("@fecha_ingreso",dtFechaIngreso.EditValue);
            int id_h_ingreso = Convert.ToInt32(cmd_header.ExecuteScalar());

            SqlCommand cmd1 = new SqlCommand("sp_insert_ingresos_V5", transaction.Connection);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Transaction = transaction;
            cmd1.Parameters.AddWithValue("@idheader", id_h_ingreso);
            cmd1.Parameters.AddWithValue("@numero_transaccion", Convert.ToInt32(txtNumIngreso.Text));
            cmd1.Parameters.AddWithValue("@itemcode", this.ItemCode);
            cmd1.Parameters.AddWithValue("@lote_materia_prima", lote_string);
            cmd1.Parameters.AddWithValue("@unidadesxtarima", Convert.ToDecimal(txtCantidadT.Text));
            cmd1.Parameters.AddWithValue("@TotalTarimas", cantTarimas);
            //cmd1.Parameters.AddWithValue("@pesotarima", dp.ValidateNumberDecimal(txtPeso.Text));
            cmd1.Parameters.AddWithValue("@fecha_ingreso", dtFechaIngreso.EditValue);
            cmd1.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);
            int id_ingreso_ = Convert.ToInt32(cmd1.ExecuteScalar());

            for (int i = 1; i <= cantTarimas; i++)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_generar_codigo_from_tables_id_V3", transaction.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaction;
                    cmd.Parameters.AddWithValue("@id", 7); /*7 Es Reproceso*/
                    string barcode = cmd.ExecuteScalar().ToString();

                    SqlCommand cmd2 = new SqlCommand("sp_insert_new_tarima_sin_boleta_mp_v3", transaction.Connection);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Transaction = transaction;
                    cmd2.Parameters.AddWithValue("@itemcode", this.ItemCode);
                    cmd2.Parameters.AddWithValue("@id_proveedor", DBNull.Value);
                    cmd2.Parameters.AddWithValue("@fecha_ingreso", dtFechaIngreso.EditValue);
                    cmd2.Parameters.AddWithValue("@numero_transaccion", txtNumIngreso.Text);
                    cmd2.Parameters.AddWithValue("@fecha_vencimiento", dtFechaVencimiento.EditValue);
                    cmd2.Parameters.AddWithValue("@fecha_produccion_materia_prima", dtFechaProduccion.EditValue);
                    cmd2.Parameters.AddWithValue("@lote_materia_prima", lote_string);
                    cmd2.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);
                    cmd2.Parameters.AddWithValue("@id_usuario", usuarioLogueado.Id);
                    cmd2.Parameters.AddWithValue("@id_tipo_transaccion_kardex", glTipoTransaccion.EditValue);
                    cmd2.Parameters.AddWithValue("@codigo_barra", barcode);
                    cmd2.Parameters.AddWithValue("@cant", txtCantidadT.Text);
                    cmd2.Parameters.AddWithValue("@peso", txtPeso.Text);
                    cmd2.Parameters.AddWithValue("@id_ingreso", id_ingreso_); //Ingreso de Reproceso
                    cmd2.ExecuteNonQuery();

                    CantGuardo++;

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                    transaction.Rollback();
                }
            }

          
            if (CantGuardo > 0)
            {
                CajaDialogo.Information("Datos guardados exitosamente!");
                this.Close();
            }
        }

        private void slueMP_EditValueChanged(object sender, EventArgs e)
        {
           
             this.ItemCode = slueMP.EditValue.ToString();

        }

        private void gridLookUpEditPresentacion_EditValueChanged(object sender, EventArgs e)
        {
            if (gridLookUpEditPresentacion.EditValue == null)
                return;

            var id_pres = gridLookUpEditPresentacion.EditValue;
            foreach (dsRecepcionMPx.presentacionesRow row in dsRecepcionMPx1.presentaciones.Rows)
            {
                if(row.id == Convert.ToInt32(id_pres))
                {
                    decimal Factor = row.factor;
                    decimal peso = Factor * txtCantidadT.Value;
                    txtPeso.Text = string.Format("{0:###,##0.00}", peso);
                    break;
                }
            }
        }

        private void txtCantidadT_EditValueChanged(object sender, EventArgs e)
        {
            if (gridLookUpEditPresentacion.EditValue == null)
                return;

            var id_pres = gridLookUpEditPresentacion.EditValue;
            foreach (dsRecepcionMPx.presentacionesRow row in dsRecepcionMPx1.presentaciones.Rows)
            {
                if (row.id == Convert.ToInt32(id_pres))
                {
                    decimal Factor = row.factor;
                    decimal peso = Factor * txtCantidadT.Value;
                    txtPeso.Text = string.Format("{0:###,##0.00}", peso);
                    break;
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Buscar Lote
            xfrmBuscarLotePT frm = new xfrmBuscarLotePT();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                dsLogistica2.lote_selected.Clear();
                foreach (int LoteSelected in frm.ListaLotesInt)
                {
                    dsLogistica2.lote_selectedRow rowLoteNew = dsLogistica2.lote_selected.Newlote_selectedRow();
                    rowLoteNew.lote = LoteSelected;
                    dsLogistica2.lote_selected.Addlote_selectedRow(rowLoteNew);
                    dsLogistica2.AcceptChanges();
                }
            }
        }

        private void xfrmMP_Reproceso_Load(object sender, EventArgs e)
        {

        }
    }
}