namespace LOSA.MigracionACS.PT
{
    partial class PT_NewGrp_Dtl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PT_NewGrp_Dtl));
            this.grp_detail = new DevExpress.XtraEditors.GroupControl();
            this.txt_detail = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grp_detail)).BeginInit();
            this.grp_detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_detail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_detail
            // 
            this.grp_detail.Controls.Add(this.simpleButton1);
            this.grp_detail.Controls.Add(this.txt_detail);
            this.grp_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_detail.Location = new System.Drawing.Point(0, 0);
            this.grp_detail.Name = "grp_detail";
            this.grp_detail.Size = new System.Drawing.Size(340, 56);
            this.grp_detail.TabIndex = 0;
            this.grp_detail.Text = "groupControl1";
            // 
            // txt_detail
            // 
            this.txt_detail.Location = new System.Drawing.Point(5, 27);
            this.txt_detail.Name = "txt_detail";
            this.txt_detail.Properties.MaxLength = 50;
            this.txt_detail.Size = new System.Drawing.Size(297, 20);
            this.txt_detail.TabIndex = 0;
            this.txt_detail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_detail_KeyDown);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::LOSA.Properties.Resources.Accept_24x24;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(308, 26);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(22, 21);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Tag = "Agregar Gasto";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // PT_NewGrp_Dtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 56);
            this.Controls.Add(this.grp_detail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PT_NewGrp_Dtl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PT_NewGrp_Dtl";
            this.Load += new System.EventHandler(this.PT_NewGrp_Dtl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grp_detail)).EndInit();
            this.grp_detail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_detail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grp_detail;
        private DevExpress.XtraEditors.TextEdit txt_detail;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}