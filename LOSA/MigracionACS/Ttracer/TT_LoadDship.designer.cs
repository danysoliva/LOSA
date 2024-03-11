namespace LOSA.MigracionACS.Ttracer
{
    partial class TT_LoadDship
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TT_LoadDship));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnrefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.grd_load = new DevExpress.XtraGrid.GridControl();
            this.dSTtracer = new MigracionACS.Ttracer.dSTtracer();
            this.grdv_load = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colshipid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGranel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colutilizar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnuse = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.coldate_begin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComment = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnuse)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnrefresh);
            this.panelControl1.Controls.Add(this.btnclose);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1353, 37);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl1_MouseDown);
            // 
            // btnrefresh
            // 
            this.btnrefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.ImageOptions.Image")));
            this.btnrefresh.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnrefresh.Location = new System.Drawing.Point(1278, 2);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(34, 29);
            this.btnrefresh.TabIndex = 3;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnclose
            // 
            this.btnclose.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnclose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.ImageOptions.Image")));
            this.btnclose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnclose.Location = new System.Drawing.Point(1316, 2);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(34, 29);
            this.btnclose.TabIndex = 2;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(32, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(248, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Configuracion predefinida de barco";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LOSA.Properties.Resources.LogoLimp_x32;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 37);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1353, 41);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.grd_load);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 78);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1353, 539);
            this.panelControl3.TabIndex = 2;
            // 
            // grd_load
            // 
            this.grd_load.DataMember = "shiptoarrib";
            this.grd_load.DataSource = this.dSTtracer;
            this.grd_load.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_load.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grd_load.Location = new System.Drawing.Point(2, 2);
            this.grd_load.MainView = this.grdv_load;
            this.grd_load.Margin = new System.Windows.Forms.Padding(2);
            this.grd_load.Name = "grd_load";
            this.grd_load.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnuse});
            this.grd_load.Size = new System.Drawing.Size(1349, 535);
            this.grd_load.TabIndex = 0;
            this.grd_load.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_load});
            // 
            // dSTtracer
            // 
            this.dSTtracer.DataSetName = "dSTtracer";
            this.dSTtracer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_load
            // 
            this.grdv_load.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDocNum,
            this.colshipid,
            this.colCardCode,
            this.colCardname,
            this.colItemCode,
            this.colItemName,
            this.colpeso,
            this.colstatus,
            this.coltipo,
            this.colGranel,
            this.colid,
            this.colutilizar,
            this.coldate_begin,
            this.colComment});
            this.grdv_load.GridControl = this.grd_load;
            this.grdv_load.GroupCount = 1;
            this.grdv_load.Name = "grdv_load";
            this.grdv_load.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_load.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coltipo, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colDocNum
            // 
            this.colDocNum.Caption = "N SAP";
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 1;
            this.colDocNum.Width = 76;
            // 
            // colshipid
            // 
            this.colshipid.Caption = "Barco";
            this.colshipid.FieldName = "shipid";
            this.colshipid.Name = "colshipid";
            this.colshipid.Visible = true;
            this.colshipid.VisibleIndex = 2;
            this.colshipid.Width = 195;
            // 
            // colCardCode
            // 
            this.colCardCode.Caption = "Codigo Proveedor";
            this.colCardCode.FieldName = "CardCode";
            this.colCardCode.Name = "colCardCode";
            this.colCardCode.Visible = true;
            this.colCardCode.VisibleIndex = 3;
            this.colCardCode.Width = 111;
            // 
            // colCardname
            // 
            this.colCardname.Caption = "Descripcion de Proveedor";
            this.colCardname.FieldName = "Cardname";
            this.colCardname.Name = "colCardname";
            this.colCardname.Visible = true;
            this.colCardname.VisibleIndex = 4;
            this.colCardname.Width = 262;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Codigo de Articulo";
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 5;
            this.colItemCode.Width = 120;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Descripcion del Articulo";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 6;
            this.colItemName.Width = 378;
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Peso Segun Orden/ Cantidad";
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 8;
            this.colpeso.Width = 160;
            // 
            // colstatus
            // 
            this.colstatus.Caption = "Estado";
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 9;
            this.colstatus.Width = 340;
            // 
            // coltipo
            // 
            this.coltipo.Caption = "Tipo";
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 9;
            this.coltipo.Width = 173;
            // 
            // colGranel
            // 
            this.colGranel.FieldName = "Granel";
            this.colGranel.Name = "colGranel";
            this.colGranel.Visible = true;
            this.colGranel.VisibleIndex = 7;
            this.colGranel.Width = 39;
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 43;
            // 
            // colutilizar
            // 
            this.colutilizar.Caption = "Utilizar";
            this.colutilizar.ColumnEdit = this.btnuse;
            this.colutilizar.Name = "colutilizar";
            this.colutilizar.Visible = true;
            this.colutilizar.VisibleIndex = 10;
            this.colutilizar.Width = 56;
            // 
            // btnuse
            // 
            this.btnuse.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnuse.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnuse.Name = "btnuse";
            this.btnuse.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnuse.Click += new System.EventHandler(this.btnuse_Click);
            // 
            // coldate_begin
            // 
            this.coldate_begin.FieldName = "date_begin";
            this.coldate_begin.Name = "coldate_begin";
            // 
            // colComment
            // 
            this.colComment.FieldName = "Comment";
            this.colComment.Name = "colComment";
            // 
            // TT_LoadDship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 617);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TT_LoadDship";
            this.Text = "TT_LoadDship";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnuse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl grd_load;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_load;
        private dSTtracer dSTtracer;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colshipid;
        private DevExpress.XtraGrid.Columns.GridColumn colCardCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCardname;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn colGranel;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraEditors.SimpleButton btnrefresh;
        private DevExpress.XtraEditors.SimpleButton btnclose;
        private DevExpress.XtraGrid.Columns.GridColumn colutilizar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnuse;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_begin;
        private DevExpress.XtraGrid.Columns.GridColumn colComment;
    }
}