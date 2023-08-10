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
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Logistica
{
    public partial class frm_selecionarProducto : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int Tab_Active;
        int DEFAULT_VALUE = 0;
        public string codigo, itemcode;
        public int id;
        public string descripcion;
        public frm_selecionarProducto(int Ptab)
        {
            InitializeComponent();
            Tab_Active = Ptab;
            get_articulos();
        }
        public void get_pt()
        {
            string query = @"sp_get_pt_id_codigo_descripcion";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsCierreMes.articulos.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCierreMes.articulos);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void get_mp()
        {
            string query = @"sp_get_mp_id_codigo_descripcion";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsCierreMes.articulos.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCierreMes.articulos);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void get_articulos()
        {
            if (Tab_Active == 0)
            {
                get_mp();
            }
            else
            {
                get_pt();
            }
        }

        private void btn_seleccinar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsCierreMes.articulosRow)gridView.GetFocusedDataRow();
                codigo = row.codigo;
                id = row.id;
                descripcion = row.producto;
                itemcode = row.itemcode;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void grdv_data_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsCierreMes.articulosRow)gridView.GetFocusedDataRow();
                codigo = row.codigo;
                id = row.id;
                descripcion = row.producto;
                itemcode = row.itemcode;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}