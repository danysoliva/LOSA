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
        public MateriaPrima MateriaPrimaSelected;
        public frmSearchMP()
        {
            InitializeComponent();
            MateriaPrimaSelected = new MateriaPrima();
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
                if (!string.IsNullOrEmpty(txtParametroBusqueda.Text))
                    cmd.Parameters.AddWithValue("@parametro_busqueda", txtParametroBusqueda.Text);
                else
                    cmd.Parameters.AddWithValue("@parametro_busqueda", DBNull.Value);

                dsConfigLoteConsumo1.search_mp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsConfigLoteConsumo1.search_mp);

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
                    if (MateriaPrimaSelected.RecuperarRegistroFromID_RM(row.id))
                    {
                        MateriaPrimaSelected.IdMP_ACS = row.id;
                        MateriaPrimaSelected.CodeMP_SAP = row.ItemCode;
                        row.Seleccionado = true;
                    }
                    //IdUserNewAssigned = row.id;
                    //row.seleccionado = true;
                }

                foreach (dsConfigLoteConsumo.search_mpRow row1 in dsConfigLoteConsumo1.search_mp)
                {
                    if (row1.id != MateriaPrimaSelected.IdMP_ACS)
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
    }
}