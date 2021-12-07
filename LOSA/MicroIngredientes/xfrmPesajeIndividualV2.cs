using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class xfrmPesajeIndividualV2 : DevExpress.XtraEditors.XtraForm
    {
        //int batchMaximo;
        //int id_orden_pesaje_h;
        int BasculaSelected = 0;
        PesajeIndividualInfo pesajeIndividual = new PesajeIndividualInfo();

        public xfrmPesajeIndividualV2(PesajeIndividualInfo ppesajeIndividual)
        {
            InitializeComponent();
            //batchMaximo = pBatchMaximo;
            pesajeIndividual = ppesajeIndividual;
            //seBatch.Properties.MaxValue = ppesajeIndividual.CantBatchMaximo;
            LoadBasculas();
            //id_orden_pesaje_h = pid_orden_pesaje_h;
        }


        List<PesajeIndividualNew> pesaje_list = new List<PesajeIndividualNew>();

        public xfrmPesajeIndividualV2(List<PesajeIndividualNew> pPesaje)
        {
            InitializeComponent();
            //pesajeIndividual = ppesajeIndividual;
            LoadBasculas();
            pesaje_list = pPesaje;
        }

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

                pesajeIndividual.BasculaID = BasculaSelected;

                List<PesajeIndividualCompletados> pesajesCompletados = new List<PesajeIndividualCompletados>();


                foreach (var item in pesaje_list)
                {
                    int counter = 1;

                    string batch_completados = counter + " de " + item.BatchPlan;

                    pesajeIndividual.BasculaID = BasculaSelected;
                    pesajeIndividual.Batch_Plan = item.BatchAPesar;
                    pesajeIndividual.PesoPorBatch = item.PesoPorBatch;
                    //pesajeIndividual

                    xfrmPesajeIndividualBatchV3 frm = new xfrmPesajeIndividualBatchV3(batch_completados, "Báscula: " + lueBascula.Text, pesajeIndividual,item.Material);


                    for (int i = 1; i <= item.BatchPlan; i++)
                    {

                        if (frm.ShowDialog() == DialogResult.OK)
                        {

                            PesajeIndividualCompletados pesajeIndividualCompletado = new PesajeIndividualCompletados();

                            //frmSelectLotePesaje frm2 = new frmSelectLotePesaje(pesajeIndividual.MateriaPrimaID,
                            //                                                    frm.peso_bascula,
                            //                                                    1,
                            //                                                    pesajeIndividual.id_orden_pesaje_header,
                            //                                                    frm.fecha);


                            frmSelectLotePesaje frm2 = new frmSelectLotePesaje(item.MP_ID,
                                                                                frm.peso_bascula_finish,
                                                                                1,
                                                                                item.OrdenID,
                                                                                frm.fecha);
                            if (frm2.ShowDialog() == DialogResult.OK)
                            {
                                //LoadData();
                                pesajeIndividualCompletado.OrdenPesaje_H = pesajeIndividual.id_orden_pesaje_header;
                                //pesajeIndividualCompletado.PesoReal = frm.peso_bascula_finish;
                                pesajeIndividualCompletado.Fecha = frm.fecha;

                                pesajesCompletados.Add(pesajeIndividualCompletado);


                            }



                        }
                        else
                            return;

                    }


                }

                //for (int i = 1; i <= Convert.ToInt32(seBatch.EditValue); i++)
                //{

                //    if (frm.ShowDialog() == DialogResult.OK)
                //    {

                //        PesajeIndividualCompletados pesajeIndividualCompletado = new PesajeIndividualCompletados();

                //        frmSelectLotePesaje frm2 = new frmSelectLotePesaje(pesajeIndividual.MateriaPrimaID,
                //                                                            frm.peso_bascula,
                //                                                            1,
                //                                                            pesajeIndividual.id_orden_pesaje_header,
                //                                                            frm.fecha);
                //        if (frm2.ShowDialog() == DialogResult.OK)
                //        {
                //            //LoadData();
                //            pesajeIndividualCompletado.OrdenPesaje_H = pesajeIndividual.id_orden_pesaje_header;
                //            pesajeIndividualCompletado.PesoReal = frm.peso_bascula;
                //            pesajeIndividualCompletado.Fecha = frm.fecha;

                //            pesajesCompletados.Add(pesajeIndividualCompletado);


                //        }



                //    }
                //    else
                //        return;

                //}









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
            try
            {
                foreach (var item in pesaje_list)
                {
                    //DataRow row = dsMicros.New_Pesaje.Rows.Add();
                    var row = (dsMicros.New_PesajeRow) dsMicros.New_Pesaje.Rows.Add();

                    //row["codigo"] = item.Codigo;
                    //row["material"] = item.Material;
                    //row["batchPlan"] = item.BatchPlan;

                    row.codigo = item.Codigo;
                    row.material = item.Material;
                    row.batchPlan = item.BatchPlan;
                    row.batch_a_pesar = item.BatchAPesar;

                    //row["codigo"] = item.Codigo;
                    //row["material"] = item.Material;
                    //row["batchPlan"] = item.BatchPlan;

                    dsMicros.New_Pesaje.AcceptChanges();

                    //var row =(dsMicros.New_PesajeRow) gvPesaje.GetDataRow(gvPesaje.FocusedRowHandle);

                    //row.codigo = item.Codigo;
                    //row.material = item.Material;
                    //row.batchPlan = item.BatchPlan;

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            
            //gcPesaje.DataSource = pesaje_list.ToArray();
           
            //table.Rows.Add(row);
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