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
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MicroIngredientes
{
    public partial class xfrmMicroIngredientes : DevExpress.XtraEditors.XtraForm
    {
        public xfrmMicroIngredientes()
        {
            InitializeComponent();
            LoadData();
        }


        private void LoadData()
        {

            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.Micros.Clear();
                    SqlCommand cmd = new SqlCommand("sp_get_ordenes_pesaje_manual_interface_V5", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@vertodas", toggleSwitch1.IsOn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dsMicros.Micros);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridView = (GridView)gcMicros.FocusedView;
                var row = (dsMicros.MicrosRow)gridView.GetDataRow(gridView.FocusedRowHandle);


                if (row != null)
                {
                    xfrmDetalleOrdenesMicros frm = new xfrmDetalleOrdenesMicros(row.id, row.Codigo_Orden);
                    //frm.MdiParent = this.MdiParent;
                    frm.ShowDialog();
                }


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void CambiarEstado(int caseEstado , dsMicros.MicrosRow row)
        {
            try
            {

                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {

                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("dbo.sp_get_cambiar_estado_OP_Orden_pesaje_manual", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", SqlDbType.Int).Value = row.id;
                    cmd.Parameters.AddWithValue("estado", SqlDbType.Int).Value = row._Cod__Estado;
                    cmd.Parameters.AddWithValue("case", SqlDbType.Int).Value = caseEstado;

                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }

                LoadData();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void btnActivar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gv = (GridView)gcMicros.FocusedView;
                var row = (dsMicros.MicrosRow)gv.GetDataRow(gv.FocusedRowHandle);

                DataOperations dp = new DataOperations();
                Boolean ExisteConfPesajeManual;

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("dbo.sp_validate_OP_Conf_PesajeIndividual",cnx);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_orden", SqlDbType.Int).Value = row.id;

                     ExisteConfPesajeManual = Convert.ToBoolean( cmd.ExecuteScalar());

                    cnx.Close();
                }

                if (row != null)
                {

                    if (row.batch_real == 0 && row._Cod__Estado!=70)
                    {
                        if (ExisteConfPesajeManual==false)
                        {

                        xfrmAsistentePesaje frm = new xfrmAsistentePesaje(row.id);

                        frm.Show();
                        }
                    }
                    else
                    if (row._Cod__Estado == 80)
                    {
                        CajaDialogo.Error("Orden ya esta finalizada");
                        return;
                    }

                }


                CambiarEstado(1, row);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSuspender_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                var gv = (GridView)gcMicros.FocusedView;
                var row = (dsMicros.MicrosRow)gv.GetDataRow(gv.FocusedRowHandle);

                if (row != null)
                {
                    if (row._Cod__Estado == 80)
                    {
                        CajaDialogo.Error("Orden ya esta finalizada");
                        return;
                    }

                }



                CambiarEstado(2, row);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnFinalizar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gv = (GridView)gcMicros.FocusedView;
                var row = (dsMicros.MicrosRow)gv.GetDataRow(gv.FocusedRowHandle);

                if (row != null)
                {
                    if (row._Cod__Estado == 80)
                    {
                        CajaDialogo.Error("Orden ya esta finalizada");
                        return;
                    }

                }


                CambiarEstado(3, row);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSpin_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                var gv = (GridView)gcMicros.FocusedView;
                var row = (dsMicros.MicrosRow)gv.GetDataRow(gv.FocusedRowHandle);

                if (row._Cod__Estado != 70)
                {
                    CajaDialogo.Error("Debe Activar la orden para planificar Batch(es)!");
                    return;
                }



                xfrmSpinBatchPlan frm = new xfrmSpinBatchPlan(row.id, row.Codigo_Orden);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    int batchDisponibles = 0;

                    batchDisponibles = row._Cant__Batch - row.batch_real;


                    if (frm.cantBatch <= batchDisponibles)
                    {
                        DataOperations dp = new DataOperations();

                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                        {
                            cnx.Open();
                            SqlCommand cmd = new SqlCommand("sp_acumulador_batch_real", cnx);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = row.id;
                            cmd.Parameters.AddWithValue("@batch_acumulado", SqlDbType.Int).Value = frm.cantBatch;

                            cmd.ExecuteNonQuery();
                            cnx.Close();

                            LoadData();
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("DEDE DE PESAR UNA CANTIDAD MENOR O IGUAL A LA CANTIDAD DE BATCH DISPONIBLE");
                    }


                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gvMicros_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var gridView = (GridView)gcMicros.FocusedView;
                var row = (dsMicros.MicrosRow)gridView.GetDataRow(e.RowHandle);

                if (row._Cod__Estado == 70)
                {
                    e.Appearance.BackColor = Color.FromArgb(200, 102, 255, 102);
                }
                else
                {
                    e.Appearance.BackColor = Color.FromArgb(200, 255, 255, 255);
                }
            }
        }

        private void gcMicros_Click(object sender, EventArgs e)
        {

        }
    }
}