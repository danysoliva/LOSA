
namespace LOSA.TransaccionesPT
{
    partial class frmRevisionDeActivaciondeTm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRevisionDeActivaciondeTm));
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsPT1 = new LOSA.TransaccionesPT.dsPT();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigobarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldateprod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colturno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colloteagrupador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colf_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_escaneo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridNoActivadas = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNoActivadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.cmdHome.Location = new System.Drawing.Point(1096, 3);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(199, 52);
            this.cmdHome.TabIndex = 8;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(5, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(1085, 39);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Activación de Tarimas";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(139, 80);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEdit1.Properties.Appearance.Options.UseFont = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Properties.IsFloatValue = false;
            this.spinEdit1.Properties.Mask.EditMask = "N00";
            this.spinEdit1.Size = new System.Drawing.Size(77, 24);
            this.spinEdit1.TabIndex = 33;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 83);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 17);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "Vista Cant. Registro(s)";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(222, 72);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(133, 32);
            this.simpleButton1.TabIndex = 35;
            this.simpleButton1.Text = "Recargar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 110);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1290, 633);
            this.xtraTabControl1.TabIndex = 36;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage1.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1284, 597);
            this.xtraTabPage1.Text = "Tarimas Activadas";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "loadtml";
            this.gridControl1.DataSource = this.dsPT1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1284, 597);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // dsPT1
            // 
            this.dsPT1.DataSetName = "dsPT";
            this.dsPT1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcodigobarra,
            this.collote,
            this.coldateprod,
            this.colturno,
            this.colproducto,
            this.colcodigop,
            this.colloteagrupador,
            this.colf_vencimiento,
            this.colcantidad,
            this.colpeso,
            this.colfecha_escaneo});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colcodigobarra
            // 
            this.colcodigobarra.Caption = "Codigo Barra";
            this.colcodigobarra.FieldName = "codigobarra";
            this.colcodigobarra.Name = "colcodigobarra";
            this.colcodigobarra.OptionsColumn.AllowEdit = false;
            this.colcodigobarra.Visible = true;
            this.colcodigobarra.VisibleIndex = 0;
            this.colcodigobarra.Width = 126;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 1;
            this.collote.Width = 126;
            // 
            // coldateprod
            // 
            this.coldateprod.Caption = "F. Produccion";
            this.coldateprod.FieldName = "dateprod";
            this.coldateprod.Name = "coldateprod";
            this.coldateprod.OptionsColumn.AllowEdit = false;
            this.coldateprod.Visible = true;
            this.coldateprod.VisibleIndex = 3;
            this.coldateprod.Width = 123;
            // 
            // colturno
            // 
            this.colturno.Caption = "Turno";
            this.colturno.FieldName = "turno";
            this.colturno.Name = "colturno";
            this.colturno.OptionsColumn.AllowEdit = false;
            this.colturno.Visible = true;
            this.colturno.VisibleIndex = 5;
            this.colturno.Width = 123;
            // 
            // colproducto
            // 
            this.colproducto.Caption = "Producto";
            this.colproducto.FieldName = "producto";
            this.colproducto.Name = "colproducto";
            this.colproducto.OptionsColumn.AllowEdit = false;
            this.colproducto.Visible = true;
            this.colproducto.VisibleIndex = 6;
            this.colproducto.Width = 123;
            // 
            // colcodigop
            // 
            this.colcodigop.Caption = "Codigo P";
            this.colcodigop.FieldName = "codigop";
            this.colcodigop.Name = "colcodigop";
            this.colcodigop.OptionsColumn.AllowEdit = false;
            this.colcodigop.Visible = true;
            this.colcodigop.VisibleIndex = 7;
            this.colcodigop.Width = 123;
            // 
            // colloteagrupador
            // 
            this.colloteagrupador.Caption = "Lote PT";
            this.colloteagrupador.FieldName = "loteagrupador";
            this.colloteagrupador.Name = "colloteagrupador";
            this.colloteagrupador.OptionsColumn.AllowEdit = false;
            // 
            // colf_vencimiento
            // 
            this.colf_vencimiento.Caption = "F. Vencimiento";
            this.colf_vencimiento.FieldName = "f_vencimiento";
            this.colf_vencimiento.Name = "colf_vencimiento";
            this.colf_vencimiento.OptionsColumn.AllowEdit = false;
            this.colf_vencimiento.Visible = true;
            this.colf_vencimiento.VisibleIndex = 4;
            this.colf_vencimiento.Width = 132;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 8;
            this.colcantidad.Width = 118;
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Peso";
            this.colpeso.FieldName = "fecha_activacion";
            this.colpeso.Name = "colpeso";
            this.colpeso.OptionsColumn.AllowEdit = false;
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 9;
            this.colpeso.Width = 125;
            // 
            // colfecha_escaneo
            // 
            this.colfecha_escaneo.Caption = "F. Ingreso";
            this.colfecha_escaneo.DisplayFormat.FormatString = "g";
            this.colfecha_escaneo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_escaneo.FieldName = "fecha_activacion";
            this.colfecha_escaneo.Name = "colfecha_escaneo";
            this.colfecha_escaneo.OptionsColumn.AllowEdit = false;
            this.colfecha_escaneo.Visible = true;
            this.colfecha_escaneo.VisibleIndex = 2;
            this.colfecha_escaneo.Width = 147;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage2.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage2.Controls.Add(this.gridNoActivadas);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1284, 597);
            this.xtraTabPage2.Text = "Tarimas NO Activadas";
            // 
            // gridNoActivadas
            // 
            this.gridNoActivadas.DataMember = "loadtml_no_activadas";
            this.gridNoActivadas.DataSource = this.dsPT1;
            this.gridNoActivadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNoActivadas.Location = new System.Drawing.Point(0, 0);
            this.gridNoActivadas.MainView = this.gridView1;
            this.gridNoActivadas.Name = "gridNoActivadas";
            this.gridNoActivadas.Size = new System.Drawing.Size(1284, 597);
            this.gridNoActivadas.TabIndex = 10;
            this.gridNoActivadas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.gridView1.GridControl = this.gridNoActivadas;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn8, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Codigo";
            this.gridColumn2.FieldName = "codigobarra";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Lote";
            this.gridColumn3.FieldName = "lote";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "F. Produccion";
            this.gridColumn4.FieldName = "dateprod";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Turno";
            this.gridColumn5.FieldName = "turno";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Producto";
            this.gridColumn6.FieldName = "producto";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "C. Producto";
            this.gridColumn7.FieldName = "codigop";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Lote";
            this.gridColumn8.FieldName = "loteagrupador";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "F. Vencimiento";
            this.gridColumn9.FieldName = "f_vencimiento";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Unidades";
            this.gridColumn10.FieldName = "cantidad";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "SUM={0:0.##}")});
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 7;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Peso Kg.";
            this.gridColumn11.FieldName = "peso";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "peso", "SUM={0:0.##}")});
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 8;
            // 
            // frmRevisionDeActivaciondeTm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 745);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmdHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRevisionDeActivaciondeTm";
            this.Text = "frmRevisionDeActivaciondeTm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNoActivadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridNoActivadas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private dsPT dsPT1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigobarra;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn coldateprod;
        private DevExpress.XtraGrid.Columns.GridColumn colturno;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigop;
        private DevExpress.XtraGrid.Columns.GridColumn colloteagrupador;
        private DevExpress.XtraGrid.Columns.GridColumn colf_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_escaneo;
    }
}