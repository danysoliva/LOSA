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
using DevExpress.XtraGrid.Views.Grid;
using LOSA.AlmacenesExterno.Models;
using ACS.Classes;
using System.Data.SqlClient;
using LOSA.AlmacenesExterno.Salida_Almacen.Models;
using LOSA.AlmacenesExterno.Salida_Almacen;
using LOSA.Clases;
using LOSA.AlmacenesExterno.Reporteria;
using DevExpress.XtraReports.UI;

namespace LOSA.AlmacenesExterno
{
    public partial class xfrmMovimientoStockMain : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public xfrmMovimientoStockMain(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            load_data();
        }

        public void load_data()
        {
            DataOperations dp = new DataOperations();
            string query = @"sp_load_salida_externa_header";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsSalidasAlmacenesExternos1.Salida_Almacen_Header.Clear();
                da.Fill(dsSalidasAlmacenesExternos1.Salida_Almacen_Header);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            xfrmMovimientoStock frm = new xfrmMovimientoStock(UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }
        }

        private void repositoryPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview1 = (GridView)gcTransferencia.FocusedView;
            var row = (dsSalidasAlmacenesExternos.Salida_Almacen_HeaderRow)gridview1.GetFocusedDataRow();

            xrpt_Main_traslado_almacen report = new xrpt_Main_traslado_almacen();
            report.Parameters["id_h"].Value = row.id;


            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Send the report to the default printer.
                printTool.ShowPreviewDialog();
            }
        }
    }
}