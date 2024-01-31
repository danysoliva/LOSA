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
using System.Data.SqlClient;
using LOSA.Clases;
using static DevExpress.Xpo.DB.DataStoreLongrunnersWatch;
using DevExpress.Utils.Extensions;

namespace LOSA.MigracionACS.PT
{
    public partial class frmCRUDProductoTerminado : DevExpress.XtraEditors.XtraForm
    {

        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        string indiceFam, indiceCat, indiceBag, indiceTam; 
        int Especie = 0;
        int IdProducto = 0;
        decimal PesoSaco = 0;
        string CodigoAQF;

        public enum TipoOperacion 
        {
            Insert = 1,
            Update = 2,
            SolicitudInsert = 3
        }

        TipoOperacion TipoOP;

        public frmCRUDProductoTerminado(UserLogin pUserLogin, TipoOperacion pTipoOP, int pid_pt)
        {
            InitializeComponent();

            TipoOP = pTipoOP;

            switch (TipoOP)
            {
                case TipoOperacion.Insert:

                    spindDiasVenc.EditValue = 150;
                    spinDiasMinimos.EditValue = 60;
                    TsEstado.IsOn = true;
                    toggleSwitchEspecie.IsOn = true;
                    lblCodUnite.Visible = false;
                    txtCodUnite.Visible = false;
                    lblProceso.Visible = false;
                    gridLookProce.Visible = false;
                    lblEstado.Visible = false;
                    TsEstado.Visible = false;
                    grdCodSAP.Visible = false;

                    GenerarCodigo();
                    LoadFamilia();

                    break;
                case TipoOperacion.Update:
                    toggleSwitchEspecie.Enabled = false;
                    IdProducto = pid_pt;
                    LoadFamilia();
                    ProductoTerminado pt = new ProductoTerminado(dp.ConnectionStringCostos);
                    pt.Recuperar_producto(IdProducto);
                    if (pt.especie == 1)
                    {
                        toggleSwitchEspecie.IsOn = true;
                        Especie = 1;
                    }
                    else
                    {
                        toggleSwitchEspecie.IsOn = false;
                        Especie = 2;
                        lblCodUnite.Visible = true;
                        txtCodUnite.Visible = true;
                    }
                    txtCodigo.Text = pt.Codigo;
                    txtDescripcionFacturacion.Text = pt.descripcion;
                    txtDescrpcionTecnica.Text = pt.descripcion_Tecnica;
                    txtFormula.Text = pt.formula_code;
                    grdCategoria.EditValue = pt.id_category;
                    grdFamilia.EditValue = pt.family;
                    grdtipoSaco.EditValue = pt.id_portafolio;
                    grdPesoSaco.EditValue = pt.id_bag;
                    if (Convert.ToInt32(grdPesoSaco.EditValue) > 0)
                    {
                        BagsPT pt_bag = new BagsPT();
                        pt_bag.RecuperarRegistro(Convert.ToInt32(grdPesoSaco.EditValue));
                        PesoSaco = pt_bag.net;
                    }
                    txtCodUnite.Text = pt.codigo_unite;
                    txtTamano.Text = pt.tamaño;
                    txtDiametroParticula.Text = pt.diametro;
                    spindDiasVenc.EditValue = pt.dias_vencimiento;
                    spinDiasMinimos.EditValue = pt.dias_venc_despacho;
                    //CodeSAP = pt.codesap;
                    CodigoAQF = txtCodigo.Text;
                    int TipoData;

                    if (pt.codesap == "PTXXX")
                    {
                        if (!string.IsNullOrEmpty(txtCodigo.Text))
                        {
                            TipoData = 1;
                            CargarCodigosSAP(TipoData);
                        }
                    }

                    txtRegistro.Text = pt.registro;
                    grdOrigen.EditValue = pt.idOr;
                    spinProteina.EditValue = pt.proteinas;
                    spinGrasas.EditValue = pt.grasa;
                    if (pt.estado == "a")
                        TsEstado.IsOn = true;
                    else
                        TsEstado.IsOn = false;
                    
                    LlenadoProce();
                    gridLookProce.EditValue = pt.id_proceso;

                    

                    lblProceso.Visible = true;
                    gridLookProce.Visible = true;
                    lblEstado.Visible = true;
                    TsEstado.Visible = true;


                    break;
                case TipoOperacion.SolicitudInsert:

                    spindDiasVenc.EditValue = 150;
                    spinDiasMinimos.EditValue = 60;
                    toggleSwitchEspecie.IsOn = true;
                    GenerarCodigo();
                    LoadFamilia();

                    break;
                default:
                    break;
            }

        }

