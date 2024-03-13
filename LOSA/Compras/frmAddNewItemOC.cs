using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Calidad.LoteConfConsumo;
using LOSA.Finanzas;
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
using LOSA.Compras;
using LOSA.Clases;

namespace LOSA.Compras
{
    public partial class frmAddNewItemOC : DevExpress.XtraEditors.XtraForm
    {
        public string ItemCode;
        public string ItemName;
        public string Capitulo;
        public string Partida;
        public decimal Unidades, PrecioUnitario, Total;
        public string CodeISV;

        bool ExistenPartidas = false;

        DataOperations dp = new DataOperations();
        public frmAddNewItemOC()
        {
            InitializeComponent();
            CargarCapitulos();
        }

        private void CargarCapitulos()
        {
            try
            {
                string query = @"[sp_cm_orden_compra_capitulos_codigos]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsExoneracion1.capitulos.Clear();
                adat.Fill(dsExoneracion1.capitulos);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSearchMP frm = new frmSearchMP(frmSearchMP.TipoBusqueda.Items);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ItemCode = frm.ItemSeleccionado.ItemCode;
                ItemName = frm.ItemSeleccionado.ItemName;
                txtItem.Text = frm.ItemSeleccionado.ItemCode + " - " + frm.ItemSeleccionado.ItemName;
            }
        }

        private void gridLookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void CargarPartidasArancelarias(string pCode)
        {
            ExistenPartidas = false;
            try
            {
                string query = @"[sp_cm_exoneracion_partida_arancelaria]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Code", pCode.Trim());
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsExoneracion1.partida_arancelaria.Clear();
                adat.Fill(dsExoneracion1.partida_arancelaria);
                conn.Close();

                foreach (dsExoneracion.partida_arancelariaRow item in dsExoneracion1.partida_arancelaria)
                {
                    ExistenPartidas = true;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void txtUd_EditValueChanged(object sender, EventArgs e)
        {
            if (TsExoOExe.IsOn) //Exonerada
            {
                CalcularTotal();
                CalcularSaldos();
            }
            else
            {
                CalcularTotal();
                CamposExentos();
            }
            
            
        }

        private void grdCapitulo_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(grdCapitulo.EditValue.ToString()))
            {
                CargarPartidasArancelarias(grdCapitulo.EditValue.ToString());
                //dsExoneracion1.partida_arancelaria.AcceptChanges();
                if (ExistenPartidas == false) //No Existe Partida Relacionada con Este Capitulo
                {
                    DetalleExoneracion Saldo = new DetalleExoneracion();
                    Saldo.RecuperarSaldoCapitulo(grdCapitulo.EditValue.ToString());
                    txtSaldoDisponible.EditValue = Saldo.SaldoDisponible;
                    txtUdDisponible.EditValue = 0;
                    grdPartidaAranc.Enabled = false;
                }
                else
                {
                    grdPartidaAranc.Enabled = true;
                }
            }
        }

        private void CalcularSaldos()
        {
            
            if (ExistenPartidas == false) //No se toman en cuenta Unidades
            {
                txtSaldoPorConsumir.EditValue = txtTotal.EditValue;
                txtUdporConsumir.EditValue = 0;

                 txtNuevoSaldo.EditValue = Convert.ToDecimal(txtSaldoDisponible.EditValue) - Convert.ToDecimal(txtSaldoPorConsumir.EditValue);

                txtUdNueva.EditValue = 0;
            }
            else
            {
                txtSaldoPorConsumir.EditValue = txtTotal.EditValue;
                txtUdporConsumir.EditValue = txtUd.EditValue;

                txtNuevoSaldo.EditValue = Convert.ToDecimal(txtSaldoDisponible.EditValue) - Convert.ToDecimal(txtSaldoPorConsumir.EditValue);

                txtUdNueva.EditValue = Convert.ToDecimal(txtUdDisponible.EditValue) - Convert.ToDecimal(txtUdporConsumir.EditValue);
            }

            

        }

