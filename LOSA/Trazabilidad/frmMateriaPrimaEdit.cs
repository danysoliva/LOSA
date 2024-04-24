using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace LOSA.Trazabilidad
{
    public partial class frmMateriaPrimaEdit : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int IdMP;
        public frmMateriaPrimaEdit(int pidMP)
        {
            InitializeComponent();

            IdMP = pidMP;

            loadOrigen();

            MateriaPrima mp = new MateriaPrima();

            mp.RecuperarRegistroFromID_MP(IdMP);

            txtCodigoSAP.Text = mp.CodeMP_SAP;
            txtNombreComercial.Text = mp.NameComercial;
            txtTipoMP.Text = mp.TipoMp;

            txtUniteId.EditValue = mp.UniteId;
            grdTipoOrigen.EditValue = mp.TipoOrigen;
            if (mp.ValidacionLotes == true)
                tsGestionLoteVen.IsOn = true;
            else
                tsGestionLoteVen.IsOn = false;

        }

        private void loadOrigen()
        {
            try
            {
                string query = @"sp_mp_get_origen_mp";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMantoTrazabilidad1.OrigenMP.Clear();
                adat.Fill(dsMantoTrazabilidad1.OrigenMP);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grdTipoOrigen.Text))
            {
                CajaDialogo.Error("Debe seleccionar el Origen de la MP!");
                return;
            }

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_update_mp_materia_prima_info_calidad", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UniteID",txtUniteId.Text.Trim());
                cmd.Parameters.AddWithValue("@TipoOrigen",grdTipoOrigen.EditValue);
                if(tsGestionLoteVen.IsOn)
                    cmd.Parameters.AddWithValue("@Gestion_lote_vencimiento", 1);
                else
                    cmd.Parameters.AddWithValue("@Gestion_lote_vencimiento", 0);
                cmd.Parameters.AddWithValue("@IdMP", IdMP);
                cmd.ExecuteNonQuery();
                conn.Close();

                CajaDialogo.Information("MP Actualizado con Exito!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

    }
}