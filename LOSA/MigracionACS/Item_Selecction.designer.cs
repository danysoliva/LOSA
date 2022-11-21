namespace LOSA.MigracionACS
{
    partial class Item_Selecction
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.col_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_Detail = new DevExpress.XtraBars.BarButtonItem();
            this.btn_acceptar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_cancelar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // col_estado
            // 
            this.col_estado.Caption = "estado";
            this.col_estado.FieldName = "estado";
            this.col_estado.Name = "col_estado";
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
            this.btn_acceptar,
            this.btn_cancelar,
            this.btn_Detail});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Detail),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_acceptar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_cancelar)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_Detail
            // 
            this.btn_Detail.Caption = "Ver Detalle";
            this.btn_Detail.Glyph = global::LOSA.Properties.Resources.Details_32x32;
            this.btn_Detail.Id = 2;
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btn_Detail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Detail_ItemClick);
            // 
            // btn_acceptar
            // 
            this.btn_acceptar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.btn_acceptar.Caption = "Aceptar";
            this.btn_acceptar.Glyph = global::LOSA.Properties.Resources.Accept_32x32;
            this.btn_acceptar.Id = 0;
            this.btn_acceptar.Name = "btn_acceptar";
            this.btn_acceptar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_acceptar_ItemClick);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_cancelar.Caption = "Cancelar";
            this.btn_cancelar.Glyph = global::LOSA.Properties.Resources.cancel_32x32;
            this.btn_cancelar.Id = 1;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_cancelar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(387, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 364);
            this.barDockControlBottom.Size = new System.Drawing.Size(387, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 324);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(387, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 324);
            // 
            // grd_data
            // 
            this.grd_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_data.Location = new System.Drawing.Point(0, 40);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.MenuManager = this.barManager1;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(387, 324);
            this.grd_data.TabIndex = 4;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            this.grd_data.DoubleClick += new System.EventHandler(this.grd_data_DoubleClick);
            // 
            // grdv_data
            // 
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col1,
            this.col2,
            this.col_estado,
            this.col_grupo});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.Azure;
            styleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.col_estado;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "[estado] == \'f\'";
            this.grdv_data.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsBehavior.Editable = false;
            this.grdv_data.OptionsCustomization.AllowGroup = false;
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdv_data_FocusedRowChanged);
            // 
            // col_id
            // 
            this.col_id.Caption = "ID";
            this.col_id.FieldName = "id";
            this.col_id.Name = "col_id";
            // 
            // col1
            // 
            this.col1.Caption = "texto";
            this.col1.FieldName = "col1";
            this.col1.Name = "col1";
            this.col1.Visible = true;
            this.col1.VisibleIndex = 0;
            // 
            // col2
            // 
            this.col2.Caption = "texto";
            this.col2.FieldName = "col2";
            this.col2.Name = "col2";
            this.col2.Visible = true;
            this.col2.VisibleIndex = 1;
            // 
            // col_grupo
            // 
            this.col_grupo.Caption = "Grupo";
            this.col_grupo.FieldName = "grupo";
            this.col_grupo.Name = "col_grupo";
            // 
            // Item_Selecction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 364);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item_Selecction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "texto";
            this.Load += new System.EventHandler(this.Item_Selecction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btn_cancelar;
        private DevExpress.XtraBars.BarButtonItem btn_acceptar;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col2;
        private DevExpress.XtraGrid.Columns.GridColumn col1;
        private DevExpress.XtraBars.BarButtonItem btn_Detail;
        private DevExpress.XtraGrid.Columns.GridColumn col_estado;
        private DevExpress.XtraGrid.Columns.GridColumn col_grupo;
    }
}