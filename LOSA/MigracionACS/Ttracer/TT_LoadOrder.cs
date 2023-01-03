using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.Ttracer
{
    public partial class TT_LoadOrder : Form
    {
        DataOperations dp = new DataOperations();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        int IdShi;
        string usercode;
        DateTime fechaini;
        int tipo;
        public TT_LoadOrder( int idSHIP, string usercode, int tipoo, DateTime fechaini)
        {
            InitializeComponent();
            IdShi = idSHIP;
            this.usercode = usercode;
            load_data();
            this.tipo = tipoo;
            this.fechaini = fechaini;
        }
        public void load_data()
        {
            string query;
            query = @"EXEC [dbo].[CPS_Seleccion_Order_v2]
		                    @paramidship = "+IdShi+@",
		                    @tipo = "+tipo;
            DataOperations dp = new DataOperations();
            SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dSTtracer.ordercompra.Clear();
                da.Fill(dSTtracer.ordercompra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ordenes de SAP. Llamada de pila: "+ex.Message);
               
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

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btndisone_Click(object sender, EventArgs e)
        {
            if (tipo==1)
            {
                var gridview = (GridView)grd_order.FocusedView;
                var row = (dSTtracer.ordercompraRow)gridview.GetFocusedDataRow();
                int tipoo = 0;
                int bit = 0;
                

                if (row.Granel)
                {
                    if (row.default_code.Substring(0, 2) == "MP")
                    {
                        bit = 1;
                    }
                    else
                    {
                        bit = 0;
                    }
                }
                else
                {
                    bit = 0;
                }
                switch (row.default_code.Substring(0, 2))
                {
                    case "MP"://Materia Prima
                        if (bit == 1)
                        {
                            tipoo = 8;
                        }
                        else
                        {
                            tipoo = 1;

                        }
                        break;
                    case "CO": //Combustible
                        tipoo = 3;
                        break;
                    case "ME": // Material de empaque
                        tipoo = 10;
                        break;
                    case "SV": //Servicios
                        tipoo = 12;
                        break;
                    case "DS": //Desechos
                        tipoo = 5;
                        break;
                    case "PT": //Producto terminado
                        tipoo = 2;
                        break;
                    case "RM": //Repuestos Muyang
                        tipoo = 12;
                        break;
                    case "RS": //Repuestos y suministros
                        tipoo = 12;
                        break;
                    default:
                        break;
                }
                if (row.Canttimes > 0 )
                {

                }
                else
                {
                    MessageBox.Show("La cantidad de camiones esperados debe ser mayor que 0");
                    return;
                }
                if (row.Pesoesperado > 0)
                {

                }
                else
                {
                    MessageBox.Show("El peso esperado por vehiculo debe ser mayor que 0.");
                }
                string notes;
                if (row.notes.Length >= 150)
                {
                    notes = row.notes.Substring(0, 150);
                }
                else
                {
                    notes = row.notes;
                }
                // Agregar a la vitacora de Orden de compras.
                #region V I T A C O R A   D E  O C.
                Boolean alreadyexis = false;
                DataTable dt;
                dt = new DataTable();
                dt.Columns.Add("DocEntry" , typeof(int));
                dt.Columns.Add("LineNum", typeof(int));
                
                string Qry;
                Qry = @"SELECT 
                  [DocEntry]
                  ,[LineNum]
              FROM [dbo].[oc_trans_bas]
              where enable = 1 and DocEntry ="+row.purchase_order_id;
                SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Qry, cn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dt.Clear();
                    da.Fill(dt);
                    foreach (DataRow rows in dt.Rows)
                    {
                        if (row.line.ToString() == rows["LineNum"].ToString())
                        {
                            alreadyexis = true;
                        }
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                Qry = @"INSERT INTO [dbo].[oc_trans_bas]
                                           ([DocEntry]
                                           ,[LineNum]
                                           ,[quantity]
                                           ,[TaxDate]
                                           ,[CardCode]
                                           ,[CardName]
                                           ,[Comments]
                                           ,[ItemCode]
                                           ,[ItemName]
                                           ,[granel]
                                           ,[enable]
                                           ,[close])
                                     VALUES
                                           (@Docnum
                                           ,@LineNum
                                           ,@Quantity
                                           ,@datecrate
                                           ,@codigoProve
                                           ,@DescripProve
                                           ,@Coment
                                           ,@codigoItems
                                           ,@DescripItems
                                           ,@granel
                                           ,1
                                           ,0)";
                cn = new SqlConnection(dp.ConnectionStringBascula);
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Qry, cn);
                    cmd.Parameters.Add("@Docnum", SqlDbType.Int).Value = row.purchase_order_id;
                    cmd.Parameters.Add("@LineNum", SqlDbType.Int).Value = row.line;
                    cmd.Parameters.Add("@Quantity", SqlDbType.Decimal).Value = row.quantity;
                    cmd.Parameters.Add("@datecrate", SqlDbType.DateTime).Value = row.date_order;
                    cmd.Parameters.Add("@codigoProve", SqlDbType.VarChar).Value = row.partner_id;
                    cmd.Parameters.Add("@DescripProve", SqlDbType.VarChar).Value = row.partner_name;
                    cmd.Parameters.Add("@Coment", SqlDbType.VarChar).Value = notes;
                    cmd.Parameters.Add("@codigoItems", SqlDbType.VarChar).Value = row.default_code;
                    cmd.Parameters.Add("@DescripItems", SqlDbType.VarChar).Value = row.default_code_name ;
                    cmd.Parameters.Add("@granel", SqlDbType.Bit).Value = bit;
                    if (alreadyexis)
                    {

                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
                catch (Exception ex )
                {

                    MessageBox.Show("Error al cargar data de la OC." + ex.Message);
                    return;
                }
                #endregion
                if (row.Canttimes > 10)
                {
                    if (MessageBox.Show("La cantidad de camiones a arr, seguro que deseas continuar?","Advertencia", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.OK)
                    {

                    }
                }
                for (int i = 0; i < row.Canttimes; i++)
                {

                    
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
                                                   ,granel, line)
                                             VALUES
                                                   (" + row.purchase_order_id + @"
                                                   ,null
                                                   ,'" + row.partner_id + @"'
                                                   ,'" + row.partner_name + @"'
                                                   ,'" + row.default_code + @"'
                                                   ,'" + row.default_code_name + @"'
                                                   , " + row.Pesoesperado + @"
                                                   , '0'
                                                   ,'" + String.Format("{0:yyyy-MM-dd}", fechaini) + @"' 
                                                   ,0
                                                   ,0
                                                   ,1
                                                   ,10
                                                   , " + tipoo + @"
                                                   ,'" + notes + "', " + IdShi + @", " + bit + @", "+row.line+@")";
                    dp.ACS_DoSmallDBOperationBas(query);
                   

                }
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                var gridview = (GridView)grd_order.FocusedView;
                var row = (dSTtracer.ordercompraRow)gridview.GetFocusedDataRow();
                int bit = 0;
                if (row.Granel)
                {
                    if (row.default_code.Substring(0, 2) == "MP")
                    {
                        bit = 1;
                    }
                    else
                    {
                        bit = 0;
                    }
                }
                else
                {
                    bit = 0;
                }
                if (row.Canttimes > 0)
                {

                }
                else
                {
                    MessageBox.Show("La cantidad de camiones esperados debe ser mayor que 0");
                    return;
                }
                if (row.Pesoesperado > 0)
                {

                }
                else
                {
                    MessageBox.Show("El peso esperado por vehiculo debe ser mayor que 0.");
                }
                SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT T0.[id]
                                                    FROM[dbo].[TS_ship_d] T0
                                                      where T0.id_shiph =" + IdShi + "and t0.enable = 1;", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Solo puede haber una orden de compra por plan.");
                        return;
                    }
                    cn.Close();
                    string Query = @"INSERT INTO [dbo].[TS_ship_d]
                                   ([id_shiph]
                                   ,[DocNum]
                                   ,[ItemCode]
                                   ,[ItemName]
                                   ,[CardCode]
                                   ,[Cardname]
                                    ,[peso]
                                   ,[status]
                                   ,[date_create]
                                   ,[enable]
                                   ,[id_unit]
                                   ,[close]
                                   ,[usersing]
                                   ,[DocEntry]
                                   ,[Linenum]
                                    ,granel, Comment,pesoaprox)
                             VALUES
                                   (" + IdShi + @"
                                   ," + row.oc_num + @"
                                   ,'" + row.default_code + @"'
                                   ,'" + row.default_code_name + @"'
                                   ,'" + row.partner_id + @"'
                                   ,'" + row.partner_name + @"'
                                   ," + row.quantity + @"
                                   ,10
                                   ,SYSDATETIME()
                                   ,1
                                   ,0
                                   ,0
                                   ," + usercode + @"
                                   ," + row.purchase_order_id + @"
                                   ," + row.line + @", " + bit + @", '" + row.notes + "', "+row.Pesoesperado + ") Select Scope_identity()";
                     int idinserted = dp.basculaDB_Return_int(Query);


                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (Exception)
                {


                }
            }
        }

        private void grdv_order_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void grdv_order_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int movio = 0;
            var gridview = (GridView)grd_order.FocusedView;
            var row = (dSTtracer.ordercompraRow)gridview.GetFocusedDataRow();
            if (e.Column.Name == "colGranel")
            {
                if (row.default_code.Substring(0,2) == "MP")
                {
                    foreach (DataRow roww in dSTtracer.ordercompra.Rows)
                    {
                        if (row.oc_num == Convert.ToInt32(roww["oc_num"]) && row.line == Convert.ToInt32(roww["line"]) && row.default_code.Substring(0, 2) == "MP")
                        {
                            roww["Granel"] = e.Value;
                            row.Granel = Convert.ToBoolean(e.Value);
                            movio = 1;
                        }
                    }
                }
                else
                {
                   
                    return;
                }
                
            }
           
            
        }
      
        private void grd_order_Click(object sender, EventArgs e)
        {

        }
    }
}
