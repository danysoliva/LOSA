using ACS.Classes;
using Core.Clases.Herramientas;
using DevExpress.XtraReports.UI;
using LOSA.Calidad.LoteConfConsumo;
using LOSA.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LOSA.RecepcionMP
{
    public partial class frmagregarlote : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int IdSerie;
        int NumBoleta;
        int IdMP;
        int idUbicacionNueva;
        string ItemCode;
        UserLogin UsuarioLogeado;
        int Id_ingreso;
        decimal factor;
        public frmagregarlote(int id_ingreso, int numero_referencia, UserLogin user, string pitemcode)
        {
            InitializeComponent();
            UsuarioLogeado = user;
            ItemCode = pitemcode;
            MateriaPrima mp = new MateriaPrima();
            mp.RecuperarRegistroFromCode(ItemCode);

            txtCodigoMP.Text = ItemCode;
            txtMP_Name.Text = mp.NameComercial;
            txtpresentacionPromedio.Visible = false;
            Tg_presentacion_promedio.IsOn = false;
            gridLookUpEditPresentacion.Visible = true;
            gridLookUpEditPresentacion.Enabled = true;



            this.Id_ingreso = id_ingreso;
            LoadPresentaciones();
            Load_Data();

        }
        private void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_presentaciones_activas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRecepcionMPx.presentaciones.Clear();
                adat.Fill(dsRecepcionMPx.presentaciones);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void LoadDatosBoleta(int idserie)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_detalles_boleta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SerieBoleta", idserie);
                //cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //txtCodigoMP.Text = dr.GetString(1);
                    //txtMP_Name.Text = dr.GetString(2);

                    txtCodigoProveedor.Text = dr.GetString(3);
                    txtProveedorName.Text = dr.GetString(4);
                    NumBoleta = dr.GetInt32(0);
                   
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        public void Load_Data()
        {
            string query = @"ps_get_info_ingreso";
            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idingreso", Id_ingreso);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdSerie = dr.GetInt32(7);
                    txtIdBoleta.Text = IdSerie.ToString();
                    dtFechaIngreso.DateTime = dr.GetDateTime(4);
                    gridLookUpEditPresentacion.EditValue = dr.GetInt32(8);
                    txtNumIngreso.Text = dr.GetInt32(1).ToString();
                }
                else
                {
                    CajaDialogo.Error("No se pudo leer el numero de ingreo, contacte al departamento de IT para mas soluciones");
                    return;
                }
                dr.Close();
                con.Close();
                LoadDatosBoleta(IdSerie);


            }
            catch (Exception ex)
            {
                
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            int idloteInserted;
            if (gvNuevaUbicacion.RowCount <= 0)
            {
                CajaDialogo.Error("Debe seleccionar una ubicacion predeterminada para todas las tarimas.");
                return;
            }
            if (IdSerie <= 0)
            {
                CajaDialogo.Error("No se puede registrar una tarima sin la boleta de bascula!");
                return;
            }

            if (Convert.ToDecimal(txtUnidades.Text) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una tarima con unidades de materia en cero (0)!");
                return;
            }

            if (!Tg_presentacion_promedio.IsOn)
            {
                if (string.IsNullOrEmpty(gridLookUpEditPresentacion.Text))
                {
                    CajaDialogo.Error("Es necesario seleccionar la presentacion de la Materia Prima!");
                    return;
                }
            }

            if (string.IsNullOrEmpty(txtLote.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar el lote para la tarima!");
                return;
            }

            if (string.IsNullOrEmpty(dtFechaProduccion.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la fecha de producción!");
                return;
            }

            if (string.IsNullOrEmpty(dtFechaVencimiento.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la fecha de vencimiento de la materia prima!");
                return;
            }

            int cant = 0;
            try
            {
                cant = Convert.ToInt32(txtCantidadTarimasTotal.Text);
            }
            catch
            {
                cant = 0;
            }

            if (cant <= 0)
            {
                CajaDialogo.Error("No se puede registrar menos de una (1) tarima!");
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_only_lote_ingresos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@itemcode", txtCodigoMP.Text);//
                cmd.Parameters.AddWithValue("@itemname", txtMP_Name.Text);//
                cmd.Parameters.AddWithValue("@cardcode", txtCodigoProveedor.Text);//
                cmd.Parameters.AddWithValue("@cardname", txtProveedorName.Text);  //
                cmd.Parameters.AddWithValue("@fecha_ingreso", dtFechaIngreso.EditValue);
                cmd.Parameters.AddWithValue("@numero_transaccion", txtNumIngreso.Text); //
                cmd.Parameters.AddWithValue("@lote_materia_prima", txtLote.Text);//
                cmd.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);//
                cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);//
                cmd.Parameters.AddWithValue("@id_boleta", this.IdSerie);//
                cmd.Parameters.AddWithValue("@cant", txtUnidades.Text);//
                cmd.Parameters.AddWithValue("@TotalTarimas", txtCantidadTarimasTotal.Text);//
                cmd.Parameters.AddWithValue("@pesotaria", Convert.ToDecimal(txtPesoKg.Text));//
                cmd.Parameters.AddWithValue("@id_ingreso",Id_ingreso);//
                idloteInserted = Convert.ToInt32(cmd.ExecuteScalar());
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return;

            }

            bool Guardo = false;
            int vid_tarima = 0;
            ArrayList List = new ArrayList();

            for (int i = 1; i <= cant; i++)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();

                    SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", con);
                    cmm.CommandType = CommandType.StoredProcedure;
                    cmm.Parameters.AddWithValue("@id", 1);
                    string barcode = cmm.ExecuteScalar().ToString();

                    SqlCommand cmd = new SqlCommand("sp_insert_new_tarima_lote_v2", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@itemcode", txtCodigoMP.Text);
                    cmd.Parameters.AddWithValue("@id_proveedor", txtCodigoProveedor.Text);
                    cmd.Parameters.AddWithValue("@fecha_ingreso", dtFechaIngreso.EditValue);
                    cmd.Parameters.AddWithValue("@numero_transaccion", txtNumIngreso.Text);
                    cmd.Parameters.AddWithValue("@fecha_vencimiento", dtFechaVencimiento.EditValue);
                    cmd.Parameters.AddWithValue("@fecha_produccion_materia_prima", dtFechaProduccion.EditValue);
                    cmd.Parameters.AddWithValue("@lote_materia_prima", txtLote.Text);
                    cmd.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);
                    cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                    cmd.Parameters.AddWithValue("@id_boleta", this.IdSerie);
                    cmd.Parameters.AddWithValue("@codigo_barra", barcode);
                    cmd.Parameters.AddWithValue("@cant", txtUnidades.Text);
                    cmd.Parameters.AddWithValue("@peso", Convert.ToDecimal(txtPesoKg.Text));
                    cmd.Parameters.AddWithValue("@idlotes", idloteInserted);
                    cmd.Parameters.AddWithValue("@factor", factor);
                    //cmd.Parameters.AddWithValue("@bit_promedio", Tg_presentacion_promedio.IsOn ? 1 : 0);
                    if (Tg_presentacion_promedio.IsOn)
                        cmd.Parameters.AddWithValue("@bit_promedio", 1);
                    else
                        cmd.Parameters.AddWithValue("@bit_promedio", 0);
                    vid_tarima = Convert.ToInt32(cmd.ExecuteScalar());

                    SqlCommand cmdx = new SqlCommand("sp_insert_ubicacion_default", con);
                    cmdx.CommandType = CommandType.StoredProcedure;
                    cmdx.Parameters.AddWithValue("@id_tarima", vid_tarima);
                    cmdx.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                    cmdx.Parameters.AddWithValue("@codigo_barra", barcode);
                    cmdx.Parameters.AddWithValue("@id_ubicacion", idUbicacionNueva);
                    cmdx.ExecuteNonQuery();

                    List.Add(vid_tarima);

                    Guardo = true;
                    con.Close();
                    //CajaDialogo.InformationAuto();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }

            if (Guardo)
            {
                DialogResult r = CajaDialogo.Pregunta("Desea Imprimir la(s) Hoja(s) de Ingreso?");
                if (r == DialogResult.Yes)
                {
                    for (int i = 0; i <= (List.Count - 1); i++)
                    {
                        int id_tarimax = Convert.ToInt32(List[i]);

                        rptReporteIngresoTarima report = new rptReporteIngresoTarima(id_tarimax);
                        report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                        report.ShowPrintMarginsWarning = false;
                        report.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                        report.Print();
                    }
                }
            }
        }
        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            //Indica el numero de copias de la boleta que seran impresas
            e.PrintDocument.PrinterSettings.Copies = 1;
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtUnidades_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void txtUnidades_TextChanged(object sender, EventArgs e)
        {
            if (Tg_presentacion_promedio.IsOn) // 
            {
                CalculodelPromedio();
            }
            else
            {
                try
                {
                    txtPesoKg.Text = string.Format("{0:###,##0.00}", (factor * Convert.ToDecimal(txtUnidades.Text)));
                }
                catch
                {
                    txtPesoKg.Text = "0";
                }
            }
            //txtPesoTM.Text = string.Format("{0:0.00}", (factor * Convert.ToDecimal(txtUnidades.Text)));
        }

        private void gridLookUpEditPresentacion_EditValueChanged(object sender, EventArgs e)
        {
            PresentacionX pre1 = new PresentacionX();
            if (pre1.RecuperarRegistro(Convert.ToInt32(gridLookUpEditPresentacion.EditValue)))
            {
                factor = pre1.Factor;
                txtPesoKg.Text = string.Format("{0:###,##0.00}", (factor * Convert.ToDecimal(txtUnidades.Text)));
            }

        }
        private DataTable CreateDataUbicacion_v2(string pRack, string pBodega)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Detalle", typeof(string));
            dt.Columns.Add("Valor", typeof(string));

            dt.Rows.Add("Bodega", pBodega);

            dt.Rows.Add("RACK", pRack);
            //dt.Rows.Add("ALTURA", pAltura);
            //dt.Rows.Add("PROFUNDIDAD", pProfundidad);

            return dt;
        }
        private void GvNuevaUbicacion_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

        }
        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            frmUbicacionTarima2 frm = new frmUbicacionTarima2();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                idUbicacionNueva = frm.idUbicacion;
                gcNuevaUbicación.DataSource = CreateDataUbicacion_v2(frm.rack, frm.BodegaNombre);
                gvNuevaUbicacion.InitNewRow += GvNuevaUbicacion_InitNewRow;
                gvNuevaUbicacion.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            }
        }

        private void txtLote_Click(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void beNuevaUbicacion_Click(object sender, EventArgs e)
        {
            frmUbicacionTarima2 frm = new frmUbicacionTarima2();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                idUbicacionNueva = frm.idUbicacion;
                gcNuevaUbicación.DataSource = CreateDataUbicacion_v2(frm.rack, frm.BodegaNombre);
                gvNuevaUbicacion.InitNewRow += GvNuevaUbicacion_InitNewRow;
                gvNuevaUbicacion.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmBoleta frm = new FrmBoleta();
            frm.WindowState = FormWindowState.Maximized;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtIdBoleta.Text = frm.NumBoleta.ToString();
                this.IdSerie = frm.IdSerie;
                this.NumBoleta = frm.NumBoleta;
                this.ItemCode = frm.ItemCode;
                LoadDatosBoleta(frm.IdSerie);
            }
        }

        private void txtIdBoleta_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtIdBoleta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                int id_b = 0;
                try
                {
                    id_b = Convert.ToInt32(txtIdBoleta.Text);
                }
                catch { }

                this.IdSerie = id_b;
                Boleta bol1 = new Boleta();
                if (bol1.RecuperarRegistro(this.IdSerie))
                {
                    txtIdBoleta.Text = bol1.NumID.ToString();
                }
                LoadDatosBoleta(id_b);
            }
        }

        private void btnMP_Click(object sender, EventArgs e)
        {
            //frmSelectMP frm = new frmSelectMP();
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    txtCodigoMP.Text = frm.ItemCode;
            //    txtMP_Name.Text = frm.ItemName;
            //}

            frmSearchMP frm = new frmSearchMP(frmSearchMP.TipoBusqueda.MateriaPrima);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCodigoMP.Text = frm.ItemSeleccionado.ItemCode;
                txtMP_Name.Text = frm.ItemSeleccionado.ItemName;
            }

        }

        public void CalculodelPromedio()
        {
            try
            {
                int unidades_Tarimas = Convert.ToInt32(txtUnidades.Text);
                int cantidad_tariams = Convert.ToInt32(txtCantidadTarimasTotal.Text);
                decimal Unidades_totales = unidades_Tarimas * cantidad_tariams;
                decimal total_pesoKg = Convert.ToDecimal(txtPesoKg.Text);
                factor = total_pesoKg / Unidades_totales;
                txtpresentacionPromedio.Text = string.Format("{0:###,##0.00}", (factor));


            }
            catch (Exception ex)
            {
            }
        }

        private void txtCantidadTarimasTotal_TextChanged(object sender, EventArgs e)
        {
            if (Tg_presentacion_promedio.IsOn)
            {
                try
                {
                    CalculodelPromedio();
                }
                catch (Exception ex)
                {

                }
            }
            else
            {

            }
        }

        private void Tg_presentacion_promedio_Toggled(object sender, EventArgs e)
        {
            if (Tg_presentacion_promedio.IsOn)          // Data
            {
                try
                {
                    txtpresentacionPromedio.Visible = true;
                    gridLookUpEditPresentacion.Visible = false;
                    factor = 0;
                    labelControl12.Text = "Peso total KG";
                    txtPesoKg.Enabled = true;
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                txtpresentacionPromedio.Visible = false;
                gridLookUpEditPresentacion.Visible = true;
                txtPesoKg.Enabled = false;
                labelControl12.Text = "Peso Kg por tarima";

                try
                {
                    PresentacionX pre1 = new PresentacionX();
                    if (pre1.RecuperarRegistro(Convert.ToInt32(gridLookUpEditPresentacion.EditValue)))
                    {
                        factor = pre1.Factor;
                        txtPesoKg.Text = string.Format("{0:###,##0.00}", (factor * Convert.ToDecimal(txtUnidades.Text)));

                    }
                }
                catch (Exception ex)
                {


                }
            }
        }

        private void txtPesoKg_TextChanged(object sender, EventArgs e)
        {
            CalculodelPromedio();
        }
    }
}