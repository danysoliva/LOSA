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
using System.Data.Sql;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.MigracionACS.DataSetx;
using LOSA.Clases;

namespace LOSA.MigracionACS.PT
{
    public partial class PT_Productos : DevExpress.XtraEditors.XtraForm
    {

        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;
        UserLogin UsuarioLogeado;
        public bool CerrarForm;
        private string user = "";
        private string ppass = "";
        private string SelectedProduct = null;
        DataOperations dp = new DataOperations();
        //DataSet products;
        int id_Formula;
        #region Developer Defined Functions

        //For Desingn to be inherited
        protected override bool GetAllowSkin()
        {
            if (this.DesignMode) return false;
            return true;
        }


        #endregion

        public PT_Productos(string ActiveUserCode, string ActiveUserName, string ActiveUserType, UserLogin pUser)
        {
            InitializeComponent();
            this.UsuarioLogeado = pUser;
            ValidatePermisos();
            #region autentificacion de permisos
            GetAllowSkin();

            //if (UsuarioLogeado == null)
            //    UsuarioLogeado = new UserLogin();

            this.ActiveUserCode = UsuarioLogeado.AD_User;
            //if (UsuarioLogeado.RecuperarRegistro(ActiveUserCode))
            //{
            //    if (UsuarioLogeado.ValidarNivelPermisos(10))
            //    {
            //        btn_New.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            //    }
            //    else
            //    {
            //        btn_New.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //        //Comentario
            //    }
            //}
            this.ActiveUserName = UsuarioLogeado.Nombre;
            this.ActiveUserType = UsuarioLogeado.Tipo;

            #endregion
        }


        private void ValidatePermisos()
        {
            bool AccesoPrevio = false;
            if (UsuarioLogeado.ValidarNivelPermisos(10))
            {
                btn_New.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                AccesoPrevio = true;
            }

            //Validar si cuenta con un permiso temporal para acceder
            if (UsuarioLogeado.ValidarNivelPermisosTemporal(10))
            {
                btn_New.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
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
                        btn_New.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        btn_Activate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        btn_Inactivate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        AccesoPrevio = true;
                        break;
                    case 3://Medium Autorization
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        btn_New.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_Activate.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_Inactivate.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        AccesoPrevio = true;
                        break;
                    default:
                        break;
                }
            }

            if (!AccesoPrevio)
            {
                CerrarForm = true;
                CajaDialogo.Error("No tiene privilegios para esta función! El permiso requerido es #10");
            }
            else
            {
                refresh_grid();
            }
        }

        private void PT_Productos_Load(object sender, EventArgs e)
        {

            //refresh_grid();
            //string fortherecord;
            //if (ActiveUserType == "pr")
            //{
            //    //col_Costo.Visible = false;
            //}
            //else
            //{
            //    //btn_New.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;//aqui
            //    btn_Activate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //    btn_Inactivate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //}

            //if (SelectedProduct == null)
            //{
            //    btn_Edit.Enabled = false;
            //}
            //else
            //{
            //    btn_Edit.Enabled = true;
            //}

            //this.WindowState = FormWindowState.Maximized;
        }

