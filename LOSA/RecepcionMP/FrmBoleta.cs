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
using System.Data.SqlClient;
using LOSA.Clases;
using LOSA.RecepcionMP;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.RecepcionMP
{
    public partial class FrmBoleta : DevExpress.XtraEditors.XtraForm
    {

        DataOperations dp = new DataOperations();
        SqlConnection cnn1 = new SqlConnection();
        private int _idSerie;
        private int _NumBoleta;
        private string _ItemCode;
        private decimal peso_Bascula;
        private string oC;
        private string factura;

        public int IdSerie { get { return _idSerie; } set { _idSerie = value; } }
        public int NumBoleta { get { return _NumBoleta; } set { _NumBoleta = value; } }

        public string ItemCode { get => _ItemCode; set => _ItemCode = value; }
        public decimal Peso_Bascula { get => peso_Bascula; set => peso_Bascula = value; }
        public string OC { get => oC; set => oC = value; }
        public string Factura { get => factura; set => factura = value; }

        public FrmBoleta()
        {
            InitializeComponent();
            //cargarDatos();
        }

        private void simpleButton1_Click(object sender, EventArgs e){ }

       void cargarDatos()
        {
            try
            {
                //Roger
                //SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);

                //string SQL = @"exec sp_getBoletasBascula";

                //dsRecepcionMP.Bascula.Clear();
                //SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);
                //adat.Fill(dsRecepcionMP.Bascula);

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_getBoletasBascula_v2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dsRecepcionMP.Bascula.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMP.Bascula);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvBascula_DoubleClick(object sender, EventArgs e)
        {
            //Seleccion del lote
            //bib
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMPx.BasculaRow)gridView.GetFocusedDataRow();

            this.IdSerie = row.IDSerie;
            this.NumBoleta = row.NBoleta;
            this.ItemCode = row.itemcode;
            this.peso_Bascula = row.peso_prod;
            this.OC = row.oc;
            this.Factura = row.numero_factura;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmBoleta_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}