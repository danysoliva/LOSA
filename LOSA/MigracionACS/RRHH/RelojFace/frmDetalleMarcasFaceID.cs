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

namespace LOSA.MigracionACS.RRHH.RelojFace
{
    public partial class frmDetalleMarcasFaceID : DevExpress.XtraEditors.XtraForm
    {
        DateTime Fecha;
        string Code;
        public frmDetalleMarcasFaceID(string namep, DateTime fecha, string code)
        {
            InitializeComponent();
            lblEmployeeName.Text = namep;
            Fecha = fecha;
            Code = code;
            LoadDatos();
        }

        private void LoadDatos()
        {
            string query = @"[sp_get_rrhh_detalle_marcas_faceid]";
            DataOperations dp = new DataOperations();
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", Fecha);
                cmd.Parameters.AddWithValue("@code", Code);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsFaceReloj1.detalle_marcas.Clear();
                da.Fill(dsFaceReloj1.detalle_marcas);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}