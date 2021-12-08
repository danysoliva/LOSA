﻿using ACS.Classes;
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
    public partial class xfrmPesajeIndividualBatchV3 : DevExpress.XtraEditors.XtraForm
    {
        //string batch_completados;
        PesajeIndividualInfo pesajeIndividual = new PesajeIndividualInfo();
        decimal limiteInferior = 0;
        decimal limiteSuperior = 0;
       public DateTime fecha;

        public xfrmPesajeIndividualBatchV3(string completados, string bascula, PesajeIndividualInfo pPesaje,string pMP)
        {
            InitializeComponent();
            lblCompletados.Text = completados;
            //lblBascula.Text = bascula;
            pesajeIndividual = pPesaje;
            lblRequerido.Text = "Valor Requerido: " + pesajeIndividual.PesoPorBatch.ToString("N2") +" Kg";
            //lblBasculaAceptada.Text = pMP;
        }


        public xfrmPesajeIndividualBatchV3(string completados, string bascula, PesajeIndividualInfo pPesaje)
        {
            InitializeComponent();
            lblCompletados.Text = completados;
            //lblBascula.Text = bascula;
            pesajeIndividual = pPesaje;
            lblRequerido.Text = "Valor Requerido: " + pesajeIndividual.PesoPorBatch.ToString("N2") + " Kg";
            //lblMP.Text = pMP;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //if (peso_bascula_finish >= limiteInferior && peso_bascula_finish <= limiteSuperior)
            //{
            //    timer1.Enabled = false;
            //    fecha = DateTime.Now;
            //    this.DialogResult = DialogResult.OK;
            //}
            //else
            //{
            //    lblError.Visible = true;
            //    lblSuperior.Visible = true;
            //    lblInferior.Visible = true;
            //}

           
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xfrmPesajeIndividualBatch_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblMP.Text = "Pesaje de "+ pesajeIndividual.MateriaPrima;
        }

        public decimal peso_bascula_finish = 0;
        decimal pesoBascula1=0, pesoBascula2=0;

        private void btnBascula1_Click(object sender, EventArgs e)
        {
            if (pesoBascula1 >= limiteInferior && pesoBascula1 <= limiteSuperior)
            {
                peso_bascula_finish = pesoBascula1;
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

        private void btnBascula2_Click(object sender, EventArgs e)
        {
            if (pesoBascula2 >= limiteInferior && pesoBascula2 <= limiteSuperior)
            {
                peso_bascula_finish = pesoBascula2;
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

        private void lblValorBascula1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();
           
            //Resetear valor de peso de bascula
            pesoBascula1 = 0;
            pesoBascula2 = 0;

            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
            {
                cnx.Open();
                dsMicros.Pesaje_Bascula.Clear();
                SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_basculas_value", cnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dsMicros.Pesaje_Bascula);

                cnx.Close();

                foreach (var item in dsMicros.Pesaje_Bascula)
                {

                    if (item.id_bascula==1)
                    {
                        lblBascula1.Text = item.descripcion;
                        lblValorBascula1.Text = "Valor en Báscula: " + item.peso.ToString("N2") + " Kg";
                        pesoBascula1 = item.peso;

                    }
                    else if (item.id_bascula == 2)
                    {
                        lblBascula2.Text = item.descripcion;
                        lblValorBascula2.Text = "Valor en Báscula: " + item.peso.ToString("N2") + " Kg";
                        pesoBascula2 = item.peso;

                    }


                }

            }


            //////Test valores random para probar bascula
            //pesoBascula1 = 0;
            //pesoBascula2 = 0;

            //Random rnd = new Random();

            //pesoBascula1 = Convert.ToDecimal(rnd.NextDouble() * (0.80 - 0.70) + 0.70);
            //lblValorBascula1.Text = "Valor en Báscula: " + pesoBascula1.ToString("N2") + " Kg";

            //pesoBascula2 = Convert.ToDecimal(rnd.NextDouble() * (0.80 - 0.70) + 0.70);
            //lblValorBascula2.Text = "Valor en Báscula: " + pesoBascula2.ToString("N2") + " Kg";



            limiteInferior = pesajeIndividual.PesoPorBatch - (pesajeIndividual.PesoPorBatch * Convert.ToDecimal (0.03));
            limiteSuperior = pesajeIndividual.PesoPorBatch + (pesajeIndividual.PesoPorBatch * Convert.ToDecimal (0.03));

            //lblValorBascula1.Text = "Valor en Báscula: " + peso_bascula.ToString("N2")+ " Kg";
            lblInferior.Text = "Límite Inferior: " + limiteInferior.ToString("N2");
            lblSuperior.Text = "Límite Superior: " + limiteSuperior.ToString("N2");

            if (pesoBascula1>=limiteInferior && pesoBascula1 <= limiteSuperior)
            {
                //btnGuardar.Enabled = true;
                lblError.Visible = false;
                lblSuperior.Visible = false;
                lblInferior.Visible = false;
                //peso_bascula_finish = pesoBascula1;
                btnBascula1.Enabled = true;
            }
            else
             if (pesoBascula2 >= limiteInferior && pesoBascula2 <= limiteSuperior)
            {
                //btnGuardar.Enabled = true;
                lblError.Visible = false;
                lblSuperior.Visible = false;
                lblInferior.Visible = false;
                //peso_bascula_finish = pesoBascula2;
                btnBascula2.Enabled = true;

            }
            else
            {
                //btnGuardar.Enabled = false;
                //lblError.Visible = false;
                lblSuperior.Visible = true;
                lblInferior.Visible = true;
                btnBascula1.Enabled = false;
                btnBascula2.Enabled = false;


            }
        }
    }
}