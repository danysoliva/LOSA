using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ACS.Classes;
using System.Data.SqlClient;
using System.Windows.Forms;
using Devart.Data.PostgreSql;

namespace LOSA.MigracionACS.RPTS.PRD
{
    public partial class RPT_PRD_Formula_Local : DevExpress.XtraReports.UI.XtraReport
    {
        int idFormula;
        Int64 idFormula64;
        int idNucleo;
        string iLote;
        public RPT_PRD_Formula_Local(int pIdFormula,
                                     string pCodigo,
                                     string pCodigoInterno,
                                     string pVersionFormula,
                                     string pDescripcion,
                                     string pEspecie,
                                     string pLote)
        {
            InitializeComponent();
            idFormula = pIdFormula;
            
            txtCodigo.Text = pCodigo;
            txtCodigoInt.Text = pCodigoInterno;
            txtVersion.Text = pVersionFormula;
            txtDescripcion.Text = pDescripcion;
            txtEspecie.Text = pEspecie;
            txtCodeFull.Text = pCodigo + "." + pVersionFormula;

            if (string.IsNullOrEmpty(pLote))
            {
                iLote = pLote;
                txtLote.Text = iLote;
                txtLote.Visible = txtFechaProdFin.Visible = txtFechaProdInicio.Visible = false;
                lblLote.Visible = lblFechaFinProd.Visible = lblfechaInicioProd.Visible = false;
            }
            else
            {
                iLote = pLote;
                txtLote.Text = iLote;
                txtLote.Visible = txtFechaProdFin.Visible = txtFechaProdInicio.Visible = true;
                lblLote.Visible = lblFechaFinProd.Visible = lblfechaInicioProd.Visible = true;
            }

            //txtFechaProdInicio.Text = "domingo, 30 de julio de 2017";

            lblComentPadre.Visible = txtComentario.Visible = true;
            lblComentarioLocal.Visible = txtComentarioLocal.Visible = true;
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


                string sql_d = @"EXEC [dbo].[FM_FL_Get_Structure] @id_formula = " + idFormula.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(sql_d, Conn);
                dsProduccion1.detalle_form_local.Clear();
                adapter.Fill(dsProduccion1.detalle_form_local);

                string sql = @"EXEC [dbo].[FM_FL_Get_Structure] @id_formula = " + idNucleo.ToString();
                SqlDataAdapter adapt = new SqlDataAdapter(sql, Conn);
                dsProduccion1.detalle_nucleo.Clear();
                adapt.Fill(dsProduccion1.detalle_nucleo);


                string sqlA = @"SELECT vv.format_id
                                FROM FML_Formulas_v2 AS vv
                                WHERE        (codigo = '+" + txtCodigo.Text.Trim() + "') AND (version = "+ txtVersion.Text +") and tipo = 'FB' ";
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
                                WHERE (id_formula = " + idFormula.ToString() + ")";
                    SqlCommand cmdC = new SqlCommand(sqlC, Conn);
                    txtComentarioLocal.Text = cmdC.ExecuteScalar().ToString();

                    //comment
                }
                catch
                {
                    txtComentarioLocal.Visible = lblComentarioLocal.Visible = false;
                }

                if (!string.IsNullOrEmpty(iLote))
                {
                    SqlConnection Conn2 = new SqlConnection(dp.ConnectionStringAPMS);
                    Conn2.Open();
                    string xSql = @"SELECT xx.start_date, xx.end_date, xx.fp_lot_number 
                                FROM [dbo].[OP_Production_Orders_Main_Mix]xx
                                where xx.fp_lot_number = " + iLote.ToString() + " and " +
                                          " xx.start_date is not null and " +
                                          " xx.end_date is not null ";
                    SqlCommand xcmd = new SqlCommand(xSql, Conn2);
                    SqlDataReader dr1 = xcmd.ExecuteReader();
                    if (dr1.Read())
                    {
                        txtFechaProdInicio.Text = dr1.GetDateTime(0).ToString();
                        txtFechaProdFin.Text = dr1.GetDateTime(1).ToString();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
