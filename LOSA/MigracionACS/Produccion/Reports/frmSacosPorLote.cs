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
using ACS.Classes;
using LOSA.Classes;

namespace LOSA.MigracionACS.Produccion.Reports
{
    public partial class frmSacosPorLote : DevExpress.XtraEditors.XtraForm
    {
        ReporteProceso ReporteActualClass;
        public frmSacosPorLote()
        {
            InitializeComponent();
            LoadReportesListado();
        }

        private void LoadReportesListado()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_rows_listado_reportes_proceso", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsReportesPRD1.listado_reportes.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesPRD1.listado_reportes);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gridLookUpEditListadoReportes_EditValueChanged(object sender, EventArgs e)
        {
            ReporteProceso rep1 = new ReporteProceso();
            if (rep1.RecuperarRegistro(Convert.ToInt32(gridLookUpEditListadoReportes.EditValue)))
            {
                ReporteActualClass = rep1;
                switch (rep1.tipo)
                {
                    case 1://sin parametros
                        groupBoxNumOrdenMix.Visible = groupBoxFechas.Visible = false;
                        break;

                    case 2://rango de fechas
                        groupBoxFechas.Visible = true;
                        groupBoxNumOrdenMix.Visible = false;
                        break;
                    case 3:
                        //parametro int
                        groupBoxNumOrdenMix.Visible = true;
                        groupBoxFechas.Visible = false;
                        break;
                    default:
                        break;
                }
            }

        }

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
            if(ReporteActualClass == null)
            {
                CajaDialogo.Error("Debe seleccionar un reporte!");
                gridLookUpEditListadoReportes.Focus();
                return;
            }

            //grDetalle.DataSource = "";


            grDetalle.DataSource = null;
            gridView1.Columns.Clear();



            DataOperations dp = new DataOperations();
            SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
            SqlCommand cmd = new SqlCommand(ReporteActualClass.StoredProcedure);
            cmd.CommandType = CommandType.StoredProcedure;

            switch (ReporteActualClass.tipo)
            {
                case 1:
                    //Sin parametros
                    try
                    {
                        con.Open();
                        cmd.Connection = con;
                        DataTable tablon = new DataTable();
                        SqlDataAdapter adat = new SqlDataAdapter(cmd);
                        adat.Fill(tablon);
                        grDetalle.DataSource = tablon;
                        con.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;

                case 2:
                    //rango de fechas
                    try
                    {
                        con.Open();
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                        cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                        DataTable tablon = new DataTable();
                        SqlDataAdapter adat = new SqlDataAdapter(cmd);
                        adat.Fill(tablon);
                        grDetalle.DataSource = tablon;

                        con.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
                case 3:
                    //Sin parametros
                    try
                    {
                        con.Open();
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@intpar", txtNumeroOrden.Text);
                        DataTable tablon = new DataTable();
                        SqlDataAdapter adat = new SqlDataAdapter(cmd);
                        adat.Fill(tablon);
                        grDetalle.DataSource = tablon;

                        con.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
            }
            
        }

        private void txtNumeroOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}