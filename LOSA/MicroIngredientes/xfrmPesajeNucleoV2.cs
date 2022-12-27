using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.MicroIngredientes.Models;
using System;
using System.Collections;
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
    public partial class xfrmPesajeNucleoV2 : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        PesajeBasculaInfo pesaje = new PesajeBasculaInfo();
        decimal limiteInferior = 0;
        decimal limiteSuperior = 0;
        public int BasculaId;
        public DateTime fecha;
        public long id_tarima_micros;
        decimal ActualAcumuladoKg;
        decimal Max_kg;
        TarimaMicroingrediente TarimaEscaneada;
        public ArrayList ListaPesajes;

        enum Basculas
        {
            Bascula1=1,
            Bascula2=2,
            Ambas=3
        }

        public xfrmPesajeNucleoV2(decimal pActualAcumuladoKg, decimal max_kg, string pMP)
        {
            //PESAJE INDIVIDUAL
            InitializeComponent();
            ListaPesajes = new ArrayList();
            TarimaEscaneada = new TarimaMicroingrediente();
            ActualAcumuladoKg = pActualAcumuladoKg;
            Max_kg = max_kg;
            lblCompletados.Text = "Pesaje Efectuado: " + string.Format("{0:###,##0.00}", ActualAcumuladoKg) + " Kg/" 
                                    + string.Format("{0:###,##0.00}", max_kg)+" Kg";
            LoadLimites(max_kg);
            timer1.Start();
        }

        private void LoadLimites(decimal pmax_kg)
        {
            limiteInferior = pmax_kg - (pmax_kg * Convert.ToDecimal(0.03));
            limiteSuperior = pmax_kg + (pmax_kg * Convert.ToDecimal(0.03));

            //lblValorBascula1.Text = "Valor en Báscula: " + peso_bascula.ToString("N2")+ " Kg";
            lblInferior.Text = "Límite Minimo: " + limiteInferior.ToString("N2") + " Kg";
            lblSuperior.Text = "Límite Maximo: " + limiteSuperior.ToString("N2") + " Kg";
            lblInferior.Visible = lblSuperior.Visible = true;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.peso_bascula_finish = pesoBasculaAcumuladoALL;
            foreach(dsMicros.MP_EscaneoRow row in dsMicros.MP_Escaneo)
            {
                ItemPesajeManualNucleo item = new ItemPesajeManualNucleo();
                item.Id_mp = row.id_mp;
                item.Lote = row.lote;
                item.Peso = row.peso;
                item.Id_tarima_micro = row.id_tarima_micro;
                item.Id_tarima_origen = row.id_tarima_origen;
                ListaPesajes.Add(item);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {  
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void xfrmPesajeIndividualBatch_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            //lblMP.Text = "MP: "+ pesaje.MateriaPrima;
        }

        public decimal peso_bascula_finish = 0;
        decimal pesoBascula1 = 0, pesoBascula2 = 0, pesoBasculaAcumulado1 = 0, pesoBasculaAcumulado2 = 0, pesoBasculaAcumuladoALL=0, pesoBasculaAcumuladoTMP1 = 0, pesoBasculaAcumuladoTMP2 = 0, pesoBasculaAcumuladoTMP_ALL=0;
        public int idTarimaOrigen=0;
        public string lote_tarima_micros;


        private void btnBascula1_Click(object sender, EventArgs e)
        {
            try
            {
                var row = (dsMicros.MP_EscaneoRow)dsMicros.MP_Escaneo.NewRow();
                row.mp = TarimaEscaneada.MateriaPrima;
                row.lote = TarimaEscaneada.LoteMP;
                lblLoteName.Text = "Lote: " + TarimaEscaneada.LoteMP;
                row.id_mp = TarimaEscaneada.Id_materiaprima;
                row.id_tarima_origen = TarimaEscaneada.IdTarimaOrigen;
                row.id_tarima_micro = TarimaEscaneada.Id;
                row.peso = pesoBasculaAcumulado1;
                
                dsMicros.MP_Escaneo.AddMP_EscaneoRow(row);
                //PesajeAcumulado = new List<LoteMPAcumulado>();

                //foreach (dsMicros.MP_EscaneoRow row in dsMicros.MP_Escaneo.Rows)
                //{

                //    PesajeAcumulado.Add(new LoteMPAcumulado
                //    {
                //        MateriaPrimaId = row.id_mp,
                //        Lote = row.lote,
                //        MateriaPrima = row.mp,
                //        TarimaOrigeId = row.id_tarima_origen,
                //        TarimaMicroId=row.id_tarima_micro,
                //        Peso=row.peso,
                //    });
                //    id_tarima_micros = row.id_tarima_micro;
                //}

                //peso_bascula_finish = PesajeAcumulado.Sum(t => t.Peso);
                ////peso_bascula_finish = Convert.ToDecimal("4.90");

                //if (peso_bascula_finish >= limiteInferior && peso_bascula_finish <= limiteSuperior)
                //{

                //    timer1.Enabled = false;
                //    fecha = dp.Now();

                //    this.DialogResult = DialogResult.OK;
                //}
                //else
                //{
                //    lblError.Visible = true;
                //    lblSuperior.Visible = true;
                //    lblInferior.Visible = true;
                //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }
            txtCodBarra.Focus();
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            //indicePeso = gvPesaje.FocusedRowHandle - 1;
            gvPesaje.DeleteRow(gvPesaje.FocusedRowHandle);
            timer1.Enabled = true;
            indicePeso = gvPesaje.RowCount - 1;
            txtCodBarra.Focus();
        }


        public List<LoteMPAcumulado> PesajeAcumulado = new List<LoteMPAcumulado>();

       private void btnBascula2_Click(object sender, EventArgs e)
        {
            try
            {
                var row = (dsMicros.MP_EscaneoRow)dsMicros.MP_Escaneo.NewRow();
                row.mp = TarimaEscaneada.MateriaPrima;
                row.lote = TarimaEscaneada.LoteMP;
                lblLoteName.Text = "Lote: " + TarimaEscaneada.LoteMP;
                row.id_mp = TarimaEscaneada.Id_materiaprima;
                row.id_tarima_origen = TarimaEscaneada.IdTarimaOrigen;
                row.id_tarima_micro = TarimaEscaneada.Id;

                row.peso = pesoBasculaAcumulado2;

                dsMicros.MP_Escaneo.AddMP_EscaneoRow(row);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }
            txtCodBarra.Focus();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            BasculaId = (int)Basculas.Bascula2;
            btnBasc1.Appearance.BackColor = default(Color);
            btnBasc2.Appearance.BackColor = ColorTranslator.FromHtml("#479DEE");
            btnBascAmbas.Appearance.BackColor = default(Color);
            txtCodBarra.Focus();
        }

        private void lblRequerido_Click(object sender, EventArgs e)
        {

        }

        private void btnBasc1_Click(object sender, EventArgs e)
        {
            BasculaId = (int)Basculas.Bascula1;
            btnBasc1.Appearance.BackColor = ColorTranslator.FromHtml("#479DEE");
            btnBasc2.Appearance.BackColor = default(Color);
            btnBascAmbas.Appearance.BackColor = default(Color);
            txtCodBarra.Focus();
        }

        private void btnBascAmbas_Click(object sender, EventArgs e)
        {
            BasculaId = (int)Basculas.Ambas;
            btnBasc1.Appearance.BackColor= default(Color);
            btnBasc2.Appearance.BackColor= default(Color);
            btnBascAmbas.Appearance.BackColor = ColorTranslator.FromHtml("#479DEE");
            txtCodBarra.Focus();
        }

        private void lblValorBascula1_Click(object sender, EventArgs e)
        {

        }

        int indicePeso = 0;
        private void txtCodBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    TarimaMicroingrediente tarima = new TarimaMicroingrediente();

                    if (!string.IsNullOrEmpty(txtCodBarra.Text))
                    {
                        //if (pesaje.MateriaPrimaID != tarima.Id_materiaprima)
                        //{
                        //    CajaDialogo.Error("La materia prima escaneada no coincide con la que se está pesando");
                        //    txtCodBarra.Text = "";
                        //    return;
                        //}

                        timer1.Enabled = true;
                        indicePeso = 0;

                        //if (BasculaId == 0)
                        //{
                        //    CajaDialogo.Error("DEBE SELECCIONAR UNA BASCULA");
                        //    return;
                        //}

                        idTarimaOrigen = tarima.IdTarimaOrigen;
                        lote_tarima_micros = tarima.LoteMP;

                        tarima.RecuperarRegistroPorCodBarra(txtCodBarra.Text);

                        if (tarima.Recuperado == true)
                        {
                            lblMP.Text = "MP: " + tarima.MateriaPrima;
                            lblLoteName.Text = "Lote: " + tarima.LoteMP;
                            txtCodBarra.Text = "";
                            id_tarima_micros = tarima.Id;
                            TarimaEscaneada = tarima;
                            txtCodBarra.Focus();

                            //var row = (dsMicros.MP_EscaneoRow)dsMicros.MP_Escaneo.NewRow();
                            //row.mp = tarima.MateriaPrima;
                            //row.lote = tarima.LoteMP;
                            //lblLoteName.Text = "Lote: " + tarima.LoteMP;
                            //row.id_mp = tarima.Id_materiaprima;
                            //row.id_tarima_origen = tarima.IdTarimaOrigen;
                            //row.id_tarima_micro = tarima.Id;

                            //if (BasculaId == 1)// (int)Basculas.Bascula1)
                            //{
                            //    row.peso = pesoBascula1;

                            //}
                            //else if (BasculaId == 2)// (int)Basculas.Bascula2)
                            //{

                            //    row.peso = pesoBascula2;
                            //}

                            //dsMicros.MP_Escaneo.Rows.Add(row);
                            //indicePeso = dsMicros.MP_Escaneo.Rows.IndexOf(row);

                            //pesoBasculaAcumulado1 = Convert.ToDecimal(colpeso.Summary[0].SummaryValue.ToString());
                            //pesoBasculaAcumulado2 = Convert.ToDecimal(colpeso.Summary[0].SummaryValue.ToString());
                            //pesoBasculaAcumuladoALL = Convert.ToDecimal(colpeso.Summary[0].SummaryValue.ToString());

                            //limiteInferior = pesaje.PesoPorBatch - (pesaje.PesoPorBatch * Convert.ToDecimal(0.03));
                            //limiteSuperior = pesaje.PesoPorBatch + (pesaje.PesoPorBatch * Convert.ToDecimal(0.03));

                            ////lblValorBascula1.Text = "Valor en Báscula: " + peso_bascula.ToString("N2")+ " Kg";
                            //lblInferior.Text = "Límite Minimo: " + limiteInferior.ToString("N2");
                            //lblSuperior.Text = "Límite Maximo: " + limiteSuperior.ToString("N2");


                            //switch (BasculaId)
                            //{
                            //    case (int)Basculas.Bascula1:
                            //        if (pesoBasculaAcumulado1 >= limiteInferior && pesoBasculaAcumulado1 <= limiteSuperior)
                            //        {
                            //            lblError.Visible = true;
                            //            lblSuperior.Visible = true;
                            //            lblInferior.Visible = true;
                            //            btnBascula1.Enabled = true;
                            //            lblError.Text = "El peso acumulado es de " + pesoBasculaAcumulado1.ToString("N2") + "Kg";
                            //            lblError.ForeColor = Color.Green;
                            //            txtCodBarra.Enabled = false;
                            //        }
                            //        else
                            //        {
                            //            btnGuardar.Enabled = true;
                            //            lblError.Visible = true;
                            //            lblSuperior.Visible = true;
                            //            lblInferior.Visible = true;
                            //            btnBascula1.Enabled = false;
                            //            btnBascula2.Enabled = false;

                            //            if (BasculaId == (int)Basculas.Bascula1)
                            //            {
                            //                lblError.Text = "El peso acumulado es de " + pesoBasculaAcumulado1 + " Kg no esta dentro de los límites de tolerancia";
                            //                lblError.ForeColor = Color.Red;
                            //            }
                            //            else
                            //            {
                            //                lblError.Text = "El peso acumulado es de " + pesoBasculaAcumulado2 + " Kg no esta dentro de los límites de tolerancia";
                            //                lblError.ForeColor = Color.Red;
                            //            }
                            //            txtCodBarra.Enabled = true;
                            //            row.peso = pesoBascula1;
                            //        }
                            //        break;

                            //    case (int)Basculas.Bascula2:
                            //        if (pesoBasculaAcumulado2 >= limiteInferior && pesoBasculaAcumulado2 <= limiteSuperior)
                            //        {
                            //            //btnGuardar.Enabled = true;
                            //            lblError.Visible = true;
                            //            lblSuperior.Visible = true;
                            //            lblInferior.Visible = true;
                            //            //peso_bascula_finish = true;
                            //            btnBascula2.Enabled = true;
                            //            lblError.Text = "El peso acumulado es de " + pesoBasculaAcumulado2.ToString("N2") + "Kg";
                            //            lblError.ForeColor = Color.Green;
                            //            txtCodBarra.Enabled = false;

                            //        }
                            //        else
                            //        {
                            //            //btnGuardar.Enabled = false;
                            //            lblError.Visible = true;
                            //            lblSuperior.Visible = true;
                            //            lblInferior.Visible = true;
                            //            btnBascula1.Enabled = false;
                            //            btnBascula2.Enabled = false;

                            //            if (BasculaId == (int)Basculas.Bascula1)
                            //            {

                            //                lblError.Text = "El peso acumulado es de " + pesoBasculaAcumulado1 + " Kg no esta dentro de los límites de tolerancia";
                            //                lblError.ForeColor = Color.Red;

                            //            }
                            //            else
                            //            {
                            //                lblError.Text = "El peso acumulado es de " + pesoBasculaAcumulado2 + " Kg no esta dentro de los límites de tolerancia";
                            //                lblError.ForeColor = Color.Red;

                            //            }
                            //            txtCodBarra.Enabled = true;
                            //            row.peso = pesoBascula2;

                            //        }
                            //        break;

                            //    case (int)Basculas.Ambas:
                            //        if (pesoBasculaAcumuladoALL >= limiteInferior && pesoBasculaAcumuladoALL <= limiteSuperior)
                            //        {
                            //            //btnGuardar.Enabled = true;
                            //            lblError.Visible = true;
                            //            lblSuperior.Visible = true;
                            //            lblInferior.Visible = true;
                            //            //peso_bascula_finish = true;
                            //            btnBascula1.Enabled = true;
                            //            btnBascula2.Enabled = true;
                            //            lblError.Text = "El peso acumulado es de " + pesoBasculaAcumuladoALL.ToString("N2") + "Kg";
                            //            lblError.ForeColor = Color.Green;
                            //            txtCodBarra.Enabled = false;

                            //        }
                            //        break;
                            //}

                        }
                        else
                        {
                            //Tarima No recuperada
                            lblLoteName.Text = "";
                            lblMP.Text = "";
                        }
                    }

                    //txtCodBarra.Text = "";
                }
                catch (Exception ex)
                {
                    txtCodBarra.Text = "";
                    txtCodBarra.Focus();                        
                    CajaDialogo.Error(ex.Message);
                }
            }
            //btnBascula2.Enabled = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();

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

                    if (item.id_bascula == 1)//(int)Basculas.Bascula1)
                    {
                        lblBascula1.Text = item.descripcion;

                        pesoBascula1 = pesoBascula1 + item.peso;

                        lblValorBascula1.Text = "Valor en Báscula: " + item.peso.ToString("N2") + " Kg";
                    }
                    else if (item.id_bascula == 2)//(int)Basculas.Bascula2)
                    {
                        lblBascula2.Text = item.descripcion;
                        pesoBascula2 = item.peso;
                        lblValorBascula2.Text = "Valor en Báscula: " + item.peso.ToString("N2") + " Kg";
                    }
                }

                decimal peso_test = 3.35M;
                pesoBasculaAcumulado1 = 1.35M;
                pesoBasculaAcumulado2 = 2.42M;

                lblValorBascula1.Text = "Valor en Báscula: " + peso_test + " Kg";//MI0000000095

            }

           

            //Bascula 1
            if (pesoBasculaAcumulado1 > 0 && pesoBasculaAcumulado1 <= limiteSuperior && TarimaEscaneada.Recuperado)
            {
                //pesoBasculaAcumulado2 = 0;
                //pesoBasculaAcumuladoALL = 0;
                lblError.Visible = true;
                lblSuperior.Visible = true;
                lblInferior.Visible = true;
                btnBascula1.Enabled = true;
                lblError.Text = "El peso acumulado es de " + pesoBasculaAcumulado1.ToString("N2") + " Kg";
                lblError.ForeColor = Color.Green;
                lblSuperior.ForeColor = Color.Green;
                lblInferior.ForeColor = Color.Green;
            }
            else
            {
                //pesoBasculaAcumulado2 = 0;
                //pesoBasculaAcumuladoALL = 0;

                //pesoBasculaAcumuladoTMP_ALL = 0;
                //pesoBasculaAcumuladoTMP2 = 0;
                //lblError.Text = "El Peso de " + pesoBasculaAcumulado1.ToString("N2") + " Kg no cumple los límite";
                //lblError.ForeColor = Color.Red;
                //lblError.Visible =true; 
                lblError.ForeColor = Color.Black;
                lblError.Visible =false;
                lblSuperior.Visible = true;
                lblInferior.Visible = true;
                btnBascula1.Enabled = false;
                btnBascula2.Enabled = false;
                lblSuperior.ForeColor = Color.Red;
                lblInferior.ForeColor = Color.Red;
            }

            //Bascula 2
            if (pesoBasculaAcumulado2 > 0 && pesoBasculaAcumulado2 <= limiteSuperior && TarimaEscaneada.Recuperado)
            {
                //pesoBasculaAcumulado1 = 0;
                //pesoBasculaAcumuladoALL = 0;
                //lblError.Visible = true;
                lblSuperior.Visible = false;
                lblInferior.Visible = false;
                btnBascula2.Enabled = true;
                lblError.Text = "El peso " + pesoBasculaAcumulado2.ToString("N2") + " Kg cumple con los límites";
                lblError.ForeColor = Color.Green;
            }
            else
            {
                //pesoBasculaAcumulado1 = 0;
                //pesoBasculaAcumuladoALL = 0;
                //pesoBascula1 = 0;

                pesoBasculaAcumuladoTMP1 = 0;
                pesoBasculaAcumuladoTMP_ALL = 0;
                //lblError.Text = "El Peso de " + pesoBasculaAcumulado2.ToString("N2") + " Kg no cumple con los límites";
                //lblError.ForeColor = Color.Red;
                //lblError.Visible = true;
                lblError.ForeColor = Color.Black;
                lblError.Visible = false;

                lblSuperior.Visible = true;
                lblInferior.Visible = true;
                //btnBascula1.Enabled = false;
                btnBascula2.Enabled = false;
                lblSuperior.ForeColor = Color.Red;
                lblInferior.ForeColor = Color.Red;
            }

            pesoBasculaAcumuladoALL = 0;
            foreach (dsMicros.MP_EscaneoRow rowp in dsMicros.MP_Escaneo)
            {
                pesoBasculaAcumuladoALL += rowp.peso;
            }

            //Peso Total
            if (pesoBasculaAcumuladoALL >= 0 && (ActualAcumuladoKg + pesoBasculaAcumuladoALL) <= limiteSuperior && TarimaEscaneada.Recuperado)
            {
                lblError.Visible = true;
                lblSuperior.Visible = true;
                lblInferior.Visible = true;
                lblError.Text = "El peso acumulado es de " + pesoBasculaAcumulado1.ToString("N2") + " Kg";
                lblError.ForeColor = Color.Green;
                lblSuperior.ForeColor = Color.Green;
                lblInferior.ForeColor = Color.Green; 
                btnGuardar.Enabled = true;
            }
            else
            {
                //pesoBasculaAcumulado2 = 0;
                //pesoBasculaAcumuladoALL = 0;
                //pesoBasculaAcumuladoTMP_ALL = 0;
                //pesoBasculaAcumuladoTMP2 = 0;
                //lblError.Text = "El Peso de " + pesoBasculaAcumulado1.ToString("N2") + " Kg no cumple los límite";
                //lblError.ForeColor = Color.Red;
                //lblError.Visible = true;
                lblError.ForeColor = Color.Black;
                lblError.Visible = false;

                lblSuperior.Visible = true;
                lblInferior.Visible = true;
                lblSuperior.ForeColor = Color.Red;
                lblInferior.ForeColor = Color.Red;
                btnGuardar.Enabled = false;
            }

        }




        public class LoteMPAcumulado
        {
            public int MateriaPrimaId { get; set; }
            public string MateriaPrima { get; set; }
            public long TarimaMicroId { get; set; }
            public int TarimaOrigeId { get; set; }
            public string Lote { get; set; }
            public decimal Peso { get; set; }
        }
}

}