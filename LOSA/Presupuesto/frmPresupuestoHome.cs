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
using ACS.Classes;
using LOSA.Clases;
using System.Data;
using LOSA.Presupuesto;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;


namespace LOSA.Presupuesto
{
    public partial class frmPresupuestoHome : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado = new UserLogin();
        int IdPresupuesto;
        int IdDetalle;
        public frmPresupuestoHome(UserLogin user)
        {
            InitializeComponent();
            UsuarioLogeado = user;
            //Permisos - Todavia no me queda claro!


            CargarPresupuestos();
        }

        private void CargarPresupuestos()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_presupuesto_all", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPresupuesto1.presupuestos_h.Clear();
                adat.Fill(dsPresupuesto1.presupuestos_h);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarPresupuestosDetalle()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_presupuesto_detalle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_presupuesto",IdPresupuesto);
                cmd.Parameters.AddWithValue("@user_id",UsuarioLogeado.Id);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPresupuesto1.presupuesto_detalle.Clear();
                adat.Fill(dsPresupuesto1.presupuesto_detalle);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void btnAddHeader_Click(object sender, EventArgs e)
        {
            frmPresupuestoHomeOP frm = new frmPresupuestoHomeOP(frmPresupuestoHomeOP.Operacion.Nuevo, UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarPresupuestos();
            }
        }

        private void btnCloseHeader_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reposAddPresupuesto_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            //DETALLE PRESUPUESTO POR DEPARTAMENTO Y PRESUPUESTO ID
            var gridview = (GridView)gcHeader.FocusedView;
            var row = (dsPresupuesto.presupuestos_hRow)gridview.GetFocusedDataRow();

            IdPresupuesto = row.id;
            navigationFrame1.SelectNextPage();
            CargarPresupuestosDetalle();

        }

        private void btnDetalleAtras_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectPrevPage();
            CargarPresupuestos();
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //DETALLE con montos POR Departamento
            var gridview = (GridView)gcDetalle.FocusedView;
            var row = (dsPresupuesto.presupuesto_detalleRow)gridview.GetFocusedDataRow();
            IdDetalle = row.id_detalle;
            txtDepartamento.Text = row.departamento;
            navigationFrame1.SelectNextPage();

            CargarPresupuestosDetalleLinea(IdDetalle);

        }

        private void CargarPresupuestosDetalleLinea(int idDetalle)
        {
            try
            {
                string query = @"";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@idDetalle", idDetalle);
                dsPresupuesto1.presupuesto_detalle_lineas.Clear();
                adat.Fill(dsPresupuesto1.presupuesto_detalle_lineas);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAddDetalle_Click(object sender, EventArgs e)
        {
            //Esto lo Generaria Manual
        }

        private void btnAddDetalleAuto_Click(object sender, EventArgs e)
        {
            //Esto deberia generar el Detalle de cada departamento segun configuracion de [FIN_presupuesto_ruta_usuarios]
            //Todavia no se si valdra la pena.

        }

        private void btnDetalle_lineasBack_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectPrevPage();

            CargarPresupuestosDetalle();
        }

        private void btnDetalleLineasCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}