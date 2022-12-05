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

namespace LOSA.MigracionACS.OIL
{
    public partial class frmDetalle : DevExpress.XtraEditors.XtraForm
    {
        int IdReq;
        DataOperations dp;
        public frmDetalle(int pIdReq)
        {
            InitializeComponent();
            IdReq = pIdReq;
            dp = new DataOperations();
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = @"SELECT tt.cant_s as solicitada,
                                   tt.cant as dosificada,
	                               rr.long_name,
	                               tt.fecha_hora
                               FROM [dbo].[oil_req_d] dd join
                                    [dbo].oil_transfers tt on
	                                dd.id = tt.id_req_d join
	                                [dbo].MD_Raw_Material rr
	                                on rr.id = dd.id_rm
                               where dd.id_requisicion = " + IdReq.ToString();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsAceites1.detalles_req.Clear();
                adat.Fill(dsAceites1.detalles_req);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}