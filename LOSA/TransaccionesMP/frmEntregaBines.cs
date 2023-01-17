using ACS.Classes;
using DevExpress.XtraEditors;
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
using ACS.Classes;
using LOSA.Clases;
using LOSA.TransaccionesMP.VentanasMensajes;

namespace LOSA.TransaccionesMP
{
    public partial class frmEntregaBines : DevExpress.XtraEditors.XtraForm
    {
        int id_mp1, id_mp2, id_mp3, id_mp4;
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        public int idTarima;
        DataTable dt_tarima;
        Tarima tarimaEncontrada;
        public frmEntregaBines(UserLogin pUserLogin)
        {
            InitializeComponent();
            GetsName();
            UsuarioLogeado = pUserLogin;
            txtTarima.Focus();

        }

        private void GetsName()
        {
            id_mp1 = 1122;  //MP00063 Ronozyme Hipos GT
            id_mp2 = 1096;  //MP00036 Hacienda 66
            id_mp3 = 5;     //MP00033 Rovabio
           

            lblMP1.Text = LoadMPBG001(id_mp1);
            txtMP1.Text = Convert.ToString(load_existencia(id_mp1));
            
            lblMP2.Text = LoadMPBG001(id_mp2);
            txtMP2.Text = Convert.ToString(load_existencia(id_mp2));
            
            lblMP3.Text = LoadMPBG001(id_mp3);
            txtMP3.Text = Convert.ToString(load_existencia(id_mp3));

            
        }

