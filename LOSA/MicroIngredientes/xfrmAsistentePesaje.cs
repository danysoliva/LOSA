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
using System.Threading.Tasks;
using System.Windows.Forms;
using static LOSA.MicroIngredientes.xfrmConfPlanBatch;

namespace LOSA.MicroIngredientes
{
    public partial class xfrmAsistentePesaje : DevExpress.XtraEditors.XtraForm
    {
        Int64 ordenID = 0;
        PesajeIndividualNew pesaje = new PesajeIndividualNew();
        List<PesajeIndividualNew> pesaje_list = new List<PesajeIndividualNew>();
        int PesajeID;
        int BatchPlan;
        int Default_value;

        public xfrmAsistentePesaje(Int64 id_orden, int id,int batchPlanP)
        {
            InitializeComponent();
            ordenID = id_orden;
            PesajeID = id;
            BatchPlan = batchPlanP;
            LoadData();
        }


        private void LoadData()
        {

            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                {
                    cnx.Open();
                    dsMicros.New_Pesaje.Clear();
                    SqlCommand cmd = new SqlCommand("dbo.get_Micro_Order_MP_sin_bines", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_order", ordenID);
                    cmd.Parameters.AddWithValue("@id_pesaje", PesajeID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dsMicros.New_Pesaje);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public bool HayMPSeleccionada()
        {
            bool HaySeleccionadas = false;

            int ContadordeMPs = Default_value;


            ContadordeMPs = (from Material in dsMicros.New_Pesaje
                                                        where Material.seleccionar == true
                                                        select Material).Count();
            if (ContadordeMPs > 0)
            {
                HaySeleccionadas = true;
            }

            return HaySeleccionadas;

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                bool guardar = false;
                guardar = true;
                DataOperations dp = new DataOperations();
                if (HayMPSeleccionada())
                {
                    pesaje_list.Clear();


                    foreach (var item in dsMicros.New_Pesaje)
                    {
                        if (item.seleccionar == true)
                        {

                            pesaje = new PesajeIndividualNew();
                            pesaje.Codigo = item.codigo;
                            pesaje.Material = item.material;
                            pesaje.PesoPorBatch = item.peso_por_batch;
                            pesaje.PesoTotal = item.Peso_Total;
                            pesaje.BatchPlan = item.batchPlan;
                            pesaje.OrdenID = item.id_orden;
                            pesaje.MP_ID = item.id_mp;
                            pesaje.PesoReal = 0;
                            pesaje.BatchCompletados = 0;

                            pesaje_list.Add(pesaje);
                        }
                    }

                    int id_orden = pesaje_list.GroupBy(x => x.OrdenID).FirstOrDefault().Key;
                    //int id_mp = pesaje_list.GroupBy(x=>x.MP_ID) .FirstOrDefault().Key;
                  

                    var row = (dsMicros.New_PesajeRow)gvPesaje.GetFocusedDataRow();

                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                    {
                        cnx.Open();

                        foreach (var item in dsMicros.New_Pesaje)
                        {
                            if (item.seleccionar == true)
                            {

                                SqlCommand cmd = new SqlCommand("dbo.sp_insert_MP_Pesaje_IndividualV2", cnx);
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.Add("@id_orden", SqlDbType.Int).Value = PesajeID;
                                cmd.Parameters.Add("@id_mp", SqlDbType.Int).Value = item.id_mp;
                                cmd.Parameters.Add("@peso_por_batch", SqlDbType.Decimal).Value = item.peso_por_batch;
                                cmd.Parameters.Add("@peso_total", SqlDbType.Decimal).Value = item.Peso_Total;
                                cmd.Parameters.Add("@batchPlan", SqlDbType.Int).Value = BatchPlan;


                                cmd.ExecuteNonQuery();
                            }

                        }
                        cnx.Close();
                        guardar = true;
                    }

                }

                if (guardar == true)
                {

                    //xfrmResumenMPIndividual frm = new xfrmResumenMPIndividual(pesaje_list, PesajeID,1);

                    //frm.Show();
                    this.DialogResult = DialogResult.OK;

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


        }

        private void gvPesaje_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {


                try
                {
                    var gridView = (GridView)gcPesaje.FocusedView;
                    var row = (dsMicros.New_PesajeRow)gridView.GetFocusedDataRow();
                    if (e.Column.Name == "gridColumn1")  //Este nombre de la columnaa es de seleccionar..
                    {
                        row.seleccionar = Convert.ToBoolean(e.Value);
                        row.AcceptChanges();
                    }


                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }




            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsMicros.New_PesajeRow)gvPesaje.GetFocusedDataRow();
                PesajeIndividualNew pesaje = new PesajeIndividualNew();

                pesaje.BatchPlan = 0;
                pesaje.PesoPorBatch = row.peso_por_batch;
                pesaje.PesoTotal = row.Peso_Total;
                gvPesaje.PostEditor();


                if (row.seleccionar==true)
                {
                    xfrmConfPlanBatch frm = new xfrmConfPlanBatch(pesaje,Convert.ToInt32( ModeForm.IniciarPesaje));

                    if (frm.ShowDialog()== DialogResult.OK)
                    {
                        row.batchPlan = frm.pesaje.BatchPlan;

                        gvPesaje.PostEditor();

                        pesaje_list.Clear();


                        foreach (var item in dsMicros.New_Pesaje)
                        {
                            if (item.seleccionar == true)
                            {
                                pesaje = new PesajeIndividualNew();

                                pesaje.Codigo = item.codigo;
                                pesaje.Material = item.material;
                                pesaje.PesoPorBatch = item.peso_por_batch;
                                pesaje.PesoTotal = item.Peso_Total;
                                pesaje.BatchPlan = item.batchPlan;
                                pesaje.OrdenID = item.id_orden;
                                pesaje.MP_ID = item.id_mp;
                                pesaje.PesoReal = 0;
                                pesaje.BatchCompletados = 0;

                                pesaje_list.Add(pesaje);
                            }
                        }
                    }
                }
                else
                {
                    CajaDialogo.Error("NO HA SELECCIONADO ESTE MATERIAL");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}