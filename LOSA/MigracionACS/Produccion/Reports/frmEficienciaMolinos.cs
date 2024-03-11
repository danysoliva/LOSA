using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
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

namespace LOSA.MigracionACS.Produccion.Reports
{
    public partial class frmEficienciaMolinos : DevExpress.XtraEditors.XtraForm
    {
        public bool CerrarForm;
        UserLogin UsuarioLogeado;
        public frmEficienciaMolinos(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            
            if (UsuarioLogeado.GrupoUsuario.GrupoUsuarioActivo == GrupoUser.GrupoUsuario.Administradores)
                txtSupporIT_WindowName.Visible = txtSupporIT_WindowName.ReadOnly = true;
            else
                txtSupporIT_WindowName.Visible = false;

            DataOperations dp = new DataOperations();
            dtDesde.EditValue = dp.Now().AddDays(-3);
            dtHasta.EditValue = dp.Now();
            ValidatePermisos();
        }


        private void ValidatePermisos()
        {
            bool AccesoPrevio = false;
            if (UsuarioLogeado.ValidarNivelPermisos(61))
            {
                //btnc_VerifyReach.Enabled = true;
                AccesoPrevio = true;
            }

            //Validar si cuenta con un permiso temporal para acceder
            if (UsuarioLogeado.ValidarNivelPermisosTemporal(61))
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
                CajaDialogo.Error("No tiene privilegios para esta función! El permiso requerido es #61");
            }
            else
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridDetalleReq.ExportToXlsx(dialog.FileName);
                //Impresion().ExportToXlsx(dialog.FileName);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dtDesde_EditValueChanged(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void dtHasta_EditValueChanged(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void LoadDatos()
        {
            if (dtDesde.EditValue == null || dtHasta.EditValue == null)
                return;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_eficiencia_simple_molinos_martillos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                dsEficienciaMolinos1.eficienciasimple.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsEficienciaMolinos1.eficienciasimple);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


    }
}