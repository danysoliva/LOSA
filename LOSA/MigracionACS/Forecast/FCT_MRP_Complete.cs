using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.MigracionACS.Forecast;
using LOSA;

namespace ACS.Forecast
{
    public partial class FCT_MRP_Complete : DevExpress.XtraEditors.XtraForm
    {
        #region Developer Defined Variables

        DataOperations dp = new DataOperations();

        public string ActiveUserCode;

        DataSet OutputData = new DataSet();

        DataSet ReportData;

        string kind;
        string SelRecordID;
        UserLogin UsuarioLogeado;

        #endregion

        #region Developer Defined Methods

        private void LoadMRPs()
        {
            try
            {
                cmb_MRPs.Properties.DataSource = dp.ACS_GetSelectData(@"  SELECT A.[id]
                                                                            ,A.[nombre]
                                                                            ,B.[nombre] AS usuario
                                                                        FROM [dbo].[FCT_MRP] A
                                                                    INNER JOIN [dbo].[conf_usuarios] B ON A.[usuario_c] = B.[id]
                                                                        WHERE [status] = 'a'").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proceso ha fallado por completo.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataSet GetIngredientes(string IDFormula)
        {
            try
            {
                Double PesoFormula = 0;
                string FixedQuery = @" SELECT  A.[local_rm] AS 'mpid'
		                                        ,A.[source_inc_kg] AS 'pesokg'
		                                        ,0.0000 AS 'parte_formula'
	                                        FROM [dbo].[FML_Formulas_FF_D] A
                                            INNER JOIN [dbo].[MP_MateriasPrimas] B
	                                            ON COALESCE(A.[local_rm], 0) = B.[id]
	                                        WHERE [id_h] = " + IDFormula + "";

                DataSet mp = new DataSet();
                mp = dp.ACS_GetSelectData(FixedQuery);

                foreach (DataRow row in mp.Tables[0].Rows)
                {
                    PesoFormula += Convert.ToDouble(row["pesokg"].ToString());
                }

                foreach (DataRow row in mp.Tables[0].Rows)
                {
                    Double Percentage = (Convert.ToDouble(row["pesokg"].ToString()) / PesoFormula);
                    row["parte_formula"] = Convert.ToDouble(Percentage.ToString());
                }

                return mp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private DataSet GetProyeccionDetail_Kg(string IDProyeccion)
        {
            try
            {
                DataSet Proyeccion = dp.ACS_GetSelectData(@"  SELECT A.[id]
                                                                ,A.[id_form]
                                                                ,(A.[ene] * 1000) AS ene
                                                                ,(A.[feb] * 1000) AS feb
                                                                ,(A.[mar] * 1000) AS mar
                                                                ,(A.[abr] * 1000) AS abr
                                                                ,(A.[may] * 1000) AS may
                                                                ,(A.[jun] * 1000) AS jun
                                                                ,(A.[jul] * 1000) AS jul
                                                                ,(A.[ago] * 1000) AS ago
                                                                ,(A.[sep] * 1000) AS sep
                                                                ,(A.[oct] * 1000) AS oct
                                                                ,(A.[nov] * 1000) AS nov
                                                                ,(A.[dic] * 1000) AS dic
                                                            FROM [dbo].[FCT_Proyecciones_Venta_D_v2] A
                                                            WHERE A.[id_proy] = " + IDProyeccion + @"");

                return Proyeccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proceso ha fallado por completo.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private DataSet GetConsumos(DataSet proyecciones)
        {
            try
            {
                OutputData = dp.ACS_GetSelectData(@"  SELECT 0 AS id
                                                        ,A.[id] AS id_mp
                                                        ,CONCAT(A.[material],' - Costo Actual: $ ', D.[valor_tm]) AS material
                                                        ,CONCAT(B.[orden], ' - ', B.[tipo]) AS tipo
                                                        ,3 AS kind
                                                        ,'Consumos Proyectados' AS kindN
	                                                    ,0.00000000 AS ene
	                                                    ,0.00000000 AS feb
	                                                    ,0.00000000 AS mar
	                                                    ,0.00000000 AS abr
	                                                    ,0.00000000 AS may
	                                                    ,0.00000000 AS jun
	                                                    ,0.00000000 AS jul
	                                                    ,0.00000000 AS ago
	                                                    ,0.00000000 AS sep
	                                                    ,0.00000000 AS oct
	                                                    ,0.00000000 AS nov
	                                                    ,0.00000000 AS dic
	                                                    ,0.00000000 AS total
                                                    FROM [dbo].[MP_MateriasPrimas] A
                                            INNER JOIN [dbo].[MP_TipoFMateriaPrima] B ON A.[tipof] = B.[id]
                                            INNER JOIN [dbo].[MP_UltimoCosto] D ON A.[id] = D.[idMP]
                                            WHERE A.estado= 'a'
                                            --ORDER BY B.[orden] ASC");

                foreach (DataRow rowProy in proyecciones.Tables[0].Rows)
                {
                    DataSet DatosProyeccion = GetProyeccionDetail_Kg(rowProy["id"].ToString());

                    foreach (DataRow rowP in DatosProyeccion.Tables[0].Rows)
                    {
                        DataSet Ingredientes = GetIngredientes(rowP["id_form"].ToString());
                        foreach (DataRow rowI in Ingredientes.Tables[0].Rows)
                        {
                            foreach (DataRow rowO in OutputData.Tables[0].Rows)
                            {
                                if (rowI["mpid"].ToString() == rowO["id_mp"].ToString())
                                {
                                    rowO["ene"] = (Convert.ToDouble(rowO["ene"].ToString()) + ((Convert.ToDouble(rowP["ene"].ToString()) * Convert.ToDouble(rowI["parte_formula"].ToString())) / (Double)1000));
                                    rowO["feb"] = (Convert.ToDouble(rowO["feb"].ToString()) + ((Convert.ToDouble(rowP["feb"].ToString()) * Convert.ToDouble(rowI["parte_formula"].ToString())) / (Double)1000));
                                    rowO["mar"] = (Convert.ToDouble(rowO["mar"].ToString()) + ((Convert.ToDouble(rowP["mar"].ToString()) * Convert.ToDouble(rowI["parte_formula"].ToString())) / (Double)1000));
                                    rowO["abr"] = (Convert.ToDouble(rowO["abr"].ToString()) + ((Convert.ToDouble(rowP["abr"].ToString()) * Convert.ToDouble(rowI["parte_formula"].ToString())) / (Double)1000));
                                    rowO["may"] = (Convert.ToDouble(rowO["may"].ToString()) + ((Convert.ToDouble(rowP["may"].ToString()) * Convert.ToDouble(rowI["parte_formula"].ToString())) / (Double)1000));
                                    rowO["jun"] = (Convert.ToDouble(rowO["jun"].ToString()) + ((Convert.ToDouble(rowP["jun"].ToString()) * Convert.ToDouble(rowI["parte_formula"].ToString())) / (Double)1000));
                                    rowO["jul"] = (Convert.ToDouble(rowO["jul"].ToString()) + ((Convert.ToDouble(rowP["jul"].ToString()) * Convert.ToDouble(rowI["parte_formula"].ToString())) / (Double)1000));
                                    rowO["ago"] = (Convert.ToDouble(rowO["ago"].ToString()) + ((Convert.ToDouble(rowP["ago"].ToString()) * Convert.ToDouble(rowI["parte_formula"].ToString())) / (Double)1000));
                                    rowO["sep"] = (Convert.ToDouble(rowO["sep"].ToString()) + ((Convert.ToDouble(rowP["sep"].ToString()) * Convert.ToDouble(rowI["parte_formula"].ToString())) / (Double)1000));
                                    rowO["oct"] = (Convert.ToDouble(rowO["oct"].ToString()) + ((Convert.ToDouble(rowP["oct"].ToString()) * Convert.ToDouble(rowI["parte_formula"].ToString())) / (Double)1000));
                                    rowO["nov"] = (Convert.ToDouble(rowO["nov"].ToString()) + ((Convert.ToDouble(rowP["nov"].ToString()) * Convert.ToDouble(rowI["parte_formula"].ToString())) / (Double)1000));
                                    rowO["dic"] = (Convert.ToDouble(rowO["dic"].ToString()) + ((Convert.ToDouble(rowP["dic"].ToString()) * Convert.ToDouble(rowI["parte_formula"].ToString())) / (Double)1000));

                                    //break;
                                }
                            }
                        }
                    }
                }

                if (OutputData.Tables[0].Rows.Count > 0)
                {
                    if (rgrp_Todo.SelectedIndex == 1)
                    {
                        for (int i = 1; i < int.Parse(System.DateTime.Now.Month.ToString()); i++)
                        {
                            foreach (DataRow row in OutputData.Tables[0].Rows)
                            {
                                row[GetMes(i)] = "0.00";
                            }
                        }

                        Double Diario;

                        foreach (DataRow row in OutputData.Tables[0].Rows)
                        {
                            Diario = (Convert.ToDouble(row[GetMes(int.Parse(DateTime.Now.Month.ToString()))].ToString()) / DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
                            row[GetMes(int.Parse(DateTime.Now.Month.ToString()))] = (Convert.ToDouble(row[GetMes(int.Parse(DateTime.Now.Month.ToString()))].ToString()) - (Diario * DateTime.Now.Day));
                        }
                    }

                    foreach (DataRow row in OutputData.Tables[0].Rows)
                    {
                        row["total"] = (Convert.ToDouble(row["ene"].ToString()) + Convert.ToDouble(row["feb"].ToString()) + Convert.ToDouble(row["mar"].ToString()) + Convert.ToDouble(row["abr"].ToString()) + Convert.ToDouble(row["may"].ToString()) + Convert.ToDouble(row["jun"].ToString()) + Convert.ToDouble(row["jul"].ToString()) + Convert.ToDouble(row["ago"].ToString()) + Convert.ToDouble(row["sep"].ToString()) + Convert.ToDouble(row["oct"].ToString()) + Convert.ToDouble(row["nov"].ToString()) + Convert.ToDouble(row["dic"].ToString()));
                    }

                    foreach (DataRow row in OutputData.Tables[0].Rows)
                    {
                        if (row["total"].ToString() == "0.00000000")
                        {
                            //OutputData.Tables[0].Rows.Remove(row);
                            row.Delete();
                        }
                    }
                }

                return OutputData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información. \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private string GetMes(int MesNum)
        {
            string mes = "";

            switch (MesNum)
            {
                case 1:
                    mes = "ene";
                    break;
                case 2:
                    mes = "feb";
                    break;
                case 3:
                    mes = "mar";
                    break;
                case 4:
                    mes = "abr";
                    break;
                case 5:
                    mes = "may";
                    break;
                case 6:
                    mes = "jun";
                    break;
                case 7:
                    mes = "jul";
                    break;
                case 8:
                    mes = "ago";
                    break;
                case 9:
                    mes = "sep";
                    break;
                case 10:
                    mes = "oct";
                    break;
                case 11:
                    mes = "nov";
                    break;
                case 12:
                    mes = "dic";
                    break;
            }

            return mes;
        }

        private void LoadReportInfo() 
        {
            /*
             1 = Inventario Inicial 
             2 = Compras
             3 = Consumos
             4 = Inventario Final
             5 = DPI
             */

            try
            {
                //SplashScreenManager.ShowForm(typeof(WaitForm1));

                //Evaluar si se requiere actualizar alguna materia prima
                string id_mrp = cmb_MRPs.EditValue.ToString();
                string sql = @"SELECT distinct ff.id as 'id_mat_prima'
                                FROM [dbo].[FCT_Proyecciones_Venta_D_v2] dd inner join
                                 [dbo].[FML_Formulas_FF_D] ee on dd.id_form = ee.id_h inner join
                                 [dbo].[MP_MateriasPrimas] ff on ee.source_mat_code = ff.codigo inner join
                                 [dbo].[FCT_MRP_Proyecciones_v2] gg on dd.id_proy = gg.id_pro
                                where gg.id_mrp = " + id_mrp + " " + "and " +
                                      "ff.id not in (select distinct dd.id_mp " +
                                      "from [dbo].[FCT_MRP_D] dd " +
                                      "where dd.id_mrp = " + id_mrp + ")";

                DataOperations dp = new DataOperations();
                SqlConnection Conn = new SqlConnection(dp.ConnectionStringCostos);
                Conn.Open();

                SqlCommand cmd = new SqlCommand(sql, Conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    try
                    {
                        //Agregar materias primas
                        while (dr.Read())
                        {
                            int mat_prima = dr.GetInt32(0);
                            for (int i = 1; i <= 4; i++)
                            {
                                #region Comment
                                //dp.ACS_DoSmallDBOperation(@" INSERT INTO [dbo].[FCT_MRP_PREV_D]
                                //                           ([id_mrp]
                                //                           ,[id_mp]
                                //                           ,[kind]
                                //                           ,[ene]
                                //                           ,[feb]
                                //                           ,[mar]
                                //                           ,[abr]
                                //                           ,[may]
                                //                           ,[jun]
                                //                           ,[jul]
                                //                           ,[ago]
                                //                           ,[sep]
                                //                           ,[oct]
                                //                           ,[nov]
                                //                           ,[dic])
                                //                        VALUES(" + id_mrp + @"
                                //                           ," + mat_prima.ToString() + @"
                                //                           ," + i.ToString() + @"
                                //                           ,0.0000
                                //                           ,0.0000
                                //                           ,0.0000
                                //                           ,0.0000
                                //                           ,0.0000
                                //                           ,0.0000
                                //                           ,0.0000
                                //                           ,0.0000
                                //                           ,0.0000
                                //                           ,0.0000
                                //                           ,0.0000
                                //                           ,0.0000)");
                                #endregion
                                //DataOperations dp = new DataOperations();
                                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                                con.Open();

                                SqlCommand cmdq = new SqlCommand("sp_get_listado_estados", con);
                                cmdq.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@idmrp", id_mrp);
                                cmd.Parameters.AddWithValue("@idmp", mat_prima);
                                cmd.Parameters.AddWithValue("@kind", i);
                                //cmdq.ExecuteNonQuery();

                                con.Close();

                            }
                        }
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                dr.Close();

                Conn.Close();


                //Saca el listado de materias primas
                DataSet RawMat = dp.ACS_GetSelectData(@"SELECT DISTINCT [id_mp]
                                                      FROM [dbo].[FCT_MRP_D]
                                                     WHERE [id_mrp] = " + cmb_MRPs.EditValue.ToString() + "");

                //DataSet IniStructure = dp.ACS_GetSelectData(@"  SELECT A.[id]
                //                                                  ,A.[id_mp]
                //                                               ,CONCAT(B.[material],' - Costo Actual: $ ', D.[valor_tm]) AS material
                //                                                  ,CONCAT(C.[orden], ' - ', C.[tipo]) AS tipo
                //                                                  ,A.[kind]
                //                                               ,(CASE A.[kind] WHEN 1 THEN 'Inventario Inicial' WHEN 2 THEN 'Compras / En Transito' END) AS kindN
                //                                                  ,A.[ene]
                //                                                  ,A.[feb]
                //                                                  ,A.[mar]
                //                                                  ,A.[abr]
                //                                                  ,A.[may]
                //                                                  ,A.[jun]
                //                                                  ,A.[jul]
                //                                                  ,A.[ago]
                //                                                  ,A.[sep]
                //                                                  ,A.[oct]
                //                                                  ,A.[nov]
                //                                                  ,A.[dic]
                //                                                  ,0.00000 AS total
                //                                              FROM [dbo].[FCT_MRP_D] A
                //                                              INNER JOIN [dbo].[MP_MateriasPrimas] B ON A.[id_mp] = B.[id]
                //                                              INNER JOIN [dbo].[MP_TipoFMateriaPrima] C ON B.[tipof] = C.[id]
                //                                              INNER JOIN [dbo].[MP_UltimoCosto] D ON B.[id] = D.[idMP]
                //                                             WHERE [id_mrp] = " + cmb_MRPs.EditValue.ToString() + @"
                //                                             --ORDER BY C.[orden] ASC, A.[kind]");


                //DataSet IniStructure = dp.ACS_GetSelectData(@" select *
                //                                                 from(

                //                                                   SELECT A.[id]
                //                                                    ,A.[id_mp]
                //                                                    ,CONCAT(B.[material],' - Costo Actual: $ ', D.[valor_tm]) AS material
                //                                                    ,CONCAT(C.[orden], ' - ', C.[tipo]) AS tipo
                //                                                    ,A.[kind]
                //                                                    ,(CASE A.[kind] WHEN 1 THEN 'Inventario Inicial' WHEN 2 THEN 'Compras / En Transito' END) AS kindN
                //                                                    ,A.[ene]
                //                                                    ,A.[feb]
                //                                                    ,A.[mar]
                //                                                    ,A.[abr]
                //                                                    ,A.[may]
                //                                                    ,A.[jun]
                //                                                    ,A.[jul]
                //                                                    ,A.[ago]
                //                                                    ,A.[sep]
                //                                                    ,A.[oct]
                //                                                    ,A.[nov]
                //                                                    ,A.[dic]
                //                                                    ,0.00000 AS total
                //                                                   FROM [dbo].[FCT_MRP_D] A
                //                                                   INNER JOIN [dbo].[MP_MateriasPrimas] B ON A.[id_mp] = B.[id]
                //                                                   INNER JOIN [dbo].[MP_TipoFMateriaPrima] C ON B.[tipof] = C.[id]
                //                                                   INNER JOIN [dbo].[MP_UltimoCosto] D ON B.[id] = D.[idMP]
                //                                                   WHERE [id_mrp] = " + cmb_MRPs.EditValue.ToString() + @"

                //                                                   union all 

                //                                                   select 0 as id,* 
                //                                                   from(
                //                                                   SELECT   distinct A.[id_mp]
                //                                                     ,B.[material] AS material
                //                                                     ,CONCAT(C.[orden], ' - ', C.[tipo]) AS tipo
                //                                                     ,6 as [kind]
                //                                                     ,'Consumo Real'  AS kindN
                //                                                     ,dbo.sp_get_consumo_real_by_id_rm(1, MRP.year, A.id_mp) as ene
                //                                                     ,dbo.sp_get_consumo_real_by_id_rm(2, MRP.year, A.id_mp) as[feb]
                //                                                     ,dbo.sp_get_consumo_real_by_id_rm(3, MRP.year, A.id_mp) as[mar]
                //                                                     ,dbo.sp_get_consumo_real_by_id_rm(4, MRP.year, A.id_mp) as[abr]
                //                                                     ,dbo.sp_get_consumo_real_by_id_rm(5, MRP.year, A.id_mp) as[may]
                //                                                     ,dbo.sp_get_consumo_real_by_id_rm(6, MRP.year, A.id_mp) as[jun]
                //                                                     ,dbo.sp_get_consumo_real_by_id_rm(7, MRP.year, A.id_mp) as[jul]
                //                                                     ,dbo.sp_get_consumo_real_by_id_rm(8, MRP.year, A.id_mp) as[ago]
                //                                                     ,dbo.sp_get_consumo_real_by_id_rm(9, MRP.year, A.id_mp) as[sep]
                //                                                     ,dbo.sp_get_consumo_real_by_id_rm(10, MRP.year, A.id_mp) as[oct]
                //                                                     ,dbo.sp_get_consumo_real_by_id_rm(11, MRP.year, A.id_mp) as[nov]
                //                                                     ,dbo.sp_get_consumo_real_by_id_rm(12, MRP.year, A.id_mp) as[dic]
                //                                                     --,0.00000 AS total
                //                                                     ,dbo.sp_get_consumo_real_by_id_rm_total(MRP.year, A.id_mp) as[total]
                //                                                    FROM [dbo].[FCT_MRP_D] A
                //                                                      JOIN [dbo].[MP_MateriasPrimas] B ON A.[id_mp] = B.[id]
                //                                                      JOIN [dbo].[MP_TipoFMateriaPrima] C ON B.[tipof] = C.[id]
                //                                                     --INNER JOIN [dbo].[MP_UltimoCosto] D ON B.[id] = D.[idMP]
                //                                                     JOIN [dbo].[FCT_MRP] MRP on MRP.id = A.id_mrp 
                //                                                    WHERE [id_mrp] = " + cmb_MRPs.EditValue.ToString() + @") as tableConsumoReal

                //                                                 )as megaRMP order by 4,2 asc");
                DataSet IniStructure = new DataSet();
                try
                {
                    //DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                    con.Open();

                    SqlCommand cmdy = new SqlCommand("sp_get_mrp_complete_purchase_analysis", con);
                    cmdy.CommandType = CommandType.StoredProcedure;
                    cmdy.Parameters.AddWithValue("@mrp_id", cmb_MRPs.EditValue);
                    //dsPresupuesto1.estados.Clear();
                    SqlDataAdapter adat = new SqlDataAdapter(cmdy);
                    adat.Fill(IniStructure);
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }

                ReportData = IniStructure.Clone();

                DataSet Consumos = GetConsumos(dp.ACS_GetSelectData(@"SELECT [id_pro] AS id
                                                                    FROM [dbo].[FCT_MRP_Proyecciones_v2]
                                                                   WHERE [id_mrp] = " + cmb_MRPs.EditValue.ToString() + ""));

                //Double InvInicial = 0;
                //Double Compras = 0;
                DataSet InvFinA = ReportData.Clone();
                bool isFirst = false;


                DataSet InvIni = ReportData.Clone();
                DataSet Compra = ReportData.Clone();
                DataSet Consum = ReportData.Clone();
                DataSet InvFin = ReportData.Clone();
                DataSet ConsReal = ReportData.Clone();

                string mes;
                string InvIniRowID = "x";


                //foreach (DataRow rowMP in RawMat.Tables[0].Rows) 
                //{
                //    foreach (DataRow rowMPR in IniStructure.Tables[0].Rows) 
                //    {
                //        if (rowMPR["id_mp"].ToString() == rowMP["id_mp"].ToString()) 
                //        {
                //            if (rowMPR["kind"].ToString() == "1") 
                //            {
                //                ReportData.Tables[0].Rows.Add(rowMPR.ItemArray);
                //            }
                //            else if (rowMPR["kind"].ToString() == "2") 
                //            {
                //                ReportData.Tables[0].Rows.Add(rowMPR.ItemArray);

                //                foreach (DataRow rowCon in Consumos.Tables[0].Rows) 
                //                {
                //                    if (rowCon.RowState != DataRowState.Deleted)
                //                    {
                //                        if (rowCon["id_mp"].ToString() == rowMP["id_mp"].ToString())
                //                        {
                //                            ReportData.Tables[0].Rows.Add(rowCon.ItemArray);

                //                            rowCon["id"] = 0;
                //                            rowCon["kind"] = 4;
                //                            rowCon["kindN"] = "Inventario Final";
                //                            rowCon["ene"] = 0.0000;
                //                            rowCon["feb"] = 0.0000;
                //                            rowCon["mar"] = 0.0000;
                //                            rowCon["abr"] = 0.0000;
                //                            rowCon["may"] = 0.0000;
                //                            rowCon["jun"] = 0.0000;
                //                            rowCon["jul"] = 0.0000;
                //                            rowCon["ago"] = 0.0000;
                //                            rowCon["sep"] = 0.0000;
                //                            rowCon["oct"] = 0.0000;
                //                            rowCon["nov"] = 0.0000;
                //                            rowCon["dic"] = 0.0000;
                //                            rowCon["total"] = 0.0000;

                //                            ReportData.Tables[0].Rows.Add(rowCon.ItemArray);

                //                            rowCon["id"] = 0;
                //                            rowCon["kind"] = 5;
                //                            rowCon["kindN"] = "DPI";
                //                            rowCon["ene"] = 0.00;
                //                            rowCon["feb"] = 0.00;
                //                            rowCon["mar"] = 0.00;
                //                            rowCon["abr"] = 0.00;
                //                            rowCon["may"] = 0.00;
                //                            rowCon["jun"] = 0.00;
                //                            rowCon["jul"] = 0.00;
                //                            rowCon["ago"] = 0.00;
                //                            rowCon["sep"] = 0.00;
                //                            rowCon["oct"] = 0.00;
                //                            rowCon["nov"] = 0.00;
                //                            rowCon["dic"] = 0.00;
                //                            rowCon["total"] = 0.00;

                //                            ReportData.Tables[0].Rows.Add(rowCon.ItemArray);
                //                        }
                //                    }
                //                }
                //            }
                //        }
                //    }

                //    //foreach (DataRow rowRD in ReportData.Tables[0].Rows) 
                //    //{
                //    //    if (rowRD["id_mp"].ToString() == rowMP["id_mp"].ToString()) 
                //    //    {
                //    //        if (rowRD["kind"].ToString() == "1") 
                //    //        {

                //    //            rowRD["total"] = (Convert.ToDouble(rowRD["ene"].ToString()) + Convert.ToDouble(rowRD["feb"].ToString()) + Convert.ToDouble(rowRD["mar"].ToString()) + Convert.ToDouble(rowRD["abr"].ToString()) + Convert.ToDouble(rowRD["may"].ToString()) + Convert.ToDouble(rowRD["jun"].ToString()) + Convert.ToDouble(rowRD["jul"].ToString()) + Convert.ToDouble(rowRD["ago"].ToString()) + Convert.ToDouble(rowRD["sep"].ToString()) + Convert.ToDouble(rowRD["oct"].ToString()) + Convert.ToDouble(rowRD["nov"].ToString()) + Convert.ToDouble(rowRD["dic"].ToString()));
                //    //            InvIni.Tables[0].Rows.Add(rowRD.ItemArray);
                //    //            InvIniRowID = rowRD["id"].ToString();
                //    //        }
                //    //        else if (rowRD["kind"].ToString() == "2")
                //    //        {
                //    //            rowRD["total"] = (Convert.ToDouble(rowRD["ene"].ToString()) + Convert.ToDouble(rowRD["feb"].ToString()) + Convert.ToDouble(rowRD["mar"].ToString()) + Convert.ToDouble(rowRD["abr"].ToString()) + Convert.ToDouble(rowRD["may"].ToString()) + Convert.ToDouble(rowRD["jun"].ToString()) + Convert.ToDouble(rowRD["jul"].ToString()) + Convert.ToDouble(rowRD["ago"].ToString()) + Convert.ToDouble(rowRD["sep"].ToString()) + Convert.ToDouble(rowRD["oct"].ToString()) + Convert.ToDouble(rowRD["nov"].ToString()) + Convert.ToDouble(rowRD["dic"].ToString()));
                //    //            Compra.Tables[0].Rows.Add(rowRD.ItemArray);
                //    //        }
                //    //        else if (rowRD["kind"].ToString() == "3")
                //    //        {
                //    //            Consum.Tables[0].Rows.Add(rowRD.ItemArray);
                //    //        }

                //    //        else if (rowRD["kind"].ToString() == "4")
                //    //        {
                //    //            rowRD["ene"] = ((Convert.ToDouble(InvIni.Tables[0].Rows[0]["ene"].ToString()) + Convert.ToDouble(Compra.Tables[0].Rows[0]["ene"].ToString())) - Convert.ToDouble(Consum.Tables[0].Rows[0]["ene"].ToString()));
                //    //            rowRD["feb"] = ((Convert.ToDouble(InvIni.Tables[0].Rows[0]["feb"].ToString()) + Convert.ToDouble(Compra.Tables[0].Rows[0]["feb"].ToString())) - Convert.ToDouble(Consum.Tables[0].Rows[0]["feb"].ToString()));
                //    //            rowRD["mar"] = ((Convert.ToDouble(InvIni.Tables[0].Rows[0]["mar"].ToString()) + Convert.ToDouble(Compra.Tables[0].Rows[0]["mar"].ToString())) - Convert.ToDouble(Consum.Tables[0].Rows[0]["mar"].ToString()));
                //    //            rowRD["abr"] = ((Convert.ToDouble(InvIni.Tables[0].Rows[0]["abr"].ToString()) + Convert.ToDouble(Compra.Tables[0].Rows[0]["abr"].ToString())) - Convert.ToDouble(Consum.Tables[0].Rows[0]["abr"].ToString()));
                //    //            rowRD["may"] = ((Convert.ToDouble(InvIni.Tables[0].Rows[0]["may"].ToString()) + Convert.ToDouble(Compra.Tables[0].Rows[0]["may"].ToString())) - Convert.ToDouble(Consum.Tables[0].Rows[0]["may"].ToString()));
                //    //            rowRD["jun"] = ((Convert.ToDouble(InvIni.Tables[0].Rows[0]["jun"].ToString()) + Convert.ToDouble(Compra.Tables[0].Rows[0]["jun"].ToString())) - Convert.ToDouble(Consum.Tables[0].Rows[0]["jun"].ToString()));
                //    //            rowRD["jul"] = ((Convert.ToDouble(InvIni.Tables[0].Rows[0]["jul"].ToString()) + Convert.ToDouble(Compra.Tables[0].Rows[0]["jul"].ToString())) - Convert.ToDouble(Consum.Tables[0].Rows[0]["jul"].ToString()));
                //    //            rowRD["ago"] = ((Convert.ToDouble(InvIni.Tables[0].Rows[0]["ago"].ToString()) + Convert.ToDouble(Compra.Tables[0].Rows[0]["ago"].ToString())) - Convert.ToDouble(Consum.Tables[0].Rows[0]["ago"].ToString()));
                //    //            rowRD["sep"] = ((Convert.ToDouble(InvIni.Tables[0].Rows[0]["sep"].ToString()) + Convert.ToDouble(Compra.Tables[0].Rows[0]["sep"].ToString())) - Convert.ToDouble(Consum.Tables[0].Rows[0]["sep"].ToString()));
                //    //            rowRD["oct"] = ((Convert.ToDouble(InvIni.Tables[0].Rows[0]["oct"].ToString()) + Convert.ToDouble(Compra.Tables[0].Rows[0]["oct"].ToString())) - Convert.ToDouble(Consum.Tables[0].Rows[0]["oct"].ToString()));
                //    //            rowRD["nov"] = ((Convert.ToDouble(InvIni.Tables[0].Rows[0]["nov"].ToString()) + Convert.ToDouble(Compra.Tables[0].Rows[0]["nov"].ToString())) - Convert.ToDouble(Consum.Tables[0].Rows[0]["nov"].ToString()));
                //    //            rowRD["dic"] = ((Convert.ToDouble(InvIni.Tables[0].Rows[0]["dic"].ToString()) + Convert.ToDouble(Compra.Tables[0].Rows[0]["dic"].ToString())) - Convert.ToDouble(Consum.Tables[0].Rows[0]["dic"].ToString()));
                //    //            rowRD["total"] = (Convert.ToDouble(rowRD["ene"].ToString()) + Convert.ToDouble(rowRD["feb"].ToString()) + Convert.ToDouble(rowRD["mar"].ToString()) + Convert.ToDouble(rowRD["abr"].ToString()) + Convert.ToDouble(rowRD["may"].ToString()) + Convert.ToDouble(rowRD["jun"].ToString()) + Convert.ToDouble(rowRD["jul"].ToString()) + Convert.ToDouble(rowRD["ago"].ToString()) + Convert.ToDouble(rowRD["sep"].ToString()) + Convert.ToDouble(rowRD["oct"].ToString()) + Convert.ToDouble(rowRD["nov"].ToString()) + Convert.ToDouble(rowRD["dic"].ToString()));
                //    //            InvFin.Tables[0].Rows.Add(rowRD.ItemArray);
                //    //            //InvFinA.Tables[0].Rows.Add(rowRD.ItemArray);

                //    //            foreach (DataRow rowRD2 in ReportData.Tables[0].Rows)
                //    //            {
                //    //                if (rowRD2["id"].ToString() == InvIniRowID && rowRD2["kind"].ToString() == "1")
                //    //                {
                //    //                    for (int i = cmb_meses.SelectedIndex + 1; i <= 11; i++)
                //    //                    {
                //    //                        rowRD2[GetMes(i + 1)] = ((Convert.ToDouble(rowRD2[GetMes(i)].ToString()) + 
                //    //                                                  Convert.ToDouble(Compra.Tables[0].Rows[0][GetMes(i)].ToString())) - 
                //    //                                                  Convert.ToDouble(Consum.Tables[0].Rows[0][GetMes(i)].ToString()));

                //    //                        rowRD[GetMes(i + 1)] = ((Convert.ToDouble(rowRD2[GetMes(i + 1)].ToString()) + 
                //    //                                                 Convert.ToDouble(Compra.Tables[0].Rows[0][GetMes(i + 1)].ToString())) - 
                //    //                                                 Convert.ToDouble(Consum.Tables[0].Rows[0][GetMes(i + 1)].ToString()));
                //    //                    }

                //    //                    rowRD["total"] = (Convert.ToDouble(rowRD["ene"].ToString()) + 
                //    //                                      Convert.ToDouble(rowRD["feb"].ToString()) + 
                //    //                                      Convert.ToDouble(rowRD["mar"].ToString()) + 
                //    //                                      Convert.ToDouble(rowRD["abr"].ToString()) + 
                //    //                                      Convert.ToDouble(rowRD["may"].ToString()) + 
                //    //                                      Convert.ToDouble(rowRD["jun"].ToString()) + 
                //    //                                      Convert.ToDouble(rowRD["jul"].ToString()) + 
                //    //                                      Convert.ToDouble(rowRD["ago"].ToString()) + 
                //    //                                      Convert.ToDouble(rowRD["sep"].ToString()) + 
                //    //                                      Convert.ToDouble(rowRD["oct"].ToString()) + 
                //    //                                      Convert.ToDouble(rowRD["nov"].ToString()) + 
                //    //                                      Convert.ToDouble(rowRD["dic"].ToString()));
                //    //                    InvFin = new DataSet();
                //    //                    InvFin = ReportData.Clone();

                //    //                    InvFin.Tables[0].Rows.Add(rowRD.ItemArray);

                //    //                    //rowRD2["total"] = (Convert.ToDouble(rowRD2["ene"].ToString()) + Convert.ToDouble(rowRD2["feb"].ToString()) + Convert.ToDouble(rowRD2["mar"].ToString()) + Convert.ToDouble(rowRD2["abr"].ToString()) + Convert.ToDouble(rowRD2["may"].ToString()) + Convert.ToDouble(rowRD2["jun"].ToString()) + Convert.ToDouble(rowRD2["jul"].ToString()) + Convert.ToDouble(rowRD2["ago"].ToString()) + Convert.ToDouble(rowRD2["sep"].ToString()) + Convert.ToDouble(rowRD2["oct"].ToString()) + Convert.ToDouble(rowRD2["nov"].ToString()) + Convert.ToDouble(rowRD2["dic"].ToString()));
                //    //                }
                //    //            }
                //    //        }
                //    //        else if (rowRD["kind"].ToString() == "5") 
                //    //        {
                //    //            if (Convert.ToDouble(Consum.Tables[0].Rows[0]["ene"].ToString()) > 0)
                //    //            rowRD["ene"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["ene"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["ene"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 1));

                //    //            if (Convert.ToDouble(Consum.Tables[0].Rows[0]["feb"].ToString()) > 0)
                //    //            rowRD["feb"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["feb"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["feb"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 2));

                //    //            if (Convert.ToDouble(Consum.Tables[0].Rows[0]["mar"].ToString()) > 0)
                //    //            rowRD["mar"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["mar"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["mar"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 3));

                //    //            if (Convert.ToDouble(Consum.Tables[0].Rows[0]["abr"].ToString()) > 0)
                //    //            rowRD["abr"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["abr"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["abr"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 4));

                //    //            if (Convert.ToDouble(Consum.Tables[0].Rows[0]["may"].ToString()) > 0)
                //    //            rowRD["may"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["may"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["may"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 5));

                //    //            if (Convert.ToDouble(Consum.Tables[0].Rows[0]["jun"].ToString()) > 0)
                //    //            rowRD["jun"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["jun"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["jun"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 6));

                //    //            if (Convert.ToDouble(Consum.Tables[0].Rows[0]["jul"].ToString()) > 0)
                //    //            rowRD["jul"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["jul"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["jul"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 7));

                //    //            if (Convert.ToDouble(Consum.Tables[0].Rows[0]["ago"].ToString()) > 0)
                //    //            rowRD["ago"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["ago"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["ago"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 8));

                //    //            if (Convert.ToDouble(Consum.Tables[0].Rows[0]["sep"].ToString()) > 0)
                //    //            rowRD["sep"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["sep"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["sep"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 9));

                //    //            if (Convert.ToDouble(Consum.Tables[0].Rows[0]["oct"].ToString()) > 0)
                //    //            rowRD["oct"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["oct"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["oct"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 10));

                //    //            if (Convert.ToDouble(Consum.Tables[0].Rows[0]["nov"].ToString()) > 0)
                //    //            rowRD["nov"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["nov"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["nov"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 11));

                //    //            if (Convert.ToDouble(Consum.Tables[0].Rows[0]["dic"].ToString()) > 0)
                //    //            rowRD["dic"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["dic"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["dic"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 12));

                //    //            rowRD["total"] = ((Convert.ToDouble(rowRD["ene"].ToString()) + Convert.ToDouble(rowRD["feb"].ToString()) + Convert.ToDouble(rowRD["mar"].ToString()) + Convert.ToDouble(rowRD["abr"].ToString()) + Convert.ToDouble(rowRD["may"].ToString()) + Convert.ToDouble(rowRD["jun"].ToString()) + Convert.ToDouble(rowRD["jul"].ToString()) + Convert.ToDouble(rowRD["ago"].ToString()) + Convert.ToDouble(rowRD["sep"].ToString()) + Convert.ToDouble(rowRD["oct"].ToString()) + Convert.ToDouble(rowRD["nov"].ToString()) + Convert.ToDouble(rowRD["dic"].ToString())) / 12);
                //    //        }
                //    //        else if (rowRD["kind"].ToString() == "6")
                //    //        {
                //    //            ConsReal.Tables[0].Rows.Add(rowRD.ItemArray);
                //    //        }
                //    //    }
                //    //}

                //    InvIni = ReportData.Clone();
                //    Compra = ReportData.Clone();
                //    Consum = ReportData.Clone();
                //    InvFin = ReportData.Clone();
                //}

                //foreach (DataRow row in ReportData.Tables[0].Rows) 
                //{

                //}

                //grd_mrp.DataSource = ReportData.Tables[0];
                grd_mrp.DataSource = IniStructure.Tables[0];
                CheckGroupStatus();

                //SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proceso ha fallado por completo.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckGroupStatus()
        {
            if (rgrp_Grid.SelectedIndex == 0)
            {
                grdv_mrp.ExpandAllGroups();
            }
            else
            {
                grdv_mrp.CollapseAllGroups();
            }
        }

        #endregion

        #region Constructors

        public FCT_MRP_Complete(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
        }

        #endregion

        #region Form Events

        private void FCT_MRPv2_Load(object sender, EventArgs e)
        {
            LoadMRPs();
        }

        private void btn_NewMRP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FCT_MRP_New mrp = new FCT_MRP_New(this.UsuarioLogeado);
            mrp.ActiveUserCode = ActiveUserCode;
            if (mrp.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                LoadMRPs();
            }
        }

        private void cmb_MRPs_EditValueChanged(object sender, EventArgs e)
        {
            LoadReportInfo();
            btn_actuMasiva.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btn_SaveChanges.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btn_export.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btn_Options.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            rgrp_Todo.Enabled = true;
            rgrp_Grid.Enabled = true;
            cmb_meses.Enabled = true;
        }

        private void grdv_mrp_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                //kind = grdv_mrp.GetRowCellValue(e.FocusedRowHandle, col_kind).ToString();
                //SelRecordID = grdv_mrp.GetRowCellValue(e.FocusedRowHandle, col_id).ToString();
            }
            catch { }
        }

        private void grdv_mrp_ShowingEditor(object sender, CancelEventArgs e)
        {
            //switch (kind) 
            //{
            //    case "1":
            //        e.Cancel = false;
            //        break;
            //    case "2":
            //        e.Cancel = false;
            //        break;
            //    case "3":
            //        e.Cancel = true;
            //        break;
            //    case "4":
            //        e.Cancel = true;
            //        break;
            //    case "5":
            //        e.Cancel = true;
            //        break;
            //}
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FCT_TextFileUpload tu = new FCT_TextFileUpload();
            tu.ActiveUserCode = ActiveUserCode;
            tu.SelectedMRP = cmb_MRPs.EditValue.ToString();
            tu.accion = "compras";
            if (tu.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadReportInfo();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                grdv_toExcel.Columns.Clear();

                grd_toExcel.DataSource = dp.ACS_GetSelectData(@"SELECT DISTINCT A.[id_mp]
			                                                           ,B.[codigo]
			                                                           ,B.[material]
			                                                           ,0 AS ene
			                                                           ,0 AS feb
			                                                           ,0 AS mar
			                                                           ,0 AS abr
			                                                           ,0 AS may
			                                                           ,0 AS jun
			                                                           ,0 AS jul
			                                                           ,0 AS ago
			                                                           ,0 AS sep
			                                                           ,0 AS oct
			                                                           ,0 AS nov
			                                                           ,0 AS dic
                                                          FROM [dbo].[FCT_MRP_D] A
                                                        INNER JOIN [dbo].[MP_MateriasPrimas] B ON A.[id_mp] = B.[id]
                                                        WHERE [id_mrp] = " + cmb_MRPs.EditValue.ToString() + @"").Tables[0];

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Archivo de Excel (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grdv_toExcel.ExportToXlsx(dialog.FileName.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proceso ha fallado por completo.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                grdv_toExcel.Columns.Clear();

                grd_toExcel.DataSource = dp.ACS_GetSelectData(@"SELECT DISTINCT A.[id_mp]
			                                                           ,B.[codigo]
			                                                           ,B.[material]
			                                                           ,0 AS Valor_Mes
                                                          FROM [dbo].[FCT_MRP_D] A
                                                        INNER JOIN [dbo].[MP_MateriasPrimas] B ON A.[id_mp] = B.[id]
                                                        WHERE [id_mrp] = " + cmb_MRPs.EditValue.ToString() + @"").Tables[0];

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Archivo de Excel (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grdv_toExcel.ExportToXlsx(dialog.FileName.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proceso ha fallado por completo.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FCT_TextFileUpload tu = new FCT_TextFileUpload();
            tu.ActiveUserCode = ActiveUserCode;
            tu.SelectedMRP = cmb_MRPs.EditValue.ToString();
            tu.accion = "inventario";
            if (tu.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadReportInfo();
            }
        }

        private void btn_SaveChanges_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                foreach (DataRow row in ReportData.Tables[0].Rows) 
                {
                    if (row["kind"].ToString() == "1" || row["kind"].ToString() == "2") 
                    {
                        dp.ACS_DoSmallDBOperation(@"UPDATE [dbo].[FCT_MRP_D]
                                                   SET [ene] = " + row["ene"].ToString() + @"
                                                      ,[feb] = " + row["feb"].ToString() + @"
                                                      ,[mar] = " + row["mar"].ToString() + @"
                                                      ,[abr] = " + row["abr"].ToString() + @"
                                                      ,[may] = " + row["may"].ToString() + @"
                                                      ,[jun] = " + row["jun"].ToString() + @"
                                                      ,[jul] = " + row["jul"].ToString() + @"
                                                      ,[ago] = " + row["ago"].ToString() + @"
                                                      ,[sep] = " + row["sep"].ToString() + @"
                                                      ,[oct] = " + row["oct"].ToString() + @"
                                                      ,[nov] = " + row["nov"].ToString() + @"
                                                      ,[dic] = " + row["dic"].ToString() + @"
                                                 WHERE [id] = " + row["id"].ToString() + " ");
                    }
                }

                MessageBox.Show("Cambios Guardados", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadReportInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los cambios no han podido ser guardados.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rgrp_Todo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReportInfo();
        }

        private void cmb_meses_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReportInfo();
        }

        private void barButtonItem1_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Archivo de Excel (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_mrp.ExportToXlsx(dialog.FileName.ToString());
            }
        }

        private void btn_pdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Archivo PDF (.pdf)|*.pdf";
            dialog.FilterIndex = 0;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_mrp.ExportToPdf(dialog.FileName.ToString());
            }
        }

        private void btn_dpi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));

                DataSet Information = ReportData.Clone();
                DataSet InvFin = ReportData.Clone();
                DataSet Consum = ReportData.Clone();
                int inv = 0;
                int con = 0;
                int gen = 0;

                foreach (DataRow row in ReportData.Tables[0].Rows)
                {
                    if (gen == 0) 
                    {
                        Information.Tables[0].Rows.Add(row.ItemArray);

                        Information.Tables[0].Rows[0]["ene"] = 0;
                        Information.Tables[0].Rows[0]["feb"] = 0;
                        Information.Tables[0].Rows[0]["mar"] = 0;
                        Information.Tables[0].Rows[0]["abr"] = 0;
                        Information.Tables[0].Rows[0]["may"] = 0;
                        Information.Tables[0].Rows[0]["jun"] = 0;
                        Information.Tables[0].Rows[0]["jul"] = 0;
                        Information.Tables[0].Rows[0]["ago"] = 0;
                        Information.Tables[0].Rows[0]["sep"] = 0;
                        Information.Tables[0].Rows[0]["oct"] = 0;
                        Information.Tables[0].Rows[0]["nov"] = 0;
                        Information.Tables[0].Rows[0]["dic"] = 0;

                        gen++;
                    }

                    if (row["kind"].ToString() == "3") //Acumula Consumos
                    {
                        if (con == 0)
                        {
                            Consum.Tables[0].Rows.Add(row.ItemArray);

                            Consum.Tables[0].Rows[0]["ene"] = 0;
                            Consum.Tables[0].Rows[0]["feb"] = 0;
                            Consum.Tables[0].Rows[0]["mar"] = 0;
                            Consum.Tables[0].Rows[0]["abr"] = 0;
                            Consum.Tables[0].Rows[0]["may"] = 0;
                            Consum.Tables[0].Rows[0]["jun"] = 0;
                            Consum.Tables[0].Rows[0]["jul"] = 0;
                            Consum.Tables[0].Rows[0]["ago"] = 0;
                            Consum.Tables[0].Rows[0]["sep"] = 0;
                            Consum.Tables[0].Rows[0]["oct"] = 0;
                            Consum.Tables[0].Rows[0]["nov"] = 0;
                            Consum.Tables[0].Rows[0]["dic"] = 0;

                            con++;
                        }
                        else 
                        {
                            Consum.Tables[0].Rows[0]["ene"] = (Convert.ToDouble(Consum.Tables[0].Rows[0]["ene"].ToString()) + Convert.ToDouble(row["ene"].ToString()));
                            Consum.Tables[0].Rows[0]["feb"] = (Convert.ToDouble(Consum.Tables[0].Rows[0]["feb"].ToString()) + Convert.ToDouble(row["feb"].ToString()));
                            Consum.Tables[0].Rows[0]["mar"] = (Convert.ToDouble(Consum.Tables[0].Rows[0]["mar"].ToString()) + Convert.ToDouble(row["mar"].ToString()));
                            Consum.Tables[0].Rows[0]["abr"] = (Convert.ToDouble(Consum.Tables[0].Rows[0]["abr"].ToString()) + Convert.ToDouble(row["abr"].ToString()));
                            Consum.Tables[0].Rows[0]["may"] = (Convert.ToDouble(Consum.Tables[0].Rows[0]["may"].ToString()) + Convert.ToDouble(row["may"].ToString()));
                            Consum.Tables[0].Rows[0]["jun"] = (Convert.ToDouble(Consum.Tables[0].Rows[0]["jun"].ToString()) + Convert.ToDouble(row["jun"].ToString()));
                            Consum.Tables[0].Rows[0]["jul"] = (Convert.ToDouble(Consum.Tables[0].Rows[0]["jul"].ToString()) + Convert.ToDouble(row["jul"].ToString()));
                            Consum.Tables[0].Rows[0]["ago"] = (Convert.ToDouble(Consum.Tables[0].Rows[0]["ago"].ToString()) + Convert.ToDouble(row["ago"].ToString()));
                            Consum.Tables[0].Rows[0]["sep"] = (Convert.ToDouble(Consum.Tables[0].Rows[0]["sep"].ToString()) + Convert.ToDouble(row["sep"].ToString()));
                            Consum.Tables[0].Rows[0]["oct"] = (Convert.ToDouble(Consum.Tables[0].Rows[0]["oct"].ToString()) + Convert.ToDouble(row["oct"].ToString()));
                            Consum.Tables[0].Rows[0]["nov"] = (Convert.ToDouble(Consum.Tables[0].Rows[0]["nov"].ToString()) + Convert.ToDouble(row["nov"].ToString()));
                            Consum.Tables[0].Rows[0]["dic"] = (Convert.ToDouble(Consum.Tables[0].Rows[0]["dic"].ToString()) + Convert.ToDouble(row["dic"].ToString()));
                        }
                    }
                    else if (row["kind"].ToString() == "4") //Acumula Inventarios Finales
                    {
                        if (inv == 0)
                        {
                            InvFin.Tables[0].Rows.Add(row.ItemArray);

                            InvFin.Tables[0].Rows[0]["ene"] = 0;
                            InvFin.Tables[0].Rows[0]["feb"] = 0;
                            InvFin.Tables[0].Rows[0]["mar"] = 0;
                            InvFin.Tables[0].Rows[0]["abr"] = 0;
                            InvFin.Tables[0].Rows[0]["may"] = 0;
                            InvFin.Tables[0].Rows[0]["jun"] = 0;
                            InvFin.Tables[0].Rows[0]["jul"] = 0;
                            InvFin.Tables[0].Rows[0]["ago"] = 0;
                            InvFin.Tables[0].Rows[0]["sep"] = 0;
                            InvFin.Tables[0].Rows[0]["oct"] = 0;
                            InvFin.Tables[0].Rows[0]["nov"] = 0;
                            InvFin.Tables[0].Rows[0]["dic"] = 0;

                            inv++;
                        }
                        else
                        {
                            InvFin.Tables[0].Rows[0]["ene"] = (Convert.ToDouble(InvFin.Tables[0].Rows[0]["ene"].ToString()) + Convert.ToDouble(row["ene"].ToString()));
                            InvFin.Tables[0].Rows[0]["feb"] = (Convert.ToDouble(InvFin.Tables[0].Rows[0]["feb"].ToString()) + Convert.ToDouble(row["feb"].ToString()));
                            InvFin.Tables[0].Rows[0]["mar"] = (Convert.ToDouble(InvFin.Tables[0].Rows[0]["mar"].ToString()) + Convert.ToDouble(row["mar"].ToString()));
                            InvFin.Tables[0].Rows[0]["abr"] = (Convert.ToDouble(InvFin.Tables[0].Rows[0]["abr"].ToString()) + Convert.ToDouble(row["abr"].ToString()));
                            InvFin.Tables[0].Rows[0]["may"] = (Convert.ToDouble(InvFin.Tables[0].Rows[0]["may"].ToString()) + Convert.ToDouble(row["may"].ToString()));
                            InvFin.Tables[0].Rows[0]["jun"] = (Convert.ToDouble(InvFin.Tables[0].Rows[0]["jun"].ToString()) + Convert.ToDouble(row["jun"].ToString()));
                            InvFin.Tables[0].Rows[0]["jul"] = (Convert.ToDouble(InvFin.Tables[0].Rows[0]["jul"].ToString()) + Convert.ToDouble(row["jul"].ToString()));
                            InvFin.Tables[0].Rows[0]["ago"] = (Convert.ToDouble(InvFin.Tables[0].Rows[0]["ago"].ToString()) + Convert.ToDouble(row["ago"].ToString()));
                            InvFin.Tables[0].Rows[0]["sep"] = (Convert.ToDouble(InvFin.Tables[0].Rows[0]["sep"].ToString()) + Convert.ToDouble(row["sep"].ToString()));
                            InvFin.Tables[0].Rows[0]["oct"] = (Convert.ToDouble(InvFin.Tables[0].Rows[0]["oct"].ToString()) + Convert.ToDouble(row["oct"].ToString()));
                            InvFin.Tables[0].Rows[0]["nov"] = (Convert.ToDouble(InvFin.Tables[0].Rows[0]["nov"].ToString()) + Convert.ToDouble(row["nov"].ToString()));
                            InvFin.Tables[0].Rows[0]["dic"] = (Convert.ToDouble(InvFin.Tables[0].Rows[0]["dic"].ToString()) + Convert.ToDouble(row["dic"].ToString()));
                        }
                    }
                }

                if (Convert.ToDouble(Consum.Tables[0].Rows[0]["ene"].ToString()) > 0)
                Information.Tables[0].Rows[0]["ene"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["ene"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["ene"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 1));

                if (Convert.ToDouble(Consum.Tables[0].Rows[0]["feb"].ToString()) > 0)
                Information.Tables[0].Rows[0]["feb"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["feb"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["feb"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 2));

                if (Convert.ToDouble(Consum.Tables[0].Rows[0]["mar"].ToString()) > 0)
                Information.Tables[0].Rows[0]["mar"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["mar"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["mar"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 3));

                if (Convert.ToDouble(Consum.Tables[0].Rows[0]["abr"].ToString()) > 0)
                Information.Tables[0].Rows[0]["abr"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["abr"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["abr"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 4));

                if (Convert.ToDouble(Consum.Tables[0].Rows[0]["may"].ToString()) > 0)
                Information.Tables[0].Rows[0]["may"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["may"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["may"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 5));

                if (Convert.ToDouble(Consum.Tables[0].Rows[0]["jun"].ToString()) > 0)
                Information.Tables[0].Rows[0]["jun"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["jun"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["jun"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 6));

                if (Convert.ToDouble(Consum.Tables[0].Rows[0]["jul"].ToString()) > 0)
                Information.Tables[0].Rows[0]["jul"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["jul"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["jul"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 7));

                if (Convert.ToDouble(Consum.Tables[0].Rows[0]["ago"].ToString()) > 0)
                Information.Tables[0].Rows[0]["ago"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["ago"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["ago"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 8));

                if (Convert.ToDouble(Consum.Tables[0].Rows[0]["sep"].ToString()) > 0)
                Information.Tables[0].Rows[0]["sep"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["sep"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["sep"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 9));

                if (Convert.ToDouble(Consum.Tables[0].Rows[0]["oct"].ToString()) > 0)
                Information.Tables[0].Rows[0]["oct"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["oct"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["oct"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 10));

                if (Convert.ToDouble(Consum.Tables[0].Rows[0]["nov"].ToString()) > 0)
                Information.Tables[0].Rows[0]["nov"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["nov"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["nov"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 11));

                if (Convert.ToDouble(Consum.Tables[0].Rows[0]["dic"].ToString()) > 0)
                Information.Tables[0].Rows[0]["dic"] = ((Convert.ToDouble(InvFin.Tables[0].Rows[0]["dic"].ToString()) / Convert.ToDouble(Consum.Tables[0].Rows[0]["dic"].ToString())) * DateTime.DaysInMonth(DateTime.Now.Year, 12));

                SplashScreenManager.CloseForm();

                FCT_Show_DPI dpi = new FCT_Show_DPI();
                dpi.datos = Information;
                dpi.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema al cargar la informacion.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rgrp_Grid_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckGroupStatus();
        }

        #endregion

        private void btn_Editview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FCT_MRP_EDIT mrp = new FCT_MRP_EDIT();
            if (mrp.ShowDialog() == DialogResult.Yes)
            {
                LoadMRPs();
            }
        }

        private void btnViewDetailsDiciembre_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //View Details Diciembre
            var gridView = (GridView)grd_mrp.FocusedView;
            var row = (DataRow)gridView.GetFocusedDataRow();

            int kind = Convert.ToInt32(row["kind"]);
            if (kind == 2)//compras normales
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Normales, 12, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            if (kind == 3)//compras en transito
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Transito, 12, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }

        }

        private void btnComprasNov_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //View Details Diciembre
            var gridView = (GridView)grd_mrp.FocusedView;
            var row = (DataRow)gridView.GetFocusedDataRow();

            int kind = Convert.ToInt32(row["kind"]);
            if (kind == 2)//compras normales
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Normales, 11, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            if (kind == 3)//compras en transito
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Transito, 11, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void btnOctubreCompras_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //View Details Diciembre
            var gridView = (GridView)grd_mrp.FocusedView;
            var row = (DataRow)gridView.GetFocusedDataRow();

            int kind = Convert.ToInt32(row["kind"]);
            if (kind == 2)//compras normales
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Normales, 10, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            if (kind == 3)//compras en transito
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Transito, 10, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void btnSeptCompras_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //View Details Diciembre
            var gridView = (GridView)grd_mrp.FocusedView;
            var row = (DataRow)gridView.GetFocusedDataRow();

            int kind = Convert.ToInt32(row["kind"]);
            if (kind == 2)//compras normales
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Normales, 9, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            if (kind == 3)//compras en transito
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Transito, 9, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void btAgoCompras_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //View Details Diciembre
            var gridView = (GridView)grd_mrp.FocusedView;
            var row = (DataRow)gridView.GetFocusedDataRow();

            int kind = Convert.ToInt32(row["kind"]);
            if (kind == 2)//compras normales
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Normales, 8, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            if (kind == 3)//compras en transito
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Transito, 8, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void btnSepCompras_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //View Details Julio
            var gridView = (GridView)grd_mrp.FocusedView;
            var row = (DataRow)gridView.GetFocusedDataRow();

            int kind = Convert.ToInt32(row["kind"]);
            if (kind == 2)//compras normales
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Normales, 7, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            if (kind == 3)//compras en transito
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Transito, 7, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void btJunioCompras_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //View Details Julio
            var gridView = (GridView)grd_mrp.FocusedView;
            var row = (DataRow)gridView.GetFocusedDataRow();

            int kind = Convert.ToInt32(row["kind"]);
            if (kind == 2)//compras normales
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Normales, 6, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            if (kind == 3)//compras en transito
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Transito, 6, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void btnMayoCompras_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //View Details Julio
            var gridView = (GridView)grd_mrp.FocusedView;
            var row = (DataRow)gridView.GetFocusedDataRow();

            int kind = Convert.ToInt32(row["kind"]);
            if (kind == 2)//compras normales
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Normales, 5, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            if (kind == 3)//compras en transito
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Transito, 5, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void btnAbrilCompras_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //View Details Julio
            var gridView = (GridView)grd_mrp.FocusedView;
            var row = (DataRow)gridView.GetFocusedDataRow();

            int kind = Convert.ToInt32(row["kind"]);
            if (kind == 2)//compras normales
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Normales, 4, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            if (kind == 3)//compras en transito
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Transito, 4, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void btnMarzoCompras_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //View Details Julio
            var gridView = (GridView)grd_mrp.FocusedView;
            var row = (DataRow)gridView.GetFocusedDataRow();

            int kind = Convert.ToInt32(row["kind"]);
            if (kind == 2)//compras normales
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Normales, 3, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            if (kind == 3)//compras en transito
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Transito, 3, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void btnFebCompras_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //View Details Julio
            var gridView = (GridView)grd_mrp.FocusedView;
            var row = (DataRow)gridView.GetFocusedDataRow();

            int kind = Convert.ToInt32(row["kind"]);
            if (kind == 2)//compras normales
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Normales, 2, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            if (kind == 3)//compras en transito
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Transito, 2, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void btEneroCompras_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //View Details Julio
            var gridView = (GridView)grd_mrp.FocusedView;
            var row = (DataRow)gridView.GetFocusedDataRow();

            int kind = Convert.ToInt32(row["kind"]);
            if (kind == 2)//compras normales
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Normales, 1, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            if (kind == 3)//compras en transito
            {
                //CajaDialogo.InformationAuto();
                frmDetalleCompras frm = new frmDetalleCompras(frmDetalleCompras.TipoConsulta.Transito, 1, Convert.ToInt32(row["id_mp"]));
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void grdv_mrp_RowStyle(object sender, RowStyleEventArgs e)
        {
            e.Appearance.BackColor = Color.White;
        }
    }


}