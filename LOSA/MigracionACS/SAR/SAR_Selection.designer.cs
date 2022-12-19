namespace LOSA.MigracionACS.SAR
{
    partial class SAR_Selection
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAR_Selection));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.Pnmail = new DevExpress.XtraEditors.PanelControl();
            this.grd_exoneracion = new DevExpress.XtraGrid.GridControl();
            this.exoneracionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_SAR = new MigracionACS.SAR.dS_SAR();
            this.grdv_exoneracion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colanio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcerrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnseleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.coleditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btneditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnclose = new DevExpress.XtraBars.BarButtonItem();
            this.btnnueva = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tgghabilitados = new DevExpress.XtraBars.BarToggleSwitchItem();
            ((System.ComponentModel.ISupportInitialize)(this.Pnmail)).BeginInit();
            this.Pnmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_exoneracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exoneracionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_exoneracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnseleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnmail
            // 
            this.Pnmail.Controls.Add(this.grd_exoneracion);
            this.Pnmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnmail.Location = new System.Drawing.Point(0, 50);
            this.Pnmail.Name = "Pnmail";
            this.Pnmail.Size = new System.Drawing.Size(1345, 572);
            this.Pnmail.TabIndex = 0;
            // 
            // grd_exoneracion
            // 
            this.grd_exoneracion.DataSource = this.exoneracionBindingSource;
            this.grd_exoneracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_exoneracion.Location = new System.Drawing.Point(2, 2);
            this.grd_exoneracion.MainView = this.grdv_exoneracion;
            this.grd_exoneracion.MenuManager = this.barManager1;
            this.grd_exoneracion.Name = "grd_exoneracion";
            this.grd_exoneracion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnseleccionar,
            this.btneditar});
            this.grd_exoneracion.Size = new System.Drawing.Size(1341, 568);
            this.grd_exoneracion.TabIndex = 0;
            this.grd_exoneracion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_exoneracion});
            // 
            // exoneracionBindingSource
            // 
            this.exoneracionBindingSource.DataMember = "exoneracion";
            this.exoneracionBindingSource.DataSource = this.dS_SAR;
            // 
            // dS_SAR
            // 
            this.dS_SAR.DataSetName = "dS_SAR";
            this.dS_SAR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_exoneracion
            // 
            this.grdv_exoneracion.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_exoneracion.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_exoneracion.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_exoneracion.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_exoneracion.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_exoneracion.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_exoneracion.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_exoneracion.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_exoneracion.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_exoneracion.Appearance.Row.Options.UseFont = true;
            this.grdv_exoneracion.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_exoneracion.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_exoneracion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colanio,
            this.colinicio,
            this.colfinal,
            this.colcerrado,
            this.colseleccion,
            this.coleditar});
            this.grdv_exoneracion.GridControl = this.grd_exoneracion;
            this.grdv_exoneracion.Name = "grdv_exoneracion";
            this.grdv_exoneracion.OptionsView.ShowAutoFilterRow = true;
            this.grdv_exoneracion.OptionsView.ShowGroupPanel = false;
            this.grdv_exoneracion.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdv_exoneracion_RowClick);
            this.grdv_exoneracion.DoubleClick += new System.EventHandler(this.grdv_exoneracion_DoubleClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colanio
            // 
            this.colanio.Caption = "Año";
            this.colanio.FieldName = "anio";
            this.colanio.Name = "colanio";
            this.colanio.OptionsColumn.AllowEdit = false;
            this.colanio.Visible = true;
            this.colanio.VisibleIndex = 0;
            this.colanio.Width = 129;
            // 
            // colinicio
            // 
            this.colinicio.Caption = "Fecha inicial";
            this.colinicio.FieldName = "inicio";
            this.colinicio.Name = "colinicio";
            this.colinicio.OptionsColumn.AllowEdit = false;
            this.colinicio.Visible = true;
            this.colinicio.VisibleIndex = 1;
            this.colinicio.Width = 129;
            // 
            // colfinal
            // 
            this.colfinal.Caption = "Fecha final";
            this.colfinal.FieldName = "final";
            this.colfinal.Name = "colfinal";
            this.colfinal.OptionsColumn.AllowEdit = false;
            this.colfinal.Visible = true;
            this.colfinal.VisibleIndex = 2;
            this.colfinal.Width = 129;
            // 
            // colcerrado
            // 
            this.colcerrado.Caption = "Estado";
            this.colcerrado.FieldName = "cerrado";
            this.colcerrado.Name = "colcerrado";
            this.colcerrado.OptionsColumn.AllowEdit = false;
            this.colcerrado.Visible = true;
            this.colcerrado.VisibleIndex = 3;
            this.colcerrado.Width = 129;
            // 
            // colseleccion
            // 
            this.colseleccion.Caption = "Seleccionar";
            this.colseleccion.ColumnEdit = this.btnseleccionar;
            this.colseleccion.Name = "colseleccion";
            this.colseleccion.Visible = true;
            this.colseleccion.VisibleIndex = 4;
            this.colseleccion.Width = 144;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btnseleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions3, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // coleditar
            // 
            this.coleditar.Caption = "Editar";
            this.coleditar.ColumnEdit = this.btneditar;
            this.coleditar.Name = "coleditar";
            this.coleditar.Visible = true;
            this.coleditar.VisibleIndex = 5;
            this.coleditar.Width = 116;
            // 
            // btneditar
            // 
            this.btneditar.AutoHeight = false;
            editorButtonImageOptions4.Image = global::LOSA.Properties.Resources.edit_24x24;
            this.btneditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions4, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btneditar.Name = "btneditar";
            this.btneditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
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
            this.btnclose,
            this.btnnueva,
            this.tgghabilitados});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnclose),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnnueva),
            new DevExpress.XtraBars.LinkPersistInfo(this.tgghabilitados)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // btnclose
            // 
            this.btnclose.Caption = "Cerrar";
            this.btnclose.Id = 0;
            this.btnclose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.ImageOptions.Image")));
            this.btnclose.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ItemAppearance.Normal.Options.UseFont = true;
            this.btnclose.Name = "btnclose";
            this.btnclose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnclose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnclose_ItemClick);
            // 
            // btnnueva
            // 
            this.btnnueva.Caption = "Nueva exoneracion";
            this.btnnueva.Id = 1;
            this.btnnueva.ImageOptions.Image = global::LOSA.Properties.Resources.new_32x32;
            this.btnnueva.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnueva.ItemAppearance.Normal.Options.UseFont = true;
            this.btnnueva.Name = "btnnueva";
            this.btnnueva.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnnueva.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnnueva_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1345, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 622);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1345, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 572);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1345, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 572);
            // 
            // tgghabilitados
            // 
            this.tgghabilitados.Caption = "Ver deshabilitados";
            this.tgghabilitados.Id = 2;
            this.tgghabilitados.Name = "tgghabilitados";
            this.tgghabilitados.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.tgghabilitados_CheckedChanged);
            // 
            // SAR_Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 622);
            this.Controls.Add(this.Pnmail);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SAR_Selection";
            this.Text = "Selecciona una exoneracion";
            ((System.ComponentModel.ISupportInitialize)(this.Pnmail)).EndInit();
            this.Pnmail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_exoneracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exoneracionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_exoneracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnseleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl Pnmail;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnclose;
        private DevExpress.XtraGrid.GridControl grd_exoneracion;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_exoneracion;
        private System.Windows.Forms.BindingSource exoneracionBindingSource;
        private dS_SAR dS_SAR;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colanio;
        private DevExpress.XtraGrid.Columns.GridColumn colinicio;
        private DevExpress.XtraGrid.Columns.GridColumn colfinal;
        private DevExpress.XtraGrid.Columns.GridColumn colcerrado;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccion;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnseleccionar;
        private DevExpress.XtraGrid.Columns.GridColumn coleditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btneditar;
        private DevExpress.XtraBars.BarButtonItem btnnueva;
        private DevExpress.XtraBars.BarToggleSwitchItem tgghabilitados;
    }
}