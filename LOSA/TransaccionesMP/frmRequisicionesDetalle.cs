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
        DataOperations dp;
        public frmRequisicionesDetalle(UserLogin pUsuarioLogeado, int pIdReqH)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            IdRequisicionHeader = pIdReqH;

             dp = new DataOperations();
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
              
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
            if (row.asignado == 0)
            {
                frmSeleccionLote frm = new frmSeleccionLote(UsuarioLogeado,
                                                           row.id,
                                                           row.id_materia_prima,
                                                           row.solicitada,
                                                           row.id_unidad_medida,
                                                           row.unidad);
                frm.WindowState = FormWindowState.Maximized;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadDatos();
                }
            }
            else
            {

                if (row.pendiente == row.asignado)
                {
                    frmSeleccionLote frm = new frmSeleccionLote(UsuarioLogeado,
                                                                row.id,
                                                                row.id_materia_prima,
                                                                row.solicitada,
                                                                row.id_unidad_medida,
                                                                row.unidad);
                    frm.WindowState = FormWindowState.Maximized;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadDatos();
                    }

                }
                else
                {
                    CajaDialogo.Error("Ya se empezo a entregar tarimas de esta requisicion ya no se puede Modificar.");
                    return;
                }
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
                    {
                        e.Appearance.BackColor = Color.FromArgb(113, 220, 200);
                    }
                    else
                    {
                        if (row.asignado > 0)
                        {
                            //
                            e.Appearance.BackColor = Color.FromArgb(255, 255, 192);
                        }
                        else
                        {
                            e.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                        }
                    }
                }
            }
        }

        private void chkAutoSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoSelect.Checked)
            {
                //SeleccionLoteMPAuto
                foreach(dsTransaccionesMP.requisiciones_dRow row in dsTransaccionesMP1.requisiciones_d.Rows)
                {
                    SeleccionLoteMPAuto sele = new SeleccionLoteMPAuto(row.id_materia_prima,
                                                                        row.id,
                                                                        row.solicitada,
                                                                        this.UsuarioLogeado.Id);
                    if(sele.Guardar_SeleccionLoteAuto())
                    {
                        //LoadDatos();
                    }
                }
                
                LoadDatos();
                CajaDialogo.Information("Autoseleccion finalizada con Exito!");
            }
            else
            {

            }
        }

        private void btnconsumir_Click(object sender, EventArgs e)
        {

            try
            {
                var gridView = (GridView)grDetalleLote.FocusedView;
                var row = (dsTransaccionesMP.requisiciones_dRow)gridView.GetFocusedDataRow();
                if (row.asignado != 0)
                {
                    if (row.asignado != row.entregada)
                    {
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                        cn.Open();
                        string query = @"sp_entregar_in_bodega";
                        SqlCommand cmd = new SqlCommand(query,cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_detalle_req", row.id);
                        cmd.Parameters.AddWithValue("@cantidaP", row.pendiente);
                        cmd.ExecuteNonQuery();
                        CajaDialogo.Information("Lotes en produccion consumidos.");
                        LoadDatos();
                    }
                    else
                    {
                        CajaDialogo.Error("Ya se ha entregado toda la materia prima para esta Materia prima.");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("Debe de asignar lotes para verificar si se puede consumir de la bodega de produccion.");
                    return;
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}
