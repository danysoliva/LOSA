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
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.TransaccionesPT
{
    public partial class frmPlanPT : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        private int id_Seleccionado;
        UserLogin UsuarioLogeado;
        public frmPlanPT(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            LoadData();
        }

        public int Id_Seleccionado { get => id_Seleccionado;
                                    set => id_Seleccionado = value; }

        public void LoadData()
        {
            string Query = @"sp_load_order_f_producto_terminado";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsPT.OFabricacion.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPT.OFabricacion);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdv_data_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPlanificar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsPT.OFabricacionRow)gridView.GetFocusedDataRow();
                Id_Seleccionado = row.DocEntry;
                frmGestiondePlan frm = new frmGestiondePlan(row.DocEntry
                                                            , row.ItemCode
                                                            , row.ItemName
                                                            , row.FechaP
                                                            , row.Cantidad
                                                            , UsuarioLogeado);
                frm.Show();
            }
            catch (Exception ex)
            {

            }
        }
    }
}