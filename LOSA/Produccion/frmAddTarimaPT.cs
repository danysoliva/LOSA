using ACS.Classes;
using LOSA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Produccion
{
    public partial class frmAddTarimaPT : Form
    {
        UserLogin UsuarioLogeado;
        int Lote;
        int IdProd;
        decimal bolsa;
        public frmAddTarimaPT(UserLogin UsuarioLogeado, int plote, int pidProd)
        {
            InitializeComponent();
            LoadNumeroTransaccion();
            bolsa = 1;
            Lote = plote;
            txtLote.Text = plote.ToString();
            IdProd = pidProd;
            DataOperations dp = new DataOperations();
            dtFechaProduccion.EditValue = dp.Now();
            DateTime fechav = Convert.ToDateTime(dtFechaProduccion.EditValue);
            dtFechaVence.EditValue = fechav.AddDays(Convert.ToInt32(txtDias.Text));
            ProductoTerminado pt = new ProductoTerminado(dp.ConnectionStringCostos);
            if (pt.Recuperar_producto(pidProd))
            {
                txtProductoName.Text = pt.descripcion;
                int idbag = pt.id_bag;
                if (idbag > 0)
                {
                    BagsPT bg = new BagsPT();
                    if (bg.RecuperarRegistro(idbag))
                    {
                        txtProductoName.Text = pt.descripcion;
                        bolsa = bg.net;
                        txtPresentacion.Text = bg.Descripcion;
                        if (bolsa <= 25)
                        {
                            txtUnidades.Text = "70";
                        }
                        else
                        {
                            txtUnidades.Text = "25";
                        }
                        decimal peso_ = Convert.ToDecimal(txtUnidades.Text) * bolsa;
                        txtPesoKg.Text = string.Format("{0:###,##0.00}", peso_);
                    }
                }
            }
        }
        private void LoadNumeroTransaccion()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                SqlCommand cmm2 = new SqlCommand("sp_generar_codigo_from_tables_id", con);
                cmm2.CommandType = CommandType.StoredProcedure;
                cmm2.Parameters.AddWithValue("@id", 2);
                string num_ingreso = cmm2.ExecuteScalar().ToString();
                txtNumTransaccion.Text = num_ingreso;
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
