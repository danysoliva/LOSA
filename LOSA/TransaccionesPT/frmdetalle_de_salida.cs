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

namespace LOSA.TransaccionesPT
{
    public partial class frmdetalle_de_salida : DevExpress.XtraEditors.XtraForm
    {

        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public int id_ajuste;
        public frmdetalle_de_salida(int Pid, UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            id_ajuste = Pid;
            load_data();
        }

        public void  load_data() 
        {
            string query = @"sp_obtener_resumen_del_ajuste_de_inventario";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ajuste", id_ajuste);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsPT.show_resumen_ajuste.Clear();
                da.Fill(dsPT.show_resumen_ajuste);
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

        private void grdv_data_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsPT.show_resumen_ajusteRow)gridView.GetDataRow(e.RowHandle);
                if (e.RowHandle >= 0)
                {

                    if (row.tipo_op == 2)
                    {
                        e.Appearance.BackColor = Color.FromArgb(156, 83, 67);

                    }
                    else
                    {
                        e.Appearance.BackColor = Color.FromArgb(77, 201, 176);
                    }
                }
            }
            catch (Exception ex)
            {                

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Mensaje", "Desea crear el ajuste de inventario, despues de esta operacion no se puede revertir.", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string query = @"sp_ejecutar_ajuste_inventario_lineas";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                try
                {
                    cn.Open();
                    SqlCommand cmd;
                    foreach (dsPT.show_resumen_ajusteRow row in dsPT.show_resumen_ajuste.Rows)
                    {
                        cmd = new SqlCommand(query,cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_Ajuste",row.id);
                        cmd.ExecuteNonQuery();
                    }
                    query = @"sp_cambiar_ejecutado_ajuste_inventario";
                   cmd = new SqlCommand(query,cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_h", id_ajuste);
                    cmd.ExecuteNonQuery();
                    CajaDialogo.Information("Ajuste realizado exitosamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdv_data.ExportToXlsx(dialog.FileName);
            }
        }
    }
}