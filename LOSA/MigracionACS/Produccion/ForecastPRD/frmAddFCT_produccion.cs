using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace LOSA.MigracionACS.Produccion.ForecastPRD
{
    public partial class frmAddFCT_produccion : DevExpress.XtraEditors.XtraForm
    {
        public int Mes = 0;
        public int Anio = 0;

        public object Especie { get; }

        public frmAddFCT_produccion(int pmes, int panio)
        {
            InitializeComponent();
            Mes = pmes;
            Anio = panio;
            comboBox2.Text = panio.ToString();
            SetMes();
            if(Especie!=null)
                LoadProductos();
        }

        public frmAddFCT_produccion(int pmes, int panio, object editValue) : this(pmes, panio)
        {
            Especie = editValue;
            LoadProductos();
        }

        private void SetMes()
        {
            switch (Mes)
            {
                case 1:
                    comboBox1.Text = "Enero";
                    break;
                case 2:
                    comboBox1.Text = "Febrero";
                    break;
                case 3:
                    comboBox1.Text = "Marzo";
                    break;
                case 4:
                    comboBox1.Text = "Abril";
                    break;
                case 5:
                    comboBox1.Text = "Mayo";
                    break;
                case 6:
                    comboBox1.Text = "Junio";
                    break;
                case 7:
                    comboBox1.Text = "Julio";
                    break;
                case 8:
                    comboBox1.Text = "Agosto";
                    break;
                case 9:
                    comboBox1.Text = "Septiembre";
                    break;
                case 10:
                    comboBox1.Text = "Octubre";
                    break;
                case 11:
                    comboBox1.Text = "Noviembre";
                    break;
                case 12:
                    comboBox1.Text = "Diciembre";
                    break;
                default:
                    Mes = 0;
                    break;
            }
        }

        private void LoadProductos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_pt_list_fct_prd_v2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mes", Mes);
                cmd.Parameters.AddWithValue("@anio", Anio);
                cmd.Parameters.AddWithValue("@especie", Especie);
                dsFCT_PRD1.new_prodmast.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsFCT_PRD1.new_prodmast);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "tm")
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsFCT_PRD.new_prodmastRow)gridView.GetFocusedDataRow();

                if (row.tm > 0)
                {
                    dsFCT_PRD.new_prodRow row1 = dsFCT_PRD1.new_prod.Newnew_prodRow();
                    row1.tm = row.tm;
                    row1.codeodoo = row.codeodoo;
                    row1.codesap = row.codesap;
                    row1.idpt = row.idpt;
                    row1.name = row.name;
                    dsFCT_PRD1.new_prod.Addnew_prodRow(row1);
                    dsFCT_PRD1.AcceptChanges();
                }
            }
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            if(Mes==0 || Anio == 0)
            {
                CajaDialogo.Error("Es necesario ingresar el mes y el año!");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Enero":
                    Mes = 1;
                    break;
                case "Febrero":
                    Mes = 2;
                    break;
                case "Marzo":
                    Mes = 3;
                    break;
                case "Abril":
                    Mes = 4;
                    break;
                case "Mayo":
                    Mes = 5;
                    break;
                case "Junio":
                    Mes = 6;
                    break;
                case "Julio":
                    Mes = 7;
                    break;
                case "Agosto":
                    Mes = 8;
                    break;
                case "Septiembre":
                    Mes = 9;
                    break;
                case "Octubre":
                    Mes = 10;
                    break;
                case "Noviembre":
                    Mes = 11;
                    break;
                case "Diciembre":
                    Mes = 12;
                    break;
                default:
                    Mes = 0;
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Anio = Convert.ToInt32(comboBox2.Text);
            }
            catch { Anio = 0; }
        }
    }
}