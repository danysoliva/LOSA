using ACS.Classes;
using LOSA.MigracionACS.Produccion.DataSet_;
using DevExpress.XtraGrid.Views.Grid;
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

namespace LOSA.MigracionACS.Produccion.Eficiencia
{
    public partial class frmHorasPorPeriodioMaquinas : Form
    {
        public int Id1;
        public int Id2;
        public int Id3;
        public decimal Horas1;
        public decimal Horas2;
        public decimal Horas3;

        private DateTime fechai;
        private DateTime fechaf;

        public frmHorasPorPeriodioMaquinas(DateTime pDesde, DateTime phasta)
        {
            InitializeComponent();
            fechai = pDesde;
            fechaf = phasta;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                //var gridView = (GridView)gridControl1.FocusedView;
                //var row = (dsReportesPRD.horas_maquinaRow)gridView.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_hour_work_machine_v3", con);
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", fechai);
                cmd.Parameters.AddWithValue("@hasta", fechaf);
                //cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                dsReportesPRD1.horas_maquina.Clear();
                SqlDataAdapter adat1 = new SqlDataAdapter(cmd);
                adat1.Fill(dsReportesPRD1.horas_maquina);
                //cmd.ExecuteNonQuery();
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

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            //foreach select all
            //var gridView = (GridView)gridControl1.FocusedView;
            //var row = (dsMensualidades.mensualidadesRow)gridView.GetFocusedDataRow();
            var gridView1 = (GridView)gridControl1.FocusedView;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                row["colSeleccionar"] = chkSelectAll.Checked;
            }
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            var gridView1 = (GridView)gridControl1.FocusedView;

            bool continuar = false;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                //int id = Convert.ToInt32(row["id"]);
                try
                {
                    continuar = Convert.ToBoolean(row["colSeleccionar"]);
                }
                catch
                {
                    continuar = false;
                }
                
                if (continuar)
                    break;
            }

            if (!continuar)
            {
                CajaDialogo.Error("No se puede aplicar el cambio, debe seleccionar una maquina!");
                return;
            }

            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                //int id = Convert.ToInt32(row["id"]);
                int id_m = Convert.ToInt32(row["id_maquina"]);
                bool Seleccion = false;
                try
                {
                    Seleccion = Convert.ToBoolean(row["colSeleccionar"]);
                }
                catch
                {
                    Seleccion = false;
                }

                if (Seleccion)
                {
                    switch (id_m)
                    {
                        case 1:
                            Id1 = Convert.ToInt32(row["id"]);
                            Horas1 = Convert.ToDecimal(row["horas"]);
                            break;
                        case 2:
                            Id2 = Convert.ToInt32(row["id"]);
                            Horas2 = Convert.ToDecimal(row["horas"]);
                            break;
                        case 3:
                            Id3 = Convert.ToInt32(row["id"]);
                            Horas3 = Convert.ToDecimal(row["horas"]);
                            break;
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmHorasPorPeriodioMaquinas_Load(object sender, EventArgs e)
        {

        }
    }
}
