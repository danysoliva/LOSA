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
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.MigracionACS.Finanzas.Inventarios
{
    public partial class frmReportManager : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        public frmReportManager(UserLogin pUserLogin )
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;

            cargar_reportes();
            
        }

        private void cargar_reportes()
        {
            string query = @"sp_load_lista_report_manager";
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dSRPT1.report_manager.Clear();
                adat.Fill(dSRPT1.report_manager);
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            gridView1.Columns.Clear();

            if (grdSelectReport.EditValue == null)
            {
                CajaDialogo.Error("Seleccione un Reporte!");
                return;
            }

            if (string.IsNullOrEmpty(dtDesde.Text))
            {
                CajaDialogo.Error("Debe Seleccionar una Fecha");
                dtDesde.Focus();
                return;
            }

            if (string.IsNullOrEmpty(dtHasta.Text))
            {
                CajaDialogo.Error("Debe Seleccionar una Fecha");
                dtHasta.Focus();
                return;
            }
            string query = "";
            switch (grdSelectReport.EditValue)
            {
                case 1:

                    query = @"sp_report_manager_reporte_dmc";

                    break;
                case 2:

                    query = @"sp_report_manager_oc_detalle_rubros_capitulos";
    
                    break;
                case 3:

                    query = @"[sp_reporte_de_gastos_integraciones]";
                    break;

                default:
                    break;

            }

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                DataTable tabla = new DataTable();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(tabla);
                grdReporte.DataSource = tabla;
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdReporte.ExportToXlsx(dialog.FileName);
            }
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

            switch (grdSelectReport.EditValue)
            {
                case 1: //Reporte DMC

                    switch (UsuarioLogueado.GrupoUsuario.GrupoUsuarioActivo)
                    {
                        case GrupoUser.GrupoUsuario.Logistica:
                            int idnivel = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);

                            switch (idnivel)
                            {
                                case 1://Basic View
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 2://Basic No Autorization
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 3://Medium Autorization
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 4://Depth With Delta
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 5://Depth Without Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                default:
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                            }

                            break;
                        case GrupoUser.GrupoUsuario.Administradores:
                            idnivel = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);

                            switch (idnivel)
                            {
                                case 1://Basic View
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    grdSelectReport.Text = null;
                                    break;
                                case 2://Basic No Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 3://Medium Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 4://Depth With Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 5://Depth Without Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                default:
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                            }
                            break;
                        case GrupoUser.GrupoUsuario.Contabilidad:
                            idnivel = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);

                            switch (idnivel)
                            {
                                case 1://Basic View
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 2://Basic No Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 3://Medium Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 4://Depth With Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 5://Depth Without Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                default:
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                            }
                            break;
                        default:
                            break;
                    }

                    break;



                case 2: //Reporte de Ordenes de Compra por Detalle de Rubro y Capitulo
                    switch (UsuarioLogueado.GrupoUsuario.GrupoUsuarioActivo)
                    {
                        case GrupoUser.GrupoUsuario.Logistica:
                            int idnivel = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);

                            switch (idnivel)
                            {
                                case 1://Basic View
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 2://Basic No Autorization
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 3://Medium Autorization
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 4://Depth With Delta
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 5://Depth Without Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                default:
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                            }

                            break;
                        case GrupoUser.GrupoUsuario.Administradores:
                            idnivel = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);

                            switch (idnivel)
                            {
                                case 1://Basic View
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    grdSelectReport.Text = null;
                                    break;
                                case 2://Basic No Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 3://Medium Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 4://Depth With Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 5://Depth Without Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                default:
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                            }
                            break;
                        case GrupoUser.GrupoUsuario.Contabilidad:
                            idnivel = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);

                            switch (idnivel)
                            {
                                case 1://Basic View
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 2://Basic No Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 3://Medium Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 4://Depth With Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 5://Depth Without Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                default:
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                            }
                            break;
                        default:
                            break;
                    }

                    break;
                default:
                    break;
            }

            
        }
    }
}