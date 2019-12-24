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
    public partial class frmTrazabilidadLote : Form
    {
        DataOperations dp = new DataOperations();
        string NumeroLote;
        DateTime fechaCreacion;
        public frmTrazabilidadLote()
        {
            InitializeComponent();
            //NumeroLote = pNumeroLote;
            cargarEventosLote();
            
        }

        private void cargarEventosLote()
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL = @"exec sp_trazabilidad_lotes @numero_lote";

                dsLogistica2.EventosLote.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);

                adat.SelectCommand.Parameters.AddWithValue("@numero_lote", teLote.Text);

                adat.Fill(dsLogistica2.EventosLote);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void teLote_EditValueChanged(object sender, EventArgs e)
        {
            cargarEventosLote();
        }

        private void frmTrazabilidadLote_Load(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
        }

        private void teLote_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }
    }
}
