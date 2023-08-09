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
        DataOperations dp = new DataOperations();
        public ItemBusqueda ItemSeleccionado;
        DataView dv;// = new DataView(dsConfigLoteConsumo1.search_mp);
        string StoreProcedureConfigActual = "";
        public enum TipoBusqueda
        {
            MateriaPrima = 1,
            ProductoTerminado = 2,
            Empleados = 3,
            PresentacionEmpaqueALOSY = 4,
            BodegasALOSY = 5,
            MaterialEmpaque = 6,
            Reproceso = 7
        }

        TipoBusqueda TipoBusquedaActual;
        public frmSearchMP(TipoBusqueda pTipo)
        {
            InitializeComponent();
            TipoBusquedaActual = pTipo;
            StoreProcedureConfigActual = "sp_get_lista_materias_primas";

            //MateriaPrimaSelected = new MateriaPrima();
            switch (TipoBusquedaActual)
            {
                case TipoBusqueda.MateriaPrima:
                    LoadData();
                    break;
                case TipoBusqueda.ProductoTerminado:
                    break;
                case TipoBusqueda.Empleados:
                    break;
                case TipoBusqueda.PresentacionEmpaqueALOSY:
                    break;
                case TipoBusqueda.BodegasALOSY:
                    break;
                case TipoBusqueda.MaterialEmpaque:
                    LoadData();
                    break;
                case TipoBusqueda.Reproceso:
                    LoadData();
                    break;
                default:
                    break;
            }
            ItemSeleccionado = new ItemBusqueda();
            
        }

        private void load_data_material_empaque()
        {
            string sql = @"sp_get_lista_materias_primas";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@parametro_busqueda", Convert.ToInt32(TipoBusquedaActual));

                dsConfigLoteConsumo1.search_mp.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsConfigLoteConsumo1.search_mp);
                dv = new DataView(dsConfigLoteConsumo1.search_mp);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                SqlConnection con;
                if (TipoBusquedaActual == TipoBusqueda.MaterialEmpaque)
                    con = new SqlConnection(dp.ConnectionStringAMS);
                else
                    con = new SqlConnection(dp.ConnectionStringLOSA);

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