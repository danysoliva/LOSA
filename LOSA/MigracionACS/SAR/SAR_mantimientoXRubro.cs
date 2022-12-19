using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACS.Classes;
using System.Data.SqlClient;


namespace LOSA.MigracionACS.SAR
{
    public partial class SAR_mantimientoXRubro : Form
    {
        Decimal monto;
        int Varid;
        DataOperations dp = new DataOperations();
        DateTime Parinicio;
        DateTime Parfinal;
        int tipo;
        public SAR_mantimientoXRubro(int CodRubro, string Descripcion, int IDdetalle, Decimal monto, DateTime dtinicio, DateTime dtfinal)
        {

            InitializeComponent();
            lbltitulo.Text = "Exoneracion vigentes desde la fecha: " + dtinicio.ToString("MM-dd-yyyy")+ @" hasta la fecha: "+dtfinal.ToString("MM-dd-yyyy");
            txtcodigo.Text = CodRubro.ToString();
            txtrubro.Text = Descripcion;
            this.monto = monto;
            txtpresupuesto.Text = Convert.ToString(monto);
            Varid = IDdetalle;
            Parinicio = dtinicio;
            Parfinal = dtfinal;
            tipo = 1;

        }

        public SAR_mantimientoXRubro(string CodRubro, string Descripcion, int IDdetalle, Decimal monto, DateTime dtinicio, DateTime dtfinal)
        {

            InitializeComponent();
            lbltitulo.Text = "Exoneracion vigentes desde la fecha: " + dtinicio.ToString("MM-dd-yyyy") + @" hasta la fecha: " + dtfinal.ToString("MM-dd-yyyy");
            txtcodigo.Text = CodRubro.ToString();
            txtrubro.Text = Descripcion;
            this.monto = monto;
            txtpresupuesto.Text = Convert.ToString(monto);
            Varid = IDdetalle;
            Parinicio = dtinicio;
            Parfinal = dtfinal;
            tipo = 2;

        }

        private void btncerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnguardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtpresupuesto.Text == "")
            {
                MessageBox.Show("El presupuesto para este rubro no puede quedar vacio");
                txtrubro.Focus();
                return;

            }
            else
            {
                monto = Convert.ToDecimal(txtpresupuesto.Text);
            }
            string Query = @"UPDATE [dbo].[SAR_presupuesto_d]
                               SET [monto] = @monto
                             WHERE id = @id";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.Parameters.Add("@monto", SqlDbType.Decimal).Value = monto;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Varid;
                cmd.ExecuteNonQuery();
                cn.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error("Error de data" +ex.Message);

            }
        }
    }
}
