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

namespace LOSA.RecepcionMP
{
    public partial class frmeditarLote : DevExpress.XtraEditors.XtraForm
    {
        public int id_L;
        int id_mp;
        string sapcode;
        DataOperations dp = new DataOperations();
        public frmeditarLote(int id_lote)
        {
            InitializeComponent();
            id_L = id_lote;
            load_data();
        }
        public void load_data()
        {
            string query = @"sp_load_informacion_of_ingreso_lote";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id_L);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtingreso.Text = dr.IsDBNull(1) ? "0" : dr.GetSqlInt32(1).ToString();
                    txtlote.Text = dr.IsDBNull(2) ? " " : dr.GetString(2);
                    txtmp.Text = dr.IsDBNull(6) ? " " : dr.GetString(6);
                    sapcode = dr.IsDBNull(7) ? " " : dr.GetString(7);

                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }    

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtlote.Text == "")
            {
                CajaDialogo.Error("El lote de materia prima no puede quedar vacio.");
                return;
            }
            if (txtmp.Text == "")
            {
                CajaDialogo.Error("La materia prima seleccionada no puede quedar vacia.");
                return;
            }
            string query = @"sp_update_losa_ingreso_lotes";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", txtlote.Text);
                cmd.Parameters.AddWithValue("@id", id_L);
                cmd.Parameters.AddWithValue("@sapcode", sapcode);
                cmd.ExecuteNonQuery();
                cn.Close();
                CajaDialogo.Information("Transaccion exitosa!");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnpick_Click(object sender, EventArgs e)
        {
            frmMP frm = new frmMP();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                sapcode = frm.ItemCode;
                txtmp.Text = frm.MateriaPrima;
            }
        }
    }
}