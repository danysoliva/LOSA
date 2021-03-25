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
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.TransaccionesPT
{
    public partial class frm_editar_tm : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int id;
        public int id_pt;
        public string itemcode;
        public decimal factor;
        int id_presentacion;
        public frm_editar_tm(int id)
        {
            InitializeComponent();
            this.id = id;
            LoadPresentaciones();
            load();
        }

        private void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_presentaciones_activas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPT.presentacion.Clear();
                adat.Fill(dsPT.presentacion);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        public void load()
        {
            string query = @"sp_load_tarimas_to_edit_tm";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query,cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_tm", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dt_ingreso.EditValue = dr.IsDBNull(0) ? DateTime.Now : dr.GetDateTime(0);
                dt_vencimiento.EditValue = dr.IsDBNull(1) ? DateTime.Now.AddDays(150) : dr.GetDateTime(1);
                txtlote.Text = dr.IsDBNull(2) ? "No COnfig" : dr.GetInt32(2).ToString();
                grd_presentacion.EditValue = dr.IsDBNull(11)? 0 : dr.GetInt32(11);
                dt_produccion.EditValue = dr.IsDBNull(6) ? DateTime.Now : dr.GetDateTime(6);
                txt_unidades.Text = dr.IsDBNull(7) ? "1" : dr.GetDecimal(7).ToString();
                txt_peso.Text = dr.IsDBNull(8) ? "0" : dr.GetDecimal(8).ToString();
                id_pt = dr.IsDBNull(5) ? 0 : dr.GetInt32(5);
                txt_producto.Text = dr.IsDBNull(12) ? " " : dr.GetString(12);
                itemcode = dr.IsDBNull(13) ? "  " : dr.GetString(13); 


            }
            dr.Close();
            cn.Close();
            
        }

        private void grd_presentacion_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                id_presentacion = Convert.ToInt32(grd_presentacion.EditValue);
                foreach (dsPT.presentacionRow row in dsPT.presentacion.Rows)
                {
                    if (id_presentacion == row.id)
                    {
                        factor = row.factor;
                    }
                }
                txt_peso.Text = (factor * Convert.ToInt32(txt_unidades.Text)).ToString();
            }
            catch (Exception ex)
            {

               
            }
        }

        private void txt_unidades_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
          
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_unidades_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                id_presentacion = Convert.ToInt32(grd_presentacion.EditValue);
                foreach (dsPT.presentacionRow row in dsPT.presentacion.Rows)
                {
                    if (id_presentacion == row.id)
                    {
                        factor = row.factor;
                    }
                }
                txt_peso.Text = (factor * Convert.ToInt32(txt_unidades.Text)).ToString();
            }
            catch (Exception ex)
            {


            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txt_unidades.Text == "0" ) 
            {
                CajaDialogo.Error("No puede guardar una tarima con 0 unidades.");
                return;
            }
            if (txt_peso.Text == "0")
            {
                CajaDialogo.Error("No puede guardar una tarima con 0 de peso.");
                return;
            }
            if (grd_presentacion.EditValue == null)
            {
                CajaDialogo.Error("Debe seleccionar una presentacion para poder guardar la informacion.");
                return;
            }
            string query = @"sp_update_tarima_pt";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", id_pt);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@f_ingreso", dt_ingreso.EditValue);
                cmd.Parameters.AddWithValue("@f_vencimiento", dt_vencimiento.EditValue);
                cmd.Parameters.AddWithValue("@f_produccion" , dt_produccion.EditValue);
                cmd.Parameters.AddWithValue("@cantidad", txt_unidades.Text);
                cmd.Parameters.AddWithValue("@peso", txt_peso.Text);
                cmd.Parameters.AddWithValue("@itemcode", itemcode);
                cmd.Parameters.AddWithValue("@id_presentacion", grd_presentacion.EditValue);
                cmd.ExecuteNonQuery();

                CajaDialogo.Information("Cambio realizado exitosamente");
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