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
using LOSA.Calidad.Parametros;

namespace LOSA.Calidad
{
    public partial class frm_mantenimiento_calidad : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frm_mantenimiento_calidad(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManteIngresos_Click(object sender, EventArgs e)
        {
            frmOlorMantenimiento frm = new frmOlorMantenimiento(UsuarioLogeado);
            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmColormantenimiento frm = new frmColormantenimiento(UsuarioLogeado);
            frm.Show();
        }

        private void btntextura_Click(object sender, EventArgs e)
        {
            frmTexturaMantenimiento frm = new frmTexturaMantenimiento(UsuarioLogeado);
            frm.Show();
        }

        private void btngrumos_Click(object sender, EventArgs e)
        {
            frmGrumosMantenimiento frm = new frmGrumosMantenimiento(UsuarioLogeado);
            frm.Show();
        }

        private void btnplaga_Click(object sender, EventArgs e)
        {
            frmInsectosMantenimiento frm = new frmInsectosMantenimiento(UsuarioLogeado);
            frm.Show();
        }

        private void frm_mantenimiento_calidad_Load(object sender, EventArgs e)
        {

        }

        private void btnOrigenEspecie_Click(object sender, EventArgs e)
        {
            frmOrigenMantenimiento frm = new frmOrigenMantenimiento(UsuarioLogeado);
            frm.Show();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            frmPescaMantenimiento frm = new frmPescaMantenimiento(UsuarioLogeado);
            frm.Show();

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            frmPaisMantenimiento frm = new frmPaisMantenimiento(UsuarioLogeado);
            frm.Show();
        }

        private void frmTipo_Click(object sender, EventArgs e)
        {
            frmTipoMantenimiento frm = new frmTipoMantenimiento(UsuarioLogeado);
            frm.Show();
        }

        private void btnConfiguracionMP_Click(object sender, EventArgs e)
        {
            ConfiguracionMP frm = new ConfiguracionMP(UsuarioLogeado);
            frm.Show();
        }

        private void btnconfiguracionCal_Click(object sender, EventArgs e)
        {
            frmcalidadcausas frm = new frmcalidadcausas();
            frm.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmcrudParametros frm = new frmcrudParametros();
            frm.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmConfiguracionPT frm = new frmConfiguracionPT();
            frm.Show();
        }

        private void btnCertificado_Click(object sender, EventArgs e)
        {
            xfrmCertificadoCalidad frm = new xfrmCertificadoCalidad();
            frm.Show();
        }
    }
}