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
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.TransaccionesPT
{
    public partial class frm_saco_dañado : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        private int idTarima;
        private decimal factorPresentacion;
        private int IsMicro = 0;
        UserLogin usuarioLogueado;
        Tarima tarimaEncontrada;
        public int idUbicacionNueva;
        public int unidades =1;
        int id_motivo = 0;
        public frm_saco_dañado()
        {
            InitializeComponent();
            txtTarima.Focus();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
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

                            if (InfoTarima.RecuperarRegistro(idTarima, ""))
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
                    txtCantidadT.Text = tarimaEncontrada.Cantidad.ToString();
                    //txtPeso.Text = tarimaEncontrada.Peso.ToString();




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
                    frm_select_motivo_to_drop frm = new frm_select_motivo_to_drop();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        txtMotivo.Text = frm.Motivo;
                        id_motivo = frm.Id_motivo;
                    }
                   
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
                    lblMensaje.Text = "Se ha eliminado correctamente.";
                    //panelNotificacion.BackColor = Color.MediumSeaGreen;
                    //timerLimpiarMensaje.Enabled = true;
                    //timerLimpiarMensaje.Start();

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
        private void txtTarima_KeyDown(object sender, KeyEventArgs e)
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
            txtTarima.Text = "";
            gcTarima.DataSource = null;
            lblMensaje.Text = "";
            id_motivo = 0;
            txtMotivo.Text = "";
            txtCantidadT.Text = "0.00";
            txtTarima.Focus();
        }

        private void btn_udup_Click(object sender, EventArgs e)
        {
            if (unidades >= 0)
            {
                unidades++;
            }

            txttosacar.Text = unidades.ToString();
        }

        private void btn_uddown_Click(object sender, EventArgs e)
        {
            if (unidades > 1)
            {
                unidades = unidades - 1;
            }

            txttosacar.Text = unidades.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //   sp_insert_motivo_to_out_sacos_pt
            string query = @"sp_insert_motivo_to_out_sacos_pt";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tarima", idTarima);
                cmd.Parameters.AddWithValue("@cantidad", unidades);
                cmd.Parameters.AddWithValue("@id_motivo" , id_motivo);
                cmd.ExecuteNonQuery();

                lblMensaje.Text = "Se ha eliminado correctamente.";
                panelNotificacion.BackColor = Color.MediumSeaGreen;
                timerLimpiarMensaje.Enabled = true;
                timerLimpiarMensaje.Start();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message); ;
            }

        }
    }
}