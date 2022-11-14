
namespace LOSA.MicroIngredientes
{
    partial class xfrmAlimentacionTarimaArriba
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmAlimentacionTarimaArriba));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsMicrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMicros = new LOSA.MicroIngredientes.dsMicros();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_orden_encabezado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_kg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_batch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAMI_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorder_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorder_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_turno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtOrden1 = new System.Windows.Forms.TextBox();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtLotePT1 = new System.Windows.Forms.TextBox();
            this.txtProducto1 = new System.Windows.Forms.TextBox();
            this.txtMix1 = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMix2 = new System.Windows.Forms.TextBox();
            this.txtProducto2 = new System.Windows.Forms.TextBox();
            this.txtLotePT2 = new System.Windows.Forms.TextBox();
            this.txtOrden2 = new System.Windows.Forms.TextBox();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.teCodBarra = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teCodBarra.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "plan_microsh_report_AlimentacionTarima";
            this.gridControl1.DataSource = this.dsMicrosBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1288, 363);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsMicrosBindingSource
            // 
            this.dsMicrosBindingSource.DataSource = this.dsMicros;
            this.dsMicrosBindingSource.Position = 0;
            // 
            // dsMicros
            // 
            this.dsMicros.DataSetName = "dsMicros";
            this.dsMicros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Empty.Options.UseFont = true;
            this.gridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_orden_encabezado,
            this.coltotal_kg,
            this.colfecha,
            this.colcant_batch,
            this.colAMI_ID,
            this.colorder_id,
            this.colorder_code,
            this.colid_turno,
            this.collot,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_orden_encabezado
            // 
            this.colid_orden_encabezado.FieldName = "id_orden_encabezado";
            this.colid_orden_encabezado.Name = "colid_orden_encabezado";
            this.colid_orden_encabezado.Width = 91;
            // 
            // coltotal_kg
            // 
            this.coltotal_kg.Caption = "Total Kg";
            this.coltotal_kg.FieldName = "total_kg";
            this.coltotal_kg.Name = "coltotal_kg";
            this.coltotal_kg.Width = 124;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Width = 128;
            // 
            // colcant_batch
            // 
            this.colcant_batch.Caption = "Cant. Batch Inicial";
            this.colcant_batch.FieldName = "cant_batch";
            this.colcant_batch.Name = "colcant_batch";
            this.colcant_batch.OptionsColumn.AllowEdit = false;
            this.colcant_batch.Visible = true;
            this.colcant_batch.VisibleIndex = 4;
            this.colcant_batch.Width = 185;
            // 
            // colAMI_ID
            // 
            this.colAMI_ID.Caption = "Plan #";
            this.colAMI_ID.FieldName = "AMI_ID";
            this.colAMI_ID.Name = "colAMI_ID";
            this.colAMI_ID.OptionsColumn.AllowEdit = false;
            this.colAMI_ID.Visible = true;
            this.colAMI_ID.VisibleIndex = 0;
            this.colAMI_ID.Width = 116;
            // 
            // colorder_id
            // 
            this.colorder_id.Caption = "Order Id";
            this.colorder_id.FieldName = "order_id";
            this.colorder_id.Name = "colorder_id";
            this.colorder_id.OptionsColumn.AllowEdit = false;
            this.colorder_id.Visible = true;
            this.colorder_id.VisibleIndex = 1;
            this.colorder_id.Width = 120;
            // 
            // colorder_code
            // 
            this.colorder_code.Caption = "Order Code";
            this.colorder_code.FieldName = "order_code";
            this.colorder_code.Name = "colorder_code";
            this.colorder_code.OptionsColumn.AllowEdit = false;
            this.colorder_code.Visible = true;
            this.colorder_code.VisibleIndex = 2;
            this.colorder_code.Width = 173;
            // 
            // colid_turno
            // 
            this.colid_turno.FieldName = "id_turno";
            this.colid_turno.Name = "colid_turno";
            this.colid_turno.Width = 108;
            // 
            // collot
            // 
            this.collot.FieldName = "lot";
            this.collot.Name = "collot";
            this.collot.OptionsColumn.AllowEdit = false;
            this.collot.Visible = true;
            this.collot.VisibleIndex = 3;
            this.collot.Width = 147;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Batch Adicionado";
            this.gridColumn1.FieldName = "acumulado";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 192;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Batch Pendientes";
            this.gridColumn2.FieldName = "batch_pendientes";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            this.gridColumn2.Width = 164;
            // 
            // txtOrden1
            // 
            this.txtOrden1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrden1.Location = new System.Drawing.Point(38, 118);
            this.txtOrden1.Name = "txtOrden1";
            this.txtOrden1.ReadOnly = true;
            this.txtOrden1.Size = new System.Drawing.Size(206, 33);
            this.txtOrden1.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.AppearancePage.Header.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 205);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1294, 399);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1288, 363);
            this.xtraTabPage1.Text = "Resumen Pesajes";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(38, 91);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(206, 21);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "# Orden de Producción";
            // 
            // txtLotePT1
            // 
            this.txtLotePT1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLotePT1.Location = new System.Drawing.Point(328, 118);
            this.txtLotePT1.Name = "txtLotePT1";
            this.txtLotePT1.ReadOnly = true;
            this.txtLotePT1.Size = new System.Drawing.Size(114, 33);
            this.txtLotePT1.TabIndex = 4;
            // 
            // txtProducto1
            // 
            this.txtProducto1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto1.Location = new System.Drawing.Point(526, 118);
            this.txtProducto1.Name = "txtProducto1";
            this.txtProducto1.ReadOnly = true;
            this.txtProducto1.Size = new System.Drawing.Size(532, 33);
            this.txtProducto1.TabIndex = 5;
            // 
            // txtMix1
            // 
            this.txtMix1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMix1.Location = new System.Drawing.Point(1142, 118);
            this.txtMix1.Name = "txtMix1";
            this.txtMix1.ReadOnly = true;
            this.txtMix1.Size = new System.Drawing.Size(119, 33);
            this.txtMix1.TabIndex = 6;
            this.txtMix1.Tag = "1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(526, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(532, 21);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Producto";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(328, 91);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(114, 21);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Lote PT";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(1143, 91);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(119, 21);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "MIX";
            // 
            // txtMix2
            // 
            this.txtMix2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMix2.Location = new System.Drawing.Point(1142, 162);
            this.txtMix2.Name = "txtMix2";
            this.txtMix2.ReadOnly = true;
            this.txtMix2.Size = new System.Drawing.Size(119, 33);
            this.txtMix2.TabIndex = 13;
            this.txtMix2.Tag = "2";
            // 
            // txtProducto2
            // 
            this.txtProducto2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto2.Location = new System.Drawing.Point(526, 162);
            this.txtProducto2.Name = "txtProducto2";
            this.txtProducto2.ReadOnly = true;
            this.txtProducto2.Size = new System.Drawing.Size(532, 33);
            this.txtProducto2.TabIndex = 12;
            // 
            // txtLotePT2
            // 
            this.txtLotePT2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLotePT2.Location = new System.Drawing.Point(328, 162);
            this.txtLotePT2.Name = "txtLotePT2";
            this.txtLotePT2.ReadOnly = true;
            this.txtLotePT2.Size = new System.Drawing.Size(114, 33);
            this.txtLotePT2.TabIndex = 11;
            // 
            // txtOrden2
            // 
            this.txtOrden2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrden2.Location = new System.Drawing.Point(38, 162);
            this.txtOrden2.Name = "txtOrden2";
            this.txtOrden2.ReadOnly = true;
            this.txtOrden2.Size = new System.Drawing.Size(206, 33);
            this.txtOrden2.TabIndex = 2;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAtras.ImageOptions.SvgImage")));
            this.btnAtras.Location = new System.Drawing.Point(1113, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(130, 56);
            this.btnAtras.TabIndex = 96;
            this.btnAtras.Text = "Salir";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(38, 35);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(99, 21);
            this.labelControl5.TabIndex = 98;
            this.labelControl5.Text = "Cod. Barra:";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // teCodBarra
            // 
            this.teCodBarra.Location = new System.Drawing.Point(143, 29);
            this.teCodBarra.Name = "teCodBarra";
            this.teCodBarra.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.teCodBarra.Properties.Appearance.Options.UseFont = true;
            this.teCodBarra.Size = new System.Drawing.Size(332, 32);
            this.teCodBarra.TabIndex = 0;
            this.teCodBarra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.teCodBarra_KeyDown);
            // 
            // xfrmAlimentacionTarimaArriba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 603);
            this.Controls.Add(this.teCodBarra);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtMix2);
            this.Controls.Add(this.txtProducto2);
            this.Controls.Add(this.txtLotePT2);
            this.Controls.Add(this.txtOrden2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMix1);
            this.Controls.Add(this.txtProducto1);
            this.Controls.Add(this.txtLotePT1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.txtOrden1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "xfrmAlimentacionTarimaArriba";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teCodBarra.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txtOrden1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtLotePT1;
        private System.Windows.Forms.TextBox txtProducto1;
        private System.Windows.Forms.TextBox txtMix1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtMix2;
        private System.Windows.Forms.TextBox txtProducto2;
        private System.Windows.Forms.TextBox txtLotePT2;
        private System.Windows.Forms.TextBox txtOrden2;
        private dsMicros dsMicros;
        private DevExpress.XtraGrid.Columns.GridColumn colid_orden_encabezado;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_kg;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_batch;
        private DevExpress.XtraGrid.Columns.GridColumn colAMI_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colorder_id;
        private DevExpress.XtraGrid.Columns.GridColumn colorder_code;
        private DevExpress.XtraGrid.Columns.GridColumn colid_turno;
        private DevExpress.XtraGrid.Columns.GridColumn collot;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource dsMicrosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.TextEdit teCodBarra;
    }
}
