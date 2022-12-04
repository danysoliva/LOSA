namespace LOSA.MigracionACS.OIL
{
    partial class frmTipoReq
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
            this.cmdMix = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNormal = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // cmdMix
            // 
            this.cmdMix.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMix.Appearance.Options.UseFont = true;
            this.cmdMix.Enabled = false;
            this.cmdMix.Location = new System.Drawing.Point(51, 105);
            this.cmdMix.Name = "cmdMix";
            this.cmdMix.Size = new System.Drawing.Size(267, 59);
            this.cmdMix.TabIndex = 1;
            this.cmdMix.Text = "Req. Mix";
            this.cmdMix.Click += new System.EventHandler(this.cmdMix_Click);
            // 
            // cmdNormal
            // 
            this.cmdNormal.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNormal.Appearance.Options.UseFont = true;
            this.cmdNormal.ImageOptions.Image = global::LOSA.Properties.Resources.Aha_Soft_Transport_Pipe_line1;
            this.cmdNormal.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmdNormal.Location = new System.Drawing.Point(51, 27);
            this.cmdNormal.Name = "cmdNormal";
            this.cmdNormal.Size = new System.Drawing.Size(267, 59);
            this.cmdNormal.TabIndex = 0;
            this.cmdNormal.Text = "Req. Normal";
            this.cmdNormal.Click += new System.EventHandler(this.cmdNormal_Click);
            // 
            // frmTipoReq
            // 
            this.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 193);
            this.Controls.Add(this.cmdMix);
            this.Controls.Add(this.cmdNormal);
            this.Name = "frmTipoReq";
            this.Text = "Tipo de Requisicón";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdNormal;
        private DevExpress.XtraEditors.SimpleButton cmdMix;
    }
}