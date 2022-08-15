﻿using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
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

namespace LOSA.TransaccionesMP
{
    public partial class frmRequisiciones : Form
    {
        UserLogin UsuarioLogeado; DataOperations dp = new DataOperations();
        public frmRequisiciones(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_requisiciones_pendientes_h", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                dsTransaccionesMP1.requisiciones_h.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTransaccionesMP1.requisiciones_h);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void LoadDatos_Finalizadas()
        {
            try
            {

                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_requisiciones_pendientes_h_show_finalizadas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                dsTransaccionesMP1.requisiciones_h.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTransaccionesMP1.requisiciones_h);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnVerD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Boton ver
            var gridView = (GridView)grRequisicoinesMP.FocusedView;
            var row = (dsTransaccionesMP.requisiciones_hRow)gridView.GetFocusedDataRow();

            frmRequisicionesDetalle frm = new frmRequisicionesDetalle(UsuarioLogeado, row.id, row.Lote);
            frm.WindowState = FormWindowState.Maximized;
            if(frm.ShowDialog()== DialogResult.OK)
            {
                LoadDatos();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)grRequisicoinesMP.FocusedView;
            var row = (dsTransaccionesMP.requisiciones_hRow)gridView.GetFocusedDataRow();

            Requisiciones.Reportes.lblNumeroReq report = new Requisiciones.Reportes.lblNumeroReq(row.id, row.Lote);
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            report.ShowPrintMarginsWarning = false;
            //report.ShowPreview();
            report.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
            report.Print();

        }
        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            //Indica el numero de copias de la boleta que seran impresas
            e.PrintDocument.PrinterSettings.Copies = 1;
        }

        private void btnend_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grRequisicoinesMP.FocusedView;
                var row = (dsTransaccionesMP.requisiciones_hRow)gridView.GetFocusedDataRow();

                if (row.finalizado)
                {
                    if (MessageBox.Show("Desea Abrir de nuevo la requisa en cuestion?","Pregunta" , MessageBoxButtons.OKCancel, MessageBoxIcon.Question ) == DialogResult.OK)
                    {
                        string query = "sp_reactivar_requisa";
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@req", row.id);
                        cmd.ExecuteNonQuery();
                        cn.Close();


                        if (tggView.IsOn)
                        {
                            LoadDatos();
                        }
                        else
                        {
                            LoadDatos_Finalizadas();
                        }
                    }

                }
                else
                {
                    if (MessageBox.Show("Desea finalizar la requisa? No podra seguir enviando materia prima despues de esta accion", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {

                        string query = "sp_finalizar_requisa_v2";
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@req", row.id);
                        cmd.Parameters.AddWithValue("@user_end", UsuarioLogeado.Id);
                        cmd.ExecuteNonQuery();
                        cn.Close();


                        if (tggView.IsOn)
                        {
                            LoadDatos();
                        }
                        else
                        {
                            LoadDatos_Finalizadas();
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }

        private void tggView_Toggled(object sender, EventArgs e)
        {
            if (tggView.IsOn)                 // vista Activas
            {
                LoadDatos();
            }
            else
            {
                LoadDatos_Finalizadas();
            }
        }
    }
}
