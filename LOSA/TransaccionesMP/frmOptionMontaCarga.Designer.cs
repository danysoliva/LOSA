namespace LOSA.TransaccionesMP
{
    partial class frmOptionMontaCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptionMontaCarga));
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.tabOpciones = new DevExpress.XtraTab.XtraTabControl();
            this.TabMateriaPrima = new DevExpress.XtraTab.XtraTabPage();
            this.cmdRequisiciones = new DevExpress.XtraEditors.SimpleButton();
            this.btnCambiarUbicacion = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdEntradaMP = new DevExpress.XtraEditors.SimpleButton();
            this.TabProductoTerminado = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabOpciones)).BeginInit();
            this.tabOpciones.SuspendLayout();
            this.TabMateriaPrima.SuspendLayout();
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
            this.cmdHome.Location = new System.Drawing.Point(436, 4);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(199, 71);
            this.cmdHome.TabIndex = 7;
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
            this.tabOpciones.Location = new System.Drawing.Point(4, 90);
            this.tabOpciones.Name = "tabOpciones";
            this.tabOpciones.SelectedTabPage = this.TabMateriaPrima;
            this.tabOpciones.Size = new System.Drawing.Size(635, 469);
            this.tabOpciones.TabIndex = 9;
            this.tabOpciones.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabMateriaPrima,
            this.TabProductoTerminado});
            // 
            // TabMateriaPrima
            // 
            this.TabMateriaPrima.Controls.Add(this.cmdRequisiciones);
            this.TabMateriaPrima.Controls.Add(this.btnCambiarUbicacion);
            this.TabMateriaPrima.Controls.Add(this.simpleButton1);
            this.TabMateriaPrima.Controls.Add(this.cmdEntradaMP);
            this.TabMateriaPrima.Image = ((System.Drawing.Image)(resources.GetObject("TabMateriaPrima.Image")));
            this.TabMateriaPrima.Name = "TabMateriaPrima";
            this.TabMateriaPrima.PageVisible = false;
            this.TabMateriaPrima.Size = new System.Drawing.Size(629, 422);
            this.TabMateriaPrima.Text = "Materia Prima";
            // 
            // cmdRequisiciones
            // 
            this.cmdRequisiciones.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRequisiciones.Appearance.Options.UseFont = true;
            this.cmdRequisiciones.Appearance.Options.UseTextOptions = true;
            this.cmdRequisiciones.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.cmdRequisiciones.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRequisiciones.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRequisiciones.ImageOptions.Image")));
            this.cmdRequisiciones.Location = new System.Drawing.Point(7, 214);
            this.cmdRequisiciones.Name = "cmdRequisiciones";
            this.cmdRequisiciones.Size = new System.Drawing.Size(199, 71);
            this.cmdRequisiciones.TabIndex = 9;
            this.cmdRequisiciones.Text = "Requisiciones";
            this.cmdRequisiciones.Click += new System.EventHandler(this.cmdRequisiciones_Click);
            // 
            // btnCambiarUbicacion
            // 
            this.btnCambiarUbicacion.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarUbicacion.Appearance.Options.UseFont = true;
            this.btnCambiarUbicacion.Appearance.Options.UseTextOptions = true;
            this.btnCambiarUbicacion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnCambiarUbicacion.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCambiarUbicacion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiarUbicacion.ImageOptions.Image")));
            this.btnCambiarUbicacion.Location = new System.Drawing.Point(7, 127);
            this.btnCambiarUbicacion.Name = "btnCambiarUbicacion";
            this.btnCambiarUbicacion.Size = new System.Drawing.Size(199, 71);
            this.btnCambiarUbicacion.TabIndex = 8;
            this.btnCambiarUbicacion.Text = "Cambiar Ubicacion";
            this.btnCambiarUbicacion.Click += new System.EventHandler(this.btnCambiarUbicacion_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = global::LOSA.Properties.Resources.wrench;
            this.simpleButton1.Location = new System.Drawing.Point(7, 300);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(199, 71);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Mantenimiento";
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdEntradaMP
            // 
            this.cmdEntradaMP.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEntradaMP.Appearance.Options.UseFont = true;
            this.cmdEntradaMP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdEntradaMP.ImageOptions.Image = global::LOSA.Properties.Resources.check_in;
            this.cmdEntradaMP.Location = new System.Drawing.Point(7, 40);
            this.cmdEntradaMP.Name = "cmdEntradaMP";
            this.cmdEntradaMP.Size = new System.Drawing.Size(199, 71);
            this.cmdEntradaMP.TabIndex = 7;
            this.cmdEntradaMP.Text = "Ingreso MP";
            this.cmdEntradaMP.Click += new System.EventHandler(this.cmdEntradaMP_Click);
            // 
            // TabProductoTerminado
            // 
            this.TabProductoTerminado.Image = global::LOSA.Properties.Resources.Container_icon32px;
            this.TabProductoTerminado.Name = "TabProductoTerminado";
            this.TabProductoTerminado.PageVisible = false;
            this.TabProductoTerminado.Size = new System.Drawing.Size(629, 422);
            this.TabProductoTerminado.Text = "Producto Terminado";
            // 
            // frmOptionMontaCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.tabOpciones);
            this.Controls.Add(this.cmdHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOptionMontaCarga";
            this.Text = "frmOptionMontaCarga";
            ((System.ComponentModel.ISupportInitialize)(this.tabOpciones)).EndInit();
            this.tabOpciones.ResumeLayout(false);
            this.TabMateriaPrima.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraTab.XtraTabControl tabOpciones;
        private DevExpress.XtraTab.XtraTabPage TabMateriaPrima;
        private DevExpress.XtraEditors.SimpleButton cmdRequisiciones;
        private DevExpress.XtraEditors.SimpleButton btnCambiarUbicacion;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton cmdEntradaMP;
        private DevExpress.XtraTab.XtraTabPage TabProductoTerminado;
    }
}