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

namespace LOSA.TransaccionesMP
{
    public partial class frmResumenToDevolucion : DevExpress.XtraEditors.XtraForm
    {
        int Id_Pesaje = 0;
        decimal UnidadesMaximas = 0;
        decimal UnidadesMinimas = 1;
        decimal factor;

        public decimal UnidadesActualizadas;
        public decimal KgActualizados;

        public frmResumenToDevolucion(int pId_Pesaje)
        {
            InitializeComponent();
            Id_Pesaje = pId_Pesaje;

            LoadCargarDatos();

        }

        private void LoadCargarDatos()
        {
            DataOperations dp = new DataOperations();
            try
            {
                string query = @"[sp_get_tarimas_en_proceso_bascula_for_id]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_registro", Id_Pesaje);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProduccion1.Bascula1.Clear();
                adat.Fill(dsProduccion1.Bascula1);
                conn.Close();

                AlimentacionBasculas ali = new AlimentacionBasculas();
                ali.RecuperarRegistros(Id_Pesaje);
                lblTotalUd_en_tarima.Text = txtPorEnviar.Text = ali.Unidades.ToString();
                UnidadesMaximas = ali.Unidades;
                txtKgAEnviar.Text = ali.Peso.ToString();

                if (ali.Id_Tarima > 0)
                {
                    Tarima tm = new Tarima();
                    tm.RecuperarRegistro_v3(ali.Id_Tarima,"");
                    
                    PresentacionX pres = new PresentacionX();
                    pres.RecuperarRegistro(tm.IdPresentacion);
                    txtPresentacion.Text = pres.Descripcion;
                    factor = pres.Factor;
                }

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

        private void btnUP_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtPorEnviar.EditValue) >= UnidadesMaximas)
            {
                txtPorEnviar.Text = UnidadesMaximas.ToString();
            }
            else
            {
                txtPorEnviar.Text = (Convert.ToDecimal(txtPorEnviar.EditValue) + 1).ToString();
                txtKgAEnviar.Text = (Convert.ToDecimal(txtPorEnviar.Text) * factor).ToString();

            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtPorEnviar.EditValue) <= UnidadesMinimas)
            {
                txtPorEnviar.Text = UnidadesMinimas.ToString();
            }
            else
            {
                txtPorEnviar.Text = (Convert.ToDecimal(txtPorEnviar.EditValue) - 1).ToString();
                txtKgAEnviar.Text = (Convert.ToDecimal(txtPorEnviar.Text) * factor).ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPorEnviar.Text == "0.00")
            {
                CajaDialogo.Error("Las unidades no puede ser 0!");
                return;
            }


            DialogResult r = CajaDialogo.Pregunta("Esta seguro de Actualizar la Entrega?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            UnidadesActualizadas = Convert.ToDecimal(txtPorEnviar.Text);
            KgActualizados = Convert.ToDecimal(txtKgAEnviar.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}