using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACS.Classes;
using LOSA.Clases;
using System.Data;
using LOSA.Presupuesto;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Data.OleDb;
//using LOSA.Utileria;
using System.Threading;

namespace LOSA.Presupuesto
{
    public partial class frmPresupuestoHome : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado = new UserLogin();
        int IdPresupuesto;
        int IdDetalle;
        LOSA.Clases.Presupuesto presu = new Clases.Presupuesto();
      

        public frmPresupuestoHome(UserLogin user)
        {
            InitializeComponent();
            UsuarioLogeado = user;
            //Permisos - Todavia no me queda claro!

            if (UsuarioLogeado.ValidarNivelPermisos(103))
            {
                btnAddHeader.Visible = true;
                //btnAddDetalle.Visible = true;
                btnAddDetalleAuto.Visible = true;
            }
            else
            {
                btnAddHeader.Visible = false;
                //btnAddDetalle.Visible = false;
                btnAddDetalleAuto.Visible = false;
            }
            CargarPresupuestos();
        }

        private void CargarPresupuestos()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_presupuesto_all", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPresupuesto1.presupuestos_h.Clear();
                adat.Fill(dsPresupuesto1.presupuestos_h);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarPresupuestosDetalle()
        {
            bool Admin = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                    Admin = true;
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_presupuesto_detalle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_presupuesto",IdPresupuesto);
                cmd.Parameters.AddWithValue("@user_id",UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@IsAdmin", Admin);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPresupuesto1.presupuesto_detalle.Clear();
                adat.Fill(dsPresupuesto1.presupuesto_detalle);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void btnAddHeader_Click(object sender, EventArgs e)
        {
            frmPresupuestoHomeOP frm = new frmPresupuestoHomeOP(frmPresupuestoHomeOP.Operacion.Nuevo, UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarPresupuestos();
            }
        }

        private void btnCloseHeader_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reposAddPresupuesto_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            //DETALLE PRESUPUESTO POR DEPARTAMENTO Y PRESUPUESTO ID
            var gridview = (GridView)gcHeader.FocusedView;
            var row = (dsPresupuesto.presupuestos_hRow)gridview.GetFocusedDataRow();

            IdPresupuesto = row.id;
            comboAnio.Text = row.anio.ToString();
            txtDescripcionDetalle.Text = row.descripcion;
            navigationFrame1.SelectNextPage();
            CargarPresupuestosDetalle();

        }

        private void btnDetalleAtras_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectPrevPage();
            CargarPresupuestos();
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //DETALLE con montos POR Departamento
            var gridview = (GridView)gcDetalle.FocusedView;
            var row = (dsPresupuesto.presupuesto_detalleRow)gridview.GetFocusedDataRow();
            IdDetalle = row.id_detalle;
            txtDepartamento.Text = row.departamento;
            navigationFrame1.SelectNextPage();

            CargarPresupuestosDetalleLinea(IdDetalle);

        }

        private void CargarPresupuestosDetalleLinea(int idDetalle)
        {
            try
            {
                string query = @"sp_presupuesto_get_linea_detalle_by_detalle";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@id_detalle", idDetalle);
                dsPresupuesto1.presupuesto_detalle_lineas.Clear();
                adat.Fill(dsPresupuesto1.presupuesto_detalle_lineas);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAddDetalle_Click(object sender, EventArgs e)
        {
            //Esto lo Generaria Manual
            frmPresupuestoDetalleOP frm = new frmPresupuestoDetalleOP(UsuarioLogeado, IdPresupuesto);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarPresupuestosDetalle();
            }
        }

        private void btnAddDetalleAuto_Click(object sender, EventArgs e)
        {
            //Esto deberia generar el Detalle de cada departamento segun configuracion de [FIN_presupuesto_ruta_usuarios]
            //Todavia no se si valdra la pena.

            List<Int32> ListDepartament = new List<Int32>();
            foreach (dsPresupuesto.presupuesto_detalleRow item in dsPresupuesto1.presupuesto_detalle)
            {
                ListDepartament.Add(Convert.ToInt32(item.id_departamento));
            }

            frmGeneracionDetallePresupuesto frm = new frmGeneracionDetallePresupuesto(UsuarioLogeado, IdPresupuesto, ListDepartament); ;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarPresupuestosDetalle();
            }
     
        }

        private void btnDetalle_lineasBack_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectPrevPage();

