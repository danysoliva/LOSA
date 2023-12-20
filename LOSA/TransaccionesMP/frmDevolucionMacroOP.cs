using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace LOSA.TransaccionesMP
{
    public partial class frmDevolucionMacroOP : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;   
        public frmDevolucionMacroOP(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
            loadData();
        }

        private void loadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                string query = @"[sp_get_tarimas_en_proceso_bascula_para_edicion]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsTransaccionesMP1.tarimas_bascula.Clear();
                adat.Fill(dsTransaccionesMP1.tarimas_bascula);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void reposEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridDetalle.FocusedView;
            var row = (dsTransaccionesMP.tarimas_basculaRow)gridview.GetFocusedDataRow();

            frmResumenToDevolucion frm = new frmResumenToDevolucion(row.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_alimentacion_basculas_edicion_tolva_llena", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_pesaje", row.id);
                    cmd.Parameters.AddWithValue("@unidades", frm.UnidadesActualizadas);
                    cmd.Parameters.AddWithValue("@kg",frm.KgActualizados);
                    cmd.ExecuteNonQuery();

                    CajaDialogo.Information("Pesaje Actualizado!\nActualizar la Ventana de Alimentacion");
                    loadData();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }


            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}