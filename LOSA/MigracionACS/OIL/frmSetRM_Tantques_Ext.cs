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

namespace LOSA.MigracionACS.OIL
{
    public partial class frmSetRM_Tantques_Ext : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp;
        int idRM_Ext1;
        int idRM_Ext2;
        int idRM_Ext3;
        UserLogin UsuarioLogeado;
        public bool CerrarForm;
        bool allowEdit;

        public frmSetRM_Tantques_Ext(UserLogin pUser)
        {
            InitializeComponent();
            dp = new DataOperations();
            UsuarioLogeado = pUser;
            allowEdit = true;
            ValidatePermisos();
        }


        private void ValidatePermisos()
        {
            bool AccesoPrevio = false;
            if (UsuarioLogeado.ValidarNivelPermisos(8))
            {
                //btnc_VerifyReach.Enabled = true;
                AccesoPrevio = true;
            }

            //Validar si cuenta con un permiso temporal para acceder
            if (UsuarioLogeado.ValidarNivelPermisosTemporal(8))
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
                        allowEdit = false;
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
                CajaDialogo.Error("No tiene privilegios para esta función! El permiso requerido es #8");
            }
            else
            {
                CargarMateriales();
            }
        }

        void CargarMateriales() 
        {
            idRM_Ext1 = GetMaterialIdBin(88);
            idRM_Ext2 = GetMaterialIdBin(90);
            idRM_Ext3 = GetMaterialIdBin(91);

            lblNombreTanque1.Text = GetMaterialName(idRM_Ext1);
            lblNombreTanque2.Text = GetMaterialName(idRM_Ext2);
            lblNombreTanque3.Text = GetMaterialName(idRM_Ext3);
        }

        public int GetMaterialIdBin(int pIdBin)
        {
            int idRM = 0;
            try
            {
                string sql = @"SELECT [set_rm_id]
                               FROM [dbo].[MD_Bins]
                               where id = " + pIdBin;
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                idRM = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return idRM;
        }
        public string GetMaterialName(int pIdRM)
        {
            string RM = "";
            try
            {
                string sql = @"SELECT short_name
                               FROM [dbo].[MD_Raw_Material]
                               where id = " + pIdRM;
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                RM = cmd.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return RM;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            xSeleccionRM.ProQuery = @"SELECT [id]
                                            ,[long_name]as descripcion
                                      FROM [dbo].[MD_Raw_Material]
                                      where material_group = 3 and
                                            status = 40
                                      order by long_name asc";
            SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);

            try
            {
                conn.Open();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            xSeleccionRM.ProConnection = conn;
            xSeleccionRM.ProIndex = 1;
            xSeleccionRM.LoadData();
            conn.Close();
            flyoutPanelCambiarRM.ShowPopup();
        }

        private void xSeleccionRM_OnItemSeleccionado(object sender, EventArgs e)
        {
            if (allowEdit)
            {
                try
                {
                    int Bin_ID;
                    switch (xSeleccionRM.ProIndex)
                    {
                        case 1:
                            Bin_ID = 88;
                            break;
                        case 2:
                            Bin_ID = 90;
                            break;
                        case 3:
                            Bin_ID = 91;
                            break;
                        default:
                            Bin_ID = 0;
                            break;
                    }

                    string sql = @"UPDATE [dbo].[MD_Bins]
                                   SET [set_rm_id] = " + xSeleccionRM.ProIdSeleccionado.ToString() +
                                   " WHERE id = " + Bin_ID.ToString();
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    CargarMateriales();
                    flyoutPanelCambiarRM.HidePopup();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
            else
            {
                CajaDialogo.Error("No tiene privilegios para esta función! El permiso requerido es #8");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            xSeleccionRM.ProQuery = @"SELECT [id]
                                            ,[long_name]as descripcion
                                      FROM [dbo].[MD_Raw_Material]
                                      where material_group = 3 and
                                            status = 40
                                      order by long_name asc";
            SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);

            try
            {
                conn.Open();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            xSeleccionRM.ProConnection = conn;
            xSeleccionRM.ProIndex = 2;
            xSeleccionRM.LoadData();
            conn.Close();
            flyoutPanelCambiarRM.ShowPopup();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            xSeleccionRM.ProQuery = @"SELECT [id]
                                            ,[long_name]as descripcion
                                      FROM [dbo].[MD_Raw_Material]
                                      where material_group = 3 and
                                            status = 40
                                      order by long_name asc";
            SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);

            try
            {
                conn.Open();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            xSeleccionRM.ProConnection = conn;
            xSeleccionRM.ProIndex = 3;
            xSeleccionRM.LoadData();
            conn.Close();
            flyoutPanelCambiarRM.ShowPopup();
        }









    }
}