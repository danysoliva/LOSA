namespace LOSA.MigracionACS.Produccion
{
    partial class PRB_Calidad
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRB_Calidad));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblhumedad = new DevExpress.XtraEditors.LabelControl();
            this.lblnoconf = new DevExpress.XtraEditors.LabelControl();
            this.txthumedad = new DevExpress.XtraEditors.TextEdit();
            this.txtnoconf = new DevExpress.XtraEditors.TextEdit();
            this.btnguardar = new DevExpress.XtraEditors.ButtonEdit();
            this.btncancel = new DevExpress.XtraEditors.ButtonEdit();
            this.lbldato = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txthumedad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnoconf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnguardar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncancel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(352, 28);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Seccion donde el cargado de calidad llena los datos de humedad\r\ny producto no con" +
    "forme: ";
            // 
            // lblhumedad
            // 
            this.lblhumedad.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhumedad.Appearance.Options.UseFont = true;
            this.lblhumedad.Location = new System.Drawing.Point(37, 100);
            this.lblhumedad.Name = "lblhumedad";
            this.lblhumedad.Size = new System.Drawing.Size(56, 14);
            this.lblhumedad.TabIndex = 1;
            this.lblhumedad.Text = "Humedad:";
            // 
            // lblnoconf
            // 
            this.lblnoconf.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoconf.Appearance.Options.UseFont = true;
            this.lblnoconf.Location = new System.Drawing.Point(37, 138);
            this.lblnoconf.Name = "lblnoconf";
            this.lblnoconf.Size = new System.Drawing.Size(128, 14);
            this.lblnoconf.TabIndex = 2;
            this.lblnoconf.Text = "Producto no conforme:";
            // 
            // txthumedad
            // 
            this.txthumedad.Location = new System.Drawing.Point(171, 97);
            this.txthumedad.Name = "txthumedad";
            this.txthumedad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthumedad.Properties.Appearance.Options.UseFont = true;
            this.txthumedad.Size = new System.Drawing.Size(180, 20);
            this.txthumedad.TabIndex = 3;
            this.txthumedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthumedad_KeyPress);
            // 
            // txtnoconf
            // 
            this.txtnoconf.Location = new System.Drawing.Point(171, 138);
            this.txtnoconf.Name = "txtnoconf";
            this.txtnoconf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoconf.Properties.Appearance.Options.UseFont = true;
            this.txtnoconf.Size = new System.Drawing.Size(180, 20);
            this.txtnoconf.TabIndex = 4;
            this.txtnoconf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnoconf_KeyPress);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(89, 183);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnguardar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnguardar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnguardar.Size = new System.Drawing.Size(100, 38);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(195, 183);
            this.btncancel.Name = "btncancel";
            this.btncancel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btncancel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btncancel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btncancel.Size = new System.Drawing.Size(100, 38);
            this.btncancel.TabIndex = 6;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // lbldato
            // 
            this.lbldato.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldato.Appearance.Options.UseFont = true;
            this.lbldato.Location = new System.Drawing.Point(12, 58);
            this.lbldato.Name = "lbldato";
            this.lbldato.Size = new System.Drawing.Size(81, 14);
            this.lbldato.TabIndex = 7;
            this.lbldato.Text = "Id de Registro:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(109, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(14, 14);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "ID";
            // 
            // PRB_Calidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 233);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lbldato);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtnoconf);
            this.Controls.Add(this.txthumedad);
            this.Controls.Add(this.lblnoconf);
            this.Controls.Add(this.lblhumedad);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PRB_Calidad";
            this.Text = "Registro de Calidad";
            this.Load += new System.EventHandler(this.PRB_Calidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txthumedad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnoconf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnguardar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncancel.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblhumedad;
        private DevExpress.XtraEditors.LabelControl lblnoconf;
        private DevExpress.XtraEditors.TextEdit txthumedad;
        private DevExpress.XtraEditors.TextEdit txtnoconf;
        private DevExpress.XtraEditors.ButtonEdit btnguardar;
        private DevExpress.XtraEditors.ButtonEdit btncancel;
        private DevExpress.XtraEditors.LabelControl lbldato;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}