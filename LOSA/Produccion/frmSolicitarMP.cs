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
using System.Data.SqlClient;

namespace LOSA.Produccion
{
    public partial class frmSolicitarMP : DevExpress.XtraEditors.XtraForm
    {

        public int id_mp;
        public string mpdes;
        public string itemcode;
        UserLogin UsuarioLogeado;
        int id_requisa;
        DataOperations dp = new DataOperations();
        public frmSolicitarMP(int Pid, UserLogin Puser)
        {
            InitializeComponent();
            id_requisa = Pid;
            UsuarioLogeado = Puser;
        }

        private void bn_Mp_Click(object sender, EventArgs e)
        {
            frm_seleccionarMPInorder frm = new frm_seleccionarMPInorder(id_requisa);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                mpdes = frm.descripcion;
                itemcode = frm.itemcode;
                id_mp = frm.id_mp;
                txtMP.Text = mpdes;
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMP.Text == "")
                {
                    CajaDialogo.Error("Debe de seleccionar una materia prima para hacer esta requisa.");
                    return;
                }
                if (txt_kg.Text == "0.00")
                {
                    CajaDialogo.Error("Debe de agregar una cantidad de kg para hacer esta requisa.");
                    return;
                }
                if (txt_kg.Text == "")
                {
                    CajaDialogo.Error("Debe de agregar una cantidad de kg para hacer esta requisa.");
                    return;
                }

                string query = @"sp_inserd_in_requisas_manuales";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_req", id_requisa);
                cmd.Parameters.AddWithValue("@id_mp", id_mp);
                cmd.Parameters.AddWithValue("@itemcode", itemcode);
                cmd.Parameters.AddWithValue("@kg", txt_kg.Text);
                cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;
                this.Close();
                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
               
            }
        }
    }
}