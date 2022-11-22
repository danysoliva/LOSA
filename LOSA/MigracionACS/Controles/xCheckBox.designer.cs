namespace LOSA.MigracionACS.Controles
{
    partial class xCheckBox
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
            this.pColor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pColor
            // 
            this.pColor.BackColor = System.Drawing.Color.RoyalBlue;
            this.pColor.Location = new System.Drawing.Point(8, 6);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(17, 17);
            this.pColor.TabIndex = 0;
            this.pColor.Visible = false;
            this.pColor.Click += new System.EventHandler(this.pColor_Click);
            // 
            // xCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LOSA.Properties.Resources.Sin_título2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.pColor);
            this.Name = "xCheckBox";
            this.Size = new System.Drawing.Size(35, 31);
            this.Load += new System.EventHandler(this.xCheckBox_Load);
            this.Click += new System.EventHandler(this.xCheckBox_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pColor;
    }
}
