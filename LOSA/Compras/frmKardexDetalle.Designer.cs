
namespace LOSA.Compras
{
    partial class frmKardexDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKardexDetalle));
            this.txtCapitulo = new System.Windows.Forms.TextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtPartidaArancelaria = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsCompras1 = new LOSA.Compras.dsCompras();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_orden_h = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWhsCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbase_ref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_linea_solicitud_d = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnite_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCapitulo
            // 
            this.txtCapitulo.BackColor = System.Drawing.Color.White;
            this.txtCapitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCapitulo.Enabled = false;
            this.txtCapitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCapitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtCapitulo.Location = new System.Drawing.Point(206, 13);
            this.txtCapitulo.Name = "txtCapitulo";
            this.txtCapitulo.Size = new System.Drawing.Size(231, 16);
            this.txtCapitulo.TabIndex = 80;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(69, 13);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(141, 16);
            this.labelControl12.TabIndex = 79;
            this.labelControl12.Text = "Capitulo___________";
            // 
            // txtPartidaArancelaria
            // 
            this.txtPartidaArancelaria.BackColor = System.Drawing.Color.White;
            this.txtPartidaArancelaria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPartidaArancelaria.Enabled = false;
            this.txtPartidaArancelaria.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPartidaArancelaria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtPartidaArancelaria.Location = new System.Drawing.Point(206, 46);
            this.txtPartidaArancelaria.Name = "txtPartidaArancelaria";
            this.txtPartidaArancelaria.Size = new System.Drawing.Size(231, 16);
            this.txtPartidaArancelaria.TabIndex = 82;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(69, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(215, 16);
            this.labelControl1.TabIndex = 81;
            this.labelControl1.Text = "Partida Arancelaria___________";
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.ImageOptions.Image")));
            this.cmdClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdClose.Location = new System.Drawing.Point(1189, 12);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(47, 33);
            this.cmdClose.TabIndex = 83;
            this.cmdClose.ToolTip = "Cerrar Ventana";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "kardex_detalle";
            this.gridControl1.DataSource = this.dsCompras1;
            this.gridControl1.Location = new System.Drawing.Point(3, 94);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1264, 698);
            this.gridControl1.TabIndex = 84;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsCompras1
            // 
            this.dsCompras1.DataSetName = "dsCompras";
            this.dsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_orden_h,
            this.colDocNum,
            this.colItemCode,
            this.colDescription,
            this.colDocDate,
            this.colCurrency,
            this.colWhsCode,
            this.colbase_ref,
            this.colnum_linea_solicitud_d,
            this.colQuantity,
            this.colUnite_Price,
            this.coltotal,
            this.colestado});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_orden_h
            // 
            this.colid_orden_h.FieldName = "id_orden_h";
            this.colid_orden_h.Name = "colid_orden_h";
            this.colid_orden_h.OptionsColumn.ReadOnly = true;
            // 
            // colDocNum
            // 
            this.colDocNum.Caption = "# OC SAP";
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.ReadOnly = true;
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 0;
            this.colDocNum.Width = 70;
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.ReadOnly = true;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 2;
            this.colItemCode.Width = 105;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Descripcion";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.ReadOnly = true;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 169;
            // 
            // colDocDate
            // 
            this.colDocDate.Caption = "Fecha ";
            this.colDocDate.FieldName = "DocDate";
            this.colDocDate.Name = "colDocDate";
            this.colDocDate.OptionsColumn.ReadOnly = true;
            this.colDocDate.Visible = true;
            this.colDocDate.VisibleIndex = 4;
            this.colDocDate.Width = 101;
            // 
            // colCurrency
            // 
            this.colCurrency.Caption = "Moneda";
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.OptionsColumn.ReadOnly = true;
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 8;
            this.colCurrency.Width = 92;
            // 
            // colWhsCode
            // 
            this.colWhsCode.FieldName = "WhsCode";
            this.colWhsCode.Name = "colWhsCode";
            this.colWhsCode.OptionsColumn.ReadOnly = true;
            this.colWhsCode.Visible = true;
            this.colWhsCode.VisibleIndex = 5;
            this.colWhsCode.Width = 101;
            // 
            // colbase_ref
            // 
            this.colbase_ref.Caption = "Solicitud de Compra";
            this.colbase_ref.FieldName = "base_ref";
            this.colbase_ref.Name = "colbase_ref";
            this.colbase_ref.OptionsColumn.ReadOnly = true;
            this.colbase_ref.Visible = true;
            this.colbase_ref.VisibleIndex = 6;
            this.colbase_ref.Width = 116;
            // 
            // colnum_linea_solicitud_d
            // 
            this.colnum_linea_solicitud_d.FieldName = "num_linea_solicitud_d";
            this.colnum_linea_solicitud_d.Name = "colnum_linea_solicitud_d";
            this.colnum_linea_solicitud_d.OptionsColumn.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Canitdad";
            this.colQuantity.DisplayFormat.FormatString = "{0:#,###,##0.00} Ud";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.ReadOnly = true;
            this.colQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:#,###,##0.00} Ud")});
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 7;
            this.colQuantity.Width = 85;
            // 
            // colUnite_Price
            // 
            this.colUnite_Price.Caption = "Precio Unitario";
            this.colUnite_Price.DisplayFormat.FormatString = "{0:#,###,##0.00} Lps";
            this.colUnite_Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnite_Price.FieldName = "Unite_Price";
            this.colUnite_Price.Name = "colUnite_Price";
            this.colUnite_Price.OptionsColumn.ReadOnly = true;
            this.colUnite_Price.Visible = true;
            this.colUnite_Price.VisibleIndex = 9;
            this.colUnite_Price.Width = 153;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.DisplayFormat.FormatString = "{0:#,###,##0.00} Lps";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.ReadOnly = true;
            this.coltotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", "{0:#,###,##0.00} Lps")});
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 10;
            this.coltotal.Width = 111;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.ReadOnly = true;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 1;
            this.colestado.Width = 136;
            // 
            // frmKardexDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 794);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.txtPartidaArancelaria);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCapitulo);
            this.Controls.Add(this.labelControl12);
            this.Name = "frmKardexDetalle";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCapitulo;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.TextBox txtPartidaArancelaria;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsCompras dsCompras1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_orden_h;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colWhsCode;
        private DevExpress.XtraGrid.Columns.GridColumn colbase_ref;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_linea_solicitud_d;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnite_Price;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
    }
}