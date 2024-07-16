using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Presupuesto;
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

namespace LOSA.MigracionACS.RRHH.RelojFace
{
    public partial class frmMarcasReloj : DevExpress.XtraEditors.XtraForm
    {
        string Codigo;
        public DateTime FechaHoraSelected;
        public int IdMarca;
        public frmMarcasReloj(string pCodigo)
        {
            InitializeComponent();
            Codigo = pCodigo;
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_marcas_generales_empleado_marca_manual", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", Codigo);
                dsFaceReloj1.marcas_reloj.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsFaceReloj1.marcas_reloj);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsFaceReloj.marcas_relojRow)gridView.GetFocusedDataRow();

            if (!row.IsauthDateTimeNull())
            {
                FechaHoraSelected = row.authDateTime;
                IdMarca = row.id;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.DialogResult =DialogResult.Cancel;
            this.Close();
        }
    }
}