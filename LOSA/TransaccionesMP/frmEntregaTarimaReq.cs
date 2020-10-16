using ACS.Classes;
using LOSA.Clases;
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

namespace LOSA.TransaccionesMP
{
    public partial class frmEntregaTarimaReq : Form
    {
        DataOperations dp = new DataOperations();
        private int idTarima;
        private decimal factorPresentacion;
        UserLogin usuarioLogueado = new UserLogin();
        Tarima tarimaEncontrada;
        Requisicion RequisicionActual = new Requisicion();
        public frmEntregaTarimaReq(UserLogin pUsuarioLogueado)
        {
            InitializeComponent();
            usuarioLogueado = pUsuarioLogueado;
            Focus_();
        }

        public frmEntregaTarimaReq(UserLogin pUsuarioLogueado, string pCode)
        {
            InitializeComponent();
            usuarioLogueado = pUsuarioLogueado;
            txtTarima.Text = pCode;
            EntregarTarima();
            Focus_();
        }

        void datosTarimaPorCodBarra(SqlConnection connection)
        {
            Tarima InfoTarima = new Tarima();
            try
            {
                using (connection)
                {
                    string SQL = "exec sp_getTarimas_without_filters @codigo_barra";
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

                            if (InfoTarima.RecuperarRegistro(idTarima, ""))
                            {
                                factorPresentacion = InfoTarima.Factor;
                                tarimaEncontrada = InfoTarima;
                            }

                            gcTarima.DataSource = CreateDataTarima(dr.GetInt32(0), dr.GetString(2), dr.GetString(1), dr.GetString(5), dr.GetString(6));
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
        private DataTable CreateDataTarima(int idTarima, string pProveedor, string pNombreTarima, string pLote, string pPpresentacion)
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

                return dt;
            }
            catch (Exception error)
            {
                CajaDialogo.Information(error.Message);
                return dt;
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


           

            if (tarimaEncontrada != null)
            {
                if (!RequisicionActual.Recuperado)
                {
                    error = true;
                    lblMensaje.Text = "Debe indicar la requisicion que esta entregando!";
                    panelNotificacion.BackColor = Color.Red;
                    timerLimpiarMensaje.Enabled = true;
                    timerLimpiarMensaje.Start();
                    return;
                }

                if (tarimaEncontrada.Recuperado)
                {
                    //if (!tarimaEncontrada.Enable)
                    //{
                    //    error = true;
                    //    mensaje = "La tarima no esta activa!";
                    //}

                    if (tarimaEncontrada.Id_estadoCalidad > 1)
                    {
                        error = true;
                        mensaje = "La tarima no esta Disponible por parte de Calidad!";
                    }

                    if (!error)
                    {
                        
                        txtCantidadT.Text = string.Format("{0:###,##0.00}", tarimaEncontrada.Cantidad);
                        txtPeso.Text = string.Format("{0:###,##0.00}", tarimaEncontrada.Peso);

                        try
                        {
                            DataOperations dp = new DataOperations();
                            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                            con.Open();

                            SqlCommand cmd = new SqlCommand("sp_verifica_diponibilidad_tarima_entrega", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id", tarimaEncontrada.Id);
                            disponible = Convert.ToBoolean(cmd.ExecuteScalar());
                            con.Close();
                        }
                        catch (Exception ec)
                        {
                            CajaDialogo.Error(ec.Message);
                        }


                        if (!disponible)
                        {
                            error = true;
                            mensaje = "La tarima no esta disponible para entrega!";
                        }

                        if (!error)//Si error sigue en false evaluaremos la ubicacion.
                        {
                            Ubicacion_Tarima ub1 = new Ubicacion_Tarima();
                            if (ub1.RecuperarRegistro(tarimaEncontrada.Id, ""))
                            {
                                //if (ub1.IdBodega > 1)
                                //{
                                //    error = true;
                                //    mensaje = "La tarima no esta en la bodega de MP, no se puede entregar!";
                                //}
                            }
                            else
                            {
                                error = true;
                                mensaje = "La tarima no tiene una ubicacion valida, aun esta en proceso de recepción!";
                            }
                        }
                    }
                }
                else
                {
                    error = true;
                    mensaje = "El codigo de barra leido no es correcto!";
                }

                if (error)
                {
                    lblMensaje.Text = mensaje;
                    panelNotificacion.BackColor = Color.Red;
                    timerLimpiarMensaje.Enabled = true;
                    timerLimpiarMensaje.Start();
                    return;
                }

                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();

                    //SqlCommand cmd = new SqlCommand("sp_set_insert_salida_tarima_bodega_mp", con);
                    SqlCommand cmd = new SqlCommand("sp_set_insert_salida_tarima_bodega_mp_v2", con);  
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idtarima", tarimaEncontrada.Id);
                    cmd.Parameters.AddWithValue("@id_usuario", usuarioLogueado.Id);
                    cmd.Parameters.AddWithValue("@id_req", RequisicionActual.IdRequisicion);
                    Guardo = Convert.ToBoolean(cmd.ExecuteScalar());
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
                lblMensaje.Text = "No se encontro el registro de la tarima!";
                panelNotificacion.BackColor = Color.Red;
                timerLimpiarMensaje.Enabled = true;
                timerLimpiarMensaje.Start();
            }

        }


        private void beIdTarima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EntregarTarima();
            }
        }

        private void timerLimpiarMensaje_Tick(object sender, EventArgs e)
        {
            timerLimpiarMensaje.Stop();
            timerLimpiarMensaje.Enabled = false;
            panelNotificacion.BackColor = Color.White;
            txtCantidadT.Text = txtPeso.Text = "0";
            txtTarima.Text = "";
            gcTarima.DataSource = null;
            lblMensaje.Text = "";
            txtTarima.Focus();
            pictureBoxIndicadorOk.Visible = false;

        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmEntregaTarimaReq_Click(object sender, EventArgs e)
        {
            Focus_();
        }

        private void Focus_()
        {
            if (RequisicionActual.IdRequisicion == 0)
                txtRequisicion.Focus();
            else
                txtTarima.Focus();
            
        }

        private void lblRequisicionEncontrada_Click(object sender, EventArgs e)
        {
            Focus_();
        }

        private void gcTarima_Click(object sender, EventArgs e)
        {
            Focus_();
        }

        private void pictureBoxIndicadorOk_Click(object sender, EventArgs e)
        {
            Focus_();
        }

        private void cmdSelectTarima_Click(object sender, EventArgs e)
        {
            Focus_();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {
            Focus_();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            Focus_();
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
                        pictureBoxIndicadorOk.Visible = false;
                        txtRequisicion.Focus();
                    }
                }
                else
                {
                    pictureBoxIndicadorOk.Visible = false;
                    txtRequisicion.Focus();
                }
            }
        }

        private void frmEntregaTarimaReq_Activated(object sender, EventArgs e)
        {
            Focus_();
        }

        private void frmEntregaTarimaReq_Load(object sender, EventArgs e)
        {
            Focus_();
        }
    }
}
