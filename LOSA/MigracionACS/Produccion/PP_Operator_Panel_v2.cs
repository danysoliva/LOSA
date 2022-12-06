using ACS.Classes;
using LOSA.Clases;
using LOSA.MigracionACS.Formulas;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LOSA.MigracionACS.Produccion
{
    public partial class PP_Operator_Panel_v2 : DevExpress.XtraEditors.XtraForm
    {
        #region Global Form Variables

        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;
        string FormAction;
        DataTable UserGroups;

        string selIdFormula;

        string selIDOrdPro;
        string selNumOrdPro;
        string selWinCCCode;
        string selCodProdTe;
        string selProdKg;

        int selProdBag;
        int selLineID;
        int selCodeFormula;
        int selVersionFormula;
        string selNameFormula;
        string selLastModBy;
        DateTime selLastModOn;
        DateTime selDateProduction;

        int selid_plan;
        int selid_pt;
        int selPriority;
        int selParadas;

        int selStatus;

        public bool CerrarForm;

        DataOperations dp = new DataOperations();
        FMOP fmop = new FMOP();
        SqlConnection conn = new SqlConnection();
        UserLogin UsuarioLogeado;

        #endregion

        #region Developer Defined Methods

        private void load_orders()
        {
            try
            {
                grd_data.DataSource = dp.ACS_Exec_SP_Get_Data("PP_Plan_Ordenes_Get_Active_v2", new SqlCommand());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable Gen_RM_Requirement()
        {
            try
            {
                #region Gen Daily Information

                //DataTable RMData = new DataTable();
                //SqlCommand cmd = new SqlCommand("PP_Plan_RM_Req_Temp_Get_Daily", conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.VarChar, 100));

                //cmd.Parameters["@userID"].Value = ActiveUserCode;

                //if (conn.State == ConnectionState.Closed)
                //    conn.Open();

                //RMData.Load(cmd.ExecuteReader());

                //grd_rmReq.DataSource = RMData;

                #endregion

                #region Gen Total Requirement

                DataTable RMData = new DataTable();
                SqlCommand cmd = new SqlCommand("PP_Plan_RM_Req_Temp_Get_Total_OP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.VarChar, 100));

                cmd.Parameters["@userID"].Value = ActiveUserCode;

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                RMData.Load(cmd.ExecuteReader());

                return RMData;

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ERROR: {0}\nSTAKTRACE: {1}", ex.Message, ex.StackTrace));
                return null;
            }
        }

        private DataTable get_Order_Material_Req()
        {
            try
            {
                #region Insert Info into temporary table

                SqlCommand cmd = new SqlCommand("PP_Plan_RM_Req_Temp_Ins", conn);
                //SqlCommand cmd = new SqlCommand("PP_Plan_RM_Req_Temp_Ins_Temp", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@FormulaID", SqlDbType.VarChar, 100));
                cmd.Parameters.Add(new SqlParameter("@BatchNo", SqlDbType.VarChar, 100));
                cmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.VarChar, 100));
                cmd.Parameters.Add(new SqlParameter("@date_production", SqlDbType.Date));

                cmd.Parameters["@FormulaID"].Value = selIdFormula;
                cmd.Parameters["@BatchNo"].Value = selParadas.ToString();
                cmd.Parameters["@UserID"].Value = ActiveUserCode;
                cmd.Parameters["@date_production"].Value = selDateProduction;

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                cmd.ExecuteNonQuery();

                return Gen_RM_Requirement();

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ERROR: {0}\nSTAKTRACE: {1}", ex.Message, ex.StackTrace));
                return null;
            }
        }

        private void Drop_TempTables(string action)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PP_Plan_RM_Req_Temp_Drop", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.VarChar, 100));
                cmd.Parameters.Add(new SqlParameter("@Action", SqlDbType.VarChar, 10));
                cmd.Parameters.Add(new SqlParameter("@FormulaID", SqlDbType.VarChar, 100));

                cmd.Parameters["@UserID"].Value = ActiveUserCode;
                cmd.Parameters["@Action"].Value = action;
                cmd.Parameters["@FormulaID"].Value = "-1";

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

        #region Form Constructors

        public PP_Operator_Panel_v2(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            CerrarForm = false;
            ValidatePermisos();
            //this.ActiveUserCode = ActiveUserCode;
            //this.ActiveUserName = ActiveUserName;
            //this.ActiveUserType = ActiveUserType;
            //this.FormAction = FormAction;
            //this.UserGroups = UserGroups;
        }

        #endregion

        #region Form Events

        private void ValidatePermisos()
        {
            bool AccesoPrevio = false;
            if (UsuarioLogeado.ValidarNivelPermisos(69))
            {
                btnc_CancelOrder.Enabled = true;
                btnc_CloseOrder.Enabled = true;
                btnc_CopyOrder.Enabled = true;
                btnc_SendProducction.Enabled = true;
                btnc_VerifyReach.Enabled = true;
                AccesoPrevio = true;
            }

            //Validar si cuenta con un permiso temporal para acceder
            if (UsuarioLogeado.ValidarNivelPermisosTemporal(69))
            {
                btnc_CancelOrder.Enabled = true;
                btnc_CloseOrder.Enabled = true;
                btnc_CopyOrder.Enabled = true;
                btnc_SendProducction.Enabled = true;
                btnc_VerifyReach.Enabled = true;
                AccesoPrevio = true;
            }

            //Si no se consiguio acceso previo vamos a validar niveles permanentes
            if (!AccesoPrevio)
            {
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 7);//7=ALOSY, 9=AMS
                switch (idNivel)
                {
                    case 1://Basic View
                    case 2://Basic No Autorization
                        btnc_CancelOrder.Enabled = false;
                        btnc_CloseOrder.Enabled = false;
                        btnc_CopyOrder.Enabled = false;
                        btnc_SendProducction.Enabled = false;
                        btnc_VerifyReach.Enabled = false;
                        AccesoPrevio = true;
                        break;
                    case 3://Medium Autorization
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        btnc_CancelOrder.Enabled = true;
                        btnc_CloseOrder.Enabled = true;
                        btnc_CopyOrder.Enabled = true;
                        btnc_SendProducction.Enabled = true;
                        btnc_VerifyReach.Enabled = true;
                        AccesoPrevio = true;
                        break;
                    default:
                        break;
                }
            }

            if (!AccesoPrevio)
            {
                CerrarForm = true;
                CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #69");
            }
            else
            {
                load_orders();

                conn.ConnectionString = dp.ConnectionStringCostos;
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    txt_dbMessage.Caption = "[Conexión Establecida]";
                    txt_dbMessage.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    txt_dbMessage.Caption = "[Conexión Erronea]";
                    txt_dbMessage.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkRed;
                }
            }
        }

        private void PP_Operator_Panel_v2_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    //if (FormAction == "view") 
            //    //{
            //    //        btnc_CancelOrder.Enabled = false;
            //    //        btnc_CloseOrder.Enabled = false;
            //    //        btnc_CopyOrder.Enabled = false;
            //    //        btnc_SendProducction.Enabled = false;
            //    //        btnc_VerifyReach.Enabled = false;
            //    //}

            //    //foreach (DataRow row in UserGroups.Rows)
            //    //{
            //    //    string group = row["GroupName"].ToString();
            //    //    if ( group == "app_acs_prod_support" ||
            //    //         group == "app_acs_fml_planner"  ||
            //    //         group == "app_acs_it_admin")
            //    //    {
            //    //        btnc_CancelOrder.Enabled = true;
            //    //        btnc_CloseOrder.Enabled = true;
            //    //        btnc_CopyOrder.Enabled = true;
            //    //        btnc_SendProducction.Enabled = true;
            //    //        btnc_VerifyReach.Enabled = true;
            //    //        break;
            //    //    }
            //    //}

            //    bool AccesoPrevio = false;
            //    if (UsuarioLogeado.ValidarNivelPermisos(69))
            //    {
            //        btnc_CancelOrder.Enabled = true;
            //        btnc_CloseOrder.Enabled = true;
            //        btnc_CopyOrder.Enabled = true;
            //        btnc_SendProducction.Enabled = true;
            //        btnc_VerifyReach.Enabled = true;
            //        AccesoPrevio = true;
            //    }
            //    //else
            //    //{
            //    //    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #69");
            //    //}

            //    if (!AccesoPrevio)
            //    {
            //        int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7=ALOSY, 9=AMS
            //        switch (idNivel)
            //        {
            //            case 1://Basic View
            //            case 2://Basic No Autorization
            //                btnc_CancelOrder.Enabled = false;
            //                btnc_CloseOrder.Enabled = false;
            //                btnc_CopyOrder.Enabled = false;
            //                btnc_SendProducction.Enabled = false;
            //                btnc_VerifyReach.Enabled = false;
            //                AccesoPrevio = true;
            //                break;
            //            case 3://Medium Autorization
            //            case 4://Depth With Delta
            //            case 5://Depth Without Delta
            //                btnc_CancelOrder.Enabled = true;
            //                btnc_CloseOrder.Enabled = true;
            //                btnc_CopyOrder.Enabled = true;
            //                btnc_SendProducction.Enabled = true;
            //                btnc_VerifyReach.Enabled = true;
            //                AccesoPrevio = true;
            //                break;
            //            default:
            //                break;
            //        }
            //    }

            //    if (!AccesoPrevio)
            //    {

            //        CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #69");
            //    }
            //    else
            //    {
            //        load_orders();

            //        conn.ConnectionString = dp.ConnectionStringCostos;
            //        conn.Open();
            //        if (conn.State == ConnectionState.Open)
            //        {
            //            txt_dbMessage.Caption = "[Conexión Establecida]";
            //            txt_dbMessage.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Green;
            //        }
            //        else
            //        {
            //            txt_dbMessage.Caption = "[Conexión Erronea]";
            //            txt_dbMessage.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkRed;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

           
        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void grdv_data_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0) return;
            string error_plus = "";
            try
            {
                selid_plan = int.Parse(grdv_data.GetDataRow(e.FocusedRowHandle)["id_plan"].ToString());
                selid_pt = int.Parse(grdv_data.GetDataRow(e.FocusedRowHandle)["id_pt"].ToString());
                selPriority = int.Parse(grdv_data.GetDataRow(e.FocusedRowHandle)["priority"].ToString());
                selIdFormula = grdv_data.GetDataRow(e.FocusedRowHandle)["id_formula"].ToString();
                selNumOrdPro = grdv_data.GetDataRow(e.FocusedRowHandle)["pp_code"].ToString();
                selIDOrdPro = grdv_data.GetDataRow(e.FocusedRowHandle)["id_orden"].ToString();
                selWinCCCode = grdv_data.GetDataRow(e.FocusedRowHandle)["form_wincc"].ToString();
                selCodProdTe = grdv_data.GetDataRow(e.FocusedRowHandle)["cod_pt"].ToString();
                selProdKg = grdv_data.GetDataRow(e.FocusedRowHandle)["kg_production"].ToString();
                error_plus = " El error se produjo al intentar cargar la cantidad de sacos para Orden de Producción.";
                selProdBag = Convert.ToInt32(grdv_data.GetDataRow(e.FocusedRowHandle)["bag_production"].ToString()); //NEW
                error_plus = "";
                selLineID = Convert.ToInt32(grdv_data.GetDataRow(e.FocusedRowHandle)["line_id"].ToString()); //NEW
                selCodeFormula = Convert.ToInt32(grdv_data.GetDataRow(e.FocusedRowHandle)["code_formula"].ToString()); //NEW
                selVersionFormula = Convert.ToInt32(grdv_data.GetDataRow(e.FocusedRowHandle)["version_formula"].ToString()); //NEW 
                selNameFormula = grdv_data.GetDataRow(e.FocusedRowHandle)["name_formula"].ToString(); //NEW
                selDateProduction = Convert.ToDateTime(grdv_data.GetDataRow(e.FocusedRowHandle)["date_prouction"].ToString()); //NEW
                selLastModBy = grdv_data.GetDataRow(e.FocusedRowHandle)["last_mod_by"].ToString(); //NEW
                selLastModOn = Convert.ToDateTime(grdv_data.GetDataRow(e.FocusedRowHandle)["last_mod_on"].ToString()); //NEW

                selStatus = int.Parse(grdv_data.GetDataRow(e.FocusedRowHandle)["status"].ToString());
                selParadas = int.Parse(grdv_data.GetDataRow(e.FocusedRowHandle)["cant_paradas"].ToString());
            }
            catch
            {
                MessageBox.Show("Hay un error interno en los datos de la orden, llamar a Sistemas." + error_plus, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void grdv_data_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right) 
            {
                ContextMenu.ShowPopup(Cursor.Position);
            }
        }
        #region MicroIngredientes
        public int InsertOrdenPesajeManual(int porder_number, int pLote)
        {
            int i = 0;
            //sp_insert_orden_produccion_pesaje_manual
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                //Guardar el header de la orden manual
                SqlCommand cmd = new SqlCommand("sp_insert_orden_produccion_pesaje_manual", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@order_id", porder_number);
                cmd.Parameters.AddWithValue("@order_code", selNumOrdPro);
                cmd.Parameters.AddWithValue("@lot", pLote);
                cmd.Parameters.AddWithValue("@cant_batch", selParadas);
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

        #region MicroIngredientes Detalle
        public void InsertOrdenPesajeManualDetalle(int idH_OrdenPesajeManual, int pIdOrder)
        {
            //sp_insert_orden_produccion_pesaje_manual
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                //Guardar el header de la orden manual
                SqlCommand cmd2 = new SqlCommand("sp_set_insert_detalle_orden_pesaje_manual", con);
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
        #endregion


        private void btnc_SendProducction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (selStatus == 40)
                {
                    if (MessageBox.Show(string.Format("¿Seguro que desea enviar a produccir la Orden {0} por un total de {1}Kg y {2} sacos?", selNumOrdPro, selProdKg, selProdBag), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        //Pendding : Validar los datos de inventario de las materias primas (DONE BY DAVID RIEGA)
                        #region Validación General de la Orden de Produccion

                        bool can_produce = true;
                        //int TEST = 10;

                        //DataTable order_rm_req = get_Order_Material_Req();
                        //foreach (DataColumn col in order_rm_req.Columns)
                        //{
                        //    col.ReadOnly = false;
                        //}
                        //order_rm_req.Columns["line_comment"].MaxLength = 500;

                        //if (order_rm_req.Rows.Count > 0)
                        //{
                        #region Validacion de Lotes
                        //foreach (DataRow row in order_rm_req.Rows)
                        //{
                        //    DataTable stock_line = new DataTable();

                        //    #region Validacion de Stock

                        //    #region Vericar si requiere validacion de Stock

                        //    stock_line = fmop.apms_get_available_stock_lines_info(Convert.ToInt32(row["id"]), "RM", 20, 70, 1, true);

                        //    if (stock_line.Rows.Count == 1) // Existe una linea que indica Stock Ilimitado
                        //    {
                        //        row["line_status"] = 80; //Validacion de Stock no es necesaria
                        //        row["line_comment"] = "Validación de Stock no es necesaria";
                        //        //TEST = 80;
                        //    }
                        //    else if (stock_line.Rows.Count > 1)
                        //    {
                        //        row["line_status"] = 60;//Error de lineas de stock, existe mas de una linea ilimitada, comportamiento anormal
                        //        row["line_comment"] = "Error en lineas de Stock, existen duplicados. Comportamiento anormal";
                        //        can_produce = false;
                        //        //TEST = 60;
                        //    }

                        //    #endregion

                        //    #region Verifica si requiere stock

                        //    else if (stock_line.Rows.Count == 0)
                        //    {
                        //        stock_line = fmop.apms_get_available_stock_lines_info(Convert.ToInt32(row["id"]), "RM", 30, 40, 0, false);

                        //        if (stock_line.Rows.Count > 0)
                        //        {
                        //            int count_activo = 0;
                        //            Double real_active = 0;
                        //            Double real_available = 0;

                        //            foreach (DataRow line in stock_line.Rows)
                        //            {
                        //                if (Convert.ToInt32(line["active"]) == 1)
                        //                {
                        //                    count_activo++;
                        //                    real_active += Convert.ToDouble(line["remaining_kg"]);
                        //                }
                        //                else
                        //                {
                        //                    real_available += Convert.ToDouble(line["remaining_kg"]);
                        //                }
                        //            }

                        //            row["real_active_kg"] = real_active;
                        //            row["real_available_kg"] = real_available;
                        //            row["total_kg_d"] = (real_active + real_available);
                        //            row["diff"] = (Convert.ToDouble(row["total_kg_d"]) - Convert.ToDouble(row["total_kg"]));

                        //            if (count_activo == 0)
                        //            {
                        //                if (Convert.ToDouble(row["diff"]) >= 0)
                        //                {
                        //                    row["line_status"] = 40;//El stock disponible es suficiente para la orden, pero no existe ninguna linea de stock activa (ningun lote activo que pueda ser consumido)
                        //                    row["line_comment"] = "Stock suficiente, pero no existen lotes activos.";
                        //                    can_produce = false;
                        //                    //TEST = 40;
                        //                }
                        //                else
                        //                {
                        //                    row["line_status"] = 21;//no existe ninguna linea de stock activa (ningun lote activo que pueda ser consumido), y las lineas disponibles no son suficiente para producir la orden
                        //                    row["line_comment"] = "Stock insuficiente y no existen lotes activos.";
                        //                    can_produce = false;
                        //                    //TEST = 21;
                        //                }
                        //            }
                        //            else if (count_activo == 1)
                        //            {
                        //                if (Convert.ToDouble(row["diff"]) >= 0)
                        //                {
                        //                    row["line_status"] = 50;//Validado, el stock es suficiente y los estados son correctos, todo esta OK
                        //                    row["line_comment"] = "Stock Validado Correctamente.";
                        //                    //TEST = 50;
                        //                }
                        //                else
                        //                {
                        //                    row["line_status"] = 20;//Valida las existencias, pero no hay suficiente para hacer la orden de produccion
                        //                    row["line_comment"] = "Stock insuficiente para producir orden.";
                        //                    can_produce = false;
                        //                    //TEST = 20;
                        //                }
                        //            }
                        //            else if (count_activo > 1)
                        //            {
                        //                row["line_status"] = 61;//Cuando el material tiene 2 lotes activos, eso indica que existe un problema en la linea de stock y no deberia dejar continuar
                        //                row["line_comment"] = "Existe un problema en lineas de stock, mas de una linea activa.";
                        //                can_produce = false;
                        //                //TEST = 61;
                        //            }

                        //        }
                        //        else
                        //        {
                        //            row["line_status"] = 25;//Stock Insuficiente, no existen lotes activos, no hay material
                        //            row["line_comment"] = "No hay lotes activos ni disponibles.";
                        //            can_produce = false;
                        //            //TEST = 25;
                        //        }
                        //    }

                        //    #endregion

                        //    #endregion
                        //}
                        #endregion

                        if (can_produce)
                        {
                            #region Save Main on APMS

                            int inserted_main = -1;
                            int lot_number = fmop.pp_get_lote_fp_inserted_in_order(int.Parse(selIDOrdPro)) == -1 ? fmop.pp_order_get_next_lot_number() : fmop.pp_get_lote_fp_inserted_in_order(int.Parse(selIDOrdPro));
                            //int lot_number = fmop.pp_order_get_next_lot_number();    
                            int order_number = Convert.ToInt32(selNumOrdPro.Substring(3, (selNumOrdPro.Length - 3)));

                            inserted_main = fmop.apms_order_save_main(int.Parse(selIDOrdPro)
                                                                         , order_number
                                                                         , selNumOrdPro
                                                                         , selLineID
                                                                         , lot_number
                                                                         , fmop.apms_get_equivalent_fp(selid_pt)
                                                                         , selid_pt
                                                                         , int.Parse(selIdFormula)
                                                                         , selCodeFormula
                                                                         , selVersionFormula
                                                                         , Convert.ToDouble(selProdKg)
                                                                         , selParadas
                                                                         , 0.00
                                                                         , selParadas
                                                                         , 0.00
                                                                         , selParadas
                                                                         , selProdBag
                                                                         , 0.00
                                                                         , 0
                                                                         , 0.00
                                                                         , 0
                                                                         , 0.00
                                                                         , 0
                                                                         , 0
                                                                         , selDateProduction
                                                                         , selLineID
                                                                         , selLastModBy
                                                                         , selLastModOn
                                                                         , ActiveUserName
                                                                         , 50
                                                                         , ""
                                                                         , "");

                           // int orden_man_id = InsertOrdenPesajeManual(inserted_main, lot_number);

                            #endregion

                            #region Save Main Mix Lines

                            int inserted_mix1 = -1;
                            int inserted_mix2 = -1;

                            if (inserted_main > 0)
                            {
                                inserted_mix1 = fmop.apms_order_save_main_mix_line(inserted_main, 1, "P", (selNumOrdPro + "P").ToString(), lot_number, Convert.ToDouble(selProdKg), Convert.ToInt32(selParadas), 0.00, 0, 50, false, true);
                                inserted_mix2 = fmop.apms_order_save_main_mix_line(inserted_main, 2, "S", (selNumOrdPro + "S").ToString(), lot_number, Convert.ToDouble(selProdKg), Convert.ToInt32(selParadas), 0.00, 0, 50, false, true);
                            }

                            #endregion

                            #region Save Mix Structure

                            if (inserted_mix1 > 0 && inserted_mix2 > 0)
                            {
                                DataTable data = fmop.local_formula_get_structure(Convert.ToInt32(selIdFormula));

                                int second = 0;

                                if (data.Rows.Count > 0)
                                {
                                    foreach (DataRow row in data.Rows)
                                    {
                                        if (row["mix"].ToString() == "A")
                                        {
                                            if (row["materialType"].ToString() == "MP")
                                            {
                                                fmop.apms_order_save_main_structure(inserted_main, inserted_mix1, Convert.ToInt32(row["id_item"]), "RM", 1, "P", selParadas, Convert.ToDouble(row["peso"]), (Convert.ToDouble(row["peso"]) * selParadas), 0, 0.00);
                                            }
                                            else if (row["materialType"].ToString() == "NC")
                                            {
                                                fmop.apms_create_new_NC(Convert.ToInt32(row["id_item"]));
                                                fmop.apms_order_save_main_structure(inserted_main, inserted_mix1, Convert.ToInt32(row["id_item"]), "NC", 1, "P", selParadas, Convert.ToDouble(row["peso"]), (Convert.ToDouble(row["peso"]) * selParadas), 0, 0.00);
                                            }
                                        }
                                        else if (row["mix"].ToString() == "B")
                                        {
                                            if (second == 0)
                                            {
                                                Double total_mix1 = 0;
                                                foreach (DataRow m1row in data.Rows)
                                                {
                                                    //Suma todos los que van en el mix A para hacer el sfp que ira en el mix 2
                                                    /*if (m1row["mix"].ToString() == "A")
                                                        total_mix1 += Convert.ToDouble(m1row["peso"]);*/

                                                    //Ahora vamos a sumar todos, excepto los que si van en el 2do ya que ahora se pueden enviar tolvas al 1er mezclado.
                                                    int idmp = 0;
                                                    try
                                                    {
                                                        idmp = Convert.ToInt32(m1row["id_item"]);
                                                    }
                                                    catch { }

                                                    //si la materia prima es distinta de filax. El agua es el id 49
                                                    if (idmp > 0)
                                                    {
                                                        if (idmp != 10 && idmp != 6 /*&& idmp!=49*/)
                                                            total_mix1 += Convert.ToDouble(m1row["peso"]);
                                                    }
                                                }
                                                fmop.apms_order_save_main_structure(inserted_main, inserted_mix2, inserted_mix1, "SFP", 2, "S", selParadas, total_mix1, (total_mix1 * selParadas), 0, 0.00);
                                                second++;
                                            }

                                            //Guardar Header Requisicion ALOSY
                                            //if (GuardarHeaderRequisicionMP_ALOSY())
                                            //{

                                            //}

                                            if (row["materialType"].ToString() == "MP")
                                            {
                                                fmop.apms_order_save_main_structure(inserted_main, inserted_mix2, Convert.ToInt32(row["id_item"]), "RM", 2, "S", selParadas, Convert.ToDouble(row["peso"]), (Convert.ToDouble(row["peso"]) * selParadas), 0, 0.00);
                                            }
                                            else if (row["materialType"].ToString() == "NC")
                                            {
                                                //Pendding: Validar si el nucleo ya existe, no sera necesario crearlo.(DONE BY DAVID RIEGA)
                                                if (!fmop.apms_nc_exist(int.Parse(row["id_item"].ToString())))
                                                {
                                                    fmop.apms_create_new_NC(Convert.ToInt32(row["id_item"]));
                                                    //fmop.apms_order_save_main_structure(inserted_main, inserted_mix2, Convert.ToInt32(row["id_item"]), "NC", 2, "S", selParadas, Convert.ToDouble(row["peso"]), (Convert.ToDouble(row["peso"]) * selParadas), 0, 0.00);   // JV!
                                                }
                                                fmop.apms_order_save_main_structure(inserted_main, inserted_mix2, Convert.ToInt32(row["id_item"]), "NC", 2, "S", selParadas, Convert.ToDouble(row["peso"]), (Convert.ToDouble(row["peso"]) * selParadas), 0, 0.00);
                                                //else 
                                                //{
                                                //    fmop.apms_order_save_main_structure(inserted_main, inserted_mix2, fmop.apms_get_nc_id(Convert.ToInt32(row["id_item"])), "NC", 2, "S", selParadas, Convert.ToDouble(row["peso"]), (Convert.ToDouble(row["peso"]) * selParadas), 0, 0.00);
                                                //}
                                            }
                                        }
                                    }
                                   // InsertOrdenPesajeManualDetalle(orden_man_id, inserted_main);

                                    MessageBox.Show(string.Format("Orden de Producción {0} enviada y asignada con el numero de lote {1}.", selNumOrdPro, lot_number), "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    #region Update Local Order
                                    //Pendding: Cambiar el estado de la orden de forma local si todo fue exitoso y asignar numero de Lote.
                                    fmop.pp_change_order_status(int.Parse(selIDOrdPro), 50, lot_number);

                                    #endregion
                                }
                            }
                            #endregion

                            #region Create Record On Odoo (For Lot ussage)

                            //fmop.odoo_insert_new_production_order(selNumOrdPro,
                            //                                    selNameFormula,
                            //                                    Convert.ToInt64(selIDOrdPro),
                            //                                    selDateProduction,
                            //                                    selCodeFormula.ToString(),
                            //                                    selVersionFormula,
                            //                                    selNumOrdPro,
                            //                                    Convert.ToInt64(selIdFormula),
                            //                                    50);

                            #endregion



                            load_orders();
                        }
                        //else
                        //{
                        //    OP_Order_Material_Validation form = new OP_Order_Material_Validation(order_rm_req, UserGroups, ActiveUserCode, ActiveUserName, ActiveUserType, selIdFormula, selParadas, selDateProduction);
                        //    if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        //    {
                        //        #region Save Main on APMS

                        //        int inserted_main = -1;
                        //        int lot_number = fmop.pp_get_lote_fp_inserted_in_order(int.Parse(selIDOrdPro)) == -1 ? fmop.pp_order_get_next_lot_number() : fmop.pp_get_lote_fp_inserted_in_order(int.Parse(selIDOrdPro));

                        //        //int lot_number =  fmop.pp_get_lote_fp_inserted_in_order(int.Parse(selIDOrdPro));
                        //        int order_number = Convert.ToInt32(selNumOrdPro.Substring(3, (selNumOrdPro.Length - 3)));

                        //        inserted_main = fmop.apms_order_save_main(int.Parse(selIDOrdPro)
                        //                                                     , order_number
                        //                                                     , selNumOrdPro
                        //                                                     , selLineID
                        //                                                     , lot_number
                        //                                                     , fmop.apms_get_equivalent_fp(selid_pt)
                        //                                                     , selid_pt
                        //                                                     , int.Parse(selIdFormula)
                        //                                                     , selCodeFormula
                        //                                                     , selVersionFormula
                        //                                                     , Convert.ToDouble(selProdKg)
                        //                                                     , selParadas
                        //                                                     , 0.00
                        //                                                     , selParadas
                        //                                                     , 0.00
                        //                                                     , selParadas
                        //                                                     , selProdBag
                        //                                                     , 0.00
                        //                                                     , 0
                        //                                                     , 0.00
                        //                                                     , 0
                        //                                                     , 0.00
                        //                                                     , 0
                        //                                                     , 0
                        //                                                     , selDateProduction
                        //                                                     , selLineID
                        //                                                     , selLastModBy
                        //                                                     , selLastModOn
                        //                                                     , ActiveUserName
                        //                                                     , 50
                        //                                                     , ""
                        //                                                     , "");

                        //        #endregion

                        //        InsertOrdenPesajeManual(order_number, lot_number);

                        //        #region Save Main Mix Lines

                        //        int inserted_mix1 = -1;
                        //        int inserted_mix2 = -1;

                        //        if (inserted_main > 0)
                        //        {
                        //            inserted_mix1 = fmop.apms_order_save_main_mix_line(inserted_main, 1, "P", (selNumOrdPro + "P").ToString(), lot_number, Convert.ToDouble(selProdKg), Convert.ToInt32(selParadas), 0.00, 0, 50, false, false);
                        //            inserted_mix2 = fmop.apms_order_save_main_mix_line(inserted_main, 2, "S", (selNumOrdPro + "S").ToString(), lot_number, Convert.ToDouble(selProdKg), Convert.ToInt32(selParadas), 0.00, 0, 50, false, false);
                        //        }

                        //        #endregion

                        //        #region Save Mix Structure

                        //        if (inserted_mix1 > 0 && inserted_mix2 > 0)
                        //        {
                        //            DataTable data = fmop.local_formula_get_structure(Convert.ToInt32(selIdFormula));

                        //            int second = 0;

                        //            if (data.Rows.Count > 0)
                        //            {
                        //                foreach (DataRow row in data.Rows)
                        //                {
                        //                    if (row["mix"].ToString() == "A")
                        //                    {
                        //                        if (row["materialType"].ToString() == "MP")
                        //                        {
                        //                            fmop.apms_order_save_main_structure(inserted_main, inserted_mix1, Convert.ToInt32(row["id_item"]), "RM", 1, "P", selParadas, Convert.ToDouble(row["peso"]), (Convert.ToDouble(row["peso"]) * selParadas), 0, 0.00);
                        //                        }
                        //                        else if (row["materialType"].ToString() == "NC")
                        //                        {
                        //                            fmop.apms_create_new_NC(Convert.ToInt32(row["id_item"]));
                        //                            fmop.apms_order_save_main_structure(inserted_main, inserted_mix1, Convert.ToInt32(row["id_item"]), "NC", 1, "P", selParadas, Convert.ToDouble(row["peso"]), (Convert.ToDouble(row["peso"]) * selParadas), 0, 0.00);
                        //                        }
                        //                    }
                        //                    else if (row["mix"].ToString() == "B")
                        //                    {
                        //                        if (second == 0)
                        //                        {
                        //                            Double total_mix1 = 0;
                        //                            foreach (DataRow m1row in data.Rows)
                        //                            {
                        //                                if (m1row["mix"].ToString() == "A")
                        //                                    total_mix1 += Convert.ToDouble(m1row["peso"]);
                        //                            }

                        //                            fmop.apms_order_save_main_structure(inserted_main, inserted_mix2, inserted_mix1, "SFP", 2, "S", selParadas, total_mix1, (total_mix1 * selParadas), 0, 0.00);
                        //                            second++;
                        //                        }

                        //                        if (row["materialType"].ToString() == "MP")
                        //                        {
                        //                            fmop.apms_order_save_main_structure(inserted_main, inserted_mix2, Convert.ToInt32(row["id_item"]), "RM", 2, "S", selParadas, Convert.ToDouble(row["peso"]), (Convert.ToDouble(row["peso"]) * selParadas), 0, 0.00);
                        //                        }
                        //                        else if (row["materialType"].ToString() == "NC")
                        //                        {
                        //                            //Pendding: Validar si el nucleo ya existe, no sera necesario crearlo.(DONE BY DAVID RIEGA)
                        //                            if (!fmop.apms_nc_exist(int.Parse(row["id_item"].ToString())))
                        //                            {
                        //                                fmop.apms_create_new_NC(Convert.ToInt32(row["id_item"]));
                        //                                //fmop.apms_order_save_main_structure(inserted_main, inserted_mix2, Convert.ToInt32(row["id_item"]), "NC", 2, "S", selParadas, Convert.ToDouble(row["peso"]), (Convert.ToDouble(row["peso"]) * selParadas), 0, 0.00);  // JV
                        //                            }
                        //                            fmop.apms_order_save_main_structure(inserted_main, inserted_mix2, Convert.ToInt32(row["id_item"]), "NC", 2, "S", selParadas, Convert.ToDouble(row["peso"]), (Convert.ToDouble(row["peso"]) * selParadas), 0, 0.00);
                        //                            //else
                        //                            //{
                        //                            //    fmop.apms_order_save_main_structure(inserted_main, inserted_mix2, fmop.apms_get_nc_id(Convert.ToInt32(row["id_item"])), "NC", 2, "S", selParadas, Convert.ToDouble(row["peso"]), (Convert.ToDouble(row["peso"]) * selParadas), 0, 0.00);
                        //                            //}
                        //                        }
                        //                    }
                        //                }

                        //                MessageBox.Show(string.Format("Orden de Producción {0} enviada y asignada con el numero de lote {1}.", selNumOrdPro, lot_number), "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //                #region Update Local Order
                        //                //Pendding: Cambiar el estado de la orden de forma local si todo fue exitoso y asignar numero de Lote.
                        //                fmop.pp_change_order_status(int.Parse(selIDOrdPro), 50, lot_number);

                        //                #endregion
                        //            }
                        //        }
                        //        #endregion

                        //        #region Create Record On Odoo (For Lot ussage)

                        //        //fmop.odoo_insert_new_production_order(selNumOrdPro,
                        //        //                                    selNameFormula,
                        //        //                                    Convert.ToInt64(selIDOrdPro),
                        //        //                                    selDateProduction,
                        //        //                                    selCodeFormula.ToString(),
                        //        //                                    selVersionFormula,
                        //        //                                    selNumOrdPro,
                        //        //                                    Convert.ToInt64(selIdFormula),
                        //        //                                    50);

                        //        #endregion

                        //        load_orders();
                        //    }
                        //    else 
                        //    {
                        //        order_rm_req = new DataTable();
                        //        Drop_TempTables("Drop");
                        //    }

                        //    //MessageBox.Show("FUCK ESTA MIERDA TIENE ALGO MALO. Estado: " + TEST);
                        //}


                        //}
                        //else 
                        //{
                        //    MessageBox.Show("Ocurrio un error al intentar validad los consumos requeridos de la orden de producción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                        #endregion
                    }
                }
                else if (selStatus >= 0 && selStatus < 40)
                {
                    MessageBox.Show("No puede enviar a producir una orden no aprovada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (selStatus > 40 && selStatus <= 80)
                {
                    MessageBox.Show("La Orden ya ha sido enviada a producción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message != "Object reference not set to an instance of an object.")
                    MessageBox.Show("Caso X: Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnc_CancelOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (selStatus <= 40)
                {
                    if (MessageBox.Show(string.Format("¿Seguro que desea cancelar la orden de producción {0}?, este proceso es irreversible y no le permitira producir la formula {1}", selNumOrdPro, selWinCCCode), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int idplan = selid_plan;

                        SqlCommand command = new SqlCommand();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@id_orden", SqlDbType.Int));
                        command.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));

                        command.Parameters["@id_orden"].Value = selIDOrdPro;
                        command.Parameters["@status"].Value = 99;

                        dp.ACS_Exec_SP("PP_Plan_Ordenes_Change_Status", command);

                        MessageBox.Show("La orden ha sido cancelada", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (int.Parse(dp.ACS_GetSelectData(string.Format(@"SELECT COUNT([id]) AS cant FROM [dbo].[PP_Plan_Ordenes] WHERE [id_plan] = {0} AND ([status] >= 1 AND [status] <= 30)", idplan)).Tables[0].Rows[0][0].ToString()) <= 0)
                        {
                            command = new SqlCommand();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                            command.Parameters.Add(new SqlParameter("@st", SqlDbType.Int));

                            command.Parameters["@id"].Value = idplan;
                            command.Parameters["@st"].Value = 95;

                            dp.ACS_Exec_SP("PP_Plan_Update_Status", command);

                            MessageBox.Show("Todas las ordenes de este plan han sido terminadas\n\nEl plan de producción ha sido finalizado.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                       
                        load_orders();
                        // Esto deja en blanco la pantalla:
                        //grd_data.DataSource = dp.ACS_Exec_SP_Get_Data("PP_Plan_Ordenes_Get_Active", new SqlCommand());
                    }
                }
                else if (selStatus > 40 && selStatus <= 80)
                {
                    MessageBox.Show("No puede cancelar una orden que actualmente esta en producción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("No puede cancelar la Orden\n\nEstado de Orden desconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message != "Object reference not set to an instance of an object.")
                    MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnc_CloseOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (selStatus >= 50 && selStatus <= 80)
                {
                    if (MessageBox.Show(string.Format("¿Seguro que desea marcar la orden de producción {0} como finalizada?, este proceso es irreversible y no le permitira continuar produciendo la formula {1}", selNumOrdPro, selWinCCCode), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int idplan = selid_plan;

                        //////CAMBIAR METODO DE CANCELACION A SISTEMA NUEVO
                        //CAMBIAR ESTADO DE ORDEN EN APMS, Antes validando que pueda ser suspendido.

                        SqlCommand command = new SqlCommand();
                        //command.CommandType = CommandType.StoredProcedure;
                        //command.Parameters.Add(new SqlParameter("@w_product_name", SqlDbType.VarChar, 300));

                        //command.Parameters["@w_product_name"].Value = selNumOrdPro;

                        //dp.WinCC_Exec_SP("sp_cierre_orden", command);

                        ///////////////////


                        command = new SqlCommand();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@id_orden", SqlDbType.Int));
                        command.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));

                        command.Parameters["@id_orden"].Value = selIDOrdPro;
                        command.Parameters["@status"].Value = "95";

                        dp.ACS_Exec_SP("PP_Plan_Ordenes_Change_Status", command);

                        MessageBox.Show("La orden ha sido finalizada.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (int.Parse(dp.ACS_GetSelectData(string.Format(@"SELECT COUNT([id]) AS cant FROM [dbo].[PP_Plan_Ordenes] WHERE [id_plan] = {0} AND ([status] >= 1 AND [status] <= 80)", idplan)).Tables[0].Rows[0][0].ToString()) <= 0)
                        {
                            command = new SqlCommand();
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                            command.Parameters.Add(new SqlParameter("@st", SqlDbType.Int));

                            command.Parameters["@id"].Value = idplan;
                            command.Parameters["@st"].Value = 95;

                            dp.ACS_Exec_SP("PP_Plan_Update_Status", command);

                            MessageBox.Show("Todas las ordenes de este plan han sido terminadas\n\nEl plan de producción ha sido finalizado.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        load_orders();
                        // Esto deja en blanco la pantalla:
                        //grd_data.DataSource = dp.ACS_Exec_SP_Get_Data("PP_Plan_Ordenes_Get_Active", new SqlCommand());
                    }
                }
                else if (selStatus < 50)
                {
                    MessageBox.Show("No puede marcar como finalizada una orden que no esta activa en producción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("No puede marcar como finalizada la Orden\n\nEstado de Orden desconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message != "Object reference not set to an instance of an object.")
                    MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnc_CopyOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (selStatus >= 50 && selStatus <= 80)
                {
                    PP_Order_Copy_Dialog copy = new PP_Order_Copy_Dialog(int.Parse(selIDOrdPro),selid_plan, selid_pt, int.Parse(selIdFormula), selWinCCCode, DateTime.Now.Date, selPriority, ActiveUserCode);
                    if (copy.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        MessageBox.Show("Orden de Produccion Generada con Exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_orders();
                    }
                }
                else
                {
                    MessageBox.Show("No puede copiar una orden que aun no esta en producción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message != "Object reference not set to an instance of an object.")
                    MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnc_UpdateData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_orders();
        }

        private void PP_Operator_Panel_v2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();
        }

        #endregion

        private void btn_SoporteIT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void cmdVerDetalle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Detalle de la formula
            if (!string.IsNullOrEmpty(selIdFormula))
            {
                FML_NewFormula_view_only fm = new FML_NewFormula_view_only(ActiveUserCode,
                                                                             ActiveUserName,
                                                                             ActiveUserType,
                                                                             "view",
                                                                             int.Parse(selIdFormula),
                                                                             0,
                                                                             "NC",
                                                                             UserGroups);
                fm.ShowDialog();
                fmop.local_formula_event_entry(int.Parse(selIdFormula), int.Parse(ActiveUserCode), "EVT", "Formula Visualizada");
            }
        }
    }
}