
namespace LOSA.MigracionACS.RRHH.Liquidaciones
{
    partial class frmConfPorcentajeLiquiOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfPorcentajeLiquiOP));
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.spinPorcentaje = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPorcentaje.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdClose.ImageOptions.SvgImage")));
            this.cmdClose.Location = new System.Drawing.Point(250, 175);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(91, 43);
            this.cmdClose.TabIndex = 112;
            this.cmdClose.Text = "Cerrar";
            this.cmdClose.ToolTip = "Guardar";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdGuardar.ImageOptions.Image = global::LOSA.Properties.Resources.saveChanges_32x32;
            this.cmdGuardar.Location = new System.Drawing.Point(106, 175);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(91, 43);
            this.cmdGuardar.TabIndex = 111;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.ToolTip = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.Location = new System.Drawing.Point(187, 30);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(98, 19);
            this.lblPorcentaje.TabIndex = 109;
            this.lblPorcentaje.Text = "Porcentaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 108;
            this.label1.Text = "Descripcion";
            // 
            // spinPorcentaje
            // 
            this.spinPorcentaje.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinPorcentaje.Location = new System.Drawing.Point(191, 100);
            this.spinPorcentaje.Name = "spinPorcentaje";
            this.spinPorcentaje.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.spinPorcentaje.Properties.Appearance.Options.UseFont = true;
            this.spinPorcentaje.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinPorcentaje.Size = new System.Drawing.Size(160, 24);
            this.spinPorcentaje.TabIndex = 113;
            // 
            // frmConfPorcentajeLiquiOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 249);
            this.Controls.Add(this.spinPorcentaje);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.label1);
            this.Name = "frmConfPorcentajeLiquiOP";
            ((System.ComponentModel.ISupportInitialize)(this.spinPorcentaje.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit spinPorcentaje;
    }
}