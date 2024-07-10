
namespace LOSA.Presupuesto
{
    partial class DashboardCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardCompras));
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.occotizacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPresupuesto1 = new LOSA.Presupuesto.dsPresupuesto();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barEditItemAnio = new DevExpress.XtraBars.BarEditItem();
            this.reposDtAnio = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barEditItemMes = new DevExpress.XtraBars.BarEditItem();
            this.reposDtMes = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.btnCargarDashboard = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.conteocotizacionesxocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.occotizacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDtAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDtAnio.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDtMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDtMes.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conteocotizacionesxocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // occotizacionesBindingSource
            // 
            this.occotizacionesBindingSource.DataMember = "oc_cotizaciones";
            this.occotizacionesBindingSource.DataSource = this.dsPresupuesto1;
            // 
            // dsPresupuesto1
            // 
            this.dsPresupuesto1.DataSetName = "dsPresupuesto";
            this.dsPresupuesto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barEditItemAnio,
            this.barEditItemMes,
            this.btnCargarDashboard});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposDtAnio,
            this.reposDtMes});
            this.ribbon.Size = new System.Drawing.Size(1414, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barEditItemAnio
            // 
            this.barEditItemAnio.Caption = "Año";
            this.barEditItemAnio.Edit = this.reposDtAnio;
            this.barEditItemAnio.EditWidth = 120;
            this.barEditItemAnio.Id = 1;
            this.barEditItemAnio.Name = "barEditItemAnio";
            // 
            // reposDtAnio
            // 
            this.reposDtAnio.AutoHeight = false;
            this.reposDtAnio.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reposDtAnio.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reposDtAnio.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.reposDtAnio.DisplayFormat.FormatString = "yyyy";
            this.reposDtAnio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.reposDtAnio.EditFormat.FormatString = "yyyy";
            this.reposDtAnio.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.reposDtAnio.MaskSettings.Set("mask", "yyyyy");
            this.reposDtAnio.Name = "reposDtAnio";
            this.reposDtAnio.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.reposDtAnio.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // barEditItemMes
            // 
            this.barEditItemMes.Caption = "Mes";
            this.barEditItemMes.Edit = this.reposDtMes;
            this.barEditItemMes.EditWidth = 120;
            this.barEditItemMes.Id = 2;
            this.barEditItemMes.Name = "barEditItemMes";
            // 
            // reposDtMes
            // 
            this.reposDtMes.AutoHeight = false;
            this.reposDtMes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reposDtMes.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reposDtMes.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.reposDtMes.DisplayFormat.FormatString = "MMMM";
            this.reposDtMes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.reposDtMes.EditFormat.FormatString = "MMMM";
            this.reposDtMes.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.reposDtMes.MaskSettings.Set("mask", "MMMM");
            this.reposDtMes.Name = "reposDtMes";
            this.reposDtMes.VistaCalendarViewStyle = ((DevExpress.XtraEditors.VistaCalendarViewStyle)(((DevExpress.XtraEditors.VistaCalendarViewStyle.YearView | DevExpress.XtraEditors.VistaCalendarViewStyle.QuarterView) 
            | DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView)));
            this.reposDtMes.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // btnCargarDashboard
            // 
            this.btnCargarDashboard.Caption = "Cargar";
            this.btnCargarDashboard.Id = 3;
            this.btnCargarDashboard.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarDashboard.ImageOptions.Image")));
            this.btnCargarDashboard.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCargarDashboard.ImageOptions.LargeImage")));
            this.btnCargarDashboard.Name = "btnCargarDashboard";
            this.btnCargarDashboard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCargarDashboard_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Compras";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditItemAnio);
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditItemMes);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCargarDashboard);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Criterios";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Presupuesto";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 811);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1414, 24);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(12, 164);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.chartControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1390, 312);
            this.splitContainerControl1.SplitterPosition = 691;
            this.splitContainerControl1.TabIndex = 3;
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.conteocotizacionesxocBindingSource;
            simpleDiagram3D1.RotationMatrixSerializable = "0.997993093167614;-0.0375657442861475;-0.0509764734555754;0;-0.0136859188601267;0" +
    ".658038307123656;-0.752860067995898;0;0.0618262210934262;0.752046807861095;0.656" +
    "203563820897;0;0;0;0;1";
            this.chartControl1.Diagram = simpleDiagram3D1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.ItemVisibilityMode = DevExpress.XtraCharts.LegendItemVisibilityMode.AutoGeneratedAndCustom;
            this.chartControl1.Legend.LegendID = -1;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Series 1";
            series1.SeriesID = 2;
            series1.View = pie3DSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(691, 312);
            this.chartControl1.TabIndex = 0;
            // 
            // conteocotizacionesxocBindingSource
            // 
            this.conteocotizacionesxocBindingSource.DataMember = "conteo_cotizacionesxoc";
            this.conteocotizacionesxocBindingSource.DataSource = this.dsPresupuesto1;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Location = new System.Drawing.Point(12, 482);
            this.splitContainerControl2.Name = "splitContainerControl2";
            // 
            // splitContainerControl2.Panel1
            // 
            this.splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // splitContainerControl2.Panel2
            // 
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1390, 323);
            this.splitContainerControl2.SplitterPosition = 692;
            this.splitContainerControl2.TabIndex = 6;
            // 
            // DashboardCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 835);
            this.Controls.Add(this.splitContainerControl2);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "DashboardCompras";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "DashboardCompras";
            ((System.ComponentModel.ISupportInitialize)(this.occotizacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDtAnio.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDtAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDtMes.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDtMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conteocotizacionesxocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarEditItem barEditItemAnio;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit reposDtAnio;
        private DevExpress.XtraBars.BarEditItem barEditItemMes;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit reposDtMes;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.BindingSource occotizacionesBindingSource;
        private dsPresupuesto dsPresupuesto1;
        private DevExpress.XtraBars.BarButtonItem btnCargarDashboard;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource conteocotizacionesxocBindingSource;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
    }
}