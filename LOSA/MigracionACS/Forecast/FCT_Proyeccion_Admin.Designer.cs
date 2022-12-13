
namespace LOSA.MigracionACS.Forecast
{
    partial class FCT_Proyeccion_Admin
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCT_Proyeccion_Admin));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcProyeccion = new DevExpress.XtraGrid.GridControl();
            this.dsForecastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsForecast_ = new MigracionACS.Forecast.dsForecast_();
            this.gvProyeccion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreated_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colanio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_proyeccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDeshabilitar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeshabilitar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcProyeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForecastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForecast_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProyeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeshabilitar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcProyeccion
            // 
            this.gcProyeccion.DataMember = "Proyeccion";
            this.gcProyeccion.DataSource = this.dsForecastBindingSource;
            this.gcProyeccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcProyeccion.Location = new System.Drawing.Point(0, 83);
            this.gcProyeccion.MainView = this.gvProyeccion;
            this.gcProyeccion.Name = "gcProyeccion";
            this.gcProyeccion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditar,
            this.btnDeshabilitar});
            this.gcProyeccion.Size = new System.Drawing.Size(849, 277);
            this.gcProyeccion.TabIndex = 7;
            this.gcProyeccion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProyeccion});
            // 
            // dsForecastBindingSource
            // 
            this.dsForecastBindingSource.DataSource = this.dsForecast_;
            this.dsForecastBindingSource.Position = 0;
            // 
            // dsForecast_
            // 
            this.dsForecast_.DataSetName = "dsForecast_";
            this.dsForecast_.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvProyeccion
            // 
            this.gvProyeccion.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProyeccion.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvProyeccion.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProyeccion.Appearance.Row.Options.UseFont = true;
            this.gvProyeccion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colcreated_date,
            this.colanio,
            this.coltipo_proyeccion,
            this.gridColumn3,
            this.colEditar,
            this.colDeshabilitar});
            this.gvProyeccion.GridControl = this.gcProyeccion;
            this.gvProyeccion.Name = "gvProyeccion";
            this.gvProyeccion.OptionsCustomization.AllowFilter = false;
            this.gvProyeccion.OptionsCustomization.AllowGroup = false;
            this.gvProyeccion.OptionsView.ShowAutoFilterRow = true;
            this.gvProyeccion.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Width = 107;
            // 
            // colname
            // 
            this.colname.Caption = "Nombre";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 214;
            // 
            // colcreated_date
            // 
            this.colcreated_date.Caption = "Fecha Creación";
            this.colcreated_date.FieldName = "created_date";
            this.colcreated_date.Name = "colcreated_date";
            this.colcreated_date.Visible = true;
            this.colcreated_date.VisibleIndex = 1;
            this.colcreated_date.Width = 114;
            // 
            // colanio
            // 
            this.colanio.Caption = "Año";
            this.colanio.FieldName = "anio";
            this.colanio.Name = "colanio";
            this.colanio.Visible = true;
            this.colanio.VisibleIndex = 2;
            this.colanio.Width = 62;
            // 
            // coltipo_proyeccion
            // 
            this.coltipo_proyeccion.Caption = "Tipo Proyección";
            this.coltipo_proyeccion.FieldName = "tipo_proyeccion";
            this.coltipo_proyeccion.Name = "coltipo_proyeccion";
            this.coltipo_proyeccion.Visible = true;
            this.coltipo_proyeccion.VisibleIndex = 3;
            this.coltipo_proyeccion.Width = 120;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "Comentario";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 175;
            // 
            // colEditar
            // 
            this.colEditar.Caption = "Editar";
            this.colEditar.ColumnEdit = this.btnEditar;
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 5;
            this.colEditar.Width = 62;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.btnEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEditar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditar_ButtonClick);
            // 
            // colDeshabilitar
            // 
            this.colDeshabilitar.Caption = "Deshabilitar";
            this.colDeshabilitar.ColumnEdit = this.btnDeshabilitar;
            this.colDeshabilitar.Name = "colDeshabilitar";
            this.colDeshabilitar.Visible = true;
            this.colDeshabilitar.VisibleIndex = 6;
            this.colDeshabilitar.Width = 84;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnDeshabilitar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDeshabilitar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDeshabilitar_ButtonClick);
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.EditValue = true;
            this.toggleSwitch1.Location = new System.Drawing.Point(184, 53);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "No";
            this.toggleSwitch1.Properties.OnText = "Si";
            this.toggleSwitch1.Size = new System.Drawing.Size(95, 24);
            this.toggleSwitch1.TabIndex = 8;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(184, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 17);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Habilitados";
            // 
            // cmdNew
            // 
            this.cmdNew.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.Appearance.Options.UseFont = true;
            this.cmdNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdNew.ImageOptions.SvgImage")));
            this.cmdNew.Location = new System.Drawing.Point(21, 33);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(103, 44);
            this.cmdNew.TabIndex = 10;
            this.cmdNew.Text = "Nuevo";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(734, 33);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(103, 44);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // FCT_Proyeccion_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 360);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.gcProyeccion);
            this.Name = "FCT_Proyeccion_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyección";
            ((System.ComponentModel.ISupportInitialize)(this.gcProyeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForecastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForecast_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProyeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeshabilitar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcProyeccion;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProyeccion;
        private System.Windows.Forms.BindingSource dsForecastBindingSource;
        private dsForecast_ dsForecast_;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated_date;
        private DevExpress.XtraGrid.Columns.GridColumn colanio;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_proyeccion;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditar;
        private DevExpress.XtraGrid.Columns.GridColumn colDeshabilitar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeshabilitar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}