        private void btn_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //PT_NuevoProducto pt = new PT_NuevoProducto(ActiveUserCode, ActiveUserName, ActiveUserType);//aqui
            if (UsuarioLogeado.ValidarNivelPermisos(16))
            {
                //frmNewProductoUniversal pt = new frmNewProductoUniversal(ActiveUserCode, ActiveUserName, ActiveUserType);
                frmCRUDProductoTerminado pt = new frmCRUDProductoTerminado(UsuarioLogeado, frmCRUDProductoTerminado.TipoOperacion.Insert, 0);
                if (pt.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    refresh_grid();
                }
            }
        }



        private void btn_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void repositoryItemButtonEdit1_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (btn_New.Visibility != DevExpress.XtraBars.BarItemVisibility.Never)
            {
                var gridview = (GridView)gridControl1.FocusedView;
                var row = (DSProductos.ProductosRow)gridview.GetFocusedDataRow();
                string a = row.Codigo;
                string b = row.Descripcion;
                string c = row.especie;
                string d = row.Fecha.ToString();
                string q = row.Estado;
                int dias_vencimiento = row.dias_vencimiento;
                int f = row.formula_code;

                //EditarProductos NewForm = new EditarProductos(a, b, c, d, q, f, UsuarioLogeado, row.id, dias_vencimiento);
                //if (NewForm.ShowDialog() == DialogResult.OK)
                //{
                //    refresh_grid();
                //}

                frmCRUDProductoTerminado frm = new frmCRUDProductoTerminado(UsuarioLogeado, frmCRUDProductoTerminado.TipoOperacion.Update, row.id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    refresh_grid();
                }
            }
        }



        private void Tooglerefell()
        {
            refresh_grid();
        }

        private void barToggleSwitchItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barToggleSwitchItem1.Checked == false)
            {
                barToggleSwitchItem1.Checked = true;
                Tooglerefell();
            }
            else
            {
                barToggleSwitchItem1.Checked = false;
                Tooglerefell();
            }

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

     
        void refresh_grid()
        {
            try
            {
                string FixedQuery = "sp_get_portafolio_pt";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(FixedQuery, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (barToggleSwitchItem1.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@estado", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@estado", 0);
                }

                
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                dsProductos1.Productos.Clear();
                Da.Fill(dsProductos1.Productos);
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            #region Cargado de Datos Anterior

            ////Segun habilitado o no
            //if (barToggleSwitchItem1.Checked == true)
            //{

            //    try
            //    {
            //        string FixedQuery = @"SELECT A.id
            //                                    ,A.[Codigo]
            //                                    ,A.[Descripcion]
	           //                                 ,coalesce(A.[Formula_code_V2], 0) as [formula_code] 
	           //                                 ,F.Descripcion as especie
            //                                    ,coalesce (A.[diametro], ' ') as [size]
            //                                    ,coalesce (B.description , '') as description
	           //                                 ,coalesce (D.short_name , '') as long_name
	           //                                 ,coalesce (E.description , '')  as typesaco
	           //                                 ,coalesce (C.description , '') as categoria
	           //                                 ,coalesce (g.description , '') as proceso
	           //                                 ,A.[Fecha] as Fecha
	           //                                 ,CASE WHEN A.[Estado] = 'a' Then
            //                                    'Habilitado'
            //                                        Else 
            //                                    'Inhabilitado' end as Estado
												//,coalesce (h.descripcion, '') as oridescripcion
												//,coalesce (a.tamanio, '') as tamanio
            //                                    ,coalesce(A.code_sap, 'NoConfig') as codeSAP
            //                                    ,I.date as fechaSAP
												//,Case when coalesce(I.id_formula,0) = (Select top 1 
												//												R.id
												//										From [dbo].[FML_Formulas_v2] R
												//										Where R.[codigo] = A.formula_code_V2
												//											and (R.estado > 39 and R.estado < 90)
												//											and  R.available_date < = SYSDATETIME()
												//											order by R.id Desc) then 1
												//	else 0 end as SubidoSAP
            //                                    ,[dias_vencimiento]
										  //FROM [dbo].[PT_Productos] A left join
            //                                   [dbo].[PT_Products_Bags] B on
            //                                     A.id_bag = B.id left join
            //                                   [dbo].PT_Products_Category C on
            //                                     A.id_category = c.id left join
            //                                   [dbo].[PT_Productos_Familias] D on
            //                                     A.family = D.id left join
            //                                   [dbo].[PT_Products_Portafolio] E on
            //                                     A.id_portafolio = E.id left join
            //                                   [dbo].[Conf_Especies] F on
            //                                     A.Especie = F.id left join
            //                                   .dbo.PT_Products_Process G on
            //                                     A.id_proceso = g.id left join
												// .dbo.PT_Products_Origen H on
												// A.id_origen = H.id LEFT JOIN (Select top 1 *
												//								from dbo.pt_log_update_fml_SAP X
												//								order by 1 desc )  I on A.id = I.id_pt	
            //                              order by A.id desc";



            //        DataOperations dp = new DataOperations();
            //        SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
            //        conn.Open();
            //        SqlDataAdapter Da = new SqlDataAdapter(FixedQuery, conn);
            //        dsProductos1.Productos.Clear();
            //        Da.Fill(dsProductos1.Productos);

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //if (barToggleSwitchItem1.Checked == false)
            //{
            //    try
            //    {
            //        string FixedQuery = @"SELECT A.id
            //                                    ,A.[Codigo]
            //                                    ,A.[Descripcion]
	           //                                 ,coalesce(A.[Formula_code_V2], 0) as [formula_code] 
	           //                                 ,F.Descripcion as especie
            //                                    ,coalesce (A.[diametro], ' ') as [size]
            //                                    ,coalesce (B.description , '') as description
	           //                                 ,coalesce (D.short_name , '') as long_name
	           //                                 ,coalesce (E.description , '')  as typesaco
	           //                                 ,coalesce (C.description , '') as categoria
	           //                                 ,coalesce (g.description , '') as proceso
	           //                                 ,A.[Fecha] as Fecha
	           //                                 ,CASE WHEN A.[Estado] = 'a' Then
            //                                    'Habilitado'
            //                                        Else 
            //                                    'Inhabilitado' end as Estado
												//,coalesce (h.descripcion, '') as oridescripcion
												//,coalesce (a.tamanio, '') as tamanio
            //                                    ,coalesce(A.code_sap, 'NoConfig') as codeSAP
            //                                    ,I.date as fechaSAP
												//,Case when coalesce(I.id_formula,0) = (Select top 1 
												//												R.id
												//										From [dbo].[FML_Formulas_v2] R
												//										Where R.[codigo] = A.formula_code_V2
												//											and (R.estado > 39 and R.estado < 90)
												//											and  R.available_date < = SYSDATETIME()
												//											order by R.id Desc) then 1
												//	else 0 end as SubidoSAP
            //                                    ,[dias_vencimiento]
										  //FROM [dbo].[PT_Productos] A left join
            //                                   [dbo].[PT_Products_Bags] B on
            //                                     A.id_bag = B.id left join
            //                                   [dbo].PT_Products_Category C on
            //                                     A.id_category = c.id left join
            //                                   [dbo].[PT_Productos_Familias] D on
            //                                     A.family = D.id left join
            //                                   [dbo].[PT_Products_Portafolio] E on
            //                                     A.id_portafolio = E.id left join
            //                                   [dbo].[Conf_Especies] F on
            //                                     A.Especie = F.id left join
            //                                   .dbo.PT_Products_Process G on
            //                                     A.id_proceso = g.id left join
												// .dbo.PT_Products_Origen H on
												// A.id_origen = H.id LEFT JOIN (Select top 1 *
												//								from dbo.pt_log_update_fml_SAP X
												//								order by 1 desc )  I on A.id = I.id_pt	
										  //where A.Estado = 'a'
            //                              order by A.id desc";



            //        DataOperations dp = new DataOperations();
            //        SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
            //        conn.Open();
            //        SqlDataAdapter Da = new SqlDataAdapter(FixedQuery, conn);
            //        dsProductos1.Productos.Clear();
            //        Da.Fill(dsProductos1.Productos);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            #endregion
        }

        private void barToggleSwitchItem2_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_Excel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl1.ExportToXlsx(dialog.FileName);
            }
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl1.ExportToXlsx(dialog.FileName);

            }
        }

        private void btnSAP_Click(object sender, EventArgs e)
        {
            if (btn_New.Visibility != DevExpress.XtraBars.BarItemVisibility.Never)
            {
                int idformu;
                var gridview = (GridView)gridControl1.FocusedView;
                var row = (DSProductos.ProductosRow)gridview.GetFocusedDataRow();
                if (user != "")
                {
                    if (ppass != "")
                    {
                        if (row.formula_code == 0 || row.formula_code == 0)
                        {
                            MessageBox.Show("Antes de actualizar la lista de materiales de SAP. actualizar la formula de Producto terminado a la par del Boton de exportar.", "ERROR: 00001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            #region VALIDACION DE ID ADICIONAL DENTRO DE SAP, REMPLAZADA POR VALIDACION CONFIGURADA EN PT_PRODUCTOS DE ACS
                            #endregion
                            if (row.codeSAP == "NoConfig")
                            {
                                MessageBox.Show("No se ha configurado el codigo SAP en ACS para este codigo de producto terminado", "ERROR: 00002", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                #region Validar si existe la lista de Materiales o hay que hacer un UPDATE
                                try
                                {
                                    try
                                    {

                                        string Query = @"sp_get_format_id_and_version_local_fml"; //Obtiene la ultima formula aprobada con este codigo 
                                                                                                  // Y que este disponible a la fecha
                                        SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                                        cn.Open();
                                        SqlCommand cmd = new SqlCommand(Query, cn);
                                        cmd.CommandType = CommandType.StoredProcedure;
                                        cmd.Parameters.AddWithValue("@codigo", row.formula_code);
                                        SqlDataReader dr = cmd.ExecuteReader();
                                        int id_formad = 0;
                                        int version = 0;
                                        if (dr.Read())
                                        {
                                            id_formad = dr.IsDBNull(0) ? 0 : dr.GetInt32(0);
                                            version = dr.IsDBNull(1) ? 0 : dr.GetInt32(1);
                                            id_Formula = dr.IsDBNull(2) ? 0 : dr.GetInt32(2);
                                            FMOP fml = new FMOP();
                                            DataTable dt = fml.formula_get_structure_SAP(id_formad);
                                            foreach (DataRow Valid in dt.Rows)
                                            {
                                                if (Valid["SAPcode"].ToString() == "--")
                                                {
                                                    MessageBox.Show("La materia prima:" + Valid["Materia Prima"].ToString() + " No tiene configurado el codigo de SAP");
                                                    return;
                                                }
                                            }
                                            SAPbobsCOM.Company Ob = dp.Company(user, ppass);
                                            SAPbobsCOM.ProductTrees oProduct = (SAPbobsCOM.ProductTrees)Ob.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductTrees);
                                            if (oProduct.GetByKey(row.codeSAP)) //Update
                                            {

                                                oProduct.UserFields.Fields.Item("U_Formula").Value = Convert.ToString(row.formula_code);
                                                oProduct.UserFields.Fields.Item("U_Version").Value = Convert.ToString(version);
                                                oProduct.Items.Delete();
                                                int i = 0;
                                                for (i = 0; i < oProduct.Items.Count; i++)
                                                {
                                                    oProduct.Items.SetCurrentLine(i);
                                                    oProduct.Items.Delete();
                                                }
                                                i = 0;
                                                foreach (DataRow Rows in dt.Rows)
                                                {
                                                    try
                                                    {
                                                        oProduct.Items.SetCurrentLine(i);
                                                        oProduct.Items.ItemCode = Rows["SAPcode"].ToString();
                                                        oProduct.Items.Warehouse = Rows["AlmacenPredeterminado"].ToString();
                                                        oProduct.Items.ParentItem = row.codeSAP;
                                                        oProduct.Items.Quantity = Convert.ToDouble(Rows["Kg x Batch"].ToString());
                                                        oProduct.Items.Add();


                                                        i++;
                                                    }
                                                    catch (Exception)
                                                    {


                                                    }
                                                }
                                                if (oProduct.Update() != 0)
                                                {

                                                    MessageBox.Show(Ob.GetLastErrorDescription());
                                                    return;
                                                }
                                                else
                                                {

                                                    try
                                                    {
                                                        string query = @"sp_insert_log_fml_to_sap";
                                                        cn = new SqlConnection(dp.ConnectionStringCostos);
                                                        cn.Open();
                                                        cmd = new SqlCommand(query, cn);
                                                        cmd.CommandType = CommandType.StoredProcedure;
                                                        cmd.Parameters.AddWithValue("@id_formula", id_Formula);
                                                        cmd.Parameters.AddWithValue("@id_pt", row.id);
                                                        cmd.ExecuteNonQuery();
                                                        row.SubidoSAP = true;
                                                        row.fechaSAP = DateTime.Now;
                                                        row.AcceptChanges();

                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        Console.WriteLine(ex.Message);
                                                        MessageBox.Show("Error al momento de guardar si la formula fua actualizada, pero el proceso continuo normalmente.");
                                                    }
                                                    MessageBox.Show("Lista de materiales Actualizada", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    return;
                                                }

                                            }
                                            else//Createe
                                            {
                                                oProduct = (SAPbobsCOM.ProductTrees)Ob.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductTrees);
                                                oProduct.TreeCode = row.codeSAP;
                                                oProduct.Quantity = 1.00;
                                                oProduct.UserFields.Fields.Item("U_Formula").Value = Convert.ToString(row.formula_code);
                                                oProduct.UserFields.Fields.Item("U_Version").Value = Convert.ToString(version);
                                                oProduct.UserFields.Fields.Item("U_CantidadKg").Value = 2500.00;
                                                oProduct.TreeType = SAPbobsCOM.BoItemTreeTypes.iProductionTree;
                                                oProduct.Warehouse = "BG007";
                                                oProduct.Items.ParentItem = row.codeSAP;
                                                int i = 0;
                                                foreach (DataRow A in dt.Rows)
                                                {

                                                    oProduct.Items.SetCurrentLine(i);
                                                    oProduct.Items.ParentItem = row.codeSAP;
                                                    oProduct.Items.ItemCode = A["SAPcode"].ToString();
                                                    oProduct.Items.Quantity = Convert.ToDouble(A["Kg x Batch"].ToString());
                                                    oProduct.Items.Add();
                                                    i = i + 1;
                                                }
                                                if (oProduct.Add() != 0)
                                                {

                                                    MessageBox.Show(Ob.GetLastErrorDescription());
                                                    return;
                                                }
                                                else
                                                {
                                                    try
                                                    {
                                                        string query = @"sp_insert_log_fml_to_sap";
                                                        cn = new SqlConnection(dp.ConnectionStringCostos);
                                                        cn.Open();
                                                        cmd = new SqlCommand(query, cn);
                                                        cmd.CommandType = CommandType.StoredProcedure;
                                                        cmd.Parameters.AddWithValue("@id_formula", id_Formula);
                                                        cmd.Parameters.AddWithValue("@id_pt", row.id);
                                                        cmd.ExecuteNonQuery();
                                                        row.SubidoSAP = true;
                                                        row.fechaSAP = DateTime.Now;
                                                        row.AcceptChanges();
                                                    }
                                                    catch (Exception ex)
                                                    {

                                                        MessageBox.Show("Error al momento de guardar si la formula fua actualizada, pero el proceso continuo normalmente.");
                                                    }
                                                    MessageBox.Show("Lista de materiales creada", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    return;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se ha encontrado una formula aprobada para realizar esta actualizacion.");
                                            return;
                                        }
                                    }
                                    catch (Exception ex)
                                    {

                                        MessageBox.Show("Algo anda mal...  " + ex.Message);
                                    }
                                    #endregion


                                }
                                catch (Exception EX)
                                {
                                    MessageBox.Show(EX.Message);
                                    return;
                                }


                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe autentificarse con las credenciales de SAP para poder cargar las Listas de Materiales", "ERROR: 00003", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }

                }
                else
                {
                    MessageBox.Show("Debe autentificarse con las credenciales de SAP para poder cargar las Listas de Materiales", "ERROR: 00003", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SAP.frmLoginSAP Saperoco = new SAP.frmLoginSAP();
            if (Saperoco.ShowDialog() == DialogResult.OK)
            {
                barEditItem1.EditValue = "Conectado a SAP";
                barEditItem1.Edit.Appearance.BackColor = Color.Green;
                barEditItem1.Edit.Appearance.ForeColor = Color.Black;
                user = Saperoco.user;
                ppass = Saperoco.pasword;
                btnSAP.ReadOnly = false;
            }
            else
            {

            }
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (DSProductos.ProductosRow)gridView.GetDataRow(e.RowHandle);
                if (row.SubidoSAP)
                {
                    e.Appearance.BackColor = Color.FromArgb(187, 235, 213);
                    
                }
                else
                {
                    e.Appearance.BackColor = Color.FromArgb(254, 240, 222);
                }
            }
        }

        private void barButtonActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            refresh_grid();
        }

        private void barButtonClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}


