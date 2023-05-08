namespace LOSA.MigracionACS.Ordenes_Combustible
{
    partial class OC_Perfiles
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OC_Perfiles));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grPerfiles = new DevExpress.XtraGrid.GridControl();
            this.dsOrdenesCombustible1 = new LOSA.MigracionACS.Ordenes_Combustible.dsOrdenesCombustible();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreation_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfuel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colq_orders = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryButtonEditPerfiles = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemOrdenManual = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.collicense_plate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colliters = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_liters = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltanque_lleno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cmdExportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TSPerfiles = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grPerfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrdenesCombustible1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryButtonEditPerfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemOrdenManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TSPerfiles.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grPerfiles
            // 
            this.grPerfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grPerfiles.DataMember = "grPerfiles";
            this.grPerfiles.DataSource = this.dsOrdenesCombustible1;
            this.grPerfiles.Location = new System.Drawing.Point(5, 5);
            this.grPerfiles.MainView = this.gridView1;
            this.grPerfiles.Name = "grPerfiles";
            this.grPerfiles.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryButtonEditPerfiles,
            this.repositoryItemOrdenManual});
            this.grPerfiles.Size = new System.Drawing.Size(1098, 701);
            this.grPerfiles.TabIndex = 0;
            this.grPerfiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsOrdenesCombustible1
            // 
            this.dsOrdenesCombustible1.DataSetName = "dsOrdenesCombustible";
            this.dsOrdenesCombustible1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colcar,
            this.colcreation_date,
            this.colfuel,
            this.colq_orders,
            this.colenable,
            this.gridColumn1,
            this.gridColumn2,
            this.collicense_plate,
            this.colliters,
            this.coltotal_liters,
            this.coltanque_lleno,
            this.gridColumn3});
            this.gridView1.GridControl = this.grPerfiles;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colname
            // 
            this.colname.Caption = "Nombre";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 120;
            // 
            // colcar
            // 
            this.colcar.Caption = "Vehículo";
            this.colcar.FieldName = "car";
            this.colcar.Name = "colcar";
            this.colcar.OptionsColumn.AllowEdit = false;
            this.colcar.Visible = true;
            this.colcar.VisibleIndex = 1;
            this.colcar.Width = 120;
            // 
            // colcreation_date
            // 
            this.colcreation_date.Caption = "Fecha de Creacion";
            this.colcreation_date.FieldName = "creation_date";
            this.colcreation_date.Name = "colcreation_date";
            this.colcreation_date.OptionsColumn.AllowEdit = false;
            this.colcreation_date.Visible = true;
            this.colcreation_date.VisibleIndex = 3;
            this.colcreation_date.Width = 158;
            // 
            // colfuel
            // 
            this.colfuel.Caption = "Combustible";
            this.colfuel.FieldName = "fuel";
            this.colfuel.Name = "colfuel";
            this.colfuel.OptionsColumn.AllowEdit = false;
            this.colfuel.Visible = true;
            this.colfuel.VisibleIndex = 4;
            this.colfuel.Width = 109;
            // 
            // colq_orders
            // 
            this.colq_orders.Caption = "Numero de Ordenes";
            this.colq_orders.FieldName = "q_orders";
            this.colq_orders.Name = "colq_orders";
            this.colq_orders.OptionsColumn.AllowEdit = false;
            this.colq_orders.Visible = true;
            this.colq_orders.VisibleIndex = 5;
            this.colq_orders.Width = 135;
            // 
            // colenable
            // 
            this.colenable.Caption = "Estado";
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.Width = 114;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.repositoryButtonEditPerfiles;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 10;
            this.gridColumn1.Width = 89;
            // 
            // repositoryButtonEditPerfiles
            // 
            this.repositoryButtonEditPerfiles.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.repositoryButtonEditPerfiles.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryButtonEditPerfiles.Name = "repositoryButtonEditPerfiles";
            this.repositoryButtonEditPerfiles.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryButtonEditPerfiles.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryButtonEditPerfiles_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Orden Manual";
            this.gridColumn2.ColumnEdit = this.repositoryItemOrdenManual;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 11;
            // 
            // repositoryItemOrdenManual
            // 
            this.repositoryItemOrdenManual.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repositoryItemOrdenManual.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemOrdenManual.Name = "repositoryItemOrdenManual";
            this.repositoryItemOrdenManual.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemOrdenManual.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemOrdenManual_ButtonClick);
            // 
            // collicense_plate
            // 
            this.collicense_plate.FieldName = "license_plate";
            this.collicense_plate.Name = "collicense_plate";
            this.collicense_plate.Visible = true;
            this.collicense_plate.VisibleIndex = 2;
            // 
            // colliters
            // 
            this.colliters.Caption = "Prom. Litros por Orden";
            this.colliters.DisplayFormat.FormatString = "n2";
            this.colliters.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colliters.FieldName = "liters";
            this.colliters.Name = "colliters";
            this.colliters.Visible = true;
            this.colliters.VisibleIndex = 6;
            // 
            // coltotal_liters
            // 
            this.coltotal_liters.DisplayFormat.FormatString = "n2";
            this.coltotal_liters.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal_liters.FieldName = "total_liters";
            this.coltotal_liters.Name = "coltotal_liters";
            this.coltotal_liters.Visible = true;
            this.coltotal_liters.VisibleIndex = 7;
            // 
            // coltanque_lleno
            // 
            this.coltanque_lleno.Caption = "Tanque Lleno";
            this.coltanque_lleno.FieldName = "tanque_lleno";
            this.coltanque_lleno.Name = "coltanque_lleno";
            this.coltanque_lleno.Visible = true;
            this.coltanque_lleno.VisibleIndex = 9;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Galones";
            this.gridColumn3.DisplayFormat.FormatString = "#0.00";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "galones";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 8;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.grPerfiles);
            this.panelControl1.Location = new System.Drawing.Point(3, 109);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1108, 704);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.cmdExportExcel);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.TSPerfiles);
            this.panelControl2.Controls.Add(this.btnNew);
            this.panelControl2.Controls.Add(this.btnClose);
            this.panelControl2.Location = new System.Drawing.Point(3, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1108, 100);
            this.panelControl2.TabIndex = 2;
            // 
            // cmdExportExcel
            // 
            this.cmdExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExportExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdExportExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdExportExcel.ImageOptions.Image")));
            this.cmdExportExcel.Location = new System.Drawing.Point(908, 26);
            this.cmdExportExcel.Name = "cmdExportExcel";
            this.cmdExportExcel.Size = new System.Drawing.Size(74, 50);
            this.cmdExportExcel.TabIndex = 6;
            this.cmdExportExcel.Text = "Excel";
            this.cmdExportExcel.Click += new System.EventHandler(this.cmdExportExcel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Perfiles";
            // 
            // TSPerfiles
            // 
            this.TSPerfiles.EditValue = true;
            this.TSPerfiles.Location = new System.Drawing.Point(473, 60);
            this.TSPerfiles.Name = "TSPerfiles";
            this.TSPerfiles.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSPerfiles.Properties.Appearance.Options.UseFont = true;
            this.TSPerfiles.Properties.OffText = "Inactivos";
            this.TSPerfiles.Properties.OnText = "Activos";
            this.TSPerfiles.Size = new System.Drawing.Size(141, 26);
            this.TSPerfiles.TabIndex = 4;
            this.TSPerfiles.Toggled += new System.EventHandler(this.TSPerfiles_Toggled);
            // 
            // btnNew
            // 
            this.btnNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(39, 26);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 50);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Crear";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(1013, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 50);
            this.btnClose.TabIndex = 2;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // OC_Perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 814);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.MinimizeBox = false;
            this.Name = "OC_Perfiles";
            ((System.ComponentModel.ISupportInitialize)(this.grPerfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrdenesCombustible1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryButtonEditPerfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemOrdenManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TSPerfiles.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grPerfiles;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private dsOrdenesCombustible dsOrdenesCombustible1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colcar;
        private DevExpress.XtraGrid.Columns.GridColumn colcreation_date;
        private DevExpress.XtraGrid.Columns.GridColumn colfuel;
        private DevExpress.XtraGrid.Columns.GridColumn colq_orders;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryButtonEditPerfiles;
        private DevExpress.XtraEditors.ToggleSwitch TSPerfiles;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemOrdenManual;
        private DevExpress.XtraEditors.SimpleButton cmdExportExcel;
        private DevExpress.XtraGrid.Columns.GridColumn collicense_plate;
        private DevExpress.XtraGrid.Columns.GridColumn colliters;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_liters;
        private DevExpress.XtraGrid.Columns.GridColumn coltanque_lleno;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}