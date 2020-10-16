﻿using ACS.Classes;
using LOSA.Clases;
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

namespace LOSA.RecepcionMP
{
    public partial class frmEditLoteActivo : Form
    {
        UserLogin UsuarioLogeado;
        int idLote;
        public frmEditLoteActivo(UserLogin pUsuarioLogeado, string PLote, int pId, DateTime pFecha)
        {
            InitializeComponent();
            txtLote.Text = PLote; 
            UsuarioLogeado = pUsuarioLogeado;
            dtFecha.Value = pFecha;
            idLote = pId;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLote.Text))
            {
                CajaDialogo.Error("No se puede grabar un lote en blanco!");
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringBascula);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_update_lote_activo_granel", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", txtLote.Text);
                cmd.Parameters.AddWithValue("@id", idLote);
                cmd.Parameters.AddWithValue("@fecha", dtFecha.Value);
                cmd.ExecuteNonQuery();

                con.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
