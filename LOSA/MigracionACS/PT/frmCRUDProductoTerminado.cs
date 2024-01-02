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

namespace LOSA.MigracionACS.PT
{
    public partial class frmCRUDProductoTerminado : DevExpress.XtraEditors.XtraForm
    {

        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        string indiceFam, indiceCat, indiceBag, indiceTam;
        int IdProducto = 0;

        public enum TipoOperacion 
        {
            Insert = 1,
            Update = 2
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
                    GenerarCodigo();
                    LoadFamilia();

                    break;
                case TipoOperacion.Update:
                    IdProducto = pid_pt;

                    ProductoTerminado pt = new ProductoTerminado(dp.ConnectionStringCostos);
                    pt.Recuperar_producto(IdProducto);

                    break;
                default:
                    break;
            }

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
                aCSDataSet21.Familia.Clear();
                Da.Fill(aCSDataSet21.Familia);



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
                                FROM [dbo].[PT_Products_Bags] 
                                    where enable = 1";
                SqlDataAdapter DataBags = new SqlDataAdapter(bags, con);
                aCSDataSet21.Bolsas.Clear();
                DataBags.Fill(aCSDataSet21.Bolsas);
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
                            where especie = " + esp + " and enable = 1";
                SqlDataAdapter datOr = new SqlDataAdapter(QueryOrigen, con);
                aCSDataSet21.Origen.Clear();
                datOr.Fill(aCSDataSet21.Origen);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRUDProductoTerminado));
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.toggleSwitchEspecie = new DevExpress.XtraEditors.ToggleSwitch();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcionFacturacion = new DevExpress.XtraEditors.TextEdit();
            this.txtDescrpcionTecnica = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFormula = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtRegistro = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTamano = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.spindDiasVenc = new DevExpress.XtraEditors.SpinEdit();
            this.spinDiasMinimos = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit4 = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodSAP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.grdCategoria = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdFamilia = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdtipoSaco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdPesoSaco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdOrigen = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.origenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCSDataSet21 = new LOSA.MigracionACS.ACSDataSet2();
            this.bolsasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.portafolioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchEspecie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionFacturacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescrpcionTecnica.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTamano.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spindDiasVenc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiasMinimos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodSAP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFamilia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdtipoSaco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesoSaco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrigen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCSDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolsasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portafolioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(423, 504);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(125, 42);
            this.btnAtras.TabIndex = 85;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(249, 504);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(125, 42);
            this.cmdGuardar.TabIndex = 84;
            this.cmdGuardar.Text = "Guardar";
            // 
            // toggleSwitchEspecie
            // 
            this.toggleSwitchEspecie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toggleSwitchEspecie.EditValue = true;
            this.toggleSwitchEspecie.Location = new System.Drawing.Point(357, 8);
            this.toggleSwitchEspecie.Name = "toggleSwitchEspecie";
            this.toggleSwitchEspecie.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toggleSwitchEspecie.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitchEspecie.Properties.OffText = "Camaron";
            this.toggleSwitchEspecie.Properties.OnText = "Tilapia";
            this.toggleSwitchEspecie.Size = new System.Drawing.Size(162, 26);
            this.toggleSwitchEspecie.TabIndex = 89;
            this.toggleSwitchEspecie.Toggled += new System.EventHandler(this.toggleSwitchEspecie_Toggled);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(241, 58);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Size = new System.Drawing.Size(163, 28);
            this.txtCodigo.TabIndex = 88;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(68, 61);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(87, 21);
            this.labelControl15.TabIndex = 87;
            this.labelControl15.Text = "Codigo AQF:";
            // 
            // txtDescripcionFacturacion
            // 
            this.txtDescripcionFacturacion.Location = new System.Drawing.Point(241, 137);
            this.txtDescripcionFacturacion.Name = "txtDescripcionFacturacion";
            this.txtDescripcionFacturacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDescripcionFacturacion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcionFacturacion.Size = new System.Drawing.Size(229, 28);
            this.txtDescripcionFacturacion.TabIndex = 90;
            // 
            // txtDescrpcionTecnica
            // 
            this.txtDescrpcionTecnica.Location = new System.Drawing.Point(241, 98);
            this.txtDescrpcionTecnica.Name = "txtDescrpcionTecnica";
            this.txtDescrpcionTecnica.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDescrpcionTecnica.Properties.Appearance.Options.UseFont = true;
            this.txtDescrpcionTecnica.Size = new System.Drawing.Size(229, 28);
            this.txtDescrpcionTecnica.TabIndex = 91;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(68, 101);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(139, 21);
            this.labelControl1.TabIndex = 92;
            this.labelControl1.Text = "Descripcion Tecnica:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(68, 140);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(168, 21);
            this.labelControl2.TabIndex = 93;
            this.labelControl2.Text = "Descripcion Facturacion:";
            // 
            // txtFormula
            // 
            this.txtFormula.Location = new System.Drawing.Point(241, 177);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFormula.Properties.Appearance.Options.UseFont = true;
            this.txtFormula.Size = new System.Drawing.Size(194, 28);
            this.txtFormula.TabIndex = 94;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(68, 180);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 21);
            this.labelControl3.TabIndex = 95;
            this.labelControl3.Text = "Formula:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(68, 218);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 21);
            this.labelControl4.TabIndex = 96;
            this.labelControl4.Text = "Categoria:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(585, 137);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRegistro.Properties.Appearance.Options.UseFont = true;
            this.txtRegistro.Size = new System.Drawing.Size(120, 28);
            this.txtRegistro.TabIndex = 97;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(478, 101);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 21);
            this.labelControl5.TabIndex = 98;
            this.labelControl5.Text = "Tamaño:";
            // 
            // txtTamano
            // 
            this.txtTamano.Location = new System.Drawing.Point(585, 98);
            this.txtTamano.Name = "txtTamano";
            this.txtTamano.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTamano.Properties.Appearance.Options.UseFont = true;
            this.txtTamano.Size = new System.Drawing.Size(120, 28);
            this.txtTamano.TabIndex = 99;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(68, 257);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 21);
            this.labelControl6.TabIndex = 100;
            this.labelControl6.Text = "Familia:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(478, 140);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(61, 21);
            this.labelControl7.TabIndex = 101;
            this.labelControl7.Text = "Registro:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(68, 298);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(91, 21);
            this.labelControl8.TabIndex = 102;
            this.labelControl8.Text = "Tipo de Saco:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(480, 181);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(51, 21);
            this.labelControl9.TabIndex = 103;
            this.labelControl9.Text = "Origen:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(68, 339);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(94, 21);
            this.labelControl10.TabIndex = 104;
            this.labelControl10.Text = "Peso de Saco:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(478, 222);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(61, 21);
            this.labelControl11.TabIndex = 105;
            this.labelControl11.Text = "Proteina:";
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(585, 219);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.spinEdit1.Properties.Appearance.Options.UseFont = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(120, 28);
            this.spinEdit1.TabIndex = 107;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(707, 222);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(13, 21);
            this.labelControl12.TabIndex = 108;
            this.labelControl12.Text = "%";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(68, 379);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(169, 21);
            this.labelControl13.TabIndex = 109;
            this.labelControl13.Text = "Diametro de la Particula:";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(68, 418);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(145, 21);
            this.labelControl14.TabIndex = 110;
            this.labelControl14.Text = "Dias de Vencimiento:";
            // 
            // spindDiasVenc
            // 
            this.spindDiasVenc.EditValue = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.spindDiasVenc.Location = new System.Drawing.Point(241, 415);
            this.spindDiasVenc.Name = "spindDiasVenc";
            this.spindDiasVenc.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.spindDiasVenc.Properties.Appearance.Options.UseFont = true;
            this.spindDiasVenc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spindDiasVenc.Properties.EditValueChangedDelay = 150;
            this.spindDiasVenc.Properties.MaxValue = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.spindDiasVenc.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spindDiasVenc.Size = new System.Drawing.Size(95, 28);
            this.spindDiasVenc.TabIndex = 111;
            // 
            // spinDiasMinimos
            // 
            this.spinDiasMinimos.EditValue = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.spinDiasMinimos.Location = new System.Drawing.Point(380, 447);
            this.spinDiasMinimos.Name = "spinDiasMinimos";
            this.spinDiasMinimos.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.spinDiasMinimos.Properties.Appearance.Options.UseFont = true;
            this.spinDiasMinimos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinDiasMinimos.Properties.EditValueChangedDelay = 150;
            this.spinDiasMinimos.Properties.MaxValue = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.spinDiasMinimos.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinDiasMinimos.Size = new System.Drawing.Size(90, 28);
            this.spinDiasMinimos.TabIndex = 113;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Appearance.Options.UseTextOptions = true;
            this.labelControl16.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl16.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl16.Location = new System.Drawing.Point(68, 454);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(306, 21);
            this.labelControl16.TabIndex = 112;
            this.labelControl16.Text = "Dias Minimos para Despacho de Producto:";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(707, 262);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(13, 21);
            this.labelControl17.TabIndex = 116;
            this.labelControl17.Text = "%";
            // 
            // spinEdit4
            // 
            this.spinEdit4.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit4.Location = new System.Drawing.Point(585, 259);
            this.spinEdit4.Name = "spinEdit4";
            this.spinEdit4.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.spinEdit4.Properties.Appearance.Options.UseFont = true;
            this.spinEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit4.Size = new System.Drawing.Size(120, 28);
            this.spinEdit4.TabIndex = 115;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(478, 262);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(50, 21);
            this.labelControl18.TabIndex = 114;
            this.labelControl18.Text = "Grasas:";
            // 
            // txtCodSAP
            // 
            this.txtCodSAP.Enabled = false;
            this.txtCodSAP.Location = new System.Drawing.Point(585, 58);
            this.txtCodSAP.Name = "txtCodSAP";
            this.txtCodSAP.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSAP.Properties.Appearance.Options.UseFont = true;
            this.txtCodSAP.Size = new System.Drawing.Size(120, 28);
            this.txtCodSAP.TabIndex = 118;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Location = new System.Drawing.Point(480, 61);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(85, 21);
            this.labelControl19.TabIndex = 117;
            this.labelControl19.Text = "Codigo SAP:";
            // 
            // grdCategoria
            // 
            this.grdCategoria.Location = new System.Drawing.Point(241, 215);
            this.grdCategoria.Name = "grdCategoria";
            this.grdCategoria.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdCategoria.Properties.Appearance.Options.UseFont = true;
            this.grdCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdCategoria.Properties.DataSource = this.categoriaBindingSource;
            this.grdCategoria.Properties.DisplayMember = "descripcion";
            this.grdCategoria.Properties.NullText = "";
            this.grdCategoria.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdCategoria.Properties.ValueMember = "id";
            this.grdCategoria.Size = new System.Drawing.Size(194, 28);
            this.grdCategoria.TabIndex = 119;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // grdFamilia
            // 
            this.grdFamilia.Location = new System.Drawing.Point(241, 254);
            this.grdFamilia.Name = "grdFamilia";
            this.grdFamilia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdFamilia.Properties.Appearance.Options.UseFont = true;
            this.grdFamilia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdFamilia.Properties.DataSource = this.familiaBindingSource;
            this.grdFamilia.Properties.DisplayMember = "descripcion";
            this.grdFamilia.Properties.NullText = "";
            this.grdFamilia.Properties.PopupView = this.gridLookUpEdit2View;
            this.grdFamilia.Properties.ValueMember = "id";
            this.grdFamilia.Size = new System.Drawing.Size(194, 28);
            this.grdFamilia.TabIndex = 120;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // grdtipoSaco
            // 
            this.grdtipoSaco.Location = new System.Drawing.Point(241, 295);
            this.grdtipoSaco.Name = "grdtipoSaco";
            this.grdtipoSaco.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdtipoSaco.Properties.Appearance.Options.UseFont = true;
            this.grdtipoSaco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdtipoSaco.Properties.DataSource = this.portafolioBindingSource;
            this.grdtipoSaco.Properties.DisplayMember = "descripcion";
            this.grdtipoSaco.Properties.NullText = "";
            this.grdtipoSaco.Properties.PopupView = this.gridView1;
            this.grdtipoSaco.Properties.ValueMember = "id";
            this.grdtipoSaco.Size = new System.Drawing.Size(194, 28);
            this.grdtipoSaco.TabIndex = 121;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // grdPesoSaco
            // 
            this.grdPesoSaco.Location = new System.Drawing.Point(241, 336);
            this.grdPesoSaco.Name = "grdPesoSaco";
            this.grdPesoSaco.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdPesoSaco.Properties.Appearance.Options.UseFont = true;
            this.grdPesoSaco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdPesoSaco.Properties.DataSource = this.bolsasBindingSource;
            this.grdPesoSaco.Properties.DisplayMember = "Tamaño";
            this.grdPesoSaco.Properties.NullText = "";
            this.grdPesoSaco.Properties.PopupView = this.gridView2;
            this.grdPesoSaco.Properties.ValueMember = "id";
            this.grdPesoSaco.Size = new System.Drawing.Size(194, 28);
            this.grdPesoSaco.TabIndex = 122;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // grdOrigen
            // 
            this.grdOrigen.Location = new System.Drawing.Point(585, 178);
            this.grdOrigen.Name = "grdOrigen";
            this.grdOrigen.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdOrigen.Properties.Appearance.Options.UseFont = true;
            this.grdOrigen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdOrigen.Properties.DataSource = this.origenBindingSource;
            this.grdOrigen.Properties.DisplayMember = "descripcion";
            this.grdOrigen.Properties.NullText = "";
            this.grdOrigen.Properties.PopupView = this.gridView3;
            this.grdOrigen.Properties.ValueMember = "id";
            this.grdOrigen.Size = new System.Drawing.Size(120, 28);
            this.grdOrigen.TabIndex = 123;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // origenBindingSource
            // 
            this.origenBindingSource.DataMember = "Origen";
            this.origenBindingSource.DataSource = this.aCSDataSet21;
            // 
            // aCSDataSet21
            // 
            this.aCSDataSet21.DataSetName = "ACSDataSet2";
            this.aCSDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolsasBindingSource
            // 
            this.bolsasBindingSource.DataMember = "Bolsas";
            this.bolsasBindingSource.DataSource = this.aCSDataSet21;
            // 
            // portafolioBindingSource
            // 
            this.portafolioBindingSource.DataMember = "Portafolio";
            this.portafolioBindingSource.DataSource = this.aCSDataSet21;
            // 
            // familiaBindingSource
            // 
            this.familiaBindingSource.DataMember = "Familia";
            this.familiaBindingSource.DataSource = this.aCSDataSet21;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.aCSDataSet21;
            // 
            // frmCRUDProductoTerminado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 558);
            this.Controls.Add(this.grdOrigen);
            this.Controls.Add(this.grdPesoSaco);
            this.Controls.Add(this.grdtipoSaco);
            this.Controls.Add(this.grdFamilia);
            this.Controls.Add(this.grdCategoria);
            this.Controls.Add(this.txtCodSAP);
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.labelControl17);
            this.Controls.Add(this.spinEdit4);
            this.Controls.Add(this.labelControl18);
            this.Controls.Add(this.spinDiasMinimos);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.spindDiasVenc);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtTamano);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtFormula);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDescrpcionTecnica);
            this.Controls.Add(this.txtDescripcionFacturacion);
            this.Controls.Add(this.toggleSwitchEspecie);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.cmdGuardar);
            this.Name = "frmCRUDProductoTerminado";
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchEspecie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionFacturacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescrpcionTecnica.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTamano.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spindDiasVenc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiasMinimos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodSAP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFamilia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdtipoSaco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesoSaco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrigen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCSDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolsasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portafolioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void GenerarCodigo()
        {
            ProductoTerminado prod = new ProductoTerminado(dp.ConnectionStringCostos);
            try
            {
                if (toggleSwitchEspecie.IsOn)//Camaraon
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toggleSwitchEspecie_Toggled(object sender, EventArgs e)
        {
            GenerarCodigo();
        }
    }
}