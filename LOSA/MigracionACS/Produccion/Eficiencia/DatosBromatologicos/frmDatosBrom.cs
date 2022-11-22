﻿using ACS.Classes;
using LOSA.MigracionACS.Produccion.DataSet_;
using DevExpress.XtraGrid.Views.Grid;
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
using LOSA.Clases;
using LOSA.Classes;

namespace LOSA.MigracionACS.Produccion.Eficiencia.DatosBromatologicos
{
    public partial class frmDatosBrom : Form
    {
        DataOperations dp;
        int pIdRowPRB_H;
        UserLogin UsuarioLogeado;
        public frmDatosBrom(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            dp = new DataOperations();

            pIdRowPRB_H = 0;
            dtDesde.EditValue = dp.Now().AddDays(-1); 
            dtHasta.EditValue = dp.Now();
            LoadRegistros();
        }

        private void LoadRegistros()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();

                string sql = @"sp_get_detalle_datos_turno_brom";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReportesPRD1.header_brom.Clear();
                adat.Fill(dsReportesPRD1.header_brom);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }//End LoadDatos

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsReportesPRD.header_bromRow)gridView.GetDataRow(e.RowHandle);// .GetFocusedDataRow();
            pIdRowPRB_H = row.id;
            LoadDetalleLotes();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (pIdRowPRB_H > 0)
            {
                PRB_Lote_Pick lote_Pick = new PRB_Lote_Pick(Convert.ToDateTime(dtDesde.EditValue),
                                                            Convert.ToDateTime(dtHasta.EditValue),
                                                            pIdRowPRB_H);
                if (lote_Pick.ShowDialog() == DialogResult.Yes)
                {
                    
                    int lote = lote_Pick.lote;
                    string Descripcion = lote_Pick.Descripcion;
                    string Code = lote_Pick.Code;
                    int Formula =0;
                    int Version = 0;
                    string product_name = "";
                    APMS_OrderProduction Orden = new APMS_OrderProduction();
                    if (Orden.RecupearRegistroFromLote(lote))
                    {
                        Formula = Orden.fml_code;
                        Version = Orden.fml_version;
                        product_name = Orden.prod_name;

                        //
                        try
                        {
                            SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                            conn.Open();

                            string sql = @"sp_set_insert_detalle_datos_prb_bromatologicos";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_h", pIdRowPRB_H);
                            cmd.Parameters.AddWithValue("@lote", lote);
                            cmd.Parameters.AddWithValue("@id_user", UsuarioLogeado.UserId);//@
                            cmd.Parameters.AddWithValue("@producto_name", product_name);//@
                            cmd.Parameters.AddWithValue("@producto", Code);//@
                            cmd.Parameters.AddWithValue("@formula", Formula + "." + Version);//
                            cmd.ExecuteNonQuery();
                            LoadDetalleLotes();
                        }
                        catch (Exception ec)
                        {
                            CajaDialogo.Error(ec.Message);
                        }
                    }
                }
            }
            
        }

        private void LoadDetalleLotes()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();

                string sql = @"sp_get_detalle_datos_prb_bromatologicos";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", pIdRowPRB_H);
                dsReportesPRD1.detalle_brom.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesPRD1.detalle_brom);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            LoadRegistros();
        }

        private void cmdButtonEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("¿Realmente desea eliminar este registro?");
            if (r != DialogResult.Yes)
                return;

            var gridview = (GridView)gridControl2.FocusedView;
            var row = (dsReportesPRD.detalle_bromRow)gridview.GetFocusedDataRow();
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();

                string sql = @"sp_set_disable_row_detail_bromatologic";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.ExecuteNonQuery();
                CajaDialogo.InformationAuto();
                LoadDetalleLotes();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //var gridview = (GridView)gridControl2.FocusedView;
            //var row = (dsReportesPRD.detalle_bromRow)gridview.GetFocusedDataRow();

            ////switch (e.Column.Name)
            ////{
            ////    case "colhumedad_brom":

            ////        break;
            ////    case "colhumedad_promedio":

            ////        break;
            ////    case "colproteina_brom":

            ////        break;
            ////    case "colproteina_promedio":

            ////        break;
            ////    case "colgrasa_brom":

            ////        break;
            ////    case "colgrasa_promedio":

            ////        break;
            ////    default:
            ////        break;
            ////}

            ////
            //try
            //{
            //    SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
            //    conn.Open();

            //    string sql = @"sp_set_update_parametro_bromatologic_detail_value";
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@colname", e.Column.Name);
            //    cmd.Parameters.AddWithValue("@valor", e.Value);
            //    cmd.Parameters.AddWithValue("@id", row.id);
            //    cmd.ExecuteNonQuery();
            //    CajaDialogo.InformationAuto();
            //    LoadDetalleLotes();
            //}
            //catch (Exception ec)
            //{
            //    CajaDialogo.Error(ec.Message);
            //}
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridview = (GridView)gridControl2.FocusedView;
            var row = (dsReportesPRD.detalle_bromRow)gridview.GetFocusedDataRow();

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();

                string sql = @"sp_set_update_parametro_bromatologic_detail_value";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@colname", e.Column.Name);
                cmd.Parameters.AddWithValue("@valor", e.Value);
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.ExecuteNonQuery();
                //CajaDialogo.InformationAuto();
                LoadDetalleLotes();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }











    }
}