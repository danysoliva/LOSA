namespace LOSA.TransaccionesMP
{
    partial class frmRequisicionesDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequisicionesDetalle));
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
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
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
            this.chkAutoSelect = new System.Windows.Forms.CheckBox();
            this.colConsumir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnconsumir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalleLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnconsumir)).BeginInit();
            this.SuspendLayout();
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
            this.btnAtras.Location = new System.Drawing.Point(644, 6);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(205, 58);
            this.btnAtras.TabIndex = 33;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
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
            this.labelControl1.Location = new System.Drawing.Point(5, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(389, 49);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Detalle MP Solicitada";
            // 
            // grDetalleLote
            // 
            this.grDetalleLote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDetalleLote.DataMember = "requisiciones_d";
            this.grDetalleLote.DataSource = this.dsTransaccionesMP1;
            this.grDetalleLote.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grDetalleLote.Location = new System.Drawing.Point(3, 69);
            this.grDetalleLote.MainView = this.gvTarimas;
            this.grDetalleLote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grDetalleLote.Name = "grDetalleLote";
            this.grDetalleLote.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnconsumir});
            this.grDetalleLote.Size = new System.Drawing.Size(847, 618);
            this.grDetalleLote.TabIndex = 34;
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
            this.colasignado,
            this.colConsumir});
            this.gvTarimas.DetailHeight = 431;
            this.gvTarimas.GridControl = this.grDetalleLote;
            this.gvTarimas.Name = "gvTarimas";
            this.gvTarimas.OptionsCustomization.AllowFilter = false;
            this.gvTarimas.OptionsView.ShowAutoFilterRow = true;
            this.gvTarimas.OptionsView.ShowFooter = true;
            this.gvTarimas.OptionsView.ShowGroupPanel = false;
            this.gvTarimas.RowHeight = 25;
            this.gvTarimas.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvTarimas_RowStyle);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 27;
            this.colid.Name = "colid";
            this.colid.Width = 100;
            // 
            // colid_materia_prima
            // 
            this.colid_materia_prima.FieldName = "id_materia_prima";
            this.colid_materia_prima.MinWidth = 27;
            this.colid_materia_prima.Name = "colid_materia_prima";
            this.colid_materia_prima.Width = 100;
            // 
            // colmp
            // 
            this.colmp.Caption = "MP";
            this.colmp.FieldName = "mp";
            this.colmp.MinWidth = 27;
            this.colmp.Name = "colmp";
            this.colmp.OptionsColumn.AllowEdit = false;
            this.colmp.Visible = true;
            this.colmp.VisibleIndex = 0;
            this.colmp.Width = 89;
            // 
            // colsolicitada
            // 
            this.colsolicitada.Caption = "Solicitada";
            this.colsolicitada.FieldName = "solicitada";
            this.colsolicitada.MinWidth = 27;
            this.colsolicitada.Name = "colsolicitada";
            this.colsolicitada.OptionsColumn.AllowEdit = false;
            this.colsolicitada.Visible = true;
            this.colsolicitada.VisibleIndex = 1;
            this.colsolicitada.Width = 89;
            // 
            // colprogramada
            // 
            this.colprogramada.FieldName = "programada";
            this.colprogramada.MinWidth = 27;
            this.colprogramada.Name = "colprogramada";
            this.colprogramada.Width = 100;
            // 
            // colentregada
            // 
            this.colentregada.Caption = "Entregada";
            this.colentregada.FieldName = "entregada";
            this.colentregada.MinWidth = 27;
            this.colentregada.Name = "colentregada";
            this.colentregada.OptionsColumn.AllowEdit = false;
            this.colentregada.Visible = true;
            this.colentregada.VisibleIndex = 3;
            this.colentregada.Width = 89;
            // 
            // colpendiente
            // 
            this.colpendiente.Caption = "Pendiente";
            this.colpendiente.FieldName = "pendiente";
            this.colpendiente.MinWidth = 27;
            this.colpendiente.Name = "colpendiente";
            this.colpendiente.OptionsColumn.AllowEdit = false;
            this.colpendiente.Visible = true;
            this.colpendiente.VisibleIndex = 4;
            this.colpendiente.Width = 89;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.MinWidth = 27;
            this.colenable.Name = "colenable";
            this.colenable.Width = 100;
            // 
            // colid_unidad_medida
            // 
            this.colid_unidad_medida.FieldName = "id_unidad_medida";
            this.colid_unidad_medida.MinWidth = 27;
            this.colid_unidad_medida.Name = "colid_unidad_medida";
            this.colid_unidad_medida.Width = 100;
            // 
            // colunidad
            // 
            this.colunidad.Caption = "Unidad Medida";
            this.colunidad.FieldName = "unidad";
            this.colunidad.MinWidth = 27;
            this.colunidad.Name = "colunidad";
            this.colunidad.OptionsColumn.AllowEdit = false;
            this.colunidad.Visible = true;
            this.colunidad.VisibleIndex = 5;
            this.colunidad.Width = 89;
            // 
            // colcode_sap
            // 
            this.colcode_sap.Caption = "Cod. MP SAP";
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.MinWidth = 27;
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.AllowEdit = false;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 6;
            this.colcode_sap.Width = 89;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.btnEdit;
            this.gridColumn1.MinWidth = 27;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 113;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnVerD_ButtonClick);
            // 
            // colasignado
            // 
            this.colasignado.Caption = "Cant. Asignada";
            this.colasignado.FieldName = "asignado";
            this.colasignado.MinWidth = 27;
            this.colasignado.Name = "colasignado";
            this.colasignado.Visible = true;
            this.colasignado.VisibleIndex = 2;
            this.colasignado.Width = 89;
            // 
            // chkAutoSelect
            // 
            this.chkAutoSelect.AutoSize = true;
            this.chkAutoSelect.BackColor = System.Drawing.Color.Transparent;
            this.chkAutoSelect.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAutoSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoSelect.Location = new System.Drawing.Point(437, 28);
            this.chkAutoSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAutoSelect.Name = "chkAutoSelect";
            this.chkAutoSelect.Size = new System.Drawing.Size(180, 29);
            this.chkAutoSelect.TabIndex = 46;
            this.chkAutoSelect.Text = "Auto Selección";
            this.chkAutoSelect.UseVisualStyleBackColor = false;
            this.chkAutoSelect.CheckedChanged += new System.EventHandler(this.chkAutoSelect_CheckedChanged);
            // 
            // colConsumir
            // 
            this.colConsumir.Caption = "Consumir de Produccion";
            this.colConsumir.ColumnEdit = this.btnconsumir;
            this.colConsumir.MinWidth = 25;
            this.colConsumir.Name = "colConsumir";
            this.colConsumir.Visible = true;
            this.colConsumir.VisibleIndex = 8;
            this.colConsumir.Width = 91;
            // 
            // btnconsumir
            // 
            this.btnconsumir.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnconsumir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnconsumir.Name = "btnconsumir";
            this.btnconsumir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnconsumir.Click += new System.EventHandler(this.btnconsumir_Click);
            // 
            // frmRequisicionesDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(851, 689);
            this.ControlBox = false;
            this.Controls.Add(this.chkAutoSelect);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grDetalleLote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRequisicionesDetalle";
            this.Text = "frmRequisicionesDetalle";
            ((System.ComponentModel.ISupportInitialize)(this.grDetalleLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnconsumir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grDetalleLote;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTarimas;
        private dsTransaccionesMP dsTransaccionesMP1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
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
        private DevExpress.XtraGrid.Columns.GridColumn colasignado;
        private System.Windows.Forms.CheckBox chkAutoSelect;
        private DevExpress.XtraGrid.Columns.GridColumn colConsumir;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnconsumir;
    }
}