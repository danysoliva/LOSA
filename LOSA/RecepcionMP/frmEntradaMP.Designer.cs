namespace LOSA.RecepcionMP
{
    partial class frmEntradaMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntradaMP));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.btnUbicacion = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSelectTarima = new DevExpress.XtraEditors.SimpleButton();
            this.beTarima = new DevExpress.XtraEditors.ButtonEdit();
            this.beUbicacion = new DevExpress.XtraEditors.ButtonEdit();
            this.gcTarima = new DevExpress.XtraGrid.GridControl();
            this.gvTarima = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcUbicacion = new DevExpress.XtraGrid.GridControl();
            this.gvUbicacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.beTarima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beUbicacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTarima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUbicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUbicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 154);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 21);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tarima:";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 370);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 21);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Ubicacion:";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(157, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(271, 21);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Entrada de Materia Prima";
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdHome.ImageOptions.Image")));
            this.cmdHome.Location = new System.Drawing.Point(434, 11);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(176, 60);
            this.cmdHome.TabIndex = 27;
            this.cmdHome.Text = "Home";
            this.cmdHome.Click += new System.EventHandler(this.CmdHome_Click);
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUbicacion.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbicacion.Appearance.Options.UseFont = true;
            this.btnUbicacion.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnUbicacion.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.btnUbicacion.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnUbicacion.Location = new System.Drawing.Point(413, 351);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Size = new System.Drawing.Size(62, 51);
            this.btnUbicacion.TabIndex = 11;
            this.btnUbicacion.Click += new System.EventHandler(this.BtnUbicacion_Click);
            // 
            // cmdSelectTarima
            // 
            this.cmdSelectTarima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSelectTarima.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelectTarima.Appearance.Options.UseFont = true;
            this.cmdSelectTarima.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSelectTarima.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.cmdSelectTarima.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdSelectTarima.Location = new System.Drawing.Point(411, 136);
            this.cmdSelectTarima.Name = "cmdSelectTarima";
            this.cmdSelectTarima.Size = new System.Drawing.Size(62, 51);
            this.cmdSelectTarima.TabIndex = 10;
            this.cmdSelectTarima.Click += new System.EventHandler(this.CmdSelectTarima_Click);
            // 
            // beTarima
            // 
            this.beTarima.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.beTarima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beTarima.EditValue = "";
            this.beTarima.Location = new System.Drawing.Point(78, 144);
            this.beTarima.Name = "beTarima";
            this.beTarima.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beTarima.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.beTarima.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.beTarima.Properties.MaxLength = 20;
            this.beTarima.Properties.NullText = "Escanee o selecciona una tarima";
            this.beTarima.Size = new System.Drawing.Size(316, 36);
            this.beTarima.TabIndex = 28;
            this.beTarima.ToolTip = "Hola";
            this.beTarima.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BeTarima_ButtonClick);
            this.beTarima.Enter += new System.EventHandler(this.BeTarima_Enter);
            this.beTarima.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BeTarima_KeyDown);
            // 
            // beUbicacion
            // 
            this.beUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beUbicacion.Location = new System.Drawing.Point(104, 360);
            this.beUbicacion.Name = "beUbicacion";
            this.beUbicacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beUbicacion.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.beUbicacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.beUbicacion.Properties.MaxLength = 20;
            this.beUbicacion.Size = new System.Drawing.Size(290, 36);
            this.beUbicacion.TabIndex = 29;
            this.beUbicacion.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BeUbicacion_ButtonClick);
            this.beUbicacion.Click += new System.EventHandler(this.BeUbicacion_Click);
            this.beUbicacion.Enter += new System.EventHandler(this.BeUbicacion_Enter);
            this.beUbicacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BeUbicacion_KeyDown);
            // 
            // gcTarima
            // 
            this.gcTarima.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gcTarima.EmbeddedNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.gcTarima.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gcTarima.Location = new System.Drawing.Point(12, 189);
            this.gcTarima.MainView = this.gvTarima;
            this.gcTarima.Name = "gcTarima";
            this.gcTarima.Size = new System.Drawing.Size(463, 156);
            this.gcTarima.TabIndex = 32;
            this.gcTarima.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTarima});
            // 
            // gvTarima
            // 
            this.gvTarima.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvTarima.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gvTarima.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvTarima.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvTarima.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvTarima.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvTarima.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvTarima.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvTarima.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gvTarima.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvTarima.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvTarima.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvTarima.Appearance.Empty.BackColor = System.Drawing.SystemColors.Control;
            this.gvTarima.Appearance.Empty.Options.UseBackColor = true;
            this.gvTarima.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvTarima.Appearance.EvenRow.BackColor2 = System.Drawing.Color.White;
            this.gvTarima.Appearance.EvenRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvTarima.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvTarima.Appearance.EvenRow.Options.UseFont = true;
            this.gvTarima.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvTarima.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvTarima.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gvTarima.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvTarima.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvTarima.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvTarima.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvTarima.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvTarima.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gvTarima.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvTarima.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvTarima.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvTarima.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvTarima.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvTarima.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gvTarima.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvTarima.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gvTarima.Appearance.FocusedCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTarima.Appearance.FocusedCell.Options.UseFont = true;
            this.gvTarima.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvTarima.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent;
            this.gvTarima.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Transparent;
            this.gvTarima.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTarima.Appearance.FocusedRow.Options.UseFont = true;
            this.gvTarima.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvTarima.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvTarima.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvTarima.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvTarima.Appearance.FooterPanel.Options.UseFont = true;
            this.gvTarima.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvTarima.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvTarima.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvTarima.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvTarima.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvTarima.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvTarima.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvTarima.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvTarima.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvTarima.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gvTarima.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTarima.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvTarima.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gvTarima.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvTarima.Appearance.GroupPanel.Options.UseFont = true;
            this.gvTarima.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvTarima.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gvTarima.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvTarima.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvTarima.Appearance.GroupRow.Options.UseFont = true;
            this.gvTarima.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvTarima.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvTarima.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvTarima.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTarima.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvTarima.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.White;
            this.gvTarima.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvTarima.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTarima.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvTarima.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvTarima.Appearance.HorzLine.BackColor = System.Drawing.Color.DarkGray;
            this.gvTarima.Appearance.HorzLine.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvTarima.Appearance.HorzLine.Options.UseFont = true;
            this.gvTarima.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvTarima.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gvTarima.Appearance.OddRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gvTarima.Appearance.OddRow.Options.UseBackColor = true;
            this.gvTarima.Appearance.OddRow.Options.UseFont = true;
            this.gvTarima.Appearance.OddRow.Options.UseForeColor = true;
            this.gvTarima.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gvTarima.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gvTarima.Appearance.Preview.Options.UseBackColor = true;
            this.gvTarima.Appearance.Preview.Options.UseFont = true;
            this.gvTarima.Appearance.Preview.Options.UseForeColor = true;
            this.gvTarima.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvTarima.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.Row.Options.UseBackColor = true;
            this.gvTarima.Appearance.Row.Options.UseFont = true;
            this.gvTarima.Appearance.Row.Options.UseForeColor = true;
            this.gvTarima.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvTarima.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvTarima.Appearance.RowSeparator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvTarima.Appearance.RowSeparator.Options.UseFont = true;
            this.gvTarima.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gvTarima.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvTarima.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvTarima.Appearance.SelectedRow.Options.UseFont = true;
            this.gvTarima.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvTarima.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvTarima.Appearance.TopNewRow.Options.UseFont = true;
            this.gvTarima.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.VertLine.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.VertLine.Options.UseBackColor = true;
            this.gvTarima.Appearance.VertLine.Options.UseFont = true;
            this.gvTarima.GridControl = this.gcTarima;
            this.gvTarima.Name = "gvTarima";
            this.gvTarima.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvTarima.OptionsBehavior.Editable = false;
            this.gvTarima.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTarima.OptionsView.EnableAppearanceOddRow = true;
            this.gvTarima.OptionsView.ShowColumnHeaders = false;
            this.gvTarima.OptionsView.ShowGroupPanel = false;
            this.gvTarima.OptionsView.ShowIndicator = false;
            this.gvTarima.PaintStyleName = "Flat";
            this.gvTarima.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.GridView1_InitNewRow);
            // 
            // gcUbicacion
            // 
            this.gcUbicacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gcUbicacion.EmbeddedNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.gcUbicacion.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gcUbicacion.Location = new System.Drawing.Point(14, 403);
            this.gcUbicacion.MainView = this.gvUbicacion;
            this.gcUbicacion.Name = "gcUbicacion";
            this.gcUbicacion.Size = new System.Drawing.Size(461, 116);
            this.gcUbicacion.TabIndex = 33;
            this.gcUbicacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUbicacion});
            // 
            // gvUbicacion
            // 
            this.gvUbicacion.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gvUbicacion.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvUbicacion.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gvUbicacion.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gvUbicacion.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvUbicacion.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvUbicacion.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvUbicacion.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvUbicacion.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvUbicacion.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gvUbicacion.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvUbicacion.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvUbicacion.Appearance.Empty.BackColor = System.Drawing.SystemColors.Control;
            this.gvUbicacion.Appearance.Empty.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvUbicacion.Appearance.EvenRow.BackColor2 = System.Drawing.Color.White;
            this.gvUbicacion.Appearance.EvenRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacion.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacion.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvUbicacion.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.EvenRow.Options.UseFont = true;
            this.gvUbicacion.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvUbicacion.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvUbicacion.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gvUbicacion.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvUbicacion.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacion.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvUbicacion.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvUbicacion.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvUbicacion.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gvUbicacion.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvUbicacion.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvUbicacion.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvUbicacion.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvUbicacion.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gvUbicacion.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gvUbicacion.Appearance.FocusedCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacion.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacion.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.FocusedCell.Options.UseFont = true;
            this.gvUbicacion.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvUbicacion.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent;
            this.gvUbicacion.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Transparent;
            this.gvUbicacion.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacion.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacion.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.FocusedRow.Options.UseFont = true;
            this.gvUbicacion.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvUbicacion.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gvUbicacion.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvUbicacion.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvUbicacion.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacion.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvUbicacion.Appearance.FooterPanel.Options.UseFont = true;
            this.gvUbicacion.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvUbicacion.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gvUbicacion.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gvUbicacion.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacion.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvUbicacion.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvUbicacion.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvUbicacion.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvUbicacion.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacion.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvUbicacion.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvUbicacion.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gvUbicacion.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvUbicacion.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvUbicacion.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gvUbicacion.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.GroupPanel.Options.UseFont = true;
            this.gvUbicacion.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvUbicacion.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gvUbicacion.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvUbicacion.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gvUbicacion.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.GroupRow.Options.UseFont = true;
            this.gvUbicacion.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvUbicacion.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvUbicacion.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvUbicacion.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacion.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacion.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvUbicacion.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvUbicacion.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvUbicacion.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.White;
            this.gvUbicacion.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacion.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvUbicacion.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvUbicacion.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvUbicacion.Appearance.HorzLine.BackColor = System.Drawing.Color.DarkGray;
            this.gvUbicacion.Appearance.HorzLine.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacion.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.HorzLine.Options.UseFont = true;
            this.gvUbicacion.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvUbicacion.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gvUbicacion.Appearance.OddRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacion.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacion.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gvUbicacion.Appearance.OddRow.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.OddRow.Options.UseFont = true;
            this.gvUbicacion.Appearance.OddRow.Options.UseForeColor = true;
            this.gvUbicacion.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gvUbicacion.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacion.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gvUbicacion.Appearance.Preview.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.Preview.Options.UseFont = true;
            this.gvUbicacion.Appearance.Preview.Options.UseForeColor = true;
            this.gvUbicacion.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvUbicacion.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacion.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacion.Appearance.Row.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.Row.Options.UseFont = true;
            this.gvUbicacion.Appearance.Row.Options.UseForeColor = true;
            this.gvUbicacion.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvUbicacion.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvUbicacion.Appearance.RowSeparator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacion.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.RowSeparator.Options.UseFont = true;
            this.gvUbicacion.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gvUbicacion.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacion.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvUbicacion.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.SelectedRow.Options.UseFont = true;
            this.gvUbicacion.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvUbicacion.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvUbicacion.Appearance.TopNewRow.Options.UseFont = true;
            this.gvUbicacion.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gvUbicacion.Appearance.VertLine.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacion.Appearance.VertLine.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.VertLine.Options.UseFont = true;
            this.gvUbicacion.GridControl = this.gcUbicacion;
            this.gvUbicacion.Name = "gvUbicacion";
            this.gvUbicacion.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvUbicacion.OptionsBehavior.Editable = false;
            this.gvUbicacion.OptionsView.EnableAppearanceEvenRow = true;
            this.gvUbicacion.OptionsView.EnableAppearanceOddRow = true;
            this.gvUbicacion.OptionsView.ShowColumnHeaders = false;
            this.gvUbicacion.OptionsView.ShowGroupPanel = false;
            this.gvUbicacion.OptionsView.ShowIndicator = false;
            this.gvUbicacion.PaintStyleName = "Flat";
            this.gvUbicacion.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.GvUbicacion_InitNewRow);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseBackColor = true;
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGuardar.Location = new System.Drawing.Point(13, 11);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 60);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Location = new System.Drawing.Point(69, 94);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Properties.Appearance.Options.UseFont = true;
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFecha.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFecha.Size = new System.Drawing.Size(142, 30);
            this.dtFecha.TabIndex = 40;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(15, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 21);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "Fecha:";
            // 
            // frmEntradaMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 521);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gcUbicacion);
            this.Controls.Add(this.gcTarima);
            this.Controls.Add(this.beUbicacion);
            this.Controls.Add(this.beTarima);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnUbicacion);
            this.Controls.Add(this.cmdSelectTarima);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEntradaMP";
            this.Text = "frmEntradaMP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmEntradaMP_Activated);
            this.Load += new System.EventHandler(this.frmEntradaMP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beTarima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beUbicacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTarima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUbicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUbicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton cmdSelectTarima;
        private DevExpress.XtraEditors.SimpleButton btnUbicacion;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.ButtonEdit beTarima;
        private DevExpress.XtraEditors.ButtonEdit beUbicacion;
        private DevExpress.XtraGrid.GridControl gcTarima;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTarima;
        private DevExpress.XtraGrid.GridControl gcUbicacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUbicacion;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}