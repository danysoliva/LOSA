using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Micro;
using LOSA.MicroIngredientes.Models;
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

namespace LOSA.MicroIngredientes
{
    public partial class frmSelectLotePesaje : DevExpress.XtraEditors.XtraForm
    {
        int IdMP = 0;
        decimal total = 0;
        int id_orden;
        int cant_batch=0;
        decimal cantidadDisponible = 0;
        decimal unidadesDisponibles=0;
        decimal totalUnidades = 0;
        decimal kgxBatch = 0;
        string lote;
        int id_d;
        int type = 0;
        public DataTable Table;
        SqlTransaction transaction;
        int Orden_h;
        DateTime Fecha;


        PesajeManualInfo pesajeInfo = new PesajeManualInfo();

        //public frmSelectLotePesaje(int pIdmp, decimal pTotal, int pId_orden,decimal pCant_batch,decimal pKgxBatch, int pId_detalle_pesaje_manual_plan)
        public frmSelectLotePesaje(PesajeManualInfo pesajeManualInfo)
        {
            InitializeComponent();
            pesajeInfo = pesajeManualInfo;
            IdMP = pesajeManualInfo.MateriaPrimaID;
            total = pesajeManualInfo.Total;
            id_orden = pesajeManualInfo.OrdenID;
            cant_batch = pesajeManualInfo.CantBatch;
            type = 1;
            LoadLotes();

            lblPesoDisponible.Text = "Peso sin asignar: " + total.ToString("N2") + " Kg";
            //lblUnidades.Text = "Unidades sin asignar: " + pCant_batch.ToString("N2");
           
            cantidadDisponible = pesajeManualInfo.Total;

            unidadesDisponibles = pesajeManualInfo.CantBatch;
            totalUnidades = pesajeManualInfo.CantBatch;
            //kgxBatch = pKgxBatch;
            id_d = pesajeManualInfo.DetallePesajeManualPlanID;
        }
        public frmSelectLotePesaje(int Id_mp, decimal Ptotal, int Pbatch, int id_orden_H, DateTime fecha)
        {
            InitializeComponent();
            IdMP = Id_mp;
            total = Ptotal;
            cant_batch = Pbatch;
            LoadLotes();
            type = 2;
            lblPesoDisponible.Text = "Peso sin asignar: " + total.ToString("N2") + " Kg";
            //lblUnidades.Text = "Unidades sin asignar: " + pCant_batch.ToString("N2");
            Orden_h = id_orden_H;
            Fecha = fecha;
            cantidadDisponible = total;

            unidadesDisponibles = Pbatch;
            totalUnidades = Pbatch;
        }

        private void LoadLotes()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_lotes_micro_ingredientes_select_V2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idmp", IdMP);
                dsMicro.lotes_seleccion.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMicro.lotes_seleccion);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ceSeleccion_CheckedChanged(object sender, EventArgs e)
        {

            foreach (var item in dsMicro.lotes_seleccion.OrderBy(x => x.id_tarima))
            {
                if (ceSeleccion.Checked == true)
                {

                    if (cantidadDisponible > 0)
                    {
                        if (cantidadDisponible > item.peso_kg)
                        {
                            cantidadDisponible = cantidadDisponible - item.peso_kg;
                            item.cant_seleccionada = item.peso_kg;

                            //item.unidades_seleccionadas = (item.peso_kg / kgxBatch);
                            item.unidades_seleccionadas = item.unidades;
                            //unidadesDisponibles = unidadesDisponibles - (item.peso_kg/kgxBatch);
                            unidadesDisponibles = 0;

                            item.cant_restante = 0;
                            item.unidades_restantes = 0;
                        }
                        else
                        if (cantidadDisponible <= item.peso_kg)
                        {
                            item.cant_seleccionada = cantidadDisponible;
                            item.cant_restante = Math.Round(item.peso_kg - cantidadDisponible, 2);

                            item.unidades_seleccionadas = Math.Round((item.cant_seleccionada / item.presentacion_factor), 2);
                            item.unidades_restantes = Math.Round((item.peso_kg - item.cant_seleccionada) / item.presentacion_factor, 2);
                            //item.un
                            cantidadDisponible = 0;
                            unidadesDisponibles = 0;

                        }

                        item.seleccion = true;
                    }

                    lblPesoDisponible.Text = "Peso sin asignar: " + cantidadDisponible.ToString("N2") + " Kg";
                    lote = item.lote_materia_prima;
                    colseleccion.OptionsColumn.AllowEdit = false;
                    //lblUnidades.Text = "Unidades sin asignar: " + unidadesDisponibles.ToString("N2");
                }
                else
                {
                    foreach (var item2 in dsMicro.lotes_seleccion)
                    {

                        cantidadDisponible = total;
                        item.seleccion = false;
                        item.cant_restante = 0;
                        item.cant_seleccionada = 0;
                        item.unidades_restantes = 0;
                        item.unidades_seleccionadas = 0;

                    }

                    gvLotesSeleccionados.UpdateCurrentRow();
                    lblPesoDisponible.Text = "Peso sin asignar: " + cantidadDisponible.ToString("N2") + " Kg";
                    colseleccion.OptionsColumn.AllowEdit = true;

                }
            }
        }

