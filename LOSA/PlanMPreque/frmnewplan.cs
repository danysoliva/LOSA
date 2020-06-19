using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.TransaccionesMP;
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

namespace LOSA.PlanMPreque
{
    public partial class frmnewplan : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmnewplan(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            LoadData(); 
        }
        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_orders_fabrication_plafinicadas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsTransaccionesMP1.Plan_requiciones.Clear();
                adat.Fill(dsTransaccionesMP1.Plan_requiciones);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            //boton ver
            var gridView = (GridView)grOrdenFabricacion.FocusedView;
            var row = (dsTransaccionesMP.Plan_requicionesRow)gridView.GetFocusedDataRow();

            string comment = "";
            try
            {
                comment = row.Comments;
            }
            catch { }

            frmverdetalleplan frm = new frmverdetalleplan(row.idplan, this.UsuarioLogeado, comment);
            frm.WindowState = FormWindowState.Maximized;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}