
namespace LOSA.Produccion
{
    partial class frmCrearRequisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearRequisa));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCrearRequisa = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtcodigo = new DevExpress.XtraEditors.TextEdit();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsMaterialEmpaque1 = new LOSA.Produccion.dsMaterialEmpaque();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colborrar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_eliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colexistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtcomentario = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtsolicitanteManual = new DevExpress.XtraEditors.TextEdit();
            this.grd_usuarios = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.comboTurno = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtsolicitud = new DevExpress.XtraEditors.DateEdit();
            this.btnAgregarItem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtcodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterialEmpaque1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcomentario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsolicitanteManual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_usuarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboTurno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsolicitud.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsolicitud.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(393, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(482, 32);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Creacion de Requisa Material de Empaque";
            // 
            // btnCrearRequisa
            // 
            this.btnCrearRequisa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearRequisa.Appearance.Options.UseFont = true;
            this.btnCrearRequisa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCrearRequisa.ImageOptions.Image = global::LOSA.Properties.Resources.save_32x32;
            this.btnCrearRequisa.Location = new System.Drawing.Point(75, 41);
            this.btnCrearRequisa.Name = "btnCrearRequisa";
            this.btnCrearRequisa.Size = new System.Drawing.Size(104, 43);
            this.btnCrearRequisa.TabIndex = 7;
            this.btnCrearRequisa.Text = "Guardar";
            this.btnCrearRequisa.Click += new System.EventHandler(this.btnCrearRequisa_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.ImageOptions.Image = global::LOSA.Properties.Resources.close32px;
            this.btnClose.Location = new System.Drawing.Point(1037, 41);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 43);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(53, 120);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 21);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Codigo:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(121, 117);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Properties.Appearance.Options.UseFont = true;
            this.txtcodigo.Size = new System.Drawing.Size(265, 28);
            this.txtcodigo.TabIndex = 25;
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "req_detalle";
            this.grd_data.DataSource = this.dsMaterialEmpaque1;
            this.grd_data.Location = new System.Drawing.Point(4, 286);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_eliminar});
            this.grd_data.Size = new System.Drawing.Size(1204, 324);
            this.grd_data.TabIndex = 27;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsMaterialEmpaque1
            // 
            this.dsMaterialEmpaque1.DataSetName = "dsMaterialEmpaque";
            this.dsMaterialEmpaque1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colitemcode,
            this.colitemname,
            this.colcantidad,
            this.colactivo,
            this.colborrar,
            this.colexistencia,
            this.collote});
            this.grdv_data.CustomizationFormBounds = new System.Drawing.Rectangle(-707, 544, 260, 312);
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowFooter = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.Width = 67;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Item Code";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            this.colitemcode.Width = 116;
            // 
            // colitemname
            // 
            this.colitemname.Caption = "Articulo";
            this.colitemname.FieldName = "itemname";
            this.colitemname.Name = "colitemname";
            this.colitemname.OptionsColumn.AllowEdit = false;
            this.colitemname.Visible = true;
            this.colitemname.VisibleIndex = 1;
            this.colitemname.Width = 406;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad a Requisar";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "Total={0:0.##}")});
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 2;
            this.colcantidad.Width = 210;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.Name = "colactivo";
            this.colactivo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "activo", "Total={0:0.##}")});
            // 
            // colborrar
            // 
            this.colborrar.Caption = "Borrar";
            this.colborrar.ColumnEdit = this.btn_eliminar;
            this.colborrar.Name = "colborrar";
            this.colborrar.Visible = true;
            this.colborrar.VisibleIndex = 4;
            this.colborrar.Width = 223;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btn_eliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_eliminar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_eliminar_ButtonClick);
            // 
            // colexistencia
            // 
            this.colexistencia.Caption = "Existencia en Bodega";
            this.colexistencia.FieldName = "existencia";
            this.colexistencia.Name = "colexistencia";
            this.colexistencia.OptionsColumn.AllowEdit = false;
            this.colexistencia.Visible = true;
            this.colexistencia.VisibleIndex = 3;
            this.colexistencia.Width = 224;
            // 
            // collote
            // 
            this.collote.Caption = "# Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.Width = 223;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(59, 618);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(85, 21);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "Comentario:";
            // 
            // txtcomentario
            // 
            this.txtcomentario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcomentario.Location = new System.Drawing.Point(154, 620);
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomentario.Properties.Appearance.Options.UseFont = true;
            this.txtcomentario.Properties.MaxLength = 200;
            this.txtcomentario.Size = new System.Drawing.Size(921, 81);
            this.txtcomentario.TabIndex = 28;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(31, 154);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 21);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Solicitante:";
            // 
            // txtsolicitanteManual
            // 
            this.txtsolicitanteManual.Location = new System.Drawing.Point(121, 151);
            this.txtsolicitanteManual.Name = "txtsolicitanteManual";
            this.txtsolicitanteManual.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsolicitanteManual.Properties.Appearance.Options.UseFont = true;
            this.txtsolicitanteManual.Properties.MaxLength = 150;
            this.txtsolicitanteManual.Size = new System.Drawing.Size(265, 28);
            this.txtsolicitanteManual.TabIndex = 30;
            // 
            // grd_usuarios
            // 
            this.grd_usuarios.Location = new System.Drawing.Point(121, 151);
            this.grd_usuarios.Name = "grd_usuarios";
            this.grd_usuarios.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_usuarios.Properties.Appearance.Options.UseFont = true;
            this.grd_usuarios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_usuarios.Properties.DisplayMember = "user";
            this.grd_usuarios.Properties.PopupView = this.gridLookUpEdit1View;
            this.grd_usuarios.Properties.ValueMember = "id";
            this.grd_usuarios.Size = new System.Drawing.Size(265, 28);
            this.grd_usuarios.TabIndex = 31;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridLookUpEdit1View.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridLookUpEdit1View.Appearance.Empty.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridLookUpEdit1View.Appearance.FilterPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridLookUpEdit1View.Appearance.FocusedRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridLookUpEdit1View.Appearance.FooterPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridLookUpEdit1View.Appearance.GroupRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridLookUpEdit1View.Appearance.Preview.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.TopNewRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coluser});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coluser
            // 
            this.coluser.Caption = "Usuario";
            this.coluser.FieldName = "user";
            this.coluser.Name = "coluser";
            this.coluser.Visible = true;
            this.coluser.VisibleIndex = 0;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(59, 188);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 21);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "Turno:";
            // 
            // comboTurno
            // 
            this.comboTurno.Location = new System.Drawing.Point(121, 185);
            this.comboTurno.Name = "comboTurno";
            this.comboTurno.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboTurno.Properties.Appearance.Options.UseFont = true;
            this.comboTurno.Properties.AppearanceItemDisabled.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboTurno.Properties.AppearanceItemDisabled.Options.UseFont = true;
            this.comboTurno.Properties.AppearanceItemHighlight.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboTurno.Properties.AppearanceItemHighlight.Options.UseFont = true;
            this.comboTurno.Properties.AppearanceItemSelected.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboTurno.Properties.AppearanceItemSelected.Options.UseFont = true;
            this.comboTurno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboTurno.Properties.Items.AddRange(new object[] {
            "N/A",
            "Turno 1",
            "Turno 2 ",
            "Turno 3"});
            this.comboTurno.Size = new System.Drawing.Size(152, 28);
            this.comboTurno.TabIndex = 33;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(837, 120);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 21);
            this.labelControl4.TabIndex = 36;
            this.labelControl4.Text = "F. Solicitud:";
            // 
            // dtsolicitud
            // 
            this.dtsolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtsolicitud.EditValue = null;
            this.dtsolicitud.Location = new System.Drawing.Point(921, 117);
            this.dtsolicitud.Name = "dtsolicitud";
            this.dtsolicitud.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtsolicitud.Properties.Appearance.Options.UseFont = true;
            this.dtsolicitud.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtsolicitud.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtsolicitud.Size = new System.Drawing.Size(219, 28);
            this.dtsolicitud.TabIndex = 35;
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItem.Appearance.Options.UseFont = true;
            this.btnAgregarItem.ImageOptions.Image = global::LOSA.Properties.Resources.add_32x32;
            this.btnAgregarItem.Location = new System.Drawing.Point(12, 240);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(147, 40);
            this.btnAgregarItem.TabIndex = 37;
            this.btnAgregarItem.Text = "Agregar ME";
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // frmCrearRequisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 721);
            this.Controls.Add(this.btnAgregarItem);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.dtsolicitud);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.comboTurno);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtsolicitanteManual);
            this.Controls.Add(this.grd_usuarios);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCrearRequisa);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.Name = "frmCrearRequisa";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.txtcodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterialEmpaque1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcomentario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsolicitanteManual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_usuarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboTurno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsolicitud.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsolicitud.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCrearRequisa;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtcodigo;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colitemname;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraGrid.Columns.GridColumn colborrar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_eliminar;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit txtcomentario;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtsolicitanteManual;
        private DevExpress.XtraEditors.GridLookUpEdit grd_usuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coluser;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit comboTurno;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dtsolicitud;
        private DevExpress.XtraEditors.SimpleButton btnAgregarItem;
        private dsMaterialEmpaque dsMaterialEmpaque1;
    }
}