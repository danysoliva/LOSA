using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;
using LOSA.Clases;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.RecepcionMP;
using DevExpress.XtraReports.UI;

namespace LOSA.TransaccionesPT
{
    public partial class frm_planes_recibo_pt : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frm_planes_recibo_pt(UserLogin Puser)
        {
            InitializeComponent();
            Loda_data();
            UsuarioLogeado = Puser;
        }
         public void Loda_data()
        {
            string Query = @"sp_load_plan_produccion";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsPT.loadplanes.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPT.loadplanes);
                cn.Close();

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

        private void btnver_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsPT.loadplanesRow)gridView.GetFocusedDataRow();


                frm_vertarimas_pt frm = new frm_vertarimas_pt(UsuarioLogeado,row.id);
                frm.Show();
            }
            catch (Exception)
            {

               
            }   
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea finalizar este plan?, todas las tarimas que no se han activado se eliminaran", "Pregunta", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var gridView = (GridView)grd_data.FocusedView;
                    var row = (dsPT.loadplanesRow)gridView.GetFocusedDataRow();
                    string Query = @"sp_update_plan_tarimas_produccion";
                    try
                    {
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(Query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_selected", row.id);
                        SqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();
                        cn.Close();

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                    Loda_data();
                }
                

            }
            catch (Exception)
            {


            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (CajaDialogo.Pregunta("Desea imprimir todas las tarimas de este plan?") == DialogResult.Yes)
                {

                    var gridView = (GridView)grd_data.FocusedView;
                    var row = (dsPT.loadplanesRow)gridView.GetFocusedDataRow();
                    string Query = @"sp_returns_id_tarimas_to_print";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_alimentacion", row.id);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dsPT.PrintTm.Clear();
                    da.Fill(dsPT.PrintTm);
                    cn.Close();
                    foreach (dsPT.PrintTmRow row2 in dsPT.PrintTm.Rows)
                    {
                        rptReporteTarimaPT boleta = new rptReporteTarimaPT(row2.id);
                        boleta.ShowPrintMarginsWarning = false;
                        boleta.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                        boleta.Print();

                        updatePrinted(row2.id);


                    }
                }

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void updatePrinted(int id_tm)
        {
            string query = @"sp_set_printed_tm_pt";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tm", id_tm);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            //Indica el numero de copias de la boleta que seran impresas
            e.PrintDocument.PrinterSettings.Copies = 1;
        }
    }
}