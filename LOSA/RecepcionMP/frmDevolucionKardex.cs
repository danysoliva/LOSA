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
    public partial class frmDevolucionKardex : Form
    {
        private int idTarima;
        private decimal factorPresentacion;
        UserLogin usuarioLogueado = new UserLogin();
        public frmDevolucionKardex(UserLogin pUsuarioLogueado)
        {
            InitializeComponent();
            usuarioLogueado = pUsuarioLogueado;
        }

        private void CmdSelectTarima_Click(object sender, EventArgs e)
        {
            frmTarimas frm = new frmTarimas((int)opcionAbrirVentanaTarima.Opciones.ventanaDevoluciones);
            Tarima InfoTarima = new Tarima();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (InfoTarima.RecuperarRegistro(frm.idTarima, ""))
                {
                    factorPresentacion = InfoTarima.Factor;


                    this.idTarima = frm.idTarima;
                    beTarima.Text = frm.idTarima.ToString();
                    gcTarima.DataSource = CreateDataTarima(frm.idTarima, frm.proveedor, frm.nombreTarima, frm.lote, frm.presentacion);
                    //gvTarima.InitNewRow += GridView1_InitNewRow;
                    gvTarima.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);

                    TxtCantidadT_Leave(sender, e);
                }

            }
        }

        private DataTable CreateDataTarima(int idTarima, string pProveedor, string pNombreTarima, string pLote, string pPpresentacion)
        {
            DataTable dt = new DataTable();

            try
            {
                dt.Columns.Add("Detalle", typeof(string));
                dt.Columns.Add("Valor", typeof(string));


                dt.Rows.Add("TARIMA", idTarima);
                dt.Rows.Add("PROVEEDOR", pProveedor);
                dt.Rows.Add("LOTE", pLote);
                dt.Rows.Add("PRESENTACION", pPpresentacion);

                return dt;
            }
            catch (Exception error)
            {
                CajaDialogo.Information(error.Message);
                return dt;
            }
        }

        private void TxtCantidadT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPeso.Text = Math.Round(factorPresentacion * Convert.ToDecimal(txtCantidadT.Text), 2).ToString();
            }
        }

        private void TxtCantidadT_Leave(object sender, EventArgs e)
        {
            txtPeso.Text = Math.Round((factorPresentacion * Convert.ToDecimal(txtCantidadT.Text)), 2).ToString();
        }

        private void TxtCantidadT_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            bool Guardado = false;
            int vid_tarima = 0;

            if (gvTarima.RowCount <= 0)
            {
                CajaDialogo.Error("Debe seleccionar una tarima");
                return;
            }

            if (Convert.ToDecimal(txtCantidadT.Text) <= 0)
            {
                CajaDialogo.Error("Debe ingresar una cantidad mayor que cero (0)");
                return;
            }

            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_insert_kardex_from_devoluciones_form", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tarima", this.idTarima);
                cmd.Parameters.AddWithValue("@tipo_transaccion", 1);
                cmd.Parameters.AddWithValue("@cantidad", Convert.ToDecimal(txtCantidadT.Text));
                cmd.Parameters.AddWithValue("@id_usuario", Convert.ToInt32(usuarioLogueado.Id));
                //cmd.Parameters.AddWithValue("@fecha", dp.Now());
                cmd.Parameters.AddWithValue("@peso", Convert.ToDecimal(txtPeso.Text));
                cmd.ExecuteNonQuery();
                Guardado = true;
                con.Close();
                //CajaDialogo.InformationAuto();

            }
            catch (Exception ec)
            {
                Guardado = false;
                CajaDialogo.Error(ec.Message);
            }

            if (Guardado == true)
            {
                CajaDialogo.Information("Datos guardados exitosamente!");
                this.Close();
            }
        }

        private void BeTarima_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            beTarima.Text = "";
            gcTarima.DataSource = null;
        }
    }
}