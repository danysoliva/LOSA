
namespace LOSA.MigracionACS.RRHH.Liquidaciones
{
    partial class frmConfDeduccionesOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfDeduccionesOP));
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDeduccion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.tsAtributo = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.tsAtributo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(155, 78);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(238, 26);
            this.txtDescripcion.TabIndex = 9;
            // 
            // lblDeduccion
            // 
            this.lblDeduccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDeduccion.AutoSize = true;
            this.lblDeduccion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeduccion.Location = new System.Drawing.Point(176, 25);
            this.lblDeduccion.Name = "lblDeduccion";
            this.lblDeduccion.Size = new System.Drawing.Size(142, 19);
            this.lblDeduccion.TabIndex = 8;
            this.lblDeduccion.Text = "Crear Deduccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descripcion";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdGuardar.ImageOptions.Image = global::LOSA.Properties.Resources.saveChanges_32x32;
            this.cmdGuardar.Location = new System.Drawing.Point(119, 180);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(91, 43);
            this.cmdGuardar.TabIndex = 106;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.ToolTip = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdClose.ImageOptions.SvgImage")));
            this.cmdClose.Location = new System.Drawing.Point(263, 180);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(91, 43);
            this.cmdClose.TabIndex = 107;
            this.cmdClose.Text = "Cerrar";
            this.cmdClose.ToolTip = "Guardar";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // tsAtributo
            // 
            this.tsAtributo.EditValue = true;
            this.tsAtributo.Location = new System.Drawing.Point(155, 138);
            this.tsAtributo.Name = "tsAtributo";
            this.tsAtributo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsAtributo.Properties.Appearance.Options.UseFont = true;
            this.tsAtributo.Properties.OffText = "Inhabilitado";
            this.tsAtributo.Properties.OnText = "Habilitado";
            this.tsAtributo.Size = new System.Drawing.Size(163, 26);
            this.tsAtributo.TabIndex = 108;
            // 
            // frmConfDeduccionesOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 249);
            this.Controls.Add(this.tsAtributo);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDeduccion);
            this.Controls.Add(this.label1);
            this.Name = "frmConfDeduccionesOP";
            ((System.ComponentModel.ISupportInitialize)(this.tsAtributo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDeduccion;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.ToggleSwitch tsAtributo;
    }
}