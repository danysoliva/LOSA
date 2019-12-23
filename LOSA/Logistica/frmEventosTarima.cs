using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Logistica
{
    public partial class frmEventosTarima : Form
    {
        int idTarima;
        DateTime fechaCreacion;
        public frmEventosTarima(int pidTarima, DateTime pfechaCreacion )
        {
            InitializeComponent();
            idTarima = pidTarima;
            fechaCreacion = pfechaCreacion;
        }

        private void frmEventosTarima_Load(object sender, EventArgs e)
        {
            teIdTarima.Text = idTarima.ToString();
            teFechaCreacion.Text = fechaCreacion.ToShortDateString();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
