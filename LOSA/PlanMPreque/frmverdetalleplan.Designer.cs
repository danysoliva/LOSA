namespace LOSA.PlanMPreque
{
    partial class frmverdetalleplan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmverdetalleplan));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.chkAutoSelect = new System.Windows.Forms.CheckBox();
            this.grDetalleLote = new DevExpress.XtraGrid.GridControl();
            this.dsTransaccionesMP1 = new LOSA.TransaccionesMP.dsTransaccionesMP();
            this.gvTarimas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsolicitada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprogramada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentregada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_unidad_medida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colasignado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtLote = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalleLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(129, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(441, 39);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Detalle de Plan";
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(527, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(191, 47);
            this.btnAtras.TabIndex = 36;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // chkAutoSelect
            // 
            this.chkAutoSelect.AutoSize = true;
            this.chkAutoSelect.BackColor = System.Drawing.Color.Transparent;
            this.chkAutoSelect.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAutoSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoSelect.Location = new System.Drawing.Point(568, 58);
            this.chkAutoSelect.Name = "chkAutoSelect";
            this.chkAutoSelect.Size = new System.Drawing.Size(149, 24);
            this.chkAutoSelect.TabIndex = 47;
            this.chkAutoSelect.Text = "Auto Selección";
            this.chkAutoSelect.UseVisualStyleBackColor = false;
            this.chkAutoSelect.Visible = false;
            // 
            // grDetalleLote
            // 
            this.grDetalleLote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDetalleLote.DataMember = "requisiciones_d";
            this.grDetalleLote.DataSource = this.dsTransaccionesMP1;
            this.grDetalleLote.Location = new System.Drawing.Point(0, 88);
            this.grDetalleLote.MainView = this.gvTarimas;
            this.grDetalleLote.Name = "grDetalleLote";
            this.grDetalleLote.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit});
            this.grDetalleLote.Size = new System.Drawing.Size(729, 474);
            this.grDetalleLote.TabIndex = 48;
            this.grDetalleLote.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTarimas});
            // 
            // dsTransaccionesMP1
            // 
            this.dsTransaccionesMP1.DataSetName = "dsTransaccionesMP";
            this.dsTransaccionesMP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvTarimas
            // 
            this.gvTarimas.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gvTarimas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTarimas.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvTarimas.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gvTarimas.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTarimas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTarimas.Appearance.FocusedRow.Options.UseFont = true;
            this.gvTarimas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gvTarimas.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTarimas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvTarimas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTarimas.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTarimas.Appearance.Row.Options.UseFont = true;
            this.gvTarimas.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTarimas.Appearance.SelectedRow.Options.UseFont = true;
            this.gvTarimas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTarimas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTarimas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_materia_prima,
            this.colmp,
            this.colsolicitada,
            this.colprogramada,
            this.colentregada,
            this.colpendiente,
            this.colenable,
            this.colid_unidad_medida,
            this.colunidad,
            this.colcode_sap,
            this.gridColumn1,
            this.colasignado});
            this.gvTarimas.DetailHeight = 284;
            this.gvTarimas.GridControl = this.grDetalleLote;
            this.gvTarimas.Name = "gvTarimas";
            this.gvTarimas.OptionsCustomization.AllowFilter = false;
            this.gvTarimas.OptionsView.ShowAutoFilterRow = true;
            this.gvTarimas.OptionsView.ShowFooter = true;
            this.gvTarimas.OptionsView.ShowGroupPanel = false;
            this.gvTarimas.RowHeight = 16;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 17;
            this.colid.Name = "colid";
            this.colid.Width = 64;
            // 
            // colid_materia_prima
            // 
            this.colid_materia_prima.FieldName = "id_materia_prima";
            this.colid_materia_prima.MinWidth = 17;
            this.colid_materia_prima.Name = "colid_materia_prima";
            this.colid_materia_prima.Width = 64;
            // 
            // colmp
            // 
            this.colmp.Caption = "MP";
            this.colmp.FieldName = "mp";
            this.colmp.MinWidth = 17;
            this.colmp.Name = "colmp";
            this.colmp.OptionsColumn.AllowEdit = false;
            this.colmp.Visible = true;
            this.colmp.VisibleIndex = 0;
            this.colmp.Width = 64;
            // 
            // colsolicitada
            // 
            this.colsolicitada.Caption = "Solicitada";
            this.colsolicitada.FieldName = "solicitada";
            this.colsolicitada.MinWidth = 17;
            this.colsolicitada.Name = "colsolicitada";
            this.colsolicitada.OptionsColumn.AllowEdit = false;
            this.colsolicitada.Visible = true;
            this.colsolicitada.VisibleIndex = 1;
            this.colsolicitada.Width = 64;
            // 
            // colprogramada
            // 
            this.colprogramada.Caption = "Cant. Asignada";
            this.colprogramada.FieldName = "programada";
            this.colprogramada.MinWidth = 17;
            this.colprogramada.Name = "colprogramada";
            this.colprogramada.Visible = true;
            this.colprogramada.VisibleIndex = 2;
            this.colprogramada.Width = 64;
            // 
            // colentregada
            // 
            this.colentregada.Caption = "Entregada";
            this.colentregada.FieldName = "entregada";
            this.colentregada.MinWidth = 17;
            this.colentregada.Name = "colentregada";
            this.colentregada.OptionsColumn.AllowEdit = false;
            this.colentregada.Width = 64;
            // 
            // colpendiente
            // 
            this.colpendiente.Caption = "Pendiente Asignar";
            this.colpendiente.FieldName = "pendiente";
            this.colpendiente.MinWidth = 17;
            this.colpendiente.Name = "colpendiente";
            this.colpendiente.OptionsColumn.AllowEdit = false;
            this.colpendiente.Visible = true;
            this.colpendiente.VisibleIndex = 3;
            this.colpendiente.Width = 96;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.MinWidth = 17;
            this.colenable.Name = "colenable";
            this.colenable.Width = 64;
            // 
            // colid_unidad_medida
            // 
            this.colid_unidad_medida.FieldName = "id_unidad_medida";
            this.colid_unidad_medida.MinWidth = 17;
            this.colid_unidad_medida.Name = "colid_unidad_medida";
            this.colid_unidad_medida.Width = 64;
            // 
            // colunidad
            // 
            this.colunidad.Caption = "Unidad Medida";
            this.colunidad.FieldName = "unidad";
            this.colunidad.MinWidth = 17;
            this.colunidad.Name = "colunidad";
            this.colunidad.OptionsColumn.AllowEdit = false;
            this.colunidad.Visible = true;
            this.colunidad.VisibleIndex = 4;
            this.colunidad.Width = 64;
            // 
            // colcode_sap
            // 
            this.colcode_sap.Caption = "Cod. MP SAP";
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.MinWidth = 17;
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.AllowEdit = false;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 5;
            this.colcode_sap.Width = 64;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.btnEdit;
            this.gridColumn1.MinWidth = 17;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 102;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // colasignado
            // 
            this.colasignado.Caption = "Cant. Asignada";
            this.colasignado.FieldName = "asignado";
            this.colasignado.MinWidth = 17;
            this.colasignado.Name = "colasignado";
            this.colasignado.Width = 64;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(3, 2);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(183, 47);
            this.cmdGuardar.TabIndex = 49;
            this.cmdGuardar.Text = "Activar plan";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // txtLote
            // 
            this.txtLote.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Appearance.Options.UseFont = true;
            this.txtLote.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.txtLote.Location = new System.Drawing.Point(65, 62);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(106, 20);
            this.txtLote.TabIndex = 51;
            this.txtLote.Text = "N/D";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 20);
            this.labelControl2.TabIndex = 50;
            this.labelControl2.Text = "Lote PT:";
            // 
            // frmverdetalleplan
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 560);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.grDetalleLote);
            this.Controls.Add(this.chkAutoSelect);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.labelControl3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmverdetalleplan";
            this.Text = "Detalle Orden Fab. Planificada";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grDetalleLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private System.Windows.Forms.CheckBox chkAutoSelect;
        private DevExpress.XtraGrid.GridControl grDetalleLote;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTarimas;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colmp;
        private DevExpress.XtraGrid.Columns.GridColumn colsolicitada;
        private DevExpress.XtraGrid.Columns.GridColumn colprogramada;
        private DevExpress.XtraGrid.Columns.GridColumn colentregada;
        private DevExpress.XtraGrid.Columns.GridColumn colpendiente;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colid_unidad_medida;
        private DevExpress.XtraGrid.Columns.GridColumn colunidad;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colasignado;
        private TransaccionesMP.dsTransaccionesMP dsTransaccionesMP1;
        public DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.LabelControl txtLote;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}