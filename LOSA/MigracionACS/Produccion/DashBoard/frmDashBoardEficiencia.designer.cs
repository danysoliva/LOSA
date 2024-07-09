using LOSA.MigracionACS.Produccion.DashBoard;

namespace LOSA.MigracionACS.Produccion.Produccion.DashBoard
{
    partial class frmDashBoardEficiencia
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
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoardEficiencia));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Legend legend1 = new DevExpress.XtraCharts.Legend();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            this.bindingSourceTurnosGroup = new System.Windows.Forms.BindingSource(this.components);
            this.dsDashBoard1 = new LOSA.MigracionACS.Produccion.DashBoard.dsDashBoard();
            this.bindingSourceTMProducidas = new System.Windows.Forms.BindingSource(this.components);
            this.bindingGraficaFallas = new System.Windows.Forms.BindingSource(this.components);
            this.bindingHorasCausasHeader = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceProductividad = new System.Windows.Forms.BindingSource(this.components);
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
            this.panelGrande = new System.Windows.Forms.Panel();
            this.splitContainerSuperMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerHeader = new System.Windows.Forms.SplitContainer();
            this.lblPellet2 = new DevExpress.XtraEditors.LabelControl();
            this.lblPellet1 = new DevExpress.XtraEditors.LabelControl();
            this.lblExtruder = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalPorTurnoGroup = new DevExpress.XtraEditors.LabelControl();
            this.GraficoHorasTrabajadas = new DevExpress.XtraCharts.ChartControl();
            this.lblHoras = new System.Windows.Forms.Label();
            this.GraficoProductividad = new DevExpress.XtraCharts.ChartControl();
            this.lblHorasProductividad = new System.Windows.Forms.Label();
            this.splitContainerBody = new System.Windows.Forms.SplitContainer();
            this.lblHorasDisponibles = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalHoras = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalCausas = new DevExpress.XtraEditors.LabelControl();
            this.grd_extru = new DevExpress.XtraGrid.GridControl();
            this.grdv_extru = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcuenta2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltime_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltime2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoraint2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpromedio2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colview2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnver3 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colid_causa2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_maquina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_s = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.dtDesde = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.dtHasta = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Turno = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barEditMaquinas = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemRadioGroup3 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.Eficiencia = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCuadroLotes = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.cmdResumenBromatologia = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.repositoryItemTimeSpanEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit();
            this.repositoryItemTimeEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemTimeEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemTimeEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.repositoryItemRadioGroup2 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.barEditFechaDesde = new DevExpress.XtraBars.BarEditItem();
            this.dtFechaDesde = new DevExpress.XtraBars.BarEditItem();
            this.dtHoraDesde = new DevExpress.XtraBars.BarEditItem();
            this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.dtFechaHasta = new DevExpress.XtraBars.BarEditItem();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.pMenuExportExcelCausasParo = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTurnosGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDashBoard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTMProducidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingGraficaFallas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingHorasCausasHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProductividad)).BeginInit();
            this.panelGrande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSuperMain)).BeginInit();
            this.splitContainerSuperMain.Panel1.SuspendLayout();
            this.splitContainerSuperMain.Panel2.SuspendLayout();
            this.splitContainerSuperMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHeader)).BeginInit();
            this.splitContainerHeader.Panel1.SuspendLayout();
            this.splitContainerHeader.Panel2.SuspendLayout();
            this.splitContainerHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoHorasTrabajadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoProductividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBody)).BeginInit();
            this.splitContainerBody.Panel1.SuspendLayout();
            this.splitContainerBody.Panel2.SuspendLayout();
            this.splitContainerBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_extru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_extru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnver3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(legend1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeSpanEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMenuExportExcelCausasParo)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceTurnosGroup
            // 
            this.bindingSourceTurnosGroup.DataMember = "turnos_group";
            this.bindingSourceTurnosGroup.DataSource = this.dsDashBoard1;
            // 
            // dsDashBoard1
            // 
            this.dsDashBoard1.DataSetName = "dsDashBoard";
            this.dsDashBoard1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceTMProducidas
            // 
            this.bindingSourceTMProducidas.DataMember = "turnos";
            this.bindingSourceTMProducidas.DataSource = this.dsDashBoard1;
            // 
            // bindingGraficaFallas
            // 
            this.bindingGraficaFallas.DataMember = "Extru 1";
            this.bindingGraficaFallas.DataSource = this.dsDashBoard1;
            // 
            // bindingHorasCausasHeader
            // 
            this.bindingHorasCausasHeader.DataMember = "header_causes";
            this.bindingHorasCausasHeader.DataSource = this.dsDashBoard1;
            // 
            // bindingSourceProductividad
            // 
            this.bindingSourceProductividad.DataMember = "Totales";
            this.bindingSourceProductividad.DataSource = this.dsDashBoard1;
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // barWorkspaceMenuItem1
            // 
            this.barWorkspaceMenuItem1.Caption = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.Id = 2;
            this.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.WorkspaceManager = this.workspaceManager1;
            // 
            // panelGrande
            // 
            this.panelGrande.Controls.Add(this.splitContainerSuperMain);
            this.panelGrande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrande.Location = new System.Drawing.Point(0, 153);
            this.panelGrande.Name = "panelGrande";
            this.panelGrande.Size = new System.Drawing.Size(1345, 511);
            this.panelGrande.TabIndex = 3;
            // 
            // splitContainerSuperMain
            // 
            this.splitContainerSuperMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerSuperMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSuperMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerSuperMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainerSuperMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerSuperMain.Name = "splitContainerSuperMain";
            this.splitContainerSuperMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerSuperMain.Panel1
            // 
            this.splitContainerSuperMain.Panel1.Controls.Add(this.splitContainerHeader);
            // 
            // splitContainerSuperMain.Panel2
            // 
            this.splitContainerSuperMain.Panel2.Controls.Add(this.splitContainerBody);
            this.splitContainerSuperMain.Size = new System.Drawing.Size(1345, 511);
            this.splitContainerSuperMain.SplitterDistance = 244;
            this.splitContainerSuperMain.SplitterWidth = 8;
            this.splitContainerSuperMain.TabIndex = 3;
            // 
            // splitContainerHeader
            // 
            this.splitContainerHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHeader.Location = new System.Drawing.Point(0, 0);
            this.splitContainerHeader.Name = "splitContainerHeader";
            // 
            // splitContainerHeader.Panel1
            // 
            this.splitContainerHeader.Panel1.Controls.Add(this.lblPellet2);
            this.splitContainerHeader.Panel1.Controls.Add(this.lblPellet1);
            this.splitContainerHeader.Panel1.Controls.Add(this.lblExtruder);
            this.splitContainerHeader.Panel1.Controls.Add(this.lblTotalPorTurnoGroup);
            this.splitContainerHeader.Panel1.Controls.Add(this.GraficoHorasTrabajadas);
            this.splitContainerHeader.Panel1.Controls.Add(this.lblHoras);
            // 
            // splitContainerHeader.Panel2
            // 
            this.splitContainerHeader.Panel2.Controls.Add(this.GraficoProductividad);
            this.splitContainerHeader.Panel2.Controls.Add(this.lblHorasProductividad);
            this.splitContainerHeader.Size = new System.Drawing.Size(1343, 242);
            this.splitContainerHeader.SplitterDistance = 634;
            this.splitContainerHeader.SplitterWidth = 8;
            this.splitContainerHeader.TabIndex = 0;
            // 
            // lblPellet2
            // 
            this.lblPellet2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPellet2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPellet2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPellet2.Appearance.Options.UseBackColor = true;
            this.lblPellet2.Appearance.Options.UseFont = true;
            this.lblPellet2.Location = new System.Drawing.Point(320, 225);
            this.lblPellet2.Name = "lblPellet2";
            this.lblPellet2.Size = new System.Drawing.Size(93, 14);
            this.lblPellet2.TabIndex = 5;
            this.lblPellet2.Text = "Total 00.00 TM";
            // 
            // lblPellet1
            // 
            this.lblPellet1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPellet1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPellet1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPellet1.Appearance.Options.UseBackColor = true;
            this.lblPellet1.Appearance.Options.UseFont = true;
            this.lblPellet1.Location = new System.Drawing.Point(164, 225);
            this.lblPellet1.Name = "lblPellet1";
            this.lblPellet1.Size = new System.Drawing.Size(93, 14);
            this.lblPellet1.TabIndex = 4;
            this.lblPellet1.Text = "Total 00.00 TM";
            // 
            // lblExtruder
            // 
            this.lblExtruder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblExtruder.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblExtruder.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtruder.Appearance.Options.UseBackColor = true;
            this.lblExtruder.Appearance.Options.UseFont = true;
            this.lblExtruder.Location = new System.Drawing.Point(3, 225);
            this.lblExtruder.Name = "lblExtruder";
            this.lblExtruder.Size = new System.Drawing.Size(93, 14);
            this.lblExtruder.TabIndex = 3;
            this.lblExtruder.Text = "Total 00.00 TM";
            // 
            // lblTotalPorTurnoGroup
            // 
            this.lblTotalPorTurnoGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPorTurnoGroup.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPorTurnoGroup.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPorTurnoGroup.Appearance.Options.UseBackColor = true;
            this.lblTotalPorTurnoGroup.Appearance.Options.UseFont = true;
            this.lblTotalPorTurnoGroup.Location = new System.Drawing.Point(515, 225);
            this.lblTotalPorTurnoGroup.Name = "lblTotalPorTurnoGroup";
            this.lblTotalPorTurnoGroup.Size = new System.Drawing.Size(93, 14);
            this.lblTotalPorTurnoGroup.TabIndex = 2;
            this.lblTotalPorTurnoGroup.Text = "Total 00.00 TM";
            // 
            // GraficoHorasTrabajadas
            // 
            this.GraficoHorasTrabajadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraficoHorasTrabajadas.DataSource = this.bindingSourceTurnosGroup;
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.DefaultPane.StackedBarTotalLabel.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.DefaultPane.StackedBarTotalLabel.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 9F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            xyDiagram1.DefaultPane.StackedBarTotalLabel.ShowConnector = true;
            xyDiagram1.DefaultPane.StackedBarTotalLabel.TextAlignment = System.Drawing.StringAlignment.Near;
            xyDiagram1.DefaultPane.StackedBarTotalLabel.TextPattern = "{TV:#.00}";
            xyDiagram1.DefaultPane.StackedBarTotalLabel.Visible = true;
            this.GraficoHorasTrabajadas.Diagram = xyDiagram1;
            this.GraficoHorasTrabajadas.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.GraficoHorasTrabajadas.Legend.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GraficoHorasTrabajadas.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.GraficoHorasTrabajadas.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            this.GraficoHorasTrabajadas.Legend.ItemVisibilityMode = DevExpress.XtraCharts.LegendItemVisibilityMode.AutoGeneratedAndCustom;
            this.GraficoHorasTrabajadas.Legend.LegendID = -1;
            this.GraficoHorasTrabajadas.Legend.MarkerSize = new System.Drawing.Size(17, 12);
            this.GraficoHorasTrabajadas.Legend.Name = "LegendDefault";
            this.GraficoHorasTrabajadas.Legend.TextColor = System.Drawing.Color.Black;
            this.GraficoHorasTrabajadas.Legend.Title.Text = "";
            this.GraficoHorasTrabajadas.Legend.Title.Visible = true;
            this.GraficoHorasTrabajadas.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.GraficoHorasTrabajadas.Location = new System.Drawing.Point(0, 24);
            this.GraficoHorasTrabajadas.Name = "GraficoHorasTrabajadas";
            this.GraficoHorasTrabajadas.SeriesDataMember = "maquina";
            series1.ArgumentDataMember = "turno";
            series1.CrosshairHighlightPoints = DevExpress.Utils.DefaultBoolean.False;
            series1.CrosshairLabelVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.DataSource = this.bindingSourceTurnosGroup;
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            sideBySideBarSeriesLabel1.TextPattern = "{V:#.00}";
            series1.Label = sideBySideBarSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.LegendName = "LegendDefault";
            series1.SeriesID = 0;
            series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            series1.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            series1.ToolTipHintDataMember = "turno";
            series1.ToolTipSeriesPattern = "";
            series1.TopNOptions.Enabled = true;
            this.GraficoHorasTrabajadas.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.GraficoHorasTrabajadas.SeriesTemplate.ArgumentDataMember = "turno";
            this.GraficoHorasTrabajadas.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.GraficoHorasTrabajadas.SeriesTemplate.LegendName = "LegendDefault";
            this.GraficoHorasTrabajadas.SeriesTemplate.LegendTextPattern = "{A}";
            this.GraficoHorasTrabajadas.SeriesTemplate.SeriesDataMember = "maquina";
            this.GraficoHorasTrabajadas.SeriesTemplate.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending;
            this.GraficoHorasTrabajadas.SeriesTemplate.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            this.GraficoHorasTrabajadas.SeriesTemplate.ValueDataMembersSerializable = "tm";
            this.GraficoHorasTrabajadas.Size = new System.Drawing.Size(634, 200);
            this.GraficoHorasTrabajadas.SmallChartText.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.False;
            this.GraficoHorasTrabajadas.TabIndex = 1;
            this.GraficoHorasTrabajadas.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            this.GraficoHorasTrabajadas.ToolTipOptions.ShowForSeries = true;
            // 
            // lblHoras
            // 
            this.lblHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblHoras.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHoras.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(0, 0);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(634, 22);
            this.lblHoras.TabIndex = 0;
            this.lblHoras.Text = "Producción (TM por Turno y Linea)";
            this.lblHoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GraficoProductividad
            // 
            this.GraficoProductividad.DataSource = this.bindingSourceTMProducidas;
            this.GraficoProductividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GraficoProductividad.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.GraficoProductividad.Legend.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GraficoProductividad.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.GraficoProductividad.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            this.GraficoProductividad.Legend.ItemVisibilityMode = DevExpress.XtraCharts.LegendItemVisibilityMode.AutoGeneratedAndCustom;
            this.GraficoProductividad.Legend.LegendID = -1;
            this.GraficoProductividad.Legend.MarkerSize = new System.Drawing.Size(30, 15);
            this.GraficoProductividad.Legend.Name = "LegendDefault";
            this.GraficoProductividad.Legend.TextColor = System.Drawing.Color.Black;
            this.GraficoProductividad.Legend.Title.Text = "Turnos";
            this.GraficoProductividad.Legend.Title.Visible = true;
            this.GraficoProductividad.Legend.VerticalIndent = 3;
            this.GraficoProductividad.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.GraficoProductividad.Location = new System.Drawing.Point(0, 22);
            this.GraficoProductividad.Name = "GraficoProductividad";
            series2.ArgumentDataMember = "turno";
            series2.CrosshairHighlightPoints = DevExpress.Utils.DefaultBoolean.False;
            series2.CrosshairLabelVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.DataSource = this.bindingSourceTMProducidas;
            pieSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            pieSeriesLabel1.TextPattern = "{VP:0%}   {A}    {V:#0.0 TM}";
            series2.Label = pieSeriesLabel1;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.LegendName = "LegendDefault";
            series2.Name = "Chart";
            series2.SeriesID = 0;
            series2.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            series2.ToolTipHintDataMember = "turno";
            series2.ToolTipImage.Tag = "Turno";
            series2.ToolTipSeriesPattern = "";
            series2.TopNOptions.Enabled = true;
            series2.ValueDataMembersSerializable = "tm";
            pieSeriesView1.MinAllowedSizePercentage = 60D;
            pieSeriesView1.TotalLabel.TextPattern = "{TV:#.00 TM}";
            pieSeriesView1.TotalLabel.Visible = true;
            series2.View = pieSeriesView1;
            this.GraficoProductividad.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.GraficoProductividad.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.GraficoProductividad.SeriesTemplate.LegendTextPattern = "{A}";
            this.GraficoProductividad.SeriesTemplate.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending;
            this.GraficoProductividad.SeriesTemplate.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            this.GraficoProductividad.Size = new System.Drawing.Size(701, 220);
            this.GraficoProductividad.SmallChartText.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.False;
            this.GraficoProductividad.TabIndex = 2;
            this.GraficoProductividad.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            this.GraficoProductividad.ToolTipOptions.ShowForSeries = true;
            // 
            // lblHorasProductividad
            // 
            this.lblHorasProductividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblHorasProductividad.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHorasProductividad.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasProductividad.Location = new System.Drawing.Point(0, 0);
            this.lblHorasProductividad.Name = "lblHorasProductividad";
            this.lblHorasProductividad.Size = new System.Drawing.Size(701, 22);
            this.lblHorasProductividad.TabIndex = 1;
            this.lblHorasProductividad.Text = "Productividad (TM por Turno)";
            this.lblHorasProductividad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainerBody
            // 
            this.splitContainerBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBody.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBody.Name = "splitContainerBody";
            // 
            // splitContainerBody.Panel1
            // 
            this.splitContainerBody.Panel1.Controls.Add(this.lblHorasDisponibles);
            this.splitContainerBody.Panel1.Controls.Add(this.lblTotalHoras);
            this.splitContainerBody.Panel1.Controls.Add(this.lblTotalCausas);
            this.splitContainerBody.Panel1.Controls.Add(this.grd_extru);
            // 
            // splitContainerBody.Panel2
            // 
            this.splitContainerBody.Panel2.Controls.Add(this.chartControl1);
            this.splitContainerBody.Size = new System.Drawing.Size(1343, 257);
            this.splitContainerBody.SplitterDistance = 635;
            this.splitContainerBody.SplitterWidth = 8;
            this.splitContainerBody.TabIndex = 0;
            // 
            // lblHorasDisponibles
            // 
            this.lblHorasDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHorasDisponibles.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblHorasDisponibles.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasDisponibles.Appearance.Options.UseBackColor = true;
            this.lblHorasDisponibles.Appearance.Options.UseFont = true;
            this.lblHorasDisponibles.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblHorasDisponibles.Location = new System.Drawing.Point(359, 236);
            this.lblHorasDisponibles.Name = "lblHorasDisponibles";
            this.lblHorasDisponibles.Size = new System.Drawing.Size(113, 16);
            this.lblHorasDisponibles.TabIndex = 5;
            this.lblHorasDisponibles.Text = "Total 00.00 horas";
            // 
            // lblTotalHoras
            // 
            this.lblTotalHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalHoras.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalHoras.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHoras.Appearance.Options.UseBackColor = true;
            this.lblTotalHoras.Appearance.Options.UseFont = true;
            this.lblTotalHoras.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblTotalHoras.Location = new System.Drawing.Point(209, 236);
            this.lblTotalHoras.Name = "lblTotalHoras";
            this.lblTotalHoras.Size = new System.Drawing.Size(113, 16);
            this.lblTotalHoras.TabIndex = 4;
            this.lblTotalHoras.Text = "Total 00.00 horas";
            // 
            // lblTotalCausas
            // 
            this.lblTotalCausas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalCausas.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCausas.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCausas.Appearance.Options.UseBackColor = true;
            this.lblTotalCausas.Appearance.Options.UseFont = true;
            this.lblTotalCausas.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblTotalCausas.Location = new System.Drawing.Point(5, 236);
            this.lblTotalCausas.Name = "lblTotalCausas";
            this.lblTotalCausas.Size = new System.Drawing.Size(113, 16);
            this.lblTotalCausas.TabIndex = 1;
            this.lblTotalCausas.Text = "Total 00.00 horas";
            this.lblTotalCausas.Visible = false;
            this.lblTotalCausas.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // grd_extru
            // 
            this.grd_extru.DataMember = "Extru 1";
            this.grd_extru.DataSource = this.dsDashBoard1;
            this.grd_extru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_extru.Location = new System.Drawing.Point(0, 0);
            this.grd_extru.MainView = this.grdv_extru;
            this.grd_extru.Name = "grd_extru";
            this.grd_extru.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnver3});
            this.grd_extru.Size = new System.Drawing.Size(635, 257);
            this.grd_extru.TabIndex = 3;
            this.grd_extru.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_extru});
            // 
            // grdv_extru
            // 
            this.grdv_extru.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_extru.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_extru.Appearance.FooterPanel.BackColor = System.Drawing.Color.White;
            this.grdv_extru.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_extru.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grdv_extru.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_extru.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_extru.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_extru.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_extru.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_extru.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.grdv_extru.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_extru.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_extru.Appearance.Row.Options.UseFont = true;
            this.grdv_extru.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion2,
            this.colname2,
            this.colcuenta2,
            this.coltime_,
            this.coltime2,
            this.colhoraint2,
            this.colpromedio2,
            this.colview2,
            this.colid_causa2,
            this.colid_maquina,
            this.colid,
            this.colhora_s});
            this.grdv_extru.GridControl = this.grd_extru;
            this.grdv_extru.GroupCount = 1;
            this.grdv_extru.Name = "grdv_extru";
            this.grdv_extru.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_extru.OptionsBehavior.ReadOnly = true;
            this.grdv_extru.OptionsView.ShowFooter = true;
            this.grdv_extru.OptionsView.ShowGroupPanel = false;
            this.grdv_extru.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colname2, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grdv_extru.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdv_extru_RowClick);
            // 
            // coldescripcion2
            // 
            this.coldescripcion2.Caption = "Causa";
            this.coldescripcion2.FieldName = "descripcion";
            this.coldescripcion2.Name = "coldescripcion2";
            this.coldescripcion2.OptionsColumn.AllowEdit = false;
            this.coldescripcion2.Visible = true;
            this.coldescripcion2.VisibleIndex = 0;
            this.coldescripcion2.Width = 185;
            // 
            // colname2
            // 
            this.colname2.Caption = "Maquina";
            this.colname2.FieldName = "name";
            this.colname2.Name = "colname2";
            this.colname2.OptionsColumn.AllowEdit = false;
            this.colname2.Visible = true;
            this.colname2.VisibleIndex = 1;
            // 
            // colcuenta2
            // 
            this.colcuenta2.Caption = "Cantidad";
            this.colcuenta2.FieldName = "cuenta";
            this.colcuenta2.Name = "colcuenta2";
            this.colcuenta2.OptionsColumn.AllowEdit = false;
            this.colcuenta2.Visible = true;
            this.colcuenta2.VisibleIndex = 1;
            this.colcuenta2.Width = 68;
            // 
            // coltime_
            // 
            this.coltime_.Caption = "Horas";
            this.coltime_.FieldName = "time_";
            this.coltime_.Name = "coltime_";
            this.coltime_.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "time_", "{0:hh\\:mm\\:ss} ", "Total Horas")});
            this.coltime_.Width = 97;
            // 
            // coltime2
            // 
            this.coltime2.Caption = "Horas";
            this.coltime2.FieldName = "time";
            this.coltime2.Name = "coltime2";
            this.coltime2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "time", "Suma: {0:dd\\ hh\\:mm\\:ss} ")});
            this.coltime2.Width = 83;
            // 
            // colhoraint2
            // 
            this.colhoraint2.FieldName = "horaint";
            this.colhoraint2.Name = "colhoraint2";
            // 
            // colpromedio2
            // 
            this.colpromedio2.Caption = "Porcentaje";
            this.colpromedio2.DisplayFormat.FormatString = "{0:#.##} %";
            this.colpromedio2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpromedio2.FieldName = "promedio";
            this.colpromedio2.GroupFormat.FormatString = " %";
            this.colpromedio2.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpromedio2.Name = "colpromedio2";
            this.colpromedio2.OptionsColumn.AllowEdit = false;
            this.colpromedio2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "promedio", "Suma: {0:#.##} %")});
            this.colpromedio2.Visible = true;
            this.colpromedio2.VisibleIndex = 3;
            this.colpromedio2.Width = 80;
            // 
            // colview2
            // 
            this.colview2.Caption = "Detalle";
            this.colview2.ColumnEdit = this.btnver3;
            this.colview2.Name = "colview2";
            this.colview2.Visible = true;
            this.colview2.VisibleIndex = 4;
            this.colview2.Width = 57;
            // 
            // btnver3
            // 
            this.btnver3.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnver3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnver3.Name = "btnver3";
            this.btnver3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnver3.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnver3_ButtonClick);
            // 
            // colid_causa2
            // 
            this.colid_causa2.FieldName = "id_causa";
            this.colid_causa2.Name = "colid_causa2";
            // 
            // colid_maquina
            // 
            this.colid_maquina.FieldName = "id_maquina";
            this.colid_maquina.Name = "colid_maquina";
            // 
            // colid
            // 
            this.colid.Caption = "id tipo causa";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colhora_s
            // 
            this.colhora_s.Caption = "Horas";
            this.colhora_s.FieldName = "hora_s";
            this.colhora_s.Name = "colhora_s";
            this.colhora_s.OptionsColumn.AllowEdit = false;
            this.colhora_s.Visible = true;
            this.colhora_s.VisibleIndex = 2;
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.bindingGraficaFallas;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram2.DefaultPane.StackedBarTotalLabel.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 9F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {
            new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            xyDiagram2.DefaultPane.StackedBarTotalLabel.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram2.DefaultPane.StackedBarTotalLabel.ShowConnector = true;
            xyDiagram2.Rotated = true;
            this.chartControl1.Diagram = xyDiagram2;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.LegendID = -1;
            this.chartControl1.Legend.Name = "Default Legend";
            legend1.LegendID = 0;
            legend1.Name = "Legend1";
            this.chartControl1.Legends.AddRange(new DevExpress.XtraCharts.Legend[] {
            legend1});
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series3.ArgumentDataMember = "descripcion";
            series3.DataSorted = true;
            series3.DataSource = this.bindingGraficaFallas;
            sideBySideBarSeriesLabel2.TextPattern = "{V:#.00} %";
            series3.Label = sideBySideBarSeriesLabel2;
            series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series3.LegendName = "Default Legend";
            series3.LegendTextPattern = "{V}";
            series3.Name = "Series 1";
            series3.SeriesID = 0;
            series3.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            series3.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            series3.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            series3.ToolTipPointPattern = "{V}";
            series3.TopNOptions.Enabled = true;
            series3.ValueDataMembersSerializable = "promedio";
            sideBySideBarSeriesView1.BarWidth = 0.7D;
            sideBySideBarSeriesView1.ColorEach = true;
            series3.View = sideBySideBarSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.chartControl1.SeriesSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "descripcion";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "promedio";
            this.chartControl1.Size = new System.Drawing.Size(700, 257);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.ToolTipOptions.ShowForSeries = true;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.Eficiencia,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Filtros";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barStaticItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.dtDesde);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Fecha Desde";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Fecha Hora Desde";
            this.barStaticItem1.Id = 8;
            this.barStaticItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStaticItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // dtDesde
            // 
            this.dtDesde.Edit = this.repositoryItemDateEdit3;
            this.dtDesde.EditValue = new System.DateTime(2020, 3, 26, 16, 59, 1, 81);
            this.dtDesde.EditWidth = 150;
            this.dtDesde.Id = 12;
            this.dtDesde.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.ItemAppearance.Normal.Options.UseFont = true;
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.EditValueChanged += new System.EventHandler(this.dtDesde_EditValueChanged_1);
            // 
            // repositoryItemDateEdit3
            // 
            this.repositoryItemDateEdit3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemDateEdit3.Appearance.Options.UseFont = true;
            this.repositoryItemDateEdit3.AutoHeight = false;
            this.repositoryItemDateEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.DisplayFormat.FormatString = "g";
            this.repositoryItemDateEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit3.EditFormat.FormatString = "g";
            this.repositoryItemDateEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit3.Mask.EditMask = "g";
            this.repositoryItemDateEdit3.MinValue = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.repositoryItemDateEdit3.Name = "repositoryItemDateEdit3";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barStaticItem2);
            this.ribbonPageGroup2.ItemLinks.Add(this.dtHasta);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Fecha Hasta";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Fecha Hora Hasta";
            this.barStaticItem2.Id = 9;
            this.barStaticItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStaticItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // dtHasta
            // 
            this.dtHasta.Edit = this.repositoryItemDateEdit4;
            this.dtHasta.EditWidth = 150;
            this.dtHasta.Id = 14;
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.EditValueChanged += new System.EventHandler(this.dtHasta_EditValueChanged);
            // 
            // repositoryItemDateEdit4
            // 
            this.repositoryItemDateEdit4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemDateEdit4.Appearance.Options.UseFont = true;
            this.repositoryItemDateEdit4.AutoHeight = false;
            this.repositoryItemDateEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit4.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemDateEdit4.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit4.DisplayFormat.FormatString = "g";
            this.repositoryItemDateEdit4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit4.EditFormat.FormatString = "g";
            this.repositoryItemDateEdit4.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit4.Mask.EditMask = "g";
            this.repositoryItemDateEdit4.MinValue = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.repositoryItemDateEdit4.Name = "repositoryItemDateEdit4";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup3.ItemLinks.Add(this.Turno);
            this.ribbonPageGroup3.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.ThreeRows;
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            this.ribbonPageGroup3.Text = "Turno";
            // 
            // Turno
            // 
            this.Turno.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.Turno.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.True;
            this.Turno.CausesValidation = true;
            this.Turno.Edit = this.repositoryItemRadioGroup1;
            this.Turno.EditHeight = 50;
            this.Turno.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.Turno.EditValue = 4;
            this.Turno.EditWidth = 250;
            this.Turno.Id = 21;
            this.Turno.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.Turno.ImageOptions.ImageUri.Uri = "Today";
            this.Turno.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turno.ItemAppearance.Normal.Options.UseFont = true;
            this.Turno.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Immediate;
            this.Turno.Name = "Turno";
            this.Turno.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.Turno.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.Turno.VisibleWhenVertical = true;
            this.Turno.EditValueChanged += new System.EventHandler(this.Turno_EditValueChanged);
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemRadioGroup1.Appearance.Options.UseFont = true;
            this.repositoryItemRadioGroup1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemRadioGroup1.ColumnIndent = 30;
            this.repositoryItemRadioGroup1.Columns = 2;
            this.repositoryItemRadioGroup1.EnableFocusRect = true;
            this.repositoryItemRadioGroup1.ItemHorzAlignment = DevExpress.XtraEditors.RadioItemHorzAlignment.Near;
            this.repositoryItemRadioGroup1.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Turno 1"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Turno 2"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Turno 3"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Todos")});
            this.repositoryItemRadioGroup1.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Column;
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.barEditMaquinas);
            this.ribbonPageGroup4.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.ThreeRows;
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            this.ribbonPageGroup4.Text = "Maquinas";
            // 
            // barEditMaquinas
            // 
            this.barEditMaquinas.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.True;
            this.barEditMaquinas.CaptionAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.barEditMaquinas.CausesValidation = true;
            this.barEditMaquinas.Edit = this.repositoryItemRadioGroup3;
            this.barEditMaquinas.EditHeight = 60;
            this.barEditMaquinas.EditValue = 5;
            this.barEditMaquinas.EditWidth = 250;
            this.barEditMaquinas.Id = 23;
            this.barEditMaquinas.Name = "barEditMaquinas";
            this.barEditMaquinas.EditValueChanged += new System.EventHandler(this.barEditMaquinas_EditValueChanged);
            // 
            // repositoryItemRadioGroup3
            // 
            this.repositoryItemRadioGroup3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemRadioGroup3.Appearance.Options.UseFont = true;
            this.repositoryItemRadioGroup3.ColumnIndent = 40;
            this.repositoryItemRadioGroup3.Columns = 2;
            this.repositoryItemRadioGroup3.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemRadioGroup3.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Pellet 1"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Pellet 2"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Ambas Pellet"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Extruder"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(5, "Todas")});
            this.repositoryItemRadioGroup3.Name = "repositoryItemRadioGroup3";
            // 
            // Eficiencia
            // 
            this.Eficiencia.AllowTextClipping = false;
            this.Eficiencia.ItemLinks.Add(this.barButtonItem1);
            this.Eficiencia.ItemLinks.Add(this.barButtonItem2);
            this.Eficiencia.ItemLinks.Add(this.btnCuadroLotes);
            this.Eficiencia.Name = "Eficiencia";
            this.Eficiencia.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            this.Eficiencia.Text = "Eficiencia";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Eficiencia";
            this.barButtonItem1.Id = 25;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Reproceso";
            this.barButtonItem2.Id = 26;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnCuadroLotes
            // 
            this.btnCuadroLotes.Caption = "Cuadro de Lotes";
            this.btnCuadroLotes.Id = 27;
            this.btnCuadroLotes.Name = "btnCuadroLotes";
            this.btnCuadroLotes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCuadroLotes_ItemClick);
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.cmdResumenBromatologia);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Bromatología";
            // 
            // cmdResumenBromatologia
            // 
            this.cmdResumenBromatologia.Caption = "Resumen Bromatologico";
            this.cmdResumenBromatologia.Id = 28;
            this.cmdResumenBromatologia.Name = "cmdResumenBromatologia";
            this.cmdResumenBromatologia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmdResumenBromatologia_ItemClick);
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.repositoryItemTimeEdit1.EditFormat.FormatString = "g";
            this.repositoryItemTimeEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemTimeEdit1.Mask.EditMask = "d";
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            this.repositoryItemTimeEdit1.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.repositoryItemTimeEdit1.TouchUIMinValue = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // repositoryItemTimeSpanEdit1
            // 
            this.repositoryItemTimeSpanEdit1.AutoHeight = false;
            this.repositoryItemTimeSpanEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeSpanEdit1.Mask.EditMask = "dd.HH:mm:ss";
            this.repositoryItemTimeSpanEdit1.Name = "repositoryItemTimeSpanEdit1";
            // 
            // repositoryItemTimeEdit2
            // 
            this.repositoryItemTimeEdit2.AutoHeight = false;
            this.repositoryItemTimeEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit2.Name = "repositoryItemTimeEdit2";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // repositoryItemTimeEdit3
            // 
            this.repositoryItemTimeEdit3.AutoHeight = false;
            this.repositoryItemTimeEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit3.Name = "repositoryItemTimeEdit3";
            this.repositoryItemTimeEdit3.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.repositoryItemTimeEdit3.TouchUIMinValue = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // repositoryItemTimeEdit4
            // 
            this.repositoryItemTimeEdit4.AutoHeight = false;
            this.repositoryItemTimeEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit4.Name = "repositoryItemTimeEdit4";
            this.repositoryItemTimeEdit4.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.repositoryItemTimeEdit4.TouchUIMinValue = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // repositoryItemRadioGroup2
            // 
            this.repositoryItemRadioGroup2.Name = "repositoryItemRadioGroup2";
            // 
            // barEditFechaDesde
            // 
            this.barEditFechaDesde.Edit = null;
            this.barEditFechaDesde.Id = 16;
            this.barEditFechaDesde.Name = "barEditFechaDesde";
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.Edit = null;
            this.dtFechaDesde.Id = 18;
            this.dtFechaDesde.Name = "dtFechaDesde";
            // 
            // dtHoraDesde
            // 
            this.dtHoraDesde.Edit = null;
            this.dtHoraDesde.Id = 19;
            this.dtHoraDesde.Name = "dtHoraDesde";
            // 
            // barDockingMenuItem1
            // 
            this.barDockingMenuItem1.Caption = "barDockingMenuItem1";
            this.barDockingMenuItem1.CausesValidation = true;
            this.barDockingMenuItem1.Id = 7;
            this.barDockingMenuItem1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.barDockingMenuItem1.Name = "barDockingMenuItem1";
            this.barDockingMenuItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            this.barDockingMenuItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.Edit = null;
            this.dtFechaHasta.Id = 20;
            this.dtFechaHasta.Name = "dtFechaHasta";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "barEditItem3";
            this.barEditItem3.Edit = this.repositoryItemRadioGroup2;
            this.barEditItem3.Id = 22;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowCustomization = true;
            this.ribbonControl1.AllowGlyphSkinning = true;
            this.ribbonControl1.AllowInplaceLinks = true;
            this.ribbonControl1.AutoHideEmptyItems = true;
            this.ribbonControl1.AutoSizeItems = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barEditFechaDesde,
            this.dtFechaDesde,
            this.dtHoraDesde,
            this.barDockingMenuItem1,
            this.barStaticItem1,
            this.barStaticItem2,
            this.dtFechaHasta,
            this.dtDesde,
            this.dtHasta,
            this.Turno,
            this.barEditItem3,
            this.barEditMaquinas,
            this.barLinkContainerItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnCuadroLotes,
            this.cmdResumenBromatologia,
            this.barButtonItem3});
            this.ribbonControl1.ItemsVertAlign = DevExpress.Utils.VertAlignment.Center;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 30;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsAnimation.PageCategoryShowAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.OptionsCustomizationForm.AllowEditBarItemPopups = true;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTimeEdit1,
            this.repositoryItemTimeSpanEdit1,
            this.repositoryItemTimeEdit2,
            this.repositoryItemDateEdit1,
            this.repositoryItemTimeEdit3,
            this.repositoryItemDateEdit2,
            this.repositoryItemTimeEdit4,
            this.repositoryItemDateEdit3,
            this.repositoryItemDateEdit4,
            this.repositoryItemRadioGroup1,
            this.repositoryItemRadioGroup2,
            this.repositoryItemRadioGroup3});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.ShowItemCaptionsInPageHeader = true;
            this.ribbonControl1.Size = new System.Drawing.Size(1345, 153);
            // 
            // barLinkContainerItem1
            // 
            this.barLinkContainerItem1.Caption = "barLinkContainerItem1";
            this.barLinkContainerItem1.Id = 24;
            this.barLinkContainerItem1.Name = "barLinkContainerItem1";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Export To Excel";
            this.barButtonItem3.Id = 29;
            this.barButtonItem3.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // pMenuExportExcelCausasParo
            // 
            this.pMenuExportExcelCausasParo.ItemLinks.Add(this.barButtonItem3);
            this.pMenuExportExcelCausasParo.Name = "pMenuExportExcelCausasParo";
            this.pMenuExportExcelCausasParo.Ribbon = this.ribbonControl1;
            // 
            // frmDashBoardEficiencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 664);
            this.Controls.Add(this.panelGrande);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmDashBoardEficiencia";
            this.Text = "DashBoard Eficiencia por Turno";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTurnosGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDashBoard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTMProducidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingGraficaFallas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingHorasCausasHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProductividad)).EndInit();
            this.panelGrande.ResumeLayout(false);
            this.splitContainerSuperMain.Panel1.ResumeLayout(false);
            this.splitContainerSuperMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSuperMain)).EndInit();
            this.splitContainerSuperMain.ResumeLayout(false);
            this.splitContainerHeader.Panel1.ResumeLayout(false);
            this.splitContainerHeader.Panel1.PerformLayout();
            this.splitContainerHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHeader)).EndInit();
            this.splitContainerHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoHorasTrabajadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoProductividad)).EndInit();
            this.splitContainerBody.Panel1.ResumeLayout(false);
            this.splitContainerBody.Panel1.PerformLayout();
            this.splitContainerBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBody)).EndInit();
            this.splitContainerBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_extru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_extru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnver3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(legend1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeSpanEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMenuExportExcelCausasParo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraBars.BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private System.Windows.Forms.Panel panelGrande;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarEditItem barEditFechaDesde;
        private DevExpress.XtraBars.BarEditItem dtFechaDesde;
        private DevExpress.XtraBars.BarEditItem dtHoraDesde;
        private DevExpress.XtraBars.BarDockingMenuItem barDockingMenuItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarEditItem dtFechaHasta;
        private DevExpress.XtraBars.BarEditItem dtDesde;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit3;
        private DevExpress.XtraBars.BarEditItem dtHasta;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit4;
        public DevExpress.XtraBars.BarEditItem Turno;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup2;
        private DevExpress.XtraBars.BarEditItem barEditMaquinas;
        public DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit4;
        private dsDashBoard dsDashBoard1;
        public System.Windows.Forms.SplitContainer splitContainerSuperMain;
        private System.Windows.Forms.SplitContainer splitContainerHeader;
        private System.Windows.Forms.SplitContainer splitContainerBody;
        private DevExpress.XtraGrid.GridControl grd_extru;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_extru;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion2;
        private DevExpress.XtraGrid.Columns.GridColumn colname2;
        private DevExpress.XtraGrid.Columns.GridColumn colcuenta2;
        private DevExpress.XtraGrid.Columns.GridColumn coltime2;
        private DevExpress.XtraGrid.Columns.GridColumn colhoraint2;
        private DevExpress.XtraGrid.Columns.GridColumn colpromedio2;
        private DevExpress.XtraGrid.Columns.GridColumn colview2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnver3;
        private DevExpress.XtraGrid.Columns.GridColumn colid_causa2;
        private DevExpress.XtraGrid.Columns.GridColumn coltime_;
        private System.Windows.Forms.BindingSource bindingGraficaFallas;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblHorasProductividad;
        private System.Windows.Forms.BindingSource bindingHorasCausasHeader;
        private DevExpress.XtraCharts.ChartControl GraficoHorasTrabajadas;
        private DevExpress.XtraCharts.ChartControl GraficoProductividad;
        private System.Windows.Forms.BindingSource bindingSourceProductividad;
        private System.Windows.Forms.BindingSource bindingSourceTMProducidas;
        private DevExpress.XtraGrid.Columns.GridColumn colid_maquina;
        private System.Windows.Forms.BindingSource bindingSourceTurnosGroup;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraEditors.LabelControl lblTotalCausas;
        private DevExpress.XtraEditors.LabelControl lblTotalPorTurnoGroup;
        private DevExpress.XtraBars.BarLinkContainerItem barLinkContainerItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Eficiencia;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_s;
        private DevExpress.XtraEditors.LabelControl lblTotalHoras;
        private DevExpress.XtraEditors.LabelControl lblHorasDisponibles;
        private DevExpress.XtraEditors.LabelControl lblExtruder;
        private DevExpress.XtraEditors.LabelControl lblPellet2;
        private DevExpress.XtraEditors.LabelControl lblPellet1;
        private DevExpress.XtraBars.BarButtonItem btnCuadroLotes;
        private DevExpress.XtraBars.BarButtonItem cmdResumenBromatologia;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.PopupMenu pMenuExportExcelCausasParo;
    }
}