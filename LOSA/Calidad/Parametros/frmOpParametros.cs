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
using ACS.Classes;
using LOSA.Clases;
namespace LOSA.Calidad.Parametros
{
    public partial class frmOpParametros : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public enum Operacion
        {
            Nuevo = 1,
            Editar = 2
        }
        int id_parametro;

        public Operacion operacion;

        public frmOpParametros(Operacion Pop, int Parid)
        {
            InitializeComponent();
            id_parametro = Parid;
            operacion = Pop;
            load_categoria();
            load_tipo();
            if (operacion == Operacion.Editar)
            {
                load_informacion();
                labelControl3.Visible = false;
                tggenable.Visible = false;
            }
        }
        
        public void load_categoria()
        {
            string query = @"sp_get_categorias_parametros";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsParametros.categorias.Clear();
                da.Fill(dsParametros.categorias);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_tipo()
        {
            string query = @"sp_get_tipos_parametros";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsParametros.tipos.Clear();
                da.Fill(dsParametros.tipos);
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
        public void load_informacion()
        {
            string query = @"sp_load_parametro_calidad_by_id";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id_parametro);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtParametro.Text = dr.GetString(1);
                    grd_categoria.EditValue = dr.GetInt32(2);
                    tggenable.IsOn = dr.GetBoolean(3);
                    grd_aceptacion.EditValue = dr.GetInt32(4);
                    tsLlenadoPor.IsOn = dr.GetBoolean(5);
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                if ( txtParametro.Text == "")
                {
                    CajaDialogo.Error("Debe especificar el parametro que desea agregar");
                    return;
                }
                if (operacion == Operacion.Editar)
                {
                    string query = @"sp_set_update_parametros_calidadV2";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@parametro", txtParametro.Text);
                    cmd.Parameters.AddWithValue("@id_categoria", grd_categoria.EditValue);
                    cmd.Parameters.AddWithValue("@tipo_rep", grd_aceptacion.EditValue);
                    cmd.Parameters.AddWithValue("@id", id_parametro);
                    cmd.Parameters.AddWithValue("@enable", tggenable.IsOn ? 1 : 0);
                    cmd.Parameters.AddWithValue("@llenado_por", tsLlenadoPor.IsOn ? 1 : 0);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                else
                {
                    string query = @"sp_set_insert_parametros_calidad";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query,cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@parametro", txtParametro.Text);
                    cmd.Parameters.AddWithValue("@id_categoria" , grd_categoria.EditValue);
                    cmd.Parameters.AddWithValue("@tipo_rep" , grd_aceptacion.EditValue);
                    cmd.Parameters.AddWithValue("@llenado_por", tsLlenadoPor.IsOn ? 1 : 0);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}