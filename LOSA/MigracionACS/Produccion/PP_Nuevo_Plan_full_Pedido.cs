using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.MigracionACS.DataSetx;
using LOSA.Clases;

namespace LOSA.MigracionACS.Produccion
{
    public partial class PP_Nuevo_Plan_full_Pedido : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public UserLogin UsuarioLogeado;
        int LotePT;
        FMOP fmop = new FMOP();
        DataSet orders;
        int countT, countC;
        int TypeTrans = 1;
        //string ActiveUserCode;
        //string ActiveUserName;
        //string ActiveUserType;
        string FormAction;
        int IdPedidoDetalle;
        decimal PesoTotalKG;
        int TotalTarimas;
        int SacosPortarimas;
        int Id_Pedido;
        int id_gestion_lote;
        int lote_fp = 0;
        //public string ActiveUserCodeP
        //{
        //    get { return ActiveUserCode; }
        //    set { ActiveUserCode = value; }
        //}

        //public string ActiveUserNameP
        //{
        //    get { return ActiveUserName; }
        //    set { ActiveUserName = value; }
        //}

        //public string ActiveUserTypeP
        //{
        //    get { return ActiveUserType; }
        //    set { ActiveUserType = value; }
        //}

        public int Id_Pedido1
        {
            get { return Id_Pedido; }
            set { Id_Pedido = value; }
        }

        int selectedIndex;

        int selectedFormula;

        SqlConnection conn = new SqlConnection();



       

        private void Initialize_DataSet()
        {
            #region OldDataSet
            //orders = new DataSet();
            //orders.Tables.Add("OPS");

            //orders.Tables["OPS"].Columns.Add("id");
            //orders.Tables["OPS"].Columns.Add("code_op");
            //orders.Tables["OPS"].Columns.Add("id_pt");//Done
            //orders.Tables["OPS"].Columns.Add("code_pt");//Done
            //orders.Tables["OPS"].Columns.Add("pt");//Done
            //orders.Tables["OPS"].Columns.Add("bag_production");//Done
            //orders.Tables["OPS"].Columns.Add("line_id");
            //orders.Tables["OPS"].Columns.Add("id_formula");//Done
            //orders.Tables["OPS"].Columns.Add("code_formula");//Done
            //orders.Tables["OPS"].Columns.Add("version_formula");//Done
            //orders.Tables["OPS"].Columns.Add("code_wincc");//Done
            //orders.Tables["OPS"].Columns.Add("formula");//Done
            //orders.Tables["OPS"].Columns.Add("kg_production");//Done
            //orders.Tables["OPS"].Columns.Add("date_prouction");//Done
            //orders.Tables["OPS"].Columns.Add("priority");//Done
            //orders.Tables["OPS"].Columns.Add("status");//Done
            //orders.Tables["OPS"].Columns.Add("cant_paradas");//Done

            //orders.Tables["OPS"].Columns["id"].DataType = System.Type.GetType("System.Int32");
            //orders.Tables["OPS"].Columns["code_op"].DataType = System.Type.GetType("System.String");
            //orders.Tables["OPS"].Columns["id_pt"].DataType = System.Type.GetType("System.Int32");
            //orders.Tables["OPS"].Columns["code_pt"].DataType = System.Type.GetType("System.String");
            //orders.Tables["OPS"].Columns["pt"].DataType = System.Type.GetType("System.String");
            //orders.Tables["OPS"].Columns["bag_production"].DataType = System.Type.GetType("System.Int32");
            //orders.Tables["OPS"].Columns["line_id"].DataType = System.Type.GetType("System.Int32");
            //orders.Tables["OPS"].Columns["id_formula"].DataType = System.Type.GetType("System.Int32");
            //orders.Tables["OPS"].Columns["code_formula"].DataType = System.Type.GetType("System.String");
            //orders.Tables["OPS"].Columns["version_formula"].DataType = System.Type.GetType("System.Int32");
            //orders.Tables["OPS"].Columns["code_wincc"].DataType = System.Type.GetType("System.String");
            //orders.Tables["OPS"].Columns["formula"].DataType = System.Type.GetType("System.String");
            //orders.Tables["OPS"].Columns["kg_production"].DataType = System.Type.GetType("System.Double");
            //orders.Tables["OPS"].Columns["date_prouction"].DataType = System.Type.GetType("System.DateTime");
            //orders.Tables["OPS"].Columns["priority"].DataType = System.Type.GetType("System.Int32");
            //orders.Tables["OPS"].Columns["status"].DataType = System.Type.GetType("System.Int32");
            //orders.Tables["OPS"].Columns["cant_paradas"].DataType = System.Type.GetType("System.Int32");
            #endregion
        }

        private string Get_Prod_Plan_Code()
        {
            string ProdPlan = "PR-ERROR";
            string newPP = dp.ACS_GetSelectData(@"SELECT (COUNT([id]) + 1) AS New_ID FROM [dbo].[PP_Plan_Main]").Tables[0].Rows[0][0].ToString();

            switch (newPP.Length)
            {
                case 1:
                    ProdPlan = "PR-000000" + newPP;
                    break;
                case 2:
                    ProdPlan = "PR-00000" + newPP;
                    break;
                case 3:
                    ProdPlan = "PR-0000" + newPP;
                    break;
                case 4:
                    ProdPlan = "PR-000" + newPP;
                    break;
                case 5:
                    ProdPlan = "PR-00" + newPP;
                    break;
                case 6:
                    ProdPlan = "PR-0" + newPP;
                    break;
                case 7:
                    ProdPlan = "PR-" + newPP;
                    break;
                default:
                    ProdPlan = "PR-" + newPP;
                    break;
            }

            return ProdPlan;
        }

        private string Get_Prod_Orden_Code()
        {
            string ProdPlan = "PP-ERROR";
            string newPP = dp.ACS_GetSelectData(@"SELECT ((COUNT([id]) + 1)) AS New_ID FROM [dbo].[PP_Plan_Ordenes]").Tables[0].Rows[0][0].ToString();

            switch (newPP.Length)
            {
                case 1:
                    ProdPlan = "PP-000000" + newPP;
                    break;
                case 2:
                    ProdPlan = "PP-00000" + newPP;
                    break;
                case 3:
                    ProdPlan = "PP-0000" + newPP;
                    break;
                case 4:
                    ProdPlan = "PP-000" + newPP;
                    break;
                case 5:
                    ProdPlan = "PP-00" + newPP;
                    break;
                case 6:
                    ProdPlan = "PP-0" + newPP;
                    break;
                case 7:
                    ProdPlan = "PP-" + newPP;
                    break;
                default:
                    ProdPlan = "PP-" + newPP;
                    break;
            }

            return ProdPlan;
        }

