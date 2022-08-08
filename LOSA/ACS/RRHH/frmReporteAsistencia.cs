using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
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

namespace LOSA.ACS.RRHH
{
    public partial class frmReporteAsistencia : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmReporteAsistencia(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void LoadDatos()
        {
            if (string.IsNullOrEmpty(dt_inicial.Text))
            {
                CajaDialogo.Error("Debe especificar un rango de fechas valido!");
                dt_inicial.Focus();
                return;
            }

            if (string.IsNullOrEmpty(dt_final.Text))
            {
                CajaDialogo.Error("Debe especificar un rango de fechas valido!");
                dt_final.Focus();
                return;
            }

            if (dt_final.DateTime< dt_inicial.DateTime)
            {
                CajaDialogo.Error("Debe especificar un rango de fechas valido!");
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_load_marcas_turno_by_day", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dt_inicial", dt_inicial.DateTime);
                cmd.Parameters.AddWithValue("@dt_final", dt_final.DateTime);
                dsRRHH_reportes1.resumen_asistencia.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRRHH_reportes1.resumen_asistencia);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            if (dsRRHH_reportes1.resumen_asistencia.Count < 1)
            {
                CajaDialogo.Error("Debe de generar el reporte primero.");
                return;
            }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl1.ExportToXlsx(dialog.FileName);
            }
        }





    }
}