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
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using ACS.Classes;
using LOSA.Compras;

namespace LOSA.Compras
{
    public partial class frmCopiarDeSolicitud : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int IdSolicitudSeleccionado = 0;

        public frmCopiarDeSolicitud()
        {
            InitializeComponent();

            dp = new DataOperations();
            dtFechaDesdeDisponibles.DateTime = dp.Now().AddDays(-182);

            dtFechaHastaDisponibles.DateTime = dp.Now().AddDays(1);

            CargarSolicitudes();

        }

        private void CargarSolicitudes()
        {
            throw new NotImplementedException();
        }
    }
}