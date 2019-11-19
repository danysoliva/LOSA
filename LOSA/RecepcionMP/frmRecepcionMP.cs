using ACS.Classes;
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

namespace LOSA.RecepcionMP
{
    public partial class frmRecepcionMP : Form
    {
        int IdSerie;
        int NumBoleta;
        public frmRecepcionMP()
        {
            InitializeComponent();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdSelectBoleta_Click(object sender, EventArgs e)
        {
            FrmBoleta frm = new FrmBoleta();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                txtNumBoleta.Text = frm.NumBoleta.ToString();
                this.IdSerie = frm.IdSerie;
                this.NumBoleta = frm.NumBoleta;

               
            }
        }
    }
}
