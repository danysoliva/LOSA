using LOSA.Calidad;
using LOSA.Clases;
using LOSA.Logistica;
using LOSA.Mantenimientos;
using LOSA.Produccion;
using LOSA.RecepcionMP;
using LOSA.TransaccionesMP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOSA.PlanMPreque;
using LOSA.TransaccionesPT;
using LOSA.AlmacenesExterno;
using LOSA.Reportes;
using LOSA.Trazabilidad;
using LOSA.Despachos;
using LOSA.Nir;

namespace LOSA
{
    public partial class frmOpciones : Form
    {
        UserLogin UsuarioLogeado;
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
                    break;
                case GrupoUser.GrupoUsuario.Calidad:
                    int idNivel = pUser.idNivelAcceso(pUser.Id, 7);//7 = ALOSY
                    switch (idNivel)
                    {
                        case 1://Basic View
                            BasicView();
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
                            tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                            tabOpciones.TabPages[i].PageVisible = true;
                            break;
                    }
                    break;
                case GrupoUser.GrupoUsuario.Administradores:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;
                    break;
                case GrupoUser.GrupoUsuario.Produccion:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;
                    break;
                case GrupoUser.GrupoUsuario.ProduccionV2:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i-1].PageVisible = true;
                    break;
                default:
                    tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    tabOpciones.TabPages[i].PageVisible = true;
                    break;
            }
        }

        public void BasicView()
        {
            TabCalidad.PageVisible = TabLogistica.PageVisible = true;
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
            simpleButton1.Enabled =
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
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdMP_Click(object sender, EventArgs e)
        {
            frmOptionMontaCarga frm = new frmOptionMontaCarga(UsuarioLogeado, 1);//MP
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();


        }

        private void btnAlimentacionManual_Click(object sender, EventArgs e)
        {
            //frmAlimentacionManual frm = new frmAlimentacionManual(UsuarioLogeado);
            //frm.Show();
            frmAlimentacionPanel frm = new frmAlimentacionPanel();
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
            frm.Show();
        }

        private void cmdTarimasPT_Click(object sender, EventArgs e)
        {
            //frmHomeEnsacado frm = new frmHomeEnsacado(UsuarioLogeado);
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();

            frmactivacionPT frm = new frmactivacionPT(UsuarioLogeado);
            frm.Show();
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            frmDevolucionKardex frm = new frmDevolucionKardex(UsuarioLogeado);
            frm.Show();
        }

        private void cmdLotesCalidad_Click(object sender, EventArgs e)
        {
            frmLotesStatus frm = new frmLotesStatus(UsuarioLogeado);
            frm.Show();
        }

        private void btndespachos_Click(object sender, EventArgs e)
        {
            LOSA.Despachos.frmdespachos frm = new LOSA.Despachos.frmdespachos(UsuarioLogeado);
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
            frm.Show();
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            LOSA.Reportes.frmreport frm = new Reportes.frmreport();
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
            frm.Show();
        }

        private void btnPlantarimas_Click(object sender, EventArgs e)
        {
            frm_planificacion_despachos frm = new frm_planificacion_despachos(UsuarioLogeado);
            frm.Show();
        }

        private void btnajuste_Click(object sender, EventArgs e)
        {
            RecuentoInventario.frmRecuentoInventario frm = new RecuentoInventario.frmRecuentoInventario();
            frm.Show();
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
            frm.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frmreporte_trazabilidad frm = new frmreporte_trazabilidad(UsuarioLogeado);
            frm.Show();
        }

        private void btn_salidapt_Click(object sender, EventArgs e)
        {
            frmdespacho frm = new frmdespacho(UsuarioLogeado);
            frm.Show();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            frm_reporte_alimentacion frm = new frm_reporte_alimentacion();
            frm.Show();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            frm_reporte_alimentacion frm = new frm_reporte_alimentacion();
            frm.Show();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            frmreporte_trazabilidad frm = new frmreporte_trazabilidad(UsuarioLogeado);
            frm.Show();
        }

        private void btnRequisasManuales_Click(object sender, EventArgs e)
        {
            frmRequisasManuales frm = new frmRequisasManuales(UsuarioLogeado);
            frm.Show();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            frm_ajustes_inventario_PT frm = new frm_ajustes_inventario_PT(UsuarioLogeado);
            frm.Show();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            frm_reporte_produccion frm = new frm_reporte_produccion();
            frm.Show();
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            frm_reporte_produccion frm = new frm_reporte_produccion();
            frm.Show();
        }

        private void btnAlmacenesExternos_Click(object sender, EventArgs e)
        {
            xfrmAlmacenesExternos_Main frm = new xfrmAlmacenesExternos_Main(UsuarioLogeado);
            frm.Show();
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            frm_view_ingresos frm = new frm_view_ingresos(UsuarioLogeado);
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
            frm.Show();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            xfrmMovimientoStock frm = new xfrmMovimientoStock();
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

        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            frmLecturas frm = new frmLecturas(UsuarioLogeado);
            frm.Show();
        }
    }
}
