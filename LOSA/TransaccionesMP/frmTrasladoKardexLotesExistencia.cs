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
using DevExpress.XtraGrid.Views.Grid;
using LOSA.RecepcionMP;
using ACS.Classes;

namespace LOSA.TransaccionesMP
{
    public partial class frmTrasladoKardexLotesExistencia : DevExpress.XtraEditors.XtraForm
    {
        public string Lote;
        public int Id_UnidadMedida;
        private int Id_MP;
        public decimal Factor;

        public frmTrasladoKardexLotesExistencia(int pId_mp)
        {
            InitializeComponent();
            Id_MP = pId_mp;
            cargarlotespormp_kardex();
        }

        private void cargarlotespormp_kardex()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string query = "sp_get_lotes_for_mp_in_kardex";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", Id_MP);
                dsRecepcionMPx1.lotes_kardex.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.lotes_kardex);
                cn.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void reposSeleccion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gcLoteForKardex.FocusedView;
            var row = (dsRecepcionMPx.lotes_kardexRow)gridView.GetFocusedDataRow();

            this.Lote = row.lote;
            this.Id_UnidadMedida = row.id_unidadmedida;
            this.Factor = row.factor;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gvLoteForKardex_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gcLoteForKardex.FocusedView;
            var row = (dsRecepcionMPx.lotes_kardexRow)gridView.GetFocusedDataRow();

            this.Lote = row.lote;
            this.Id_UnidadMedida = row.id_unidadmedida;
            this.Factor = row.factor;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}