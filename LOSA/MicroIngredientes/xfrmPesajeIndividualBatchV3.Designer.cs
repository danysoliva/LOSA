
namespace LOSA.MicroIngredientes
{
    partial class xfrmPesajeIndividualBatchV3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmPesajeIndividualBatchV3));
            this.lblBascula1 = new DevExpress.XtraEditors.LabelControl();
            this.lblValorBascula1 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.lblCompletados = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblError = new DevExpress.XtraEditors.LabelControl();
            this.lblSuperior = new DevExpress.XtraEditors.LabelControl();
            this.lblInferior = new DevExpress.XtraEditors.LabelControl();
            this.lblRequerido = new DevExpress.XtraEditors.LabelControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsMicros = new LOSA.MicroIngredientes.dsMicros();
            this.lblValorBascula2 = new DevExpress.XtraEditors.LabelControl();
            this.lblBascula2 = new DevExpress.XtraEditors.LabelControl();
            this.lblMP = new DevExpress.XtraEditors.LabelControl();
            this.btnBascula1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnBascula2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBascula1
            // 
            this.lblBascula1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBascula1.Appearance.Options.UseFont = true;
            this.lblBascula1.Appearance.Options.UseTextOptions = true;
            this.lblBascula1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBascula1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBascula1.Location = new System.Drawing.Point(0, 80);
            this.lblBascula1.Name = "lblBascula1";
            this.lblBascula1.Size = new System.Drawing.Size(307, 19);
            this.lblBascula1.TabIndex = 20;
            this.lblBascula1.Text = "Báscula:";
            // 
            // lblValorBascula1
            // 
            this.lblValorBascula1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBascula1.Appearance.Options.UseFont = true;
            this.lblValorBascula1.Appearance.Options.UseTextOptions = true;
            this.lblValorBascula1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblValorBascula1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblValorBascula1.Location = new System.Drawing.Point(-1, 105);
            this.lblValorBascula1.Name = "lblValorBascula1";
            this.lblValorBascula1.Size = new System.Drawing.Size(308, 30);
            this.lblValorBascula1.TabIndex = 21;
            this.lblValorBascula1.Text = "Valor en Báscula: 0.00 Kg";
            this.lblValorBascula1.Click += new System.EventHandler(this.lblValorBascula1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuardar.ImageOptions.SvgImage")));
            this.btnGuardar.Location = new System.Drawing.Point(549, 355);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 63);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdClose.Location = new System.Drawing.Point(584, 5);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 39);
            this.cmdClose.TabIndex = 23;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // lblCompletados
            // 
            this.lblCompletados.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletados.Appearance.Options.UseFont = true;
            this.lblCompletados.Appearance.Options.UseTextOptions = true;
            this.lblCompletados.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCompletados.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCompletados.Location = new System.Drawing.Point(-1, 416);
            this.lblCompletados.Name = "lblCompletados";
            this.lblCompletados.Size = new System.Drawing.Size(671, 23);
            this.lblCompletados.TabIndex = 24;
            this.lblCompletados.Text = "Asistente";
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblError.Appearance.Options.UseFont = true;
            this.lblError.Appearance.Options.UseForeColor = true;
            this.lblError.Appearance.Options.UseTextOptions = true;
            this.lblError.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblError.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblError.Location = new System.Drawing.Point(-1, 304);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(671, 26);
            this.lblError.TabIndex = 25;
            this.lblError.Text = "El valor pesado no esta dentro de los limites de tolerancia";
            this.lblError.Visible = false;
            // 
            // lblSuperior
            // 
            this.lblSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSuperior.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblSuperior.Appearance.Options.UseFont = true;
            this.lblSuperior.Appearance.Options.UseForeColor = true;
            this.lblSuperior.Appearance.Options.UseTextOptions = true;
            this.lblSuperior.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblSuperior.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSuperior.Location = new System.Drawing.Point(-1, 332);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(671, 29);
            this.lblSuperior.TabIndex = 26;
            this.lblSuperior.Text = "LS";
            this.lblSuperior.Visible = false;
            // 
            // lblInferior
            // 
            this.lblInferior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInferior.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInferior.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblInferior.Appearance.Options.UseFont = true;
            this.lblInferior.Appearance.Options.UseForeColor = true;
            this.lblInferior.Appearance.Options.UseTextOptions = true;
            this.lblInferior.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblInferior.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblInferior.Location = new System.Drawing.Point(-1, 361);
            this.lblInferior.Name = "lblInferior";
            this.lblInferior.Size = new System.Drawing.Size(671, 32);
            this.lblInferior.TabIndex = 27;
            this.lblInferior.Text = "LI";
            this.lblInferior.Visible = false;
            // 
            // lblRequerido
            // 
            this.lblRequerido.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequerido.Appearance.Options.UseFont = true;
            this.lblRequerido.Appearance.Options.UseTextOptions = true;
            this.lblRequerido.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRequerido.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRequerido.Location = new System.Drawing.Point(-1, 5);
            this.lblRequerido.Name = "lblRequerido";
            this.lblRequerido.Size = new System.Drawing.Size(671, 28);
            this.lblRequerido.TabIndex = 28;
            this.lblRequerido.Text = "Valor Requerido: 0.00 Kg";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Pesaje_Bascula";
            this.bindingSource1.DataSource = this.dsMicros;
            // 
            // dsMicros
            // 
            this.dsMicros.DataSetName = "dsMicros";
            this.dsMicros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblValorBascula2
            // 
            this.lblValorBascula2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBascula2.Appearance.Options.UseFont = true;
            this.lblValorBascula2.Appearance.Options.UseTextOptions = true;
            this.lblValorBascula2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblValorBascula2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblValorBascula2.Location = new System.Drawing.Point(346, 105);
            this.lblValorBascula2.Name = "lblValorBascula2";
            this.lblValorBascula2.Size = new System.Drawing.Size(308, 30);
            this.lblValorBascula2.TabIndex = 31;
            this.lblValorBascula2.Text = "Valor en Báscula: 0.00 Kg";
            // 
            // lblBascula2
            // 
            this.lblBascula2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBascula2.Appearance.Options.UseFont = true;
            this.lblBascula2.Appearance.Options.UseTextOptions = true;
            this.lblBascula2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBascula2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBascula2.Location = new System.Drawing.Point(346, 80);
            this.lblBascula2.Name = "lblBascula2";
            this.lblBascula2.Size = new System.Drawing.Size(308, 19);
            this.lblBascula2.TabIndex = 30;
            this.lblBascula2.Text = "Báscula:";
            // 
            // lblMP
            // 
            this.lblMP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMP.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMP.Appearance.Options.UseFont = true;
            this.lblMP.Appearance.Options.UseTextOptions = true;
            this.lblMP.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblMP.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMP.Location = new System.Drawing.Point(0, 266);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(670, 32);
            this.lblMP.TabIndex = 32;
            this.lblMP.Text = "MP";
            // 
            // btnBascula1
            // 
            this.btnBascula1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBascula1.Appearance.Options.UseFont = true;
            this.btnBascula1.Enabled = false;
            this.btnBascula1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBascula1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBascula1.ImageOptions.SvgImage")));
            this.btnBascula1.Location = new System.Drawing.Point(105, 157);
            this.btnBascula1.Name = "btnBascula1";
            this.btnBascula1.Size = new System.Drawing.Size(93, 74);
            this.btnBascula1.TabIndex = 33;
            this.btnBascula1.Text = "Guardar";
            this.btnBascula1.Click += new System.EventHandler(this.btnBascula1_Click);
            // 
            // btnBascula2
            // 
            this.btnBascula2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBascula2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBascula2.Appearance.Options.UseFont = true;
            this.btnBascula2.Enabled = false;
            this.btnBascula2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBascula2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBascula2.ImageOptions.SvgImage")));
            this.btnBascula2.Location = new System.Drawing.Point(446, 157);
            this.btnBascula2.Name = "btnBascula2";
            this.btnBascula2.Size = new System.Drawing.Size(93, 74);
            this.btnBascula2.TabIndex = 34;
            this.btnBascula2.Text = "Guardar";
            this.btnBascula2.Click += new System.EventHandler(this.btnBascula2_Click);
            // 
            // xfrmPesajeIndividualBatchV3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 455);
            this.Controls.Add(this.btnBascula2);
            this.Controls.Add(this.btnBascula1);
            this.Controls.Add(this.lblMP);
            this.Controls.Add(this.lblValorBascula2);
            this.Controls.Add(this.lblBascula2);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.lblInferior);
            this.Controls.Add(this.lblSuperior);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblValorBascula1);
            this.Controls.Add(this.lblBascula1);
            this.Controls.Add(this.lblRequerido);
            this.Controls.Add(this.lblCompletados);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "xfrmPesajeIndividualBatchV3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xfrmPesajeIndividualBatch";
            this.Load += new System.EventHandler(this.xfrmPesajeIndividualBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblValorBascula1;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.LabelControl lblCompletados;
        private DevExpress.XtraEditors.LabelControl lblBascula1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl lblError;
        private DevExpress.XtraEditors.LabelControl lblSuperior;
        private DevExpress.XtraEditors.LabelControl lblInferior;
        private DevExpress.XtraEditors.LabelControl lblRequerido;
        private System.Windows.Forms.BindingSource bindingSource1;
        private dsMicros dsMicros;
        private DevExpress.XtraEditors.LabelControl lblValorBascula2;
        private DevExpress.XtraEditors.LabelControl lblBascula2;
        private DevExpress.XtraEditors.LabelControl lblMP;
        private DevExpress.XtraEditors.SimpleButton btnBascula1;
        private DevExpress.XtraEditors.SimpleButton btnBascula2;
    }
}