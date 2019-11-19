using ACS.Classes;
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

namespace LOSA.RecepcionMP
{
    public partial class frmEntradaMP : Form
    {
        private int idTarima, idUbicacion;
       
        DataOperations dp = new DataOperations();
        DataTable dtTarima = new DataTable();
        public frmEntradaMP()
        {
            InitializeComponent();
        }

        private void CmdSelectTarima_Click(object sender, EventArgs e)
        {
            frmTarimas frm = new frmTarimas();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                idTarima = frm.idTarima;
                beTarima.Text= frm.idTarima.ToString();
                txtProveedor.Text = frm.proveedor;
                txtTarima.Text = frm.nombreTarima;
                txtLote.Text = frm.lote;
                txtPresentacion.Text = frm.presentacion.ToString();

                
            }
        }

        private void CmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        void datosTarima(SqlConnection connection)
        {
            try
            {
                using (connection)
                {
                    string SQL = "exec obtenerTarimas  @codigo_barra";
                    SqlCommand cmd = new SqlCommand();
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cmd.Connection = connection;
                    cmd.CommandText = SQL;

                    cmd.Parameters.AddWithValue("@codigo_barra", beTarima.Text);

                    connection.Open();
               

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            idTarima = dr.GetInt32(0);
                            txtTarima.Text = dr.GetString(1);
                            txtProveedor.Text = dr.GetString(2);
                            txtLote.Text = dr.GetString(5);
                            txtPresentacion.Text = dr.GetString(6);
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("TARIMA NO ENCONTRADA");
                        txtTarima.Text = "";
                    }

                    cn.Close();
                  
                }
            }
            catch (Exception error)
            {
                
            }
        }

        void datosUbicacion(SqlConnection connection)
        {
            try
            {
                using (connection)
                {
                    string SQL = "exec obtenerUbicacionTarima @codigo_barra";
                    SqlCommand cmd = new SqlCommand();
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cmd.Connection = connection;
                    cmd.CommandText = SQL;

                   cmd.Parameters.AddWithValue("@codigo_barra", beTarima.Text);

                    connection.Open();


                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            idUbicacion = dr.GetInt32(0);
                            txtPasillo.Text = dr.GetString(1);
                            txtAltura.Text = dr.GetString(3);
                            txtProfundidad.Text = dr.GetString(4);
                            txtRack.Text = dr.GetString(2);

                        }
                    }
                    else
                    {
                        CajaDialogo.Error("UBICACIÓN NO ENCONTRADA");
                       beUbicacion.Text = "";
                    }

                    cn.Close();

                }
            }
            catch (Exception error)
            {

            }
        }
        private void BeTarima_Click(object sender, EventArgs e)
        {
            beTarima.Text = "";
            txtPresentacion.Text = "";
            txtProveedor.Text = "";
            txtLote.Text = "";
           
        }

        private void BeTarima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                datosTarima(cn);
            }
        }

        private void BtnUbicacion_Click(object sender, EventArgs e)
        {
            frmUbicacionTarima frm = new frmUbicacionTarima();

            if (frm.ShowDialog()==DialogResult.OK)
            {
                idUbicacion = frm.idUbicacion;
                beUbicacion.Text = frm.idUbicacion.ToString();
                txtAltura.Text = frm.altura;
                txtRack.Text = frm.rack;
                txtProfundidad.Text = frm.profundidad;
                txtPasillo.Text = frm.pasillo;
            }
        }

        private void BeUbicacion_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
         
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                datosUbicacion(cn);
            }
        }

        private void FrmEntradaMP_Load(object sender, EventArgs e)
        {
            dtTarima.Columns.Add();
            dtTarima.Columns.Add();
        }

        private void BeUbicacion_Click(object sender, EventArgs e)
        {
            txtRack.Text = "";
            txtProfundidad.Text = "";
            txtAltura.Text = "";
            txtPasillo.Text = "";
            beUbicacion.Text = "";
        }
    }
}
