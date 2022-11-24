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
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.MigracionACS.DataSetx;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;

namespace LOSA.MigracionACS.Produccion.Eficiencia
{
    public partial class PRB_Lote_Pick_v3 : DevExpress.XtraEditors.XtraForm
    {

        public DateTime desde;
        public DateTime hasta;
        public int lote;
        public string Descripcion;
        public string Code;
        int IdRegh;
        int IdLinea;
        public decimal horas;
        decimal HorasSelected;
        decimal vHorasAsignadas;
        bool PermitirGuardar = false;
        public int IdPresentacion;

        public enum TipoVentana
        {
            PRB_Registro = 1,
            PRB_Brom = 2
        }

        TipoVentana TipoVentanaActual;

        public PRB_Lote_Pick_v3(DateTime Pardesde, DateTime Parhasta, int pIdRegH, int pIdLinea)
        {
            InitializeComponent();
            TipoVentanaActual = TipoVentana.PRB_Registro;
            PermitirGuardar = false;
            LoadPresentacionSacos();
            //vHorasAsignadas = phoras_asignadas;
            APMS_OrderProduction fn = new APMS_OrderProduction();
            HorasSelected = fn.GetHorasMaquinaFromId(pIdLinea, pIdRegH);
            //textEdit1.Text = Math.Round((HorasSelected - phoras_asignadas),2).ToString();
            //txtTotalHorasMotor.Text = HorasSelected.ToString();
            desde = Pardesde;
            hasta = Parhasta;
            IdRegh = pIdRegH;
            IdLinea = pIdLinea;
            load_data();
        }
        public PRB_Lote_Pick_v3(DateTime Pardesde, DateTime Parhasta, int pIdRegH)
        {
            InitializeComponent();
            TipoVentanaActual = TipoVentana.PRB_Brom;
            desde = Pardesde;
            hasta = Parhasta;
            IdRegh = pIdRegH;
            //IdLinea = pIdLinea;
            load_data_brom();
        }

        public void load_data_brom()
        {
            try
            {
                string data = "sp_get_lotes_for_bromatologia_prd";
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
                cn.Open();
                SqlCommand cmd = new SqlCommand(data, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@fechai", DateTime.Now.AddDays(-7));
                cmd.Parameters.AddWithValue("@fechai", desde);
                //cmd.Parameters.AddWithValue("@fechaf", DateTime.Now.AddDays(3));
                cmd.Parameters.AddWithValue("@fechaf", hasta);
                cmd.Parameters.AddWithValue("@idregh", IdRegh);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRB_DATA2.loadlot.Clear();
                da.Fill(pRB_DATA2.loadlot);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void load_data()
        {
            try
            {
                //string data = @"Select DISTINCT D.fp_lot_number,
                //                        C.code as Codigo
                //                      , C.long_name as Descripcion
                //                      , B.order_number
                //                From [dbo].[OP_Production_Orders_Main_Mix] D
                //                left JOIN [dbo].[OP_Production_Orders_Main] B
                //                  ON D.[order_id] = B.[id]
                //                left JOIN [dbo].[MD_Finished_Products] C
                //                  ON B.[fp_id] = C.[id]
                //          where d.start_date between @desde"  +
                //                    @" and " + @"@hasta "
                //                + @" and D.fp_lot_number not in (SELECT [lote]
                //                                                  FROM [AQFSVR003].ACS.[dbo].[PRB_Registro_H_Lotes]
                //                                                  where enable = 1
                //                                                        and id_reg_h_prb = " + IdRegh +
                //                                                        " and id_linea = " + IdLinea + ")";
                string data = @"Select DISTINCT D.fp_lot_number,
                                        C.code as Codigo
                                      , C.long_name as Descripcion
                                      , B.order_number
                                From [dbo].[OP_Production_Orders_Main_Mix] D
                                left JOIN [dbo].[OP_Production_Orders_Main] B
		                                ON D.[order_id] = B.[id]
                                left JOIN [dbo].[MD_Finished_Products] C
		                                ON B.[fp_id] = C.[id]
		                        where d.start_date between @desde" +
                            @" and " + @"@hasta ";
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
                cn.Open();
                SqlCommand cmd = new SqlCommand(data, cn);
                cmd.Parameters.AddWithValue("@desde", desde.AddDays(-7));
                cmd.Parameters.AddWithValue("@hasta", hasta.AddDays(3));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRB_DATA2.loadlot.Clear();
                da.Fill(pRB_DATA2.loadlot);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var GridView = (GridView)gridControl1.FocusedView;
                var row = (PRB_DATA.loadlotRow)GridView.GetFocusedDataRow();
                lote = row.fp_lot_number;
                Descripcion = row.Descripcion;
                Code = row.Codigo;
                if (lote > 0 && PermitirGuardar)
                {
                    errorProvider1.Clear();
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    errorProvider1.SetError(cmdGuardar, "Es necesario que seleccione un lote Valido!");
                }
            }
            catch (Exception)
            {

            }
        }
        public int devolver()
        {
            return lote;
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            var GridView = (GridView)gridControl1.FocusedView;
            var row = (PRB_DATA.loadlotRow)GridView.GetFocusedDataRow();
            lote = row.fp_lot_number;
        }

        private void btnselec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var GridView = (GridView)gridControl1.FocusedView;
                var row = (PRB_DATA.loadlotRow)GridView.GetFocusedDataRow();
                lote = row.fp_lot_number;
            }
            catch (Exception)
            {
            }
        }

        private void btnactualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (TipoVentanaActual)
            {
                case TipoVentana.PRB_Brom:
                    load_data_brom();
                    break;
                case TipoVentana.PRB_Registro:
                    load_data();
                    break;
            }
            
        }

