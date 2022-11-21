
namespace LOSA.MigracionACS.Produccion.PlanProductionIntegrated
{
    partial class frmBusarFormula
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusarFormula));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsPlanPRD1 = new LOSA.MigracionACS.Produccion.PlanProductionIntegrated.dsPlanPRD();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colversion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_short = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfml_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colespecie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_c = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_m = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmodificado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chk_ViewDeprecated = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.colSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanPRD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSeleccionar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "formula_list";
            this.gridControl1.DataSource = this.dsPlanPRD1;
            this.gridControl1.Location = new System.Drawing.Point(3, 63);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdSeleccionar});
            this.gridControl1.Size = new System.Drawing.Size(1211, 503);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsPlanPRD1
            // 
            this.dsPlanPRD1.DataSetName = "dsPlanPRD";
            this.dsPlanPRD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcodigo,
            this.colversion,
            this.coltipo_short,
            this.colfml_code,
            this.coltipo,
            this.colnombre,
            this.colespecie,
            this.colfecha_c,
            this.colcreado,
            this.colfecha_m,
            this.colmodificado,
            this.colestado,
            this.colestado_desc,
            this.colSelect});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // colid
            // 
            this.colid.Caption = "Id";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 47;
            // 
            // colcodigo
            // 
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 1;
            this.colcodigo.Width = 88;
            // 
            // colversion
            // 
            this.colversion.FieldName = "version";
            this.colversion.Name = "colversion";
            this.colversion.OptionsColumn.AllowEdit = false;
            this.colversion.Visible = true;
            this.colversion.VisibleIndex = 2;
            this.colversion.Width = 50;
            // 
            // coltipo_short
            // 
            this.coltipo_short.FieldName = "tipo_short";
            this.coltipo_short.Name = "coltipo_short";
            this.coltipo_short.OptionsColumn.AllowEdit = false;
            this.coltipo_short.Visible = true;
            this.coltipo_short.VisibleIndex = 3;
            this.coltipo_short.Width = 70;
            // 
            // colfml_code
            // 
            this.colfml_code.Caption = "Código Fórmula";
            this.colfml_code.FieldName = "fml_code";
            this.colfml_code.Name = "colfml_code";
            this.colfml_code.OptionsColumn.AllowEdit = false;
            this.colfml_code.Width = 93;
            // 
            // coltipo
            // 
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            this.coltipo.OptionsColumn.AllowEdit = false;
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 4;
            this.coltipo.Width = 80;
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 5;
            this.colnombre.Width = 183;
            // 
            // colespecie
            // 
            this.colespecie.FieldName = "especie";
            this.colespecie.Name = "colespecie";
            this.colespecie.OptionsColumn.AllowEdit = false;
            this.colespecie.Visible = true;
            this.colespecie.VisibleIndex = 6;
            // 
            // colfecha_c
            // 
            this.colfecha_c.FieldName = "fecha_c";
            this.colfecha_c.Name = "colfecha_c";
            this.colfecha_c.OptionsColumn.AllowEdit = false;
            this.colfecha_c.Visible = true;
            this.colfecha_c.VisibleIndex = 7;
            this.colfecha_c.Width = 73;
            // 
            // colcreado
            // 
            this.colcreado.FieldName = "creado";
            this.colcreado.Name = "colcreado";
            this.colcreado.OptionsColumn.AllowEdit = false;
            this.colcreado.Visible = true;
            this.colcreado.VisibleIndex = 8;
            this.colcreado.Width = 83;
            // 
            // colfecha_m
            // 
            this.colfecha_m.FieldName = "fecha_m";
            this.colfecha_m.Name = "colfecha_m";
            this.colfecha_m.OptionsColumn.AllowEdit = false;
            this.colfecha_m.Visible = true;
            this.colfecha_m.VisibleIndex = 9;
            this.colfecha_m.Width = 83;
            // 
            // colmodificado
            // 
            this.colmodificado.FieldName = "modificado";
            this.colmodificado.Name = "colmodificado";
            this.colmodificado.OptionsColumn.AllowEdit = false;
            this.colmodificado.Visible = true;
            this.colmodificado.VisibleIndex = 10;
            this.colmodificado.Width = 83;
            // 
            // colestado
            // 
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 11;
            this.colestado.Width = 79;
            // 
            // colestado_desc
            // 
            this.colestado_desc.FieldName = "estado_desc";
            this.colestado_desc.Name = "colestado_desc";
            this.colestado_desc.OptionsColumn.AllowEdit = false;
            this.colestado_desc.Visible = true;
            this.colestado_desc.VisibleIndex = 12;
            this.colestado_desc.Width = 130;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(481, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(206, 30);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Seleccione la Fórmula";
            // 
            // chk_ViewDeprecated
            // 
            this.chk_ViewDeprecated.Caption = "Descontinuadas (Ver)";
            this.chk_ViewDeprecated.Id = 13;
            this.chk_ViewDeprecated.Name = "chk_ViewDeprecated";
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "Descontinuadas (Ver)";
            this.barToggleSwitchItem1.Id = 13;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleSwitch1.Location = new System.Drawing.Point(1109, 1);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch1.Properties.OffText = "No";
            this.toggleSwitch1.Properties.OnText = "Si";
            this.toggleSwitch1.Size = new System.Drawing.Size(95, 26);
            this.toggleSwitch1.TabIndex = 2;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(988, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(116, 17);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ver Descontinuadas";
            // 
            // radioGroup1
            // 
            this.radioGroup1.EditValue = 1;
            this.radioGroup1.Location = new System.Drawing.Point(1050, 28);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup1.Properties.Appearance.Options.UseFont = true;
            this.radioGroup1.Properties.Columns = 2;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Tilapia"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Camarón")});
            this.radioGroup1.Size = new System.Drawing.Size(154, 29);
            this.radioGroup1.TabIndex = 4;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(988, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 17);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Especie";
            // 
            // colSelect
            // 
            this.colSelect.Caption = "Seleccionar";
            this.colSelect.ColumnEdit = this.cmdSeleccionar;
            this.colSelect.Name = "colSelect";
            this.colSelect.Visible = true;
            this.colSelect.VisibleIndex = 13;
            // 
            // cmdSeleccionar
            // 
            this.cmdSeleccionar.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.cmdSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdSeleccionar.Name = "cmdSeleccionar";
            this.cmdSeleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdSeleccionar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdSeleccionar_ButtonClick);
            // 
            // frmBusarFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 567);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.radioGroup1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmBusarFormula";
            this.Text = "Buscar Fórmula";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanPRD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSeleccionar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsPlanPRD dsPlanPRD1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colversion;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_short;
        private DevExpress.XtraGrid.Columns.GridColumn colfml_code;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colespecie;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_c;
        private DevExpress.XtraGrid.Columns.GridColumn colcreado;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_m;
        private DevExpress.XtraGrid.Columns.GridColumn colmodificado;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_desc;
        private DevExpress.XtraBars.BarToggleSwitchItem chk_ViewDeprecated;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colSelect;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdSeleccionar;
        public DevExpress.XtraEditors.RadioGroup radioGroup1;
    }
}