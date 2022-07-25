using ACS.Classes;
using Core.Clases.Herramientas;
using Huellas;
using LOSA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RecepcionMP
{
    public partial class frmEditTarima : Form
    {
        int IdTarima;
        UserLogin UsuarioLogeado;
        decimal factor;
        public string ItemCode;
        public frmEditTarima(int pIdTarima, UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            LoadPresentaciones();
            IdTarima = pIdTarima;
            LoadDataTarima(pIdTarima);
            cargarDatosProveedor();
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
                dsRecepcionMPx1.presentaciones.Clear();
                adat.Fill(dsRecepcionMPx1.presentaciones);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDataTarima(int pIdTarima)
        {     
            //LoadDatosBoleta();
            Tarima tam = new Tarima();
            if (tam.RecuperarRegistro(this.IdTarima))
            {
                dtFechaIngreso.EditValue = string.Format("{0:dd/MM/yyyy}", tam.FechaIngreso);
                gridLookUpEditPresentacion.EditValue = tam.IdPresentacion;
                txtUnidades.Text = string.Format("{0:###,##0.00}", tam.Cantidad);
                txtNumIngreso.Text = string.Format("{0:###,##0}", tam.NumeroTransaccion);
                txtLote.Text = tam.LoteMP;
                txtPesoKg.Text = string.Format("{0:###,##0.00}", tam.Peso);
                dtFechaProduccion.EditValue = string.Format("{0:dd/MM/yyyy}", tam.FechaProduccion);
                dtFechaVencimiento.EditValue = string.Format("{0:dd/MM/yyyy}", tam.FechaVencimiento);
                txtIdBoleta.Text = tam.IdBoleta.ToString();
                MateriaPrima mp = new MateriaPrima();
                if (mp.RecuperarRegistroFromID_RM(tam.Id_materiaprima))
                {
                    ItemCode = mp.CodeMP_SAP;
                    txtMP_Name.Text = mp.Name;
                }
                Proveedor pv = new Proveedor();
                if (pv.RecuperarRegistro(tam.IdProveedor))
                {
                    txtCodigoProveedor.Text = tam.IdProveedor;
                    glueProveedor.EditValue = tam.IdProveedor;
                }
            }
        }

        //private void LoadDatosBoleta()
        //{
        //    try
        //    {
        //        DataOperations dp = new DataOperations();
        //        SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("sp_get_detalles_boleta", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@SerieBoleta", this.IdSerie);
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            txtCodigoMP.Text = dr.GetString(1);
        //            txtMP_Name.Text = dr.GetString(2);
        //            txtCodigoProveedor.Text = dr.GetString(3);
        //            txtProveedorName.Text = dr.GetString(4);
        //        }
        //        dr.Close();
        //        con.Close();
        //    }
        //    catch (Exception ec)
        //    {
        //        CajaDialogo.Error(ec.Message);
        //    }
        //}








        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            
            if (IdTarima <= 0)
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
                CajaDialogo.Error("Es obligatorio llenar la fecha de producción de la materia prima!");
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

            DialogResult r = CajaDialogo.Pregunta("Desea realizar estas modificaciones?");
            if (r != DialogResult.Yes)
                return;

            //Validar consumo de tarima en Alimentacion
            //ValidarConsumoAlimentacion(IdTarima);

            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_update_tarima_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fecha_ingreso",  Convert.ToDateTime(dtFechaIngreso.EditValue));
                cmd.Parameters.AddWithValue("@fecha_vencimiento", Convert.ToDateTime(dtFechaVencimiento.EditValue));
                cmd.Parameters.AddWithValue("@fecha_produccion_materia_prima", Convert.ToDateTime(dtFechaProduccion.EditValue));
                cmd.Parameters.AddWithValue("@lote_materia_prima", txtLote.Text);
                cmd.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);
                cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@cantidad", Convert.ToDecimal(txtUnidades.Text));
                cmd.Parameters.AddWithValue("@peso", Convert.ToDecimal(txtPesoKg.Text));
                cmd.Parameters.AddWithValue("@id_proveedor", glueProveedor.EditValue.ToString());
                cmd.Parameters.AddWithValue("@itemcode", this.ItemCode);
                cmd.Parameters.AddWithValue("@id", this.IdTarima);
                cmd.ExecuteScalar();
                con.Close();

                SplashForm form1 = new SplashForm(2);
                form1.Show();
                Thread.Sleep(50);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            
        }

        private void ValidarConsumoAlimentacion(int pIdTarima)
        {
            try
            {
                string sql = @"SELECT count(*)
                               FROM [LOSA].[dbo].[LOSA_alimentacion_tarimas] A
                                    where enable = 1 and id_tarima =" + pIdTarima;
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                int RegistrosConsumo = (int)cmd.ExecuteScalar();

                if (RegistrosConsumo > 0)
                {
                    CajaDialogo.Error("No puede editar esta tarima ya que fue entregada parcial o completamente a produccion!");
                    return;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
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
                factor = 0;
                factor = total_pesoKg / Unidades_totales;
                txtpresentacionPromedio.Text = string.Format("{0:###,##0.00}", (factor));


            }
            catch (Exception ex)
            {
            }
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

        void cargarDatosProveedor()
        {
            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL = @"exec sp_get_providersv2";


                dsLogistica21.Proveedores.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);
                adat.Fill(dsLogistica21.Proveedores);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void txtMP_Name_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmMP frm = new frmMP();
            if (this.MdiParent != null)
            {
                //frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtMP_Name.Text = frm.MateriaPrima;
                
                //txtCodigoProveedor.Text = frm.idProveedor;
                //txtProveedorName.Text = frm.NombreProveedor;
                this.ItemCode = frm.ItemCode;
            }
        }

        private void glueProveedor_EditValueChanged(object sender, EventArgs e)
        {
            txtCodigoProveedor.Text = glueProveedor.EditValue.ToString();
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
    }//end public partial class frmEditTarima
}//end namespace LOSA.RecepcionMP
