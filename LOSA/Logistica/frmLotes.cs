using ACS.Classes;
using Core.Clases.Herramientas;
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

namespace LOSA.Logistica
{
    public partial class frmLotes : Form
    {
        DataOperations dp = new DataOperations();
        public frmLotes()
        {
            InitializeComponent();
            //cargarDatosTarimas();
        }

        private void cargarDatosTarimas()
        {
            try
            {

                //SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                //string SQL = @"exec [sp_get_lotes_by_num]";

                //dsLogistica.LotesXProveedor.Clear();
                //SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);

                //adat.Fill(dsLogistica.LotesXProveedor);

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_lotes_by_num", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_lote", txtLote.Text);
                dsLogistica.LotesXProveedor.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogistica.LotesXProveedor);

                con.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLotes_Load(object sender, EventArgs e)
        {
            gvLotes.Columns[1].GroupIndex = 1;
        }

        private void teLote_EditValueChanged(object sender, EventArgs e)
        {
            //gvLotes.ActiveFilterString = "[lote_materia_prima] LIKE '%" + txtLote.Text + "%'";
            cargarDatosTarimas();
        }

        private void teLote_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void teLote_Leave(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
        }

        private void frmLotes_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
        }

        private void gcLotes_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
        }
    }
}