        private void btncerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cmdCancelar_EditValueChanged(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmdGuardar_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dtFechai_EditValueChanged(object sender, EventArgs e)
        {
            //recalcular la diferencia
            //desde = Convert.ToDateTime(dtFechai.EditValue);
            //hasta = Convert.ToDateTime(dtFechaf.EditValue);
            //if(hasta > desde)
            //{
            //    Funciones fn = new Funciones();
            //    horas = fn.GetDifHorasforDecimal(desde, hasta);
            //    txtHorasSeleccionadas.Text = Math.Round(horas,2).ToString();
            //    if ((HorasSelected - vHorasAsignadas) < horas)
            //    {
            //        errorProvider1.SetError(txtHorasSeleccionadas, "No puede asignar mas horas de las trabajadas! Debe reducir las horas a ingresar...");
            //        PermitirGuardar = false;
            //    }
            //    else
            //    {
            //        errorProvider1.Clear();
            //        PermitirGuardar = true;
            //    }
            //}
        }

        private void dtFechaf_EditValueChanged(object sender, EventArgs e)
        {
            ////Recalcular la diferencia
            //desde = Convert.ToDateTime(dtFechai.EditValue);
            //hasta = Convert.ToDateTime(dtFechaf.EditValue);
            //if (hasta > desde)
            //{
            //    Funciones fn = new Funciones();
            //    horas = fn.GetDifHorasforDecimal(desde, hasta);
            //    txtHorasSeleccionadas.Text = Math.Round(horas,2).ToString();
            //    if ((HorasSelected - vHorasAsignadas) < horas)
            //    {
            //        errorProvider1.SetError(txtHorasSeleccionadas, "No puede asignar mas horas de las trabajadas! Debe reducir las horas a ingresar...");
            //        PermitirGuardar = false;
            //    }
            //    else
            //    {
            //        errorProvider1.Clear();
            //        PermitirGuardar = true;
            //    }
            //}
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (lote > 0 && IdPresentacion > 0)
            {
                errorProvider1.Clear();
                
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                errorProvider1.SetError(cmdGuardar, "Necesita completar los datos de hora de inicio y fin correctamente, así como el lote y la presentación!");
            }
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                var GridView = (GridView)gridControl1.FocusedView;
                var row = (PRB_DATA.loadlotRow)GridView.GetFocusedDataRow();
                lote = row.fp_lot_number;
                Descripcion = row.Descripcion;
                Code = row.Codigo;
                if (lote > 0 && PermitirGuardar && IdPresentacion > 0)
                {
                    errorProvider1.Clear();
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    errorProvider1.SetError(cmdGuardar, "Necesita completar los datos de hora de inicio y fin correctamente, así como el lote y la presentación!");
                }
            }
            catch (Exception)
            {

            }
        }

        private void LoadPresentacionSacos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                string query = @"sp_get_persentacions_from_prb_reporte";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsEficiencia1.presentacion_sacos.Clear();
                da.Fill(dsEficiencia1.presentacion_sacos);
            }
            catch (Exception ec)
            {

                CajaDialogo.Error(ec.Message);

            }
        }

        private void gridView1_RowClick_1(object sender, RowClickEventArgs e)
        {
            var GridView = (GridView)gridControl1.FocusedView;
            var row = (PRB_DATA.loadlotRow)GridView.GetFocusedDataRow();
            lote = row.fp_lot_number;
            Descripcion = row.Descripcion;
            Code = row.Codigo;
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            IdPresentacion = Convert.ToInt32(gridLookUpEdit1.EditValue);
        }
    }
}