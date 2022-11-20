namespace LOSA.MigracionACS.Produccion.Eficiencia
{
    partial class PRB_Lote_Pick_v3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRB_Lote_Pick_v3));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btncerrar = new DevExpress.XtraBars.BarButtonItem();
            this.btnactualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnselec = new DevExpress.XtraBars.BarButtonItem();
            this.pRB_DATA2 = new LOSA.MigracionACS.DataSetx.PRB_DATA();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfp_lot_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorder_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdCancelar = new DevExpress.XtraEditors.ButtonEdit();
            this.cmdGuardar = new DevExpress.XtraEditors.ButtonEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.spinSacosProducidos = new DevExpress.XtraEditors.SpinEdit();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.binPresentaciones = new System.Windows.Forms.BindingSource(this.components);
            this.dsEficiencia1 = new LOSA.MigracionACS.Produccion.DataSet_.dsEficiencia();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRB_DATA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCancelar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSacosProducidos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binPresentaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEficiencia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btncerrar,
            this.btnactualizar,
            this.btnselec});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(701, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 462);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(701, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 462);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(701, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 462);
            // 
            // btncerrar
            // 
            this.btncerrar.Caption = "Cerrar";
            this.btncerrar.Id = 0;
            this.btncerrar.ImageOptions.Image = global::LOSA.Properties.Resources.cancel2_32;
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncerrar_ItemClick);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Caption = "Actualizar";
            this.btnactualizar.Id = 1;
            this.btnactualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.ImageOptions.Image")));
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnactualizar_ItemClick);
            // 
            // btnselec
            // 
            this.btnselec.Caption = "Seleccionar";
            this.btnselec.Id = 2;
            this.btnselec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnselec.ImageOptions.Image")));
            this.btnselec.Name = "btnselec";
            this.btnselec.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnselec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnselec_ItemClick);
            // 
            // pRB_DATA2
            // 
            this.pRB_DATA2.DataSetName = "PRB_DATA2";
            this.pRB_DATA2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "loadlot";
            this.gridControl1.DataSource = this.pRB_DATA2;
            this.gridControl1.Location = new System.Drawing.Point(1, 100);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(699, 361);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfp_lot_number,
            this.colDescripcion,
            this.colDataColumn2,
            this.colorder_number});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick_1);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick_1);
            // 
            // colfp_lot_number
            // 
            this.colfp_lot_number.Caption = "Lote #";
            this.colfp_lot_number.FieldName = "fp_lot_number";
            this.colfp_lot_number.Name = "colfp_lot_number";
            this.colfp_lot_number.OptionsColumn.AllowEdit = false;
            this.colfp_lot_number.Visible = true;
            this.colfp_lot_number.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colDataColumn2
            // 
            this.colDataColumn2.Caption = "Codigo";
            this.colDataColumn2.FieldName = "Codigo";
            this.colDataColumn2.Name = "colDataColumn2";
            this.colDataColumn2.OptionsColumn.AllowEdit = false;
            this.colDataColumn2.Visible = true;
            this.colDataColumn2.VisibleIndex = 2;
            // 
            // colorder_number
            // 
            this.colorder_number.Caption = "# Orden";
            this.colorder_number.FieldName = "order_number";
            this.colorder_number.Name = "colorder_number";
            this.colorder_number.Visible = true;
            this.colorder_number.VisibleIndex = 3;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancelar.EditValue = "Cancelar";
            this.cmdCancelar.Location = new System.Drawing.Point(586, 4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Properties.Appearance.BackColor = System.Drawing.Color.LightCoral;
            this.cmdCancelar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Properties.Appearance.Options.UseBackColor = true;
            this.cmdCancelar.Properties.Appearance.Options.UseFont = true;
            this.cmdCancelar.Properties.Appearance.Options.UseTextOptions = true;
            this.cmdCancelar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmdCancelar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdCancelar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdCancelar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmdCancelar.Size = new System.Drawing.Size(112, 36);
            this.cmdCancelar.TabIndex = 72;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGuardar.EditValue = "Aceptar";
            this.cmdGuardar.Location = new System.Drawing.Point(450, 4);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Properties.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.cmdGuardar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Properties.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Properties.Appearance.Options.UseFont = true;
            this.cmdGuardar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            this.cmdGuardar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdGuardar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmdGuardar.Size = new System.Drawing.Size(112, 36);
            this.cmdGuardar.TabIndex = 71;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(414, 76);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(177, 18);
            this.labelControl5.TabIndex = 81;
            this.labelControl5.Text = "Cantidad de Sacos_______";
            // 
            // spinSacosProducidos
            // 
            this.spinSacosProducidos.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinSacosProducidos.Location = new System.Drawing.Point(552, 70);
            this.spinSacosProducidos.MenuManager = this.barManager1;
            this.spinSacosProducidos.Name = "spinSacosProducidos";
            this.spinSacosProducidos.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.spinSacosProducidos.Properties.Appearance.Options.UseFont = true;
            this.spinSacosProducidos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSacosProducidos.Properties.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spinSacosProducidos.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinSacosProducidos.Size = new System.Drawing.Size(148, 24);
            this.spinSacosProducidos.TabIndex = 82;
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.EditValue = "";
            this.gridLookUpEdit1.Location = new System.Drawing.Point(156, 70);
            this.gridLookUpEdit1.MenuManager = this.barManager1;
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gridLookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.binPresentaciones;
            this.gridLookUpEdit1.Properties.DisplayMember = "descripcion";
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Properties.ValueMember = "id";
            this.gridLookUpEdit1.Size = new System.Drawing.Size(148, 24);
            this.gridLookUpEdit1.TabIndex = 87;
            this.gridLookUpEdit1.EditValueChanged += new System.EventHandler(this.gridLookUpEdit1_EditValueChanged);
            // 
            // binPresentaciones
            // 
            this.binPresentaciones.DataMember = "presentacion_sacos";
            this.binPresentaciones.DataSource = this.dsEficiencia1;
            // 
            // dsEficiencia1
            // 
            this.dsEficiencia1.DataSetName = "dsEficiencia";
            this.dsEficiencia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion1,
            this.colvalor});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.Caption = "Presentación";
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
            // 
            // colvalor
            // 
            this.colvalor.FieldName = "valor";
            this.colvalor.Name = "colvalor";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(18, 76);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(139, 18);
            this.labelControl6.TabIndex = 88;
            this.labelControl6.Text = "Presentación_______";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(362, 33);
            this.labelControl1.TabIndex = 93;
            this.labelControl1.Text = "Registro de Producto Adicional";
            // 
            // PRB_Lote_Pick_v3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 462);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridLookUpEdit1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.spinSacosProducidos);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PRB_Lote_Pick_v3";
            this.Text = "Elige un lote..";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRB_DATA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCancelar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSacosProducidos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binPresentaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEficiencia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btncerrar;
        private DevExpress.XtraBars.BarButtonItem btnactualizar;
        private DevExpress.XtraBars.BarButtonItem btnselec;
        private DataSetx.PRB_DATA pRB_DATA2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colfp_lot_number;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colDataColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colorder_number;
        private DevExpress.XtraEditors.ButtonEdit cmdCancelar;
        private DevExpress.XtraEditors.ButtonEdit cmdGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.SpinEdit spinSacosProducidos;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.BindingSource binPresentaciones;
        private DataSet_.dsEficiencia dsEficiencia1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}