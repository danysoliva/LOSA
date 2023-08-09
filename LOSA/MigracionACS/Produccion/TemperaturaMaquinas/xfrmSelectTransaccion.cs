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

namespace LOSA.MigracionACS.Produccion.TemperaturaMaquinas
{
    public partial class xfrmSelectTransaccion : DevExpress.XtraEditors.XtraForm
    {
        public xfrmSelectTransaccion()
        {
            InitializeComponent();
            Load();
        }


        private void Load()
        {
            try
            {
                string query = @"dbo.sp_get_transacciones_temperatura_maquinas";
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTemperatura.transaccional_H.Clear();
                da.Fill(dsTemperatura.transaccional_H);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar los datos, contacte con el administrador", "Error");

            }
        }

        public Int64 id_transaccion;
        private void btnSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsTemperatura.transaccional_HRow)gvTransaccion.GetFocusedDataRow();

                id_transaccion = row.id;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CajaDialogo.Error("Error al cargar los datos, contacte con el administrador");
                throw;
            }
        }
    }
}