using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.IT
{
    public partial class frmConfAccesos : DevExpress.XtraEditors.XtraForm
    {
        public frmConfAccesos()
        {
            InitializeComponent();
            LoadAccesos();
        }

        private void LoadAccesos()
        {
            try
            {
                string sql = @"SELECT [id]
                                      ,[nombre]
                                  FROM [dbo].[IT_Acceso]
                                  where [enable] = 1 ";
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsSolicitudes.accesos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsSolicitudes.accesos);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevoAcceso frmNuevo = new frmNuevoAcceso();
            if (frmNuevo.ShowDialog() == DialogResult.OK)
            {
                LoadAccesos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void repositoryEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Cambiar estado de acceso a enable 0
            DialogResult r = CajaDialogo.Pregunta("¿Esta seguro de eliminar este registro?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;
            var gridView1 = (GridView)gridControl1.FocusedView;
            DataRow row = (DataRow)gridView1.GetFocusedDataRow();
            try
            {
                int id = Convert.ToInt32(row["id"]);
                string sql = @"UPDATE [dbo].[IT_Acceso]
                                           SET [enable] = 0
                                         WHERE [id] = " + id.ToString();
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadAccesos();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void repositoryEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Editar el nombre del acceso
            var gridView1 = (GridView)gridControl1.FocusedView;
            var row = (dsSolicitudes.accesosRow)gridView1.GetFocusedDataRow();
            frmEditarAcceso frmEditar = new frmEditarAcceso(row.id, row.nombre);
            if (frmEditar.ShowDialog() == DialogResult.OK)
            {
                LoadAccesos();
            }
        }
    }
}