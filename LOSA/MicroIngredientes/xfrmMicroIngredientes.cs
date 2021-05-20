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
                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_ordenes_pesaje_manual_interface_V2", cnx);
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

                if (row != null)
                {
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

            xfrmSpinBatchPlan frm = new xfrmSpinBatchPlan();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                int batchDisponibles = 0;

                batchDisponibles = row._Cant__Batch - row.batch_real;


                if (frm.cantBatch<=batchDisponibles)
                {
                    DataOperations dp = new DataOperations();

                    using (SqlConnection cnx= new SqlConnection(dp.ConnectionStringAPMS))
                    {
                        cnx.Open();
                            SqlCommand cmd = new SqlCommand("sp_acumulador_batch_real", cnx);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@id",SqlDbType.Int).Value=row.id;
                            cmd.Parameters.AddWithValue("@batch_acumulado",SqlDbType.Int).Value=frm.cantBatch;

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
    }
}