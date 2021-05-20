namespace LOSA.MicroIngredientes
{
    partial class xfrmMenuMicros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmMenuMicros));
            this.cmdMicros = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // cmdMicros
            // 
            this.cmdMicros.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cmdMicros.Appearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.cmdMicros.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMicros.Appearance.Options.UseBackColor = true;
            this.cmdMicros.Appearance.Options.UseBorderColor = true;
            this.cmdMicros.Appearance.Options.UseFont = true;
            this.cmdMicros.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdMicros.Location = new System.Drawing.Point(48, 60);
            this.cmdMicros.Name = "cmdMicros";
            this.cmdMicros.Size = new System.Drawing.Size(199, 59);
            this.cmdMicros.TabIndex = 17;
            this.cmdMicros.Text = "Ordenes de Pesaje";
            this.cmdMicros.Click += new System.EventHandler(this.cmdMicros_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.Location = new System.Drawing.Point(268, 60);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(199, 59);
            this.simpleButton1.TabIndex = 18;
            this.simpleButton1.Text = "Transacciones";
            // 
            // cmdClose
            // 
            this.cmdClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.ImageOptions.Image")));
            this.cmdClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdClose.Location = new System.Drawing.Point(475, 4);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(40, 32);
            this.cmdClose.TabIndex = 19;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // xfrmMenuMicros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 160);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdMicros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfrmMenuMicros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Micro Ingredientes";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdMicros;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
    }
}