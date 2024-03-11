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
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;

namespace LOSA.MigracionACS.OIL
{
    public partial class frm_report_oil_in_and_out : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public bool CerrarForm;
        UserLogin UsuarioLogeado;
        public frm_report_oil_in_and_out(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            dp = new DataOperations();
            dtDesde.EditValue = dp.Now().AddDays(-1);
            dtHasta.EditValue = dp.Now();
            UsuarioLogeado = pUsuarioLogeado;
        }

        private void ValidatePermisos()
        {
            bool AccesoPrevio = false;
            if (UsuarioLogeado.ValidarNivelPermisos(9))
            {
                //btnc_VerifyReach.Enabled = true;
                AccesoPrevio = true;
            }

            //Validar si cuenta con un permiso temporal para acceder
            if (UsuarioLogeado.ValidarNivelPermisosTemporal(9))
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
                        cmdExportar.Visible = false;
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
                CajaDialogo.Error("No tiene privilegios para esta función! El permiso requerido es #9");
            }
            else
            {

            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                grd_data.ExportToXlsx(dialog.FileName);
        }

        private void CargarDatos_Click(object sender, EventArgs e)
        {
            CargarDatoss();
        }
        public void CargarDatoss()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                conn.Open();

                string sql = @"sp_resumen_ultimate_aceites_v2";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 60000;
                cmd.Parameters.AddWithValue("@desde", string.Format("{0:MM/dd/yyyy HH:mm:ss}", dtDesde.EditValue));
                cmd.Parameters.AddWithValue("@hasta", string.Format("{0:MM/dd/yyyy HH:mm:ss}", dtHasta.EditValue));
                SqlDataAdapter adat = new SqlDataAdapter(cmd);

                dsAceites.oilmaster.Clear();
                adat.Fill(dsAceites.oilmaster);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}