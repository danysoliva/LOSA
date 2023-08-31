
namespace LOSA.MigracionACS.Produccion.Reports
{
    partial class frmEficienciaMolinos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEficienciaMolinos));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.gridDetalleReq = new DevExpress.XtraGrid.GridControl();
            this.dsEficienciaMolinos1 = new LOSA.MigracionACS.Produccion.DataSet_.dsEficienciaMolinos();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhorase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhorasm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coleficiencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSupporIT_WindowName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEficienciaMolinos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupporIT_WindowName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(199, 30);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "Eficiencia de Molinos";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(633, 18);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(135, 58);
            this.simpleButton1.TabIndex = 25;
            this.simpleButton1.Text = "Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Hasta:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Desde:";
            // 
            // dtHasta
            // 
            this.dtHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(506, 50);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Size = new System.Drawing.Size(121, 26);
            this.dtHasta.TabIndex = 22;
            this.dtHasta.EditValueChanged += new System.EventHandler(this.dtHasta_EditValueChanged);
            // 
            // dtDesde
            // 
            this.dtDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(506, 18);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Size = new System.Drawing.Size(121, 26);
            this.dtDesde.TabIndex = 21;
            this.dtDesde.EditValueChanged += new System.EventHandler(this.dtDesde_EditValueChanged);
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
            this.btnAtras.Location = new System.Drawing.Point(775, 18);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(178, 58);
            this.btnAtras.TabIndex = 20;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // gridDetalleReq
            // 
            this.gridDetalleReq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetalleReq.DataMember = "eficienciasimple";
            this.gridDetalleReq.DataSource = this.dsEficienciaMolinos1;
            this.gridDetalleReq.Location = new System.Drawing.Point(2, 83);
            this.gridDetalleReq.MainView = this.gridView1;
            this.gridDetalleReq.Name = "gridDetalleReq";
            this.gridDetalleReq.Size = new System.Drawing.Size(961, 353);
            this.gridDetalleReq.TabIndex = 19;
            this.gridDetalleReq.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsEficienciaMolinos1
            // 
            this.dsEficienciaMolinos1.DataSetName = "dsEficienciaMolinos";
            this.dsEficienciaMolinos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre,
            this.colhorase,
            this.colhorasm,
            this.coleficiencia});
            this.gridView1.GridControl = this.gridDetalleReq;
            this.gridView1.Name = "gridView1";
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            // 
            // colhorase
            // 
            this.colhorase.FieldName = "horase";
            this.colhorase.Name = "colhorase";
            this.colhorase.Visible = true;
            this.colhorase.VisibleIndex = 1;
            // 
            // colhorasm
            // 
            this.colhorasm.FieldName = "horasm";
            this.colhorasm.Name = "colhorasm";
            this.colhorasm.Visible = true;
            this.colhorasm.VisibleIndex = 2;
            // 
            // coleficiencia
            // 
            this.coleficiencia.FieldName = "eficiencia";
            this.coleficiencia.Name = "coleficiencia";
            this.coleficiencia.Visible = true;
            this.coleficiencia.VisibleIndex = 3;
            // 
            // txtSupporIT_WindowName
            // 
            this.txtSupporIT_WindowName.EditValue = "frmEficienciaMolinos";
            this.txtSupporIT_WindowName.Location = new System.Drawing.Point(2, 1);
            this.txtSupporIT_WindowName.Name = "txtSupporIT_WindowName";
            this.txtSupporIT_WindowName.Properties.ReadOnly = true;
            this.txtSupporIT_WindowName.Size = new System.Drawing.Size(126, 20);
            this.txtSupporIT_WindowName.TabIndex = 27;
            this.txtSupporIT_WindowName.Visible = false;
            // 
            // frmEficienciaMolinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 438);
            this.Controls.Add(this.txtSupporIT_WindowName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gridDetalleReq);
            this.Name = "frmEficienciaMolinos";
            this.Text = "Eficiencia de Molinos";
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEficienciaMolinos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupporIT_WindowName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.GridControl gridDetalleReq;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DataSet_.dsEficienciaMolinos dsEficienciaMolinos1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colhorase;
        private DevExpress.XtraGrid.Columns.GridColumn colhorasm;
        private DevExpress.XtraGrid.Columns.GridColumn coleficiencia;
        private DevExpress.XtraEditors.TextEdit txtSupporIT_WindowName;
    }
}