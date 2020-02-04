namespace LOSA.Calidad
{
    partial class frmLotesStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLotesStatus));
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.grDisponibles = new DevExpress.XtraGrid.GridControl();
            this.gvMateriaPrima = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dsCalidad1 = new LOSA.Calidad.dsCalidad();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalidad1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHome
            // 
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdHome.ImageOptions.Image")));
            this.cmdHome.Location = new System.Drawing.Point(12, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(156, 52);
            this.cmdHome.TabIndex = 29;
            this.cmdHome.Text = "Home";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(1, 83);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(638, 475);
            this.xtraTabControl1.TabIndex = 30;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage1.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage1.Controls.Add(this.grDisponibles);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(632, 444);
            this.xtraTabPage1.Text = "Disponibles";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage2.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(632, 444);
            this.xtraTabPage2.Text = "Retenidos";
            // 
            // grDisponibles
            // 
            this.grDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDisponibles.DataMember = "tarimas_disponibles";
            this.grDisponibles.DataSource = this.dsCalidad1;
            this.grDisponibles.Location = new System.Drawing.Point(2, 3);
            this.grDisponibles.MainView = this.gvMateriaPrima;
            this.grDisponibles.Name = "grDisponibles";
            this.grDisponibles.Size = new System.Drawing.Size(629, 441);
            this.grDisponibles.TabIndex = 1;
            this.grDisponibles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMateriaPrima});
            // 
            // gvMateriaPrima
            // 
            this.gvMateriaPrima.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gvMateriaPrima.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvMateriaPrima.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gvMateriaPrima.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvMateriaPrima.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.FocusedRow.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gvMateriaPrima.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvMateriaPrima.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvMateriaPrima.Appearance.Row.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvMateriaPrima.Appearance.SelectedRow.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvMateriaPrima.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.collote,
            this.colmp,
            this.colproveedor,
            this.colfecha_vence,
            this.colunidades,
            this.colpeso,
            this.coltipo});
            this.gvMateriaPrima.GridControl = this.grDisponibles;
            this.gvMateriaPrima.Name = "gvMateriaPrima";
            this.gvMateriaPrima.OptionsView.ShowAutoFilterRow = true;
            this.gvMateriaPrima.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvMateriaPrima.OptionsView.ShowGroupPanel = false;
            // 
            // dsCalidad1
            // 
            this.dsCalidad1.DataSetName = "dsCalidad";
            this.dsCalidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // collote
            // 
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.Visible = true;
            this.collote.VisibleIndex = 0;
            // 
            // colmp
            // 
            this.colmp.Caption = "Nombre";
            this.colmp.FieldName = "mp";
            this.colmp.Name = "colmp";
            this.colmp.Visible = true;
            this.colmp.VisibleIndex = 1;
            // 
            // colproveedor
            // 
            this.colproveedor.Caption = "Prov.";
            this.colproveedor.FieldName = "proveedor";
            this.colproveedor.Name = "colproveedor";
            this.colproveedor.Visible = true;
            this.colproveedor.VisibleIndex = 2;
            // 
            // colfecha_vence
            // 
            this.colfecha_vence.Caption = "F. Vence";
            this.colfecha_vence.FieldName = "fecha_vence";
            this.colfecha_vence.Name = "colfecha_vence";
            this.colfecha_vence.Visible = true;
            this.colfecha_vence.VisibleIndex = 3;
            // 
            // colunidades
            // 
            this.colunidades.Caption = "Unidades";
            this.colunidades.FieldName = "unidades";
            this.colunidades.Name = "colunidades";
            this.colunidades.Visible = true;
            this.colunidades.VisibleIndex = 4;
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Peso";
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 5;
            // 
            // coltipo
            // 
            this.coltipo.Caption = "Tipo";
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 6;
            // 
            // frmLotesStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.cmdHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLotesStatus";
            this.Text = "frmLotesStatus";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalidad1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl grDisponibles;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMateriaPrima;
        private dsCalidad dsCalidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colmp;
        private DevExpress.XtraGrid.Columns.GridColumn colproveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vence;
        private DevExpress.XtraGrid.Columns.GridColumn colunidades;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
    }
}