
namespace LOSA.Trazabilidad
{
    partial class frmCRUD_PlantasPRV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRUD_PlantasPRV));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.txtProveedor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtComentario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(190, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(124, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Datos de la Planta";
            this.labelControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(22, 88);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(121, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nombre de la Planta";
            this.labelControl2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(149, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(247, 24);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(149, 115);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Properties.Appearance.Options.UseFont = true;
            this.txtDireccion.Size = new System.Drawing.Size(247, 24);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(22, 118);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 17);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Dirección";
            this.labelControl3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(22, 148);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 17);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Comentario";
            this.labelControl4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.Location = new System.Drawing.Point(106, 215);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(142, 51);
            this.cmdGuardar.TabIndex = 4;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            this.cmdGuardar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(254, 215);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(142, 51);
            this.cmdHome.TabIndex = 5;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            this.cmdHome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(149, 56);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Properties.Appearance.Options.UseFont = true;
            this.txtProveedor.Size = new System.Drawing.Size(247, 24);
            this.txtProveedor.TabIndex = 0;
            this.txtProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(22, 59);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 17);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Proveedor";
            this.labelControl5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(149, 148);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(247, 61);
            this.txtComentario.TabIndex = 3;
            this.txtComentario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // frmCRUD_PlantasPRV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 271);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmCRUD_PlantasPRV";
            this.Text = "Plantas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCRUD_PlantasPRV_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.TextEdit txtProveedor;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtComentario;
    }
}