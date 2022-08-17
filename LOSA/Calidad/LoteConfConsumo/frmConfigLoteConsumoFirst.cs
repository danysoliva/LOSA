using ACS.Classes;
using DevExpress.XtraEditors;
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
        public frmConfigLoteConsumoFirst()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmSearchMP frm = new frmSearchMP();
            if(frm.ShowDialog()== DialogResult.OK)
            {
                LoadLotesMP(frm.MateriaPrimaSelected.IdMP_ACS);
            }
        }

        private void LoadLotesMP(int pidRM)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idmp", pidRM);
                //dsPresupuesto1.estados.Clear();
                //SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //adat.Fill(dsPresupuesto1.estados);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


    }
}