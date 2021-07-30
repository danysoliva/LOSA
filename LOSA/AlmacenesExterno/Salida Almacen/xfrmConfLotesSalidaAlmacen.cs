﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LOSA.AlmacenesExterno.Salida_Almacen.Models;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using LOSA.AlmacenesExterno.Models;

namespace LOSA.AlmacenesExterno.Salida_Almacen
{
    public partial class xfrmConfLotesSalidaAlmacen : DevExpress.XtraEditors.XtraForm
    {
        List<Ingresos_Externos_D> lista = new List<Ingresos_Externos_D>();
        Ingreso_Almacenes_Externos_H ingreso_h = new Ingreso_Almacenes_Externos_H();
        int id_salida_h;

        public xfrmConfLotesSalidaAlmacen(List<Ingresos_Externos_D> ingresos_Externos_Ds, Ingreso_Almacenes_Externos_H pIngresoAlamecesExternos_H)
        {
            InitializeComponent();
            lista = ingresos_Externos_Ds;
            ingreso_h = pIngresoAlamecesExternos_H;
        }

        private void xfrmConfLotesSalidaAlmacen_Load(object sender, EventArgs e)
        {
            foreach (var item in lista)
            {
                DataRow workRow = dsSalidasAlmacenesExternos.Transferencia_Stock.NewRow();

                workRow["itemcode"] = item.ItemCode;
                workRow["itemName"] = item.ItemName;
                workRow["NumLine"] = item.NumLine;
                workRow["peso"] = item.Peso;
                workRow["unidades"] = item.Unidades;
                workRow["id_mp"] = item.IDMP;
                workRow["id"] = item.ID;
                workRow["DocEntrySAP"] = item.DocEntry;

                dsSalidasAlmacenesExternos.Transferencia_Stock.Rows.Add(workRow);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gcIngreso_Click(object sender, EventArgs e)
        {

        }

        List<dsSalidasAlmacenesExternos.Lote_SeleccionadosRow> lista_lotes_seleccionados = new List<dsSalidasAlmacenesExternos.Lote_SeleccionadosRow>();

        private void ceSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var gv = (GridView)gcIngreso.FocusedView;
                var row = (dsSalidasAlmacenesExternos.Transferencia_StockRow)gv.GetDataRow(gv.FocusedRowHandle);


                foreach (var item in dsSalidasAlmacenesExternos.Transferencia_Stock)
                {
                    item.seleccionar = false;
                }

                row.seleccionar = true;

                ObtenerLotes(row.id);

                //var lista_lotes_ingreso = dsSalidasAlmacenesExternos.Lote.ToList().Where(x=> x.id_detalle==row.id).ToList();
                //lista_lotes_ingreso.Clear();

                //foreach (var item in dsSalidasAlmacenesExternos.Lote_Seleccionados.ToList())
                //{

                //lista_lotes = dsSalidasAlmacenesExternos.Lote.ToList();
                foreach (var item2 in dsSalidasAlmacenesExternos.Lote.ToList().Where(x => x.id_detalle == row.id).ToList())
                {
                    var cant_disponible = lista_lotes_seleccionados.Where(x => x.id == item2.id).Sum(x => x.CantSeleccionada);
                    var unidades_disponible = lista_lotes_seleccionados.Where(x => x.id == item2.id).Sum(x => x.unidades_seleccionadas);

                    item2.cantidad_disponible = item2.cantidad_disponible- cant_disponible;
                    item2.unidades_disponibles = item2.unidades_disponibles - unidades_disponible;
                    //if (item.id == item2.id)
                    //{
                    //    lista_lotes_ingreso.Add(item2);
                    //}

                }

                //}


                //if (dsSalidasAlmacenesExternos.Lote.Rows.Count > 0 && dsSalidasAlmacenesExternos.Lote_Seleccionados.Rows.Count>0)
                //{
                //    //dsSalidasAlmacenesExternos.Lote.Clear();

                //    foreach (var item in lista_lotes_ingreso)
                //    {
                //        dsSalidasAlmacenesExternos.Lote.Rows.Remove(item);
                //    }

                //}





            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ObtenerLotes(int id_d)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();

                    dsSalidasAlmacenesExternos.Lote.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("[dbo].[sp_almacenes_externos_get_lotes_disponibles_by_id_detalle_salida_externa]", cnx);

                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@id_detalle", SqlDbType.Int).Value = id_d;

                    da.Fill(dsSalidasAlmacenesExternos.Lote);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        List<dsSalidasAlmacenesExternos.LoteRow> lista_lotes = new List<dsSalidasAlmacenesExternos.LoteRow>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gvLote.PostEditor();
            int contarRepetidos = 0;
            var gvl = (GridView)gcLote.FocusedView;
            var row_lote = (dsSalidasAlmacenesExternos.LoteRow)gvl.GetDataRow(gvl.FocusedRowHandle);

            if (row_lote.cantidad_disponible==0)
            {
                CajaDialogo.Error("LOTE NO DISPONIBLE");
                return;
            }

            if (row_lote.CantSeleccionada> row_lote.cantidad_disponible)
            {
                CajaDialogo.Error("DEBE DE INGRESAR UNA CANTIDAD MENOR O IGUAL A LA DISPONIBLE");
                return;
            }



            if (row_lote.unidade_seleccionadas > row_lote.unidades_disponibles)
            {
                CajaDialogo.Error("LAS UNIDADES DEBEN SER MENOR O IGUAL A LAS DISPONIBLES");
                return;
            }

            if (row_lote.CantSeleccionada==0)
            {
                CajaDialogo.Error("DEBE SELECCIONAR UNA CANTIDAD");
                return;
            }
            
            if (row_lote.unidade_seleccionadas==0)
            {
                CajaDialogo.Error("DEBE SELECCIONAR UNIDADES");
                return;
            }



            foreach (var item in dsSalidasAlmacenesExternos.Lote)
            {
                foreach (var item2 in dsSalidasAlmacenesExternos.Lote_Seleccionados)
                {
                    if (item.id == item2.id)
                    {
                        contarRepetidos++;
                    }
                }

                if (contarRepetidos == 0)
                {


                    if (item.Seleccionar == true)
                    {
                        DataRow row = dsSalidasAlmacenesExternos.Lote_Seleccionados.NewRow();

                        row["id"] = item.id;
                        row["lote"] = item.lote;
                        row["cantidad"] = item.cantidad_disponible;
                        row["unidades"] = item.unidades_disponibles;         
                        row["CantSeleccionada"] = item.CantSeleccionada;
                        row["unidades_seleccionadas"] = item.unidade_seleccionadas;
                        row["id_detalle"] = item.id_detalle;

                        dsSalidasAlmacenesExternos.Lote_Seleccionados.Rows.Add(row);

                        //lista_lotes_seleccionados.Add(row);

                        item.cantidad_disponible = item.cantidad_disponible - item.CantSeleccionada;
                        item.unidades_disponibles = item.unidades_disponibles - item.unidade_seleccionadas;

                    }
                }

                item.CantSeleccionada = 0;
                item.unidade_seleccionadas = 0;

            }

            //var ls = dsSalidasAlmacenesExternos.Lote.ToList();

            lista_lotes_seleccionados.Clear();
            lista_lotes_seleccionados = dsSalidasAlmacenesExternos.Lote_Seleccionados.ToList();

            //dsSalidasAlmacenesExternos.Lote.ToList().Removeove()

        }

        
        private void btnDelete2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gvLotesSeleccionados.DeleteRow(gvLotesSeleccionados.FocusedRowHandle);

            lista_lotes_seleccionados.Clear();

            lista_lotes_seleccionados = dsSalidasAlmacenesExternos.Lote_Seleccionados.ToList();
        }

