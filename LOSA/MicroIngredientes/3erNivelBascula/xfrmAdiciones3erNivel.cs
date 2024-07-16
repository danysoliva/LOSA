using ACS.Classes;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.MicroIngredientes._3erNivelBascula;
using SAPbouiCOM;
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
    public partial class xfrmAdiciones3erNivel : DevExpress.XtraEditors.XtraForm
    {
        long order_id;
        long order_id_first_mix;
        long IdBatchProceso;
        int LotePT_BatchEnProceso;
        decimal LecturaBascula;
        decimal TaraBascula;
        decimal PesoActual;
        string CodigoBarraLeido;
        int IdRwLeida;

        public xfrmAdiciones3erNivel()
        {
            InitializeComponent();
            //LoadHeader();
            LoadData();
            LoadData2();
            LoadDataBatchEnProceso();
            LoadDataIndividual();
            timer1.Enabled = true;
            timerAlarmaBit.Start();
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
                            order_id_first_mix = dr.GetInt32(5);

                            txtBatchTotal1.BackColor = 
                            txtBatchAgregados1.BackColor = Color.FromArgb(153, 255, 153);
                            

                            if (!dr.IsDBNull(dr.GetOrdinal("batch_agregados")))
                                txtBatchAgregados1.Text = dr.GetInt32(6).ToString();


                            if (!dr.IsDBNull(dr.GetOrdinal("plan_batch")))
                                txtBatchTotal1.Text = dr.GetInt32(7).ToString();

                            if (!dr.IsDBNull(dr.GetOrdinal("order_id")))
                                order_id_first_mix=order_id = dr.GetInt64(8);
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

                            txtBatchTotal1.Text = txtBatchAgregados1.Text = "";
                            txtBatchTotal1.BackColor = txtBatchAgregados1.BackColor = Color.White;
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

                            txtBatchTotal2.BackColor =
                            txtBatchAgregados2.BackColor = Color.FromArgb(153, 255, 153);

                            if (!dr.IsDBNull(dr.GetOrdinal("batch_agregados")))
                                txtBatchAgregados2.Text = dr.GetInt32(6).ToString();


                            if (!dr.IsDBNull(dr.GetOrdinal("plan_batch")))
                                txtBatchTotal2.Text = dr.GetInt32(7).ToString();

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

                            txtBatchTotal2.Text = txtBatchAgregados2.Text = "";
                            txtBatchTotal2.BackColor = txtBatchAgregados2.BackColor = Color.White;
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
                    SqlDataAdapter da = new SqlDataAdapter("dbo.[sp_get_detalle_orden_pesaje_micros_interfacev2_Aliementacion_5toNivel]", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@orden_id", SqlDbType.Int).Value = order_id_first_mix;
                    da.Fill(dsMicros.plan_microsh_report_AlimentacionTarima);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void LoadDataBatchEnProceso()
        {
            if (order_id_first_mix > 0)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                    {
                        cnx.Open();
                        dsBatchActual1.batch_en_proceso.Clear();
                        SqlDataAdapter da = new SqlDataAdapter("dbo.[sp_obtener_ultimo_batch_en_proceso_3er_nivel]", cnx);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@id_orden", order_id_first_mix);
                        da.Fill(dsBatchActual1.batch_en_proceso);

                        if(dsBatchActual1.batch_en_proceso.Count > 0)
                        {
                            foreach(dsBatchActual.batch_en_procesoRow row in dsBatchActual1.batch_en_proceso)
                            {
                                IdBatchProceso = row.id;
                                LotePT_BatchEnProceso = row.lote_pt;
                                break;
                            }

                            //LecturaBascula;
                            TaraBascula = 0;
                            foreach (dsBatchActual.batch_en_procesoRow row in dsBatchActual1.batch_en_proceso)
                            {
                                TaraBascula += row.Cantidad_Kg;
                            }
                            
                            PesoActual = LecturaBascula - TaraBascula;
                            lblTaraBascula.Text = string.Format("{0:###,##0.00}", TaraBascula);
                            lblPesoActual.Text = string.Format("{0:###,##0.00}", PesoActual);
                        }
                        cnx.Close();
                    }
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void LoadDataIndividual()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    //dsMicros.resumen_pesaje_individual_pendiente.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.[sp_get_detalle_orden_pesaje_micros_individualV2]", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@orden_id", SqlDbType.Int).Value = order_id_first_mix;
                    //da.Fill();

                    cnx.Close();

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


        private void txtCodBarra_TextChanged(object sender, EventArgs e){}

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void teCodBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataOperations dp = new DataOperations();
                int LotePT = LotePT_BatchEnProceso;
                LotePT = dp.ValidateNumberInt32(txtLotePT1.Text);
                if (LotePT == 0)
                {
                    CajaDialogo.Error("No hay una orden activa en Consola en el mezclado 1!");
                    return;
                }

                AlimentacionTolvaMicrosPesaje alimentacionTolva = new AlimentacionTolvaMicrosPesaje();
                if (alimentacionTolva.RecuperaRegistro(teCodBarra.Text))
                {
                    if (alimentacionTolva.Lot != LotePT)
                    {
                        CajaDialogo.Error("Esta orden no pertenece al Lote: " + LotePT.ToString() + "!");
                        return;
                    }

                    int tipo_pesaje = alimentacionTolva.TipoPesaje;

                    if (alimentacionTolva.TipoPesaje == 1)//1=Nucleo, 2=Individuales
                    {
                        CajaDialogo.Error("Solo se permite escanear materia prima individual para adicion en mezclado!");
                        return;
                    }

                    try
                    {

                        if (order_id == 0)
                        {
                            CajaDialogo.Error("NO HAY UNA ORDEN ACTIVA");
                            return;
                        }

                        MateriaPrima mp = new MateriaPrima();
                        if (mp.RecuperarRegistro_MPACS_For_IDRM_APMS(alimentacionTolva.IdMP))
                        {
                            txtMateriaPrimaEscaneada.Text = mp.CodeMP_SAP + " - " + mp.NameComercial;
                            IdRwLeida = alimentacionTolva.IdMP;
                        }
                        CodigoBarraLeido = teCodBarra.Text;
                        teCodBarra.Text = "";
                        teCodBarra.Focus();

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                }
                else
                {
                    CodigoBarraLeido = "";
                }
            }
        }

        private void cmdIniciarBatch_Click(object sender, EventArgs e)
        {
            timer_LecturaTolvaBascula.Enabled = true;
            timer_LecturaTolvaBascula.Start();

        }

        private void timer_LecturaTolvaBascula_Tick(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.Micros.Clear();
                    SqlCommand cmd = new SqlCommand("sp_get_recuperar_lectura_peso_bascula_tolva_micro_ingredientes", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@vertodas", toggleSwitch1.IsOn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        LecturaBascula = dr.GetDecimal(0);
                        lblPesoActualBascula.Text = string.Format("{0:###,##0.00}", LecturaBascula);
                        //LecturaBascula;
                        TaraBascula = 0;
                        decimal total_agregado = 0;
                        foreach (dsBatchActual.batch_en_procesoRow row in dsBatchActual1.batch_en_proceso)
                        {
                            TaraBascula += row.Cantidad_Kg;
                            total_agregado += row.Cantidad_Kg;
                        }

                        lblTotalKgAgregados.Text = string.Format("{0:###,##0.00}", total_agregado);
                        PesoActual = LecturaBascula - TaraBascula;
                        lblTaraBascula.Text = string.Format("{0:###,##0.00}", TaraBascula);
                        lblPesoActual.Text = string.Format("{0:###,##0.00}", PesoActual);
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdRefrescar_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadDataBatchEnProceso();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CodigoBarraLeido))
            {
                if (order_id_first_mix > 0)
                {
                    if (IdRwLeida > 0)
                    {
                        if (PesoActual > 0)
                        {
                            DataOperations dp = new DataOperations();
                            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                            {
                                cnx.Open();

                                SqlCommand cmd = new SqlCommand("sp_insert_adicionMezclado_acumularBatch_v4", cnx);
                                cmd.CommandType = CommandType.StoredProcedure;
                                //cmd.Parameters.AddWithValue("@codigo_barra_pesaje_individual", alimentacionTolva.CodigoBarra);
                                cmd.Parameters.AddWithValue("@codigo_barra_pesaje_individual", CodigoBarraLeido);
                                cmd.ExecuteScalar();

                                //batchCompletados = Convert.ToBoolean(cmd.ExecuteScalar());
                                cnx.Close();
                            }


                            //Gestion de batch
                            if (IdBatchProceso == 0)
                            {
                                //Cremoas uno nuevo
                                if (order_id_first_mix > 0)
                                {
                                    //creamos el batch
                                    try
                                    {
                                        //DataOperations dp = new DataOperations();
                                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                                        {
                                            cnx.Open();
                                            dsMicros.Micros.Clear();
                                            SqlCommand cmd = new SqlCommand("sp_insert_new_batch_3er_nivel_micros", cnx);
                                            cmd.CommandType = CommandType.StoredProcedure;
                                            cmd.Parameters.AddWithValue("@order_id", order_id_first_mix);
                                            //cmd.Parameters.AddWithValue("@id_usuario", this.colid_usuario);
                                            IdBatchProceso = Convert.ToInt64(cmd.ExecuteScalar());
                                            //LoadDataBatchEnProceso();
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        CajaDialogo.Error(ex.Message);
                                    }
                                }
                                else
                                {
                                    CajaDialogo.Error("No hay una orden activa en Consola para poder realizar un pesaje!");
                                    return;
                                }
                            }

                            if (order_id_first_mix > 0 && IdBatchProceso > 0 && IdRwLeida > 0)
                            {
                                //Permitimos agregar pesajes
                                try
                                {
                                    //DataOperations dp = new DataOperations();
                                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                                    {
                                        cnx.Open();
                                        dsMicros.Micros.Clear();
                                        SqlCommand cmd = new SqlCommand("sp_insert_detalle_batch_pesaje_3er_nivel", cnx);
                                        cmd.CommandType = CommandType.StoredProcedure;
                                        cmd.Parameters.AddWithValue("@id_h", IdBatchProceso);
                                        cmd.Parameters.AddWithValue("@id_rw", IdRwLeida);
                                        cmd.Parameters.AddWithValue("@cantidad", PesoActual);
                                        cmd.Parameters.AddWithValue("@tara", TaraBascula);
                                        //cmd.Parameters.AddWithValue("@id_usuario", this.colid_usuario);
                                        cmd.ExecuteNonQuery();
                                        //LoadDataBatchEnProceso();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    CajaDialogo.Error(ex.Message);
                                }
                            }
                            else
                            {
                                CajaDialogo.Error("No hay una orden activa en Consola para poder realizar un pesaje!");
                                return;
                            }

                            LoadDataBatchEnProceso();
                            CodigoBarraLeido = teCodBarra.Text;
                            teCodBarra.Text = "";
                            txtMateriaPrimaEscaneada.Text = "";
                            teCodBarra.Focus();
                        }
                        else
                        {
                            CajaDialogo.Error("No se ha escaneado ninguna materia prima!");
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("No se permite guardar lecturas o pesajes menores o iguales a cero!");
                    }
                }
                else
                {
                    CajaDialogo.Error("No hay ninguna orden cargada en el mix 1 en consola!");
                }
            }
            else
            {
                CajaDialogo.Error("No se ha escaneado ninguna materia prima!");
            }
        }

        private void cmdFinalizarBatch_Click(object sender, EventArgs e)
        {
            if (IdBatchProceso > 0)
            {
                DialogResult r = CajaDialogo.Pregunta("Esta seguro de finalizar este batch?");
                if (r != DialogResult.Yes)
                {
                    return;
                }

                try
                {
                    DataOperations dp = new DataOperations();
                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                    {
                        cnx.Open();
                        dsMicros.Micros.Clear();
                        SqlCommand cmd = new SqlCommand("sp_set_update_finalizado_batch_tercer_nivel", cnx);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_h", IdBatchProceso);
                        cmd.ExecuteNonQuery();
                        //LoadDataBatchEnProceso();

                        //escribir el bit en el PLC

                    }
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }

                IdBatchProceso = 0;
                CodigoBarraLeido = teCodBarra.Text;
                teCodBarra.Text = "";
                txtMateriaPrimaEscaneada.Text = "";
                LoadDataBatchEnProceso();
                teCodBarra.Focus();
            }
            else
            {
                CajaDialogo.Error("No hay un batch en proceso que se pueda finalizar!");
            }
        }

        private void timerAlarmaBit_Tick(object sender, EventArgs e)
        {
            //Lectura del bit desde el PLC
            bool BitInicio = false;

            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.Micros.Clear();
                    SqlCommand cmd = new SqlCommand("sp_get_recuperar_lectura_bit_alarma_3er_nivel", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@id_h", IdBatchProceso);
                    BitInicio = Convert.ToBoolean(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            if(BitInicio && TaraBascula > 0)
            {
                cmdFinalizarBatch.Enabled = true;
            }
            else
            {
                cmdFinalizarBatch.Enabled = false;
            }


        }
    }
}