            CargarPresupuestosDetalle();
        }

        private void btnDetalleLineasCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportPlantilla_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excelPackage = new ExcelPackage();
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Plantilla");
            worksheet.Cells[1, 1].Value = "Descripcion del Presupuesto";
            worksheet.Cells[1, 2].Value = "Monto ($)";
     
            using (var range = worksheet.Cells[1,1,1,2])
            {
                range.Style.Font.Bold = true;
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
            }

            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;
            dialog.FileName = "Plantilla Presupuesto";
            //dialog.

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                excelPackage.SaveAs(dialog.FileName);
            }

            //string filePath = @"C:\ruta\plantilla.xlsx";
            //FileInfo fi = new FileInfo(filePath);
            //excelPackage.SaveAs(fi);
        }

        private void btnImporPlantilla_Click(object sender, EventArgs e)
        {
            string file_name = string.Empty;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel File(.xlsx)| *.xlsx";
            //dialog.InitialDirectory = @"C:\";
            dialog.Title = "Seleccione el archivo importado anteriormente";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                file_name = @dialog.FileName.ToString();
                string Connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file_name + "; Extended Properties=\"Excel 12.0 Xml; HDR = YES\"";
                OleDbConnection con = new OleDbConnection(Connection);
                //OleDbDataAdapter myCommand = new OleDbDataAdapter("select * from [Sheet$]", con);
                OleDbDataAdapter myCommand = new OleDbDataAdapter("select * from [Plantilla$]", con);
                DataTable table = new DataTable("Tabla");
                DataColumn column1 = new DataColumn("Descripcion del Presupuesto", typeof(string));
                DataColumn column2 = new DataColumn("Monto ($)", typeof(string));

                table.Columns.Add(column1);
                table.Columns.Add(column2);

                //splashScreenManager1.ShowWaitForm();
                try
                {
                    myCommand.Fill(table);
                    foreach (DataRow item in table.Rows)
                    {
                        dsPresupuesto.presupuesto_detalle_lineasRow row1 = dsPresupuesto1.presupuesto_detalle_lineas.Newpresupuesto_detalle_lineasRow();
                        row1.id_detalle_linea = 0;
                        row1.id_detalle = 0;
                        row1.descripcion_linea_presupuesto = item.ItemArray[0].ToString();
                        row1.monto = Convert.ToDecimal(item.ItemArray[1]);
                        row1.moneda = "$";

                        dsPresupuesto1.presupuesto_detalle_lineas.Addpresupuesto_detalle_lineasRow(row1);
                        dsPresupuesto1.AcceptChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //splashScreenManager1.CloseWaitForm();
                
            }
        }

        private void btnSaveDetallleLinea_Click(object sender, EventArgs e)
        {

            foreach (dsPresupuesto.presupuesto_detalle_lineasRow item in dsPresupuesto1.presupuesto_detalle_lineas.Rows)
            {
                if (item.id_detalle_linea == 0)
                {
                    if (string.IsNullOrEmpty(item.descripcion_linea_presupuesto))
                    {
                        CajaDialogo.Error("Debe existir una descripcion en la linea!");
                        return;
                    }
                    if (item.monto <= 0)
                    {
                        CajaDialogo.Error("El Monto no debe ser <= 0");
                        return;
                    }
                }
            }

            //SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
            //conn.Open();
            //SqlCommand cmd;
            SqlTransaction transaction = null;

            SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
            bool Guardar = false;

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction("Transaction Order");
                SqlCommand cmd = conn.CreateCommand();

                foreach (dsPresupuesto.presupuesto_detalle_lineasRow item in dsPresupuesto1.presupuesto_detalle_lineas.Rows)
                {
                    if (item.id_detalle_linea == 0)
                    {
                        //presu.InsertarDetalleLineaPresupuesto(IdDetalle, item.descripcion_linea_presupuesto, item.monto, UsuarioLogeado.Id);
                        cmd.CommandText = "sp_presupuesto_insert_detalle_lineas";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_d", IdDetalle);
                        cmd.Parameters.AddWithValue("@descripcion", item.descripcion_linea_presupuesto);
                        cmd.Parameters.AddWithValue("@monto", item.monto);
                        cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                        cmd.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
                Guardar = true;
            }
            catch (Exception ec)
            {
                transaction.Rollback();
                CajaDialogo.Error(ec.Message);
                Guardar = false;
            }

            if (Guardar)
            {
                CajaDialogo.Information("Presupuesto Cargado con Exito!");
                CargarPresupuestosDetalleLinea(IdDetalle);
            }
        }

        private void btnAgregarLineaPresupuesto_Click(object sender, EventArgs e)
        {
            frmPresupuestoDetalleLineaOP frm = new frmPresupuestoDetalleLineaOP(UsuarioLogeado, IdPresupuesto, IdDetalle);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarPresupuestosDetalleLinea(IdDetalle);
            }
        }

        private void reposEliminarLinea_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gcDetalleLinea.FocusedView;
            var row = (dsPresupuesto.presupuesto_detalle_lineasRow)gridview.GetFocusedDataRow();

            //Eliminar Linea de Presupuesto por Departamento
            //Validar Si ya se uso en Ordenes de Compra!

            

            try
            {
                if (row.id_detalle_linea > 0)
                {
                    DialogResult r = CajaDialogo.Pregunta("Desea eliminar este Linea de Presupuesto?");
                    if (r != System.Windows.Forms.DialogResult.Yes)
                        return;

                    bool Guardar = false;
                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_presupuesto_delete_detalle", conn);//Aqui 
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_detalle_linea", row.id_detalle_linea);
                        cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                        Guardar = Convert.ToBoolean(cmd.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                    if (Guardar)
                    {
                        CajaDialogo.Information("Registro de Presupuesto Eliminado!");
                        CargarPresupuestosDetalleLinea(IdDetalle);
                    }
                    else
                    {
                        CajaDialogo.Error("No se puede eliminar esta Linea de Presupuesto!\nSe encuentra ligada a una Orden de Compra");
                    }
                }
                else
                {
                    try
                    {
                        gvDetalleLinea.DeleteRow(gvDetalleLinea.FocusedRowHandle);
                        dsPresupuesto1.AcceptChanges();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void reposEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //creo que por ahora no lo ocupamos!
        }
    }
}