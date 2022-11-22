namespace LOSA.MigracionACS.Produccion
{
    partial class PRB_Logistic
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRB_Logistic));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblconf = new DevExpress.XtraEditors.LabelControl();
            this.txtconfor = new DevExpress.XtraEditors.TextEdit();
            this.btn_save = new DevExpress.XtraEditors.ButtonEdit();
            this.btn_close = new DevExpress.XtraEditors.ButtonEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtconfor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(264, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Formulario de recopilacion de datos de Logistica:";
            // 
            // lblconf
            // 
            this.lblconf.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconf.Appearance.Options.UseFont = true;
            this.lblconf.Location = new System.Drawing.Point(12, 78);
            this.lblconf.Name = "lblconf";
            this.lblconf.Size = new System.Drawing.Size(96, 14);
            this.lblconf.TabIndex = 1;
            this.lblconf.Text = "Sacos conformes:";
            // 
            // txtconfor
            // 
            this.txtconfor.Location = new System.Drawing.Point(126, 76);
            this.txtconfor.Name = "txtconfor";
            this.txtconfor.Size = new System.Drawing.Size(150, 20);
            this.txtconfor.TabIndex = 2;
            this.txtconfor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnoconfor_KeyPress);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(47, 141);
            this.btn_save.Name = "btn_save";
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btn_save.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btn_save.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_save.Size = new System.Drawing.Size(100, 38);
            this.btn_save.TabIndex = 3;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(153, 141);
            this.btn_close.Name = "btn_close";
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btn_close.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btn_close.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_close.Size = new System.Drawing.Size(100, 38);
            this.btn_close.TabIndex = 4;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // PRB_Logistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 191);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txtconfor);
            this.Controls.Add(this.lblconf);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PRB_Logistic";
            this.Text = "Llenado Logistica";
            this.Load += new System.EventHandler(this.PRB_Logistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtconfor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblconf;
        private DevExpress.XtraEditors.TextEdit txtconfor;
        private DevExpress.XtraEditors.ButtonEdit btn_save;
        private DevExpress.XtraEditors.ButtonEdit btn_close;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}