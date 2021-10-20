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
                SqlCommand cmm2 = new SqlCommand("sp_generar_codigo_from_tables_id", con);
                cmm2.CommandType = CommandType.StoredProcedure;
                cmm2.Parameters.AddWithValue("@id", 2);
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

            //if (string.IsNullOrEmpty(txtLote.Text))
            //{
            //    CajaDialogo.Error("Es obligatorio llenar el lote para la tarima!");
            //    return;
            //}

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
            

            int CantGuardo = 0;
            //ArrayList Lista = new ArrayList();
            for (int i = 1; i <= cantTarimas; i++)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();

                    SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", con);
                    cmm.CommandType = CommandType.StoredProcedure;
                    cmm.Parameters.AddWithValue("@id", 1);
                    string barcode = cmm.ExecuteScalar().ToString();

                    

                    SqlCommand cmd = new SqlCommand("sp_insert_new_tarima_sin_boleta_mp", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@itemcode", this.ItemCode);
                    cmd.Parameters.AddWithValue("@id_proveedor", DBNull.Value);
                    cmd.Parameters.AddWithValue("@fecha_ingreso", dtFechaIngreso.EditValue);
                    cmd.Parameters.AddWithValue("@numero_transaccion", txtNumIngreso.Text);
                    cmd.Parameters.AddWithValue("@fecha_vencimiento", dtFechaVencimiento.EditValue);
                    cmd.Parameters.AddWithValue("@fecha_produccion_materia_prima", dtFechaProduccion.EditValue);
                    cmd.Parameters.AddWithValue("@lote_materia_prima", lote_string);
                    cmd.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);
                    cmd.Parameters.AddWithValue("@id_usuario", usuarioLogueado.Id);
                    cmd.Parameters.AddWithValue("@id_tipo_transaccion_kardex", glTipoTransaccion.EditValue);
                    cmd.Parameters.AddWithValue("@codigo_barra", barcode);
                    cmd.Parameters.AddWithValue("@cant", txtCantidadT.Text);
                    cmd.Parameters.AddWithValue("@peso", txtPeso.Text);
                    //Lista.Add(Convert.ToInt32(cmd.ExecuteScalar()));
                    cmd.ExecuteScalar();

                    

                    CantGuardo++;
                    con.Close();
                    //CajaDialogo.InformationAuto();

                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }

            //crear lote mp
            //[]
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_insert_ingresos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero_transaccion", txtNumIngreso.Text);
                cmd.Parameters.AddWithValue("@itemcode", this.ItemCode);
                cmd.Parameters.AddWithValue("@itemname", slueMP.Text);
                cmd.Parameters.AddWithValue("@id_usuario", usuarioLogueado.Id);
                cmd.Parameters.AddWithValue("@cardcode", DBNull.Value);
                cmd.Parameters.AddWithValue("@cardname", DBNull.Value);
                cmd.Parameters.AddWithValue("@id_boleta", DBNull.Value);
                cmd.Parameters.AddWithValue("@lote_materia_prima", lote_string);
                cmd.Parameters.AddWithValue("@cant", txtCantidadT.Text);
                cmd.Parameters.AddWithValue("@TotalTarimas", cantTarimas);
                cmd.Parameters.AddWithValue("@pesotaria", 0);
                cmd.Parameters.AddWithValue("@fecha_ingreso", dtFechaIngreso.EditValue);
                cmd.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);

                //cmd.Parameters.AddWithValue("@id_proveedor", DBNull.Value);
                //cmd.Parameters.AddWithValue("@fecha_vencimiento", dtFechaVencimiento.EditValue);
                //cmd.Parameters.AddWithValue("@fecha_produccion_materia_prima", dtFechaProduccion.EditValue);
                //cmd.Parameters.AddWithValue("@id_tipo_transaccion_kardex", glTipoTransaccion.EditValue);
                //cmd.Parameters.AddWithValue("@codigo_barra", barcode);
                //cmd.Parameters.AddWithValue("@peso", txtPeso.Text);
                //Lista.Add(Convert.ToInt32(cmd.ExecuteScalar()));
                cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }


            if (CantGuardo > 0)
            {
                CajaDialogo.Information("Datos guardados exitosamente!");
                this.Close();
            }
        }

        private void slueMP_EditValueChanged(object sender, EventArgs e)
        {
           
                 //txtMP_Name.Text = slueMP.Text;
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
    }
}