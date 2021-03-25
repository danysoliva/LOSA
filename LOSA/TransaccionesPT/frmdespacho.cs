﻿using System;
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
using LOSA.Clases;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Despachos;

namespace LOSA.TransaccionesPT
{
    public partial class frmdespacho : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frmdespacho(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            load_despachos();
        }

        public void load_despachos()
        {
            string Query = @"sp_load_informacion_despachos";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(Query,cn);
            cmd.CommandType = CommandType.StoredProcedure;
            dsPT.Load_despachos.Clear();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsPT.Load_despachos);
            cn.Close();
        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea marcar como finalizada este despacho? No podra seguir recibiendo tarimas.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    var gridView = (GridView)grd_data.FocusedView;
                    var row = (dsPT.Load_despachosRow)gridView.GetFocusedDataRow();
                    string query = @"sp_finalizar_despacho";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query,cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", row.id);
                    cmd.ExecuteNonQuery();
                    CajaDialogo.Error("Se finalizo correctamente este despacho.");
                    cn.Close();
                    load_despachos();

                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar este despacho? No podra hacer ninguna otra transaccion de el y las tarimas recibidas volveran al inventario.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    var gridView = (GridView)grd_data.FocusedView;
                    var row = (dsPT.Load_despachosRow)gridView.GetFocusedDataRow();
                    string query = @"sp_eliminar_despacho";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", row.id);
                    cmd.ExecuteNonQuery();
                    CajaDialogo.Error("Se elimino correctamente este despacho.");
                    cn.Close();
                    load_despachos();

                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsPT.Load_despachosRow)gridView.GetFocusedDataRow();
                frm_generar_despacho frm = new frm_generar_despacho(row.id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    load_despachos();
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsPT.Load_despachosRow)gridView.GetFocusedDataRow();
            frm_view_entrega_despacho frm = new frm_view_entrega_despacho(row.id);
            frm.Show();
        }
    }
}