namespace LOSA.RecepcionMP
{
    partial class frmCambiarUbicacionTarima
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarUbicacionTarima));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.beIdTarima = new DevExpress.XtraEditors.ButtonEdit();
            this.cmdSelectTarima = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gcUbicacionActual = new DevExpress.XtraGrid.GridControl();
            this.gvUbicacionActual = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcNuevaUbicación = new DevExpress.XtraGrid.GridControl();
            this.gvNuevaUbicacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.beNuevaUbicacion = new DevExpress.XtraEditors.ButtonEdit();
            this.btnUbicacion = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gcTarima = new DevExpress.XtraGrid.GridControl();
            this.gvTarima = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.beIdTarima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUbicacionActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUbicacionActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNuevaUbicación)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNuevaUbicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beNuevaUbicacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTarima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarima)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // beIdTarima
            // 
            this.beIdTarima.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.beIdTarima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beIdTarima.EditValue = "";
            this.beIdTarima.Location = new System.Drawing.Point(72, 99);
            this.beIdTarima.Name = "beIdTarima";
            this.beIdTarima.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beIdTarima.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.beIdTarima.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.beIdTarima.Properties.MaxLength = 20;
            this.beIdTarima.Properties.NullText = "Escanee o selecciona una tarima";
            this.beIdTarima.Size = new System.Drawing.Size(312, 28);
            this.beIdTarima.TabIndex = 31;
            this.beIdTarima.ToolTip = "Hola";
            this.beIdTarima.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BeUbicacionActual_ButtonClick);
            this.beIdTarima.Enter += new System.EventHandler(this.BeIdTarima_Enter);
            this.beIdTarima.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BeTarima_KeyDown);
            // 
            // cmdSelectTarima
            // 
            this.cmdSelectTarima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSelectTarima.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelectTarima.Appearance.Options.UseFont = true;
            this.cmdSelectTarima.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSelectTarima.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.cmdSelectTarima.Location = new System.Drawing.Point(394, 96);
            this.cmdSelectTarima.Name = "cmdSelectTarima";
            this.cmdSelectTarima.Size = new System.Drawing.Size(42, 40);
            this.cmdSelectTarima.TabIndex = 30;
            this.cmdSelectTarima.Click += new System.EventHandler(this.CmdSelectTarima_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 104);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 21);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Tarima:";
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
            this.cmdHome.Location = new System.Drawing.Point(458, 44);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(161, 43);
            this.cmdHome.TabIndex = 33;
            this.cmdHome.Text = "Home";
            this.cmdHome.Click += new System.EventHandler(this.CmdHome_Click);
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
            this.labelControl3.Location = new System.Drawing.Point(0, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(402, 21);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Ubicación de Tarima";
            // 
            // gcUbicacionActual
            // 
            this.gcUbicacionActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUbicacionActual.EmbeddedNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.gcUbicacionActual.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gcUbicacionActual.Location = new System.Drawing.Point(2, 22);
            this.gcUbicacionActual.MainView = this.gvUbicacionActual;
            this.gcUbicacionActual.Name = "gcUbicacionActual";
            this.gcUbicacionActual.Size = new System.Drawing.Size(287, 117);
            this.gcUbicacionActual.TabIndex = 34;
            this.gcUbicacionActual.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUbicacionActual});
            // 
            // gvUbicacionActual
            // 
            this.gvUbicacionActual.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gvUbicacionActual.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvUbicacionActual.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gvUbicacionActual.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gvUbicacionActual.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvUbicacionActual.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvUbicacionActual.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvUbicacionActual.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvUbicacionActual.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvUbicacionActual.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gvUbicacionActual.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvUbicacionActual.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvUbicacionActual.Appearance.Empty.BackColor = System.Drawing.SystemColors.Control;
            this.gvUbicacionActual.Appearance.Empty.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvUbicacionActual.Appearance.EvenRow.BackColor2 = System.Drawing.Color.White;
            this.gvUbicacionActual.Appearance.EvenRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacionActual.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacionActual.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvUbicacionActual.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.EvenRow.Options.UseFont = true;
            this.gvUbicacionActual.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvUbicacionActual.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvUbicacionActual.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gvUbicacionActual.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvUbicacionActual.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacionActual.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvUbicacionActual.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvUbicacionActual.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvUbicacionActual.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gvUbicacionActual.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvUbicacionActual.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvUbicacionActual.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvUbicacionActual.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvUbicacionActual.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gvUbicacionActual.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gvUbicacionActual.Appearance.FocusedCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacionActual.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacionActual.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.FocusedCell.Options.UseFont = true;
            this.gvUbicacionActual.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvUbicacionActual.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent;
            this.gvUbicacionActual.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Transparent;
            this.gvUbicacionActual.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacionActual.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacionActual.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.FocusedRow.Options.UseFont = true;
            this.gvUbicacionActual.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvUbicacionActual.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gvUbicacionActual.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvUbicacionActual.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvUbicacionActual.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacionActual.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvUbicacionActual.Appearance.FooterPanel.Options.UseFont = true;
            this.gvUbicacionActual.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvUbicacionActual.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gvUbicacionActual.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gvUbicacionActual.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacionActual.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvUbicacionActual.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvUbicacionActual.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvUbicacionActual.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvUbicacionActual.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacionActual.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvUbicacionActual.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvUbicacionActual.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gvUbicacionActual.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvUbicacionActual.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvUbicacionActual.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gvUbicacionActual.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.GroupPanel.Options.UseFont = true;
            this.gvUbicacionActual.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvUbicacionActual.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gvUbicacionActual.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvUbicacionActual.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gvUbicacionActual.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.GroupRow.Options.UseFont = true;
            this.gvUbicacionActual.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvUbicacionActual.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvUbicacionActual.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvUbicacionActual.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvUbicacionActual.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacionActual.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvUbicacionActual.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvUbicacionActual.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvUbicacionActual.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.White;
            this.gvUbicacionActual.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacionActual.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvUbicacionActual.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvUbicacionActual.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvUbicacionActual.Appearance.HorzLine.BackColor = System.Drawing.Color.DarkGray;
            this.gvUbicacionActual.Appearance.HorzLine.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacionActual.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.HorzLine.Options.UseFont = true;
            this.gvUbicacionActual.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvUbicacionActual.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gvUbicacionActual.Appearance.OddRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacionActual.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacionActual.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gvUbicacionActual.Appearance.OddRow.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.OddRow.Options.UseFont = true;
            this.gvUbicacionActual.Appearance.OddRow.Options.UseForeColor = true;
            this.gvUbicacionActual.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gvUbicacionActual.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacionActual.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gvUbicacionActual.Appearance.Preview.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.Preview.Options.UseFont = true;
            this.gvUbicacionActual.Appearance.Preview.Options.UseForeColor = true;
            this.gvUbicacionActual.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvUbicacionActual.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacionActual.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvUbicacionActual.Appearance.Row.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.Row.Options.UseFont = true;
            this.gvUbicacionActual.Appearance.Row.Options.UseForeColor = true;
            this.gvUbicacionActual.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvUbicacionActual.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvUbicacionActual.Appearance.RowSeparator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacionActual.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.RowSeparator.Options.UseFont = true;
            this.gvUbicacionActual.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gvUbicacionActual.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacionActual.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvUbicacionActual.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.SelectedRow.Options.UseFont = true;
            this.gvUbicacionActual.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvUbicacionActual.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvUbicacionActual.Appearance.TopNewRow.Options.UseFont = true;
            this.gvUbicacionActual.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gvUbicacionActual.Appearance.VertLine.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUbicacionActual.Appearance.VertLine.Options.UseBackColor = true;
            this.gvUbicacionActual.Appearance.VertLine.Options.UseFont = true;
            this.gvUbicacionActual.GridControl = this.gcUbicacionActual;
            this.gvUbicacionActual.Name = "gvUbicacionActual";
            this.gvUbicacionActual.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvUbicacionActual.OptionsBehavior.Editable = false;
            this.gvUbicacionActual.OptionsView.EnableAppearanceEvenRow = true;
            this.gvUbicacionActual.OptionsView.EnableAppearanceOddRow = true;
            this.gvUbicacionActual.OptionsView.ShowColumnHeaders = false;
            this.gvUbicacionActual.OptionsView.ShowGroupPanel = false;
            this.gvUbicacionActual.OptionsView.ShowIndicator = false;
            this.gvUbicacionActual.PaintStyleName = "Flat";
            this.gvUbicacionActual.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.GvUbicacionActual_InitNewRow);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.gcUbicacionActual);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(299, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(291, 141);
            this.groupControl1.TabIndex = 35;
            this.groupControl1.Text = "Ubicación Actual";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.gcNuevaUbicación);
            this.groupControl2.Location = new System.Drawing.Point(12, 362);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(308, 147);
            this.groupControl2.TabIndex = 36;
            this.groupControl2.Text = "Nueva Ubicación";
            // 
            // gcNuevaUbicación
            // 
            this.gcNuevaUbicación.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcNuevaUbicación.EmbeddedNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.gcNuevaUbicación.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gcNuevaUbicación.Location = new System.Drawing.Point(6, 25);
            this.gcNuevaUbicación.MainView = this.gvNuevaUbicacion;
            this.gcNuevaUbicación.Name = "gcNuevaUbicación";
            this.gcNuevaUbicación.Size = new System.Drawing.Size(290, 116);
            this.gcNuevaUbicación.TabIndex = 34;
            this.gcNuevaUbicación.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNuevaUbicacion});
            // 
            // gvNuevaUbicacion
            // 
            this.gvNuevaUbicacion.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvNuevaUbicacion.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gvNuevaUbicacion.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvNuevaUbicacion.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvNuevaUbicacion.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvNuevaUbicacion.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvNuevaUbicacion.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gvNuevaUbicacion.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvNuevaUbicacion.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.Empty.BackColor = System.Drawing.SystemColors.Control;
            this.gvNuevaUbicacion.Appearance.Empty.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.EvenRow.BackColor2 = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.EvenRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvNuevaUbicacion.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.EvenRow.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvNuevaUbicacion.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gvNuevaUbicacion.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvNuevaUbicacion.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvNuevaUbicacion.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvNuevaUbicacion.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gvNuevaUbicacion.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvNuevaUbicacion.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvNuevaUbicacion.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gvNuevaUbicacion.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gvNuevaUbicacion.Appearance.FocusedCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.FocusedCell.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent;
            this.gvNuevaUbicacion.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Transparent;
            this.gvNuevaUbicacion.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.FocusedRow.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvNuevaUbicacion.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvNuevaUbicacion.Appearance.FooterPanel.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvNuevaUbicacion.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvNuevaUbicacion.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvNuevaUbicacion.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvNuevaUbicacion.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gvNuevaUbicacion.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvNuevaUbicacion.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.GroupPanel.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gvNuevaUbicacion.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvNuevaUbicacion.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.GroupRow.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvNuevaUbicacion.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvNuevaUbicacion.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvNuevaUbicacion.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.HorzLine.BackColor = System.Drawing.Color.DarkGray;
            this.gvNuevaUbicacion.Appearance.HorzLine.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.HorzLine.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.OddRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gvNuevaUbicacion.Appearance.OddRow.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.OddRow.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.OddRow.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gvNuevaUbicacion.Appearance.Preview.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.Preview.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.Preview.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.Row.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.Row.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.Row.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.RowSeparator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.RowSeparator.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gvNuevaUbicacion.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.SelectedRow.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvNuevaUbicacion.Appearance.TopNewRow.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.VertLine.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.VertLine.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.VertLine.Options.UseFont = true;
            this.gvNuevaUbicacion.GridControl = this.gcNuevaUbicación;
            this.gvNuevaUbicacion.Name = "gvNuevaUbicacion";
            this.gvNuevaUbicacion.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvNuevaUbicacion.OptionsBehavior.Editable = false;
            this.gvNuevaUbicacion.OptionsView.EnableAppearanceEvenRow = true;
            this.gvNuevaUbicacion.OptionsView.EnableAppearanceOddRow = true;
            this.gvNuevaUbicacion.OptionsView.ShowColumnHeaders = false;
            this.gvNuevaUbicacion.OptionsView.ShowGroupPanel = false;
            this.gvNuevaUbicacion.OptionsView.ShowIndicator = false;
            this.gvNuevaUbicacion.PaintStyleName = "Flat";
            this.gvNuevaUbicacion.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.GvNuevaUbicacion_InitNewRow);
            // 
            // beNuevaUbicacion
            // 
            this.beNuevaUbicacion.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.beNuevaUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beNuevaUbicacion.EditValue = "";
            this.beNuevaUbicacion.Location = new System.Drawing.Point(150, 330);
            this.beNuevaUbicacion.Name = "beNuevaUbicacion";
            this.beNuevaUbicacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beNuevaUbicacion.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.beNuevaUbicacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.beNuevaUbicacion.Properties.MaxLength = 20;
            this.beNuevaUbicacion.Properties.NullText = "Escanee o selecciona una tarima";
            this.beNuevaUbicacion.Size = new System.Drawing.Size(325, 28);
            this.beNuevaUbicacion.TabIndex = 39;
            this.beNuevaUbicacion.ToolTip = "Hola";
            this.beNuevaUbicacion.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BeNuevaUbicacion_ButtonClick);
            this.beNuevaUbicacion.Enter += new System.EventHandler(this.BeNuevaUbicacion_Enter);
            this.beNuevaUbicacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BeNuevaUbicacion_KeyDown);
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUbicacion.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbicacion.Appearance.Options.UseFont = true;
            this.btnUbicacion.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnUbicacion.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.btnUbicacion.Location = new System.Drawing.Point(481, 328);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Size = new System.Drawing.Size(42, 40);
            this.btnUbicacion.TabIndex = 38;
            this.btnUbicacion.Click += new System.EventHandler(this.BtnUbicacion_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(9, 335);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(135, 21);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "Nueva Ubicación:";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl1.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl1.Location = new System.Drawing.Point(0, 140);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(619, 23);
            this.separatorControl1.TabIndex = 40;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGuardar.Location = new System.Drawing.Point(5, 44);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 43);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.Appearance.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.gcTarima);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(3, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(290, 141);
            this.groupControl3.TabIndex = 36;
            this.groupControl3.Text = "Información Tarima";
            // 
            // gcTarima
            // 
            this.gcTarima.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTarima.EmbeddedNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.gcTarima.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gcTarima.Location = new System.Drawing.Point(2, 22);
            this.gcTarima.MainView = this.gvTarima;
            this.gcTarima.Name = "gcTarima";
            this.gcTarima.Size = new System.Drawing.Size(286, 117);
            this.gcTarima.TabIndex = 34;
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
            this.gvTarima.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
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
            this.gvTarima.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.gvTarima.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.GvTarima_InitNewRow);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 166);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(593, 147);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // frmCambiarUbicacionTarima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 521);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.beNuevaUbicacion);
            this.Controls.Add(this.btnUbicacion);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.beIdTarima);
            this.Controls.Add(this.cmdSelectTarima);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCambiarUbicacionTarima";
            this.Text = "frmCambiarUbicacionTarima";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.beIdTarima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUbicacionActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUbicacionActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNuevaUbicación)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNuevaUbicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beNuevaUbicacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTarima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarima)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit beIdTarima;
        private DevExpress.XtraEditors.SimpleButton cmdSelectTarima;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gcUbicacionActual;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUbicacionActual;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcNuevaUbicación;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNuevaUbicacion;
        private DevExpress.XtraEditors.ButtonEdit beNuevaUbicacion;
        private DevExpress.XtraEditors.SimpleButton btnUbicacion;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gcTarima;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTarima;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}