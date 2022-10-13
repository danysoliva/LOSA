﻿using ACS.Classes;
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
        PresentacionX PresentacionActual;

        DataOperations dp = new DataOperations();

        public frm_entrega_tarima_micros(int pidtarima, string pcodigobarra, int pidPresentacion)
        {
            InitializeComponent();
            PresentacionActual = new PresentacionX();
            PresentacionActual.RecuperarRegistro(pidPresentacion);
            IdTarima = pidtarima;
            CodigoBarra = pcodigobarra;
            LoadData();
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
            UdEnviar = dp.ValidateNumberInt32(txtPorEnviar.Text);
            CalcularKg(UdEnviar);
            if (KgEnviar <= MaximoA_Enviar)
            {
                UdEnviar += 1;
                CalcularKg(UdEnviar);
                PlaceNewNumber(UdEnviar);
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