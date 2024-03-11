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
using System.Data.SqlClient;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.Produccion.Eficiencia
{
    public partial class frm_seleccion_tarimas : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public string lote;
        decimal disponible;
        decimal requerida;
        public decimal cant;
        public DataTable Result;
        public frm_seleccion_tarimas(string Plote, DataTable Pdt)
        {
            InitializeComponent();
            lote = Plote;
            txtlote.Text = lote;
            Load_data();
            Recargarconf(Pdt);

        }

        public void Recargarconf(DataTable X) 
        {
            decimal aux = 0;
            foreach (DataRow rw in X.Rows)
            {
                foreach (dsLotePick.tarimasRow row in dsLotePick.tarimas.Rows)
                {
                    if (Convert.ToInt32(rw["id_tm"]) == row.id)
                    {
                        row.selecionado = true;
                        aux = aux + row.cantidad;
                    }
                }
            }
            txtselecionada.Text = aux.ToString();
        }
         public void Load_data() 
        {
            string query = @"sp_obtener_lotes_por_seleccionar";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", lote);
                dsLotePick.tarimas.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsLotePick.tarimas);
                disponible = 0;
                foreach (dsLotePick.tarimasRow row in dsLotePick.tarimas.Rows)
                {
                    disponible = disponible + row.cantidad;
                }
                txtdisponible.Text = disponible.ToString();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
            
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chAutoseleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chAutoseleccionar.Checked)
            {
                if (txtcantidad.Text == "0")
                {
                    CajaDialogo.Error("Debe ingresar una cantidad requerida.");
                    chAutoseleccionar.Checked = false;
                    txtcantidad.Focus();
                    return;

                }
                try
                {
                    requerida = Convert.ToDecimal(txtcantidad.Text);
                    decimal aux = 0;
                    foreach (dsLotePick.tarimasRow row in dsLotePick.tarimas.Rows)
                    {
                        if (aux < requerida)
                        {
                            row.selecionado = true;
                            aux = aux + row.cantidad;
                        }
                    }
                    cant = aux;
                    txtselecionada.Text = cant.ToString();
                    aux = 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }

            }
            else
            {
                decimal aux = 0;
                foreach (dsLotePick.tarimasRow row in dsLotePick.tarimas.Rows)
                {
                    row.selecionado = false;
                }
                cant = aux;
                txtselecionada.Text = cant.ToString();
                aux = 0;
            }
        }

        private void chtodas_CheckedChanged(object sender, EventArgs e)
        {
            if (chtodas.Checked)
            {
                decimal aux = 0;
                foreach (dsLotePick.tarimasRow row in dsLotePick.tarimas.Rows)
                {

                    row.selecionado = true;
                    aux = aux + row.cantidad;

                }
                cant = aux;
                txtselecionada.Text = cant.ToString();
                aux = 0;
            }
            else
            {
                decimal aux = 0;
                foreach (dsLotePick.tarimasRow row in dsLotePick.tarimas.Rows)
                {

                    row.selecionado = false;


                }
                cant = aux;
                txtselecionada.Text = cant.ToString();
                aux = 0;
            }
        }

        private void grdv_data_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsLotePick.tarimasRow)gridView.GetDataRow(e.RowHandle);
            if (e.RowHandle >= 0)
            {

                if (row.selecionado)
                {
                    e.Appearance.BackColor = Color.FromArgb(77, 201, 176);

                }
                else
                {
                    e.Appearance.BackColor = Color.FromArgb(240, 240, 240);
                }
            }
        }

        private void grdv_data_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colselecionado")
                {
                    var gridView = (GridView)grd_data.FocusedView;
                    var row = (dsLotePick.tarimasRow)gridView.GetDataRow(e.RowHandle);
                    row.selecionado = Convert.ToBoolean(e.Value);
                    if (Convert.ToBoolean(e.Value))
                    {
                        cant = cant + row.cantidad;
                    }
                    else
                    {
                        cant = cant - row.cantidad;
                    }
                    txtselecionada.Text = cant.ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            Result = dsLotePick.tm;
            Result.AcceptChanges();
            foreach (dsLotePick.tarimasRow row in dsLotePick.tarimas.Rows)
            {
                if (row.selecionado)
                {

                    DataRow rw = Result.NewRow();
                    rw["id_tm"] = row.id;
                    rw["lote"] = lote;
                    Result.Rows.Add(rw);
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}