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
using ACS.Classes;
using LOSA.Clases;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.FromAMS
{
    public partial class frmVerDetalleSolicitud : DevExpress.XtraEditors.XtraForm
    {
        int IdRequisa = 0;
        public frmVerDetalleSolicitud(long pIdSolicitud)
        {
            InitializeComponent();
            Aprobaciones apro = new Aprobaciones();
            apro.RecuperarRegistro(pIdSolicitud);
            IdRequisa = apro.IdRequisa;
            load_data();
            load_detalle_requisa();

        }


        private void load_data()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAMS);
                conn.Open();

                string sql = "sp_get_detalle_entrega_requisa_me";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_requisa", IdRequisa);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsAprobacionDocumentos1.detalle_entregado_requisa.Clear();
                da.Fill(dsAprobacionDocumentos1.detalle_entregado_requisa);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void load_detalle_requisa()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringAMS);
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_get_detalle_requisa_me_for_id_requisa", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_requisa", IdRequisa);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsAprobacionDocumentos1.req_detalle.Clear();
                adat.Fill(dsAprobacionDocumentos1.req_detalle);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}