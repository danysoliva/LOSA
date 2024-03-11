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
using LOSA.Clases;

namespace LOSA.MigracionACS.Produccion.Reports
{
    public partial class frmReporteEnsacadora : DevExpress.XtraEditors.XtraForm
    {
        public bool CerrarForm;
        UserLogin UsuarioLogeado;
        public frmReporteEnsacadora(UserLogin puser)
        {
            InitializeComponent();
            UsuarioLogeado = puser;
            DataOperations dp = new DataOperations();
            dtDesde.EditValue = dp.Now().AddDays(-3);
            dtHasta.EditValue = dp.Now();
            ValidatePermisos();
        }


        private void ValidatePermisos()
        {
            bool AccesoPrevio = false;
            if (UsuarioLogeado.ValidarNivelPermisos(48))
            {
                //btnc_VerifyReach.Enabled = true;
                AccesoPrevio = true;
            }

            //Validar si cuenta con un permiso temporal para acceder
            if (UsuarioLogeado.ValidarNivelPermisosTemporal(48))
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
                CajaDialogo.Error("No tiene privilegios para esta función! El permiso requerido es #48");
            }
            else
            {
                //load_orders();
            }
        }

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();
                //dtDesde.EditValue = dp.Now().AddDays(-3);
                //dtHasta.EditValue = dp.Now();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_resumen_ensacadora_camaron", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                DataTable table1 = new DataTable();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(table1);
                grDetalle.DataSource = table1;

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grDetalle.ExportToXlsx(dialog.FileName);
                //Impresion().ExportToXlsx(dialog.FileName);
            }
        }
    }
}