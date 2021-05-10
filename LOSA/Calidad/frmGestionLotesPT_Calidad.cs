using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
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
using LOSA.Clases;

namespace LOSA.Calidad 
{
    public partial class frmGestionLotesPT_Calidad : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmGestionLotesPT_Calidad(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            LoadTarimasAvailables();
            LoadTarimasObs();
            LoadTarimasRet();
        }
        private void LoadTarimasRet()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tarimas_ret_calidad_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dsCalidad1.tarimas_ret.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCalidad1.tarimas_ret);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void LoadTarimasObs()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tarimas_obs_calidad_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dsCalidad1.tarimas_obs.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCalidad1.tarimas_obs);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void LoadTarimasAvailables()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tarimas_habilitadas_calidad_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dsCalidad1.tarimas_disponibles.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCalidad1.tarimas_disponibles);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}