namespace LOSA.Reportes
{
    partial class frmreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmreport));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.btnTrazabilidad = new DevExpress.XtraEditors.SimpleButton();
            this.btnCantidadMP = new DevExpress.XtraEditors.SimpleButton();
            this.btnLotes = new DevExpress.XtraEditors.SimpleButton();
            this.btnLotesXMP = new DevExpress.XtraEditors.SimpleButton();
            this.btnLotesPorProveedor = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRegistroLote = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSalidasMP = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(22, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(680, 50);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Reportes";
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
            this.cmdHome.Location = new System.Drawing.Point(476, 11);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(227, 71);
            this.cmdHome.TabIndex = 7;
            this.cmdHome.Text = "Atras";
            this.cmdHome.ClientSizeChanged += new System.EventHandler(this.cmdHome_ClientSizeChanged);
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // btnTrazabilidad
            // 
            this.btnTrazabilidad.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrazabilidad.Appearance.Options.UseFont = true;
            this.btnTrazabilidad.Appearance.Options.UseTextOptions = true;
            this.btnTrazabilidad.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnTrazabilidad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnTrazabilidad.ImageOptions.Image = global::LOSA.Properties.Resources.trazabilidad;
            this.btnTrazabilidad.Location = new System.Drawing.Point(244, 440);
            this.btnTrazabilidad.Name = "btnTrazabilidad";
            this.btnTrazabilidad.Size = new System.Drawing.Size(199, 71);
            this.btnTrazabilidad.TabIndex = 24;
            this.btnTrazabilidad.Text = "Trazabilidad de Lotes";
            this.btnTrazabilidad.Click += new System.EventHandler(this.btnTrazabilidad_Click);
            // 
            // btnCantidadMP
            // 
            this.btnCantidadMP.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantidadMP.Appearance.Options.UseFont = true;
            this.btnCantidadMP.Appearance.Options.UseTextOptions = true;
            this.btnCantidadMP.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnCantidadMP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCantidadMP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCantidadMP.ImageOptions.Image")));
            this.btnCantidadMP.Location = new System.Drawing.Point(244, 360);
            this.btnCantidadMP.Name = "btnCantidadMP";
            this.btnCantidadMP.Size = new System.Drawing.Size(199, 71);
            this.btnCantidadMP.TabIndex = 23;
            this.btnCantidadMP.Text = "Materia Prima En Existencia";
            this.btnCantidadMP.Click += new System.EventHandler(this.btnCantidadMP_Click);
            // 
            // btnLotes
            // 
            this.btnLotes.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLotes.Appearance.Options.UseFont = true;
            this.btnLotes.Appearance.Options.UseTextOptions = true;
            this.btnLotes.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnLotes.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLotes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLotes.ImageOptions.Image")));
            this.btnLotes.Location = new System.Drawing.Point(244, 280);
            this.btnLotes.Name = "btnLotes";
            this.btnLotes.Size = new System.Drawing.Size(199, 71);
            this.btnLotes.TabIndex = 22;
            this.btnLotes.Text = "Ver Lotes";
            this.btnLotes.Click += new System.EventHandler(this.btnLotes_Click);
            // 
            // btnLotesXMP
            // 
            this.btnLotesXMP.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLotesXMP.Appearance.Options.UseFont = true;
            this.btnLotesXMP.Appearance.Options.UseTextOptions = true;
            this.btnLotesXMP.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnLotesXMP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLotesXMP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLotesXMP.ImageOptions.Image")));
            this.btnLotesXMP.Location = new System.Drawing.Point(244, 200);
            this.btnLotesXMP.Name = "btnLotesXMP";
            this.btnLotesXMP.Size = new System.Drawing.Size(199, 71);
            this.btnLotesXMP.TabIndex = 21;
            this.btnLotesXMP.Text = "Ver Lotes Por Materia Prima";
            this.btnLotesXMP.Click += new System.EventHandler(this.btnLotesXMP_Click);
            // 
            // btnLotesPorProveedor
            // 
            this.btnLotesPorProveedor.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLotesPorProveedor.Appearance.Options.UseFont = true;
            this.btnLotesPorProveedor.Appearance.Options.UseTextOptions = true;
            this.btnLotesPorProveedor.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnLotesPorProveedor.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLotesPorProveedor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLotesPorProveedor.ImageOptions.Image")));
            this.btnLotesPorProveedor.Location = new System.Drawing.Point(244, 120);
            this.btnLotesPorProveedor.Name = "btnLotesPorProveedor";
            this.btnLotesPorProveedor.Size = new System.Drawing.Size(199, 71);
            this.btnLotesPorProveedor.TabIndex = 20;
            this.btnLotesPorProveedor.Text = "Ver Lotes Por Proveedor";
            this.btnLotesPorProveedor.Click += new System.EventHandler(this.btnLotesPorProveedor_Click);
            // 
            // cmdRegistroLote
            // 
            this.cmdRegistroLote.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistroLote.Appearance.Options.UseFont = true;
            this.cmdRegistroLote.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRegistroLote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRegistroLote.ImageOptions.Image")));
            this.cmdRegistroLote.Location = new System.Drawing.Point(12, 120);
            this.cmdRegistroLote.Name = "cmdRegistroLote";
            this.cmdRegistroLote.Size = new System.Drawing.Size(200, 71);
            this.cmdRegistroLote.TabIndex = 11;
            this.cmdRegistroLote.Text = "Tarimas por\r\nbodega";
            this.cmdRegistroLote.Click += new System.EventHandler(this.cmdRegistroLote_Click);
            // 
            // cmdSalidasMP
            // 
            this.cmdSalidasMP.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalidasMP.Appearance.Options.UseFont = true;
            this.cmdSalidasMP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSalidasMP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.cmdSalidasMP.Location = new System.Drawing.Point(12, 200);
            this.cmdSalidasMP.Name = "cmdSalidasMP";
            this.cmdSalidasMP.Size = new System.Drawing.Size(200, 71);
            this.cmdSalidasMP.TabIndex = 25;
            this.cmdSalidasMP.Text = "Salidas de MP";
            this.cmdSalidasMP.Click += new System.EventHandler(this.cmdSalidasMP_Click);
            // 
            // frmreport
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 522);
            this.Controls.Add(this.cmdSalidasMP);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.btnTrazabilidad);
            this.Controls.Add(this.btnCantidadMP);
            this.Controls.Add(this.btnLotes);
            this.Controls.Add(this.btnLotesXMP);
            this.Controls.Add(this.btnLotesPorProveedor);
            this.Controls.Add(this.cmdRegistroLote);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmreport";
            this.Text = "frmreport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdRegistroLote;
        private DevExpress.XtraEditors.SimpleButton btnTrazabilidad;
        private DevExpress.XtraEditors.SimpleButton btnCantidadMP;
        private DevExpress.XtraEditors.SimpleButton btnLotes;
        private DevExpress.XtraEditors.SimpleButton btnLotesXMP;
        private DevExpress.XtraEditors.SimpleButton btnLotesPorProveedor;
        private DevExpress.XtraEditors.SimpleButton cmdSalidasMP;
    }
}