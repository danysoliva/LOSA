using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Calidad.Revision_Sanidad.Model;
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

namespace LOSA.Calidad.Revision_Sanidad
{
    public partial class xfrmRevisionSanidad_InspeccionSeguridad : DevExpress.XtraEditors.XtraUserControl
    {
        List<InspeccionSeguridad_Results> items = new List<InspeccionSeguridad_Results>();

        public xfrmStepRevisionSanidad mainNavigate = new xfrmStepRevisionSanidad();


        public VehiculoInfo vehiculo = new VehiculoInfo();

        public int id_h = 0;

        private static xfrmRevisionSanidad_InspeccionSeguridad _instance = null;


        public static xfrmRevisionSanidad_InspeccionSeguridad Instance
        {

            get
            {
                if (_instance == null)
                    _instance = new xfrmRevisionSanidad_InspeccionSeguridad();

                return _instance;
            }
        }



        public xfrmRevisionSanidad_InspeccionSeguridad()
        {
            InitializeComponent();
            LoadTemplate();
            
        }

        private void LoadTemplate()
        {
            try
            {
                DataOperations dp = new DataOperations();
                items = new List<InspeccionSeguridad_Results>();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("dbo.sp_get_inspeccion_seguridad_template", cnx);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        items.Add(new InspeccionSeguridad_Results
                        {
                            InspeccionSeguridadPlantillaID = dr.GetInt32(0),
                            InspeccionSeguridadPlantillaName = dr.GetString(1),
                            InspeccionSeguridadRespuestaID = dr.GetInt32(2)
                        });
                    }

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsPlumas_Toggled(object sender, EventArgs e)
        {
            try
            {
                items.Where(S => S.InspeccionSeguridadPlantillaID == Convert.ToInt32(tsPlumas.Properties.Tag))
                             .Select(S => { S.InspeccionSeguridadRespuestaID = (int)tsPlumas.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsFaroDerecho_Toggled(object sender, EventArgs e)
        {
            try
            {
                items.Where(S => S.InspeccionSeguridadPlantillaID == Convert.ToInt32(tsFaroDerecho.Properties.Tag))
                             .Select(S => { S.InspeccionSeguridadRespuestaID = (int)tsFaroDerecho.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsFaroIzquierdo_Toggled(object sender, EventArgs e)
        {
            try
            {
                items.Where(S => S.InspeccionSeguridadPlantillaID == Convert.ToInt32(tsFaroIzquierdo.Properties.Tag))
                             .Select(S => { S.InspeccionSeguridadRespuestaID = (int)tsFaroIzquierdo.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsGuia_Toggled(object sender, EventArgs e)
        {
            try
            {
                items.Where(S => S.InspeccionSeguridadPlantillaID == Convert.ToInt32(tsGuia.Properties.Tag))
                             .Select(S => { S.InspeccionSeguridadRespuestaID = (int)tsGuia.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsGuiaIzquierda_Toggled(object sender, EventArgs e)
        {
            try
            {
                items.Where(S => S.InspeccionSeguridadPlantillaID == Convert.ToInt32(tsGuiaIzquierda.Properties.Tag))
                             .Select(S => { S.InspeccionSeguridadRespuestaID = (int)tsGuiaIzquierda.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsLuzFreno_Toggled(object sender, EventArgs e)
        {
            try
            {
                items.Where(S => S.InspeccionSeguridadPlantillaID == Convert.ToInt32(tsLuzFreno.Properties.Tag))
                             .Select(S => { S.InspeccionSeguridadRespuestaID = (int)tsLuzFreno.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsLucesParqueo_Toggled(object sender, EventArgs e)
        {
            try
            {
                items.Where(S => S.InspeccionSeguridadPlantillaID == Convert.ToInt32(tsLucesParqueo.Properties.Tag))
                             .Select(S => { S.InspeccionSeguridadRespuestaID = (int)tsLucesParqueo.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsHerramientas_Toggled(object sender, EventArgs e)
        {
            try
            {
                items.Where(S => S.InspeccionSeguridadPlantillaID == Convert.ToInt32(tsHerramientas.Properties.Tag))
                             .Select(S => { S.InspeccionSeguridadRespuestaID = (int)tsHerramientas.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void toggleSwitch4_Toggled(object sender, EventArgs e)
        {
            try
            {
                items.Where(S => S.InspeccionSeguridadPlantillaID == Convert.ToInt32(tsGata.Properties.Tag))
                             .Select(S => { S.InspeccionSeguridadRespuestaID = (int)tsGata.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsExtintor_Toggled(object sender, EventArgs e)
        {
            try
            {
                items.Where(S => S.InspeccionSeguridadPlantillaID == Convert.ToInt32(tsExtintor.Properties.Tag))
                             .Select(S => { S.InspeccionSeguridadRespuestaID = (int)tsExtintor.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsPito_Toggled(object sender, EventArgs e)
        {
            try
            {
                items.Where(S => S.InspeccionSeguridadPlantillaID == Convert.ToInt32(tsPito.Properties.Tag))
                             .Select(S => { S.InspeccionSeguridadRespuestaID = (int)tsPito.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsPitoRetro_Toggled(object sender, EventArgs e)
        {
            try
            {
                items.Where(S => S.InspeccionSeguridadPlantillaID == Convert.ToInt32(tsPitoRetro.Properties.Tag))
                             .Select(S => { S.InspeccionSeguridadRespuestaID = (int)tsPitoRetro.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsLlantaEmerg_Toggled(object sender, EventArgs e)
        {
            try
            {
                items.Where(S => S.InspeccionSeguridadPlantillaID == Convert.ToInt32(tsLlantaEmerg.Properties.Tag))
                             .Select(S => { S.InspeccionSeguridadRespuestaID = (int)tsLlantaEmerg.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsCinturon_Toggled(object sender, EventArgs e)
        {
            try
            {
                items.Where(S => S.InspeccionSeguridadPlantillaID == Convert.ToInt32(tsCinturon.Properties.Tag))
                             .Select(S => { S.InspeccionSeguridadRespuestaID = (int)tsCinturon.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsTriangulo_Toggled(object sender, EventArgs e)
        {
            try
            {
                items.Where(S => S.InspeccionSeguridadPlantillaID == Convert.ToInt32(tsTriangulo.Properties.Tag))
                             .Select(S => { S.InspeccionSeguridadRespuestaID = (int)tsTriangulo.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsEspejos_Toggled(object sender, EventArgs e)
        {
            try
            {
                items.Where(S => S.InspeccionSeguridadPlantillaID == Convert.ToInt32(tsEspejos.Properties.Tag))
                             .Select(S => { S.InspeccionSeguridadRespuestaID = (int)tsEspejos.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsTaco_Toggled(object sender, EventArgs e)
        {
            try
            {
                items.Where(S => S.InspeccionSeguridadPlantillaID == Convert.ToInt32(tsTaco.Properties.Tag))
                             .Select(S => { S.InspeccionSeguridadRespuestaID = (int)tsTaco.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsFuga_Toggled(object sender, EventArgs e)
        {
            try
            {
                items.Where(S => S.InspeccionSeguridadPlantillaID == Convert.ToInt32(tsFuga.Properties.Tag))
                             .Select(S => { S.InspeccionSeguridadRespuestaID = (int)tsFuga.EditValue; return S; }).ToList();
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
                xfrmRevisionSanidad_.Instance.id_h = id_h;
                if (!this.Controls.Contains(xfrmRevisionSanidad_.Instance))
                {
                    //ucTipoItems.dbConnection = bdConnection;
                    ((Form)this.TopLevelControl).Controls.Add(xfrmRevisionSanidad_.Instance);
                    xfrmRevisionSanidad_.Instance.Dock = DockStyle.Fill;
                    xfrmRevisionSanidad_.Instance.BringToFront();
                    xfrmRevisionSanidad_.Instance.vehiculo=vehiculo;
                    xfrmRevisionSanidad_.Instance.result_inspeccionSeguridad = items;
                    xfrmRevisionSanidad_.Instance.mainNavigate = mainNavigate;


                }
                else
                    xfrmRevisionSanidad_.Instance.BringToFront();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _instance = null;
            this.Hide();

        }

        private void xfrmRevisionSanidad_InspeccionSeguridad_Load(object sender, EventArgs e)
        {
            vehiculo = Instance.vehiculo;
        }

        private void tgFugaCombustible_Toggled(object sender, EventArgs e)
        {
            try
            {
                items.Where(S => S.InspeccionSeguridadPlantillaID == Convert.ToInt32(tgFugaCombustible.Properties.Tag))
                             .Select(S => { S.InspeccionSeguridadRespuestaID = (int)tgFugaCombustible.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).DialogResult = DialogResult.Cancel;

        }
    }
}