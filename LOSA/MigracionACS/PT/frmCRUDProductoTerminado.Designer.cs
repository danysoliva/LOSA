
namespace LOSA.MigracionACS.PT
{
    partial class frmCRUDProductoTerminado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRUDProductoTerminado));
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.tsTipoPT = new DevExpress.XtraEditors.ToggleSwitch();
            this.textFormula = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tsTipoPT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFormula.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(445, 357);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(125, 42);
            this.btnAtras.TabIndex = 85;
            this.btnAtras.Text = "Atras";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(271, 357);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(125, 42);
            this.cmdGuardar.TabIndex = 84;
            this.cmdGuardar.Text = "Guardar";
            // 
            // tsTipoPT
            // 
            this.tsTipoPT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tsTipoPT.EditValue = true;
            this.tsTipoPT.Location = new System.Drawing.Point(365, 21);
            this.tsTipoPT.Name = "tsTipoPT";
            this.tsTipoPT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.tsTipoPT.Properties.Appearance.Options.UseFont = true;
            this.tsTipoPT.Properties.OffText = "Camaron";
            this.tsTipoPT.Properties.OnText = "Tilapia";
            this.tsTipoPT.Size = new System.Drawing.Size(162, 23);
            this.tsTipoPT.TabIndex = 89;
            // 
            // textFormula
            // 
            this.textFormula.Enabled = false;
            this.textFormula.Location = new System.Drawing.Point(245, 87);
            this.textFormula.Name = "textFormula";
            this.textFormula.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.textFormula.Properties.Appearance.Options.UseFont = true;
            this.textFormula.Size = new System.Drawing.Size(154, 24);
            this.textFormula.TabIndex = 88;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(110, 90);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(126, 18);
            this.labelControl15.TabIndex = 87;
            this.labelControl15.Text = "Codigo de Formula:";
            // 
            // frmCRUDProductoTerminado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 438);
            this.Controls.Add(this.tsTipoPT);
            this.Controls.Add(this.textFormula);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.cmdGuardar);
            this.Name = "frmCRUDProductoTerminado";
            ((System.ComponentModel.ISupportInitialize)(this.tsTipoPT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFormula.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.ToggleSwitch tsTipoPT;
        private DevExpress.XtraEditors.TextEdit textFormula;
        private DevExpress.XtraEditors.LabelControl labelControl15;
    }
}