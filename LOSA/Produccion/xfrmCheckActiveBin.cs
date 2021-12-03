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
        string label_tank;
        string mp;

        public xfrmCheckActiveBin()
        {
            InitializeComponent();
             GetBinActivo();
            UpdateActiveBin();
        }

        private void GetBinActivo()
        {
            try
            {
            DataOperations dp = new DataOperations();
                int id_tank = 0;

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("dbo.sp_get_bin_activoV2", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        id_active_tank = Convert.ToInt32(dr.GetInt32(0));
                        label_tank = dr.GetString(1);
                        mp = dr.GetString(2);
                    }


                    cnx.Close();
                }
                //return id_tank;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                //return 0;
            }
        }

        private void xfrmCheckActiveBin_Load(object sender, EventArgs e)
        {
            timer1.Enabled=true;
           

        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetBinActivo();
            UpdateActiveBin();
        }

        private void UpdateActiveBin()
        {
            lblMP1.Visible = false;
            lblMP2.Visible = false;
            lblMP3.Visible = false;
            lblMP4.Visible = false;
            lblMP5.Visible = false;
            lblMP6.Visible = false;
            lblMP7.Visible = false;
            lblMP8.Visible = false;
            lblMP9.Visible = false;
            lblMP10.Visible = false;
            lblMP11.Visible = false;
            lblMP12.Visible = false;

            pcTank1.BackColor = Color.Silver;
            pcTank2.BackColor = Color.Silver;
            pcTank3.BackColor = Color.Silver;
            pcTank5.BackColor = Color.Silver;
            pcTank4.BackColor = Color.Silver;
            pcTank6.BackColor = Color.Silver;
            pcTank7.BackColor = Color.Silver;
            pcTank8.BackColor = Color.Silver;
            pcTank9.BackColor = Color.Silver;
            pcTank10.BackColor = Color.Silver;
            pcTank11.BackColor = Color.Silver;
            pcTank12.BackColor = Color.Silver;


            if (Convert.ToInt32(pcTank1.Tag.ToString()) == id_active_tank)
            {
                pcTank1.BackColor = Color.Lime;
                lblBIN.Text = label_tank;
                lblMP1.Visible = true;
                lblMP1.Text = mp;
            }

            if (Convert.ToInt32(pcTank2.Tag.ToString()) == id_active_tank)
            {
                pcTank2.BackColor = Color.Lime;
                lblBIN.Text = label_tank;
                lblMP2.Visible = true;
                lblMP2.Text = mp;
            }

            if (Convert.ToInt32(pcTank3.Tag.ToString()) == id_active_tank)
            {
                pcTank3.BackColor = Color.Lime;
                lblBIN.Text = label_tank;
                lblMP3.Visible = true;
                lblMP3.Text = mp;
            }

            if (Convert.ToInt32(pcTank4.Tag.ToString()) == id_active_tank)
            {
                pcTank4.BackColor = Color.Lime;
                lblBIN.Text = label_tank;
                lblMP4.Visible = true;
                lblMP4.Text = mp;
            }

            if (Convert.ToInt32(pcTank5.Tag.ToString()) == id_active_tank)
            {
                pcTank5.BackColor = Color.Lime;
                lblBIN.Text = label_tank;
                lblMP5.Visible = true;
                lblMP5.Text = mp;
            }


            if (Convert.ToInt32(pcTank6.Tag.ToString()) == id_active_tank)
            {
                pcTank6.BackColor = Color.Lime;
                lblBIN.Text = label_tank;
                lblMP6.Visible = true;
                lblMP6.Text = mp;
            }
            if (Convert.ToInt32(pcTank7.Tag.ToString()) == id_active_tank)
            {
                pcTank7.BackColor = Color.Lime;
                lblBIN.Text = label_tank;
                lblMP7.Visible = true;
                lblMP7.Text = mp;
            }

            if (Convert.ToInt32(pcTank8.Tag.ToString()) == id_active_tank)
            {
                pcTank8.BackColor = Color.Lime;
                lblBIN.Text = label_tank;
                lblMP8.Visible = true;
                lblMP8.Text = mp;
            }

            if (Convert.ToInt32(pcTank9.Tag.ToString()) == id_active_tank)
            {
                pcTank9.BackColor = Color.Lime;
                lblBIN.Text = label_tank;
                lblMP9.Visible = true;
                lblMP9.Text = mp;
            }

            if (Convert.ToInt32(pcTank10.Tag.ToString()) == id_active_tank)
            {
                pcTank10.BackColor = Color.Lime;
                lblBIN.Text = label_tank;
                lblMP10.Visible = true;
                lblMP10.Text = mp;
            }

            if (Convert.ToInt32(pcTank11.Tag.ToString()) == id_active_tank)
            {
                pcTank11.BackColor = Color.Lime;
                lblBIN.Text = label_tank;
                lblMP11.Visible = true;
                lblMP11.Text = mp;
            }

            if (Convert.ToInt32(pcTank12.Tag.ToString()) == id_active_tank)
            {
                pcTank12.BackColor = Color.Lime;
                lblBIN.Text = label_tank;
                lblMP12.Visible = true;
                lblMP12.Text = mp;
            }
        }
    }
}