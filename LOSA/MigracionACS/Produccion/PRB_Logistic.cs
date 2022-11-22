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
using ACS.Classes;
using LOSA.Clases;

namespace LOSA.MigracionACS.Produccion
{
    public partial class PRB_Logistic : DevExpress.XtraEditors.XtraForm
    {
        int Varid;
        DataOperations dp;
        int SelectedId;
        public PRB_Logistic(int Parid, int SelectedId)
        {
            this.SelectedId = SelectedId;
            InitializeComponent();
            dp = new DataOperations();
            Varid = Parid;
            load();
        }

        private void PRB_Logistic_Load(object sender, EventArgs e)
        {
                
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Si no se ha guardado los datos se perderan.","Se va cerrar el formulario.",MessageBoxButtons.YesNo,MessageBoxIcon.Information)== DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string conformes;
            if (txtconfor.Text == "")
            {
                MessageBox.Show("Sacos no validos");
                txtconfor.Focus();
                return;

            }
            else
            {
                conformes = txtconfor.Text;
            }
            try
            {
                string Query;
                Query = @"UPDATE [dbo].[PRB_Registro_D]
                                       SET [bag_conf] = " + conformes + @"
                            WHERE id = " + Varid;
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.ExecuteNonQuery();
                string queryup;
                queryup = @"UPDATE [dbo].[PRB_Registro_H]
                                    set
                                        [estatus] = 50
                                    where id = " + SelectedId;
                cmd = new SqlCommand(queryup, cn);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Operacion exitosa!");
                int idH = 0, lote = 0, bag_prod = 0, prod_noconf = 0, total = 0, bag_conf =0;
                decimal reproceso = 0;
                SecOps sec = new SecOps();
                string MainData;
                MainData = @"Select a.id_h
                                    ,a.lote
                                    ,a.bag_prod
                                    ,a.prod_noconf
                                    ,a.reproceso
                                    ,a.bag_conf
                                    from ACS.dbo.PRB_Registro_D a join
                                    ACS.dbo.PRB_Registro_H b on
                                    a.id_h = b.id
                                    where a.id = " + Varid;
                cmd = new SqlCommand(MainData, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    idH = dr.GetInt32(0);
                    lote = dr.GetInt32(1);
                    bag_prod = dr.GetInt32(2);
                    prod_noconf = dr.GetInt32(3);
                    reproceso = dr.GetDecimal(4);
                    bag_conf = dr.GetInt32(5);
                }
                dr.Close();
                total = bag_prod - prod_noconf;
                if (total != bag_conf)
                {
                    string recibes; // Colectar los que reciben el correo.
                    recibes = @"SELECT 
		                [mail]  
                  FROM [dbo].[conf_destinatarios]
                  where prb_alert_pt_variation = 1";
                    cmd = new SqlCommand(recibes, cn);
                    DataTable receivers;
                    receivers = new DataTable();
                    receivers.Columns.Add("mail", typeof(String));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(receivers);
                    //=================================================
                    string MessageBody;
                    MessageBody = @"<p>=======================Main ACS========================
                    <br />Se a detectado una diferencia en Producto terminado. identificador de registro: "+idH+@"
                    <br />Fecha actual= "+DateTime.Today+@"
                    <br />&nbsp;&nbsp; &nbsp;- Numero de lote: "+lote+@"
                    <br />&nbsp;&nbsp; &nbsp;- Numero de Registro: "+Varid+@"
                    <br />&nbsp;&nbsp; &nbsp;- Cantidad ingresada por logistica: "+bag_conf+@"
                    <br />&nbsp;&nbsp; &nbsp;- resta de lo ingresado por produccion y calidad: "+total+@"
                    <br />&nbsp;&nbsp; &nbsp;- Diferencia: "+(total - bag_conf)+@"</p>";

                    sec.SendEmailAlert_GD(receivers, 0, "Alerta - En varicion de producto terminado recibido", MessageBody, true, System.Net.Mail.MailPriority.High);
                    this.DialogResult = DialogResult.Yes;
                    this.Close();


                }
                else
                {
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }


               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        public void load()
        {
            try
            {
                string Query;
                Query = @"SELECT
                              coalesce([bag_conf], 0) as bag_conf
                          FROM [dbo].[PRB_Registro_D]
                          where id = " + Varid;
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                   
                        txtconfor.Text = dr.GetInt32(0).ToString();
                     
                   
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txtnoconfor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}