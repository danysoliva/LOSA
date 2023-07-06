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
using ACS.Classes;
using System.Data.SqlClient;
using LOSA.Clases;

namespace LOSA.MigracionACS.PT
{
    public partial class frmNewProductoUniversal : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp;
        string indiceFam, indiceCat, indiceBag, indiceTam;

        public frmNewProductoUniversal(string ActiveUserCode, string ActiveUserName, string ActiveUserType)
        {
            InitializeComponent();
            dp = new DataOperations();
            spindDiasVenc.EditValue = 150;
            spinDiasMinimos.EditValue = 60;
           
        }
        

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
           
            this.Close();
        }

        private void frmNewProductoUniversal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aCSDataSet2.PT_Productos_Familias' Puede moverla o quitarla según sea necesario.
            //this.pT_Productos_FamiliasTableAdapter.Fill(this.aCSDataSet2.PT_Productos_Familias);
            // TODO: esta línea de código carga datos en la tabla 'aCSDataSet1.PT_Productos_Familias' Puede moverla o quitarla según sea necesario.
            //this.pT_Productos_FamiliasTableAdapter.Fill(this.aCSDataSet1.PT_Productos_Familias);
            GenerarCodigo();
            labelControl4.Hide();
            xCheckBoxODOO.Hide();

            LoadFamilia();
            
        }

        private void LoadFamilia()
        {
            try
            {
                int esp;
                //Load Familias
                string Familias = @"SELECT [id] 
                                      ,[short_name] as descripcion 
                                      ,[enable] 
                                FROM [dbo].[PT_Productos_Familias] 
                                        where enable = 1";

                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();
                SqlDataAdapter Da = new SqlDataAdapter(Familias, con);
                acsDataSet21.Familia.Clear();
                Da.Fill(acsDataSet21.Familia);



                //Load Categorias
                string Categorias = @"SELECT [id]
                                            ,[description] as descripcion
                                            ,[enable] 
                                      FROM [dbo].[PT_Products_Category] 
                                        where enable = 1";

                SqlDataAdapter Data = new SqlDataAdapter(Categorias, con);
                acsDataSet21.Categoria.Clear();
                Data.Fill(acsDataSet21.Categoria);



                //Load Portafolio
                string Portafolio = @"SELECT [id]
                                            ,[description] as Descripcion 
                                      FROM[dbo].[PT_Products_Portafolio]
                                        where enable = 1";
                SqlDataAdapter Dataap = new SqlDataAdapter(Portafolio, con);
                acsDataSet21.Portafolio.Clear();
                Dataap.Fill(acsDataSet21.Portafolio);




                //Load Bags
                string bags = @"SELECT [id]
                                      ,[description] as Tamaño
                                FROM [dbo].[PT_Products_Bags] 
                                    where enable = 1";
                SqlDataAdapter DataBags = new SqlDataAdapter(bags, con);
                acsDataSet21.Bolsas.Clear();
                DataBags.Fill(acsDataSet21.Bolsas);
                //Load Origen
                if (toggleSwitchEspecie.IsOn)
                {
                    esp = 2;
                }
                else
                {
                    esp = 1;
                }
                string QueryOrigen;
                QueryOrigen = @"SELECT  [id]
                                  ,[descripcion]
                              FROM [dbo].[PT_Products_Origen]
                            where especie = "+esp+" and enable = 1";
                SqlDataAdapter datOr = new SqlDataAdapter(QueryOrigen, con);
                acsDataSet21.Origen.Clear();
                datOr.Fill(acsDataSet21.Origen);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void GenerarCodigo()
        {
            ProductoTerminado prod = new ProductoTerminado(dp.ConnectionStringCostos);
            try
            {
                if(toggleSwitchEspecie.IsOn)//Camaraon
                {
                    //Generar el codigo para Camaron
                    txtCodigo.Text = prod.GenerarSiguienteCodigo(4);
                }
                else
                {
                    //Generar el codigo para Tilapia
                    txtCodigo.Text = prod.GenerarSiguienteCodigo(3);
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Error", ec.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            GenerarCodigo();
            LoadNewFam();
            
        }

        private void LoadNewFam()
        {
            String qery;
           
            if (toggleSwitchEspecie.IsOn)//Camaraon
            {
               SqlConnection cox = new SqlConnection(dp.ConnectionStringCostos);
                cox.Open();
                qery = "SELECT " +
                    "[id]" +
                    ",[short_name] as descripcion" +
                    ",[enable] " +
                    "FROM [dbo].[PT_Productos_Familias] " +
                    " where specie = 2";               
                SqlDataAdapter da = new SqlDataAdapter(qery, cox);
                acsDataSet21.Familia.Clear();
                da.Fill(acsDataSet21.Familia);
                string  QueryOrigen = @"SELECT  [id]
                                  ,[descripcion]
                              FROM [dbo].[PT_Products_Origen]
                            where especie = 2 and enable = 1";
                SqlDataAdapter datOr = new SqlDataAdapter(QueryOrigen, cox);
                acsDataSet21.Origen.Clear();
                datOr.Fill(acsDataSet21.Origen);
                cox.Close();

            }
            else
            {
                SqlConnection cox = new SqlConnection(dp.ConnectionStringCostos);
                qery = "SELECT " +
                    "[id]," +
                    "[short_name] as descripcion," +
                    "[enable]" +
                    " FROM [dbo].[PT_Productos_Familias]" +
                    " where specie = 1 ";
                SqlDataAdapter da = new SqlDataAdapter(qery, cox);
                acsDataSet21.Familia.Clear();
                da.Fill(acsDataSet21.Familia);
                string QueryOrigen = @"SELECT  [id]
                                  ,[descripcion]
                              FROM [dbo].[PT_Products_Origen]
                            where especie = 1 and enable = 1";
                SqlDataAdapter datOr = new SqlDataAdapter(QueryOrigen, cox);
                acsDataSet21.Origen.Clear();
                datOr.Fill(acsDataSet21.Origen);
                cox.Close();
            }
        }

        private void xCheckBoxODOO_OnCheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void xCheckBoxACS_OnCheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void xCheckBoxAPMS_OnCheckedChanged(object sender, EventArgs e)
        {
            if(xCheckBoxAPMS.Value)
                xCheckBoxACS.Value = true;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            //Verificar si tamaño de particula es un valor correcto
            string Orgi, regist, diam;
           
            if (txtNombre.Text == "Campo requerido") 
            {
                CajaDialogo.Error("Necesita ingresar una descripcion del producto.");
                return;
            }

            if (gridLookCategoria.Text == "")
            {
                CajaDialogo.Error("Seleccione una categoria.");
                return;
            }

            if (gridLookFamilia.Text == "")
            {
                CajaDialogo.Error("Seleccione una Familia.");
                return;
            }

            if (gridLookTipoSaco.Text == "")
            {
                CajaDialogo.Error("Seleccione el tamaño de saco.");
                return;
            }

            if (gridLookPesoSaco.Text == "")
            {
                CajaDialogo.Error("Seleccione el paso del saco.");
                return;
            }
            if (gridOrigen.Text == "")
            {
                CajaDialogo.Error("Seleccione un origen. ");
                return;
            }
         
            if (txtdiametro.Text == "")
            {
                diam = " ";
            }
            else
            {
                diam = txtdiametro.Text;
            }

            if (txtRegistro.Text == "")
            {
              regist = " ";
            }
            else
            {
                regist = txtRegistro.Text;
            }

            if (gridOrigen.Text == "")
            {
                 Orgi = " ";
            }
            string size, Formulas;
            string peso = "";
            if (txtTamanioParticula.Text == "")
            {
                size = " ";
            }
            else
            {
                size = txtTamanioParticula.Text;
            }


            indiceFam = gridLookFamilia.EditValue.ToString();
            indiceCat = gridLookCategoria.EditValue.ToString();
            indiceBag = gridLookTipoSaco.EditValue.ToString();
            indiceTam = gridLookPesoSaco.EditValue.ToString();
            Orgi = gridOrigen.EditValue.ToString();

            

            if (xCheckBoxAPMS.Value && !xCheckBoxACS.Value)
            {
                CajaDialogo.Error("El registro no puede ser guardado en AMPS.\nLamentablemente para guardar el registro en APMS; es necesario registrar el Producto Terminado en ACS.\nSeleccione Crear el Producto Terminado en ACS...");
                return;
            }

            string Especie = "";
            if (toggleSwitchEspecie.IsOn)
                Especie = "2";
            else
                Especie = "1";

            bool exito = false;
            int ACS_ID = 0;
            
            if (xCheckBoxACS.Value)
            {
                //Crear el registro en ACS
                try
                {
                    
                    if (txtNombreCorto.Text == "")
                    {
                        Formulas = "NULL";
                    }
                    else
                    {
                        Formulas = txtNombreCorto.Text;
                    }

                    string SqlPeso = @"SELECT net
                                       FROM [dbo].[PT_Products_Bags]
                                       WHERE id = "+indiceTam;

                    SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                    conn.Open();
                    SqlCommand cmm = new SqlCommand(SqlPeso, conn);
                    SqlDataReader dr = cmm.ExecuteReader();

                    if (dr.Read())
                    {
                        peso = dr.GetDecimal(0).ToString();
                    }

                    dr.Close();
                    size = txtTamanioParticula.Text;

                    //string sql1 = @"INSERT INTO [dbo].[PT_Productos]
                    //                                         ([Codigo]
                    //                                        ,[Serie]
                    //                                        ,[Descripcion]
                    //                                        ,[Proteina]
                    //                                        ,[Grasa]
                    //                                        ,[TamPellet]
                    //                                        ,[PesoSaco]
                    //                                        ,[Especie]
                    //                                        ,[Fecha]
                    //                                        ,[Hora]
                    //                                        ,[Estado]
                    //                                        ,[Mes]
                    //                                        ,[Anio]
                    //                                        ,[oldCode]
                    //                                        ,[family]
                    //                                        ,[id_bag]
                    //                                        ,[formula_code]
                    //                                        ,[id_category]
                    //                                        ,[id_proceso]
                    //                                        ,[id_portafolio]
                    //                                        ,[tamanio]
                    //                                        ,[id_origen]
                    //                                        ,[Registro]
                    //                                        ,[diametro]
                    //                                        ,[dias_vencimiento]
                    //                                        ,[dias_venc_despachos])
                    //                                         VALUES( '" +
                    //                                                txtCodigo.Text + "'," +
                    //                                                "0, '" +
                    //                                                txtNombre.Text + "'," +
                    //                                                txt_Proteina.Text + "," +
                    //                                                txt_Proteina.Text + "," +
                    //                                                "0," +
                    //                                                peso + "," +
                    //                                                Especie +
                    //                                                ",GETDATE()," +
                    //                                                "(SELECT CONVERT(TIME(0),GETDATE()) AS HourMinuteSecond)," +
                    //                                                "'a',NULL," +
                    //                                                "NULL, " +
                    //                                                "NULL, "
                    //                                                + indiceFam + "," +
                    //                                                indiceTam + ",'" +
                    //                                                Formulas + "'," +
                    //                                                indiceCat +
                    //                                                ", NULL , " +
                    //                                                indiceBag + " , '" +size +
                    //                                                "' ,"+Orgi+"," +
                    //                                                "'"+regist+
                    //                                                "','"+diam+
                    //                                                "'" +
                    //                                                ",'"+ spindDiasVenc.EditValue+"'" +
                    //                                                ",'"+spinDiasMinimos.EditValue+"') SELECT SCOPE_IDENTITY()";
                    string query = @"sp_insert_pt_productos";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                    cmd.Parameters.AddWithValue("@Descripcion", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Proteina", Convert.ToDecimal(txt_Proteina.Text));
                    cmd.Parameters.AddWithValue("@Grasa", Convert.ToDecimal(spinEdit1.Text));
                    cmd.Parameters.AddWithValue("@peso", peso);
                    cmd.Parameters.AddWithValue("@Especie", Especie);
                    cmd.Parameters.AddWithValue("@indiceFam", indiceFam);
                    cmd.Parameters.AddWithValue("@indiceTam", indiceTam);
                    cmd.Parameters.AddWithValue("@formula_code", Formulas);
                    cmd.Parameters.AddWithValue("@indiceCat", indiceCat);
                    cmd.Parameters.AddWithValue("@indiceBag", indiceBag);
                    cmd.Parameters.AddWithValue("@size", size);
                    cmd.Parameters.AddWithValue("@Orgi", Orgi);
                    cmd.Parameters.AddWithValue("@diam", diam);
                    cmd.Parameters.AddWithValue("@dias_vencimiento", spindDiasVenc.EditValue);
                    cmd.Parameters.AddWithValue("@dias_venc_despachos", spinDiasMinimos.EditValue);

                    ACS_ID = Convert.ToInt32( cmd.ExecuteScalar());
                    string Incremento,Tipo;
                    if (toggleSwitchEspecie.IsOn)
                    {
                        //Camaron
                        Tipo = "4";
                    }
                    else
                    {
                        //Generar el codigo para Tilapia
                        Tipo = "3";
                    }

                    Incremento = @"UPDATE [dbo].[conf_tables_id] 
                                  SET [siguiente] = ([siguiente] + 1) 
                                  WHERE[id] = " + Tipo;
                    SqlCommand Comd = new SqlCommand(Incremento, conn);
                    Comd.ExecuteNonQuery();
                    
                    conn.Close();
                    exito = true;
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            if (xCheckBoxAPMS.Value)
            {
                //Crear el registro en APMS
                if (ACS_ID == 0)
                {
                    //Si entra aqui es porque no se ha generado el registro en el ACS
                    CajaDialogo.Error("El registro no fue guardado en ALOSY correctamente.\nLamentablemente para guardar el registro en APMS el Producto Terminado debe registrarse primero en ALOSY.\nContacte al Administrador del Sistema!");
                    exito = false;
                }
                else
                {
                    string SqlPeso = @" SELECT peso
                                        FROM [dbo].[MD_Finished_Productos_Bags]
                                        WHERE id = " + indiceTam;

                    SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                    conn.Open();
                    SqlCommand cmm = new SqlCommand(SqlPeso, conn);
                    SqlDataReader dr = cmm.ExecuteReader();

                    if (dr.Read())
                    {
                        peso = dr.GetDecimal(0).ToString();
                    }
                    dr.Close();
                   
                    size = txtTamanioParticula.Text;
                    if (string.IsNullOrEmpty(size))
                        size = "NULL";

                    //APMS 
                    string shortName = "";
                    if (txtNombre.Text.Length > 50)
                    {
                        shortName = txtNombre.Text.Substring(0, 50);
                    }
                    else
                    {
                        shortName = txtNombre.Text;
                    }

                    string LongName = "";
                    if (txtNombre.Text.Length > 70)
                    {
                        LongName = txtNombre.Text.Substring(0, 70);
                    }
                    else
                    {
                        LongName = txtNombre.Text;
                    }
                    string sqL2 = @"INSERT INTO [dbo].[MD_Finished_Products]
                                                                   ([acs_id]
                                                                    ,[code]
                                                                    ,[short_name]
                                                                    ,[long_name]
                                                                    ,[specie]
                                                                    ,[product_group]
                                                                    ,[product_subgroup]
                                                                    ,[bag_size]
                                                                    ,[status]
                                                                    ,[id_bag]
                                                                    --,[size]
                                                                    ,[id_family])
                                                             VALUES
                                                                   (" +
                                                                    ACS_ID.ToString() + ", '" +
                                                                    txtCodigo.Text.Trim().Substring(0,10) + "', '" +
                                                                    //txtNombre.Text.Substring(0,50) + "', '" +
                                                                    shortName + "', '" +
                                                                    //txtNombre.Text.Substring(0, 70) + "'," +
                                                                    LongName + "'," +
                                                                    Especie.ToString() + "," +
                                                                    "4,  " +
                                                                    "10, " +
                                                                    peso+", " +
                                                                    "40, "+
                                                                    indiceTam+","+
                                                                    //size+","+
                                                                    indiceFam+")";
                    SqlConnection conn2 = new SqlConnection(dp.ConnectionStringAPMS);
                    conn2.Open();
                    SqlCommand cmd = new SqlCommand(sqL2, conn2);
                    cmd.ExecuteScalar();
                    conn2.Close();
                    exito = true;
                }
            }

            if (xCheckBoxODOO.Value)
            {
                //Crear el Registro en ODOO
            }

            if (exito)
            {
                CajaDialogo.Information("Transacción Exitosa!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void txtNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("Campo requerido"))
            {
                txtNombre.Text = "";
                Font NewFont = new Font("Segoe UI", 12f);
                txtNombre.Font = NewFont;
                txtNombre.ForeColor = Color.Black;
            }
       
        }

        private void txtNombreCorto_Click(object sender, EventArgs e)
        {
            if (txtNombreCorto.Text.Equals(""))
            {
                
                Font NewFont = new Font("Segoe UI", 12f);
                txtNombreCorto.Font = NewFont;
                txtNombreCorto.ForeColor = Color.Black;
            }
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

      

        private void textEdit1_Click(object sender, EventArgs e)
        {
            if (txtTamanioParticula.Text.Equals(""))
            {
                
                Font NewFont = new Font("Segoe UI", 12f);
                txtTamanioParticula.Font = NewFont;
                txtTamanioParticula.ForeColor = Color.Black;
            }
        }
        

      
        private void gridLookUpEdit1_Validated(object sender, EventArgs e)
        {
           
        }
    }
}