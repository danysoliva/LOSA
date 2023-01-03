using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.MigracionACS.Ttracer
{
    public partial class TT_shipconfig : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        DataOperations dp = new DataOperations();
        public int Idtoedit;
        public int IdCreate;
        int Tipotrans;
        public string codigoGen;
        public  string  shipname;

        
        string usercode;
        public TT_shipconfig(int i , string usercode)
        {
            InitializeComponent();
            Tipotrans = i;
            this.usercode = usercode;
            if (i == 1)//Nuevo
            {
                load_ship();
                labelControl1.Text = labelControl1.Text + " (Nuevo)";
                codigoGen = dp.Nexcode(5);
                txtcode.Text = codigoGen;


            }
            else
            {
                load_ship();
                labelControl1.Text = labelControl1.Text + " (Editar)";
            }
            
        }
        public TT_shipconfig(string usercode, int IdSelected)
        {
            InitializeComponent();
            load_ship();
            labelControl1.Text = labelControl1.Text + " (Editar)";
            loadinfo(IdSelected);
            this.usercode = usercode;
            Tipotrans = 0;
            this.Idtoedit = IdSelected;
        }
        public void loadinfo(int IdSelected)
        {
            string query = @"SELECT [id] --0
                                  ,[code] --1
                                  ,[quantity] --2
                                  ,[status] --3
                                  ,[date_begin] --4 
                                  ,[date_end] -- 5
                                  ,[peso] --6
                                  ,[enable] --7
                                  ,[close] --8
                                  ,[shipid] --9
                              FROM [dbo].[TS_ship_h]
                              where id = "+IdSelected;
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    btncreate.Text = "Editar";
                    switch (dr[3].ToString())
                    {
                        case "20": //Mandado a un arribo
                            dtini.Enabled = false;
                            dtfin.Enabled = false;
                            break;
                        case "10": //Recien creado
                            tggenable.Visible = true;
                            tggclose.Visible = true;
                            labelControl8.Enabled = true;
                            labelControl9.Enabled = true;
                            tggclose.Enabled = true;
                            tggenable.Enabled = true;

                        break;
                        default:
                            break;
                    }
                    txtcode.Text = Convert.ToString(dr[1]);
                    txtunid.Text = Convert.ToString(dr[2]);
                    dtini.Text = Convert.ToString(dr[4]);
                    dtini.EditValue = Convert.ToDateTime(dr[4]);
                    dtfin.Text = Convert.ToString(dr[5]);
                    dtfin.EditValue = Convert.ToDateTime(dr[5]);
                    txtpeso.Text = Convert.ToString(dr[6]);
                    tggenable.IsOn = Convert.ToBoolean(dr[7]);
                    tggclose.IsOn = Convert.ToBoolean(dr[8]);
                    grdshipmame.EditValue = Convert.ToInt32(dr[9]);
                }
            }
            catch (Exception)
            {

              
            }
        }
        private void panelControl1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void load_ship()
        {
            string Query = @"SELECT [id]
                                    ,[codigo]
                                    ,[descripcion]
                                FROM [dbo].[M_ship]
                                where enable = 1
                                order by 1 desc";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
            cn.Open();
            SqlCommand cmd = new SqlCommand(Query, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dSTtracer.grdOpcion.Clear();
            da.Fill(dSTtracer.grdOpcion);

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtini_EditValueChanged(object sender, EventArgs e)
        {
            if (Tipotrans == 1)
            {
                try
                {
                    if (Convert.ToDateTime(dtini.Text).Date < DateTime.Now.Date)
                    {
                        MessageBox.Show("No se puede hacer una planifñicacion un dia anterior");
                        dtini.Focus();
                    }
                }
                catch (Exception)
                {


                }
            }
           
        }

        private void dtfin_EditValueChanged(object sender, EventArgs e)
        {
            if (Tipotrans == 1)
            {
                try
                {
                    if (Convert.ToDateTime(dtfin.Text).Date < Convert.ToDateTime(dtini.Text).Date)
                    {
                        MessageBox.Show("No se puede guardar la planificacion si la fecha de inicio es menor a la de la final.");
                    }

                }
                catch (Exception)
                {


                }
            }
           
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            if (dtini.Text == "")
            {
                MessageBox.Show("La fecha de inicio no puede quedar vacía.");
                return;
            }
            if (dtfin.Text == "")
            {
                MessageBox.Show("La fecha final del plan no puede quedar vacia");
                return;
            }
            if (txtpeso.Text == "")
            {
                MessageBox.Show("El peso esperado del barco no puede quedar vacío; si no se tiene este dato colocar un aproximado");
                return;
            }
            if (txtunid.Text == "")
            {
                MessageBox.Show("Las unidades del envio no puede estar en cero.");
            }
            string query = @"";
            if (Tipotrans == 1)
            {
                query = @"INSERT INTO [dbo].[TS_ship_h]
                                                               ([code]
                                                               ,[quantity]
                                                               ,[status]
                                                               ,[date_begin]
                                                               ,[date_end]
                                                               ,[date_create]
                                                               ,[peso]
                                                               ,[enable]
                                                               ,[close]
                                                               ,[createby]
                                                               ,[shipid])
                                                         VALUES
                                                               ('" + codigoGen+@"'
                                                               ,"+txtunid.Text+@"
                                                               , 10
                                                               , '"+Convert.ToDateTime(dtini.Text).Date.ToString("MM/dd/yyyy") + @"'
                                                               , '"+ Convert.ToDateTime(dtfin.Text).Date.ToString("MM/dd/yyyy") + @"'
                                                               , '"+DateTime.Now.Date.ToString("MM/dd/yyyy") + @"'
                                                               ,"+txtpeso.Text+@"
                                                               , 1
                                                               , 0
                                                               , "+ usercode + @", "+grdshipmame.EditValue.ToString()+") SELECT SCOPE_IDENTITY()";
            }
            else
            {
                int bitena = 1;
                int bitclo = 1;
                if (tggclose.IsOn)
                {
                    bitclo = 1;
                }
                else
                {
                    bitclo = 0;
                }
                if (tggenable.IsOn)
                {
                    bitena = 1;
                }
                else
                {
                    bitena = 0;
                }
                query = @"UPDATE [dbo].[TS_ship_h]
                                       SET 
                                          [quantity] = "+txtunid.Text+@"
                                          ,[date_begin] = '"+ Convert.ToDateTime(dtini.Text).Date.ToString("MM/dd/yyyy") + @"'
                                          ,[date_end] = '" + Convert.ToDateTime(dtfin.Text).Date.ToString("MM/dd/yyyy") + @"'
                                          ,[peso] = "+txtpeso.Text+@"
                                          ,[enable] = "+bitena+@"
                                          ,[close] = "+bitclo+@"
                                          ,[lastmodby] = "+usercode+ @"
                                          ,[datelastmod] = '" + DateTime.Now.Date.ToString("MM/dd/yyyy") + @"'
                                          ,[shipid] = "+grdshipmame.EditValue+@"
                                     WHERE id = " + Idtoedit;
            }
            
            SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                if (Tipotrans == 1)
                {
                    
                    IdCreate = Convert.ToInt32(cmd.ExecuteScalar());
                    shipname = grdshipmame.Text;
                    dp.updatesecuence(5);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    shipname = grdshipmame.Text;
                    codigoGen = txtcode.Text;
                    MessageBox.Show("Data Actualizada!");
                }
               
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al generar la configuracion. Mensaje de pila" + ex.Message);
            }
           
        }
    }
}
