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
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.RRHH.Liquidaciones
{
    public partial class frmConfDeducciones : DevExpress.XtraEditors.XtraForm
    {
        public int ID_empleado;

        public frmConfDeducciones(int pId_empleado)
        {
            InitializeComponent();
            ID_empleado = pId_empleado;
            LoadData();
        }

        private void LoadData()
        {
            string query = @"[sp_load_RRHH_list_deducciones]";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@enable", tsAtributo.IsOn);
                SqlDataAdapter dat = new SqlDataAdapter(cmd);
                dsRRHH_.lista_deducciones.Clear();
                dat.Fill(dsRRHH_.lista_deducciones);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            frmConfDeduccionesOP op = new frmConfDeduccionesOP();
            if (op.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                
            }
        }

        private void repositoryEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview1 = (GridView)gridControl1.FocusedView;
            var row = (dsRRHH_.lista_deduccionesRow)gridview1.GetFocusedDataRow();

            frmConfDeduccionesOP frm = new frmConfDeduccionesOP(row.id, row.descripcion);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tsAtributo_Toggled(object sender, EventArgs e)
        {
            if (tsAtributo.IsOn)
            {
                LoadData();
            }
            else
            {
                LoadData();
            }
        }
    }
}