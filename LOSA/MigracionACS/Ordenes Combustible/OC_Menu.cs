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
using System.Data.SqlClient;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using LOSA.MigracionACS.Ordenes_Combustible;
using System.Threading;
using DevExpress.XtraPrinting;
using LOSA.Clases;

namespace LOSA.MigracionACS.Ordenes_Combustible
{
    public partial class OC_Menu : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        string operacion = "Impresion";
        public OC_Menu(UserLogin pUserC)
        {
            InitializeComponent();
            UsuarioLogeado = pUserC;
            LoadOrdenes();
        }

        private void cmdPerfiles_Click(object sender, EventArgs e)
        {
            OC_Perfiles frm = new OC_Perfiles(UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadOrdenes();
            }
        }

        private void LoadOrdenes()
        {
            try
            {
                string sql = @"SELECT [id]
                                  ,(Select B.name 
			                            FROM [FuelOrders_Perfiles]B 
				                            WHERE B.id = A.id_perfil) as [name]	
                                  ,[num_order]
                                  ,[status]
                                  ,(Select C.nombre
			                            FROM [conf_usuarios]C
				                            WHERE C.id = A.id_usercreate) as [usercreate]
                                  ,[date]
                                  ,(Select D.description
			                            FROM [FuelOrders_Fuel]D
				                            WHERE D.id = A.fuel_id) as [fuel]
                                  ,[fuel_id]
                                  ,[liters]
                                  ,[printState]
                                  ,[bit_tanquelleno]
                              FROM [dbo].[FuelOrders_Issued]A
                                        where A.[status] = 1 and A.[printState] = 0
                                         ORDER BY [num_order] DESC";
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsOrdenesCombustible1.cargarordenes.Clear();
                adat.Fill(dsOrdenesCombustible1.cargarordenes);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdGenerar_Click(object sender, EventArgs e)
        {
            //AQUI IRA LA PROGRAMACION PARA GENERAR ORDENES 
            OC_PreVisualizacionesOrdenes frm = new OC_PreVisualizacionesOrdenes(UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadOrdenes();
            }

            //DialogResult r = CajaDialogo.Pregunta("Desea generar el lote de ordenes pre-configurado?");
            //if (r != System.Windows.Forms.DialogResult.Yes)
            //    return;


            //try
            //{
            //    DataOperations dp = new DataOperations();
            //    SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
            //    con.Open();

            //    SqlCommand cmd = new SqlCommand("FuelOrderCreateOrder", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("id_usercreate", UsuarioLogeado.UserId);
            //    cmd.ExecuteNonQuery();

            //    CajaDialogo.Information("Ordenes creadas exitosamente!");
            //    con.Close();

            //    LoadOrdenes();

            //    //this.DialogResult = DialogResult.OK;
            //    //this.Close();
            //}
            //catch (Exception ec)
            //{
            //    CajaDialogo.Error(ec.Message);
            //}
        }

        private void cmdReimpresion_Click(object sender, EventArgs e)
        {
            OC_ReImprimir frm = new OC_ReImprimir();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadOrdenes();
            }
        }

        private void repositoryItemPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl2.FocusedView;
            var row = (dsOrdenesCombustible.cargarordenesRow)gridView.GetFocusedDataRow();

            try
            {
                string sql = @"SELECT	 aa.[id]
		                                ,[num_order]
		                                ,(Select bb.name 
			                                        FROM [FuelOrders_Perfiles]bb 
				                                        WHERE bb.id = aa.id_perfil) as [name]	
		                                ,[car]
		                                ,[license_plate]
		                                ,[date]
		                                ,[fuel_id]
		                                ,cc.description
		                                ,[liters]
		                                ,[printState]
		                                ,[bit_tanquelleno]
                                        ,aa.[obs]
	                                FROM [dbo].[FuelOrders_Issued]aa
	                                join [FuelOrders_Fuel]cc 
		                                on cc.id = aa.fuel_id
		                                where aa.status = 1 and aa.id =" + row.id.ToString();
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsOrdenesCombustible1.print_orders.Clear();
                adat.Fill(dsOrdenesCombustible1.print_orders);

                int id_fuel = row.fuel_id;
                decimal liters = row.liters;
                DateTime fecha = row.date;

                //Rpts_OCombustible report = new Rpts_OCombustible(id_fuel, liters, fecha) { DataSource = dsOrdenesCombustible, DataMember = "print_orders", ShowPrintMarginsWarning = false };
                //report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                //ReportPrintTool reportPrint = new ReportPrintTool(report);
                //reportPrint.ShowPreviewDialog();
                Rpts_OCombustible report = new Rpts_OCombustible(id_fuel, liters, fecha) { DataSource = dsOrdenesCombustible1, DataMember = "print_orders", ShowPrintMarginsWarning = false };

                using (ReportPrintTool printTool = new ReportPrintTool(report))
                {
                    printTool.Print();
                    //printTool.ShowPreviewDialog();
                    //printTool.PrinterSettings.
                }

               
                string sql2 = @"UPDATE [dbo].[FuelOrders_Issued]
                                   SET [printState] = 1
                                       WHERE id =" + row.id;

                try
                {
                    SqlConnection conn2 = new SqlConnection(dp.ConnectionStringCostos);
                    conn2.Open();
                    SqlCommand cmd2 = new SqlCommand(sql2, conn2);
                    cmd2.ExecuteNonQuery();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }

                LoadOrdenes();

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            //Indica el numero de copias de la boleta que seran impresas
            e.PrintDocument.PrinterSettings.Copies = 1;
        }

        private void cmdPrintAll_Click(object sender, EventArgs e)
        {
            if (gridView2.DataRowCount == 0)
            {
                CajaDialogo.Error("No se han generado ordenes!");
                return;
            }

            foreach (DataRow row in dsOrdenesCombustible1.cargarordenes.Rows)
            {
                try
                {
                    string sql = @"SELECT	 aa.[id]
		                                ,[num_order]
		                                ,(Select bb.name 
			                                        FROM [FuelOrders_Perfiles]bb 
				                                        WHERE bb.id = aa.id_perfil) as [name]	
		                                ,[car]
		                                ,[license_plate]
		                                ,[date]
		                                ,[fuel_id]
		                                ,cc.description
		                                ,[liters]
		                                ,[printState]
		                                ,[bit_tanquelleno]
                                        ,[obs]
	                                FROM [dbo].[FuelOrders_Issued]aa
	                                join [FuelOrders_Fuel]cc 
		                                on cc.id = aa.fuel_id
		                                where aa.status = 1 and aa.id =" + row["id"];
                    DataOperations dp = new DataOperations();
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    dsOrdenesCombustible1.print_orders.Clear();
                    adat.Fill(dsOrdenesCombustible1.print_orders);

                    int id_fuel = Convert.ToInt32(row["fuel_id"].ToString());
                    decimal liters = Convert.ToDecimal(row["liters"]);
                    DateTime fecha = Convert.ToDateTime(row["date"]);

                    Rpts_OCombustible rptcombustible = new Rpts_OCombustible(id_fuel, liters, fecha) { DataSource = dsOrdenesCombustible1, DataMember = "print_orders", ShowPrintMarginsWarning = false }; ;
                    //rptcombustible.ShowPrintMarginsWarning = false;
                    //rptcombustible.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                    //rptcombustible.Print();

                    using (ReportPrintTool printTool = new ReportPrintTool(rptcombustible))
                    {
                        printTool.Print();
                    }
                    Thread.Sleep(400);

                    string sql2 = @"UPDATE [dbo].[FuelOrders_Issued]
                                   SET [printState] = 1
                                       WHERE id =" + row["id"];

                    SqlConnection conn2 = new SqlConnection(dp.ConnectionStringCostos);
                    conn2.Open();
                    SqlCommand cmd2 = new SqlCommand(sql2, conn2);
                    cmd2.ExecuteNonQuery();
                    
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }

            LoadOrdenes();
        }
    }
}