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
using LOSA.Finanzas;
using LOSA.Clases;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Finanzas
{
    public partial class frmExoneracionAQ : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();

        public frmExoneracionAQ(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
            cargarheader();
        }

        private void cargarheader()
        {
            try
            {
                string query = @"sp_get_header_exoneracion_aq";
                SqlConnection conn = new SqlConnection(dp.ConnectionSAP_ACS);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsExoneracion1.lista_exoneracion.Clear();
                adat.Fill(dsExoneracion1.lista_exoneracion);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reposCerrarPeriodo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdListaExoneracion.FocusedView;
            var row = (dsExoneracion.lista_exoneracionRow)gridview.GetFocusedDataRow();

            bool PeriodoActivo = false;
            if (row.cerrado)
            {
                CajaDialogo.Error("Este Periodo esta Cerrado!");
                return;
            }

            if (dp.Now() < row.final)
            {
                PeriodoActivo = true;
            }

            if (PeriodoActivo)
            {
                DialogResult r = CajaDialogo.Pregunta("La Exoneracion sigue Vigente!\n Fecha de Finalizacion: "+row.final + "\n Fecha Actual: "+ dp.Now()+"\n Desea Cerrar de todos modos?");
                if (r != DialogResult.Yes)
                    return;
            }
            else
            {
                DialogResult r = CajaDialogo.Pregunta("Esta seguro que desea cerrar el Periodo de Exoneracion Año: " + row.anio + "?");
                if (r != DialogResult.Yes)
                    return;
            }
            
            try
            {
                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void repostGestionPresupuesto_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdListaExoneracion.FocusedView;
            var row = (dsExoneracion.lista_exoneracionRow)gridview.GetFocusedDataRow();

            frmExoneracionDetalle frm = new frmExoneracionDetalle(UsuarioLogueado, row.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cargarheader();
            }

        }
    }
}