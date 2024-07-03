
namespace LOSA.Presupuesto
{
    partial class frmPresupuestoDetalleLineaOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresupuestoDetalleLineaOP));
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcionH = new DevExpress.XtraEditors.TextEdit();
            this.comboAnio = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescrPresupuesto = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonto = new DevExpress.XtraEditors.SpinEdit();
            this.txtDepartamento = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboAnio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescrPresupuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartamento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(407, 241);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 42);
            this.btnClose.TabIndex = 67;
            this.btnClose.Text = "Cancelar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSave.ImageOptions.Image = global::LOSA.Properties.Resources.save_24x24;
            this.btnSave.Location = new System.Drawing.Point(222, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 42);
            this.btnSave.TabIndex = 66;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(217, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 25);
            this.label6.TabIndex = 68;
            this.label6.Text = "Agregar Detalle Presupuesto";
            // 
            // txtDescripcionH
            // 
            this.txtDescripcionH.Enabled = false;
            this.txtDescripcionH.Location = new System.Drawing.Point(288, 80);
            this.txtDescripcionH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionH.Name = "txtDescripcionH";
            this.txtDescripcionH.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionH.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcionH.Size = new System.Drawing.Size(319, 26);
            this.txtDescripcionH.TabIndex = 72;
            // 
            // comboAnio
            // 
            this.comboAnio.Enabled = false;
            this.comboAnio.Location = new System.Drawing.Point(288, 46);
            this.comboAnio.Name = "comboAnio";
            this.comboAnio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboAnio.Properties.Appearance.Options.UseFont = true;
            this.comboAnio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboAnio.Properties.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.comboAnio.Size = new System.Drawing.Size(172, 26);
            this.comboAnio.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 19);
            this.label2.TabIndex = 70;
            this.label2.Text = "Comentario________________________:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 19);
            this.label1.TabIndex = 69;
            this.label1.Text = "Año______________________________________:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 19);
            this.label3.TabIndex = 74;
            this.label3.Text = "Departamento___________________:";
            // 
            // txtDescrPresupuesto
            // 
            this.txtDescrPresupuesto.Location = new System.Drawing.Point(288, 145);
            this.txtDescrPresupuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescrPresupuesto.Name = "txtDescrPresupuesto";
            this.txtDescrPresupuesto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrPresupuesto.Properties.Appearance.Options.UseFont = true;
            this.txtDescrPresupuesto.Size = new System.Drawing.Size(319, 26);
            this.txtDescrPresupuesto.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 19);
            this.label4.TabIndex = 75;
            this.label4.Text = "Descripcion del Presupuesto__:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 19);
            this.label5.TabIndex = 77;
            this.label5.Text = "Monto___________________________:";
            // 
            // txtMonto
            // 
            this.txtMonto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMonto.Location = new System.Drawing.Point(288, 177);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtMonto.Properties.Appearance.Options.UseFont = true;
            this.txtMonto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMonto.Size = new System.Drawing.Size(172, 26);
            this.txtMonto.TabIndex = 78;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Enabled = false;
            this.txtDepartamento.Location = new System.Drawing.Point(288, 113);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Properties.Appearance.Options.UseFont = true;
            this.txtDepartamento.Size = new System.Drawing.Size(227, 26);
            this.txtDepartamento.TabIndex = 79;
            // 
            // frmPresupuestoDetalleLineaOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 322);
            this.ControlBox = false;
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescrPresupuesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcionH);
            this.Controls.Add(this.comboAnio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Name = "frmPresupuestoDetalleLineaOP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboAnio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescrPresupuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartamento.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtDescripcionH;
        private DevExpress.XtraEditors.ComboBoxEdit comboAnio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtDescrPresupuesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SpinEdit txtMonto;
        private DevExpress.XtraEditors.TextEdit txtDepartamento;
    }
}