        SqlTransaction transaction;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dsSalidasAlmacenesExternos.Lote_Seleccionados.Rows.Count==0)
                {
                    CajaDialogo.Error("DEBE DE SELECCIONAR LOS LOTES A TRANSFERIR");
                    return;
                }

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);


                cnx.Open();
                transaction = cnx.BeginTransaction("SampleTransaction");

                SqlCommand cmd = new SqlCommand("sp_salida_almacenes_externos_h_insert", transaction.Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = transaction;


                cmd.Parameters.Add("@bodega_in", SqlDbType.VarChar).Value = ingreso_h.BodegaIN;
                cmd.Parameters.Add("@bodega_out", SqlDbType.VarChar).Value = ingreso_h.BodegaOUT;
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now.Date;
                cmd.Parameters.Add("@DocEntry", SqlDbType.Int).Value = ingreso_h.DocEntry;
                cmd.Parameters.Add("@user_creador", SqlDbType.Int).Value = 1035;
                cmd.Parameters.Add("@numero_transaccion", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@id_ingreso", SqlDbType.Int).Value = ingreso_h.ID;

                id_salida_h = Convert.ToInt32(cmd.ExecuteScalar());


                //Insertar detalle de salida de almacen

                foreach (var item in dsSalidasAlmacenesExternos.Transferencia_Stock)
                {
                    var SumCantSeleccionados = dsSalidasAlmacenesExternos.Lote_Seleccionados.ToList().Where(x => x.id_detalle == item.id).ToList().Sum(x => x.CantSeleccionada);
                    var SumUnidadesSeleccionados = dsSalidasAlmacenesExternos.Lote_Seleccionados.ToList().Where(x => x.id_detalle == item.id).ToList().Sum(x => x.unidades_seleccionadas);

                    //var SumCantSeleccionados = lista_lotes_seleccionados.Where(x=>x.id_detalle==item.id).ToList().Sum(x => x.CantSeleccionada);
                    //var SumUnidadesSeleccionados = lista_lotes_seleccionados.Where(x => x.id_detalle == item.id).ToList().Sum(x => x.unidades_seleccionadas);



                    SqlCommand cmd2 = new SqlCommand("sp_salida_almacenes_externos_d_insert", transaction.Connection);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Transaction = transaction;

                    cmd2.Parameters.Add("@id_mp", SqlDbType.Int).Value = item.id_mp;
                    cmd2.Parameters.Add("@id_h", SqlDbType.Int).Value = id_salida_h;
                    //cmd2.Parameters.Add("@peso", SqlDbType.Decimal).Value = item.peso;
                    cmd2.Parameters.Add("@peso", SqlDbType.Decimal).Value = SumCantSeleccionados;
                    //cmd2.Parameters.Add("@unidades", SqlDbType.Decimal).Value = item.unidades;
                    cmd2.Parameters.Add("@unidades", SqlDbType.Decimal).Value = SumUnidadesSeleccionados;
                    cmd2.Parameters.Add("@LineNum", SqlDbType.Int).Value = item.NumLine;
                    cmd2.Parameters.Add("@DocEntry", SqlDbType.Int).Value = ingreso_h.DocEntry;

                    int id_salida_d = Convert.ToInt32(cmd2.ExecuteScalar());


                    foreach (var item2 in lista_lotes_seleccionados.Where(x => x.id_detalle == item.id).ToList())
                    {
                        SqlCommand cmd3 = new SqlCommand("sp_salida_almacenes_externos_lotes_insert ", transaction.Connection);
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Transaction = transaction;

                        cmd3.Parameters.Add("@peso", SqlDbType.Decimal).Value = item2.CantSeleccionada;
                        cmd3.Parameters.Add("@unidades", SqlDbType.Decimal).Value = item2.unidades_seleccionadas;
                        cmd3.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                        cmd3.Parameters.Add("@user_creador", SqlDbType.Int).Value = 1035;
                        cmd3.Parameters.Add("@id_serie", SqlDbType.Int).Value = 0;
                        cmd3.Parameters.Add("@DocEntry", SqlDbType.Int).Value = ingreso_h.DocEntry;
                        cmd3.Parameters.Add("@id_mp", SqlDbType.Int).Value = item.id_mp;
                        cmd3.Parameters.Add("@id_lote_externo", SqlDbType.Int).Value = item2.id;
                        cmd3.Parameters.Add("@id_detalle", SqlDbType.Int).Value = id_salida_d;
                        cmd3.Parameters.Add("@id_presentacio", SqlDbType.Int).Value = 0;
                        cmd3.Parameters.Add("@bodega_in", SqlDbType.VarChar).Value = ingreso_h.BodegaIN;
                        cmd3.Parameters.Add("@bodega_out", SqlDbType.VarChar).Value = ingreso_h.BodegaOUT;
                        cmd3.Parameters.Add("@LineNum", SqlDbType.Int).Value = item.NumLine;
                        cmd3.Parameters.Add("@id_ingreso_lote", SqlDbType.Int).Value = ingreso_h.ID;

                        cmd3.ExecuteNonQuery();


                    }
                }

                transaction.Commit();
                cnx.Close();


                CajaDialogo.Information("TRANSFERENCIA CREADA EXITOSAMENTE");
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaction.Rollback();
            }
        }
    }
}