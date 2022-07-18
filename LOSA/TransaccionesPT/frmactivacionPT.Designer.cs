namespace LOSA.TransaccionesPT
{
    partial class frmactivacionPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmactivacionPT));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelNotificacion = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.gcTarima = new DevExpress.XtraGrid.GridControl();
            this.gvTarima = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPeso = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidadT = new DevExpress.XtraEditors.TextEdit();
            this.pictureBoxIndicadorOk = new System.Windows.Forms.PictureBox();
            this.txtTarima = new DevExpress.XtraEditors.ButtonEdit();
            this.timerLimpiarMensaje = new System.Windows.Forms.Timer();
            this.beNuevaUbicacion = new DevExpress.XtraEditors.ButtonEdit();
            this.btnUbicacion = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcNuevaUbicación = new DevExpress.XtraGrid.GridControl();
            this.gvNuevaUbicacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelNotificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTarima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIndicadorOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beNuevaUbicacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNuevaUbicación)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNuevaUbicacion)).BeginInit();
            this.SuspendLayout();
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
            this.labelControl3.Location = new System.Drawing.Point(88, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(372, 39);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Activacion de Tarimas";
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
            this.cmdHome.Location = new System.Drawing.Point(449, 5);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(183, 56);
            this.cmdHome.TabIndex = 33;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 95);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 37);
            this.labelControl1.TabIndex = 97;
            this.labelControl1.Text = "Tarima:";
            // 
            // panelNotificacion
            // 
            this.panelNotificacion.BackColor = System.Drawing.Color.White;
            this.panelNotificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNotificacion.Controls.Add(this.lblMensaje);
            this.panelNotificacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNotificacion.Location = new System.Drawing.Point(0, 514);
            this.panelNotificacion.Name = "panelNotificacion";
            this.panelNotificacion.Size = new System.Drawing.Size(638, 46);
            this.panelNotificacion.TabIndex = 103;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(3, 5);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(630, 34);
            this.lblMensaje.TabIndex = 0;
            // 
            // gcTarima
            // 
            this.gcTarima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTarima.EmbeddedNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.gcTarima.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gcTarima.Location = new System.Drawing.Point(12, 164);
            this.gcTarima.MainView = this.gvTarima;
            this.gcTarima.Name = "gcTarima";
            this.gcTarima.Size = new System.Drawing.Size(558, 100);
            this.gcTarima.TabIndex = 98;
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
            this.gvTarima.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(339, 274);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 24);
            this.labelControl2.TabIndex = 102;
            this.labelControl2.Text = "Peso (Kg)";
            // 
            // txtPeso
            // 
            this.txtPeso.EditValue = "0";
            this.txtPeso.Location = new System.Drawing.Point(428, 270);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Properties.Appearance.Options.UseFont = true;
            this.txtPeso.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPeso.Properties.ReadOnly = true;
            this.txtPeso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPeso.Size = new System.Drawing.Size(142, 32);
            this.txtPeso.TabIndex = 100;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(0, 274);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(80, 24);
            this.labelControl7.TabIndex = 101;
            this.labelControl7.Text = "Unidades";
            // 
            // txtCantidadT
            // 
            this.txtCantidadT.EditValue = "0";
            this.txtCantidadT.Enabled = false;
            this.txtCantidadT.Location = new System.Drawing.Point(90, 266);
            this.txtCantidadT.Name = "txtCantidadT";
            this.txtCantidadT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadT.Properties.Appearance.Options.UseFont = true;
            this.txtCantidadT.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantidadT.Properties.Mask.EditMask = "n2";
            this.txtCantidadT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCantidadT.Properties.NullText = "0";
            this.txtCantidadT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCantidadT.Size = new System.Drawing.Size(142, 32);
            this.txtCantidadT.TabIndex = 99;
            // 
            // pictureBoxIndicadorOk
            // 
            this.pictureBoxIndicadorOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxIndicadorOk.Image = global::LOSA.Properties.Resources.Accept_icon128px;
            this.pictureBoxIndicadorOk.Location = new System.Drawing.Point(488, 86);
            this.pictureBoxIndicadorOk.Name = "pictureBoxIndicadorOk";
            this.pictureBoxIndicadorOk.Size = new System.Drawing.Size(138, 133);
            this.pictureBoxIndicadorOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIndicadorOk.TabIndex = 104;
            this.pictureBoxIndicadorOk.TabStop = false;
            this.pictureBoxIndicadorOk.Visible = false;
            // 
            // txtTarima
            // 
            this.txtTarima.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.txtTarima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTarima.EditValue = "";
            this.txtTarima.Location = new System.Drawing.Point(137, 92);
            this.txtTarima.Name = "txtTarima";
            this.txtTarima.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarima.Properties.Appearance.Options.UseFont = true;
            this.txtTarima.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.txtTarima.Properties.MaxLength = 20;
            this.txtTarima.Properties.NullText = "Escanee o selecciona una tarima";
            this.txtTarima.Size = new System.Drawing.Size(281, 44);
            this.txtTarima.TabIndex = 105;
            this.txtTarima.ToolTip = "Hola";
            this.txtTarima.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTarima_KeyDown);
            // 
            // timerLimpiarMensaje
            // 
            this.timerLimpiarMensaje.Interval = 4000;
            this.timerLimpiarMensaje.Tick += new System.EventHandler(this.timerLimpiarMensaje_Tick);
            // 
            // beNuevaUbicacion
            // 
            this.beNuevaUbicacion.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.beNuevaUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beNuevaUbicacion.EditValue = "";
            this.beNuevaUbicacion.Location = new System.Drawing.Point(151, 308);
            this.beNuevaUbicacion.Name = "beNuevaUbicacion";
            this.beNuevaUbicacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beNuevaUbicacion.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.beNuevaUbicacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.beNuevaUbicacion.Properties.MaxLength = 20;
            this.beNuevaUbicacion.Properties.NullText = "Escanee o selecciona una tarima";
            this.beNuevaUbicacion.Size = new System.Drawing.Size(325, 28);
            this.beNuevaUbicacion.TabIndex = 109;
            this.beNuevaUbicacion.ToolTip = "Hola";
            this.beNuevaUbicacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.beNuevaUbicacion_KeyDown);
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUbicacion.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbicacion.Appearance.Options.UseFont = true;
            this.btnUbicacion.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnUbicacion.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.btnUbicacion.Location = new System.Drawing.Point(482, 306);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Size = new System.Drawing.Size(42, 40);
            this.btnUbicacion.TabIndex = 108;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(10, 313);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(135, 21);
            this.labelControl4.TabIndex = 107;
            this.labelControl4.Text = "Nueva Ubicación:";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.gcNuevaUbicación);
            this.groupControl2.Location = new System.Drawing.Point(13, 340);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(308, 147);
            this.groupControl2.TabIndex = 106;
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
            // 
            // frmactivacionPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.beNuevaUbicacion);
            this.Controls.Add(this.btnUbicacion);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.txtTarima);
            this.Controls.Add(this.pictureBoxIndicadorOk);
            this.Controls.Add(this.panelNotificacion);
            this.Controls.Add(this.gcTarima);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtCantidadT);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmactivacionPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmactivacionPT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelNotificacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTarima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIndicadorOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beNuevaUbicacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNuevaUbicación)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNuevaUbicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panelNotificacion;
        private System.Windows.Forms.Label lblMensaje;
        private DevExpress.XtraGrid.GridControl gcTarima;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTarima;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPeso;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtCantidadT;
        private System.Windows.Forms.PictureBox pictureBoxIndicadorOk;
        private DevExpress.XtraEditors.ButtonEdit txtTarima;
        private System.Windows.Forms.Timer timerLimpiarMensaje;
        private DevExpress.XtraEditors.ButtonEdit beNuevaUbicacion;
        private DevExpress.XtraEditors.SimpleButton btnUbicacion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcNuevaUbicación;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNuevaUbicacion;
    }
}