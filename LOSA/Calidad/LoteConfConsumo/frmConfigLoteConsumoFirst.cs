﻿using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
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

namespace LOSA.Calidad.LoteConfConsumo
{
    public partial class frmConfigLoteConsumoFirst : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmConfigLoteConsumoFirst(UserLogin puser)
        {
            InitializeComponent();
            UsuarioLogeado = puser;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmSearchMP frm = new frmSearchMP(frmSearchMP.TipoBusqueda.MateriaPrima);
            if(frm.ShowDialog()== DialogResult.OK)
            {
                LoadLotesMP(frm.ItemSeleccionado.id);
                textEdit1.Text = frm.ItemSeleccionado.ItemCode + " " + frm.ItemSeleccionado.ItemName;
            }
        }

        private void LoadLotesMP(int pidRM)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_lotes_configurados_por_mpv2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idmp", pidRM);
                dsConfigLoteConsumo1.config_lote.Clear();
                //dsPresupuesto1.estados.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsConfigLoteConsumo1.config_lote);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }

        private void repositoryEditarFechaVenc_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsConfigLoteConsumo.config_loteRow)gridView.GetFocusedDataRow();

            frmEditFechaVencimientoIngreso frm = new frmEditFechaVencimientoIngreso(row.id_mp, row.numero_transaccion, row.lote, row.fecha_vence, row.id_lote_alosy, UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadLotesMP(row.id_mp);
            }
        }
    }
}