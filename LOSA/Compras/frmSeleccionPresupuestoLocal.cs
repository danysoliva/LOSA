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
using LOSA.Clases;
using LOSA.Compras;
using LOSA.Presupuesto;
using System.Data.SqlClient;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Compras
{
    public partial class frmSeleccionPresupuestoLocal : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        DataView dv;
        public ItemBusqueda ItemSeleccionado;

        public frmSeleccionPresupuestoLocal()
        {
            InitializeComponent();
            ObtenerPresupuestoActivos();
            ItemSeleccionado = new ItemBusqueda();

           

       
        }

        private void ObtenerDetallePresupuestos()
        {
            try
            {
                string query = @"sp_presupuesto_get_lineas_detalle";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_presupuesto", grdPresipuesto.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPresupuesto1.SelectPresupuesto.Clear();
                adat.Fill(dsPresupuesto1.SelectPresupuesto);
                dv = new DataView(dsPresupuesto1.SelectPresupuesto);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ObtenerPresupuestoActivos()
        {
            try
            {
                string query = @"sp_presupuesto_get_presupuesto_en_proceso";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPresupuesto1.PresupuestoActivo.Clear();
                adat.Fill(dsPresupuesto1.PresupuestoActivo);
                conn.Close();

               
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtParametroBusqueda_EditValueChanged(object sender, EventArgs e)
        {
            dv.RowFilter = @"concat_ like '%" + txtParametroBusqueda.Text + "%'";
            gridControlDetallePres.DataSource = dv;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControlDetallePres.FocusedView;
            var row = (dsPresupuesto.SelectPresupuestoRow)gridView.GetFocusedDataRow();

            ItemSeleccionado.id = row.id;
            ItemSeleccionado.ItemName = row.descripcion;
            row.Seleccionado = true;
            cmdAplicar_Click(new object(), new EventArgs());

            foreach (dsPresupuesto.SelectPresupuestoRow row1 in dsPresupuesto1.SelectPresupuesto)
            {
                if (row1.id != ItemSeleccionado.id)
                    row1.Seleccionado = false;
            }
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtParametroBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dv.Count == 1)
                {
                    var gridView = (GridView)gridControlDetallePres.FocusedView;
                    var row = (dsPresupuesto.SelectPresupuestoRow)gridView.GetDataRow(0);

                    ItemSeleccionado.id = row.id;
                    ItemSeleccionado.ItemName = row.descripcion;
                    row.Seleccionado = true;
                    cmdAplicar_Click(new object(), new EventArgs());
                }
            }
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Seleccionado")
            {
                var gridView = (GridView)gridControlDetallePres.FocusedView;
                var row = (dsPresupuesto.SelectPresupuestoRow)gridView.GetFocusedDataRow();
                if (Convert.ToBoolean(e.Value))
                {
                    ItemSeleccionado.id = row.id;
                    ItemSeleccionado.ItemName = row.descripcion;
                    row.Seleccionado = true;
                }

                foreach (dsPresupuesto.SelectPresupuestoRow row1 in dsPresupuesto1.SelectPresupuesto)
                {
                    if (row1.id != ItemSeleccionado.id)
                        row1.Seleccionado = false;
                }
            }
        }

        private void grdPresipuesto_EditValueChanged(object sender, EventArgs e)
        {
            ObtenerDetallePresupuestos();
            txtParametroBusqueda.Focus();
        }

        private void frmSeleccionPresupuestoLocal_Load(object sender, EventArgs e)
        {
            int contador = 0;
            foreach (dsPresupuesto.PresupuestoActivoRow item in dsPresupuesto1.PresupuestoActivo)
            {
                contador = contador + 1;
                grdPresipuesto.EditValue = item.id;
                grdPresipuesto.Enabled = false;
                if (contador >= 2)
                {
                    grdPresipuesto.EditValue = 0;
                    grdPresipuesto.Enabled = true;
                }
            }
        }
    }
}