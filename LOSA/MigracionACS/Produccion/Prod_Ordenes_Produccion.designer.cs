namespace LOSA.MigracionACS.Produccion
{
    partial class Prod_Ordenes_Produccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prod_Ordenes_Produccion));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.btn_ProdPlan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ViewActivePlans = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ViewPlanProceso = new DevExpress.XtraBars.BarButtonItem();
            this.btn_OldPlans = new DevExpress.XtraBars.BarButtonItem();
            this.btn_formulas = new DevExpress.XtraBars.BarButtonItem();
            this.btn_pts = new DevExpress.XtraBars.BarButtonItem();
            this.btn_exit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_exit,
            this.btn_ProdPlan,
            this.btn_ViewActivePlans,
            this.btn_OldPlans,
            this.btn_ViewPlanProceso,
            this.barMdiChildrenListItem1,
            this.btn_formulas,
            this.btn_pts});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 12;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barMdiChildrenListItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ProdPlan, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ViewActivePlans, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ViewPlanProceso),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_OldPlans),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_formulas, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_pts),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_exit)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "Planes de Producción - Toolbox";
            this.barMdiChildrenListItem1.Id = 8;
            this.barMdiChildrenListItem1.ImageOptions.Image = global::LOSA.Properties.Resources.pp_icon_24;
            this.barMdiChildrenListItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barMdiChildrenListItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            this.barMdiChildrenListItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_ProdPlan
            // 
            this.btn_ProdPlan.Caption = "Nuevo Plan de Producción";
            this.btn_ProdPlan.Id = 1;
            this.btn_ProdPlan.ImageOptions.Image = global::LOSA.Properties.Resources.pp_new_32;
            this.btn_ProdPlan.Name = "btn_ProdPlan";
            this.btn_ProdPlan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ProdPlan_ItemClick);
            // 
            // btn_ViewActivePlans
            // 
            this.btn_ViewActivePlans.Caption = "Ver Planes Activos y En Cola";
            this.btn_ViewActivePlans.Id = 2;
            this.btn_ViewActivePlans.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ViewActivePlans.ImageOptions.Image")));
            this.btn_ViewActivePlans.Name = "btn_ViewActivePlans";
            this.btn_ViewActivePlans.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ViewActivePlans_ItemClick);
            // 
            // btn_ViewPlanProceso
            // 
            this.btn_ViewPlanProceso.Caption = "Ver Plan en Proceso";
            this.btn_ViewPlanProceso.Id = 5;
            this.btn_ViewPlanProceso.ImageOptions.Image = global::LOSA.Properties.Resources.pp_OnProcess_32;
            this.btn_ViewPlanProceso.Name = "btn_ViewPlanProceso";
            this.btn_ViewPlanProceso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btn_ViewPlanProceso.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ViewPlanProceso_ItemClick);
            // 
            // btn_OldPlans
            // 
            this.btn_OldPlans.Caption = "Ver Planes Antigüos";
            this.btn_OldPlans.Id = 4;
            this.btn_OldPlans.ImageOptions.Image = global::LOSA.Properties.Resources.pp_old_32;
            this.btn_OldPlans.Name = "btn_OldPlans";
            this.btn_OldPlans.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btn_formulas
            // 
            this.btn_formulas.Caption = "Formulas";
            this.btn_formulas.Id = 10;
            this.btn_formulas.ImageOptions.Image = global::LOSA.Properties.Resources.formula_32x32;
            this.btn_formulas.Name = "btn_formulas";
            this.btn_formulas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btn_formulas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_formulas_ItemClick);
            // 
            // btn_pts
            // 
            this.btn_pts.Caption = "Productos Terminados";
            this.btn_pts.Id = 11;
            this.btn_pts.ImageOptions.Image = global::LOSA.Properties.Resources.pt_32x32;
            this.btn_pts.Name = "btn_pts";
            this.btn_pts.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btn_pts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_pts_ItemClick);
            // 
            // btn_exit
            // 
            this.btn_exit.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_exit.Caption = "Salir";
            this.btn_exit.Id = 0;
            this.btn_exit.ImageOptions.Image = global::LOSA.Properties.Resources.exit_24x24;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(867, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 421);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(867, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 381);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(867, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 381);
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // Prod_Ordenes_Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 421);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Prod_Ordenes_Produccion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_exit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_ProdPlan;
        private DevExpress.XtraBars.BarButtonItem btn_ViewActivePlans;
        private DevExpress.XtraBars.BarButtonItem btn_OldPlans;
        private DevExpress.XtraBars.BarButtonItem btn_ViewPlanProceso;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.BarButtonItem btn_formulas;
        private DevExpress.XtraBars.BarButtonItem btn_pts;
    }
}