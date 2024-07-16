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
using LOSA.Presupuesto;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;

namespace LOSA.Presupuesto
{
    public partial class frmDetalleOC : DevExpress.XtraEditors.XtraForm
    {
        SqlCommand cmd;
        SqlDataAdapter adat;
        int IDDetalle = 0;
        public bool Data = false;
        DataOperations dp = new DataOperations();
        public frmDetalleOC(int idLinea)
        {
            InitializeComponent();
            cmd = new SqlCommand();
            adat = new SqlDataAdapter();
            IDDetalle = idLinea;
            LoadDataDetalle();


        }

        private void LoadDataDetalle()
        {
            try
            {
                string query = @"sp_presupuesto_get_oc_h";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_detalle", IDDetalle);
                adat = new SqlDataAdapter(cmd);
                dsPresupuesto1.ordenes_autorizadas.Clear();
                adat.Fill(dsPresupuesto1.ordenes_autorizadas);

                foreach (dsPresupuesto.ordenes_autorizadasRow item in dsPresupuesto1.ordenes_autorizadas.Rows)
                {
                    Data = true;
                }

                if (Data)
                {
                    string queryDetalle = @"sp_presupuesto_get_detalle_oc";
                    cmd = new SqlCommand(queryDetalle, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_detalle", IDDetalle);
                    adat = new SqlDataAdapter(cmd);
                    dsPresupuesto1.oc_detalle_exonerada.Clear();
                    adat.Fill(dsPresupuesto1.oc_detalle_exonerada);
                }
                else
                {
                    Data = false;
                }           

                gridView1.ExpandAllGroups();

                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}