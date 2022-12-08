
namespace LOSA.Reportes
{
    partial class frmrptarimasvirtuales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrptarimasvirtuales));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdTarimasV = new DevExpress.XtraGrid.GridControl();
            this.dSReportes1 = new LOSA.Requisiciones.dSReportes();
            this.grdvTarimasV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsap_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_create = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coludxtarima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_tm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltarimas_virtuales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltarimas_retenidas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltarimas_bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colud_esperadas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposbuttonVerVirtuales = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdTarimasV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReportes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvTarimasV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposbuttonVerVirtuales)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTarimasV
            // 
            this.grdTarimasV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTarimasV.DataMember = "tarimasvs";
            this.grdTarimasV.DataSource = this.dSReportes1;
            this.grdTarimasV.Location = new System.Drawing.Point(3, 86);
            this.grdTarimasV.MainView = this.grdvTarimasV;
            this.grdTarimasV.Name = "grdTarimasV";
            this.grdTarimasV.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposbuttonVerVirtuales});
            this.grdTarimasV.Size = new System.Drawing.Size(1469, 626);
            this.grdTarimasV.TabIndex = 0;
            this.grdTarimasV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvTarimasV});
            // 
            // dSReportes1
            // 
            this.dSReportes1.DataSetName = "dSReportes";
            this.dSReportes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdvTarimasV
            // 
            this.grdvTarimasV.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdvTarimasV.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdvTarimasV.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdvTarimasV.Appearance.Row.Options.UseFont = true;
            this.grdvTarimasV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colsap_code,
            this.collote_pt,
            this.colproducto,
            this.coldate_create,
            this.coludxtarima,
            this.colcant_tm,
            this.coltarimas_virtuales,
            this.coltarimas_retenidas,
            this.coltarimas_bodega,
            this.colud_esperadas,
            this.gridColumn1});
            this.grdvTarimasV.GridControl = this.grdTarimasV;
            this.grdvTarimasV.Name = "grdvTarimasV";
            this.grdvTarimasV.OptionsView.ShowAutoFilterRow = true;
            this.grdvTarimasV.OptionsView.ShowFooter = true;
            this.grdvTarimasV.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colsap_code
            // 
            this.colsap_code.Caption = "Cod Sap";
            this.colsap_code.FieldName = "sap_code";
            this.colsap_code.Name = "colsap_code";
            this.colsap_code.OptionsColumn.AllowEdit = false;
            this.colsap_code.Visible = true;
            this.colsap_code.VisibleIndex = 0;
            this.colsap_code.Width = 74;
            // 
            // collote_pt
            // 
            this.collote_pt.Caption = "Lote PT";
            this.collote_pt.FieldName = "lote_pt";
            this.collote_pt.Name = "collote_pt";
            this.collote_pt.OptionsColumn.AllowEdit = false;
            this.collote_pt.Visible = true;
            this.collote_pt.VisibleIndex = 1;
            this.collote_pt.Width = 93;
            // 
            // colproducto
            // 
            this.colproducto.Caption = "Producto";
            this.colproducto.FieldName = "producto";
            this.colproducto.Name = "colproducto";
            this.colproducto.OptionsColumn.AllowEdit = false;
            this.colproducto.Visible = true;
            this.colproducto.VisibleIndex = 2;
            this.colproducto.Width = 152;
            // 
            // coldate_create
            // 
            this.coldate_create.Caption = "Fecha";
            this.coldate_create.FieldName = "date_create";
            this.coldate_create.Name = "coldate_create";
            this.coldate_create.OptionsColumn.AllowEdit = false;
            this.coldate_create.Visible = true;
            this.coldate_create.VisibleIndex = 3;
            this.coldate_create.Width = 78;
            // 
            // coludxtarima
            // 
            this.coludxtarima.Caption = "Unidadres por Tarima";
            this.coludxtarima.FieldName = "udxtarima";
            this.coludxtarima.Name = "coludxtarima";
            this.coludxtarima.OptionsColumn.AllowEdit = false;
            this.coludxtarima.Visible = true;
            this.coludxtarima.VisibleIndex = 4;
            this.coludxtarima.Width = 159;
            // 
            // colcant_tm
            // 
            this.colcant_tm.Caption = "Tarimas Planificadas";
            this.colcant_tm.FieldName = "cant_tm";
            this.colcant_tm.Name = "colcant_tm";
            this.colcant_tm.OptionsColumn.AllowEdit = false;
            this.colcant_tm.Visible = true;
            this.colcant_tm.VisibleIndex = 6;
            this.colcant_tm.Width = 147;
            // 
            // coltarimas_virtuales
            // 
            this.coltarimas_virtuales.Caption = "Tarimas Virtuales";
            this.coltarimas_virtuales.FieldName = "tarimas_virtuales";
            this.coltarimas_virtuales.Name = "coltarimas_virtuales";
            this.coltarimas_virtuales.OptionsColumn.AllowEdit = false;
            this.coltarimas_virtuales.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tarimas_virtuales", "SUMA={0:#.##}")});
            this.coltarimas_virtuales.Visible = true;
            this.coltarimas_virtuales.VisibleIndex = 7;
            this.coltarimas_virtuales.Width = 134;
            // 
            // coltarimas_retenidas
            // 
            this.coltarimas_retenidas.Caption = "Tarimas Retenidas";
            this.coltarimas_retenidas.FieldName = "tarimas_retenidas";
            this.coltarimas_retenidas.Name = "coltarimas_retenidas";
            this.coltarimas_retenidas.OptionsColumn.AllowEdit = false;
            this.coltarimas_retenidas.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tarimas_retenidas", "SUMA={0:#.##}")});
            this.coltarimas_retenidas.Visible = true;
            this.coltarimas_retenidas.VisibleIndex = 8;
            this.coltarimas_retenidas.Width = 131;
            // 
            // coltarimas_bodega
            // 
            this.coltarimas_bodega.Caption = "Tarimas en Bodega";
            this.coltarimas_bodega.FieldName = "tarimas_bodega";
            this.coltarimas_bodega.Name = "coltarimas_bodega";
            this.coltarimas_bodega.OptionsColumn.AllowEdit = false;
            this.coltarimas_bodega.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tarimas_bodega", "SUMA={0:#.##}")});
            this.coltarimas_bodega.Visible = true;
            this.coltarimas_bodega.VisibleIndex = 9;
            this.coltarimas_bodega.Width = 136;
            // 
            // colud_esperadas
            // 
            this.colud_esperadas.Caption = "Unidades Planificadas";
            this.colud_esperadas.FieldName = "ud_esperadas";
            this.colud_esperadas.Name = "colud_esperadas";
            this.colud_esperadas.OptionsColumn.AllowEdit = false;
            this.colud_esperadas.Visible = true;
            this.colud_esperadas.VisibleIndex = 5;
            this.colud_esperadas.Width = 152;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ver Tarimas Virtuales";
            this.gridColumn1.ColumnEdit = this.reposbuttonVerVirtuales;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 10;
            this.gridColumn1.Width = 195;
            // 
            // reposbuttonVerVirtuales
            // 
            this.reposbuttonVerVirtuales.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.reposbuttonVerVirtuales.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposbuttonVerVirtuales.Name = "reposbuttonVerVirtuales";
            this.reposbuttonVerVirtuales.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposbuttonVerVirtuales.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposbuttonVerVirtuales_ButtonClick);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Appearance.BackColor = System.Drawing.Color.White;
            this.btnExport.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseBackColor = true;
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnExport.ImageOptions.Image = global::LOSA.Properties.Resources.excel32px;
            this.btnExport.Location = new System.Drawing.Point(1127, 35);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(129, 45);
            this.btnExport.TabIndex = 45;
            this.btnExport.Text = "Exportar";
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdHome.ImageOptions.Image")));
            this.cmdHome.Location = new System.Drawing.Point(1313, 35);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(129, 45);
            this.cmdHome.TabIndex = 43;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(175, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(1059, 39);
            this.labelControl3.TabIndex = 44;
            this.labelControl3.Text = "Tarimas Virtuales vs Activadas";
            // 
            // frmrptarimasvirtuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 714);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.grdTarimasV);
            this.Name = "frmrptarimasvirtuales";
            ((System.ComponentModel.ISupportInitialize)(this.grdTarimasV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReportes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvTarimasV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposbuttonVerVirtuales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdTarimasV;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvTarimasV;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Requisiciones.dSReportes dSReportes1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colsap_code;
        private DevExpress.XtraGrid.Columns.GridColumn collote_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_create;
        private DevExpress.XtraGrid.Columns.GridColumn coludxtarima;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_tm;
        private DevExpress.XtraGrid.Columns.GridColumn coltarimas_virtuales;
        private DevExpress.XtraGrid.Columns.GridColumn coltarimas_retenidas;
        private DevExpress.XtraGrid.Columns.GridColumn coltarimas_bodega;
        private DevExpress.XtraGrid.Columns.GridColumn colud_esperadas;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposbuttonVerVirtuales;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}