namespace LOSA.MigracionACS.SAR
{
    partial class SAR_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAR_Main));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.v = new DevExpress.XtraBars.BarButtonItem();
            this.btngeneral = new DevExpress.XtraBars.BarButtonItem();
            this.btncapitulo = new DevExpress.XtraBars.BarButtonItem();
            this.btnKardex = new DevExpress.XtraBars.BarButtonItem();
            this.btnrubrox = new DevExpress.XtraBars.BarButtonItem();
            this.btnclose = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnrealtime = new DevExpress.XtraBars.BarButtonItem();
            this.btnrubro = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl = new DevExpress.XtraEditors.LabelControl();
            this.lblbegin = new DevExpress.XtraEditors.LabelControl();
            this.dtfin = new DevExpress.XtraEditors.DateEdit();
            this.dtbegin = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnsaldos = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnrealtime,
            this.v,
            this.btngeneral,
            this.btnclose,
            this.btnrubro,
            this.btnKardex,
            this.btncapitulo,
            this.btnrubrox,
            this.btnsaldos});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(95, 134);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.v),
            new DevExpress.XtraBars.LinkPersistInfo(this.btngeneral),
            new DevExpress.XtraBars.LinkPersistInfo(this.btncapitulo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnKardex),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnrubrox),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnclose)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // v
            // 
            this.v.Caption = "Exportar";
            this.v.Id = 1;
            this.v.ImageOptions.Image = global::LOSA.Properties.Resources.excel_32x32;
            this.v.Name = "v";
            this.v.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.v_ItemClick);
            // 
            // btngeneral
            // 
            this.btngeneral.Caption = "Generar";
            this.btngeneral.Id = 2;
            this.btngeneral.ImageOptions.Image = global::LOSA.Properties.Resources.Generate_32x32;
            this.btngeneral.Name = "btngeneral";
            this.btngeneral.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btngeneral_ItemClick);
            this.btngeneral.ItemDoubleClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btngeneral_ItemDoubleClick);
            // 
            // btncapitulo
            // 
            this.btncapitulo.Caption = "Capitulo";
            this.btncapitulo.Id = 6;
            this.btncapitulo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btncapitulo.ImageOptions.Image")));
            this.btncapitulo.Name = "btncapitulo";
            this.btncapitulo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncapitulo_ItemClick_1);
            // 
            // btnKardex
            // 
            this.btnKardex.Caption = "Kardex";
            this.btnKardex.Id = 5;
            this.btnKardex.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKardex.ImageOptions.Image")));
            this.btnKardex.Name = "btnKardex";
            this.btnKardex.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKardex_ItemClick_1);
            // 
            // btnrubrox
            // 
            this.btnrubrox.Caption = "Rubro";
            this.btnrubrox.Id = 7;
            this.btnrubrox.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnrubrox.ImageOptions.Image")));
            this.btnrubrox.Name = "btnrubrox";
            this.btnrubrox.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnrubrox_ItemClick);
            // 
            // btnclose
            // 
            this.btnclose.Caption = "Cerrar";
            this.btnclose.Id = 3;
            this.btnclose.ImageOptions.Image = global::LOSA.Properties.Resources.cancel2_32;
            this.btnclose.Name = "btnclose";
            this.btnclose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnclose_ItemClick_1);
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(2069, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 697);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(2069, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 647);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2069, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 647);
            // 
            // btnrealtime
            // 
            this.btnrealtime.Caption = "Tiempo real";
            this.btnrealtime.Id = 0;
            this.btnrealtime.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnrealtime.ImageOptions.Image")));
            this.btnrealtime.Name = "btnrealtime";
            this.btnrealtime.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnrealtime_ItemClick);
            // 
            // btnrubro
            // 
            this.btnrubro.Caption = "Rubro";
            this.btnrubro.Id = 4;
            this.btnrubro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnrubro.ImageOptions.Image")));
            this.btnrubro.Name = "btnrubro";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbl);
            this.panelControl1.Controls.Add(this.lblbegin);
            this.panelControl1.Controls.Add(this.dtfin);
            this.panelControl1.Controls.Add(this.dtbegin);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 50);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(2069, 75);
            this.panelControl1.TabIndex = 4;
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(1348, 48);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(70, 16);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Fecha Final:";
            // 
            // lblbegin
            // 
            this.lblbegin.Location = new System.Drawing.Point(1348, 11);
            this.lblbegin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblbegin.Name = "lblbegin";
            this.lblbegin.Size = new System.Drawing.Size(91, 16);
            this.lblbegin.TabIndex = 5;
            this.lblbegin.Text = "Fecha de Inicio:";
            // 
            // dtfin
            // 
            this.dtfin.EditValue = null;
            this.dtfin.Location = new System.Drawing.Point(1520, 39);
            this.dtfin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtfin.MenuManager = this.barManager1;
            this.dtfin.Name = "dtfin";
            this.dtfin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfin.Size = new System.Drawing.Size(487, 22);
            this.dtfin.TabIndex = 4;
            // 
            // dtbegin
            // 
            this.dtbegin.EditValue = null;
            this.dtbegin.Location = new System.Drawing.Point(1520, 7);
            this.dtbegin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtbegin.MenuManager = this.barManager1;
            this.dtbegin.Name = "dtbegin";
            this.dtbegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtbegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtbegin.Size = new System.Drawing.Size(487, 22);
            this.dtbegin.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(99, 11);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(221, 29);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Reporte de Capitulos";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 125);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(2069, 572);
            this.panelControl2.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(2065, 568);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnsaldos
            // 
            this.btnsaldos.Caption = "Saldos totales";
            this.btnsaldos.Id = 8;
            this.btnsaldos.Name = "btnsaldos";
            // 
            // SAR_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2069, 722);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SAR_Main";
            this.Text = "SAR_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarButtonItem btnrealtime;
        private DevExpress.XtraBars.BarButtonItem v;
        private DevExpress.XtraBars.BarButtonItem btngeneral;
        private DevExpress.XtraBars.BarButtonItem btnrubro;
        private DevExpress.XtraBars.BarButtonItem btnKardex;
        private DevExpress.XtraBars.BarButtonItem btncapitulo;
        private DevExpress.XtraBars.BarButtonItem btnclose;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraBars.BarButtonItem btnrubrox;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lbl;
        private DevExpress.XtraEditors.LabelControl lblbegin;
        private DevExpress.XtraEditors.DateEdit dtfin;
        private DevExpress.XtraEditors.DateEdit dtbegin;
        private DevExpress.XtraBars.BarButtonItem btnsaldos;
    }
}