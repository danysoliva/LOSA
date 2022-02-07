using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Calidad
{
    public partial class frmNoConfirmidadMP : DevExpress.XtraEditors.XtraForm
    {
        private int id_lote;

        public frmNoConfirmidadMP(int Pid_lote)
        {
            InitializeComponent();
            Id_lote = Pid_lote;
        }

        public void load_data()
        {

        }
        public int Id_lote { get => id_lote; set => id_lote = value; }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}