        private string Get_Prod_Orden_Code_only_Pesajes()
        {
            string ProdPlan = "PP-ERROR";
            string newPP = dp.ACS_GetSelectData(@"SELECT ((COUNT([id]))) AS New_ID FROM [dbo].[PP_Plan_Ordenes]").Tables[0].Rows[0][0].ToString();
                                  //POr que -1? Por que se hace el update de luego de insertar el pp_order pero se necesita guardar
                                  
            switch (newPP.Length)
            {
                case 1:
                    ProdPlan = "PP-000000" + newPP;
                    break;
                case 2:
                    ProdPlan = "PP-00000" + newPP;
                    break;
                case 3:
                    ProdPlan = "PP-0000" + newPP;
                    break;
                case 4:
                    ProdPlan = "PP-000" + newPP;
                    break;
                case 5:
                    ProdPlan = "PP-00" + newPP;
                    break;
                case 6:
                    ProdPlan = "PP-0" + newPP;
                    break;
                case 7:
                    ProdPlan = "PP-" + newPP;
                    break;
                default:
                    ProdPlan = "PP-" + newPP;
                    break;
            }

            return ProdPlan;
        }
        #region PROCEDIMIENTOS DE INSERCION DE PLANES
        private int Insert_Header()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@code", SqlDbType.VarChar, 10));
                cmd.Parameters.Add(new SqlParameter("@description", SqlDbType.VarChar, 100));
                cmd.Parameters.Add(new SqlParameter("@valid_from", SqlDbType.Date));
                cmd.Parameters.Add(new SqlParameter("@valid_to", SqlDbType.Date));
                cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@created_by", SqlDbType.Int));
                //cmd.Parameters.Add(new SqlParameter("@id_usuario", SqlDbType.Int));
                //cmd.Parameters.Add(new SqlParameter("@lote_pt", SqlDbType.Int));

                SqlParameter param = cmd.Parameters.Add(new SqlParameter("@InsertedID", SqlDbType.Int));
                param.Direction = ParameterDirection.ReturnValue;

                cmd.Parameters["@code"].Value = Get_Prod_Plan_Code();
                cmd.Parameters["@description"].Value = txt_Descripcion.Text.ToString();
                cmd.Parameters["@valid_from"].Value = string.Format("{0:yyyy-MM-dd}", dt_desde.EditValue);
                cmd.Parameters["@valid_to"].Value = string.Format("{0:yyyy-MM-dd}", dt_Hasta.EditValue);
                cmd.Parameters["@status"].Value = 10;
                cmd.Parameters["@created_by"].Value = UsuarioLogeado.UserId;// ActiveUserCode;
                //cmd.Parameters["@id_usuario"].Value = UsuarioLogeado.UserId;
                //cmd.Parameters["@lote_pt"].Value = UsuarioLogeado.UserId;

