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

namespace LOSA.Calidad
{
    public partial class frmInfoAdicional : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        int id_ingreso;
        int id_calidad;
        int id_certificado;
        int id_trasporte;
        int idop = 1; //Nuevo
        public frmInfoAdicional(UserLogin Puser, int id)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            id_ingreso = id;
            Load_data();
            validar_op();
            if (idop == 0)
            {   //editar
                
            }
            else
            {    //nuevo no hacer nada
                load_informacion_calidad();
            }
        }
        public void load_informacion_calidad()
        {
            try
            {
                string query = @"sp_load_informacion_ingreso_calidad";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", id_ingreso);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cholor.Checked = (dr.IsDBNull(0) ? false : dr.GetBoolean(0) ? true : false);
                    chcolor.Checked = (dr.IsDBNull(1) ? false : dr.GetBoolean(1) ? true : false);
                    chtextura.Checked = (dr.IsDBNull(2) ? false : dr.GetBoolean(2) ? true : false);
                    chrencion.Checked = (dr.IsDBNull(3) ? false : dr.GetBoolean(3) ? true : false);
                    chplaga.Checked = (dr.IsDBNull(4) ? false : dr.GetBoolean(4) ? true : false);
                    chdensidad.Checked = (dr.IsDBNull(5) ? false : dr.GetBoolean(5) ? true : false);
                    chhumedad.Checked = (dr.IsDBNull(7) ? false : dr.GetBoolean(7) ? true : false);
                    txtmesh.Text = (dr.IsDBNull(10) ? "" : dr.GetString(10));
                    grd_silo.EditValue = (dr.IsDBNull(11) ? 0 : dr.GetInt32(11));
                    grd_bodega.EditValue = (dr.IsDBNull(12) ? 0 : dr.GetInt32(12));
                    txtcomentario.Text = (dr.IsDBNull(14) ? "" : dr.GetString(14));
                    chpregunta1.Checked = (dr.IsDBNull(15) ? false : dr.GetBoolean(15) ? true : false);
                    chpregunta2.Checked = (dr.IsDBNull(16) ? false : dr.GetBoolean(16) ? true : false);
                    chpregunta3.Checked = (dr.IsDBNull(17) ? false : dr.GetBoolean(17) ? true : false);
                    grd_referencia.EditValue = (dr.IsDBNull(25) ? 0 : dr.GetInt32(25));
                    grd_certificado.EditValue = (dr.IsDBNull(26) ? 0 : dr.GetInt32(26));
                    grd_provedor.EditValue = (dr.IsDBNull(27) ? 0 : dr.GetInt32(27));
                    chtransporte1.Checked = (dr.IsDBNull(28) ? false : dr.GetBoolean(28) ? true : false);
                    chtransporte2.Checked = (dr.IsDBNull(29) ? false : dr.GetBoolean(29) ? true : false);
                    chtransporte3.Checked = (dr.IsDBNull(30) ? false : dr.GetBoolean(30) ? true : false);
                    id_calidad = (dr.IsDBNull(18) ? 0 : dr.GetInt32(18));
                    id_trasporte = (dr.IsDBNull(19) ? 0 : dr.GetInt32(19));
                    id_certificado = (dr.IsDBNull(24) ? 0 : dr.GetInt32(18));
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }
        public void validar_op()
        {
            try
            {
                string query = @"sp_verificar_si_existe_informacion";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id_ingreso);
                idop = Convert.ToInt32(cmd.ExecuteScalar());
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }     

        }
        public void Load_data()
        {
            string query = @"sp_load_respuestas_calidad_ingreso";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@query",4);
                dsCalidad.silo.Clear();
                dsCalidad.bodega.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCalidad.silo);
                da.Fill(dsCalidad.bodega);

                cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@query", 1);
                da = new SqlDataAdapter(cmd);
                dsCalidad.referencia.Clear();
                da.Fill(dsCalidad.referencia);

                cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@query", 3);
                da = new SqlDataAdapter(cmd);
                dsCalidad.proveedor.Clear();
                da.Fill(dsCalidad.proveedor);

                cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@query", 2);
                da = new SqlDataAdapter(cmd);
                dsCalidad.certificado.Clear();
                da.Fill(dsCalidad.certificado);
                cn.Close();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInfoAdicional_Load(object sender, EventArgs e)
        {

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (idop== 1)
            {
                string query = @"sp_salvar_informacion_calidad";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@olor", cholor.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@color", chcolor.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@texura", chtextura.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@retencion", chrencion.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@plaga", chplaga.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@densidad", chdensidad.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@humedad", chhumedad.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@temperatura", chtextura.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@mesh", txtmesh.Text == "" ? "" : txtmesh.Text);
                    cmd.Parameters.AddWithValue("@silo", grd_silo.EditValue == null ? DBNull.Value : grd_silo.EditValue);
                    cmd.Parameters.AddWithValue("@bodega", grd_bodega.EditValue == null ? DBNull.Value : grd_bodega.EditValue);
                    cmd.Parameters.AddWithValue("@observaciones", txtcomentario.Text == "" ? "" : txtcomentario.Text);
                    cmd.Parameters.AddWithValue("@id_ingreso", id_ingreso);
                    cmd.Parameters.AddWithValue("@referencia", grd_referencia.EditValue == null ? DBNull.Value : grd_referencia.EditValue);
                    cmd.Parameters.AddWithValue("@certificado", grd_certificado.EditValue == null ? DBNull.Value : grd_certificado.EditValue);
                    cmd.Parameters.AddWithValue("@proveedor", grd_provedor.EditValue == null ? DBNull.Value : grd_provedor.EditValue); 
                    cmd.Parameters.AddWithValue("@pregunta1", chpregunta1.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@pregunta2", chpregunta2.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@pregunta3", chpregunta3.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@user", UsuarioLogeado.Id);
                    cmd.Parameters.AddWithValue("@transporte1", chtransporte1.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@transporte2", chtransporte2.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@transporte3", chtransporte3.Checked ? 1 : 0);
                    cmd.ExecuteNonQuery();

                    cn.Close();
                    CajaDialogo.Information("Informacion subida.");

                    this.DialogResult = DialogResult.OK;
                    this.Close();



                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }

            }
            else
            {
                try
                {

                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }
            }
        }
    }
}