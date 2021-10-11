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

namespace LOSA.Nir
{
    public partial class frmLigarLecturas : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frmLigarLecturas(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            load_data();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
          public void load_data()
        {
            string Query = @"sp_load_all_ingreso_lote_nir";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsNir.nir_lote.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsNir.nir_lote);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnLectura_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsNir.nir_loteRow)gridView.GetFocusedDataRow();

                frmUnirLigaduras frm = new frmUnirLigaduras(UsuarioLogeado,row.sap,row.odoo,row.nombre_comercial,row.id,row.lote,row.numero_transaccion);
                if (frm.ShowDialog() == DialogResult.OK)
                {

                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}