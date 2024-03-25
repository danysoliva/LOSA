namespace LOSA.MigracionACS.SAP
{
    partial class frmPartidasRRHH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartidasRRHH));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdCargar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsDataSetSAP1 = new LOSA.MigracionACS.SAP.dsDataSetSAP();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_periodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colperiodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_seleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDetalles = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colmoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubirSAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdSubirA_SAP = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.CheckSeleccionado = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdProcesar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdConexionSAP = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataSetSAP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSubirA_SAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckSeleccionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCargar
            // 
            this.cmdCargar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Appearance.Options.UseFont = true;
            this.cmdCargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCargar.ImageOptions.Image")));
            this.cmdCargar.Location = new System.Drawing.Point(-3, 55);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(137, 44);
            this.cmdCargar.TabIndex = 0;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(871, 55);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(137, 44);
            this.cmdCerrar.TabIndex = 1;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "PartidasRRHH";
            this.gridControl1.DataSource = this.dsDataSetSAP1;
            this.gridControl1.Location = new System.Drawing.Point(0, 105);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.CheckSeleccionado,
            this.btnDetalles,
            this.cmdSubirA_SAP});
            this.gridControl1.Size = new System.Drawing.Size(1008, 506);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsDataSetSAP1
            // 
            this.dsDataSetSAP1.DataSetName = "dsDataSetSAP";
            this.dsDataSetSAP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnumero,
            this.colestado,
            this.colid_periodo,
            this.colperiodo,
            this.colfecha,
            this.colreferencia,
            this.colimporte,
            this.col_seleccionado,
            this.colDetail,
            this.colmoneda,
            this.coltasa,
            this.colSubirSAP});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colid
            // 
            this.colid.Caption = "Id";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 38;
            // 
            // colnumero
            // 
            this.colnumero.Caption = "Numero";
            this.colnumero.FieldName = "numero";
            this.colnumero.Name = "colnumero";
            this.colnumero.OptionsColumn.AllowEdit = false;
            this.colnumero.Visible = true;
            this.colnumero.VisibleIndex = 1;
            this.colnumero.Width = 149;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 2;
            this.colestado.Width = 79;
            // 
            // colid_periodo
            // 
            this.colid_periodo.FieldName = "id_periodo";
            this.colid_periodo.Name = "colid_periodo";
            // 
            // colperiodo
            // 
            this.colperiodo.Caption = "Periodo";
            this.colperiodo.FieldName = "periodo";
            this.colperiodo.Name = "colperiodo";
            this.colperiodo.OptionsColumn.AllowEdit = false;
            this.colperiodo.Visible = true;
            this.colperiodo.VisibleIndex = 3;
            this.colperiodo.Width = 77;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 4;
            this.colfecha.Width = 81;
            // 
            // colreferencia
            // 
            this.colreferencia.Caption = "Referencia";
            this.colreferencia.FieldName = "referencia";
            this.colreferencia.Name = "colreferencia";
            this.colreferencia.Visible = true;
            this.colreferencia.VisibleIndex = 5;
            this.colreferencia.Width = 298;
            // 
            // colimporte
            // 
            this.colimporte.Caption = "Importe";
            this.colimporte.DisplayFormat.FormatString = "#,###,##0.00";
            this.colimporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colimporte.FieldName = "importe";
            this.colimporte.Name = "colimporte";
            this.colimporte.OptionsColumn.AllowEdit = false;
            this.colimporte.Visible = true;
            this.colimporte.VisibleIndex = 6;
            this.colimporte.Width = 122;
            // 
            // col_seleccionado
            // 
            this.col_seleccionado.Caption = "Seleccionado";
            this.col_seleccionado.FieldName = "seleccionado";
            this.col_seleccionado.Name = "col_seleccionado";
            this.col_seleccionado.Width = 67;
            // 
            // colDetail
            // 
            this.colDetail.Caption = "Detalle";
            this.colDetail.ColumnEdit = this.btnDetalles;
            this.colDetail.Name = "colDetail";
            this.colDetail.Visible = true;
            this.colDetail.VisibleIndex = 9;
            this.colDetail.Width = 79;
            // 
            // btnDetalles
            // 
            this.btnDetalles.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnDetalles.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDetalles.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDetalles_ButtonClick);
            // 
            // colmoneda
            // 
            this.colmoneda.Caption = "Moneda";
            this.colmoneda.FieldName = "moneda";
            this.colmoneda.Name = "colmoneda";
            this.colmoneda.OptionsColumn.AllowEdit = false;
            this.colmoneda.Visible = true;
            this.colmoneda.VisibleIndex = 7;
            // 
            // coltasa
            // 
            this.coltasa.Caption = "Tasa";
            this.coltasa.DisplayFormat.FormatString = "#0.0000";
            this.coltasa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltasa.FieldName = "tasa";
            this.coltasa.Name = "coltasa";
            this.coltasa.OptionsColumn.AllowEdit = false;
            this.coltasa.Visible = true;
            this.coltasa.VisibleIndex = 8;
            // 
            // colSubirSAP
            // 
            this.colSubirSAP.Caption = "Subir a SAP";
            this.colSubirSAP.ColumnEdit = this.cmdSubirA_SAP;
            this.colSubirSAP.Name = "colSubirSAP";
            this.colSubirSAP.Visible = true;
            this.colSubirSAP.VisibleIndex = 10;
            // 
            // cmdSubirA_SAP
            // 
            this.cmdSubirA_SAP.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdSubirA_SAP.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdSubirA_SAP.Name = "cmdSubirA_SAP";
            this.cmdSubirA_SAP.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdSubirA_SAP.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdSubirA_SAP_ButtonClick);
            // 
            // CheckSeleccionado
            // 
            this.CheckSeleccionado.AutoHeight = false;
            this.CheckSeleccionado.Name = "CheckSeleccionado";
            this.CheckSeleccionado.ValueChecked = false;
            this.CheckSeleccionado.ValueGrayed = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(238, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(530, 23);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Partidas a Sincronizar con SAP";
            // 
            // cmdProcesar
            // 
            this.cmdProcesar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(200)))), ((int)(((byte)(116)))));
            this.cmdProcesar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProcesar.Appearance.Options.UseBackColor = true;
            this.cmdProcesar.Appearance.Options.UseFont = true;
            this.cmdProcesar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdProcesar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdProcesar.ImageOptions.Image")));
            this.cmdProcesar.Location = new System.Drawing.Point(827, 5);
            this.cmdProcesar.Name = "cmdProcesar";
            this.cmdProcesar.Size = new System.Drawing.Size(181, 44);
            this.cmdProcesar.TabIndex = 4;
            this.cmdProcesar.Text = "Exportar a SAP";
            this.cmdProcesar.Visible = false;
            this.cmdProcesar.Click += new System.EventHandler(this.cmdProcesar_Click);
            // 
            // cmdConexionSAP
            // 
            this.cmdConexionSAP.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdConexionSAP.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConexionSAP.Appearance.Options.UseBackColor = true;
            this.cmdConexionSAP.Appearance.Options.UseFont = true;
            this.cmdConexionSAP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdConexionSAP.Location = new System.Drawing.Point(154, 13);
            this.cmdConexionSAP.Name = "cmdConexionSAP";
            this.cmdConexionSAP.Size = new System.Drawing.Size(142, 28);
            this.cmdConexionSAP.TabIndex = 5;
            this.cmdConexionSAP.Text = "Desconectado";
            this.cmdConexionSAP.Click += new System.EventHandler(this.cmdConexionSAP_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(0, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(148, 23);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Estado Conexion a SAP";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPartidasRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 611);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmdConexionSAP);
            this.Controls.Add(this.cmdProcesar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdCargar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPartidasRRHH";
            this.Text = "Partidas RRHH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataSetSAP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSubirA_SAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckSeleccionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdCargar;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsDataSetSAP dsDataSetSAP1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colid_periodo;
        private DevExpress.XtraGrid.Columns.GridColumn colperiodo;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colreferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte;
        private DevExpress.XtraGrid.Columns.GridColumn col_seleccionado;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit CheckSeleccionado;
        private DevExpress.XtraEditors.SimpleButton cmdProcesar;
        private DevExpress.XtraGrid.Columns.GridColumn colDetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDetalles;
        private DevExpress.XtraGrid.Columns.GridColumn colmoneda;
        private DevExpress.XtraGrid.Columns.GridColumn coltasa;
        private DevExpress.XtraEditors.SimpleButton cmdConexionSAP;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colSubirSAP;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdSubirA_SAP;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}