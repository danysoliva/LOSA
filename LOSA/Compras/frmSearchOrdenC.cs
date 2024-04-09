using ACS.Classes;
using DevExpress.XtraEditors;
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
using LOSA.Compras;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Compras
{
    public partial class frmSearchOrdenC : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;
        public int IdOrdenesSeleccionado = 0;

        public enum FiltroOrdenesCompra
        {
            Todas = 1,
            Abiertas = 2
        }
        FiltroOrdenesCompra Filtro;
        public frmSearchOrdenC(frmSearchOrdenC.FiltroOrdenesCompra pfiltro, UserLogin pUserLogin)
        {
            InitializeComponent();
            Filtro = pfiltro;
            UsuarioLogueado = pUserLogin;

            LoadData();

        }

        private void LoadData()
        {
            try
            {
                string query = @"sp_get_ordenes_compra";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.orden_compra_exo.Clear();
                adat.Fill(dsCompras1.orden_compra_exo);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridview = (GridView)grdSolicitudes.FocusedView;
            var row = (dsCompras.orden_compra_exoRow)gridview.GetFocusedDataRow();

            IdOrdenesSeleccionado = row.id_h;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void reposAprobacion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdSolicitudes.FocusedView;
            var row = (dsCompras.orden_compra_exoRow)gridview.GetFocusedDataRow();

            bool Proceder = false;

            if (row.id_h > 0)
            {
                CMOrdenCompraH oc = new CMOrdenCompraH();
                oc.RecuperarRegistro(row.id_h);

                switch (row.id_estado)
                {
                    case 1://Pendiente de Aprobacion
                        Proceder = false;
                        CajaDialogo.Information("La Orden ya se encuentra en espera de aprobacion!");

                        break;

                    case 2: //Autorizado
                        Proceder = false;
                        CajaDialogo.Information("La Orden ya fue Autorizada!");

                        break;
                    case 3: //Rechazado
                        Proceder = false;
                        CajaDialogo.Information("La Orden se encuentra Rechazada!");

                        break;

                    case 4: //Cancelado
                        Proceder = false;
                        CajaDialogo.Information("La Orden fue Cancelada!");

                        break;

                    case 5: //Creada (Se debe Enviar a Aprobacion)
                        Proceder = true;
                        break;

                    default:
                        break;
                }

                if (Proceder)
                {
                    try
                    {
                        string query = @"sp_CM_enviar_aprobacion_orden_compra";
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_h", row.id_h);
                        cmd.Parameters.AddWithValue("@user_id", UsuarioLogueado.Id);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                    CajaDialogo.Information("Orden de Compra enviada a aprobacion!");
                    LoadData();

                }
            }
        }
    }
}