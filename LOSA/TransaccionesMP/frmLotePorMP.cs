using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.RecepcionMP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.TransaccionesMP
{
    public partial class frmLotePorMP : DevExpress.XtraEditors.XtraForm
    {
        public int Id_Lote;
        public string Lote;
        public int Id_UnidadMedida;
        public int Id_MP;
        public int Id_TipoIngreso;
        public frmLotePorMP()
        {
            InitializeComponent();
            cargarlotespormp();
        }

        private void cargarlotespormp()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL = @"sp_get_lotes_for_mp";
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsRecepcionMPx1.lista_lotes_mp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);
                adat.Fill(dsRecepcionMPx1.lista_lotes_mp);
                cn.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gcLotePorMP.FocusedView;
            var row = (dsRecepcionMPx.lista_lotes_mpRow)gridView.GetFocusedDataRow();

            this.Id_Lote = row.id_lote;
            this.Lote = row.lote;
            this.Id_UnidadMedida = row.id_unidadmedida;
            //this.Id_MP = ;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gvMP_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gcLotePorMP.FocusedView;
            var row = (dsRecepcionMPx.lista_lotes_mpRow)gridView.GetFocusedDataRow();

            this.Id_Lote = row.id_lote;
            this.Lote = row.lote;
            this.Id_UnidadMedida = row.id_unidadmedida;
            //this.Id_MP = Id_UnidadMedida;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}