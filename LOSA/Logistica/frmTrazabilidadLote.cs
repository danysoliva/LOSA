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
        public frmTrazabilidadLote()
        {
            InitializeComponent();
            cargarDatosTarimas();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarDatosTarimas()
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL = @"exec sp_get_lotes_by_MP";

                 dsLogistica1.Lotes.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);

                adat.Fill(dsLogistica1.Lotes);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void frmTrazabilidadLote_Load(object sender, EventArgs e)
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

        private void btnEvento_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                frmEventosTarima frm = new frmEventosTarima(Convert.ToInt32(gvLotes.GetFocusedRowCellValue(gvLotes.Columns[0]).ToString()
                                                            ), Convert.ToDateTime(gvLotes.GetFocusedRowCellValue(gvLotes.Columns["fecha_ingreso"]).ToString()));
                frm.Show();
            }
            catch(Exception error)
            {
                CajaDialogo.Error(error.Message);
            }

            }

        private void frmTrazabilidadLote_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
        }
    }
}
