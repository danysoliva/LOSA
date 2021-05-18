using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.TransaccionesPT
{
    public partial class frm_select_motivo_to_drop : DevExpress.XtraEditors.XtraForm
    {
        private int id_motivo;
        private string motivo;
        DataOperations dp = new DataOperations();

        public int Id_motivo { get => id_motivo; set => id_motivo = value; }
        public string Motivo { get => motivo; set => motivo = value; }

        public frm_select_motivo_to_drop()
        {
            InitializeComponent();
            LOAD_DATA();
        }
          public void LOAD_DATA()
        {
            string Query = @"sp_load_motivo_to_out_pt";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsPT.motivo_out.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPT.motivo_out);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnseleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsPT.motivo_outRow)gridView.GetFocusedDataRow();
                Id_motivo = row.id;
                Motivo = row.descripcion;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {

                
            }
        }

        private void grdv_data_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsPT.motivo_outRow)gridView.GetFocusedDataRow();
                Id_motivo = row.id;
                Motivo = row.descripcion;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {


            }
        }
    }
}