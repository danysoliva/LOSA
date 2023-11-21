
namespace LOSA.RecepcionMP
{
    partial class frm_detalle_granel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_detalle_granel));
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.ingresoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsingresos = new LOSA.RecepcionMP.dsingresos();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colboleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitem_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImprimirLote = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsingresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(643, 9);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(178, 58);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(320, 23);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(272, 44);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "Detalle de ingreso de granel";
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataSource = this.ingresoBindingSource;
            this.grd_data.Location = new System.Drawing.Point(2, 107);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(826, 522);
            this.grd_data.TabIndex = 32;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // ingresoBindingSource
            // 
            this.ingresoBindingSource.DataMember = "ingreso";
            this.ingresoBindingSource.DataSource = this.dsingresos;
            // 
            // dsingresos
            // 
            this.dsingresos.DataSetName = "dsingresos";
            this.dsingresos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_data.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Empty.Options.UseFont = true;
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colingreso,
            this.colboleta,
            this.colEntrada,
            this.collote,
            this.colfecha,
            this.colitem_code,
            this.colitemname});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowFooter = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // colingreso
            // 
            this.colingreso.Caption = "Ingreso";
            this.colingreso.FieldName = "ingreso";
            this.colingreso.Name = "colingreso";
            this.colingreso.OptionsColumn.AllowEdit = false;
            this.colingreso.Visible = true;
            this.colingreso.VisibleIndex = 0;
            // 
            // colboleta
            // 
            this.colboleta.Caption = "Boleta";
            this.colboleta.FieldName = "boleta";
            this.colboleta.Name = "colboleta";
            this.colboleta.OptionsColumn.AllowEdit = false;
            this.colboleta.Visible = true;
            this.colboleta.VisibleIndex = 2;
            // 
            // colEntrada
            // 
            this.colEntrada.Caption = "P. Entrada";
            this.colEntrada.DisplayFormat.FormatString = "d";
            this.colEntrada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEntrada.FieldName = "Entrada";
            this.colEntrada.Name = "colEntrada";
            this.colEntrada.OptionsColumn.AllowEdit = false;
            this.colEntrada.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Entrada", "SUMA={0:d}")});
            this.colEntrada.Visible = true;
            this.colEntrada.VisibleIndex = 6;
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
            // colfecha
            // 
            this.colfecha.Caption = "F. Ingreso";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 1;
            // 
            // colitem_code
            // 
            this.colitem_code.Caption = "Codigo";
            this.colitem_code.FieldName = "item_code";
            this.colitem_code.Name = "colitem_code";
            this.colitem_code.OptionsColumn.AllowEdit = false;
            this.colitem_code.Visible = true;
            this.colitem_code.VisibleIndex = 3;
            // 
            // colitemname
            // 
            this.colitemname.Caption = "MP";
            this.colitemname.FieldName = "itemname";
            this.colitemname.Name = "colitemname";
            this.colitemname.OptionsColumn.AllowEdit = false;
            this.colitemname.Visible = true;
            this.colitemname.VisibleIndex = 4;
            // 
            // btnImprimirLote
            // 
            this.btnImprimirLote.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirLote.Appearance.Options.UseFont = true;
            this.btnImprimirLote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirLote.ImageOptions.Image")));
            this.btnImprimirLote.Location = new System.Drawing.Point(12, 19);
            this.btnImprimirLote.Name = "btnImprimirLote";
            this.btnImprimirLote.Size = new System.Drawing.Size(141, 60);
            this.btnImprimirLote.TabIndex = 33;
            this.btnImprimirLote.Text = "Imprimir\r\nCartilla";
            this.btnImprimirLote.Click += new System.EventHandler(this.btnImprimirLote_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(159, 19);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(141, 60);
            this.simpleButton1.TabIndex = 34;
            this.simpleButton1.Text = "Imprimir\r\nhoja de lote";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frm_detalle_granel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 641);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnImprimirLote);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_detalle_granel";
            this.Text = "frm_detalle_granel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsingresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private System.Windows.Forms.BindingSource ingresoBindingSource;
        private dsingresos dsingresos;
        private DevExpress.XtraGrid.Columns.GridColumn colingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colboleta;
        private DevExpress.XtraGrid.Columns.GridColumn colEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colitem_code;
        private DevExpress.XtraGrid.Columns.GridColumn colitemname;
        private DevExpress.XtraEditors.SimpleButton btnImprimirLote;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}