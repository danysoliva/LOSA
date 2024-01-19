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
using LOSA.Clases;
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.Finanzas
{
    public partial class frmExoneracionAQ_OP : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        int Id_Header = 0;
        public enum TipoOperacion
        {
            insert =1,
            update = 2
        }

        TipoOperacion tipoOperacion;

        public frmExoneracionAQ_OP(UserLogin pUserLogin, TipoOperacion ptipo_op, int pIdHeader)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
            tipoOperacion = ptipo_op;

            switch (tipoOperacion)
            {
                case TipoOperacion.insert:
                    txtAnio.EditValue = dp.Now().Year;
                    dtFechaInicio.EditValue = dp.Now().Date;
                    dtFechaFin.EditValue = dp.Now().AddYears(1);

                    break;
                case TipoOperacion.update:
                    lblTipoOp.Text = "Edicion Exoneracion Fiscal";
                    Id_Header = pIdHeader;
                    DetalleExoneracion dH = new DetalleExoneracion();
                    dH.RecuperarHedaer(Id_Header);
                    txtAnio.Text = dH.Anio.ToString();
                    dtFechaInicio.EditValue = dH.FInicio;
                    dtFechaFin.EditValue = dH.FFinal;
                    break;
                default:

                    CajaDialogo.Error("No se pudo definir una Operacion(INSERT-UPDATE)");
                    break;
            }

            
        }

        private void cmdConfirma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResolucion.Text))
            {
                CajaDialogo.Error("Debe Colocar la Resolucion!");
            }
            if (string.IsNullOrEmpty(txtAnio.Text))
            {
                CajaDialogo.Error("Debe Seleccionar un Año valido!");
            }
            if (string.IsNullOrEmpty(dtFechaInicio.Text))
            {
                CajaDialogo.Error("Debe Seleccionar una Fecha de Inicio valida!");
            }

            if (string.IsNullOrEmpty(dtFechaFin.Text))
            {
                CajaDialogo.Error("Debe Seleccionar una Fecha de Fin valida!");
            }

            if (Convert.ToDateTime(dtFechaInicio.EditValue) >= Convert.ToDateTime(dtFechaFin.EditValue))
            {
                CajaDialogo.Error("La Fecha Inicial no puede ser mayor que la Fecha Fin");
            }

            SqlConnection conn = new SqlConnection(dp.ConnectionSAP_ACS);
            conn.Open();

            switch (tipoOperacion)
            {
                case TipoOperacion.insert:

                    try
                    {
                        SqlCommand cmdI = new SqlCommand("sp_insert_new_exoneracion_header", conn);
                        cmdI.CommandType = CommandType.StoredProcedure;
                        cmdI.Parameters.AddWithValue("@anio", txtAnio.EditValue);
                        cmdI.Parameters.AddWithValue("@inicio", dtFechaInicio.EditValue);
                        cmdI.Parameters.AddWithValue("@final", dtFechaFin.EditValue);
                        cmdI.Parameters.AddWithValue("@resolucion_exonerada", txtResolucion.Text);
                        cmdI.Parameters.AddWithValue("@user_create", UsuarioLogueado.Id);
                        cmdI.ExecuteNonQuery();

                        CajaDialogo.Information("Transaccion Exitosa!\nPeriodo Creado!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex) 
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    

                    break;
                case TipoOperacion.update:
                    try
                    {
                        SqlCommand cmdU = new SqlCommand("", conn);
                        cmdU.CommandType = CommandType.StoredProcedure;
                        cmdU.Parameters.AddWithValue("@anio", txtAnio.EditValue);
                        cmdU.Parameters.AddWithValue("@inicio", dtFechaInicio.EditValue);
                        cmdU.Parameters.AddWithValue("@final", dtFechaFin.EditValue);
                        cmdU.Parameters.AddWithValue("@resolucion_exonerada", txtResolucion.Text);
                        cmdU.Parameters.AddWithValue("@Id_Header", Id_Header);
                        cmdU.ExecuteNonQuery();

                        CajaDialogo.Information("Transaccion Exitosa!\nPeriodo Editado!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex) 
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                    

                    break;
                default:
                    break;

                    
            }
        }
    }
}