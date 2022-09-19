
namespace LOSA.Logistica
{
    partial class frmRecuentoInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuentoInventario));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.dtFechaRecu = new DevExpress.XtraEditors.DateEdit();
            this.grd_meses_disponibles = new DevExpress.XtraEditors.GridLookUpEdit();
            this.mesesBindingSource = new System.Windows.Forms.BindingSource();
            this.dsCierreMes1 = new LOSA.Logistica.dsCierreMes();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmes_numero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grd_years = new DevExpress.XtraEditors.GridLookUpEdit();
            this.yearsBindingSource = new System.Windows.Forms.BindingSource();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colejercicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeleLote = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Import_Excel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.grdRecuento = new DevExpress.XtraGrid.GridControl();
            this.grdRecuentoVista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colwhs_equivalente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia_ud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltoma_fisica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabMP = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPT = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager();
            this.colnueva_cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaRecu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaRecu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_meses_disponibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCierreMes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_years.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecuentoVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitContainerControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1324, 120);
            this.panelControl1.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(5, 5);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.splitContainerControl1.Panel1.Controls.Add(this.dtFechaRecu);
            this.splitContainerControl1.Panel1.Controls.Add(this.grd_meses_disponibles);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.grd_years);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.splitContainerControl1.Panel2.Controls.Add(this.btnSeleLote);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnPrint);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnSalir);
            this.splitContainerControl1.Panel2.Controls.Add(this.btn_Import_Excel);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnAddArticulo);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1314, 110);
            this.splitContainerControl1.SplitterPosition = 621;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // dtFechaRecu
            // 
            this.dtFechaRecu.EditValue = null;
            this.dtFechaRecu.Location = new System.Drawing.Point(439, 41);
            this.dtFechaRecu.Name = "dtFechaRecu";
            this.dtFechaRecu.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtFechaRecu.Properties.Appearance.Options.UseFont = true;
            this.dtFechaRecu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaRecu.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtFechaRecu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaRecu.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.dtFechaRecu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFechaRecu.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm";
            this.dtFechaRecu.Size = new System.Drawing.Size(173, 24);
            this.dtFechaRecu.TabIndex = 14;
            // 
            // grd_meses_disponibles
            // 
            this.grd_meses_disponibles.Enabled = false;
            this.grd_meses_disponibles.Location = new System.Drawing.Point(108, 71);
            this.grd_meses_disponibles.Name = "grd_meses_disponibles";
            this.grd_meses_disponibles.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grd_meses_disponibles.Properties.Appearance.Options.UseFont = true;
            this.grd_meses_disponibles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_meses_disponibles.Properties.DataSource = this.mesesBindingSource;
            this.grd_meses_disponibles.Properties.DisplayMember = "mes";
            this.grd_meses_disponibles.Properties.PopupView = this.gridView1;
            this.grd_meses_disponibles.Properties.ValueMember = "mes_numero";
            this.grd_meses_disponibles.Size = new System.Drawing.Size(220, 24);
            this.grd_meses_disponibles.TabIndex = 13;
            this.grd_meses_disponibles.EditValueChanged += new System.EventHandler(this.grd_meses_disponibles_EditValueChanged);
            // 
            // mesesBindingSource
            // 
            this.mesesBindingSource.DataMember = "meses";
            this.mesesBindingSource.DataSource = this.dsCierreMes1;
            // 
            // dsCierreMes1
            // 
            this.dsCierreMes1.DataSetName = "dsCierreMes";
            this.dsCierreMes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmes_numero,
            this.colmes});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colmes_numero
            // 
            this.colmes_numero.FieldName = "mes_numero";
            this.colmes_numero.Name = "colmes_numero";
            // 
            // colmes
            // 
            this.colmes.Caption = "Meses Disponibles";
            this.colmes.FieldName = "mes";
            this.colmes.Name = "colmes";
            this.colmes.Visible = true;
            this.colmes.VisibleIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(334, 44);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(99, 17);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Fecha Recuento:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(8, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 17);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Año:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(8, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 17);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Mes disponible:";
            // 
            // grd_years
            // 
            this.grd_years.Location = new System.Drawing.Point(108, 37);
            this.grd_years.Name = "grd_years";
            this.grd_years.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_years.Properties.Appearance.Options.UseFont = true;
            this.grd_years.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_years.Properties.DataSource = this.yearsBindingSource;
            this.grd_years.Properties.DisplayMember = "ejercicio";
            this.grd_years.Properties.PopupView = this.gridLookUpEdit1View;
            this.grd_years.Properties.ValueMember = "ejercicio";
            this.grd_years.Size = new System.Drawing.Size(220, 24);
            this.grd_years.TabIndex = 10;
            this.grd_years.EditValueChanged += new System.EventHandler(this.grd_years_EditValueChanged);
            // 
            // yearsBindingSource
            // 
            this.yearsBindingSource.DataMember = "years";
            this.yearsBindingSource.DataSource = this.dsCierreMes1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridLookUpEdit1View.Appearance.FilterPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridLookUpEdit1View.Appearance.FocusedRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridLookUpEdit1View.Appearance.FooterPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridLookUpEdit1View.Appearance.GroupFooter.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridLookUpEdit1View.Appearance.GroupPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridLookUpEdit1View.Appearance.GroupRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridLookUpEdit1View.Appearance.Preview.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridLookUpEdit1View.Appearance.TopNewRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colejercicio});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colejercicio
            // 
            this.colejercicio.Caption = "Ejercicio";
            this.colejercicio.FieldName = "ejercicio";
            this.colejercicio.Name = "colejercicio";
            this.colejercicio.Visible = true;
            this.colejercicio.VisibleIndex = 0;
            // 
            // btnSeleLote
            // 
            this.btnSeleLote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleLote.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleLote.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.btnSeleLote.Appearance.Options.UseFont = true;
            this.btnSeleLote.Appearance.Options.UseForeColor = true;
            this.btnSeleLote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleLote.ImageOptions.Image")));
            this.btnSeleLote.Location = new System.Drawing.Point(128, 8);
            this.btnSeleLote.Name = "btnSeleLote";
            this.btnSeleLote.Size = new System.Drawing.Size(175, 90);
            this.btnSeleLote.TabIndex = 18;
            this.btnSeleLote.Text = "Seleccion de lotes";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Appearance.Options.UseForeColor = true;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(305, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(175, 44);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.btnSalir.Appearance.Options.UseFont = true;
            this.btnSalir.Appearance.Options.UseForeColor = true;
            this.btnSalir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSalir.ImageOptions.SvgImage")));
            this.btnSalir.Location = new System.Drawing.Point(483, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(175, 44);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btn_Import_Excel
            // 
            this.btn_Import_Excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Import_Excel.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import_Excel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.btn_Import_Excel.Appearance.Options.UseFont = true;
            this.btn_Import_Excel.Appearance.Options.UseForeColor = true;
            this.btn_Import_Excel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Import_Excel.ImageOptions.Image")));
            this.btn_Import_Excel.Location = new System.Drawing.Point(306, 55);
            this.btn_Import_Excel.Name = "btn_Import_Excel";
            this.btn_Import_Excel.Size = new System.Drawing.Size(175, 44);
            this.btn_Import_Excel.TabIndex = 15;
            this.btn_Import_Excel.Text = "Importar Excel";
            this.btn_Import_Excel.Visible = false;
            // 
            // btnAddArticulo
            // 
            this.btnAddArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddArticulo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArticulo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.btnAddArticulo.Appearance.Options.UseFont = true;
            this.btnAddArticulo.Appearance.Options.UseForeColor = true;
            this.btnAddArticulo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddArticulo.ImageOptions.Image")));
            this.btnAddArticulo.Location = new System.Drawing.Point(483, 55);
            this.btnAddArticulo.Name = "btnAddArticulo";
            this.btnAddArticulo.Size = new System.Drawing.Size(176, 44);
            this.btnAddArticulo.TabIndex = 14;
            this.btnAddArticulo.Text = "Adicionar Articulo";
            this.btnAddArticulo.Click += new System.EventHandler(this.btnAddArticulo_Click);
            // 
            // grdRecuento
            // 
            this.grdRecuento.DataMember = "Recuento_mpV2";
            this.grdRecuento.DataSource = this.dsCierreMes1;
            this.grdRecuento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRecuento.Location = new System.Drawing.Point(0, 0);
            this.grdRecuento.MainView = this.grdRecuentoVista;
            this.grdRecuento.Name = "grdRecuento";
            this.grdRecuento.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryEliminar});
            this.grdRecuento.Size = new System.Drawing.Size(1318, 554);
            this.grdRecuento.TabIndex = 1;
            this.grdRecuento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdRecuentoVista});
            // 
            // grdRecuentoVista
            // 
            this.grdRecuentoVista.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdRecuentoVista.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdRecuentoVista.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdRecuentoVista.Appearance.Row.Options.UseFont = true;
            this.grdRecuentoVista.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_mp,
            this.colcode_sap,
            this.colnombre_comercial,
            this.colTipoId,
            this.colTipoName,
            this.colwhs_equivalente,
            this.colpresentacion,
            this.colexistencia_ud,
            this.colexistencia,
            this.collote,
            this.coltoma_fisica,
            this.coldiferencia,
            this.colnueva_cantidad,
            this.gridColumn1});
            this.grdRecuentoVista.GridControl = this.grdRecuento;
            this.grdRecuentoVista.Name = "grdRecuentoVista";
            this.grdRecuentoVista.OptionsView.ShowGroupPanel = false;
            this.grdRecuentoVista.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdRecuentoVista_CellValueChanged);
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.Name = "colid_mp";
            // 
            // colcode_sap
            // 
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.AllowEdit = false;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 0;
            // 
            // colnombre_comercial
            // 
            this.colnombre_comercial.FieldName = "nombre_comercial";
            this.colnombre_comercial.Name = "colnombre_comercial";
            this.colnombre_comercial.OptionsColumn.AllowEdit = false;
            this.colnombre_comercial.Visible = true;
            this.colnombre_comercial.VisibleIndex = 1;
            // 
            // colTipoId
            // 
            this.colTipoId.FieldName = "TipoId";
            this.colTipoId.Name = "colTipoId";
            this.colTipoId.OptionsColumn.AllowEdit = false;
            // 
            // colTipoName
            // 
            this.colTipoName.FieldName = "TipoName";
            this.colTipoName.Name = "colTipoName";
            this.colTipoName.OptionsColumn.AllowEdit = false;
            this.colTipoName.Visible = true;
            this.colTipoName.VisibleIndex = 2;
            // 
            // colwhs_equivalente
            // 
            this.colwhs_equivalente.FieldName = "whs_equivalente";
            this.colwhs_equivalente.Name = "colwhs_equivalente";
            this.colwhs_equivalente.OptionsColumn.AllowEdit = false;
            this.colwhs_equivalente.Visible = true;
            this.colwhs_equivalente.VisibleIndex = 3;
            // 
            // colpresentacion
            // 
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.OptionsColumn.AllowEdit = false;
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 4;
            // 
            // colexistencia_ud
            // 
            this.colexistencia_ud.FieldName = "existencia_ud";
            this.colexistencia_ud.Name = "colexistencia_ud";
            this.colexistencia_ud.OptionsColumn.AllowEdit = false;
            this.colexistencia_ud.Visible = true;
            this.colexistencia_ud.VisibleIndex = 6;
            // 
            // colexistencia
            // 
            this.colexistencia.FieldName = "existencia";
            this.colexistencia.Name = "colexistencia";
            this.colexistencia.OptionsColumn.AllowEdit = false;
            this.colexistencia.Visible = true;
            this.colexistencia.VisibleIndex = 7;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 5;
            // 
            // coltoma_fisica
            // 
            this.coltoma_fisica.FieldName = "toma_fisica";
            this.coltoma_fisica.Name = "coltoma_fisica";
            this.coltoma_fisica.Visible = true;
            this.coltoma_fisica.VisibleIndex = 8;
            // 
            // coldiferencia
            // 
            this.coldiferencia.FieldName = "diferencia";
            this.coldiferencia.Name = "coldiferencia";
            this.coldiferencia.Visible = true;
            this.coldiferencia.VisibleIndex = 9;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Eliminar";
            this.gridColumn1.ColumnEdit = this.repositoryEliminar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 11;
            // 
            // repositoryEliminar
            // 
            this.repositoryEliminar.AutoHeight = false;
            editorButtonImageOptions3.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions3.SvgImage")));
            this.repositoryEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Eliminar", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryEliminar.Name = "repositoryEliminar";
            this.repositoryEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryEliminar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryEliminar_ButtonClick);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 120);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabMP;
            this.xtraTabControl1.Size = new System.Drawing.Size(1324, 582);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabMP,
            this.xtraTabPT});
            // 
            // xtraTabMP
            // 
            this.xtraTabMP.Controls.Add(this.grdRecuento);
            this.xtraTabMP.Name = "xtraTabMP";
            this.xtraTabMP.Size = new System.Drawing.Size(1318, 554);
            this.xtraTabMP.Text = "Materia Prima";
            // 
            // xtraTabPT
            // 
            this.xtraTabPT.Name = "xtraTabPT";
            this.xtraTabPT.Size = new System.Drawing.Size(1318, 554);
            this.xtraTabPT.Text = "Producto Terminado";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // colnueva_cantidad
            // 
            this.colnueva_cantidad.Caption = "Nueva Cantidad";
            this.colnueva_cantidad.FieldName = "nueva_cantidad";
            this.colnueva_cantidad.Name = "colnueva_cantidad";
            this.colnueva_cantidad.Visible = true;
            this.colnueva_cantidad.VisibleIndex = 10;
            // 
            // frmRecuentoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 702);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl1);
            this.IsMdiContainer = true;
            this.Name = "frmRecuentoInventario";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaRecu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaRecu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_meses_disponibles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCierreMes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_years.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecuentoVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabMP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grdRecuento;
        private DevExpress.XtraGrid.Views.Grid.GridView grdRecuentoVista;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.DateEdit dtFechaRecu;
        private DevExpress.XtraEditors.GridLookUpEdit grd_meses_disponibles;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmes_numero;
        private DevExpress.XtraGrid.Columns.GridColumn colmes;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit grd_years;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colejercicio;
        private DevExpress.XtraEditors.SimpleButton btnSeleLote;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.SimpleButton btn_Import_Excel;
        private DevExpress.XtraEditors.SimpleButton btnAddArticulo;
        private dsCierreMes dsCierreMes1;
        private System.Windows.Forms.BindingSource mesesBindingSource;
        private System.Windows.Forms.BindingSource yearsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoId;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoName;
        private DevExpress.XtraGrid.Columns.GridColumn colwhs_equivalente;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia_ud;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn coltoma_fisica;
        private DevExpress.XtraGrid.Columns.GridColumn coldiferencia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryEliminar;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabMP;
        private DevExpress.XtraTab.XtraTabPage xtraTabPT;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraGrid.Columns.GridColumn colnueva_cantidad;
    }
}