﻿using ACS.Classes;
using ACS.Produccion.TemperaturaMaquinas.Model;
using ACS.Produccion.TemperaturaMaquinas.Reportes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
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

namespace LOSA.MigracionACS.Produccion.TemperaturaMaquinas
{
    public partial class xfrmTemperaturaExtusora : DevExpress.XtraEditors.XtraForm
    {
        public xfrmTemperaturaExtusora()
        {
            InitializeComponent();
            load_orden_activas();
        }

        public void load_data()
        {
            //string query = @"sp_get_temperatura_extusora_log";
            string query = @"sp_get_turnos_registro_temperaturas";
            DataOperations dp = new DataOperations();

            SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                //cmd.Parameters.AddWithValue("@todos", tsVerTodosTickets.EditValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTemperatura.turnos.Clear();
                da.Fill(dsTemperatura.turnos);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        OrdenActivaConsola ordenActiva = new OrdenActivaConsola();
        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

            ordenActiva = new OrdenActivaConsola();

            if (ordenActiva.RecuperaRegistro(Convert.ToInt32( searchLookUpEdit1.EditValue)))
            {
                txtFormula.Text = ordenActiva.VersionFormula.ToString();
                txtLote.Text = ordenActiva.LotePT.ToString();
                txtProduct.Text = ordenActiva.ProductoTerminado;
                txtFormula.Text = ordenActiva.VersionFormula.ToString();
                txtVersion.Text = ordenActiva.VersionFormula.ToString() ;
            }
        }


        public void load_orden_activas()
        {
            string query = @"sp_get_Ordenes_activas_consola";
            DataOperations dp = new DataOperations();

            SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@fecha", deFecha.EditValue);

                //cmd.Parameters.AddWithValue("@todos", tsVerTodosTickets.EditValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTemperatura.OrdenActivaConsola.Clear();
                da.Fill(dsTemperatura.OrdenActivaConsola);
                cn.Close();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();

            try
            {


                //T1
                foreach (var item in dsTemperatura.Extusora)
                {
                    //CajaDialogo.Error(item.ToString());
                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                    {
                        cnx.Open();

                        SqlCommand cmd = new SqlCommand("sp_insert_transaccional_temperatura_maquinas_d", cnx);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@intervalo_hora", SqlDbType.VarChar).Value = item.intervalo_hora;
                        cmd.Parameters.Add("@id_submaquina", SqlDbType.VarChar).Value = 32;
                        cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = dtDesde.EditValue;
                        cmd.Parameters.Add("@temperatura", SqlDbType.VarChar).Value = item.T1;
                        cmd.Parameters.Add("@id_h", SqlDbType.VarChar).Value = 1;
                        cmd.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = item.Observacion;

                        cmd.ExecuteNonQuery();
                        cnx.Close();

                    }
                }


                //T2
                foreach (var item in dsTemperatura.Extusora)
                {
                    //CajaDialogo.Error(item.ToString());
                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                    {
                        cnx.Open();

                        SqlCommand cmd = new SqlCommand("sp_insert_transaccional_temperatura_maquinas_d", cnx);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@intervalo_hora", SqlDbType.VarChar).Value = item.intervalo_hora;
                        cmd.Parameters.Add("@id_submaquina", SqlDbType.VarChar).Value = 33;
                        cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = dtDesde.EditValue;
                        cmd.Parameters.Add("@temperatura", SqlDbType.VarChar).Value = item.T2;
                        cmd.Parameters.Add("@id_h", SqlDbType.VarChar).Value = 1;
                        cmd.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = item.Observacion;

                        cmd.ExecuteNonQuery();
                        cnx.Close();

                    }
                }


                //T3
                foreach (var item in dsTemperatura.Extusora)
                {
                    //CajaDialogo.Error(item.ToString());
                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                    {
                        cnx.Open();

                        SqlCommand cmd = new SqlCommand("sp_insert_transaccional_temperatura_maquinas_d", cnx);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@intervalo_hora", SqlDbType.VarChar).Value = item.intervalo_hora;
                        cmd.Parameters.Add("@id_submaquina", SqlDbType.VarChar).Value = 34;
                        cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = dtDesde.EditValue;
                        cmd.Parameters.Add("@temperatura", SqlDbType.VarChar).Value = item.T3;
                        cmd.Parameters.Add("@id_h", SqlDbType.VarChar).Value = 1;
                        cmd.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = item.Observacion;

                        cmd.ExecuteNonQuery();
                        cnx.Close();

                    }
                }


                //T4
                foreach (var item in dsTemperatura.Extusora)
                {
                    //CajaDialogo.Error(item.ToString());
                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                    {
                        cnx.Open();

                        SqlCommand cmd = new SqlCommand("sp_insert_transaccional_temperatura_maquinas_d", cnx);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@intervalo_hora", SqlDbType.VarChar).Value = item.intervalo_hora;
                        cmd.Parameters.Add("@id_submaquina", SqlDbType.VarChar).Value = 35;
                        cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = dtDesde.EditValue;
                        cmd.Parameters.Add("@temperatura", SqlDbType.VarChar).Value = item.T4;
                        cmd.Parameters.Add("@id_h", SqlDbType.VarChar).Value = 1;
                        cmd.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = item.Observacion;

                        cmd.ExecuteNonQuery();
                        cnx.Close();

                    }
                }
            



            //sub maquina 707C1
            foreach (var item in dsTemperatura.Extusora)
            {
                //CajaDialogo.Error(item.ToString());
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("sp_insert_transaccional_temperatura_maquinas_d", cnx);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@intervalo_hora", SqlDbType.VarChar).Value = item.intervalo_hora;
                    cmd.Parameters.Add("@id_submaquina", SqlDbType.VarChar).Value = 4;
                    cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = dtDesde.EditValue;
                    cmd.Parameters.Add("@temperatura", SqlDbType.Decimal).Value = item._707C1;
                    cmd.Parameters.Add("@id_h", SqlDbType.VarChar).Value = 1;
                    cmd.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = item.Observacion;

                    cmd.ExecuteNonQuery();
                    cnx.Close();

                }
            }


            //707C2
            foreach (var item in dsTemperatura.Extusora)
            {
                //CajaDialogo.Error(item.ToString());
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("sp_insert_transaccional_temperatura_maquinas_d", cnx);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@intervalo_hora", SqlDbType.VarChar).Value = item.intervalo_hora;
                    cmd.Parameters.Add("@id_submaquina", SqlDbType.VarChar).Value = 5;
                    cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = dtDesde.EditValue;
                    cmd.Parameters.Add("@temperatura", SqlDbType.VarChar).Value = item._707C2;
                    cmd.Parameters.Add("@id_h", SqlDbType.VarChar).Value = 1;
                    cmd.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = item.Observacion;

                    cmd.ExecuteNonQuery();
                    cnx.Close();

                }
            }

