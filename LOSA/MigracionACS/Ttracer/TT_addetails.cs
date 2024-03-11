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
    public partial class TT_addetails : Form
    {
        DataOperations dp = new DataOperations();
        int idofplan;
        int lineoforder;
        Boolean granel;
        int idofOrder;
        public TT_addetails()
        {
            InitializeComponent();
            radioGroup1.SelectedIndex = 1;
            load_data();
            load_bruno_mars();
        }
        public void load_bruno_mars()
        {
            string Query = @"EXEC	 [dbo].[CPS_Seleccion_Order_v2]
		                            @paramidship =0,
		                            @tipo = 0";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                dSTtracer.ordercompra.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dSTtracer.ordercompra);
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void load_data()
        {
            string query = @"SELECT t2.[id]
                              ,t2.[codigo]
	                          ,case when t2.withship = 0 then 'Sin barco'
	                          else (Select TOP 1 T0.descripcion from M_ship T0 Join TS_ship_h T1 On T0.id = T1.shipid 
                        where T1.id =  t2.shipid) end as barco
                        ,shipid
                              ,t2.[date_create]
                              ,t2.[date_inicio]
                              ,t2.[date_fin]
                              ,t2.[comment]
                              ,t2.[tonaprox]
                          FROM [dbo].[DC_workplan_h] t2
                        where t2.[close] = 0
                          order by 1 desc";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                dSTtracer.planheader.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dSTtracer.planheader);
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 0)
            {
                grd_plan.Enabled = false;
                idofplan = 0;
                labelControl4.Text = "Sin seleccionar.";
            }
            else
            {
                grd_plan.Enabled = true;
            }
        }

        private void grdv_plan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var gridview = (GridView)grd_plan.FocusedView;
            var row = (dSTtracer.planheaderRow)gridview.GetFocusedDataRow();
            
            try
            {
                idofplan = row.id;
                labelControl4.Text = idofplan.ToString();
                
            }
            catch (Exception ex) 
            {

                idofplan = 0;
                labelControl4.Text = "Sin seleccionar.";
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelControl4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void grdv_order_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_order.FocusedView;
                var row = (dSTtracer.ordercompraRow)gridview.GetFocusedDataRow();
                granel = row.Granel;
                if (granel)
                {
                    labelControl8.Text = "Si";
                }
                else
                {
                    labelControl8.Text = "No";
                }
                try
                {
                    idofOrder = row.oc_num;
                    lineoforder = row.line;
                    labelControl6.Text = idofOrder.ToString();

                }
                catch (Exception ex)
                {
                    lineoforder = 0;
                    idofOrder = 0;
                    labelControl6.Text = "Sin seleccionar.";
                }
            }
            catch (Exception ex)
            {

              
            }
        }

        private void grdv_order_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "colGranel")
            {
                if (Convert.ToBoolean(e.Value))
                {
                    labelControl8.Text = "Si";
                    granel = Convert.ToBoolean(e.Value);
                }
                else
                {
                    labelControl8.Text = "No";
                    granel = Convert.ToBoolean(e.Value);
                }
            }
            
        }

        private void btnload_Click(object sender, EventArgs e)
        {//Aqui es la magia 
           int tipoo = 0;
                            int bit = 0;
                string docnum, provecode, descriprove, prodcode, descripitem
                    , comment = "";
                descriprove = "";
                descripitem = "";
                prodcode = "";
                docnum = "";
                provecode = "";
                decimal quantityplan = 0;
                DateTime dateplanarribe = DateTime.MinValue;
            if (idofplan == 0)
            {
                foreach (DataRow row in dSTtracer.ordercompra)
                {
                    if (idofOrder == Convert.ToInt32(row["oc_num"].ToString()))
                    {
                        if (lineoforder == Convert.ToInt32(row["line"].ToString()))
                        {
                            docnum = row["oc_num"].ToString();
                            provecode = row["partner_id"].ToString();
                            descriprove = row["partner_name"].ToString();
                            prodcode = row["default_code"].ToString();
                            descripitem = row["default_code_name"].ToString();
                            comment = row["notes"].ToString();
                            dateplanarribe = Convert.ToDateTime(row["date_order"].ToString());
                             quantityplan = Convert.ToDecimal(row["quantity"].ToString());

                            //switch (row["default_code"].ToString().Substring(0, 2))
                            //{
                            //    case "MP"://Materia Prima
                            //        tipoo = 1;
                            //        break;
                            //    case "CO": //Combustible
                            //        tipoo = 2;
                            //        break;
                            //    case "ME": // Material de empaque
                            //        tipoo = 3;
                            //        break;
                            //    case "SV": //Servicios
                            //        tipoo = 4;
                            //        break;
                            //    case "DS": //Desechos
                            //        tipoo = 5;
                            //        break;
                            //    case "PT": //Producto terminado
                            //        tipoo = 6;
                            //        break;
                            //    case "RM": //Repuestos Muyang
                            //        tipoo = 7;
                            //        break;
                            //    case "RS": //Repuestos y suministros
                            //        tipoo = 8;
                            //        break;
                            //    default:
                            //        break;
                            //}
                            SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                            try
                            {
                                string Typesugerido = row["default_code"].ToString().Substring(0, 2);
                                if (Typesugerido == "CO" || Typesugerido == "SV" || Typesugerido == "DS" || Typesugerido == "RM" || Typesugerido == "RS") // LOS FILTROS DE ITEMS SE CAMBIAN SEGUN EL TIPO SELECCIONADO.
                                {
                                    Typesugerido = "NA";
                                }

                                cn.Open();
                                string query = @"SELECT top 1 T0.[id] 
                                            FROM [dbo].[M_tipo_op] T0
                                            where T0.enable = 1 and  t0.codigo = '" + Typesugerido + @"'";
                                SqlCommand cmd = new SqlCommand(query, cn);
                                SqlDataReader dr = cmd.ExecuteReader();
                                if (dr.Read())
                                {
                                    tipoo = Convert.ToInt32(dr[0].ToString());
                                }
                                else
                                {
                                    switch (row["default_code"].ToString().Substring(0, 2))
                                    {
                                        case "MP"://Materia Prima
                                            tipoo = 1;
                                            break;
                                        case "CO": //Combustible
                                            tipoo = 2;
                                            break;
                                        case "ME": // Material de empaque
                                            tipoo = 3;
                                            break;
                                        case "SV": //Servicios
                                            tipoo = 4;
                                            break;
                                        case "DS": //Desechos
                                            tipoo = 5;
                                            break;
                                        case "PT": //Producto terminado
                                            tipoo = 6;
                                            break;
                                        case "RM": //Repuestos Muyang
                                            tipoo = 7;
                                            break;
                                        case "RS": //Repuestos y suministros
                                            tipoo = 8;
                                            break;
                                        default:
                                            break;
                                    }
                                    cn.Close();
                                }
                                cn.Close();
                            }
                            catch (Exception ex)
                            {
                                switch (row["default_code"].ToString().Substring(0, 2))
                                {
                                    case "MP"://Materia Prima
                                        tipoo = 1;
                                        break;
                                    case "CO": //Combustible
                                        tipoo = 2;
                                        break;
                                    case "ME": // Material de empaque
                                        tipoo = 3;
                                        break;
                                    case "SV": //Servicios
                                        tipoo = 4;
                                        break;
                                    case "DS": //Desechos
                                        tipoo = 5;
                                        break;
                                    case "PT": //Producto terminado
                                        tipoo = 6;
                                        break;
                                    case "RM": //Repuestos Muyang
                                        tipoo = 7;
                                        break;
                                    case "RS": //Repuestos y suministros
                                        tipoo = 8;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }
                #region V I T A C O R A   D E  O C.
                Boolean alreadyexis = false;
                DataTable dt;
                dt = new DataTable();
                dt.Columns.Add("DocEntry", typeof(int));
                dt.Columns.Add("LineNum", typeof(int));

                string Qry;
                Qry = @"SELECT 
                  [DocEntry]
                  ,[LineNum]
              FROM [dbo].[oc_trans_bas]
              where enable = 1 and DocEntry =" + idofOrder;
                SqlConnection cnn = new SqlConnection(dp.ConnectionStringBascula);
                try
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(Qry, cnn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dt.Clear();
                    da.Fill(dt);
                    foreach (DataRow rows in dt.Rows)
                    {
                        if (lineoforder.ToString() == rows["LineNum"].ToString())
                        {
                            alreadyexis = true;
                        }
                    }
                    cnn.Close();
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
                cnn = new SqlConnection(dp.ConnectionStringBascula);
                try
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(Qry, cnn);
                    cmd.Parameters.Add("@Docnum", SqlDbType.Int).Value = idofOrder;
                    cmd.Parameters.Add("@LineNum", SqlDbType.Int).Value = lineoforder;
                    cmd.Parameters.Add("@Quantity", SqlDbType.Decimal).Value = quantityplan;
                    cmd.Parameters.Add("@datecrate", SqlDbType.DateTime).Value = dateplanarribe;
                    cmd.Parameters.Add("@codigoProve", SqlDbType.VarChar).Value = provecode;
                    cmd.Parameters.Add("@DescripProve", SqlDbType.VarChar).Value = descriprove;
                    cmd.Parameters.Add("@Coment", SqlDbType.VarChar).Value = comment;
                    cmd.Parameters.Add("@codigoItems", SqlDbType.VarChar).Value = prodcode;
                    cmd.Parameters.Add("@DescripItems", SqlDbType.VarChar).Value = descripitem;
                    cmd.Parameters.Add("@granel", SqlDbType.Bit).Value = bit;
                    if (alreadyexis)
                    {

                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                    }
                    cnn.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al cargar data de la OC." + ex.Message);
                    return;
                }
                #endregion
                string codigoP = dp.Nexcode(3);
                    string QUERY = @"INSERT INTO [dbo].[DC_workplan_h]
                                       ([codigo]
                                       ,[withship]
                                       ,[shipid]
                                       ,[date_create]
                                       ,[date_inicio]
                                       ,[date_fin]
                                       ,[close]
                                       ,[comment]
                                       ,[tonaprox]
                                       ,[enable])
                                 VALUES
                                       ('"+ codigoP + @"'
                                       ,0
                                       ,null
                                       ,SYSDATETIME()
                                       ,SYSDATETIME()
                                       ,SYSDATETIME()
                                       ,0
                                       ,'CARGA MANUAL DE ARRIBO' 
                                       ,0
                                       ,1) Select SCOPE_IDENTITY();";
                    using (SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula))
                    {
                        cn.Open();
                        SqlCommand cmd = cn.CreateCommand();
                        SqlTransaction trans;
                        trans = cn.BeginTransaction("SampleTransaction");
                        cmd.Connection = cn;
                        cmd.Transaction = trans;
                        try
                        {
                        if (comment.Length > 150)
                        {
                            comment = comment.Substring(0, 150);
                        }
                        //cmd.CommandText = QUERY;
                        //int IdInserted = Convert.ToInt32(cmd.ExecuteScalar());
                            QUERY = @"INSERT INTO [dbo].[DC_workplan_d]
                                                       ([docnum]
                                                       ,[shipid_d]
                                                       ,[provecode]
                                                       ,[descriprove]
                                                       ,[prodcode]
                                                       ,[descripitem]
                                                       ,[quantityplan]
                                                       ,[unt]
                                                       ,[printed]
                                                       ,[idconfvehi]
                                                       ,[enable]
                                                       ,[status]
                                                       ,[typeid]
                                                       ,[comment]
                                                       ,[idh]
                                                       ,[granel]
                                                    ,[dateplanarribe], line)
                                                 VALUES
                                                       ('" + docnum + @"'
                                                       ,null
                                                       ,'" + provecode + @"'
                                                       ,'" + descriprove + @"'
                                                       ,'" + prodcode + @"'
                                                       ,'" + descripitem + @"'
                                                       ,"+ quantityplan + @"
                                                       ,'0'
                                                       ,0
                                                       ,0
                                                       ,1
                                                       ,10
                                                       ," + tipoo + @"
                                                       ,'  '
                                                       ,null
                                                       ," + bit + @", SYSDATETIME(),"+lineoforder+@" );";
                            cmd.CommandText = QUERY;
                            cmd.ExecuteNonQuery();
                        string Query = @"UPDATE [dbo].[conf_tables_id]
                               SET
                                  [siguiente] = siguiente + 1
                             WHERE id = 3";
                        cmd.CommandText = Query;
                        cmd.ExecuteNonQuery();
                        // Query = @"UPDATE [dbo].[conf_tables_id]
                        //       SET
                        //          [siguiente] = siguiente + 1
                        //     WHERE id = 9";
                        //cmd.CommandText = Query;
                        //cmd.ExecuteNonQuery();
                        trans.Commit();
                        cn.Close();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                        catch (Exception ex)
                        {
                            try
                            {
                            labelControl1.Text = ex.Message;
                                trans.Rollback();
                            }
                            catch (Exception ex2)
                            {

                                MessageBox.Show(ex2.Message);
                            }
                        }
                    }
                  
                }
                else
                {

                foreach (DataRow row in dSTtracer.ordercompra)
                {
                    if (idofOrder == Convert.ToInt32(row["oc_num"].ToString()))
                    {
                        if (lineoforder == Convert.ToInt32(row["line"].ToString()))
                        {
                            docnum = row["oc_num"].ToString();
                            provecode = row["partner_id"].ToString();
                            descriprove = row["partner_name"].ToString();
                            prodcode = row["default_code"].ToString();
                            descripitem = row["default_code_name"].ToString();
                            comment = row["notes"].ToString();
                            quantityplan = Convert.ToDecimal(row["quantity"].ToString());

                            SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                            try
                            {
                                string Typesugerido = row["default_code"].ToString().Substring(0, 2);
                                if (Typesugerido == "CO" || Typesugerido == "SV" || Typesugerido == "DS" || Typesugerido == "RM" || Typesugerido == "RS") // LOS FILTROS DE ITEMS SE CAMBIAN SEGUN EL TIPO SELECCIONADO.
                                {
                                    Typesugerido = "NA";
                                }

                                cn.Open();
                                string query = @"SELECT top 1 T0.[id] 
                                            FROM [dbo].[M_tipo_op] T0
                                            where T0.enable = 1 and  t0.codigo = '" + Typesugerido + @"'";
                                SqlCommand cmd = new SqlCommand(query, cn);
                                SqlDataReader dr = cmd.ExecuteReader();
                                if (dr.Read())
                                {
                                    tipoo = Convert.ToInt32(dr[0].ToString());
                                }
                                else
                                {
                                    switch (row["default_code"].ToString().Substring(0, 2))
                                    {
                                        case "MP"://Materia Prima
                                            tipoo = 1;
                                            break;
                                        case "CO": //Combustible
                                            tipoo = 3;
                                            break;
                                        case "ME": // Material de empaque
                                            tipoo = 10;
                                            break;
                                        case "SV": //Servicios
                                            tipoo = 6;
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
                                    cn.Close();
                                }
                                cn.Close();
                            }
                            catch (Exception ex)
                            {
                                switch (row["default_code"].ToString().Substring(0, 2))
                                {
                                    case "MP"://Materia Prima
                                        tipoo = 1;
                                        break;
                                    case "CO": //Combustible
                                        tipoo = 3;
                                        break;
                                    case "ME": // Material de empaque
                                        tipoo = 10;
                                        break;
                                    case "SV": //Servicios
                                        tipoo = 6;
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
                            }
                            if (Convert.ToBoolean(row["Granel"].ToString()))
                            {
                                if (row["default_code"].ToString().Substring(0, 2) == "MP")
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
                        }
                    }
                }
                string QUERY = @"";
                using (SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula))
                {
                    cn.Open();
                    SqlCommand cmd = cn.CreateCommand();
                    SqlTransaction trans;
                    if (comment.Length > 150)
                    {
                        comment = comment.Substring(0, 150);
                    }
                    trans = cn.BeginTransaction("SampleTransaction");
                    cmd.Connection = cn;
                    cmd.Transaction = trans;
                    cmd.CommandText = QUERY;
                    try
                    {

                        QUERY = @"INSERT INTO [dbo].[DC_workplan_d]
                                                       ([docnum]
                                                       ,[shipid_d]
                                                       ,[provecode]
                                                       ,[descriprove]
                                                       ,[prodcode]
                                                       ,[descripitem]
                                                       ,[quantityplan]
                                                       ,[unt]
                                                       ,[printed]
                                                       ,[idconfvehi]
                                                       ,[enable]
                                                       ,[status]
                                                       ,[typeid]
                                                       ,[comment]
                                                       ,[idh]
                                                       ,[granel]
                                                    ,[dateplanarribe],[line])
                                                 VALUES
                                                       ('" + docnum + @"'
                                                       ,null
                                                       ,'" + provecode + @"'
                                                       ,'" + descriprove + @"'
                                                       ,'" + prodcode + @"'
                                                       ,'" + descripitem + @"'
                                                       ,"+ quantityplan + @"
                                                       ,'0'
                                                       ,0
                                                       ,0
                                                       ,1
                                                       ,10
                                                       ," + tipoo + @"
                                                       ,'" + comment + @"'
                                                       ," + idofplan + @"
                                                       ," + bit + @", SYSDATETIME(), "+ lineoforder + @");";
                        cmd.CommandText = QUERY;
                        cmd.ExecuteNonQuery();
                        // string Query = @"UPDATE [dbo].[conf_tables_id]
                        //       SET
                        //          [siguiente] = siguiente + 1
                        //     WHERE id = 9";
                        //cmd.CommandText = Query;
                        //cmd.ExecuteNonQuery();
                        trans.Commit();

                        cn.Close();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            labelControl1.Text = ex.Message;
                            trans.Rollback();
                        }
                        catch (Exception ex2)
                        {

                            MessageBox.Show(ex2.Message);
                        }
                    }
                }
            }
          
        }

        private void btnOnlyacar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula))
            {
                
                string codigoP = dp.Nexcode(3);
                string QUERY = @"INSERT INTO [dbo].[DC_workplan_h]
                                       ([codigo]
                                       ,[withship]
                                       ,[shipid]
                                       ,[date_create]
                                       ,[date_inicio]
                                       ,[date_fin]
                                       ,[close]
                                       ,[comment]
                                       ,[tonaprox]
                                       ,[enable])
                                 VALUES
                                       ('" + codigoP + @"'
                                       ,0
                                       ,null
                                       ,SYSDATETIME()
                                       ,SYSDATETIME()
                                       ,SYSDATETIME()
                                       ,0
                                       ,'Vehiculo en espera de Producto Terminado' 
                                       ,0
                                       ,1) Select SCOPE_IDENTITY();";
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                SqlTransaction trans;
                trans = cn.BeginTransaction("SampleTransaction");
                cmd.Connection = cn;
                cmd.Transaction = trans;
                cmd.CommandText = QUERY;
                try
                {
                    cmd.CommandText = QUERY;
                    int IdInserted = Convert.ToInt32(cmd.ExecuteScalar());
                    QUERY = @"INSERT INTO [dbo].[DC_workplan_d]
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
                                           ,[idh]
                                           ,[granel])
                                     VALUES
                                           (0
                                           ,0
                                           ,'CL0000'
                                           ,'Por Asignar'
                                           ,'PT0000'
                                           ,'Producto Terminado'
                                           ,0
                                           ,'0'
                                           ,SYSDATETIME()
                                           ,0
                                           ,0
                                           ,1
                                           ,10
                                           ,2
                                           ,'En espera de Asignacion de producto'
                                           ,"+ IdInserted + @"
                                           ,0)";
                    cmd.CommandText = QUERY;
                    cmd.ExecuteNonQuery();
                    //string  Query = @"UPDATE [dbo].[conf_tables_id]
                    //           SET
                    //              [siguiente] = siguiente + 1
                    //         WHERE id = 9";
                    //cmd.CommandText = Query;
                    //cmd.ExecuteNonQuery();
                    trans.Commit();
                    cn.Close();
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (Exception ex)
                {

                    try
                    {
                        labelControl1.Text = ex.Message;
                        trans.Rollback();
                    }
                    catch (Exception ex2)
                    {

                        MessageBox.Show(ex2.Message);
                    }
                }
            }
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
