using DevExpress.XtraEditors;
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
using LOSA.Clases;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using static LOSA.Logistica.frmNuevoRecuento;
using LOSA.Logistica;

namespace LOSA.RecuentoInventario
{
    public partial class frmDetalleRecuento : DevExpress.XtraEditors.XtraForm
    {
        //Recuento NuevoRecuento;
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        DataTable MpList;
        decimal NuevaCantidad = 0;
        int id_year;
        int id_mes;
        DateTime fecha_rec;
        int Id_header;
        bool contabilizado;
        int id_detalle_recuento;

        public frmDetalleRecuento(DataTable pdata, UserLogin puserLogin,int pidyear,int pidmes, DateTime pfecha_recuento)
        {
            InitializeComponent();
            UsuarioLogeado = puserLogin;
            cmdSelecLote.Visible = false;
            btnConfirmar.Visible = true;
            //pidyear = Convert.ToInt32(grd_years.EditValue);
            //NuevoRecuento = new Recuento();
            id_year = pidyear;
            id_mes = pidmes;
            MpList = pdata;
            get_meses_by_year();
            get_bodegas();
            get_years();
            grd_mps.DataSource = pdata;
            fecha_rec = pfecha_recuento;

            grd_years.EditValue = id_year;
            grd_meses_disponibles.EditValue = id_mes;
            //mes = Convert.ToInt32(grd_meses_disponibles.EditValue);
        }

        public frmDetalleRecuento(UserLogin puserLogin, int pid_recuento, bool pcontabilizado)
        {
            InitializeComponent();
            dsCierreMes1.Recuento_mp.Clear();
            cmdSelecLote.Visible = true;
            btnConfirmar.Visible = false;
            UsuarioLogeado = puserLogin;
            Id_header = pid_recuento;
            contabilizado = pcontabilizado;
            load_data_contabilizar();
            get_meses_by_year();
            get_bodegas();
            get_years();
            
        }

