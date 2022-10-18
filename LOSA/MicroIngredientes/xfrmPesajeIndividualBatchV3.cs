using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
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
        //PesajeIndividualInfo pesajeIndividual = new PesajeIndividualInfo();
        //PesajeManualInfo pesajeManual = new PesajeManualInfo();
        PesajeBasculaInfo pesaje = new PesajeBasculaInfo();
        decimal limiteInferior = 0;
        decimal limiteSuperior = 0;
        int BasculaId;
        public DateTime fecha;

        enum Basculas
        {
            Bascula1=1,
            Bascula2=2,
            Ambas=3
        }

        public xfrmPesajeIndividualBatchV3(string completados, string bascula, PesajeIndividualInfo pPesaje, string pMP)
        {
            InitializeComponent();
            lblCompletados.Text = completados;
            //lblBascula.Text = bascula;
            //pesajeIndividual = pPesaje;
            //lblRequerido.Text = "Valor Requerido: " + pesajeIndividual.PesoPorBatch.ToString("N2") + " Kg";
            //lblBasculaAceptada.Text = pMP;
        }


        public xfrmPesajeIndividualBatchV3(string completados, string bascula, PesajeBasculaInfo pPesaje)
        {
            InitializeComponent();
            lblCompletados.Text = completados;
            //lblBascula.Text = bascula;
            pesaje = pPesaje;
            lblRequerido.Text = "Valor Requerido: " + pesaje.PesoPorBatch.ToString("N2") + " Kg";
            //lblMP.Text = pMP;
        }


        //public xfrmPesajeIndividualBatchV3(string completados, string bascula, PesajeIndividualInfo pPesaje)
        //{
        //    InitializeComponent();
        //    lblCompletados.Text = completados;
        //    //lblBascula.Text = bascula;
        //    pesajeIndividual = pPesaje;
        //    lblRequerido.Text = "Valor Requerido: " + pesajeIndividual.PesoPorBatch.ToString("N2") + " Kg";
        //    //lblMP.Text = pMP;
        //}

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
            this.DialogResult = DialogResult.Cancel;
        }

        private void xfrmPesajeIndividualBatch_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblMP.Text = "Pesaje de "+ pesaje.MateriaPrima;
        }

        public decimal peso_bascula_finish = 0;
        decimal pesoBascula1 = 0, pesoBascula2 = 0, pesoBasculaAcumulado1 = 0, pesoBasculaAcumulado2 = 0, pesoBasculaAcumuladoALL=0, pesoBasculaAcumuladoTMP1 = 0, pesoBasculaAcumuladoTMP2 = 0, pesoBasculaAcumuladoTMP_ALL=0;
        public int idTarimaOrigen=0;
        public string lote_tarima_micros;


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

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gvPesaje.DeleteRow(gvPesaje.FocusedRowHandle);
            timer1.Enabled = true;

        }


        public List<LoteMPAcumulado> PesajeAcumulado = new List<LoteMPAcumulado>();

       private void btnBascula2_Click(object sender, EventArgs e)
        {
            try
            {
                PesajeAcumulado = new List<LoteMPAcumulado>();
            if (pesoBasculaAcumulado1 >= limiteInferior && pesoBasculaAcumulado1 <= limiteSuperior)
            {
                peso_bascula_finish = pesoBasculaAcumulado1;
                timer1.Enabled = false;
                fecha = DateTime.Now;

                foreach (dsMicros.MP_EscaneoRow row in dsMicros.MP_Escaneo.Rows)
                {

                    PesajeAcumulado.Add(new LoteMPAcumulado
                    {
                        MateriaPrimaId=row.id_mp,
                        Lote=row.lote,
                        MateriaPrima = row.mp,
                        TarimaOrigeId=row.id_tarima_origen,
                        
                    }) ;
                }

                //this.DialogResult = DialogResult.OK;
            }
            else
            if (pesoBasculaAcumulado2 >= limiteInferior && pesoBasculaAcumulado2 <= limiteSuperior)
            {
                peso_bascula_finish = pesoBasculaAcumulado2;
                timer1.Enabled = false;
                fecha = DateTime.Now;

                    foreach (dsMicros.MP_EscaneoRow row in dsMicros.MP_Escaneo.Rows)
                    {

                        PesajeAcumulado.Add(new LoteMPAcumulado
                        {
                            MateriaPrimaId = row.id_mp,
                            Lote = row.lote,
                            MateriaPrima = row.mp,
                            TarimaOrigeId = row.id_tarima_origen,
                            TarimaMicroId=row.id_tarima_micro
                            
                        });
                    }

                    this.DialogResult = DialogResult.OK;
                }
            else
            {
                lblError.Visible = true;
                lblSuperior.Visible = true;
                lblInferior.Visible = true;
            }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            BasculaId = (int)Basculas.Bascula2;
            btnBasc1.Appearance.BackColor = default(Color);
            btnBasc2.Appearance.BackColor = ColorTranslator.FromHtml("#479DEE");
            btnBascAmbas.Appearance.BackColor = default(Color);

        }

        private void btnBasc1_Click(object sender, EventArgs e)
        {
            BasculaId = (int)Basculas.Bascula1;
            btnBasc1.Appearance.BackColor = ColorTranslator.FromHtml("#479DEE");
            btnBasc2.Appearance.BackColor = default(Color);
            btnBascAmbas.Appearance.BackColor = default(Color);
        }

        private void btnBascAmbas_Click(object sender, EventArgs e)
        {
            BasculaId = (int)Basculas.Ambas;
            btnBasc1.Appearance.BackColor= default(Color);
            btnBasc2.Appearance.BackColor= default(Color);
            btnBascAmbas.Appearance.BackColor = ColorTranslator.FromHtml("#479DEE");
        }

        private void lblValorBascula1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodBarra_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                TarimaMicroingrediente tarima = new TarimaMicroingrediente();

                if (!string.IsNullOrEmpty(txtCodBarra.Text))
                {
                    //if (pesajeIndividual.MateriaPrimaID!= tarima.Id_materiaprima)
                    //{
                    //    CajaDialogo.Error("La materia prima escaneada no coincide con la que se está pesando");
                    //    return;
                    //}


                    if (BasculaId == 0)
                    {
                        CajaDialogo.Error("DEBE SELECCIONAR UNA BASCULA");
                        return;
                    }

                    idTarimaOrigen = tarima.IdTarimaOrigen;
                    lote_tarima_micros = tarima.LoteMP;

                    tarima.RecuperarRegistroPorCodBarra(txtCodBarra.Text);

                    if (tarima.Recuperado == true)
                    {
                        lblMP.Text = "MP: " + tarima.MateriaPrima;


                        var row = (dsMicros.MP_EscaneoRow)dsMicros.MP_Escaneo.NewRow();

                        row.mp = tarima.MateriaPrima;
                        row.lote = tarima.LoteMP;
                        row.id_mp = tarima.Id_materiaprima;
                        row.id_tarima_origen = tarima.IdTarimaOrigen;
                        row.id_tarima_micro = tarima.Id;

                        if (BasculaId == (int)Basculas.Bascula1)
                        {
                            row.peso = pesoBascula1;

                        }
                        else if (BasculaId == (int)Basculas.Bascula2)
                        {

                            row.peso = pesoBascula2;
                        }
                        else
                        {
                            row.peso = pesoBascula1+pesoBascula2;

                        }

                        dsMicros.MP_Escaneo.Rows.Add(row);

                        pesoBasculaAcumulado1 = Convert.ToDecimal(colpeso.Summary[0].SummaryValue.ToString());
                        pesoBasculaAcumulado2 = Convert.ToDecimal(colpeso.Summary[0].SummaryValue.ToString());
                        pesoBasculaAcumuladoALL = Convert.ToDecimal(colpeso.Summary[0].SummaryValue.ToString());




                        limiteInferior = pesaje.PesoPorBatch - (pesaje.PesoPorBatch * Convert.ToDecimal(0.03));
                        limiteSuperior = pesaje.PesoPorBatch + (pesaje.PesoPorBatch * Convert.ToDecimal(0.03));

                        //lblValorBascula1.Text = "Valor en Báscula: " + peso_bascula.ToString("N2")+ " Kg";
                        lblInferior.Text = "Límite Inferior: " + limiteInferior.ToString("N2");
                        lblSuperior.Text = "Límite Superior: " + limiteSuperior.ToString("N2");


                        switch (BasculaId)
                        {
                            case (int)Basculas.Bascula1:
                                if (pesoBasculaAcumulado1 >= limiteInferior && pesoBasculaAcumulado1 <= limiteSuperior)
                                {
                                    //btnGuardar.Enabled = true;
                                    lblError.Visible = true;
                                    lblSuperior.Visible = true;
                                    lblInferior.Visible = true;
                                    //peso_bascula_finish = pesoBascula1;
                                    btnBascula1.Enabled = true;
                                    lblError.Text = "El peso acumulado es de " + pesoBasculaAcumulado1.ToString("N2") + "Kg";
                                    lblError.ForeColor = Color.Green;
                                    lblPesoAcumulado.Visible = false;
                                    lblPesoAcumulado2.Visible = false;
                                    txtCodBarra.Enabled = false;
                                }
                                else
                                {
                                    //btnGuardar.Enabled = false;
                                    lblError.Visible = true;
                                    lblSuperior.Visible = true;
                                    lblInferior.Visible = true;
                                    btnBascula1.Enabled = false;
                                    btnBascula2.Enabled = false;
                                    lblPesoAcumulado.Visible = true;
                                    lblPesoAcumulado2.Visible = true;

                                    if (BasculaId == (int)Basculas.Bascula1)
                                    {

                                        lblError.Text = "El peso acumulado es de " + pesoBasculaAcumulado1 + " Kg no esta dentro de los límites de tolerancia";
                                        lblError.ForeColor = Color.Red;

                                    }
                                    else
                                    {
                                        lblError.Text = "El peso acumulado es de " + pesoBasculaAcumulado2 + " Kg no esta dentro de los límites de tolerancia";
                                        lblError.ForeColor = Color.Red;

                                    }
                                    txtCodBarra.Enabled = true;

                                }
                                break;

                            case (int)Basculas.Bascula2:
                                if (pesoBasculaAcumulado2 >= limiteInferior && pesoBasculaAcumulado2 <= limiteSuperior)
                                {
                                    //btnGuardar.Enabled = true;
                                    lblError.Visible = true;
                                    lblSuperior.Visible = true;
                                    lblInferior.Visible = true;
                                    //peso_bascula_finish = true;
                                    btnBascula2.Enabled = true;
                                    lblError.Text = "El peso acumulado es de " + pesoBasculaAcumulado2.ToString("N2") + "Kg";
                                    lblError.ForeColor = Color.Green;
                                    lblPesoAcumulado.Visible = false;
                                    lblPesoAcumulado2.Visible = false;
                                    txtCodBarra.Enabled = false;

                                }
                                else
                                {
                                    //btnGuardar.Enabled = false;
                                    lblError.Visible = true;
                                    lblSuperior.Visible = true;
                                    lblInferior.Visible = true;
                                    btnBascula1.Enabled = false;
                                    btnBascula2.Enabled = false;
                                    lblPesoAcumulado.Visible = true;
                                    lblPesoAcumulado2.Visible = true;

                                    if (BasculaId == (int)Basculas.Bascula1)
                                    {

                                        lblError.Text = "El peso acumulado es de " + pesoBasculaAcumulado1 + " Kg no esta dentro de los límites de tolerancia";
                                        lblError.ForeColor = Color.Red;

                                    }
                                    else
                                    {
                                        lblError.Text = "El peso acumulado es de " + pesoBasculaAcumulado2 + " Kg no esta dentro de los límites de tolerancia";
                                        lblError.ForeColor = Color.Red;

                                    }
                                    txtCodBarra.Enabled = true;

                                }
                                break;

                            case (int)Basculas.Ambas:
                                if (pesoBasculaAcumuladoALL >= limiteInferior && pesoBasculaAcumuladoALL <= limiteSuperior)
                                {
                                    //btnGuardar.Enabled = true;
                                    lblError.Visible = true;
                                    lblSuperior.Visible = true;
                                    lblInferior.Visible = true;
                                    //peso_bascula_finish = true;
                                    btnBascula1.Enabled = true;
                                    btnBascula2.Enabled = true;
                                    lblError.Text = "El peso acumulado es de " + pesoBasculaAcumuladoALL.ToString("N2") + "Kg";
                                    lblError.ForeColor = Color.Green;
                                    lblPesoAcumulado.Visible = false;
                                    lblPesoAcumulado2.Visible = false;
                                    txtCodBarra.Enabled = false;

                                }
                                break;
                        }

                    }
                }

                txtCodBarra.Text = "";
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void txtCodBarra_EditValueChanged(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();

            //Resetear valor de peso de bascula
            pesoBascula1 = 0;
            pesoBascula2 = 0;

            pesoBasculaAcumulado1= Convert.ToDecimal(colpeso.Summary[0].SummaryValue.ToString());
            pesoBasculaAcumulado2= Convert.ToDecimal(colpeso.Summary[0].SummaryValue.ToString());
            pesoBasculaAcumuladoALL= Convert.ToDecimal(colpeso.Summary[0].SummaryValue.ToString());

            pesoBasculaAcumuladoTMP1 = Convert.ToDecimal(colpeso.Summary[0].SummaryValue.ToString());
            pesoBasculaAcumuladoTMP2 = Convert.ToDecimal(colpeso.Summary[0].SummaryValue.ToString());
            pesoBasculaAcumuladoTMP_ALL = Convert.ToDecimal(colpeso.Summary[0].SummaryValue.ToString());

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

                    if (item.id_bascula==(int)Basculas.Bascula1)
                    {
                        lblBascula1.Text = item.descripcion;
                        //pesoBascula1 = pesoBascula1 + item.peso;
                        //lblValorBascula1.Text = "Valor en Báscula: " + item.peso.ToString("N2") + " Kg";

                        //pesoBascula1 = Convert.ToDecimal("0.7");
                        Random rand = new Random();
                        pesoBascula1 = rand.Next(1, 10);

                        lblValorBascula1.Text = "Valor en Báscula: " + pesoBascula1.ToString("N2") + " Kg";


                        pesoBasculaAcumuladoTMP1 = pesoBasculaAcumuladoTMP1 + pesoBascula1;
                        txtCodBarra.Focus();
                        //BasculaId = item.id_bascula;

                    }
                    else if (item.id_bascula == (int)Basculas.Bascula2)
                    {
                        lblBascula2.Text = item.descripcion;

                        //pesoBascula2 = item.peso;
                        //lblValorBascula2.Text = "Valor en Báscula: " + item.peso.ToString("N2") + " Kg";

                        pesoBascula2 = Convert.ToDecimal("0.7");
                        lblValorBascula2.Text = "Valor en Báscula: " + pesoBascula2.ToString("N2") + " Kg";

                        pesoBasculaAcumuladoTMP2 = pesoBasculaAcumuladoTMP2 + pesoBascula2;
                        //BasculaId = item.id_bascula;

                    }
                }

            }

            //pesoBasculaAcumuladoTMP1 = pesoBasculaAcumuladoTMP1 + pesoBascula1;
            //pesoBasculaAcumuladoTMP2 = pesoBasculaAcumuladoTMP2 + pesoBascula2;
            //pesoBasculaAcumuladoTMP_ALL = pesoBasculaAcumuladoTMP_ALL +pesoBascula1+ pesoBascula2;



            limiteInferior = pesaje.PesoPorBatch - (pesaje.PesoPorBatch * Convert.ToDecimal(0.03));
            limiteSuperior = pesaje.PesoPorBatch + (pesaje.PesoPorBatch * Convert.ToDecimal(0.03));

            //lblValorBascula1.Text = "Valor en Báscula: " + peso_bascula.ToString("N2")+ " Kg";
            lblInferior.Text = "Límite Inferior: " + limiteInferior.ToString("N2") + " Kg";
            lblSuperior.Text = "Límite Superior: " + limiteSuperior.ToString("N2") + " Kg";


            switch (BasculaId)
            {

                case (int)Basculas.Bascula1:

                    if (pesoBasculaAcumulado1 >= limiteInferior && pesoBasculaAcumulado1 <= limiteSuperior)
                    {
                        pesoBasculaAcumulado2 = 0;
                        pesoBasculaAcumuladoALL = 0;

                        //btnGuardar.Enabled = true;
                        lblError.Visible = true;
                        lblSuperior.Visible = true;
                        lblInferior.Visible = true;
                        //peso_bascula_finish = pesoBascula1;
                        //btnBascula1.Enabled = true;
                        lblError.Text = "El peso acumulado es de " + pesoBasculaAcumulado1.ToString("N2") + " Kg";
                        lblError.ForeColor = Color.Green;
                        lblSuperior.ForeColor = Color.Green;
                        lblInferior.ForeColor = Color.Green;
                        txtCodBarra.Enabled = false;
                        timer1.Enabled = false;
                    }
                    else
                    {
                        pesoBasculaAcumulado2 = 0;
                        pesoBasculaAcumuladoALL = 0;

                        pesoBasculaAcumuladoTMP_ALL = 0;
                        pesoBasculaAcumuladoTMP2 = 0;

                        lblError.Text = "El Peso Acumulado es de " + pesoBasculaAcumulado1 + " Kg no esta dentro de los límites de tolerancia";
                        lblError.ForeColor = Color.Red;
                        lblPesoAcumulado.Text = "P. Acumulado + Valor en Báscula:" + pesoBasculaAcumuladoTMP1.ToString("N2") + " Kg";
                        lblPesoAcumulado2.Text = "P. Acumulado + Valor en Báscula:" + pesoBasculaAcumuladoTMP2.ToString("N2") + " Kg";

                        //btnGuardar.Enabled = false;
                        lblError.Visible = true;
                        lblSuperior.Visible = true;
                        lblInferior.Visible = true;
                        btnBascula1.Enabled = false;
                        btnBascula2.Enabled = false;
                        txtCodBarra.Enabled = true;
                        lblPesoAcumulado.Visible = true;
                        lblPesoAcumulado2.Visible = true;
                        lblSuperior.ForeColor = Color.Red;
                        lblInferior.ForeColor = Color.Red;
                    }
                    break;

                case (int)Basculas.Bascula2:

                    if (pesoBasculaAcumulado2 >= limiteInferior && pesoBasculaAcumulado2 <= limiteSuperior)
                    {
                        pesoBasculaAcumulado1 = 0;
                        pesoBasculaAcumuladoALL = 0;


                        //btnGuardar.Enabled = true;
                        lblError.Visible = true;
                        lblSuperior.Visible = false;
                        lblInferior.Visible = false;
                        //peso_bascula_finish = pesoBascula2;
                        //btnBascula2.Enabled = true;
                        lblError.Text = "El peso acumulado es de " + pesoBasculaAcumulado2.ToString("N2") + " Kg";
                        lblError.ForeColor = Color.Green;
                        txtCodBarra.Enabled = false;
                        timer1.Enabled = false;

                    }
                    else
                    {
                        pesoBasculaAcumulado1 = 0;
                        pesoBasculaAcumuladoALL = 0;

                        pesoBasculaAcumuladoTMP1 = 0;
                        pesoBasculaAcumuladoTMP_ALL = 0;

                        lblError.Text = "El Peso Acumulado es de " + pesoBasculaAcumulado2 + " Kg no esta dentro de los límites de tolerancia";
                        lblError.ForeColor = Color.Red;
                        lblPesoAcumulado2.Text = "P. Acumulado + Valor en Báscula:" + pesoBasculaAcumuladoTMP2.ToString("N2") + " Kg";
                        lblPesoAcumulado.Text = "P. Acumulado + Valor en Báscula:" + pesoBasculaAcumuladoTMP1.ToString("N2") + " Kg";

                        //btnGuardar.Enabled = false;
                        lblError.Visible = true;
                        lblSuperior.Visible = true;
                        lblInferior.Visible = true;
                        btnBascula1.Enabled = false;
                        btnBascula2.Enabled = false;
                        txtCodBarra.Enabled = true;
                        lblPesoAcumulado.Visible = true;
                        lblPesoAcumulado2.Visible = true;
                        lblSuperior.ForeColor = Color.Red;
                        lblInferior.ForeColor = Color.Red;
                    }

                    break;

                case (int)Basculas.Ambas:

                    if (pesoBasculaAcumuladoALL >= limiteInferior && pesoBasculaAcumuladoALL <= limiteSuperior)
                    {
                        pesoBasculaAcumulado2 = 0;
                        pesoBasculaAcumulado1 = 0;
                        //btnGuardar.Enabled = true;
                        lblError.Visible = true;
                        lblSuperior.Visible = false;
                        lblInferior.Visible = false;
                        //peso_bascula_finish = pesoBascula2;
                        //btnBascula2.Enabled = true;
                        lblError.Text = "El peso acumulado es de " + pesoBasculaAcumuladoALL.ToString("N2") + " Kg";
                        lblError.ForeColor = Color.Green;
                        txtCodBarra.Enabled = false;
                        timer1.Enabled = false;
                    }
                    else
                    {

                        pesoBasculaAcumuladoTMP_ALL = pesoBasculaAcumuladoTMP_ALL + pesoBascula1+ pesoBascula2;

                        pesoBasculaAcumulado2 = 0;
                        pesoBasculaAcumulado1 = 0;

                        pesoBasculaAcumuladoTMP1 = 0;
                        pesoBasculaAcumuladoTMP2 = 0;

                        lblError.Text = "El Peso Acumulado es de " + pesoBasculaAcumuladoALL + " Kg no esta dentro de los límites de tolerancia";
                        lblError.ForeColor = Color.Red;
                        lblPesoAcumulado2.Text = "P. Acumulado + Valor en Báscula:" + pesoBasculaAcumuladoTMP_ALL.ToString("N2") + " Kg";
                        lblPesoAcumulado.Text = "P. Acumulado + Valor en Báscula:" + pesoBasculaAcumuladoTMP_ALL.ToString("N2") + " Kg";

                        //btnGuardar.Enabled = false;
                        lblError.Visible = true;
                        lblSuperior.Visible = true;
                        lblInferior.Visible = true;
                        btnBascula1.Enabled = false;
                        btnBascula2.Enabled = false;
                        txtCodBarra.Enabled = true;
                        lblPesoAcumulado.Visible = true;
                        lblPesoAcumulado2.Visible = true;
                        lblSuperior.ForeColor = Color.Red;
                        lblInferior.ForeColor = Color.Red;
                    }
                    break;
            }
        }

        public class LoteMPAcumulado
        {
            public int MateriaPrimaId { get; set; }
            public string MateriaPrima { get; set; }
            public long TarimaMicroId { get; set; }
            public int TarimaOrigeId { get; set; }
            public string Lote { get; set; }
        }
}

}