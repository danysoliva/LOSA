using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
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

namespace LOSA.Produccion
{
    public partial class frmTolva : Form
    {
        public int idTolva;
        public string shortNameTolva;
        public frmTolva()
        {
            InitializeComponent();
            cargarDatos();
        }

        void cargarDatos()
        {
            try
            {
                
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tolva", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dsProduccion.Tolva.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProduccion.Tolva);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void GvTolva_DoubleClick(object sender, EventArgs e)
        {
      
            var gridView = (GridView)gcTolva.FocusedView;
            var row = (dsProduccion.TolvaRow)gridView.GetFocusedDataRow();

            this.idTolva = row.id;
            this.shortNameTolva = row.code;
           this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BtnSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gcTolva.FocusedView;
            var row = (dsProduccion.TolvaRow)gridView.GetFocusedDataRow();

            this.idTolva = row.id;
            this.shortNameTolva = row.code;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
