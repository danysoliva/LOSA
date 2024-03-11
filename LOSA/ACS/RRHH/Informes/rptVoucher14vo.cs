using ACS.Classes;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace LOSA.ACS.RRHH.Informes
{
    public partial class rptVoucher14vo : DevExpress.XtraReports.UI.XtraReport
    {
        string CodigoEmpleado;
        public rptVoucher14vo(string CodigoEmp)
        {
            InitializeComponent();
            CodigoEmpleado = CodigoEmp;
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_pago_catorceavo_tmp_to_print", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@code", CodigoEmpleado);
                dsInformesRRHH1.catorceavo.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsInformesRRHH1.catorceavo);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

    }
}
