namespace LOSA.Mantenimientos
{
    partial class frmMantoOpciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantoOpciones));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmdRegistroLote = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdPresentaciones = new DevExpress.XtraEditors.SimpleButton();
            this.cmdUbicaciones = new DevExpress.XtraEditors.SimpleButton();
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
            this.labelControl3.Location = new System.Drawing.Point(22, 27);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(372, 39);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Mantenimientos ALOSY";
            // 
            // cmdRegistroLote
            // 
            this.cmdRegistroLote.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistroLote.Appearance.Options.UseFont = true;
            this.cmdRegistroLote.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRegistroLote.ImageOptions.Image = global::LOSA.Properties.Resources.edit_table_1_;
            this.cmdRegistroLote.Location = new System.Drawing.Point(12, 98);
            this.cmdRegistroLote.Name = "cmdRegistroLote";
            this.cmdRegistroLote.Size = new System.Drawing.Size(199, 71);
            this.cmdRegistroLote.TabIndex = 33;
            this.cmdRegistroLote.Text = "Bodegas";
            this.cmdRegistroLote.Click += new System.EventHandler(this.cmdRegistroLote_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(411, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(199, 71);
            this.simpleButton2.TabIndex = 34;
            this.simpleButton2.Text = "Home";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // cmdPresentaciones
            // 
            this.cmdPresentaciones.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPresentaciones.Appearance.Options.UseFont = true;
            this.cmdPresentaciones.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdPresentaciones.ImageOptions.Image = global::LOSA.Properties.Resources.edit_table_1_;
            this.cmdPresentaciones.Location = new System.Drawing.Point(12, 276);
            this.cmdPresentaciones.Name = "cmdPresentaciones";
            this.cmdPresentaciones.Size = new System.Drawing.Size(199, 71);
            this.cmdPresentaciones.TabIndex = 35;
            this.cmdPresentaciones.Text = "Presentaciones MP";
            this.cmdPresentaciones.Click += new System.EventHandler(this.cmdPresentaciones_Click);
            // 
            // cmdUbicaciones
            // 
            this.cmdUbicaciones.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUbicaciones.Appearance.Options.UseFont = true;
            this.cmdUbicaciones.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdUbicaciones.ImageOptions.Image = global::LOSA.Properties.Resources.edit_table_1_;
            this.cmdUbicaciones.Location = new System.Drawing.Point(12, 188);
            this.cmdUbicaciones.Name = "cmdUbicaciones";
            this.cmdUbicaciones.Size = new System.Drawing.Size(199, 71);
            this.cmdUbicaciones.TabIndex = 36;
            this.cmdUbicaciones.Text = "Ubicaciones Rack";
            this.cmdUbicaciones.Click += new System.EventHandler(this.cmdUbicaciones_Click);
            // 
            // frmMantoOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 521);
            this.Controls.Add(this.cmdUbicaciones);
            this.Controls.Add(this.cmdPresentaciones);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.cmdRegistroLote);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMantoOpciones";
            this.Text = "frmMantoOpciones";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton cmdRegistroLote;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton cmdPresentaciones;
        private DevExpress.XtraEditors.SimpleButton cmdUbicaciones;
    }
}