﻿using ACS.Classes;
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

namespace LOSA.RecepcionMP
{
    public partial class frmEntradaMP : Form
    {
        private int idTarima, idUbicacion;
       
        DataOperations dp = new DataOperations();
        DataTable dtTarima = new DataTable();
        public frmEntradaMP()
        {
            InitializeComponent();
        }

        private void CmdSelectTarima_Click(object sender, EventArgs e)
        {
            frmTarimas frm = new frmTarimas();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                idTarima = frm.idTarima;
                beTarima.Text= frm.idTarima.ToString();
                //txtProveedor.Text = frm.proveedor;
                //txtTarima.Text = frm.nombreTarima;
                //txtLote.Text = frm.lote;
                //txtPresentacion.Text = frm.presentacion;

                gcTarima.DataSource = CreateDataTarima(frm.proveedor, frm.nombreTarima, frm.lote, frm.presentacion);
                gvTarima.InitNewRow += GridView1_InitNewRow;
                gvTarima.Columns[0].AppearanceCell.Font= new Font(gvTarima.Columns[0].AppearanceCell.Font, FontStyle.Bold);

            }
        }

        private void CmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        void datosTarima(SqlConnection connection)
        {
            try
            {
                using (connection)
                {
                    string SQL = "exec obtenerTarimas  @codigo_barra";
                    SqlCommand cmd = new SqlCommand();
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cmd.Connection = connection;
                    cmd.CommandText = SQL;

                    cmd.Parameters.AddWithValue("@codigo_barra", beTarima.Text);

                    connection.Open();
               

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            idTarima = dr.GetInt32(0);
                            //txtTarima.Text = dr.GetString(1);
                            //txtProveedor.Text = dr.GetString(2);
                            //txtLote.Text = dr.GetString(5);
                            //txtPresentacion.Text = dr.GetString(6);

                            gcTarima.DataSource = CreateDataTarima(dr.GetString(2), dr.GetString(1), dr.GetString(5), dr.GetString(6));
                            gvTarima.InitNewRow += GridView1_InitNewRow;
                            gvTarima.Columns[0].AppearanceCell.Font = new Font("Segoe UI",11, FontStyle.Bold);
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("TARIMA NO ENCONTRADA");
                        //txtTarima.Text = "";
                    }

                    cn.Close();
                  
                }
            }
            catch (Exception error)
            {
                CajaDialogo.Error(error.Message);
            }
        }

        void datosUbicacion(SqlConnection connection)
        {
            try
            {
                using (connection)
                {
                    string SQL = "exec obtenerUbicacionTarima @codigo_barra";
                    SqlCommand cmd = new SqlCommand();
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cmd.Connection = connection;
                    cmd.CommandText = SQL;

                   cmd.Parameters.AddWithValue("@codigo_barra", beTarima.Text);

                    connection.Open();


                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            idUbicacion = dr.GetInt32(0);
                           

                            gcUbicacion.DataSource = CreateDataUbicacion(dr.GetString(2), dr.GetString(4), dr.GetString(3), dr.GetString(1));
                            gvUbicacion.InitNewRow += GvUbicacion_InitNewRow;
                            gvUbicacion.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);

                        }
                    }
                    else
                    {
                        CajaDialogo.Error("UBICACIÓN NO ENCONTRADA");
                       beUbicacion.Text = "";
                    }

                    cn.Close();

                }
            }
            catch (Exception error)
            {
                CajaDialogo.Error(error.Message);
            }
        }
       

        private void BeTarima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                datosTarima(cn);
            }
        }

        private void BtnUbicacion_Click(object sender, EventArgs e)
        {
            frmUbicacionTarima frm = new frmUbicacionTarima();

            if (frm.ShowDialog()==DialogResult.OK)
            {
                idUbicacion = frm.idUbicacion;
                beUbicacion.Text = frm.idUbicacion.ToString();
               

                gcUbicacion.DataSource = CreateDataUbicacion(frm.rack, frm.profundidad, frm.altura, frm.pasillo);
                gvUbicacion.InitNewRow += GvUbicacion_InitNewRow;
                gvUbicacion.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            }
        }

        private void BeUbicacion_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
         
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                datosUbicacion(cn);
            }
        }

         private void BeUbicacion_Click(object sender, EventArgs e)
        {
           
            beUbicacion.Text = "";
        }

        private void GridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvTarima.SetRowCellValue(e.RowHandle, gvTarima.Columns["Detalle"], true);
        }

        private void BeTarima_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            beTarima.Text = "";
            gcTarima.DataSource = null;
        
        }

        private DataTable CreateDataTarima(string pProveedor, string pNombreTarima, string pLote, string pPpresentacion)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Detalle", typeof(string));
            dt.Columns.Add("Valor", typeof(string));

          
            dt.Rows.Add("TARIMA", pNombreTarima);
            dt.Rows.Add("PROVEEDOR" ,pProveedor);
            dt.Rows.Add("LOTE" ,pLote);
            dt.Rows.Add("PRESENTACION",pPpresentacion);

            return dt;
        }

        private void GvUbicacion_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
           gvUbicacion.SetRowCellValue(e.RowHandle, gvUbicacion.Columns["Detalle"], true);
        }

        private void BeUbicacion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           beUbicacion.Text = "";
           gcUbicacion.DataSource = null;
        }

        private DataTable CreateDataUbicacion(string pRack, string pProfundidad, string pAltura, string pPasillo)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Detalle", typeof(string));
            dt.Columns.Add("Valor", typeof(string));


            dt.Rows.Add("PASILLO", pPasillo);
            dt.Rows.Add("RACK", pRack);
            dt.Rows.Add("ALTURA", pAltura);
            dt.Rows.Add("PROFUNDIDAD", pProfundidad);

            return dt;
        }
    }
}
