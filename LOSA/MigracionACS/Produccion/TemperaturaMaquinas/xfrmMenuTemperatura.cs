using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.MigracionACS.Produccion.Molinos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MigracionACS.Produccion.TemperaturaMaquinas
{
    public partial class xfrmMenuTemperatura : DevExpress.XtraEditors.XtraForm
    {
        public bool CerrarForm;
        UserLogin UsuarioLogeado;
        public xfrmMenuTemperatura(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            ValidatePermisos();
        }


        private void ValidatePermisos()
        {
            bool AccesoPrevio = false;
            if (UsuarioLogeado.ValidarNivelPermisos(61))
            {
                //btnc_VerifyReach.Enabled = true;
                AccesoPrevio = true;
            }

            //Validar si cuenta con un permiso temporal para acceder
            if (UsuarioLogeado.ValidarNivelPermisosTemporal(61))
            {
                //btnc_VerifyReach.Enabled = true;
                AccesoPrevio = true;
            }

            //Si no se consiguio acceso previo vamos a validar niveles permanentes
            if (!AccesoPrevio)
            {
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 7);//7=ALOSY, 9=AMS
                switch (idNivel)
                {
                    case 1://Basic View
                    case 2://Basic No Autorization
                        //btnc_VerifyReach.Enabled = false;
                        AccesoPrevio = true;
                        break;
                    case 3://Medium Autorization
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        //btnc_VerifyReach.Enabled = true;
                        AccesoPrevio = true;
                        break;
                    default:
                        break;
                }
            }

            if (!AccesoPrevio)
            {
                CerrarForm = true;
                CajaDialogo.Error("No tiene privilegios para esta función! El permiso requerido es #61");
            }
            else
            {

            }
        }

        private void btnExtrusora_Click(object sender, EventArgs e)
        {
            xfrmTemperaturaExtusora frm = new xfrmTemperaturaExtusora();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnPellet1_Click(object sender, EventArgs e)
        {
            xfrmTemperaturaPellet_1 frm = new xfrmTemperaturaPellet_1();

            frm.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            xfrmTemperaturaPellet_2 frm = new xfrmTemperaturaPellet_2();

            frm.Show();
        }

        private void btnMolinosTilapia_Click(object sender, EventArgs e)
        {
           xfrmTemperaturaMolinosTilapia frm = new xfrmTemperaturaMolinosTilapia();

            frm.Show();
        }

        private void btnCamaron_Click(object sender, EventArgs e)
        {
            xfrmTemperaturaMolinosCamaron frm = new xfrmTemperaturaMolinosCamaron();

            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            xfrmEficienciaMolinos frm = new xfrmEficienciaMolinos();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}