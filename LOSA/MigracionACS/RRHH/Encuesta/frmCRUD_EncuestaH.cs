using ACS.Classes;
using DevExpress.Xpo;
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

namespace LOSA.MigracionACS.RRHH.Encuesta
{
    public partial class frmCRUD_EncuestaH : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmCRUD_EncuestaH(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            this.UsuarioLogeado = pUsuarioLogeado;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAMS);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_encuesta_header_crud", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsEncuesta1.crud_encuesta_h.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsEncuesta1.crud_encuesta_h);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnEncuesta_Click(object sender, EventArgs e)
        {
            xfrmGenerarEncuesta frm = new xfrmGenerarEncuesta(this.UsuarioLogeado);
            //frmCRUD_EncuestaH frm = new frmCRUD_EncuestaH(this.UsuarioLogeado);
            frm.ShowDialog();
        }

        private void cmdCopiarDesdeEsta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsEncuesta.crud_encuesta_hRow)gridView.GetFocusedDataRow();

            xfrmGenerarEncuesta frm = new xfrmGenerarEncuesta(row.descripcion, row.instrucciones, row.codigo, row.anio_evaluar, this.UsuarioLogeado);
            //frmCRUD_EncuestaH frm = new frmCRUD_EncuestaH(this.UsuarioLogeado);
            frm.ShowDialog();
        }
    }
}