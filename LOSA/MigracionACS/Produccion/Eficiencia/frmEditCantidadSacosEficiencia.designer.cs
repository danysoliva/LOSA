
namespace LOSA.MigracionACS.Produccion.Eficiencia
{
    partial class frmEditCantidadSacosEficiencia
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGuardar_ = new System.Windows.Forms.Button();
            this.cmd_Cancelar = new System.Windows.Forms.Button();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(97, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cantidad Actual";
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "";
            this.textEdit1.Location = new System.Drawing.Point(223, 32);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(126, 24);
            this.textEdit1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(97, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(112, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Cantidad Nueva";
            // 
            // cmdGuardar_
            // 
            this.cmdGuardar_.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.cmdGuardar_.Image = global::LOSA.Properties.Resources.save_32x32;
            this.cmdGuardar_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar_.Location = new System.Drawing.Point(135, 114);
            this.cmdGuardar_.Name = "cmdGuardar_";
            this.cmdGuardar_.Size = new System.Drawing.Size(112, 42);
            this.cmdGuardar_.TabIndex = 52;
            this.cmdGuardar_.Text = "Guardar";
            this.cmdGuardar_.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar_.UseVisualStyleBackColor = true;
            this.cmdGuardar_.Click += new System.EventHandler(this.cmdGuardar__Click);
            // 
            // cmd_Cancelar
            // 
            this.cmd_Cancelar.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.cmd_Cancelar.Image = global::LOSA.Properties.Resources.cancel_32x32;
            this.cmd_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_Cancelar.Location = new System.Drawing.Point(253, 114);
            this.cmd_Cancelar.Name = "cmd_Cancelar";
            this.cmd_Cancelar.Size = new System.Drawing.Size(112, 42);
            this.cmd_Cancelar.TabIndex = 53;
            this.cmd_Cancelar.Text = "Cancelar";
            this.cmd_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_Cancelar.UseVisualStyleBackColor = true;
            this.cmd_Cancelar.Click += new System.EventHandler(this.cmd_Cancelar_Click);
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(223, 74);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.spinEdit1.Properties.Appearance.Options.UseFont = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Properties.IsFloatValue = false;
            this.spinEdit1.Properties.Mask.EditMask = "N00";
            this.spinEdit1.Properties.MaxValue = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.spinEdit1.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit1.Size = new System.Drawing.Size(126, 24);
            this.spinEdit1.TabIndex = 54;
            // 
            // frmEditCantidadSacosEficiencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 168);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.cmd_Cancelar);
            this.Controls.Add(this.cmdGuardar_);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmEditCantidadSacosEficiencia";
            this.Text = "Editar Cantidad de Sacos";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button cmdGuardar_;
        private System.Windows.Forms.Button cmd_Cancelar;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
    }
}