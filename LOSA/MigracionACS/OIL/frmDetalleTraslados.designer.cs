namespace LOSA.MigracionACS.OIL
{
    partial class frmDetalleTraslados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleTraslados));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsAceites1 = new MigracionACS.OIL.dsAceites();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmdExportar = new DevExpress.XtraEditors.SimpleButton();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_rw = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAceites1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "reporte_d";
            this.gridControl1.DataSource = this.dsAceites1;
            this.gridControl1.Location = new System.Drawing.Point(-1, 58);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(747, 346);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // dsAceites1
            // 
            this.dsAceites1.DataSetName = "dsAceites";
            this.dsAceites1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_rw,
            this.colfecha,
            this.colcantidad,
            this.coluser});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // cmdExportar
            // 
            this.cmdExportar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportar.Appearance.Options.UseFont = true;
            this.cmdExportar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdExportar.ImageOptions.Image")));
            this.cmdExportar.Location = new System.Drawing.Point(618, 12);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(116, 39);
            this.cmdExportar.TabIndex = 7;
            this.cmdExportar.Text = "Exportar";
            this.cmdExportar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_rw
            // 
            this.colid_rw.Caption = "Materia Prima";
            this.colid_rw.FieldName = "id_rw";
            this.colid_rw.Name = "colid_rw";
            this.colid_rw.OptionsColumn.AllowEdit = false;
            this.colid_rw.Visible = true;
            this.colid_rw.VisibleIndex = 0;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 1;
            // 
            // colcantidad
            // 
            this.colcantidad.AppearanceCell.Options.UseTextOptions = true;
            this.colcantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.DisplayFormat.FormatString = "###,##0.00";
            this.colcantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 2;
            // 
            // coluser
            // 
            this.coluser.Caption = "Usuario";
            this.coluser.FieldName = "user";
            this.coluser.Name = "coluser";
            this.coluser.OptionsColumn.AllowEdit = false;
            this.coluser.Visible = true;
            this.coluser.VisibleIndex = 3;
            // 
            // frmDetalleTraslados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 405);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDetalleTraslados";
            this.Text = "Detalle Traslados";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAceites1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton cmdExportar;
        private dsAceites dsAceites1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_rw;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn coluser;
    }
}