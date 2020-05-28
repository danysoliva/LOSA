namespace LOSA.Tools
{
    partial class frmInputBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInputBox));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.lblInstrucciones = new DevExpress.XtraEditors.LabelControl();
            this.txtValue = new DevExpress.XtraEditors.TextEdit();
            this.btnup = new DevExpress.XtraEditors.ButtonEdit();
            this.btndown = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndown.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(312, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(167, 47);
            this.btnAtras.TabIndex = 27;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
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
            this.cmdGuardar.Location = new System.Drawing.Point(1, 12);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(167, 47);
            this.cmdGuardar.TabIndex = 28;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones.Appearance.Options.UseFont = true;
            this.lblInstrucciones.Appearance.Options.UseTextOptions = true;
            this.lblInstrucciones.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblInstrucciones.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblInstrucciones.Location = new System.Drawing.Point(1, 81);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(483, 23);
            this.lblInstrucciones.TabIndex = 29;
            this.lblInstrucciones.Text = "Instrucciones";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(124, 110);
            this.txtValue.Name = "txtValue";
            this.txtValue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Properties.Appearance.Options.UseFont = true;
            this.txtValue.Size = new System.Drawing.Size(182, 32);
            this.txtValue.TabIndex = 30;
            this.txtValue.Click += new System.EventHandler(this.txtValue_Click);
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // btnup
            // 
            this.btnup.Location = new System.Drawing.Point(312, 109);
            this.btnup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnup.Name = "btnup";
            this.btnup.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnup.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnup.Size = new System.Drawing.Size(45, 38);
            this.btnup.TabIndex = 31;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btndown
            // 
            this.btndown.Location = new System.Drawing.Point(362, 109);
            this.btndown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndown.Name = "btndown";
            this.btndown.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndown.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btndown.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btndown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btndown.Size = new System.Drawing.Size(45, 38);
            this.btndown.TabIndex = 32;
            this.btndown.Click += new System.EventHandler(this.btndown_Click);
            // 
            // frmInputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 166);
            this.ControlBox = false;
            this.Controls.Add(this.btndown);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.btnAtras);
            this.Name = "frmInputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInputBox";
            this.Activated += new System.EventHandler(this.frmInputBox_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndown.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        public DevExpress.XtraEditors.LabelControl lblInstrucciones;
        public DevExpress.XtraEditors.TextEdit txtValue;
        private DevExpress.XtraEditors.ButtonEdit btnup;
        private DevExpress.XtraEditors.ButtonEdit btndown;
    }
}