using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace LOSA.Calidad.InspeccionIngreso
{
    public partial class frmIngresoTipoMarino : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        public IngredienteMarino IM { get; private set; }

        public enum TipoOperacion
        {
            Agregar = 1,
            Editar = 2
        }

        decimal PorcentajeMarino = 0;

        public frmIngresoTipoMarino(decimal pPorcentajeMarino)
        {
            InitializeComponent();

            load_especie();
            load_zonas();
            load_paises();
            load_tipo();

            PorcentajeMarino = pPorcentajeMarino;

        }

        public void load_tipo()
        {
            string query = @"sp_load_tipo_ingreso_calidad";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsMantenimientoC1.tipoingreso.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMantenimientoC1.tipoingreso);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_paises()
        {
            string query = @"sp_load_paises_de_origen_calidad_ingreso";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsMantenimientoC1.pais.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMantenimientoC1.pais);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_zonas()
        {
            string query = @"sp_load_zona_pesca_calidad";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsMantenimientoC1.zonaPesca.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMantenimientoC1.zonaPesca);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_especie()
        {
            string query = @"sp_select_especies_origen";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsMantenimientoC1.origen_especie.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMantenimientoC1.origen_especie);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void grd_origenespecie_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (grd_origenespecie.EditValue != null)
                {
                    foreach (dsMantenimientoC.origen_especieRow row in dsMantenimientoC1.origen_especie.Rows)
                    {
                        if (Convert.ToInt32(grd_origenespecie.EditValue) == row.id)
                        {
                            hyfishsource.EditValue = row.fishsource;
                            hyIUCN.EditValue = row.iucn;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grd_origenespecie.Text))
            {
                CajaDialogo.Error("Debe Seleccionar " + labelControl21.Text);
                return;
            }

            if (string.IsNullOrEmpty(grd_pesca.Text))
            {
                CajaDialogo.Error("Debe Seleccionar " + labelControl22.Text);
                return;
            }

            if (string.IsNullOrEmpty(grd_origen.Text))
            {
                CajaDialogo.Error("Debe Seleccionar: " + labelControl25.Text);
                return;
            }

            if (string.IsNullOrEmpty(grd_tipo.Text))
            {
                CajaDialogo.Error("Debe Seleccionar: " + labelControl26.Text);
                return;
            }

            if (Convert.ToDecimal(spTipoporcentaje.EditValue) <= 0)
            {
                CajaDialogo.Error("El % Tipo debe ser entre 1 y 100");
                return;
            }

            //Validemos Cantidad Porcentaje de Especie!
            if (Convert.ToDecimal(spTipoporcentaje.EditValue) + PorcentajeMarino > 100)
            {
                decimal TotalMaximoAceptado = (100 - PorcentajeMarino);
                CajaDialogo.Error("El Porcentaje supera el 100%\nPuede adicionar un Maximo de: "+ TotalMaximoAceptado);
                return;
            }

            if (Convert.ToDecimal(spTipoporcentaje.EditValue) > 100)
            {
                CajaDialogo.Error("El % Tipo debe ser entre 1 y 100");
                return;
            }

            try
            {
                IM = new IngredienteMarino();

                IM.Origen = Convert.ToInt32(grd_origenespecie.EditValue);
                IM.ZonaPesca = Convert.ToInt32(grd_pesca.EditValue);
                IM.Planta = txtPLantaSenasa.Text;
                IM.PorcentajeSustentable = Convert.ToDecimal(spsustentable.EditValue);
                IM.PaisOrigen = Convert.ToInt32(grd_origen.EditValue);
                IM.FishSurse =  hyfishsource.Text;
                IM.IUCN = hyIUCN.Text;
                IM.Tipo = Convert.ToInt32(grd_tipo.EditValue);
                IM.PorcentajeTipo = Convert.ToDecimal(spTipoporcentaje.EditValue);

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}