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

namespace LOSA.Calidad
{
    public partial class frmInsectosMantenimiento : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frmInsectosMantenimiento(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            load_data();
        }

        public void load_data()
        {

            string Query = @"sp_load_critero_insectos";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsMantenimientoC.insectos.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMantenimientoC.insectos);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsMantenimientoC.insectosRow)gridView.GetFocusedDataRow();

                frmNuevoCriterioInsectos frm = new frmNuevoCriterioInsectos(row.id, row.descripcion);
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

        private void cmdHome_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoCriterioInsectos frm = new frmNuevoCriterioInsectos();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }
        }
    }
}