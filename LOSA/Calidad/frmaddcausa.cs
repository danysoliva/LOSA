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
using System.Data.SqlClient;
using Core.Clases.Herramientas;

namespace LOSA.Calidad
{
    public partial class frmaddcausa : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int idcausa;
        int isedit = 0;
        public frmaddcausa()
        {
            InitializeComponent();
            load_tipotarimas();
        }

        public frmaddcausa(int id_Causa)
        {
            InitializeComponent();
            load_tipotarimas();
            idcausa = id_Causa;
            isedit = 1;
            recuperar_data();
        }
        public void recuperar_data()
        {
            string query = @"exec [dbo].[sp_load_data_causas_calidad]
		                            @id = @parametro";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@parametro", SqlDbType.Int).Value = idcausa;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtcausa.Text = dr.GetString(1);
                    grd_tipo_tarima.EditValue = dr.GetInt32(3);
                    
                }
            }
            catch (Exception ex )
            {
                CajaDialogo.Error(ex.Message);
            }


        }
        public void load_tipotarimas()
        {
            string query = @"EXEC sp_load_tipo_tarimas";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                dsCalidad.tipo_tarima.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCalidad.tipo_tarima);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtcausa.Text == "")
            {
                CajaDialogo.Error("Debe ingresar una causa antes de guardar.");
                return;
            }
            if (grd_tipo_tarima.EditValue == null)
            {
                CajaDialogo.Error("Seleccione un tipo de tarima.");
                return;
            }
            if (isedit == 0)
            {
                try
                {
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("sp_insert_causas_calidad", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@descripcion", txtcausa.Text);
                    cmd.Parameters.AddWithValue("@id_tipo", Convert.ToInt32(grd_tipo_tarima.EditValue));
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    DialogResult = DialogResult.OK;
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
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("sp_update_causa_caludad", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", idcausa);
                    cmd.Parameters.AddWithValue("@descripcion", txtcausa.Text);
                    cmd.Parameters.AddWithValue("@tipo_tarima", Convert.ToInt32(grd_tipo_tarima.EditValue));
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }

            }
        }

        private void txtcausa_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            
        }

        private void txtcausa_Click(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }
    }
}