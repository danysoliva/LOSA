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

namespace LOSA.Logistica
{
    public partial class frmLotesXMP : Form
    {
        DataOperations dp = new DataOperations();
        public frmLotesXMP()
        {
            InitializeComponent();
            cargarMateriaPrima();
            //cargarDatosTarimas();
            cbMateriaPrima.Enabled = true;
        }

        public frmLotesXMP(string SAPCODE_MP)
        {
            InitializeComponent();
            cargarMateriaPrima();
            //cargarDatosTarimas();
            cbMateriaPrima.Enabled = false;
            //MateriaPrima mp = new MateriaPrima();
            //if (mp.RecuperarRegistroFromCode(SAPCODE_MP))
            //{
                cbMateriaPrima.EditValue = SAPCODE_MP;
                //cbMateriaPrima.Text = mp.Name;
                cargarDatosTarimas();
            //}
        }

        private void cargarDatosTarimas(int pidmp)
        {
            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_lotes_by_MP_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", pidmp);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsLogistica.LotesXProveedor.Clear();
                adat.Fill(dsLogistica.LotesXProveedor);
                con.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cargarDatosTarimas()
        {
            try
            {
                    
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_lotes_by_MP_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", cbMateriaPrima.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsLogistica.LotesXProveedor.Clear();
                adat.Fill(dsLogistica.LotesXProveedor);
                con.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cargarMateriaPrima()
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL = @"exec sp_get_list_MP_by_tarima";

                dsLogistica.Materia_prima_v2.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);

                adat.Fill(dsLogistica.Materia_prima_v2);
                cn.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLotesXMP_Load(object sender, EventArgs e)
        {
            gvLotes.Columns[1].GroupIndex = 1;
        }

        private void cbMateriaPrima_EditValueChanged(object sender, EventArgs e)
        {
            //gvLotes.ActiveFilterString = "[itemcode] = '" + cbMateriaPrima.EditValue + "'";
            cargarDatosTarimas();
        }
    }
}
