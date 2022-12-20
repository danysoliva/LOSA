using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
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
    public partial class xfrmAlimentacionTarimaArriba : DevExpress.XtraEditors.XtraForm
    {
        long order_id;

        public xfrmAlimentacionTarimaArriba()
        {
            InitializeComponent();
            //LoadHeader();
            LoadData();
            LoadData2();
            timer1.Enabled = true;
        }

        public void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("dbo.sp_load_micros_ordenes_mix", cnx);

                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        //Mix1
                        if (dr.GetInt32(4)==1 && dr.GetInt32(0)==1)
                        {
                            txtMix1.Text = dr.GetInt32(0).ToString();
                            //txtMix1.BackColor = Color.ForestGreen;
                            txtMix1.BackColor = Color.FromArgb(153,255,153);

                            txtOrden1.Text = dr.GetString(1);
                            //txtOrden1.BackColor = Color.ForestGreen;
                            txtOrden1.BackColor = Color.FromArgb(153, 255, 153);

                            txtLotePT1.Text = dr.GetInt64(2).ToString();
                            //txtLotePT1.BackColor = Color.ForestGreen;
                            txtLotePT1.BackColor = Color.FromArgb(153, 255, 153);

                            txtProducto1.Text = dr.GetString(3).ToString();
                            //txtProducto1.BackColor = Color.ForestGreen;
                            txtProducto1.BackColor = Color.FromArgb(153, 255, 153);

                            order_id = dr.GetInt32(5);
                        }

                        if (dr.GetInt32(4) == 0 && dr.GetInt32(0) == 1)
                        {
                            txtOrden1.Text = "";
                            txtOrden1.BackColor = Color.White;

                            txtLotePT1.Text = "";
                            txtLotePT1.BackColor = Color.White;

                            txtProducto1.Text = "";
                            txtProducto1.BackColor = Color.White;

                            txtMix1.Text = "1";
                            txtMix2.Text = "2";
                        }


                        //Mix 2

                        if (dr.GetInt32(4) == 1 && dr.GetInt32(0) == 2)
                        {
                            txtMix2.Text = dr.GetInt32(0).ToString();
                            txtMix2.BackColor = Color.FromArgb(153, 255, 153);//= Color.ForestGreen;

                            txtOrden2.Text = dr.GetString(1);
                            txtOrden2.BackColor = Color.FromArgb(153, 255, 153); //Color.ForestGreen;

                            txtLotePT2.Text = dr.GetInt64(2).ToString();
                            txtLotePT2.BackColor  = Color.FromArgb(153, 255, 153); //Color.ForestGreen;

                            txtProducto2.Text = dr.GetString(3).ToString();
                            txtProducto2.BackColor  = Color.FromArgb(153, 255, 153); //Color.ForestGreen;

                            order_id = dr.GetInt32(5);

                        }

                        if (dr.GetInt32(4) == 0 && dr.GetInt32(0) == 2)
                        {
                            txtOrden2.Text = "";
                            txtOrden2.BackColor = Color.White;

                            txtLotePT2.Text = "";
                            txtLotePT2.BackColor = Color.White;

                            txtProducto2.Text = "";
                            txtProducto2.BackColor = Color.White;

                            txtMix1.Text = "1";
                            txtMix2.Text = "2";
                        }
                    }

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
 
            }
        }

        private void LoadData2()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.plan_microsh_report_AlimentacionTarima.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.[sp_get_detalle_orden_pesaje_micros_interfacev2_to_reprintV2]", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //da.SelectCommand.Parameters.AddWithValue("@orden_id", SqlDbType.Int).Value = order_id;
                    da.Fill(dsMicros.plan_microsh_report_AlimentacionTarima);
                    cnx.Close();

                }

                
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.resumen_pesaje_individual_pendiente.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.[sp_get_detalle_orden_pesaje_micros_individual]", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //da.SelectCommand.Parameters.AddWithValue("@orden_id", SqlDbType.Int).Value = order_id;
                    da.Fill(dsMicros.resumen_pesaje_individual_pendiente);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }



        private void LoadHeader()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.Micros.Clear();
                    SqlCommand cmd = new SqlCommand("c", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@vertodas", toggleSwitch1.IsOn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                      order_id = dr.GetInt32(0);
                      
                    }
                }
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

        //private void txtCodBarra_KeyDown(object sender, KeyEventArgs e)
        //{
        //    AlimentacionTolvaMicrosPesaje alimentacionTolva = new AlimentacionTolvaMicrosPesaje();
        //    xfrmMezclaMicroShow frm = new xfrmMezclaMicroShow(order_id, Convert.ToInt32(txtCodBarra.Text));
        //    //xfrmMezclaMicroShow frm = new xfrmMezclaMicroShow( order_id,Convert.ToInt32(txtCodBarra.Text));
        //    DataOperations dp = new DataOperations();
        //    bool batchCompletados;

        //    try
        //    {

        //        if (order_id == 0)
        //        {
        //            CajaDialogo.Error("NO HAY UNA ORDEN ACTIVA");
        //            return;
        //        }

        //        if (alimentacionTolva.RecuperaRegistro(Convert.ToInt32(teCodBarra.Text), order_id))
        //        {
        //            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS) )
        //            {
        //                cnx.Open();

        //                SqlCommand cmd = new SqlCommand("dbo.sp_insert_adicionMezclado_acumularBatch", cnx);
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.Add("@orden_id", SqlDbType.Int).Value= order_id;
        //                cmd.Parameters.Add("@AMI_ID", SqlDbType.Int).Value= Convert.ToInt32(teCodBarra.Text);

        //                batchCompletados= Convert.ToBoolean( cmd.ExecuteScalar());

        //                cnx.Close();
        //            }

        //            LoadData2();

        //            if (batchCompletados==true)
        //            {
        //                CajaDialogo.Error("NO SE PUEDE ADICIONAR MAS BATCH");
        //                return;
        //            }
        //            else
        //            frm.ShowDialog();

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        CajaDialogo.Error(ex.Message);
        //    }
        //}

        private void txtCodBarra_TextChanged(object sender, EventArgs e)
        {
            //AlimentacionTolvaMicrosPesaje alimentacionTolva = new AlimentacionTolvaMicrosPesaje();
            //xfrmMezclaMicroShow frm = new xfrmMezclaMicroShow(order_id, Convert.ToInt32(teCodBarra.Text));
            ////xfrmMezclaMicroShow frm = new xfrmMezclaMicroShow( order_id,Convert.ToInt32(txtCodBarra.Text));
            //DataOperations dp = new DataOperations();
            //bool batchCompletados;

            //try
            //{

            //    if (order_id == 0)
            //    {
            //        CajaDialogo.Error("NO HAY UNA ORDEN ACTIVA");
            //        return;
            //    }

            //    if (alimentacionTolva.RecuperaRegistro(Convert.ToInt32(teCodBarra.Text), order_id))
            //    {
            //        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
            //        {
            //            cnx.Open();

            //            SqlCommand cmd = new SqlCommand("dbo.sp_insert_adicionMezclado_acumularBatch", cnx);
            //            cmd.CommandType = CommandType.StoredProcedure;
            //            cmd.Parameters.Add("@orden_id", SqlDbType.Int).Value = order_id;
            //            cmd.Parameters.Add("@AMI_ID", SqlDbType.Int).Value = Convert.ToInt32(teCodBarra.Text);

            //            batchCompletados = Convert.ToBoolean(cmd.ExecuteScalar());

            //            cnx.Close();
            //        }

            //        LoadData2();

            //        if (batchCompletados == true)
            //        {
            //            CajaDialogo.Error("NO SE PUEDEN ADICIONAR MAS BATCH");
            //            return;
            //        }
            //        else
            //            frm.ShowDialog();
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("NO EXISTE LA ORDEN ESCANEADA");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void teCodBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataOperations dp = new DataOperations();
                int LotePT = dp.ValidateNumberInt32(txtLotePT1.Text);
                if (LotePT == 0)
                {
                    CajaDialogo.Error("No hay una orden activa en Consola en el mezclado 1!");
                    return;
                }
                
                AlimentacionTolvaMicrosPesaje alimentacionTolva = new AlimentacionTolvaMicrosPesaje();
                if (alimentacionTolva.RecuperaRegistro(teCodBarra.Text))
                {
                    //if (alimentacionTolva.Lot != LotePT)
                    //{
                    //    CajaDialogo.Error("Esta orden no pertenece al Lote: " + LotePT.ToString() + "!" );
                    //    return;
                    //}

                    xfrmMezclaMicroShow frm = new xfrmMezclaMicroShow(order_id, 0, teCodBarra.Text, alimentacionTolva.IdMP);
                    //xfrmMezclaMicroShow frm = new xfrmMezclaMicroShow( order_id,Convert.ToInt32(txtCodBarra.Text));
                    bool batchCompletados;
                    int tipo_pesaje = 0;
                    try
                    {

                        if (order_id == 0)
                        {
                            CajaDialogo.Error("NO HAY UNA ORDEN ACTIVA");
                            return;
                        }

                        //if (alimentacionTolva.RecuperaRegistro(Convert.ToInt32(teCodBarra.Text), order_id))
                        if(frm.ShowDialog() == DialogResult.OK)
                        {
                            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                            {
                                cnx.Open();

                                SqlCommand cmd = new SqlCommand("dbo.[sp_insert_adicionMezclado_acumularBatch_v2]", cnx);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@codigo_barra_pesaje_individual", alimentacionTolva.CodigoBarra);

                                //batchCompletados = Convert.ToBoolean(cmd.ExecuteScalar());
                                tipo_pesaje = Convert.ToInt32(cmd.ExecuteScalar());
                                cnx.Close();
                            }


                            LoadData2();
                            //if (batchCompletados == true)
                            //{
                            //    CajaDialogo.Error("NO SE PUEDE ADICIONAR MAS BATCH");
                            //    return;
                            //}
                            //else
                            //    //frm.ShowDialog();
                            //    teCodBarra.Focus();
                            if (tipo_pesaje == 1)
                            {
                                //PESAJE DE NUCLEO
                                xtraTabControl1.SelectedTabPage = xtraTabPage1;
                                
                            }
                            else
                            {
                                //PESAJE INDIVIDUAL
                                xtraTabControl1.SelectedTabPage = xtraTabPage2;
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                }
            }
        }
    

        //private void teCodBarra_EditValueChanged(object sender, EventArgs e)
        //{

        //    AlimentacionTolvaMicrosPesaje alimentacionTolva = new AlimentacionTolvaMicrosPesaje();
        //    xfrmMezclaMicroShow frm = new xfrmMezclaMicroShow(order_id, Convert.ToInt32(txtCodBarra.Text));
        //    //xfrmMezclaMicroShow frm = new xfrmMezclaMicroShow( order_id,Convert.ToInt32(txtCodBarra.Text));
        //    DataOperations dp = new DataOperations();
        //    bool batchCompletados;

        //    try
        //    {

        //        if (order_id == 0)
        //        {
        //            CajaDialogo.Error("NO HAY UNA ORDEN ACTIVA");
        //            return;
        //        }

        //        if (alimentacionTolva.RecuperaRegistro(Convert.ToInt32(txtCodBarra.Text), order_id))
        //        {
        //            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
        //            {
        //                cnx.Open();

        //                SqlCommand cmd = new SqlCommand("dbo.sp_insert_adicionMezclado_acumularBatch", cnx);
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.Add("@orden_id", SqlDbType.Int).Value = order_id;
        //                cmd.Parameters.Add("@AMI_ID", SqlDbType.Int).Value = Convert.ToInt32(txtCodBarra.Text);

        //                batchCompletados = Convert.ToBoolean(cmd.ExecuteScalar());

        //                cnx.Close();
        //            }

        //            LoadData2();

        //            if (batchCompletados == true)
        //            {
        //                CajaDialogo.Error("NO SE PUEDE ADICIONAR MAS BATCH");
        //                return;
        //            }
        //            else
        //                frm.ShowDialog();

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        CajaDialogo.Error(ex.Message);
        //    }
        //}
    }
}
