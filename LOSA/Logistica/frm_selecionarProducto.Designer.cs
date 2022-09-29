
namespace LOSA.Logistica
{
    partial class frm_selecionarProducto
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.articulosBindingSource = new System.Windows.Forms.BindingSource();
            this.dsCierreMes = new LOSA.Logistica.dsCierreMes();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_seleccinar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCierreMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_seleccinar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(420, 3);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(111, 46);
            this.cmdHome.TabIndex = 7;
            this.cmdHome.Text = "Cerrar";
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataSource = this.articulosBindingSource;
            this.grd_data.Location = new System.Drawing.Point(0, 73);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_seleccinar});
            this.grd_data.Size = new System.Drawing.Size(535, 599);
            this.grd_data.TabIndex = 8;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // articulosBindingSource
            // 
            this.articulosBindingSource.DataMember = "articulos";
            this.articulosBindingSource.DataSource = this.dsCierreMes;
            // 
            // dsCierreMes
            // 
            this.dsCierreMes.DataSetName = "dsCierreMes";
            this.dsCierreMes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcodigo,
            this.colproducto,
            this.colSeleccionar,
            this.colitemcode});
            this.grdv_data.CustomizationFormBounds = new System.Drawing.Rectangle(-1594, 505, 260, 302);
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.DoubleClick += new System.EventHandler(this.grdv_data_DoubleClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Width = 104;
            // 
            // colproducto
            // 
            this.colproducto.Caption = "Producto";
            this.colproducto.FieldName = "producto";
            this.colproducto.Name = "colproducto";
            this.colproducto.OptionsColumn.AllowEdit = false;
            this.colproducto.Visible = true;
            this.colproducto.VisibleIndex = 1;
            this.colproducto.Width = 322;
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.Caption = "Seleccionar";
            this.colSeleccionar.ColumnEdit = this.btn_seleccinar;
            this.colSeleccionar.Name = "colSeleccionar";
            this.colSeleccionar.Visible = true;
            this.colSeleccionar.VisibleIndex = 2;
            this.colSeleccionar.Width = 102;
            // 
            // btn_seleccinar
            // 
            this.btn_seleccinar.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.tap;
            this.btn_seleccinar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btn_seleccinar.Name = "btn_seleccinar";
            this.btn_seleccinar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_seleccinar.Click += new System.EventHandler(this.btn_seleccinar_Click);
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Item Code";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            this.colitemcode.Width = 93;
            // 
            // frm_selecionarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 672);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.cmdHome);
            this.Name = "frm_selecionarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion de productos";
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCierreMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_seleccinar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private System.Windows.Forms.BindingSource articulosBindingSource;
        private dsCierreMes dsCierreMes;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_seleccinar;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
    }
}