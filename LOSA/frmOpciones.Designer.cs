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
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.tabOpciones = new DevExpress.XtraTab.XtraTabControl();
            this.TabMontacarga = new DevExpress.XtraTab.XtraTabPage();
            this.cmdPT = new DevExpress.XtraEditors.SimpleButton();
            this.cmdMP = new DevExpress.XtraEditors.SimpleButton();
            this.TabLogistica = new DevExpress.XtraTab.XtraTabPage();
            this.cmdRequisiciones_ = new DevExpress.XtraEditors.SimpleButton();
            this.btnAjustesKardex = new DevExpress.XtraEditors.SimpleButton();
            this.btnDevolciones = new DevExpress.XtraEditors.SimpleButton();
            this.cmdOrdenesFabricacion = new DevExpress.XtraEditors.SimpleButton();
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tabOpciones)).BeginInit();
            this.tabOpciones.SuspendLayout();
            this.TabMontacarga.SuspendLayout();
            this.TabLogistica.SuspendLayout();
            this.TabAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.TabMontacarga.Controls.Add(this.labelControl2);
            this.TabMontacarga.Controls.Add(this.labelControl1);
            this.TabMontacarga.Controls.Add(this.cmdPT);
            this.TabMontacarga.Controls.Add(this.cmdMP);
            this.TabMontacarga.Image = ((System.Drawing.Image)(resources.GetObject("TabMontacarga.Image")));
            this.TabMontacarga.Name = "TabMontacarga";
            this.TabMontacarga.PageVisible = false;
            this.TabMontacarga.Size = new System.Drawing.Size(629, 422);
            this.TabMontacarga.Text = "MontaCarga";
            // 
            // cmdPT
            // 
            this.cmdPT.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPT.Appearance.Options.UseFont = true;
            this.cmdPT.Appearance.Options.UseTextOptions = true;
            this.cmdPT.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmdPT.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.cmdPT.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.cmdPT.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdPT.ImageOptions.Image = global::LOSA.Properties.Resources.hapag_4_icon;
            this.cmdPT.Location = new System.Drawing.Point(331, 29);
            this.cmdPT.Name = "cmdPT";
            this.cmdPT.Size = new System.Drawing.Size(274, 331);
            this.cmdPT.TabIndex = 11;
            this.cmdPT.Click += new System.EventHandler(this.cmdPT_Click);
            // 
            // cmdMP
            // 
            this.cmdMP.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMP.Appearance.Options.UseFont = true;
            this.cmdMP.Appearance.Options.UseTextOptions = true;
            this.cmdMP.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmdMP.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.cmdMP.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.cmdMP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdMP.ImageOptions.Image = global::LOSA.Properties.Resources.Containers_icon;
            this.cmdMP.Location = new System.Drawing.Point(33, 29);
            this.cmdMP.Name = "cmdMP";
            this.cmdMP.Size = new System.Drawing.Size(274, 331);
            this.cmdMP.TabIndex = 10;
            this.cmdMP.Click += new System.EventHandler(this.cmdMP_Click);
            // 
            // TabLogistica
            // 
            this.TabLogistica.Controls.Add(this.cmdRequisiciones_);
            this.TabLogistica.Controls.Add(this.btnAjustesKardex);
            this.TabLogistica.Controls.Add(this.btnDevolciones);
            this.TabLogistica.Controls.Add(this.cmdOrdenesFabricacion);
            this.TabLogistica.Controls.Add(this.cmdRegistroLote);
            this.TabLogistica.Controls.Add(this.simpleButton3);
            this.TabLogistica.Controls.Add(this.cmdRecepcionMPLogistica);
            this.TabLogistica.Image = global::LOSA.Properties.Resources.box;
            this.TabLogistica.Name = "TabLogistica";
            this.TabLogistica.PageVisible = false;
            this.TabLogistica.Size = new System.Drawing.Size(629, 422);
            this.TabLogistica.Text = "Logistica";
            // 
            // cmdRequisiciones_
            // 
            this.cmdRequisiciones_.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRequisiciones_.Appearance.Options.UseFont = true;
            this.cmdRequisiciones_.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRequisiciones_.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRequisiciones_.ImageOptions.Image")));
            this.cmdRequisiciones_.Location = new System.Drawing.Point(9, 258);
            this.cmdRequisiciones_.Name = "cmdRequisiciones_";
            this.cmdRequisiciones_.Size = new System.Drawing.Size(199, 71);
            this.cmdRequisiciones_.TabIndex = 14;
            this.cmdRequisiciones_.Text = "Requisiciones";
            this.cmdRequisiciones_.Click += new System.EventHandler(this.cmdRequisiciones__Click);
            // 
            // btnAjustesKardex
            // 
            this.btnAjustesKardex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjustesKardex.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustesKardex.Appearance.Options.UseFont = true;
            this.btnAjustesKardex.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAjustesKardex.Location = new System.Drawing.Point(424, 96);
            this.btnAjustesKardex.Name = "btnAjustesKardex";
            this.btnAjustesKardex.Size = new System.Drawing.Size(199, 71);
            this.btnAjustesKardex.TabIndex = 13;
            this.btnAjustesKardex.Text = "Ajustes Kardex";
            this.btnAjustesKardex.Click += new System.EventHandler(this.BtnAjustesKardex_Click);
            // 
            // btnDevolciones
            // 
            this.btnDevolciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDevolciones.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolciones.Appearance.Options.UseFont = true;
            this.btnDevolciones.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnDevolciones.Location = new System.Drawing.Point(424, 177);
            this.btnDevolciones.Name = "btnDevolciones";
            this.btnDevolciones.Size = new System.Drawing.Size(199, 71);
            this.btnDevolciones.TabIndex = 12;
            this.btnDevolciones.Text = "Devoluciones ";
            this.btnDevolciones.Click += new System.EventHandler(this.BtnDevolciones_Click);
            // 
            // cmdOrdenesFabricacion
            // 
            this.cmdOrdenesFabricacion.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOrdenesFabricacion.Appearance.Options.UseFont = true;
            this.cmdOrdenesFabricacion.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdOrdenesFabricacion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdOrdenesFabricacion.ImageOptions.Image")));
            this.cmdOrdenesFabricacion.Location = new System.Drawing.Point(9, 177);
            this.cmdOrdenesFabricacion.Name = "cmdOrdenesFabricacion";
            this.cmdOrdenesFabricacion.Size = new System.Drawing.Size(199, 71);
            this.cmdOrdenesFabricacion.TabIndex = 11;
            this.cmdOrdenesFabricacion.Text = "Ordenes de\r\nFabricación";
            this.cmdOrdenesFabricacion.Click += new System.EventHandler(this.cmdProgramaRequisiciones_Click);
            // 
            // cmdRegistroLote
            // 
            this.cmdRegistroLote.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistroLote.Appearance.Options.UseFont = true;
            this.cmdRegistroLote.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRegistroLote.ImageOptions.Image = global::LOSA.Properties.Resources.edit_table_1_;
            this.cmdRegistroLote.Location = new System.Drawing.Point(9, 15);
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
            this.simpleButton3.Location = new System.Drawing.Point(424, 15);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(199, 71);
            this.simpleButton3.TabIndex = 8;
            this.simpleButton3.Text = "Mantenimiento";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // cmdRecepcionMPLogistica
            // 
            this.cmdRecepcionMPLogistica.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRecepcionMPLogistica.Appearance.Options.UseFont = true;
            this.cmdRecepcionMPLogistica.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRecepcionMPLogistica.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRecepcionMPLogistica.ImageOptions.Image")));
            this.cmdRecepcionMPLogistica.Location = new System.Drawing.Point(9, 96);
            this.cmdRecepcionMPLogistica.Name = "cmdRecepcionMPLogistica";
            this.cmdRecepcionMPLogistica.Size = new System.Drawing.Size(199, 71);
            this.cmdRecepcionMPLogistica.TabIndex = 9;
            this.cmdRecepcionMPLogistica.Text = "Ver Tarimas";
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
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(95, 366);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(148, 29);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Materia Prima";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(367, 366);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(214, 29);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Producto Terminado";
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
            this.TabMontacarga.PerformLayout();
            this.TabLogistica.ResumeLayout(false);
            this.TabAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton cmdHome;
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
        private DevExpress.XtraEditors.SimpleButton cmdOrdenesFabricacion;
        private DevExpress.XtraEditors.SimpleButton btnDevolciones;
        private DevExpress.XtraEditors.SimpleButton btnAjustesKardex;
        private DevExpress.XtraEditors.SimpleButton cmdRequisiciones_;
        private DevExpress.XtraEditors.SimpleButton cmdMP;
        private DevExpress.XtraEditors.SimpleButton cmdPT;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}