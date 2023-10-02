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

namespace LOSA.MigracionACS.Produccion.ProductoMedicado
{
    public partial class frmAddItemForMedicado : DevExpress.XtraEditors.XtraForm
    {
        public frmAddItemForMedicado()
        {
            InitializeComponent();
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_seleccion_lote_for_medicado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsMedicado1.seleccionar_item.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMedicado1.seleccionar_item);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            int cont = 0;
            foreach(dsMedicado.seleccionar_itemRow row in dsMedicado1.seleccionar_item)
            {
                decimal val = 0;
                try
                {
                    val = Convert.ToDecimal(row.cantidad);
                }
                catch { }

                if (val > 0)
                    cont++;


                if (cont > 0)
                    break;
            }

            if(cont<0) 
            {
                CajaDialogo.Error("Es necesario ingresar una cantidad mayor a cero!");
                return;
            }

            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}