using ACS.Classes;
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

        PesajeIndividualInfo pesajeIndividual = new PesajeIndividualInfo();

        public xfrmPesajeIndividual(PesajeIndividualInfo ppesajeIndividual)
        {
            InitializeComponent();
            //batchMaximo = pBatchMaximo;
            pesajeIndividual = ppesajeIndividual;
            seBatch.Properties.MaxValue = ppesajeIndividual.CantBatchMaximo;
            LoadBasculas();
            //id_orden_pesaje_h = pid_orden_pesaje_h;
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
                seBatch.EditValue = 10;
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

                if (string.IsNullOrEmpty(lueBascula.Text))
                {
                    CajaDialogo.Error("DEBE SELECCIONAR UNA BASCULA");
                    return;
                }

                int cantBatch_a_pesar = Convert.ToInt32( seBatch.EditValue);
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS);
                cnx.Open();

                transaction = cnx.BeginTransaction("SampleTransaction");

                //Obtener peso de bascula
                decimal peso_bascula = 0;

                SqlCommand cmd2= new SqlCommand("sp_get_peso_bascula_by_id", transaction.Connection);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(lueBascula.EditValue);

                cmd2.Transaction = transaction;

                peso_bascula = Convert.ToDecimal(cmd2.ExecuteScalar());


                //Thread.Sleep(5000);
                    //int conteo=0;
                for (int i = 1; i <= cantBatch_a_pesar; i++)
                {
 
                        SqlCommand cmd = new SqlCommand("sp_insert_OP_Orden_pesaje_manual_batch_log", transaction.Connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Transaction = transaction;


                        cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                        cmd.Parameters.Add("@id_orden_pesaje_h", SqlDbType.Int).Value = pesajeIndividual.id_orden_pesaje_header;
                        cmd.Parameters.Add("@id_code", SqlDbType.Int).Value = 0;

                        cmd.ExecuteNonQuery();

                }



                //esto es temporal solo para hacer validaciones.. se debe quitar esta linea
                peso_bascula = pesajeIndividual.PesoPorBatch;


                        SqlCommand cmd3 = new SqlCommand("sp_insert_OP_Orden_pesaje_manual_transaccion", transaction.Connection);
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Transaction = transaction;

                        cmd3.Parameters.Add("@id_orden_encabezado", SqlDbType.Int).Value = pesajeIndividual.id_orden_pesaje_header;
                        cmd3.Parameters.Add("@batch_plan", SqlDbType.Int).Value = pesajeIndividual.Total;
                        cmd3.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now;
                        cmd3.Parameters.Add("@batch_real", SqlDbType.Decimal).Value = peso_bascula*Convert.ToDecimal( seBatch.EditValue);
                        cmd3.Parameters.Add("@id_rm", SqlDbType.Int).Value = pesajeIndividual.MateriaPrimaID;// IdMP;
                        cmd3.Parameters.Add("@bascula", SqlDbType.VarChar).Value = "";
                        cmd3.Parameters.Add("@id_tipo_pesaje", SqlDbType.Int).Value = 2;
                        cmd3.Parameters.Add("@lote", SqlDbType.VarChar).Value = DBNull.Value;
                        cmd3.Parameters.Add("@id_tarima", SqlDbType.VarChar).Value = DBNull.Value;
                        cmd3.Parameters.Add("@cant_batch", SqlDbType.VarChar).Value = seBatch.EditValue;
                        cmd3.Parameters.Add("@id_pesaje_manual_plan", SqlDbType.Int).Value = DBNull.Value;
                           
                        cmd3.ExecuteNonQuery();

                 transaction.Commit();
                cnx.Close();
                timer1.Enabled = false;

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
            DataOperations dp = new DataOperations();

            decimal peso_bascula = 0;
            int id_bascula = 0;

            if (string.IsNullOrEmpty( lueBascula.Text))
            {
                id_bascula = 0;
            }
            else
            {
                id_bascula = Convert.ToInt32(lueBascula.EditValue);
            }

            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("sp_get_peso_bascula_by_id", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id_bascula;

                peso_bascula = Convert.ToDecimal(cmd.ExecuteScalar());

                cnx.Close();

            }

            lblValorbascula.Text = "Valor en Báscula: " + peso_bascula + " Kg";
        }

        private void xfrmPesajeIndividual_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}