using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.Reportes
{
    public partial class xrptAlimentacionMicros : DevExpress.XtraReports.UI.XtraReport
    {
        public xrptAlimentacionMicros(int id)
        {
            InitializeComponent();
            DataOperations dp = new DataOperations();

            using (SqlConnection cnx = new  SqlConnection(dp.ConnectionStringLOSA))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from pruebaDetail1", cnx);
                da.Fill(dsReportes1.PruebaDetalle1);

            }

            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from pruebaDetail2", cnx);
                da.Fill(dsReportes1.PruebaDetalle2);

            }
        }

    }
}