                return dp.ACS_Exec_SP_GetID("PP_Plan_Main_Insert", cmd, param);
                //return dp.ACS_Exec_SP_GetID("PP_Plan_Main_Insert_v2", cmd, param);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message + "\nSTAKTRACE: " + ex.StackTrace);
                return -4;
            }
        }
        public void Recoleccion_Datos()
        {
            DataOperations Pru = new DataOperations();
            SqlConnection Conn = new SqlConnection(Pru.ConnectionStringCostos);
            string sql = @"SELECT pp.[id] as id,
                                pp.[name] as name
                            FROM [dbo].[PP_Production_Lines] pp join
                                [dbo].[Conf_Especies] ee on 
                                pp.id_especie = ee.id 
                            WHERE [status] >= 40 AND [status] < 80";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            SqlDataAdapter adat = new SqlDataAdapter(cmd);
            dSProductos.lineas_produccion.Clear();
            adat.Fill(dSProductos.lineas_produccion);
        }


        private void Insert_Orders(int idPlan)
        {
            try
            {
                int und = Convert.ToInt32(grd_udtm.EditValue);
                int unidades = 0;
                foreach (dsProduccion.unidades_tarimaRow row3 in dsProduccion1.unidades_tarima.Rows)
                {
                    if (und == row3.id)
                    {
                        unidades = row3.unidades;
                    }

                }

                lote_fp = lote_fp == 0 ? fmop.pp_order_get_next_lot_number() : lote_fp;
                foreach (DataRow row in dSProductos.OrdenTilapia.Rows)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@id_plan", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@pp_code", SqlDbType.VarChar, 10));
                    cmd.Parameters.Add(new SqlParameter("@id_pt", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@form_wincc", SqlDbType.VarChar, 18));
                    cmd.Parameters.Add(new SqlParameter("@kg_production", SqlDbType.Decimal));
                    cmd.Parameters.Add(new SqlParameter("@bag_production", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@lot_number", SqlDbType.Int));      // Me quede aqui.. Seguir Jueves
                    cmd.Parameters.Add(new SqlParameter("@line_id", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@date_prouction", SqlDbType.Date));
                    cmd.Parameters.Add(new SqlParameter("@priority", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@created_by", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@last_mod_by", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@kg_reached", SqlDbType.Decimal));
                    cmd.Parameters.Add(new SqlParameter("@kg_difference", SqlDbType.Decimal));
                    cmd.Parameters.Add(new SqlParameter("@cant_paradas", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@id_Pedido_Detalle", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@cant_tm", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@unidades", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@id_presentacion", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@ud_x_tarima", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@id_lotereservado", SqlDbType.Int));
                    string save = Recuperar_id_For(row["formula_code"].ToString()).ToString();
                    cmd.Parameters["@id_plan"].Value = idPlan;
                    cmd.Parameters["@pp_code"].Value = Get_Prod_Orden_Code();
                    cmd.Parameters["@id_pt"].Value = Recuperar_Id_pt(row["Codigo"].ToString());
                    cmd.Parameters["@id_formula"].Value = Recuperar_id_For(row["formula_code"].ToString());
                    cmd.Parameters["@form_wincc"].Value = (Get_Formula_Wincc_Code(save).Substring(0, 11) + Get_Prod_Orden_Code().Substring(3, 7));
                    cmd.Parameters["@kg_production"].Value = Convert.ToDouble((Convert.ToDouble(row["Peso_Pedido"]) * 1000));
                    cmd.Parameters["@bag_production"].Value = unidades;
                    cmd.Parameters["@lot_number"].Value = lote_fp;
                    cmd.Parameters["@line_id"].Value = Convert.ToInt32(row["line_id"].ToString());
                    cmd.Parameters["@date_prouction"].Value = Convert.ToDateTime(string.Format("{0:yyyy-MM-dd HH:mm:ss}", row["fecha_de_trabajo"]));
                    cmd.Parameters["@priority"].Value = row["Prioridad"];
                    cmd.Parameters["@status"].Value = 40;
                    cmd.Parameters["@created_by"].Value = this.UsuarioLogeado.UserId;//int.Parse(ActiveUserCode);
                    cmd.Parameters["@last_mod_by"].Value = this.UsuarioLogeado.UserId;// int.Parse(ActiveUserCode);
                    cmd.Parameters["@kg_reached"].Value = 0.00;
                    cmd.Parameters["@kg_difference"].Value = 0.00;
                    cmd.Parameters["@cant_paradas"].Value = row["batch"];
                    cmd.Parameters["@id_Pedido_Detalle"].Value = row["id_Pedido_Detalle"];
                    cmd.Parameters["@cant_tm"].Value = txtcant_tm.Text;
                    cmd.Parameters["@unidades"].Value = txt_Sacos.Text;
                    cmd.Parameters["@id_presentacion"].Value = grd_presentacion.EditValue;  //
                    cmd.Parameters["@ud_x_tarima"].Value = unidades;
                    cmd.Parameters["@id_lotereservado"].Value = id_gestion_lote;

                    int id_inserted = 0;
                    try
                    {
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                        cn.Open();
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = @"PP_Plan_Ordenes_Insertv_4";
                        id_inserted = Convert.ToInt32(cmd.ExecuteScalar());
                        cn.Close();
                        int PesajeidManual = InsertOrdenPesajeManual(id_inserted, lote_fp, Convert.ToInt32(row["batch"]));
                        InsertOrdenPesajeManualDetalle(PesajeidManual, id_inserted);
                    }
                    catch (Exception ex)
                    {

                        CajaDialogo.Error(ex.Message);
                    }


                    #region Validate & Change Formula Status

                    int status = fmop.local_formula_get_status(Recuperar_id_For(row["formula_code"].ToString()));

                    if (status < 50)
                    {
                        //fmop.local_formula_change_status(Convert.ToInt32(save), int.Parse(ActiveUserCode), 50);
                        fmop.local_formula_change_status(Convert.ToInt32(save), this.UsuarioLogeado.UserId, 50);

                        int nucleo = int.Parse(dp.ACS_GetSelectData(string.Format(@"SELECT COALESCE([nucleo], 0 ) AS nucleo FROM [dbo].[FML_Ingredientes_v2] WHERE [formula] = {0} AND [tipo] = 'NC' ", save)).Tables[0].Rows[0][0].ToString());

                        if (nucleo > 0)
                        {
                            status = fmop.local_formula_get_status(nucleo);

                            if (status < 50)
                            {
                                //fmop.local_formula_change_status(nucleo, int.Parse(ActiveUserCode), 50);
                                fmop.local_formula_change_status(nucleo, this.UsuarioLogeado.UserId, 50);
                            }
                        }
                    }

                    #endregion
                }

                Try_Drop_TempTables(selectedFormula.ToString(), "Drop");
                MessageBox.Show("Plan de Producción Generado sin Problemas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ERROR: {0}\nSTAKTRACE: {1}", ex.Message, ex.StackTrace));
            }
            

        }
        private void Insert_Orden_Cam(int idPlan)
        {
            try
            {

                int und = Convert.ToInt32(grd_udtm.EditValue);
                int unidades = 0;

                foreach (dsProduccion.unidades_tarimaRow row3 in dsProduccion1.unidades_tarima.Rows)
                {
                    if (und == row3.id)
                    {
                        unidades = row3.unidades;
                    }

                }
                lote_fp = lote_fp == 0 ? fmop.pp_order_get_next_lot_number() : lote_fp;
                foreach (DataRow row in dSProductos.OrdenCamaron.Rows)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@id_plan", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@pp_code", SqlDbType.VarChar, 10));
                    cmd.Parameters.Add(new SqlParameter("@id_pt", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@form_wincc", SqlDbType.VarChar, 18));
                    cmd.Parameters.Add(new SqlParameter("@kg_production", SqlDbType.Decimal));
                    cmd.Parameters.Add(new SqlParameter("@bag_production", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@lot_number", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@line_id", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@date_prouction", SqlDbType.Date));
                    cmd.Parameters.Add(new SqlParameter("@priority", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@created_by", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@last_mod_by", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@kg_reached", SqlDbType.Decimal));
                    cmd.Parameters.Add(new SqlParameter("@kg_difference", SqlDbType.Decimal));
                    cmd.Parameters.Add(new SqlParameter("@cant_paradas", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@id_Pedido_Detalle", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@cant_tm", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@unidades", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@id_presentacion", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@ud_x_tarima", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@id_lotereservado", SqlDbType.Int));
                    string save = Recuperar_id_For(row["formula_code"].ToString()).ToString();
                    cmd.Parameters["@id_plan"].Value = idPlan;
                    cmd.Parameters["@pp_code"].Value = Get_Prod_Orden_Code();
                    cmd.Parameters["@id_pt"].Value = Recuperar_Id_pt(row["Codigo"].ToString());
                    cmd.Parameters["@id_formula"].Value = Recuperar_id_For(row["formula_code"].ToString());
                    cmd.Parameters["@form_wincc"].Value = (Get_Formula_Wincc_Code(save).Substring(0, 11) + Get_Prod_Orden_Code().Substring(3, 7));
                    cmd.Parameters["@kg_production"].Value = Convert.ToDouble((Convert.ToDouble(row["Peso_Pedido"]) * 1000));
                    cmd.Parameters["@bag_production"].Value = unidades;
                    cmd.Parameters["@lot_number"].Value = lote_fp;
                    cmd.Parameters["@line_id"].Value = Convert.ToInt32(row["line_id"].ToString());
                    cmd.Parameters["@date_prouction"].Value = Convert.ToDateTime(string.Format("{0:yyyy-MM-dd HH:mm:ss}", row["fecha_de_trabajo"]));
                    cmd.Parameters["@priority"].Value = row["Prioridad"];
                    cmd.Parameters["@status"].Value = 40;
                    cmd.Parameters["@created_by"].Value = this.UsuarioLogeado.UserId;
                    cmd.Parameters["@last_mod_by"].Value = this.UsuarioLogeado.UserId; //int.Parse(ActiveUserCode);
                    cmd.Parameters["@kg_reached"].Value = 0.00;
                    cmd.Parameters["@kg_difference"].Value = 0.00;
                    cmd.Parameters["@cant_paradas"].Value = row["batch"];
                    cmd.Parameters["@id_Pedido_Detalle"].Value = row["id_Pedido_Detalle"];
                    cmd.Parameters["@cant_tm"].Value = txtcant_tm.Text;
                    cmd.Parameters["@unidades"].Value = txt_Sacos.Text;
                    cmd.Parameters["@id_presentacion"].Value = grd_presentacion.EditValue;  //
                    cmd.Parameters["@ud_x_tarima"].Value = unidades;
                    cmd.Parameters["@id_lotereservado"].Value = id_gestion_lote;
                    int id_inserted = 0;
                    try
                    {
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                        cn.Open();
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = @"PP_Plan_Ordenes_Insertv_4";
                        id_inserted = Convert.ToInt32(cmd.ExecuteScalar());
                        cn.Close();
                        int PesajeidManual = InsertOrdenPesajeManual(id_inserted,lote_fp,Convert.ToInt32(row["batch"]));
                        InsertOrdenPesajeManualDetalle(PesajeidManual, id_inserted);


                    }
                    catch (Exception ex)
                    {

                        CajaDialogo.Error(ex.Message);
                    }

                    #region Validate & Change Formula Status

                    int status = fmop.local_formula_get_status(Recuperar_id_For(row["formula_code"].ToString()));

                    if (status < 50)
                    {
                        //fmop.local_formula_change_status(Convert.ToInt32(save), int.Parse(ActiveUserCode), 50);
                        fmop.local_formula_change_status(Convert.ToInt32(save), this.UsuarioLogeado.UserId, 50);
                        int nucleo = int.Parse(dp.ACS_GetSelectData(string.Format(@"SELECT COALESCE([nucleo], 0 ) AS nucleo FROM [dbo].[FML_Ingredientes_v2] WHERE [formula] = {0} AND [tipo] = 'NC' ", save)).Tables[0].Rows[0][0].ToString());

                        if (nucleo > 0)
                        {
                            status = fmop.local_formula_get_status(nucleo);

                            if (status < 50)
                            {
                                //fmop.local_formula_change_status(nucleo, int.Parse(ActiveUserCode), 50);
                                fmop.local_formula_change_status(nucleo, this.UsuarioLogeado.UserId, 50);
                            }
                        }
                    }

                    
                    #endregion
                }

                Try_Drop_TempTables(selectedFormula.ToString(), "Drop");
                MessageBox.Show("Plan de Producción Generado sin Problemas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ERROR: {0}\nSTAKTRACE: {1}", ex.Message, ex.StackTrace));
            }
        }
        public void InsertOrdenPesajeManualDetalle(int idH_OrdenPesajeManual, int pIdOrder)
        {
            //sp_insert_orden_produccion_pesaje_manual
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                //Guardar el header de la orden manual
                SqlCommand cmd2 = new SqlCommand("sp_set_insert_detalle_orden_pesaje_manual_v2", con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@id_orden_encabezado", idH_OrdenPesajeManual);
                cmd2.Parameters.AddWithValue("@order_id", pIdOrder);
                cmd2.ExecuteScalar();

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public int InsertOrdenPesajeManual(int porder_number, int pLote, int batches)
        {
            int i = 0;
            //sp_insert_orden_produccion_pesaje_manual
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                //Guardar el header de la orden manual
                SqlCommand cmd = new SqlCommand("sp_insert_orden_produccion_pesaje_manual_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@order_id", porder_number);
                cmd.Parameters.AddWithValue("@order_code", Get_Prod_Orden_Code_only_Pesajes());
                cmd.Parameters.AddWithValue("@lot", pLote);
                cmd.Parameters.AddWithValue("@cant_batch", batches);
                int IdOrderManual = Convert.ToInt32(cmd.ExecuteScalar());
                i = IdOrderManual;

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return i;
        }

        #endregion
        private void Gen_RM_Requirement()
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ERROR: {0}\nSTAKTRACE: {1}", ex.Message, ex.StackTrace));
            }
        }
        #region Limpieza no necesaria
        private void Try_Drop_TempTables(string formula, string action)
        {//Hacer un limpiar los grids.
            try
            {
                SqlCommand cmd = new SqlCommand("PP_Plan_RM_Req_Temp_Drop", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.VarChar, 100));
                cmd.Parameters.Add(new SqlParameter("@Action", SqlDbType.VarChar, 10));
                cmd.Parameters.Add(new SqlParameter("@FormulaID", SqlDbType.VarChar, 100));

                cmd.Parameters["@UserID"].Value = this.UsuarioLogeado.UserId;
                cmd.Parameters["@Action"].Value = action;
                cmd.Parameters["@FormulaID"].Value = formula;

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ERROR: {0}\nSTAKTRACE: {1}", ex.Message, ex.StackTrace));
            }
        }

        #endregion

        public int Recuperar_Id_pt(string cod)
        {
            dp = new DataOperations();
            string Query = @"EXEC	 [dbo].[PP_GET_ID_PT] @Codigo ='"+cod.Trim()+"'";
            SqlConnection ni = new SqlConnection(dp.ConnectionStringCostos);
            ni.Open();
            SqlCommand dmc = new SqlCommand(Query, ni);
            return Convert.ToInt32(dmc.ExecuteScalar().ToString());
          
        }
        public int Recuperar_id_For(string ParCodigoFormula)
        {
            dp = new DataOperations();
            SqlConnection ni = new SqlConnection(dp.ConnectionStringCostos);
            string Query;
            SqlCommand Cmd;
            Query = "SELECT[dbo].[PP_Regreso_de_id_f] ('" + ParCodigoFormula.Trim() + "')";
            Cmd = new SqlCommand(Query, ni); ni.Open();
            
            return Convert.ToInt32(Cmd.ExecuteScalar());
            
        }
        public PP_Nuevo_Plan_full_Pedido(int PiDPedido, UserLogin pUsuarioLogeado, int pLotePT)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            LotePT = pLotePT;
            btn_NewOP.Enabled = false;
            this.FormAction = "new";
            Id_Pedido1 = PiDPedido;
            btn_Save.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            dp = new DataOperations();
            SqlConnection nc = new SqlConnection(dp.ConnectionStringCostos);
            nc.Open();
            string qeri;
            qeri = @"Select fecha_ini, fecha_fin from [dbo].[PT_Pedido] Where id_Pedido = " + Id_Pedido;
            SqlCommand cmmd = new SqlCommand(qeri, nc);
            SqlDataReader rd = cmmd.ExecuteReader();
            if (rd.Read())
            {
                dt_desde.EditValue = string.Format("{0:yyyy-MM-dd}", rd.GetDateTime(0));
                dt_Hasta.EditValue = string.Format("{0:yyyy-MM-dd}", rd.GetDateTime(1));
                dt_desde.Text = dt_desde.EditValue.ToString();
                dt_Hasta.Text = dt_Hasta.EditValue.ToString();
            }

            chk_AutoGen.Checked = false;
            chk_AutoGen.Checked = true;
            llenado_mp_all_Reck();
        }
        int Especie;
        public PP_Nuevo_Plan_full_Pedido(int PiDPedido, int pIdPedidoDetalle, int PEspecie, UserLogin pUsuarioLogeado, int pLotePt)
        {
            InitializeComponent();
            LotePT = pLotePt;
            UsuarioLogeado = pUsuarioLogeado;
            load_unidades_por_tarima();
            load_presentacion();
            TypeTrans = 2;
            btn_NewOP.Enabled = false;
            this.FormAction = "new";
            Id_Pedido1 = PiDPedido;
            IdPedidoDetalle = pIdPedidoDetalle;
            dp = new DataOperations();
            SqlConnection nc = new SqlConnection(dp.ConnectionStringCostos);
            nc.Open();
            string qeri;
            qeri = @"Select fecha_ini, fecha_fin from [dbo].[PT_Pedido] Where id_Pedido = " + Id_Pedido;
            SqlCommand cmmd = new SqlCommand(qeri, nc);
            SqlDataReader rd = cmmd.ExecuteReader();
            if (rd.Read())
            {
                dt_desde.EditValue = string.Format("{0:yyyy-MM-dd}", rd.GetDateTime(0));
                dt_Hasta.EditValue = string.Format("{0:yyyy-MM-dd}", rd.GetDateTime(1));
                dt_desde.Text = dt_desde.EditValue.ToString();
                dt_Hasta.Text = dt_Hasta.EditValue.ToString();
            }

            chk_AutoGen.Checked = false;
            chk_AutoGen.Checked = true;
            Especie = PEspecie;
        }
        public void load_presentacion()
        {
            string query = @"sp_load_pt_bags";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsProduccion1.bags.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsProduccion1.bags);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void Llenado_grid()
        {
            try
            {
                string Q = @"";
                if (TypeTrans == 2)
                {
                    Q = @"EXEC [dbo].[PP_LOAD_NEW_ORDER_BY_ESP_V2]
                            @Especie = 2,
		                    @Id_Pedido = " + Id_Pedido +
                           ", @id_pedidoDetalle = " + IdPedidoDetalle;
                }
                else
                {
                    Q = @"EXEC [dbo].[PP_LOAD_NEW_ORDER_BY_ESP]
                            @Especie = 2,
		                    @Id_Pedido = " + Id_Pedido;
                }
                 
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Q, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dSProductos.OrdenCamaron.Clear();
                da.Fill(dSProductos.OrdenCamaron);



                string QueryTilapia;
                if (TypeTrans == 2)
                {
                    QueryTilapia = @"EXEC [dbo].[PP_LOAD_NEW_ORDER_BY_ESP_V2]
                        @Especie = 1,
		                @Id_Pedido = " + Id_Pedido +
                   ", @id_pedidoDetalle = " + IdPedidoDetalle;
                }
                else
                {
                    QueryTilapia = @"EXEC [dbo].[PP_LOAD_NEW_ORDER_BY_ESP]
                        @Especie = 1,
		                @Id_Pedido = " + Id_Pedido;
                }
                
                cmd = new SqlCommand(QueryTilapia, cn);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dSProductos.OrdenTilapia.Clear();
                dap.Fill(dSProductos.OrdenTilapia);
                dSProductos.AcceptChanges();
                Recoleccion_Datos();
                
                countT = dSProductos.OrdenTilapia.Rows.Count;
                countC = dSProductos.OrdenCamaron.Rows.Count;
                if (Especie == 1)  // si es tilapia pues sacamos el peso de Tilapia.
                {
                    foreach (DSProductos.OrdenTilapiaRow rw in dSProductos.OrdenTilapia.Rows)
                    {
                        PesoTotalKG = rw.Peso_Pedido;
                    }
                }
                else
                {
                    foreach (DSProductos.OrdenCamaronRow rw in dSProductos.OrdenCamaron.Rows)
                    {
                        PesoTotalKG = rw.Peso_Pedido;
                    }
                }
                txt_KgProduccion.Text = (PesoTotalKG*1000).ToString();
             
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            
        }

        public void load_unidades_por_tarima()
        {
            string query = @"sp_load_unidades_por_tarima";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsProduccion1.unidades_tarima.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsProduccion1.unidades_tarima);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }


        public void Llenado_MP()
        {

            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                String QryMP = @"[PP_Load_of_MP]";
                SqlCommand DMC = new SqlCommand(QryMP, cn);
                DMC.CommandType = CommandType.StoredProcedure;
                DMC.Parameters.AddWithValue(" @Id_Pedido", Id_Pedido);
                SqlDataAdapter da = new SqlDataAdapter(DMC);
                dSProductos.MateriaPrima.Clear();
                da.Fill(dSProductos.MateriaPrima);

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

            
        }

        private void btn_cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();

            Try_Drop_TempTables(selectedFormula.ToString(), "Drop");

            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void PP_Nuevo_Plan_full_Pedido_Load(object sender, EventArgs e)
        {
            try
            {
                conn.ConnectionString = dp.ConnectionStringCostos;
                conn.Open();
                if (conn.State == ConnectionState.Open)
                    this.Text = this.Text + " - [Database Connection Established]";
                else
                    this.Text = this.Text + " - [Error on Database Connection]";

                splitContainerControl1.SplitterPosition = splitContainerControl1.Width / 2;

                if (FormAction == "new")
                {
                    txt_Codigo.Text = Get_Prod_Plan_Code();
                    Llenado_grid();
                    //Llenado_MP();
                    //Initialize_DataSet();
                    //grd_data.DataSource = orders.Tables["OPS"];
                    
                }
                else if (FormAction == "edit")
                {
                    grp_mainOptions.Enabled = false;

                    //GET PLAN DATA AND SET IT IN THE RIGTH PLACE.
                    //grd_data.DataSource = orders.Tables["OPS"];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ERROR: {0}\nSTAKTRACE: {1}", ex.Message, ex.StackTrace));
            }
        }

        private void chk_AutoGen_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dp = new DataOperations();
                SqlConnection nc = new SqlConnection(dp.ConnectionStringCostos);
                nc.Open();
                string qeri;
                qeri = @"Select fecha_ini, fecha_fin from [dbo].[PT_Pedido] Where id_Pedido = " + Id_Pedido;
                SqlCommand cmmd = new SqlCommand(qeri, nc);
                SqlDataReader rd = cmmd.ExecuteReader();
                if (rd.Read())
                {
                    dt_desde.EditValue = string.Format("{0:yyyy-MM-dd}", rd.GetDateTime(0));
                    dt_Hasta.EditValue = string.Format("{0:yyyy-MM-dd}", rd.GetDateTime(1));
                }


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

            if (chk_AutoGen.Checked == true)
            {
                txt_Descripcion.Enabled = false;
                txt_Descripcion.Text = string.Format("Programa de Produccion del {0} al {1}", dt_desde.Text, dt_Hasta.Text);
            }
            else
            {
                txt_Descripcion.Enabled = true;
            }
        }

        private void dt_desde_EditValueChanged(object sender, EventArgs e)
        {
            if (chk_AutoGen.Checked == true)
            {
                txt_Descripcion.Enabled = false;
                txt_Descripcion.Text = string.Format("Programa de Produccion del {0} al {1}", dt_desde.Text, dt_Hasta.Text);
            }
        }

        private void dt_Hasta_EditValueChanged(object sender, EventArgs e)
        {
            if (chk_AutoGen.Checked == true)
            {
                txt_Descripcion.Enabled = false;
                txt_Descripcion.Text = string.Format("Programa de Produccion del {0} al {1}", dt_desde.Text, dt_Hasta.Text);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Insert_Header();
        }

        void addPlan(object sender, FormClosedEventArgs e)
        {
            // lanzar el evento
        }

        #region BOTON DE AGREGAR PRODUCTO ELIMINADO POR ESTAR CARGADO DIRECTAMENTE DEL PEDIDO
        private void btn_NewOP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }
        #endregion

        #region Vereficar su necesaridad
        private void orden_OnFinalizarPresionado(object sender, EventArgs e)
        {
            //MessageBox.Show("Hizo Click!");
            //if (Action_AddPlan)
            DataRow row = (DataRow)sender;

            DataRow row1 = orders.Tables["OPS"].NewRow();
            row1["id"] = row["id"];
            row1["code_op"] = row["code_op"];
            row1["id_pt"] = row["id_pt"];
            row1["code_pt"] = row["code_pt"];
            row1["pt"] = row["pt"];
            row1["bag_production"] = row["bag_production"];
            row1["line_id"] = row["line_id"];
            row1["id_formula"] = row["id_formula"];
            row1["code_formula"] = row["code_formula"];
            row1["version_formula"] = row["version_formula"];
            row1["code_wincc"] = row["code_wincc"];
            row1["formula"] = row["formula"];
            row1["kg_production"] = row["kg_production"];
            row1["date_prouction"] = row["date_prouction"];
            row1["priority"] = row["priority"];
            row1["status"] = row["status"];
            row1["cant_paradas"] = row["cant_paradas"];

            //orders.Tables["OPS"].Rows.Add(orden.GetRow());
            orders.Tables["OPS"].Rows.Add(row1);


            dt_desde.Enabled = false;
            dt_Hasta.Enabled = false;

            /******************************************************************************/
            /* *****INSERTING INTO TEMP TABLE TO CALCULATE RAW MATERIAL REQUIREMENTS***** */
            //DataRow InsertedRow = orden.GetRow();
            DataRow InsertedRow = row;
            SqlCommand cmd = new SqlCommand("PP_Plan_RM_Req_Temp_Ins", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@FormulaID", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@BatchNo", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@date_production", SqlDbType.Date));

            cmd.Parameters["@FormulaID"].Value = InsertedRow["id_formula"].ToString();
            cmd.Parameters["@BatchNo"].Value = InsertedRow["cant_paradas"].ToString();
            cmd.Parameters["@UserID"].Value = this.UsuarioLogeado.UserId;
            cmd.Parameters["@date_production"].Value = InsertedRow["date_prouction"];

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            cmd.ExecuteNonQuery();

            //Gen_RM_Requirement();
            /******************************************************************************/

            var gridView = (GridView)gridCamaron.FocusedView;
            var row_ = (DataRow)gridView.GetFocusedDataRow();
            DateTime anterior = Convert.ToDateTime(dt_desde.EditValue);
            //sum total de paradas
            int conta = 1;
            foreach (DataRow dtRow in orders.Tables["OPS"].Rows)
            {
                foreach (DataColumn dc in orders.Tables["OPS"].Columns)
                {
                    if (dc.ColumnName == "date_prouction")
                        dtRow[dc] = anterior = anterior.AddHours((int)row_["cant_paradas"] * 0.2666);

                    if (dc.ColumnName == "priority")
                    {
                        dtRow[dc] = conta;
                        conta++;
                    }
                }
            }
        }
#endregion

        private void btn_deleteOP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
        }

        private void grdv_data_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                selectedIndex = e.FocusedRowHandle;
                selectedFormula = int.Parse(grd_Camaron.GetDataRow(e.FocusedRowHandle)["id_formula"].ToString());
            }
            catch { }

        }
        public void Validacion_Tilapia(int ParPlan)
        {
            if (txt_Descripcion.Text != "")
            {
                double cantKilos = 0;
                foreach (DataRow r in dSProductos.OrdenTilapia.Rows)
                {
                    cantKilos += Convert.ToDouble(r["Peso_Pedido"]);
                }

                bool OP_Generadas = false;
                foreach (DSProductos.OrdenTilapiaRow row in dSProductos.OrdenTilapia.Rows)
                {
                    if (!string.IsNullOrEmpty(row.code_pp))
                    {
                        OP_Generadas = true;
                        break;
                    }
                }

                if (OP_Generadas)
                {
                    CajaDialogo.Error("Ya fueron generadas las ordenes de producción de este pedido! Debe activarlas en el Plan de Producción...");
                    return;
                }

                cantKilos *= 1000;

                if (MessageBox.Show(string.Format("¿Seguro que desea crear el Plan de Producción por {0}Kg de alimento.", cantKilos), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    
                    int rmi = 0;

                    foreach (DataRow row in dSProductos.OrdenTilapia.Rows)
                    {
                        rmi += dp.get_inactive_rm(Recuperar_id_For(row["formula_code"].ToString()));
                    }

                    if (rmi > 0)
                    {
                        if (MessageBox.Show(string.Format("Aparentemente este plan de producción tiene formulas con almenos {0} materias primas o núcleos inactivos\n\n¿Seguro que desea crear el plan de producción?", rmi.ToString()), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            Insert_Orders(ParPlan);
                        }
                    }
                    else
                    {
                        Insert_Orders(ParPlan);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes definir una descripción al plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void Validacion_Camaron(int ParPlan)
        {
            if (txt_Descripcion.Text != "")
            {
                double cantKilos = 0;
                foreach (DataRow r in dSProductos.OrdenCamaron.Rows)
                {
                    cantKilos += Convert.ToDouble(r["Peso_Pedido"]);
                }
                cantKilos = cantKilos * 1000;

                bool OP_Generadas = false;
                foreach (DSProductos.OrdenCamaronRow row in dSProductos.OrdenCamaron.Rows)
                {
                    if (!string.IsNullOrEmpty(row.code_pp))
                    {
                        OP_Generadas = true;
                        break;
                    }
                }

                if (OP_Generadas)
                {
                    CajaDialogo.Error("Ya fueron generadas las ordenes de producción de este pedido! Debe activarlas en el Plan de Producción...");
                    return;
                }

                if (MessageBox.Show(string.Format("¿Seguro que desea crear el Plan de Producción por {0}Kg de alimento.", cantKilos), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    //if (MessageBox.Show("¿Deseas Guardar la Informacion de Consumos antes de cerrar?", "Consumos Materia Prima", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    //{
                    //    SaveFileDialog dialog = new SaveFileDialog();
                    //    dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                    //    dialog.FilterIndex = 0;

                    //    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    //    {
                    //        grd_rmReq.ExportToXlsx((string.Format("{0} - Diarios.xlsx", dialog.FileName.Substring(0, (dialog.FileName.Length - 5)))));
                    //        grd_reqMP_Total.ExportToXlsx((string.Format("{0} - Totales.xlsx", dialog.FileName.Substring(0, (dialog.FileName.Length - 5)))));
                    //    }
                    //}

                    int rmi = 0;

                    foreach (DataRow row in dSProductos.OrdenCamaron.Rows)
                    {
                        rmi += dp.get_inactive_rm(Recuperar_id_For(row["formula_code"].ToString()));
                    }

                    if (rmi > 0)
                    {
                        if (MessageBox.Show(string.Format("Aparentemente este plan de producción tiene formulas con almenos {0} materias primas o núcleos inactivos\n\n¿Seguro que desea crear el plan de producción?", rmi.ToString()), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            Insert_Orden_Cam(ParPlan);
                        }
                    }
                    else
                    {
                        Insert_Orden_Cam(ParPlan);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes definir una descripción al plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int ParPlan;
            if (!tgg_reservarlote.IsOn)
            {
                lote_fp = 0;
                id_gestion_lote = 0;
            }
               
            if (grd_presentacion.EditValue == null)
            {
                CajaDialogo.Error("Debe especificar la presentacion de la programacion de orden de produccion.");
                grd_presentacion.ShowPopup();
                return;
            }
            if (grd_udtm.EditValue == null)
            {
                CajaDialogo.Error("Debe especificar la cantidad de sacos que se asignan por la tarima.");
                grd_udtm.ShowPopup();
                return;
            }

            //if (dSProductos.OrdenTilapia.Count > 0)
            //{

            //    if (dSProductos.OrdenCamaron.Count > 0)
            //    {
            //        ParPlan = Insert_Header();
            //        Validacion_Camaron(ParPlan);

            //    }
            //    else
            //    {
            //        ParPlan = Insert_Header();
            //        Validacion_Tilapia(ParPlan);
            //    }

            //}
            //else
            //{
            //    if (dSProductos.OrdenCamaron.Count > 0)
            //    {
            //        ParPlan = Insert_Header();
            //        Validacion_Camaron(ParPlan);

            //    }
            //    else
            //    {
            //        MessageBox.Show("No hay datos ingresados...");
            //        this.Close();
            //    }

            //}

            bool Guardo = false;
            if (dSProductos.OrdenTilapia.Count > 0)
            {
                ParPlan = Insert_Header();
                Validacion_Tilapia(ParPlan);
                Guardo = true;
            }

            if (dSProductos.OrdenCamaron.Count > 0)
            {
                ParPlan = Insert_Header();
                Validacion_Camaron(ParPlan);
                Guardo = true;
            }

            if (!Guardo)
            {
                MessageBox.Show("No hay datos ingresados...");
                this.Close();
            }
            
        }

        private void btn_EditOP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Llenado_MP();

            if (TypeTrans == 1)
            {
                llenado_mp_all_Reck();
            }
            else
            {
                llenado_mp_v2();
            }
        }
        public void llenado_mp_all_Reck()
        {



            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();


                String QryMP = @"PP_Load_of_MP_all_req";
                SqlCommand DMC = new SqlCommand(QryMP, cn);
                DMC.CommandType = CommandType.StoredProcedure;
                DMC.Parameters.AddWithValue("@Id_Pedido", Id_Pedido);
                SqlDataAdapter da = new SqlDataAdapter(DMC);
                dSProductos.MateriaPrima.Clear();
                da.Fill(dSProductos.MateriaPrima);
                cn.Close();




            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void llenado_mp_v2() 
        {

            

            try
            {
                string query = @"sp_get_id_formula_pedido_detalle";
                 SqlConnection  cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pedido_detalle", IdPedidoDetalle);
                int id_formula = Convert.ToInt32(cmd.ExecuteScalar());         //Este es el format ID
                cn.Close();
                cn.Open();


                String QryMP = @"PP_Load_of_MP_V2";
                SqlCommand DMC = new SqlCommand(QryMP, cn);
                DMC.CommandType = CommandType.StoredProcedure;
                DMC.Parameters.AddWithValue("@id_formula", id_formula);
                DMC.Parameters.AddWithValue("@Id_Pedido", IdPedidoDetalle);
                SqlDataAdapter da = new SqlDataAdapter(DMC);
                dSProductos.MateriaPrima.Clear();
                da.Fill(dSProductos.MateriaPrima);
                cn.Close();




            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void PP_Nuevo_Plan_full_Pedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();
        }

        private void splitContainerControl1_Resize(object sender, EventArgs e)
        {
            splitContainerControl1.SplitterPosition = splitContainerControl1.Width / 2;
        }
        #region Exportado
        private void btn_excel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //grd_rmReq.ExportToXlsx(dialog.FileName);
            }
        }

        private void btn_pdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF File (.pdf)|*.pdf";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //grd_rmReq.ExportToPdf(dialog.FileName);
            }
        }

        private void btn_consumo_Total_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_reqMP_Total.ExportToXlsx(dialog.FileName);
            }
        }

        private void btn_pdf_total_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF File (.pdf)|*.pdf";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_reqMP_Total.ExportToPdf(dialog.FileName);
            }
        }

        private void btn_Both_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //grd_rmReq.ExportToXlsx((string.Format("{0} - Diarios.xlsx", dialog.FileName.Substring(0, (dialog.FileName.Length - 5)))));
                grd_reqMP_Total.ExportToXlsx((string.Format("{0} - Totales.xlsx", dialog.FileName.Substring(0, (dialog.FileName.Length - 5)))));
            }
        }
        #endregion

        private void dt_desde_Validating(object sender, CancelEventArgs e)
        {
            if (chk_AutoGen.Checked == true)
            {
                txt_Descripcion.Enabled = false;
                txt_Descripcion.Text = string.Format("Programa de Produccion del {0} al {1}", dt_desde.Text, dt_Hasta.Text);
            }
            else
            {
                txt_Descripcion.Enabled = true;
            }
        }

        private void dt_Hasta_Validating(object sender, CancelEventArgs e)
        {
            if (chk_AutoGen.Checked == true)
            {
                txt_Descripcion.Enabled = false;
                txt_Descripcion.Text = string.Format("Programa de Produccion del {0} al {1}", dt_desde.Text, dt_Hasta.Text);
            }
            else
            {
                txt_Descripcion.Enabled = true;
            }
        }

        private void TG_especie_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void grd_data_Click(object sender, EventArgs e)
        {

        }
        #region codigodeWincc
        private string Get_Formula_Wincc_Code(string formulaID)
        {
            try
            {
                DataSet datos = dp.ACS_GetSelectData(@"SELECT A.[codigo]
	                                                            ,B.[shortCode]
	                                                            ,A.[version]
                                                            FROM [dbo].[FML_Formulas_v2] A
                                                      INNER JOIN [dbo].[Conf_Especies] B
	                                                        ON A.[especie] = B.[id]
                                                            WHERE A.[id] = "+formulaID);
                string GenWinccCode = "";

                if (datos.Tables[0].Rows[0]["shortCode"].ToString().Length == 2)
                {
                    GenWinccCode += (datos.Tables[0].Rows[0]["shortCode"].ToString() + "-");
                }
                else
                {
                    GenWinccCode += (string.Format("E{0}-", datos.Tables[0].Rows[0]["shortCode"]));
                }

                switch (datos.Tables[0].Rows[0]["codigo"].ToString().Length)
                {
                    case 1:
                        GenWinccCode += (string.Format("000{0}-", datos.Tables[0].Rows[0]["codigo"]));
                        break;
                    case 2:
                        GenWinccCode += (string.Format("00{0}-", datos.Tables[0].Rows[0]["codigo"]));
                        break;
                    case 3:
                        GenWinccCode += (string.Format("0{0}-", datos.Tables[0].Rows[0]["codigo"]));
                        break;
                    case 4:
                        GenWinccCode += (datos.Tables[0].Rows[0]["codigo"].ToString() + "-");
                        break;
                    default:
                        GenWinccCode += (datos.Tables[0].Rows[0]["codigo"].ToString().Substring(0, 4) + "-");
                        break;
                }

                if (datos.Tables[0].Rows[0]["version"].ToString().Length == 2)
                {
                    GenWinccCode += (datos.Tables[0].Rows[0]["version"].ToString() + "-");
                }
                else
                {
                    GenWinccCode += (string.Format("0{0}-", datos.Tables[0].Rows[0]["version"]));
                }

                GenWinccCode += Get_Prod_Orden_Code().Substring(3, 7);

                return GenWinccCode;
            }
            catch { return ""; }
            
        }

        private void grd_reqMP_Total_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void grdTilapia_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
            //var GridView = (GridView)gridTilapia.FocusedView;
            //var row = (DSProductos.OrdenTilapiaRow)GridView.GetFocusedDataRow();
            //row.line_id = Convert.ToInt32(e.Value); 
        }

        private void repositoryItemGridLookUpEdit2_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            var GridView = (GridView)gridTilapia.FocusedView;
            var row = (DSProductos.OrdenTilapiaRow)GridView.GetFocusedDataRow();
            row.line_id = Convert.ToInt32(e.NewValue.ToString());
        }

        private void grdTilapia_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void repositoryItemGridLookUpEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            var GridView = (GridView)gridCamaron.FocusedView;
            var row = (DSProductos.OrdenCamaronRow)GridView.GetFocusedDataRow();
            row.line_id = Convert.ToInt32(e.NewValue.ToString());
        }

        private void btnSAP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void grd_udtm_EditValueChanged(object sender, EventArgs e)
        {
            double bagzise = 1;
            foreach (dsProduccion.bagsRow row in dsProduccion1.bags.Rows)
            {
                if (grd_presentacion.EditValue == null)
                {
                    break;
                }
                if (Convert.ToInt32(grd_presentacion.EditValue) == row.id)
                {
                    bagzise = row.net;
                }

            }
            Double sacos = Math.Round(Convert.ToDouble((Double.Parse(txt_KgProduccion.Text.ToString()) / bagzise).ToString()), 0);
            if (grd_presentacion.EditValue != null)
            {
                txtcant_tm.Text = Math.Round((Double.Parse(txt_KgProduccion.Text.ToString()) / Convert.ToInt32(sacos)), 0).ToString();
            }
            if (grd_udtm.EditValue != null)
            {
                int und = Convert.ToInt32(grd_udtm.EditValue);
                int unidades = 0;
                foreach (dsProduccion.unidades_tarimaRow row3 in dsProduccion1.unidades_tarima.Rows)
                {
                    if (und == row3.id)
                    {
                        unidades = row3.unidades;
                    }

                }
                decimal tarimas = Convert.ToDecimal(sacos) / Convert.ToDecimal(unidades);
                int cambio = Convert.ToInt32(tarimas);
                if (cambio < tarimas)
                {
                    cambio = cambio + 1;
                }

                txtcant_tm.Text = cambio.ToString();
            }
        }

        private void grd_presentacion_EditValueChanged(object sender, EventArgs e)
        {
            if (grd_presentacion.EditValue != null)
            {
                try
                {
                    double bagzise = 1;
                    foreach (dsProduccion.bagsRow row3 in dsProduccion1.bags.Rows)
                    {
                        if (grd_presentacion.EditValue == null)
                        {
                            break;
                        }
                        if (Convert.ToInt32(grd_presentacion.EditValue) == row3.id)
                        {
                            bagzise = row3.net;
                        }
                    }
                    Double sacos = Math.Round(Convert.ToDouble((Double.Parse(txt_KgProduccion.Text.ToString()) / bagzise).ToString()), 0);
                    txt_Sacos.Text = sacos.ToString();//Convert.ToInt32(Math.Round(Convert.ToDouble((Double.Parse(txt_KgProduccion.Text.ToString()) / bag_weight).ToString()),0)).ToString();
                   // row["bag_production"] = Convert.ToInt32(sacos);
                    if (grd_udtm.EditValue != null)
                    {
                        int und = Convert.ToInt32(grd_udtm.EditValue);
                        int unidades = 0;
                        foreach (dsProduccion.unidades_tarimaRow row in dsProduccion1.unidades_tarima.Rows)
                        {
                            if (und == row.id)
                            {
                                unidades = row.unidades;
                            }

                        }
                        decimal tarimas = Convert.ToDecimal(sacos) / Convert.ToDecimal(unidades);
                        int cambio = Convert.ToInt32(tarimas);
                        if (cambio < tarimas)
                        {
                            cambio = cambio + 1;
                        }

                        txtcant_tm.Text = cambio.ToString();
                    }




                }
                catch (Exception ex)
                {


                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void btnBuscarLote_Click(object sender, EventArgs e)
        {
            PP_seleccionLote frm = new PP_seleccionLote();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                id_gestion_lote = frm.id;
                lote_fp = frm.lote;
                txtloteselec.Text = lote_fp.ToString();
            }
        }

        private void tgg_reservarlote_Toggled(object sender, EventArgs e)
        {
            if (tgg_reservarlote.IsOn)
            {
                btnBuscarLote.Enabled = true;
            }
            else
            {
                btnBuscarLote.Enabled = false;
            }
        }

        private void repositoryItemGridLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {

        

        }
    }
    #endregion
}