        Boolean SeleccionoLotes;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var item in dsMicro.lotes_seleccion)
                {
                    if (item.seleccion== true)
                    {
                        SeleccionoLotes = true;
                    }
                }


                if (SeleccionoLotes==false)
                {
                    CajaDialogo.Error("DEBE SELECIONAR AL MENOS UN ELEMENTO");
                    return;
                }

                //if (cantidadDisponible!=0)
                //{
                //    CajaDialogo.Error("HAY TODAVIA PESO POR ASIGNAR");
                //    return;
                //}


                if (type == 1)
                {
                    DataOperations dp = new DataOperations();
                    foreach (var item in dsMicro.lotes_seleccion)
                    {
                        if (item.seleccion == true)
                        {
                            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                            {
                                cnx.Open();

                                SqlCommand cmd = new SqlCommand("sp_insert_OP_Orden_pesaje_manual_transaccion", cnx);
                                cmd.CommandType = CommandType.StoredProcedure;


                                cmd.Parameters.Add("@id_orden_encabezado", SqlDbType.Int).Value = id_orden;
                                cmd.Parameters.Add("@batch_plan", SqlDbType.Int).Value = total;
                                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now;
                                cmd.Parameters.Add("@batch_real", SqlDbType.Decimal).Value = item.cant_seleccionada;
                                cmd.Parameters.Add("@id_rm", SqlDbType.Int).Value = pesajeInfo.MateriaPrimaID;// IdMP;
                                cmd.Parameters.Add("@bascula", SqlDbType.VarChar).Value = "B1";
                                cmd.Parameters.Add("@id_tipo_pesaje", SqlDbType.Int).Value = 1;
                                cmd.Parameters.Add("@lote", SqlDbType.VarChar).Value = item.lote_materia_prima;
                                cmd.Parameters.Add("@id_tarima", SqlDbType.VarChar).Value = item.id_tarima;
                                cmd.Parameters.Add("@cant_batch", SqlDbType.Int).Value = cant_batch;
                                cmd.Parameters.Add("@id_pesaje_manual_plan", SqlDbType.Int).Value = id_d;
                                cmd.Parameters.Add("@cant_sacos", SqlDbType.Decimal).Value = item.unidades_seleccionadas;
                                cmd.Parameters.Add("@ami_id", SqlDbType.Int).Value = pesajeInfo.AMI_ID;

                                cmd.ExecuteNonQuery();

                                cnx.Close();
                            }


                        }


                    }

                    this.DialogResult = DialogResult.OK;
                }
                else
                {


                    DataOperations dp = new DataOperations();
                    SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS);
                    cnx.Open();

                    //transaction = cnx.BeginTransaction("SampleTransaction");

                  
                        

                            SqlCommand cmd = new SqlCommand("sp_insert_OP_Orden_pesaje_manual_batch_log",cnx);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Transaction = transaction;


                            cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = Fecha;
                            cmd.Parameters.Add("@id_orden_pesaje_h", SqlDbType.Int).Value = Orden_h;
                            cmd.Parameters.Add("@id_code", SqlDbType.Int).Value = DBNull.Value;

                            cmd.ExecuteNonQuery();

                            foreach (dsMicro.lotes_seleccionRow row in dsMicro.lotes_seleccion.Rows)
                            {

                                    if (row.seleccion)
                                    {
                                        SqlCommand cmd3 = new SqlCommand("sp_insert_OP_Orden_pesaje_manual_transaccion", cnx);
                                        cmd3.CommandType = CommandType.StoredProcedure;
                                        cmd3.Transaction = transaction;

                                        cmd3.Parameters.Add("@id_orden_encabezado", SqlDbType.Int).Value = Orden_h;
                                        cmd3.Parameters.Add("@batch_plan", SqlDbType.Int).Value = total;
                                        cmd3.Parameters.Add("@date", SqlDbType.DateTime).Value = Fecha;
                                        cmd3.Parameters.Add("@batch_real", SqlDbType.Decimal).Value = row.cant_seleccionada;
                                        cmd3.Parameters.Add("@id_rm", SqlDbType.Int).Value = IdMP;// IdMP;
                                        cmd3.Parameters.Add("@bascula", SqlDbType.VarChar).Value = "B1";
                                        cmd3.Parameters.Add("@id_tipo_pesaje", SqlDbType.Int).Value = 2;
                                        cmd3.Parameters.Add("@lote", SqlDbType.VarChar).Value = row.lote_materia_prima;//Dejar este parametro con espacios
                                        cmd3.Parameters.Add("@id_tarima", SqlDbType.VarChar).Value = row.id_tarima;
                                        cmd3.Parameters.Add("@cant_batch", SqlDbType.Int).Value = 1;
                                        cmd3.Parameters.Add("@cant_sacos", SqlDbType.Int).Value = row.unidades_seleccionadas;
                                        cmd3.Parameters.Add("@ami_id", SqlDbType.Int).Value = DBNull.Value;
                                        cmd3.Parameters.Add("@id_pesaje_manual_plan", SqlDbType.Int).Value = DBNull.Value;

                                        cmd3.ExecuteNonQuery();
                                    }

                            }

                        
                    
                    //transaction.Commit();
                    cnx.Close();

                    this.DialogResult = DialogResult.OK;

                }

            }
            catch (Exception ex)
            {
                //transaction.Rollback();
                CajaDialogo.Error(ex.Message);
            }
        }

        private void repositoryItemCheckEdit1_EditValueChanged(object sender, EventArgs e)
        {
            gvLotesSeleccionados.PostEditor();
            var row = (dsMicro.lotes_seleccionRow)gvLotesSeleccionados.GetDataRow(gvLotesSeleccionados.FocusedRowHandle);

            if (row.seleccion == true)
            {
                if (cantidadDisponible > 0)
                {

                    if (cantidadDisponible > row.peso_kg)
                    {
                        cantidadDisponible = cantidadDisponible - row.peso_kg;
                        row.cant_seleccionada = row.peso_kg;

                        row.unidades_seleccionadas = row.unidades;
                        unidadesDisponibles = 0;

                        row.cant_restante = 0;
                        row.unidades_restantes = 0;

                        //gvLotesSeleccionados.PostEditor();
                        //gvLotesSeleccionados.UpdateCurrentRow();
                    }
                    else
                        if (cantidadDisponible <= row.peso_kg)
                    {
                        row.cant_seleccionada = cantidadDisponible;
                        row.cant_restante = Math.Round(row.peso_kg - cantidadDisponible, 2);

                        row.unidades_seleccionadas = Math.Round((row.cant_seleccionada / row.presentacion_factor), 2);
                        row.unidades_restantes = Math.Round((row.peso_kg - row.cant_seleccionada) / row.presentacion_factor, 2);

                        cantidadDisponible = 0;
                        unidadesDisponibles = 0;

                    }

                    gvLotesSeleccionados.PostEditor();
                    gvLotesSeleccionados.UpdateCurrentRow();

                    lblPesoDisponible.Text = "Peso sin asignar: " + cantidadDisponible.ToString("N2") + " Kg";
                    lote = row.lote_materia_prima;
                }
                else
                {
                    CajaDialogo.Error("NO PUEDE REALIZAR MAS ASIGNACIONES");
                    row.seleccion = false;

                    gvLotesSeleccionados.PostEditor();
                    gvLotesSeleccionados.UpdateCurrentRow();
                    return;
                }

            }
            else
            {
                cantidadDisponible = cantidadDisponible + row.cant_seleccionada;
                lblPesoDisponible.Text = "Peso sin asignar: " + cantidadDisponible.ToString("N2") + " Kg";
                row.cant_seleccionada = 0;
                row.cant_restante = 0;
                row.unidades_restantes = 0;
                row.unidades_seleccionadas = 0;

                gvLotesSeleccionados.PostEditor();
                gvLotesSeleccionados.UpdateCurrentRow();
            }
        }

        private void lblPesoDisponible_Click(object sender, EventArgs e)
        {

        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            LoadLotes();
        }
    }
}