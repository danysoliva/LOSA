
namespace LOSA.MicroIngredientes
{
    partial class xfrmPesajeIndividualBatchV3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmPesajeIndividualBatchV3));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lblBascula1 = new DevExpress.XtraEditors.LabelControl();
            this.lblValorBascula1 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.lblCompletados = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblError = new DevExpress.XtraEditors.LabelControl();
            this.lblSuperior = new DevExpress.XtraEditors.LabelControl();
            this.lblInferior = new DevExpress.XtraEditors.LabelControl();
            this.lblRequerido = new DevExpress.XtraEditors.LabelControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsMicros = new LOSA.MicroIngredientes.dsMicros();
            this.lblValorBascula2 = new DevExpress.XtraEditors.LabelControl();
            this.lblBascula2 = new DevExpress.XtraEditors.LabelControl();
            this.lblMP = new DevExpress.XtraEditors.LabelControl();
            this.btnBascula1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnBascula2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtCodBarra = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsMicrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvPesaje = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tarima_origen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnBasc1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnBasc2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnBascAmbas = new DevExpress.XtraEditors.SimpleButton();
            this.lblLoteName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodBarra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPesaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBascula1
            // 
            this.lblBascula1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBascula1.Appearance.Options.UseFont = true;
            this.lblBascula1.Appearance.Options.UseTextOptions = true;
            this.lblBascula1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBascula1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBascula1.Location = new System.Drawing.Point(0, 163);
            this.lblBascula1.Name = "lblBascula1";
            this.lblBascula1.Size = new System.Drawing.Size(307, 19);
            this.lblBascula1.TabIndex = 20;
            this.lblBascula1.Text = "Báscula:";
            // 
            // lblValorBascula1
            // 
            this.lblValorBascula1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBascula1.Appearance.Options.UseFont = true;
            this.lblValorBascula1.Appearance.Options.UseTextOptions = true;
            this.lblValorBascula1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblValorBascula1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblValorBascula1.Location = new System.Drawing.Point(-1, 188);
            this.lblValorBascula1.Name = "lblValorBascula1";
            this.lblValorBascula1.Size = new System.Drawing.Size(367, 30);
            this.lblValorBascula1.TabIndex = 21;
            this.lblValorBascula1.Text = "Valor en Báscula: 0.00 Kg";
            this.lblValorBascula1.Click += new System.EventHandler(this.lblValorBascula1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuardar.ImageOptions.SvgImage")));
            this.btnGuardar.Location = new System.Drawing.Point(633, 669);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 63);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblCompletados
            // 
            this.lblCompletados.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletados.Appearance.Options.UseFont = true;
            this.lblCompletados.Appearance.Options.UseTextOptions = true;
            this.lblCompletados.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCompletados.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCompletados.Location = new System.Drawing.Point(-1, 705);
            this.lblCompletados.Name = "lblCompletados";
            this.lblCompletados.Size = new System.Drawing.Size(757, 23);
            this.lblCompletados.TabIndex = 24;
            this.lblCompletados.Text = "Asistente";
            // 
            // timer1
            // 
            this.timer1.Interval = 650;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblError.Appearance.Options.UseFont = true;
            this.lblError.Appearance.Options.UseForeColor = true;
            this.lblError.Appearance.Options.UseTextOptions = true;
            this.lblError.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblError.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblError.Location = new System.Drawing.Point(-1, 587);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(757, 26);
            this.lblError.TabIndex = 25;
            this.lblError.Text = "El valor pesado no esta dentro de los limites de tolerancia";
            this.lblError.Visible = false;
            // 
            // lblSuperior
            // 
            this.lblSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSuperior.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblSuperior.Appearance.Options.UseFont = true;
            this.lblSuperior.Appearance.Options.UseForeColor = true;
            this.lblSuperior.Appearance.Options.UseTextOptions = true;
            this.lblSuperior.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblSuperior.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSuperior.Location = new System.Drawing.Point(-1, 628);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(757, 29);
            this.lblSuperior.TabIndex = 26;
            this.lblSuperior.Text = "LS";
            this.lblSuperior.Visible = false;
            // 
            // lblInferior
            // 
            this.lblInferior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInferior.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInferior.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblInferior.Appearance.Options.UseFont = true;
            this.lblInferior.Appearance.Options.UseForeColor = true;
            this.lblInferior.Appearance.Options.UseTextOptions = true;
            this.lblInferior.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblInferior.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblInferior.Location = new System.Drawing.Point(-1, 657);
            this.lblInferior.Name = "lblInferior";
            this.lblInferior.Size = new System.Drawing.Size(757, 32);
            this.lblInferior.TabIndex = 27;
            this.lblInferior.Text = "LI";
            this.lblInferior.Visible = false;
            // 
            // lblRequerido
            // 
            this.lblRequerido.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequerido.Appearance.Options.UseFont = true;
            this.lblRequerido.Appearance.Options.UseTextOptions = true;
            this.lblRequerido.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRequerido.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRequerido.Location = new System.Drawing.Point(-1, 5);
            this.lblRequerido.Name = "lblRequerido";
            this.lblRequerido.Size = new System.Drawing.Size(757, 28);
            this.lblRequerido.TabIndex = 28;
            this.lblRequerido.Text = "Valor Requerido: 0.00 Kg";
            this.lblRequerido.Click += new System.EventHandler(this.lblRequerido_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Pesaje_Bascula";
            this.bindingSource1.DataSource = this.dsMicros;
            // 
            // dsMicros
            // 
            this.dsMicros.DataSetName = "dsMicros";
            this.dsMicros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblValorBascula2
            // 
            this.lblValorBascula2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBascula2.Appearance.Options.UseFont = true;
            this.lblValorBascula2.Appearance.Options.UseTextOptions = true;
            this.lblValorBascula2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblValorBascula2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblValorBascula2.Location = new System.Drawing.Point(391, 188);
            this.lblValorBascula2.Name = "lblValorBascula2";
            this.lblValorBascula2.Size = new System.Drawing.Size(359, 30);
            this.lblValorBascula2.TabIndex = 31;
            this.lblValorBascula2.Text = "Valor en Báscula: 0.00 Kg";
            // 
            // lblBascula2
            // 
            this.lblBascula2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBascula2.Appearance.Options.UseFont = true;
            this.lblBascula2.Appearance.Options.UseTextOptions = true;
            this.lblBascula2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBascula2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBascula2.Location = new System.Drawing.Point(442, 163);
            this.lblBascula2.Name = "lblBascula2";
            this.lblBascula2.Size = new System.Drawing.Size(308, 19);
            this.lblBascula2.TabIndex = 30;
            this.lblBascula2.Text = "Báscula:";
            // 
            // lblMP
            // 
            this.lblMP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMP.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMP.Appearance.Options.UseFont = true;
            this.lblMP.Appearance.Options.UseTextOptions = true;
            this.lblMP.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblMP.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMP.Location = new System.Drawing.Point(0, 334);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(756, 32);
            this.lblMP.TabIndex = 32;
            this.lblMP.Text = "MP Name";
            // 
            // btnBascula1
            // 
            this.btnBascula1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBascula1.Appearance.Options.UseFont = true;
            this.btnBascula1.Enabled = false;
            this.btnBascula1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBascula1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBascula1.ImageOptions.SvgImage")));
            this.btnBascula1.Location = new System.Drawing.Point(105, 230);
            this.btnBascula1.Name = "btnBascula1";
            this.btnBascula1.Size = new System.Drawing.Size(93, 74);
            this.btnBascula1.TabIndex = 1;
            this.btnBascula1.Text = "Guardar";
            this.btnBascula1.Click += new System.EventHandler(this.btnBascula1_Click);
            // 
            // btnBascula2
            // 
            this.btnBascula2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBascula2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBascula2.Appearance.Options.UseFont = true;
            this.btnBascula2.Enabled = false;
            this.btnBascula2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBascula2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBascula2.ImageOptions.SvgImage")));
            this.btnBascula2.Location = new System.Drawing.Point(532, 230);
            this.btnBascula2.Name = "btnBascula2";
            this.btnBascula2.Size = new System.Drawing.Size(93, 74);
            this.btnBascula2.TabIndex = 2;
            this.btnBascula2.Text = "Guardar";
            this.btnBascula2.Click += new System.EventHandler(this.btnBascula2_Click);
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.Location = new System.Drawing.Point(122, 117);
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarra.Properties.Appearance.Options.UseFont = true;
            this.txtCodBarra.Size = new System.Drawing.Size(324, 26);
            this.txtCodBarra.TabIndex = 0;
            this.txtCodBarra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodBarra_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(23, 111);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 32);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Código:";
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdClose.Location = new System.Drawing.Point(670, 5);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 39);
            this.cmdClose.TabIndex = 23;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "MP_Escaneo";
            this.gridControl1.DataSource = this.dsMicrosBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 381);
            this.gridControl1.MainView = this.gvPesaje;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDelete});
            this.gridControl1.Size = new System.Drawing.Size(756, 190);
            this.gridControl1.TabIndex = 38;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPesaje});
            // 
            // dsMicrosBindingSource
            // 
            this.dsMicrosBindingSource.DataSource = this.dsMicros;
            this.dsMicrosBindingSource.Position = 0;
            // 
            // gvPesaje
            // 
            this.gvPesaje.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPesaje.Appearance.FooterPanel.Options.UseFont = true;
            this.gvPesaje.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPesaje.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvPesaje.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPesaje.Appearance.Row.Options.UseFont = true;
            this.gvPesaje.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmp,
            this.collote,
            this.colid_tarima_origen,
            this.colpeso,
            this.colid_mp,
            this.gridColumn1});
            this.gvPesaje.GridControl = this.gridControl1;
            this.gvPesaje.Name = "gvPesaje";
            this.gvPesaje.OptionsView.ShowFooter = true;
            this.gvPesaje.OptionsView.ShowGroupPanel = false;
            // 
            // colmp
            // 
            this.colmp.Caption = "Materia Prima";
            this.colmp.FieldName = "mp";
            this.colmp.Name = "colmp";
            this.colmp.OptionsColumn.AllowEdit = false;
            this.colmp.OptionsFilter.AllowFilter = false;
            this.colmp.Visible = true;
            this.colmp.VisibleIndex = 0;
            this.colmp.Width = 210;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.OptionsFilter.AllowFilter = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 1;
            this.collote.Width = 223;
            // 
            // colid_tarima_origen
            // 
            this.colid_tarima_origen.FieldName = "id_tarima_origen";
            this.colid_tarima_origen.Name = "colid_tarima_origen";
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Peso";
            this.colpeso.DisplayFormat.FormatString = "{0:N2} Kg";
            this.colpeso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.OptionsColumn.AllowEdit = false;
            this.colpeso.OptionsFilter.AllowFilter = false;
            this.colpeso.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "peso", "P. Acumulado={0:N2} Kg")});
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 2;
            this.colpeso.Width = 233;
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.Name = "colid_mp";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Borrar";
            this.gridColumn1.ColumnEdit = this.btnDelete;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 72;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDelete_ButtonClick);
            // 
            // btnBasc1
            // 
            this.btnBasc1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasc1.Appearance.Options.UseFont = true;
            this.btnBasc1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnBasc1.ImageOptions.Image = global::LOSA.Properties.Resources.weighing_machine_32X321;
            this.btnBasc1.Location = new System.Drawing.Point(201, 49);
            this.btnBasc1.Name = "btnBasc1";
            this.btnBasc1.Size = new System.Drawing.Size(112, 49);
            this.btnBasc1.TabIndex = 41;
            this.btnBasc1.Text = "Báscula 1";
            this.btnBasc1.Click += new System.EventHandler(this.btnBasc1_Click);
            // 
            // btnBasc2
            // 
            this.btnBasc2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBasc2.Appearance.Options.UseFont = true;
            this.btnBasc2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnBasc2.ImageOptions.Image = global::LOSA.Properties.Resources.weighing_machine_32X32;
            this.btnBasc2.Location = new System.Drawing.Point(322, 49);
            this.btnBasc2.Name = "btnBasc2";
            this.btnBasc2.Size = new System.Drawing.Size(112, 49);
            this.btnBasc2.TabIndex = 42;
            this.btnBasc2.Text = "Báscula 2";
            this.btnBasc2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnBascAmbas
            // 
            this.btnBascAmbas.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBascAmbas.Appearance.Options.UseFont = true;
            this.btnBascAmbas.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnBascAmbas.ImageOptions.Image = global::LOSA.Properties.Resources.weighing_machine_32X32;
            this.btnBascAmbas.Location = new System.Drawing.Point(443, 49);
            this.btnBascAmbas.Name = "btnBascAmbas";
            this.btnBascAmbas.Size = new System.Drawing.Size(112, 49);
            this.btnBascAmbas.TabIndex = 43;
            this.btnBascAmbas.Text = "Ambas";
            this.btnBascAmbas.Click += new System.EventHandler(this.btnBascAmbas_Click);
            // 
            // lblLoteName
            // 
            this.lblLoteName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoteName.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoteName.Appearance.Options.UseFont = true;
            this.lblLoteName.Appearance.Options.UseTextOptions = true;
            this.lblLoteName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblLoteName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLoteName.Location = new System.Drawing.Point(-1, 308);
            this.lblLoteName.Name = "lblLoteName";
            this.lblLoteName.Size = new System.Drawing.Size(757, 32);
            this.lblLoteName.TabIndex = 44;
            // 
            // xfrmPesajeIndividualBatchV3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 777);
            this.Controls.Add(this.lblCompletados);
            this.Controls.Add(this.lblLoteName);
            this.Controls.Add(this.btnBascAmbas);
            this.Controls.Add(this.btnBasc2);
            this.Controls.Add(this.btnBasc1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCodBarra);
            this.Controls.Add(this.btnBascula2);
            this.Controls.Add(this.btnBascula1);
            this.Controls.Add(this.lblMP);
            this.Controls.Add(this.lblValorBascula2);
            this.Controls.Add(this.lblBascula2);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.lblInferior);
            this.Controls.Add(this.lblSuperior);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblValorBascula1);
            this.Controls.Add(this.lblBascula1);
            this.Controls.Add(this.lblRequerido);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "xfrmPesajeIndividualBatchV3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xfrmPesajeIndividualBatch";
            this.Load += new System.EventHandler(this.xfrmPesajeIndividualBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodBarra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPesaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblValorBascula1;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.LabelControl lblCompletados;
        private DevExpress.XtraEditors.LabelControl lblBascula1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl lblError;
        private DevExpress.XtraEditors.LabelControl lblSuperior;
        private DevExpress.XtraEditors.LabelControl lblInferior;
        private DevExpress.XtraEditors.LabelControl lblRequerido;
        private System.Windows.Forms.BindingSource bindingSource1;
        private dsMicros dsMicros;
        private DevExpress.XtraEditors.LabelControl lblValorBascula2;
        private DevExpress.XtraEditors.LabelControl lblBascula2;
        private DevExpress.XtraEditors.LabelControl lblMP;
        private DevExpress.XtraEditors.SimpleButton btnBascula1;
        private DevExpress.XtraEditors.SimpleButton btnBascula2;
        private DevExpress.XtraEditors.TextEdit txtCodBarra;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPesaje;
        private System.Windows.Forms.BindingSource dsMicrosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colmp;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tarima_origen;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnBasc1;
        private DevExpress.XtraEditors.SimpleButton btnBasc2;
        private DevExpress.XtraEditors.SimpleButton btnBascAmbas;
        private DevExpress.XtraEditors.LabelControl lblLoteName;
    }
}