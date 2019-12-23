namespace LOSA.Logistica
{
    partial class frmEventosTarima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventosTarima));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teIdTarima = new DevExpress.XtraEditors.TextEdit();
            this.teFechaCreacion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gcEventos = new DevExpress.XtraGrid.GridControl();
            this.gvEventos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.teIdTarima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFechaCreacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(160, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID Tarima:";
            // 
            // teIdTarima
            // 
            this.teIdTarima.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.teIdTarima.Location = new System.Drawing.Point(257, 87);
            this.teIdTarima.Name = "teIdTarima";
            this.teIdTarima.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teIdTarima.Properties.Appearance.Options.UseFont = true;
            this.teIdTarima.Properties.ReadOnly = true;
            this.teIdTarima.Size = new System.Drawing.Size(251, 32);
            this.teIdTarima.TabIndex = 1;
            // 
            // teFechaCreacion
            // 
            this.teFechaCreacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.teFechaCreacion.Location = new System.Drawing.Point(257, 125);
            this.teFechaCreacion.Name = "teFechaCreacion";
            this.teFechaCreacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teFechaCreacion.Properties.Appearance.Options.UseFont = true;
            this.teFechaCreacion.Properties.ReadOnly = true;
            this.teFechaCreacion.Size = new System.Drawing.Size(251, 32);
            this.teFechaCreacion.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(113, 128);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(138, 25);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Fecha Creación:";
            // 
            // gcEventos
            // 
            this.gcEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcEventos.Location = new System.Drawing.Point(0, 163);
            this.gcEventos.MainView = this.gvEventos;
            this.gcEventos.Name = "gcEventos";
            this.gcEventos.Size = new System.Drawing.Size(639, 397);
            this.gcEventos.TabIndex = 4;
            this.gcEventos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEventos});
            // 
            // gvEventos
            // 
            this.gvEventos.GridControl = this.gcEventos;
            this.gvEventos.Name = "gvEventos";
            this.gvEventos.OptionsView.ShowGroupPanel = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(167, 47);
            this.btnAtras.TabIndex = 10;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmEventosTarima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gcEventos);
            this.Controls.Add(this.teFechaCreacion);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.teIdTarima);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEventosTarima";
            this.Text = "frmEventosTarima";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEventosTarima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teIdTarima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFechaCreacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teIdTarima;
        private DevExpress.XtraEditors.TextEdit teFechaCreacion;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gcEventos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEventos;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
    }
}