using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ACS.Classes;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LOSA.MigracionACS.RPTS.PRD
{
    public partial class RPT_FB_Manual_RM_Complete : DevExpress.XtraReports.UI.XtraReport
    {
        int idFormula;
        int idNucleo;
        public RPT_FB_Manual_RM_Complete(int pIdFormula,
                                         string pCodigo,
                                         string pCodigoInterno,
                                         string pVersionFormula,
                                         string pDescripcion,
                                         string pEspecie)
        {
            InitializeComponent();
            idFormula = pIdFormula;
            //idNucleo = pIdNucleo;
            txtCodigo.Text = pCodigo;
            txtCodigoInt.Text = pCodigoInterno;
            txtVersion.Text = pVersionFormula;
            txtDescripcion.Text = pDescripcion;
            txtEspecie.Text = pEspecie;
            txtCodeFull.Text = pCodigo + "." + pVersionFormula;


            CargarDatos();
        }

        public void CargarDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection Conn = new SqlConnection(dp.ConnectionStringCostos);
                Conn.Open();

                string ss = @"SELECT top 1 A.[nucleo] AS 'id_item'
                              FROM [dbo].[FML_Ingredientes_v2] A
                             WHERE A.[formula] = " + idFormula.ToString() +
                               "AND A.[tipo] = 'NC'";
                SqlCommand cmd = new SqlCommand(ss, Conn);
                idNucleo = Convert.ToInt32(cmd.ExecuteScalar());


                string sql_d = @"EXEC [dbo].[RPT_FM_FF_FB_Manual_Materials_v2] @id_formula = " + idFormula.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(sql_d, Conn);
                dsReportPRD1.formula.Clear();
                adapter.Fill(dsReportPRD1.formula);

                string sql = @"EXEC [dbo].[RPT_FM_FF_NC_Build_v2] @id_formula = " + idNucleo.ToString();
                SqlDataAdapter adapt = new SqlDataAdapter(sql, Conn);
                dsReportPRD1.formula_nc.Clear();
                adapt.Fill(dsReportPRD1.formula_nc);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
