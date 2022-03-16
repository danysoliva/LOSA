
namespace LOSA.TransaccionesPT
{
    partial class MantiniemintoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantiniemintoCliente));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.ClientesGrid = new DevExpress.XtraGrid.GridControl();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPT = new LOSA.TransaccionesPT.dsPT();
            this.ClientesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colciudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente_aqua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Appearance.Options.UseFont = true;
            this.btnclose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.ImageOptions.Image")));
            this.btnclose.Location = new System.Drawing.Point(1293, 8);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(97, 50);
            this.btnclose.TabIndex = 0;
            this.btnclose.Text = "Cerrar";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // ClientesGrid
            // 
            this.ClientesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientesGrid.DataSource = this.clientesBindingSource;
            this.ClientesGrid.Location = new System.Drawing.Point(12, 77);
            this.ClientesGrid.MainView = this.ClientesView;
            this.ClientesGrid.Name = "ClientesGrid";
            this.ClientesGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditar});
            this.ClientesGrid.Size = new System.Drawing.Size(1372, 642);
            this.ClientesGrid.TabIndex = 1;
            this.ClientesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ClientesView});
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.dsPT;
            // 
            // dsPT
            // 
            this.dsPT.DataSetName = "dsPT";
            this.dsPT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClientesView
            // 
            this.ClientesView.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientesView.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.ClientesView.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientesView.Appearance.Empty.Options.UseFont = true;
            this.ClientesView.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesView.Appearance.FocusedRow.Options.UseFont = true;
            this.ClientesView.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientesView.Appearance.FooterPanel.Options.UseFont = true;
            this.ClientesView.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientesView.Appearance.GroupFooter.Options.UseFont = true;
            this.ClientesView.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientesView.Appearance.GroupPanel.Options.UseFont = true;
            this.ClientesView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesView.Appearance.HeaderPanel.Options.UseFont = true;
            this.ClientesView.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientesView.Appearance.Preview.Options.UseFont = true;
            this.ClientesView.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientesView.Appearance.Row.Options.UseFont = true;
            this.ClientesView.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientesView.Appearance.TopNewRow.Options.UseFont = true;
            this.ClientesView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcodigo,
            this.colnombre,
            this.coldireccion1,
            this.colciudad,
            this.colpais,
            this.colcliente_aqua,
            this.colCardName,
            this.colEditar});
            this.ClientesView.GridControl = this.ClientesGrid;
            this.ClientesView.Name = "ClientesView";
            this.ClientesView.OptionsView.ShowAutoFilterRow = true;
            this.ClientesView.OptionsView.ShowFooter = true;
            this.ClientesView.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.ColumnEdit = this.btnEditar;
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // btnEditar
            // 
            this.btnEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEditar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditar_ButtonClick);
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 193;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 193;
            // 
            // coldireccion1
            // 
            this.coldireccion1.Caption = "Direccion";
            this.coldireccion1.FieldName = "direccion1";
            this.coldireccion1.Name = "coldireccion1";
            this.coldireccion1.OptionsColumn.AllowEdit = false;
            this.coldireccion1.Visible = true;
            this.coldireccion1.VisibleIndex = 2;
            this.coldireccion1.Width = 193;
            // 
            // colciudad
            // 
            this.colciudad.Caption = "Ciudad";
            this.colciudad.FieldName = "ciudad";
            this.colciudad.Name = "colciudad";
            this.colciudad.OptionsColumn.AllowEdit = false;
            this.colciudad.Visible = true;
            this.colciudad.VisibleIndex = 3;
            this.colciudad.Width = 193;
            // 
            // colpais
            // 
            this.colpais.Caption = "Pais";
            this.colpais.FieldName = "pais";
            this.colpais.Name = "colpais";
            this.colpais.OptionsColumn.AllowEdit = false;
            this.colpais.Visible = true;
            this.colpais.VisibleIndex = 4;
            this.colpais.Width = 193;
            // 
            // colcliente_aqua
            // 
            this.colcliente_aqua.FieldName = "cliente_aqua";
            this.colcliente_aqua.Name = "colcliente_aqua";
            this.colcliente_aqua.OptionsColumn.AllowEdit = false;
            // 
            // colCardName
            // 
            this.colCardName.Caption = "Cliente";
            this.colCardName.FieldName = "CardName";
            this.colCardName.Name = "colCardName";
            this.colCardName.OptionsColumn.AllowEdit = false;
            this.colCardName.Visible = true;
            this.colCardName.VisibleIndex = 5;
            this.colCardName.Width = 330;
            // 
            // colEditar
            // 
            this.colEditar.Caption = "Editar";
            this.colEditar.ColumnEdit = this.btnEditar;
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 6;
            this.colEditar.Width = 59;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Appearance.Options.UseFont = true;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(12, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(130, 50);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo cliente";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // MantiniemintoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 728);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.ClientesGrid);
            this.Controls.Add(this.btnclose);
            this.Name = "MantiniemintoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantiniemintoCliente";
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnclose;
        private DevExpress.XtraGrid.GridControl ClientesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView ClientesView;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private dsPT dsPT;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion1;
        private DevExpress.XtraGrid.Columns.GridColumn colciudad;
        private DevExpress.XtraGrid.Columns.GridColumn colpais;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente_aqua;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditar;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
    }
}