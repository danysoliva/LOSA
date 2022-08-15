namespace LOSA.PlanMPreque
{
    partial class frmnewplan
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnewplan));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grOrdenFabricacion = new DevExpress.XtraGrid.GridControl();
            this.dsTransaccionesMP1 = new LOSA.TransaccionesMP.dsTransaccionesMP();
            this.gvTarimas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDocEntry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlannedQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnVer = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colSeleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.colLote = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grOrdenFabricacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer)).BeginInit();
            this.SuspendLayout();
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
            this.labelControl1.Location = new System.Drawing.Point(34, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(497, 40);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "Ordenes de Fabricacion planificadas";
            // 
            // grOrdenFabricacion
            // 
            this.grOrdenFabricacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grOrdenFabricacion.DataMember = "Plan_requiciones";
            this.grOrdenFabricacion.DataSource = this.dsTransaccionesMP1;
            this.grOrdenFabricacion.Location = new System.Drawing.Point(-2, 100);
            this.grOrdenFabricacion.MainView = this.gvTarimas;
            this.grOrdenFabricacion.Name = "grOrdenFabricacion";
            this.grOrdenFabricacion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnVer});
            this.grOrdenFabricacion.Size = new System.Drawing.Size(731, 462);
            this.grOrdenFabricacion.TabIndex = 34;
            this.grOrdenFabricacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.colDocEntry,
            this.colLote,
            this.colItemCode,
            this.colProdName,
            this.colfecha,
            this.colPlannedQty,
            this.colEstado,
            this.colComments,
            this.colVer,
            this.colSeleccionar});
            this.gvTarimas.GridControl = this.grOrdenFabricacion;
            this.gvTarimas.Name = "gvTarimas";
            this.gvTarimas.OptionsCustomization.AllowFilter = false;
            this.gvTarimas.OptionsView.ShowAutoFilterRow = true;
            this.gvTarimas.OptionsView.ShowGroupPanel = false;
            this.gvTarimas.RowHeight = 20;
            // 
            // colDocEntry
            // 
            this.colDocEntry.Caption = "Num Orden F.";
            this.colDocEntry.FieldName = "DocEntry";
            this.colDocEntry.Name = "colDocEntry";
            this.colDocEntry.Visible = true;
            this.colDocEntry.VisibleIndex = 0;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Cod. SAP MP";
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 2;
            // 
            // colProdName
            // 
            this.colProdName.Caption = "Materia Prima";
            this.colProdName.FieldName = "ProdName";
            this.colProdName.Name = "colProdName";
            this.colProdName.Visible = true;
            this.colProdName.VisibleIndex = 3;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 4;
            // 
            // colPlannedQty
            // 
            this.colPlannedQty.Caption = "Cantidad";
            this.colPlannedQty.FieldName = "PlannedQty";
            this.colPlannedQty.Name = "colPlannedQty";
            this.colPlannedQty.Visible = true;
            this.colPlannedQty.VisibleIndex = 5;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 6;
            // 
            // colComments
            // 
            this.colComments.Caption = "Comentario";
            this.colComments.FieldName = "Comments";
            this.colComments.Name = "colComments";
            this.colComments.Visible = true;
            this.colComments.VisibleIndex = 7;
            // 
            // colVer
            // 
            this.colVer.Caption = "Ver";
            this.colVer.ColumnEdit = this.btnVer;
            this.colVer.Name = "colVer";
            this.colVer.Visible = true;
            this.colVer.VisibleIndex = 8;
            // 
            // btnVer
            // 
            this.btnVer.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btnVer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnVer.Name = "btnVer";
            this.btnVer.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.Caption = "Seleccionar";
            this.colSeleccionar.FieldName = "Seleccionar";
            this.colSeleccionar.Name = "colSeleccionar";
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
            this.btnAtras.Location = new System.Drawing.Point(527, 8);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(191, 47);
            this.btnAtras.TabIndex = 35;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // colLote
            // 
            this.colLote.FieldName = "Lote";
            this.colLote.Name = "colLote";
            this.colLote.OptionsColumn.AllowEdit = false;
            this.colLote.Visible = true;
            this.colLote.VisibleIndex = 1;
            // 
            // frmnewplan
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 560);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.grOrdenFabricacion);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmnewplan";
            this.Text = "Ordenes de Fab. Planificadas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grOrdenFabricacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grOrdenFabricacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTarimas;
        private DevExpress.XtraGrid.Columns.GridColumn colDocEntry;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProdName;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colPlannedQty;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colComments;
        private DevExpress.XtraGrid.Columns.GridColumn colVer;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnVer;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private TransaccionesMP.dsTransaccionesMP dsTransaccionesMP1;
        private DevExpress.XtraGrid.Columns.GridColumn colLote;
    }
}