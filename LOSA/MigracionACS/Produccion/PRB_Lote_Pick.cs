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

namespace LOSA.MigracionACS.Produccion
{
    public partial class PRB_Lote_Pick : DevExpress.XtraEditors.XtraForm
    {

        DateTime desde;
        DateTime hasta;
        public int lote;
        public string Descripcion;
        public string Code;
        int IdRegh;
        int IdLinea;

        public enum TipoVentana
        {
            PRB_Registro = 1,
            PRB_Brom = 2
        }

        TipoVentana TipoVentanaActual;

        public PRB_Lote_Pick(DateTime Pardesde, DateTime Parhasta, int pIdRegH, int pIdLinea)
        {
            InitializeComponent();
            TipoVentanaActual = TipoVentana.PRB_Registro;
            desde = Pardesde;
            hasta = Parhasta;
            IdRegh = pIdRegH;
            IdLinea = pIdLinea;
            load_data();
        }
        public PRB_Lote_Pick(DateTime Pardesde, DateTime Parhasta, int pIdRegH)
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
                string data;
                //data = @"Select DISTINCT D.fp_lot_number,
                //                C.code as Codigo
                //              , C.long_name as Descripcion
                //              , B.order_number
                //        From [dbo].[OP_Batch_Intake_Data_RM] A
                //        left JOIN [dbo].[OP_Production_Orders_Main_Mix] D
                //          ON A.[order_mix_id] = D.[id] 
                //        left JOIN [dbo].[OP_Production_Orders_Main] B
                //          ON A.[order_id] = B.[id]
                //        left JOIN [dbo].[MD_Finished_Products] C
                //          ON B.[fp_id] = C.[id]
                //  where d.start_date between '" + DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd") + 
                //            @"'and '" + DateTime.Now.AddDays(3).ToString("yyyy-MM-dd") + @"'"
                //        + @" and D.fp_lot_number not in (SELECT [lote]
                //                                          FROM [AQFSVR003].ACS.[dbo].[PRB_Registro_H_Lotes]
                //                                          where enable = 1
                //                                                and id_reg_h_prb = " + IdRegh
                //                                                + " and id_linea = " + IdLinea +")"
                //        ;
                data = "sp_get_lotes_for_bromatologia_prd";
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
                cn.Open();
                SqlCommand cmd = new SqlCommand(data, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@fechai", DateTime.Now.AddDays(-7));
                cmd.Parameters.AddWithValue("@fechai", desde.AddDays(-2));
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
                string data;
                //data = @"Select DISTINCT D.fp_lot_number,
                //                C.code as Codigo
                //              , C.long_name as Descripcion
                //        From [dbo].[OP_Batch_Intake_Data_RM] A
                //        left JOIN [dbo].[OP_Production_Orders_Main_Mix] D
                //          ON A.[order_mix_id] = D.[id] 
                //        left JOIN [dbo].[OP_Production_Orders_Main] B
                //          ON A.[order_id] = B.[id]
                //        left JOIN [dbo].[MD_Finished_Products] C
                //          ON B.[fp_id] = C.[id]
                //  where d.start_date between '" + DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd") +
                //            @"'and '" + DateTime.Now.AddDays(3).ToString("yyyy-MM-dd") + @"'"
                //        + @" and D.fp_lot_number not in (SELECT [lote]
                //                                          FROM [AQFSVR003].ACS.[dbo].[PRB_Registro_H_Lotes]
                //                                          where enable = 1
                //                                                and id_reg_h_prb = " + IdRegh +
                //                                                " and id_linea = " + IdLinea + ")";

                data = @"Select DISTINCT D.fp_lot_number,
                                C.code as Codigo
                              , C.long_name as Descripcion
                              , B.order_number
                        From [dbo].[OP_Production_Orders_Main_Mix] D
                        left JOIN [dbo].[OP_Production_Orders_Main] B
		                        ON D.[order_id] = B.[id]
                        left JOIN [dbo].[MD_Finished_Products] C
		                        ON B.[fp_id] = C.[id]
		                where d.start_date between @desde"  +
                            @" and " + @"@hasta "
                        + @" and D.fp_lot_number not in (SELECT [lote]
                                                          FROM [AQFSVR003].ACS.[dbo].[PRB_Registro_H_Lotes]
                                                          where enable = 1
                                                                and id_reg_h_prb = " + IdRegh +
                                                                " and id_linea = " + IdLinea + ")";
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
                this.DialogResult = DialogResult.Yes;
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
    }
}