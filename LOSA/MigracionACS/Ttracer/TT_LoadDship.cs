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
using System.Runtime.InteropServices;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.Ttracer
{
    public partial class TT_LoadDship : Form
    {
        int idship;
        int idarrib;

        DataOperations dp = new DataOperations();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public TT_LoadDship(int ID, int idarrib)
        {
            InitializeComponent();
            idship = ID;
            this.idarrib = idarrib;
            load_ship();
        }
        public void load_ship()
        {
            string query = @"Select 
                            T1.id
		                    ,T1.DocNum
		                    ,T3.descripcion as shipid
		                    ,T1.CardCode
		                    ,T1.Cardname
		                    ,t1.ItemCode
		                    ,T1.ItemName
		                    ,T1.peso
                            ,T0.date_begin
		                    ,T1.status
                            ,coalesce(T1.Comment, 'Vacio') as Comment
                            ,coalesce(T1.Granel,0) as Granel
		                    ,Case when T1.ItemCode like 'MP%%' then 'Materia Prima'
	                                              when T1.ItemCode like 'CO%%' then 'Combustible'
	                                              when T1.ItemCode like 'RS%%' then 'Repuesto y suministro'
	                                              when T1.ItemCode like 'ME%%' then 'Material de empaque'
	                                              when T1.ItemCode like 'DS%%' then 'Desechos'
	                                              when T1.ItemCode like 'RM%%' then 'Repuestos Muyang'
	                                              when T1.ItemCode like 'SV%%' then 'Servicios'
	                                              end as tipo
                    from TS_ship_h T0 join TS_ship_d T1 On T0.id = T1.id_shiph
				                      join M_ship T3 On T3.id = T0.shipid
				                      where T0.id = " + idship+@" and t1.enable = 1 and t1.[close] = 0";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dSTtracer.shiptoarrib.Clear();
                da.Fill(dSTtracer.shiptoarrib);

            }
            catch (Exception)
            {

  
            }

        }

        private void panelControl1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnuse_Click(object sender, EventArgs e)
        {
            try
            {
                
                var gridview = (GridView)grd_load.FocusedView;
                var row = (dSTtracer.shiptoarribRow)gridview.GetFocusedDataRow();
                int bit = 0;
                if (row.Granel)
                {
                    bit = 1;
                }
                else
                {
                    bit = 0;
                }
                int tipo =0;
                switch (row.ItemCode.Substring(0,2))
                {
                    case "MP"://Materia Prima
                        tipo = 1;
                        break;
                    case "CO": //Combustible
                        tipo = 2;
                        break;
                    case "ME": // Material de empaque
                        tipo = 3;
                        break;
                    case "SV": //Servicios
                        tipo = 4;
                        break;
                    case "DS": //Desechos
                        tipo = 5;
                        break;
                    case "PT": //Producto terminado
                        tipo = 6;
                        break;
                    case "RM": //Repuestos Muyang
                        tipo = 7;
                        break;
                    case "RS": //Repuestos y suministros
                        tipo = 8;
                        break;
                    default:
                        break;
                }


                string query = @"INSERT INTO [dbo].[DC_workplan_d]
                                                   ([docnum]
                                                   ,[shipid_d]
                                                   ,[provecode]
                                                   ,[descriprove]
                                                   ,[prodcode]
                                                   ,[descripitem]
                                                   ,[quantityplan]
                                                   ,[unt]
                                                   ,[dateplanarribe]
                                                   ,[printed]
                                                   ,[idconfvehi]
                                                   ,[enable]
                                                   ,[status]
                                                   ,[typeid]
                                                   ,[comment]
                                                   ,idh
                                                   ,granel)
                                             VALUES
                                                   (" + row.DocNum+@"
                                                   ,"+ idship + @"
                                                   ,'"+row.CardCode+@"'
                                                   ,'"+row.Cardname+@"'
                                                   ,'"+row.ItemCode+@"'
                                                   ,'"+row.ItemName+@"'
                                                   , "+row.peso+@"
                                                   , '0'
                                                   ,'"+String.Format("{0:yyyy-MM-dd}",row.date_begin)+@"' 
                                                   ,0
                                                   ,0
                                                   ,1
                                                   ,10
                                                   , "+tipo+@"
                                                   ,'"+row.Comment+ "', "+ idarrib + @", "+ bit + @")";
                dp.ACS_DoSmallDBOperationBas(query);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {

            }
           
            
        }
    }
}
