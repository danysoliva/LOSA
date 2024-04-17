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
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.TransaccionesMP
{
    
    public partial class frmviewrequisa_detalle : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int LotePT, IdRequisicionHeader;
        UserLogin UsuarioLogeado;

        public frmviewrequisa_detalle(int pIdl, UserLogin Puser, int pLote)
        {
            InitializeComponent();
            LotePT = pLote;
            txtLote.Text = pLote.ToString();
            IdRequisicionHeader = pIdl;
            LoadDatos();
            UsuarioLogeado = Puser;
        }

        private void LoadDatos()
        {
            try
            {

                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_requisicion_detalle", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_req_header", IdRequisicionHeader);
                dsTransaccionesMP1.requisiciones_d.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTransaccionesMP1.requisiciones_d);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void verLotesProximosAvencer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
             this.DialogResult = DialogResult.OK;
             this.Close();
        }
    }
}