using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.Ttracer
{
    public partial class TT_Shipselect : Form
    {
       public int Selectid;
        DataOperations dp = new DataOperations();
        string codigouser;
        public TT_Shipselect(string codigouser)
        {
            InitializeComponent();
            this.codigouser = codigouser;
            load_data_de_barco_para_crear_un_plan();
        }
        public void load_data_de_barco_para_crear_un_plan()
        {
            string query = @"Select 
	                        T2.descripcion as Nbarco
	                        ,T1.id as idplan
	                        ,T2.codigo as CodigoB
	                        ,T1.date_begin as dtini
	                        ,T1.date_create as dtfin
	                        ,T1.quantity as Camiones
	                        ,T1.peso as peso
	                        ,Case when T1.quantity <> null then T1.peso / 1
	                        When T1.quantity = 0 then T1.peso / 1
	                        when T1.quantity > 0 then T1.peso / T1.quantity end as CntxCamion
                        From TS_ship_h T1 join M_ship T2 on T1.shipid = T2.id
                        where T1.enable = 1 and t2.enable = 1 and t1.[close] = 0
                        and T1.date_begin >= SYSDATETIME()";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dSTtracer.shipArrib.Clear();
                da.Fill(dSTtracer.shipArrib);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            //Abrira un pequeño formulario que muestre el detalle
            var GridView = (GridView)grd_ship.FocusedView;
            var row = (dSTtracer.shipArribRow)GridView.GetFocusedDataRow();
            Selectid = row.idplan;
            TT_showdetalleship show = new TT_showdetalleship(Selectid);
            if (show.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            var GridView = (GridView)grd_ship.FocusedView;
            var row = (dSTtracer.shipArribRow)GridView.GetFocusedDataRow();
            Selectid = row.idplan;
            SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
            //Validacion de ingreso a la oc
            #region V I T A C O R A   D E  O C.
            Boolean alreadyexis = false;
            DataTable dt;
            dt = new DataTable();
            dt.Columns.Add("DocEntry", typeof(int));
            dt.Columns.Add("LineNum", typeof(int));

            string Qry = "";
            int Docnum = 0;
            int linemun = 0;
            Qry = @"Select T1.DocNum
		,T1.Linenum
		from TS_ship_d T1 Join TS_ship_h T0 on T1.id_shiph = T0.id where T1.id_shiph = " + Selectid;

            SqlConnection cnn = new SqlConnection(dp.ConnectionStringBascula);
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(Qry, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                   Docnum = Convert.ToInt32(dr[0].ToString());
                    linemun = Convert.ToInt32(dr[1].ToString());
                }
                cnn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            Qry = @"SELECT 
                  [DocEntry]
                  ,[LineNum]
              FROM [dbo].[oc_trans_bas]
              where enable = 1 and DocEntry =" + Docnum;
            cnn = new SqlConnection(dp.ConnectionStringBascula);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Qry, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                foreach (DataRow rows in dt.Rows)
                {
                    if (linemun.ToString() == rows["LineNum"].ToString())
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
                                           (Select T1.DocNum
		                                    ,t1.Linenum
		                                    ,T0.quantity
		                                    ,T0.date_create
		                                    ,T1.CardCode
		                                    ,T1.Cardname
		                                    ,T1.Comment
		                                    ,T1.ItemCode
		                                    ,T1.ItemName
		                                    ,T1.granel
		                                    ,1
		                                    ,0
		                                    from TS_ship_d T1 Join TS_ship_h T0 on T1.id_shiph = T0.id where T1.id_shiph = " + Selectid + ")";
            cn = new SqlConnection(dp.ConnectionStringBascula);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Qry, cn);
                if (alreadyexis)
                {

                }
                else
                {
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar data de la OC." + ex.Message);
                return;
            }
            #endregion
            string newplan = dp.Nexcode(3);
            string queryable = @"INSERT INTO [dbo].[DC_workplan_h]
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
                                               ('"+newplan+@"'
                                               ,1
                                               ,"+ Selectid + @"
                                               ,SYSDATETIME()
                                               ,'"+row.dtini.ToString("yyyy-MM-dd hh:mm:ss")+ @"'
                                               ,'" + row.dtfin.ToString("yyyy-MM-dd hh:mm:ss") + @"'
                                               ,0
                                               ,'Plan Activado para la fecha: "+row.dtini+@" y termina a la fecha: "+row.dtfin+@"'
                                               ,"+row.peso+@"
                                               ,1) SELECT SCOPE_IDENTITY()";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(queryable, cn);
                int Id = Convert.ToInt32(cmd.ExecuteScalar());


                for (int i = 0; i < row.Camiones; i++)
                {

                    string QUERY = @"INSERT INTO [dbo].[DC_workplan_d]
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
                                               ,[enable]
                                               ,[status]
                                               ,[typeid]
                                               ,[comment]
                                               ,[idh]
                                               ,[codigoGen]
                                               ,[granel]
                                               ,[line]
                                               ,[idconductor])
                                         
                                               (Select T1.DocNum
		                                       ,T1.id
		                                       ,T1.CardCode
		                                       ,T1.Cardname
		                                       ,T1.ItemCode
		                                       ,T1.ItemName
		                                       ,COALESCE(t1.[pesoaprox],1)
		                                       ,'0'
		                                       ,T0.date_begin
											   ,0
		                                       ,1
		                                       ,10
		                                       ,coalesce((Select top 1 CASE WHEN  SUBSTRING(T1.ItemCode,0,3) = 'MP'
                                                            then 8 else T2.id end 
                                                            from [M_tipo_op] T2 
                                                            Where SUBSTRING(T1.ItemCode,0,3) = T2.[codigo]),12) as tipo
		                                       ,SUBSTRING(T1.Comment,0,150)
		                                       ," + Id + @"
		                                       ,null
		                                       ,1
		                                       ,t1.Linenum
											   ,null
		                                        from TS_ship_d T1 Join TS_ship_h T0 on T1.id_shiph = T0.id where T1.id_shiph = " + Selectid + ")";
                try
                {
                    cmd = new SqlCommand(QUERY, cn);
                    cmd.ExecuteNonQuery();
                 
                }
                catch (Exception exs)
                {

                        MessageBox.Show(exs.Message);
                }
            }

                string update = @"UPDATE [dbo].[TS_ship_h]
                                           SET 
                                                  [lastmodby] = "+codigouser+@"
                                                  ,[datelastmod] = SYSDATETIME()
                                             WHERE id =" + Selectid;
                cmd = new SqlCommand(update, cn);
                cmd.ExecuteNonQuery();

                cn.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
   
}
