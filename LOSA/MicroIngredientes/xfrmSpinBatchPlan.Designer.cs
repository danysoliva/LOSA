namespace LOSA.MicroIngredientes
{
    partial class xfrmSpinBatchPlan
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
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.seBatch = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdCheck = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.seBatch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdClose.Location = new System.Drawing.Point(186, 83);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(74, 40);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // seBatch
            // 
            this.seBatch.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seBatch.Location = new System.Drawing.Point(207, 30);
            this.seBatch.Name = "seBatch";
            this.seBatch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seBatch.Properties.Appearance.Options.UseFont = true;
            this.seBatch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seBatch.Properties.IsFloatValue = false;
            this.seBatch.Properties.Mask.EditMask = "N00";
            this.seBatch.Size = new System.Drawing.Size(100, 26);
            this.seBatch.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(33, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(165, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Cant. Batch a pesar:";
            // 
            // cmdCheck
            // 
            this.cmdCheck.ImageOptions.Image = global::LOSA.Properties.Resources.Done_icon;
            this.cmdCheck.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdCheck.Location = new System.Drawing.Point(81, 83);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(74, 40);
            this.cmdCheck.TabIndex = 3;
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // xfrmSpinBatchPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 151);
            this.Controls.Add(this.cmdCheck);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.seBatch);
            this.Controls.Add(this.cmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "xfrmSpinBatchPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xfrmSpinBatchPlan";
            ((System.ComponentModel.ISupportInitialize)(this.seBatch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.SpinEdit seBatch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdCheck;
    }
}