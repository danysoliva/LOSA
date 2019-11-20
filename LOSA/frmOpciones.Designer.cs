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
            this.cmdRegistroLote = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRecepcionMPLogistica = new DevExpress.XtraEditors.SimpleButton();
            this.TabCalidad = new DevExpress.XtraTab.XtraTabPage();
            this.TabAdmin = new DevExpress.XtraTab.XtraTabPage();
            this.btnEstadosRequisiciones = new DevExpress.XtraEditors.SimpleButton();
            this.btnKardexTiposTransacciones = new DevExpress.XtraEditors.SimpleButton();
            this.btnEstadosProgramacionesRequisiciones = new DevExpress.XtraEditors.SimpleButton();
            this.btnTiposPresentaciones = new DevExpress.XtraEditors.SimpleButton();
            this.btnBodegas = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabOpciones)).BeginInit();
            this.tabOpciones.SuspendLayout();
            this.TabMontacarga.SuspendLayout();
            this.TabLogistica.SuspendLayout();
            this.TabAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = global::LOSA.Properties.Resources.wrench;
            this.simpleButton1.Location = new System.Drawing.Point(415, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(199, 71);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Mantenimiento";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdHome
            // 
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(430, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(199, 71);
            this.cmdHome.TabIndex = 6;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.ImageOptions.Image = global::LOSA.Properties.Resources.check_in;
            this.simpleButton2.Location = new System.Drawing.Point(415, 113);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(199, 71);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Recepción MP";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // tabOpciones
            // 
            this.tabOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOpciones.AppearancePage.Header.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOpciones.AppearancePage.Header.Options.UseFont = true;
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
            this.TabMontacarga.Image = ((System.Drawing.Image)(resources.GetObject("TabMontacarga.Image")));
            this.TabMontacarga.Name = "TabMontacarga";
            this.TabMontacarga.PageVisible = false;
            this.TabMontacarga.Size = new System.Drawing.Size(629, 422);
            this.TabMontacarga.Text = "MontaCarga";
            // 
            // TabLogistica
            // 
            this.TabLogistica.Controls.Add(this.cmdRegistroLote);
            this.TabLogistica.Controls.Add(this.simpleButton3);
            this.TabLogistica.Controls.Add(this.cmdRecepcionMPLogistica);
            this.TabLogistica.Image = global::LOSA.Properties.Resources.box;
            this.TabLogistica.Name = "TabLogistica";
            this.TabLogistica.PageVisible = false;
            this.TabLogistica.Size = new System.Drawing.Size(629, 422);
            this.TabLogistica.Text = "Logistica";
            // 
            // cmdRegistroLote
            // 
            this.cmdRegistroLote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRegistroLote.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistroLote.Appearance.Options.UseFont = true;
            this.cmdRegistroLote.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRegistroLote.ImageOptions.Image = global::LOSA.Properties.Resources.edit_table_1_;
            this.cmdRegistroLote.Location = new System.Drawing.Point(424, 137);
            this.cmdRegistroLote.Name = "cmdRegistroLote";
            this.cmdRegistroLote.Size = new System.Drawing.Size(199, 71);
            this.cmdRegistroLote.TabIndex = 10;
            this.cmdRegistroLote.Text = "Registro Lote";
            this.cmdRegistroLote.Click += new System.EventHandler(this.cmdRegistroLote_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton3.ImageOptions.Image = global::LOSA.Properties.Resources.wrench;
            this.simpleButton3.Location = new System.Drawing.Point(424, 48);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(199, 71);
            this.simpleButton3.TabIndex = 8;
            this.simpleButton3.Text = "Mantenimiento";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // cmdRecepcionMPLogistica
            // 
            this.cmdRecepcionMPLogistica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRecepcionMPLogistica.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRecepcionMPLogistica.Appearance.Options.UseFont = true;
            this.cmdRecepcionMPLogistica.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRecepcionMPLogistica.ImageOptions.Image = global::LOSA.Properties.Resources.check_in;
            this.cmdRecepcionMPLogistica.Location = new System.Drawing.Point(424, 223);
            this.cmdRecepcionMPLogistica.Name = "cmdRecepcionMPLogistica";
            this.cmdRecepcionMPLogistica.Size = new System.Drawing.Size(199, 71);
            this.cmdRecepcionMPLogistica.TabIndex = 9;
            this.cmdRecepcionMPLogistica.Text = "Recepción MP";
            this.cmdRecepcionMPLogistica.Visible = false;
            this.cmdRecepcionMPLogistica.Click += new System.EventHandler(this.cmdRecepcionMPLogistica_Click);
            // 
            // TabCalidad
            // 
            this.TabCalidad.Image = global::LOSA.Properties.Resources.medal;
            this.TabCalidad.Name = "TabCalidad";
            this.TabCalidad.PageVisible = false;
            this.TabCalidad.Size = new System.Drawing.Size(629, 422);
            this.TabCalidad.Text = "Calidad";
            // 
            // TabAdmin
            // 
            this.TabAdmin.Controls.Add(this.btnEstadosRequisiciones);
            this.TabAdmin.Controls.Add(this.btnKardexTiposTransacciones);
            this.TabAdmin.Controls.Add(this.btnEstadosProgramacionesRequisiciones);
            this.TabAdmin.Controls.Add(this.btnTiposPresentaciones);
            this.TabAdmin.Controls.Add(this.btnBodegas);
            this.TabAdmin.Image = global::LOSA.Properties.Resources.admin;
            this.TabAdmin.Name = "TabAdmin";
            this.TabAdmin.PageVisible = false;
            this.TabAdmin.Size = new System.Drawing.Size(629, 422);
            this.TabAdmin.Text = "Administrador";
            // 
            // btnEstadosRequisiciones
            // 
            this.btnEstadosRequisiciones.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadosRequisiciones.Appearance.Options.UseFont = true;
            this.btnEstadosRequisiciones.Appearance.Options.UseTextOptions = true;
            this.btnEstadosRequisiciones.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnEstadosRequisiciones.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnEstadosRequisiciones.Location = new System.Drawing.Point(419, 44);
            this.btnEstadosRequisiciones.Name = "btnEstadosRequisiciones";
            this.btnEstadosRequisiciones.Size = new System.Drawing.Size(204, 71);
            this.btnEstadosRequisiciones.TabIndex = 11;
            this.btnEstadosRequisiciones.Text = "Estados de Requisiciones";
            this.btnEstadosRequisiciones.Click += new System.EventHandler(this.BtnEstadosRequisiciones_Click);
            // 
            // btnKardexTiposTransacciones
            // 
            this.btnKardexTiposTransacciones.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnKardexTiposTransacciones.Appearance.Options.UseFont = true;
            this.btnKardexTiposTransacciones.Appearance.Options.UseTextOptions = true;
            this.btnKardexTiposTransacciones.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnKardexTiposTransacciones.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnKardexTiposTransacciones.Location = new System.Drawing.Point(419, 140);
            this.btnKardexTiposTransacciones.Name = "btnKardexTiposTransacciones";
            this.btnKardexTiposTransacciones.Size = new System.Drawing.Size(204, 71);
            this.btnKardexTiposTransacciones.TabIndex = 10;
            this.btnKardexTiposTransacciones.Text = "Tipos de Transacción (Kardex)";
            this.btnKardexTiposTransacciones.Click += new System.EventHandler(this.BtnKardexTiposTransacciones_Click);
            // 
            // btnEstadosProgramacionesRequisiciones
            // 
            this.btnEstadosProgramacionesRequisiciones.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadosProgramacionesRequisiciones.Appearance.Options.UseFont = true;
            this.btnEstadosProgramacionesRequisiciones.Appearance.Options.UseTextOptions = true;
            this.btnEstadosProgramacionesRequisiciones.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnEstadosProgramacionesRequisiciones.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnEstadosProgramacionesRequisiciones.Location = new System.Drawing.Point(419, 239);
            this.btnEstadosProgramacionesRequisiciones.Name = "btnEstadosProgramacionesRequisiciones";
            this.btnEstadosProgramacionesRequisiciones.Size = new System.Drawing.Size(204, 71);
            this.btnEstadosProgramacionesRequisiciones.TabIndex = 9;
            this.btnEstadosProgramacionesRequisiciones.Text = "Estados de Programación de Requisiciones";
            this.btnEstadosProgramacionesRequisiciones.Click += new System.EventHandler(this.BtnEstadosProgramacionesRequisiciones_Click);
            // 
            // btnTiposPresentaciones
            // 
            this.btnTiposPresentaciones.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiposPresentaciones.Appearance.Options.UseFont = true;
            this.btnTiposPresentaciones.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnTiposPresentaciones.Location = new System.Drawing.Point(9, 140);
            this.btnTiposPresentaciones.Name = "btnTiposPresentaciones";
            this.btnTiposPresentaciones.Size = new System.Drawing.Size(204, 71);
            this.btnTiposPresentaciones.TabIndex = 8;
            this.btnTiposPresentaciones.Text = "Tipos Presentación";
            this.btnTiposPresentaciones.Click += new System.EventHandler(this.BtnTiposPresentaciones_Click);
            // 
            // btnBodegas
            // 
            this.btnBodegas.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBodegas.Appearance.Options.UseFont = true;
            this.btnBodegas.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnBodegas.Location = new System.Drawing.Point(9, 44);
            this.btnBodegas.Name = "btnBodegas";
            this.btnBodegas.Size = new System.Drawing.Size(204, 71);
            this.btnBodegas.TabIndex = 5;
            this.btnBodegas.Text = "Bodegas";
            this.btnBodegas.Click += new System.EventHandler(this.BtnBodegas_Click);
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
            this.TabAdmin.ResumeLayout(false);
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
        private DevExpress.XtraEditors.SimpleButton btnBodegas;
        private DevExpress.XtraEditors.SimpleButton btnTiposPresentaciones;
        private DevExpress.XtraEditors.SimpleButton btnEstadosProgramacionesRequisiciones;
        private DevExpress.XtraEditors.SimpleButton btnKardexTiposTransacciones;
        private DevExpress.XtraEditors.SimpleButton btnEstadosRequisiciones;
        private DevExpress.XtraEditors.SimpleButton cmdRegistroLote;
    }
}