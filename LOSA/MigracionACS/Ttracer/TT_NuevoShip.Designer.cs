namespace LOSA.MigracionACS.Ttracer
{
    partial class TT_NuevoShip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TT_NuevoShip));
            this.lblpregunta = new DevExpress.XtraEditors.LabelControl();
            this.btnexcel = new System.Windows.Forms.Button();
            this.btnmanual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpregunta
            // 
            this.lblpregunta.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpregunta.Appearance.Options.UseFont = true;
            this.lblpregunta.Location = new System.Drawing.Point(24, 29);
            this.lblpregunta.Name = "lblpregunta";
            this.lblpregunta.Size = new System.Drawing.Size(383, 28);
            this.lblpregunta.TabIndex = 1;
            this.lblpregunta.Text = "Configuracion de nuevo plan de barco";
            // 
            // btnexcel
            // 
            this.btnexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexcel.Image")));
            this.btnexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcel.Location = new System.Drawing.Point(62, 76);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(399, 97);
            this.btnexcel.TabIndex = 3;
            this.btnexcel.Text = "Cargar desde plantilla de excel";
            this.btnexcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // btnmanual
            // 
            this.btnmanual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanual.Image = ((System.Drawing.Image)(resources.GetObject("btnmanual.Image")));
            this.btnmanual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmanual.Location = new System.Drawing.Point(492, 76);
            this.btnmanual.Name = "btnmanual";
            this.btnmanual.Size = new System.Drawing.Size(399, 97);
            this.btnmanual.TabIndex = 2;
            this.btnmanual.Text = "Ingreso Manual";
            this.btnmanual.UseVisualStyleBackColor = true;
            this.btnmanual.Click += new System.EventHandler(this.btnmanual_Click);
            // 
            // TT_NuevoShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 202);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnmanual);
            this.Controls.Add(this.lblpregunta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TT_NuevoShip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo plan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblpregunta;
        private System.Windows.Forms.Button btnmanual;
        private System.Windows.Forms.Button btnexcel;
    }
}