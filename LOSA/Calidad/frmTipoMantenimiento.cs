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
using System;

namespace LOSA.Calidad
{
    public partial class frmTipoMantenimiento : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frmTipoMantenimiento(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            load_data();
        }

        public void load_data()
        {

            string Query = @"sp_load_tipo_origen";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsMantenimientoC.Tipo.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMantenimientoC.Tipo);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdHome_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsMantenimientoC.TipoRow)gridView.GetFocusedDataRow();

                frmNuevoCriterioTipo frm = new frmNuevoCriterioTipo(row.id, row.descripcion);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    load_data();
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            frmNuevoCriterioTipo frm = new frmNuevoCriterioTipo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }
        }
    }
}