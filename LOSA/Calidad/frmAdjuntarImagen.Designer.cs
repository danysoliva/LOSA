
namespace LOSA.Calidad
{
    partial class frmAdjuntarImagen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdjuntarImagen));
            this.peImagen = new DevExpress.XtraEditors.PictureEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpload = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuscarArchivo = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilePath = new DevExpress.XtraEditors.TextEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.peImagen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilePath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // peImagen
            // 
            this.peImagen.Location = new System.Drawing.Point(98, 98);
            this.peImagen.Name = "peImagen";
            this.peImagen.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peImagen.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peImagen.Size = new System.Drawing.Size(328, 162);
            this.peImagen.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(290, 299);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 42);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.ImageOptions.Image")));
            this.btnUpload.Location = new System.Drawing.Point(148, 299);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(119, 42);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Subir Muestra";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnBuscarArchivo
            // 
            this.btnBuscarArchivo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarArchivo.ImageOptions.Image")));
            this.btnBuscarArchivo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnBuscarArchivo.Location = new System.Drawing.Point(84, 48);
            this.btnBuscarArchivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarArchivo.Name = "btnBuscarArchivo";
            this.btnBuscarArchivo.Size = new System.Drawing.Size(70, 27);
            this.btnBuscarArchivo.TabIndex = 9;
            this.btnBuscarArchivo.Click += new System.EventHandler(this.btnBuscarArchivo_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(174, 51);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Properties.Appearance.Options.UseFont = true;
            this.txtFilePath.Properties.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(267, 24);
            this.txtFilePath.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAdjuntarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 373);
            this.Controls.Add(this.btnBuscarArchivo);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.peImagen);
            this.Name = "frmAdjuntarImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdjuntarImagen";
            ((System.ComponentModel.ISupportInitialize)(this.peImagen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilePath.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit peImagen;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnUpload;
        private DevExpress.XtraEditors.SimpleButton btnBuscarArchivo;
        private DevExpress.XtraEditors.TextEdit txtFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}