namespace LOSA.MigracionACS.Ttracer
{
    partial class TT_Nuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TT_Nuevo));
            this.pnmain = new DevExpress.XtraEditors.PanelControl();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnmain)).BeginInit();
            this.pnmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnmain
            // 
            this.pnmain.Controls.Add(this.btnYes);
            this.pnmain.Controls.Add(this.btnNO);
            this.pnmain.Controls.Add(this.labelControl1);
            this.pnmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnmain.Location = new System.Drawing.Point(0, 0);
            this.pnmain.Name = "pnmain";
            this.pnmain.Size = new System.Drawing.Size(1027, 432);
            this.pnmain.TabIndex = 0;
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Image = ((System.Drawing.Image)(resources.GetObject("btnYes.Image")));
            this.btnYes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYes.Location = new System.Drawing.Point(5, 185);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(487, 186);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "Si, ya tengo configurado un barco";
            this.btnYes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNO
            // 
            this.btnNO.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNO.Image = ((System.Drawing.Image)(resources.GetObject("btnNO.Image")));
            this.btnNO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNO.Location = new System.Drawing.Point(517, 185);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(465, 186);
            this.btnNO.TabIndex = 1;
            this.btnNO.Text = "No, deseo generar un plan de inicio.";
            this.btnNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(84, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(770, 114);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "¿El plan a crear tiene preconfigurado\r\n un barco?";
            // 
            // TT_Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 432);
            this.Controls.Add(this.pnmain);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "TT_Nuevo";
            this.Text = "Guia de Nuevo Plan";
            ((System.ComponentModel.ISupportInitialize)(this.pnmain)).EndInit();
            this.pnmain.ResumeLayout(false);
            this.pnmain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnmain;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNO;
    }
}