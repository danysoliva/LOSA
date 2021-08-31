
namespace LOSA.MicroIngredientes
{
    partial class xfrmPesajeIndividualBatch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmPesajeIndividualBatch));
            this.lblBascula = new DevExpress.XtraEditors.LabelControl();
            this.lblValorBascula = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.lblCompletados = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblError = new DevExpress.XtraEditors.LabelControl();
            this.lblSuperior = new DevExpress.XtraEditors.LabelControl();
            this.lblInferior = new DevExpress.XtraEditors.LabelControl();
            this.lblRequerido = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lblBascula
            // 
            this.lblBascula.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBascula.Appearance.Options.UseFont = true;
            this.lblBascula.Appearance.Options.UseTextOptions = true;
            this.lblBascula.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBascula.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBascula.Location = new System.Drawing.Point(-1, 50);
            this.lblBascula.Name = "lblBascula";
            this.lblBascula.Size = new System.Drawing.Size(391, 19);
            this.lblBascula.TabIndex = 20;
            this.lblBascula.Text = "Báscula:";
            // 
            // lblValorBascula
            // 
            this.lblValorBascula.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBascula.Appearance.Options.UseFont = true;
            this.lblValorBascula.Appearance.Options.UseTextOptions = true;
            this.lblValorBascula.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblValorBascula.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblValorBascula.Location = new System.Drawing.Point(-1, 75);
            this.lblValorBascula.Name = "lblValorBascula";
            this.lblValorBascula.Size = new System.Drawing.Size(391, 19);
            this.lblValorBascula.TabIndex = 21;
            this.lblValorBascula.Text = "Valor en Báscula: 0.00 Kg";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuardar.ImageOptions.SvgImage")));
            this.btnGuardar.Location = new System.Drawing.Point(158, 136);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 63);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdClose.Location = new System.Drawing.Point(300, 5);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 39);
            this.cmdClose.TabIndex = 23;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // lblCompletados
            // 
            this.lblCompletados.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletados.Appearance.Options.UseFont = true;
            this.lblCompletados.Appearance.Options.UseTextOptions = true;
            this.lblCompletados.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCompletados.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCompletados.Location = new System.Drawing.Point(-1, 306);
            this.lblCompletados.Name = "lblCompletados";
            this.lblCompletados.Size = new System.Drawing.Size(391, 19);
            this.lblCompletados.TabIndex = 24;
            this.lblCompletados.Text = "Báscula:";
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblError
            // 
            this.lblError.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblError.Appearance.Options.UseFont = true;
            this.lblError.Appearance.Options.UseForeColor = true;
            this.lblError.Appearance.Options.UseTextOptions = true;
            this.lblError.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblError.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblError.Location = new System.Drawing.Point(-1, 215);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(391, 19);
            this.lblError.TabIndex = 25;
            this.lblError.Text = "El valor pesado no esta dentro de los limites de tolerancia";
            this.lblError.Visible = false;
            // 
            // lblSuperior
            // 
            this.lblSuperior.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblSuperior.Appearance.Options.UseFont = true;
            this.lblSuperior.Appearance.Options.UseForeColor = true;
            this.lblSuperior.Appearance.Options.UseTextOptions = true;
            this.lblSuperior.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblSuperior.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSuperior.Location = new System.Drawing.Point(-1, 238);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(391, 19);
            this.lblSuperior.TabIndex = 26;
            this.lblSuperior.Text = "LS";
            this.lblSuperior.Visible = false;
            // 
            // lblInferior
            // 
            this.lblInferior.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInferior.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblInferior.Appearance.Options.UseFont = true;
            this.lblInferior.Appearance.Options.UseForeColor = true;
            this.lblInferior.Appearance.Options.UseTextOptions = true;
            this.lblInferior.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblInferior.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblInferior.Location = new System.Drawing.Point(-1, 259);
            this.lblInferior.Name = "lblInferior";
            this.lblInferior.Size = new System.Drawing.Size(391, 19);
            this.lblInferior.TabIndex = 27;
            this.lblInferior.Text = "LI";
            this.lblInferior.Visible = false;
            // 
            // lblRequerido
            // 
            this.lblRequerido.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequerido.Appearance.Options.UseFont = true;
            this.lblRequerido.Appearance.Options.UseTextOptions = true;
            this.lblRequerido.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRequerido.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRequerido.Location = new System.Drawing.Point(-1, 5);
            this.lblRequerido.Name = "lblRequerido";
            this.lblRequerido.Size = new System.Drawing.Size(231, 19);
            this.lblRequerido.TabIndex = 28;
            this.lblRequerido.Text = "Valor Requerido: 0.00 Kg";
            // 
            // xfrmPesajeIndividualBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 337);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.lblRequerido);
            this.Controls.Add(this.lblInferior);
            this.Controls.Add(this.lblSuperior);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblCompletados);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblValorBascula);
            this.Controls.Add(this.lblBascula);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "xfrmPesajeIndividualBatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xfrmPesajeIndividualBatch";
            this.Load += new System.EventHandler(this.xfrmPesajeIndividualBatch_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblValorBascula;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.LabelControl lblCompletados;
        private DevExpress.XtraEditors.LabelControl lblBascula;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl lblError;
        private DevExpress.XtraEditors.LabelControl lblSuperior;
        private DevExpress.XtraEditors.LabelControl lblInferior;
        private DevExpress.XtraEditors.LabelControl lblRequerido;
    }
}