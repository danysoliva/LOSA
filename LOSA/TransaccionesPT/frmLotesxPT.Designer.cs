
namespace LOSA.TransaccionesPT
{
    partial class frmLotesxPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLotesxPT));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.gridLotePT = new DevExpress.XtraGrid.GridControl();
            this.dsPT1 = new LOSA.TransaccionesPT.dsPT();
            this.gvLotePT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPT_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLote_PT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre_Comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion_Interna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlan_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLotePT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotePT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).BeginInit();
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
            this.btnAtras.Location = new System.Drawing.Point(434, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(166, 56);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // gridLotePT
            // 
            this.gridLotePT.DataMember = "lote_pt";
            this.gridLotePT.DataSource = this.dsPT1;
            this.gridLotePT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridLotePT.Location = new System.Drawing.Point(0, 74);
            this.gridLotePT.MainView = this.gvLotePT;
            this.gridLotePT.Name = "gridLotePT";
            this.gridLotePT.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSeleccionar});
            this.gridLotePT.Size = new System.Drawing.Size(612, 415);
            this.gridLotePT.TabIndex = 8;
            this.gridLotePT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLotePT});
            // 
            // dsPT1
            // 
            this.dsPT1.DataSetName = "dsPT";
            this.dsPT1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvLotePT
            // 
            this.gvLotePT.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gvLotePT.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvLotePT.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvLotePT.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gvLotePT.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvLotePT.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvLotePT.Appearance.FocusedRow.Options.UseFont = true;
            this.gvLotePT.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gvLotePT.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvLotePT.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvLotePT.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvLotePT.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvLotePT.Appearance.Row.Options.UseFont = true;
            this.gvLotePT.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvLotePT.Appearance.SelectedRow.Options.UseFont = true;
            this.gvLotePT.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvLotePT.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvLotePT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPT_Id,
            this.colLote_PT,
            this.colcode_sap,
            this.colNombre_Comercial,
            this.colDescripcion_Interna,
            this.colid_orden,
            this.colPlan_Date,
            this.gridColumn1});
            this.gvLotePT.GridControl = this.gridLotePT;
            this.gvLotePT.Name = "gvLotePT";
            this.gvLotePT.OptionsCustomization.AllowFilter = false;
            this.gvLotePT.OptionsFilter.AllowFilterEditor = false;
            this.gvLotePT.OptionsView.ShowAutoFilterRow = true;
            this.gvLotePT.OptionsView.ShowGroupPanel = false;
            this.gvLotePT.DoubleClick += new System.EventHandler(this.gvLotePT_DoubleClick);
            // 
            // colPT_Id
            // 
            this.colPT_Id.FieldName = "PT_Id";
            this.colPT_Id.Name = "colPT_Id";
            // 
            // colLote_PT
            // 
            this.colLote_PT.Caption = "# Lote";
            this.colLote_PT.FieldName = "Lote_PT";
            this.colLote_PT.Name = "colLote_PT";
            this.colLote_PT.OptionsColumn.AllowEdit = false;
            this.colLote_PT.Visible = true;
            this.colLote_PT.VisibleIndex = 1;
            this.colLote_PT.Width = 106;
            // 
            // colcode_sap
            // 
            this.colcode_sap.Caption = "Codigo SAP";
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.AllowEdit = false;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 0;
            this.colcode_sap.Width = 104;
            // 
            // colNombre_Comercial
            // 
            this.colNombre_Comercial.Caption = "Nombre Comercial";
            this.colNombre_Comercial.FieldName = "Nombre_Comercial";
            this.colNombre_Comercial.Name = "colNombre_Comercial";
            this.colNombre_Comercial.OptionsColumn.AllowEdit = false;
            this.colNombre_Comercial.Visible = true;
            this.colNombre_Comercial.VisibleIndex = 2;
            this.colNombre_Comercial.Width = 124;
            // 
            // colDescripcion_Interna
            // 
            this.colDescripcion_Interna.Caption = "Nombre";
            this.colDescripcion_Interna.FieldName = "Descripcion_Interna";
            this.colDescripcion_Interna.Name = "colDescripcion_Interna";
            this.colDescripcion_Interna.OptionsColumn.AllowEdit = false;
            this.colDescripcion_Interna.Width = 101;
            // 
            // colid_orden
            // 
            this.colid_orden.FieldName = "id_orden";
            this.colid_orden.Name = "colid_orden";
            this.colid_orden.OptionsColumn.AllowEdit = false;
            // 
            // colPlan_Date
            // 
            this.colPlan_Date.Caption = "Fecha de Produccion";
            this.colPlan_Date.FieldName = "Plan_Date";
            this.colPlan_Date.Name = "colPlan_Date";
            this.colPlan_Date.OptionsColumn.AllowEdit = false;
            this.colPlan_Date.Visible = true;
            this.colPlan_Date.VisibleIndex = 3;
            this.colPlan_Date.Width = 152;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Seleccionar";
            this.gridColumn1.ColumnEdit = this.btnSeleccionar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 108;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.tap;
            this.btnSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSeleccionar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSeleccionar_ButtonClick);
            // 
            // frmLotesxPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 489);
            this.Controls.Add(this.gridLotePT);
            this.Controls.Add(this.btnAtras);
            this.Name = "frmLotesxPT";
            this.ShowIcon = false;
            this.Text = "Lotes de Producto Terminado";
            ((System.ComponentModel.ISupportInitialize)(this.gridLotePT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotePT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.GridControl gridLotePT;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLotePT;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSeleccionar;
        private dsPT dsPT1;
        private DevExpress.XtraGrid.Columns.GridColumn colPT_Id;
        private DevExpress.XtraGrid.Columns.GridColumn colLote_PT;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_Comercial;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion_Interna;
        private DevExpress.XtraGrid.Columns.GridColumn colid_orden;
        private DevExpress.XtraGrid.Columns.GridColumn colPlan_Date;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}