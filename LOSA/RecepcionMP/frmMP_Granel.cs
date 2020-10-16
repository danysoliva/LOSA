using ACS.Classes;
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

namespace LOSA.RecepcionMP
{
    public partial class frmMP_Granel : Form
    {
        UserLogin UsuarioLogeado;
        public frmMP_Granel(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringBascula);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_ingresos_granel_mp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsRecepcionMPx1.granel.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.granel);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdPasarAlosy_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Registrar en ALOSY

        }

        private void cmdLoteActivo_Click(object sender, EventArgs e)
        {
            frmLoteActvoGranel frm = new frmLoteActvoGranel(UsuarioLogeado);
            frm.Show();
        }

        private void checkBoxSeleccionarTodas_CheckedChanged(object sender, EventArgs e)
        {
            
                foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
                {
                    row.seleccionar = checkBoxSeleccionarTodas.Checked;
                }

           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Generar ingreso de granel

            frmIngresoGranelAlosy frm = new frmIngresoGranelAlosy(this.UsuarioLogeado);
            frm.Show();
        }
    }
}
