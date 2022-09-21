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
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MicroIngredientes
{
    public partial class xfrmDetalleOrdenesMicros : DevExpress.XtraEditors.XtraForm
    {
        int id = 0;
        string codigoOrden;
        int LotePT;
        UserLogin UsuarioLogeado;

        public xfrmDetalleOrdenesMicros(int _ID, string _CodigoOrden, int LotePt, UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            id = _ID;
            LotePT = LotePt;
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
                    SqlDataAdapter da = new SqlDataAdapter("[sp_get_detalle_orden_pesaje_micros_interface_indiv_v2]", cnx);
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
            lblTitulo.Text = "Código Orden: "+codigoOrden + " Lote: " + LotePT.ToString();


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

                    pesaje.BatchPlan = item.Batch_Plan;
                    pesaje.MP_ID = item.id_rm;
                    pesaje.OrdenID = item.id_orden_encabezado;
                    pesaje.PesoPorBatch = item.Peso_por_Batch;
                    pesaje.PesoTotal = item.Total;
                    pesaje.Material = item.Material;
                    pesaje.BatchCompletados = item.Batch_Completados;
                    pesaje.Codigo = item.codigo;

                    pesaje_list.Add(pesaje);

                }

                xfrmResumenMPIndividual frm = new xfrmResumenMPIndividual(pesaje_list,id,2);

                frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void cmdConfigurarDetalle_Click(object sender, EventArgs e)
        {
            int tipo_pesaje = 0;
            if (xtraTabControl1.SelectedTabPageIndex == 0)
                tipo_pesaje = 1;//mezcla
            else
                tipo_pesaje = 2;//Individual

            frmDetalleFormula frm = new frmDetalleFormula(UsuarioLogeado, LotePT, id, tipo_pesaje);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_set_insert_new_mp_for_pesaje_micros", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_orden_encabezado", id);
                    cmd.Parameters.AddWithValue("@id_rm", frm.IdRM);
                    cmd.Parameters.AddWithValue("@batch_plan", frm.CantBatch);
                    cmd.Parameters.AddWithValue("@id_tipo_pesaje", tipo_pesaje);
                    cmd.Parameters.AddWithValue("@set_point", frm.PlanByBatch);
                    cmd.Parameters.AddWithValue("@set_point_total", frm.PlanBatchTotal);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    if (xtraTabControl1.SelectedTabPageIndex == 0)
                        LoadData();
                    else
                        LoadDataIndividual();

                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }

         


        }

        private void cmdEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Mezclas o Nucleos
            //Validar si hay batch que se hayan pesado de esta materia prima antes de permitir eliminar
            var gridView = (GridView)gcDetalle.FocusedView;
            var row = (dsMicros.DetalleOrdenesMicroRow)gridView.GetFocusedDataRow();

            FuncionesMicroI Fn = new FuncionesMicroI();
            decimal valor = Fn.GetValorPesadoPorRM(row.id_RM, id);

            if (valor > 0)
            {
                CajaDialogo.Error("Ya se efectuaron pesajes de este material! No se permite eliminmar esta Materia Prima. Solicite ayuda de su supervisor o el depto. de IT");
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Esta seguro que desea quitar esta materia prima de Micro Ingredientes?");
            if (r != DialogResult.Yes)
                return;

            //Update enable = 0 al row 
            if (Fn.SetEnableRM_and_order(row.id_RM, id, false))
                LoadData();

        }

        private void cmdEliminarI_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Individuales
            //Validar si hay batch que se hayan pesado de esta materia prima antes de permitir eliminar
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsMicros.DetalleOrdenesPesajeIndividualRow)gridView.GetFocusedDataRow();

            FuncionesMicroI Fn = new FuncionesMicroI();
            decimal valor = Fn.GetValorPesadoPorRM(row.id_rm, id);

            if (valor > 0)
            {
                CajaDialogo.Error("Ya se efectuaron pesajes de este material! No se permite eliminmar esta Materia Prima. Solicite ayuda de su supervisor o el depto. de IT");
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Esta seguro que desea quitar esta materia prima de Micro Ingredientes?");
            if (r != DialogResult.Yes)
                return;

            //Update enable = 0 al row 
            if (Fn.SetEnableRM_and_order(row.id_rm, id, false))
                LoadDataIndividual();

        }
    }
}