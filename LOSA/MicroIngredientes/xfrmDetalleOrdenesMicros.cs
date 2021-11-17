using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;
using System.Data.SqlClient;
using LOSA.MicroIngredientes.Models;

namespace LOSA.MicroIngredientes
{
    public partial class xfrmDetalleOrdenesMicros : DevExpress.XtraEditors.XtraForm
    {
        int id = 0;
        string codigoOrden;

        public xfrmDetalleOrdenesMicros(int _ID, string _CodigoOrden)
        {
            InitializeComponent();
            id = _ID;
            codigoOrden = _CodigoOrden;
            LoadData();
            LoadDataIndividual();

            if (dsMicros.DetalleOrdenesPesajeIndividual.Rows.Count < 1)
            {
                btnStartPesaje.Enabled = false;
            }
        }


        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.DetalleOrdenesMicro.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("[sp_get_detalle_orden_pesaje_micros_interfacev3]", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@orden_id", SqlDbType.Int).Value = id;
                    da.Fill(dsMicros.DetalleOrdenesMicro);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
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
                    dsMicros.DetalleOrdenesPesajeIndividual.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("[sp_get_detalle_orden_pesaje_micros_interface_indiv]", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@orden_id", SqlDbType.Int).Value = id;
                    da.Fill(dsMicros.DetalleOrdenesPesajeIndividual);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void xfrmDetalleOrdenesMicros_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Código Orden: "+codigoOrden;


        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
        }

        private void repositoryItemSpinEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            //xfrmSpinBatchPlan frm = new xfrmSpinBatchPlan();

            //if (frm.ShowDialog()== DialogResult.OK)
            //{
            //    LoadData();
            //}

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartPesaje_Click(object sender, EventArgs e)
        {
            List<PesajeIndividualNew> pesaje_list = new List<PesajeIndividualNew>();
            PesajeIndividualNew pesaje = new PesajeIndividualNew();

            try
            {
                foreach (var item in dsMicros.DetalleOrdenesPesajeIndividual)
                {
                    pesaje = new PesajeIndividualNew();

                    pesaje.BatchPlan = 0;
                    pesaje.MP_ID = item.id_rm;
                    pesaje.OrdenID = item.id_orden_encabezado;
                    pesaje.PesoPorBatch = item.Peso_por_Batch;
                    pesaje.PesoTotal = item.Total;
                    pesaje.Material = item.Material;
                    pesaje.BatchCompletados = item.Batch_Completados;

                    pesaje_list.Add(pesaje);

                }

                xfrmResumenMPIndividual frm = new xfrmResumenMPIndividual(pesaje_list);

                frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }
    }
}