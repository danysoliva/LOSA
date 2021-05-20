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
using ACS.Classes;
using LOSA.Clases;
using System.Data.SqlClient;

namespace LOSA.RecepcionMP
{
    public partial class frm_edit_data : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int Id_ingreso;
        public string Itemcode;
        public string Dscripcion;
        public string pv;
        public string cardcode;
        public frm_edit_data(int Pingreso)
        {
            InitializeComponent();
            Id_ingreso = Pingreso;
            load_data();
        }

        public void load_data()
        {
            string query = @"sp_load_info_ingreso_to_edit";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso" , Id_ingreso);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Itemcode = dr.GetString(1);
                    Dscripcion = dr.GetString(2);
                    pv = dr.GetString(3);
                    cardcode = dr.GetString(4);
                    txtBoleta.Text = dr.GetInt32(5).ToString();
                    txtmp.Text = Dscripcion;
                    txtproveedor.Text = pv;
                }

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfindMP_EditValueChanged(object sender, EventArgs e)
        {
            frmMP frm = new frmMP();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Itemcode = frm.ItemCode;
                Dscripcion = frm.MateriaPrima;
                txtmp.Text = Dscripcion;
            }
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {
            frm_select_pv frm = new frm_select_pv();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                pv = frm.pv;
                cardcode = frm.Cardcode;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmp.Text == "")
                {
                    CajaDialogo.Error("Debe seleccionar una materia prima.");
                    return;
                }
                if (txtproveedor.Text == "")
                {
                    CajaDialogo.Error("Debe seleccionar un proveedor.");
                    return;
                }
                if (txtBoleta.Text == "")
                {
                    CajaDialogo.Error("La boleta no puede quedar vacia.");
                    return;
                }

                string query = @"sp_update_data_ingreso_header";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn );
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id" , Id_ingreso);
                cmd.Parameters.AddWithValue("@itemcode", Itemcode);
                cmd.Parameters.AddWithValue("@dscripcion", Dscripcion);
                cmd.Parameters.AddWithValue("@pv", pv);
                cmd.Parameters.AddWithValue("@cardcode", cardcode);
                cmd.Parameters.AddWithValue("@boleta", txtBoleta.Text);
                cmd.ExecuteNonQuery();
                CajaDialogo.Information("Cambio realizado.!");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnfindMP_Click(object sender, EventArgs e)
        {
            frmMP frm = new frmMP();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Itemcode = frm.ItemCode;
                Dscripcion = frm.MateriaPrima;
                txtmp.Text = Dscripcion;
            }
        }

        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            frm_select_pv frm = new frm_select_pv();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                pv = frm.pv;
                cardcode = frm.Cardcode;
            }
        }
    }
}