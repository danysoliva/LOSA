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
using ACS.Classes;
using LOSA.Clases;
using System.Data.SqlClient;

namespace LOSA.TransaccionesMP
{
    public partial class frmEntregaTarimaReq_3 : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        private int idTarima;
        private decimal factorPresentacion;
        private int IsMicro = 0;
        UserLogin usuarioLogueado = new UserLogin();
        Tarima tarimaEncontrada;
        Requisicion RequisicionActual = new Requisicion();
        DataTable Tarima;
        public frmEntregaTarimaReq_3(UserLogin Puser)
        {
            InitializeComponent();
            usuarioLogueado = Puser;
            load_tarimas_scan();
            txtRequisicion.Focus();
        }
                                                                                         
        public void load_tarimas_scan()
        {
            string query = @"sp_load_tarimas_escaneadas";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            SqlCommand cmd = new SqlCommand(query,cn);
            cmd.CommandType = CommandType.StoredProcedure;
            dsTransaccionesMP.viewTarimas.Clear();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsTransaccionesMP.viewTarimas);
            cn.Close();

            
        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerLimpiarMensaje_Tick(object sender, EventArgs e)
        {
            timerLimpiarMensaje.Stop();
            timerLimpiarMensaje.Enabled = false;
            panelNotificacion.BackColor = Color.White;
            //txtCantidadT.Text = txtPeso.Text = "0";
            txtTarima.Text = "";
            gcTarima.DataSource = null;
            lblMensaje.Text = "";
            txtTarima.Focus();
            //pictureBoxIndicadorOk.Visible = false;
            //txtentrega.Text = string.Format("{0:###,##0.00}", 0);
            //txtpesoendregadas.Text = string.Format("{0:###,##0.00}", 0);
            //txtsolicitada.Text = string.Format("{0:###,##0.00}", 0);
            //txtdevueltas.Text = string.Format("{0:###,##0.00}", 0);
            //txtrequeridas.Text = string.Format("{0:###,##0.00}", 0);

            //txtacumualdo.Text = string.Format("{0:###,##0.00}", 0);
        }

