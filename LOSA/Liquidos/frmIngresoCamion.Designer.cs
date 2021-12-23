using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Liquidos
{
    partial class frmIngresoCamion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoCamion));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dtFechaIngreso = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMP_Name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoMP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.camionesINBindingSource = new System.Windows.Forms.BindingSource();
            this.dsLiquidos_ = new LOSA.Liquidos.dsLiquidos_();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresaTrans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaEntra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colshipid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEditBarco = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bindingSource1 = new System.Windows.Forms.BindingSource();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNBoleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPesoBruto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_ubicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridLookUpEditUbicaciones = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.ubicacionLiquidosBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPesonetoIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPesoProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpesoSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconductorin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvehiculo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfurgon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoBoleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipo_boleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSNegocio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Registrar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingSourceUbicaciones = new System.Windows.Forms.BindingSource();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGenerarIngreso = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.barcosBindingSource = new System.Windows.Forms.BindingSource();
            this.grdUbicaciones = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrack = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ubicacionesgranelBindingSource = new System.Windows.Forms.BindingSource();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.chnuevoIngreso = new DevExpress.XtraEditors.CheckEdit();
            this.txtingreso = new DevExpress.XtraEditors.TextEdit();
            this.lblingreso = new DevExpress.XtraEditors.LabelControl();
            this.btningreso = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtLote = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtDisponible = new DevExpress.XtraEditors.TextEdit();
            this.txtAltanque = new DevExpress.XtraEditors.TextEdit();
            this.txtEnTarimas = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalIngreso = new DevExpress.XtraEditors.TextEdit();
            this.txtEspacioOcupado = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtcapacidad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.colEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIngreso.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIngreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMP_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoMP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camionesINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLiquidos_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditBarco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditUbicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionLiquidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUbicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUbicaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesgranelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chnuevoIngreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtingreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisponible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltanque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnTarimas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalIngreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEspacioOcupado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcapacidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFechaIngreso
            // 
            this.dtFechaIngreso.EditValue = null;
            this.dtFechaIngreso.Enabled = false;
            this.dtFechaIngreso.Location = new System.Drawing.Point(210, 79);
            this.dtFechaIngreso.Name = "dtFechaIngreso";
            this.dtFechaIngreso.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaIngreso.Properties.Appearance.Options.UseFont = true;
            this.dtFechaIngreso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaIngreso.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaIngreso.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaIngreso.Properties.MinValue = new System.DateTime(2019, 11, 1, 0, 0, 0, 0);
            this.dtFechaIngreso.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaIngreso.Size = new System.Drawing.Size(410, 30);
            this.dtFechaIngreso.TabIndex = 77;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(20, 85);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(189, 25);
            this.labelControl5.TabIndex = 76;
            this.labelControl5.Text = "Fecha Ingreso_________";
            // 
            // txtMP_Name
            // 
            this.txtMP_Name.EditValue = "";
            this.txtMP_Name.Enabled = false;
            this.txtMP_Name.Location = new System.Drawing.Point(346, 42);
            this.txtMP_Name.Name = "txtMP_Name";
            this.txtMP_Name.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtMP_Name.Properties.Appearance.Options.UseFont = true;
            this.txtMP_Name.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMP_Name.Size = new System.Drawing.Size(274, 32);
            this.txtMP_Name.TabIndex = 72;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(20, 50);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(199, 25);
            this.labelControl3.TabIndex = 71;
            this.labelControl3.Text = "Materia Prima__________";
            // 
            // txtCodigoMP
            // 
            this.txtCodigoMP.EditValue = "";
            this.txtCodigoMP.Enabled = false;
            this.txtCodigoMP.Location = new System.Drawing.Point(210, 42);
            this.txtCodigoMP.Name = "txtCodigoMP";
            this.txtCodigoMP.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtCodigoMP.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoMP.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoMP.Size = new System.Drawing.Size(130, 32);
            this.txtCodigoMP.TabIndex = 70;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(79, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(819, 31);
            this.labelControl1.TabIndex = 92;
            this.labelControl1.Text = "Registro Tanque";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.camionesINBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 228);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEditBarco,
            this.GridLookUpEditUbicaciones,
            this.btnEliminar});
            this.gridControl1.Size = new System.Drawing.Size(989, 254);
            this.gridControl1.TabIndex = 93;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // camionesINBindingSource
            // 
            this.camionesINBindingSource.DataMember = "Camiones_IN";
            this.camionesINBindingSource.DataSource = this.dsLiquidos_;
            // 
            // dsLiquidos_
            // 
            this.dsLiquidos_.DataSetName = "dsLiquidos_";
            this.dsLiquidos_.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcomentarios,
            this.colEmpresaTrans,
            this.colfechaEntra,
            this.colFechaFin,
            this.colshipid,
            this.colbarco,
            this.colNBoleta,
            this.colnumero_factura,
            this.colOperador,
            this.colPesoBruto,
            this.colid_ubicacion,
            this.colPesonetoIn,
            this.colitemcode,
            this.colPesoProd,
            this.colpesoSalida,
            this.colpeso_factura,
            this.colconductorin,
            this.colvehiculo,
            this.colfurgon,
            this.colTipoBoleta,
            this.colid_tipo_boleta,
            this.colSNegocio,
            this.colProducto,
            this.col_Registrar,
            this.colseleccionar,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.colEliminar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsFilter.AllowFilterEditor = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colcomentarios
            // 
            this.colcomentarios.Caption = "Comentarios";
            this.colcomentarios.FieldName = "comentarios";
            this.colcomentarios.Name = "colcomentarios";
            this.colcomentarios.OptionsColumn.AllowEdit = false;
            this.colcomentarios.Visible = true;
            this.colcomentarios.VisibleIndex = 5;
            this.colcomentarios.Width = 222;
            // 
            // colEmpresaTrans
            // 
            this.colEmpresaTrans.FieldName = "EmpresaTrans";
            this.colEmpresaTrans.Name = "colEmpresaTrans";
            this.colEmpresaTrans.OptionsColumn.AllowEdit = false;
            // 
            // colfechaEntra
            // 
            this.colfechaEntra.Caption = "Fecha Ent.";
            this.colfechaEntra.FieldName = "fechaEntra";
            this.colfechaEntra.Name = "colfechaEntra";
            this.colfechaEntra.OptionsColumn.AllowEdit = false;
            this.colfechaEntra.Visible = true;
            this.colfechaEntra.VisibleIndex = 0;
            this.colfechaEntra.Width = 91;
            // 
            // colFechaFin
            // 
            this.colFechaFin.FieldName = "FechaFin";
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.OptionsColumn.AllowEdit = false;
            // 
            // colshipid
            // 
            this.colshipid.Caption = "Barco";
            this.colshipid.ColumnEdit = this.LookUpEditBarco;
            this.colshipid.FieldName = "shipid";
            this.colshipid.Name = "colshipid";
            this.colshipid.Width = 128;
            // 
            // LookUpEditBarco
            // 
            this.LookUpEditBarco.AutoHeight = false;
            this.LookUpEditBarco.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditBarco.DataSource = this.bindingSource1;
            this.LookUpEditBarco.DisplayMember = "descripcion";
            this.LookUpEditBarco.Name = "LookUpEditBarco";
            this.LookUpEditBarco.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.LookUpEditBarco.ValueMember = "id";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "barcos";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coldescripcion});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // colbarco
            // 
            this.colbarco.Caption = "Barco";
            this.colbarco.FieldName = "barco";
            this.colbarco.Name = "colbarco";
            this.colbarco.OptionsColumn.AllowEdit = false;
            this.colbarco.Width = 151;
            // 
            // colNBoleta
            // 
            this.colNBoleta.FieldName = "NBoleta";
            this.colNBoleta.Name = "colNBoleta";
            this.colNBoleta.OptionsColumn.AllowEdit = false;
            this.colNBoleta.Visible = true;
            this.colNBoleta.VisibleIndex = 1;
            this.colNBoleta.Width = 77;
            // 
            // colnumero_factura
            // 
            this.colnumero_factura.FieldName = "numero_factura";
            this.colnumero_factura.Name = "colnumero_factura";
            this.colnumero_factura.OptionsColumn.AllowEdit = false;
            // 
            // colOperador
            // 
            this.colOperador.FieldName = "Operador";
            this.colOperador.Name = "colOperador";
            this.colOperador.OptionsColumn.AllowEdit = false;
            // 
            // colPesoBruto
            // 
            this.colPesoBruto.FieldName = "PesoBruto";
            this.colPesoBruto.Name = "colPesoBruto";
            this.colPesoBruto.OptionsColumn.AllowEdit = false;
            this.colPesoBruto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PesoBruto", "{0:#.##}")});
            // 
            // colid_ubicacion
            // 
            this.colid_ubicacion.Caption = "Ubicación Almacén";
            this.colid_ubicacion.ColumnEdit = this.GridLookUpEditUbicaciones;
            this.colid_ubicacion.FieldName = "id_ubicacion";
            this.colid_ubicacion.Name = "colid_ubicacion";
            this.colid_ubicacion.Visible = true;
            this.colid_ubicacion.VisibleIndex = 4;
            this.colid_ubicacion.Width = 141;
            // 
            // GridLookUpEditUbicaciones
            // 
            this.GridLookUpEditUbicaciones.AutoHeight = false;
            this.GridLookUpEditUbicaciones.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GridLookUpEditUbicaciones.DataSource = this.ubicacionLiquidosBindingSource;
            this.GridLookUpEditUbicaciones.DisplayMember = "descripcion";
            this.GridLookUpEditUbicaciones.Name = "GridLookUpEditUbicaciones";
            this.GridLookUpEditUbicaciones.PopupView = this.gridView2;
            this.GridLookUpEditUbicaciones.ValueMember = "id";
            // 
            // ubicacionLiquidosBindingSource
            // 
            this.ubicacionLiquidosBindingSource.DataMember = "Ubicacion_Liquidos";
            this.ubicacionLiquidosBindingSource.DataSource = this.dsLiquidos_;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colPesonetoIn
            // 
            this.colPesonetoIn.FieldName = "PesonetoIn";
            this.colPesonetoIn.Name = "colPesonetoIn";
            this.colPesonetoIn.OptionsColumn.AllowEdit = false;
            // 
            // colitemcode
            // 
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            // 
            // colPesoProd
            // 
            this.colPesoProd.FieldName = "PesoProd";
            this.colPesoProd.Name = "colPesoProd";
            this.colPesoProd.OptionsColumn.AllowEdit = false;
            this.colPesoProd.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PesoProd", "{0:#.##}")});
            this.colPesoProd.Visible = true;
            this.colPesoProd.VisibleIndex = 2;
            this.colPesoProd.Width = 94;
            // 
            // colpesoSalida
            // 
            this.colpesoSalida.FieldName = "pesoSalida";
            this.colpesoSalida.Name = "colpesoSalida";
            this.colpesoSalida.OptionsColumn.AllowEdit = false;
            // 
            // colpeso_factura
            // 
            this.colpeso_factura.FieldName = "peso_factura";
            this.colpeso_factura.Name = "colpeso_factura";
            this.colpeso_factura.OptionsColumn.AllowEdit = false;
            // 
            // colconductorin
            // 
            this.colconductorin.FieldName = "conductorin";
            this.colconductorin.Name = "colconductorin";
            this.colconductorin.OptionsColumn.AllowEdit = false;
            // 
            // colvehiculo
            // 
            this.colvehiculo.FieldName = "vehiculo";
            this.colvehiculo.Name = "colvehiculo";
            this.colvehiculo.OptionsColumn.AllowEdit = false;
            // 
            // colfurgon
            // 
            this.colfurgon.FieldName = "furgon";
            this.colfurgon.Name = "colfurgon";
            this.colfurgon.OptionsColumn.AllowEdit = false;
            // 
            // colTipoBoleta
            // 
            this.colTipoBoleta.FieldName = "TipoBoleta";
            this.colTipoBoleta.Name = "colTipoBoleta";
            this.colTipoBoleta.OptionsColumn.AllowEdit = false;
            // 
            // colid_tipo_boleta
            // 
            this.colid_tipo_boleta.FieldName = "id_tipo_boleta";
            this.colid_tipo_boleta.Name = "colid_tipo_boleta";
            this.colid_tipo_boleta.OptionsColumn.AllowEdit = false;
            // 
            // colSNegocio
            // 
            this.colSNegocio.FieldName = "SNegocio";
            this.colSNegocio.Name = "colSNegocio";
            this.colSNegocio.OptionsColumn.AllowEdit = false;
            this.colSNegocio.Visible = true;
            this.colSNegocio.VisibleIndex = 3;
            this.colSNegocio.Width = 88;
            // 
            // colProducto
            // 
            this.colProducto.FieldName = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.OptionsColumn.AllowEdit = false;
            // 
            // col_Registrar
            // 
            this.col_Registrar.Caption = "Registrar Lote";
            this.col_Registrar.Name = "col_Registrar";
            // 
            // colseleccionar
            // 
            this.colseleccionar.Caption = "Seleccionar";
            this.colseleccionar.FieldName = "seleccionar";
            this.colseleccionar.Name = "colseleccionar";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Lote";
            this.gridColumn1.FieldName = "lote";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 88;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Fecha PRD";
            this.gridColumn2.FieldName = "fecha_produccion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            this.gridColumn2.Width = 88;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Fecha Venc.";
            this.gridColumn3.FieldName = "fecha_vencimiento";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 7;
            this.gridColumn3.Width = 106;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "cardname";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "cardcode";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // bindingSourceUbicaciones
            // 
            this.bindingSourceUbicaciones.DataMember = "ubicaciones_granel";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 161);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(137, 18);
            this.labelControl2.TabIndex = 94;
            this.labelControl2.Text = "Detalle de Boletas";
            // 
            // cmdGenerarIngreso
            // 
            this.cmdGenerarIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGenerarIngreso.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGenerarIngreso.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGenerarIngreso.Appearance.Options.UseBackColor = true;
            this.cmdGenerarIngreso.Appearance.Options.UseFont = true;
            this.cmdGenerarIngreso.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGenerarIngreso.ImageOptions.Image")));
            this.cmdGenerarIngreso.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGenerarIngreso.Location = new System.Drawing.Point(626, 3);
            this.cmdGenerarIngreso.Name = "cmdGenerarIngreso";
            this.cmdGenerarIngreso.Size = new System.Drawing.Size(194, 56);
            this.cmdGenerarIngreso.TabIndex = 96;
            this.cmdGenerarIngreso.Text = "Guardar Informacion";
            this.cmdGenerarIngreso.Click += new System.EventHandler(this.cmdGenerarIngreso_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(826, 3);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(166, 56);
            this.btnAtras.TabIndex = 95;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // barcosBindingSource
            // 
            this.barcosBindingSource.DataMember = "barcos";
            // 
            // grdUbicaciones
            // 
            this.grdUbicaciones.Location = new System.Drawing.Point(190, 189);
            this.grdUbicaciones.Name = "grdUbicaciones";
            this.grdUbicaciones.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdUbicaciones.Properties.Appearance.Options.UseFont = true;
            this.grdUbicaciones.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdUbicaciones.Properties.DataSource = this.ubicacionLiquidosBindingSource;
            this.grdUbicaciones.Properties.DisplayMember = "descripcion";
            this.grdUbicaciones.Properties.PopupView = this.gridView3;
            this.grdUbicaciones.Properties.ValueMember = "id";
            this.grdUbicaciones.Size = new System.Drawing.Size(254, 28);
            this.grdUbicaciones.TabIndex = 99;
            this.grdUbicaciones.EditValueChanged += new System.EventHandler(this.grdUbicaciones_EditValueChanged);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid3,
            this.colrack,
            this.colcodigo_barra});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colid3
            // 
            this.colid3.FieldName = "id";
            this.colid3.Name = "colid3";
            // 
            // colrack
            // 
            this.colrack.Caption = "Ubicación";
            this.colrack.FieldName = "descripcion";
            this.colrack.Name = "colrack";
            this.colrack.Visible = true;
            this.colrack.VisibleIndex = 0;
            // 
            // colcodigo_barra
            // 
            this.colcodigo_barra.FieldName = "codigo_barra";
            this.colcodigo_barra.Name = "colcodigo_barra";
            // 
            // ubicacionesgranelBindingSource
            // 
            this.ubicacionesgranelBindingSource.DataMember = "ubicaciones_granel";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(190, 161);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(88, 25);
            this.labelControl7.TabIndex = 100;
            this.labelControl7.Text = "Ubicacion";
            // 
            // chnuevoIngreso
            // 
            this.chnuevoIngreso.EditValue = true;
            this.chnuevoIngreso.Location = new System.Drawing.Point(626, 65);
            this.chnuevoIngreso.Name = "chnuevoIngreso";
            this.chnuevoIngreso.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chnuevoIngreso.Properties.Appearance.Options.UseFont = true;
            this.chnuevoIngreso.Properties.Caption = "Nuevo Ingreso";
            this.chnuevoIngreso.Size = new System.Drawing.Size(253, 24);
            this.chnuevoIngreso.TabIndex = 101;
            this.chnuevoIngreso.CheckedChanged += new System.EventHandler(this.chnuevoIngreso_CheckedChanged);
            // 
            // txtingreso
            // 
            this.txtingreso.EditValue = "";
            this.txtingreso.Enabled = false;
            this.txtingreso.Location = new System.Drawing.Point(729, 95);
            this.txtingreso.Name = "txtingreso";
            this.txtingreso.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtingreso.Properties.Appearance.Options.UseFont = true;
            this.txtingreso.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtingreso.Size = new System.Drawing.Size(130, 32);
            this.txtingreso.TabIndex = 102;
            // 
            // lblingreso
            // 
            this.lblingreso.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblingreso.Appearance.Options.UseFont = true;
            this.lblingreso.Location = new System.Drawing.Point(636, 102);
            this.lblingreso.Name = "lblingreso";
            this.lblingreso.Size = new System.Drawing.Size(87, 25);
            this.lblingreso.TabIndex = 103;
            this.lblingreso.Text = "Ingreso___";
            // 
            // btningreso
            // 
            this.btningreso.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningreso.Appearance.Options.UseFont = true;
            this.btningreso.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.btningreso.Location = new System.Drawing.Point(865, 91);
            this.btningreso.Name = "btningreso";
            this.btningreso.Size = new System.Drawing.Size(42, 40);
            this.btningreso.TabIndex = 104;
            this.btningreso.Visible = false;
            this.btningreso.Click += new System.EventHandler(this.btningreso_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(41, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 36);
            this.btnAdd.TabIndex = 105;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLote
            // 
            this.txtLote.EditValue = "";
            this.txtLote.Location = new System.Drawing.Point(210, 116);
            this.txtLote.Name = "txtLote";
            this.txtLote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Properties.Appearance.Options.UseFont = true;
            this.txtLote.Properties.Appearance.Options.UseTextOptions = true;
            this.txtLote.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.txtLote.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLote.Size = new System.Drawing.Size(410, 32);
            this.txtLote.TabIndex = 106;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(20, 124);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(196, 25);
            this.labelControl6.TabIndex = 107;
            this.labelControl6.Text = "# Lote__________________";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 96);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(221, 25);
            this.labelControl4.TabIndex = 108;
            this.labelControl4.Text = "Disponibilidad del tanque:";
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(12, 128);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(202, 25);
            this.labelControl8.TabIndex = 109;
            this.labelControl8.Text = "Total Ingreso al Tanque:";
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(12, 160);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(178, 25);
            this.labelControl9.TabIndex = 110;
            this.labelControl9.Text = "Pendiente en Tarima:";
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(12, 191);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(114, 25);
            this.labelControl10.TabIndex = 111;
            this.labelControl10.Text = "Total Ingreso:";
            // 
            // txtDisponible
            // 
            this.txtDisponible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisponible.EditValue = "0";
            this.txtDisponible.Location = new System.Drawing.Point(282, 95);
            this.txtDisponible.Name = "txtDisponible";
            this.txtDisponible.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisponible.Properties.Appearance.Options.UseFont = true;
            this.txtDisponible.Properties.Mask.EditMask = "n";
            this.txtDisponible.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDisponible.Size = new System.Drawing.Size(200, 26);
            this.txtDisponible.TabIndex = 112;
            // 
            // txtAltanque
            // 
            this.txtAltanque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAltanque.EditValue = "0";
            this.txtAltanque.Location = new System.Drawing.Point(282, 127);
            this.txtAltanque.Name = "txtAltanque";
            this.txtAltanque.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltanque.Properties.Appearance.Options.UseFont = true;
            this.txtAltanque.Properties.Mask.EditMask = "n";
            this.txtAltanque.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAltanque.Size = new System.Drawing.Size(200, 26);
            this.txtAltanque.TabIndex = 113;
            // 
            // txtEnTarimas
            // 
            this.txtEnTarimas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnTarimas.EditValue = "0";
            this.txtEnTarimas.Location = new System.Drawing.Point(282, 159);
            this.txtEnTarimas.Name = "txtEnTarimas";
            this.txtEnTarimas.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnTarimas.Properties.Appearance.Options.UseFont = true;
            this.txtEnTarimas.Properties.Mask.EditMask = "n";
            this.txtEnTarimas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtEnTarimas.Size = new System.Drawing.Size(200, 26);
            this.txtEnTarimas.TabIndex = 114;
            // 
            // txtTotalIngreso
            // 
            this.txtTotalIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalIngreso.EditValue = "0";
            this.txtTotalIngreso.Location = new System.Drawing.Point(282, 191);
            this.txtTotalIngreso.Name = "txtTotalIngreso";
            this.txtTotalIngreso.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalIngreso.Properties.Appearance.Options.UseFont = true;
            this.txtTotalIngreso.Properties.Mask.EditMask = "n";
            this.txtTotalIngreso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalIngreso.Size = new System.Drawing.Size(200, 26);
            this.txtTotalIngreso.TabIndex = 115;
            // 
            // txtEspacioOcupado
            // 
            this.txtEspacioOcupado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEspacioOcupado.EditValue = "0";
            this.txtEspacioOcupado.Location = new System.Drawing.Point(282, 63);
            this.txtEspacioOcupado.Name = "txtEspacioOcupado";
            this.txtEspacioOcupado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspacioOcupado.Properties.Appearance.Options.UseFont = true;
            this.txtEspacioOcupado.Properties.Mask.EditMask = "n";
            this.txtEspacioOcupado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtEspacioOcupado.Size = new System.Drawing.Size(200, 26);
            this.txtEspacioOcupado.TabIndex = 117;
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(12, 62);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(256, 25);
            this.labelControl11.TabIndex = 116;
            this.labelControl11.Text = "Cantidad Ocupada del tanque:";
            // 
            // txtcapacidad
            // 
            this.txtcapacidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcapacidad.EditValue = "0";
            this.txtcapacidad.Location = new System.Drawing.Point(282, 31);
            this.txtcapacidad.Name = "txtcapacidad";
            this.txtcapacidad.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcapacidad.Properties.Appearance.Options.UseFont = true;
            this.txtcapacidad.Properties.Mask.EditMask = "n";
            this.txtcapacidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtcapacidad.Size = new System.Drawing.Size(200, 26);
            this.txtcapacidad.TabIndex = 119;
            // 
            // labelControl12
            // 
            this.labelControl12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(12, 32);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(199, 25);
            this.labelControl12.TabIndex = 118;
            this.labelControl12.Text = "Capaciodad del tanque:";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Location = new System.Drawing.Point(3, 487);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(488, 227);
            this.groupControl1.TabIndex = 120;
            this.groupControl1.Text = "Tarimas por ingresar";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // labelControl15
            // 
            this.labelControl15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(17, 92);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(141, 25);
            this.labelControl15.TabIndex = 121;
            this.labelControl15.Text = "Peso por Tarima:";
            // 
            // labelControl14
            // 
            this.labelControl14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(17, 61);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(125, 25);
            this.labelControl14.TabIndex = 120;
            this.labelControl14.Text = "Ud por Tarima:";
            // 
            // labelControl13
            // 
            this.labelControl13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(17, 30);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(113, 25);
            this.labelControl13.TabIndex = 119;
            this.labelControl13.Text = "Presentacion:";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.txtcapacidad);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl12);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.txtEspacioOcupado);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.txtTotalIngreso);
            this.groupControl2.Controls.Add(this.txtDisponible);
            this.groupControl2.Controls.Add(this.txtEnTarimas);
            this.groupControl2.Controls.Add(this.txtAltanque);
            this.groupControl2.Location = new System.Drawing.Point(497, 487);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(495, 227);
            this.groupControl2.TabIndex = 121;
            this.groupControl2.Text = "Resumen";
            // 
            // colEliminar
            // 
            this.colEliminar.Caption = "Descartar";
            this.colEliminar.ColumnEdit = this.btnEliminar;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Visible = true;
            this.colEliminar.VisibleIndex = 8;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmIngresoCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 715);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btningreso);
            this.Controls.Add(this.lblingreso);
            this.Controls.Add(this.txtingreso);
            this.Controls.Add(this.chnuevoIngreso);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.grdUbicaciones);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.cmdGenerarIngreso);
            this.Controls.Add(this.txtCodigoMP);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtFechaIngreso);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtMP_Name);
            this.Controls.Add(this.labelControl3);
            this.Name = "frmIngresoCamion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso MP Líquidos";
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIngreso.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIngreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMP_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoMP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camionesINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLiquidos_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditBarco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditUbicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionLiquidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUbicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUbicaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesgranelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chnuevoIngreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtingreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisponible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltanque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnTarimas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalIngreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEspacioOcupado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcapacidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.DateEdit dtFechaIngreso;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMP_Name;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCodigoMP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private GridControl gridControl1;
        private GridView gridView1;
        private LabelControl labelControl2;
        //private dsRecepcionMPx dsRecepcionMPx1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentarios;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresaTrans;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaEntra;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colshipid;
        private DevExpress.XtraGrid.Columns.GridColumn colbarco;
        private DevExpress.XtraGrid.Columns.GridColumn colNBoleta;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colOperador;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoBruto;
        private DevExpress.XtraGrid.Columns.GridColumn colPesonetoIn;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoProd;
        private DevExpress.XtraGrid.Columns.GridColumn colpesoSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colconductorin;
        private DevExpress.XtraGrid.Columns.GridColumn colvehiculo;
        private DevExpress.XtraGrid.Columns.GridColumn colfurgon;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoBoleta;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_boleta;
        private DevExpress.XtraGrid.Columns.GridColumn colSNegocio;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionar;
        private DevExpress.XtraGrid.Columns.GridColumn col_Registrar;
        private SimpleButton cmdGenerarIngreso;
        private SimpleButton btnAtras;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit LookUpEditBarco;
        private GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_ubicacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit GridLookUpEditUbicaciones;
        private GridView gridView2;
        private System.Windows.Forms.BindingSource bindingSourceUbicaciones;
        private GridLookUpEdit grdUbicaciones;
        private GridView gridView3;
        private LabelControl labelControl7;
        private System.Windows.Forms.BindingSource ubicacionesgranelBindingSource;
        private System.Windows.Forms.BindingSource barcosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid3;
        private DevExpress.XtraGrid.Columns.GridColumn colrack;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra;
        private CheckEdit chnuevoIngreso;
        private TextEdit txtingreso;
        private LabelControl lblingreso;
        private SimpleButton btningreso;
        private SimpleButton btnAdd;
        private System.Windows.Forms.BindingSource camionesINBindingSource;
        private dsLiquidos_ dsLiquidos_;
        private System.Windows.Forms.BindingSource ubicacionLiquidosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private TextEdit txtLote;
        private LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private LabelControl labelControl4;
        private LabelControl labelControl8;
        private LabelControl labelControl9;
        private LabelControl labelControl10;
        private TextEdit txtDisponible;
        private TextEdit txtAltanque;
        private TextEdit txtEnTarimas;
        private TextEdit txtTotalIngreso;
        private TextEdit txtEspacioOcupado;
        private LabelControl labelControl11;
        private TextEdit txtcapacidad;
        private LabelControl labelControl12;
        private GroupControl groupControl1;
        private LabelControl labelControl14;
        private LabelControl labelControl13;
        private GroupControl groupControl2;
        private LabelControl labelControl15;
        private DevExpress.XtraGrid.Columns.GridColumn colEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEliminar;
    }
}