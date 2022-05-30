using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Calidad.Revision_Sanidad.Model;
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

namespace LOSA.Calidad.Revision_Sanidad
{
    public partial class xfrmVehiculoInfo : DevExpress.XtraEditors.XtraForm
    {
        public xfrmVehiculoInfo()
        {
            InitializeComponent();
            loadVehiculos();
        }
        private void loadVehiculos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_info_vehiculo", cnx);
                    dsSanidad.info_vehiculo.Clear();

                    da.Fill(dsSanidad.info_vehiculo);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public VehiculoInfo vehiculo = new VehiculoInfo();
        private void btnSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                vehiculo = new VehiculoInfo();
                var row = (dsSanidad.info_vehiculoRow)gvVehiculo.GetFocusedDataRow();

                vehiculo.Contenedor = row.contenedor;
                vehiculo.Placa = row.placa;
                vehiculo.Proveedor = row.proveedor;
                vehiculo.Fecha = row.fecha;
                vehiculo.Hora = row.hora.ToString();
                vehiculo.Conductor = row.conductor;
                vehiculo.Placa = row.placa;
                vehiculo.CarCode = row.carcode;

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}