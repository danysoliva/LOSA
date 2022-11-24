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
using System.Data.Sql;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using ACS.DataSetx;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Data.OleDb;
using ACS.SAP;
using ACS.Produccion.PlanProductionIntegrated;

namespace ACS.Produccion
{
    public partial class PP_Main_Products_Order : Form
    {

        DataOperations dp;
        string Codigo, Especie;
        int ID_Pedido;
        string file_name;
        string ActiveUserCode, ActiveUserName, ActiveUserType;
        string SAPuser, sappass = "";
        int id, type;

        public string ActiveUserCodeP
        {
            get { return ActiveUserCode; }
            set { ActiveUserCode = value; }
        }

        public string ActiveUserNameP
        {
            get { return ActiveUserName; }
            set { ActiveUserName = value; }
        }

        public string ActiveUserTypeP
        {
            get { return ActiveUserType; }
            set { ActiveUserType = value; }
        }
        UserLogin UsuarioLogeado;
        public PP_Main_Products_Order(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            dp = new DataOperations();
            LoadPresentaciones();
            LoadClasesAdicional();
        }

        private void LoadClasesAdicional()
        {
            try
            {
                string Qry = @"select 1 as id,
                               'Si' as descripcion
                        union all

                        select 0 as id,
                              'No' as descripcion;";
                SqlConnection CN = new SqlConnection(dp.ConnectionStringCostos);
                CN.Open();
                SqlCommand cmd = new SqlCommand(Qry, CN);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dSProductos1.clase.Clear();
                adat.Fill(dSProductos1.clase);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void barButtonNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Nuevo_Pedido Np = new Nuevo_Pedido();
            if (Np.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Se ha añadido un nuevo Pedido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ID_Pedido = Np.Indice;
                ribbonPageGroup2.Visible = true;
                load_EditCamaron();
                load_EditTilapia();

                //load_Data();
            }
        }

        private void barButtonCargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PT_Cargar_Pedido CP = new PT_Cargar_Pedido();
            if (CP.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ID_Pedido = CP.Id_Pedido;
                ribbonPageGroup2.Visible = true;
                load_EditCamaron();
                load_EditTilapia();

                //load_Data();
            }
        }

