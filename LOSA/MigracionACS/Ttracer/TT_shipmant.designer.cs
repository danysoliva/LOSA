namespace LOSA.MigracionACS.Ttracer

{
    partial class TT_shipmant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TT_shipmant));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.grd_shipd = new DevExpress.XtraGrid.GridControl();
            this.dSTtracer = new MigracionACS.Ttracer.dSTtracer();
            this.grdv_shid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombredelbarco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapplicagranel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechafin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnkik = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldocentry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btneditar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnorden = new System.Windows.Forms.Button();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblship = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnloadoldplan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_shipd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_shid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnkik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btn);
            this.panelControl1.Controls.Add(this.btnclose);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1925, 52);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl1_MouseDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(57, 6);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(257, 29);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mantenimiento de barco";
            // 
            // btn
            // 
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn.Image = global::LOSA.Properties.Resources.remove_24x24;
            this.btn.Location = new System.Drawing.Point(1822, 2);
            this.btn.Margin = new System.Windows.Forms.Padding(4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(49, 43);
            this.btn.TabIndex = 2;
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(1872, 2);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(49, 43);
            this.btnclose.TabIndex = 1;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LOSA.Properties.Resources.LogoLimp_x32;
            this.pictureBox1.Location = new System.Drawing.Point(7, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.grd_shipd);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 52);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1925, 822);
            this.panelControl2.TabIndex = 1;
            // 
            // grd_shipd
            // 
            this.grd_shipd.DataMember = "shipd";
            this.grd_shipd.DataSource = this.dSTtracer;
            this.grd_shipd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_shipd.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grd_shipd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_shipd.Location = new System.Drawing.Point(2, 78);
            this.grd_shipd.MainView = this.grdv_shid;
            this.grd_shipd.Margin = new System.Windows.Forms.Padding(4);
            this.grd_shipd.Name = "grd_shipd";
            this.grd_shipd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnkik});
            this.grd_shipd.Size = new System.Drawing.Size(1921, 742);
            this.grd_shipd.TabIndex = 1;
            this.grd_shipd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_shid});
            // 
            // dSTtracer
            // 
            this.dSTtracer.DataSetName = "dSTtracer";
            this.dSTtracer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_shid
            // 
            this.grdv_shid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colIDH,
            this.colnombredelbarco,
            this.colCodigo,
            this.colDescripcion,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colestatus,
            this.colenable,
            this.colapplicagranel,
            this.colfechafin,
            this.colfechain,
            this.colkik,
            this.coltipo,
            this.coldocentry});
            this.grdv_shid.GridControl = this.grd_shipd;
            this.grdv_shid.GroupCount = 1;
            this.grdv_shid.Name = "grdv_shid";
            this.grdv_shid.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_shid.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coltipo, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 81;
            // 
            // colIDH
            // 
            this.colIDH.FieldName = "IDH";
            this.colIDH.Name = "colIDH";
            this.colIDH.OptionsColumn.AllowEdit = false;
            // 
            // colnombredelbarco
            // 
            this.colnombredelbarco.Caption = "Barco";
            this.colnombredelbarco.FieldName = "nombre del barco";
            this.colnombredelbarco.Name = "colnombredelbarco";
            this.colnombredelbarco.OptionsColumn.AllowEdit = false;
            this.colnombredelbarco.Visible = true;
            this.colnombredelbarco.VisibleIndex = 4;
            this.colnombredelbarco.Width = 205;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.AllowEdit = false;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 5;
            this.colCodigo.Width = 89;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 6;
            this.colDescripcion.Width = 384;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Cod. Prov";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 126;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Prov. Nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 8;
            this.gridColumn2.Width = 448;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "Kg/unit";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 9;
            this.gridColumn3.Width = 132;
            // 
            // colestatus
            // 
            this.colestatus.Caption = "Estado";
            this.colestatus.FieldName = "estatus";
            this.colestatus.Name = "colestatus";
            this.colestatus.OptionsColumn.AllowEdit = false;
            this.colestatus.Visible = true;
            this.colestatus.VisibleIndex = 10;
            this.colestatus.Width = 54;
            // 
            // colenable
            // 
            this.colenable.Caption = "Enable";
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.AllowEdit = false;
            this.colenable.Visible = true;
            this.colenable.VisibleIndex = 11;
            this.colenable.Width = 57;
            // 
            // colapplicagranel
            // 
            this.colapplicagranel.Caption = "Granel";
            this.colapplicagranel.FieldName = "applicagranel";
            this.colapplicagranel.Name = "colapplicagranel";
            this.colapplicagranel.OptionsColumn.AllowEdit = false;
            this.colapplicagranel.Visible = true;
            this.colapplicagranel.VisibleIndex = 12;
            this.colapplicagranel.Width = 49;
            // 
            // colfechafin
            // 
            this.colfechafin.Caption = "Fecha Planificada";
            this.colfechafin.FieldName = "fechafin";
            this.colfechafin.Name = "colfechafin";
            this.colfechafin.OptionsColumn.AllowEdit = false;
            this.colfechafin.Visible = true;
            this.colfechafin.VisibleIndex = 2;
            this.colfechafin.Width = 110;
            // 
            // colfechain
            // 
            this.colfechain.Caption = "Fecha de finalizacion";
            this.colfechain.FieldName = "fechain";
            this.colfechain.Name = "colfechain";
            this.colfechain.OptionsColumn.AllowEdit = false;
            this.colfechain.Visible = true;
            this.colfechain.VisibleIndex = 3;
            this.colfechain.Width = 131;
            // 
            // colkik
            // 
            this.colkik.Caption = "Eliminar";
            this.colkik.ColumnEdit = this.btnkik;
            this.colkik.Name = "colkik";
            this.colkik.Visible = true;
            this.colkik.VisibleIndex = 13;
            this.colkik.Width = 35;
            // 
            // btnkik
            // 
            this.btnkik.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnkik.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnkik.Name = "btnkik";
            this.btnkik.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnkik.Click += new System.EventHandler(this.btnkik_Click);
            // 
            // coltipo
            // 
            this.coltipo.Caption = "Tipo";
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            this.coltipo.OptionsColumn.AllowEdit = false;
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 13;
            // 
            // coldocentry
            // 
            this.coldocentry.Caption = "Numero SAP";
            this.coldocentry.FieldName = "docentry";
            this.coldocentry.Name = "coldocentry";
            this.coldocentry.Visible = true;
            this.coldocentry.VisibleIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btneditar);
            this.panelControl3.Controls.Add(this.button4);
            this.panelControl3.Controls.Add(this.btnorden);
            this.panelControl3.Controls.Add(this.lblCodigo);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.lblship);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.btnloadoldplan);
            this.panelControl3.Controls.Add(this.button1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1921, 76);
            this.panelControl3.TabIndex = 0;
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btneditar.Enabled = false;
            this.btneditar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditar.Location = new System.Drawing.Point(196, 1);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(199, 74);
            this.btneditar.TabIndex = 8;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(927, 1);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(243, 74);
            this.button4.TabIndex = 7;
            this.button4.Text = "Maestro de Barcos";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnorden
            // 
            this.btnorden.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnorden.Enabled = false;
            this.btnorden.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorden.ForeColor = System.Drawing.Color.White;
            this.btnorden.Image = ((System.Drawing.Image)(resources.GetObject("btnorden.Image")));
            this.btnorden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnorden.Location = new System.Drawing.Point(680, 1);
            this.btnorden.Margin = new System.Windows.Forms.Padding(4);
            this.btnorden.Name = "btnorden";
            this.btnorden.Size = new System.Drawing.Size(243, 74);
            this.btnorden.TabIndex = 6;
            this.btnorden.Text = "Agregar orden de compra";
            this.btnorden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnorden.UseVisualStyleBackColor = false;
            this.btnorden.Click += new System.EventHandler(this.btnorden_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Appearance.Options.UseFont = true;
            this.lblCodigo.Location = new System.Drawing.Point(1415, 11);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(24, 24);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "....";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(1211, 11);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(160, 24);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Codigo Generado:";
            // 
            // lblship
            // 
            this.lblship.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblship.Appearance.Options.UseFont = true;
            this.lblship.Location = new System.Drawing.Point(1415, 42);
            this.lblship.Margin = new System.Windows.Forms.Padding(4);
            this.lblship.Name = "lblship";
            this.lblship.Size = new System.Drawing.Size(24, 24);
            this.lblship.TabIndex = 3;
            this.lblship.Text = "....";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1211, 42);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(165, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nombre del barco:";
            // 
            // btnloadoldplan
            // 
            this.btnloadoldplan.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnloadoldplan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloadoldplan.ForeColor = System.Drawing.Color.White;
            this.btnloadoldplan.Image = ((System.Drawing.Image)(resources.GetObject("btnloadoldplan.Image")));
            this.btnloadoldplan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnloadoldplan.Location = new System.Drawing.Point(396, 1);
            this.btnloadoldplan.Margin = new System.Windows.Forms.Padding(4);
            this.btnloadoldplan.Name = "btnloadoldplan";
            this.btnloadoldplan.Size = new System.Drawing.Size(281, 74);
            this.btnloadoldplan.TabIndex = 1;
            this.btnloadoldplan.Text = "Cargar configuracion de barco";
            this.btnloadoldplan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnloadoldplan.UseVisualStyleBackColor = false;
            this.btnloadoldplan.Click += new System.EventHandler(this.btnloadoldplan_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(6, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nuevo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TT_shipmant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1925, 874);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TT_shipmant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TT_shipmant";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_shipd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_shid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnkik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblship;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button btnloadoldplan;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridControl grd_shipd;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_shid;
        private System.Windows.Forms.Button btnorden;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btneditar;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDH;
        private DevExpress.XtraGrid.Columns.GridColumn colnombredelbarco;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colestatus;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colapplicagranel;
        private dSTtracer dSTtracer;
        private DevExpress.XtraGrid.Columns.GridColumn colfechafin;
        private DevExpress.XtraGrid.Columns.GridColumn colfechain;
        private DevExpress.XtraGrid.Columns.GridColumn colkik;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnkik;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn coldocentry;
    }
}