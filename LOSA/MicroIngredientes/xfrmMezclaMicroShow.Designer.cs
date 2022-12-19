
namespace LOSA.MicroIngredientes
{
    partial class xfrmMezclaMicroShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmMezclaMicroShow));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsReportesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReportes = new LOSA.Reportes.dsReportes();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkg_por_batch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "detalle_rpt_microsIndividual";
            this.gridControl1.DataSource = this.dsReportesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 96);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(875, 204);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsReportesBindingSource
            // 
            this.dsReportesBindingSource.DataSource = this.dsReportes;
            this.dsReportesBindingSource.Position = 0;
            // 
            // dsReportes
            // 
            this.dsReportes.DataSetName = "dsReportes";
            this.dsReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_orden,
            this.colidmp,
            this.colenable,
            this.colkg_por_batch,
            this.colItemCode,
            this.colItemName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Appearance.Options.UseBackColor = true;
            this.btnSalir.Appearance.Options.UseFont = true;
            this.btnSalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSalir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSalir.ImageOptions.SvgImage")));
            this.btnSalir.Location = new System.Drawing.Point(732, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(131, 37);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(0, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(875, 25);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mezcla de Micro Ingredientes";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colid_orden
            // 
            this.colid_orden.FieldName = "id_orden";
            this.colid_orden.Name = "colid_orden";
            this.colid_orden.OptionsColumn.AllowEdit = false;
            this.colid_orden.Visible = true;
            this.colid_orden.VisibleIndex = 0;
            this.colid_orden.Width = 129;
            // 
            // colidmp
            // 
            this.colidmp.FieldName = "idmp";
            this.colidmp.Name = "colidmp";
            this.colidmp.OptionsColumn.AllowEdit = false;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.AllowEdit = false;
            // 
            // colkg_por_batch
            // 
            this.colkg_por_batch.FieldName = "kg_por_batch";
            this.colkg_por_batch.Name = "colkg_por_batch";
            this.colkg_por_batch.OptionsColumn.AllowEdit = false;
            this.colkg_por_batch.Visible = true;
            this.colkg_por_batch.VisibleIndex = 3;
            this.colkg_por_batch.Width = 421;
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.AllowEdit = false;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 1;
            this.colItemCode.Width = 154;
            // 
            // colItemName
            // 
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.AllowEdit = false;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 2;
            this.colItemName.Width = 413;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(131, 37);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Continuar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // xfrmMezclaMicroShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 300);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfrmMezclaMicroShow";
            this.Text = "Mezcla de Micro Ingrediente";
            this.Load += new System.EventHandler(this.xfrmMezclaMicroShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dsReportesBindingSource;
        private LOSA.Reportes.dsReportes dsReportes;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_orden;
        private DevExpress.XtraGrid.Columns.GridColumn colidmp;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colkg_por_batch;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}