
namespace LOSA.TransaccionesMP
{
    partial class frmEntregaTarimaMicros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntregaTarimaMicros));
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.panelNotificacion = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.grd_data_entregadaMicros = new DevExpress.XtraGrid.GridControl();
            this.dsMicro1 = new LOSA.Micro.dsMicro();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colexistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_produccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_transaccion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcproveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalidas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dsTransaccionesMP = new LOSA.TransaccionesMP.dsTransaccionesMP();
            this.txtTarima = new DevExpress.XtraEditors.ButtonEdit();
            this.cmdSelectTarima = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.timerLimpiarMensaje = new System.Windows.Forms.Timer();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.grid_mp_disponible_prd = new DevExpress.XtraGrid.GridControl();
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
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdLotesProximosVencerMP = new DevExpress.XtraEditors.SimpleButton();
            this.dsMicro2 = new LOSA.Micro.dsMicro();
            this.panelNotificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data_entregadaMicros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_mp_disponible_prd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicro2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(488, 2);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(175, 48);
            this.cmdHome.TabIndex = 7;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // panelNotificacion
            // 
            this.panelNotificacion.BackColor = System.Drawing.Color.White;
            this.panelNotificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNotificacion.Controls.Add(this.lblMensaje);
            this.panelNotificacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNotificacion.Location = new System.Drawing.Point(0, 686);
            this.panelNotificacion.Name = "panelNotificacion";
            this.panelNotificacion.Size = new System.Drawing.Size(673, 71);
            this.panelNotificacion.TabIndex = 104;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(3, 5);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(665, 59);
            this.lblMensaje.TabIndex = 0;
            // 
            // grd_data_entregadaMicros
            // 
            this.grd_data_entregadaMicros.DataMember = "informacionPRD_micro";
            this.grd_data_entregadaMicros.DataSource = this.dsMicro1;
            this.grd_data_entregadaMicros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_data_entregadaMicros.Location = new System.Drawing.Point(0, 0);
            this.grd_data_entregadaMicros.MainView = this.grdv_data;
            this.grd_data_entregadaMicros.Name = "grd_data_entregadaMicros";
            this.grd_data_entregadaMicros.Size = new System.Drawing.Size(652, 534);
            this.grd_data_entregadaMicros.TabIndex = 105;
            this.grd_data_entregadaMicros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsMicro1
            // 
            this.dsMicro1.DataSetName = "dsMicro";
            this.dsMicro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colexistencia,
            this.colnombre_comercial,
            this.colfecha_vence,
            this.colfecha_produccion,
            this.colid_mp,
            this.collote,
            this.coldias,
            this.colfecha_ingreso1,
            this.colnumero_transaccion1,
            this.colcproveedor,
            this.colproveedor,
            this.colcode_sap1,
            this.colcodigo,
            this.colingreso,
            this.colsalidas});
            this.grdv_data.GridControl = this.grd_data_entregadaMicros;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowFooter = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // colexistencia
            // 
            this.colexistencia.Caption = "Existencia";
            this.colexistencia.FieldName = "existencia";
            this.colexistencia.Name = "colexistencia";
            this.colexistencia.Visible = true;
            this.colexistencia.VisibleIndex = 6;
            this.colexistencia.Width = 101;
            // 
            // colnombre_comercial
            // 
            this.colnombre_comercial.FieldName = "nombre_comercial";
            this.colnombre_comercial.Name = "colnombre_comercial";
            this.colnombre_comercial.Visible = true;
            this.colnombre_comercial.VisibleIndex = 1;
            this.colnombre_comercial.Width = 90;
            // 
            // colfecha_vence
            // 
            this.colfecha_vence.FieldName = "fecha_vence";
            this.colfecha_vence.Name = "colfecha_vence";
            this.colfecha_vence.Visible = true;
            this.colfecha_vence.VisibleIndex = 2;
            this.colfecha_vence.Width = 90;
            // 
            // colfecha_produccion
            // 
            this.colfecha_produccion.FieldName = "fecha_produccion";
            this.colfecha_produccion.Name = "colfecha_produccion";
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.Name = "colid_mp";
            // 
            // collote
            // 
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.Visible = true;
            this.collote.VisibleIndex = 3;
            this.collote.Width = 90;
            // 
            // coldias
            // 
            this.coldias.FieldName = "dias";
            this.coldias.Name = "coldias";
            // 
            // colfecha_ingreso1
            // 
            this.colfecha_ingreso1.FieldName = "fecha_ingreso";
            this.colfecha_ingreso1.Name = "colfecha_ingreso1";
            // 
            // colnumero_transaccion1
            // 
            this.colnumero_transaccion1.FieldName = "numero_transaccion";
            this.colnumero_transaccion1.Name = "colnumero_transaccion1";
            // 
            // colcproveedor
            // 
            this.colcproveedor.FieldName = "cproveedor";
            this.colcproveedor.Name = "colcproveedor";
            // 
            // colproveedor
            // 
            this.colproveedor.FieldName = "proveedor";
            this.colproveedor.Name = "colproveedor";
            // 
            // colcode_sap1
            // 
            this.colcode_sap1.FieldName = "code_sap";
            this.colcode_sap1.Name = "colcode_sap1";
            this.colcode_sap1.Visible = true;
            this.colcode_sap1.VisibleIndex = 0;
            this.colcode_sap1.Width = 83;
            // 
            // colcodigo
            // 
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            // 
            // colingreso
            // 
            this.colingreso.FieldName = "ingreso";
            this.colingreso.Name = "colingreso";
            this.colingreso.Visible = true;
            this.colingreso.VisibleIndex = 4;
            this.colingreso.Width = 90;
            // 
            // colsalidas
            // 
            this.colsalidas.FieldName = "salidas";
            this.colsalidas.Name = "colsalidas";
            this.colsalidas.Visible = true;
            this.colsalidas.VisibleIndex = 5;
            this.colsalidas.Width = 90;
            // 
            // dsTransaccionesMP
            // 
            this.dsTransaccionesMP.DataSetName = "dsTransaccionesMP";
            this.dsTransaccionesMP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTarima
            // 
            this.txtTarima.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.txtTarima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTarima.EditValue = "";
            this.txtTarima.Location = new System.Drawing.Point(133, 56);
            this.txtTarima.Name = "txtTarima";
            this.txtTarima.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarima.Properties.Appearance.Options.UseFont = true;
            this.txtTarima.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.txtTarima.Properties.MaxLength = 20;
            this.txtTarima.Properties.NullText = "Escanee o selecciona una tarima";
            this.txtTarima.Size = new System.Drawing.Size(268, 44);
            this.txtTarima.TabIndex = 107;
            this.txtTarima.ToolTip = "Hola";
            this.txtTarima.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTarima_KeyDown);
            // 
            // cmdSelectTarima
            // 
            this.cmdSelectTarima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSelectTarima.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelectTarima.Appearance.Options.UseFont = true;
            this.cmdSelectTarima.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSelectTarima.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.cmdSelectTarima.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdSelectTarima.Location = new System.Drawing.Point(407, 56);
            this.cmdSelectTarima.Name = "cmdSelectTarima";
            this.cmdSelectTarima.Size = new System.Drawing.Size(62, 44);
            this.cmdSelectTarima.TabIndex = 108;
            this.cmdSelectTarima.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 37);
            this.labelControl2.TabIndex = 109;
            this.labelControl2.Text = "Tarima:";
            // 
            // timerLimpiarMensaje
            // 
            this.timerLimpiarMensaje.Interval = 5500;
            this.timerLimpiarMensaje.Tick += new System.EventHandler(this.timerLimpiarMensaje_Tick);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.AppearancePage.Header.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(8, 106);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(658, 574);
            this.xtraTabControl1.TabIndex = 112;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.grd_data_entregadaMicros);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(652, 534);
            this.xtraTabPage1.Text = "MP Entregada Micros";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.grid_mp_disponible_prd);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(652, 306);
            this.xtraTabPage2.Text = "MP Disponible PRD";
            // 
            // grid_mp_disponible_prd
            // 
            this.grid_mp_disponible_prd.DataMember = "informacionPRD_micro_tentative";
            this.grid_mp_disponible_prd.DataSource = this.dsMicro1;
            this.grid_mp_disponible_prd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_mp_disponible_prd.Location = new System.Drawing.Point(0, 0);
            this.grid_mp_disponible_prd.MainView = this.gridView1;
            this.grid_mp_disponible_prd.Name = "grid_mp_disponible_prd";
            this.grid_mp_disponible_prd.Size = new System.Drawing.Size(652, 306);
            this.grid_mp_disponible_prd.TabIndex = 106;
            this.grid_mp_disponible_prd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
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
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15});
            this.gridView1.GridControl = this.grid_mp_disponible_prd;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Existencia";
            this.gridColumn1.FieldName = "existencia";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 101;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "nombre_comercial";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 90;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "fecha_vence";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 90;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "fecha_produccion";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "id_mp";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "lote";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 90;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "dias";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "fecha_ingreso";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "numero_transaccion";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "cproveedor";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "proveedor";
            this.gridColumn11.Name = "gridColumn11";
            // 
            // gridColumn12
            // 
            this.gridColumn12.FieldName = "code_sap";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            this.gridColumn12.Width = 83;
            // 
            // gridColumn13
            // 
            this.gridColumn13.FieldName = "codigo";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // gridColumn14
            // 
            this.gridColumn14.FieldName = "ingreso";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 4;
            this.gridColumn14.Width = 90;
            // 
            // gridColumn15
            // 
            this.gridColumn15.FieldName = "salidas";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 5;
            this.gridColumn15.Width = 90;
            // 
            // cmdLotesProximosVencerMP
            // 
            this.cmdLotesProximosVencerMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdLotesProximosVencerMP.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLotesProximosVencerMP.Appearance.Options.UseFont = true;
            this.cmdLotesProximosVencerMP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdLotesProximosVencerMP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdLotesProximosVencerMP.ImageOptions.SvgImage")));
            this.cmdLotesProximosVencerMP.Location = new System.Drawing.Point(475, 56);
            this.cmdLotesProximosVencerMP.Name = "cmdLotesProximosVencerMP";
            this.cmdLotesProximosVencerMP.Size = new System.Drawing.Size(188, 44);
            this.cmdLotesProximosVencerMP.TabIndex = 113;
            this.cmdLotesProximosVencerMP.Text = "Orden Lotes MP \r\nUltima Tarima Escaneada";
            this.cmdLotesProximosVencerMP.Visible = false;
            this.cmdLotesProximosVencerMP.Click += new System.EventHandler(this.cmdLotesProximosVencerMP_Click);
            // 
            // dsMicro2
            // 
            this.dsMicro2.DataSetName = "dsMicro";
            this.dsMicro2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmEntregaTarimaMicros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 757);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.cmdLotesProximosVencerMP);
            this.Controls.Add(this.txtTarima);
            this.Controls.Add(this.cmdSelectTarima);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelNotificacion);
            this.Controls.Add(this.cmdHome);
            this.Name = "frmEntregaTarimaMicros";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmEntregaTarimaMicros_Activated);
            this.Load += new System.EventHandler(this.frmEntregaTarimaMicros_Load);
            this.panelNotificacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_data_entregadaMicros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_mp_disponible_prd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicro2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private System.Windows.Forms.Panel panelNotificacion;
        private System.Windows.Forms.Label lblMensaje;
        private DevExpress.XtraGrid.GridControl grd_data_entregadaMicros;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraEditors.ButtonEdit txtTarima;
        private DevExpress.XtraEditors.SimpleButton cmdSelectTarima;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Timer timerLimpiarMensaje;
        private dsTransaccionesMP dsTransaccionesMP;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton cmdLotesProximosVencerMP;
        private Micro.dsMicro dsMicro1;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vence;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_produccion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn coldias;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso1;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_transaccion1;
        private DevExpress.XtraGrid.Columns.GridColumn colcproveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colproveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap1;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colsalidas;
        private DevExpress.XtraGrid.GridControl grid_mp_disponible_prd;
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private Micro.dsMicro dsMicro2;
    }
}