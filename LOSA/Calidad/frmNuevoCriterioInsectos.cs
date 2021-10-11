using LOSA.Calidad;
using LOSA.Clases;
using LOSA.Logistica;
using LOSA.Mantenimientos;
using LOSA.Produccion;
using LOSA.RecepcionMP;
using LOSA.TransaccionesMP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOSA.PlanMPreque;
using LOSA.TransaccionesPT;
using LOSA.AlmacenesExterno;
using LOSA.Reportes;
using LOSA.Trazabilidad;
using LOSA.Despachos;
using LOSA.Nir;
using ACS.Classes;
using System.Data.SqlClient;

namespace LOSA.Calidad
{
    public partial class frmNuevoCriterioInsectos : DevExpress.XtraEditors.XtraForm
    {
        int type = 0;
        int id = 0;
        DataOperations dp = new DataOperations();
        public frmNuevoCriterioInsectos()
        {
            InitializeComponent();
            type = 1;
            labelControl2.Visible = false;
            tggenable.Visible = false;
        }

        public frmNuevoCriterioInsectos(int Pid, string Pcriterio)
        {
            InitializeComponent();
            id = Pid;
            type = 2;
            txtolor.Text = Pcriterio;
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            if (txtolor.Text == "")
            {
                CajaDialogo.Error("No se puede guardar el registro vacio. ");
                return;
            }
            int bit_enable = 0;
            if (tggenable.IsOn)
            {
                bit_enable = 1;
            }
            else
            {
                bit_enable = 0;
            }


            if (type == 1)
            {         // nuevo
                string query = "sp_insert_insectos_criterio";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@criterio", txtolor.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }
            }
            else
            {
                string query = "sp_update_insectos_criterio";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@criterio", txtolor.Text);
                    cmd.Parameters.AddWithValue("@enable", bit_enable);
                    cmd.Parameters.AddWithValue("@id_criterio", id);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }
            }


            CajaDialogo.Information("Ajuste realizado.");
            this.DialogResult = DialogResult.OK;
        }
    }
}