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


namespace LOSA.TransaccionesPT
{
    public partial class frmactivacionPT : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        private int idTarima;
        private decimal factorPresentacion;
        private int IsMicro = 0;
        UserLogin usuarioLogueado;
        Tarima tarimaEncontrada;
        public int idUbicacionNueva;
        int InProgress = 0;
        public frmactivacionPT(UserLogin pUser)
        {
            InitializeComponent();
            usuarioLogueado = pUser;

        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void datosTarimaPorCodBarra(SqlConnection connection)
        {
            Tarima InfoTarima = new Tarima();
            try
            {
                using (connection)
                {
                    string SQL = "exec sp_getTarimas_without_filters_PT @codigo_barra";
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

                            if (InfoTarima.RecuperarRegistro_activacion(idTarima, ""))
                            {
                                factorPresentacion = InfoTarima.Factor;
                                tarimaEncontrada = InfoTarima;

                            }
                            gcTarima.DataSource = CreateDataTarima(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4));
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

                dt.Rows.Add("PT", pNombreTarima);
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
             

                if (tarimaEncontrada.Recuperado)
                {

                    if (tarimaEncontrada.id_estado_pt > 1)
                    {

                        error = true;
                        mensaje = "Ya se ha activado la tarima seleccionada!";
                    }

                    txtCantidadT.Text = tarimaEncontrada.Cantidad.ToString();
                    txtPeso.Text = tarimaEncontrada.Peso.ToString();
                }
                else
                {
                    error = true;
                    mensaje = "La Tarima ya esta activa o no se ha podido encontrar!";
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
                    SqlCommand cmd = new SqlCommand("sp_activar_tarima_producto_terminado", con);  // Update de Data
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_selected", tarimaEncontrada.Id);
                    cmd.Parameters.AddWithValue("@codigo_barra", tarimaEncontrada.CodigoBarra);
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
                    idTarima = tarimaEncontrada.Id;
                    //Mensaje de transaccion exitosa
                    lblMensaje.Text = "Tarima Activada";
                    //panelNotificacion.BackColor = Color.MediumSeaGreen;
                    //timerLimpiarMensaje.Enabled = true;
                    //timerLimpiarMensaje.Start();
                    InProgress = 1;
                    beNuevaUbicacion.Focus();
                }

                


            }
            else
            {
                lblMensaje.Text = "No se encontro el registro de la tarima!";
                panelNotificacion.BackColor = Color.Red;
                timerLimpiarMensaje.Enabled = true;
                timerLimpiarMensaje.Start();
                InProgress = 0;
            }



        }

        private void txtTarima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (InProgress == 0) //validacion
                {
                    EntregarTarima();
                }
                else
                {
                    beNuevaUbicacion.Focus();
                }
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

            gcNuevaUbicación.DataSource = null;
            gcTarima.DataSource = null;
            beNuevaUbicacion.Text = "";
            txtTarima.Focus();
        }

        private void beNuevaUbicacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                gcNuevaUbicación.DataSource = CreateDataNuevaUbicacion(0, beNuevaUbicacion.Text);
                gvNuevaUbicacion.InitNewRow += GvNuevaUbicacion_InitNewRow;
                gvNuevaUbicacion.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);


                try
                {
                    if (gvTarima.RowCount <= 0 || gvNuevaUbicacion.RowCount <= 0)
                        CajaDialogo.Error("INFORMACION INCOMPLETA");
                    else
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                        con.Open();


                        SqlCommand cmd = new SqlCommand("sp_cambiar_ubicacion_tarima_v2_activacion", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        Tarima tam1 = new Tarima();


                        cmd.Parameters.AddWithValue("@id_tarima", idTarima);
                        cmd.Parameters.AddWithValue("@idUbicacionNueva", idUbicacionNueva);

                        cmd.ExecuteNonQuery();

                        con.Close();
                       
                        panelNotificacion.BackColor = Color.MediumSeaGreen;
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                        InProgress = 0;

                    }
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }
        private void GvNuevaUbicacion_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

        }
        private DataTable CreateDataNuevaUbicacion(int pIdUbicacion, string pCodigoBarra)
        {
            DataTable dt = new DataTable();
            Ubicaciones infoUbicaciones = new Ubicaciones();

            dt.Columns.Add("Detalle", typeof(string));
            dt.Columns.Add("Valor", typeof(string));

            if (infoUbicaciones.RecuperarRegistro_v2(pIdUbicacion, pCodigoBarra))
            {
                //id_um = tam1.IdUnidadMedida.ToString();
                //cantidadMP = tam1.Cantidad;
                idUbicacionNueva = infoUbicaciones.Id;
                //dt.Rows.Add("PASILLO", infoUbicaciones.Pasillo);
                dt.Rows.Add("RACK", infoUbicaciones.Rack);
                //dt.Rows.Add("ALTURA", infoUbicaciones.Altura);
                //dt.Rows.Add("PROFUNDIDAD", infoUbicaciones.Profundidad);
            }

            return dt;
        }

    }
}