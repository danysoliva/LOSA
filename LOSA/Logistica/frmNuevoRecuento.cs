﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOSA.Clases;
using ACS.Classes;
using System.Data.SqlClient;
using System.Linq;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;

namespace LOSA.Logistica
{
    public partial class frmNuevoRecuento : DevExpress.XtraEditors.XtraForm
    {
        Recuento NuevoRecuento;
        UserLogin UsuarioLogeado;
        int tabActive;
        int DEFAULT_VALUE = 0;
        DataOperations dp = new DataOperations();
        public frmNuevoRecuento(UserLogin Puser)
        {
            InitializeComponent();
            tabActive = DEFAULT_VALUE;
            UsuarioLogeado = Puser;
            NuevoRecuento = new Recuento();
            get_years();
            get_bodegas();
        }

            
        public void get_bodegas()
        {
            string query = @"sp_get_bodegas_id_descripcion";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsCierreMes.bodegas.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCierreMes.bodegas);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void get_meses_by_year()
        {
            string query = @"sp_get_meses_disponible_por_ejercicio";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@year", NuevoRecuento.year);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCierreMes.meses.Clear();
                da.Fill(dsCierreMes.meses);
                cn.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void get_years()
        {
            string query = @"sp_obtener_años_disponibles";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCierreMes.years.Clear();
                da.Fill(dsCierreMes.years);
                cn.Close();
               
                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class Recuento
        {
            public int mes;
            public string mes_name;
            public int year;
            public string comentario;
            public DateTime date_counted;
            private int DEFAULT_VALUE = 0;

            public Recuento()
            {
                mes = DEFAULT_VALUE;
                mes_name = "";
                year = DEFAULT_VALUE;
                comentario = "";
            }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            tabActive = xtraTabControl1.SelectedTabPageIndex;
        }

        private void grd_meses_disponibles_EditValueChanged(object sender, EventArgs e)
        {
            NuevoRecuento.mes = Convert.ToInt32(grd_meses_disponibles.EditValue);
            NuevoRecuento.mes_name = grd_meses_disponibles.Text;
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            NuevoRecuento.year = Convert.ToInt32(grd_years.EditValue);
            if (NuevoRecuento.year != DEFAULT_VALUE)
            {
                grd_meses_disponibles.Enabled = true;
                get_meses_by_year();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_selecionarProducto frm = new frm_selecionarProducto(tabActive);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (tabActive == 0)
                {
                    DataRow dr = dsCierreMes.Recuento_mp.NewRow();
                    dr["id_mp"] = frm.id;
                    dr["descripcion"] = frm.descripcion;
                    dr["odoo"] = frm.codigo;
                    dr["peso"] = DEFAULT_VALUE;
                    dr["diferencia"] = DEFAULT_VALUE;
                    dr["id_bodega"] = DEFAULT_VALUE;
                    dr["ExistenciaAprox"] = DEFAULT_VALUE;
                    dsCierreMes.Recuento_mp.Rows.Add(dr);
                    dsCierreMes.Recuento_mp.AcceptChanges();
                }
                else
                {
                    DataRow dr = dsCierreMes.Recuento_pt.NewRow();
                    dr["id_mp"] = frm.id;
                    dr["descripcion"] = frm.descripcion;
                    dr["odoo"] = frm.codigo;
                    dr["peso"] = DEFAULT_VALUE;
                    dr["diferencia"] = DEFAULT_VALUE;
                    dr["id_bodega"] = DEFAULT_VALUE;
                    dr["ExistenciaAprox"] = DEFAULT_VALUE;
                    dsCierreMes.Recuento_pt.Rows.Add(dr);
                    dsCierreMes.Recuento_pt.AcceptChanges();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                grdv_dataMP.DeleteRow(grdv_dataMP.FocusedRowHandle);
                dsCierreMes.Recuento_mp.AcceptChanges();
            }
            catch (Exception )
            {

            }
        }

        private void btneliminarpt_Click(object sender, EventArgs e)
        {
            try
            {
                grdv_data_pt.DeleteRow(grdv_data_pt.FocusedRowHandle);
                dsCierreMes.Recuento_pt.AcceptChanges();
            }
            catch (Exception)
            {

            }
        }

        private void grdv_dataMP_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridColumn colBodega = view.Columns["colid_bodega"];
            var gridView = (GridView)grd_dataMp.FocusedView;
            var RowSelecionada = (dsCierreMes.Recuento_mpRow)gridView.GetFocusedDataRow();
            //Get the value of the first column
            //Get the value of the second column
            //Validity criterion
            IEnumerable<DataRow> YaEstaLabodega = from row in dsCierreMes.Recuento_mp.AsEnumerable()
                                                  where row.id_mp == RowSelecionada.id_mp && row.id_bodega == Convert.ToInt32(RowSelecionada.id_bodega)
                                                  select row;

            if (YaEstaLabodega.Count() > 1)
            {
                e.Valid = false;
                view.SetColumnError(colBodega, "Se ha seleccionado dos veces la misma bodega para una materia prima.",DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
                
            }

            //Bueno si nos dejan... nos vamos a querer toda la bici... bueno vamo a calcular cuanto inventario tenemos 
            //-- Siempre pongo las dos guiones como que si estuviera en SQL server
            // Si lees esto me deben un cafe, sea quien seas. Hail Marathon. att Rodrigo  si ya me botaron 94388749   o mandame una captura de este
            // Mensaje y dime que te parecio mi codigo, no es mucho pero es trabajo honesto es una broma muy famosa en el año 2021. 

            int id_mp_selected = RowSelecionada.id_mp;
            // vamos a consultar en el kardex el invenario de esta MP.
            Kardex RegistroMP = new Kardex();
            if (RegistroMP.GetTotalInventarioKgByMp(id_mp_selected,RowSelecionada.id_bodega))
            {
                RowSelecionada.ExistenciaAprox = RegistroMP.TotalInventarioMP;
                RowSelecionada.diferencia = RowSelecionada.ExistenciaAprox - RowSelecionada.peso;
                RowSelecionada.AcceptChanges();   
            }
            else
            { 
                RowSelecionada.diferencia = 0 - RowSelecionada.peso;
                RowSelecionada.AcceptChanges();
            }

        }

        private void grdv_dataMP_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ErrorText = "Una materia prima no puede ajustarse si se ha seleccionado dos veces la misma bodega.";
            e.WindowCaption = "Error en la configuracion.";
        }
    }
}