                CajaDialogo.Information("guardado");
                dsTemperatura.Extusora.Clear();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void bbCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtFormula.Enabled = true;
            txtLote.Enabled = true;
            txtProduct.Enabled = true;
            txtVersion.Enabled = true;
            //dtDesde.Enabled = true;
            btnFiltrar.Enabled = true;
            //bbNew.Enabled = false;
            //bbConsultar.Enabled = false;
            dsTemperatura.Extusora.Clear();

            searchLookUpEdit1.Enabled = true;
            //bbSave.Enabled = true;

        }

        int id_h = 0;
        private void bbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //bbConsultar.Enabled = false;

                DataOperations dp = new DataOperations();
                id_h = 0;
                //CajaDialogo.Error(item.ToString());
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("dbo.sp_insert_transaccional_temperatura_maquinas_h", cnx);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_orden", SqlDbType.Int).Value = ordenActiva.OrdenID;
                    cmd.Parameters.Add("@estado", SqlDbType.Int).Value = ordenActiva.Estado ;
                    cmd.Parameters.Add("@num_orden", SqlDbType.Int).Value = ordenActiva.NumOrden;
                    cmd.Parameters.Add("@cod_orden_produccion", SqlDbType.VarChar).Value = ordenActiva.CodeOrdenPRD;
                    cmd.Parameters.Add("@lote_producto_terminado", SqlDbType.Int).Value = ordenActiva.LotePT;
                    cmd.Parameters.Add("@producto", SqlDbType.VarChar).Value = ordenActiva.ProductoTerminado;
                    cmd.Parameters.Add("@codigo_formula", SqlDbType.Int).Value = ordenActiva.FormulaCod;
                    cmd.Parameters.Add("@version_formula", SqlDbType.Int).Value = ordenActiva.VersionFormula;
                    cmd.Parameters.Add("@fecha_creacion", SqlDbType.DateTime).Value = dtDesde.EditValue;