        private void PP_Main_Products_Order_Load(object sender, EventArgs e)
        {
        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var Question = MessageBox.Show("Estas seguro de concluir el pedido", "Se inhabilitara el pedido", MessageBoxButtons.YesNo);
            if (Question == System.Windows.Forms.DialogResult.Yes)
            {
                string Query;
                dp = new DataOperations();
                Query = @"UPDATE [dbo].[PT_Pedido]
                               SET [enable] = 0 " +
                          "WHERE id_Pedido = " + ID_Pedido;
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    CajaDialogo.Information("Se dio por concluido el pedido.");
                    ribbonPageGroup2.Visible = false;
                    borrar();
                }
                con.Close();
            }
            else
            {
                return;
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PP_Productions_Orders PO = new PP_Productions_Orders();
            dp = new DataOperations();
            if (PO.ShowDialog() == DialogResult.OK)
            {
                Codigo = PO.ProCodigo;
                ProductoTerminado PT = new ProductoTerminado(dp.ConnectionStringCostos);
                PT.Recuperar_producto(Codigo);
                string registro = PT.registro;
                dp = new DataOperations();
                Codigo = PO.ProCodigo;
                Especie = PO.EspecieX;
                string Qry;
                try
                {
                    Qry = @"EXEC [dbo].[PP_Insert_Detalle_Pedido]
		                    @Codigo = '" + Codigo + @"',
		                    @Registro = '" + registro + @"',
		                    @idPedido = " + ID_Pedido;
                    SqlConnection CN = new SqlConnection(dp.ConnectionStringCostos);
                    CN.Open();
                    SqlCommand cmd = new SqlCommand(Qry, CN);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error("Debe de ingresar el numero de formula en el portafolio para planificar este producto.");
                }
                load_EditCamaron();
                load_EditTilapia();
                //load_Data();
            }


        }
        public void load_EditCamaron()
        {
            dp = new DataOperations();
            string Query;
            Query = @"EXEC [dbo].[LlenadoDePedidoCamaron] @Id_Pedido = " + ID_Pedido;

            SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dSProductos1.PedidoDetalle.Clear();
            da.Fill(dSProductos1.PedidoDetalle);
            con.Close();
        }
        public void load_EditTilapia()
        {
            dp = new DataOperations();
            string Query;
            Query = @"EXEC [dbo].[LlenadoDePedidoTilapia] @Id_Pedido = " + ID_Pedido;

            SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dSProductos1.PedidoDetalleTilapia.Clear();
            da.Fill(dSProductos1.PedidoDetalleTilapia);
            con.Close();
        }
        void borrar()
        {
            dSProductos1.PedidoDetalle.Clear();
            dSProductos1.PedidoDetalleTilapia.Clear();
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Cursor.Position);
                try
                {
                    id = Convert.ToInt32(gridView1.GetDataRow(e.RowHandle)["id"]);
                    type = 0;
                }
                catch (Exception)
                {


                }
            }
        }
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }
        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
        }
        private void repositoryItemButtonEdit2_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            barButtonItem6.Enabled = true;
        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            switch (e.Column.FieldName)
            {
                case "cliente":
                    string CLIENTE = e.Value.ToString();
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                        con.Open();
                        string sqlx = @"UPDATE [dbo].[PT_Pedido_Detalle]
                                           SET [cliente] = @cliente
                                         WHERE id = @id";
                        SqlCommand cmd = new SqlCommand(sqlx, con);
                        //cmd.CommandType = CommandType.StoredProcedure;
                        var gridView = (GridView)gridControl1.FocusedView;
                        var row = (DSProductos.PedidoDetalleRow)gridView.GetFocusedDataRow();

                        cmd.Parameters.AddWithValue("@cliente", CLIENTE);
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
                case "adicional":
                    int pid_adicional = Convert.ToInt32(e.Value);
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                        con.Open();
                        string sqlx = @"UPDATE [dbo].[PT_Pedido_Detalle]
                                           SET [adicional] = @add
                                         WHERE id = @id";
                        SqlCommand cmd = new SqlCommand(sqlx, con);
                        //cmd.CommandType = CommandType.StoredProcedure;
                        var gridView = (GridView)gridControl1.FocusedView;
                        var row = (DSProductos.PedidoDetalleRow)gridView.GetFocusedDataRow();

                        cmd.Parameters.AddWithValue("@add", pid_adicional);
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
                case "obs":
                    string obs = e.Value.ToString();
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                        con.Open();
                        string sqlx = @"UPDATE [dbo].[PT_Pedido_Detalle]
                                           SET [obs] = @obs
                                         WHERE id = @id";
                        SqlCommand cmd = new SqlCommand(sqlx, con);
                        //cmd.CommandType = CommandType.StoredProcedure;
                        var gridView = (GridView)gridControl1.FocusedView;
                        var row = (DSProductos.PedidoDetalleRow)gridView.GetFocusedDataRow();

                        cmd.Parameters.AddWithValue("@obs", obs);
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
                case "id_presentacion":
                    try
                    {
                        var gridView = (GridView)gridControl1.FocusedView;
                        var row = (DSProductos.PedidoDetalleRow)gridView.GetFocusedDataRow();

                        decimal Factor = 1;
                        foreach (DSProductos.presentacionesRow pres in dSProductos1.presentaciones.Rows)
                        {
                            if (pres.id == Convert.ToInt32(e.Value))
                            {
                                Factor = pres.factor;
                            }
                        }
                        decimal CantidadKg = row.Peso_pedido * 1000;
                        decimal cantSacos = 0;
                        int Conver = 0;
                        cantSacos = CantidadKg / Factor;
                        Conver = Convert.ToInt32(cantSacos);
                        if (Conver < cantSacos)
                        {
                            Conver++;
                        }
                        row.Sacos = Conver;
                        row.AcceptChanges();
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                        con.Open();
                        string sqlx = @"UPDATE [dbo].[PT_Pedido_Detalle]
                                           SET [id_presentacion] = @id_pres  ,
                                                [Sacos] = @Sacos
                                         WHERE id = @id";
                        SqlCommand cmd = new SqlCommand(sqlx, con);
                        cmd.Parameters.AddWithValue("@id_pres", row.id_presentacion);
                        cmd.Parameters.AddWithValue("@Sacos", row.Sacos);
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
                case "batch":
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                        con.Open();
                        string sqlx = @"UPDATE [dbo].[PT_Pedido_Detalle]
                                           SET [batch] = @batch
                                         WHERE id = @id";
                        SqlCommand cmd = new SqlCommand(sqlx, con);
                        //cmd.CommandType = CommandType.StoredProcedure;
                        var gridView = (GridView)gridControl1.FocusedView;
                        var row = (DSProductos.PedidoDetalleRow)gridView.GetFocusedDataRow();

                        cmd.Parameters.AddWithValue("@batch", e.Value);
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
                default:
                    try
                    {
                        decimal PesoKG, Save, frac, ver;
                        int batch, Sacos, prioridad, id_pedido;
                        string codex;
                        PesoKG = 0; Save = 0; frac = 0; Sacos = 0;
                        batch = 0;
                        decimal ConverSave;

                        decimal tamañoSaco;
                        string destino, registro;
                        var GridView = (GridView)gridControl1.FocusedView;
                        var row = (DSProductos.PedidoDetalleRow)GridView.GetFocusedDataRow();
                        id_pedido = row.id_pedido;
                        int IDPEDIDODETALLE = Convert.ToInt32(row.id);
                        codex = row.Codigo;
                        PesoKG = Convert.ToDecimal(row.Peso_pedido);
                        ConverSave = PesoKG * 1000;
                        batch = Convert.ToInt32(ConverSave / 2500);
                        Save = ConverSave / 2500;
                        frac = Save - batch;
                        if (frac > 0)
                        {
                            batch = batch + 1;
                        }

                        tamañoSaco = Convert.ToDecimal(row.id_bag);
                        ver = (PesoKG * 1000) / tamañoSaco;
                        Sacos = Convert.ToInt32(ver);
                        Save = (PesoKG * 1000) / tamañoSaco;
                        frac = Save - Sacos;
                        if (frac > 0)
                        {
                            Sacos = Sacos + 1;
                        }
                        row.Sacos = Sacos;
                        row.batch = batch;
                        //string fecha = Convert.ToString(row.fecha_de_trabajo);


                        prioridad = row.prioridad;
                        destino = row.Destino;
                        if (destino.Length > 25)
                        {
                            destino = destino.Substring(25);
                        }
                        registro = row.Registro;
                        string detallezar = row.zardetalle;
                        string formula = row.formula_vigente;
                        //if (row.fecha_de_trabajo == null)
                        //{
                        //    row.fecha_de_trabajo = DateTime.Now;
                        //}
                        string Query;
                        Query = @"UPDATE [dbo].[PT_Pedido_Detalle]
                               SET  [formula_vigente] = '" + formula + "'" +
                                           ",[batch] = " + batch + " " +
                                           ",[Peso_Pedido] = " + PesoKG + "  " +
                                           ",[Prioridad] = " + prioridad + " " +
                                           ",[Sacos] = " + Sacos + "  " +
                                           ",[Destino] = '" + destino + "'" +
                                           ",[Registro] = '" + registro + "' " +
                                           ",[fecha_de_trabajo] =  '" + string.Format("{0:MM/dd/yyyy HH:mm:ss }", row.fecha_de_trabajo) +
                                           "' ,[detalleZar] = '" + detallezar +
                               "' WHERE cod_Produc = '" + codex + "' and id_pedido = " + id_pedido + " and id = " + IDPEDIDODETALLE;
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(Query, cn);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        load_EditCamaron();

                        //load_Data();
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    break;
            }
            
            
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl1.ExportToXlsx(dialog.FileName);
                //gridControl2.ExportToXlsx(dialog.FileName);
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                file_name = string.Empty;

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Excel File(.xlsx)| *.xlsx";
                //dialog.InitialDirectory = @"C:\";
                dialog.Title = "Un archivo que tenga solo productos terminados y toneladas.";

                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    file_name = @dialog.FileName.ToString();
                    string Connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file_name + "; Extended Properties=\"Excel 12.0 Xml; HDR = YES\"";
                    OleDbConnection con = new OleDbConnection(Connection);
                    OleDbDataAdapter myCommand = new OleDbDataAdapter("select * from [Hoja1$]", con);
                    dSProductos1.CargarData.Clear();
                    myCommand.Fill(dSProductos1.CargarData);
                    foreach (DataRow row in dSProductos1.CargarData.Rows)
                    {
                        Codigo = row["Codigo"].ToString();
                        ProductoTerminado PT = new ProductoTerminado(dp.ConnectionStringCostos);
                        PT.Recuperar_producto(Codigo);
                        string registro = PT.registro;
                        dp = new DataOperations();
                        string Qry;
                        Qry = @"[dbo].[PT_Insert_of_Pedido] @Codigo = '" + Codigo + "' " +
                            ", @ID_Pedido = " + ID_Pedido + "" +
                            ", @registro = '" + registro + "'" +
                            ", @Toneladas = " + row["toneladas"].ToString();

                        SqlConnection CN = new SqlConnection(dp.ConnectionStringCostos);
                        CN.Open();
                        SqlCommand cmd = new SqlCommand(Qry, CN);
                        cmd.ExecuteNonQuery();
                        CN.Close();
                        load_EditCamaron();
                        load_EditTilapia();
                    }


                }


            }
            catch (Exception)
            {

                CajaDialogo.Error("Error al cargar los datos desde el excel, revise nuevamente.");
            }


        }


        private void gridView1_Click(object sender, EventArgs e)
        {
            barButtonItem6.Enabled = true;
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            barButtonItem6.Enabled = true;
        }

        private void gridView1_LostFocus(object sender, EventArgs e)
        {
            //barButtonItem6.Enabled = false;
        }

        private void BarButtonReporte_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProgramaProduccion report = new ProgramaProduccion(ID_Pedido, UsuarioLogeado.Nombre);
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(report);
            printReport.ShowPreview();
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            switch (e.Column.FieldName)
            {
                case "cliente":
                    string CLIENTE = e.Value.ToString();
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                        con.Open();
                        string sqlx = @"UPDATE [dbo].[PT_Pedido_Detalle]
                                           SET [cliente] = @cliente
                                         WHERE id = @id";
                        SqlCommand cmd = new SqlCommand(sqlx, con);
                        //cmd.CommandType = CommandType.StoredProcedure;
                        var gridView = (GridView)gridControl2.FocusedView;
                        var row = (DSProductos.PedidoDetalleTilapiaRow)gridView.GetFocusedDataRow();

                        cmd.Parameters.AddWithValue("@cliente", CLIENTE);
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
                case "adicional":
                    int pid_adicional = Convert.ToInt32(e.Value);
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                        con.Open();
                        string sqlx = @"UPDATE [dbo].[PT_Pedido_Detalle]
                                           SET [adicional] = @add
                                         WHERE id = @id";
                        SqlCommand cmd = new SqlCommand(sqlx, con);
                        //cmd.CommandType = CommandType.StoredProcedure;
                        var gridView = (GridView)gridControl1.FocusedView;
                        var row = (DSProductos.PedidoDetalleRow)gridView.GetFocusedDataRow();

                        cmd.Parameters.AddWithValue("@add", pid_adicional);
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
                case "obs":
                    string obs = e.Value.ToString();
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                        con.Open();
                        string sqlx = @"UPDATE [dbo].[PT_Pedido_Detalle]
                                           SET [obs] = @obs
                                         WHERE id = @id";
                        SqlCommand cmd = new SqlCommand(sqlx, con);
                        //cmd.CommandType = CommandType.StoredProcedure;
                        var gridView = (GridView)gridControl2.FocusedView;
                        var row = (DSProductos.PedidoDetalleTilapiaRow)gridView.GetFocusedDataRow();

                        cmd.Parameters.AddWithValue("@obs", obs);
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
                case "id_presentacion":
                    try
                    {
                      
                        //cmd.CommandType = CommandType.StoredProcedure;
                        var gridView = (GridView)gridControl2.FocusedView;
                        var row = (DSProductos.PedidoDetalleTilapiaRow)gridView.GetFocusedDataRow();

                      
                        decimal Factor = 1;
                        foreach (DSProductos.presentacionesRow pres in dSProductos1.presentaciones.Rows)
                        {
                            if (pres.id == row.id_presentacion)
                            {
                                Factor = pres.factor;
                            }
                        }
                        decimal CantidadKg = row.Peso_pedido * 1000;
                        decimal cantSacos = 0;
                        int Conver = 0;
                        cantSacos = CantidadKg / Factor;
                        Conver = Convert.ToInt32(cantSacos);
                        if (Conver < cantSacos)
                        {
                            Conver++;
                        }
                        row.Sacos = Conver;
                        row.AcceptChanges();
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                        con.Open();
                        string sqlx = @"UPDATE [dbo].[PT_Pedido_Detalle]
                                           SET [id_presentacion] = @id_pres  ,
                                                [Sacos] = @Sacos
                                         WHERE id = @id";
                        SqlCommand cmd = new SqlCommand(sqlx, con);
                        cmd.Parameters.AddWithValue("@id_pres", row.id_presentacion);
                        cmd.Parameters.AddWithValue("@Sacos", row.Sacos);
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
                case "batch":
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                        con.Open();
                        string sqlx = @"UPDATE [dbo].[PT_Pedido_Detalle]
                                           SET [batch] = @batch
                                         WHERE id = @id";
                        SqlCommand cmd = new SqlCommand(sqlx, con);
                        //cmd.CommandType = CommandType.StoredProcedure;
                        var gridView = (GridView)gridControl1.FocusedView;
                        var row = (DSProductos.PedidoDetalleRow)gridView.GetFocusedDataRow();

                        cmd.Parameters.AddWithValue("@batch", e.Value);
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
                default:
                    try
                    {
                        decimal PesoKG, Save, frac, ver;
                        int batch, Sacos, prioridad, id_pedido;
                        string codex;
                        PesoKG = 0; Save = 0; frac = 0; Sacos = 0;
                        batch = 0;
                        Decimal ConverSave;

                        decimal tamañoSaco;
                        string destino, registro;
                        var GridView = (GridView)gridControl2.FocusedView;
                        var row = (DSProductos.PedidoDetalleTilapiaRow)GridView.GetFocusedDataRow();
                        int IDPEDIDODETALLE = Convert.ToInt32(row.id);
                        id_pedido = row.id_pedido;
                        codex = row.Codigo;
                        PesoKG = Convert.ToDecimal(row.Peso_pedido);
                        ConverSave = PesoKG * 1000;
                        batch = Convert.ToInt32(ConverSave / 2500);
                        Save = ConverSave / 2500;
                        frac = Save - batch;
                        if (frac > 0)
                        {
                            batch = batch + 1;
                        }

                        tamañoSaco = Convert.ToDecimal(row.id_bag);
                        ver = (PesoKG * 1000) / tamañoSaco;
                        Sacos = Convert.ToInt32(ver);
                        Save = (PesoKG * 1000) / tamañoSaco;
                        frac = Save - Sacos;
                        if (frac > 0)
                        {
                            Sacos = Sacos + 1;
                        }
                        row.Sacos = Sacos;
                        row.batch = batch;
                        //string fecha = Convert.ToString(row.fecha_de_trabajo);


                        prioridad = row.prioridad;
                        destino = row.Destino;
                        registro = row.Registro;
                        string detallezar = row.zardetalle;
                        string formula = row.formula_vigente;
                        //if (row.fecha_de_trabajo == null)
                        //{
                        //    row.fecha_de_trabajo = DateTime.Now;
                        //}
                        string Query;
                        Query = @"UPDATE [dbo].[PT_Pedido_Detalle]
                               SET  [formula_vigente] = '" + formula + "'" +
                                           ",[batch] = " + batch + " " +
                                           ",[Peso_Pedido] = " + PesoKG + "  " +
                                           ",[Prioridad] = " + prioridad + " " +
                                           ",[Sacos] = " + Sacos + "  " +
                                           ",[Destino] = '" + destino + "'" +
                                           ",[Registro] = '" + registro + "' " +
                                           ",[fecha_de_trabajo] =  '" + string.Format("{0:MM/dd/yyyy HH:mm:ss }", row.fecha_de_trabajo) +
                                           "' ,[detalleZar] = '" + detallezar +
                               "' WHERE cod_Produc = '" + codex + "' and id_pedido = " + id_pedido + "and id = " + IDPEDIDODETALLE;
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(Query, cn);
                        cmd.ExecuteNonQuery();

                        load_EditTilapia();
                        //load_Data();
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    break;
            }

                
        }

        private void repositoryItemButtonEdit4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var GridView = (GridView)gridControl1.FocusedView;
            var row = (DSProductos.PedidoDetalleRow)GridView.GetFocusedDataRow();

            //if (row.lote != 0)
            if(ValidarSi_se_produjo_lote_pt(row.lote))
            {
                CajaDialogo.Error("No se puede eliminar una orden que ya fue enviada a produccion.");
                return;
            }
            if (MessageBox.Show("Desea eleminar este producto de este pedido? " + 
                                 Convert.ToString(row.Descripcion), "Eliminar producto de pedido", 
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dp = new DataOperations();
                    string QryDelete;
                    QryDelete = @"sp_set_disable_pedido_detalle_row";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(QryDelete, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_pedido", Convert.ToInt32(row.id));
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
                load_EditCamaron();
                load_EditTilapia();
            }
        }

        private bool ValidarSi_se_produjo_lote_pt(int pLote)
        {
            bool val = false;
            try
            {
                dp = new DataOperations();
                string QryDelete;
                QryDelete = @"sp_get_validar_si_se_produjo_lote_pt";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
                cn.Open();
                SqlCommand cmd = new SqlCommand(QryDelete, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote_pt", pLote);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int valor_int = dr.GetInt32(0);
                    if (valor_int == 1)
                        val = true;
                    else
                        val = false;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            return val;
        }

        private void repositoryItemButtonEdit5_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var GridView = (GridView)gridControl2.FocusedView;
            var row = (DSProductos.PedidoDetalleTilapiaRow)GridView.GetFocusedDataRow();

            if (MessageBox.Show("Desea eleminar este producto de este pedido? " + Convert.ToString(row.Descripcion), "Eliminar producto de pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dp = new DataOperations();
                    string QryDelete;
                    QryDelete = @"sp_set_disable_pedido_detalle_row";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(QryDelete, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_pedido", Convert.ToInt32(row.id));
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }
                load_EditCamaron();
                load_EditTilapia();
                //load_Data();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void repositoryItemButtonEdit3_Click(object sender, EventArgs e)
        {
            var GridView = (GridView)gridControl2.FocusedView;
            var row = (DSProductos.PedidoDetalleTilapiaRow)GridView.GetFocusedDataRow();
            Codigo = Convert.ToString(row.Codigo);
            Llenado_Zarandas LLZ = new Llenado_Zarandas(Codigo);
            if (LLZ.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    string Queryupdate;
                    dp = new DataOperations();
                    Queryupdate = @"UPDATE  [dbo].[PT_Pedido_Detalle]
                                    SET [detalleZar] = (Select ACS.dbo.Llenado_Zarandas('" + Codigo + "')) " +
                                        " WHERE cod_Produc = '" + Codigo + "' and id_pedido = " + ID_Pedido;
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Queryupdate, cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();


                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }

                load_EditTilapia();
                //load_Data();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLoginSAP log = new frmLoginSAP();/*Aqui se obtiene las credenciales del usuario que hara las transacciones de SAP
                                                    Es preciso mencionar que se respeta el nivel de autorizaciones de documentos.
                                                    Asi que si usted tiene unas credenciales de Finanzas no podra hacer el trabajo de produccion; y si los permisos lo dejan
                                                    las licencias le haran el bloqueo. Solo puede hacerlo una licencia de logistica, y que tenga las autorizaciones necesarias.
                                                    el manager, por ser el manager puede hacerlo. Simplemente tenerlo en cuenta. ya que les puede causar inconveniente si desean hacerlo
                                                    con el tipo de licencia inadecuado o con usuarios sin autorizaciones.*/
            if (log.ShowDialog() == DialogResult.OK)
            {
                SAPuser = log.user;
                sappass = log.pasword;
                barStaticItem1.Caption = "Conectado a SAP";
                barButtonItem8.ItemAppearance.Normal.BackColor = Color.FromArgb(192, 255, 192);
            }
            else
            {
                barButtonItem8.ItemAppearance.Normal.BackColor = Color.Transparent;
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void gridView2_RowClick(object sender, RowClickEventArgs e)// Tilapia
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Cursor.Position);
                try
                {
                    id = Convert.ToInt32(gridView2.GetDataRow(e.RowHandle)["id"]);//Con cada click row se obtiene el id
                    type = 1;// Esto ayuda a identificar de que gridcontrol viene la data; Cuando es  viene del Grid de Camaron y cuando es 1 viene del grid de Tilapia
                }
                catch (Exception)
                {


                }
            }
        }

        private void btnLiberar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)/*Los demas botones del contros popup siguen esta logica.
                                                                                                  Si tiene algun inconveniente con alguno. Revisar este que esta con los comentarios*/
        {
            #region CAMBIAR STATUS A LIBERADO DE ORDEN DE FABRICACION
            if (SAPuser == string.Empty || sappass == "")//Valida si se hizo el login o no. Simple, pero funcional.
            {
                MessageBox.Show("Debe iniciar sesion en SAP para crear la lista de materiales.");
                return;
            }
            else
            {
                int Docentry = 0;
                if (type == 0)
                {
                    foreach (DataRow row in dSProductos1.PedidoDetalle.Rows)
                    {
                        if (id == Convert.ToInt32(row["id"]))//Esta variable ID se obtiene con el evento gridview1.RowClick para poder validar si ya existe una orden de fabricacion con este regristro.
                        {
                            Docentry = Convert.ToInt32(row["docentry"]);// Obtenemos el Docentry de la orden de fabricacion en la tabla de Pedido detalle que esta corresponde a la de Camaron
                        }
                    }
                    if (Docentry != 0)
                    {
                        SAPbobsCOM.Company Ob = dp.Company(SAPuser, sappass);//Invoca el objeto de SAP y le asigna las credenciales impotadas en el formulario de acceso a SAP
                        SAPbobsCOM.ProductionOrders oProduct = (SAPbobsCOM.ProductionOrders)Ob.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders); // LLama al objeto de Orden de fabricacion de SAP
                        if (oProduct.GetByKey(Docentry))//Se obtiene el documento buscado, este DocEntry se guarda en la tabla de Pedido Detalle al momento de crear la orden de fabricacion por SDK; en ACS.
                        {

                            switch (oProduct.ProductionOrderStatus) // Segun el estado de la orden se hacen estos casos diferentes.
                            {
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposPlanned:
                                    oProduct.ProductionOrderStatus = SAPbobsCOM.BoProductionOrderStatusEnum.boposReleased;
                                    if (oProduct.Update() != 0)
                                    {
                                        MessageBox.Show(Ob.GetLastErrorDescription());/*La mayoria de los posibles errores ya estan cubiertos con el switch. Asi que si hay algun problema. este Log de la sdk le dirá
                                         Tambine pueda ser un transaccion Notification que la sdk respeta esos bloqueos. */                                               
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Se cambio el estado a Liberdado.");
                                    }
                                    break;
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposReleased:
                                    MessageBox.Show("Ya se encuentra liberado esta orden de fabricacion.");
                                    break;
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposClosed:
                                    MessageBox.Show("No se puede liberar una orden ya cerrada");
                                    break;
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposCancelled:
                                    MessageBox.Show("La orden ya fue cancelada anteriormente.");
                                    break;
                                default:
                                    break;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Algo anda mal con la orden en SAP");//No ha llegado ha este punto, no sabria decirle a ciencia cierta por que se llego aqui. Tambien pueda ser que no encontro el documento.
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha creado una orden de fabricacion en SAP");//Si no encuentra el docEntry, es que esta malo. ó esta equivocado.
                    }
                }
                else
                {
                    foreach (DataRow row in dSProductos1.PedidoDetalleTilapia.Rows)//obtenemos el docentry para tilapia
                    {
                        if (id == Convert.ToInt32(row["id"]))
                        {
                            Docentry = Convert.ToInt32(row["docentry"]);
                        }
                    }
                    if (Docentry != 0)
                    {
                        SAPbobsCOM.Company Ob = dp.Company(SAPuser, sappass);//Enviamos las credenciales
                        SAPbobsCOM.ProductionOrders oProduct = (SAPbobsCOM.ProductionOrders)Ob.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders); //Obtenemos el objeto del documento.
                        if (oProduct.GetByKey(Docentry))///El docentry guardado lo buscamos en SAP
                        {

                            switch (oProduct.ProductionOrderStatus)//Swich segun los status que tenemos en SAP.
                            {
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposPlanned:
                                    oProduct.ProductionOrderStatus = SAPbobsCOM.BoProductionOrderStatusEnum.boposReleased;
                                    if (oProduct.Update() != 0)
                                    {
                                        MessageBox.Show(Ob.GetLastErrorDescription());
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Se cambio el estado a Liberdado.");
                                    }
                                    break;
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposReleased:
                                    MessageBox.Show("Ya se encuentra liberado esta orden de fabricacion.");
                                    break;
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposClosed:
                                    MessageBox.Show("No se puede liberar una orden ya cerrada");
                                    break;
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposCancelled:
                                    MessageBox.Show("La orden ya fue cancelada anteriormente.");
                                    break;
                                default:
                                    break;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Algo anda mal con la orden en SAP");
                        }

                    }
                    else
                    {
                        MessageBox.Show("No se ha creado una orden de fabricacion en SAP");
                    }
                }
               
            }
            #endregion
        }

        private void btncancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//La documentacion y la explicacion de este evento esta en otro;buscar este evento "btnLiberar_ItemClic" para entender este.
        {
            #region btn CANCELAR ORDEN DE FABRICACION EN SAP
            if (SAPuser == string.Empty || sappass == "")
            {
                MessageBox.Show("Debe iniciar sesion en SAP para crear la lista de materiales.");
                return;
            }
            else
            {
                int Docentry = 0;
                if (type == 0)
                {
                    foreach (DataRow row in dSProductos1.PedidoDetalle.Rows)
                    {
                        if (id == Convert.ToInt32(row["id"]))
                        {
                            Docentry = Convert.ToInt32(row["docentry"]);
                        } 
                    }
                    if (Docentry != 0)
                    {
                        SAPbobsCOM.Company Ob = dp.Company(SAPuser, sappass);//Invoca el objeto de SAP y le asigna las credenciales impotadas en el formulario de acceso a SAP
                        SAPbobsCOM.ProductionOrders oProduct = (SAPbobsCOM.ProductionOrders)Ob.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders); // LLama al objeto de Orden de fabricacion de SAP
                        if (oProduct.GetByKey(Docentry))//Se obtiene el documento buscado, este DocEntry se guarda en la tabla de Pedido Detalle al momento de crear la orden de fabricacion por SDK; en ACS.
                        {

                            switch (oProduct.ProductionOrderStatus) // Segun el estado de la orden se hacen estos casos diferentes.
                            {
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposPlanned:
                                    oProduct.ProductionOrderStatus = SAPbobsCOM.BoProductionOrderStatusEnum.boposCancelled;
                                    if (oProduct.Update() != 0)
                                    {
                                        MessageBox.Show(Ob.GetLastErrorDescription());/*La mayoria de los posibles errores ya estan cubiertos con el switch. Asi que si hay algun problema. este Log de la sdk le dirá
                                         Tambine pueda ser un transaccion Notification que la sdk respeta esos bloqueos. */
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Se cambio el estado a Cancelado.");
                                    }
                                    break;
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposReleased:
                                    if (MessageBox.Show("La orden se encuentra en estado liberado, seguro que deseas Cancelarla?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                                    {
                                        oProduct.ProductionOrderStatus = SAPbobsCOM.BoProductionOrderStatusEnum.boposCancelled;
                                        if (oProduct.Update() != 0)
                                        {
                                            MessageBox.Show(Ob.GetLastErrorDescription());/*La mayoria de los posibles errores ya estan cubiertos con el switch. Asi que si hay algun problema. este Log de la sdk le dirá
                                         Tambine pueda ser un transaccion Notification que la sdk respeta esos bloqueos. */
                                            return;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Se cambio el estado a Cancelado.");
                                        }
                                    }
                                    else
                                    {
                                        return;
                                    }
                                    break;
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposClosed:
                                    MessageBox.Show("No se puede cancelar una orden ya cerrada.");
                                    break;
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposCancelled:
                                    MessageBox.Show("La orden ya fue cancelada anteriormente.");
                                    break;
                                default:
                                    break;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Algo anda mal con la orden en SAP");//No ha llegado ha este punto, no sabria decirle a ciencia cierta por que se llego aqui. Tambien pueda ser que no encontro el documento.
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha creado una orden de fabricacion en SAP");
                    }
                }
                else
                {
                    foreach (DataRow row in dSProductos1.PedidoDetalleTilapia.Rows)
                    {
                        if (id == Convert.ToInt32(row["id"]))
                        {
                            Docentry = Convert.ToInt32(row["docentry"]);
                        }
                    }
                    if (Docentry != 0)
                    {
                        SAPbobsCOM.Company Ob = dp.Company(SAPuser, sappass);//Invoca el objeto de SAP y le asigna las credenciales impotadas en el formulario de acceso a SAP
                        SAPbobsCOM.ProductionOrders oProduct = (SAPbobsCOM.ProductionOrders)Ob.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders); // LLama al objeto de Orden de fabricacion de SAP
                        if (oProduct.GetByKey(Docentry))//Se obtiene el documento buscado, este DocEntry se guarda en la tabla de Pedido Detalle al momento de crear la orden de fabricacion por SDK; en ACS.
                        {

                            switch (oProduct.ProductionOrderStatus) // Segun el estado de la orden se hacen estos casos diferentes.
                            {
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposPlanned:
                                    oProduct.ProductionOrderStatus = SAPbobsCOM.BoProductionOrderStatusEnum.boposCancelled;
                                    if (oProduct.Update() != 0)
                                    {
                                        MessageBox.Show(Ob.GetLastErrorDescription());/*La mayoria de los posibles errores ya estan cubiertos con el switch. Asi que si hay algun problema. este Log de la sdk le dirá
                                         Tambine pueda ser un transaccion Notification que la sdk respeta esos bloqueos. */
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Se cambio el estado a Cancelado.");
                                    }
                                    break;
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposReleased:
                                    if (MessageBox.Show("La orden se encuentra en estado liberado, seguro que deseas Cancelarla?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                                    {
                                        oProduct.ProductionOrderStatus = SAPbobsCOM.BoProductionOrderStatusEnum.boposCancelled;
                                        if (oProduct.Update() != 0)
                                        {
                                            MessageBox.Show(Ob.GetLastErrorDescription());/*La mayoria de los posibles errores ya estan cubiertos con el switch. Asi que si hay algun problema. este Log de la sdk le dirá
                                         Tambine pueda ser un transaccion Notification que la sdk respeta esos bloqueos. */
                                            return;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Se cambio el estado a Cancelado.");
                                        }
                                    }
                                    else
                                    {
                                        return;
                                    }
                                    break;
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposClosed:
                                    MessageBox.Show("No se puede cancelar una orden ya cerrada.");
                                    break;
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposCancelled:
                                    MessageBox.Show("La orden ya fue cancelada anteriormente.");
                                    break;
                                default:
                                    break;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Algo anda mal con la orden en SAP");//No ha llegado ha este punto, no sabria decirle a ciencia cierta por que se llego aqui. Tambien pueda ser que no encontro el documento.
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha creado una orden de fabricacion en SAP");
                    }
                }
            }
            #endregion
        }

        private void btnSAPUp_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var GridView = (GridView)gridControl2.FocusedView;
            var row = (DSProductos.PedidoDetalleTilapiaRow)GridView.GetFocusedDataRow();

            if (row.lote == 0)
            {
                CajaDialogo.Error("Debe registrar primero la orden de produccion para subir la orden de fabricacion a SAP.");
                return;
            }

            if (SAPuser == string.Empty || sappass == "")//Valida las credenciales
            {
                MessageBox.Show("Debe iniciar sesion en SAP para crear la lista de materiales.");
                return;
            }
            else
            {
                try
                {

                    if (row.docentry == 0) //Valida si ya existe en SAP. Si tiene algun numero es que ya se creo una orden de Fabricacion.
                    {
                        SAPbobsCOM.Company Ob = dp.Company(SAPuser, sappass);//Crea el objeto company que vuelve a validar las credenciales.
                        SAPbobsCOM.ProductionOrders oProduct = (SAPbobsCOM.ProductionOrders)Ob.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders);//Se obtiene el objeto de SAP.
                        oProduct.ItemNo = row.code_sap;//Se agisna el codigo de SAP.
                        oProduct.Warehouse = "BG007";//El almacen al cual siempre va ir. Se puede dejar dinamico haciendo una minicolsulta a una tabla de configuracion. Pero no va cambiar nunca esto.
                        oProduct.UserFields.Fields.Item("U_Formula").Value = row.formula_code; // la formula, y la vigencia. que se guardan en campos definidos por el usuario. Asi se llaman esos campos.
                        oProduct.UserFields.Fields.Item("U_Version").Value = row.formula_vigente;
                        oProduct.UserFields.Fields.Item("U_U_cliente").Value = row.cliente;
                        oProduct.UserFields.Fields.Item("U_U_lote").Value = row.lote;
                        oProduct.UserFields.Fields.Item("U_U_Registro").Value = row.Registro;
                        oProduct.UserFields.Fields.Item("U_U_destino").Value = row.Destino;
                        oProduct.StartDate = row.fecha_ini;//Fecha de programacion segun la dataa ingresada.
                        oProduct.PostingDate = DateTime.Now;//la fecha de ingreso.
                        oProduct.DueDate = row.fecha_fin;//fecha de finalizacion, este hay que hacerle algun cambio sobre su manipulacion
                        oProduct.Priority = 100;//row.prioridad;//la prioridad de la orden. EN SAP el defaul value es 100...
                        oProduct.PlannedQuantity = Convert.ToDouble(row.batch) * 2500; //las toneladas multiplicadas por 2500, procedimiento similar al que se realiza en SAP.
                        //Se podria poner desde aqui el estado liberado a la orden. pero por alguna razon, muy de SAP no permite crear la orden de fabricaion en estado liberado.
                        if (oProduct.Add() != 0)//Devuelve 0 si no se crea el documento, si hay algun error. 
                        {
                            MessageBox.Show(Ob.GetLastErrorDescription());
                            return;
                        }
                        else
                        {
                            int save = Convert.ToInt32(Ob.GetNewObjectKey());
                            row.docentry = Convert.ToInt32(Ob.GetNewObjectKey());//Guardamos en la tabla pedido detalle el Docentry Generado.
                            string Query;
                            Query = @"UPDATE [dbo].[PT_Pedido_Detalle]
                                       SET 
                                          [DocEntry] = " + save + @"
                                     WHERE id = " + row.id;
                            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                            cn.Open();
                            SqlCommand cmd = new SqlCommand(Query, cn);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Orden de fabricacion creada..");
                            foreach (DataRow rows in dSProductos1.PedidoDetalleTilapia.Rows)
                            {
                                if (row.id == Convert.ToInt32(row["id"]))
                                {
                                    row["id"] = save; 
                                }//en la vista tambien debe guardarse. Por si se necesita cambiar el estado de la orden
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe una orden de Fabricacion para este producto.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        private void btncerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//La documentacion y la explicacion de este evento esta en otro;buscar este evento "btnLiberar_ItemClic" para entender este.
        {
            if (SAPuser == string.Empty || sappass == "")
            {
                MessageBox.Show("Debe iniciar sesion en SAP para crear la lista de materiales.");
                return;
            }
            else
            {
                int Docentry = 0;
                if (type == 0)
                {
                    foreach (DataRow row in dSProductos1.PedidoDetalle.Rows)
                    {
                        if (id == Convert.ToInt32(row["id"]))
                        {
                            Docentry = Convert.ToInt32(row["docentry"]);
                        }
                    }
                    if (Docentry != 0)
                    {
                        SAPbobsCOM.Company Ob = dp.Company(SAPuser, sappass);//Invoca el objeto de SAP y le asigna las credenciales impotadas en el formulario de acceso a SAP
                        SAPbobsCOM.ProductionOrders oProduct = (SAPbobsCOM.ProductionOrders)Ob.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders); // LLama al objeto de Orden de fabricacion de SAP
                        if (oProduct.GetByKey(Docentry))//Se obtiene el documento buscado, este DocEntry se guarda en la tabla de Pedido Detalle al momento de crear la orden de fabricacion por SDK; en ACS.
                        {

                            switch (oProduct.ProductionOrderStatus) // Segun el estado de la orden se hacen estos casos diferentes.
                            {
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposPlanned:
                                    oProduct.ProductionOrderStatus = SAPbobsCOM.BoProductionOrderStatusEnum.boposClosed;
                                    if (oProduct.Update() != 0)
                                    {
                                        MessageBox.Show(Ob.GetLastErrorDescription());/*La mayoria de los posibles errores ya estan cubiertos con el switch. Asi que si hay algun problema. este Log de la sdk le dirá
                                         Tambine pueda ser un transaccion Notification que la sdk respeta esos bloqueos. */
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Se cambio el estado a Cerrado.");
                                    }
                                    break;
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposReleased:
                                    if (MessageBox.Show("La orden se encuentra en estado liberado, seguro que deseas Cerrarla?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                                    {
                                        oProduct.ProductionOrderStatus = SAPbobsCOM.BoProductionOrderStatusEnum.boposClosed;
                                        if (oProduct.Update() != 0)
                                        {
                                            MessageBox.Show(Ob.GetLastErrorDescription());/*La mayoria de los posibles errores ya estan cubiertos con el switch. Asi que si hay algun problema. este Log de la sdk le dirá
                                         Tambine pueda ser un transaccion Notification que la sdk respeta esos bloqueos. */
                                            return;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Se cambio el estado a Cerrado.");
                                        }
                                    }
                                    else
                                    {
                                        return;
                                    }
                                    break;
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposClosed:
                                    MessageBox.Show("La orden ya fue cerrada anteriormente.");
                                    break;
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposCancelled:
                                    MessageBox.Show("La orden ya fue cancelada anteriormente.");
                                    break;
                                default:
                                    break;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Algo anda mal con la orden en SAP");//No ha llegado ha este punto, no sabria decirle a ciencia cierta por que se llego aqui. Tambien pueda ser que no encontro el documento.
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha creado una orden de fabricacion en SAP");
                    }
                }
                else
                {
                    foreach (DataRow row in dSProductos1.PedidoDetalleTilapia.Rows)
                    {
                        if (id == Convert.ToInt32(row["id"]))
                        {
                            Docentry = Convert.ToInt32(row["docentry"]);
                        }
                    }
                    if (Docentry != 0)
                    {
                        SAPbobsCOM.Company Ob = dp.Company(SAPuser, sappass);//Invoca el objeto de SAP y le asigna las credenciales impotadas en el formulario de acceso a SAP
                        SAPbobsCOM.ProductionOrders oProduct = (SAPbobsCOM.ProductionOrders)Ob.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders); // LLama al objeto de Orden de fabricacion de SAP
                        if (oProduct.GetByKey(Docentry))//Se obtiene el documento buscado, este DocEntry se guarda en la tabla de Pedido Detalle al momento de crear la orden de fabricacion por SDK; en ACS.
                        {

                            switch (oProduct.ProductionOrderStatus) // Segun el estado de la orden se hacen estos casos diferentes.
                            {
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposPlanned:
                                    oProduct.ProductionOrderStatus = SAPbobsCOM.BoProductionOrderStatusEnum.boposClosed;
                                    if (oProduct.Update() != 0)
                                    {
                                        MessageBox.Show(Ob.GetLastErrorDescription());/*La mayoria de los posibles errores ya estan cubiertos con el switch. Asi que si hay algun problema. este Log de la sdk le dirá
                                         Tambine pueda ser un transaccion Notification que la sdk respeta esos bloqueos. */
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Se cambio el estado a Cerrado.");
                                    }
                                    break;
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposReleased:
                                    if (MessageBox.Show("La orden se encuentra en estado liberado, seguro que deseas Cerrarla?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                                    {
                                        oProduct.ProductionOrderStatus = SAPbobsCOM.BoProductionOrderStatusEnum.boposClosed;
                                        if (oProduct.Update() != 0)
                                        {
                                            MessageBox.Show(Ob.GetLastErrorDescription());/*La mayoria de los posibles errores ya estan cubiertos con el switch. Asi que si hay algun problema. este Log de la sdk le dirá
                                         Tambine pueda ser un transaccion Notification que la sdk respeta esos bloqueos. */
                                            return;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Se cambio el estado a Cerrado.");
                                        }
                                    }
                                    else
                                    {
                                        return;
                                    }
                                    break;
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposClosed:
                                    MessageBox.Show("La orden ya fue cerrada anteriormente.");
                                    break;
                                case SAPbobsCOM.BoProductionOrderStatusEnum.boposCancelled:
                                    MessageBox.Show("La orden ya fue cancelada anteriormente.");
                                    break;
                                default:
                                    break;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Algo anda mal con la orden en SAP");//No ha llegado ha este punto, no sabria decirle a ciencia cierta por que se llego aqui. Tambien pueda ser que no encontro el documento.
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha creado una orden de fabricacion en SAP");
                    }
                }
            }
        }

        private void cmdBuscarFomula_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Buscar Formula Camaron
            frmBusarFormula frm = new frmBusarFormula();
            frm.radioGroup1.SelectedIndex = 1;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var gridView = (GridView)gridControl1.FocusedView;
                    var row = (DSProductos.PedidoDetalleRow)gridView.GetFocusedDataRow();

                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringACS);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_set_update_id_formula_pedido_detalle_v2", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idformula", frm.IdFormula);
                    cmd.Parameters.AddWithValue("@iddetalle_pedido", row.id);
                    cmd.Parameters.AddWithValue("@version", frm.VersionF.ToString());
                    cmd.ExecuteNonQuery();
                    row.formula_vigente = frm.VersionF.ToString();
                    row.formula_code = frm.codigoF;
                    e.Button.Tag = "Listo!";
                    dSProductos1.PedidoDetalle.AcceptChanges();
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }

        private void cmdBuscarFormula_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Buscar Formula Camaron
            frmBusarFormula frm = new frmBusarFormula();
            frm.radioGroup1.SelectedIndex = 0;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var gridView = (GridView)gridControl2.FocusedView;
                    var row = (DSProductos.PedidoDetalleTilapiaRow)gridView.GetFocusedDataRow();

                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringACS);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_set_update_id_formula_pedido_detalle_v2", con);
                    cmd.CommandType = CommandType.StoredProcedure;         
                    cmd.Parameters.AddWithValue("@idformula", frm.IdFormula);
                    cmd.Parameters.AddWithValue("@iddetalle_pedido", row.id);
                    cmd.Parameters.AddWithValue("@version", frm.VersionF.ToString());
                    cmd.ExecuteNonQuery();
                    row.formula_vigente = frm.VersionF.ToString();
                    row.formula_code = frm.codigoF;
                    e.Button.Tag = "Listo!";
                    dSProductos1.PedidoDetalleTilapia.AcceptChanges();
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }

        private void cmdOrdenPRD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Crear Orden camaron
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (DSProductos.PedidoDetalleRow)gridView.GetFocusedDataRow();

            //Crear orden de fabricacion individual
            PP_Nuevo_Plan_full_Pedido PNPFP = new PP_Nuevo_Plan_full_Pedido(ID_Pedido, row.id, 2, this.UsuarioLogeado, row.lote);
            PNPFP.ActiveUserCodeP = this.ActiveUserCode;
            PNPFP.ActiveUserNameP = this.ActiveUserName;
            PNPFP.ActiveUserTypeP = this.ActiveUserType;
            PNPFP.Id_Pedido1 = this.ID_Pedido;
            if (PNPFP.ShowDialog() == DialogResult.OK)
            {
                load_EditCamaron();
                load_EditTilapia();
            }
        }

        private void colCrearOrdenPRD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //crear orden Tilapia
            var gridView = (GridView)gridControl2.FocusedView;
            var row = (DSProductos.PedidoDetalleTilapiaRow)gridView.GetFocusedDataRow();

            //if (row.docentry == 0)
            //{
            //    CajaDialogo.Error("Para enviar a produccir este pedido, debe de generar primero la orden en SAP.");
            //    return;
            //}
            //Crear orden de fabricacion individual
            PP_Nuevo_Plan_full_Pedido PNPFP = new PP_Nuevo_Plan_full_Pedido(ID_Pedido, row.id,1, UsuarioLogeado, 0);
            PNPFP.ActiveUserCodeP = this.ActiveUserCode;
            PNPFP.ActiveUserNameP = this.ActiveUserName;
            PNPFP.ActiveUserTypeP = this.ActiveUserType;
            PNPFP.Id_Pedido1 = this.ID_Pedido;
            if (PNPFP.ShowDialog() == DialogResult.OK)
            {

                load_EditCamaron();
                load_EditTilapia();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var gridView = (GridView)gridControl1.FocusedView;
            //var row = (dsMensualidades.mensualidadesRow)gridView.GetFocusedDataRow();
            string name = sender.ToString();
            //Crear orden de fabricacion individual
            PP_Nuevo_Plan_full_Pedido PNPFP = new PP_Nuevo_Plan_full_Pedido(ID_Pedido,UsuarioLogeado,0);
            PNPFP.ActiveUserCodeP = this.ActiveUserCode;
            PNPFP.ActiveUserNameP = this.ActiveUserName;
            PNPFP.ActiveUserTypeP = this.ActiveUserType;
            PNPFP.Id_Pedido1 = this.ID_Pedido;
            PNPFP.Show();
        }

        private void timerConnectionSAP_Tick(object sender, EventArgs e)
        {
            if (SAPuser == string.Empty || sappass == "")//Valida las credenciales
            {
                //Transparente
                barButtonItem8.ItemAppearance.Normal.BackColor = Color.Transparent;
            }
            else
            {
                //verde
                barButtonItem8.ItemAppearance.Normal.BackColor = Color.FromArgb(192, 255, 192);
            }
        }

        private void btnRecargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            load_EditCamaron();
            load_EditTilapia();
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            var GridView = (GridView)gridControl1.FocusedView;
            var row = (DSProductos.PedidoDetalleRow)GridView.GetFocusedDataRow();

            if (row.lote != 0 )
            {
                if (gridView1.FocusedColumn.Name == "gridColumn25" || 
                    gridView1.FocusedColumn.Name == "colsapup" ||
                    gridView1.FocusedColumn.Name == "coladicional" ||
                    gridView1.FocusedColumn.Name == "colprioridad" ||
                    gridView1.FocusedColumn.Name == "colcliente" ||
                    gridView1.FocusedColumn.Name == "colDestino" ||
                    gridView1.FocusedColumn.Name == "colfecha_de_trabajo") 
                {

                }
                else
                {
                    e.Cancel = true;
                }
              
            }
        }

        private void gridView2_ShowingEditor(object sender, CancelEventArgs e)
        {
            var GridView = (GridView)gridControl2.FocusedView;
            var row = (DSProductos.PedidoDetalleTilapiaRow)GridView.GetFocusedDataRow();

            if (row.lote != 0)
            {
                if (gridView1.FocusedColumn.Name == "gridColumn25" ||
                    gridView1.FocusedColumn.Name == "colsapup" ||
                    gridView1.FocusedColumn.Name == "coladicional" ||
                    gridView1.FocusedColumn.Name == "colprioridad" ||
                    gridView1.FocusedColumn.Name == "colcliente" ||
                    gridView1.FocusedColumn.Name == "colDestino" ||
                    gridView1.FocusedColumn.Name == "gridColumn21") 
                {

                }
                else
                {
                    e.Cancel = true;
                }

            }
        }

        private void gridView1_ShowFilterPopupListBox(object sender, FilterPopupListBoxEventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CheckPermissions();
        }

        private void CheckPermissions()
        {
            SAPbobsCOM.Company _sboCompany = dp.Company("manager", "Aq4x_3Fj2#");
            SAPbobsCOM.SBObob oSBObob = (SAPbobsCOM.SBObob)_sboCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge);

            try
            {
                SAPbobsCOM.Recordset oRecordSet = oSBObob.GetSystemPermission(_sboCompany.UserName.ToString(), "222");
                //oSBObob.get
                int count = oRecordSet.Fields.Count;
                for(int i=0; i<count; i++)
                {
                    Console.WriteLine(oRecordSet.Fields.Item(i).Value.ToString());
                    CajaDialogo.Information(oRecordSet.Fields.Item(i).Value.ToString());
                }
                CajaDialogo.Information(oRecordSet.Fields.Item(0).Value.ToString());
                //_sboApp.MessageBox(oRecordSet.Fields.Item(0).Value.ToString(), 1, "Ok", "", "");
            }
            catch (Exception ex)
            {
                CajaDialogo.Information(ex.Message);//, SAPbouiCOM.BoMessageTime.bmt_Medium, true);
                //_sboApp.SetStatusBarMessage(ex.Message, SAPbouiCOM.BoMessageTime.bmt_Medium, true);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(oSBObob);
                oSBObob = null;
                GC.Collect();
            }
        }

        private void btn_SAP_Click(object sender, EventArgs e)
        {
            #region CREACION DE ORDEN DE FABRICACION EN SAP
            var GridView = (GridView)gridControl1.FocusedView;
            var row = (DSProductos.PedidoDetalleRow)GridView.GetFocusedDataRow();

            if (row.lote == 0)
            {
                CajaDialogo.Error("Debe registrar primero la orden de produccion para subir la orden de fabricacion a SAP.");
                return;
            }
            if (SAPuser == string.Empty || sappass == "")//Valida las credenciales
            {
                MessageBox.Show("Debe iniciar sesion en SAP para crear la lista de materiales.");
                return;
            }
            else
            {
                try
                {
                    
                    if ( row.docentry == 0) //Valida si ya existe en SAP. Si tiene algun numero es que ya se creo una orden de Fabricacion.
                    {
                        SAPbobsCOM.Company Ob = dp.Company(SAPuser, sappass);//Crea el objeto company que vuelve a validar las credenciales.
                        SAPbobsCOM.ProductionOrders oProduct = (SAPbobsCOM.ProductionOrders)Ob.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders);//Se obtiene el objeto de SAP.
                        oProduct.ItemNo = row.code_sap;//Se agisna el codigo de SAP.
                        oProduct.Warehouse = "BG007";//El almacen al cual siempre va ir. Se puede dejar dinamico haciendo una minicolsulta a una tabla de configuracion. Pero no va cambiar nunca esto.
                        oProduct.UserFields.Fields.Item("U_Formula").Value = row.formula_code; // la formula, y la vigencia. que se guardan en campos definidos por el usuario. Asi se llaman esos campos.
                        oProduct.UserFields.Fields.Item("U_Version").Value = row.formula_vigente;
                        oProduct.UserFields.Fields.Item("U_U_cliente").Value = row.cliente;
                        oProduct.UserFields.Fields.Item("U_U_lote").Value = row.lote;
                        oProduct.UserFields.Fields.Item("U_U_Registro").Value = row.Registro;
                        oProduct.UserFields.Fields.Item("U_U_destino").Value = row.Destino;
                        oProduct.StartDate = row.fecha_ini;//Fecha de programacion segun la dataa ingresada.
                        oProduct.PostingDate = DateTime.Now;//la fecha de ingreso.
                        oProduct.DueDate = row.fecha_fin;//fecha de finalizacion, este hay que hacerle algun cambio sobre su manipulacion
                        oProduct.Priority = 100;//row.prioridad;//la prioridad de la orden
                        oProduct.PlannedQuantity = Convert.ToDouble(row.batch) * 2500; //las toneladas multiplicadas por 2500, procedimiento similar al que se realiza en SAP.
                        
                        //Se podria poner desde aqui el estado liberado a la orden. pero por alguna razon, muy de SAP no permite crear la orden de fabricaion en estado liberado.
                        if (oProduct.Add() != 0)//Devuelve 0 si no se crea el documento, si hay algun error. 
                        {
                            MessageBox.Show(Ob.GetLastErrorDescription());
                            return;
                        }
                        else
                        { 
                            int save = Convert.ToInt32(Ob.GetNewObjectKey());
                            row.docentry = Convert.ToInt32(Ob.GetNewObjectKey());//Guardamos en la tabla pedido detalle el Docentry Generado.
                            string Query;
                            Query = @"UPDATE [dbo].[PT_Pedido_Detalle]
                                       SET [DocEntry] = " + save+ @"
                                     WHERE id = " + row.id;
                            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                            cn.Open();
                            SqlCommand cmd = new SqlCommand(Query, cn);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Orden de fabricacion creada..");
                            foreach (DataRow rows in dSProductos1.PedidoDetalle.Rows)
                            {
                                if (row.id == Convert.ToInt32(row["id"]))
                                {
                                   row["id"] = save;
                                }//en la vista tambien debe guardarse. Por si se necesita cambiar el estado de la orden
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe una orden de Fabricacion para este producto.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
               
            }
            #endregion
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //PP_Nuevo_Plan_full_Pedido PNPFP = new PP_Nuevo_Plan_full_Pedido(ID_Pedido);
            PP_Nuevo_Plan_full_PedidoAquaForecas PNPFP = new PP_Nuevo_Plan_full_PedidoAquaForecas(ID_Pedido);
            PNPFP.ActiveUserCodeP = this.ActiveUserCode;
            PNPFP.ActiveUserNameP = this.ActiveUserName;
            PNPFP.ActiveUserTypeP = this.ActiveUserType;
            PNPFP.Id_Pedido1 = this.ID_Pedido;
            PNPFP.Show();

        }

        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {
            var GridView = (GridView)gridControl1.FocusedView;
            var row = (DSProductos.PedidoDetalleRow)GridView.GetFocusedDataRow();
            Codigo = Convert.ToString(row.Codigo);
            Llenado_Zarandas LLZ = new Llenado_Zarandas(Codigo);
            if (LLZ.ShowDialog() == DialogResult.OK)
            { 
                try
                {
                
                string Queryupdate;
                    dp = new DataOperations();
                Queryupdate = @"UPDATE  [dbo].[PT_Pedido_Detalle]
                                    SET [detalleZar] = (Select ACS.dbo.Llenado_Zarandas('"+Codigo+"')) " +
                                    " WHERE cod_Produc = '" + Codigo + "' and id_pedido = " + ID_Pedido;
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Queryupdate, cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();


                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }
                load_EditCamaron();
             
                //load_Data();

            }

        }

        void load_Data()//Se cambio por un procedimiento almacenado en SQL SERVER
        {
            dp = new DataOperations();
            string Query;
            Query = @"		SELECT
							 B.id as id
	                        ,A.[Codigo] as Codigo
	                        ,A.[Descripcion] as Descripcion
	                        ,B.[id_pedido] as id_pedido
	                        ,coalesce (B.[Peso_Pedido] , 0) as Peso_pedido
	                        ,coalesce (B.[Sacos] , 0) as  Sacos
	                        ,coalesce (B.[batch] , 0) as batch
	                        ,coalesce (B.[Prioridad] , 0) as prioridad
	                        ,coalesce (B.[formula_vigente] , ' ') as formula_vigente
	                        ,coalesce (A.[formula_code], ' ') as formula_code
	                        ,C.fecha_ini as fecha_ini
	                        ,C.fecha_fin as fecha_fin
	                        ,coalesce ((SELECT .dbo.PT_Products_Process.description
		                        From .dbo.PT_Products_Process
		                        Where A.id_proceso = ACS.dbo.PT_Products_Process.id), ' ') as id_proceso
	                        ,coalesce (A.[Registro] , ' ') as Registro
	                        ,coalesce  (B.[Destino] , ' ') as Destino
	                        ,coalesce ((SELECT .dbo.PT_Products_Bags.net
			                        From .dbo.PT_Products_Bags
			                        Where a.id_bag = ACS.dbo.PT_Products_Bags.id), 0) as id_bag
	                        ,coalesce ((SELECT .dbo.PT_Products_Portafolio.description
			                        From .dbo.PT_Products_Portafolio
			                        Where a.id_portafolio = ACS.dbo.PT_Products_Portafolio.id), ' ') as [id_portafolio]
	                        ,(Case When A.Especie = 1 Then
			                        'Tilapia'
		                        else
			                        'Camaron'
		                        end) as Especie
                            ,A.Especie as spicie
                            ,coalesce ((Select ACS.dbo.Llenado_Zarandas(Codigo)), ' ')  as zardetalle
                            ,coalesce (B.fecha_de_trabajo, '01/01/1991 12:00:00 a.m.') as fecha_de_trabajo
                            ,coalesce (A.[tamaño], ' ') as tamanio
                            ,coalesce ((Select ACS.dbo.PT_Products_Origen.descripcion 
				                      from ACS.dbo.PT_Products_Origen
				                      Where A.id_origen = ACS.Dbo.PT_Products_Origen.id), ' ') as id_origen
                            ,coalesce (A.[diamentro], ' ') as size

                        From 
	                        .dbo.PT_Productos A join 
	                        .dbo.PT_Pedido_Detalle B on
	                        A.Codigo = B.cod_Produc join
	                        .dbo.PT_Pedido C on
	                        B.id_pedido = C.id_Pedido
	                        where C.id_Pedido = " + ID_Pedido+
                         " and c.enable = 1 order by spicie desc, prioridad";
                         
            SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dSProductos1.PedidoDetalle.Clear();
            da.Fill(dSProductos1.PedidoDetalle);
            con.Close();
        }


        public void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_load_presentacion_pt]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dSProductos1.presentaciones.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dSProductos1.presentaciones);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }






    }
}
