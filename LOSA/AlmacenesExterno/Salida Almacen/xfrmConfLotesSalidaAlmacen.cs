using System;
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

                var lista_lotes_ingreso = dsSalidasAlmacenesExternos.Lote.ToList().Where(x=> x.id_detalle==row.id).ToList();
                lista_lotes_ingreso.Clear();

                foreach (var item in dsSalidasAlmacenesExternos.Lote_Seleccionados.ToList())
                {
                    foreach (var item2 in dsSalidasAlmacenesExternos.Lote.ToList().Where(x => x.id_detalle == row.id).ToList())
                    {
                        if (item.id==item2.id)
                        {
                            lista_lotes_ingreso.Add(item2);
                        }

                    }

                }


                if (dsSalidasAlmacenesExternos.Lote.Rows.Count > 0 && dsSalidasAlmacenesExternos.Lote_Seleccionados.Rows.Count>0)
                {
                    //dsSalidasAlmacenesExternos.Lote.Clear();

                    foreach (var item in lista_lotes_ingreso)
                    {

                        dsSalidasAlmacenesExternos.Lote.Rows.Remove(item);
                        
                    }

                }





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
                    SqlDataAdapter da = new SqlDataAdapter("sp_almacenes_externos_get_lotes_by_id_detalle", cnx);

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int contarRepetidos = 0;

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
                        row["cantidad"] = item.cantidad;
                        row["unidades"] = item.unidades;
                        row["id_detalle"] = item.id_detalle;

                        dsSalidasAlmacenesExternos.Lote_Seleccionados.Rows.Add(row);
                    }
                }
            }

            ceSeleccionar_CheckedChanged(null, null);
        }

        private void btnDelete2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gvLotesSeleccionados.DeleteRow(gvLotesSeleccionados.FocusedRowHandle);
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
                    SqlCommand cmd2 = new SqlCommand("sp_salida_almacenes_externos_d_insert", transaction.Connection);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Transaction = transaction;

                    cmd2.Parameters.Add("@id_mp", SqlDbType.Int).Value = item.id_mp;
                    cmd2.Parameters.Add("@id_h", SqlDbType.Int).Value = id_salida_h;
                    cmd2.Parameters.Add("@peso", SqlDbType.Decimal).Value = item.peso;
                    cmd2.Parameters.Add("@unidades", SqlDbType.Decimal).Value = item.unidades;
                    cmd2.Parameters.Add("@LineNum", SqlDbType.Int).Value = item.NumLine;
                    cmd2.Parameters.Add("@DocEntry", SqlDbType.Int).Value = ingreso_h.DocEntry;

                    int id_salida_d = Convert.ToInt32(cmd2.ExecuteScalar());


                    foreach (var item2 in dsSalidasAlmacenesExternos.Lote_Seleccionados.ToList().Where(x => x.id_detalle == item.id).ToList())
                    {
                        SqlCommand cmd3 = new SqlCommand("sp_salida_almacenes_externos_lotes_insert ", transaction.Connection);
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Transaction = transaction;

                        cmd3.Parameters.Add("@peso", SqlDbType.Decimal).Value = item2.cantidad;
                        cmd3.Parameters.Add("@unidades", SqlDbType.Decimal).Value = item2.unidades;
                        cmd3.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                        cmd3.Parameters.Add("@user_creador", SqlDbType.Int).Value = 1035;
                        cmd3.Parameters.Add("@id_serie", SqlDbType.Int).Value = 0;
                        cmd3.Parameters.Add("@DocEntry", SqlDbType.Int).Value = ingreso_h.DocEntry;
                        cmd3.Parameters.Add("@id_mp", SqlDbType.Int).Value = item.id_mp;
                        cmd3.Parameters.Add("@id_lote_externo", SqlDbType.Int).Value = item.id;
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
