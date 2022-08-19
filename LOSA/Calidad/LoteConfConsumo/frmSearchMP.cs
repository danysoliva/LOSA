using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace LOSA.Calidad.LoteConfConsumo
{
    public partial class frmSearchMP : DevExpress.XtraEditors.XtraForm
    {
        //public MateriaPrima MateriaPrimaSelected;
        public ItemBusqueda ItemSeleccionado;
        DataView dv;// = new DataView(dsConfigLoteConsumo1.search_mp);
        public enum TipoBusqueda
        {
            MateriaPrima = 1,
            ProductoTerminado = 2,
            Empleados = 3,
            BodegasALOSY = 4
        }

        TipoBusqueda TipoBusquedaActual;
        string StoreProcedureConfigActual;
        public frmSearchMP(TipoBusqueda pTipo)
        {
            InitializeComponent();
            TipoBusquedaActual = pTipo;
            //switch (TipoBusquedaActual)
            //{
            //    case TipoBusqueda.MateriaPrima:
            //        StoreProcedureConfigActual = "sp_get_lista_materias_primas";
            //        break;
            //    case TipoBusqueda.ProductoTerminado:
            //        StoreProcedureConfigActual = "";
            //        break;
            //    case TipoBusqueda.Empleados:
            //        StoreProcedureConfigActual = "";
            //        break;
            //    default:
            //        break;
            //}
            StoreProcedureConfigActual = "sp_get_lista_materias_primas";

            //MateriaPrimaSelected = new MateriaPrima();
            ItemSeleccionado = new ItemBusqueda();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_lista_materias_primas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@parametro_busqueda", Convert.ToInt32(TipoBusquedaActual));


                dsConfigLoteConsumo1.search_mp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsConfigLoteConsumo1.search_mp);

                dv = new DataView(dsConfigLoteConsumo1.search_mp);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Seleccionado")
            {
                var gridView = (GridView)gridControlDetalleMP.FocusedView;
                var row = (dsConfigLoteConsumo.search_mpRow)gridView.GetFocusedDataRow();
                if (Convert.ToBoolean(e.Value))
                {
                    ItemSeleccionado.id = row.id;
                    ItemSeleccionado.ItemCode = row.ItemCode;
                    ItemSeleccionado.ItemName = row.Name_;
                    row.Seleccionado = true;
                }

                foreach (dsConfigLoteConsumo.search_mpRow row1 in dsConfigLoteConsumo1.search_mp)
                {
                    if (row1.id != ItemSeleccionado.id)
                        row1.Seleccionado = false;
                }
            }
        }

        private void frmSearchMP_Activated(object sender, EventArgs e)
        {
            txtParametroBusqueda.Focus();
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtParametroBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(dv.Count == 1)
                {
                    var gridView = (GridView)gridControlDetalleMP.FocusedView;
                    var row = (dsConfigLoteConsumo.search_mpRow)gridView.GetDataRow(0);

                    ItemSeleccionado.id = row.id;
                    ItemSeleccionado.ItemCode = row.ItemCode;
                    ItemSeleccionado.ItemName = row.Name_;
                    row.Seleccionado = true;
                    cmdAplicar_Click(new object(), new EventArgs());
                }
            }
        }

        private void txtParametroBusqueda_EditValueChanged(object sender, EventArgs e)
        {
            dv.RowFilter = @"[concat_] like '%" + txtParametroBusqueda.Text + "%'";
            gridControlDetalleMP.DataSource = dv;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControlDetalleMP.FocusedView;
            var row = (dsConfigLoteConsumo.search_mpRow)gridView.GetFocusedDataRow();

            ItemSeleccionado.id = row.id;
            ItemSeleccionado.ItemCode = row.ItemCode;
            ItemSeleccionado.ItemName = row.Name_;
            row.Seleccionado = true;
            cmdAplicar_Click(new object(), new EventArgs());

            foreach (dsConfigLoteConsumo.search_mpRow row1 in dsConfigLoteConsumo1.search_mp)
            {
                if (row1.id != ItemSeleccionado.id)
                    row1.Seleccionado = false;
            }
        }





    }
}