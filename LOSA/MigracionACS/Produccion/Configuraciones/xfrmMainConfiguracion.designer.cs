
namespace LOSA.MigracionACS.Produccion.Configuraciones
{
    partial class xfrmMainConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmMainConfiguracion));
            this.btnMaquinaDado = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnTipoMaquinaDado = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnMaquinaDado
            // 
            this.btnMaquinaDado.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaquinaDado.Appearance.Options.UseFont = true;
            this.btnMaquinaDado.Appearance.Options.UseTextOptions = true;
            this.btnMaquinaDado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnMaquinaDado.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnMaquinaDado.Location = new System.Drawing.Point(172, 137);
            this.btnMaquinaDado.Name = "btnMaquinaDado";
            this.btnMaquinaDado.Size = new System.Drawing.Size(132, 51);
            this.btnMaquinaDado.TabIndex = 0;
            this.btnMaquinaDado.Text = "Máquinas de Dado";
            this.btnMaquinaDado.Click += new System.EventHandler(this.btnMaquinaDado_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(142, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(403, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Configuraciones de Gestión de Producción";
            // 
            // btnTipoMaquinaDado
            // 
            this.btnTipoMaquinaDado.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoMaquinaDado.Appearance.Options.UseFont = true;
            this.btnTipoMaquinaDado.Appearance.Options.UseTextOptions = true;
            this.btnTipoMaquinaDado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnTipoMaquinaDado.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnTipoMaquinaDado.Location = new System.Drawing.Point(382, 137);
            this.btnTipoMaquinaDado.Name = "btnTipoMaquinaDado";
            this.btnTipoMaquinaDado.Size = new System.Drawing.Size(132, 51);
            this.btnTipoMaquinaDado.TabIndex = 2;
            this.btnTipoMaquinaDado.Text = "Tipo de Máquina";
            this.btnTipoMaquinaDado.Click += new System.EventHandler(this.btnTipoMaquinaDado_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Appearance.Options.UseFont = true;
            this.btnSalir.Appearance.Options.UseTextOptions = true;
            this.btnSalir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnSalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSalir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnSalir.Location = new System.Drawing.Point(589, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 51);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // xfrmMainConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 303);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnTipoMaquinaDado);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnMaquinaDado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfrmMainConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuraciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnMaquinaDado;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTipoMaquinaDado;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
    }
}