        private void CargarCodigosSAP(int tipoData)
        {
            try
            {
                if (tipoData == 1) 
                {
                    string query = @"sp_get_obtener_codigos_sap";
                    DataOperations dpSAP = new DataOperations();
                    SqlConnection cn = new SqlConnection(dpSAP.ConnectionStringCostos);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo_aqf", txtCodigo.Text);
                    cmd.Parameters.AddWithValue("@tipo_data", tipoData);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    aCSDataSet21.CodigosSAP.Clear();
                    da.Fill(aCSDataSet21.CodigosSAP);
                    cn.Close();



                    foreach (DataRow row in aCSDataSet21.CodigosSAP)
                    {
                        if (row["CodeAQF"].ToString() == CodigoAQF.ToString())
                        {
                            grdCodSAP.EditValue = CodigoAQF;
                            grdCodSAP.Enabled = false;
                            return;
                        }

                    }
                }
                else
                {
                    string query = @"sp_get_obtener_codigos_sap";
                    DataOperations dpSAP = new DataOperations();
                    SqlConnection cn = new SqlConnection(dpSAP.ConnectionStringCostos);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo_aqf", Convert.ToInt32(txtCodigo.EditValue));
                    cmd.Parameters.AddWithValue("@tipo_data", tipoData);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    aCSDataSet21.CodigosSAP.Clear();
                    da.Fill(aCSDataSet21.CodigosSAP);
                    cn.Close();

                    
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error("No se pudo Realizar la Conexion con el Servidor de SAP!\nNotificar al Departamento de IT", ex);
            }
        }

        private void LlenadoProce()
        {
            try
            {
                String Qry;
                Qry = @"SELECT id
                              ,description
                        FROM [dbo].[PT_Products_Process]
                        where enable = 1";
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();
                SqlCommand cmd = new SqlCommand(Qry, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dSProductos1.Proceso);
                con.Close();
            }
            catch (Exception es)
            {
                CajaDialogo.Error(es.Message);
                throw;
            }
        }

        private void LoadFamilia()
        {
            try
            {
                int esp;
                //Load Familias
                //string Familias = @"SELECT [id] 
                //                      ,[short_name] as descripcion 
                //                      ,[enable] 
                //                FROM [dbo].[PT_Productos_Familias] 
                //                        where enable = 1";

                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();
                //SqlDataAdapter Da = new SqlDataAdapter(Familias, con);
                //aCSDataSet21.Familia.Clear();
                //Da.Fill(aCSDataSet21.Familia);



                //Load Categorias
                string Categorias = @"SELECT [id]
                                            ,[description] as descripcion
                                            ,[enable] 
                                      FROM [dbo].[PT_Products_Category] 
                                        where enable = 1";

                SqlDataAdapter Data = new SqlDataAdapter(Categorias, con);
                aCSDataSet21.Categoria.Clear();
                Data.Fill(aCSDataSet21.Categoria);



                //Load Portafolio
                string Portafolio = @"SELECT [id]
                                            ,[description] as Descripcion 
                                      FROM[dbo].[PT_Products_Portafolio]
                                        where enable = 1";
                SqlDataAdapter Dataap = new SqlDataAdapter(Portafolio, con);
                aCSDataSet21.Portafolio.Clear();
                Dataap.Fill(aCSDataSet21.Portafolio);




                //Load Bags
                string bags = @"SELECT [id]
                                      ,[description] as Tamaño
                                      ,[net] as Factor
                                FROM [dbo].[PT_Products_Bags] 
                                    where enable = 1";
                SqlDataAdapter DataBags = new SqlDataAdapter(bags, con);
                aCSDataSet21.Bolsas.Clear();
                DataBags.Fill(aCSDataSet21.Bolsas);
                //Load Origen
                if (toggleSwitchEspecie.IsOn) //Tilapia
                {
                    esp = 1;
                }
                else //Camaron
                {
                    esp = 2;
                }
                string QueryOrigen;
                QueryOrigen = @"SELECT  [id]
                                  ,[descripcion]
                              FROM [dbo].[PT_Products_Origen]
                            where especie = " + esp + " and enable = 1";
                SqlDataAdapter datOr = new SqlDataAdapter(QueryOrigen, con);
                aCSDataSet21.Origen.Clear();
                datOr.Fill(aCSDataSet21.Origen);
                

                string FamiliasToggled = @"SELECT [id] 
                                      ,[short_name] as descripcion 
                                      ,[enable] 
                                FROM [dbo].[PT_Productos_Familias] 
                                        where enable = 1 and specie = " + esp;
                SqlDataAdapter DaToggled = new SqlDataAdapter(FamiliasToggled, con);
                aCSDataSet21.Familia.Clear();
                DaToggled.Fill(aCSDataSet21.Familia);
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
                if (toggleSwitchEspecie.IsOn)//Tilapia
                {
                    //Generar el codigo para Tilapia
                    txtCodigo.Text = prod.GenerarSiguienteCodigo(3);
                    lblCodUnite.Visible = false;
                    txtCodUnite.Visible = false;
                }
                else
                {
                    //Generar el codigo para Camaron
                    txtCodigo.Text = prod.GenerarSiguienteCodigo(4);
                    lblCodUnite.Visible = true;
                    txtCodUnite.Visible = true;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Error", ec.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                CajaDialogo.Error("El Campo Codigo AQF no puede estar Vacio!");
                return;
            }

            if (string.IsNullOrEmpty(txtDescrpcionTecnica.Text))
            {
                CajaDialogo.Error("Este campo no puede estar vacio! (Descripcion Tecnica)");
                txtDescrpcionTecnica.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcionFacturacion.Text))
            {
                CajaDialogo.Error("Este campo no puede estar vacio! (Descripcion Facturacion)");
                txtDescripcionFacturacion.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtFormula.Text))
            {
                CajaDialogo.Error("Este campo no puede estar vacio! (Formula)");
                txtFormula.Focus();
                return;
            }

            if (string.IsNullOrEmpty(grdCategoria.Text))
            {
                CajaDialogo.Error("Este campo no puede estar vacio! (Categoria)");
                return;
            }

            if (string.IsNullOrEmpty(grdFamilia.Text))
            {
                CajaDialogo.Error("Este campo no puede estar vacio! (Familia)");
                return;
            }

            if (string.IsNullOrEmpty(grdtipoSaco.Text))
            {
                CajaDialogo.Error("Este campo no puede estar vacio! (Tipo de Saco)");
                return;
            }

            if (string.IsNullOrEmpty(grdPesoSaco.Text))
            {
                CajaDialogo.Error("Este campo no puede estar vacio! (Peso Saco)");
                return;
            }

            if (Convert.ToInt32(spindDiasVenc.EditValue) <= 0)
            {
                CajaDialogo.Error("Los Dias de Vencimiento no pueden ser Menor que (0)!");
                return;
            }

            if (Convert.ToInt32(spinDiasMinimos.EditValue) <= 0)
            {
                CajaDialogo.Error("Los Dias Minimos de Despacho no pueden ser Menor que (0)!");
                return;
            }

            if (Convert.ToInt32(spindDiasVenc.EditValue) < Convert.ToInt32(spinDiasMinimos.EditValue))
            {
                CajaDialogo.Error("Los Dias de Vencimiento del Producto no puede ser menor que los Dias Minimos de Despacho!");
                return;
            }

            if (string.IsNullOrEmpty(grdOrigen.Text))
            {
                CajaDialogo.Error("Este campo no puede estar vacio! (Origen)");
                return;
            }

            if (string.IsNullOrEmpty(txtTamano.Text) || string.IsNullOrEmpty(txtDiametroParticula.Text))
            {
                CajaDialogo.Error("Este campo no puede estar vacio! (Tamaño || Diametro Particula)");
                return;
            }

            switch (TipoOP)
            {
                case TipoOperacion.Insert:


                    if (toggleSwitchEspecie.IsOn)
                    {
                        Especie = 1;//Tilapia
                    }
                    else
                    {
                        Especie = 2; //Camaron
                        if (string.IsNullOrEmpty(txtCodUnite.Text))
                        {
                            CajaDialogo.Error("Este campo no puede estar vacio! (Codigo Unite)");
                            return;
                        }
                    }

                    DialogResult r = CajaDialogo.Pregunta("Se creara un nuevo Producto Terminado, esta seguro de continuar?");
                    if (r != System.Windows.Forms.DialogResult.Yes)
                        return;

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("[sp_insert_pt_productosV2]", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Codigo",txtCodigo.Text.Trim());
                        cmd.Parameters.AddWithValue("@Descripcion",txtDescripcionFacturacion.Text);
                        cmd.Parameters.AddWithValue("@Proteina",spinProteina.EditValue);
                        cmd.Parameters.AddWithValue("@Grasa",spinGrasas.EditValue);
                        cmd.Parameters.AddWithValue("@Especie", Especie);
                        cmd.Parameters.AddWithValue("@indiceFam", grdFamilia.EditValue); 
                        cmd.Parameters.AddWithValue("@indiceTam", grdPesoSaco.EditValue);
                        cmd.Parameters.AddWithValue("@formula_code",txtFormula.Text.Trim());
                        cmd.Parameters.AddWithValue("@indiceCat", grdCategoria.EditValue);
                        cmd.Parameters.AddWithValue("@indiceBag", grdtipoSaco.EditValue);
                        cmd.Parameters.AddWithValue("@size", txtTamano.Text);
                        cmd.Parameters.AddWithValue("@Orgi",grdOrigen.EditValue);
                        cmd.Parameters.AddWithValue("@regist", txtRegistro.Text);
                        cmd.Parameters.AddWithValue("@diam",txtDiametroParticula.Text);
                        cmd.Parameters.AddWithValue("@dias_vencimiento", Convert.ToInt32(spindDiasVenc.EditValue));
                        cmd.Parameters.AddWithValue("@dias_venc_despachos", Convert.ToInt32(spinDiasMinimos.EditValue));
                        cmd.Parameters.AddWithValue("@cod_unite", txtCodUnite.Text);
                        
                        int IdPT_ACS = Convert.ToInt32(cmd.ExecuteScalar());

                        if (IdPT_ACS > 0) //si es Mayor que 0 se guardo en AQFSVR10.ACS vamos a Guardarlo a AQFSVR008.APMS
                        {
                            int Tipo;
                            if (toggleSwitchEspecie.IsOn) //Tilapia
                                Tipo = 3;
                            else //Camaron
                                Tipo = 4;

                            SqlCommand cmdACS = new SqlCommand("sp_producto_update_codigo_aqf_correlativo", conn);
                            cmdACS.CommandType = CommandType.StoredProcedure;
                            cmdACS.Parameters.AddWithValue("@tipo", Tipo);
                            cmdACS.ExecuteNonQuery();
                            conn.Close();

                            //Crear el registro en APMS
                            string shortName = "";
                            if (txtDescrpcionTecnica.Text.Length > 50)
                            {
                                shortName = txtDescrpcionTecnica.Text.Substring(0, 50);
                            }
                            else
                            {
                                shortName = txtDescrpcionTecnica.Text;
                            }

                            string LongName = "";
                            if (txtDescrpcionTecnica.Text.Length > 70)
                            {
                                LongName = txtDescrpcionTecnica.Text.Substring(0, 70);
                            }
                            else
                            {
                                LongName = txtDescrpcionTecnica.Text;
                            }

                            SqlConnection connAPMS = new SqlConnection(dp.ConnectionStringAPMS);
                            connAPMS.Open();
                            SqlCommand cmdAPMS = new SqlCommand("sp_insert_finished_products", connAPMS);
                            cmdAPMS.CommandType = CommandType.StoredProcedure;
                            cmdAPMS.Parameters.AddWithValue("@acs_id",IdPT_ACS);
                            cmdAPMS.Parameters.AddWithValue("@code", txtCodigo.Text.Trim());
                            cmdAPMS.Parameters.AddWithValue("@short_name", txtDescrpcionTecnica.Text);
                            cmdAPMS.Parameters.AddWithValue("@long_name", txtDescrpcionTecnica.Text);
                            cmdAPMS.Parameters.AddWithValue("@specie", Especie);
                            cmdAPMS.Parameters.AddWithValue("@product_group", 4);
                            cmdAPMS.Parameters.AddWithValue("@product_subgroup", 10);
                            cmdAPMS.Parameters.AddWithValue("@bag_size", PesoSaco);
                            cmdAPMS.Parameters.AddWithValue("@id_bag", grdPesoSaco.EditValue);
                            cmdAPMS.Parameters.AddWithValue("@id_family", grdFamilia.EditValue);
                            cmdAPMS.Parameters.AddWithValue("@comercial_name", txtDescripcionFacturacion.Text);

                            bool Guardado = Convert.ToBoolean(cmdAPMS.ExecuteScalar());

                            if (Guardado)
                            {
                                #region CargaPTSAP

                                #endregion

                                CajaDialogo.Information("Producto Terminado Registrado!\nFavor Subirlo a SAP para Completar el Registro!");
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                CajaDialogo.Error("El Registro no fue Creado en APMS.\nContacte al Dpto de Sistemas!");
                            }
                        }
                        else
                        {
                            CajaDialogo.Error("El registro no fue guardado en ALOSY correctamente.\nLamentablemente para guardar el registro en APMS el Producto Terminado debe registrarse primero en ALOSY.\nContacte al Administrador del Sistema!");
                        }
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                    break;

                case TipoOperacion.Update:



                    string EstadoPT;
                    if (!TsEstado.IsOn)
                    {
                        bool PermitirUpdate = false;
                        //Si se esta enviando a Inactivo Vamos a validar que no este usando en Produccion Actualmente!
                        //todavia no se a echo..

                        try
                        {

                        }
                        catch (Exception ex)
                        {
                            CajaDialogo.Error(ex.Message);
                        }

                        if (PermitirUpdate)
                        {
                            EstadoPT = "i";
                        }
                        else
                        {
                            CajaDialogo.Error("No se puede Desactivar este Producto.\nActualmente esta siendo usado!");
                            return;
                        }
                        
                    }
                    else
                    {
                        EstadoPT = "a";
                    }

                    if (grdCodSAP.Text == "PTXXXX")
                    {
                        CajaDialogo.Error("Debe seleccionar un Codigo de SAP, Valido!");
                        return;
                    }

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_update_pt_portafolio", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
                        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcionFacturacion.Text);
                        cmd.Parameters.AddWithValue("@Proteina", spinProteina.EditValue);
                        cmd.Parameters.AddWithValue("@Grasa", spinGrasas.EditValue);
                        cmd.Parameters.AddWithValue("@PesoSaco", PesoSaco);
                        cmd.Parameters.AddWithValue("@Estado", EstadoPT);
                        cmd.Parameters.AddWithValue("@family", grdFamilia.EditValue);
                        cmd.Parameters.AddWithValue("@id_bag", grdPesoSaco.EditValue);
                        cmd.Parameters.AddWithValue("@formula_code", dp.ValidateNumberInt32(txtFormula.Text));
                        cmd.Parameters.AddWithValue("@id_category", grdCategoria.EditValue);
                        cmd.Parameters.AddWithValue("@id_proceso", gridLookProce.EditValue);
                        cmd.Parameters.AddWithValue("@id_portafolio", grdtipoSaco.EditValue);
                        cmd.Parameters.AddWithValue("@tamanio", txtTamano.Text);
                        cmd.Parameters.AddWithValue("@id_origen", grdOrigen.EditValue);
                        cmd.Parameters.AddWithValue("@Registro",txtRegistro.Text);
                        cmd.Parameters.AddWithValue("@diametro", txtDiametroParticula.Text);
                        cmd.Parameters.AddWithValue("@Descripcion_Tecnica", txtDescrpcionTecnica.Text);
                        if (Especie == 1) //Tilapia
                            cmd.Parameters.AddWithValue("@codigo_unite", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@codigo_unite", txtCodUnite.Text);
                        cmd.Parameters.AddWithValue("@dias_vencimiento", spindDiasVenc.EditValue);
                        cmd.Parameters.AddWithValue("@dias_venc_despachos", spinDiasMinimos.EditValue);
                        cmd.Parameters.AddWithValue("@code_sap", grdCodSAP.Text);
                        cmd.ExecuteNonQuery();


                        SqlConnection connAPMS = new SqlConnection(dp.ConnectionStringAPMS);
                        connAPMS.Open();
                        SqlCommand cmdAPMS = new SqlCommand("sp_update_pt_portafolio", connAPMS);
                        cmdAPMS.CommandType = CommandType.StoredProcedure;
                        cmdAPMS.Parameters.AddWithValue("@short_name", txtDescrpcionTecnica.Text);
                        cmdAPMS.Parameters.AddWithValue("@long_name", txtDescrpcionTecnica.Text);
                        //cmdAPMS.Parameters.AddWithValue("@product_group",);
                        //cmdAPMS.Parameters.AddWithValue("@product_subgroup",);
                        cmdAPMS.Parameters.AddWithValue("@bag_size", PesoSaco);
                        if (EstadoPT == "a")
                            cmdAPMS.Parameters.AddWithValue("@status", 40);//por alguna razon es Activo.
                        else
                            cmdAPMS.Parameters.AddWithValue("@status", 99);//No se por poner un numero..

                        cmdAPMS.Parameters.AddWithValue("@id_bag", grdPesoSaco.EditValue);
                        cmdAPMS.Parameters.AddWithValue("@id_family",grdFamilia.EditValue);
                        cmdAPMS.Parameters.AddWithValue("@code_sap", grdCodSAP.Text);
                        cmdAPMS.Parameters.AddWithValue("@comercial_name",txtDescripcionFacturacion.Text);
                        cmdAPMS.Parameters.AddWithValue("@IdProducto", IdProducto);
                       
                        cmdAPMS.ExecuteNonQuery();
                        connAPMS.Close();

                        CajaDialogo.Information("Producto Terminado Actualizado!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }


                    break;

                case TipoOperacion.SolicitudInsert:
                    //Esto lo haremos luego, quizas en Tickets vamos a ver.

                    break;

                default:

                    CajaDialogo.Error("No se logro definir la Operacion(Insert-Update)\nContact al Departamento de IT");

                    break;
            }

        }

        private void grdPesoSaco_EditValueChanged(object sender, EventArgs e)
        {
            if (gridView2.RowCount <= 0)
            {
                this.PesoSaco = 0;
            }
            else
            {
                this.PesoSaco = Convert.ToDecimal(gridView2.GetFocusedRowCellValue(gridView2.Columns[2]).ToString());
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toggleSwitchEspecie_Toggled(object sender, EventArgs e)
        {
            GenerarCodigo();
            LoadNewFam();
        }

        private void LoadNewFam()
        {
            String qery;

            if (toggleSwitchEspecie.IsOn)//Tilapia
            {
                SqlConnection cox = new SqlConnection(dp.ConnectionStringCostos);
                cox.Open();
                qery = "SELECT " +
                    "[id]" +
                    ",[short_name] as descripcion" +
                    ",[enable] " +
                    "FROM [dbo].[PT_Productos_Familias] " +
                    " where specie = 1";
                SqlDataAdapter da = new SqlDataAdapter(qery, cox);
                aCSDataSet21.Familia.Clear();
                da.Fill(aCSDataSet21.Familia);
                string QueryOrigen = @"SELECT  [id]
                                  ,[descripcion]
                              FROM [dbo].[PT_Products_Origen]
                            where especie = 1 and enable = 1";
                SqlDataAdapter datOr = new SqlDataAdapter(QueryOrigen, cox);
                aCSDataSet21.Origen.Clear();
                datOr.Fill(aCSDataSet21.Origen);
                cox.Close();

            }
            else //Camaron
            {
                SqlConnection cox = new SqlConnection(dp.ConnectionStringCostos);
                qery = "SELECT " +
                    "[id]," +
                    "[short_name] as descripcion," +
                    "[enable]" +
                    " FROM [dbo].[PT_Productos_Familias]" +
                    " where specie = 2 ";
                SqlDataAdapter da = new SqlDataAdapter(qery, cox);
                aCSDataSet21.Familia.Clear();
                da.Fill(aCSDataSet21.Familia);
                string QueryOrigen = @"SELECT  [id]
                                  ,[descripcion]
                              FROM [dbo].[PT_Products_Origen]
                            where especie = 2 and enable = 1";
                SqlDataAdapter datOr = new SqlDataAdapter(QueryOrigen, cox);
                aCSDataSet21.Origen.Clear();
                datOr.Fill(aCSDataSet21.Origen);
                cox.Close();
            }
        }
    }
}