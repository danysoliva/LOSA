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
using LOSA.Logistica;

namespace LOSA.RecuentoInventario
{
    public partial class frmAddLote : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;

        int id_mp;
        int id_bodega;

        public string lote, presentacion;
        public int id_presentacion;
        public DateTime fecha_venc;



        public frmAddLote(int pid_mp, int pid_bodega)
        {
            InitializeComponent();
            id_mp = pid_mp;
            id_bodega = pid_bodega;

            load_lotes();

        }

        private void load_lotes()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_lotes_in_kardex_historic", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", id_mp);
                cmd.Parameters.AddWithValue("@id_bodega", id_bodega);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCierreMes1.lotes_recuento.Clear();
                adat.Fill(dsCierreMes1.lotes_recuento);
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdvLote_DoubleClick(object sender, EventArgs e)
        {
            var gridview1 = (GridView)grdLote.FocusedView;
            var row = (dsCierreMes.lotes_recuentoRow)grdvLote.GetFocusedDataRow();

            lote = row.lote;
            id_presentacion = row.id_unidadmedida;
            id_mp = row.id_mp;
            fecha_venc = row.fecha_vencimiento;
            presentacion = row.presentacion;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}