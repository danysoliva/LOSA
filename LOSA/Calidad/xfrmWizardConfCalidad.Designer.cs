
namespace LOSA.Calidad
{
    partial class xfrmWizardConfCalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmWizardConfCalidad));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(48, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(447, 50);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Este ingreso ya tiene una configuración aplicada para un lote, ¿Desea copiarla?";
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAceptar.Appearance.Options.UseFont = true;
            this.cmdAceptar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAceptar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAceptar.ImageOptions.SvgImage")));
            this.cmdAceptar.Location = new System.Drawing.Point(80, 145);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(91, 48);
            this.cmdAceptar.TabIndex = 1;
            this.cmdAceptar.Text = "Si";
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Appearance.Options.UseFont = true;
            this.cmdClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdClose.ImageOptions.SvgImage")));
            this.cmdClose.Location = new System.Drawing.Point(190, 145);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(91, 48);
            this.cmdClose.TabIndex = 2;
            this.cmdClose.Text = "No";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(307, 145);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(152, 48);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Ver Conf. Existente";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Appearance.Options.UseFont = true;
            this.cmdCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCancelar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.cmdCancelar.Location = new System.Drawing.Point(435, 3);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(91, 48);
            this.cmdCancelar.TabIndex = 4;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.Visible = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // xfrmWizardConfCalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 208);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfrmWizardConfCalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistente de configuración";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdAceptar;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton cmdCancelar;
    }
}