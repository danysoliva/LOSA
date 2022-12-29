using ACS.Classes;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using LOSA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MigracionACS.Produccion.BannerTV
{
    public partial class frmBannerMainTV_PRD : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public bool CerrarForm;
        DataOperations dp;
        public frmBannerMainTV_PRD(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            dp = new DataOperations();
            DateTime Now = dp.Now();
            lblFechaHora.Text = Now.DayOfWeek + " " + string.Format("{0:dd/MMMM/yyyy HH:mm}", Now);
            ValidatePermisos();
        }


        private void ValidatePermisos()
        {
            bool AccesoPrevio = false;
            if (UsuarioLogeado.ValidarNivelPermisos(68))
            {
                //btnc_VerifyReach.Enabled = true;
                AccesoPrevio = true;
            }

            //Validar si cuenta con un permiso temporal para acceder
            if (UsuarioLogeado.ValidarNivelPermisosTemporal(68))
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
                CajaDialogo.Error("No tiene privilegios para esta función! El permiso requerido es #68");
            }
            else
            {
                Load_TM_Producidas();
                Load_TM_EficienciaPorLineaY_Turno();
                timerNextPage.Enabled = true;
                timerNextPage.Start();
                timerFechaHora.Enabled = true;
                timerFechaHora.Start();

                //Cargar Imagenes en los tabs.
                //skip 2
                try
                {

                    SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_get_bannertv_list_tabs", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                    dsBanner1.bannerhome.Clear();
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    adat.Fill(dsBanner1.bannerhome);

                    foreach (dsBanner.bannerhomeRow row in dsBanner1.bannerhome.Rows)
                    {
                        if (row.use_image)
                        {
                            if (row.Path != null)
                            {
                                if (!string.IsNullOrEmpty(row.Path))
                                {
                                    switch (row.id_tab)
                                    {
                                        case 0:
                                            pictureBox1.Image = ByteToImage(GetImgByte(row.Path));
                                            break;
                                        case 2:
                                            pictureBox3.Image = ByteToImage(GetImgByte(row.Path));
                                            break;
                                        case 3:
                                            pictureBox4.Image = ByteToImage(GetImgByte(row.Path));
                                            break;
                                        case 4:
                                            pictureBox5.Image = ByteToImage(GetImgByte(row.Path));
                                            break;
                                        case 5:
                                            break;
                                        default:
                                            break;

                                    }

                                    //Loading();
                                    //ObtenerCantidadImagenes();
                                    //row_id_muestra_actual = MuestrasRepuesto_list.Find(x => x.ID == id_muestra).RowNumber;
                                }
                            }
                        }
                    }

                }
                catch (Exception EX)
                {
                    CajaDialogo.Error(EX.Message);
                }
            }
        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

       

        //Grafico de pastel
        public void Load_TM_Producidas()
        {
            try
            {
                //Primero, a partir de la fecha seleccionada toma el mes, y descarta el año puesto que según decías va a ser el año que tú especifiques.
                int mes = DateTime.Now.Month;
                int año = DateTime.Now.Year;
                //Obtener el primer dia del mes, sabiendo el mes y el año, es muy fácil:
                DateTime primerDia = new DateTime(año, mes, 1);
                //Para obtener el último día del mes, puedes recurrir al truco de sumar 1 mes y restar 1 día:
                DateTime ultimoDia = primerDia.AddMonths(1).AddDays(-1);

                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_detalle_tm_producidas_x_turno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_i", primerDia);
                cmd.Parameters.AddWithValue("@fecha_f", ultimoDia);
                //cmd.Parameters.Add("@filtro_maquina", SqlDbType.Int).Value = filtroMaquina;
                cmd.Parameters.AddWithValue("@filtro_maquina", 5);
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

        public void Load_TM_EficienciaPorLineaY_Turno()
        {
            try
            {
                //Primero, a partir de la fecha seleccionada toma el mes, y descarta el año puesto que según decías va a ser el año que tú especifiques.
                int mes = DateTime.Now.Month;
                int año = DateTime.Now.Year;
                //Obtener el primer dia del mes, sabiendo el mes y el año, es muy fácil:
                DateTime primerDia = new DateTime(año, mes, 1);
                //Para obtener el último día del mes, puedes recurrir al truco de sumar 1 mes y restar 1 día:
                DateTime ultimoDia = primerDia.AddMonths(1).AddDays(-1);

                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_detalle_tm_producidas_x_turno_group", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_i", primerDia);
                cmd.Parameters.AddWithValue("@fecha_f", ultimoDia);
                cmd.Parameters.AddWithValue("@filtro_maquina", 5);
                cmd.Parameters.AddWithValue("@id_turno", 1);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsDashBoard1.turnos_group1.Clear();
                adat.Fill(dsDashBoard1.turnos_group1);

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fecha_i", primerDia);
                cmd.Parameters.AddWithValue("@fecha_f", ultimoDia);
                cmd.Parameters.AddWithValue("@filtro_maquina", 5);
                cmd.Parameters.AddWithValue("@id_turno", 2);
                dsDashBoard1.turnos_group2.Clear();
                adat.Fill(dsDashBoard1.turnos_group2);

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fecha_i", primerDia);
                cmd.Parameters.AddWithValue("@fecha_f", ultimoDia);
                cmd.Parameters.AddWithValue("@filtro_maquina", 5);
                cmd.Parameters.AddWithValue("@id_turno", 3);
                dsDashBoard1.turnos_group3.Clear();
                adat.Fill(dsDashBoard1.turnos_group3);

                cn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void timerNextPage_Tick(object sender, EventArgs e)
        {
            SetPageVisible();

        }

        private void SetPageVisible()
        {
            BannerTV_Tab BannerSiguiente = new BannerTV_Tab();
            int IdNextTab = -1;
            switch (navigationFrame1.SelectedPage.Caption)
            {
                case "navigationPage1"://ID = 1
                    if (BannerSiguiente.RecuperarRegistro(0))
                    {
                        IdNextTab = BannerSiguiente.IdNextTab;
                        timerNextPage.Interval = BannerSiguiente.Interval * 1000;
                    }
                    //navigationFrame1.SelectedPage = navigationPage2;
                    break;
                case "navigationPage2"://ID = 2
                    if (BannerSiguiente.RecuperarRegistro(1))
                    {
                        IdNextTab = BannerSiguiente.IdNextTab;
                        timerNextPage.Interval = BannerSiguiente.Interval * 1000;
                    }
                    //navigationFrame1.SelectedPage = navigationPage4;
                    break;
                case "navigationPage4"://ID = 3
                    //navigationFrame1.SelectedPage = navigationPage5;
                    if (BannerSiguiente.RecuperarRegistro(2)) { 
                        IdNextTab = BannerSiguiente.IdNextTab;
                        timerNextPage.Interval = BannerSiguiente.Interval * 1000;
                    }
                    break;
                case "navigationPage5"://ID = 4
                    if (BannerSiguiente.RecuperarRegistro(3)) { 
                        IdNextTab = BannerSiguiente.IdNextTab;
                        timerNextPage.Interval = BannerSiguiente.Interval * 1000;
                    }
                    //navigationFrame1.SelectedPage = navigationPage6;
                    break;
                case "navigationPage6"://ID = 5
                    if (BannerSiguiente.RecuperarRegistro(4)) { 
                        IdNextTab = BannerSiguiente.IdNextTab;
                        timerNextPage.Interval = BannerSiguiente.Interval * 1000;
                    }
                    //navigationFrame1.SelectedPage = navigationPage7;
                    break;
                case "navigationPage7"://ID = 6
                    if (BannerSiguiente.RecuperarRegistro(5)) { 
                        IdNextTab = BannerSiguiente.IdNextTab;
                        timerNextPage.Interval = BannerSiguiente.Interval * 1000;
                    }
                    //navigationFrame1.SelectedPage = navigationPage8;
                    break;
                case "navigationPage8"://ID = 7
                    if (BannerSiguiente.RecuperarRegistro(6)) { 
                        IdNextTab = BannerSiguiente.IdNextTab;
                        timerNextPage.Interval = BannerSiguiente.Interval * 1000;
                    }
                    //navigationFrame1.SelectedPage = navigationPage9;
                    break;
                case "navigationPage9"://ID = 8
                    if (BannerSiguiente.RecuperarRegistro(7)) { 
                        IdNextTab = BannerSiguiente.IdNextTab;
                        timerNextPage.Interval = BannerSiguiente.Interval * 1000;
                    }
                    //navigationFrame1.SelectedPage = navigationPage10;
                    break;
                case "navigationPage10"://ID = 9
                    if (BannerSiguiente.RecuperarRegistro(8)) { 
                        IdNextTab = BannerSiguiente.IdNextTab;
                        timerNextPage.Interval = BannerSiguiente.Interval * 1000;
                    }
                    //navigationFrame1.SelectedPage = navigationPage11;
                    break;
                case "navigationPage11"://ID = 10
                    if (BannerSiguiente.RecuperarRegistro(9)) { 
                        IdNextTab = BannerSiguiente.IdNextTab;
                        timerNextPage.Interval = BannerSiguiente.Interval * 1000;
                    }
                    //navigationFrame1.SelectedPage = navigationPage1;
                    break;
                case "navigationPage12"://ID = 11
                    if (BannerSiguiente.RecuperarRegistro(10))
                    {
                        IdNextTab = BannerSiguiente.IdNextTab;
                        timerNextPage.Interval = BannerSiguiente.Interval * 1000;
                    }
                    //navigationFrame1.SelectedPage = navigationPage1;
                    break;
                case "navigationPage13"://ID = 12
                    if (BannerSiguiente.RecuperarRegistro(11))
                    {
                        IdNextTab = BannerSiguiente.IdNextTab;
                        timerNextPage.Interval = BannerSiguiente.Interval * 1000;
                    }
                    //navigationFrame1.SelectedPage = navigationPage1;
                    break;
                case "navigationPage14"://ID = 13
                    if (BannerSiguiente.RecuperarRegistro(12))
                    {
                        IdNextTab = BannerSiguiente.IdNextTab;
                        timerNextPage.Interval = BannerSiguiente.Interval * 1000;
                    }
                    //navigationFrame1.SelectedPage = navigationPage1;
                    break;
                default:
                    break;
            }

            switch (IdNextTab)
            {
                case 0:
                    navigationFrame1.SelectedPage = navigationPage1;
                    break;
                case 1:
                    navigationFrame1.SelectedPage = navigationPage2;
                    break;
                case 2:
                    navigationFrame1.SelectedPage = navigationPage4;
                    break;
                case 3:
                    navigationFrame1.SelectedPage = navigationPage5;
                    break;
                case 4:
                    navigationFrame1.SelectedPage = navigationPage6;
                    break;
                case 5:
                    navigationFrame1.SelectedPage = navigationPage7;
                    break;
                case 6:
                    navigationFrame1.SelectedPage = navigationPage8;
                    break;
                case 7:
                    navigationFrame1.SelectedPage = navigationPage9;
                    break;
                case 8:
                    navigationFrame1.SelectedPage = navigationPage10;
                    break;
                case 9:
                    navigationFrame1.SelectedPage = navigationPage11;
                    break;
                case 10:
                    navigationFrame1.SelectedPage = navigationPage12;
                    break;
                case 11:
                    navigationFrame1.SelectedPage = navigationPage13;
                    break;
                case 12:
                    navigationFrame1.SelectedPage = navigationPage14;
                    break;
                default:
                    break;
            }
        }

        private void timerRefreshData_Tick(object sender, EventArgs e)
        {
            //switch (navigationFrame1.SelectedPageIndex)
            //{
            //    case 0://navigationPage1
            //        Load_TM_Producidas();
            //        break;
            //    case 11://navigationPage2

            //        break;
            //    default://Si hay un problema de index

            //        break;
            //}
            Load_TM_Producidas();
            Load_TM_EficienciaPorLineaY_Turno();
        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();
            DateTime Now = dp.Now();
            lblFechaHora.Text = string.Format("{0:dd/MMMM/yyyy HH:mm}", Now);
        }
        public byte[] GetImgByte(string ftpFilePath)
        {
            DataOperations dp = new DataOperations();


            WebClient ftpClient = new WebClient();
            //ftpClient.Credentials = new NetworkCredential(UsuarioLogeado.AD_User, UsuarioLogeado.Password);
            ftpClient.Credentials = new NetworkCredential("operador", "Tempo1234");

            byte[] imageByte = ftpClient.DownloadData(ftpFilePath);
            return imageByte;
        }










    }
}