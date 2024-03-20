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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using ACS.Classes;
using LOSA.Clases;
using LOSA.FromAMS;

namespace AMS.Compras.ControlInv
{
    public partial class frmrequisascs : UserControl
    {
        DataOperations dp = new DataOperations();
        public int bit = 1;


        private static frmrequisascs _instance = null;

        public UserLogin _UsuarioLogeado;

        public UserLogin UsuarioLogeado { get => _UsuarioLogeado; set => _UsuarioLogeado = value; }
        public static frmrequisascs Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmrequisascs();

                return _instance;
            }
        }


        public frmrequisascs()
        {
            InitializeComponent();
        }

        private void frmrequisascs_Load(object sender, EventArgs e)
        {
            load_data();

        }
        public void load_data()
        {
            string Query = @"[dbo].[sp_req_load_header]";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bit", bit);
                cmd.Parameters.AddWithValue("@id_user", _UsuarioLogeado.UserId);
                dsControlInv_AMS1.req_heades.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsControlInv_AMS1.req_heades);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tggabiertas_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tggabiertas.Checked)
            {
                tggabiertas.Caption = "Ocultar Cerradas";
                bit = 2;

            }
            else
            {
                tggabiertas.Caption = "Mostar todas";
                btnmisrequsas.Caption = "Mis Requisas";
                bit = 1;
            }
            load_data();
        }

        private void btnmisrequsas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bit == 1)
            {
                btnmisrequsas.Caption = "Ver Todas";  
                bit = 3;
            }
            else
            {

                btnmisrequsas.Caption = "Mis Requisas";
                bit = 1;
            }
            load_data();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void btnfin_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
                bool requisa_completada;
                SqlCommand cmd2 = new SqlCommand("dbo.uspValidarRequisaAntesDeFinalizar", cn);
                cmd2.CommandType = CommandType.StoredProcedure;
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsControlInv_AMS.req_headesRow)gridView.GetFocusedDataRow();

                cn.Open();
                cmd2.Parameters.Add("@id_req_h", row.id);

                requisa_completada = Convert.ToBoolean(cmd2.ExecuteScalar());
                cn.Close();


                if (requisa_completada == true)
                {
                    if (MessageBox.Show("Desea marcar como finalizada esta requisa?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        string Query = @"[dbo].[sp_update_activo_req]";

                        var gridView2 = (GridView)grd_data.FocusedView;
                        var row2 = (dsControlInv_AMS.req_headesRow)gridView2.GetFocusedDataRow();


                        cn.Open();
                        SqlCommand cmd = new SqlCommand(Query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_req", row2.id);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        CajaDialogo.Information("Cambio realizado!");
                        load_data();
                    }

                }
                else
                {
                    if (MessageBox.Show("Esta requisa aun no ha sido completada. Desea marcarla como finalizada?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        string Query = @"[dbo].[sp_update_activo_req]";

                        var gridView3 = (GridView)grd_data.FocusedView;
                        var row3 = (dsControlInv_AMS.req_headesRow)gridView3.GetFocusedDataRow();


                        cn.Open();
                        SqlCommand cmd = new SqlCommand(Query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_req", row3.id);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        CajaDialogo.Information("Cambio realizado!");
                        load_data();
                    }
                }


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void btnnuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOP_req frm = new frmOP_req(this.UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }
        }

        private void btn_reimprimir_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsControlInv_AMS.req_headesRow)gridView.GetFocusedDataRow();
                rpt_requisas report = new rpt_requisas(row.id);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(report);
                printReport.ShowPreview();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsControlInv_AMS.req_headesRow)gridView.GetFocusedDataRow();
                frmOP_req frm = new frmOP_req(_UsuarioLogeado, row.id);

                if (row.abierta==false)
                {
                    CajaDialogo.Error("Esta requisa esta cerrada");
                    return;
                }
                
                
                
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    load_data();
                }

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDevolucion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsControlInv_AMS.req_headesRow)grdv_data.GetFocusedDataRow();

                if (row.abierta == false)
                {
                    CajaDialogo.Error("Esta requisa esta cerrada");
                    return;
                }

                frmrequisa_devolucion frm = new frmrequisa_devolucion(_UsuarioLogeado, row.id);

                if (frm.ShowDialog()== DialogResult.OK)
                {

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnactualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_data();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _instance = null;
            this.Hide();
        }
    }
}