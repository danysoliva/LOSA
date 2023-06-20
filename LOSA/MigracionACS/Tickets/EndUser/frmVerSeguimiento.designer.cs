namespace LOSA.MigracionACS.Tickets.EndUser
{
    partial class frmVerSeguimiento
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerSeguimiento));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grd_seguimiento = new DevExpress.XtraGrid.GridControl();
            this.seguimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTickets = new LOSA.MigracionACS.Tickets.EndUser.dsTickets();
            this.grdv_seguimiento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnArchivo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grd_seguimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_seguimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnArchivo)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_seguimiento
            // 
            this.grd_seguimiento.DataSource = this.seguimientoBindingSource;
            this.grd_seguimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_seguimiento.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grd_seguimiento.Location = new System.Drawing.Point(0, 0);
            this.grd_seguimiento.MainView = this.grdv_seguimiento;
            this.grd_seguimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grd_seguimiento.Name = "grd_seguimiento";
            this.grd_seguimiento.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnArchivo});
            this.grd_seguimiento.Size = new System.Drawing.Size(846, 678);
            this.grd_seguimiento.TabIndex = 1;
            this.grd_seguimiento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_seguimiento});
            // 
            // seguimientoBindingSource
            // 
            this.seguimientoBindingSource.DataMember = "Seguimiento";
            this.seguimientoBindingSource.DataSource = this.dsTickets;
            // 
            // dsTickets
            // 
            this.dsTickets.DataSetName = "dsTickets";
            this.dsTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_seguimiento
            // 
            this.grdv_seguimiento.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_seguimiento.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.Preview.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.Row.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_seguimiento.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_seguimiento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcomentario,
            this.colfecha,
            this.gridColumn1,
            this.gridColumn2});
            this.grdv_seguimiento.DetailHeight = 431;
            this.grdv_seguimiento.GridControl = this.grd_seguimiento;
            this.grdv_seguimiento.Name = "grdv_seguimiento";
            this.grdv_seguimiento.OptionsView.ShowAutoFilterRow = true;
            this.grdv_seguimiento.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 25;
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Width = 206;
            // 
            // colcomentario
            // 
            this.colcomentario.FieldName = "comentario";
            this.colcomentario.MinWidth = 25;
            this.colcomentario.Name = "colcomentario";
            this.colcomentario.OptionsColumn.AllowEdit = false;
            this.colcomentario.OptionsFilter.AllowFilter = false;
            this.colcomentario.Visible = true;
            this.colcomentario.VisibleIndex = 0;
            this.colcomentario.Width = 525;
            // 
            // colfecha
            // 
            this.colfecha.FieldName = "fecha";
            this.colfecha.MinWidth = 25;
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.OptionsFilter.AllowFilter = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 1;
            this.colfecha.Width = 188;
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.btnArchivo;
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 113;
            // 
            // btnArchivo
            // 
            this.btnArchivo.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnArchivo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnArchivo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnArchivo_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID Ticket";
            this.gridColumn2.FieldName = "id_ticket";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 94;
            // 
            // frmVerSeguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 678);
            this.Controls.Add(this.grd_seguimiento);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVerSeguimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Seguimiento";
            ((System.ComponentModel.ISupportInitialize)(this.grd_seguimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_seguimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnArchivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_seguimiento;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_seguimiento;
        private System.Windows.Forms.BindingSource seguimientoBindingSource;
        private dsTickets dsTickets;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentario;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnArchivo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}