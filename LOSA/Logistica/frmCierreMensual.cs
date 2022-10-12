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
using ACS.Classes;
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Logistica
{
    public partial class frmCierreMensual : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;

        public frmCierreMensual(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            load_data();
        }

        public void load_data()
        {
            string query = @"sp_get_inventario_final_encabezados";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCierreMes1.recuentos_h.Clear();
                da.Fill(dsCierreMes1.recuentos_h);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoRecuento_Click(object sender, EventArgs e)
        {
            frmNuevoRecuento frm = new frmNuevoRecuento(UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }
        }

        private void repositoryVerDetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gv = (GridView)grd_data.FocusedView;
            var row = (dsCierreMes.recuentos_hRow)gv.GetDataRow(gv.FocusedRowHandle);

            frmCierreMensual_Detalle frm = new frmCierreMensual_Detalle(row.id);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdNuevoRecuento_Click(object sender, EventArgs e)
        {

        }

        private void reposbtnContabilizar_Click(object sender, EventArgs e)
        {
            var gv = (GridView)grd_data.FocusedView;
            var row = (dsCierreMes.recuentos_hRow)gv.GetDataRow(gv.FocusedRowHandle);

            if (row.contabilizacion == true)
            {
                CajaDialogo.Error("Este Recuento ya fue contabilizado, cree uno nuevo!");
                return;
            }
            else
            {
                frmCierreMensual_Detalle frm = new frmCierreMensual_Detalle(row.id, row.contabilizacion);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }
    }
}