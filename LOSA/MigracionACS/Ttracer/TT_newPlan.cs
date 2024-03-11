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
using System.Data.SqlClient;


namespace LOSA.MigracionACS.Ttracer
{
    public partial class TT_newPlan : Form
    {
        int withship = 0;
       public int IdGenerado;
        string usercode;
        string tcodigoGen;
        DataOperations dp = new DataOperations();
        public TT_newPlan(string usercode)
        {
            InitializeComponent();
            tcodigoGen = dp.Nexcode(3);
            txtCodigo.Text = tcodigoGen;
            this.usercode = usercode;
        }
        public void load_ship()
        {
            try
            {

                string Query = @"Select 
	                                T2.descripcion as Nbarco
	                                ,T1.id as idplan
	                                ,T2.codigo as CodigoB
	                                ,T1.date_begin as dtini
	                                ,T1.date_create as dtfin
                                From TS_ship_h T1 join M_ship T2 on T1.shipid = T2.id
                                where T1.enable = 1 and t2.enable = 1 and t1.[close] = 0
                                and T1.date_begin between '" + Convert.ToDateTime(dtinicio.Text).ToString("yyyy-MM-dd")+@"'
                                and '"+Convert.ToDateTime(dtfin.Text).ToString("yyyy-MM-dd")+@"'";
                
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dSTtracer.shipArrib.Clear();
                    da.Fill(dSTtracer.shipArrib);

                
            }
            catch (Exception ex)
            {
            //    MessageBox.Show("Error al cargar los datos del plan de barco. Mensaje de pila: " + ex.Message);
                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (tggwithship.IsOn)
            {
                withship = 1;
                grdship.Enabled = true;
            }
            else
            {
                withship = 0;
                grdship.Enabled = false;
                grdship.EditValue = DBNull.Value;
            }
        }

        private void dtinicio_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtinicio.Text).Date < DateTime.Now.Date )
            {
                MessageBox.Show("La fecha de inicio no puede ser menor a la fecha actual.");
                dtinicio.Focus();

            }
            else
            {
                load_ship();
            }
        }

        private void dtfin_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtfin.Text).Date < Convert.ToDateTime(dtinicio.Text).Date)
            {
                MessageBox.Show("La fecha final no puede ser menor a la fecha de inicio.");
                dtfin.Focus();

            }
            else
            {
                load_ship();
            }

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string texto;
            #region V A L I D A C I O N E S
            if (withship == 1)
            {//Con barco
                if (grdship.EditValue == null)
                {
                    MessageBox.Show("Tiene la opcion de que tiene un barco asignado, pero no seleccion ninguno"
                        , "Advertencia" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grdship.Focus();
                    return;
                }
                if (dtinicio.Text == "")
                {
                    MessageBox.Show("La fecha de inicio no puede ir en blanco.");
                    return;
                }
                if (dtfin.Text == "")
                {
                    MessageBox.Show("La fecha final no puede quedar en blanco");
                }
                if (txtpesoaprox.Text == "")
                {
                    MessageBox.Show("Debe colocar almenos una cantidad.");
                }
                if (txtcomment.Text == "")
                {
                    texto = "";
                }
                else
                {
                    texto = txtcomment.Text;
                }
                try
                {
                    string Query = @"INSERT INTO [dbo].[DC_workplan_h]
                                               ([codigo]
                                               ,[withship]
                                               ,[shipid]
                                               ,[date_create]
                                               ,[date_inicio]
                                               ,[date_fin]
                                               ,[close]
                                               ,[comment]
                                               ,[tonaprox]
                                               ,[enable])
                                         VALUES
                                               ('"+ txtCodigo.Text+ @"'
                                               ,1
                                               ,"+grdship.EditValue+@"
                                               ,GETDATE()
                                               ,'"+ Convert.ToDateTime(dtinicio.Text).ToString("yyyy-MM-dd") + @"'
                                               ,'"+ Convert.ToDateTime(dtfin.Text).ToString("yyyy-MM-dd") + @"'
                                               ,0
                                               ,'"+txtcomment.Text+@"'
                                               ,"+txtpesoaprox.Text+@"
                                               ,1) Select SCOPE_IDENTITY();";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    IdGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                    cn.Close();
                    dp.updatesecuence(3);
                    this.DialogResult = DialogResult.OK;
                    this.Close();



                }
                catch (Exception)
                {

                   
                }
            }
            else
            {//Sin barco
                if (dtinicio.Text == "")
                {
                    MessageBox.Show("La fecha de inicio no puede ir en blanco.");
                    return;
                }
                if (dtfin.Text == "")
                {
                    MessageBox.Show("La fecha final no puede quedar en blanco");
                }
                if (txtpesoaprox.Text == "")
                {
                    MessageBox.Show("Debe colocar almenos una cantidad.");
                }
                if (txtcomment.Text == "")
                {
                    texto = "";
                }
                else
                {
                    texto = txtcomment.Text;
                }
                try
                {
                    string Query = @" INSERT INTO [dbo].[DC_workplan_h]
                                                       ([codigo]
                                                       ,[withship]
                                                       ,[date_create]
                                                       ,[date_inicio]
                                                       ,[date_fin]
                                                       ,[close]
                                                       ,[comment]
                                                       ,[tonaprox]
                                                       ,[enable])
                                                 VALUES
                                                       ('"+txtCodigo.Text+@"'
                                                       ,0
                                                       ,SYSDATETIME()
                                                       ,'"+ Convert.ToDateTime(dtinicio.Text).ToString("yyyy-MM-dd") + @"'
                                                       ,'"+ Convert.ToDateTime(dtfin.Text).ToString("yyyy-MM-dd") + @"'
                                                       ,0
                                                       ,'"+txtcomment.Text+@"'
                                                       ,"+txtpesoaprox.Text+@"
                                                       ,1) SELECT SCOPE_IDENTITY()";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                    cn.Open();
                    SqlCommand cmmd = new SqlCommand(Query, cn);
                    IdGenerado = Convert.ToInt32(cmmd.ExecuteScalar());
                    MessageBox.Show("Creado Exitosamente.");
                    cn.Close();

                    dp.updatesecuence(3);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception)
                {

                }

           
            }
            #endregion
        }
    }
}
