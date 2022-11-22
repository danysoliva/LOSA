using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.MigracionACS.RPTS.PRD
{
    public partial class RPT_FB_Manual_RM : DevExpress.XtraReports.UI.XtraReport
    {
        public RPT_FB_Manual_RM(int pIdFormula,
                                string pCodigo,
                                string pCodigoInterno,
                                string pVersionFormula)
        {
            InitializeComponent();

            lblComentPadre.Visible = txtComentario.Visible = true;
            lblComentarioLocal.Visible = txtComentarioLocal.Visible = true;

            DataOperations dp = new DataOperations();

            SqlConnection Conn = new SqlConnection(dp.ConnectionStringCostos);
            Conn.Open();

            string sqlA = @"SELECT vv.format_id
                                FROM FML_Formulas_v2 AS vv
                                WHERE        (codigo = '+" + pCodigo + "') AND (version = " + pVersionFormula + ") and tipo = 'FB' ";
            SqlCommand cmdA = new SqlCommand(sqlA, Conn);
            string formPadre = cmdA.ExecuteScalar().ToString();

            try
            {
                string sqlB = @"SELECT ff.comment
                                FROM [dbo].[FML_FF_Comments] ff
                                where ff.id_formula = " + formPadre;
                SqlCommand cmdB = new SqlCommand(sqlB, Conn);
                txtComentario.Text = cmdB.ExecuteScalar().ToString();
            }
            catch
            {
                txtComentario.Visible = lblComentPadre.Visible = false;
            }

            try
            {
                string sqlC = @"SELECT TOP (1) comment
                                FROM FML_Formulas_Comments AS cc
                                WHERE (id_formula = " + pIdFormula + ")";
                SqlCommand cmdC = new SqlCommand(sqlC, Conn);
                txtComentarioLocal.Text = cmdC.ExecuteScalar().ToString();

                //comment
            }
            catch
            {
                txtComentarioLocal.Visible = lblComentarioLocal.Visible = false;
            }
        }

    }
}
