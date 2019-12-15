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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.tabOpciones = new DevExpress.XtraTab.XtraTabControl();
            this.TabMontacarga = new DevExpress.XtraTab.XtraTabPage();
            this.cmdRequisiciones = new DevExpress.XtraEditors.SimpleButton();
            this.btnCambiarUbicacion = new DevExpress.XtraEditors.SimpleButton();
            this.TabLogistica = new DevExpress.XtraTab.XtraTabPage();
            this.btnLotesXMP = new DevExpress.XtraEditors.SimpleButton();
            this.btnLote = new DevExpress.XtraEditors.SimpleButton();
            this.btnAjustesKardex = new DevExpress.XtraEditors.SimpleButton();
            this.btnDevolciones = new DevExpress.XtraEditors.SimpleButton();
            this.cmdProgramaRequisiciones = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRegistroLote = new DevExpress.XtraEditors.SimpleButton();
            this.btnMantenimientoLogistica = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRecepcionMPLogistica = new DevExpress.XtraEditors.SimpleButton();
            this.TabCalidad = new DevExpress.XtraTab.XtraTabPage();
            this.TabAdmin = new DevExpress.XtraTab.XtraTabPage();
            this.btnEstadosRequisiciones = new DevExpress.XtraEditors.SimpleButton();
            this.btnKardexTiposTransacciones = new DevExpress.XtraEditors.SimpleButton();
            this.btnEstadosProgramacionesRequisiciones = new DevExpress.XtraEditors.SimpleButton();
            this.btnTiposPresentaciones = new DevExpress.XtraEditors.SimpleButton();
            this.btnBodegas = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnAlimentacionManual = new DevExpress.XtraEditors.SimpleButton();
            this.btnVerLotes = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabOpciones)).BeginInit();
            this.tabOpciones.SuspendLayout();
            this.TabMontacarga.SuspendLayout();
            this.TabLogistica.SuspendLayout();
            this.TabAdmin.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = global::LOSA.Properties.Resources.wrench;
            this.simpleButton1.Location = new System.Drawing.Point(9, 271);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(199, 71);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Mantenimiento";
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.ImageOptions.Image = global::LOSA.Properties.Resources.check_in;
            this.simpleButton2.Location = new System.Drawing.Point(9, 11);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(199, 71);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Ingreso MP";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
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
            this.xtraTabPage1});
            // 
            // TabMontacarga
            // 
            this.TabMontacarga.Controls.Add(this.cmdRequisiciones);
            this.TabMontacarga.Controls.Add(this.btnCambiarUbicacion);
            this.TabMontacarga.Controls.Add(this.simpleButton1);
            this.TabMontacarga.Controls.Add(this.simpleButton2);
            this.TabMontacarga.Image = ((System.Drawing.Image)(resources.GetObject("TabMontacarga.Image")));
            this.TabMontacarga.Name = "TabMontacarga";
            this.TabMontacarga.PageVisible = false;
            this.TabMontacarga.Size = new System.Drawing.Size(629, 422);
            this.TabMontacarga.Text = "MontaCarga";
            // 
            // cmdRequisiciones
            // 
            this.cmdRequisiciones.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRequisiciones.Appearance.Options.UseFont = true;
            this.cmdRequisiciones.Appearance.Options.UseTextOptions = true;
            this.cmdRequisiciones.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.cmdRequisiciones.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRequisiciones.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRequisiciones.ImageOptions.Image")));
            this.cmdRequisiciones.Location = new System.Drawing.Point(9, 185);
            this.cmdRequisiciones.Name = "cmdRequisiciones";
            this.cmdRequisiciones.Size = new System.Drawing.Size(199, 71);
            this.cmdRequisiciones.TabIndex = 9;
            this.cmdRequisiciones.Text = "Requisiciones";
            // 
            // btnCambiarUbicacion
            // 
            this.btnCambiarUbicacion.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarUbicacion.Appearance.Options.UseFont = true;
            this.btnCambiarUbicacion.Appearance.Options.UseTextOptions = true;
            this.btnCambiarUbicacion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnCambiarUbicacion.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCambiarUbicacion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiarUbicacion.ImageOptions.Image")));
            this.btnCambiarUbicacion.Location = new System.Drawing.Point(9, 98);
            this.btnCambiarUbicacion.Name = "btnCambiarUbicacion";
            this.btnCambiarUbicacion.Size = new System.Drawing.Size(199, 71);
            this.btnCambiarUbicacion.TabIndex = 8;
            this.btnCambiarUbicacion.Text = "Cambiar Ubicacion";
            this.btnCambiarUbicacion.Click += new System.EventHandler(this.BtnCambiarUbicacion_Click);
            // 
            // TabLogistica
            // 
            this.TabLogistica.Controls.Add(this.btnVerLotes);
            this.TabLogistica.Controls.Add(this.btnLotesXMP);
            this.TabLogistica.Controls.Add(this.btnLote);
            this.TabLogistica.Controls.Add(this.btnAjustesKardex);
            this.TabLogistica.Controls.Add(this.btnDevolciones);
            this.TabLogistica.Controls.Add(this.cmdProgramaRequisiciones);
            this.TabLogistica.Controls.Add(this.cmdRegistroLote);
            this.TabLogistica.Controls.Add(this.btnMantenimientoLogistica);
            this.TabLogistica.Controls.Add(this.cmdRecepcionMPLogistica);
            this.TabLogistica.Image = global::LOSA.Properties.Resources.box;
            this.TabLogistica.Name = "TabLogistica";
            this.TabLogistica.PageVisible = false;
            this.TabLogistica.Size = new System.Drawing.Size(629, 422);
            this.TabLogistica.Text = "Logistica";
            // 
            // btnLotesXMP
            // 
            this.btnLotesXMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLotesXMP.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLotesXMP.Appearance.Options.UseFont = true;
            this.btnLotesXMP.Appearance.Options.UseTextOptions = true;
            this.btnLotesXMP.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnLotesXMP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLotesXMP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLotesXMP.ImageOptions.Image")));
            this.btnLotesXMP.Location = new System.Drawing.Point(424, 96);
            this.btnLotesXMP.Name = "btnLotesXMP";
            this.btnLotesXMP.Size = new System.Drawing.Size(199, 71);
            this.btnLotesXMP.TabIndex = 15;
            this.btnLotesXMP.Text = "Ver Lotes por Materia Prima";
            this.btnLotesXMP.Click += new System.EventHandler(this.btnLotesXMP_Click);
            // 
            // btnLote
            // 
            this.btnLote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLote.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLote.Appearance.Options.UseFont = true;
            this.btnLote.Appearance.Options.UseTextOptions = true;
            this.btnLote.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnLote.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLote.ImageOptions.Image")));
            this.btnLote.Location = new System.Drawing.Point(424, 15);
            this.btnLote.Name = "btnLote";
            this.btnLote.Size = new System.Drawing.Size(199, 71);
            this.btnLote.TabIndex = 14;
            this.btnLote.Text = "Ver Lotes por Proveedor";
            this.btnLote.Click += new System.EventHandler(this.BtnLote_Click);
            // 
            // btnAjustesKardex
            // 
            this.btnAjustesKardex.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustesKardex.Appearance.Options.UseFont = true;
            this.btnAjustesKardex.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAjustesKardex.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAjustesKardex.ImageOptions.Image")));
            this.btnAjustesKardex.Location = new System.Drawing.Point(9, 258);
            this.btnAjustesKardex.Name = "btnAjustesKardex";
            this.btnAjustesKardex.Size = new System.Drawing.Size(199, 71);
            this.btnAjustesKardex.TabIndex = 13;
            this.btnAjustesKardex.Text = "Ajustes Kardex";
            this.btnAjustesKardex.Click += new System.EventHandler(this.BtnAjustesKardex_Click);
            // 
            // btnDevolciones
            // 
            this.btnDevolciones.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolciones.Appearance.Options.UseFont = true;
            this.btnDevolciones.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnDevolciones.ImageOptions.Image = global::LOSA.Properties.Resources.devoluciones;
            this.btnDevolciones.Location = new System.Drawing.Point(9, 339);
            this.btnDevolciones.Name = "btnDevolciones";
            this.btnDevolciones.Size = new System.Drawing.Size(199, 71);
            this.btnDevolciones.TabIndex = 12;
            this.btnDevolciones.Text = "Devoluciones ";
            this.btnDevolciones.Click += new System.EventHandler(this.BtnDevolciones_Click);
            // 
            // cmdProgramaRequisiciones
            // 
            this.cmdProgramaRequisiciones.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProgramaRequisiciones.Appearance.Options.UseFont = true;
            this.cmdProgramaRequisiciones.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdProgramaRequisiciones.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdProgramaRequisiciones.ImageOptions.Image")));
            this.cmdProgramaRequisiciones.Location = new System.Drawing.Point(9, 177);
            this.cmdProgramaRequisiciones.Name = "cmdProgramaRequisiciones";
            this.cmdProgramaRequisiciones.Size = new System.Drawing.Size(199, 71);
            this.cmdProgramaRequisiciones.TabIndex = 11;
            this.cmdProgramaRequisiciones.Text = "Ordenes de\r\nFabricación";
            this.cmdProgramaRequisiciones.Click += new System.EventHandler(this.cmdProgramaRequisiciones_Click);
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
            // btnMantenimientoLogistica
            // 
            this.btnMantenimientoLogistica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMantenimientoLogistica.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimientoLogistica.Appearance.Options.UseFont = true;
            this.btnMantenimientoLogistica.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnMantenimientoLogistica.ImageOptions.Image = global::LOSA.Properties.Resources.wrench;
            this.btnMantenimientoLogistica.Location = new System.Drawing.Point(424, 258);
            this.btnMantenimientoLogistica.Name = "btnMantenimientoLogistica";
            this.btnMantenimientoLogistica.Size = new System.Drawing.Size(199, 71);
            this.btnMantenimientoLogistica.TabIndex = 8;
            this.btnMantenimientoLogistica.Text = "Mantenimiento";
            this.btnMantenimientoLogistica.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // cmdRecepcionMPLogistica
            // 
            this.cmdRecepcionMPLogistica.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRecepcionMPLogistica.Appearance.Options.UseFont = true;
            this.cmdRecepcionMPLogistica.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRecepcionMPLogistica.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRecepcionMPLogistica.ImageOptions.Image")));
            this.cmdRecepcionMPLogistica.Location = new System.Drawing.Point(9, 96);
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
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnAlimentacionManual);
            this.xtraTabPage1.Image = global::LOSA.Properties.Resources.production;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.PageVisible = false;
            this.xtraTabPage1.Size = new System.Drawing.Size(629, 422);
            this.xtraTabPage1.Text = "Producción";
            // 
            // btnAlimentacionManual
            // 
            this.btnAlimentacionManual.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlimentacionManual.Appearance.Options.UseFont = true;
            this.btnAlimentacionManual.Appearance.Options.UseTextOptions = true;
            this.btnAlimentacionManual.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnAlimentacionManual.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAlimentacionManual.ImageOptions.Image = global::LOSA.Properties.Resources.alimentacion_manual;
            this.btnAlimentacionManual.Location = new System.Drawing.Point(30, 40);
            this.btnAlimentacionManual.Name = "btnAlimentacionManual";
            this.btnAlimentacionManual.Size = new System.Drawing.Size(199, 71);
            this.btnAlimentacionManual.TabIndex = 14;
            this.btnAlimentacionManual.Text = "Alimentación Manual";
            this.btnAlimentacionManual.Click += new System.EventHandler(this.BtnAlimentacionManual_Click);
            // 
            // btnVerLotes
            // 
            this.btnVerLotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerLotes.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerLotes.Appearance.Options.UseFont = true;
            this.btnVerLotes.Appearance.Options.UseTextOptions = true;
            this.btnVerLotes.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnVerLotes.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnVerLotes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.btnVerLotes.Location = new System.Drawing.Point(424, 177);
            this.btnVerLotes.Name = "btnVerLotes";
            this.btnVerLotes.Size = new System.Drawing.Size(199, 71);
            this.btnVerLotes.TabIndex = 16;
            this.btnVerLotes.Text = "Ver Lotes";
            this.btnVerLotes.Click += new System.EventHandler(this.btnVerLotes_Click);
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
            this.xtraTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraTab.XtraTabControl tabOpciones;
        private DevExpress.XtraTab.XtraTabPage TabMontacarga;
        private DevExpress.XtraTab.XtraTabPage TabLogistica;
        private DevExpress.XtraTab.XtraTabPage TabCalidad;
        private DevExpress.XtraTab.XtraTabPage TabAdmin;
        private DevExpress.XtraEditors.SimpleButton btnMantenimientoLogistica;
        private DevExpress.XtraEditors.SimpleButton cmdRecepcionMPLogistica;
        private DevExpress.XtraEditors.SimpleButton btnBodegas;
        private DevExpress.XtraEditors.SimpleButton btnTiposPresentaciones;
        private DevExpress.XtraEditors.SimpleButton btnEstadosProgramacionesRequisiciones;
        private DevExpress.XtraEditors.SimpleButton btnKardexTiposTransacciones;
        private DevExpress.XtraEditors.SimpleButton btnEstadosRequisiciones;
        private DevExpress.XtraEditors.SimpleButton cmdRegistroLote;
        private DevExpress.XtraEditors.SimpleButton btnCambiarUbicacion;
        private DevExpress.XtraEditors.SimpleButton cmdRequisiciones;
        private DevExpress.XtraEditors.SimpleButton cmdProgramaRequisiciones;
        private DevExpress.XtraEditors.SimpleButton btnDevolciones;
        private DevExpress.XtraEditors.SimpleButton btnAjustesKardex;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnAlimentacionManual;
        private DevExpress.XtraEditors.SimpleButton btnLote;
        private DevExpress.XtraEditors.SimpleButton btnLotesXMP;
        private DevExpress.XtraEditors.SimpleButton btnVerLotes;
    }
}