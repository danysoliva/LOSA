using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;
using System.Data;
using LOSA.Clases;
namespace LOSA.Calidad
{
    public partial class frmSelectCausaRechazo : DevExpress.XtraEditors.XtraForm 
    {
        public int id;
        public string producto;
        public string comentario;
        int Tipo_tarima;
        DataOperations dp = new DataOperations();
        public frmSelectCausaRechazo( int tipoTa)
        {
            InitializeComponent();
            Tipo_tarima = tipoTa;
            load_data();


        }
        public void load_data()
        {
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener_causas_por_tipo_de_tarima", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo_tarima", Tipo_tarima);//
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCalidad.causas.Clear();
                da.Fill(dsCalidad.causas);
                cn.Close();
                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtcomentario.Text == "")
            {
                CajaDialogo.Error("No se puede agregar una causa de retencion sin comentario o justificacion.");
                return;
            }
            if (grd_causas.EditValue == null )
            {
                CajaDialogo.Error("Debe seleccionar una causa de retencion.");
                return;
            }
            id = Convert.ToInt32(grd_causas.EditValue);
            producto = grd_causas.Text;
            comentario = txtcomentario.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnAtras_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}