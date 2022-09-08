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
using System.Collections;

namespace LOSA.Calidad
{
    public partial class frm_retencionesPT : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        //string Lote;
        //int id_mp;
        //string ingreso;
        //int Tipo_tarima;
        //int id_turno;
        ArrayList Lista;
        int IdEstado;
        public frm_retencionesPT(UserLogin Puser , ArrayList pLista, int pIdEstado)
        {
            InitializeComponent();
            IdEstado = pIdEstado;
            //id_mp = Pid_pt;
            //id_turno = Pid_turno;
            //Lote = Plote;

            //UsuarioLogeado = Puser;
            //txtitemcode.Text = codigoP;
            //txtnombre.Text = producto;
            //txtlote.Text = Lote;
            //txtingreso.Text = "";
            UsuarioLogeado = Puser;
            Lista = pLista;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Abort;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmretencionadd frm = new frmretencionadd(2);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int id = frm.id;
                foreach (DataRow Ite in dsCalidad.causaadd.Rows)
                {
                    if (Ite["id"].ToString() == id.ToString())
                    {
                        CajaDialogo.Error("Ya se ha registradio esta causa de retencion, por favor revisar las causas");
                        return;
                    }
                }
                DataRow Row = dsCalidad.causaadd.NewRow();
                Row["id"] = frm.id;
                Row["descripcion"] = frm.producto;
                Row["comentario"] = frm.comentario;
                dsCalidad.causaadd.Rows.Add(Row);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //string Query = @"sp_load_idtm_from_lote_v2";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                //int bit = 0;
               
                //SqlCommand cmd = new SqlCommand(Query, cn);
                //cmd.CommandType = CommandType.StoredProcedure;
                ////cmd.Parameters.AddWithValue("@lote", Lote);
                ////cmd.Parameters.AddWithValue("@id_mp", id_mp);
                ////cmd.Parameters.AddWithValue("@id_turno", id_turno);
                //dsCalidad.Tarimas.Clear();
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //da.Fill(dsCalidad.Tarimas);
                //foreach (dsCalidad.TarimasRow row in dsCalidad.Tarimas.Rows)
                foreach(int idtarima in Lista)
                {
                    SqlCommand cmd = new SqlCommand("sp_set_update_tarima_estado_calidadV2", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_estado", IdEstado);
                    cmd.Parameters.AddWithValue("@id", idtarima);
                    cmd.Parameters.AddWithValue("@user", UsuarioLogeado.Id);
                    cmd.ExecuteNonQuery();
                    foreach (dsCalidad.causaaddRow row2 in dsCalidad.causaadd.Rows)
                    {
                        cmd = new SqlCommand("sp_insert_into_calidad_tarimas", cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idtarima", idtarima);
                        cmd.Parameters.AddWithValue("@id_causa", row2.id);
                        cmd.Parameters.AddWithValue("@usuario", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@comentario", row2.comentario);
                        cmd.ExecuteNonQuery();
                    }
                }

                cn.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_causa.FocusedView;
                var row = (dsCalidad.causaaddRow)gridview.GetFocusedDataRow();
                foreach (DataRow item in dsCalidad.causaadd.Rows)
                {
                    if (Convert.ToInt32(item["id"]) == row.id)
                    {
                        item.Delete();
                    }
                }
                dsCalidad.causaadd.AcceptChanges();
            }
            catch (Exception ex)
            {
            }
        }
    }
}