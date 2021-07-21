using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace LOSA.MicroIngredientes
{
    public partial class frmSelectLotePesaje : DevExpress.XtraEditors.XtraForm
    {
        int IdMP = 0;
        public frmSelectLotePesaje(int pIdmp)
        {
            InitializeComponent();
            IdMP = pIdmp;
            LoadLotes();
        }


        private void LoadLotes()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_lotes_micro_ingredientes_select]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idmp", IdMP);
                dsMicro1.lotes_seleccion.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMicro1.lotes_seleccion);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


    }
}