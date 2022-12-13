namespace LOSA.MigracionACS.Forecast
{
    partial class FCT_TextFileUpload
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
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_cancel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_accept = new DevExpress.XtraBars.BarButtonItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_terminar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grp_File = new DevExpress.XtraEditors.GroupControl();
            this.txt_file = new DevExpress.XtraEditors.TextEdit();
            this.btn_SearchFile = new DevExpress.XtraEditors.SimpleButton();
            this.grp_opciones = new DevExpress.XtraEditors.GroupControl();
            this.cmb_meses = new DevExpress.XtraEditors.ComboBoxEdit();
            this.rgp_options = new DevExpress.XtraEditors.RadioGroup();
            this.grp_estado = new DevExpress.XtraEditors.GroupControl();
            this.lst_estado = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_File)).BeginInit();
            this.grp_File.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_file.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_opciones)).BeginInit();
            this.grp_opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_meses.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgp_options.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_estado)).BeginInit();
            this.grp_estado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_estado)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_accept,
            this.btn_cancel,
            this.btn_terminar});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar1;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_cancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_accept)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_cancel.Caption = "Cancelar";
            this.btn_cancel.Id = 1;
            this.btn_cancel.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_32x32;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btn_accept
            // 
            this.btn_accept.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_accept.Caption = "Aceptar";
            this.btn_accept.Id = 0;
            this.btn_accept.ImageOptions.Image = global::LOSA.Properties.Resources.Accept_32x32;
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_accept_ItemClick);
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_terminar)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 3";
            // 
            // btn_terminar
            // 
            this.btn_terminar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_terminar.Caption = "Terminar";
            this.btn_terminar.Id = 2;
            this.btn_terminar.ImageOptions.Image = global::LOSA.Properties.Resources.Accept_32x32;
            this.btn_terminar.Name = "btn_terminar";
            this.btn_terminar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_terminar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btn_terminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_terminar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(350, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 386);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(350, 43);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 346);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(350, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 346);
            // 
            // grp_File
            // 
            this.grp_File.Controls.Add(this.txt_file);
            this.grp_File.Controls.Add(this.btn_SearchFile);
            this.grp_File.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_File.Location = new System.Drawing.Point(0, 40);
            this.grp_File.Name = "grp_File";
            this.grp_File.Size = new System.Drawing.Size(350, 47);
            this.grp_File.TabIndex = 4;
            this.grp_File.Text = "Seleccione el Archivo";
            // 
            // txt_file
            // 
            this.txt_file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_file.Location = new System.Drawing.Point(2, 20);
            this.txt_file.MenuManager = this.barManager1;
            this.txt_file.Name = "txt_file";
            this.txt_file.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_file.Properties.Appearance.Options.UseFont = true;
            this.txt_file.Properties.ReadOnly = true;
            this.txt_file.Size = new System.Drawing.Size(319, 24);
            this.txt_file.TabIndex = 0;
            // 
            // btn_SearchFile
            // 
            this.btn_SearchFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_SearchFile.ImageOptions.Image = global::LOSA.Properties.Resources.search_16x16;
            this.btn_SearchFile.Location = new System.Drawing.Point(321, 20);
            this.btn_SearchFile.Name = "btn_SearchFile";
            this.btn_SearchFile.Size = new System.Drawing.Size(27, 25);
            this.btn_SearchFile.TabIndex = 1;
            this.btn_SearchFile.Click += new System.EventHandler(this.btn_SearchFile_Click);
            // 
            // grp_opciones
            // 
            this.grp_opciones.Controls.Add(this.cmb_meses);
            this.grp_opciones.Controls.Add(this.rgp_options);
            this.grp_opciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_opciones.Location = new System.Drawing.Point(0, 87);
            this.grp_opciones.Name = "grp_opciones";
            this.grp_opciones.Size = new System.Drawing.Size(350, 75);
            this.grp_opciones.TabIndex = 5;
            this.grp_opciones.Text = "Opciones";
            // 
            // cmb_meses
            // 
            this.cmb_meses.EditValue = "Enero";
            this.cmb_meses.Enabled = false;
            this.cmb_meses.Location = new System.Drawing.Point(163, 37);
            this.cmb_meses.MenuManager = this.barManager1;
            this.cmb_meses.Name = "cmb_meses";
            this.cmb_meses.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_meses.Properties.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmb_meses.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_meses.Size = new System.Drawing.Size(175, 20);
            this.cmb_meses.TabIndex = 1;
            // 
            // rgp_options
            // 
            this.rgp_options.Dock = System.Windows.Forms.DockStyle.Left;
            this.rgp_options.Location = new System.Drawing.Point(2, 20);
            this.rgp_options.MenuManager = this.barManager1;
            this.rgp_options.Name = "rgp_options";
            this.rgp_options.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgp_options.Properties.Appearance.Options.UseBackColor = true;
            this.rgp_options.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgp_options.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Actualizar Todo el Año"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Actualizar Mes Específico")});
            this.rgp_options.Size = new System.Drawing.Size(155, 53);
            this.rgp_options.TabIndex = 0;
            this.rgp_options.SelectedIndexChanged += new System.EventHandler(this.rgp_options_SelectedIndexChanged);
            // 
            // grp_estado
            // 
            this.grp_estado.Controls.Add(this.lst_estado);
            this.grp_estado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_estado.Location = new System.Drawing.Point(0, 162);
            this.grp_estado.Name = "grp_estado";
            this.grp_estado.Size = new System.Drawing.Size(350, 224);
            this.grp_estado.TabIndex = 6;
            this.grp_estado.Text = "Estado del Proceso";
            // 
            // lst_estado
            // 
            this.lst_estado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_estado.Location = new System.Drawing.Point(2, 20);
            this.lst_estado.Name = "lst_estado";
            this.lst_estado.Size = new System.Drawing.Size(346, 202);
            this.lst_estado.TabIndex = 0;
            // 
            // FCT_TextFileUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 429);
            this.Controls.Add(this.grp_estado);
            this.Controls.Add(this.grp_opciones);
            this.Controls.Add(this.grp_File);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCT_TextFileUpload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCT_TextFileUpload";
            this.Load += new System.EventHandler(this.FCT_TextFileUpload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_File)).EndInit();
            this.grp_File.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_file.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_opciones)).EndInit();
            this.grp_opciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_meses.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgp_options.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_estado)).EndInit();
            this.grp_estado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lst_estado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_cancel;
        private DevExpress.XtraBars.BarButtonItem btn_accept;
        private DevExpress.XtraEditors.GroupControl grp_estado;
        private DevExpress.XtraEditors.GroupControl grp_opciones;
        private DevExpress.XtraEditors.GroupControl grp_File;
        private DevExpress.XtraEditors.TextEdit txt_file;
        private DevExpress.XtraEditors.SimpleButton btn_SearchFile;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_terminar;
        private DevExpress.XtraEditors.ListBoxControl lst_estado;
        private DevExpress.XtraEditors.RadioGroup rgp_options;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_meses;
    }
}