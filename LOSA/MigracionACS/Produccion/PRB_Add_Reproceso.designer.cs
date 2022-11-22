namespace LOSA.MigracionACS.Produccion
{
    partial class PRB_Add_Reproceso
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
            this.gridLookPresentacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourcePresentaciones = new System.Windows.Forms.BindingSource(this.components);
            this.dsEficiencia1 = new LOSA.MigracionACS.Produccion.DataSet_.dsEficiencia();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblIntruc = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.spinCantidad = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditTotal = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEditLote = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prB_DATA21 = new LOSA.MigracionACS.DataSetx.PRB_DATA();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfp_lot_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookUpEditTipoReproceso = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceTipoReproceso = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitchAplicaReproceso = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookPresentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePresentaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEficiencia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditLote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prB_DATA21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditTipoReproceso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoReproceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchAplicaReproceso.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLookPresentacion
            // 
            this.gridLookPresentacion.EditValue = "";
            this.gridLookPresentacion.Location = new System.Drawing.Point(129, 74);
            this.gridLookPresentacion.Name = "gridLookPresentacion";
            this.gridLookPresentacion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookPresentacion.Properties.Appearance.Options.UseFont = true;
            this.gridLookPresentacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookPresentacion.Properties.DataSource = this.bindingSourcePresentaciones;
            this.gridLookPresentacion.Properties.DisplayMember = "description";
            this.gridLookPresentacion.Properties.PopupView = this.gridView1;
            this.gridLookPresentacion.Properties.ValueMember = "id";
            this.gridLookPresentacion.Size = new System.Drawing.Size(204, 22);
            this.gridLookPresentacion.TabIndex = 17;
            this.gridLookPresentacion.EditValueChanged += new System.EventHandler(this.gridLookPresentacion_EditValueChanged);
            // 
            // bindingSourcePresentaciones
            // 
            this.bindingSourcePresentaciones.DataMember = "presentaciones";
            this.bindingSourcePresentaciones.DataSource = this.dsEficiencia1;
            // 
            // dsEficiencia1
            // 
            this.dsEficiencia1.DataSetName = "dsEficiencia";
            this.dsEficiencia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescription});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescription
            // 
            this.coldescription.Caption = "Elija la Presentación";
            this.coldescription.FieldName = "description";
            this.coldescription.Name = "coldescription";
            this.coldescription.OptionsColumn.AllowEdit = false;
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(193, 16);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Presentación_________________";
            // 
            // lblIntruc
            // 
            this.lblIntruc.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntruc.Appearance.Options.UseFont = true;
            this.lblIntruc.Location = new System.Drawing.Point(12, 52);
            this.lblIntruc.Name = "lblIntruc";
            this.lblIntruc.Size = new System.Drawing.Size(232, 16);
            this.lblIntruc.TabIndex = 15;
            this.lblIntruc.Text = "Agregar un nuevo registro de Reproceso";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 114);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(188, 16);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Cant. Sacos_________________";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(114, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(222, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // spinCantidad
            // 
            this.spinCantidad.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinCantidad.Location = new System.Drawing.Point(129, 109);
            this.spinCantidad.Name = "spinCantidad";
            this.spinCantidad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinCantidad.Properties.Appearance.Options.UseFont = true;
            this.spinCantidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinCantidad.Properties.DisplayFormat.FormatString = "###,##0.00";
            this.spinCantidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinCantidad.Properties.EditFormat.FormatString = "###,##0.00";
            this.spinCantidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinCantidad.Properties.Mask.EditMask = "###,##0.00";
            this.spinCantidad.Size = new System.Drawing.Size(204, 22);
            this.spinCantidad.TabIndex = 22;
            this.spinCantidad.EditValueChanged += new System.EventHandler(this.spinCantidad_EditValueChanged);
            // 
            // spinEditTotal
            // 
            this.spinEditTotal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditTotal.Location = new System.Drawing.Point(129, 147);
            this.spinEditTotal.Name = "spinEditTotal";
            this.spinEditTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEditTotal.Properties.Appearance.Options.UseFont = true;
            this.spinEditTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditTotal.Properties.DisplayFormat.FormatString = "###,##0.00";
            this.spinEditTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditTotal.Properties.EditFormat.FormatString = "###,##0.00";
            this.spinEditTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditTotal.Properties.Mask.EditMask = "###,##0.00";
            this.spinEditTotal.Properties.ReadOnly = true;
            this.spinEditTotal.Size = new System.Drawing.Size(204, 22);
            this.spinEditTotal.TabIndex = 24;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 152);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(149, 16);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Total_________________";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(340, 78);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(18, 16);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Kg.";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 192);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(137, 16);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "Lote________________";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(340, 112);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(52, 16);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "Unidades";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(339, 150);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(18, 16);
            this.labelControl7.TabIndex = 29;
            this.labelControl7.Text = "Kg.";
            // 
            // gridLookUpEditLote
            // 
            this.gridLookUpEditLote.EditValue = "";
            this.gridLookUpEditLote.Location = new System.Drawing.Point(129, 192);
            this.gridLookUpEditLote.Name = "gridLookUpEditLote";
            this.gridLookUpEditLote.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditLote.Properties.DataSource = this.bindingSource1;
            this.gridLookUpEditLote.Properties.DisplayMember = "fp_lot_number";
            this.gridLookUpEditLote.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEditLote.Properties.ValueMember = "fp_lot_number";
            this.gridLookUpEditLote.Size = new System.Drawing.Size(204, 20);
            this.gridLookUpEditLote.TabIndex = 31;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "loadlot";
            this.bindingSource1.DataSource = this.prB_DATA21;
            // 
            // prB_DATA21
            // 
            this.prB_DATA21.DataSetName = "PRB_DATA2";
            this.prB_DATA21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfp_lot_number,
            this.colDescripcion,
            this.colCodigo});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colfp_lot_number
            // 
            this.colfp_lot_number.Caption = "Lote";
            this.colfp_lot_number.FieldName = "fp_lot_number";
            this.colfp_lot_number.Name = "colfp_lot_number";
            this.colfp_lot_number.Visible = true;
            this.colfp_lot_number.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colCodigo
            // 
            this.colCodigo.Caption = "Codigo";
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 2;
            // 
            // gridLookUpEditTipoReproceso
            // 
            this.gridLookUpEditTipoReproceso.EditValue = "";
            this.gridLookUpEditTipoReproceso.Location = new System.Drawing.Point(129, 228);
            this.gridLookUpEditTipoReproceso.Name = "gridLookUpEditTipoReproceso";
            this.gridLookUpEditTipoReproceso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditTipoReproceso.Properties.DataSource = this.bindingSourceTipoReproceso;
            this.gridLookUpEditTipoReproceso.Properties.DisplayMember = "descripcion";
            this.gridLookUpEditTipoReproceso.Properties.PopupView = this.gridView2;
            this.gridLookUpEditTipoReproceso.Properties.ValueMember = "id";
            this.gridLookUpEditTipoReproceso.Size = new System.Drawing.Size(204, 20);
            this.gridLookUpEditTipoReproceso.TabIndex = 33;
            // 
            // bindingSourceTipoReproceso
            // 
            this.bindingSourceTipoReproceso.DataMember = "tipo_reproceso";
            this.bindingSourceTipoReproceso.DataSource = this.prB_DATA21;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coldescripcion1});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.Caption = "Tipo de Reproceso";
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(12, 232);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(220, 16);
            this.labelControl8.TabIndex = 32;
            this.labelControl8.Text = "Tipo de Reproceso________________";
            // 
            // toggleSwitchAplicaReproceso
            // 
            this.toggleSwitchAplicaReproceso.EditValue = true;
            this.toggleSwitchAplicaReproceso.Location = new System.Drawing.Point(129, 12);
            this.toggleSwitchAplicaReproceso.Name = "toggleSwitchAplicaReproceso";
            this.toggleSwitchAplicaReproceso.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitchAplicaReproceso.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitchAplicaReproceso.Properties.OffText = "No";
            this.toggleSwitchAplicaReproceso.Properties.OnText = "Si";
            this.toggleSwitchAplicaReproceso.Size = new System.Drawing.Size(95, 26);
            this.toggleSwitchAplicaReproceso.TabIndex = 34;
            this.toggleSwitchAplicaReproceso.Toggled += new System.EventHandler(this.toggleSwitchAplicaReproceso_Toggled);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(12, 21);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(157, 16);
            this.labelControl9.TabIndex = 35;
            this.labelControl9.Text = "Tiene reproceso_________";
            // 
            // PRB_Add_Reproceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 310);
            this.Controls.Add(this.toggleSwitchAplicaReproceso);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.gridLookUpEditTipoReproceso);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.gridLookUpEditLote);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.spinEditTotal);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.spinCantidad);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gridLookPresentacion);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblIntruc);
            this.Name = "PRB_Add_Reproceso";
            this.Text = "Detalle de Reproceso";
            ((System.ComponentModel.ISupportInitialize)(this.gridLookPresentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePresentaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEficiencia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditLote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prB_DATA21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditTipoReproceso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoReproceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchAplicaReproceso.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit gridLookPresentacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblIntruc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DataSet_.dsEficiencia dsEficiencia1;
        private System.Windows.Forms.BindingSource bindingSourcePresentaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraEditors.SpinEdit spinCantidad;
        private DevExpress.XtraEditors.SpinEdit spinEditTotal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditLote;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DataSetx.PRB_DATA prB_DATA21;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colfp_lot_number;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditTipoReproceso;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.BindingSource bindingSourceTipoReproceso;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchAplicaReproceso;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}