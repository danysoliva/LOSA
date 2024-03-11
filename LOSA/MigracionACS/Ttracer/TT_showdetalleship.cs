using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;


namespace LOSA.MigracionACS.Ttracer
{
    public partial class TT_showdetalleship : Form
    {
        DataOperations dp = new DataOperations();
        int id;
        public TT_showdetalleship(int id)
        {
            InitializeComponent();
            this.id = id;
            load_details();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
        public void load_details()
        {
            string Query = @"SELECT  [id]
                                  ,[DocNum]
                                  ,[ItemCode]
                                  ,[ItemName]
                                  ,[CardCode]
                                  ,[Cardname]
                                  ,[date_create]
                                  ,[peso]
                                  ,[close]
                                  ,[DocEntry]
                                  ,[Linenum]
                                  ,[granel]
                                  ,[Comment]
                              FROM [dbo].[TS_ship_d]
                              where id_shiph = "+id+" and [close] = 0 and enable = 1";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dSTtracer.showdetalle.Clear();
                da.Fill(dSTtracer.showdetalle);
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
