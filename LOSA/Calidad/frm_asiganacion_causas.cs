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
using ACS.Classes;
using System.Data.SqlClient;
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Calidad
{
    public partial class frm_asiganacion_causas : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int Id_tarima;
        int tipo_tarima;
        UserLogin UsuarioLogeado;//Formulario que unicamente bloquea
        public frm_asiganacion_causas(UserLogin ParUser, int id_tarima)
        {
            InitializeComponent();
            UsuarioLogeado = ParUser;
            Id_tarima = id_tarima;
            load_data();
        }
        public void load_data()
        {
            string Query = @"exec [dbo].[ps_obtener_data_tarima]
                                @id = @parid";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.Parameters.Add("@parid", SqlDbType.Int).Value = Id_tarima;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtcantidad.Text = dr[5].ToString();
                    txtnombre.Text = dr[4].ToString();
                    txtitemcode.Text = dr[2].ToString();
                    txttarima.Text = dr[3].ToString();
                    tipo_tarima = dr.GetInt32(6);
                }
                dr.Close();
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Operacion de Retener
            DataOperations dp = new DataOperations();
            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_set_update_tarima_estado_calidad", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_estado", 3);
            cmd.Parameters.AddWithValue("@id", Id_tarima);
            cmd.ExecuteNonQuery();
            foreach (DataRow row in dsCalidad.causaadd.Rows)
            {
                cmd = new SqlCommand("sp_insert_into_calidad_tarimas",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idtarima",Id_tarima);
                cmd.Parameters.AddWithValue("@id_causa", row["id"].ToString());
                cmd.Parameters.AddWithValue("@usuario", UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@comentario", row["comentario"].ToString());
                cmd.ExecuteNonQuery();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmretencionadd frm = new frmretencionadd(tipo_tarima);
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