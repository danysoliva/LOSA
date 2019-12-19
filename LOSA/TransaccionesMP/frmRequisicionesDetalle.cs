using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
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

namespace LOSA.TransaccionesMP
{
    public partial class frmRequisicionesDetalle : Form
    {
        UserLogin UsuarioLogeado;
        int IdRequisicionHeader;
        public frmRequisicionesDetalle(UserLogin pUsuarioLogeado, int pIdReqH)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            IdRequisicionHeader = pIdReqH;
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_requisicion_detalle", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_req_header", IdRequisicionHeader);
                dsTransaccionesMP1.requisiciones_d.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTransaccionesMP1.requisiciones_d);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnVerD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Boton editar
            var gridView = (GridView)grDetalleLote.FocusedView;
            var row = (dsTransaccionesMP.requisiciones_dRow)gridView.GetFocusedDataRow();
            frmSeleccionLote frm = new frmSeleccionLote(UsuarioLogeado, row.id, row.id_materia_prima, row.solicitada, row.id_unidad_medida, row.unidad);
            frm.WindowState = FormWindowState.Maximized;
            if(frm.ShowDialog()== DialogResult.OK)
            {
                LoadDatos();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gvTarimas_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var gridView = (GridView)grDetalleLote.FocusedView;
                //var row = (dsNotas.notas_resumenRow)gridView.GetFocusedDataRow();
                var row = (dsTransaccionesMP.requisiciones_dRow)gridView.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    if (row.solicitada == row.asignado)
                        e.Appearance.BackColor = Color.FromArgb(113, 220, 200);
                    else
                        e.Appearance.BackColor = Color.FromArgb(255, 255, 255); 
                }
            }
        }
    }
}
