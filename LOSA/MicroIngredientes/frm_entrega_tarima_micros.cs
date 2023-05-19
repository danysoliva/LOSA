using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.Micro;
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
    public partial class frm_entrega_tarima_micros : DevExpress.XtraEditors.XtraForm
    {
        int IdTarima;
        string CodigoBarra;
        public decimal UdEnviar;
        public decimal KgEnviar;
        decimal MaximoA_Enviar;
        int Ud_MaximoA_Enviar;

        int IdMP;
        string LoteMP;
        PresentacionX PresentacionActual;

        DataOperations dp = new DataOperations();

        public enum TipoTransaccion
        {
            ConTarima =1,
            SinTarima =2
        }

        TipoTransaccion TipoTransaccionActual;
        public frm_entrega_tarima_micros(int pidtarima, string pcodigobarra, int pidPresentacion)
        {
            InitializeComponent();
            TipoTransaccionActual = TipoTransaccion.ConTarima;
            PresentacionActual = new PresentacionX();
            if (PresentacionActual.RecuperarRegistro(pidPresentacion))
                lblPresentacion.Text = PresentacionActual.Descripcion;
            
            IdTarima = pidtarima;
            CodigoBarra = pcodigobarra;
            LoadData();
        }


        public frm_entrega_tarima_micros(int pidMP,  int pIdLoteALOSY, string pLote)
        {
            InitializeComponent();
            TipoTransaccionActual = TipoTransaccion.SinTarima;
            PresentacionActual = new PresentacionX();
            LoteMP lot1 = new LoteMP();
            if (lot1.RecuperarRegistro(pIdLoteALOSY))
            {
                if (PresentacionActual.RecuperarRegistro(lot1.IdPresentacion))
                    lblPresentacion.Text = PresentacionActual.Descripcion;
                
            }
            IdMP = pidMP;
            LoteMP = pLote;
            LoadDataSinTarima();
        }

        public frm_entrega_tarima_micros(int pidMP, int pIdTarima, string pLote, decimal pCantidadMaxima, int pUdMaxEnviar )
        {
            InitializeComponent();
            TipoTransaccionActual = TipoTransaccion.SinTarima;
            PresentacionActual = new PresentacionX();
            MaximoA_Enviar = pCantidadMaxima;
            Ud_MaximoA_Enviar = pUdMaxEnviar;
            Tarima tar1 = new Tarima();
            //if (lot1.RecuperarRegistro(pIdLoteALOSY))
            //{
            //    if (PresentacionActual.RecuperarRegistro(lot1.IdPresentacion))
            //        lblPresentacion.Text = PresentacionActual.Descripcion;
            //}
            IdMP = pidMP;
            LoteMP = pLote;

            if (Ud_MaximoA_Enviar == 0)
            {
                txtPorEnviar.EditValue = 0;
                txtKgEnviar.EditValue = MaximoA_Enviar;
                btnUP.Enabled = false;
                btnDown.Enabled = false;
            }
            else
            {
                tar1.RecuperarRegistro(pIdTarima);
                if (PresentacionActual.RecuperarRegistro(tar1.IdPresentacion))
                    lblPresentacion.Text = PresentacionActual.Descripcion;

                LoadDataSinTarima();
            }
            //if (tar1.RecuperarRegistro(pIdTarima))
            //{
            //    if (PresentacionActual.RecuperarRegistro(tar1.IdPresentacion))
            //        lblPresentacion.Text = PresentacionActual.Descripcion;
            //}
            
        }

        private void LoadData()
        {
            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                SqlCommand cmd = new SqlCommand("[sp_get_lotes_micro_ingredientes_V5]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tarima", IdTarima);
                cmd.Parameters.AddWithValue("@bar_code", CodigoBarra);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMicro2.informacionPRD_micro.Clear();
                adat.Fill(dsMicro2.informacionPRD_micro);
                UdEnviar = 0;
                KgEnviar = 0;
                foreach(dsMicro.informacionPRD_microRow row in dsMicro2.informacionPRD_micro)
                { 
                    if (row.existencia > 0)
                        MaximoA_Enviar += row.existencia;
                }
                CalcularUnidades(KgEnviar);
                
                PlaceNewNumber(0);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDataSinTarima()
        {
            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                SqlCommand cmd = new SqlCommand("[sp_get_lotes_micro_ingredientes_V6]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", LoteMP);
                cmd.Parameters.AddWithValue("@id_mp", IdMP);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMicro2.informacionPRD_micro.Clear();
                adat.Fill(dsMicro2.informacionPRD_micro);
                UdEnviar = 0;
                KgEnviar = 0;
                foreach (dsMicro.informacionPRD_microRow row in dsMicro2.informacionPRD_micro)
                {
                    if (row.existencia > 0)
                        MaximoA_Enviar += row.existencia;
                }
                CalcularUnidades(KgEnviar);

                PlaceNewNumber(0);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void CalcularUnidades(decimal kgEnviar)
        {
            if(PresentacionActual != null)
            {
                if (PresentacionActual.Recuperado)
                {
                    if (PresentacionActual.Factor > 0)
                        UdEnviar = KgEnviar / PresentacionActual.Factor;
                }
            }
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            //up            
            //switch (TipoTransaccionActual)
            //{
            //    case TipoTransaccion.ConTarima:
            if(Ud_MaximoA_Enviar>0)
            {
                UdEnviar = dp.ValidateNumberInt32(txtPorEnviar.Text);
                //CalcularKg(UdEnviar);
                if (UdEnviar < Ud_MaximoA_Enviar)
                {
                    UdEnviar += 1;
                    CalcularKg(UdEnviar);
                    PlaceNewNumber(UdEnviar);
                }
            }
            else
            {
                UdEnviar = dp.ValidateNumberInt32(txtPorEnviar.Text);
                CalcularKg(UdEnviar);
                if (KgEnviar <= MaximoA_Enviar)
                {
                    UdEnviar += 1;
                    CalcularKg(UdEnviar);
                    PlaceNewNumber(UdEnviar);
                }
            }
            

            
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            //down
            UdEnviar = dp.ValidateNumberInt32(txtPorEnviar.Text);
            if (UdEnviar > 0)
            {
                UdEnviar -= 1;
                CalcularKg(UdEnviar);
                PlaceNewNumber(UdEnviar);
            }
        }

        private void CalcularKg(decimal udEnviar)
        {
            KgEnviar = UdEnviar * PresentacionActual.Factor;
        }

        private void PlaceNewNumber(decimal pudEnviar)
        {
            txtPorEnviar.Text = pudEnviar.ToString();
            txtKgEnviar.Text = KgEnviar.ToString();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(UdEnviar == 0)
            {
                CajaDialogo.Error("Debe enviar al menos una unidad!");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}