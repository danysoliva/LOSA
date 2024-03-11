﻿using ACS.Classes;
using DevExpress.XtraEditors;
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
using LOSA.Compras;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Compras
{
    public partial class frmSearchOrdenC : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;
        public int IdOrdenesSeleccionado = 0;

        public enum FiltroOrdenesCompra
        {
            Todas = 1,
            Abiertas = 2
        }
        FiltroOrdenesCompra Filtro;
        public frmSearchOrdenC(frmSearchOrdenC.FiltroOrdenesCompra pfiltro, UserLogin pUserLogin)
        {
            InitializeComponent();
            Filtro = pfiltro;
            UsuarioLogueado = pUserLogin;

            LoadData();

        }

        private void LoadData()
        {
            try
            {
                string query = @"sp_get_ordenes_compra";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //switch (Filtro)
                //{
                //    case FiltroOrdenesCompra.Todas:
                //        cmd.Parameters.AddWithValue("@filtro", 1);
                //        break;

                //    case FiltroOrdenesCompra.Abiertas:
                //        cmd.Parameters.AddWithValue("@filtro", 2);
                //        break;

                //    default:
                //        break;
                //}
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.orden_compra_exo.Clear();
                adat.Fill(dsCompras1.orden_compra_exo);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridview = (GridView)grdSolicitudes.FocusedView;
            var row = (dsCompras.orden_compra_exoRow)gridview.GetFocusedDataRow();

            IdOrdenesSeleccionado = row.id_h;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}