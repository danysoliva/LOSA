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
using LOSA.TransaccionesPT;
using System.Data.SqlClient;

namespace LOSA.TransaccionesPT
{
    public partial class frmAjusteIKardexPT : DevExpress.XtraEditors.XtraForm
    {
        string code_sap;
        int Id_PT;
        public frmAjusteIKardexPT()
        {
            InitializeComponent();
            LoadPresentaciones();
        }

        private void txtPT_Name_Click(object sender, EventArgs e)
        {
            frmPT frm = new frmPT();
            frm.MdiParent = this.MdiParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtPT_Name.Text = frm.ProductoT;
                code_sap = frm.CodeSAP;
                Id_PT = frm.id_pt;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_presentaciones_activas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //dsRecepcionMPx.presentaciones.Clear();
                //adat.Fill(dsRecepcionMPx.presentaciones);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void txtNumLote_Click(object sender, EventArgs e)
        {
            frmLotesxPT frm = new frmLotesxPT(Id_PT);
            frm.MdiParent = this.MdiParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtNumLote.Text = Convert.ToString(frm.lot_number);
            }
        }
    }
}