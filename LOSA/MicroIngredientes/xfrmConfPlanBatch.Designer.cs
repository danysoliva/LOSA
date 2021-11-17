
namespace LOSA.MicroIngredientes
{
    partial class xfrmConfPlanBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmConfPlanBatch));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSum10 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.seBatch = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblPesoBatch = new DevExpress.XtraEditors.LabelControl();
            this.lblPesoReal = new DevExpress.XtraEditors.LabelControl();
            this.lblPesoTotal = new DevExpress.XtraEditors.LabelControl();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cmdDown = new DevExpress.XtraEditors.SimpleButton();
            this.cmdUp = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.seBatch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(363, 100);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 44);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "-10";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdSum10
            // 
            this.cmdSum10.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSum10.Appearance.Options.UseFont = true;
            this.cmdSum10.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSum10.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdSum10.Location = new System.Drawing.Point(363, 14);
            this.cmdSum10.Name = "cmdSum10";
            this.cmdSum10.Size = new System.Drawing.Size(75, 44);
            this.cmdSum10.TabIndex = 13;
            this.cmdSum10.Text = "+10";
            this.cmdSum10.Click += new System.EventHandler(this.cmdSum10_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(41, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(220, 19);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Cantidad de Batch a pesar:";
            // 
            // seBatch
            // 
            this.seBatch.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seBatch.Enabled = false;
            this.seBatch.Location = new System.Drawing.Point(267, 64);
            this.seBatch.Name = "seBatch";
            this.seBatch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seBatch.Properties.Appearance.Options.UseFont = true;
            this.seBatch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seBatch.Properties.IsFloatValue = false;
            this.seBatch.Properties.Mask.EditMask = "N00";
            this.seBatch.Properties.MaxValue = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.seBatch.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seBatch.Size = new System.Drawing.Size(171, 30);
            this.seBatch.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(153, 169);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(128, 19);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Peso por Batch:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(193, 234);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 19);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Peso Real:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(187, 194);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(93, 19);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Peso Total:";
            // 
            // lblPesoBatch
            // 
            this.lblPesoBatch.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoBatch.Appearance.Options.UseFont = true;
            this.lblPesoBatch.Location = new System.Drawing.Point(293, 169);
            this.lblPesoBatch.Name = "lblPesoBatch";
            this.lblPesoBatch.Size = new System.Drawing.Size(122, 19);
            this.lblPesoBatch.TabIndex = 18;
            this.lblPesoBatch.Text = "Peso por Batch";
            // 
            // lblPesoReal
            // 
            this.lblPesoReal.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoReal.Appearance.Options.UseFont = true;
            this.lblPesoReal.Location = new System.Drawing.Point(292, 230);
            this.lblPesoReal.Name = "lblPesoReal";
            this.lblPesoReal.Size = new System.Drawing.Size(42, 23);
            this.lblPesoReal.TabIndex = 19;
            this.lblPesoReal.Text = "0.00";
            // 
            // lblPesoTotal
            // 
            this.lblPesoTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoTotal.Appearance.Options.UseFont = true;
            this.lblPesoTotal.Location = new System.Drawing.Point(292, 194);
            this.lblPesoTotal.Name = "lblPesoTotal";
            this.lblPesoTotal.Size = new System.Drawing.Size(122, 19);
            this.lblPesoTotal.TabIndex = 20;
            this.lblPesoTotal.Text = "Peso por Batch";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnNext.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnNext.Appearance.Options.UseBackColor = true;
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Appearance.Options.UseForeColor = true;
            this.btnNext.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnNext.Location = new System.Drawing.Point(303, 279);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(111, 44);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Confirmar";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Appearance.Options.UseForeColor = true;
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCancel.Location = new System.Drawing.Point(133, 279);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 44);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmdDown
            // 
            this.cmdDown.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdDown.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdDown.ImageOptions.Image")));
            this.cmdDown.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdDown.Location = new System.Drawing.Point(267, 100);
            this.cmdDown.Name = "cmdDown";
            this.cmdDown.Size = new System.Drawing.Size(75, 44);
            this.cmdDown.TabIndex = 12;
            this.cmdDown.Text = "simpleButton2";
            this.cmdDown.Click += new System.EventHandler(this.cmdDown_Click);
            // 
            // cmdUp
            // 
            this.cmdUp.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdUp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdUp.ImageOptions.Image")));
            this.cmdUp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdUp.Location = new System.Drawing.Point(267, 14);
            this.cmdUp.Name = "cmdUp";
            this.cmdUp.Size = new System.Drawing.Size(75, 44);
            this.cmdUp.TabIndex = 11;
            this.cmdUp.Text = "simpleButton1";
            this.cmdUp.Click += new System.EventHandler(this.cmdUp_Click);
            // 
            // xfrmConfPlanBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 335);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblPesoTotal);
            this.Controls.Add(this.lblPesoReal);
            this.Controls.Add(this.lblPesoBatch);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdSum10);
            this.Controls.Add(this.cmdDown);
            this.Controls.Add(this.cmdUp);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.seBatch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfrmConfPlanBatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar Planificacion de Batch";
            this.Load += new System.EventHandler(this.xfrmConfPlanBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seBatch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton cmdSum10;
        private DevExpress.XtraEditors.SimpleButton cmdDown;
        private DevExpress.XtraEditors.SimpleButton cmdUp;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit seBatch;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblPesoBatch;
        private DevExpress.XtraEditors.LabelControl lblPesoReal;
        private DevExpress.XtraEditors.LabelControl lblPesoTotal;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}