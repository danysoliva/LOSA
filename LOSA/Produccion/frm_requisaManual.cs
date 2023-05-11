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

namespace LOSA.Produccion
{
    public partial class frm_requisaManual : DevExpress.XtraEditors.XtraForm
    {
        public int id_requisa;
        public string itemcode;
        public int id_mp;
        public string mpdes;
        public int id_requisa_manual;
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        public frm_requisaManual(int Pid, UserLogin Puser, int Pid_req_manual)
        {
            InitializeComponent();
            id_requisa = Pid;
            id_requisa_manual = Pid_req_manual;
            UsuarioLogeado = Puser;
            load_requisa_manual();
        }

        public void load_requisa_manual() 
        {
            string query = @"sp_obtener_materia_prima_solicitada_manual";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_req", id_requisa);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsProduccion.lista_mp.Clear();
                da.Fill(dsProduccion.lista_mp);
                
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
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
                frmSolicitarMP frm = new frmSolicitarMP(id_requisa, UsuarioLogeado, id_requisa_manual);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    load_requisa_manual();
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}