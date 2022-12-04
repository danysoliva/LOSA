namespace LOSA.MigracionACS.OIL
{
    partial class frmLotesDisponiblesGranel
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dsGranelesLOSA1 = new MigracionACS.OIL.dsGranelesLOSA();
            this.colid_lote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGranelesLOSA1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "lotes_graneles_disponibles";
            this.gridControl1.DataSource = this.dsGranelesLOSA1;
            this.gridControl1.Location = new System.Drawing.Point(-2, 49);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(681, 373);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_lote,
            this.collote,
            this.colMP,
            this.colcantidad});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // dsGranelesLOSA1
            // 
            this.dsGranelesLOSA1.DataSetName = "dsGranelesLOSA";
            this.dsGranelesLOSA1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colid_lote
            // 
            this.colid_lote.FieldName = "id_lote";
            this.colid_lote.Name = "colid_lote";
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 0;
            // 
            // colMP
            // 
            this.colMP.Caption = "Materia Prima";
            this.colMP.FieldName = "MP";
            this.colMP.Name = "colMP";
            this.colMP.OptionsColumn.AllowEdit = false;
            this.colMP.Visible = true;
            this.colMP.VisibleIndex = 1;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad Disponible";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el Lote";
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.BackColor = System.Drawing.Color.Salmon;
            this.cmdCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Image = global::LOSA.Properties.Resources.close_round_24;
            this.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.Location = new System.Drawing.Point(589, 6);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(84, 37);
            this.cmdCerrar.TabIndex = 17;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // frmLotesDisponiblesGranel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 420);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmLotesDisponiblesGranel";
            this.Text = "Lotes Disponibles Granel";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGranelesLOSA1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsGranelesLOSA dsGranelesLOSA1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_lote;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colMP;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdCerrar;
    }
}