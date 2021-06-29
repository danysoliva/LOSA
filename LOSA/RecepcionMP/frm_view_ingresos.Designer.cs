
namespace LOSA.RecepcionMP
{
    partial class frm_view_ingresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_view_ingresos));
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsingresos = new LOSA.RecepcionMP.dsingresos();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_boleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_lote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitem_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_ubicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colubicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colingreso2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnactualizar = new DevExpress.XtraEditors.SimpleButton();
            this.dtFechaHasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaDesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btn_excel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsingresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesde.Properties)).BeginInit();
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
            this.cmdHome.Location = new System.Drawing.Point(483, 8);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(147, 54);
            this.cmdHome.TabIndex = 7;
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
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(94, 27);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(372, 39);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Ingreso de MP Granel";
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "granel";
            this.grd_data.DataSource = this.dsingresos;
            this.grd_data.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_data.Location = new System.Drawing.Point(0, 153);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(637, 405);
            this.grd_data.TabIndex = 33;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsingresos
            // 
            this.dsingresos.DataSetName = "dsingresos";
            this.dsingresos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Empty.Options.UseFont = true;
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_boleta,
            this.colentrada,
            this.collote,
            this.colid_lote,
            this.colfecha,
            this.colenable,
            this.colitem_code,
            this.colnombre,
            this.colid_ubicacion,
            this.colubicacion,
            this.colingreso,
            this.collote2,
            this.colingreso2});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.GroupCount = 1;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colingreso2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colid_boleta
            // 
            this.colid_boleta.Caption = "Serie Boleta";
            this.colid_boleta.FieldName = "id_boleta";
            this.colid_boleta.Name = "colid_boleta";
            this.colid_boleta.OptionsColumn.AllowEdit = false;
            this.colid_boleta.Visible = true;
            this.colid_boleta.VisibleIndex = 0;
            // 
            // colentrada
            // 
            this.colentrada.Caption = "Peso Entrada";
            this.colentrada.DisplayFormat.FormatString = "{0:0.##.##} Kg.";
            this.colentrada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colentrada.FieldName = "entrada";
            this.colentrada.Name = "colentrada";
            this.colentrada.OptionsColumn.AllowEdit = false;
            this.colentrada.Visible = true;
            this.colentrada.VisibleIndex = 7;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 3;
            // 
            // colid_lote
            // 
            this.colid_lote.FieldName = "id_lote";
            this.colid_lote.Name = "colid_lote";
            this.colid_lote.OptionsColumn.AllowEdit = false;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "F. Ingreso";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 5;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.AllowEdit = false;
            // 
            // colitem_code
            // 
            this.colitem_code.Caption = "Codigo";
            this.colitem_code.FieldName = "item_code";
            this.colitem_code.Name = "colitem_code";
            this.colitem_code.OptionsColumn.AllowEdit = false;
            this.colitem_code.Visible = true;
            this.colitem_code.VisibleIndex = 1;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "MP";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 2;
            // 
            // colid_ubicacion
            // 
            this.colid_ubicacion.FieldName = "id_ubicacion";
            this.colid_ubicacion.Name = "colid_ubicacion";
            this.colid_ubicacion.OptionsColumn.AllowEdit = false;
            // 
            // colubicacion
            // 
            this.colubicacion.Caption = "Ubicacion";
            this.colubicacion.FieldName = "ubicacion";
            this.colubicacion.Name = "colubicacion";
            this.colubicacion.OptionsColumn.AllowEdit = false;
            this.colubicacion.Visible = true;
            this.colubicacion.VisibleIndex = 6;
            // 
            // colingreso
            // 
            this.colingreso.Caption = "Ingreso";
            this.colingreso.FieldName = "ingreso";
            this.colingreso.Name = "colingreso";
            this.colingreso.OptionsColumn.AllowEdit = false;
            this.colingreso.Visible = true;
            this.colingreso.VisibleIndex = 4;
            // 
            // collote2
            // 
            this.collote2.Caption = "Lote";
            this.collote2.FieldName = "lote2";
            this.collote2.Name = "collote2";
            this.collote2.OptionsColumn.AllowEdit = false;
            // 
            // colingreso2
            // 
            this.colingreso2.Caption = "Ingreso";
            this.colingreso2.FieldName = "ingreso2";
            this.colingreso2.Name = "colingreso2";
            this.colingreso2.OptionsColumn.AllowEdit = false;
            this.colingreso2.Visible = true;
            this.colingreso2.VisibleIndex = 8;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnactualizar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnactualizar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Appearance.Options.UseBackColor = true;
            this.btnactualizar.Appearance.Options.UseFont = true;
            this.btnactualizar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnactualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.ImageOptions.Image")));
            this.btnactualizar.Location = new System.Drawing.Point(479, 89);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(151, 58);
            this.btnactualizar.TabIndex = 34;
            this.btnactualizar.Text = "Actualizar";
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.EditValue = null;
            this.dtFechaHasta.Location = new System.Drawing.Point(110, 114);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaHasta.Properties.Appearance.Options.UseFont = true;
            this.dtFechaHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHasta.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaHasta.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaHasta.Size = new System.Drawing.Size(142, 26);
            this.dtFechaHasta.TabIndex = 57;
            this.dtFechaHasta.EditValueChanged += new System.EventHandler(this.dtFechaHasta_EditValueChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(4, 117);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(86, 21);
            this.labelControl9.TabIndex = 59;
            this.labelControl9.Text = "Fecha Hasta:";
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.EditValue = null;
            this.dtFechaDesde.Location = new System.Drawing.Point(110, 86);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaDesde.Properties.Appearance.Options.UseFont = true;
            this.dtFechaDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesde.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaDesde.Properties.MinValue = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtFechaDesde.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaDesde.Size = new System.Drawing.Size(142, 26);
            this.dtFechaDesde.TabIndex = 56;
            this.dtFechaDesde.EditValueChanged += new System.EventHandler(this.dtFechaDesde_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(4, 89);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(90, 21);
            this.labelControl8.TabIndex = 58;
            this.labelControl8.Text = "Fecha Desde:";
            // 
            // btn_excel
            // 
            this.btn_excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excel.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_excel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excel.Appearance.Options.UseBackColor = true;
            this.btn_excel.Appearance.Options.UseFont = true;
            this.btn_excel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_excel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_excel.ImageOptions.Image")));
            this.btn_excel.Location = new System.Drawing.Point(322, 89);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(151, 58);
            this.btn_excel.TabIndex = 60;
            this.btn_excel.Text = "Exportar";
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // frm_view_ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.dtFechaHasta);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.dtFechaDesde);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_view_ingresos";
            this.Text = "frm_view_ingresos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsingresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesde.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraEditors.SimpleButton btnactualizar;
        private dsingresos dsingresos;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_boleta;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colid_lote;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colitem_code;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colid_ubicacion;
        private DevExpress.XtraGrid.Columns.GridColumn colubicacion;
        private DevExpress.XtraGrid.Columns.GridColumn colingreso;
        private DevExpress.XtraEditors.DateEdit dtFechaHasta;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.DateEdit dtFechaDesde;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btn_excel;
        private DevExpress.XtraGrid.Columns.GridColumn collote2;
        private DevExpress.XtraGrid.Columns.GridColumn colingreso2;
    }
}