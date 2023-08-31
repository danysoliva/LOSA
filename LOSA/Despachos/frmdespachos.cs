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
using LOSA.Clases;
using System.Data.SqlClient;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Despachos
{
    public partial class frmdespachos : DevExpress.XtraEditors.XtraForm
    {
        DataOperations op = new DataOperations();
        UserLogin ULogin;
        public frmdespachos(UserLogin UsuarioLogeado)
        {
            InitializeComponent();
            load_data_orden_de_ventas();
            ULogin = UsuarioLogeado;
            if(ULogin.GrupoUsuario.GrupoUsuarioActivo == GrupoUser.GrupoUsuario.Administradores)
                txtNameForIT_Support.Visible = txtNameForIT_Support.ReadOnly = true;
            else
                txtNameForIT_Support.Visible = txtNameForIT_Support.ReadOnly = false;

        }
        public void load_data_orden_de_ventas()
        {
            SqlConnection sqlConnection = new SqlConnection(op.ConnectionStringLOSA);
            try
            {
                string qry = @"EXEC [dbo].[orden_venta_load_despachos]";//Query que obtiene la informacion de las Ordenes de ventas.
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(qry, sqlConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                ds_despachos.orden_venta.Clear();
                dataAdapter.Fill(ds_despachos.orden_venta);
                sqlConnection.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_despachos.FocusedView;
                var row = (ds_despachos.orden_ventaRow)gridview.GetFocusedDataRow();
                frmplandespacho frm = new frmplandespacho(row.id, ULogin, row.CardCode, row.CardName , row.DocNum);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnNuevoOrdenCarga_Click(object sender, EventArgs e)
        {
            frm_nueva_orden frm = new frm_nueva_orden(ULogin);
            frm.Show();
        }
    }
}