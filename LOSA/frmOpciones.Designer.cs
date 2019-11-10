namespace LOSA
{
    partial class frmOpciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpciones));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.tabOpciones = new DevExpress.XtraTab.XtraTabControl();
            this.TabMontacarga = new DevExpress.XtraTab.XtraTabPage();
            this.TabLogistica = new DevExpress.XtraTab.XtraTabPage();
            this.TabCalidad = new DevExpress.XtraTab.XtraTabPage();
            this.TabAdmin = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRecepcionMPLogistica = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabOpciones)).BeginInit();
            this.tabOpciones.SuspendLayout();
            this.TabMontacarga.SuspendLayout();
            this.TabLogistica.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.Location = new System.Drawing.Point(415, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(199, 71);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Mantenimiento";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdHome
            // 
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdHome.ImageOptions.Image")));
            this.cmdHome.Location = new System.Drawing.Point(430, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(199, 71);
            this.cmdHome.TabIndex = 6;
            this.cmdHome.Text = "Home";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.Location = new System.Drawing.Point(415, 113);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(199, 71);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Recepción MP";
            // 
            // tabOpciones
            // 
            this.tabOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOpciones.Location = new System.Drawing.Point(2, 89);
            this.tabOpciones.Name = "tabOpciones";
            this.tabOpciones.SelectedTabPage = this.TabMontacarga;
            this.tabOpciones.Size = new System.Drawing.Size(635, 469);
            this.tabOpciones.TabIndex = 8;
            this.tabOpciones.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabMontacarga,
            this.TabLogistica,
            this.TabCalidad,
            this.TabAdmin});
            // 
            // TabMontacarga
            // 
            this.TabMontacarga.Controls.Add(this.simpleButton1);
            this.TabMontacarga.Controls.Add(this.simpleButton2);
            this.TabMontacarga.Name = "TabMontacarga";
            this.TabMontacarga.PageVisible = false;
            this.TabMontacarga.Size = new System.Drawing.Size(629, 441);
            this.TabMontacarga.Text = "MontaCarga";
            // 
            // TabLogistica
            // 
            this.TabLogistica.Controls.Add(this.simpleButton3);
            this.TabLogistica.Controls.Add(this.cmdRecepcionMPLogistica);
            this.TabLogistica.Name = "TabLogistica";
            this.TabLogistica.PageVisible = false;
            this.TabLogistica.Size = new System.Drawing.Size(629, 441);
            this.TabLogistica.Text = "Logistica";
            // 
            // TabCalidad
            // 
            this.TabCalidad.Name = "TabCalidad";
            this.TabCalidad.PageVisible = false;
            this.TabCalidad.Size = new System.Drawing.Size(629, 441);
            this.TabCalidad.Text = "Calidad";
            // 
            // TabAdmin
            // 
            this.TabAdmin.Name = "TabAdmin";
            this.TabAdmin.PageVisible = false;
            this.TabAdmin.Size = new System.Drawing.Size(629, 441);
            this.TabAdmin.Text = "Administrador";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton3.Location = new System.Drawing.Point(205, 41);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(199, 71);
            this.simpleButton3.TabIndex = 8;
            this.simpleButton3.Text = "Mantenimiento";
            // 
            // cmdRecepcionMPLogistica
            // 
            this.cmdRecepcionMPLogistica.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRecepcionMPLogistica.Appearance.Options.UseFont = true;
            this.cmdRecepcionMPLogistica.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRecepcionMPLogistica.Location = new System.Drawing.Point(205, 131);
            this.cmdRecepcionMPLogistica.Name = "cmdRecepcionMPLogistica";
            this.cmdRecepcionMPLogistica.Size = new System.Drawing.Size(199, 71);
            this.cmdRecepcionMPLogistica.TabIndex = 9;
            this.cmdRecepcionMPLogistica.Text = "Recepción MP";
            this.cmdRecepcionMPLogistica.Click += new System.EventHandler(this.cmdRecepcionMPLogistica_Click);
            // 
            // frmOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.tabOpciones);
            this.Controls.Add(this.cmdHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOpciones";
            this.Text = "frmOpciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tabOpciones)).EndInit();
            this.tabOpciones.ResumeLayout(false);
            this.TabMontacarga.ResumeLayout(false);
            this.TabLogistica.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraTab.XtraTabControl tabOpciones;
        private DevExpress.XtraTab.XtraTabPage TabMontacarga;
        private DevExpress.XtraTab.XtraTabPage TabLogistica;
        private DevExpress.XtraTab.XtraTabPage TabCalidad;
        private DevExpress.XtraTab.XtraTabPage TabAdmin;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton cmdRecepcionMPLogistica;
    }
}