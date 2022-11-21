using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.MigracionACS.DataSetx;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.Produccion
{
    public partial class Llenado_Zarandas : Form
    {
        string code;
        DataOperations dp;
        public Llenado_Zarandas(string Codigo)
        {
            InitializeComponent();
            code = Codigo;
            labelCodigo.Text = code;
            Llenado();
        }

        private void Llenado_Zarandas_Load(object sender, EventArgs e)
        {

        }
        public void Llenado()
        {
            dp = new DataOperations();
            string Qye;
            Qye = @"Select
                        b.cod_oodo as cod_oodo
                        ,a.description as description
                        ,b.superior as superior
                        ,b.inferior as inferior
                        ,b.id_Zaranda as id_Zaranda
                     from .dbo.PT_Products_Zaranda A join 
                        .dbo.PT_ProZar B on 
                        A.id = b.id_Zaranda
                    where b.cod_oodo = '"+code+"' ";
            SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
            con.Open();
            SqlCommand command = new SqlCommand(Qye,con);
            SqlDataAdapter da = new SqlDataAdapter(command);
            dSProductos.ZarPro.Clear();
            da.Fill(dSProductos.ZarPro);
        
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Llenado();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CajaDialogo.Information("Finalizando.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            dp = new DataOperations();
            var GridView = (GridView)gridControl1.FocusedView;
            string sup, inf;
            var row = (DSProductos.ZarProRow)GridView.GetFocusedDataRow();
            int identificadorZarandas = Convert.ToInt32(row.id_Zaranda);
            if ( Convert.ToString(row.superior) == "0")
            {
                sup = "0";
            }
            else
            {
                sup = Convert.ToString(row.superior);
            }
            if (Convert.ToString(row.inferior) == "0")
            {
                inf = "0";

            }
            else
            {
                inf = Convert.ToString(row.inferior);
            }
            
            
            string querys;
            querys = @"update [dbo].[PT_ProZar]
                            set [superior] = "+sup+","+
                            "[inferior] = "+inf+"" +
                            "Where [cod_oodo] = '" + code + "' and [id_Zaranda] = " + identificadorZarandas;
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            cn.Open();
            SqlCommand cmd = new SqlCommand(querys, cn);
            cmd.ExecuteNonQuery();



        }
    }
}
