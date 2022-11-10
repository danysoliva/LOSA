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

namespace LOSA.MicroIngredientes
{
    public partial class xfrmAlimentacionTarimaArriba : DevExpress.XtraEditors.XtraForm
    {
        int order_id;

        public xfrmAlimentacionTarimaArriba()
        {
            InitializeComponent();
            LoadHeader();
            LoadData();
            LoadData2();
            timer1.Enabled = true;
        }

        public void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("dbo.sp_load_micros_ordenes_mix", cnx);

                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        //Mix1
                        if (dr.GetInt32(4)==1 && dr.GetInt32(0)==1)
                        {
                            txtMix1.Text = dr.GetInt32(0).ToString();
                            txtMix1.BackColor = Color.ForestGreen;

                            txtOrden1.Text = dr.GetString(1);
                            txtOrden1.BackColor = Color.ForestGreen;

                            txtLotePT1.Text = dr.GetInt64(2).ToString();
                            txtLotePT1.BackColor = Color.ForestGreen;

                            txtProducto1.Text = dr.GetString(3).ToString();
                            txtProducto1.BackColor = Color.ForestGreen;
                        }

                        if (dr.GetInt32(4) == 0 && dr.GetInt32(0) == 1)
                        {
                            txtOrden1.Text = "";
                            txtOrden1.BackColor = Color.White;

                            txtLotePT1.Text = "";
                            txtLotePT1.BackColor = Color.White;

                            txtProducto1.Text = "";
                            txtProducto1.BackColor = Color.White;

                            txtMix1.Text = "1";
                            txtMix2.Text = "2";
                        }


                        //Mix 2

                        if (dr.GetInt32(4) == 1 && dr.GetInt32(0) == 2)
                        {
                            txtMix2.Text = dr.GetInt32(0).ToString();
                            txtMix2.BackColor = Color.ForestGreen;

                            txtOrden2.Text = dr.GetString(1);
                            txtOrden2.BackColor = Color.ForestGreen;

                            txtLotePT2.Text = dr.GetInt64(2).ToString();
                            txtLotePT2.BackColor = Color.ForestGreen;

                            txtProducto2.Text = dr.GetString(3).ToString();
                            txtProducto2.BackColor = Color.ForestGreen;
                        }

                        if (dr.GetInt32(4) == 0 && dr.GetInt32(0) == 2)
                        {
                            txtOrden2.Text = "";
                            txtOrden2.BackColor = Color.White;

                            txtLotePT2.Text = "";
                            txtLotePT2.BackColor = Color.White;

                            txtProducto2.Text = "";
                            txtProducto2.BackColor = Color.White;

                            txtMix1.Text = "1";
                            txtMix2.Text = "2";
                        }
                    }

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
 
            }
        }

        private void LoadData2()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.plan_microsh_report.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("[sp_get_detalle_orden_pesaje_micros_interfacev2_to_reprint]", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@orden_id", SqlDbType.Int).Value = order_id;
                    da.Fill(dsMicros.plan_microsh_report);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadHeader()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.Micros.Clear();
                    SqlCommand cmd = new SqlCommand("sp_get_ordenes_pesaje_manual_interface_V6", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@vertodas", toggleSwitch1.IsOn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                      order_id = dr.GetInt32(0);
                      
                    }
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

        private void txtCodBarra_KeyDown(object sender, KeyEventArgs e)
        {
            AlimentacionTolvaMicrosPesaje alimentacionTolva = new AlimentacionTolvaMicrosPesaje();
            xfrmMezclaMicroShow frm = new xfrmMezclaMicroShow(1169, Convert.ToInt32(txtCodBarra.Text));
            //xfrmMezclaMicroShow frm = new xfrmMezclaMicroShow( order_id,Convert.ToInt32(txtCodBarra.Text));

            try
            {
                if (alimentacionTolva.RecuperaRegistro(Convert.ToInt32(txtCodBarra.Text), order_id))
                {
                    frm.ShowDialog();

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void txtCodBarra_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
