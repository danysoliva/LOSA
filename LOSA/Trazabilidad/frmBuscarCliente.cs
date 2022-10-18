using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Calidad;
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

namespace LOSA.Trazabilidad
{
    public partial class frmBuscarCliente : DevExpress.XtraEditors.XtraForm
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_Direccion_Clientesv2", cnx);
                    dsCalidad1.Direccion_Clientes.Clear();

                    da.Fill(dsCalidad1.Direccion_Clientes);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            //validar la seleccion minima
            int count = 0;
            foreach(dsCalidad.Direccion_ClientesRow row in dsCalidad1.Direccion_Clientes)
            {
                if (row.seleccionado)
                    count++;
            }

            if (count == 0)
            {
                CajaDialogo.Error("Al menos debe seleccionar un cliente!");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}