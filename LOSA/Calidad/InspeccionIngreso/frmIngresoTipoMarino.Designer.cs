
namespace LOSA.Calidad.InspeccionIngreso
{
    partial class frmIngresoTipoMarino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoTipoMarino));
            this.grd_origenespecie = new DevExpress.XtraEditors.GridLookUpEdit();
            this.origenespecieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimientoC1 = new LOSA.Calidad.dsMantenimientoC();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliucn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfishsource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.grd_pesca = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.spsustentable = new DevExpress.XtraEditors.SpinEdit();
            this.hyIUCN = new DevExpress.XtraEditors.HyperLinkEdit();
            this.hyfishsource = new DevExpress.XtraEditors.HyperLinkEdit();
            this.txtPLantaSenasa = new DevExpress.XtraEditors.TextEdit();
            this.grd_origen = new DevExpress.XtraEditors.GridLookUpEdit();
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.grd_tipo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tipoingresoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.spTipoporcentaje = new DevExpress.XtraEditors.SpinEdit();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.zonaPescaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grd_origenespecie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenespecieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_pesca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spsustentable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyIUCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyfishsource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPLantaSenasa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_origen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_tipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoingresoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTipoporcentaje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonaPescaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_origenespecie
            // 
            this.grd_origenespecie.Location = new System.Drawing.Point(246, 19);
            this.grd_origenespecie.Name = "grd_origenespecie";
            this.grd_origenespecie.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_origenespecie.Properties.Appearance.Options.UseFont = true;
            this.grd_origenespecie.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_origenespecie.Properties.DataSource = this.origenespecieBindingSource;
            this.grd_origenespecie.Properties.DisplayMember = "nombre";
            this.grd_origenespecie.Properties.PopupView = this.gridLookUpEdit1View;
            this.grd_origenespecie.Properties.ValueMember = "id";
            this.grd_origenespecie.Size = new System.Drawing.Size(160, 24);
            this.grd_origenespecie.TabIndex = 52;
            this.grd_origenespecie.EditValueChanged += new System.EventHandler(this.grd_origenespecie_EditValueChanged);
            // 
            // origenespecieBindingSource
            // 
            this.origenespecieBindingSource.DataMember = "origen_especie";
            this.origenespecieBindingSource.DataSource = this.dsMantenimientoC1;
            // 
            // dsMantenimientoC1
            // 
            this.dsMantenimientoC1.DataSetName = "dsMantenimientoC";
            this.dsMantenimientoC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridLookUpEdit1View.Appearance.Empty.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridLookUpEdit1View.Appearance.FilterPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.FocusedRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridLookUpEdit1View.Appearance.FooterPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridLookUpEdit1View.Appearance.GroupPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridLookUpEdit1View.Appearance.GroupRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridLookUpEdit1View.Appearance.Preview.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridLookUpEdit1View.Appearance.TopNewRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid3,
            this.colnombre,
            this.coliucn,
            this.colfishsource});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid3
            // 
            this.colid3.FieldName = "id";
            this.colid3.Name = "colid3";
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Especie";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            // 
            // coliucn
            // 
            this.coliucn.FieldName = "iucn";
            this.coliucn.Name = "coliucn";
            // 
            // colfishsource
            // 
            this.colfishsource.FieldName = "fishsource";
            this.colfishsource.Name = "colfishsource";
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl21.Appearance.Options.UseFont = true;
            this.labelControl21.Location = new System.Drawing.Point(137, 22);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(91, 17);
            this.labelControl21.TabIndex = 51;
            this.labelControl21.Text = "Origen especie:";
            // 
            // grd_pesca
            // 
            this.grd_pesca.Location = new System.Drawing.Point(246, 49);
            this.grd_pesca.Name = "grd_pesca";
            this.grd_pesca.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.grd_pesca.Properties.Appearance.Options.UseFont = true;
            this.grd_pesca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_pesca.Properties.DataSource = this.zonaPescaBindingSource;
            this.grd_pesca.Properties.DisplayMember = "descripcion";
            this.grd_pesca.Properties.PopupView = this.gridView1;
            this.grd_pesca.Properties.ValueMember = "id";
            this.grd_pesca.Size = new System.Drawing.Size(160, 22);
            this.grd_pesca.TabIndex = 54;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView1.Appearance.Empty.Options.UseFont = true;
            this.gridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid2,
            this.coldescripcion2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid2
            // 
            this.colid2.FieldName = "id";
            this.colid2.Name = "colid2";
            // 
            // coldescripcion2
            // 
            this.coldescripcion2.Caption = "Zona";
            this.coldescripcion2.FieldName = "descripcion";
            this.coldescripcion2.Name = "coldescripcion2";
            this.coldescripcion2.OptionsColumn.AllowEdit = false;
            this.coldescripcion2.Visible = true;
            this.coldescripcion2.VisibleIndex = 0;
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl22.Appearance.Options.UseFont = true;
            this.labelControl22.Location = new System.Drawing.Point(112, 54);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(116, 17);
            this.labelControl22.TabIndex = 53;
            this.labelControl22.Text = "Zona de Pesca FAO:";
            // 
            // spsustentable
            // 
            this.spsustentable.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spsustentable.Location = new System.Drawing.Point(246, 113);
            this.spsustentable.Name = "spsustentable";
            this.spsustentable.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.spsustentable.Properties.Appearance.Options.UseFont = true;
            this.spsustentable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spsustentable.Size = new System.Drawing.Size(160, 22);
            this.spsustentable.TabIndex = 76;
            // 
            // hyIUCN
            // 
            this.hyIUCN.Location = new System.Drawing.Point(246, 196);
            this.hyIUCN.Name = "hyIUCN";
            this.hyIUCN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.hyIUCN.Properties.Appearance.Options.UseFont = true;
            this.hyIUCN.Size = new System.Drawing.Size(160, 22);
            this.hyIUCN.TabIndex = 75;
            // 
            // hyfishsource
            // 
            this.hyfishsource.Location = new System.Drawing.Point(246, 169);
            this.hyfishsource.Name = "hyfishsource";
            this.hyfishsource.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.hyfishsource.Properties.Appearance.Options.UseFont = true;
            this.hyfishsource.Size = new System.Drawing.Size(160, 22);
            this.hyfishsource.TabIndex = 74;
            // 
            // txtPLantaSenasa
            // 
            this.txtPLantaSenasa.Location = new System.Drawing.Point(246, 84);
            this.txtPLantaSenasa.Name = "txtPLantaSenasa";
            this.txtPLantaSenasa.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPLantaSenasa.Properties.Appearance.Options.UseFont = true;
            this.txtPLantaSenasa.Size = new System.Drawing.Size(160, 22);
            this.txtPLantaSenasa.TabIndex = 73;
            // 
            // grd_origen
            // 
            this.grd_origen.Location = new System.Drawing.Point(246, 141);
            this.grd_origen.Name = "grd_origen";
            this.grd_origen.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.grd_origen.Properties.Appearance.Options.UseFont = true;
            this.grd_origen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_origen.Properties.DataSource = this.paisBindingSource;
            this.grd_origen.Properties.DisplayMember = "descripcion";
            this.grd_origen.Properties.PopupView = this.gridView2;
            this.grd_origen.Properties.ValueMember = "id";
            this.grd_origen.Size = new System.Drawing.Size(160, 22);
            this.grd_origen.TabIndex = 72;
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataMember = "pais";
            this.paisBindingSource.DataSource = this.dsMantenimientoC1;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView2.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView2.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView2.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView2.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView2.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView2.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView2.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView2.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView2.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView2.Appearance.GroupRow.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView2.Appearance.Preview.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView2.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid5,
            this.coldescripcion4});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colid5
            // 
            this.colid5.FieldName = "id";
            this.colid5.Name = "colid5";
            // 
            // coldescripcion4
            // 
            this.coldescripcion4.Caption = "Origen";
            this.coldescripcion4.FieldName = "descripcion";
            this.coldescripcion4.Name = "coldescripcion4";
            this.coldescripcion4.Visible = true;
            this.coldescripcion4.VisibleIndex = 0;
            // 
            // labelControl29
            // 
            this.labelControl29.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.labelControl29.Appearance.Options.UseFont = true;
            this.labelControl29.Location = new System.Drawing.Point(147, 199);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(81, 15);
            this.labelControl29.TabIndex = 71;
            this.labelControl29.Text = "Lista roja IUCN:";
            // 
            // labelControl28
            // 
            this.labelControl28.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.labelControl28.Appearance.Options.UseFont = true;
            this.labelControl28.Location = new System.Drawing.Point(119, 173);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(109, 15);
            this.labelControl28.TabIndex = 70;
            this.labelControl28.Text = "Fishsource indicator:";
            // 
            // labelControl25
            // 
            this.labelControl25.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl25.Appearance.Options.UseFont = true;
            this.labelControl25.Location = new System.Drawing.Point(139, 142);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(89, 17);
            this.labelControl25.TabIndex = 69;
            this.labelControl25.Text = "Pais de Origen:";
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl24.Appearance.Options.UseFont = true;
            this.labelControl24.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl24.Location = new System.Drawing.Point(13, 112);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(215, 20);
            this.labelControl24.TabIndex = 68;
            this.labelControl24.Text = "% obtenido de fuentes sustentables:";
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl23.Appearance.Options.UseFont = true;
            this.labelControl23.Appearance.Options.UseTextOptions = true;
            this.labelControl23.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl23.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl23.Location = new System.Drawing.Point(13, 77);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(215, 34);
            this.labelControl23.TabIndex = 67;
            this.labelControl23.Text = "Planta autorizada por SENASA para importar:";
            // 
            // grd_tipo
            // 
            this.grd_tipo.Location = new System.Drawing.Point(246, 236);
            this.grd_tipo.Name = "grd_tipo";
            this.grd_tipo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.grd_tipo.Properties.Appearance.Options.UseFont = true;
            this.grd_tipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_tipo.Properties.DataSource = this.tipoingresoBindingSource;
            this.grd_tipo.Properties.DisplayMember = "descripcion";
            this.grd_tipo.Properties.PopupView = this.gridView3;
            this.grd_tipo.Properties.ValueMember = "id";
            this.grd_tipo.Size = new System.Drawing.Size(160, 22);
            this.grd_tipo.TabIndex = 79;
            // 
            // tipoingresoBindingSource
            // 
            this.tipoingresoBindingSource.DataMember = "tipoingreso";
            this.tipoingresoBindingSource.DataSource = this.dsMantenimientoC1;
            // 
            // gridView3
            // 
            this.gridView3.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView3.Appearance.Empty.Options.UseFont = true;
            this.gridView3.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView3.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView3.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView3.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView3.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView3.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView3.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView3.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView3.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView3.Appearance.GroupRow.Options.UseFont = true;
            this.gridView3.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView3.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView3.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView3.Appearance.Preview.Options.UseFont = true;
            this.gridView3.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView3.Appearance.Row.Options.UseFont = true;
            this.gridView3.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView3.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid4,
            this.coldescripcion3});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colid4
            // 
            this.colid4.FieldName = "id";
            this.colid4.Name = "colid4";
            // 
            // coldescripcion3
            // 
            this.coldescripcion3.Caption = "Tipo";
            this.coldescripcion3.FieldName = "descripcion";
            this.coldescripcion3.Name = "coldescripcion3";
            this.coldescripcion3.Visible = true;
            this.coldescripcion3.VisibleIndex = 0;
            // 
            // labelControl27
            // 
            this.labelControl27.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl27.Appearance.Options.UseFont = true;
            this.labelControl27.Location = new System.Drawing.Point(190, 268);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(38, 13);
            this.labelControl27.TabIndex = 78;
            this.labelControl27.Text = "% Tipo:";
            // 
            // labelControl26
            // 
            this.labelControl26.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl26.Appearance.Options.UseFont = true;
            this.labelControl26.Location = new System.Drawing.Point(202, 240);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(26, 13);
            this.labelControl26.TabIndex = 77;
            this.labelControl26.Text = "Tipo:";
            // 
            // spTipoporcentaje
            // 
            this.spTipoporcentaje.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spTipoporcentaje.Location = new System.Drawing.Point(246, 264);
            this.spTipoporcentaje.Name = "spTipoporcentaje";
            this.spTipoporcentaje.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.spTipoporcentaje.Properties.Appearance.Options.UseFont = true;
            this.spTipoporcentaje.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spTipoporcentaje.Size = new System.Drawing.Size(160, 22);
            this.spTipoporcentaje.TabIndex = 80;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(172, 301);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 35);
            this.btnGuardar.TabIndex = 81;
            this.btnGuardar.Text = "Guardar";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(292, 301);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 82;
            this.btnClose.Text = "Cerrar";
            // 
            // zonaPescaBindingSource
            // 
            this.zonaPescaBindingSource.DataMember = "zonaPesca";
            this.zonaPescaBindingSource.DataSource = this.dsMantenimientoC1;
            // 
            // frmIngresoTipoMarino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 348);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grd_tipo);
            this.Controls.Add(this.labelControl27);
            this.Controls.Add(this.labelControl26);
            this.Controls.Add(this.spTipoporcentaje);
            this.Controls.Add(this.spsustentable);
            this.Controls.Add(this.hyIUCN);
            this.Controls.Add(this.hyfishsource);
            this.Controls.Add(this.txtPLantaSenasa);
            this.Controls.Add(this.grd_origen);
            this.Controls.Add(this.labelControl29);
            this.Controls.Add(this.labelControl28);
            this.Controls.Add(this.labelControl25);
            this.Controls.Add(this.labelControl24);
            this.Controls.Add(this.labelControl23);
            this.Controls.Add(this.grd_pesca);
            this.Controls.Add(this.labelControl22);
            this.Controls.Add(this.grd_origenespecie);
            this.Controls.Add(this.labelControl21);
            this.Name = "frmIngresoTipoMarino";
            this.Text = "frmIngresoTipoMarino";
            ((System.ComponentModel.ISupportInitialize)(this.grd_origenespecie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenespecieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_pesca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spsustentable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyIUCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyfishsource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPLantaSenasa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_origen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_tipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoingresoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTipoporcentaje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonaPescaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit grd_origenespecie;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid3;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn coliucn;
        private DevExpress.XtraGrid.Columns.GridColumn colfishsource;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.GridLookUpEdit grd_pesca;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid2;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion2;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.SpinEdit spsustentable;
        private DevExpress.XtraEditors.HyperLinkEdit hyIUCN;
        private DevExpress.XtraEditors.HyperLinkEdit hyfishsource;
        private DevExpress.XtraEditors.TextEdit txtPLantaSenasa;
        private DevExpress.XtraEditors.GridLookUpEdit grd_origen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colid5;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion4;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.GridLookUpEdit grd_tipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colid4;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion3;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.SpinEdit spTipoporcentaje;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private dsMantenimientoC dsMantenimientoC1;
        private System.Windows.Forms.BindingSource origenespecieBindingSource;
        private System.Windows.Forms.BindingSource paisBindingSource;
        private System.Windows.Forms.BindingSource tipoingresoBindingSource;
        private System.Windows.Forms.BindingSource zonaPescaBindingSource;
    }
}