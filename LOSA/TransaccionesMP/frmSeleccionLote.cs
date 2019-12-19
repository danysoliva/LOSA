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
    public partial class frmSeleccionLote : Form
    {
        UserLogin UsuarioLogeado;
        int IdRequisicionDetalle;
        MateriaPrima MP;
        decimal CantidadPendiente;
        int id_unidad;

        public frmSeleccionLote(UserLogin pUsuarioLogeado, int pIdRequisicionDetalle, int IdRM, decimal pCantidad, int pIdUnidad, string pUnidadName)
        {
            InitializeComponent();
            MP = new MateriaPrima();
            UsuarioLogeado = pUsuarioLogeado;
            IdRequisicionDetalle = pIdRequisicionDetalle;
            CantidadPendiente = pCantidad;
            txtCantidadPendiente.Text = string.Format("{0:###,##0.00}", CantidadPendiente);
            id_unidad = pIdUnidad;
            lblUnidad.Text = pUnidadName;

            if (MP.RecuperarRegistroFromID_RM(IdRM))
            {
                txtCodigoMP.Text = MP.Codigo;
                txtMP_Name.Text = MP.Name;
            }

            LoadDetalleLotes();
        }

        private void LoadDetalleLotes()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_lotes_mp_req", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idmp", MP.IdMP_ACS);
                cmd.Parameters.AddWithValue("@id_detalle_req", IdRequisicionDetalle);
                
                dsTransaccionesMP1.detalle_lote_mp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTransaccionesMP1.detalle_lote_mp);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chkAutoSelect_CheckedChanged(object sender, EventArgs e)
        {
            decimal total_solicitado = CantidadPendiente;
            decimal cantidaPendiente = CantidadPendiente;
            if (chkAutoSelect.Checked)
            {
                //var gridView = (GridView)grRequisicoinesMP.FocusedView;
                //var row = (dsTransaccionesMP.detalle_lote_mpRow)gridView.GetFocusedDataRow();

                foreach (dsTransaccionesMP.detalle_lote_mpRow row in dsTransaccionesMP1.detalle_lote_mp.Rows)
                {
                    if (row.peso_total == cantidaPendiente)
                    {
                        row.seleccionado = true;
                        cantidaPendiente = 0;
                        row.cants = row.peso_total;
                        break;
                    }
                    if(row.peso_total > cantidaPendiente && cantidaPendiente > 0)
                    {
                        if(row.peso_total > cantidaPendiente)
                            row.cants = cantidaPendiente;
                        else
                            row.cants = total_solicitado - cantidaPendiente;

                        //row.cants = row.peso_total - cantidaPendiente;
                        cantidaPendiente -= row.cants;
                        row.seleccionado = true;
                        break;
                    }
                }
            }
            else
            {
                foreach (dsTransaccionesMP.detalle_lote_mpRow row in dsTransaccionesMP1.detalle_lote_mp.Rows)
                {
                    row.seleccionado = false;
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            int Seleccionados = 0;
            foreach (dsTransaccionesMP.detalle_lote_mpRow row in dsTransaccionesMP1.detalle_lote_mp.Rows)
            {
                if (row.seleccionado)
                {
                    Seleccionados++;
                    break;
                }
            }

            if(Seleccionados <= 0)
            {
                CajaDialogo.Error("Debe seleccionar al menos un lote");
                return;
            }

            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                foreach (dsTransaccionesMP.detalle_lote_mpRow row in dsTransaccionesMP1.detalle_lote_mp.Rows)
                {
                    if (row.seleccionado)
                    {
                        SqlCommand cmd = new SqlCommand("sp_get_insert_lotes_req_mp", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@lote_mp", row.lote_mp);
                        cmd.Parameters.AddWithValue("@id_detalle_req", IdRequisicionDetalle);
                        cmd.Parameters.AddWithValue("@cantidad", row.cants);
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                        cmd.ExecuteNonQuery();
                    }
                }
                con.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }



        }
    }
}
