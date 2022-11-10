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
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.RecepcionMP
{
    public partial class frmSeleccionrLoteExterno : DevExpress.XtraEditors.XtraForm
    {
        int id_externo = 0;
        DataOperations dp = new DataOperations();
        public string lote;
        public string Itemcode;
        public string Itemname;
        public string cardcode;
        public string cardname;
        public Decimal LimiteKG;
        public DateTime fproduccion;
        public DateTime fvencimiento;
        public int id_lote_externo;
        public int id_mp;
        public frmSeleccionrLoteExterno(int Pid_externo)
        {
            InitializeComponent();
            id_externo = Pid_externo;
            load_data();


        }
        public frmSeleccionrLoteExterno(int Pid_externo, int pid_mp)
        {
            InitializeComponent();
            id_externo = Pid_externo;
            id_mp = pid_mp;
            load_data_forMP();

           
        }

        public void load_data_forMP()
        {
            string query = @"sp_lotes_in_ingreso_externo_forid_mp";
            DataOperations dp = new DataOperations();
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@id_ingreso_Externo", id_externo);
            cmd.Parameters.AddWithValue("@id_mp", id_mp);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dsWizard.verLotes.Clear();
            da.Fill(dsWizard.verLotes);
            cn.Close();
        }

        public void load_data()
        {
            string query = @"sp_lotes_in_ingreso_externo";
            DataOperations dp = new DataOperations();
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_ingreso_Externo", id_externo);
            //cmd.Parameters.AddWithValue("@id_mp", id_mp);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dsWizard.verLotes.Clear();
            da.Fill(dsWizard.verLotes);
            cn.Close();
        }

        public void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsWizard.verLotesRow)gridView.GetFocusedDataRow();
                lote = row.lote;
                Itemcode = row.code_sap;
                Itemname = row.nombre_comercial;
                cardcode = row.cardcode;
                cardname = row.proveedor;
                fproduccion = row.fecha_produccion;
                fvencimiento = row.fecha_vencimiento;
                LimiteKG = row.Existencia;
                id_lote_externo = row.id;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void grdv_data_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsWizard.verLotesRow)gridView.GetFocusedDataRow();
                lote = row.lote;
                Itemcode = row.code_sap;
                Itemname = row.nombre_comercial;
                cardcode = row.cardcode;
                cardname = row.proveedor;
                fproduccion = row.fecha_produccion;
                fvencimiento = row.fecha_vencimiento;
                LimiteKG = row.Existencia;
                id_lote_externo = row.id;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
            }
        }
    }
}