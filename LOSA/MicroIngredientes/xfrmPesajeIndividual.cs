﻿using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.MicroIngredientes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MicroIngredientes
{
    public partial class xfrmPesajeIndividual : DevExpress.XtraEditors.XtraForm
    {
        //int batchMaximo;
        //int id_orden_pesaje_h;
        int BasculaSelected = 0;
        int tipoPesaje = 0;

       public enum TipoPesaje
        {
            PesajeNucleo=1,
            PesajeIndividual=2
        }

        //PesajeIndividualInfo pesajeIndividual = new PesajeIndividualInfo();
        //PesajeManualInfo pesajeManual = new PesajeManualInfo();
        PesajeBasculaInfo pesaje = new PesajeBasculaInfo();
        

        public xfrmPesajeIndividual(PesajeBasculaInfo ppesaje, int pTipoPesaje)
        {
            InitializeComponent();
            pesaje = ppesaje;
            seBatch.Properties.MaxValue = pesaje.CantBatchMaximo;
            LoadBasculas();
            tipoPesaje = pTipoPesaje;
        }


        //public xfrmPesajeIndividual(PesajeManualInfo ppesajeManual, int pTipoPesaje)
        //{
        //    InitializeComponent();
        //    pesajeManual = ppesajeManual;
        //    //seBatch.Properties.MaxValue = ppesajeIndividual.CantBatchMaximo;
        //    LoadBasculas();
        //    tipoPesaje = pTipoPesaje;
        //}

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadBasculas()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx= new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();

                    dsMicros.Pesaje_Bascula.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("sp_get_OP_Orden_pesaje_real", cnx);
                    da.Fill(dsMicros.Pesaje_Bascula);


                    cnx.Close();

                }


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdUp_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(seBatch.EditValue);
            if (val < seBatch.Properties.MaxValue)
            {
                seBatch.EditValue = val + 1;
                lblMensaje.Visible = false;
            }
            else
            {
                lblMensaje.Visible = true;
            }
        }

        private void cmdDown_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(seBatch.EditValue);
            if (val > 1)
            {
                seBatch.EditValue = val - 1;
                lblMensaje.Visible = false;
            }
        }

        private void cmdSum10_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(seBatch.EditValue);
            if (n == 1)
            {
                if (10>pesaje.CantBatchMaximo)
                {
                    seBatch.EditValue = pesaje.CantBatchMaximo;
                    lblMensaje.Visible = true;
                    lblMensaje.Text = "Cantidad maxima a pesar: " + seBatch.Properties.MaxValue;
                }
                else
                {
                seBatch.EditValue = 10;
                    lblMensaje.Visible = false;
                }
            }
            else
            {
                if ((Convert.ToInt32(seBatch.EditValue) + 10)<=seBatch.Properties.MaxValue)
                {

                seBatch.EditValue = Convert.ToInt32(seBatch.EditValue) + 10;
                }
                else
                {
                    lblMensaje.Visible = true;
                    lblMensaje.Text = "Cantidad maxima a pesar: " + seBatch.Properties.MaxValue;
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(seBatch.EditValue) - 10;
            if (n < 1)
            {
                seBatch.EditValue = 1;
            }
            else
            {
                seBatch.EditValue = n;
            }

            lblMensaje.Visible = false;
        }


        SqlTransaction transaction;

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {

                //if (BasculaSelected == 0)
                //{
                //    CajaDialogo.Error("DEBE SELECCIONAR UNA BASCULA");
                //    return;
                //}

                //pesajeIndividual.BasculaID = BasculaSelected;

                List<PesajeIndividualCompletados> pesajesCompletados = new List<PesajeIndividualCompletados>();
                DataOperations dp = new DataOperations();

                ///******Por Validar**********

                switch (tipoPesaje)
                {
                    case (int)TipoPesaje.PesajeNucleo:


                        for (int i = 1; i <= pesaje.CantBatch; i++)
                        {
                            string batch_completados2 = i + " de " + pesaje.CantBatch;
                            xfrmPesajeIndividualBatchV3 frm2 = new xfrmPesajeIndividualBatchV3(batch_completados2, "Báscula: " + lueBascula.Text, pesaje);


                            if (frm2.ShowDialog() == DialogResult.OK)
                            {
                                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                                {
                                    cnx.Open();

                                    SqlCommand cmd = new SqlCommand("sp_insert_OP_Orden_pesaje_manual_transaccion", cnx);
                                    cmd.CommandType = CommandType.StoredProcedure;


                                    cmd.Parameters.Add("@id_orden_encabezado", SqlDbType.Int).Value = pesaje.id_orden_pesaje_header;
                                    cmd.Parameters.Add("@batch_plan", SqlDbType.Int).Value = pesaje.Total;
                                    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now;
                                    cmd.Parameters.Add("@batch_real", SqlDbType.Decimal).Value = frm2.peso_bascula_finish;
                                    cmd.Parameters.Add("@id_rm", SqlDbType.Int).Value = pesaje.MateriaPrimaID;// IdMP;
                                    cmd.Parameters.Add("@bascula", SqlDbType.VarChar).Value = "B1";
                                    cmd.Parameters.Add("@id_tipo_pesaje", SqlDbType.Int).Value = 1;
                                    cmd.Parameters.Add("@lote", SqlDbType.VarChar).Value = frm2.lote_tarima_micros; //??
                                    cmd.Parameters.Add("@id_tarima", SqlDbType.VarChar).Value = frm2.idTarimaOrigen;//??
                                    cmd.Parameters.Add("@cant_batch", SqlDbType.Int).Value = pesaje.CantBatch;
                                    //cmd.Parameters.Add("@id_pesaje_manual_plan", SqlDbType.Int).Value = id_d;//??
                                    cmd.Parameters.Add("@id_pesaje_manual_plan", SqlDbType.Int).Value = DBNull.Value;//??
                                    cmd.Parameters.Add("@cant_sacos", SqlDbType.Decimal).Value = pesaje.CantBatch;//??
                                    cmd.Parameters.Add("@ami_id", SqlDbType.Int).Value = pesaje.AMI_ID;

                                    cmd.ExecuteNonQuery();

                                    cnx.Close();
                                }
                            }
                            else
                                return;

                        }

                        break;


                    case (int)TipoPesaje.PesajeIndividual:
                        for (int i = 1; i <= Convert.ToInt32(seBatch.EditValue); i++)
                        {
                            string batch_completados = i + " de " + Convert.ToInt32(seBatch.EditValue);
                            //xfrmPesajeIndividualBatch frm = new xfrmPesajeIndividualBatch(batch_completados, "Báscula: " + lueBascula.Text, pesajeIndividual);
                            xfrmPesajeIndividualBatchV3 frm = new xfrmPesajeIndividualBatchV3(batch_completados, "Báscula: " + lueBascula.Text, pesaje);



                            if (frm.ShowDialog() == DialogResult.OK)
                            {


                                DataOperations dp2 = new DataOperations();
                                SqlConnection cnx2 = new SqlConnection(dp2.ConnectionStringAPMS);
                                cnx2.Open();

                                //transaction = cnx.BeginTransaction("SampleTransaction");



                                

                                SqlCommand cmd = new SqlCommand("sp_insert_OP_Orden_pesaje_manual_batch_log", cnx2);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Transaction = transaction;


                                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                                cmd.Parameters.Add("@id_orden_pesaje_h", SqlDbType.Int).Value = pesaje.id_orden_pesaje_header;
                                cmd.Parameters.Add("@id_code", SqlDbType.Int).Value = DBNull.Value;

                                cmd.ExecuteNonQuery();

                                //foreach (dsMicro.lotes_seleccionRow row in dsMicro.lotes_seleccion.Rows)
                                //{

                                //    if (row.seleccion)
                                //    {
                                //        SqlCommand cmd3 = new SqlCommand("sp_insert_OP_Orden_pesaje_manual_transaccion", cnx2);
                                //        cmd3.CommandType = CommandType.StoredProcedure;
                                //        cmd3.Transaction = transaction;

                                //        cmd3.Parameters.Add("@id_orden_encabezado", SqlDbType.Int).Value = pesajeIndividual.id_orden_pesaje_header;
                                //        cmd3.Parameters.Add("@batch_plan", SqlDbType.Int).Value = pesajeIndividual.Batch_Plan;
                                //        cmd3.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now;
                                //        cmd3.Parameters.Add("@batch_real", SqlDbType.Decimal).Value = row.cant_seleccionada;//?
                                //        cmd3.Parameters.Add("@id_rm", SqlDbType.Int).Value = pesajeIndividual.MateriaPrimaID;// IdMP;
                                //        cmd3.Parameters.Add("@bascula", SqlDbType.VarChar).Value = "B1";
                                //        cmd3.Parameters.Add("@id_tipo_pesaje", SqlDbType.Int).Value = 2;
                                //        cmd3.Parameters.Add("@lote", SqlDbType.VarChar).Value = row.lote_materia_prima;//Dejar este parametro con espacios
                                //        cmd3.Parameters.Add("@id_tarima", SqlDbType.VarChar).Value = row.id_tarima; //??
                                //        cmd3.Parameters.Add("@cant_batch", SqlDbType.Int).Value = 1;
                                //        cmd3.Parameters.Add("@cant_sacos", SqlDbType.Int).Value = row.unidades_seleccionadas;
                                //        cmd3.Parameters.Add("@ami_id", SqlDbType.Int).Value = DBNull.Value;
                                //        cmd3.Parameters.Add("@id_pesaje_manual_plan", SqlDbType.Int).Value = DBNull.Value;

                                //        cmd3.ExecuteNonQuery();
                                //    }


                            //}



                            //transaction.Commit();
                            cnx2.Close();

                                this.DialogResult = DialogResult.OK;
                                //PesajeIndividualCompletados pesajeIndividualCompletado = new PesajeIndividualCompletados();

                                //frmSelectLotePesaje frm2 = new frmSelectLotePesaje(pesajeIndividual.MateriaPrimaID,
                                //                                                    frm.peso_bascula_finish,
                                //                                                    1,
                                //                                                    pesajeIndividual.id_orden_pesaje_header,
                                //                                                    frm.fecha);

                                //if (frm2.ShowDialog() == DialogResult.OK)
                                //{
                                //    //LoadData();
                                //pesajeIndividualCompletado.OrdenPesaje_H = pesajeIndividual.id_orden_pesaje_header;
                                //pesajeIndividualCompletado.PesoReal = frm.peso_bascula_finish;
                                //pesajeIndividualCompletado.Fecha = frm.fecha;
                                //pesajesCompletados.Add(pesajeIndividualCompletado);

                                ///******Por Validar**********
                                //DataOperations dp = new DataOperations();
                                //SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS);
                                //cnx.Open();

                                ////transaction = cnx.BeginTransaction("SampleTransaction");




                                //SqlCommand cmd = new SqlCommand("sp_insert_OP_Orden_pesaje_manual_batch_log", cnx);
                                //cmd.CommandType = CommandType.StoredProcedure;
                                //cmd.Transaction = transaction;


                                //cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = Fecha;
                                //cmd.Parameters.Add("@id_orden_pesaje_h", SqlDbType.Int).Value = Orden_h;
                                //cmd.Parameters.Add("@id_code", SqlDbType.Int).Value = DBNull.Value;

                                //cmd.ExecuteNonQuery();

                                //foreach (dsMicro.lotes_seleccionRow row in dsMicro.lotes_seleccion.Rows)
                                //{

                                //    if (row.seleccion)
                                //    {
                                //        SqlCommand cmd3 = new SqlCommand("sp_insert_OP_Orden_pesaje_manual_transaccion", cnx);
                                //        cmd3.CommandType = CommandType.StoredProcedure;
                                //        cmd3.Transaction = transaction;

                                //        cmd3.Parameters.Add("@id_orden_encabezado", SqlDbType.Int).Value = Orden_h;
                                //        cmd3.Parameters.Add("@batch_plan", SqlDbType.Int).Value = total;
                                //        cmd3.Parameters.Add("@date", SqlDbType.DateTime).Value = Fecha;
                                //        cmd3.Parameters.Add("@batch_real", SqlDbType.Decimal).Value = row.cant_seleccionada;
                                //        cmd3.Parameters.Add("@id_rm", SqlDbType.Int).Value = IdMP;// IdMP;
                                //        cmd3.Parameters.Add("@bascula", SqlDbType.VarChar).Value = "B1";
                                //        cmd3.Parameters.Add("@id_tipo_pesaje", SqlDbType.Int).Value = 2;
                                //        cmd3.Parameters.Add("@lote", SqlDbType.VarChar).Value = row.lote_materia_prima;//Dejar este parametro con espacios
                                //        cmd3.Parameters.Add("@id_tarima", SqlDbType.VarChar).Value = row.id_tarima;
                                //        cmd3.Parameters.Add("@cant_batch", SqlDbType.Int).Value = 1;
                                //        cmd3.Parameters.Add("@cant_sacos", SqlDbType.Int).Value = row.unidades_seleccionadas;
                                //        cmd3.Parameters.Add("@ami_id", SqlDbType.Int).Value = DBNull.Value;
                                //        cmd3.Parameters.Add("@id_pesaje_manual_plan", SqlDbType.Int).Value = DBNull.Value;

                                //        cmd3.ExecuteNonQuery();
                                //    }


                                //}



                                //transaction.Commit();
                                //cnx.Close();




                            }
                            else
                                return;

                        }

                        break;
                }








                //OLD*************
                //DataOperations dp = new DataOperations();
                //SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS);
                //cnx.Open();

                //transaction = cnx.BeginTransaction("SampleTransaction");

                //if (Convert.ToInt32(seBatch.EditValue) == pesajesCompletados.Count())
                //{

                //    foreach (var item in pesajesCompletados)
                //    {

                //        SqlCommand cmd = new SqlCommand("sp_insert_OP_Orden_pesaje_manual_batch_log", transaction.Connection);
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        cmd.Transaction = transaction;


                //        cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = item.Fecha;
                //        cmd.Parameters.Add("@id_orden_pesaje_h", SqlDbType.Int).Value = pesajeIndividual.id_orden_pesaje_header;
                //        cmd.Parameters.Add("@id_code", SqlDbType.Int).Value = DBNull.Value;

                //        cmd.ExecuteNonQuery();

                //    }

                //    foreach (var item in pesajesCompletados)
                //    {

                //        SqlCommand cmd3 = new SqlCommand("sp_insert_OP_Orden_pesaje_manual_transaccion", transaction.Connection);
                //        cmd3.CommandType = CommandType.StoredProcedure;
                //        cmd3.Transaction = transaction;

                //        cmd3.Parameters.Add("@id_orden_encabezado", SqlDbType.Int).Value = item.OrdenPesaje_H;
                //        cmd3.Parameters.Add("@batch_plan", SqlDbType.Int).Value = pesajeIndividual.PesoPorBatch;
                //        cmd3.Parameters.Add("@date", SqlDbType.DateTime).Value = item.Fecha;
                //        cmd3.Parameters.Add("@batch_real", SqlDbType.Decimal).Value = item.PesoReal;
                //        cmd3.Parameters.Add("@id_rm", SqlDbType.Int).Value = pesajeIndividual.MateriaPrimaID;// IdMP;
                //        cmd3.Parameters.Add("@bascula", SqlDbType.VarChar).Value = lueBascula.Text;
                //        cmd3.Parameters.Add("@id_tipo_pesaje", SqlDbType.Int).Value = 2;
                //        cmd3.Parameters.Add("@lote", SqlDbType.VarChar).Value = "";//Dejar este parametro con espacios
                //        cmd3.Parameters.Add("@id_tarima", SqlDbType.VarChar).Value = DBNull.Value;
                //        cmd3.Parameters.Add("@cant_batch", SqlDbType.Int).Value = 1;
                //        cmd3.Parameters.Add("@cant_sacos", SqlDbType.Int).Value = DBNull.Value;
                //        cmd3.Parameters.Add("@ami_id", SqlDbType.Int).Value = DBNull.Value;
                //        cmd3.Parameters.Add("@id_pesaje_manual_plan", SqlDbType.Int).Value = DBNull.Value;

                //        cmd3.ExecuteNonQuery();
                //    }

                //}
                //transaction.Commit();
                //cnx.Close();

                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                CajaDialogo.Error(ex.Message);                                      
            }
        }



        //private void GuardarPesaje()
        //{
        //    DataOperations dp = new DataOperations();

        //    decimal peso_bascula = 0;

        //    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
        //    {
        //        cnx.Open();
        //        SqlCommand cmd = new SqlCommand("sp_get_peso_bascula_by_id", cnx);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        peso_bascula = Convert.ToDecimal(cmd.ExecuteScalar());

        //        cnx.Close();

        //    }

        //    peso_bascula = pesajeIndividual.PesoPorBatch;

        //    for (int i = 1; i <= seBatch.Properties.MaxValue; i++)
        //    {
        //        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
        //        {
        //            cnx.Open();

        //            SqlCommand cmd = new SqlCommand("sp_insert_OP_Orden_pesaje_manual_transaccion", cnx);
        //            cmd.CommandType = CommandType.StoredProcedure;


        //            cmd.Parameters.Add("@id_orden_encabezado", SqlDbType.Int).Value = pesajeIndividual.id_orden_pesaje_header;
        //            cmd.Parameters.Add("@batch_plan", SqlDbType.Int).Value = pesajeIndividual.Total;
        //            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now;
        //            cmd.Parameters.Add("@batch_real", SqlDbType.Decimal).Value = peso_bascula;
        //            cmd.Parameters.Add("@id_rm", SqlDbType.Int).Value = pesajeIndividual.MateriaPrimaID;// IdMP;
        //            cmd.Parameters.Add("@bascula", SqlDbType.VarChar).Value = "";
        //            cmd.Parameters.Add("@id_tipo_pesaje", SqlDbType.Int).Value = 2;
        //            cmd.Parameters.Add("@lote", SqlDbType.VarChar).Value = DBNull.Value;
        //            cmd.Parameters.Add("@id_tarima", SqlDbType.VarChar).Value = DBNull.Value;
        //            cmd.Parameters.Add("@cant_batch", SqlDbType.VarChar).Value = 1;
        //            cmd.Parameters.Add("@id_pesaje_manual_plan", SqlDbType.Int).Value = DBNull.Value;

        //            cmd.ExecuteNonQuery();

        //            cnx.Close();
        //        }
        //    }
                   
                        
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            //lblValorbascula.Text = "Valor en Báscula: " + peso_bascula + " Kg";
        }

        private void xfrmPesajeIndividual_Load(object sender, EventArgs e)
        {
            if (tipoPesaje==(int)TipoPesaje.PesajeNucleo)
            {
                labelControl1.Visible = false;
                cmdUp.Visible = false;
                cmdDown.Visible = false;
                seBatch.Visible = false;
                simpleButton1.Visible = false;
                cmdSum10.Visible = false;
            }
        }

        private void Bascula1_Click(object sender, EventArgs e)
        {
            BasculaSelected = 1;
            Bascula1.Appearance.BackColor = Color.FromArgb(51, 196, 129);
            Bascula2.Appearance.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void Bascula2_Click(object sender, EventArgs e)
        {
            BasculaSelected = 2;
            Bascula2.Appearance.BackColor = Color.FromArgb(51, 196, 129);
            Bascula1.Appearance.BackColor = Color.FromArgb(255, 255, 255);
        }
    }
}