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
            cargarDatosTarimas();
        }

        private void cargarDatosTarimas()
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL = @"exec sp_get_lotes_by_MP";

                dsLogistica.LotesXProveedor.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);

                adat.Fill(dsLogistica.LotesXProveedor);

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
            gvLotes.ActiveFilterString = "[lote_materia_prima] LIKE '%" + teLote.Text + "%'";
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

      
    }
}
