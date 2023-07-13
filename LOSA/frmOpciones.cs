
using ACS.Classes;
using ACS.Forecast;
using ACS.Produccion;
using ACS.RRHH.HorasExtra;
using JAGUAR_APP.TransaccionesMP.Gestion_Granel;
using LOSA.Accesos;
using LOSA.Accesos.AccesosUsuarios;
using LOSA.Accesos.GestionGrupos;
using LOSA.Accesos.GestionSistemas;
using LOSA.Accesos.GrupoLosa;
using LOSA.Accesos.NivelAccesoSistema;
using LOSA.ACS.RRHH;
using LOSA.ACS.RRHH.Informes;
using LOSA.AlmacenesExterno;
using LOSA.AlmacenesExterno.Salida_Almacen;
using LOSA.Calidad;
using LOSA.Calidad.LoteConfConsumo;
using LOSA.Calidad.Revision_Sanidad;
using LOSA.Clases;
using LOSA.Despachos;
using LOSA.Liquidos;
using LOSA.Logistica;
using LOSA.Mantenimientos;
using LOSA.MigracionACS.AquaForecast;
using LOSA.MigracionACS.Finanzas.Inventarios;
using LOSA.MigracionACS.Finanzas.ODOO;
using LOSA.MigracionACS.Finanzas.Reports;
using LOSA.MigracionACS.Forecast;
using LOSA.MigracionACS.Formulas;
using LOSA.MigracionACS.Management;
using LOSA.MigracionACS.OIL;
using LOSA.MigracionACS.Ordenes_Combustible;
using LOSA.MigracionACS.Produccion;
using LOSA.MigracionACS.Produccion.BannerTV;
using LOSA.MigracionACS.Produccion.Configuraciones;
using LOSA.MigracionACS.Produccion.Consumos;
using LOSA.MigracionACS.Produccion.Eficiencia;
using LOSA.MigracionACS.Produccion.Eficiencia.DatosBromatologicos;
using LOSA.MigracionACS.Produccion.ForecastPRD;
using LOSA.MigracionACS.Produccion.Produccion.DashBoard;
using LOSA.MigracionACS.Produccion.Reports;
using LOSA.MigracionACS.Produccion.TemperaturaMaquinas;
using LOSA.MigracionACS.PT;
using LOSA.MigracionACS.RPTS;
using LOSA.MigracionACS.RRHH;
using LOSA.MigracionACS.RRHH.Encuesta;
using LOSA.MigracionACS.RRHH.Liquidaciones;
using LOSA.MigracionACS.RRHH.RelojFace;
using LOSA.MigracionACS.RRHH.Reportes;
using LOSA.MigracionACS.Ttracer;
using LOSA.MigracionACS.Ttracer.Reportes;
using LOSA.MigracionACS.Ttracer.ViewLogistica;
using LOSA.Nir;
using LOSA.PlanMPreque;
using LOSA.Produccion;
using LOSA.Produccion.CierreLote;
using LOSA.RecepcionMP;
using LOSA.RecuentoInventario;
using LOSA.Reportes;
using LOSA.Reproceso;
using LOSA.Tools;
using LOSA.TransaccionesMP;
using LOSA.TransaccionesPT;
using LOSA.Trazabilidad;
using LOSA.Trazabilidad.ReportesTRZ;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace LOSA
{
    public partial class frmOpciones : Form
    {
        UserLogin UsuarioLogeado;
        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;
        string ActiveADUser;
        DataTable UserGroups;

        public frmOpciones(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            int i = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
            //int i = Convert.ToInt32(4);
            switch (pUser.GrupoUsuario.GrupoUsuarioActivo)
            {
                case GrupoUser.GrupoUsuario.Montacarga:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;
                    break;
                case GrupoUser.GrupoUsuario.Logistica:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;
                    int idNivel = pUser.idNivelAcceso(pUser.Id, 7);//7 = ALOSY
                    switch (idNivel)
                    {
                        case 1://Basic View
                            tabOpciones.TabPages[9].PageVisible = true;
                            break;
                        case 2://Basic No Autorization
                            tabOpciones.TabPages[9].PageVisible = true;
                            break;
                        case 3://Medium Autorization
                            tabOpciones.TabPages[9].PageVisible = true;
                            break;
                        case 4://Depth With Delta
                            tabOpciones.TabPages[9].PageVisible = true;
                            tabOpciones.TabPages[7].PageVisible = true;
                            break;
                        case 5://Depth Without Delta
                            tabOpciones.TabPages[9].PageVisible = true;
                            tabOpciones.TabPages[7].PageVisible = true;
                            break;
                        default:
                            tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                            tabOpciones.TabPages[i].PageVisible = true;
                            break;
                    }
                    break;
                    
                case GrupoUser.GrupoUsuario.Calidad:
                    idNivel = pUser.idNivelAcceso(pUser.Id, 7);//7 = ALOSY
                    switch (idNivel)
                    {
                        case 1://Basic View
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel;
                            break;
                        case 2://Basic No Autorization

                            break;
                        case 3://Medium Autorization

                            break;
                        case 4://Depth With Delta
                            tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                            tabOpciones.TabPages[i].PageVisible = true;
                            break;
                        case 5://Depth Without Delta

                            break;
                        default:
                            tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                            tabOpciones.TabPages[i].PageVisible = true;
                            break;
                    }
                    break;
                case GrupoUser.GrupoUsuario.Administradores:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;

                    idNivel = pUser.idNivelAcceso(pUser.Id, 7);//7 = ALOSY
                    switch (idNivel)
                    {
                        case 1://Basic View
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel;
                            break;
                        case 2://Basic No Autorization

                            break;
                        case 3://Medium Autorization

                            break;
                        case 4://Depth With Delta
                        case 5://Depth Without Delta
                            tabOpciones.TabPages[0].PageVisible = true;
                            tabOpciones.TabPages[1].PageVisible = true;
                            tabOpciones.TabPages[2].PageVisible = true;
                            tabOpciones.TabPages[3].PageVisible = true;
                            tabOpciones.TabPages[4].PageVisible = true;
                            tabOpciones.TabPages[5].PageVisible = true;
                            tabOpciones.TabPages[6].PageVisible = true;
                            tabOpciones.TabPages[7].PageVisible = true;
                            tabOpciones.TabPages[8].PageVisible = true;
                            tabOpciones.TabPages[9].PageVisible = true;
                            tabOpciones.TabPages[10].PageVisible = true;
                            break;
                        default:
                            tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                            tabOpciones.TabPages[i].PageVisible = true;
                            break;
                    }
                    break;
                case GrupoUser.GrupoUsuario.Produccion:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;
                    break;
                case GrupoUser.GrupoUsuario.ProduccionV2:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i - 1].PageVisible = true;
                    
                    
                    idNivel = pUser.idNivelAcceso(pUser.Id, 7);//7 = ALOSY
                    switch (idNivel)
                    {
                        case 1://Basic View
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel;
                            break;
                        case 2://Basic No Autorization
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel;
                            break;
                        case 3://Medium Autorization
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel;
                            break;
                        case 4://Depth With Delta
                            //tabOpciones.TabPages[0].PageVisible = true;
                            //tabOpciones.TabPages[1].PageVisible = true;
                            //tabOpciones.TabPages[2].PageVisible = true;
                            //tabOpciones.TabPages[3].PageVisible = true;
                            tabOpciones.TabPages[4].PageVisible = true;
                            tabOpciones.TabPages[5].PageVisible = true;
                            tabOpciones.TabPages[10].PageVisible = true;
                           
                            break;
                        case 5://Depth Without Delta

                            break;
                        default:
                            tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                            tabOpciones.TabPages[i].PageVisible = true;
                            break;
                    }

                    if (pUser.ValidarNivelPermisos(92))
                        tabOpciones.TabPages[10].PageVisible = true;

                    break;
                case GrupoUser.GrupoUsuario.Contabilidad:
                    int idNivel2 = pUser.idNivelAcceso(pUser.Id, 7);//7 = ALOSY
                    switch (idNivel2)
                    {
                        case 1://Basic View
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel2;
                            break;
                        case 2://Basic No Autorization
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel2;
                            break;
                        case 3://Medium Autorization
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel2;
                            break;
                        case 4://Depth With Delta
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel2;
                            break;
                        case 5://Depth Without Delta
                            tabOpciones.SelectedTabPageIndex = 2;//Calidad
                            tabOpciones.TabPages[1].PageVisible = true;
                            tabOpciones.TabPages[8].PageVisible = true;
                            tabOpciones.TabPages[4].PageVisible = true;
                            break;
                        default:
                            tabOpciones.SelectedTabPageIndex = 2;//Calidad
                            tabOpciones.TabPages[1].PageVisible = true;
                            tabOpciones.TabPages[8].PageVisible = true;
                            break;
                    }
                    break;

                case GrupoUser.GrupoUsuario.RRHH:
                    int idNivel3 = pUser.idNivelAcceso(pUser.Id, 7);//7 = ALOSY

                    switch (idNivel3)
                    {
                        case 1://Basic View
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel3;
                            tabOpciones.SelectedTabPageIndex = 6;//RRHH
                            tabOpciones.TabPages[6].PageVisible = true;
                            tabOpciones.TabPages[2].PageVisible = false;
                            tabOpciones.TabPages[1].PageVisible = false;
                            break;
                        case 2://Basic No Autorization
                            tabOpciones.SelectedTabPageIndex = 6;//RRHH
                            tabOpciones.TabPages[6].PageVisible = true;
                            break;
                        case 3://Medium Autorization
                            tabOpciones.SelectedTabPageIndex = 6;//RRHH
                            tabOpciones.TabPages[6].PageVisible = true;
                            break;
                        case 4://Depth With Delta
                            tabOpciones.SelectedTabPageIndex = 6;//RRHH
                            tabOpciones.TabPages[6].PageVisible = true;
                            break;
                        case 5://Depth Without Delta
                            tabOpciones.SelectedTabPageIndex = 6;//RRHH
                            tabOpciones.TabPages[6].PageVisible = true;
                            break;
                        default:
                            tabOpciones.SelectedTabPageIndex = 6;//RRHH
                            tabOpciones.TabPages[6].PageVisible = true;
                            break;
                    }
                    break;

                case GrupoUser.GrupoUsuario.Forecasting:
                    int idNivel4 = pUser.idNivelAcceso(pUser.Id, 7);//7 = ALOSY

                    switch (idNivel4)
                    {
                        case 1://Basic View
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel4;
                            break;
                        case 2://Basic No Autorization

                            break;
                        case 3://Medium Autorization

                            break;
                        case 4://Depth With Delta
                            BasicView();
                            tabOpciones.SelectedTabPageIndex = 7;//Forecasting
                            tabOpciones.TabPages[1].PageVisible = true;
                            tabOpciones.TabPages[7].PageVisible = true;
                            break;
                        case 5://Depth Without Delta

                            break;
                        default:
                            tabOpciones.SelectedTabPageIndex = 7;//Forecasting
                            tabOpciones.TabPages[1].PageVisible = true;
                            tabOpciones.TabPages[7].PageVisible = true;
                            break;
                    }
                    break;

                case GrupoUser.GrupoUsuario.Bascula:
                    int idNivel10 = pUser.idNivelAcceso(pUser.Id, 7);//7 = ALOSY

                    switch (idNivel10)
                    {
                        case 1://Basic View
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel10;
                            break;
                        case 2://Basic No Autorization

                            break;
                        case 3://Medium Autorization

                            break;
                        case 4://Depth With Delta

                            break;
                        case 5://Depth Without Delta

                            break;
                        default:
                            tabOpciones.SelectedTabPageIndex = 8;//RRHH
                            tabOpciones.TabPages[8].PageVisible = true;
                            break;
                    }
                    break;

                case GrupoUser.GrupoUsuario.Formulacion:
                    int idNivel11 = pUser.idNivelAcceso(pUser.Id, 7);//7 = ALOSY

                    switch (idNivel11)
                    {
                        case 1://Basic View
                            BasicView();
                            UsuarioLogeado.Idnivel = idNivel11;
                            break;
                        case 2://Basic No Autorization

                            break;
                        case 3://Medium Autorization

                            break;
                        case 4://Depth With Delta

                            break;
                        case 5://Depth Without Delta

                            break;
                        default:
                            tabOpciones.SelectedTabPageIndex = 9;//RRHH
                            tabOpciones.TabPages[9].PageVisible = true;
                            break;
                    }
                    break;

                default:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;
                    break;
            }
        }

        public void BasicView()
        {
            TabCalidad.PageVisible = TabLogistica.PageVisible = TabContabilidad.PageVisible = true;
            cmdRegistroLote.Enabled =
            cmdGestionIngresos.Enabled =
            btnAjustesKardex.Enabled =
            cmdOrdenesFabricacion.Enabled =
            btnplanrequisas.Enabled =
            cmdRequisiciones_.Enabled =
            btnajuste.Enabled =
            cmdUbicaciones.Enabled =
            simpleButton3.Enabled =
            btndespachos.Enabled =
            btnReq_PT.Enabled =
            simpleButton2.Enabled =
            btnPlantarimas.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //frmMantenimiento frm = new frmMantenimiento();
            //frm.Show();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdRecepcionMPLogistica_Click(object sender, EventArgs e)
        {
            //
            frmImprimirHojaIngreso frm = new frmImprimirHojaIngreso(UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void BtnBodegas_Click(object sender, EventArgs e)
        {
            //frmBodega frm = new frmBodega();
            //frm.Show();
        }

        private void BtnTiposPresentaciones_Click(object sender, EventArgs e)
        {
            //frmTipoPresentacion frm = new frmTipoPresentacion();
            //frm.Show();
        }

        private void BtnEstadosProgramacionesRequisiciones_Click(object sender, EventArgs e)
        {
            //frmEstadoProgramacionRequisicion frm = new frmEstadoProgramacionRequisicion();
            //frm.Show();
        }

        private void BtnKardexTiposTransacciones_Click(object sender, EventArgs e)
        {
            //frmKardexTipoTransaccion frm = new frmKardexTipoTransaccion();
            //frm.Show();
        }

        private void BtnEstadosRequisiciones_Click(object sender, EventArgs e)
        {
            //frmEstadoRequisicion frm = new frmEstadoRequisicion();
            //frm.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //Mantenimientos
            frmMantoOpciones frm = new frmMantoOpciones(UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdRegistroLote_Click(object sender, EventArgs e)
        {

            frm_ingresos frm = new frm_ingresos(UsuarioLogeado);

            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            //frmTarima frm = new frmTarima(UsuarioLogeado);
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmEntradaMP frm = new frmEntradaMP(UsuarioLogeado);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void BtnCambiarUbicacion_Click(object sender, EventArgs e)
        {
            frmCambiarUbicacionTarima frm = new frmCambiarUbicacionTarima();
            frm.Show();
        }

        private void cmdProgramaRequisiciones_Click(object sender, EventArgs e)
        {
            frmOrdenesFabricacion frm = new frmOrdenesFabricacion(this.UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void BtnDevolciones_Click(object sender, EventArgs e)
        {
            frmDevolucionKardex frm = new frmDevolucionKardex(UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            frm.Show();
        }

        private void BtnAjustesKardex_Click(object sender, EventArgs e)
        {
            frmAjustesKardex frm = new frmAjustesKardex(UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            frm.Show();
        }

        private void cmdRequisiciones_Click(object sender, EventArgs e)
        {

        }

        private void cmdRequisiciones__Click(object sender, EventArgs e)
        {
            frmRequisiciones frm = new frmRequisiciones(UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdPT_Click(object sender, EventArgs e)
        {
            frmOptionMontaCarga frm = new frmOptionMontaCarga(UsuarioLogeado, 2);//pt
            //frm.WindowState = FormWindowState.Maximized;
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            frm.Show();
        }

        private void cmdMP_Click(object sender, EventArgs e)
        {
            frmOptionMontaCarga frm = new frmOptionMontaCarga(UsuarioLogeado, 1);//MP
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            frm.Show();


        }

        private void btnAlimentacionManual_Click(object sender, EventArgs e)
        {
            //frmAlimentacionManual frm = new frmAlimentacionManual(UsuarioLogeado);
            //frm.Show();
            frmAlimentacionPanel frm = new frmAlimentacionPanel(UsuarioLogeado);
            frm.Show();
        }

        private void btnLotesPorProveedor_Click(object sender, EventArgs e)
        {
            frmLotesXProveedor frm = new frmLotesXProveedor();
            frm.Show();
        }

        private void btnLotesXMP_Click(object sender, EventArgs e)
        {
            frmLotesXMP frm = new frmLotesXMP();
            frm.Show();
        }

        private void btnLotes_Click(object sender, EventArgs e)
        {
            frmLotes frm = new frmLotes();
            frm.Show();
        }

        private void btnCantidadMP_Click(object sender, EventArgs e)
        {
            frmCantidadMP frm = new frmCantidadMP();
            frm.Show();
        }

        private void btnDevolciones_Click_1(object sender, EventArgs e)
        {
            frmDevolucionKardex frm = new frmDevolucionKardex(UsuarioLogeado);
            frm.Show();
        }

        private void btnTrazabilidad_Click(object sender, EventArgs e)
        {
            frmTrazabilidadLote frm = new frmTrazabilidadLote();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdTarimasPT_Click(object sender, EventArgs e)
        {
            //frmHomeEnsacado frm = new frmHomeEnsacado(UsuarioLogeado);
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();

            frmactivacionPT frm = new frmactivacionPT(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            frmDevolucionKardex frm = new frmDevolucionKardex(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdLotesCalidad_Click(object sender, EventArgs e)
        {
            frmLotesStatus frm = new frmLotesStatus(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btndespachos_Click(object sender, EventArgs e)
        {
            LOSA.Despachos.frmdespachos frm = new LOSA.Despachos.frmdespachos(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnplanesdespachos_Click(object sender, EventArgs e)
        {
            //LOSA.Despachos.frmplanes FRM = new Despachos.frmplanes(UsuarioLogeado);
            //FRM.Show();
        }

        private void btnReq_PT_Click(object sender, EventArgs e)
        {
            LOSA.Despachos.frm_Reqresumen_pt frm = new Despachos.frm_Reqresumen_pt(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            LOSA.Reportes.frmreport frm = new Reportes.frmreport(this.UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }

            frm.Show();
        }

        private void btnconfiguracionCal_Click(object sender, EventArgs e)
        {
            frmcalidadcausas frm = new frmcalidadcausas();
            frm.Show();
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            //frmTarimaManual FRM = new frmTarimaManual(UsuarioLogeado);
            //FRM.Show();
            frmMP_Granel frm = new frmMP_Granel(UsuarioLogeado);


            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnplanrequisas_Click(object sender, EventArgs e)
        {
            frmnewplan frm = new frmnewplan(UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }

            frm.Show();

        }

        private void cmdGestionIngresos_Click(object sender, EventArgs e)
        {
            //abrir la ventana de gestion de ingresos.
            frmGestionIngresos frm = new frmGestionIngresos(this.UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdUbicaciones_Click(object sender, EventArgs e)
        {
            frmGestionUbicaciones frm = new frmGestionUbicaciones(this.UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                frm.FormBorderStyle = FormBorderStyle.None;
            }

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnRecuento_Click(object sender, EventArgs e)
        {

        }

        private void btnAlimentacion_Click(object sender, EventArgs e)
        {
            frmPlanPT frm = new frmPlanPT(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnPlantarimas_Click(object sender, EventArgs e)
        {
            frm_planificacion_despachos frm = new frm_planificacion_despachos(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnajuste_Click(object sender, EventArgs e)
        {

            //Poner validacion de permisos de forma restrictiva
            RecuentoInventario.frmRecuentoInventario frm = new RecuentoInventario.frmRecuentoInventario();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            //CajaDialogo.Error("Esta opcion esta en mantenimiento! No esta disponible actualmente!");
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            frmcalidad frm = new frmcalidad(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmPrintTM frm = new frmPrintTM(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frmreporte_trazabilidad frm = new frmreporte_trazabilidad(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btn_salidapt_Click(object sender, EventArgs e)
        {
            frmdespacho frm = new frmdespacho(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            frm_reporte_alimentacion frm = new frm_reporte_alimentacion();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            frm_reporte_alimentacion frm = new frm_reporte_alimentacion();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            frmreporte_trazabilidad frm = new frmreporte_trazabilidad(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnRequisasManuales_Click(object sender, EventArgs e)
        {
            frmRequisasManuales frm = new frmRequisasManuales(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            frm_ajustes_inventario_PT frm = new frm_ajustes_inventario_PT(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            frm_reporte_produccion frm = new frm_reporte_produccion();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            frm_reporte_produccion frm = new frm_reporte_produccion();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnAlmacenesExternos_Click(object sender, EventArgs e)
        {
            xfrmAlmacenesExternos_Main frm = new xfrmAlmacenesExternos_Main(UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                //frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            frm.Show();
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            frm_view_ingresos frm = new frm_view_ingresos(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            frmRequisiciones frm = new frmRequisiciones(UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btntarimasactivadasPT_Click(object sender, EventArgs e)
        {
            frm_rpt_productoT frm = new frm_rpt_productoT();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            //xfrmMovimientoStock frm = new xfrmMovimientoStock(UsuarioLogeado);
            xfrmMovimientoStockMain frm = new xfrmMovimientoStockMain(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdReporteReqManuales_Click(object sender, EventArgs e)
        {
            frmRequisicionesManualesReporte frm = new frmRequisicionesManualesReporte();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            frmRequisicionesManualesReporte frm = new frmRequisicionesManualesReporte();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            frmTrazabilidadOpciones frm = new frmTrazabilidadOpciones(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btn_andenes_Click(object sender, EventArgs e)
        {
            frmSeleccionAnden frm = new frmSeleccionAnden();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void ManteIngresos_Click(object sender, EventArgs e)
        {
            frm_mantenimiento_calidad frm = new frm_mantenimiento_calidad(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnMPReproceso_Click(object sender, EventArgs e)
        {

            xfrmReprocesoMenu frm = new xfrmReprocesoMenu(UsuarioLogeado);

            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            frm_MateriaPrimaEnBodegaPRd frm = new frm_MateriaPrimaEnBodegaPRd(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            frmLecturas frm = new frmLecturas(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton17_Click_1(object sender, EventArgs e)
        {
            xfrmIngresoLiquidos frm = new xfrmIngresoLiquidos(UsuarioLogeado);

            //xfrmTanque frm = new xfrmTanque();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnAut_Tm_Click(object sender, EventArgs e)
        {

        }

        private void tabEntregaMP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton17_Click_2(object sender, EventArgs e)
        {
            //frmPendienteAlmacenExterno frm = new frmPendienteAlmacenExterno(UsuarioLogeado);
            //Reproceso.frmReprocesoPrint frm = new Reproceso.frmReprocesoPrint();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
            //xfrmIngresosMP_Reproceso frm = new xfrmIngresosMP_Reproceso(UsuarioLogeado);
            Reproceso.frmReprocesoPrint frm = new Reproceso.frmReprocesoPrint(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton17_Click_3(object sender, EventArgs e)
        {
            xfrmCheckActiveBin frm = new xfrmCheckActiveBin();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            frmReporteExterno frm = new frmReporteExterno(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnLoteActivoGranel_Click(object sender, EventArgs e)
        {
            frmLoteActivoGranel frm = new frmLoteActivoGranel(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void frmOpciones_Load(object sender, EventArgs e)
        {
            try
            {
                bool newVersion;
                bool notificacionesSinLeer;

                NotificacionesGenerales notifications = new NotificacionesGenerales();
                xfrmPopup frm = new xfrmPopup(UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                this.ActiveUserCode = UsuarioLogeado.Id.ToString();
                this.ActiveUserName = UsuarioLogeado.NombreUser;
                this.ActiveUserType = UsuarioLogeado.Tipo;


                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    Version ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
                    notifications.Major = ver.Major;
                    notifications.Minor = ver.Minor;
                    notifications.Build = ver.Build;
                    notifications.Revision = ver.Revision;
                }
                else
                {
                    var ver = Assembly.GetExecutingAssembly().GetName().Version;
                    notifications.Major = ver.Major;
                    notifications.Minor = ver.Minor;
                    notifications.Build = ver.Build;
                    notifications.Revision = ver.Revision;
                }

                newVersion = notifications.ValidarVersionBuild(notifications.Major, notifications.Minor, notifications.Build, notifications.Revision, UsuarioLogeado.Id);
                notificacionesSinLeer = notifications.ValidarNotificacionesSinLeer(UsuarioLogeado.Id);

                if (notificacionesSinLeer)
                {
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnImprimirTm_Click(object sender, EventArgs e)
        {
            frmprint__tarimas frm = new frmprint__tarimas();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btn_rptubicaciones_Click(object sender, EventArgs e)
        {
            rptUbicaciones frm = new rptUbicaciones();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            frmTrazabilidadHaciaAdelanteByMP_Lot frm = new frmTrazabilidadHaciaAdelanteByMP_Lot();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
            frmControlIngreso frm = new frmControlIngreso();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            frmReporteProductoTerminado frm = new frmReporteProductoTerminado();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            frmReporteGeneralProductoTermnado frm = new frmReporteGeneralProductoTermnado(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton23_Click(object sender, EventArgs e)
        {
            frmPlanSemanal frm = new frmPlanSemanal(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnReporteProduccionDespachos_Click(object sender, EventArgs e)
        {
            frmrptPlansemanal frm = new frmrptPlansemanal();
            if (this.MdiParent != null)
                if (!frm.IsMdiChild)
                    frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton24_Click(object sender, EventArgs e)
        {
            //CajaDialogo.Error("En Construccion..");
            //frmCierreMensual frm = new frmCierreMensual(UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();


            try
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//9 = AMS
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        frmCierreMensual frm2 = new frmCierreMensual(UsuarioLogeado);
                        frm2.MdiParent = this.MdiParent;
                        frm2.Show();
                        break;
                    default:
                        break;
                }

                //if (!accesoprevio)
                //{
                //    if (UsuarioLogeado.ValidarNivelPermisos(80))
                //    {
                //        xfrmMainConfiguracion frm = new xfrmMainConfiguracion();
                //        frm.MdiParent = this.MdiParent;
                //        frm.Show();
                //    }
                //    else
                //    {
                //        CajaDialogo.Error("No tiene privilegios para esta función!");
                //    }
                //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }

        }

        private void simpleButton25_Click(object sender, EventArgs e)
        {
            frmSeguimientoAlimentacion frm = new frmSeguimientoAlimentacion(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton26_Click(object sender, EventArgs e)
        {
            frmReporteSeguimientoComprasTransito frm = new frmReporteSeguimientoComprasTransito();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton27_Click(object sender, EventArgs e)
        {
            frmGestionUbicaciones frm = new frmGestionUbicaciones(this.UsuarioLogeado, 1);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                frm.FormBorderStyle = FormBorderStyle.None;
            }

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void simpleButton28_Click(object sender, EventArgs e)
        {
            frmGestionUbicaciones frm = new frmGestionUbicaciones(this.UsuarioLogeado, 2);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                frm.FormBorderStyle = FormBorderStyle.None;
            }

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void tabMasterData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton29_Click(object sender, EventArgs e)
        {
            frmSeguimientoDespachos frm = new frmSeguimientoDespachos();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton30_Click(object sender, EventArgs e)
        {
            frmReporteInventarioKardexGeneral frm = new frmReporteInventarioKardexGeneral(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton31_Click(object sender, EventArgs e)
        {
            MantiniemintoCliente frm = new MantiniemintoCliente(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void tabPT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton32_Click(object sender, EventArgs e)
        {
            //xfrmPT_Reproceso frm = new xfrmPT_Reproceso(UsuarioLogeado);
            //xfrmReprocesoMenu frm = new xfrmReprocesoMenu(UsuarioLogeado);
            frmEleccionReproceso frm = new frmEleccionReproceso(UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            //frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void simpleButton33_Click(object sender, EventArgs e)
        {
            xfrmIngresosMP_Reproceso frm = new xfrmIngresosMP_Reproceso(UsuarioLogeado);

            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnClientesLote_Click(object sender, EventArgs e)
        {
            xfrmTrazabilidadClientesLotes frm = new xfrmTrazabilidadClientesLotes(UsuarioLogeado);

            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void simpleButton34_Click(object sender, EventArgs e)
        {
            //xfrmRevisionSanidad_InspeccionSeguridad frm = new xfrmRevisionSanidad_InspeccionSeguridad();

            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;

            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();

            //xfrmWizardRevisionanidadFirstStep frm = new xfrmWizardRevisionanidadFirstStep();

            ////if (this.MdiParent != null)
            ////    frm.MdiParent = this.MdiParent;

            ////frm.WindowState = FormWindowState.Maximized;
            //frm.Show();


            //xfrmWizardRevisionanidadFirstStep uc = new xfrmWizardRevisionanidadFirstStep();
            //uc.Dock = DockStyle.Fill;
            //this.Controls.Add(uc);

            xfrmSanidadAdmin frm = new xfrmSanidadAdmin();
            frm.ShowDialog();
        }

        private void cmdReportReqManual_Click(object sender, EventArgs e)
        {
            frmReporteRequisicionesManuales frm = new frmReporteRequisicionesManuales();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.Show();
            //frmrptMpEntregadaaProduccion
        }

        private void simpleButton35_Click(object sender, EventArgs e)
        {
            //frmrptMpEntregadaaProduccion frm = new frmrptMpEntregadaaProduccion();
            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;

            //frm.Show();

            frmSeguimientoAlimentacion frm = new frmSeguimientoAlimentacion(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            //
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton36_Click(object sender, EventArgs e)
        {
            frmReporteAsistencia frm = new frmReporteAsistencia(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void cmdReporteInventarioPorFecha_Click(object sender, EventArgs e)
        {
            frmReporteInvPorLoteA_LaFecha frm = new frmReporteInvPorLoteA_LaFecha(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void cmdVerConfiguracionLotesVencimientoMP_Click(object sender, EventArgs e)
        {
            frmConfigLoteConsumoFirst frm = new frmConfigLoteConsumoFirst(UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void cmdLoteActivoGranel_Click(object sender, EventArgs e)
        {
            frmLoteActivoGranelV2 frm = new frmLoteActivoGranelV2(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdReporteProximosVencer_Click(object sender, EventArgs e)
        {
            frmReporteKardexGeneralVencimiento frm = new frmReporteKardexGeneralVencimiento(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            frmRutasTrazabilidad frm = new frmRutasTrazabilidad(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnRecuento_Click_1(object sender, EventArgs e)
        {
            Logistica.frmRecuentoInventarios frmRecuentoInventario = new Logistica.frmRecuentoInventarios(this.UsuarioLogeado);
            frmRecuentoInventario.Show();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            frmEntregaTarimaMicros frm = new frmEntregaTarimaMicros(UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            frm.Show();
        }

        private void btnTransferenciaPendiente_Click(object sender, EventArgs e)
        {
            frmTransPendientes frm = new frmTransPendientes(UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();

        }

        private void btnHistorialPT_Click(object sender, EventArgs e)
        {
            frmHisotrialPTCodigo frm = new frmHisotrialPTCodigo();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdUsuarios_Click(object sender, EventArgs e)
        {
            AccesoUsuario frm = new AccesoUsuario();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdGrupos_Click(object sender, EventArgs e)
        {
            PrincipalGestionGrupos frm = new PrincipalGestionGrupos();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdSistemas_Click(object sender, EventArgs e)
        {
            PrincipalSistemas frm = new PrincipalSistemas();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdGruposAlosy_Click(object sender, EventArgs e)
        {
            PrincipalGrupoLosa frm = new PrincipalGrupoLosa();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdAccesoSistemas_Click(object sender, EventArgs e)
        {
            NivelAccesoSistema frm = new NivelAccesoSistema();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }


        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmAlimentacionManual frm = new frmAlimentacionManual(UsuarioLogeado);
            //frm.Show();
            frmAlimentacionPanel frm = new frmAlimentacionPanel(UsuarioLogeado);
            frm.Show();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPrintTM frm = new frmPrintTM(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmactivacionPT frm = new frmactivacionPT(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_reporte_alimentacion frm = new frm_reporte_alimentacion();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xfrmCheckActiveBin frm = new xfrmCheckActiveBin();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                PP_Operator_Panel_v2 frm = new PP_Operator_Panel_v2(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;

                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbTrazabilidad_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {

                RPT_Trazabilidad_Lote frm = new RPT_Trazabilidad_Lote(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void bnProgramaProduccion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                PP_Main_Products_Order frm = new PP_Main_Products_Order(UsuarioLogeado);
                frm.ActiveUserCodeP = ActiveUserCode;
                frm.ActiveUserNameP = ActiveUserName;
                frm.ActiveUserTypeP = ActiveUserType;
                frm.MdiParent = this.MdiParent;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void bnPortafolio_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                PT_Productos frm = new PT_Productos(ActiveUserCode, ActiveUserName, ActiveUserType, this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbControlProduccion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                string a = null;
                int group = 0;
                string Query = @"SELECT 
                                      [id_group]
                                  FROM [ACS].[dbo].[conf_usuarios]
                                  where id = " + ActiveUserCode;
                DataOperations dp = new DataOperations();

                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    group = dr.GetInt32(0);
                }
                //PRB_Registro pp = new PRB_Registro(ActiveUserCode, group, this.UsuarioLogeado);
                //pp.UsuarioLog1 = ActiveUserName;
                //pp.CodigoUss = ActiveUserCode;
                //pp.MdiParent = this.MdiParent;
                //pp.Show();

                try
                {
                    PRB_Registro frm = new PRB_Registro(ActiveUserCode, group, this.UsuarioLogeado);
                    frm.UsuarioLog1 = ActiveUserName;
                    frm.CodigoUss = ActiveUserCode;
                    frm.MdiParent = this.MdiParent;
                    if (!frm.CerrarForm)
                        frm.Show();
                    else
                        frm.Dispose();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    if (UsuarioLogeado.ValidarNivelPermisos(60))
            //    {
            //        frmDatosBrom frm = new frmDatosBrom(this.UsuarioLogeado);
            //        frm.MdiParent = this.MdiParent;
            //        frm.Show();
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #60");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            try
            {
                frmDatosBrom frm = new frmDatosBrom(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbConsultaHora_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                frmHorometrosLineas frm = new frmHorometrosLineas();
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                PP_Operator_Panel_v2 frm = new PP_Operator_Panel_v2(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;

                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


            //accesoprevio = true;
            //PP_Operator_Panel_v2 frm = new PP_Operator_Panel_v2(this.UsuarioLogeado);
            //frm.MdiParent = this;
            //frm.Show();
            //try
            //{
            //    bool accesoprevio = false;
            //    int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7=ALOSY, 9=AMS
            //    switch (idNivel)
            //    {
            //        case 1://Basic View
            //        case 2://Basic No Autorization
            //        case 3://Medium Autorization
            //        case 4://Depth With Delta
            //        case 5://Depth Without Delta
            //            accesoprevio = true;
            //            PP_Operator_Panel_v2 frm = new PP_Operator_Panel_v2(this.UsuarioLogeado);
            //            frm.MdiParent = this;
            //            frm.Show();
            //            break;
            //        default:
            //            break;
            //    }

            //    if (!accesoprevio)
            //    {
            //        if (UsuarioLogeado.ValidarNivelPermisos(69))
            //        {
            //            //frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
            //            PP_Operator_Panel_v2 frm = new PP_Operator_Panel_v2(this.UsuarioLogeado);
            //            frm.MdiParent = this;
            //            frm.Show();
            //        }
            //        else
            //        {
            //            CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #69");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
        }

        private void nbReporteBatch_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    if (UsuarioLogeado.ValidarNivelPermisos(46))
            //    {
            //        frmintakeKepserver frm = new frmintakeKepserver();
            //        frm.MdiParent = this.MdiParent;
            //        frm.Show();
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #46");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            try
            {
                frmintakeKepserver frm = new frmintakeKepserver(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbReporteEnsacadora_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    //reporte ensacadora
            //    if (UsuarioLogeado.ValidarNivelPermisos(48))
            //    {
            //        frmReporteEnsacadora frm = new frmReporteEnsacadora();
            //        frm.MdiParent = this.MdiParent;
            //        frm.WindowState = FormWindowState.Maximized;
            //        frm.Show();
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #48");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
            try
            {
                frmReporteEnsacadora frm = new frmReporteEnsacadora(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    //reporte Ingenieria de procesos.
            //    //Sacos por lotes
            //    if (UsuarioLogeado.ValidarNivelPermisos(48))
            //    {
            //        frmSacosPorLote frm = new frmSacosPorLote();
            //        frm.MdiParent = this.MdiParent;
            //        frm.WindowState = FormWindowState.Maximized;
            //        frm.Show();
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #48");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
            try
            {
                frmSacosPorLote frm = new frmSacosPorLote(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbEficienciaTurno_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    frmDashBoardEficiencia frm = new frmDashBoardEficiencia(UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
            try
            {
                frmDashBoardEficiencia frm = new frmDashBoardEficiencia(UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbGestionLotes_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    PP_Gestion_lote frm = new PP_Gestion_lote(UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
            try
            {
                PP_Gestion_lote frm = new PP_Gestion_lote(UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbReporteEficiencia_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{

            //    //Imprimir reporte de eficiencia
            //    frmPrintReportEficiencia frm = new frmPrintReportEficiencia(this.UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            try
            {
                frmPrintReportEficiencia frm = new frmPrintReportEficiencia(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbEficienciaMolinos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    frmEficienciaMolinos frm = new frmEficienciaMolinos();
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
            try
            {
                frmEficienciaMolinos frm = new frmEficienciaMolinos(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbBannerTV_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{

            //    frmBannerMainTV_PRD frm = new frmBannerMainTV_PRD(UsuarioLogeado);
            //    frm.MdiParent = this.MdiParent;
            //    //frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
            try
            {
                frmBannerMainTV_PRD frm = new frmBannerMainTV_PRD(UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem18_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    bool accesoprevio = false;
            //    int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //    switch (idNivel)
            //    {
            //        case 1://Basic View
            //            break;
            //        case 2://Basic No Autorization
            //            break;
            //        case 3://Medium Autorization
            //            break;
            //        case 4://Depth With Delta
            //            accesoprevio = true;
            //            frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
            //            frm.MdiParent = this.MdiParent;
            //            frm.Show();
            //            break;
            //        case 5://Depth Without Delta
            //            break;
            //        default:
            //            break;
            //    }

            //    if (!accesoprevio)
            //    {
            //        if (UsuarioLogeado.ValidarNivelPermisos(68))
            //        {
            //            frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
            //            frm.MdiParent = this.MdiParent;
            //            frm.Show();
            //        }
            //        else
            //        {
            //            CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #68");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            try
            {
                frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbTemperatura_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                xfrmMenuTemperatura frm = new xfrmMenuTemperatura(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbForeCastPRD_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                frmFCT_produccion frm = new frmFCT_produccion(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbConfiguraciones_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                        accesoprevio = true;
                        xfrmMainConfiguracion frm = new xfrmMainConfiguracion();
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                        break;
                    case 5://Depth Without Delta
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(80))
                    {
                        xfrmMainConfiguracion frm = new xfrmMainConfiguracion();
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #80");
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void navBarItem22_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                IntakeBatchViewerFull frm = new IntakeBatchViewerFull();
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void nbPlanProduccion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                Prod_Ordenes_Produccion frm = new Prod_Ordenes_Produccion(ActiveUserCode, ActiveUserName, ActiveUserType, this.UsuarioLogeado);
                //frm.MdiParent = this.MdiParent;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void frmTmVirtuales_Click(object sender, EventArgs e)
        {
            try
            {
                frmrptarimasvirtuales frm = new frmrptarimasvirtuales();
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton37_Click(object sender, EventArgs e)
        {
            xfrmAccesosTemporalesAdmin frm = new xfrmAccesosTemporalesAdmin(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void nbTrasladoAceiteExterno_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmOilRequest frm = new frmOilRequest(this.UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
            try
            {
                frmOilRequest frm = new frmOilRequest(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbSetMaterial_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmSetRM_Tantques_Ext frm = new frmSetRM_Tantques_Ext(this.UsuarioLogeado);
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
            try
            {
                frmSetRM_Tantques_Ext frm = new frmSetRM_Tantques_Ext(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbReporteTrasladoAceites_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //try
            //{
            //    frmReporteTraslados prod = new frmReporteTraslados();
            //    prod.MdiParent = this.MdiParent;
            //    prod.Show();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            try
            {
                frmReporteTraslados frm = new frmReporteTraslados(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbTrasladosTanquesArriba_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmReporteTrasladosArribaAdvanced frm = new frmReporteTrasladosArribaAdvanced();
            //prod.MdiParent = this.MdiParent;
            //prod.Show();
            try
            {
                frmReporteTrasladosArribaAdvanced frm = new frmReporteTrasladosArribaAdvanced(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbSalidaAceite_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frmReporteConsumoLinea frm = new frmReporteConsumoLinea(this.UsuarioLogeado);
            //prod.MdiParent = this.MdiParent;
            //prod.Show();
            try
            {
                frmReporteConsumoLinea frm = new frmReporteConsumoLinea(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbSetLoteGranel_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (UsuarioLogeado.ValidarNivelPermisos(8))
            {
                frmLoteActivoGraneles frm = new frmLoteActivoGraneles();
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            else
            {
                CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #48");
            }
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frm_report_oil_in_and_out frm = new frm_report_oil_in_and_out();
            //frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
            try
            {
                frm_report_oil_in_and_out frm = new frm_report_oil_in_and_out(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //bool accesoprevio = false;
            //int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            //switch (idNivel)
            //{
            //    case 1://Basic View
            //        break;
            //    case 2://Basic No Autorization
            //        break;
            //    case 3://Medium Autorization
            //        break;
            //    case 4://Depth With Delta
            //        accesoprevio = true;
            //        frmReporteTrasladosArribaByOrden frm = new frmReporteTrasladosArribaByOrden();
            //        frm.MdiParent = this.MdiParent;
            //        frm.Show();
            //        break;
            //    case 5://Depth Without Delta
            //        break;
            //    default:
            //        break;
            //}

            //if (!accesoprevio)
            //{
            //    if (UsuarioLogeado.ValidarNivelPermisos(73))
            //    {
            //        //frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
            //        frmReporteTrasladosArribaByOrden frm = new frmReporteTrasladosArribaByOrden();
            //        frm.MdiParent = this;
            //        frm.Show();
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #73");
            //    }
            //}

            try
            {
                frmReporteTrasladosArribaByOrden frm = new frmReporteTrasladosArribaByOrden(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void nbTrazabilidad_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                RPT_Trazabilidad_Lote frm = new RPT_Trazabilidad_Lote(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;

                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void simpleButton38_Click(object sender, EventArgs e)
        {
            frmEmpleadosM FRM = new frmEmpleadosM();
            FRM.MdiParent = this.MdiParent;
            FRM.Show();
        }

        private void simpleButton39_Click(object sender, EventArgs e)
        {
            OC_Menu frmCom = new OC_Menu(UsuarioLogeado);
            frmCom.MdiParent = this.MdiParent;
            frmCom.WindowState = FormWindowState.Maximized;
            frmCom.Show();
        }

        private void simpleButton40_Click(object sender, EventArgs e)
        {

            if (UsuarioLogeado.ValidarNivelPermisos(57))
            {
                frmGestionAccesosEncuesta frm = new frmGestionAccesosEncuesta();
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            else
            {
                CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #57");
            }
        }

        private void simpleButton41_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoFace frm = new Frm_MantenimientoFace();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton42_Click(object sender, EventArgs e)
        {
            frmResumenHorasExtra frm = new frmResumenHorasExtra(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton43_Click(object sender, EventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    frmResumenNominas frm = new frmResumenNominas();
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }
        }

        private void simpleButton44_Click(object sender, EventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    frmResumenVacaciones frm = new frmResumenVacaciones();
                    frm.MdiParent = this;
                    frm.Show();
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }
        }

        private void simpleButton45_Click(object sender, EventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    frmLiquidacionesOP frm = new frmLiquidacionesOP(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(81))
                {
                    frmLiquidacionesOP frm = new frmLiquidacionesOP(UsuarioLogeado);
                    //frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #81");
                }
            }
        }

        private void simpleButton46_Click(object sender, EventArgs e)
        {
            frmSaldosVacacionesRRHH frm = new frmSaldosVacacionesRRHH(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton49_Click(object sender, EventArgs e)
        {
            FML_Compare_Cost_External_Local form = new FML_Compare_Cost_External_Local();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void simpleButton47_Click(object sender, EventArgs e)
        {
            FCT_Proyeccion_Ventas forecast = new FCT_Proyeccion_Ventas();
            //forecast.MdiParent = this;
            forecast.ActiveUserCode = ActiveUserCode;
            forecast.ShowDialog();
        }

        private void simpleButton51_Click(object sender, EventArgs e)
        {
            FCT_Volumenes vol = new FCT_Volumenes();
            //vol.MdiParent = this;
            vol.ActiveUserCode = ActiveUserCode;
            vol.ShowDialog();
        }

        private void simpleButton50_Click(object sender, EventArgs e)
        {
            FCT_MRP mrp = new FCT_MRP(this.UsuarioLogeado);
            mrp.MdiParent = this.MdiParent;
            mrp.ActiveUserCode = ActiveUserCode;
            mrp.ShowDialog();
        }

        private void simpleButton48_Click(object sender, EventArgs e)
        {
            FCT_Proyeccion_Sacos frm = new FCT_Proyeccion_Sacos();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton56_Click(object sender, EventArgs e)
        {
            FCT_Proyeccion_Etiquetas frm = new FCT_Proyeccion_Etiquetas();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton52_Click(object sender, EventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    FCT_MRP_Complete frm = new FCT_MRP_Complete(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                case 5://Depth Without Delta
                    accesoprevio = true;
                    FCT_MRP_Complete frm1 = new FCT_MRP_Complete(this.UsuarioLogeado);
                    frm1.MdiParent = this.MdiParent;
                    frm1.Show();
                    break;
                default:
                    break;
            }
        }

        private void simpleButton53_Click(object sender, EventArgs e)
        {
            //AFC_ProyeccionVentas
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    AFC_ProyeccionVentas frm = new AFC_ProyeccionVentas(UsuarioLogeado);
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    break;
                case 5://Depth Without Delta
                    accesoprevio = true;
                    AFC_ProyeccionVentas frm1 = new AFC_ProyeccionVentas(UsuarioLogeado);
                    frm1.WindowState = FormWindowState.Maximized;
                    frm1.Show();
                    break;
                default:
                    break;
            }
        }

        private void simpleButton54_Click(object sender, EventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    frmFCT_produccion frm = new frmFCT_produccion(this.UsuarioLogeado);
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    break;
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmFCT_produccion frm1 = new frmFCT_produccion(this.UsuarioLogeado);
                    frm1.WindowState = FormWindowState.Maximized;
                    frm1.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(71))
                {
                    //frmMantoPhotosTV frm = new frmMantoPhotosTV(UsuarioLogeado);
                    frmFCT_produccion frm = new frmFCT_produccion(this.UsuarioLogeado);
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #71");
                }
            }
        }

        private void simpleButton55_Click(object sender, EventArgs e)
        {
            //AFC_ConsumoReal
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    AFC_ConsumoReal frm = new AFC_ConsumoReal();
                    frm.MdiParent = this;
                    frm.Show();
                    break;
                case 5://Depth Without Delta
                    accesoprevio = true;
                    AFC_ConsumoReal frm1 = new AFC_ConsumoReal();
                    frm1.MdiParent = this;
                    frm1.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(71))
                {
                    AFC_ConsumoReal frm = new AFC_ConsumoReal();
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #71");
                }
            }
        }

        private void simpleButton58_Click(object sender, EventArgs e)
        {
            try
            {
                MigracionACS.Produccion.Reports.Rep_Fml_Uso form = new MigracionACS.Produccion.Reports.Rep_Fml_Uso();
                form.MdiParent = this.MdiParent;
                form.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);               
            }
        }

        private void simpleButton59_Click(object sender, EventArgs e)
        {
            try
            {
                MigracionACS.Finanzas.Reports.Rep_Fml_Uso form = new MigracionACS.Finanzas.Reports.Rep_Fml_Uso();
                form.MdiParent = this.MdiParent;
                form.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        
        }

        private void simpleButton62_Click(object sender, EventArgs e)
        {
            try
            {
                MigracionACS.Finanzas.Reports.RPT_Conta_Varios form = new MigracionACS.Finanzas.Reports.RPT_Conta_Varios(ActiveUserCode, ActiveUserType, ActiveADUser, UserGroups, this.UsuarioLogeado);
                form.MdiParent = this.MdiParent;
                form.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton65_Click(object sender, EventArgs e)
        {
            try
            {
            MigracionACS. Finanzas.Reports.RPT_FML_NC_MasterDetailReport form = new MigracionACS.Finanzas.Reports.RPT_FML_NC_MasterDetailReport();
                form.MdiParent = this.MdiParent;
            form.Show();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton61_Click(object sender, EventArgs e)
        {
            try
            {
               MigracionACS.Finanzas.Reports.RPT_FML_FL_FF_CostVar_MasterDetailReport form = new MigracionACS.Finanzas.Reports.RPT_FML_FL_FF_CostVar_MasterDetailReport(ActiveUserCode, ActiveUserName, ActiveUserType, UserGroups);
                form.MdiParent = this.MdiParent;
                form.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton60_Click(object sender, EventArgs e)
        {
            try
            {
                int user_id = int.Parse(ActiveUserCode);
                //user_id = GetUserID(ActiveUserName);

                if (user_id == 1020 || user_id == 1035 || user_id == 1037)
                {
                    frm_Reporteador_Validate_byUser frm = new frm_Reporteador_Validate_byUser(ActiveUserCode, ActiveUserName, ActiveUserType);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene permisos para Abrir esta ventana");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                
            }
        }

        private void simpleButton66_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogeado.ValidarNivelPermisos(34))
                {
                   MigracionACS.SAR.SAR_Main frmAll = new MigracionACS.SAR.SAR_Main();
                    frmAll.MdiParent = this.MdiParent;
                    frmAll.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #34");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }
        }

        private void simpleButton63_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogeado.ValidarNivelPermisos(58))
                {
                    frmConsumoConsolaReal frm = new frmConsumoConsolaReal();
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #58");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
             
            }
        }

        private void simpleButton64_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogeado.ValidarNivelPermisos(58))
                {
                    frmConsumoConsolaTeorico frm = new frmConsumoConsolaTeorico();
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #58");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            
            }
        }

        private void simpleButton57_Click(object sender, EventArgs e)
        {
            rd_OdooMenu.ShowPopup(new Point((this.Width / 2), (this.Height / 2)));
        }

        private void btnMP_BodsegaPRD_Click(object sender, EventArgs e)
        {
            frm_MateriaPrimaEnBodegaPRd frm = new frm_MateriaPrimaEnBodegaPRd(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btn_mp_bodega_prd_finanzas_Click(object sender, EventArgs e)
        {
            frm_MateriaPrimaEnBodegaPRd frm = new frm_MateriaPrimaEnBodegaPRd(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnRutas_traza_produccion_Click(object sender, EventArgs e)
        {
            frmRutasTrazabilidad frm = new frmRutasTrazabilidad(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnrutas_traz_logistica_Click(object sender, EventArgs e)
        {
            frmRutasTrazabilidad frm = new frmRutasTrazabilidad(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btn_rutas_traza_contabilidad_Click(object sender, EventArgs e)
        {
            frmRutasTrazabilidad frm = new frmRutasTrazabilidad(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btn_add_tarimas_pt_Click(object sender, EventArgs e)
        {

        }

        private void navBarItem19_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                frmReporteTrasladosArribaByLotePT frm = new frmReporteTrasladosArribaByLotePT(this.UsuarioLogeado);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                if (!frm.CerrarForm)
                    frm.Show();
                else
                    frm.Dispose();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton67_Click(object sender, EventArgs e)
        {
            xfrmReporteLotesAConsumir frm = new xfrmReporteLotesAConsumir();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xfrmReporteLotesAConsumir frm = new xfrmReporteLotesAConsumir();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton68_Click(object sender, EventArgs e)
        {
            try
            {
                TT_Arribo arrib = new TT_Arribo(ActiveUserCode);
                arrib.MdiParent = this.MdiParent;
                arrib.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton71_Click(object sender, EventArgs e)
        {
            try
            {
                TT_reporte_bascula rept = new TT_reporte_bascula();
                rept.MdiParent = this.MdiParent;
                rept.WindowState = FormWindowState.Maximized;
                rept.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton70_Click(object sender, EventArgs e)
        {
            try
            {
                frmCamionesEnPredio rept = new frmCamionesEnPredio(UsuarioLogeado);
                rept.MdiParent = this.MdiParent;
                //rept.WindowState = FormWindowState.Maximized;
                rept.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton69_Click(object sender, EventArgs e)
        {
            try
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 9);//9 = AMS
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                        accesoprevio = true;
                        frmDetalleDesechos frm = new frmDetalleDesechos(this.UsuarioLogeado);
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                        break;
                    case 5://Depth Without Delta
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton72_Click(object sender, EventArgs e)
        {
            try
            {
                FML_FF_Main_Panel form = new FML_FF_Main_Panel(ActiveUserCode, ActiveUserName, ActiveUserType, UserGroups, this.UsuarioLogeado);
                form.MdiParent = this.MdiParent;
                form.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton73_Click(object sender, EventArgs e)
        {
            try
            {
                FML_Formulas_v2 fm = new FML_Formulas_v2(ActiveUserCode, ActiveUserName, ActiveUserType, UserGroups, this.UsuarioLogeado);
                fm.MdiParent = this.MdiParent;
                fm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void navBarItem9_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xfrmMP_Por_BIN frm = new xfrmMP_Por_BIN();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdCierreLotesPT_Click(object sender, EventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    frmCierreLoteMain frm = new frmCierreLoteMain(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(84))
                {
                    frmCierreLoteMain frm = new frmCierreLoteMain(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #84");
                }
            }
           
        }

        private void btnViewRequisasCalidad_Click(object sender, EventArgs e)
        {
            frmviewrequisas frm = new frmviewrequisas(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnValidacionTarimas_Click(object sender, EventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7); //7 = ALOSY
            
            switch (idNivel)
            {
                case 1://BasicView
                    break;

                case 2: //Basic No Autorization
                    break;

                case 3://Medium Autorization
                    break;

                case 4://Depth With Delta
                    accesoprevio = true;
                    frmValidacionTarimas frm2 = new frmValidacionTarimas(UsuarioLogeado);
                    frm2.MdiParent = this.MdiParent;
                    frm2.Show();
                    break;

                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmValidacionTarimas frm = new frmValidacionTarimas(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;

            }

            //if (!accesoprevio)
            //{
            //    if (UsuarioLogeado.ValidarNivelPermisos())
            //    {
            //        frmValidacionTarimas frm = new frmValidacionTarimas(UsuarioLogeado);
            //        frm.Show();
            //    }
            //    else
            //    {
            //        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #");
            //    }
            //}
           
        }

        private void cmdReporteBancosPlanilla_Click(object sender, EventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7); //7 = ALOSY

            switch (idNivel)
            {
                case 1://BasicView
                    break;

                case 2: //Basic No Autorization
                    break;

                case 3://Medium Autorization
                    break;

                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmReporteBancosODOO frm = new frmReporteBancosODOO(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;

            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(88))
                {
                    frmReporteBancosODOO frm = new frmReporteBancosODOO(UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #88");
                }
            }
        }

        private void btnReqMEmpaque_Click(object sender, EventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
            switch (idNivel)
            {
                case 1://Basic View
                    accesoprevio = true;
                    frmRequisasMaterialEmpaque frm = new frmRequisasMaterialEmpaque(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                case 2://Basic No Autorization                 
                case 3://Medium Autorization
                case 4://Depth With Delta
                case 5://Depth Without Delta                 
                default:
                    accesoprevio = true;
                    frmRequisasMaterialEmpaque frm0 = new frmRequisasMaterialEmpaque(this.UsuarioLogeado);
                    frm0.MdiParent = this.MdiParent;
                    frm0.Show();
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(89))
                {
                    frmRequisasMaterialEmpaque frm = new frmRequisasMaterialEmpaque(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #89");
                }
            }


        }

        private void btnMaterialEmpaquePT_Click(object sender, EventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                case 3://Medium Autorization
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmRequisasMaterialEmpaque frm = new frmRequisasMaterialEmpaque(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(89))
                {
                    frmRequisasMaterialEmpaque frm = new frmRequisasMaterialEmpaque(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #89");
                }
            }
        }

        private void btnCalidadMaterialEmpaque_Click(object sender, EventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                case 3://Medium Autorization
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmRequisasMaterialEmpaque frm = new frmRequisasMaterialEmpaque(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(89))
                {
                    frmRequisasMaterialEmpaque frm = new frmRequisasMaterialEmpaque(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #89");
                }
            }
        }

        private void btnPrioridadLotePT_Click(object sender, EventArgs e)
        {

        }

        private void cmdAprobarAjustesInvALOSY_Click(object sender, EventArgs e)
        {
            //frmSolicitudesAjustesInventario
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                case 3://Medium Autorization
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmSolicitudesAjustesInventario frm = new frmSolicitudesAjustesInventario(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(91))
                {
                    frmSolicitudesAjustesInventario frm = new frmSolicitudesAjustesInventario(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #91");
                }
            }
        }

        private void cmdImprimirVouchers_Click(object sender, EventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmHomePlanillaCatorceavo frm = new frmHomePlanillaCatorceavo(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(81))
                {
                    frmHomePlanillaCatorceavo frm = new frmHomePlanillaCatorceavo(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #81");
                }
            }
        }

        private void cmdGestionLotesGranel_Click(object sender, EventArgs e)
        {
            //frmGestionLoteGranel
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmGestionLoteGranel frm = new frmGestionLoteGranel(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(81))
                {
                    frmGestionLoteGranel frm = new frmGestionLoteGranel(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #81");
                }
            }
        }

        private void btnGestionMP_Click(object sender, EventArgs e)
        {

        }

        private void btn_print_mp_remanente_Click(object sender, EventArgs e)
        {
            frmPrintTarimasRemanente frm = new frmPrintTarimasRemanente();
            frm.Show();
        }

        private void cmdPrintVouchersPlanillas_Click(object sender, EventArgs e)
        {
            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                case 5://Depth Without Delta
                    accesoprevio = true;
                    frmHomePrintVoucherPlanilla frm = new frmHomePrintVoucherPlanilla(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(81))
                {
                    frmHomePrintVoucherPlanilla frm = new frmHomePrintVoucherPlanilla(this.UsuarioLogeado);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #81");
                }
            }
            
        }
    }
}