
namespace LOSA.TransaccionesMP
{
    partial class frmResumenToEntregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResumenToEntregar));
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSolicitados = new DevExpress.XtraEditors.TextEdit();
            this.txtEnviados = new DevExpress.XtraEditors.TextEdit();
            this.txtPorEnviar = new DevExpress.XtraEditors.TextEdit();
            this.txtRestante = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnDown = new DevExpress.XtraEditors.SimpleButton();
            this.btnUP = new DevExpress.XtraEditors.SimpleButton();
            this.chConsumirPendientes = new DevExpress.XtraEditors.CheckEdit();
            this.gcTarima = new DevExpress.XtraGrid.GridControl();
            this.gvTarima = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreTarima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_tarima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_boleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsMicro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmp_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dsTransaccionesMP1 = new LOSA.TransaccionesMP.dsTransaccionesMP();
            ((System.ComponentModel.ISupportInitialize)(this.txtSolicitados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnviados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorEnviar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRestante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chConsumirPendientes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTarima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(408, 597);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(175, 48);
            this.cmdHome.TabIndex = 7;
            this.cmdHome.Text = "Cancelar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(215, 597);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(175, 48);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Entegar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 225);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(358, 30);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Cantidad Solicitada en requisa (Kg.):";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(137, 267);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(231, 30);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Cantidad Enviada (Kg.):";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(54, 329);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(306, 30);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Por enviar de esta tarima (Ud.):";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(93, 410);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(267, 30);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Restante por Requisa (kg.):";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(353, 368);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(333, 30);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "_____________________________________";
            // 
            // txtSolicitados
            // 
            this.txtSolicitados.Enabled = false;
            this.txtSolicitados.Location = new System.Drawing.Point(380, 222);
            this.txtSolicitados.Name = "txtSolicitados";
            this.txtSolicitados.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtSolicitados.Properties.Appearance.Options.UseFont = true;
            this.txtSolicitados.Size = new System.Drawing.Size(300, 36);
            this.txtSolicitados.TabIndex = 14;
            // 
            // txtEnviados
            // 
            this.txtEnviados.Enabled = false;
            this.txtEnviados.Location = new System.Drawing.Point(380, 264);
            this.txtEnviados.Name = "txtEnviados";
            this.txtEnviados.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtEnviados.Properties.Appearance.Options.UseFont = true;
            this.txtEnviados.Size = new System.Drawing.Size(300, 36);
            this.txtEnviados.TabIndex = 15;
            // 
            // txtPorEnviar
            // 
            this.txtPorEnviar.Enabled = false;
            this.txtPorEnviar.Location = new System.Drawing.Point(380, 326);
            this.txtPorEnviar.Name = "txtPorEnviar";
            this.txtPorEnviar.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtPorEnviar.Properties.Appearance.Options.UseFont = true;
            this.txtPorEnviar.Size = new System.Drawing.Size(138, 36);
            this.txtPorEnviar.TabIndex = 16;
            // 
            // txtRestante
            // 
            this.txtRestante.Enabled = false;
            this.txtRestante.Location = new System.Drawing.Point(380, 404);
            this.txtRestante.Name = "txtRestante";
            this.txtRestante.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtRestante.Properties.Appearance.Options.UseFont = true;
            this.txtRestante.Size = new System.Drawing.Size(300, 36);
            this.txtRestante.TabIndex = 17;
            // 
            // textEdit1
            // 
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(380, 459);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(300, 36);
            this.textEdit1.TabIndex = 109;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(114, 462);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(246, 30);
            this.labelControl6.TabIndex = 108;
            this.labelControl6.Text = "Restante en tarima (Ud.):";
            // 
            // btnDown
            // 
            this.btnDown.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.ImageOptions.Image")));
            this.btnDown.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDown.Location = new System.Drawing.Point(604, 315);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(76, 65);
            this.btnDown.TabIndex = 111;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUP
            // 
            this.btnUP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUP.ImageOptions.Image")));
            this.btnUP.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnUP.Location = new System.Drawing.Point(524, 315);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(74, 65);
            this.btnUP.TabIndex = 110;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // chConsumirPendientes
            // 
            this.chConsumirPendientes.Location = new System.Drawing.Point(178, 555);
            this.chConsumirPendientes.Name = "chConsumirPendientes";
            this.chConsumirPendientes.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.chConsumirPendientes.Properties.Appearance.Options.UseFont = true;
            this.chConsumirPendientes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.chConsumirPendientes.Properties.Caption = "Consumir lo pendiente de la Requisa";
            this.chConsumirPendientes.Size = new System.Drawing.Size(440, 36);
            this.chConsumirPendientes.TabIndex = 112;
            this.chConsumirPendientes.CheckedChanged += new System.EventHandler(this.chConsumirPendientes_CheckedChanged);
            // 
            // gcTarima
            // 
            this.gcTarima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTarima.DataMember = "tarima_monta_carga";
            this.gcTarima.DataSource = this.dsTransaccionesMP1;
            this.gcTarima.EmbeddedNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.gcTarima.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gcTarima.Location = new System.Drawing.Point(12, 12);
            this.gcTarima.MainView = this.gvTarima;
            this.gcTarima.Name = "gcTarima";
            this.gcTarima.Size = new System.Drawing.Size(674, 193);
            this.gcTarima.TabIndex = 113;
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
            this.gvTarima.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid2,
            this.colnombreTarima,
            this.colnombreProveedor,
            this.colfecha_ingreso,
            this.colnumero_transaccion,
            this.collote_materia_prima,
            this.colpresentacion,
            this.coltipo_tarima,
            this.colid_boleta,
            this.colnum,
            this.colIsMicro,
            this.colitemcode,
            this.colmp_name});
            this.gvTarima.GridControl = this.gcTarima;
            this.gvTarima.Name = "gvTarima";
            this.gvTarima.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvTarima.OptionsBehavior.Editable = false;
            this.gvTarima.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTarima.OptionsView.EnableAppearanceOddRow = true;
            this.gvTarima.OptionsView.ShowGroupPanel = false;
            this.gvTarima.OptionsView.ShowIndicator = false;
            this.gvTarima.PaintStyleName = "Flat";
            // 
            // colid2
            // 
            this.colid2.FieldName = "id";
            this.colid2.Name = "colid2";
            // 
            // colnombreTarima
            // 
            this.colnombreTarima.FieldName = "nombreTarima";
            this.colnombreTarima.Name = "colnombreTarima";
            // 
            // colnombreProveedor
            // 
            this.colnombreProveedor.Caption = "Provider";
            this.colnombreProveedor.FieldName = "nombreProveedor";
            this.colnombreProveedor.Name = "colnombreProveedor";
            this.colnombreProveedor.Visible = true;
            this.colnombreProveedor.VisibleIndex = 3;
            this.colnombreProveedor.Width = 104;
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.Caption = "Date";
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.Visible = true;
            this.colfecha_ingreso.VisibleIndex = 4;
            this.colfecha_ingreso.Width = 84;
            // 
            // colnumero_transaccion
            // 
            this.colnumero_transaccion.Caption = "Transaction Num";
            this.colnumero_transaccion.FieldName = "numero_transaccion";
            this.colnumero_transaccion.Name = "colnumero_transaccion";
            this.colnumero_transaccion.Visible = true;
            this.colnumero_transaccion.VisibleIndex = 5;
            this.colnumero_transaccion.Width = 76;
            // 
            // collote_materia_prima
            // 
            this.collote_materia_prima.Caption = "Lot";
            this.collote_materia_prima.FieldName = "lote_materia_prima";
            this.collote_materia_prima.Name = "collote_materia_prima";
            this.collote_materia_prima.Visible = true;
            this.collote_materia_prima.VisibleIndex = 6;
            this.collote_materia_prima.Width = 96;
            // 
            // colpresentacion
            // 
            this.colpresentacion.Caption = "Size";
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 7;
            this.colpresentacion.Width = 49;
            // 
            // coltipo_tarima
            // 
            this.coltipo_tarima.FieldName = "tipo_tarima";
            this.coltipo_tarima.Name = "coltipo_tarima";
            // 
            // colid_boleta
            // 
            this.colid_boleta.FieldName = "id_boleta";
            this.colid_boleta.Name = "colid_boleta";
            // 
            // colnum
            // 
            this.colnum.Caption = "#";
            this.colnum.FieldName = "num";
            this.colnum.Name = "colnum";
            this.colnum.Visible = true;
            this.colnum.VisibleIndex = 0;
            this.colnum.Width = 39;
            // 
            // colIsMicro
            // 
            this.colIsMicro.FieldName = "IsMicro";
            this.colIsMicro.Name = "colIsMicro";
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Code";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 1;
            this.colitemcode.Width = 81;
            // 
            // colmp_name
            // 
            this.colmp_name.Caption = "Name";
            this.colmp_name.FieldName = "mp_name";
            this.colmp_name.Name = "colmp_name";
            this.colmp_name.Visible = true;
            this.colmp_name.VisibleIndex = 2;
            this.colmp_name.Width = 81;
            // 
            // dsTransaccionesMP1
            // 
            this.dsTransaccionesMP1.DataSetName = "dsTransaccionesMP";
            this.dsTransaccionesMP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmResumenToEntregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 657);
            this.Controls.Add(this.gcTarima);
            this.Controls.Add(this.chConsumirPendientes);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtRestante);
            this.Controls.Add(this.txtPorEnviar);
            this.Controls.Add(this.txtEnviados);
            this.Controls.Add(this.txtSolicitados);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdHome);
            this.Name = "frmResumenToEntregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen a Entregar";
            this.Load += new System.EventHandler(this.frmResumenToEntregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSolicitados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnviados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorEnviar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRestante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chConsumirPendientes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTarima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSolicitados;
        private DevExpress.XtraEditors.TextEdit txtEnviados;
        private DevExpress.XtraEditors.TextEdit txtPorEnviar;
        private DevExpress.XtraEditors.TextEdit txtRestante;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnDown;
        private DevExpress.XtraEditors.SimpleButton btnUP;
        private DevExpress.XtraEditors.CheckEdit chConsumirPendientes;
        private DevExpress.XtraGrid.GridControl gcTarima;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTarima;
        private DevExpress.XtraGrid.Columns.GridColumn colid2;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreTarima;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn collote_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_tarima;
        private DevExpress.XtraGrid.Columns.GridColumn colid_boleta;
        private DevExpress.XtraGrid.Columns.GridColumn colnum;
        private DevExpress.XtraGrid.Columns.GridColumn colIsMicro;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colmp_name;
        private dsTransaccionesMP dsTransaccionesMP1;
    }
}