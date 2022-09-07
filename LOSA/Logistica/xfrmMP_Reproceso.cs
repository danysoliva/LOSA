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

            foreach (dsLogistica2.lote_selectedRow row in dsLogistica2.lote_selected.Rows)
            {
                if (dsLogistica2.lote_selected.Count == 0)
                {
                    CajaDialogo.Error("Debe seleccionar un Lote de Producto Terminado");
                    return;
                }
            }

            if (string.IsNullOrEmpty(slueMP.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar la Materia Prima!");
                return;
            }

            if (string.IsNullOrEmpty(dtFechaIngreso.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la fecha de ingreso de la materia prima!");
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

            if (string.IsNullOrEmpty(dtFechaProduccion.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la fecha de produccion de la materia prima!");
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
            string lote_string = "";
            foreach (dsLogistica2.lote_selectedRow row in dsLogistica2.lote_selected.Rows)
            {
                lote_string =  row.lote.ToString();
            }


            //SqlTransaction transaction;
            int CantGuardo = 0;

            DataOperations dp = new DataOperations();
            //SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA);

           

            
            //ArrayList Lista = new ArrayList();

            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction("SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {


                    //SqlCommand cmd_header = new SqlCommand("sp_insert_ingresos_mp_h_reproceso", connection);
                    command.CommandText = "sp_insert_ingresos_mp_h_reproceso";
                    //command.CommandType = CommandType.StoredProcedure;
                    //command.Transaction = transaction;
                    command.Parameters.AddWithValue("@numero_transaccion", dp.ValidateNumberInt32(txtNumIngreso.Text));
                    command.Parameters.AddWithValue("@itemcode", this.ItemCode);
                    command.Parameters.AddWithValue("@itemname", slueMP.Text);
                    command.Parameters.AddWithValue("@id_usuario", usuarioLogueado.Id);
                    command.Parameters.AddWithValue("@fecha_ingreso", dtFechaIngreso.EditValue);
                    //int id_h_ingreso = Convert.ToInt32(command.ExecuteScalar());
                    int id_h_ingreso = 0;
                    using (SqlDataReader drx1 = command.ExecuteReader())
                    {
                        if (drx1.Read())
                        {
                            if (!drx1.IsDBNull(drx1.GetOrdinal("id")))
                                id_h_ingreso = drx1.GetInt32(0);
                        }
                    }
                    //drx1.Close();

                    //command = new SqlCommand("sp_insert_ingresos_V5", connection);
                    command.Parameters.Clear();
                    command.CommandText = "sp_insert_ingresos_V6";
                    //command.CommandType = CommandType.StoredProcedure;
                    //command.Transaction = transaction;
                    command.Parameters.AddWithValue("@idheader", id_h_ingreso);
                    command.Parameters.AddWithValue("@numero_transaccion", Convert.ToInt32(txtNumIngreso.Text));
                    command.Parameters.AddWithValue("@itemcode", this.ItemCode);
                    command.Parameters.AddWithValue("@lote_materia_prima", lote_string);
                    LotePT LotePT = new LotePT();
                    LotePT.RecuperarRegistro(Convert.ToInt32(lote_string));
                    int idptReproceso = LotePT.id_pt;
                    string OrderCodepp = LotePT.OrderCodePP;

                    command.Parameters.AddWithValue("@unidadesxtarima", txtCantidadT.EditValue);
                    command.Parameters.AddWithValue("@TotalTarimas", cantTarimas);
                    //command.Parameters.AddWithValue("@pesotarima", dp.ValidateNumberDecimal(txtPeso.Text));
                    command.Parameters.AddWithValue("@fecha_ingreso", dtFechaIngreso.EditValue);
                    command.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);
                    command.Parameters.AddWithValue("@idptReproceso", idptReproceso);
                    command.Parameters.AddWithValue("@OrderCodepp", OrderCodepp);
                    int id_ingreso_ = 0;

                    SqlDataReader drx = command.ExecuteReader();
                    if (drx.Read())
                    {
                        if (!drx.IsDBNull(drx.GetOrdinal("id_lote")))
                            id_ingreso_ = drx.GetInt32(0);
                    }
                    drx.Close();


                    for (int i = 1; i <= cantTarimas; i++)
                    {
                        //try
                        //{
                        //SqlCommand cmd = new SqlCommand("sp_generar_codigo_from_tables_id_V3", connection);
                        command.Parameters.Clear();
                        command.CommandText = "sp_generar_codigo_from_tables_id_V3";
                        //command.CommandType = CommandType.StoredProcedure;
                        //command.Transaction = transaction;
                        command.Parameters.AddWithValue("@id", 1); /*Ingreso */
                        string barcode = command.ExecuteScalar().ToString();

                        //SqlCommand command = new SqlCommand("sp_insert_new_tarima_sin_boleta_mp_v3", connection);
                        //command.CommandType = CommandType.StoredProcedure;
                        //command.Transaction = transaction;
                        command.CommandText = "sp_insert_new_tarima_sin_boleta_mp_v3";
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@itemcode", this.ItemCode);
                        command.Parameters.AddWithValue("@id_proveedor", DBNull.Value);
                        command.Parameters.AddWithValue("@fecha_ingreso", dtFechaIngreso.EditValue);
                        command.Parameters.AddWithValue("@numero_transaccion", txtNumIngreso.Text);
                        command.Parameters.AddWithValue("@fecha_vencimiento", dtFechaVencimiento.EditValue);
                        command.Parameters.AddWithValue("@fecha_produccion_materia_prima", dtFechaProduccion.EditValue);
                        command.Parameters.AddWithValue("@lote_materia_prima", lote_string);
                        command.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);
                        command.Parameters.AddWithValue("@id_usuario", usuarioLogueado.Id);
                        command.Parameters.AddWithValue("@id_tipo_transaccion_kardex", glTipoTransaccion.EditValue);
                        command.Parameters.AddWithValue("@codigo_barra", barcode);
                        command.Parameters.AddWithValue("@cant", txtCantidadT.EditValue);
                        command.Parameters.AddWithValue("@peso", Convert.ToDecimal(txtPeso.Text));
                        command.Parameters.AddWithValue("@id_ingreso", id_ingreso_); //Ingreso de Reproceso
                        command.ExecuteNonQuery();

                        CantGuardo++;

                    }

                    transaction.Commit();
                    connection.Close();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    CajaDialogo.Error(ex.Message);
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

                if (dsLogistica2.lote_selected.Count != 0)
                {
                    int LoteSelc = 0;
                    foreach (dsLogistica2.lote_selectedRow row2 in dsLogistica2.lote_selected.Rows)
                    {
                        LoteSelc = row2.lote;
                    }

                    LotePT infoPT = new LotePT();
                    infoPT.RecuperarRegistro(LoteSelc);

                    if (infoPT.especie == 1)//Tilapia
                    {
                        foreach (dsLogistica2.MP_ReprocesoRow row3 in dsLogistica2.MP_Reproceso.Rows)
                        {
                            slueMP.EditValue = "MP00080";
                              
                        }
                        ItemCode = Convert.ToString(slueMP.EditValue);

                    }
                    else
                    {
                        foreach (dsLogistica2.MP_ReprocesoRow row3 in dsLogistica2.MP_Reproceso.Rows)
                        {
                            
                            slueMP.EditValue = "MP00081";

                        }
                        ItemCode = Convert.ToString(slueMP.EditValue);
                    }
                }
            }
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }
    }
}