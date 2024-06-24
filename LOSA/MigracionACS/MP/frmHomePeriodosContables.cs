using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.MigracionACS.MP;
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

namespace ACS.MP
{
    public partial class frmHomePeriodosContables : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmHomePeriodosContables(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            LoadPeriodos();
        }

        private void LoadPeriodos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_listado_periodos_contables_crud", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsmp1.periodoscontables.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsmp1.periodoscontables);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult r =  CajaDialogo.Pregunta("¿Realmente desea eliminar este periodo contable?");
            if (r != DialogResult.Yes)
                return;

            //Diable row
            try
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (DSMP.periodoscontablesRow)gridView.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_disable_periodos_contables_crud", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.Parameters.AddWithValue("@enable", 0);
                cmd.ExecuteNonQuery();
                con.Close();
                CajaDialogo.InformationAuto();
                LoadPeriodos();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            frmMantoPeriodosContables frm = new frmMantoPeriodosContables(UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadPeriodos();
            }
        }
    }
}