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
using ACS.Classes;
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.RecepcionMP
{
    public partial class frm_select_numero_granel : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        private int ingreso;

        public int Ingreso { get => ingreso; set => ingreso = value; }

        public frm_select_numero_granel()
        {
            InitializeComponent();
            load_ingresos();
        }
        
        public void load_ingresos()
        {
            string query = @"sp_load_ingreso_granel_to_pick";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsingresos.ingreso.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsingresos.ingreso);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void grdv_data_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsingresos.ingresoRow)gridView.GetFocusedDataRow();
                Ingreso = row.ingreso;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

              
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsingresos.ingresoRow)gridView.GetFocusedDataRow();
                Ingreso = row.ingreso;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {


            }
        }
    }
}