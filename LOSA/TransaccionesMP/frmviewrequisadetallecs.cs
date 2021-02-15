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
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;

namespace LOSA.TransaccionesMP
{
    public partial class frmviewrequisadetallecs : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int IdRequisicionHeader;
        public frmviewrequisadetallecs(int pIdl)
        {
            InitializeComponent();
            IdRequisicionHeader = pIdl;
            LoadDatos();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}