namespace LOSA.TransaccionesPT
{
    partial class frm_verdetalleTM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_verdetalleTM));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.tmptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPT = new LOSA.TransaccionesPT.dsPT();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_producto_termiado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_producto_termiado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_produccion_producto_termiado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_tm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colduplicar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnduplicar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colimprimir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnimprimir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btn_excel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_editar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnduplicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnimprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_editar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(126, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(372, 39);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "Tarimas de ingreso";
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(504, 7);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(126, 53);
            this.cmdHome.TabIndex = 41;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataSource = this.tmptBindingSource;
            this.grd_data.Location = new System.Drawing.Point(1, 108);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnduplicar,
            this.btnimprimir,
            this.btn_editar});
            this.grd_data.Size = new System.Drawing.Size(636, 452);
            this.grd_data.TabIndex = 42;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // tmptBindingSource
            // 
            this.tmptBindingSource.DataMember = "tm_pt";
            this.tmptBindingSource.DataSource = this.dsPT;
            // 
            // dsPT
            // 
            this.dsPT.DataSetName = "dsPT";
            this.dsPT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.collote_producto_termiado,
            this.colpresentacion,
            this.colid_producto_termiado,
            this.colproducto,
            this.colfecha_produccion_producto_termiado,
            this.colcodigo_barra,
            this.colestado_tm,
            this.colcantidad,
            this.colpeso,
            this.colitemcode,
            this.colduplicar,
            this.colimprimir,
            this.colEditar});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // collote_producto_termiado
            // 
            this.collote_producto_termiado.Caption = "Lote";
            this.collote_producto_termiado.FieldName = "lote_producto_termiado";
            this.collote_producto_termiado.Name = "collote_producto_termiado";
            this.collote_producto_termiado.OptionsColumn.AllowEdit = false;
            this.collote_producto_termiado.Visible = true;
            this.collote_producto_termiado.VisibleIndex = 2;
            // 
            // colpresentacion
            // 
            this.colpresentacion.Caption = "Presentacion";
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.OptionsColumn.AllowEdit = false;
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 4;
            // 
            // colid_producto_termiado
            // 
            this.colid_producto_termiado.FieldName = "id_producto_termiado";
            this.colid_producto_termiado.Name = "colid_producto_termiado";
            this.colid_producto_termiado.OptionsColumn.AllowEdit = false;
            // 
            // colproducto
            // 
            this.colproducto.Caption = "Producto";
            this.colproducto.FieldName = "producto";
            this.colproducto.Name = "colproducto";
            this.colproducto.OptionsColumn.AllowEdit = false;
            this.colproducto.Visible = true;
            this.colproducto.VisibleIndex = 0;
            // 
            // colfecha_produccion_producto_termiado
            // 
            this.colfecha_produccion_producto_termiado.Caption = "F. Produccion";
            this.colfecha_produccion_producto_termiado.FieldName = "fecha_produccion_producto_termiado";
            this.colfecha_produccion_producto_termiado.Name = "colfecha_produccion_producto_termiado";
            this.colfecha_produccion_producto_termiado.OptionsColumn.AllowEdit = false;
            this.colfecha_produccion_producto_termiado.Visible = true;
            this.colfecha_produccion_producto_termiado.VisibleIndex = 1;
            // 
            // colcodigo_barra
            // 
            this.colcodigo_barra.FieldName = "codigo_barra";
            this.colcodigo_barra.Name = "colcodigo_barra";
            this.colcodigo_barra.OptionsColumn.AllowEdit = false;
            // 
            // colestado_tm
            // 
            this.colestado_tm.Caption = "Estado";
            this.colestado_tm.FieldName = "estado_tm";
            this.colestado_tm.Name = "colestado_tm";
            this.colestado_tm.OptionsColumn.AllowEdit = false;
            this.colestado_tm.Visible = true;
            this.colestado_tm.VisibleIndex = 5;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Unidades";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 6;
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Peso Kg.";
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.OptionsColumn.AllowEdit = false;
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 3;
            // 
            // colitemcode
            // 
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            // 
            // colduplicar
            // 
            this.colduplicar.Caption = "Duplicar";
            this.colduplicar.ColumnEdit = this.btnduplicar;
            this.colduplicar.Name = "colduplicar";
            this.colduplicar.Visible = true;
            this.colduplicar.VisibleIndex = 7;
            // 
            // btnduplicar
            // 
            this.btnduplicar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnduplicar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnduplicar.Name = "btnduplicar";
            this.btnduplicar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnduplicar.Click += new System.EventHandler(this.btnduplicar_Click);
            // 
            // colimprimir
            // 
            this.colimprimir.Caption = "Imprimir";
            this.colimprimir.ColumnEdit = this.btnimprimir;
            this.colimprimir.Name = "colimprimir";
            this.colimprimir.Visible = true;
            this.colimprimir.VisibleIndex = 8;
            // 
            // btnimprimir
            // 
            this.btnimprimir.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnimprimir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excel.Appearance.Options.UseFont = true;
            this.btn_excel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_excel.ImageOptions.Image")));
            this.btn_excel.Location = new System.Drawing.Point(7, 6);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(113, 54);
            this.btn_excel.TabIndex = 43;
            this.btn_excel.Text = "Excel";
            this.btn_excel.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btn_editar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // colEditar
            // 
            this.colEditar.Caption = "Editar TM";
            this.colEditar.ColumnEdit = this.btn_editar;
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 9;
            // 
            // frm_verdetalleTM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_verdetalleTM";
            this.Text = "frm_verdetalleTM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnduplicar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnimprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_editar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private System.Windows.Forms.BindingSource tmptBindingSource;
        private dsPT dsPT;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn collote_producto_termiado;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_producto_termiado;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_produccion_producto_termiado;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_tm;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colduplicar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnduplicar;
        private DevExpress.XtraGrid.Columns.GridColumn colimprimir;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnimprimir;
        private DevExpress.XtraEditors.SimpleButton btn_excel;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_editar;
    }
}