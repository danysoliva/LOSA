
namespace LOSA.Compras
{
    partial class frmCopiarDeSolicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCopiarDeSolicitud));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaDesdeDisponibles = new DevExpress.XtraEditors.DateEdit();
            this.dtFechaHastaDisponibles = new DevExpress.XtraEditors.DateEdit();
            this.cmdRefreshDisponibles = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dsCompras1 = new LOSA.Compras.dsCompras();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_contabilizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsolicitantes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Desde:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(171, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Hasta:";
            // 
            // dtFechaDesdeDisponibles
            // 
            this.dtFechaDesdeDisponibles.EditValue = null;
            this.dtFechaDesdeDisponibles.Location = new System.Drawing.Point(65, 13);
            this.dtFechaDesdeDisponibles.Name = "dtFechaDesdeDisponibles";
            this.dtFechaDesdeDisponibles.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dtFechaDesdeDisponibles.Properties.Appearance.Options.UseFont = true;
            this.dtFechaDesdeDisponibles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesdeDisponibles.Size = new System.Drawing.Size(100, 22);
            this.dtFechaDesdeDisponibles.TabIndex = 2;
            // 
            // dtFechaHastaDisponibles
            // 
            this.dtFechaHastaDisponibles.EditValue = null;
            this.dtFechaHastaDisponibles.Location = new System.Drawing.Point(214, 13);
            this.dtFechaHastaDisponibles.Name = "dtFechaHastaDisponibles";
            this.dtFechaHastaDisponibles.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dtFechaHastaDisponibles.Properties.Appearance.Options.UseFont = true;
            this.dtFechaHastaDisponibles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHastaDisponibles.Size = new System.Drawing.Size(100, 22);
            this.dtFechaHastaDisponibles.TabIndex = 3;
            // 
            // cmdRefreshDisponibles
            // 
            this.cmdRefreshDisponibles.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.cmdRefreshDisponibles.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRefreshDisponibles.Appearance.Options.UseBackColor = true;
            this.cmdRefreshDisponibles.Appearance.Options.UseFont = true;
            this.cmdRefreshDisponibles.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRefreshDisponibles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRefreshDisponibles.ImageOptions.Image")));
            this.cmdRefreshDisponibles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdRefreshDisponibles.Location = new System.Drawing.Point(334, 0);
            this.cmdRefreshDisponibles.Name = "cmdRefreshDisponibles";
            this.cmdRefreshDisponibles.Size = new System.Drawing.Size(117, 41);
            this.cmdRefreshDisponibles.TabIndex = 102;
            this.cmdRefreshDisponibles.Text = "Refresh";
            this.cmdRefreshDisponibles.Click += new System.EventHandler(this.cmdRefreshDisponibles_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "solicitudes_compra";
            this.gridControl1.DataSource = this.dsCompras1;
            this.gridControl1.Location = new System.Drawing.Point(3, 47);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(699, 298);
            this.gridControl1.TabIndex = 103;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDocNum,
            this.colfecha_contabilizacion,
            this.colsolicitantes,
            this.colcomentarios,
            this.colfecha_vencimiento});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // dsCompras1
            // 
            this.dsCompras1.DataSetName = "dsCompras";
            this.dsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colDocNum
            // 
            this.colDocNum.Caption = "Num. Solicitud";
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.AllowEdit = false;
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 0;
            // 
            // colfecha_contabilizacion
            // 
            this.colfecha_contabilizacion.Caption = "Fecha Contabilizacion";
            this.colfecha_contabilizacion.FieldName = "fecha_contabilizacion";
            this.colfecha_contabilizacion.Name = "colfecha_contabilizacion";
            this.colfecha_contabilizacion.OptionsColumn.AllowEdit = false;
            this.colfecha_contabilizacion.Visible = true;
            this.colfecha_contabilizacion.VisibleIndex = 1;
            // 
            // colsolicitantes
            // 
            this.colsolicitantes.Caption = "Solicitante";
            this.colsolicitantes.FieldName = "solicitantes";
            this.colsolicitantes.Name = "colsolicitantes";
            this.colsolicitantes.OptionsColumn.AllowEdit = false;
            this.colsolicitantes.Visible = true;
            this.colsolicitantes.VisibleIndex = 2;
            // 
            // colcomentarios
            // 
            this.colcomentarios.Caption = "Comentarios";
            this.colcomentarios.FieldName = "comentarios";
            this.colcomentarios.Name = "colcomentarios";
            this.colcomentarios.OptionsColumn.AllowEdit = false;
            this.colcomentarios.Visible = true;
            this.colcomentarios.VisibleIndex = 3;
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.Caption = "Fecha Vencimiento";
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.OptionsColumn.AllowEdit = false;
            this.colfecha_vencimiento.Visible = true;
            this.colfecha_vencimiento.VisibleIndex = 4;
            // 
            // frmCopiarDeSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 350);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmdRefreshDisponibles);
            this.Controls.Add(this.dtFechaHastaDisponibles);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtFechaDesdeDisponibles);
            this.Name = "frmCopiarDeSolicitud";
            this.Text = "Seleccione la Solicitud de Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtFechaDesdeDisponibles;
        private DevExpress.XtraEditors.DateEdit dtFechaHastaDisponibles;
        private DevExpress.XtraEditors.SimpleButton cmdRefreshDisponibles;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsCompras dsCompras1;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_contabilizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colsolicitantes;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentarios;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
    }
}