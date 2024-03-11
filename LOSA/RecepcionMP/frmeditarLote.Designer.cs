namespace LOSA.RecepcionMP
{
    partial class frmeditarLote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmeditarLote));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtingreso = new DevExpress.XtraEditors.TextEdit();
            this.txtlote = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtmp = new DevExpress.XtraEditors.TextEdit();
            this.btnpick = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtingreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(195, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(283, 36);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "Editar Lote";
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
            this.btnAtras.Location = new System.Drawing.Point(539, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(153, 47);
            this.btnAtras.TabIndex = 34;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 93);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(142, 21);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Numero de Ingreso: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(26, 200);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 21);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Lote";
            // 
            // txtingreso
            // 
            this.txtingreso.Enabled = false;
            this.txtingreso.Location = new System.Drawing.Point(195, 90);
            this.txtingreso.Name = "txtingreso";
            this.txtingreso.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtingreso.Properties.Appearance.Options.UseFont = true;
            this.txtingreso.Size = new System.Drawing.Size(100, 28);
            this.txtingreso.TabIndex = 37;
            // 
            // txtlote
            // 
            this.txtlote.Location = new System.Drawing.Point(195, 193);
            this.txtlote.Name = "txtlote";
            this.txtlote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtlote.Properties.Appearance.Options.UseFont = true;
            this.txtlote.Size = new System.Drawing.Size(364, 28);
            this.txtlote.TabIndex = 38;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(26, 276);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(102, 21);
            this.labelControl4.TabIndex = 39;
            this.labelControl4.Text = "Materia Prima ";
            // 
            // txtmp
            // 
            this.txtmp.Location = new System.Drawing.Point(195, 269);
            this.txtmp.Name = "txtmp";
            this.txtmp.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtmp.Properties.Appearance.Options.UseFont = true;
            this.txtmp.Size = new System.Drawing.Size(364, 28);
            this.txtmp.TabIndex = 40;
            // 
            // btnpick
            // 
            this.btnpick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnpick.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.btnpick.Location = new System.Drawing.Point(579, 263);
            this.btnpick.Name = "btnpick";
            this.btnpick.Size = new System.Drawing.Size(45, 43);
            this.btnpick.TabIndex = 41;
            this.btnpick.Click += new System.EventHandler(this.btnpick_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Appearance.Options.UseBackColor = true;
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAgregar.ImageOptions.Image = global::LOSA.Properties.Resources.plus;
            this.btnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAgregar.Location = new System.Drawing.Point(12, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(144, 47);
            this.btnAgregar.TabIndex = 42;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmeditarLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 483);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnpick);
            this.Controls.Add(this.txtmp);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtlote);
            this.Controls.Add(this.txtingreso);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmeditarLote";
            this.Text = "frmeditarLote";
            ((System.ComponentModel.ISupportInitialize)(this.txtingreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmp.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtingreso;
        private DevExpress.XtraEditors.TextEdit txtlote;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtmp;
        private DevExpress.XtraEditors.SimpleButton btnpick;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
    }
}