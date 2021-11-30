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

namespace LOSA.Produccion
{
    public partial class xfrmCheckActiveBin : DevExpress.XtraEditors.XtraForm
    //public partial class xfrmCheckActiveBin 

    {
        int id_active_tank;
        public xfrmCheckActiveBin()
        {
            InitializeComponent();
            id_active_tank = GetBinActivo();
        }

        private int GetBinActivo()
        {
            try
            {
            DataOperations dp = new DataOperations();
                int id_tank = 0;

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("dbo.sp_get_bin_activo",cnx);
                    cmd.CommandType = CommandType.StoredProcedure;

                    id_tank = Convert.ToInt32(cmd.ExecuteScalar());

                    cnx.Close();
                }
                return id_tank;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return 0;
            }
        }

        private void xfrmCheckActiveBin_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32( pcTank1.Tag.ToString())==id_active_tank)
            {
                pcTank1.BackColor = Color.Lime;
                lblBIN.Text = "FD" + id_active_tank;
            }

            if (Convert.ToInt32( pcTank2.Tag.ToString())==id_active_tank)
            {
                pcTank2.BackColor = Color.Lime;
                lblBIN.Text = "FD" + id_active_tank;
            }

            if (Convert.ToInt32( pcTank3.Tag.ToString())==id_active_tank)
            {
                pcTank3.BackColor = Color.Lime;
                lblBIN.Text = "FD" + id_active_tank;
            }

            if (Convert.ToInt32( pcTank4.Tag.ToString())==id_active_tank)
            {
                pcTank4.BackColor = Color.Lime;
                lblBIN.Text = "FD" + id_active_tank;
            }

            if (Convert.ToInt32( pcTank5.Tag.ToString())==id_active_tank)
            {
                pcTank5.BackColor = Color.Lime;
                lblBIN.Text = "FD" + id_active_tank;
            }
            if (Convert.ToInt32( pcTank6.Tag.ToString())==id_active_tank)
            {
                pcTank6.BackColor = Color.Lime;
                lblBIN.Text = "FD" + id_active_tank;
            }
            if (Convert.ToInt32( pcTank7.Tag.ToString())==id_active_tank)
            {
                pcTank7.BackColor = Color.Lime;
                lblBIN.Text = "FD" + id_active_tank;
            }

            if (Convert.ToInt32( pcTank8.Tag.ToString())==id_active_tank)
            {
                pcTank8.BackColor = Color.Lime;
                lblBIN.Text = "FD" + id_active_tank;
            }

            if (Convert.ToInt32( pcTank9.Tag.ToString())==id_active_tank)
            {
                pcTank9.BackColor = Color.Lime;
                lblBIN.Text = "FD" + id_active_tank;
            }

            if (Convert.ToInt32( pcTank10.Tag.ToString())==id_active_tank)
            {
                pcTank10.BackColor = Color.Lime;
                lblBIN.Text = "FD" + id_active_tank;
            }

            if (Convert.ToInt32( pcTank11.Tag.ToString())==id_active_tank)
            {
                pcTank11.BackColor = Color.Lime;
                lblBIN.Text = "FD" + id_active_tank;
            }

            if (Convert.ToInt32( pcTank12.Tag.ToString())==id_active_tank)
            {
                pcTank12.BackColor = Color.Lime;
                lblBIN.Text = "FD" + id_active_tank;
            }

        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}