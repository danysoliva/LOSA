using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
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

namespace LOSA.MigracionACS.RRHH.Encuesta
{
    public partial class frmGestionAccesosEncuesta : Form
    {
        public frmGestionAccesosEncuesta()
        {
            InitializeComponent();
            LoadDetalleCodigos();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            frmNewAccesoEncuesta frm = new frmNewAccesoEncuesta();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadDetalleCodigos();
            }
        }

        private void LoadDetalleCodigos()
        {
            try
            {
                string query = @"sp_get_detalle_codigos_encuesta_rrhh_V2";
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAMS);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (radioGroup1.SelectedIndex < 0)
                    radioGroup1.SelectedIndex = 0;
                cmd.Parameters.AddWithValue("@filtro", radioGroup1.SelectedIndex);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsEncuesta1.codigos.Clear();
                adat.Fill(dsEncuesta1.codigos);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkTodos.Checked)
            //{
                
            //}
            //else
            //{

            //}

            foreach (dsEncuesta.codigosRow row in dsEncuesta1.codigos.Rows)
            {
                row.seleccionado = chkTodos.Checked;
            }
        }

        private void cmdDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Eliminar codigo
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsEncuesta.codigosRow)gridView.GetFocusedDataRow();
            if(row.finish)
            {
                CajaDialogo.Error("No se permite eliminar codigos completados!");
                return;
            }
            else
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringAMS);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_disable_encuesta", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo", row.codigo);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadDetalleCodigos();
                    CajaDialogo.InformationAuto();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Imprimir codigos
            int count = 0;
            //Vamos a revisar si hay elementos para imprimir
            foreach (dsEncuesta.codigosRow row2 in dsEncuesta1.codigos.Rows)
            {
                if (row2.asignado || row2.finish)
                {
                    if (row2.seleccionado)
                    {
                        count++;// = true;
                    }
                }
            }

            if (count>0)
            {
                CajaDialogo.Error("Debe seleccionar al menos un codigo. Los codigos a seleccionar no deben estar asignados ni completados...");
                return;
            }

            //Procedemos a imprimir

            //Agregamos los codigos a la lista.
            // Create new DataTable and DataSource objects.
            DataTable table = new DataTable();
            table.TableName = "table";

            // Declare DataColumn and DataRow variables.
            DataColumn column;
            DataRow row;

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "codigo";
            table.Columns.Add(column);
            
            foreach (dsEncuesta.codigosRow row1 in dsEncuesta1.codigos.Rows)
            {
                if (!row1.asignado)
                {
                    if (!row1.finish)
                    {
                        if (row1.seleccionado)
                        {
                            row = table.NewRow();

                            row["codigo"] = row1.codigo;
                            try
                            {
                                DataOperations dp = new DataOperations();
                                SqlConnection con = new SqlConnection(dp.ConnectionStringAMS);
                                con.Open();

                                SqlCommand cmd = new SqlCommand("sp_update_codigo_encuesta_rrhh", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@codigo", row1.codigo);
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                            catch (Exception ec)
                            {
                                CajaDialogo.Error("Error al marcar el codigo como asignado! Source: " + ec.Message);
                            }
                            table.Rows.Add(row);
                        }
                    }
                }
            }
            LoadDetalleCodigos();

            //Llamamos al reporte con lalista de codigos
            rptCodigosEncuesta report = new rptCodigosEncuesta() { DataSource = table, DataMember = "table", ShowPrintMarginsWarning = false };
            //RPT_OrdenCompra report = new RPT_OrdenCompra(num) { DataSource = dsCompras1, ShowPrintMarginsWarning = false };
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(report);
            printReport.ShowPreview();

        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDetalleCodigos();
        }

        private void btnEncuesta_Click(object sender, EventArgs e)
        {
            xfrmGenerarEncuesta frm = new xfrmGenerarEncuesta();

            frm.ShowDialog();
        }
    }
}
