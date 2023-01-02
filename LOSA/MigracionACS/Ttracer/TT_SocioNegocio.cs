using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.Ttracer
{
    public partial class TT_SocioNegocio : Form
    {
        DataOperations dp = new DataOperations();
        public string CardCode;
        public string CardName;
        public string Concat;
        string boleta = "";
        public TT_SocioNegocio(string TipoBoleta)
        {
            InitializeComponent();
            boleta = TipoBoleta;
            load_socio();
        }
        public void load_socio()
        {
            try
            {
                string Query = @"Select T0.CardCode, T0.CardName  FROM [AQFSVR006\AQFSVR006].[AQUA].[dbo].OCRD T0  ";
                if (boleta == "PT")
                {
                    Query = Query + "where T0.CardCode like 'CL%%'";
                }
                else
                {
                    Query = Query + @" union all Select T1.codigo Collate Modern_Spanish_CI_AS  as CardCode, T1.descripcion collate Modern_Spanish_CI_AS as CardName from dbo.M_proveedor_manual T1 ";
                }
                
                SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dSTtracer.sociodenegocio.Clear();
                da.Fill(dSTtracer.sociodenegocio);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void TT_SocioNegocio_Load(object sender, EventArgs e)
        {

        }

        private void btnrecargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_socio();
        }

        private void btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void grdv_socios_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_socios.FocusedView;
                var Row = (dSTtracer.sociodenegocioRow)gridview.GetFocusedDataRow();
                CardCode = Row.CardCode;
                CardName = Row.CardName;
                Concat = "(" + Row.CardCode + ")" + " - " + Row.CardName; 
            }
            catch (Exception ex)
            {

                
            }
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void grdv_socios_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_socios.FocusedView;
                var Row = (dSTtracer.sociodenegocioRow)gridview.GetFocusedDataRow();
                CardCode = Row.CardCode;
                CardName = Row.CardName;
                Concat = "(" + Row.CardCode + ")" + " - " + Row.CardName;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {


            }
        }

        private void btnseleccionarr_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_socios.FocusedView;
                var Row = (dSTtracer.sociodenegocioRow)gridview.GetFocusedDataRow();
                CardCode = Row.CardCode;
                CardName = Row.CardName;
                Concat = "(" + Row.CardCode + ")" + " - " + Row.CardName;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {


            }
        }
    }
}
