
namespace LOSA.Calidad
{
    partial class frmManejoTarimas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManejoTarimas));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btn_cerrar = new DevExpress.XtraEditors.SimpleButton();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsCalidad = new LOSA.Calidad.dsCalidad();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_scan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldata_Mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbit_consumo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesactivas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_desactivar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_desactivar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Appearance.Options.UseFont = true;
            this.btn_cerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.ImageOptions.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1161, 8);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(106, 55);
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "tarimas_data";
            this.grd_data.DataSource = this.dsCalidad;
            this.grd_data.Location = new System.Drawing.Point(1, 88);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_desactivar});
            this.grd_data.Size = new System.Drawing.Size(1274, 654);
            this.grd_data.TabIndex = 2;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsCalidad
            // 
            this.dsCalidad.DataSetName = "dsCalidad";
            this.dsCalidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colproducto,
            this.colcodigo,
            this.colcantidad,
            this.colkg,
            this.colfecha_scan,
            this.coldata_Mp,
            this.collote_mp,
            this.colbit_consumo,
            this.colDesactivas});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.GroupCount = 1;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowFooter = true;
            this.grdv_data.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coldata_Mp, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colproducto
            // 
            this.colproducto.Caption = "Materia Prima";
            this.colproducto.FieldName = "producto";
            this.colproducto.Name = "colproducto";
            this.colproducto.OptionsColumn.AllowEdit = false;
            this.colproducto.Visible = true;
            this.colproducto.VisibleIndex = 0;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo Mp";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 1;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Sacos";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "SUMA={0:#.##}")});
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 2;
            // 
            // colkg
            // 
            this.colkg.Caption = "Kg";
            this.colkg.FieldName = "kg";
            this.colkg.Name = "colkg";
            this.colkg.OptionsColumn.AllowEdit = false;
            this.colkg.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "kg", "SUMA={0:#.##}")});
            this.colkg.Visible = true;
            this.colkg.VisibleIndex = 3;
            // 
            // colfecha_scan
            // 
            this.colfecha_scan.Caption = "Fecha entrega";
            this.colfecha_scan.FieldName = "fecha_scan";
            this.colfecha_scan.Name = "colfecha_scan";
            this.colfecha_scan.OptionsColumn.AllowEdit = false;
            this.colfecha_scan.Visible = true;
            this.colfecha_scan.VisibleIndex = 4;
            // 
            // coldata_Mp
            // 
            this.coldata_Mp.Caption = "Lote MP";
            this.coldata_Mp.FieldName = "data_Mp";
            this.coldata_Mp.Name = "coldata_Mp";
            this.coldata_Mp.OptionsColumn.AllowEdit = false;
            this.coldata_Mp.Visible = true;
            this.coldata_Mp.VisibleIndex = 6;
            // 
            // collote_mp
            // 
            this.collote_mp.Caption = "Lote MP";
            this.collote_mp.FieldName = "lote_mp";
            this.collote_mp.Name = "collote_mp";
            this.collote_mp.OptionsColumn.AllowEdit = false;
            this.collote_mp.Visible = true;
            this.collote_mp.VisibleIndex = 5;
            // 
            // colbit_consumo
            // 
            this.colbit_consumo.FieldName = "bit_consumo";
            this.colbit_consumo.Name = "colbit_consumo";
            // 
            // colDesactivas
            // 
            this.colDesactivas.Caption = "Desactivar";
            this.colDesactivas.ColumnEdit = this.btn_desactivar;
            this.colDesactivas.Name = "colDesactivas";
            this.colDesactivas.Visible = true;
            this.colDesactivas.VisibleIndex = 6;
            // 
            // btn_desactivar
            // 
            this.btn_desactivar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btn_desactivar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btn_desactivar.Name = "btn_desactivar";
            this.btn_desactivar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_desactivar.Click += new System.EventHandler(this.btn_desactivar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(165, 20);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Ajustar lote para la cola.";
            // 
            // frmManejoTarimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 743);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.btn_cerrar);
            this.Name = "frmManejoTarimas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManejoTarimas";
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_desactivar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_cerrar;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private dsCalidad dsCalidad;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colkg;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_scan;
        private DevExpress.XtraGrid.Columns.GridColumn collote_mp;
        private DevExpress.XtraGrid.Columns.GridColumn coldata_Mp;
        private DevExpress.XtraGrid.Columns.GridColumn colbit_consumo;
        private DevExpress.XtraGrid.Columns.GridColumn colDesactivas;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_desactivar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}