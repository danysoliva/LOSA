using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MigracionACS
{
    public partial class HeadXmlLook : Form
    {
        DataSet dt;
        public HeadXmlLook(DataSet data)
        {
            InitializeComponent();
            dt = data;
            load_Head();
        }
        void load_Head()
        {
            try
            {
                foreach (DataRow row in dt.Tables["TransactionHeader"].Rows)
                {
                    textDname.Text = row["DatabaseName"].ToString();
                    textType.Text = row["MessageType"].ToString();
                    textVer.Text = row["MessageVersion"].ToString();
                    textUs.Text = row["MessageCreatedBy"].ToString();
                    textLen.Text = row["DataLanguage"].ToString();
                    textCreated.Text = row["MessageDate"].ToString();
                    textAppN.Text = row["ApplicationName"].ToString();


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en los datos");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
