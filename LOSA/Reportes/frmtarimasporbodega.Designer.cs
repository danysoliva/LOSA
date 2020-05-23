namespace LOSA.Reportes
{
    partial class frmtarimasporbodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtarimasporbodega));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grd_reporte = new DevExpress.XtraGrid.GridControl();
            this.dsReportes = new LOSA.Reportes.dsReportes();
            this.grdv_reporte = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grd_bodegas = new DevExpress.XtraGrid.GridControl();
            this.dsRecepcionMPx = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.grdv_bodegas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colselect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_reporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_reporte)).BeginInit();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_bodegas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_bodegas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).BeginInit();
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
            this.cmdHome.Location = new System.Drawing.Point(537, 13);
            this.cmdHome.Margin = new System.Windows.Forms.Padding(4);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(265, 87);
            this.cmdHome.TabIndex = 8;
            this.cmdHome.Text = "Atras";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigationFrame1.Controls.Add(this.navigationPage1);
            this.navigationFrame1.Controls.Add(this.navigationPage2);
            this.navigationFrame1.Location = new System.Drawing.Point(2, 120);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationFrame1.SelectedPage = this.navigationPage2;
            this.navigationFrame1.Size = new System.Drawing.Size(813, 475);
            this.navigationFrame1.TabIndex = 9;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Controls.Add(this.grd_reporte);
            this.navigationPage1.Controls.Add(this.simpleButton1);
            this.navigationPage1.Controls.Add(this.labelControl1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(813, 475);
            // 
            // grd_reporte
            // 
            this.grd_reporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_reporte.DataMember = "TarimasPorBodega";
            this.grd_reporte.DataSource = this.dsReportes;
            this.grd_reporte.Location = new System.Drawing.Point(3, 65);
            this.grd_reporte.MainView = this.grdv_reporte;
            this.grd_reporte.Name = "grd_reporte";
            this.grd_reporte.Size = new System.Drawing.Size(807, 407);
            this.grd_reporte.TabIndex = 17;
            this.grd_reporte.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_reporte});
            // 
            // dsReportes
            // 
            this.dsReportes.DataSetName = "dsReportes";
            this.dsReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_reporte
            // 
            this.grdv_reporte.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 12F);
            this.grdv_reporte.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_reporte.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 12F);
            this.grdv_reporte.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_reporte.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_reporte.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_reporte.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.grdv_reporte.Appearance.Row.Options.UseFont = true;
            this.grdv_reporte.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 18F);
            this.grdv_reporte.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_reporte.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colcodigo_barra,
            this.collote_materia_prima,
            this.colitemcode,
            this.colitemname,
            this.colid_proveedor,
            this.colproveedor,
            this.colcantidad});
            this.grdv_reporte.GridControl = this.grd_reporte;
            this.grdv_reporte.Name = "grdv_reporte";
            this.grdv_reporte.OptionsView.ShowAutoFilterRow = true;
            this.grdv_reporte.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.OptionsColumn.AllowEdit = false;
            // 
            // colcodigo_barra
            // 
            this.colcodigo_barra.Caption = "Codigo";
            this.colcodigo_barra.FieldName = "codigo_barra";
            this.colcodigo_barra.Name = "colcodigo_barra";
            this.colcodigo_barra.OptionsColumn.AllowEdit = false;
            this.colcodigo_barra.Visible = true;
            this.colcodigo_barra.VisibleIndex = 0;
            this.colcodigo_barra.Width = 94;
            // 
            // collote_materia_prima
            // 
            this.collote_materia_prima.Caption = "Lote";
            this.collote_materia_prima.FieldName = "lote_materia_prima";
            this.collote_materia_prima.Name = "collote_materia_prima";
            this.collote_materia_prima.OptionsColumn.AllowEdit = false;
            this.collote_materia_prima.Visible = true;
            this.collote_materia_prima.VisibleIndex = 1;
            this.collote_materia_prima.Width = 159;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Codigo A.";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 2;
            this.colitemcode.Width = 103;
            // 
            // colitemname
            // 
            this.colitemname.Caption = "Descripcion";
            this.colitemname.FieldName = "itemname";
            this.colitemname.Name = "colitemname";
            this.colitemname.OptionsColumn.AllowEdit = false;
            this.colitemname.Visible = true;
            this.colitemname.VisibleIndex = 3;
            this.colitemname.Width = 103;
            // 
            // colid_proveedor
            // 
            this.colid_proveedor.Caption = "Provedor C.";
            this.colid_proveedor.FieldName = "id_proveedor";
            this.colid_proveedor.Name = "colid_proveedor";
            this.colid_proveedor.OptionsColumn.AllowEdit = false;
            this.colid_proveedor.Visible = true;
            this.colid_proveedor.VisibleIndex = 4;
            this.colid_proveedor.Width = 103;
            // 
            // colproveedor
            // 
            this.colproveedor.Caption = "Proveedor";
            this.colproveedor.FieldName = "proveedor";
            this.colproveedor.Name = "colproveedor";
            this.colproveedor.OptionsColumn.AllowEdit = false;
            this.colproveedor.Visible = true;
            this.colproveedor.VisibleIndex = 5;
            this.colproveedor.Width = 103;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Unidades";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 6;
            this.colcantidad.Width = 122;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(522, 12);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(265, 43);
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Text = "Elegir otra bodega";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(110, 4);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(324, 54);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Tarimas";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Controls.Add(this.grd_bodegas);
            this.navigationPage2.Controls.Add(this.labelControl4);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(813, 475);
            // 
            // grd_bodegas
            // 
            this.grd_bodegas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_bodegas.DataMember = "bodegas";
            this.grd_bodegas.DataSource = this.dsRecepcionMPx;
            this.grd_bodegas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grd_bodegas.Location = new System.Drawing.Point(-4, 77);
            this.grd_bodegas.MainView = this.grdv_bodegas;
            this.grd_bodegas.Margin = new System.Windows.Forms.Padding(4);
            this.grd_bodegas.Name = "grd_bodegas";
            this.grd_bodegas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSeleccionar});
            this.grd_bodegas.Size = new System.Drawing.Size(820, 388);
            this.grd_bodegas.TabIndex = 17;
            this.grd_bodegas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_bodegas});
            // 
            // dsRecepcionMPx
            // 
            this.dsRecepcionMPx.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_bodegas
            // 
            this.grdv_bodegas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grdv_bodegas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_bodegas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdv_bodegas.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_bodegas.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_bodegas.Appearance.Row.Options.UseFont = true;
            this.grdv_bodegas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.colselect});
            this.grdv_bodegas.GridControl = this.grd_bodegas;
            this.grdv_bodegas.Name = "grdv_bodegas";
            this.grdv_bodegas.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "Codigo";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 119;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Bodega";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 371;
            // 
            // colselect
            // 
            this.colselect.Caption = "Seleccionar";
            this.colselect.ColumnEdit = this.btnSeleccionar;
            this.colselect.FieldName = "select";
            this.colselect.Name = "colselect";
            this.colselect.Visible = true;
            this.colselect.VisibleIndex = 2;
            this.colselect.Width = 110;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.tap;
            this.btnSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(236, 15);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(381, 54);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Seleccione la Bodega";
            // 
            // frmtarimasporbodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 595);
            this.Controls.Add(this.navigationFrame1);
            this.Controls.Add(this.cmdHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmtarimasporbodega";
            this.Text = "frmtarimasporbodega";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_reporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_reporte)).EndInit();
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_bodegas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_bodegas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl grd_bodegas;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_bodegas;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colselect;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSeleccionar;
        private RecepcionMP.dsRecepcionMPx dsRecepcionMPx;
        private DevExpress.XtraGrid.GridControl grd_reporte;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_reporte;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsReportes dsReportes;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra;
        private DevExpress.XtraGrid.Columns.GridColumn collote_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colitemname;
        private DevExpress.XtraGrid.Columns.GridColumn colid_proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colproveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
    }
}