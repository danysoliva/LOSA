namespace LOSA.MigracionACS.Produccion.Eficiencia.DatosBromatologicos
{
    partial class frmDatosBrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosBrom));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions5 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject17 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject18 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject19 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject20 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsReportesPRD1 = new LOSA.MigracionACS.Produccion.DataSet_.dsReportesPRD();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ini = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoras_dis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActiva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdOk = new DevExpress.XtraEditors.SimpleButton();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproteina_brom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproteina_promedio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhumedad_brom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhumedad_promedio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgrasa_brom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgrasa_promedio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldifprotein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldifhumedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldifgrasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colformula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_n = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.coldelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdButtonEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesPRD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdButtonEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "header_brom";
            this.gridControl1.DataSource = this.dsReportesPRD1;
            this.gridControl1.Location = new System.Drawing.Point(2, 58);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1056, 238);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsReportesPRD1
            // 
            this.dsReportesPRD1.DataSetName = "dsReportesPRD";
            this.dsReportesPRD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colfecha_ini,
            this.colhoras_dis,
            this.colestatus,
            this.colfecha_fin,
            this.colenable,
            this.colcomentario,
            this.coldescripcion,
            this.colActiva});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colid
            // 
            this.colid.Caption = "Id";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colfecha_ini
            // 
            this.colfecha_ini.Caption = "Fecha Inicio";
            this.colfecha_ini.DisplayFormat.FormatString = "g";
            this.colfecha_ini.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_ini.FieldName = "fecha_ini";
            this.colfecha_ini.Name = "colfecha_ini";
            this.colfecha_ini.OptionsColumn.AllowEdit = false;
            this.colfecha_ini.Visible = true;
            this.colfecha_ini.VisibleIndex = 1;
            // 
            // colhoras_dis
            // 
            this.colhoras_dis.Caption = "Horas Disponibles";
            this.colhoras_dis.FieldName = "horas_dis";
            this.colhoras_dis.Name = "colhoras_dis";
            this.colhoras_dis.OptionsColumn.AllowEdit = false;
            this.colhoras_dis.Visible = true;
            this.colhoras_dis.VisibleIndex = 3;
            // 
            // colestatus
            // 
            this.colestatus.Caption = "Estado";
            this.colestatus.FieldName = "estatus";
            this.colestatus.Name = "colestatus";
            this.colestatus.OptionsColumn.AllowEdit = false;
            // 
            // colfecha_fin
            // 
            this.colfecha_fin.Caption = "Fecha Fin";
            this.colfecha_fin.DisplayFormat.FormatString = "g";
            this.colfecha_fin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_fin.FieldName = "fecha_fin";
            this.colfecha_fin.Name = "colfecha_fin";
            this.colfecha_fin.OptionsColumn.AllowEdit = false;
            this.colfecha_fin.Visible = true;
            this.colfecha_fin.VisibleIndex = 2;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.AllowEdit = false;
            // 
            // colcomentario
            // 
            this.colcomentario.Caption = "Comentario";
            this.colcomentario.FieldName = "comentario";
            this.colcomentario.Name = "colcomentario";
            this.colcomentario.OptionsColumn.AllowEdit = false;
            this.colcomentario.Visible = true;
            this.colcomentario.VisibleIndex = 4;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Turno";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 5;
            // 
            // colActiva
            // 
            this.colActiva.Caption = "Estado";
            this.colActiva.FieldName = "Activa";
            this.colActiva.Name = "colActiva";
            this.colActiva.OptionsColumn.AllowEdit = false;
            this.colActiva.Visible = true;
            this.colActiva.VisibleIndex = 6;
            // 
            // cmdOk
            // 
            this.cmdOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOk.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOk.Appearance.Options.UseFont = true;
            this.cmdOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdOk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdOk.ImageOptions.Image")));
            this.cmdOk.Location = new System.Drawing.Point(861, 9);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(197, 43);
            this.cmdOk.TabIndex = 2;
            this.cmdOk.Text = "Refrescar";
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // dtHasta
            // 
            this.dtHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(727, 26);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtHasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtHasta.Size = new System.Drawing.Size(128, 26);
            this.dtHasta.TabIndex = 15;
            // 
            // dtDesde
            // 
            this.dtDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(494, 26);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtDesde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDesde.Size = new System.Drawing.Size(128, 26);
            this.dtDesde.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(648, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 17);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Fecha Hasta:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(411, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 17);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Fecha Desde:";
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataMember = "detalle_brom";
            this.gridControl2.DataSource = this.dsReportesPRD1;
            this.gridControl2.Location = new System.Drawing.Point(2, 346);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdButtonEliminar});
            this.gridControl2.Size = new System.Drawing.Size(1056, 293);
            this.gridControl2.TabIndex = 16;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView2.ColumnPanelRowHeight = 50;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.collote,
            this.colproteina_brom,
            this.colproteina_promedio,
            this.colhumedad_brom,
            this.colhumedad_promedio,
            this.coldelete,
            this.colgrasa_brom,
            this.colgrasa_promedio,
            this.colfecha,
            this.colid_user,
            this.coldifprotein,
            this.coldifhumedad,
            this.coldifgrasa,
            this.colformula,
            this.colproducto,
            this.coluser_n,
            this.colproducto_name});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanged);
            this.gridView2.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanging);
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 4;
            this.collote.Width = 45;
            // 
            // colproteina_brom
            // 
            this.colproteina_brom.Caption = "Proteína Según Bromatología";
            this.colproteina_brom.FieldName = "proteina_brom";
            this.colproteina_brom.Name = "colproteina_brom";
            this.colproteina_brom.Visible = true;
            this.colproteina_brom.VisibleIndex = 5;
            this.colproteina_brom.Width = 71;
            // 
            // colproteina_promedio
            // 
            this.colproteina_promedio.Caption = "Promedio Proteina PT";
            this.colproteina_promedio.FieldName = "proteina_promedio";
            this.colproteina_promedio.Name = "colproteina_promedio";
            this.colproteina_promedio.Visible = true;
            this.colproteina_promedio.VisibleIndex = 6;
            this.colproteina_promedio.Width = 63;
            // 
            // colhumedad_brom
            // 
            this.colhumedad_brom.Caption = "Humedad Según Bromatología";
            this.colhumedad_brom.FieldName = "humedad_brom";
            this.colhumedad_brom.Name = "colhumedad_brom";
            this.colhumedad_brom.Visible = true;
            this.colhumedad_brom.VisibleIndex = 8;
            this.colhumedad_brom.Width = 72;
            // 
            // colhumedad_promedio
            // 
            this.colhumedad_promedio.Caption = "Promedio Humedad PT";
            this.colhumedad_promedio.FieldName = "humedad_promedio";
            this.colhumedad_promedio.Name = "colhumedad_promedio";
            this.colhumedad_promedio.Visible = true;
            this.colhumedad_promedio.VisibleIndex = 9;
            this.colhumedad_promedio.Width = 60;
            // 
            // colgrasa_brom
            // 
            this.colgrasa_brom.Caption = "Grasa Según Bromatología";
            this.colgrasa_brom.FieldName = "grasa_brom";
            this.colgrasa_brom.Name = "colgrasa_brom";
            this.colgrasa_brom.Visible = true;
            this.colgrasa_brom.VisibleIndex = 11;
            this.colgrasa_brom.Width = 66;
            // 
            // colgrasa_promedio
            // 
            this.colgrasa_promedio.Caption = "Promedio de Grasa PT";
            this.colgrasa_promedio.FieldName = "grasa_promedio";
            this.colgrasa_promedio.Name = "colgrasa_promedio";
            this.colgrasa_promedio.Visible = true;
            this.colgrasa_promedio.VisibleIndex = 12;
            this.colgrasa_promedio.Width = 58;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.DisplayFormat.FormatString = "g";
            this.colfecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 0;
            this.colfecha.Width = 58;
            // 
            // colid_user
            // 
            this.colid_user.FieldName = "id_user";
            this.colid_user.Name = "colid_user";
            // 
            // coldifprotein
            // 
            this.coldifprotein.Caption = "%Diferencia Proteína";
            this.coldifprotein.FieldName = "difprotein";
            this.coldifprotein.Name = "coldifprotein";
            this.coldifprotein.OptionsColumn.AllowEdit = false;
            this.coldifprotein.Visible = true;
            this.coldifprotein.VisibleIndex = 7;
            this.coldifprotein.Width = 62;
            // 
            // coldifhumedad
            // 
            this.coldifhumedad.Caption = "%Diferencia Humedad";
            this.coldifhumedad.FieldName = "difhumedad";
            this.coldifhumedad.Name = "coldifhumedad";
            this.coldifhumedad.OptionsColumn.AllowEdit = false;
            this.coldifhumedad.Visible = true;
            this.coldifhumedad.VisibleIndex = 10;
            this.coldifhumedad.Width = 60;
            // 
            // coldifgrasa
            // 
            this.coldifgrasa.Caption = "%Diferencia Grasa";
            this.coldifgrasa.FieldName = "difgrasa";
            this.coldifgrasa.Name = "coldifgrasa";
            this.coldifgrasa.OptionsColumn.AllowEdit = false;
            this.coldifgrasa.Visible = true;
            this.coldifgrasa.VisibleIndex = 13;
            this.coldifgrasa.Width = 104;
            // 
            // colformula
            // 
            this.colformula.Caption = "Fórmula";
            this.colformula.FieldName = "formula";
            this.colformula.Name = "colformula";
            this.colformula.OptionsColumn.AllowEdit = false;
            this.colformula.Visible = true;
            this.colformula.VisibleIndex = 3;
            this.colformula.Width = 58;
            // 
            // colproducto
            // 
            this.colproducto.Caption = "Cod. Producto";
            this.colproducto.FieldName = "producto";
            this.colproducto.Name = "colproducto";
            this.colproducto.OptionsColumn.AllowEdit = false;
            this.colproducto.Visible = true;
            this.colproducto.VisibleIndex = 1;
            this.colproducto.Width = 58;
            // 
            // coluser_n
            // 
            this.coluser_n.Caption = "Usuario";
            this.coluser_n.FieldName = "user_n";
            this.coluser_n.Name = "coluser_n";
            this.coluser_n.OptionsColumn.AllowEdit = false;
            this.coluser_n.Visible = true;
            this.coluser_n.VisibleIndex = 14;
            this.coluser_n.Width = 78;
            // 
            // colproducto_name
            // 
            this.colproducto_name.Caption = "Producto Terminado";
            this.colproducto_name.FieldName = "producto_name";
            this.colproducto_name.Name = "colproducto_name";
            this.colproducto_name.OptionsColumn.AllowEdit = false;
            this.colproducto_name.Visible = true;
            this.colproducto_name.VisibleIndex = 2;
            this.colproducto_name.Width = 65;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.Appearance.Options.UseFont = true;
            this.cmdAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAgregar.ImageOptions.Image")));
            this.cmdAgregar.Location = new System.Drawing.Point(2, 300);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(197, 43);
            this.cmdAgregar.TabIndex = 17;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(2, 21);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(264, 29);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Bromatología en Proceso";
            // 
            // coldelete
            // 
            this.coldelete.Caption = "Eliminar";
            this.coldelete.ColumnEdit = this.cmdButtonEliminar;
            this.coldelete.FieldName = "delete";
            this.coldelete.Name = "coldelete";
            this.coldelete.Visible = true;
            this.coldelete.VisibleIndex = 15;
            this.coldelete.Width = 60;
            // 
            // cmdButtonEliminar
            // 
            this.cmdButtonEliminar.AutoHeight = false;
            editorButtonImageOptions5.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions5.Image")));
            serializableAppearanceObject17.Image = ((System.Drawing.Image)(resources.GetObject("serializableAppearanceObject17.Image")));
            serializableAppearanceObject17.Options.UseImage = true;
            this.cmdButtonEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions5, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject17, serializableAppearanceObject18, serializableAppearanceObject19, serializableAppearanceObject20, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdButtonEliminar.Name = "cmdButtonEliminar";
            this.cmdButtonEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdButtonEliminar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdButtonEliminar_ButtonClick);
            // 
            // frmDatosBrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 640);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmDatosBrom";
            this.Text = "Datos Bromatologicos";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesPRD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdButtonEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton cmdOk;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DataSet_.dsReportesPRD dsReportesPRD1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ini;
        private DevExpress.XtraGrid.Columns.GridColumn colhoras_dis;
        private DevExpress.XtraGrid.Columns.GridColumn colestatus;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_fin;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentario;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colActiva;
        private DevExpress.XtraEditors.SimpleButton cmdAgregar;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colproteina_brom;
        private DevExpress.XtraGrid.Columns.GridColumn colproteina_promedio;
        private DevExpress.XtraGrid.Columns.GridColumn colhumedad_brom;
        private DevExpress.XtraGrid.Columns.GridColumn colhumedad_promedio;
        private DevExpress.XtraGrid.Columns.GridColumn colgrasa_brom;
        private DevExpress.XtraGrid.Columns.GridColumn colgrasa_promedio;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user;
        private DevExpress.XtraGrid.Columns.GridColumn coldifprotein;
        private DevExpress.XtraGrid.Columns.GridColumn coldifhumedad;
        private DevExpress.XtraGrid.Columns.GridColumn coldifgrasa;
        private DevExpress.XtraGrid.Columns.GridColumn colformula;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto_name;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_n;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn coldelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdButtonEliminar;
    }
}