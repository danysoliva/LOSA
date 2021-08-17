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
using LOSA.AlmacenesExterno.Models;
using ACS.Classes;
using System.Data.SqlClient;

namespace LOSA.AlmacenesExterno
{
    public partial class xfrmLoteCRUD : DevExpress.XtraEditors.XtraForm
    {
            public    Ingreso_Externo_Lote lote = new Ingreso_Externo_Lote();
        public xfrmLoteCRUD()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();

                lote = new Ingreso_Externo_Lote();

                lote.Unidades = Convert.ToDecimal( txtUnidad.Text);
                lote.Lote = txtLote.Text;
                lote.Cantidad = Convert.ToDecimal(txtCantidad.Text);
                lote.NumLine = -1;
                lote.FechaProduccion = Convert.ToDateTime(deFechaProduccion.Text);
                lote.FechaVencimiento = Convert.ToDateTime(deFechaProduccion.Text);

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("sp_insert_lote_almacenes_externos", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@cantidad", SqlDbType.Decimal).Value = lote.Cantidad;
                    cmd.Parameters.Add("@unidades", SqlDbType.Decimal).Value = lote.Unidades;
                    cmd.Parameters.Add("@id_detalle", SqlDbType.Decimal).Value = 0;
                    cmd.Parameters.Add("@lote", SqlDbType.VarChar).Value = lote.Lote;
                    cmd.Parameters.Add("@fecha_vencimiento", SqlDbType.DateTime).Value = lote.FechaVencimiento;
                    cmd.Parameters.Add("@fecha_produccion", SqlDbType.DateTime).Value = lote.FechaProduccion;

                    lote.ID = Convert.ToInt32(cmd.ExecuteScalar());
                    cnx.Close();

                }

                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}