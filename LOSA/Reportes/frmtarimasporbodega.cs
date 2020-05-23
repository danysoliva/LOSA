﻿using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.RecepcionMP;
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

namespace LOSA.Reportes
{
    public partial class frmtarimasporbodega : DevExpress.XtraEditors.XtraForm
    {
        int IdBodega;
        string BodegaNombre;
        DataOperations dp = new DataOperations();
        public frmtarimasporbodega()
        {
            InitializeComponent();
            LoadBodegas();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {


            this.Close();
        }
        void LoadBodegas()
        {
            try
            {
                IdBodega = 0;
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);

                string SQL = @"exec sp_get_bodegas_enable";

                dsRecepcionMPx.bodegas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);
                dsRecepcionMPx.bodegas.Clear();
                //adat.SelectCommand.Parameters.AddWithValue("@codigo_barra", "");


                adat.Fill(dsRecepcionMPx.bodegas);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)grd_bodegas.FocusedView;
            var row = (dsRecepcionMPx.bodegasRow)gridView.GetFocusedDataRow();

            IdBodega = row.id;
            BodegaNombre = row.descripcion;

            if (IdBodega > 0)
            {
                this.navigationFrame1.SelectNextPage();
            }
            Load_Report();
        }
        public void Load_Report()
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);

                string SQL = @"sp_report_tarimas_por_bodega";
                cn.Open();
                dsRecepcionMPx.bodegas.Clear();
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_bodega", IdBodega);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);

                //adat.SelectCommand.Parameters.AddWithValue("@codigo_barra", "");
                dsReportes.TarimasPorBodega.Clear();

                adat.Fill(dsReportes.TarimasPorBodega);
                cn.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.navigationFrame1.SelectPrevPage();
            LoadBodegas();
        }
    }
}