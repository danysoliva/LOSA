
namespace LOSA.Produccion
{
    partial class frmRequisasMaterialEmpaque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequisasMaterialEmpaque));
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
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_solicitada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocEntry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgregar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_reqmanual = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colImprimir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImprimir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colid_requisa_manual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImprimirprevisualizacion = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tsVerTodas = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewRequisa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_reqmanual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimirprevisualizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsVerTodas.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_data
            // 
            this.grd_data.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grd_data.Location = new System.Drawing.Point(0, 91);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_reqmanual,
            this.btnImprimir,
            this.btnImprimirprevisualizacion});
            this.grd_data.Size = new System.Drawing.Size(1305, 533);
            this.grd_data.TabIndex = 34;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_orden,
            this.colfecha_solicitada,
            this.colLote,
            this.colDocEntry,
            this.colItemCode,
            this.colItemName,
            this.colAgregar,
            this.colImprimir,
            this.colid_requisa_manual,
            this.gridColumn1});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colid_orden
            // 
            this.colid_orden.FieldName = "id_orden";
            this.colid_orden.Name = "colid_orden";
            this.colid_orden.OptionsColumn.AllowEdit = false;
            // 
            // colfecha_solicitada
            // 
            this.colfecha_solicitada.Caption = "F. Solicitud";
            this.colfecha_solicitada.FieldName = "fecha_solicitada";
            this.colfecha_solicitada.Name = "colfecha_solicitada";
            this.colfecha_solicitada.OptionsColumn.AllowEdit = false;
            this.colfecha_solicitada.Visible = true;
            this.colfecha_solicitada.VisibleIndex = 4;
            this.colfecha_solicitada.Width = 96;
            // 
            // colLote
            // 
            this.colLote.FieldName = "Lote";
            this.colLote.Name = "colLote";
            this.colLote.OptionsColumn.AllowEdit = false;
            this.colLote.Visible = true;
            this.colLote.VisibleIndex = 1;
            this.colLote.Width = 59;
            // 
            // colDocEntry
            // 
            this.colDocEntry.Caption = "N. SAP";
            this.colDocEntry.FieldName = "DocEntry";
            this.colDocEntry.Name = "colDocEntry";
            this.colDocEntry.OptionsColumn.AllowEdit = false;
            this.colDocEntry.Visible = true;
            this.colDocEntry.VisibleIndex = 0;
            this.colDocEntry.Width = 58;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Codigo";
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.AllowEdit = false;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 2;
            this.colItemCode.Width = 96;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Articulo";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.AllowEdit = false;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 3;
            this.colItemName.Width = 123;
            // 
            // colAgregar
            // 
            this.colAgregar.Caption = "Requisa Manual";
            this.colAgregar.ColumnEdit = this.btn_reqmanual;
            this.colAgregar.Name = "colAgregar";
            this.colAgregar.Visible = true;
            this.colAgregar.VisibleIndex = 6;
            this.colAgregar.Width = 51;
            // 
            // btn_reqmanual
            // 
            this.btn_reqmanual.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btn_reqmanual.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btn_reqmanual.Name = "btn_reqmanual";
            this.btn_reqmanual.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colImprimir
            // 
            this.colImprimir.Caption = "Imprimir Requisa";
            this.colImprimir.ColumnEdit = this.btnImprimir;
            this.colImprimir.Name = "colImprimir";
            this.colImprimir.Visible = true;
            this.colImprimir.VisibleIndex = 7;
            this.colImprimir.Width = 37;
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnImprimir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colid_requisa_manual
            // 
            this.colid_requisa_manual.FieldName = "id_requisa_manual";
            this.colid_requisa_manual.Name = "colid_requisa_manual";
            this.colid_requisa_manual.Visible = true;
            this.colid_requisa_manual.VisibleIndex = 5;
            this.colid_requisa_manual.Width = 53;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Previsualizacion";
            this.gridColumn1.ColumnEdit = this.btnImprimirprevisualizacion;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 50;
            // 
            // btnImprimirprevisualizacion
            // 
            this.btnImprimirprevisualizacion.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btnImprimirprevisualizacion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnImprimirprevisualizacion.Name = "btnImprimirprevisualizacion";
            this.btnImprimirprevisualizacion.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(468, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(146, 19);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Mostar Solo Abiertas";
            // 
            // tsVerTodas
            // 
            this.tsVerTodas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tsVerTodas.EditValue = true;
            this.tsVerTodas.Location = new System.Drawing.Point(620, 51);
            this.tsVerTodas.Name = "tsVerTodas";
            this.tsVerTodas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsVerTodas.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tsVerTodas.Properties.Appearance.Options.UseFont = true;
            this.tsVerTodas.Properties.Appearance.Options.UseForeColor = true;
            this.tsVerTodas.Properties.OffText = "No";
            this.tsVerTodas.Properties.OnText = "Si";
            this.tsVerTodas.Size = new System.Drawing.Size(180, 30);
            this.tsVerTodas.TabIndex = 35;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(485, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(251, 19);
            this.labelControl3.TabIndex = 65;
            this.labelControl3.Text = "Requisas Material de Empaque";
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdCerrar.ImageOptions.SvgImage")));
            this.cmdCerrar.Location = new System.Drawing.Point(1162, 26);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(116, 39);
            this.cmdCerrar.TabIndex = 66;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // btnNewRequisa
            // 
            this.btnNewRequisa.Appearance.BackColor = System.Drawing.Color.Bisque;
            this.btnNewRequisa.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRequisa.Appearance.Options.UseBackColor = true;
            this.btnNewRequisa.Appearance.Options.UseFont = true;
            this.btnNewRequisa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnNewRequisa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnNewRequisa.Location = new System.Drawing.Point(36, 26);
            this.btnNewRequisa.Name = "btnNewRequisa";
            this.btnNewRequisa.Size = new System.Drawing.Size(130, 39);
            this.btnNewRequisa.TabIndex = 67;
            this.btnNewRequisa.Text = "Crear Requisa";
            // 
            // frmRequisasMaterialEmpaque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 624);
            this.Controls.Add(this.btnNewRequisa);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tsVerTodas);
            this.Controls.Add(this.grd_data);
            this.Name = "frmRequisasMaterialEmpaque";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_reqmanual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimirprevisualizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsVerTodas.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_orden;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_solicitada;
        private DevExpress.XtraGrid.Columns.GridColumn colLote;
        private DevExpress.XtraGrid.Columns.GridColumn colDocEntry;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colAgregar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_reqmanual;
        private DevExpress.XtraGrid.Columns.GridColumn colImprimir;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnImprimir;
        private DevExpress.XtraGrid.Columns.GridColumn colid_requisa_manual;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnImprimirprevisualizacion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ToggleSwitch tsVerTodas;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton btnNewRequisa;
    }
}