
namespace LOSA.RecepcionMP
{
    partial class frmEditLoteExterno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditLoteExterno));
            this.txtLoteOld = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNuevoLote = new DevExpress.XtraEditors.TextEdit();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoteOld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuevoLote.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLoteOld
            // 
            this.txtLoteOld.Enabled = false;
            this.txtLoteOld.Location = new System.Drawing.Point(98, 65);
            this.txtLoteOld.Name = "txtLoteOld";
            this.txtLoteOld.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtLoteOld.Properties.Appearance.Options.UseFont = true;
            this.txtLoteOld.Size = new System.Drawing.Size(278, 26);
            this.txtLoteOld.TabIndex = 23;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 68);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 20);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Lote Actual:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(145, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 25);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Editar Lote";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 113);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 20);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Nuevo Lote:";
            // 
            // txtNuevoLote
            // 
            this.txtNuevoLote.Location = new System.Drawing.Point(98, 110);
            this.txtNuevoLote.Name = "txtNuevoLote";
            this.txtNuevoLote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtNuevoLote.Properties.Appearance.Options.UseFont = true;
            this.txtNuevoLote.Size = new System.Drawing.Size(278, 26);
            this.txtNuevoLote.TabIndex = 27;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ImageOptions.Image = global::LOSA.Properties.Resources.floppy_disk32px1;
            this.cmdGuardar.Location = new System.Drawing.Point(38, 146);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(153, 49);
            this.cmdGuardar.TabIndex = 29;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(197, 146);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(153, 49);
            this.simpleButton1.TabIndex = 28;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmEditLoteExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 207);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtNuevoLote);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtLoteOld);
            this.Name = "frmEditLoteExterno";
            this.ShowIcon = false;
            this.Activated += new System.EventHandler(this.frmEditLoteExterno_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.txtLoteOld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuevoLote.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtLoteOld;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNuevoLote;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
    }
}