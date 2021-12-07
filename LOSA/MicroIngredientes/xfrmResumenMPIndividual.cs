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
using System.Threading.Tasks;
using System.Windows.Forms;
using static LOSA.MicroIngredientes.xfrmConfPlanBatch;

namespace LOSA.MicroIngredientes
{
    public partial class xfrmResumenMPIndividual : DevExpress.XtraEditors.XtraForm
    {

        List<PesajeIndividualNew> pesaje_list = new List<PesajeIndividualNew>();

        int idPesaje;

        int modeForm;
        public xfrmResumenMPIndividual(List<PesajeIndividualNew> pPesaje_List,int idPesajeP,int modeFormP)
        {
            InitializeComponent();
            pesaje_list = pPesaje_List;
            idPesaje = idPesajeP;
            modeForm = modeFormP;
        }

        private void xfrmResumenMPIndividual_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in pesaje_list)
                {
                    //var row =  dsMicros.New_Pesaje.Rows.Add();
                    var row = (dsMicros.New_PesajeRow)dsMicros.New_Pesaje.Rows.Add();
                    

                    //row["codigo"] = item.Codigo;
                    //row["material"] = item.Material;
                    //row["batchPlan"] = item.BatchPlan-item.BatchCompletados;
                    //row["id_orden"] = item.OrdenID;
                    //row["id_mp"] = item.MP_ID;
                    //row["Peso_Total"] = item.PesoTotal;
                    //row["peso_por_batch"] = item.PesoPorBatch;
                    //row["batch_completados"] = item.BatchCompletados;


                    row.codigo = item.Codigo;
                    row.material = item.Material;
                    row.batchPlan = item.BatchPlan - item.BatchCompletados;
                    row.id_orden = item.OrdenID;
                    row.id_mp = item.MP_ID;
                    row.Peso_Total = item.PesoTotal;
                    row.peso_por_batch = item.PesoPorBatch;
                    row.batch_completados = item.BatchCompletados;

                    dsMicros.New_Pesaje.AcceptChanges();

                    //var row =(dsMicros.New_PesajeRow) gvPesaje.GetDataRow(gvPesaje.FocusedRowHandle);

                    //row.codigo = item.Codigo;
                    //row.material = item.Material;
                    //row.batchPlan = item.BatchPlan;

                }

                if (modeForm==1)
                {
                    colbatchPlan.Visible = true;
                    colRealBatch.Visible = false;
                    btnFinish.Visible = true;
                    simpleButton1.Visible = false;
                }

                if (modeForm == 2)
                {
                    colbatchPlan.OptionsColumn.AllowEdit = false;
                    //colbatchPlan.Visible = false;
                    colRealBatch.Visible = true;
                    btnFinish.Visible = false;
                    simpleButton1.Visible = true;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnBatchPlan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsMicros.New_PesajeRow)gvPesaje.GetFocusedDataRow();
                PesajeIndividualNew pesaje = new PesajeIndividualNew();

                pesaje.BatchPlan = row.batchPlan - row.batch_completados;
                pesaje.PesoPorBatch = row.peso_por_batch;
                pesaje.PesoTotal = row.Peso_Total;
                pesaje.PesoReal = row.peso_por_batch * row.batch_completados;
                gvPesaje.PostEditor();


                //if (row.seleccionar == true)
                //{
                    xfrmConfPlanBatch frm = new xfrmConfPlanBatch(pesaje, modeForm);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {

                    //if (modeForm==Convert.ToInt32(ModeForm.IniciarPesaje))
                    //{
                        row.batchPlan = frm.pesaje.BatchPlan;
                        row.batch_a_pesar = frm.pesaje.BatchAPesar;

                    ////}
                    //else
                    //{
                    //    row.batchPlan = frm.pesaje.BatchPlan;

                    //}

                        dsMicros.AcceptChanges();

                        gvPesaje.PostEditor();

                        pesaje_list.Clear();


                    foreach (var item in dsMicros.New_Pesaje)
                    {
                        //if (item.seleccionar == true)
                        //{
                        pesaje = new PesajeIndividualNew();

                        pesaje.Codigo = item.codigo;
                        pesaje.Material = item.material;
                        pesaje.PesoPorBatch = item.peso_por_batch;
                        pesaje.PesoTotal = item.Peso_Total;
                        pesaje.BatchPlan = item.batchPlan;
                        pesaje.OrdenID = item.id_orden;
                        pesaje.MP_ID = item.id_mp;
                        pesaje.PesoReal = item.batch_completados * item.peso_por_batch;
                        pesaje.BatchAPesar = item.batch_a_pesar;

                                pesaje_list.Add(pesaje);
                            //}
                        }
                    }
                //}
                //else
                //{
                //    CajaDialogo.Error("NO HA SELECCIONADO ESTE MATERIAL");
                //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            foreach (var item in dsMicros.New_Pesaje)
            {
                if (item.batch_a_pesar==0)
                {
                    CajaDialogo.Error("DEBE DE INGRESAR LOS BATCH A PESAR");
                    return;
                }
            }
            xfrmPesajeIndividualV2 frm = new xfrmPesajeIndividualV2(pesaje_list);

            frm.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            SqlTransaction transaccion;
        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {


            DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS);

                //using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                //{

                foreach (var item in dsMicros.New_Pesaje)
                {
                    if (item.batchPlan==0)
                    {
                        CajaDialogo.Error("DEBE DE INGRESAR LA PLANIFICACIÓN DE LOS BATCH");
                        return;
                    }
                }
               
                cnx.Open();

                transaccion= cnx.BeginTransaction();
                Boolean guardar = false;

                foreach (var item in dsMicros.New_Pesaje)
                {
                    //if (item.seleccionar == true)
                    //{

                        SqlCommand cmd = new SqlCommand("dbo.sp_insert_MP_Pesaje_IndividualV2", transaccion.Connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Transaction = transaccion;

                        cmd.Parameters.Add("@id_orden", SqlDbType.Int).Value = idPesaje;
                        cmd.Parameters.Add("@id_mp", SqlDbType.Int).Value = item.id_mp;
                        cmd.Parameters.Add("@peso_por_batch", SqlDbType.Decimal).Value = item.peso_por_batch;
                        cmd.Parameters.Add("@peso_total", SqlDbType.Decimal).Value = item.Peso_Total;
                        cmd.Parameters.Add("@batchPlan", SqlDbType.Int).Value = item.batchPlan;

                        cmd.ExecuteNonQuery();
                        guardar = true;
                    //}

                }

                if (guardar== true)
                {
                    transaccion.Commit();
                    this.Close();
                }
                cnx.Close();
            //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaccion.Rollback();
            }
        }
    }
}