        private void grdPartidaAranc_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(grdPartidaAranc.Text))
            {
                DetalleExoneracion dSaldo = new DetalleExoneracion();
                dSaldo.RecuperarSaldoCapituloPartida(grdCapitulo.EditValue.ToString(), grdPartidaAranc.EditValue.ToString());
                txtSaldoDisponible.EditValue = dSaldo.SaldoDisponible;
                txtUdDisponible.EditValue = dSaldo.UnidadesDisponible;

                CalcularSaldos();
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItem.Text))
            {
                CajaDialogo.Error("Debe Seleccionar un Item!");
                btnAdd.Focus();
                return;
            }

            if (TsExoOExe.IsOn) //Exonerada
            {
                if (string.IsNullOrEmpty(grdCapitulo.Text))
                {
                    CajaDialogo.Error("En Ordenes Exoneradas debe seleccionar un Capitulo!");
                    return;
                }

                if (Convert.ToDecimal(txtSaldoDisponible.EditValue) <= 0)
                {
                    CajaDialogo.Error("No existe Saldo Disponible en esta combinacion de Capitulos-Partida!");
                    return;
                }

                if (Convert.ToDecimal(txtNuevoSaldo.EditValue) < 0)
                {
                    CajaDialogo.Error("No existe Saldo Disponible en esta combinacion de Capitulos-Partida!");
                    return;
                }


                if (ExistenPartidas == true)
                {
                    if (string.IsNullOrEmpty(grdPartidaAranc.Text))
                    {
                        CajaDialogo.Error("Debe seleccionar un Partida Arancelaria!");
                        return;
                    }

                    if (Convert.ToDecimal(txtUdDisponible.EditValue) <= 0)
                    {
                        CajaDialogo.Error("No hay Unidades Disponibles en esta Partida Arancelaria!");
                        return;
                    }

                    if (Convert.ToDecimal(txtUdNueva.EditValue) < 0)
                    {
                        CajaDialogo.Error("La Cantidad de Unidades supera la Disponible.");
                        return;
                    }
                }
                else
                {
                    grdPartidaAranc.EditValue = " ";
                }
            }
            else
            {
                grdPartidaAranc.EditValue = " ";
                grdCapitulo.EditValue = " ";
            }
           
            

            if (Convert.ToDecimal(txtUd.EditValue) <= 0)
            {
                CajaDialogo.Error("Debe colorar al menos una unidad(1)");
                return;
            }

            if (Convert.ToDecimal(txtUnitPrice.EditValue) <= 0)
            {
                CajaDialogo.Error("Debe colocar una Precio Unitario!");
                return;
            }

            Capitulo = grdCapitulo.EditValue.ToString();
            Partida = grdPartidaAranc.EditValue.ToString();
            Unidades = Convert.ToDecimal(txtUd.EditValue);
            PrecioUnitario = Convert.ToDecimal(txtUnitPrice.EditValue);

            if (TsExoOExe.IsOn)
                CodeISV = "EXO";
            else
                CodeISV = "EXE";

            Total = Convert.ToDecimal(txtTotal.EditValue);

            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        private void TsExoOExe_Toggled(object sender, EventArgs e)
        {
            if(TsExoOExe.IsOn)
            {
                grdCapitulo.Enabled = true;
                grdPartidaAranc.Enabled = true;
            }
            else
            {
                grdCapitulo.Enabled = false;
                grdPartidaAranc.Enabled = false;
                grdCapitulo.Text = "";
                grdPartidaAranc.Text = "";

            }
        }

        private void CalcularTotal()
        {
            decimal Total = Convert.ToDecimal(txtTotal.EditValue);
            decimal Unidades = Convert.ToDecimal(txtUd.EditValue);
            decimal PrecioUnitario = Convert.ToDecimal(txtUnitPrice.EditValue); 

            Total = (Unidades * PrecioUnitario);

            txtUd.EditValue = string.Format("{0:###,##0.00}", Unidades);
            txtUnitPrice.EditValue = string.Format("{0:###,##0.00}", PrecioUnitario);
            txtTotal.EditValue = string.Format("{0:###,##0.00}", Total);

        }

        private void txtUnitPrice_EditValueChanged(object sender, EventArgs e)
        {
            if (TsExoOExe.IsOn)
            {
                CalcularTotal();
                CalcularSaldos();
            }
            else
            {
                CalcularTotal();
                CamposExentos();
            }
            
            
        }

        private void CamposExentos()
        {
            txtSaldoDisponible.EditValue = txtSaldoPorConsumir.EditValue = txtNuevoSaldo.EditValue = 0;
            txtUdDisponible.EditValue = txtUdporConsumir.EditValue = txtUdNueva.EditValue = 0;
        }
    }
}