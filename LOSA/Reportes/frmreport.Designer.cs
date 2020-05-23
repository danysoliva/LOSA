namespace LOSA.Reportes
{
    partial class frmreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmreport));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdRegistroLote = new DevExpress.XtraEditors.SimpleButton();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(351, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 28);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Reportes";
            // 
            // cmdRegistroLote
            // 
            this.cmdRegistroLote.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistroLote.Appearance.Options.UseFont = true;
            this.cmdRegistroLote.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRegistroLote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRegistroLote.ImageOptions.Image")));
            this.cmdRegistroLote.Location = new System.Drawing.Point(13, 148);
            this.cmdRegistroLote.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRegistroLote.Name = "cmdRegistroLote";
            this.cmdRegistroLote.Size = new System.Drawing.Size(265, 87);
            this.cmdRegistroLote.TabIndex = 11;
            this.cmdRegistroLote.Text = "Tarimas por\r\nbodega";
            this.cmdRegistroLote.Click += new System.EventHandler(this.cmdRegistroLote_Click);
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(555, 13);
            this.cmdHome.Margin = new System.Windows.Forms.Padding(4);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(265, 87);
            this.cmdHome.TabIndex = 7;
            this.cmdHome.Text = "Atras";
            this.cmdHome.ClientSizeChanged += new System.EventHandler(this.cmdHome_ClientSizeChanged);
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // frmreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 642);
            this.Controls.Add(this.cmdRegistroLote);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmreport";
            this.Text = "frmreport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdRegistroLote;
    }
}