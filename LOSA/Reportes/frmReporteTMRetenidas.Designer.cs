
namespace LOSA.Reportes
{
    partial class frmReporteTMRetenidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteTMRetenidas));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.gridRetenidos = new DevExpress.XtraGrid.GridControl();
            this.dsCalidad1 = new LOSA.Calidad.dsCalidad();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnview = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colingreso3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidmp3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipotm2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTurno2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_barra2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridRetenidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnview)).BeginInit();
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
            this.cmdHome.Location = new System.Drawing.Point(554, 7);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(153, 54);
            this.cmdHome.TabIndex = 8;
            this.cmdHome.Text = "Atras";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // gridRetenidos
            // 
            this.gridRetenidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRetenidos.DataMember = "tarimas_ret";
            this.gridRetenidos.DataSource = this.dsCalidad1;
            this.gridRetenidos.Location = new System.Drawing.Point(0, 81);
            this.gridRetenidos.MainView = this.gridView2;
            this.gridRetenidos.Name = "gridRetenidos";
            this.gridRetenidos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit2,
            this.btnview});
            this.gridRetenidos.Size = new System.Drawing.Size(715, 443);
            this.gridRetenidos.TabIndex = 9;
            this.gridRetenidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // dsCalidad1
            // 
            this.dsCalidad1.DataSetName = "dsCalidad";
            this.dsCalidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gridView2.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gridView2.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gridView2.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gridView2.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView2.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView2.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.colver,
            this.colingreso3,
            this.colidmp3,
            this.colid_tipotm2,
            this.colTurno2,
            this.colcodigo_barra2,
            this.collote12});
            this.gridView2.DetailHeight = 284;
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView2.GridControl = this.gridRetenidos;
            this.gridView2.GroupCount = 1;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "unidades", this.gridColumn15, "(Cantidad Total ={0:0.##})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "peso", this.gridColumn16, "(Peso ={0:0.##.##} Kg.)")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.collote12, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "id";
            this.gridColumn10.MinWidth = 15;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Width = 56;
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "lote";
            this.gridColumn11.MinWidth = 15;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            this.gridColumn11.Width = 56;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Nombre";
            this.gridColumn12.FieldName = "mp";
            this.gridColumn12.MinWidth = 15;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 2;
            this.gridColumn12.Width = 56;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Prov.";
            this.gridColumn13.FieldName = "proveedor";
            this.gridColumn13.MinWidth = 15;
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 3;
            this.gridColumn13.Width = 56;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "F. Vence";
            this.gridColumn14.FieldName = "fecha_vence";
            this.gridColumn14.MinWidth = 15;
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 4;
            this.gridColumn14.Width = 56;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Unidades";
            this.gridColumn15.FieldName = "unidades";
            this.gridColumn15.MinWidth = 15;
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 5;
            this.gridColumn15.Width = 56;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Peso";
            this.gridColumn16.FieldName = "peso";
            this.gridColumn16.MinWidth = 15;
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 6;
            this.gridColumn16.Width = 56;
            // 
            // gridColumn17
            // 
            this.gridColumn17.FieldName = "estado";
            this.gridColumn17.MinWidth = 15;
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsColumn.AllowEdit = false;
            this.gridColumn17.Width = 56;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Editar Estado";
            this.gridColumn18.ColumnEdit = this.repositoryItemButtonEdit2;
            this.gridColumn18.MinWidth = 15;
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Width = 56;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colver
            // 
            this.colver.Caption = "Detalle";
            this.colver.ColumnEdit = this.btnview;
            this.colver.MinWidth = 15;
            this.colver.Name = "colver";
            this.colver.Width = 56;
            // 
            // btnview
            // 
            this.btnview.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnview.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnview.Name = "btnview";
            this.btnview.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colingreso3
            // 
            this.colingreso3.Caption = "Ingreso";
            this.colingreso3.FieldName = "ingreso";
            this.colingreso3.Name = "colingreso3";
            this.colingreso3.OptionsColumn.AllowEdit = false;
            this.colingreso3.Visible = true;
            this.colingreso3.VisibleIndex = 1;
            // 
            // colidmp3
            // 
            this.colidmp3.Caption = "gridColumn20";
            this.colidmp3.FieldName = "id_mp";
            this.colidmp3.Name = "colidmp3";
            // 
            // colid_tipotm2
            // 
            this.colid_tipotm2.FieldName = "id_tipotm";
            this.colid_tipotm2.Name = "colid_tipotm2";
            // 
            // colTurno2
            // 
            this.colTurno2.FieldName = "Turno";
            this.colTurno2.Name = "colTurno2";
            this.colTurno2.OptionsColumn.AllowEdit = false;
            this.colTurno2.Visible = true;
            this.colTurno2.VisibleIndex = 7;
            // 
            // colcodigo_barra2
            // 
            this.colcodigo_barra2.FieldName = "codigo_barra";
            this.colcodigo_barra2.Name = "colcodigo_barra2";
            this.colcodigo_barra2.OptionsColumn.AllowEdit = false;
            // 
            // collote12
            // 
            this.collote12.Caption = "Lote";
            this.collote12.FieldName = "lote1";
            this.collote12.Name = "collote12";
            this.collote12.OptionsColumn.AllowEdit = false;
            this.collote12.Visible = true;
            this.collote12.VisibleIndex = 9;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(153, 63);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmReporteTMRetenidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 522);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridRetenidos);
            this.Controls.Add(this.cmdHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteTMRetenidas";
            this.Text = "frmReporteTMRetenidas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridRetenidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraGrid.GridControl gridRetenidos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colver;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnview;
        private DevExpress.XtraGrid.Columns.GridColumn colingreso3;
        private DevExpress.XtraGrid.Columns.GridColumn colidmp3;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipotm2;
        private DevExpress.XtraGrid.Columns.GridColumn colTurno2;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra2;
        private DevExpress.XtraGrid.Columns.GridColumn collote12;
        private Calidad.dsCalidad dsCalidad1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}