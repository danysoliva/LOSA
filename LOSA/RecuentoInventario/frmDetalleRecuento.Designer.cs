
namespace LOSA.RecuentoInventario
{
    partial class frmDetalleRecuento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleRecuento));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.grd_meses_disponibles = new DevExpress.XtraEditors.GridLookUpEdit();
            this.mesesBindingSource = new System.Windows.Forms.BindingSource();
            this.dsCierreMes1 = new LOSA.Logistica.dsCierreMes();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmes_numero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grd_years = new DevExpress.XtraEditors.GridLookUpEdit();
            this.yearsBindingSource = new System.Windows.Forms.BindingSource();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colejercicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grd_mps = new DevExpress.XtraGrid.GridControl();
            this.grdv_mps = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id_bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_bodega = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bodegasBindingSource = new System.Windows.Forms.BindingSource();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistenciaAnterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.count_id = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_meses_disponibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCierreMes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_years.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_mps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_mps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_bodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.txtComentario);
            this.panelControl2.Controls.Add(this.grd_meses_disponibles);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.grd_years);
            this.panelControl2.Controls.Add(this.btnConfirmar);
            this.panelControl2.Controls.Add(this.cmdClose);
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1270, 668);
            this.panelControl2.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(411, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 17);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Comentario:";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(491, 23);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(261, 47);
            this.txtComentario.TabIndex = 12;
            // 
            // grd_meses_disponibles
            // 
            this.grd_meses_disponibles.EditValue = "";
            this.grd_meses_disponibles.Enabled = false;
            this.grd_meses_disponibles.Location = new System.Drawing.Point(218, 23);
            this.grd_meses_disponibles.Name = "grd_meses_disponibles";
            this.grd_meses_disponibles.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grd_meses_disponibles.Properties.Appearance.Options.UseFont = true;
            this.grd_meses_disponibles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_meses_disponibles.Properties.DataSource = this.mesesBindingSource;
            this.grd_meses_disponibles.Properties.DisplayMember = "mes";
            this.grd_meses_disponibles.Properties.PopupView = this.gridView1;
            this.grd_meses_disponibles.Properties.ValueMember = "mes_numero";
            this.grd_meses_disponibles.Size = new System.Drawing.Size(157, 24);
            this.grd_meses_disponibles.TabIndex = 11;
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
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 17);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Año:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(184, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 17);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Mes:";
            // 
            // grd_years
            // 
            this.grd_years.EditValue = "";
            this.grd_years.Enabled = false;
            this.grd_years.Location = new System.Drawing.Point(51, 23);
            this.grd_years.Name = "grd_years";
            this.grd_years.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_years.Properties.Appearance.Options.UseFont = true;
            this.grd_years.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_years.Properties.DataSource = this.yearsBindingSource;
            this.grd_years.Properties.DisplayMember = "ejercicio";
            this.grd_years.Properties.PopupView = this.gridLookUpEdit1View;
            this.grd_years.Properties.ValueMember = "ejercicio";
            this.grd_years.Size = new System.Drawing.Size(112, 24);
            this.grd_years.TabIndex = 9;
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
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Appearance.Options.UseFont = true;
            this.btnConfirmar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.ImageOptions.Image")));
            this.btnConfirmar.Location = new System.Drawing.Point(1010, 9);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(111, 50);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Appearance.Options.UseFont = true;
            this.cmdClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.ImageOptions.Image")));
            this.cmdClose.Location = new System.Drawing.Point(1150, 9);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(97, 50);
            this.cmdClose.TabIndex = 5;
            this.cmdClose.Text = "Cancelar";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.grd_mps);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(2, 74);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1266, 592);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Materias Primas a Modificar";
            // 
            // grd_mps
            // 
            this.grd_mps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_mps.Location = new System.Drawing.Point(2, 24);
            this.grd_mps.MainView = this.grdv_mps;
            this.grd_mps.Name = "grd_mps";
            this.grd_mps.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.grd_bodega});
            this.grd_mps.Size = new System.Drawing.Size(1262, 566);
            this.grd_mps.TabIndex = 0;
            this.grd_mps.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_mps});
            // 
            // grdv_mps
            // 
            this.grdv_mps.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_mps.Appearance.Empty.Options.UseFont = true;
            this.grdv_mps.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_mps.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_mps.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_mps.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_mps.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_mps.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_mps.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_mps.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_mps.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_mps.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_mps.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_mps.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_mps.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_mps.Appearance.Preview.Options.UseFont = true;
            this.grdv_mps.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_mps.Appearance.Row.Options.UseFont = true;
            this.grdv_mps.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_mps.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_mps.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collote,
            this.colMP,
            this.id_mp,
            this.id_bodega,
            this.colcodigo,
            this.colExistencia,
            this.colExistenciaAnterior,
            this.coldiferencia,
            this.colSeleccionado,
            this.count_id});
            this.grdv_mps.GridControl = this.grd_mps;
            this.grdv_mps.Name = "grdv_mps";
            this.grdv_mps.OptionsView.ShowAutoFilterRow = true;
            this.grdv_mps.OptionsView.ShowGroupPanel = false;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 1;
            // 
            // colMP
            // 
            this.colMP.Caption = "Materia Prima";
            this.colMP.FieldName = "descripcion";
            this.colMP.Name = "colMP";
            this.colMP.OptionsColumn.AllowEdit = false;
            this.colMP.Visible = true;
            this.colMP.VisibleIndex = 0;
            // 
            // id_mp
            // 
            this.id_mp.Caption = "idmp";
            this.id_mp.FieldName = "id_mp";
            this.id_mp.Name = "id_mp";
            this.id_mp.OptionsColumn.AllowEdit = false;
            // 
            // id_bodega
            // 
            this.id_bodega.Caption = "Bodega";
            this.id_bodega.ColumnEdit = this.grd_bodega;
            this.id_bodega.FieldName = "id_bodega";
            this.id_bodega.Name = "id_bodega";
            this.id_bodega.OptionsColumn.AllowEdit = false;
            this.id_bodega.Visible = true;
            this.id_bodega.VisibleIndex = 2;
            // 
            // grd_bodega
            // 
            this.grd_bodega.AutoHeight = false;
            this.grd_bodega.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_bodega.DataSource = this.bodegasBindingSource;
            this.grd_bodega.DisplayMember = "whs_code";
            this.grd_bodega.Name = "grd_bodega";
            this.grd_bodega.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.grd_bodega.ValueMember = "id";
            // 
            // bodegasBindingSource
            // 
            this.bodegasBindingSource.DataMember = "bodegas";
            this.bodegasBindingSource.DataSource = this.dsCierreMes1;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Bodega Cod";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            // 
            // colExistencia
            // 
            this.colExistencia.Caption = "Nueva Existencia";
            this.colExistencia.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.colExistencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colExistencia.FieldName = "peso";
            this.colExistencia.Name = "colExistencia";
            this.colExistencia.OptionsColumn.AllowEdit = false;
            this.colExistencia.Visible = true;
            this.colExistencia.VisibleIndex = 4;
            // 
            // colExistenciaAnterior
            // 
            this.colExistenciaAnterior.Caption = "Existencia Anterior";
            this.colExistenciaAnterior.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.colExistenciaAnterior.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colExistenciaAnterior.FieldName = "ExistenciaAprox";
            this.colExistenciaAnterior.Name = "colExistenciaAnterior";
            this.colExistenciaAnterior.OptionsColumn.AllowEdit = false;
            this.colExistenciaAnterior.Visible = true;
            this.colExistenciaAnterior.VisibleIndex = 3;
            // 
            // coldiferencia
            // 
            this.coldiferencia.Caption = "Diferencia";
            this.coldiferencia.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.coldiferencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldiferencia.FieldName = "diferencia";
            this.coldiferencia.Name = "coldiferencia";
            this.coldiferencia.OptionsColumn.AllowEdit = false;
            this.coldiferencia.UnboundExpression = "[peso] - [seleccionado]";
            this.coldiferencia.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.coldiferencia.Visible = true;
            this.coldiferencia.VisibleIndex = 5;
            // 
            // colSeleccionado
            // 
            this.colSeleccionado.Caption = "gridColumn1";
            this.colSeleccionado.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.colSeleccionado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSeleccionado.FieldName = "seleccionado";
            this.colSeleccionado.Name = "colSeleccionado";
            // 
            // count_id
            // 
            this.count_id.Caption = "count_id";
            this.count_id.FieldName = "count_id";
            this.count_id.Name = "count_id";
            this.count_id.OptionsColumn.AllowEdit = false;
            // 
            // frmDetalleRecuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 670);
            this.Controls.Add(this.panelControl2);
            this.Name = "frmDetalleRecuento";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_meses_disponibles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCierreMes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_years.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_mps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_mps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_bodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grd_mps;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_mps;
        private DevExpress.XtraGrid.Columns.GridColumn colMP;
        private DevExpress.XtraGrid.Columns.GridColumn id_mp;
        private DevExpress.XtraGrid.Columns.GridColumn id_bodega;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit grd_bodega;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colExistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colExistenciaAnterior;
        private DevExpress.XtraGrid.Columns.GridColumn coldiferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn count_id;
        private DevExpress.XtraEditors.SimpleButton btnConfirmar;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private Logistica.dsCierreMes dsCierreMes1;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private System.Windows.Forms.BindingSource bodegasBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit grd_meses_disponibles;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmes_numero;
        private DevExpress.XtraGrid.Columns.GridColumn colmes;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit grd_years;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colejercicio;
        private System.Windows.Forms.BindingSource yearsBindingSource;
        private System.Windows.Forms.BindingSource mesesBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtComentario;
    }
}