        private void txtRequisicion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtRequisicion.Text))
                {
                    if (RequisicionActual.RecuperarRegistroFromBarcode(txtRequisicion.Text.Trim()))
                    {
                        //pictureBoxIndicadorOk.Visible = true;
                        lblRequisicionEncontrada.Text = RequisicionActual.IdRequisicion.ToString();
                        txtTarima.Focus();
                    }
                    else
                    {
                        Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, "No se encontro la requisa");
                        if (frm.ShowDialog() == DialogResult.Cancel)
                        {
                            txtRequisicion.Focus();
                        }
                        
                    }
                }
                else
                {
                    Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, "Debe de escanear el codigo de Requisa");
                    if (frm.ShowDialog() == DialogResult.Cancel)
                    {
                        txtRequisicion.Focus();
                    }
                }
            }
        }

        private void txtTarima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EntregarTarima();
                load_tarimas_scan();
            }
        }
        private DataTable CreateDataTarima(int idTarima, string pProveedor, string pNombreTarima, string pLote, string pPpresentacion, string codigoSAP, string MP)
        {
            DataTable dt = new DataTable();

            try
            {
                dt.Columns.Add("Detalle", typeof(string));
                dt.Columns.Add("Valor", typeof(string));


                dt.Rows.Add("TARIMA", idTarima);
                dt.Rows.Add("PROVEEDOR", pProveedor);
                dt.Rows.Add("LOTE", pLote);
                dt.Rows.Add("PRESENTACION", pPpresentacion);

                dt.Rows.Add("Codigo", codigoSAP);
                dt.Rows.Add("Materia Prima", MP);

                return dt;
            }
            catch (Exception error)
            {
                CajaDialogo.Information(error.Message);
                return dt;
            }
        }
        void datosTarimaPorCodBarra(SqlConnection connection)
        {
            Tarima InfoTarima = new Tarima();
            try
            {
                using (connection)
                {
                    string SQL = "exec sp_getTarimas_without_filters_v3 @codigo_barra";
                    SqlCommand cmd = new SqlCommand();
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cmd.Connection = connection;
                    cmd.CommandText = SQL;

                    cmd.Parameters.AddWithValue("@codigo_barra", txtTarima.Text);

                    connection.Open();


                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            idTarima = dr.GetInt32(0);

                            if (InfoTarima.RecuperarRegistro_v3(idTarima, ""))
                            {
                                factorPresentacion = InfoTarima.Factor;
                                tarimaEncontrada = InfoTarima;

                            }
                            gcTarima.DataSource = CreateDataTarima(dr.GetInt32(0), dr.GetString(2), dr.GetString(1), dr.GetString(5), dr.GetString(6), dr.GetString(11), dr.GetString(12));
                            Tarima = CreateDataTarima(dr.GetInt32(0), dr.GetString(2), dr.GetString(1), dr.GetString(5), dr.GetString(6), dr.GetString(11), dr.GetString(12));
                            Tarima.AcceptChanges();
                            //gvTarima.InitNewRow += GridView1_InitNewRow;
                            gvTarima.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("TARIMA NO ENCONTRADA");
                        tarimaEncontrada = null;
                        gcTarima.DataSource = null;
                        txtTarima.Text = "";
                    }

                    cn.Close();

                }
            }
            catch (Exception error)
            {
                CajaDialogo.Error(error.Message);
            }
        }
        public void EntregarTarima()
        
        
        {
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            datosTarimaPorCodBarra(cn);

            //Entrega de tarima
            bool Guardo = false;
            bool error = false;
            bool disponible = false;
            string mensaje = "";
            decimal ExistenciaTM = 0;
            decimal Pentregado = 0;
            decimal Psolicitado = 0;
            decimal factor = 0;
            if (tarimaEncontrada != null)
            {
                if (!RequisicionActual.Recuperado)
                {
                    error = true;
                    lblMensaje.Text = "Debe indicar la requisicion que esta entregando!";

                    Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                    if (frm.ShowDialog() == DialogResult.Cancel)
                    {

                    }
                    panelNotificacion.BackColor = Color.Red;
                    timerLimpiarMensaje.Enabled = true;
                    timerLimpiarMensaje.Start();
                    return;
                }
                if (tarimaEncontrada.Recuperado)
                {
                    if (tarimaEncontrada.Id_estadoCalidad > 1)
                    {
                        error = true;
                        mensaje = "Calidad tiene retenido esta tarima.!";
                        Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                        if (frm.ShowDialog() == DialogResult.Cancel)
                        {

                        }
                        panelNotificacion.BackColor = Color.Red;
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                        return;
                    }


                    if (!error)
                    {
                       

                        try
                        {
                            DataOperations dp = new DataOperations();
                            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                            con.Open();

                            SqlCommand cmd = new SqlCommand("[dbo].[sp_verifica_diponibilidad_tarima_entrega_v6]", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id", tarimaEncontrada.Id);
                            cmd.Parameters.AddWithValue("@id_req", RequisicionActual.IdRequisicion);
                            SqlDataReader dr = cmd.ExecuteReader();

                            if (dr.Read())
                            {
                                disponible = dr.GetBoolean(0);
                                if (!disponible)
                                {
                                    error = true;
                                    mensaje = dr.GetString(1);
                                    Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                                    if (frm.ShowDialog() == DialogResult.Cancel)
                                    {

                                    }

                                    lblMensaje.Text = mensaje;

                                    panelNotificacion.BackColor = Color.Red;
                                    timerLimpiarMensaje.Enabled = true;
                                    timerLimpiarMensaje.Start();
                                    return;
                                }

                                 ExistenciaTM = dr.GetDecimal(2);
                                 Pentregado = dr.GetDecimal(3);
                                 Psolicitado = dr.GetDecimal(4);
                                factor = dr.GetDecimal(5);
                            }
                            dr.Close();
                            con.Close();

                        }
                        catch (Exception ec)
                        {
                            CajaDialogo.Error(ec.Message);
                        }

                        frmResumenToEntregar frms = new frmResumenToEntregar(ExistenciaTM
                                                                                 , Pentregado
                                                                                 , Psolicitado
                                                                                 , Tarima
                                                                                 ,idTarima
                                                                                 ,factor);
                        if (frms.ShowDialog() == DialogResult.OK)
                        {

                            try
                            {

                                DataOperations dp = new DataOperations();
                                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                                con.Open();

                                //SqlCommand cmd = new SqlCommand("sp_set_insert_salida_tarima_bodega_mp", con);
                                SqlCommand cmd = new SqlCommand("[dbo].[sp_insert_tarima_requisa_entrega_v6]", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@idtarima", tarimaEncontrada.Id);
                                cmd.Parameters.AddWithValue("@id_usuario", usuarioLogueado.Id);
                                cmd.Parameters.AddWithValue("@id_req", RequisicionActual.IdRequisicion);
                                cmd.Parameters.AddWithValue("@cantidad", frms.selecionado);
                                cmd.Parameters.AddWithValue("@peso", frms.pesoKg);
                                SqlDataReader dr = cmd.ExecuteReader();
                                if (dr.Read())
                                {

                                    Guardo = dr.GetInt32(4) == 1 ? true : false;

                                }
                                dr.Close();
                                con.Close();

                            }
                            catch (Exception ec)
                            {
                                //CajaDialogo.Error(ec.Message);
                                lblMensaje.Text = ec.Message;
                                panelNotificacion.BackColor = Color.Red;
                                timerLimpiarMensaje.Enabled = true;
                                timerLimpiarMensaje.Start();
                            }
                            if (Guardo)
                            {
                                //Mensaje de transaccion exitosa
                                lblMensaje.Text = "Transacción Exitosa!";
                                panelNotificacion.BackColor = Color.MediumSeaGreen;
                                timerLimpiarMensaje.Enabled = true;
                                timerLimpiarMensaje.Start();
                            }
                        }
                        else
                        {
                            Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, "Transaccion Cancelada.");
                            if (frm.ShowDialog() == DialogResult.Cancel)
                            {

                            }
                            panelNotificacion.BackColor = Color.Red;
                            timerLimpiarMensaje.Enabled = true;
                            timerLimpiarMensaje.Start();
                            return;
                        }
                        

                        

                    }
                    else
                    {
                        Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                        if (frm.ShowDialog() == DialogResult.Cancel)
                        {

                        }
                        panelNotificacion.BackColor = Color.Red;
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                        return;
                    }
                }
                else
                {
                    error = true;
                    mensaje = "El codigo de barra leido no es correcto!";
                    Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                    if (frm.ShowDialog() == DialogResult.Cancel)
                    {

                    }
                    panelNotificacion.BackColor = Color.Red;
                    timerLimpiarMensaje.Enabled = true;
                    timerLimpiarMensaje.Start();
                    return;
                }


            }
        }

        private void frmEntregaTarimaReq_3_Activated(object sender, EventArgs e)
        {
            txtRequisicion.Focus();
        }

        private void frmEntregaTarimaReq_3_Load(object sender, EventArgs e)
        {

            txtRequisicion.Focus();
        }
    }
}