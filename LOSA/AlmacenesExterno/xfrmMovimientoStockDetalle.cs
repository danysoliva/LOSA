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
using LOSA.AlmacenesExterno.Models;
using ACS.Classes;
using System.Data.SqlClient;
using LOSA.AlmacenesExterno.Salida_Almacen.Models;
using LOSA.AlmacenesExterno.Salida_Almacen;
using LOSA.Clases;


namespace LOSA.AlmacenesExterno
{
    public partial class xfrmMovimientoStockDetalle : DevExpress.XtraEditors.XtraForm
    {
        int id_header_salida;
        string bodega_origen;
        string bodega_destino;
        DateTime fecha;

        public xfrmMovimientoStockDetalle(int pid, string pbodega_in, string pbodega_out, DateTime pfecha)
        {
            InitializeComponent();
            id_header_salida = pid;
            bodega_origen = pbodega_in;
            bodega_destino = pbodega_out;
            fecha = pfecha;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}