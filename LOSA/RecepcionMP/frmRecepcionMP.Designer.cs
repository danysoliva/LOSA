namespace LOSA.RecepcionMP
{
    partial class frmRecepcionMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecepcionMP));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumBoleta = new DevExpress.XtraEditors.TextEdit();
            this.cmdSelectBoleta = new DevExpress.XtraEditors.SimpleButton();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumBoleta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(37, 141);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 19);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Boleta Bascula";
            // 
            // txtNumBoleta
            // 
            this.txtNumBoleta.Location = new System.Drawing.Point(145, 138);
            this.txtNumBoleta.Name = "txtNumBoleta";
            this.txtNumBoleta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumBoleta.Properties.Appearance.Options.UseFont = true;
            this.txtNumBoleta.Properties.ReadOnly = true;
            this.txtNumBoleta.Size = new System.Drawing.Size(331, 26);
            this.txtNumBoleta.TabIndex = 8;
            // 
            // cmdSelectBoleta
            // 
            this.cmdSelectBoleta.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelectBoleta.Appearance.Options.UseFont = true;
            this.cmdSelectBoleta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSelectBoleta.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.cmdSelectBoleta.Location = new System.Drawing.Point(482, 130);
            this.cmdSelectBoleta.Name = "cmdSelectBoleta";
            this.cmdSelectBoleta.Size = new System.Drawing.Size(42, 40);
            this.cmdSelectBoleta.TabIndex = 9;
            this.cmdSelectBoleta.Click += new System.EventHandler(this.cmdSelectBoleta_Click);
            // 
            // cmdHome
            // 
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdHome.ImageOptions.Image")));
            this.cmdHome.Location = new System.Drawing.Point(12, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(199, 71);
            this.cmdHome.TabIndex = 6;
            this.cmdHome.Text = "Home";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // frmRecepcionMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 521);
            this.ControlBox = false;
            this.Controls.Add(this.cmdSelectBoleta);
            this.Controls.Add(this.txtNumBoleta);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecepcionMP";
            this.Text = "frmRecepcionMP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRecepcionMP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumBoleta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNumBoleta;
        private DevExpress.XtraEditors.SimpleButton cmdSelectBoleta;
    }
}