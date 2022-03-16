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
    public partial class MantenimientoClienteOperaciones : DevExpress.XtraEditors.XtraForm
    {
        bool IsEditar = false;
        int ClienteKey = 0;
        DataOperations dp = new DataOperations();
        public MantenimientoClienteOperaciones(bool ParIsEditar, int Pid_cliente)
        {
            InitializeComponent();
            IsEditar = ParIsEditar;
            ClienteKey = Pid_cliente;
            load_clientes();
            if (IsEditar)
            {
                get_informacion();
            }
        }
        public void load_clientes()
        {
            string Query = @"sp_get_clientes";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsPT.cliente.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPT.cliente);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void get_informacion()
        {
            try
            {
                string query = @"sp_get_all_data_of_clients";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ClienteKey);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtCodigodeSocio.Text = dr.IsDBNull(1) ? "" : dr.GetString(1);
                        txtnombre.Text = dr.IsDBNull(2) ? "" : dr.GetString(2);
                        txtcodigoPais.Text = dr.IsDBNull(3) ? "" : dr.GetString(3);
                        txtdireccion1.Text = dr.IsDBNull(4) ? "" : dr.GetString(4);
                        txtdireccion2.Text = dr.IsDBNull(5) ? "" : dr.GetString(5);
                        txtciudad.Text = dr.IsDBNull(6) ? "" : dr.GetString(6);
                        tggenable.IsOn = dr.IsDBNull(7) ? false : dr.GetBoolean(7);
                        txtpais.Text = dr.IsDBNull(8) ? "" : dr.GetString(8);
                        grd_clienteAquafeed.EditValue = dr.IsDBNull(9) ? "" : dr.GetString(9);
                    }
                    dr.Close();
                    cn.Close();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void Cerrar_from()
        {
            this.Close();
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            Cerrar_from();
        }

        private void MantenimientoClienteOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (txtnombre.Text == "")
            {
                CajaDialogo.Error("-Debe de poder identificar el nombre del destino.");
                return;
            }
            if (txtpais.Text == "")
            {
                CajaDialogo.Error("Debe de especificar el pais.");
                return;
            }
            if (grd_clienteAquafeed.EditValue == null)
            {

                CajaDialogo.Error("Debe de seleccionar el cliente de Aquafeed para hacer referencia.");
                return;
            }
            if (txtciudad.Text == "")
            {
                CajaDialogo.Error("Debe de especificar la ciudad.");
                return;
            }
            try
            {
                if (IsEditar)
                {//Editar
                    string Query = @"sp_set_direcciones_clientes";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query,cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ClienteKey);
                    cmd.Parameters.AddWithValue("@codigo", txtCodigodeSocio.Text);
                    cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
                    cmd.Parameters.AddWithValue("@codigo_pais", txtcodigoPais.Text);
                    cmd.Parameters.AddWithValue("@direccion1", txtdireccion1.Text);
                    cmd.Parameters.AddWithValue("@ciudad", txtciudad.Text);
                    cmd.Parameters.AddWithValue("@direccion2", txtdireccion2.Text);
                    cmd.Parameters.AddWithValue("@enable", tggenable.IsOn ? 1 : 0);
                    cmd.Parameters.AddWithValue("@pais", txtpais.Text);
                    cmd.Parameters.AddWithValue("@cliente_aqua", grd_clienteAquafeed.EditValue);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                else
                {

                    string Query = @"sp_insert_direcciones_clientes";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo", txtCodigodeSocio.Text);
                    cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
                    cmd.Parameters.AddWithValue("@codigo_pais", txtcodigoPais.Text);
                    cmd.Parameters.AddWithValue("@direccion1", txtdireccion1.Text);
                    cmd.Parameters.AddWithValue("@direccion2", txtdireccion2.Text);
                    cmd.Parameters.AddWithValue("@ciudad", txtciudad.Text);
                    cmd.Parameters.AddWithValue("@enable", tggenable.IsOn ? 1 : 0);
                    cmd.Parameters.AddWithValue("@pais", txtpais.Text);
                    cmd.Parameters.AddWithValue("@cliente_aqua", grd_clienteAquafeed.EditValue);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    //Crear
                }

                CajaDialogo.Information("Cambio realizado.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}