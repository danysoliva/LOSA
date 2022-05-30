using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Calidad.Revision_Sanidad.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Calidad.Revision_Sanidad
{
    public partial class xfrmWizardRevisionanidadFirstStep : DevExpress.XtraEditors.XtraUserControl
    {
    public int id_h = 0;
       public VehiculoInfo vehiculo = new VehiculoInfo();

        private static xfrmWizardRevisionanidadFirstStep _instance = null;

        //public xfrmStepRevisionSanidad mainNavigate = new xfrmStepRevisionSanidad();


        public static xfrmWizardRevisionanidadFirstStep Instance
        {

            get
            {
                if (_instance == null)
                    _instance = new xfrmWizardRevisionanidadFirstStep();

                return _instance;
            }
        }

        public xfrmWizardRevisionanidadFirstStep()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                xfrmVehiculoInfo frm = new xfrmVehiculoInfo();

                if (frm.ShowDialog()== DialogResult.OK)
                {
                    vehiculo = new VehiculoInfo();

                    vehiculo = frm.vehiculo;

                    txtTemperaturaContenedor.Text = "0";
                    txtConductor.Text = frm.vehiculo.Conductor;
                    txtFecha.Text = frm.vehiculo.Fecha.ToString();
                    txtHora.Text = frm.vehiculo.Hora;
                    txtPlaca.Text = frm.vehiculo.Placa;
                    txtContenedor.Text = frm.vehiculo.Contenedor ;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (vehiculo != null)
                {

                    if (Convert.ToDecimal( txtTemperaturaContenedor.Text)== 0)
                    {
                        CajaDialogo.Error("Debe de ingresar la temperatura del contenedor");
                        return;
                    }

                    vehiculo.TemperaturaContenedor = Convert.ToDecimal(txtTemperaturaContenedor.Text);
                    vehiculo.SectorCliente_Destino = txtSectorClienteDestino.Text;
                    vehiculo.Cliente = txtCliente.Text;
                    vehiculo.ProveedorTransporte = txtProveedorTransporte.Text;
                    vehiculo.PaisDestino = txtPaisDestino.Text;

                    xfrmRevisionSanidad_InspeccionSeguridad.Instance.id_h = id_h;

                    if (!this.Controls.Contains(xfrmRevisionSanidad_InspeccionSeguridad.Instance))
                    {
                        ((Form)this.TopLevelControl).Controls.Add(xfrmRevisionSanidad_InspeccionSeguridad.Instance);
                        xfrmRevisionSanidad_InspeccionSeguridad.Instance.Dock = DockStyle.Fill;
                        xfrmRevisionSanidad_InspeccionSeguridad.Instance.BringToFront();
                        xfrmRevisionSanidad_InspeccionSeguridad.Instance.vehiculo = vehiculo;
                        //xfrmRevisionSanidad_InspeccionSeguridad.Instance.mainNavigate = mainNavigate;

                    }
                    else
                        xfrmRevisionSanidad_InspeccionSeguridad.Instance.BringToFront();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void xfrmWizardRevisionanidadFirstStep_Load(object sender, EventArgs e)
        {
            if (id_h!=0)
            {
               vehiculo = new VehiculoInfo();

                if (vehiculo.RecuperaRegistro(id_h))
                {
                    txtConductor.Text = vehiculo.Conductor;
                    txtContenedor.Text = vehiculo.Contenedor;
                    txtCliente.Text = vehiculo.Cliente;
                    txtSectorClienteDestino.Text = vehiculo.SectorCliente_Destino;
                    txtPlaca.Text = vehiculo.Placa;
                    txtTemperaturaContenedor.Text = vehiculo.TemperaturaContenedor.ToString();
                    txtFecha.Text = vehiculo.Fecha.ToString();
                    txtProveedorTransporte.Text = vehiculo.ProveedorTransporte;
                    txtHora.Text = vehiculo.Hora;
                    txtPaisDestino.Text = vehiculo.PaisDestino;
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).DialogResult = DialogResult.Cancel;

        }
    }
}