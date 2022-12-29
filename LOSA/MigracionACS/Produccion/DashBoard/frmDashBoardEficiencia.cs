using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraCharts;
using LOSA.Clases;
using LOSA.MigracionACS.Produccion.DashBoard;

namespace LOSA.MigracionACS.Produccion.Produccion.DashBoard
{
    public partial class frmDashBoardEficiencia : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DateTime Hasta;
        DateTime Desde;
        Double vDias;
        decimal vHorasParo;
        decimal vHorasDis;
        decimal vHorasMotor;
        public bool CerrarForm;

        public frmDashBoardEficiencia(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            ValidatePermisos();
            dtDesde.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            dtHasta.EditValue = DateTime.Now;
        }


        private void ValidatePermisos()
        {
            bool AccesoPrevio = false;
            if (UsuarioLogeado.ValidarNivelPermisos(45))
            {
                //btnc_VerifyReach.Enabled = true;
                AccesoPrevio = true;
            }

            //Validar si cuenta con un permiso temporal para acceder
            if (UsuarioLogeado.ValidarNivelPermisosTemporal(45))
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
                CajaDialogo.Error("No tiene privilegios para esta función! El permiso requerido es #45");
            }
            else
            {

            }
        }

        private void Turno_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        //Lista de fallas por tipo.
        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_datos_tipo_causa_dashboard_eficiencia", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechaini", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@fechafin", dtHasta.EditValue);
                cmd.Parameters.AddWithValue("@filtro_maquina", barEditMaquinas.EditValue);
                cmd.Parameters.AddWithValue("@filtro_turno", Turno.EditValue);
                dsDashBoard1.Extru_1.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsDashBoard1.Extru_1);

                con.Close();
                int filtromaquina_ = Convert.ToInt32(barEditMaquinas.EditValue);
                LoadDetalleHoras(filtromaquina_);
                Load_Totales(filtromaquina_);
                Load_Totales_Group(filtromaquina_);

                if (dsDashBoard1 != null)
                {
                    if (dsDashBoard1.Extru_1 != null)
                    {
                        try
                        {
                            //decimal sum = Convert.ToDecimal(dsDashBoard1.Extru_1.Compute("SUM(horaint)", string.Empty));
                            //lblTotalCausas.Text = "Total " + string.Format("{0:##,##0.00}", sum) + " horas";
                            decimal sum = 0;
                            foreach (dsDashBoard.Extru_1Row row in dsDashBoard1.Extru_1.Rows)
                            {
                                //decimal sum = Convert.ToDecimal(dsDashBoard1.Extru_1.Compute("SUM(horaint)", string.Empty));
                                row.hora_s = Get_HoraFrom_Decimal(row.horaint);
                                sum += row.horaint;
                            }
                            lblTotalCausas.Visible = true;
                            lblTotalCausas.Text = "Total " + Get_HoraFrom_Decimal(sum) + " horas de paro";
                            if (con.State == ConnectionState.Closed)
                                con.Open();

                            SqlCommand cmd1 = new SqlCommand("sp_get_total_horas_trabajadas_dashboard_eficiencia", con);
                            cmd1.CommandType = CommandType.StoredProcedure;
                            cmd1.Parameters.AddWithValue("@fechaini", dtDesde.EditValue);
                            cmd1.Parameters.AddWithValue("@fechafin", dtHasta.EditValue);
                            cmd1.Parameters.AddWithValue("@filtro_maquina", barEditMaquinas.EditValue);
                            cmd1.Parameters.AddWithValue("@filtro_turno", Turno.EditValue);
                            vHorasMotor = Convert.ToDecimal(cmd1.ExecuteScalar());
                            string hora = Get_HoraFrom_Decimal(vHorasMotor);

                            lblTotalHoras.Text = hora + " Horas Motor";

                            SqlConnection conAPMS = new SqlConnection(dp.ConnectionStringAPMS);
                            conAPMS.Open();
                            SqlCommand cmd2 = new SqlCommand("sp_get_detalle_horas_disponibles", conAPMS);
                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.AddWithValue("@fechai", dtDesde.EditValue);
                            cmd2.Parameters.AddWithValue("@fechaf", dtHasta.EditValue);
                            cmd2.Parameters.AddWithValue("@filtro_maquina", barEditMaquinas.EditValue);
                            cmd2.Parameters.AddWithValue("@filtro_turno", Turno.EditValue);
                            vHorasDis = Convert.ToDecimal(cmd2.ExecuteScalar());
                            string hora2 = Get_HoraFrom_Decimal(vHorasDis);
                            conAPMS.Close();

                            //vDias = (Convert.ToDateTime(dtDesde.EditValue) - Convert.ToDateTime(dtDesde.EditValue));
                            var fecharegistro = Convert.ToDateTime(dtDesde.EditValue);
                            var timeSpan = Convert.ToDateTime(dtHasta.EditValue) - fecharegistro;

                            vDias = timeSpan.TotalHours;

                            lblHorasDisponibles.Text = hora2 + " Horas Disp.";


                        }
                        catch (Exception ec)
                        {
                            Console.WriteLine(ec.Message);
                        }
                    }
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }



        public string Get_HoraFrom_Decimal(decimal pHoraDecimal)
        {
            string hora = "";
            int h1 = 0;
            int m1 = 0;

            h1 = Convert.ToInt32(Math.Truncate(pHoraDecimal));
            m1 = Convert.ToInt32((pHoraDecimal - h1) * 60);




            string H = h1.ToString();
            string M = m1.ToString();

            if (H.Length < 2)
                H = "0" + H;

            if (M.Length < 2)
                M = "0" + M;

            hora = H + ":" + M;


            return hora;
        }



        //Grafico de Barras por turnos y maquinas.
        public void Load_Totales_Group(int filtroMaquina)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_detalle_tm_producidas_x_turno_group", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_i", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
                cmd.Parameters.AddWithValue("@filtro_maquina", barEditMaquinas.EditValue);
                cmd.Parameters.AddWithValue("@id_turno",Turno.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsDashBoard1.turnos_group.Clear();
                adat.Fill(dsDashBoard1.turnos_group);

                cn.Close();
                if (dsDashBoard1 != null)
                {
                    if (dsDashBoard1.turnos_group != null)
                    {
                        try
                        {
                            decimal sum = Convert.ToDecimal(dsDashBoard1.turnos_group.Compute("SUM(tm)", string.Empty));
                            lblTotalPorTurnoGroup.Text = "Total " + string.Format("{0:##,##0.00}", sum) + " TM";
                        }
                        catch { }
                    }
                }

                SqlConnection cn2 = new SqlConnection(dp.ConnectionStringCostos);
                cn2.Open();
                SqlCommand cmd2 = new SqlCommand("sp_get_detalle_tm_producidas_x_turno_group_sum_maquina", cn2);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@fecha_i", dtDesde.EditValue);
                cmd2.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
                cmd2.Parameters.AddWithValue("@filtro_maquina", barEditMaquinas.EditValue);
                cmd2.Parameters.AddWithValue("@id_turno", Turno.EditValue);
                SqlDataReader dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.GetInt32(1) == 3)
                    {
                        lblExtruder.Text ="Extruder "+  string.Format("{0:##,##0.00 TM}", dr.GetDecimal(2));
                    }
                    if (dr.GetInt32(1) == 2)
                    {
                        lblPellet2.Text = "Pellet 2:  " + string.Format("{0:##,##0.00 TM}", dr.GetDecimal(2));
                    }
                    if (dr.GetInt32(1) == 1)
                    {
                        lblPellet1.Text = "Pellet 1:  " + string.Format("{0:##,##0.00 TM}", dr.GetDecimal(2));
                    }
                }
                dr.Close();
                cn2.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void barEditMaquinas_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtHasta_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
            Hasta = Convert.ToDateTime(dtDesde.EditValue);
        }

        private void dtDesde_EditValueChanged_1(object sender, EventArgs e)
        {
            if (dtHasta.EditValue != null)
            {
                LoadData();
                Desde = Convert.ToDateTime(dtDesde.EditValue);
            }
        }

        
        //Grafico de pastel
        public void Load_Totales(int filtroMaquina)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_detalle_tm_producidas_x_turno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_i", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
                //cmd.Parameters.Add("@filtro_maquina", SqlDbType.Int).Value = filtroMaquina;
                cmd.Parameters.AddWithValue("@filtro_maquina", barEditMaquinas.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsDashBoard1.turnos.Clear();
                adat.Fill(dsDashBoard1.turnos);
                cn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        void LoadDetalleHoras(int filtro_maquina)
        {
            //try
            //{
            //    DataOperations dp = new DataOperations();
            //    SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            //    cn.Open();
            //    SqlCommand cmd = new SqlCommand("sp_get_resumen_horas_efectivas_on_y_paro_v2", cn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@fecha_i", dtDesde.EditValue);
            //    cmd.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
            //    cmd.Parameters.AddWithValue("@filtro_maquina", barEditMaquinas.EditValue);
            //    //cmd.Parameters.Add("@filtro_maquina", SqlDbType.Int).Value = filtro_maquina;
            //    SqlDataAdapter adat = new SqlDataAdapter(cmd);
            //    dsDashBoard1.header_causes.Clear();
            //    adat.Fill(dsDashBoard1.header_causes);
            //    cn.Close();
            //}
            //catch (Exception ec)
            //{
            //    CajaDialogo.Error(ec.Message);
            //}
        }

        private void btnver3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //CajaDialogo.Information("Disculpas por los inconvenientes, aun esta en construccion esta opción...");
            //return;

            try
            {
                var gridview = (GridView)grd_extru.FocusedView;
                var row = (dsDashBoard.Extru_1Row)gridview.GetFocusedDataRow();

                PRB_Causas_de_paro data = new PRB_Causas_de_paro(Convert.ToDateTime(dtDesde.EditValue),
                                                                 Convert.ToDateTime(dtHasta.EditValue),
                                                                 row.id,
                                                                 Convert.ToInt32(barEditMaquinas.EditValue)// row.id_maquina,//id maquina 
                                                                ,Convert.ToInt32(Turno.EditValue));
                if (data.ShowDialog() == DialogResult.OK)
                {

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEficiencia frm = new frmEficiencia(Convert.ToDateTime(dtDesde.EditValue),
                                                  Convert.ToDateTime(dtHasta.EditValue),
                                                  Convert.ToInt32(barEditMaquinas.EditValue),
                                                  Convert.ToInt32(Turno.EditValue));
            frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmReprocesoDashboard
            frmReprocesoDashboard frm = new frmReprocesoDashboard(Convert.ToDateTime(dtDesde.EditValue),
                                                                  Convert.ToDateTime(dtHasta.EditValue),
                                                                  Convert.ToInt32(barEditMaquinas.EditValue),
                                                                  Convert.ToInt32(Turno.EditValue));
            frm.Show();
        }

        private void btnCuadroLotes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Ver cuadro de lotes
            frmCuadroLotes frm = new frmCuadroLotes(Convert.ToDateTime(dtDesde.EditValue),
                                                                  Convert.ToDateTime(dtHasta.EditValue),
                                                                  Convert.ToInt32(barEditMaquinas.EditValue),
                                                                  Convert.ToInt32(Turno.EditValue));
            frm.Show();
        }

        private void cmdResumenBromatologia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmResumenBrom frm = new frmResumenBrom(Convert.ToDateTime(dtDesde.EditValue),
                                                                  Convert.ToDateTime(dtHasta.EditValue),
                                                                  Convert.ToInt32(barEditMaquinas.EditValue),
                                                                  Convert.ToInt32(Turno.EditValue));
            //frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void grdv_extru_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                pMenuExportExcelCausasParo.ShowPopup(Cursor.Position);
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                grd_extru.ExportToXlsx(dialog.FileName);
        }
    }
} 