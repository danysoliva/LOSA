using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.TransaccionesMP;
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

namespace LOSA.Calidad
{
    public partial class frmBuscarDatosBascula : DevExpress.XtraEditors.XtraForm
    {
        public ArrayList ListaDatos;
        public frmBuscarDatosBascula(string pPlacaFurgon, int pIdserieBoleta, string pplaca_vehiculo)
        {
            InitializeComponent();
            ListaDatos = new ArrayList();
            LoadData(pPlacaFurgon, pIdserieBoleta,pplaca_vehiculo);
        }

        private void LoadData(string pPlacaFurgon, int p_idserie, string p_placa_vehiculo)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_ultimos_ingresos_por_furgon", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@placa_furgon", pPlacaFurgon);
                cmd.Parameters.AddWithValue("@id_serie", p_idserie);
                cmd.Parameters.AddWithValue("@placa_vehiculo", p_placa_vehiculo);
                dsTarima1.ultimas_cargasSelect.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTarima1.ultimas_cargasSelect);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gridView6_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var gridView = (GridView)gridControl3.FocusedView;
                //var row = (dsNotas.notas_resumenRow)gridView.GetFocusedDataRow();
                var row = (dsTarima.ultimas_cargasSelectRow)gridView.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    if (row.Row == 2|| row.Row == 3|| row.Row == 4)
                        e.Appearance.BackColor = Color.FromArgb(0, 204, 204);
                    else
                        e.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                    
                }
            }
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            foreach(dsTarima.ultimas_cargasSelectRow row in dsTarima1.ultimas_cargasSelect.Rows)
            {
                if (ListaDatos == null)
                    ListaDatos = new ArrayList();

                if (row.Row == 2 || row.Row == 3 || row.Row == 4)
                {
                    ListaDatos.Add(row.descripcion);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}