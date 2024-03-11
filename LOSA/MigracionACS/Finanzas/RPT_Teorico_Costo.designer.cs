namespace LOSA.MigracionACS.Finanzas
{
    partial class RPT_Teorico_Costo
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dthasta = new DevExpress.XtraEditors.DateEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnGenerar = new DevExpress.XtraBars.BarButtonItem();
            this.btnexportexcel = new DevExpress.XtraBars.BarButtonItem();
            this.btncerrar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnexport = new DevExpress.XtraBars.BarButtonItem();
            this.dtdesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.grd_teorico_cost = new DevExpress.XtraGrid.GridControl();
            this.dSRPT = new MigracionACS.Finanzas.dSRPT();
            this.grdv_teorico_cost = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colh_fml_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colh_skt_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colh_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colh_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colh_specie_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cols_material_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo_Sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cols_material_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cols_batch_kg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cols_cost_tm_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinclusion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbatch_count = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkg_totales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcosto_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinclusionCal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dthasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dthasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_teorico_cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_teorico_cost)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dthasta);
            this.panelControl1.Controls.Add(this.dtdesde);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 40);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1499, 74);
            this.panelControl1.TabIndex = 0;
            // 
            // dthasta
            // 
            this.dthasta.EditValue = null;
            this.dthasta.Location = new System.Drawing.Point(162, 42);
            this.dthasta.MenuManager = this.barManager1;
            this.dthasta.Name = "dthasta";
            this.dthasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dthasta.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dthasta.Properties.Appearance.Options.UseFont = true;
            this.dthasta.Properties.Appearance.Options.UseForeColor = true;
            this.dthasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dthasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dthasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dthasta.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dthasta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dthasta.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dthasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dthasta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dthasta.Size = new System.Drawing.Size(273, 22);
            this.dthasta.TabIndex = 5;
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
            this.btnGenerar,
            this.btncerrar,
            this.btnexport,
            this.btnexportexcel});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGenerar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnexportexcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btncerrar)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Caption = "Generar";
            this.btnGenerar.Id = 0;
            this.btnGenerar.ImageOptions.Image = global::LOSA.Properties.Resources.Generate_32x32;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGenerar_ItemClick);
            // 
            // btnexportexcel
            // 
            this.btnexportexcel.Caption = "Exportar a Excel";
            this.btnexportexcel.Id = 3;
            this.btnexportexcel.ImageOptions.Image = global::LOSA.Properties.Resources.excel_32x32;
            this.btnexportexcel.Name = "btnexportexcel";
            this.btnexportexcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnexportexcel_ItemClick);
            // 
            // btncerrar
            // 
            this.btncerrar.Caption = "Cerrar";
            this.btncerrar.Id = 1;
            this.btncerrar.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_32x32;
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncerrar_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1499, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 534);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1499, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 494);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1499, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 494);
            // 
            // btnexport
            // 
            this.btnexport.Caption = "Exportar";
            this.btnexport.Id = 2;
            this.btnexport.ImageOptions.Image = global::LOSA.Properties.Resources.excel_32x32;
            this.btnexport.Name = "btnexport";
            this.btnexport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnexport_ItemClick);
            // 
            // dtdesde
            // 
            this.dtdesde.EditValue = null;
            this.dtdesde.Location = new System.Drawing.Point(162, 13);
            this.dtdesde.MenuManager = this.barManager1;
            this.dtdesde.Name = "dtdesde";
            this.dtdesde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdesde.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dtdesde.Properties.Appearance.Options.UseFont = true;
            this.dtdesde.Properties.Appearance.Options.UseForeColor = true;
            this.dtdesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtdesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtdesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtdesde.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dtdesde.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtdesde.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dtdesde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtdesde.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtdesde.Size = new System.Drawing.Size(273, 22);
            this.dtdesde.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(79, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Fecha Hasta:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(79, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Fecha desde:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.grd_teorico_cost);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 114);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1499, 420);
            this.panelControl2.TabIndex = 5;
            // 
            // grd_teorico_cost
            // 
            this.grd_teorico_cost.DataMember = "RPT_Teorico";
            this.grd_teorico_cost.DataSource = this.dSRPT;
            this.grd_teorico_cost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_teorico_cost.Location = new System.Drawing.Point(2, 2);
            this.grd_teorico_cost.MainView = this.grdv_teorico_cost;
            this.grd_teorico_cost.MenuManager = this.barManager1;
            this.grd_teorico_cost.Name = "grd_teorico_cost";
            this.grd_teorico_cost.Size = new System.Drawing.Size(1495, 416);
            this.grd_teorico_cost.TabIndex = 0;
            this.grd_teorico_cost.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_teorico_cost});
            // 
            // dSRPT
            // 
            this.dSRPT.DataSetName = "dSRPT";
            this.dSRPT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_teorico_cost
            // 
            this.grdv_teorico_cost.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colh_fml_id,
            this.colh_skt_code,
            this.colh_type,
            this.colh_name,
            this.colh_specie_name,
            this.cols_material_code,
            this.colCodigo_Sap,
            this.cols_material_name,
            this.cols_batch_kg,
            this.cols_cost_tm_mp,
            this.colinclusion,
            this.colbatch_count,
            this.colkg_totales,
            this.colcosto_total,
            this.colinclusionCal});
            this.grdv_teorico_cost.GridControl = this.grd_teorico_cost;
            this.grdv_teorico_cost.Name = "grdv_teorico_cost";
            this.grdv_teorico_cost.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_teorico_cost.OptionsBehavior.Editable = false;
            this.grdv_teorico_cost.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.grdv_teorico_cost.OptionsView.ShowAutoFilterRow = true;
            this.grdv_teorico_cost.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.grdv_teorico_cost.OptionsView.ShowFooter = true;
            // 
            // colh_fml_id
            // 
            this.colh_fml_id.Caption = "h_fml_id";
            this.colh_fml_id.FieldName = "h_fml_id";
            this.colh_fml_id.Name = "colh_fml_id";
            this.colh_fml_id.Visible = true;
            this.colh_fml_id.VisibleIndex = 0;
            this.colh_fml_id.Width = 99;
            // 
            // colh_skt_code
            // 
            this.colh_skt_code.Caption = "h_skt_code";
            this.colh_skt_code.FieldName = "h_skt_code";
            this.colh_skt_code.Name = "colh_skt_code";
            this.colh_skt_code.Visible = true;
            this.colh_skt_code.VisibleIndex = 1;
            this.colh_skt_code.Width = 99;
            // 
            // colh_type
            // 
            this.colh_type.Caption = "h_type";
            this.colh_type.FieldName = "h_type";
            this.colh_type.Name = "colh_type";
            this.colh_type.Visible = true;
            this.colh_type.VisibleIndex = 2;
            this.colh_type.Width = 99;
            // 
            // colh_name
            // 
            this.colh_name.Caption = "h_name";
            this.colh_name.FieldName = "h_name";
            this.colh_name.Name = "colh_name";
            this.colh_name.Visible = true;
            this.colh_name.VisibleIndex = 3;
            this.colh_name.Width = 85;
            // 
            // colh_specie_name
            // 
            this.colh_specie_name.Caption = "h_specie_name";
            this.colh_specie_name.FieldName = "h_specie_name";
            this.colh_specie_name.Name = "colh_specie_name";
            this.colh_specie_name.Visible = true;
            this.colh_specie_name.VisibleIndex = 4;
            this.colh_specie_name.Width = 100;
            // 
            // cols_material_code
            // 
            this.cols_material_code.Caption = "s_material_code";
            this.cols_material_code.FieldName = "s_material_code";
            this.cols_material_code.Name = "cols_material_code";
            this.cols_material_code.Visible = true;
            this.cols_material_code.VisibleIndex = 5;
            this.cols_material_code.Width = 100;
            // 
            // colCodigo_Sap
            // 
            this.colCodigo_Sap.Caption = "Codigo_Sap";
            this.colCodigo_Sap.FieldName = "Codigo_Sap";
            this.colCodigo_Sap.Name = "colCodigo_Sap";
            this.colCodigo_Sap.Visible = true;
            this.colCodigo_Sap.VisibleIndex = 6;
            this.colCodigo_Sap.Width = 100;
            // 
            // cols_material_name
            // 
            this.cols_material_name.Caption = "s_material_name";
            this.cols_material_name.FieldName = "s_material_name";
            this.cols_material_name.Name = "cols_material_name";
            this.cols_material_name.Visible = true;
            this.cols_material_name.VisibleIndex = 7;
            this.cols_material_name.Width = 161;
            // 
            // cols_batch_kg
            // 
            this.cols_batch_kg.FieldName = "s_batch_kg";
            this.cols_batch_kg.Name = "cols_batch_kg";
            this.cols_batch_kg.Visible = true;
            this.cols_batch_kg.VisibleIndex = 8;
            this.cols_batch_kg.Width = 65;
            // 
            // cols_cost_tm_mp
            // 
            this.cols_cost_tm_mp.Caption = "s_cost_tm_mp";
            this.cols_cost_tm_mp.FieldName = "s_cost_tm_mp";
            this.cols_cost_tm_mp.Name = "cols_cost_tm_mp";
            this.cols_cost_tm_mp.Visible = true;
            this.cols_cost_tm_mp.VisibleIndex = 9;
            this.cols_cost_tm_mp.Width = 113;
            // 
            // colinclusion
            // 
            this.colinclusion.Caption = "inclusion";
            this.colinclusion.FieldName = "inclusion";
            this.colinclusion.Name = "colinclusion";
            this.colinclusion.Width = 152;
            // 
            // colbatch_count
            // 
            this.colbatch_count.Caption = "batch_count";
            this.colbatch_count.FieldName = "batch_count";
            this.colbatch_count.Name = "colbatch_count";
            this.colbatch_count.Visible = true;
            this.colbatch_count.VisibleIndex = 11;
            this.colbatch_count.Width = 91;
            // 
            // colkg_totales
            // 
            this.colkg_totales.Caption = "kg_totales";
            this.colkg_totales.FieldName = "kg_totales";
            this.colkg_totales.Name = "colkg_totales";
            this.colkg_totales.Visible = true;
            this.colkg_totales.VisibleIndex = 12;
            this.colkg_totales.Width = 46;
            // 
            // colcosto_total
            // 
            this.colcosto_total.Caption = "costo_total";
            this.colcosto_total.FieldName = "costo_total";
            this.colcosto_total.Name = "colcosto_total";
            this.colcosto_total.Visible = true;
            this.colcosto_total.VisibleIndex = 13;
            this.colcosto_total.Width = 55;
            // 
            // colinclusionCal
            // 
            this.colinclusionCal.Caption = "inclusion";
            this.colinclusionCal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colinclusionCal.FieldName = "inclusionCal";
            this.colinclusionCal.Name = "colinclusionCal";
            this.colinclusionCal.Visible = true;
            this.colinclusionCal.VisibleIndex = 10;
            this.colinclusionCal.Width = 112;
            // 
            // RPT_Teorico_Costo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 557);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "RPT_Teorico_Costo";
            this.Text = "RPT_Teorico_Costo";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dthasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dthasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_teorico_cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_teorico_cost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnGenerar;
        private DevExpress.XtraBars.BarButtonItem btncerrar;
        private DevExpress.XtraBars.BarButtonItem btnexport;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl grd_teorico_cost;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_teorico_cost;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dSRPT dSRPT;
        private DevExpress.XtraGrid.Columns.GridColumn colh_fml_id;
        private DevExpress.XtraGrid.Columns.GridColumn colh_skt_code;
        private DevExpress.XtraGrid.Columns.GridColumn colh_type;
        private DevExpress.XtraGrid.Columns.GridColumn colh_name;
        private DevExpress.XtraGrid.Columns.GridColumn colh_specie_name;
        private DevExpress.XtraGrid.Columns.GridColumn cols_material_code;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo_Sap;
        private DevExpress.XtraGrid.Columns.GridColumn cols_material_name;
        private DevExpress.XtraGrid.Columns.GridColumn cols_batch_kg;
        private DevExpress.XtraGrid.Columns.GridColumn cols_cost_tm_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colinclusion;
        private DevExpress.XtraGrid.Columns.GridColumn colbatch_count;
        private DevExpress.XtraGrid.Columns.GridColumn colkg_totales;
        private DevExpress.XtraGrid.Columns.GridColumn colcosto_total;
        private DevExpress.XtraBars.BarButtonItem btnexportexcel;
        private DevExpress.XtraGrid.Columns.GridColumn colinclusionCal;
        private DevExpress.XtraEditors.DateEdit dtdesde;
        private DevExpress.XtraEditors.DateEdit dthasta;
    }
}