        public void load_data_contabilizar()
        {
            string query = @"sp_get_inventario_final_detalle_contabilizar";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@id_header", Id_header);
                dsCierreMes1.recuentos_d.Clear();
                da.Fill(dsCierreMes1.Recuento_mp);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void get_meses_by_year()
        {
            string query = @"sp_get_meses_disponible_por_ejercicio";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@year", id_year);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCierreMes1.meses.Clear();
                da.Fill(dsCierreMes1.meses);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void get_years()
        {
            string query = @"sp_obtener_años_disponibles";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCierreMes1.years.Clear();
                da.Fill(dsCierreMes1.years);
                cn.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void get_bodegas()
        {
            string query = @"sp_get_bodegas_id_descripcion";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsCierreMes1.bodegas.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCierreMes1.bodegas);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            //DialogResult r = CajaDialogo.Pregunta("Desea Guardar los cambios?Se realizara un ajuste de cada Registro en Kardex.");
            //if (r == DialogResult.Yes)


            //if (string.IsNullOrEmpty(grd_years.Text))
            //{
            //    CajaDialogo.Error("Debe seleccionar el año!");
            //    return;
            //}
            //if (string.IsNullOrEmpty(grd_meses_disponibles.Text))
            //{
            //    CajaDialogo.Error("Debe seleccionar el mes!");
            //    return;
            //}
            if (string.IsNullOrEmpty(txtComentario.Text))
            {
                CajaDialogo.Error("Debe agregar un comentario de referencia");
                return;
            }


            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA))
            {

                //for (int i = 0; i < grdv_mps.SelectedRowsCount; i++)
                //{
                //    DataRow row = grdv_mps.GetDataRow(i);
                //    
                //}

                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                SqlTransaction transaction;

                //Start a local transaction.
                 transaction = connection.BeginTransaction("SampleTransaction");

                //Must assign both transaction object and connection
                //to Command object for a pending local transaction


                command.Connection = connection;
                command.Transaction = transaction;

                try
                {

                    command.CommandText = "sp_insert_encabezado_recuento_final_header";
                    command.Parameters.AddWithValue("@user_created", UsuarioLogeado.Id);
                    command.Parameters.AddWithValue("@mes", grd_meses_disponibles.EditValue);
                    command.Parameters.AddWithValue("@year", grd_years.EditValue);
                    command.Parameters.AddWithValue("@fecha_conteo", fecha_rec);
                    command.Parameters.AddWithValue("@comentario", txtComentario.Text);
                    int id_header_recuento = Convert.ToInt32(command.ExecuteScalar());


                    ////Insert en Detalle de Recuento Final MATERIA PRIMA
                    for (int i = 0; i < grdv_mps.DataRowCount; i++)
                    {
                        DataRow row = grdv_mps.GetDataRow(i);
                        
                        command.Parameters.Clear();
                        command.CommandText = "sp_insert_inventario_final_detalle";
                        command.Parameters.AddWithValue("@id_header", id_header_recuento);
                        command.Parameters.AddWithValue("@id_mp", Convert.ToInt32(row["id_mp"]));
                        command.Parameters.AddWithValue("@id_bodega", Convert.ToInt32(row["id_bodega"]));
                        //command.Parameters.AddWithValue("@lote", Convert.ToString(row["lote"]));
                        //command.Parameters.AddWithValue("@id_lote_alosy",);
                        command.Parameters.AddWithValue("@peso", Convert.ToDecimal(row["peso"])); //nueva existencia
                        command.Parameters.AddWithValue("@diferencia_peso", Convert.ToDecimal(row["diferencia"]));
                        command.Parameters.AddWithValue("@existencia_aprox", Convert.ToDecimal(row["ExistenciaAprox"]));
                        command.Parameters.AddWithValue("@existencia_fisica", Convert.ToDecimal(row["peso"]));
                        command.Parameters.AddWithValue("@tipo_producto", 1); //Es Tipo de Producto: Materia Prima
                        command.ExecuteNonQuery();
                    }
                    

                    ////Insert en Detalle de Recuento Final PRODUCTO TERMINADO
                    //for (int i = 0; i < grdv_mps.SelectedRowsCount; i++)
                    //{
                    //    //DataRow row = grdv_mps.GetDataRow(i);
                    //    //Insert en Detalle de Recuento Final
                    //    command.Parameters.Clear();
                    //    command.CommandText = "sp_insert_inventario_final_detalle";
                    //    command.Parameters.AddWithValue("@id_header", id_header_recuento);
                    //    command.Parameters.AddWithValue("@id_mp", Convert.ToInt32(row["id_mp"]));
                    //    command.Parameters.AddWithValue("@id_bodega", Convert.ToInt32(row["id_bodega"]));
                    //    //command.Parameters.AddWithValue("@lote", Convert.ToString(row["lote"]));
                    //    //command.Parameters.AddWithValue("@id_lote_alosy",);
                    //    command.Parameters.AddWithValue("@peso", Convert.ToDecimal(row["peso"])); //nueva existencia
                    //    command.Parameters.AddWithValue("@diferencia_peso", Convert.ToDecimal(row["diferencia"]));
                    //    command.Parameters.AddWithValue("@existencia_aprox", Convert.ToDecimal(row["ExistenciaAprox"]));
                    //    command.Parameters.AddWithValue("@existencia_fisica", Convert.ToDecimal(row["peso"]));
                    //    command.Parameters.AddWithValue("@tipo_producto", 2); //Es Tipo de Producto: Producto Terminado
                    //    command.ExecuteNonQuery();
                    //}

                    ////Insert en Detalle de Recuento Final REPROCESO

                    transaction.Commit();
                    connection.Close();

                    CajaDialogo.Information("Recuento Guardado con Exito!");
                    this.DialogResult = this.DialogResult;
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void cmdSelecLote_Click(object sender, EventArgs e)
        {
            //using (SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA))
            //{

            //    //for (int i = 0; i < grdv_mps.SelectedRowsCount; i++)
            //    //{
            //    //    DataRow row = grdv_mps.GetDataRow(i);

            //    //    
            //    //}

            //    dsCierreMes.Recuento_mpDataTable tableOps = new dsCierreMes.Recuento_mpDataTable();

            //    //foreach (dsCierreMes.recuentos_dRow row1 in dsCierreMes1.recuentos_d.Rows)
            //    //{
            //    //    DataRow row2 = grdv_mps.GetDataRow(i);
            //    //}

            //    for (int i = 0; i < grdv_mps.SelectedRowsCount; i++)
            //    {

            //        DataRow row2 = grdv_mps.GetDataRow(i);

            //        if (Convert.ToDecimal(row2["diferencia"]) > 0 || Convert.ToDecimal(row2["diferencia"]) < 0)
            //        {
            //            dsCierreMes.Recuento_mpRow row1 = tableOps.NewRecuento_mpRow();
            //            row1.id_mp = Convert.ToInt32(row2["id_mp"]);
            //            row1.descripcion = Convert.ToString(row2["descripcion"]);
            //            row1.peso = Convert.ToDecimal(row2["peso"]);
            //            row1.id_bodega = Convert.ToInt32(row2["id_bodega"]);
            //            row1.diferencia = Convert.ToDecimal(row2["diferencia"]);
            //            row1.ExistenciaAprox = Convert.ToDecimal(row2["ExistenciaAprox"]);
            //            row1.code_sap = Convert.ToString(row2["code_sap"]);
            //            //row1.lote = row.lote;
            //            row1.toma_fisica = Convert.ToDecimal(row2["toma_fisica"]);
            //            //row1.whs_equivalente = row.whs_equivalente;
            //            //row1.numero_transaccion = row.numero_transaccion;
            //            tableOps.AddRecuento_mpRow(row1);
            //            tableOps.AcceptChanges();

            //            Logistica.frmSeleccionLoteCierre frm = new Logistica.frmSeleccionLoteCierre(UsuarioLogeado, tableOps);
            //            if (frm.ShowDialog() == DialogResult.OK)
            //            {

            //            }

            //            //Row Style - Vamos a Pintar de Verde si cumple los parametros
            //        }
            //    }
            //}
        }

        private void grdv_mps_DoubleClick(object sender, EventArgs e)
        {
            var gv = (GridView)grd_mps.FocusedView;
            var row = (dsCierreMes.Recuento_mpRow)gv.GetDataRow(gv.FocusedRowHandle);

            try
            {
                if (contabilizado == false)
                {
                    using (SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA))
                    {
                        dsCierreMes.Recuento_mpDataTable tableOps = new dsCierreMes.Recuento_mpDataTable();

                        
                        DataTable TABLAOPSNew = new DataTable();

                        //foreach (dsCierreMes.Recuento_mpRow item in dsCierreMes1.Recuento_mp.Rows)
                        for (int i = 0; i < grdv_mps.SelectedRowsCount; i++)
                        {
                            DataRow row2 = grdv_mps.GetFocusedDataRow();

                            dsCierreMes.Recuento_mpRow row1 = tableOps.NewRecuento_mpRow();

                            row1.id_mp = Convert.ToInt32(grdv_mps.GetFocusedRowCellValue(id_mp));
                            row1.descripcion = Convert.ToString(grdv_mps.GetFocusedRowCellValue(colMP));
                            row1.id_bodega = Convert.ToInt32(grdv_mps.GetFocusedRowCellValue(id_bodega));
                            row1.ExistenciaAprox = Convert.ToDecimal(grdv_mps.GetFocusedRowCellValue(colExistenciaAnterior));
                            row1.toma_fisica = Convert.ToDecimal(grdv_mps.GetFocusedRowCellValue(colExistencia));
                            row1.diferencia = Convert.ToDecimal(grdv_mps.GetFocusedRowCellValue(coldiferencia));
                            id_detalle_recuento = Convert.ToInt32(grdv_mps.GetFocusedRowCellValue(count_id));

                            tableOps.AddRecuento_mpRow(row1);
                            tableOps.AcceptChanges();

                            
                            TABLAOPSNew = tableOps;
                        }
                        Logistica.frmSeleccionLoteCierre frm = new frmSeleccionLoteCierre(UsuarioLogeado, TABLAOPSNew, id_detalle_recuento);
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            tableOps.Clear();
                            for (int i = 0; i < grdv_mps.SelectedRowsCount; i++)
                            {
                                DataRow row2 = grdv_mps.GetFocusedDataRow();


                            }
                        }

                        //for (int i = 0; i < grdv_mps.SelectedRowsCount; i++)
                        //{

                        //    DataRow row2 = grdv_mps.GetDataRow(i);

                        //    if (Convert.ToDecimal(row2["diferencia"]) > 0 || Convert.ToDecimal(row2["diferencia"]) < 0)
                        //    {
                        //        dsCierreMes.Recuento_mpRow row1 = tableOps.NewRecuento_mpRow();
                        //        row1.id_mp = Convert.ToInt32(row2["id_mp"]);
                        //        row1.descripcion = Convert.ToString(row2["descripcion"]);
                        //        row1.peso = Convert.ToDecimal(row2["peso"]);
                        //        row1.id_bodega = Convert.ToInt32(row2["id_bodega"]);
                        //        row1.diferencia = Convert.ToDecimal(row2["diferencia"]);
                        //        row1.ExistenciaAprox = Convert.ToDecimal(row2["ExistenciaAprox"]);
                        //        row1.code_sap = Convert.ToString(row2["code_sap"]);
                        //        //row1.lote = row.lote;
                        //        row1.toma_fisica = Convert.ToDecimal(row2["toma_fisica"]);
                        //        //row1.whs_equivalente = row.whs_equivalente;
                        //        //row1.numero_transaccion = row.numero_transaccion;
                        //        int id_detalle_recuento = row.id;

                        //        tableOps.AddRecuento_mpRow(row1);
                        //        tableOps.AcceptChanges();

                        //        DataTable TABLEOPS = tableOps;
                        //        //tableOps.Clear();

                        //        Logistica.frmSeleccionLoteCierre frm = new Logistica.frmSeleccionLoteCierre(UsuarioLogeado, tableOps, id_detalle_recuento);
                        //        if (frm.ShowDialog() == DialogResult.OK)
                        //        {
                        //            //tableOps.Clear();
                        //        }
                        //    }
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdv_mps_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                ////Si el valor que se agrego igual a la diferencia en 0!
                //e.Appearance.BackColor = Color.Gray;
            }
        }
    }
}