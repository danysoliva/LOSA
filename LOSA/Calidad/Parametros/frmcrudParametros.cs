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

namespace LOSA.Calidad.Parametros
{
    public partial class frmcrudParametros : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmcrudParametros()
        {
            InitializeComponent();
            load_informacion();
        }
        public void load_informacion()
        {
            try
            {
                string query = @"sp_get_parametros_to_crud";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsParametros1.paramteros_crud.Clear();
                da.Fill(dsParametros1.paramteros_crud);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmOpParametros frm = new frmOpParametros(frmOpParametros.Operacion.Nuevo, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_informacion();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsParametros.paramteros_crudRow)gridView.GetFocusedDataRow();
                frmOpParametros frm = new frmOpParametros(frmOpParametros.Operacion.Editar, row.id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    load_informacion();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void reposTSCalidad_Toggled(object sender, EventArgs e)
        {
            

        }

        private void reposTSCalidad_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            var gridview = (GridView)grd_data.FocusedView;
            var row = (dsParametros.paramteros_crudRow)gridview.GetFocusedDataRow();

            int llenado_porCalidad = 1;
            if (Convert.ToBoolean(reposTSCalidad.ValueOn) == true)
                llenado_porCalidad = 1;
            else
                llenado_porCalidad = 0;

            try
            {
                //DataOperations dp = new DataOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                //conn.Open();
                //SqlCommand cmd = new SqlCommand("",conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                //cmd.Parameters.AddWithValue("",);
                //cmd.ExecuteNonQuery();
                //conn.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}