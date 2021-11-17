using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.MicroIngredientes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MicroIngredientes
{
    public partial class xfrmResumenMPIndividual : DevExpress.XtraEditors.XtraForm
    {

        List<PesajeIndividualNew> pesaje_list = new List<PesajeIndividualNew>();
        public xfrmResumenMPIndividual(List<PesajeIndividualNew> pPesaje_List)
        {
            InitializeComponent();
            pesaje_list = pPesaje_List;
        }

        private void xfrmResumenMPIndividual_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in pesaje_list)
                {
                    DataRow row = dsMicros.New_Pesaje.Rows.Add();

                    row["codigo"] = item.Codigo;
                    row["material"] = item.Material;
                    row["batchPlan"] = item.BatchPlan-item.BatchCompletados;
                    row["id_orden"] = item.OrdenID;
                    row["id_mp"] = item.MP_ID;
                    row["Peso_Total"] = item.PesoTotal;
                    row["peso_por_batch"] = item.PesoPorBatch;
                    row["batch_completados"] = item.BatchCompletados;

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
                    xfrmConfPlanBatch frm = new xfrmConfPlanBatch(pesaje);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        row.batchPlan = frm.pesaje.BatchPlan;

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
            xfrmPesajeIndividualV2 frm = new xfrmPesajeIndividualV2(pesaje_list);

            frm.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
