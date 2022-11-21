using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.Data.Sql;
using System.Data.SqlClient;
using ACS.Classes;


namespace LOSA.MigracionACS.Produccion
{
    public partial class Nuevo_Pedido : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataOperations dp;
        int indice;
        string cap;

        String Numero;

        public int Indice
        {
            get
            {
                return indice;
            }
            set
            {
                indice = value;
            }
        }

        public Nuevo_Pedido()
        {
            InitializeComponent();
            Carga_Actual();
            
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //    dp = new DataOperations();
            //    String Mostrar;
            //    Mostrar = @"select datepart(WEEK,'" + dateDesde.Text + "')";
            //    SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand(Mostrar, con);
            //    string var = Convert.ToString(cmd.ExecuteScalar());
            //    con.Close();
            //    textSemana.Text = var;
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
           


            if (dateDesde.Text == "")
            {
                CajaDialogo.Error("La fecha final no puede estar vacia.");
                return;
            }
            if (dateHasta.Text == "")
            {
                CajaDialogo.Error("La fecha de finalizacion no puede estar vacia.");
                return;
            }
            if (textNumero.Text == "")
            {
                Numero = "NULL";
            }
            else
            {
                Numero = textNumero.Text;
            }  panelControl2.Visible = true;
       
            


        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string Incremento;
            if (cap == textSemana.Text )
            {
                Incremento = @"UPDATE [dbo].[conf_tables_id] 
                                  SET [siguiente] = ([siguiente] + 1) 
                                  WHERE[id] = 5";
            }
            else
            {
                Incremento = @"UPDATE [dbo].[conf_tables_id] 
                                  SET [siguiente] = ("+textSemana.Text+")"
                                  +"WHERE[id] = 5";

            }
            try
            {
                string Qry;
                dp = new DataOperations();
                Qry = @"INSERT INTO [dbo].[PT_Pedido]
                                   ([fecha_ini]
                                   ,[fecha_fin]
                                   ,[Numero]
                                   ,[enable]
                                   ,[semana_num]
                                   )
                             VALUES
                                   ('" + string.Format("{0:MM/dd/yyyy}", dateDesde.EditValue) + "', '"+
                                    string.Format("{0:MM/dd/yyyy}", dateHasta.EditValue)+"' " +
                                    "," + Numero + "," +
                                        "1," +
                                         textSemana.Text+") SELECT SCOPE_IDENTITY()";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Qry, cn);
                Indice = Convert.ToInt32(cmd.ExecuteScalar());

          
                
                 
                  
                    cmd = new SqlCommand(Incremento, cn);
                    cmd.ExecuteNonQuery();


                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
           
           
        }
        void Carga_Actual()
        {
            try
            {string Quuery;
            Quuery = @"Select siguiente
					        from .dbo.conf_tables_id
					        where id = 5";
            dp = new DataOperations();
            SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
            con.Open();
            SqlCommand cmd = new SqlCommand(Quuery, con);
            cap = Convert.ToString(cmd.ExecuteScalar());
            textSemana.Text = cap;

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }
            
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void Nuevo_Pedido_Load(object sender, EventArgs e)
        {

        }
    }
}