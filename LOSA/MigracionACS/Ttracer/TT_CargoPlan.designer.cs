namespace LOSA.MigracionACS.Ttracer
{
    partial class TT_CargoPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TT_CargoPlan));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnmin = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.grd_shiph = new DevExpress.XtraGrid.GridControl();
            this.dSTtracer = new MigracionACS.Ttracer.dSTtracer();
            this.grdv_shiph = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigodePlan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHabilitado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechadeinicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechafinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombredebarcoasignado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigodelBarco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPesoplanificado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigodeEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_shiph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_shiph)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnmin);
            this.panelControl1.Controls.Add(this.btnclose);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1257, 47);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl1_MouseDown);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.Image = ((System.Drawing.Image)(resources.GetObject("btnmin.Image")));
            this.btnmin.Location = new System.Drawing.Point(1166, 3);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(44, 40);
            this.btnmin.TabIndex = 2;
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(1210, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(44, 40);
            this.btnclose.TabIndex = 0;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(52, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(286, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Selecciona un plan para cargar..";
            this.labelControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.labelControl1_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LOSA.Properties.Resources.LogoLimp_x32;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.grd_shiph);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 47);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1257, 403);
            this.panelControl2.TabIndex = 1;
            // 
            // grd_shiph
            // 
            this.grd_shiph.DataMember = "shiphload";
            this.grd_shiph.DataSource = this.dSTtracer;
            this.grd_shiph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_shiph.Location = new System.Drawing.Point(2, 2);
            this.grd_shiph.MainView = this.grdv_shiph;
            this.grd_shiph.Name = "grd_shiph";
            this.grd_shiph.Size = new System.Drawing.Size(1253, 399);
            this.grd_shiph.TabIndex = 0;
            this.grd_shiph.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_shiph});
            // 
            // dSTtracer
            // 
            this.dSTtracer.DataSetName = "dSTtracer";
            this.dSTtracer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_shiph
            // 
            this.grdv_shiph.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCodigodePlan,
            this.colHabilitado,
            this.colFechadeinicio,
            this.colFechafinal,
            this.colNombredebarcoasignado,
            this.colCodigodelBarco,
            this.colPesoplanificado,
            this.colEstado,
            this.colCodigodeEstado});
            this.grdv_shiph.GridControl = this.grd_shiph;
            this.grdv_shiph.GroupCount = 1;
            this.grdv_shiph.Name = "grdv_shiph";
            this.grdv_shiph.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_shiph.OptionsBehavior.Editable = false;
            this.grdv_shiph.OptionsView.ShowGroupPanel = false;
            this.grdv_shiph.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEstado, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grdv_shiph.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.grdv_shiph.DoubleClick += new System.EventHandler(this.grdv_shiph_DoubleClick);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 86;
            // 
            // colCodigodePlan
            // 
            this.colCodigodePlan.FieldName = "Codigo de Plan";
            this.colCodigodePlan.Name = "colCodigodePlan";
            this.colCodigodePlan.Visible = true;
            this.colCodigodePlan.VisibleIndex = 1;
            this.colCodigodePlan.Width = 83;
            // 
            // colHabilitado
            // 
            this.colHabilitado.FieldName = "Habilitado";
            this.colHabilitado.Name = "colHabilitado";
            this.colHabilitado.Visible = true;
            this.colHabilitado.VisibleIndex = 4;
            this.colHabilitado.Width = 83;
            // 
            // colFechadeinicio
            // 
            this.colFechadeinicio.FieldName = "Fecha de inicio";
            this.colFechadeinicio.Name = "colFechadeinicio";
            this.colFechadeinicio.Visible = true;
            this.colFechadeinicio.VisibleIndex = 5;
            this.colFechadeinicio.Width = 83;
            // 
            // colFechafinal
            // 
            this.colFechafinal.FieldName = "Fecha final";
            this.colFechafinal.Name = "colFechafinal";
            this.colFechafinal.Visible = true;
            this.colFechafinal.VisibleIndex = 6;
            this.colFechafinal.Width = 83;
            // 
            // colNombredebarcoasignado
            // 
            this.colNombredebarcoasignado.FieldName = "Nombre de barco asignado";
            this.colNombredebarcoasignado.Name = "colNombredebarcoasignado";
            this.colNombredebarcoasignado.Visible = true;
            this.colNombredebarcoasignado.VisibleIndex = 3;
            this.colNombredebarcoasignado.Width = 102;
            // 
            // colCodigodelBarco
            // 
            this.colCodigodelBarco.FieldName = "Codigo del Barco";
            this.colCodigodelBarco.Name = "colCodigodelBarco";
            this.colCodigodelBarco.Visible = true;
            this.colCodigodelBarco.VisibleIndex = 2;
            this.colCodigodelBarco.Width = 83;
            // 
            // colPesoplanificado
            // 
            this.colPesoplanificado.FieldName = "Peso planificado";
            this.colPesoplanificado.Name = "colPesoplanificado";
            this.colPesoplanificado.Visible = true;
            this.colPesoplanificado.VisibleIndex = 7;
            this.colPesoplanificado.Width = 83;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 8;
            // 
            // colCodigodeEstado
            // 
            this.colCodigodeEstado.FieldName = "Codigo de Estado";
            this.colCodigodeEstado.Name = "colCodigodeEstado";
            this.colCodigodeEstado.Visible = true;
            this.colCodigodeEstado.VisibleIndex = 8;
            this.colCodigodeEstado.Width = 90;
            // 
            // TT_CargoPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TT_CargoPlan";
            this.Text = "TT_CargoPlan";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_shiph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_shiph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btnclose;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grd_shiph;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_shiph;
        private dSTtracer dSTtracer;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigodePlan;
        private DevExpress.XtraGrid.Columns.GridColumn colHabilitado;
        private DevExpress.XtraGrid.Columns.GridColumn colFechadeinicio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechafinal;
        private DevExpress.XtraGrid.Columns.GridColumn colNombredebarcoasignado;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigodelBarco;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoplanificado;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigodeEstado;
    }
}