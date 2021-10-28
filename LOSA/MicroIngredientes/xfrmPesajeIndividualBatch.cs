using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.MicroIngredientes.Models;
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

namespace LOSA.MicroIngredientes
{
    public partial class xfrmPesajeIndividualBatch : DevExpress.XtraEditors.XtraForm
    {
        //string batch_completados;
        PesajeIndividualInfo pesajeIndividual = new PesajeIndividualInfo();
        decimal limiteInferior = 0;
        decimal limiteSuperior = 0;
       public DateTime fecha;

        public xfrmPesajeIndividualBatch(string completados, string bascula, PesajeIndividualInfo pPesaje)
        {
            InitializeComponent();
            lblCompletados.Text = completados;
            lblBascula.Text = bascula;
            pesajeIndividual = pPesaje;
            lblRequerido.Text = "Valor Requerido: " + pesajeIndividual.PesoPorBatch.ToString("N2") +" Kg";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (peso_bascula >= limiteInferior && peso_bascula <= limiteSuperior)
            {
                timer1.Enabled = false;
                fecha = DateTime.Now;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lblError.Visible = true;
                lblSuperior.Visible = true;
                lblInferior.Visible = true;
            }

           
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xfrmPesajeIndividualBatch_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

          public  decimal peso_bascula = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();

            
            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("sp_get_peso_bascula_by_id", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = pesajeIndividual.BasculaID;

                peso_bascula = Convert.ToDecimal(cmd.ExecuteScalar());

                cnx.Close();

            }

            limiteInferior = pesajeIndividual.PesoPorBatch - (pesajeIndividual.PesoPorBatch * Convert.ToDecimal (0.03));
            limiteSuperior = pesajeIndividual.PesoPorBatch + (pesajeIndividual.PesoPorBatch * Convert.ToDecimal (0.03));

            lblValorBascula.Text = "Valor en Báscula: " + peso_bascula.ToString("N2")+ " Kg";
            lblInferior.Text = "Límite Inferior: " + limiteInferior.ToString("N2");
            lblSuperior.Text = "Límite Superior: " + limiteSuperior.ToString("N2");

            if (peso_bascula>=limiteInferior && peso_bascula <= limiteSuperior)
            {
                btnGuardar.Enabled = true;
                lblError.Visible = false;
                lblSuperior.Visible = false;
                lblInferior.Visible = false;
            }
            else
            {
                //lblError.Visible = true;
                //lblSuperior.Visible = true;
                //lblInferior.Visible = true;
            }
        }
    }
}