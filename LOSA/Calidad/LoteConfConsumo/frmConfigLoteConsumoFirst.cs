using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
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

namespace LOSA.Calidad.LoteConfConsumo
{
    public partial class frmConfigLoteConsumoFirst : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmConfigLoteConsumoFirst(UserLogin puser)
        {
            InitializeComponent();
            UsuarioLogeado = puser;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmSearchMP frm = new frmSearchMP(frmSearchMP.TipoBusqueda.MateriaPrima);
            if(frm.ShowDialog()== DialogResult.OK)
            {
                LoadLotesMP(frm.MateriaPrimaSelected.IdMP_ACS);
                textEdit1.Text = frm.MateriaPrimaSelected.CodeMP_SAP + " " + frm.MateriaPrimaSelected.NameComercial;
            }
        }

        private void LoadLotesMP(int pidRM)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_lotes_configurados_por_mp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idmp", pidRM);
                dsConfigLoteConsumo1.config_lote.Clear();
                //dsPresupuesto1.estados.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsConfigLoteConsumo1.config_lote);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }
    }
}