        private void txtTarima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Validaciones a Morir!!
                EntregarTarima();
                GetsName();
            }
        }

        private void EntregarTarima()
        {
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            datosTarimaPorCodBarra(cn);

            bool Guardo = false;
            bool error = false;
            string mensaje = "";
            //Validar si la tarima escaneada es valida
            if (tarimaEncontrada.Recuperado)
            {
                //Validar Estaso de Tarima
                switch (tarimaEncontrada.Id_estado_tarima)
                {
                    case 1://Recepcionado
                        error = true;//No tien ubicacion
                        mensaje = "Esta tarima aun no ha sido ingresada a bodega! Solo se genero el rotulo, es necesario activar y ubicar!.";
                        break;
                    case 2://En Bodega
                        error = false;
                        //mensaje = "Calidad tiene En Observación ésta tarima.!";
                        break;
                    case 3://Retenido
                        error = true;
                        mensaje = "Esta Tarima esta Retenida!";
                        break;
                    case 4://Comprometido
                        error = true;
                        mensaje = "Esta tarima ya esta comprometida!";
                        break;
                    case 5://En Produccion
                        error = true;//esta habilitada
                        mensaje = "Esta tarima ya fue entrega a Producción";
                        break;
                    case 6://Consumido
                        error = true;
                        mensaje = "Esta Tarima ya fue entregada y consumida por producción!";
                        break;
                    //case 7://
                    //    error = true;
                    //    mensaje = "Calidad tiene Retenida ésta tarima.!";
                    //    break;
                    case 8://Parcialmente Entregado
                        error = false;
                        //mensaje = "Calidad ha Rechazado ésta tarima.!";
                        break;
                    case 9://Rechazado
                        error = true;
                        mensaje = "Esta tarima fue Rechazada!";
                        break;
                    case 10://Ajuste de Inventario
                        error = true;
                        mensaje = "Esta tarima tuvo salida por ajuste de Inventario!";
                        break;
                }

                if (error)
                {
                    lblMensaje.Text = mensaje;
                    Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                    frm.ShowDialog();
                    panelNotificacion.BackColor = Color.Red;
                    timerLimpiarMensaje.Enabled = true;
                    timerLimpiarMensaje.Start();
                    return;
                }

                //Validacion Estados de Calidad
                switch (tarimaEncontrada.Id_estadoCalidad)
                {
                    case 1://Habilitado
                        error = false;//esta habilitada
                        break;
                    case 2://En Observacion
                        error = true;
                        mensaje = "Calidad tiene En Observación ésta tarima.!";
                        break;
                    case 3://Retenido
                        error = true;
                        mensaje = "Calidad tiene Retenida ésta tarima.!";
                        break;
                    case 4://Rechazado
                        error = true;
                        mensaje = "Calidad ha Rechazado ésta tarima.!";
                        break;
                    default:
                        error = true;//esta habilitada
                        mensaje = "Esta tarima un no ha sido inspeccionada por Calidad!";
                        break;
                }

                if (error)
                {
                    lblMensaje.Text = mensaje;
                    Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                    frm.ShowDialog();
                    panelNotificacion.BackColor = Color.Red;
                    timerLimpiarMensaje.Enabled = true;
                    timerLimpiarMensaje.Start();
                    return;
                }


                //Si no se ha generado ninguna validacion previa de bloqueo el programa permitira seguir ejecutando.
                if (!error)
                {
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                        con.Open();

                        SqlCommand cmd = new SqlCommand("sp_get_disponibilidad_tarima_de_bines", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_tarima", tarimaEncontrada.Id);
                        bool disponible = Convert.ToBoolean(cmd.ExecuteScalar());
                        
                        if (disponible == false)
                        {
                            mensaje = "Esta tarima ya fue entregada en Alimentacion!";
                            frmVentanaMsjTarimaAlimentacion frm1 = new frmVentanaMsjTarimaAlimentacion(mensaje, tarimaEncontrada.CodigoBarra);
                            frm1.ShowDialog();
                            lblMensaje.Text = mensaje;
                            panelNotificacion.BackColor = Color.Red;
                            timerLimpiarMensaje.Enabled = true;
                            timerLimpiarMensaje.Start();
                            return;
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                    ////Info de Tarima
                    //SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                    //conn.Close();
                    //SqlCommand cmd = new SqlCommand("sp_getTarimas_without_filters_v4", conn);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@codigo_barra", txtTarima.Text);
                    //cmd.Parameters.AddWithValue("@tipo_query", 2);//Get Data de la tarima
                    //dt_tarima = new DataTable();
                    //SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    //adat.Fill(dt_tarima);
                    ////Sacamos el id de la tarima
                    //foreach (DataRow row in dt_tarima.Rows)
                    //{
                    //    idTarima = dp.ValidateNumberInt32(row[0]);
                    //    break;
                    //}

                    frmResumenEntregaBines frm = new frmResumenEntregaBines(dt_tarima, idTarima);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            int IDTARIMA = frm.id_tarima;
                            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                            con.Open();
                            SqlCommand cmd = new SqlCommand("sp_insert_kardex_prd_bines", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idTarima", IDTARIMA);
                            cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                            cmd.ExecuteNonQuery();

                            Guardo = true;

                            GetsName();
                            txtTarima.Text = "";
                            txtTarima.Focus();

                            //DataOperations dp = new DataOperations();
                            //SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                            //con.Open();

                            //SqlCommand cmd = new SqlCommand("", con);
                            //cmd.CommandType = CommandType.StoredProcedure;
                            //cmd.Parameters.AddWithValue("@idtarima", tarimaEncontrada.Id);
                            //cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                            //SqlDataReader dr = cmd.ExecuteReader();
                            //if (dr.Read())
                            //{
                            //    Guardo = dr.GetInt32(4) == 1 ? true : false;
                            //}
                            //dr.Close();
                            //con.Close();

                        }
                        catch (Exception ec)
                        {
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
                        lblMensaje.Text = mensaje;
                        Utileria.frmMensajeCalidad frm1 = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, "Transaccion Cancelada.");
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
                    lblMensaje.Text = mensaje;
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

        void datosTarimaPorCodBarra(SqlConnection connection)
        {
            Tarima InfoTarima = new Tarima();

            try
            {
                using (connection)
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    string LocalBarcode = txtTarima.Text;

                    //Get id Estado Tarima
                    SqlCommand cmd = new SqlCommand("sp_getTarimas_without_filters_v4", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo_barra", txtTarima.Text);
                    cmd.Parameters.AddWithValue("@tipo_query", 1);
                    SqlDataReader dr = cmd.ExecuteReader();
                    int idEstadoTarima = 0;
                    if (dr.Read())
                    {
                        idEstadoTarima = dp.ValidateNumberInt32(dr.GetValue(0));
                    }
                    dr.Close();

                    //bool Error = false;
                    //string mensaje = " ";
                    //switch (idEstadoTarima)
                    //{
                    //    case 0:
                    //    default:
                    //        mensaje = "TARIMA NO ENCONTRADA";
                    //        Error = true;
                    //        break;
                    //    case 1://Recepcionado
                    //        mensaje = "Esta tarima aun no ha sido ingresada a bodega! Solo se genero el rotulo, es necesario activar y ubicar!.";
                    //        Error = true;
                    //        break;
                    //    case 2://En Bodega
                    //        break;
                    //    case 3://Retenido
                    //        mensaje = "Esta Tarima esta Retenida!";
                    //        Error = true;
                    //        break;
                    //    case 4://Comprometido
                    //        mensaje = "Esta tarima ya esta comprometida!";
                    //        Error = true;
                    //        break;
                    //    case 5://En Produccion
                    //        mensaje = "Esta tarima ya fue entrega a Producción";
                    //        Error = true;
                    //        break;
                    //    case 6://Consumido
                    //        mensaje = "Esta Tarima ya fue entregada y consumida por producción!";
                    //        Error = true;
                    //        break;
                    //    case 8://Parcialmente Entregado
                    //        break;
                    //    case 9://Rechazado
                    //        mensaje = "Esta tarima fue Rechazada!";
                    //        Error = true;
                    //        break;
                    //    case 10://Ajuste de Inventario
                    //        mensaje = "Esta tarima tuvo salida por ajuste de Inventario!";
                    //        Error = true;
                    //        break;
                    //}

                    //if (Error)
                    //{
                    //    lblMensaje.Text = mensaje;
                    //    Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                    //    frm.ShowDialog();
                    //    panelNotificacion.BackColor = Color.FromArgb(255, 102, 102);
                    //    timerLimpiarMensaje.Enabled = true;
                    //    timerLimpiarMensaje.Start();
                    //    tarimaEncontrada = new Tarima();
                    //    tarimaEncontrada.RecuperarRegistro_v3(0, LocalBarcode);
                    //    return;
                    //}

                    cmd = new SqlCommand("sp_getTarimas_without_filters_v4", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo_barra", txtTarima.Text);
                    cmd.Parameters.AddWithValue("@tipo_query", 2);//Get Data de la tarima
                    dt_tarima = new DataTable();
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    adat.Fill(dt_tarima);
                    //Sacamos el id de la tarima
                    foreach (DataRow row in dt_tarima.Rows)
                    {
                        idTarima = dp.ValidateNumberInt32(row[0]);
                        break;
                    }

                    tarimaEncontrada = new Tarima();
                    tarimaEncontrada.RecuperarRegistro_v3(idTarima, "");

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void timerLimpiarMensaje_Tick(object sender, EventArgs e)
        {
            timerLimpiarMensaje.Stop();
            timerLimpiarMensaje.Enabled = false;
            panelNotificacion.BackColor = Color.White;
            txtTarima.Text = "";
            lblMensaje.Text = "";
            txtTarima.Focus();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        public Decimal load_existencia(int pid_mp)
        {
            decimal existencia = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_obtener_inventario_for_MP_bines_existencia]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", pid_mp);
                existencia = Convert.ToDecimal(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return existencia;
        }

        public string LoadMPBG001(int pid_mp)
        {
            string MP1 = " ";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_obtener_inventario_for_MP_bines", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", pid_mp);
                MP1 = Convert.ToString(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            return MP1;
        }
    }
}