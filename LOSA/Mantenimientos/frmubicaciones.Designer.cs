namespace LOSA.Mantenimientos
{
    partial class frmubicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmubicaciones));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lOSAubicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimiento = new LOSA.Mantenimientos.dsMantenimiento();
            this.lOSA_ubicacionesTableAdapter = new LOSA.Mantenimientos.dsMantenimientoTableAdapters.LOSA_ubicacionesTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lOSAubicacionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasilloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lOSAubicacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOSAubicacionesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(-4, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(638, 30);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "Mantenimiento Ubicaciones";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // lOSAubicacionesBindingSource
            // 
            this.lOSAubicacionesBindingSource.DataMember = "LOSA_ubicaciones";
            this.lOSAubicacionesBindingSource.DataSource = this.dsMantenimiento;
            // 
            // dsMantenimiento
            // 
            this.dsMantenimiento.DataSetName = "dsMantenimiento";
            this.dsMantenimiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOSA_ubicacionesTableAdapter
            // 
            this.lOSA_ubicacionesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.pasilloDataGridViewTextBoxColumn,
            this.rackDataGridViewTextBoxColumn,
            this.enableDataGridViewCheckBoxColumn,
            this.Editar});
            this.dataGridView2.DataSource = this.lOSAubicacionesBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(29, 164);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(548, 156);
            this.dataGridView2.TabIndex = 37;
            // 
            // lOSAubicacionesBindingSource1
            // 
            this.lOSAubicacionesBindingSource1.DataMember = "LOSA_ubicaciones";
            this.lOSAubicacionesBindingSource1.DataSource = this.dsMantenimiento;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pasilloDataGridViewTextBoxColumn
            // 
            this.pasilloDataGridViewTextBoxColumn.DataPropertyName = "pasillo";
            this.pasilloDataGridViewTextBoxColumn.HeaderText = "pasillo";
            this.pasilloDataGridViewTextBoxColumn.Name = "pasilloDataGridViewTextBoxColumn";
            // 
            // rackDataGridViewTextBoxColumn
            // 
            this.rackDataGridViewTextBoxColumn.DataPropertyName = "rack";
            this.rackDataGridViewTextBoxColumn.HeaderText = "rack";
            this.rackDataGridViewTextBoxColumn.Name = "rackDataGridViewTextBoxColumn";
            // 
            // enableDataGridViewCheckBoxColumn
            // 
            this.enableDataGridViewCheckBoxColumn.DataPropertyName = "enable";
            this.enableDataGridViewCheckBoxColumn.HeaderText = "enable";
            this.enableDataGridViewCheckBoxColumn.Name = "enableDataGridViewCheckBoxColumn";
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAgregar.ImageOptions.Image = global::LOSA.Properties.Resources.plus;
            this.btnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAgregar.Location = new System.Drawing.Point(404, 68);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(199, 71);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(15, 68);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(199, 71);
            this.btnAtras.TabIndex = 31;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmubicaciones
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmubicaciones";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(634, 374);
            this.Load += new System.EventHandler(this.frmubicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOSAubicacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOSAubicacionesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private System.Windows.Forms.BindingSource lOSAubicacionesBindingSource;
        private dsMantenimiento dsMantenimiento;
        private dsMantenimientoTableAdapters.LOSA_ubicacionesTableAdapter lOSA_ubicacionesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasilloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.BindingSource lOSAubicacionesBindingSource1;
    }
}
