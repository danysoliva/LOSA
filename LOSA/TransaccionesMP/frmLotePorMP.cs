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
        private int Id_MP;
        public int Id_TipoIngreso;
        public int Num_ingreso;
        public decimal Factor;
        public frmLotePorMP(int pid_mp)
        {
            InitializeComponent();
            Id_MP = pid_mp;
            cargarlotespormp();
        }

        private void cargarlotespormp()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                SqlCommand cmd = new SqlCommand("sp_get_lotes_for_mp", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", Id_MP);
                dsRecepcionMPx1.lista_lotes_mp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
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
            this.Num_ingreso = row.numero_ingreso;
            this.Factor = row.factor;

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
            this.Num_ingreso = row.numero_ingreso;
            this.Factor = row.factor;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}