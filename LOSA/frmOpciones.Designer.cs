namespace LOSA
{
    partial class frmOpciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpciones));
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.tabOpciones = new DevExpress.XtraTab.XtraTabControl();
            this.TabMontacarga = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdPT = new DevExpress.XtraEditors.SimpleButton();
            this.cmdMP = new DevExpress.XtraEditors.SimpleButton();
            this.TabLogistica = new DevExpress.XtraTab.XtraTabPage();
            this.btnTrazabilidad = new DevExpress.XtraEditors.SimpleButton();
            this.btnCantidadMP = new DevExpress.XtraEditors.SimpleButton();
            this.btnLotes = new DevExpress.XtraEditors.SimpleButton();
            this.btnLotesXMP = new DevExpress.XtraEditors.SimpleButton();
            this.btnLotesPorProveedor = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRequisiciones_ = new DevExpress.XtraEditors.SimpleButton();
            this.btnAjustesKardex = new DevExpress.XtraEditors.SimpleButton();
            this.cmdOrdenesFabricacion = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRegistroLote = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRecepcionMPLogistica = new DevExpress.XtraEditors.SimpleButton();
            this.TabCalidad = new DevExpress.XtraTab.XtraTabPage();
            this.TabAdmin = new DevExpress.XtraTab.XtraTabPage();
            this.btnEstadosRequisiciones = new DevExpress.XtraEditors.SimpleButton();
            this.btnKardexTiposTransacciones = new DevExpress.XtraEditors.SimpleButton();
            this.btnEstadosProgramacionesRequisiciones = new DevExpress.XtraEditors.SimpleButton();
            this.btnTiposPresentaciones = new DevExpress.XtraEditors.SimpleButton();
            this.btnBodegas = new DevExpress.XtraEditors.SimpleButton();
            this.tabProduccion = new DevExpress.XtraTab.XtraTabPage();
            this.cmdTarimasPT = new DevExpress.XtraEditors.SimpleButton();
            this.btnAlimentacionManual = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabOpciones)).BeginInit();
            this.tabOpciones.SuspendLayout();
            this.TabMontacarga.SuspendLayout();
            this.TabLogistica.SuspendLayout();
            this.TabAdmin.SuspendLayout();
            this.tabProduccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(430, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(199, 71);
            this.cmdHome.TabIndex = 6;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // tabOpciones
            // 
            this.tabOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOpciones.AppearancePage.Header.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOpciones.AppearancePage.Header.Options.UseFont = true;
            this.tabOpciones.Location = new System.Drawing.Point(2, 89);
            this.tabOpciones.Name = "tabOpciones";
            this.tabOpciones.SelectedTabPage = this.TabMontacarga;
            this.tabOpciones.Size = new System.Drawing.Size(635, 469);
            this.tabOpciones.TabIndex = 8;
            this.tabOpciones.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabMontacarga,
            this.TabLogistica,
            this.TabCalidad,
            this.TabAdmin,
            this.tabProduccion});
            // 
            // TabMontacarga
            // 
            this.TabMontacarga.Controls.Add(this.labelControl2);
            this.TabMontacarga.Controls.Add(this.labelControl1);
            this.TabMontacarga.Controls.Add(this.cmdPT);
            this.TabMontacarga.Controls.Add(this.cmdMP);
            this.TabMontacarga.Image = ((System.Drawing.Image)(resources.GetObject("TabMontacarga.Image")));
            this.TabMontacarga.Name = "TabMontacarga";
            this.TabMontacarga.PageVisible = false;
            this.TabMontacarga.Size = new System.Drawing.Size(629, 422);
            this.TabMontacarga.Text = "MontaCarga";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(304, 327);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(196, 63);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Producto Terminado";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(26, 330);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(196, 29);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Materia Prima";
            // 
            // cmdPT
            // 
            this.cmdPT.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdPT.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPT.Appearance.Options.UseBackColor = true;
            this.cmdPT.Appearance.Options.UseFont = true;
            this.cmdPT.Appearance.Options.UseImage = true;
            this.cmdPT.Appearance.Options.UseTextOptions = true;
            this.cmdPT.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmdPT.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.cmdPT.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.cmdPT.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.cmdPT.AppearanceHovered.BackColor2 = System.Drawing.Color.Transparent;
            this.cmdPT.AppearanceHovered.Image = global::LOSA.Properties.Resources.hapag_4_icon;
            this.cmdPT.AppearanceHovered.Options.UseBackColor = true;
            this.cmdPT.AppearanceHovered.Options.UseImage = true;
            this.cmdPT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdPT.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdPT.ImageOptions.Image = global::LOSA.Properties.Resources.Producto_terminado;
            this.cmdPT.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.cmdPT.Location = new System.Drawing.Point(286, 29);
            this.cmdPT.Name = "cmdPT";
            this.cmdPT.Size = new System.Drawing.Size(239, 295);
            this.cmdPT.TabIndex = 11;
            this.cmdPT.Click += new System.EventHandler(this.cmdPT_Click);
            // 
            // cmdMP
            // 
            this.cmdMP.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdMP.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMP.Appearance.Options.UseBackColor = true;
            this.cmdMP.Appearance.Options.UseFont = true;
            this.cmdMP.Appearance.Options.UseImage = true;
            this.cmdMP.Appearance.Options.UseTextOptions = true;
            this.cmdMP.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmdMP.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.cmdMP.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.cmdMP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdMP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdMP.ImageOptions.Image = global::LOSA.Properties.Resources.Materia_Prima;
            this.cmdMP.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.cmdMP.Location = new System.Drawing.Point(10, 29);
            this.cmdMP.Name = "cmdMP";
            this.cmdMP.Size = new System.Drawing.Size(238, 295);
            this.cmdMP.TabIndex = 10;
            this.cmdMP.Click += new System.EventHandler(this.cmdMP_Click);
            // 
            // TabLogistica
            // 
            this.TabLogistica.Controls.Add(this.btnTrazabilidad);
            this.TabLogistica.Controls.Add(this.btnCantidadMP);
            this.TabLogistica.Controls.Add(this.btnLotes);
            this.TabLogistica.Controls.Add(this.btnLotesXMP);
            this.TabLogistica.Controls.Add(this.btnLotesPorProveedor);
            this.TabLogistica.Controls.Add(this.cmdRequisiciones_);
            this.TabLogistica.Controls.Add(this.btnAjustesKardex);
            this.TabLogistica.Controls.Add(this.cmdOrdenesFabricacion);
            this.TabLogistica.Controls.Add(this.cmdRegistroLote);
            this.TabLogistica.Controls.Add(this.simpleButton3);
            this.TabLogistica.Controls.Add(this.cmdRecepcionMPLogistica);
            this.TabLogistica.Image = global::LOSA.Properties.Resources.box;
            this.TabLogistica.Name = "TabLogistica";
            this.TabLogistica.PageVisible = false;
            this.TabLogistica.Size = new System.Drawing.Size(629, 422);
            this.TabLogistica.Text = "Logistica";
            // 
            // btnTrazabilidad
            // 
            this.btnTrazabilidad.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrazabilidad.Appearance.Options.UseFont = true;
            this.btnTrazabilidad.Appearance.Options.UseTextOptions = true;
            this.btnTrazabilidad.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnTrazabilidad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnTrazabilidad.ImageOptions.Image = global::LOSA.Properties.Resources.trazabilidad;
            this.btnTrazabilidad.Location = new System.Drawing.Point(214, 335);
            this.btnTrazabilidad.Name = "btnTrazabilidad";
            this.btnTrazabilidad.Size = new System.Drawing.Size(199, 71);
            this.btnTrazabilidad.TabIndex = 19;
            this.btnTrazabilidad.Text = "Trazabilidad de Lotes";
            this.btnTrazabilidad.Click += new System.EventHandler(this.btnTrazabilidad_Click);
            // 
            // btnCantidadMP
            // 
            this.btnCantidadMP.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantidadMP.Appearance.Options.UseFont = true;
            this.btnCantidadMP.Appearance.Options.UseTextOptions = true;
            this.btnCantidadMP.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnCantidadMP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCantidadMP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCantidadMP.ImageOptions.Image")));
            this.btnCantidadMP.Location = new System.Drawing.Point(214, 255);
            this.btnCantidadMP.Name = "btnCantidadMP";
            this.btnCantidadMP.Size = new System.Drawing.Size(199, 71);
            this.btnCantidadMP.TabIndex = 18;
            this.btnCantidadMP.Text = "Materia Prima En Existencia";
            this.btnCantidadMP.Click += new System.EventHandler(this.btnCantidadMP_Click);
            // 
            // btnLotes
            // 
            this.btnLotes.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLotes.Appearance.Options.UseFont = true;
            this.btnLotes.Appearance.Options.UseTextOptions = true;
            this.btnLotes.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnLotes.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLotes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLotes.ImageOptions.Image")));
            this.btnLotes.Location = new System.Drawing.Point(214, 175);
            this.btnLotes.Name = "btnLotes";
            this.btnLotes.Size = new System.Drawing.Size(199, 71);
            this.btnLotes.TabIndex = 17;
            this.btnLotes.Text = "Ver Lotes";
            this.btnLotes.Click += new System.EventHandler(this.btnLotes_Click);
            // 
            // btnLotesXMP
            // 
            this.btnLotesXMP.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLotesXMP.Appearance.Options.UseFont = true;
            this.btnLotesXMP.Appearance.Options.UseTextOptions = true;
            this.btnLotesXMP.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnLotesXMP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLotesXMP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLotesXMP.ImageOptions.Image")));
            this.btnLotesXMP.Location = new System.Drawing.Point(214, 95);
            this.btnLotesXMP.Name = "btnLotesXMP";
            this.btnLotesXMP.Size = new System.Drawing.Size(199, 71);
            this.btnLotesXMP.TabIndex = 16;
            this.btnLotesXMP.Text = "Ver Lotes Por Materia Prima";
            this.btnLotesXMP.Click += new System.EventHandler(this.btnLotesXMP_Click);
            // 
            // btnLotesPorProveedor
            // 
            this.btnLotesPorProveedor.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLotesPorProveedor.Appearance.Options.UseFont = true;
            this.btnLotesPorProveedor.Appearance.Options.UseTextOptions = true;
            this.btnLotesPorProveedor.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnLotesPorProveedor.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLotesPorProveedor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLotesPorProveedor.ImageOptions.Image")));
            this.btnLotesPorProveedor.Location = new System.Drawing.Point(214, 15);
            this.btnLotesPorProveedor.Name = "btnLotesPorProveedor";
            this.btnLotesPorProveedor.Size = new System.Drawing.Size(199, 71);
            this.btnLotesPorProveedor.TabIndex = 15;
            this.btnLotesPorProveedor.Text = "Ver Lotes Por Proveedor";
            this.btnLotesPorProveedor.Click += new System.EventHandler(this.btnLotesPorProveedor_Click);
            // 
            // cmdRequisiciones_
            // 
            this.cmdRequisiciones_.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRequisiciones_.Appearance.Options.UseFont = true;
            this.cmdRequisiciones_.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRequisiciones_.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRequisiciones_.ImageOptions.Image")));
            this.cmdRequisiciones_.Location = new System.Drawing.Point(9, 255);
            this.cmdRequisiciones_.Name = "cmdRequisiciones_";
            this.cmdRequisiciones_.Size = new System.Drawing.Size(199, 71);
            this.cmdRequisiciones_.TabIndex = 14;
            this.cmdRequisiciones_.Text = "Requisiciones";
            this.cmdRequisiciones_.Click += new System.EventHandler(this.cmdRequisiciones__Click);
            // 
            // btnAjustesKardex
            // 
            this.btnAjustesKardex.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustesKardex.Appearance.Options.UseFont = true;
            this.btnAjustesKardex.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAjustesKardex.ImageOptions.Image = global::LOSA.Properties.Resources.ajustes_kardex;
            this.btnAjustesKardex.Location = new System.Drawing.Point(9, 335);
            this.btnAjustesKardex.Name = "btnAjustesKardex";
            this.btnAjustesKardex.Size = new System.Drawing.Size(199, 71);
            this.btnAjustesKardex.TabIndex = 13;
            this.btnAjustesKardex.Text = "Ajustes Kardex";
            this.btnAjustesKardex.Click += new System.EventHandler(this.BtnAjustesKardex_Click);
            // 
            // cmdOrdenesFabricacion
            // 
            this.cmdOrdenesFabricacion.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOrdenesFabricacion.Appearance.Options.UseFont = true;
            this.cmdOrdenesFabricacion.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdOrdenesFabricacion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdOrdenesFabricacion.ImageOptions.Image")));
            this.cmdOrdenesFabricacion.Location = new System.Drawing.Point(9, 175);
            this.cmdOrdenesFabricacion.Name = "cmdOrdenesFabricacion";
            this.cmdOrdenesFabricacion.Size = new System.Drawing.Size(199, 71);
            this.cmdOrdenesFabricacion.TabIndex = 11;
            this.cmdOrdenesFabricacion.Text = "Ordenes de\r\nFabricación";
            this.cmdOrdenesFabricacion.Click += new System.EventHandler(this.cmdProgramaRequisiciones_Click);
            // 
            // cmdRegistroLote
            // 
            this.cmdRegistroLote.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistroLote.Appearance.Options.UseFont = true;
            this.cmdRegistroLote.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRegistroLote.ImageOptions.Image = global::LOSA.Properties.Resources.edit_table_1_;
            this.cmdRegistroLote.Location = new System.Drawing.Point(9, 15);
            this.cmdRegistroLote.Name = "cmdRegistroLote";
            this.cmdRegistroLote.Size = new System.Drawing.Size(199, 71);
            this.cmdRegistroLote.TabIndex = 10;
            this.cmdRegistroLote.Text = "Registro Lote";
            this.cmdRegistroLote.Click += new System.EventHandler(this.cmdRegistroLote_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton3.ImageOptions.Image = global::LOSA.Properties.Resources.wrench;
            this.simpleButton3.Location = new System.Drawing.Point(419, 15);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(199, 71);
            this.simpleButton3.TabIndex = 8;
            this.simpleButton3.Text = "Mantenimiento";
            this.simpleButton3.Visible = false;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // cmdRecepcionMPLogistica
            // 
            this.cmdRecepcionMPLogistica.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRecepcionMPLogistica.Appearance.Options.UseFont = true;
            this.cmdRecepcionMPLogistica.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRecepcionMPLogistica.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRecepcionMPLogistica.ImageOptions.Image")));
            this.cmdRecepcionMPLogistica.Location = new System.Drawing.Point(9, 95);
            this.cmdRecepcionMPLogistica.Name = "cmdRecepcionMPLogistica";
            this.cmdRecepcionMPLogistica.Size = new System.Drawing.Size(199, 71);
            this.cmdRecepcionMPLogistica.TabIndex = 9;
            this.cmdRecepcionMPLogistica.Text = "Ver Tarimas";
            this.cmdRecepcionMPLogistica.Click += new System.EventHandler(this.cmdRecepcionMPLogistica_Click);
            // 
            // TabCalidad
            // 
            this.TabCalidad.Image = global::LOSA.Properties.Resources.medal;
            this.TabCalidad.Name = "TabCalidad";
            this.TabCalidad.PageVisible = false;
            this.TabCalidad.Size = new System.Drawing.Size(629, 422);
            this.TabCalidad.Text = "Calidad";
            // 
            // TabAdmin
            // 
            this.TabAdmin.Controls.Add(this.btnEstadosRequisiciones);
            this.TabAdmin.Controls.Add(this.btnKardexTiposTransacciones);
            this.TabAdmin.Controls.Add(this.btnEstadosProgramacionesRequisiciones);
            this.TabAdmin.Controls.Add(this.btnTiposPresentaciones);
            this.TabAdmin.Controls.Add(this.btnBodegas);
            this.TabAdmin.Image = global::LOSA.Properties.Resources.admin;
            this.TabAdmin.Name = "TabAdmin";
            this.TabAdmin.PageVisible = false;
            this.TabAdmin.Size = new System.Drawing.Size(629, 422);
            this.TabAdmin.Text = "Administrador";
            // 
            // btnEstadosRequisiciones
            // 
            this.btnEstadosRequisiciones.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadosRequisiciones.Appearance.Options.UseFont = true;
            this.btnEstadosRequisiciones.Appearance.Options.UseTextOptions = true;
            this.btnEstadosRequisiciones.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnEstadosRequisiciones.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnEstadosRequisiciones.Location = new System.Drawing.Point(419, 44);
            this.btnEstadosRequisiciones.Name = "btnEstadosRequisiciones";
            this.btnEstadosRequisiciones.Size = new System.Drawing.Size(204, 71);
            this.btnEstadosRequisiciones.TabIndex = 11;
            this.btnEstadosRequisiciones.Text = "Estados de Requisiciones";
            this.btnEstadosRequisiciones.Click += new System.EventHandler(this.BtnEstadosRequisiciones_Click);
            // 
            // btnKardexTiposTransacciones
            // 
            this.btnKardexTiposTransacciones.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnKardexTiposTransacciones.Appearance.Options.UseFont = true;
            this.btnKardexTiposTransacciones.Appearance.Options.UseTextOptions = true;
            this.btnKardexTiposTransacciones.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnKardexTiposTransacciones.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnKardexTiposTransacciones.Location = new System.Drawing.Point(419, 140);
            this.btnKardexTiposTransacciones.Name = "btnKardexTiposTransacciones";
            this.btnKardexTiposTransacciones.Size = new System.Drawing.Size(204, 71);
            this.btnKardexTiposTransacciones.TabIndex = 10;
            this.btnKardexTiposTransacciones.Text = "Tipos de Transacción (Kardex)";
            this.btnKardexTiposTransacciones.Click += new System.EventHandler(this.BtnKardexTiposTransacciones_Click);
            // 
            // btnEstadosProgramacionesRequisiciones
            // 
            this.btnEstadosProgramacionesRequisiciones.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadosProgramacionesRequisiciones.Appearance.Options.UseFont = true;
            this.btnEstadosProgramacionesRequisiciones.Appearance.Options.UseTextOptions = true;
            this.btnEstadosProgramacionesRequisiciones.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnEstadosProgramacionesRequisiciones.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnEstadosProgramacionesRequisiciones.Location = new System.Drawing.Point(419, 239);
            this.btnEstadosProgramacionesRequisiciones.Name = "btnEstadosProgramacionesRequisiciones";
            this.btnEstadosProgramacionesRequisiciones.Size = new System.Drawing.Size(204, 71);
            this.btnEstadosProgramacionesRequisiciones.TabIndex = 9;
            this.btnEstadosProgramacionesRequisiciones.Text = "Estados de Programación de Requisiciones";
            this.btnEstadosProgramacionesRequisiciones.Click += new System.EventHandler(this.BtnEstadosProgramacionesRequisiciones_Click);
            // 
            // btnTiposPresentaciones
            // 
            this.btnTiposPresentaciones.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiposPresentaciones.Appearance.Options.UseFont = true;
            this.btnTiposPresentaciones.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnTiposPresentaciones.Location = new System.Drawing.Point(9, 140);
            this.btnTiposPresentaciones.Name = "btnTiposPresentaciones";
            this.btnTiposPresentaciones.Size = new System.Drawing.Size(204, 71);
            this.btnTiposPresentaciones.TabIndex = 8;
            this.btnTiposPresentaciones.Text = "Tipos Presentación";
            this.btnTiposPresentaciones.Click += new System.EventHandler(this.BtnTiposPresentaciones_Click);
            // 
            // btnBodegas
            // 
            this.btnBodegas.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBodegas.Appearance.Options.UseFont = true;
            this.btnBodegas.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnBodegas.Location = new System.Drawing.Point(9, 44);
            this.btnBodegas.Name = "btnBodegas";
            this.btnBodegas.Size = new System.Drawing.Size(204, 71);
            this.btnBodegas.TabIndex = 5;
            this.btnBodegas.Text = "Bodegas";
            this.btnBodegas.Click += new System.EventHandler(this.BtnBodegas_Click);
            // 
            // tabProduccion
            // 
            this.tabProduccion.Controls.Add(this.cmdTarimasPT);
            this.tabProduccion.Controls.Add(this.btnAlimentacionManual);
            this.tabProduccion.Image = global::LOSA.Properties.Resources.produccion;
            this.tabProduccion.Name = "tabProduccion";
            this.tabProduccion.PageVisible = false;
            this.tabProduccion.Size = new System.Drawing.Size(629, 422);
            this.tabProduccion.Text = "Producción";
            // 
            // cmdTarimasPT
            // 
            this.cmdTarimasPT.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTarimasPT.Appearance.Options.UseFont = true;
            this.cmdTarimasPT.Appearance.Options.UseTextOptions = true;
            this.cmdTarimasPT.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.cmdTarimasPT.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdTarimasPT.ImageOptions.Image = global::LOSA.Properties.Resources.pallet32px;
            this.cmdTarimasPT.Location = new System.Drawing.Point(19, 114);
            this.cmdTarimasPT.Name = "cmdTarimasPT";
            this.cmdTarimasPT.Size = new System.Drawing.Size(199, 71);
            this.cmdTarimasPT.TabIndex = 10;
            this.cmdTarimasPT.Text = "Tarimas PT";
            this.cmdTarimasPT.Click += new System.EventHandler(this.cmdTarimasPT_Click);
            // 
            // btnAlimentacionManual
            // 
            this.btnAlimentacionManual.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlimentacionManual.Appearance.Options.UseFont = true;
            this.btnAlimentacionManual.Appearance.Options.UseTextOptions = true;
            this.btnAlimentacionManual.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnAlimentacionManual.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAlimentacionManual.ImageOptions.Image = global::LOSA.Properties.Resources.alimentacion_manual;
            this.btnAlimentacionManual.Location = new System.Drawing.Point(19, 23);
            this.btnAlimentacionManual.Name = "btnAlimentacionManual";
            this.btnAlimentacionManual.Size = new System.Drawing.Size(199, 71);
            this.btnAlimentacionManual.TabIndex = 9;
            this.btnAlimentacionManual.Text = "Alimentación Manual";
            this.btnAlimentacionManual.Click += new System.EventHandler(this.btnAlimentacionManual_Click);
            // 
            // frmOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.tabOpciones);
            this.Controls.Add(this.cmdHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOpciones";
            this.Text = "frmOpciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tabOpciones)).EndInit();
            this.tabOpciones.ResumeLayout(false);
            this.TabMontacarga.ResumeLayout(false);
            this.TabLogistica.ResumeLayout(false);
            this.TabAdmin.ResumeLayout(false);
            this.tabProduccion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraTab.XtraTabControl tabOpciones;
        private DevExpress.XtraTab.XtraTabPage TabMontacarga;
        private DevExpress.XtraTab.XtraTabPage TabLogistica;
        private DevExpress.XtraTab.XtraTabPage TabCalidad;
        private DevExpress.XtraTab.XtraTabPage TabAdmin;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton cmdRecepcionMPLogistica;
        private DevExpress.XtraEditors.SimpleButton btnBodegas;
        private DevExpress.XtraEditors.SimpleButton btnTiposPresentaciones;
        private DevExpress.XtraEditors.SimpleButton btnEstadosProgramacionesRequisiciones;
        private DevExpress.XtraEditors.SimpleButton btnKardexTiposTransacciones;
        private DevExpress.XtraEditors.SimpleButton btnEstadosRequisiciones;
        private DevExpress.XtraEditors.SimpleButton cmdRegistroLote;
        private DevExpress.XtraEditors.SimpleButton cmdOrdenesFabricacion;
        private DevExpress.XtraEditors.SimpleButton btnAjustesKardex;
        private DevExpress.XtraEditors.SimpleButton cmdRequisiciones_;
        private DevExpress.XtraEditors.SimpleButton cmdMP;
        private DevExpress.XtraEditors.SimpleButton cmdPT;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage tabProduccion;
        private DevExpress.XtraEditors.SimpleButton btnAlimentacionManual;
        private DevExpress.XtraEditors.SimpleButton btnCantidadMP;
        private DevExpress.XtraEditors.SimpleButton btnLotes;
        private DevExpress.XtraEditors.SimpleButton btnLotesXMP;
        private DevExpress.XtraEditors.SimpleButton btnLotesPorProveedor;
        private DevExpress.XtraEditors.SimpleButton btnTrazabilidad;
        private DevExpress.XtraEditors.SimpleButton cmdTarimasPT;
    }
}