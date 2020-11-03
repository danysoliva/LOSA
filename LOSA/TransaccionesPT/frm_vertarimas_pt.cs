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
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;
using LOSA.Tools;
using LOSA.RecepcionMP;
using DevExpress.XtraReports.UI;

namespace LOSA.TransaccionesPT
{
    public partial class frm_vertarimas_pt : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public int Id_Selected;
        public frm_vertarimas_pt(UserLogin Puser, int Pid)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            Id_Selected = Pid;
            Load_Data();
        }
        
        public void Load_Data()
        {
            string Query = @"sp_load_tarimas_from_id_produccion";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Selected", Id_Selected);
                dsPT.tarimas.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPT.tarimas);
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

        private void btnDuplicr_Click(object sender, EventArgs e)
        {
            try
            {
             

                frmInputBox frm = new frmInputBox();
                frm.Text = "Duplicar Tarima";
                frm.lblInstrucciones.Text = "Ingrese la cantidad de tarimas a duplicar:";
                frm.txtValue.Text = "1";
                frm.ValidInteger = true;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    int cant = 0;
                    try
                    {
                        cant = Convert.ToInt32(frm.txtValue.Text);
                    }
                    catch { }

                    if (cant <= 0)
                    {
                        CajaDialogo.Error("No se puede duplicar la Tarima! El valor debe ser mayor a cero.");
                        return;
                    }

                    var gridView = (GridView)grd_data.FocusedView;
                    var row = (dsPT.tarimasRow)gridView.GetFocusedDataRow();

                    ArrayList List1 = new ArrayList();

                    Tarima tar1 = new Tarima();
                    if (tar1.RecuperarRegistro(row.id))
                    {

                        for (int i = 1; i <= cant; i++)
                        {
                            try
                            {
                                DataOperations dp = new DataOperations();
                                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                                con.Open();

                                SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", con);
                                cmm.CommandType = CommandType.StoredProcedure;
                                cmm.Parameters.AddWithValue("@id", 1);
                                string barcode = cmm.ExecuteScalar().ToString();

                                string vItemCodeMP = "";
                                MateriaPrima mpx = new MateriaPrima();
                                if (mpx.RecuperarRegistroFromID_pt(row.id_producto_termiado))
                                {
                                    vItemCodeMP = mpx.CodeMP_SAP;
                                }


                                SqlCommand cmd = new SqlCommand("sp_insert_tarima_produccion", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@fechaProduccion", tar1.Fecha_produccion_pt);
                                cmd.Parameters.AddWithValue("@fechaVencimiento", tar1.FechaVencimiento);
                                cmd.Parameters.AddWithValue("@id_presentacion", tar1.IdPresentacion);
                                cmd.Parameters.AddWithValue("@usuario",UsuarioLogeado.Id);
                                cmd.Parameters.AddWithValue("@itemcode", vItemCodeMP);
                                cmd.Parameters.AddWithValue("@codigo_barra", barcode);
                                cmd.Parameters.AddWithValue("@cantidad", tar1.Cantidad);
                                cmd.Parameters.AddWithValue("@peso", tar1.Peso);
                                cmd.Parameters.AddWithValue("@Id_Alimentacion", tar1.Id_alimentacion);  
                                cmd.Parameters.AddWithValue("@lote_pt", tar1.LotePT);
                                int vid_tarima = Convert.ToInt32(cmd.ExecuteScalar());

                                List1.Add(vid_tarima);

                                con.Close();
                                //this.Close();
                            }
                            catch (Exception ec)
                            {
                                CajaDialogo.Error(ec.Message);
                            }
                        }//end for 

                        if (List1.Count > 0)
                        {
                            DialogResult r = CajaDialogo.Pregunta("Desea Imprimir la(s) Hoja(s) de Ingreso?");
                            if (r == DialogResult.Yes)
                            {
                                foreach (int i in List1)
                                {
                                    int id_tarimax = i;
                                    rptReporteTarimaPT report = new rptReporteTarimaPT(id_tarimax);
                                    report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                                    ReportPrintTool printReport = new ReportPrintTool(report);
                                    printReport.ShowPreview();
                                }
                            }
                            Load_Data();
                        }
                        List1.Clear();
                    }//end if recuperar registro
                }//end dialog 
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsPT.tarimasRow)gridView.GetFocusedDataRow();
                rptReporteTarimaPT report = new rptReporteTarimaPT(row.id);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(report);
                printReport.ShowPreview();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}