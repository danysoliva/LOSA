using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.MigracionACS.SAR
{
    class OrdenSAP
    {
        public int Parid;
        public int DocEntry;
        public int DocNum;
        public string Cardcode;
        public string CardName;
        public string moneda;
        public decimal tasa;
        public DateTime Datecont;
        public int Tipo;
        public string comentario;
        public decimal Totaldoc;
        public DataTable dt;
        public string OCEXO;
        public Boolean IsON;
        DataOperations dp = new DataOperations();
        public OrdenSAP(int IdACS)
        {
            Parid = IdACS;
            load_data();
            inizialiar_table();
            load_detalle();
        }
        public void inizialiar_table()
        {
            dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("LineNum", typeof(int));
            dt.Columns.Add("ItemCode", typeof(string));
            dt.Columns.Add("ItemName", typeof(string));
            dt.Columns.Add("Cantidad", typeof(decimal));
            dt.Columns.Add("rubro", typeof(int));
            dt.Columns.Add("capitulo", typeof(string));
            dt.Columns.Add("precioU", typeof(decimal));
            dt.Columns.Add("txtlegal", typeof(string));
            dt.Columns.Add("SacosU", typeof(string));
            dt.Columns.Add("Totallinea", typeof(decimal));

        }
        public void load_detalle()
        {
            string Query = @"SELECT  T0.[id]
                              ,T0.[LineNum]
                              ,T0.[ItemCode]
                              ,T0.[ItemName]
                              ,T0.[Cantidad]
                              ,COALESCE(T0.[rubro],0) as rubro
                              ,coalesce(T0.[capitulo], '0') as capitulo
                              ,T0.[precioU]
                              ,T0.[txtlegal]
                              ,T0.[SacosU]
                              ,T0.[Totallinea]
                          FROM [dbo].[SAR_Order_D] T0 join [dbo].SAR_Order_H T1 ON T1.id = T0.idH AND T1.enable = 1						  
						  where T0.idh = @Idload";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.Parameters.Add("@Idload", SqlDbType.Int).Value = Parid;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }
        public void load_data()
        {
            string Query = @"SELECT Coalesce(T0.[DocNum],0) as DocNum --0
                              ,Coalesce(T0.[CardCode],' ') as CardCode --1
                              ,T0.[CardName] --2
                              ,T0.[moneda] --3
                              ,Coalesce(T0.[Tasa],0) as Tasa --4
                              ,T0.[datecont] --5
                              ,T0.[datadoc] --6
                              ,T0.[id_tipo] --7
                              ,T0.[comment] --8
                              ,(Select Sum(T1.Totallinea) from [dbo].[SAR_Order_D] T1 Where T1.idH = T0.id) -- 9
                              ,T0.[docdate] --10
                                ,Coalesce(T0.DocEntry,0) as DocEntry --11
                                ,Coalesce(T0.oc_exo,'No config') -- 12
                                ,T0.Enable --13
                          FROM [dbo].[SAR_Order_H] T0
                          where id = @IDofACS";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query,cn);
                cmd.Parameters.Add("@IDofACS", SqlDbType.Int).Value = Parid;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    DocNum = Convert.ToInt32(dr[0].ToString());
                    Cardcode = Convert.ToString(dr[1].ToString());
                    CardName = Convert.ToString(dr[2].ToString());
                    moneda = dr[3].ToString();
                    tasa = Convert.ToDecimal(dr[4].ToString());
                    Datecont = Convert.ToDateTime(dr[5].ToString());
                    Tipo = Convert.ToInt32(dr[7].ToString());
                    comentario = dr[8].ToString();
                    Totaldoc = Convert.ToDecimal(dr[9].ToString());
                    DocEntry = Convert.ToInt32(dr[11].ToString());
                    OCEXO = dr[12].ToString();
                    IsON = Convert.ToBoolean(dr[13].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}