                    id_h = Convert.ToInt32( cmd.ExecuteScalar());
                    cnx.Close();

                }



                //T1
                foreach (var item in dsTemperatura.Extusora)
                {
                    //CajaDialogo.Error(item.ToString());
                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                    {
                        cnx.Open();

                        SqlCommand cmd = new SqlCommand("sp_insert_transaccional_temperatura_maquinas_d", cnx);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@intervalo_hora", SqlDbType.VarChar).Value = item.intervalo_hora;
                        cmd.Parameters.Add("@id_submaquina", SqlDbType.VarChar).Value = 32;
                        cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = dtDesde.EditValue;
                        cmd.Parameters.Add("@temperatura", SqlDbType.VarChar).Value = item.T1;
                        cmd.Parameters.Add("@id_h", SqlDbType.VarChar).Value = id_h;
                        cmd.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = item.Observacion;

                        cmd.ExecuteNonQuery();
                        cnx.Close();

                    }
                }


                //T2
                foreach (var item in dsTemperatura.Extusora)
                {
                    //CajaDialogo.Error(item.ToString());
                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                    {
                        cnx.Open();

                        SqlCommand cmd = new SqlCommand("sp_insert_transaccional_temperatura_maquinas_d", cnx);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@intervalo_hora", SqlDbType.VarChar).Value = item.intervalo_hora;
                        cmd.Parameters.Add("@id_submaquina", SqlDbType.VarChar).Value = 33;
                        cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = dtDesde.EditValue;
                        cmd.Parameters.Add("@temperatura", SqlDbType.VarChar).Value = item.T2;
                        cmd.Parameters.Add("@id_h", SqlDbType.VarChar).Value = id_h;
                        cmd.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = item.Observacion;

                        cmd.ExecuteNonQuery();
                        cnx.Close();

                    }
                }


                //T3
                foreach (var item in dsTemperatura.Extusora)
                {
                    //CajaDialogo.Error(item.ToString());
                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                    {
                        cnx.Open();

                        SqlCommand cmd = new SqlCommand("sp_insert_transaccional_temperatura_maquinas_d", cnx);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@intervalo_hora", SqlDbType.VarChar).Value = item.intervalo_hora;
                        cmd.Parameters.Add("@id_submaquina", SqlDbType.VarChar).Value = 34;
                        cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = dtDesde.EditValue;
                        cmd.Parameters.Add("@temperatura", SqlDbType.VarChar).Value = item.T3;
                        cmd.Parameters.Add("@id_h", SqlDbType.VarChar).Value = id_h;
                        cmd.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = item.Observacion;

                        cmd.ExecuteNonQuery();
                        cnx.Close();

                    }
                }


                //T4
                foreach (var item in dsTemperatura.Extusora)
                {
                    //CajaDialogo.Error(item.ToString());
                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                    {
                        cnx.Open();

                        SqlCommand cmd = new SqlCommand("sp_insert_transaccional_temperatura_maquinas_d", cnx);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@intervalo_hora", SqlDbType.VarChar).Value = item.intervalo_hora;
                        cmd.Parameters.Add("@id_submaquina", SqlDbType.VarChar).Value = 35;
                        cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = dtDesde.EditValue;
                        cmd.Parameters.Add("@temperatura", SqlDbType.VarChar).Value = item.T4;
                        cmd.Parameters.Add("@id_h", SqlDbType.VarChar).Value = id_h;
                        cmd.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = item.Observacion;

                        cmd.ExecuteNonQuery();
                        cnx.Close();

                    }
                }


                //sub maquina 707C1
                foreach (var item in dsTemperatura.Extusora)
                {
                    //CajaDialogo.Error(item.ToString());
                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                    {
                        cnx.Open();

                        SqlCommand cmd = new SqlCommand("sp_insert_transaccional_temperatura_maquinas_d", cnx);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@intervalo_hora", SqlDbType.VarChar).Value = item.intervalo_hora;
                        cmd.Parameters.Add("@id_submaquina", SqlDbType.VarChar).Value = 4;
                        cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = dtDesde.EditValue;
                        cmd.Parameters.Add("@temperatura", SqlDbType.Decimal).Value = item._707C1;
                        cmd.Parameters.Add("@id_h", SqlDbType.VarChar).Value = id_h;
                        cmd.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = item.Observacion;

                        cmd.ExecuteNonQuery();
                        cnx.Close();

                    }
                }


                //707C2
                foreach (var item in dsTemperatura.Extusora)
                {
                    //CajaDialogo.Error(item.ToString());
                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                    {
                        cnx.Open();

                        SqlCommand cmd = new SqlCommand("sp_insert_transaccional_temperatura_maquinas_d", cnx);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@intervalo_hora", SqlDbType.VarChar).Value = item.intervalo_hora;
                        cmd.Parameters.Add("@id_submaquina", SqlDbType.VarChar).Value = 5;
                        cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = dtDesde.EditValue;
                        cmd.Parameters.Add("@temperatura", SqlDbType.VarChar).Value = item._707C2;
                        cmd.Parameters.Add("@id_h", SqlDbType.VarChar).Value = id_h;
                        cmd.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = item.Observacion;

                        cmd.ExecuteNonQuery();
                        cnx.Close();

                    }
                }

                CajaDialogo.Information("TRANSACCION GUARDADA");
                dsTemperatura.Extusora.Clear();

                //bbSave.Enabled = false;
                //bbConsultar.Enabled = true;
                //bbNew.Enabled = true;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void bbConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                Transaccion_H transaccion_H = new Transaccion_H();

                txtFormula.Enabled = false;
                txtLote.Enabled = false;
                txtProduct.Enabled = false;
                txtVersion.Enabled = false;
                //dtDesde.Enabled = false;
                btnFiltrar.Enabled = false;

                searchLookUpEdit1.Enabled = false;
                //bbSave.Enabled = false;

                xfrmSelectTransaccion frm = new xfrmSelectTransaccion();

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (transaccion_H.RecuperaRegistro(frm.id_transaccion))
                    {
                        txtFormula.Text = transaccion_H.VersionFormula.ToString();
                        txtProduct.Text = transaccion_H.ProductoTerminado;
                        txtLote.Text = transaccion_H.LotePT.ToString();
                        txtVersion.Text = transaccion_H.VersionFormula.ToString();
                        dtDesde.EditValue = transaccion_H.FechaCreacion;

                        load_data_T(frm.id_transaccion);
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        public void load_data_T(Int64 id)
        {
            string query = @"dbo.sp_get_transaccion_temperatura_extusora";
            DataOperations dp = new DataOperations();

            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                //cmd.Parameters.AddWithValue("@todos", tsVerTodosTickets.EditValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTemperatura.Extusora.Clear();
                da.Fill(dsTemperatura.Extusora);
                cn.Close();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void bbClean_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dsTemperatura.Extusora.Clear();

            txtFormula.Text = "";
            txtFormula.Text = "";
            txtLote.Text = "";
            txtVersion.Text = "";
            searchLookUpEdit1.EditValue = null;
            txtProduct.Text = "";
            dtDesde.EditValue = null;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsTemperatura.turnosRow)gridView.GetFocusedDataRow();
            string query = @"sp_get_temperatura_extusora_log_v2";//por cada media hora
            //string query = @"sp_get_temperatura_extusora_log";//por cada hora
            DataOperations dp = new DataOperations();

            SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", row.fecha);
                cmd.Parameters.AddWithValue("@id_turno_acs", row.id_acs_turno);
                cmd.Parameters.AddWithValue("@id_turno_horario", row.id_turno_horario);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTemperatura.Extusora.Clear();
                da.Fill(dsTemperatura.Extusora);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdPrintReport_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsTemperatura.turnosRow)gridView.GetFocusedDataRow();
            string query = @"sp_get_temperatura_extusora_log_v2";//por cada media hora
            //string query = @"sp_get_temperatura_extusora_log";//por cada hora
            DataOperations dp = new DataOperations();

            SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", row.fecha);
                cmd.Parameters.AddWithValue("@id_turno_acs", row.id_acs_turno);
                cmd.Parameters.AddWithValue("@id_turno_horario", row.id_turno_horario);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTemperatura2.Extusora.Clear();
                da.Fill(dsTemperatura2.Extusora);
                cn.Close();


                dsTemperatura.turnosRow row1 = dsTemperatura2.turnos.NewturnosRow();
                row1.id_acs_turno = row.id_acs_turno;
                row1.order_id = row.order_id;
                row1.Lote = row.Lote;
                row1.turno = row.turno;
                row1.fecha = row.fecha;
                row1.horario = row.horario;
                row1.order_code = row.order_code;
                row1.id_turno_horario = row.id_turno_horario;
                dsTemperatura2.turnos.AddturnosRow(row1);

                rptTemperaturas report = new rptTemperaturas("Extruder") { DataSource = dsTemperatura2, ShowPrintMarginsWarning = false };
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