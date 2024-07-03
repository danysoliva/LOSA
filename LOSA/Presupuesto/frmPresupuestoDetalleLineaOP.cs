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
using ACS.Classes;
using LOSA.Clases;
using LOSA.Classes;
using LOSA.Presupuesto;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Presupuesto
{
    
    public partial class frmPresupuestoDetalleLineaOP : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado = new UserLogin();
        LOSA.Clases.Presupuesto prep = new Clases.Presupuesto();
        int IdPresupuesto;
        int IdDetalle;
        public frmPresupuestoDetalleLineaOP(UserLogin pUserLog, int pIdPresup, int pIdDetalle)
        {
            InitializeComponent();

            UsuarioLogeado = pUserLog;
            IdPresupuesto = pIdPresup;
            prep.RecuperarPresupuestoH(IdPresupuesto);
            comboAnio.Text = prep.Anio.ToString();
            txtDescripcionH.Text = prep.DescripcionH;

            IdDetalle = pIdDetalle;
            prep.RecuperarPresupuestoD(IdDetalle);
            txtDepartamento.Text = prep.DescripcionDepartamento;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescrPresupuesto.Text))
            {
                CajaDialogo.Error("Debe agregar una descripcion!");
                return;
            }

            if (Convert.ToDecimal(txtMonto.EditValue) <= 0)
            {
                CajaDialogo.Error("Debe agregar un valor Mayor que (0)!");
                return;
            }

            //Insertar
            //prep.InsertarDetalleLineaPresupuesto(IdDetalle, DescripcionPresupuesto, Monto, UsuarioLogeado.Id);

            bool Guardar = false;
            try
            {

                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_presupuesto_insert_detalle_lineas]", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_d", IdDetalle);
                cmd.Parameters.AddWithValue("@descripcion", txtDescrPresupuesto.Text);
                cmd.Parameters.AddWithValue("@monto", Convert.ToDecimal(txtMonto.EditValue));
                cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                cmd.ExecuteNonQuery();
                Guardar = true;
            }
            catch (Exception ex)
            {
                Guardar = false;
                CajaDialogo.Error(ex.Message);
            }

            if (Guardar)
            {
                CajaDialogo.Information("Presupuesto Guardado!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
    }
}