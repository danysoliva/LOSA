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
using LOSA.Clases;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Calidad
{
    public partial class frmManejoTarimas : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        string lote;
        int id;
        public frmManejoTarimas(string lote, int id_mp)
        {
            InitializeComponent();
            this.lote = lote;
            id = id_mp;
            load_data();
        }
        public void load_data()
        {
            try
            {
                string query = @"sp_get_tarimas_entregadas";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote",lote);
                cmd.Parameters.AddWithValue("@id_mp", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCalidad.tarimas_data.Clear();
                da.Fill(dsCalidad.tarimas_data);
                cn.Close();

            }
            catch (Exception es)
            {

                CajaDialogo.Error(es.Message);
            }

        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_desactivar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsCalidad.tarimas_dataRow)gridView.GetFocusedDataRow();



                string query = @"sp_update_tarima_entregada_como_consumida";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",row.id);
                cmd.ExecuteNonQuery();
                cn.Close();
                load_data();

            }
            catch (Exception es)
            {

                CajaDialogo.Error(es.Message);
            }
        }
    }
}