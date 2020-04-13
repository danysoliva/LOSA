using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;
using LOSA.Clases;
using System.Data.SqlClient;

namespace LOSA.Despachos
{
    public partial class frmseleccionlote : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        private int CantidadPendiente;
        private int Pid_detalle;
        public frmseleccionlote(int CantidadPendiente, string itemcode, string Dscripcion, int id_detalle)
        {
            InitializeComponent();
            txtunidades.Text = CantidadPendiente.ToString();
            this.CantidadPendiente = CantidadPendiente;
            txtitem.Text = "(" + itemcode + ") - " + Dscripcion;
            Pid_detalle = id_detalle;
            LoadDetalleLotes();



        }
        private void LoadDetalleLotes()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_lotes_pt_req", con);
                cmd.CommandType = CommandType.StoredProcedure;
                ds_despachos.detalle_lote_pt.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(ds_despachos.detalle_lote_pt);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            decimal total_solicitado = CantidadPendiente;
            decimal cantidaPendiente = CantidadPendiente;
            if (chkTodos.Checked)
            {
                //var gridView = (GridView)grRequisicoinesMP.FocusedView;
                //var row = (dsTransaccionesMP.detalle_lote_mpRow)gridView.GetFocusedDataRow();

                foreach (ds_despachos.detalle_lote_ptRow row in ds_despachos.detalle_lote_pt.Rows)
                {
                    if (row.cantidad == cantidaPendiente)
                    {
                        row.seleccionado = true;
                        cantidaPendiente = 0;
                        row.cants = row.cantidad;
                        break;
                    }
                    if (row.cantidad > cantidaPendiente && cantidaPendiente > 0)
                    {
                        if (row.cantidad > cantidaPendiente)
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
                foreach (ds_despachos.detalle_lote_ptRow row in ds_despachos.detalle_lote_pt.Rows)
                {
                    row.seleccionado = false;
                }
            }
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}