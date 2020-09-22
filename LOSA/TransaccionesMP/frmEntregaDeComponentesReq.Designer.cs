namespace LOSA.TransaccionesMP
{
    partial class frmEntregaDeComponentesReq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntregaDeComponentesReq));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.beIdTarima = new DevExpress.XtraEditors.ButtonEdit();
            this.cmdSelectTarima = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gvTarimas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentregado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_requisicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_detalle_req = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidades1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUbicaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUbicar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.grDetalleLote = new DevExpress.XtraGrid.GridControl();
            this.dsTransaccionesMP1 = new LOSA.TransaccionesMP.dsTransaccionesMP();
            this.dsProduccion1 = new LOSA.Produccion.dsProduccion();
            ((System.ComponentModel.ISupportInitialize)(this.beIdTarima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUbicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalleLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(612, 15);
            this.cmdHome.Margin = new System.Windows.Forms.Padding(4);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(233, 87);
            this.cmdHome.TabIndex = 1;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // beIdTarima
            // 
            this.beIdTarima.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.beIdTarima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beIdTarima.EditValue = "";
            this.beIdTarima.Location = new System.Drawing.Point(160, 44);
            this.beIdTarima.Margin = new System.Windows.Forms.Padding(4);
            this.beIdTarima.Name = "beIdTarima";
            this.beIdTarima.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beIdTarima.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.beIdTarima.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.beIdTarima.Properties.MaxLength = 20;
            this.beIdTarima.Properties.NullText = "Escanee o selecciona una tarima";
            this.beIdTarima.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beIdTarima_Properties_ButtonClick);
            this.beIdTarima.Size = new System.Drawing.Size(411, 52);
            this.beIdTarima.TabIndex = 0;
            this.beIdTarima.ToolTip = "Hola";
            this.beIdTarima.KeyDown += new System.Windows.Forms.KeyEventHandler(this.beIdTarima_KeyDown);
            // 
            // cmdSelectTarima
            // 
            this.cmdSelectTarima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSelectTarima.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelectTarima.Appearance.Options.UseFont = true;
            this.cmdSelectTarima.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSelectTarima.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.cmdSelectTarima.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdSelectTarima.Location = new System.Drawing.Point(627, 14);
            this.cmdSelectTarima.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSelectTarima.Name = "cmdSelectTarima";
            this.cmdSelectTarima.Size = new System.Drawing.Size(83, 85);
            this.cmdSelectTarima.TabIndex = 37;
            this.cmdSelectTarima.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 50);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(134, 46);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Tarima:";
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
            this.gvTarimas.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTarimas.Appearance.GroupRow.Options.UseFont = true;
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
            this.colbarcode,
            this.colpendiente,
            this.collote_mp,
            this.colentregado,
            this.colnombre_comercial,
            this.colid_requisicion,
            this.colid_detalle_req,
            this.colnumero_transaccion,
            this.colid_mp,
            this.colunidades1,
            this.colUbicaciones});
            this.gvTarimas.GridControl = this.grDetalleLote;
            this.gvTarimas.GroupCount = 1;
            this.gvTarimas.Name = "gvTarimas";
            this.gvTarimas.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvTarimas.OptionsCustomization.AllowFilter = false;
            this.gvTarimas.OptionsView.ShowAutoFilterRow = true;
            this.gvTarimas.OptionsView.ShowFooter = true;
            this.gvTarimas.OptionsView.ShowGroupPanel = false;
            this.gvTarimas.RowHeight = 20;
            this.gvTarimas.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colbarcode, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUbicaciones, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colbarcode
            // 
            this.colbarcode.Caption = "Requisicion";
            this.colbarcode.FieldName = "barcode";
            this.colbarcode.MinWidth = 25;
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.OptionsColumn.AllowEdit = false;
            this.colbarcode.Visible = true;
            this.colbarcode.VisibleIndex = 0;
            this.colbarcode.Width = 94;
            // 
            // colpendiente
            // 
            this.colpendiente.Caption = "Pendiente KG.";
            this.colpendiente.FieldName = "pendiente";
            this.colpendiente.MinWidth = 25;
            this.colpendiente.Name = "colpendiente";
            this.colpendiente.OptionsColumn.AllowEdit = false;
            this.colpendiente.Visible = true;
            this.colpendiente.VisibleIndex = 0;
            this.colpendiente.Width = 94;
            // 
            // collote_mp
            // 
            this.collote_mp.Caption = "Lote";
            this.collote_mp.FieldName = "lote_mp";
            this.collote_mp.MinWidth = 25;
            this.collote_mp.Name = "collote_mp";
            this.collote_mp.OptionsColumn.AllowEdit = false;
            this.collote_mp.Visible = true;
            this.collote_mp.VisibleIndex = 3;
            this.collote_mp.Width = 94;
            // 
            // colentregado
            // 
            this.colentregado.Caption = "Entregado Kg.";
            this.colentregado.FieldName = "entregado";
            this.colentregado.MinWidth = 25;
            this.colentregado.Name = "colentregado";
            this.colentregado.Visible = true;
            this.colentregado.VisibleIndex = 1;
            this.colentregado.Width = 94;
            // 
            // colnombre_comercial
            // 
            this.colnombre_comercial.Caption = "MP";
            this.colnombre_comercial.FieldName = "nombre_comercial";
            this.colnombre_comercial.MinWidth = 25;
            this.colnombre_comercial.Name = "colnombre_comercial";
            this.colnombre_comercial.OptionsColumn.AllowEdit = false;
            this.colnombre_comercial.Visible = true;
            this.colnombre_comercial.VisibleIndex = 2;
            this.colnombre_comercial.Width = 94;
            // 
            // colid_requisicion
            // 
            this.colid_requisicion.Caption = "Requisicion";
            this.colid_requisicion.FieldName = "id_requisicion";
            this.colid_requisicion.MinWidth = 25;
            this.colid_requisicion.Name = "colid_requisicion";
            this.colid_requisicion.OptionsColumn.AllowEdit = false;
            this.colid_requisicion.Width = 94;
            // 
            // colid_detalle_req
            // 
            this.colid_detalle_req.FieldName = "id_detalle_req";
            this.colid_detalle_req.MinWidth = 25;
            this.colid_detalle_req.Name = "colid_detalle_req";
            this.colid_detalle_req.OptionsColumn.AllowEdit = false;
            this.colid_detalle_req.Width = 94;
            // 
            // colnumero_transaccion
            // 
            this.colnumero_transaccion.FieldName = "numero_transaccion";
            this.colnumero_transaccion.MinWidth = 25;
            this.colnumero_transaccion.Name = "colnumero_transaccion";
            this.colnumero_transaccion.OptionsColumn.AllowEdit = false;
            this.colnumero_transaccion.Width = 94;
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.MinWidth = 25;
            this.colid_mp.Name = "colid_mp";
            this.colid_mp.OptionsColumn.AllowEdit = false;
            this.colid_mp.Width = 94;
            // 
            // colunidades1
            // 
            this.colunidades1.Caption = "Cant Sacos. Ud.";
            this.colunidades1.FieldName = "unidades";
            this.colunidades1.MinWidth = 25;
            this.colunidades1.Name = "colunidades1";
            this.colunidades1.OptionsColumn.AllowEdit = false;
            this.colunidades1.Visible = true;
            this.colunidades1.VisibleIndex = 4;
            this.colunidades1.Width = 94;
            // 
            // colUbicaciones
            // 
            this.colUbicaciones.Caption = "Ubicar Tarimas";
            this.colUbicaciones.ColumnEdit = this.btnUbicar;
            this.colUbicaciones.MinWidth = 25;
            this.colUbicaciones.Name = "colUbicaciones";
            this.colUbicaciones.Visible = true;
            this.colUbicaciones.VisibleIndex = 5;
            this.colUbicaciones.Width = 94;
            // 
            // btnUbicar
            // 
            this.btnUbicar.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btnUbicar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnUbicar.Name = "btnUbicar";
            this.btnUbicar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // grDetalleLote
            // 
            this.grDetalleLote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDetalleLote.DataMember = "EntregaLotes";
            this.grDetalleLote.DataSource = this.dsTransaccionesMP1;
            this.grDetalleLote.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grDetalleLote.Location = new System.Drawing.Point(5, 110);
            this.grDetalleLote.MainView = this.gvTarimas;
            this.grDetalleLote.Margin = new System.Windows.Forms.Padding(4);
            this.grDetalleLote.Name = "grDetalleLote";
            this.grDetalleLote.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnUbicar});
            this.grDetalleLote.Size = new System.Drawing.Size(839, 575);
            this.grDetalleLote.TabIndex = 2;
            this.grDetalleLote.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTarimas});
            // 
            // dsTransaccionesMP1
            // 
            this.dsTransaccionesMP1.DataSetName = "dsTransaccionesMP";
            this.dsTransaccionesMP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsProduccion1
            // 
            this.dsProduccion1.DataSetName = "dsProduccion";
            this.dsProduccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmEntregaDeComponentesReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 689);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.beIdTarima);
            this.Controls.Add(this.cmdSelectTarima);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grDetalleLote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEntregaDeComponentesReq";
            this.Text = "frmEntregaDeComponentesReq";
            ((System.ComponentModel.ISupportInitialize)(this.beIdTarima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUbicar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalleLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.ButtonEdit beIdTarima;
        private DevExpress.XtraEditors.SimpleButton cmdSelectTarima;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTarimas;
        private DevExpress.XtraGrid.GridControl grDetalleLote;
        private dsTransaccionesMP dsTransaccionesMP1;
        private Produccion.dsProduccion dsProduccion1;
        private DevExpress.XtraGrid.Columns.GridColumn colpendiente;
        private DevExpress.XtraGrid.Columns.GridColumn collote_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn colid_requisicion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_detalle_req;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colbarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colUbicaciones;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnUbicar;
        private DevExpress.XtraGrid.Columns.GridColumn colentregado;
        private DevExpress.XtraGrid.Columns.GridColumn colunidades1;
    }
}