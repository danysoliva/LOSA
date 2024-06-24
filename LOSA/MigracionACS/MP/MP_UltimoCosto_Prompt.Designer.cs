namespace ACS.MP
{
    partial class MP_UltimoCosto_Prompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MP_UltimoCosto_Prompt));
            this.chkContabilizado = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_Period = new DevExpress.XtraEditors.LookUpEdit();
            this.btn_Actualizar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancelar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.chkContabilizado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Period.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chkContabilizado
            // 
            this.chkContabilizado.Location = new System.Drawing.Point(42, 81);
            this.chkContabilizado.Name = "chkContabilizado";
            this.chkContabilizado.Properties.Caption = "Contabilizado";
            this.chkContabilizado.Size = new System.Drawing.Size(109, 19);
            this.chkContabilizado.TabIndex = 16;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(42, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Seleccione periodo:";
            // 
            // cmb_Period
            // 
            this.cmb_Period.Location = new System.Drawing.Point(167, 47);
            this.cmb_Period.Name = "cmb_Period";
            this.cmb_Period.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Period.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("period", "Periodo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("fiscalyear", "Año Fiscal")});
            this.cmb_Period.Properties.DisplayMember = "period";
            this.cmb_Period.Properties.ValueMember = "id";
            this.cmb_Period.Size = new System.Drawing.Size(221, 20);
            this.cmb_Period.TabIndex = 14;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Actualizar.ImageOptions.SvgImage")));
            this.btn_Actualizar.Location = new System.Drawing.Point(109, 117);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(104, 33);
            this.btn_Actualizar.TabIndex = 17;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Cancelar.ImageOptions.SvgImage")));
            this.btn_Cancelar.Location = new System.Drawing.Point(219, 117);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(104, 33);
            this.btn_Cancelar.TabIndex = 17;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(95, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(109, 13);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Seleccione periodo:";
            // 
            // MP_UltimoCosto_Prompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 154);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.chkContabilizado);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmb_Period);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MP_UltimoCosto_Prompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Ultimo Costo Promedio";
            ((System.ComponentModel.ISupportInitialize)(this.chkContabilizado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Period.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chkContabilizado;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cmb_Period;
        private DevExpress.XtraEditors.SimpleButton btn_Actualizar;
        private DevExpress.XtraEditors.SimpleButton btn_Cancelar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}