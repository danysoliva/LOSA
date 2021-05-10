
namespace LOSA.TransaccionesPT
{
    partial class frm_tarimas_to_ajustar_PT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tarimas_to_ajustar_PT));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.ajusteInvDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPT = new LOSA.TransaccionesPT.dsPT();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_producto_termiado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_producto_termiado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_produccion_producto_termiado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_date = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.presentacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUbi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPor_lote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpt_des = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_rep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_rep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coleditado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_new = new DevExpress.XtraEditors.SimpleButton();
            this.txtubicacion = new DevExpress.XtraEditors.TextEdit();
            this.lbltitel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grd_producto = new DevExpress.XtraEditors.GridLookUpEdit();
            this.productoPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnbuscar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajusteInvDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtubicacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_producto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoPTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
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
            this.labelControl3.Location = new System.Drawing.Point(175, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(372, 39);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Tarimas de PT";
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
            this.cmdHome.Location = new System.Drawing.Point(446, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(180, 57);
            this.cmdHome.TabIndex = 33;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataSource = this.ajusteInvDetalleBindingSource;
            this.grd_data.Location = new System.Drawing.Point(3, 165);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.grd_date});
            this.grd_data.Size = new System.Drawing.Size(635, 396);
            this.grd_data.TabIndex = 34;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // ajusteInvDetalleBindingSource
            // 
            this.ajusteInvDetalleBindingSource.DataMember = "AjusteInv_Detalle";
            this.ajusteInvDetalleBindingSource.DataSource = this.dsPT;
            // 
            // dsPT
            // 
            this.dsPT.DataSetName = "dsPT";
            this.dsPT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_producto_termiado,
            this.collote_producto_termiado,
            this.colcantidad,
            this.colpeso,
            this.colcodigo_barra,
            this.colfecha_vencimiento,
            this.colfecha_produccion_producto_termiado,
            this.colfecha_ingreso,
            this.colid_presentacion,
            this.coldescripcion,
            this.colUbi,
            this.coldel,
            this.colPor_lote,
            this.colitemcode,
            this.colpt_des,
            this.colcantidad_rep,
            this.colpeso_rep,
            this.coleditado});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsFilter.UseNewCustomFilterDialog = true;
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdv_data_CellValueChanging);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_producto_termiado
            // 
            this.colid_producto_termiado.FieldName = "id_producto_termiado";
            this.colid_producto_termiado.Name = "colid_producto_termiado";
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
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 8;
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Peso KG";
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 9;
            // 
            // colcodigo_barra
            // 
            this.colcodigo_barra.Caption = "TM";
            this.colcodigo_barra.FieldName = "codigo_barra";
            this.colcodigo_barra.Name = "colcodigo_barra";
            this.colcodigo_barra.OptionsColumn.AllowEdit = false;
            this.colcodigo_barra.Visible = true;
            this.colcodigo_barra.VisibleIndex = 0;
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.Caption = "F Vencimiento";
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.OptionsColumn.AllowEdit = false;
            this.colfecha_vencimiento.Visible = true;
            this.colfecha_vencimiento.VisibleIndex = 6;
            // 
            // colfecha_produccion_producto_termiado
            // 
            this.colfecha_produccion_producto_termiado.Caption = "F Produccion";
            this.colfecha_produccion_producto_termiado.FieldName = "fecha_produccion_producto_termiado";
            this.colfecha_produccion_producto_termiado.Name = "colfecha_produccion_producto_termiado";
            this.colfecha_produccion_producto_termiado.OptionsColumn.AllowEdit = false;
            this.colfecha_produccion_producto_termiado.Visible = true;
            this.colfecha_produccion_producto_termiado.VisibleIndex = 4;
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.Caption = "F Ingreso";
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.OptionsColumn.AllowEdit = false;
            this.colfecha_ingreso.Visible = true;
            this.colfecha_ingreso.VisibleIndex = 5;
            // 
            // colid_presentacion
            // 
            this.colid_presentacion.Caption = "Presentacion";
            this.colid_presentacion.ColumnEdit = this.grd_date;
            this.colid_presentacion.FieldName = "id_presentacion";
            this.colid_presentacion.Name = "colid_presentacion";
            this.colid_presentacion.Visible = true;
            this.colid_presentacion.VisibleIndex = 7;
            // 
            // grd_date
            // 
            this.grd_date.AutoHeight = false;
            this.grd_date.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_date.DataSource = this.presentacionBindingSource;
            this.grd_date.DisplayMember = "descripcion";
            this.grd_date.Name = "grd_date";
            this.grd_date.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.grd_date.ValueMember = "id";
            // 
            // presentacionBindingSource
            // 
            this.presentacionBindingSource.DataMember = "presentacion";
            this.presentacionBindingSource.DataSource = this.dsPT;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Presentacion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            // 
            // colUbi
            // 
            this.colUbi.FieldName = "Ubi";
            this.colUbi.Name = "colUbi";
            this.colUbi.OptionsColumn.AllowEdit = false;
            this.colUbi.Visible = true;
            this.colUbi.VisibleIndex = 12;
            // 
            // coldel
            // 
            this.coldel.Caption = "Eliminar";
            this.coldel.FieldName = "del";
            this.coldel.Name = "coldel";
            this.coldel.Visible = true;
            this.coldel.VisibleIndex = 10;
            // 
            // colPor_lote
            // 
            this.colPor_lote.Caption = "Eliminar por lote";
            this.colPor_lote.FieldName = "Por_lote";
            this.colPor_lote.Name = "colPor_lote";
            this.colPor_lote.Visible = true;
            this.colPor_lote.VisibleIndex = 11;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "C.Producto";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 1;
            // 
            // colpt_des
            // 
            this.colpt_des.Caption = "Producto";
            this.colpt_des.FieldName = "pt_des";
            this.colpt_des.Name = "colpt_des";
            this.colpt_des.OptionsColumn.AllowEdit = false;
            this.colpt_des.Visible = true;
            this.colpt_des.VisibleIndex = 3;
            // 
            // colcantidad_rep
            // 
            this.colcantidad_rep.FieldName = "cantidad_rep";
            this.colcantidad_rep.Name = "colcantidad_rep";
            // 
            // colpeso_rep
            // 
            this.colpeso_rep.FieldName = "peso_rep";
            this.colpeso_rep.Name = "colpeso_rep";
            // 
            // coleditado
            // 
            this.coleditado.FieldName = "editado";
            this.coleditado.Name = "coleditado";
            // 
            // btn_new
            // 
            this.btn_new.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_new.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_new.Appearance.Options.UseBackColor = true;
            this.btn_new.Appearance.Options.UseFont = true;
            this.btn_new.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_new.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.ImageOptions.Image")));
            this.btn_new.Location = new System.Drawing.Point(12, 11);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(180, 57);
            this.btn_new.TabIndex = 37;
            this.btn_new.Text = "Guardar";
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // txtubicacion
            // 
            this.txtubicacion.Location = new System.Drawing.Point(130, 74);
            this.txtubicacion.Name = "txtubicacion";
            this.txtubicacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtubicacion.Properties.Appearance.Options.UseFont = true;
            this.txtubicacion.Size = new System.Drawing.Size(222, 28);
            this.txtubicacion.TabIndex = 38;
            this.txtubicacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit1_KeyDown);
            // 
            // lbltitel
            // 
            this.lbltitel.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitel.Appearance.Options.UseFont = true;
            this.lbltitel.Location = new System.Drawing.Point(11, 78);
            this.lbltitel.Name = "lbltitel";
            this.lbltitel.Size = new System.Drawing.Size(106, 20);
            this.lbltitel.TabIndex = 39;
            this.lbltitel.Text = "Escanera algo..:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 123);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 20);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "Producto:";
            this.labelControl1.Visible = false;
            // 
            // grd_producto
            // 
            this.grd_producto.Location = new System.Drawing.Point(130, 115);
            this.grd_producto.Name = "grd_producto";
            this.grd_producto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grd_producto.Properties.Appearance.Options.UseFont = true;
            this.grd_producto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_producto.Properties.DataSource = this.productoPTBindingSource;
            this.grd_producto.Properties.DisplayMember = "descripcion";
            this.grd_producto.Properties.PopupView = this.gridLookUpEdit1View;
            this.grd_producto.Properties.ValueMember = "descripcion2";
            this.grd_producto.Size = new System.Drawing.Size(222, 28);
            this.grd_producto.TabIndex = 42;
            this.grd_producto.Visible = false;
            this.grd_producto.EditValueChanged += new System.EventHandler(this.grd_producto_EditValueChanged);
            // 
            // productoPTBindingSource
            // 
            this.productoPTBindingSource.DataMember = "ProductoPT";
            this.productoPTBindingSource.DataSource = this.dsPT;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coldescripcion1,
            this.colenable});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.AllowEdit = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.ImageOptions.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(358, 66);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(51, 47);
            this.btnbuscar.TabIndex = 43;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // frm_tarimas_to_ajustar_PT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.grd_producto);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lbltitel);
            this.Controls.Add(this.txtubicacion);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_tarimas_to_ajustar_PT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_tarimas_to_ajustar_PT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajusteInvDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtubicacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_producto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoPTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraEditors.SimpleButton btn_new;
        private DevExpress.XtraEditors.TextEdit txtubicacion;
        private DevExpress.XtraEditors.LabelControl lbltitel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit grd_producto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource ajusteInvDetalleBindingSource;
        private dsPT dsPT;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_producto_termiado;
        private DevExpress.XtraGrid.Columns.GridColumn collote_producto_termiado;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_produccion_producto_termiado;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colid_presentacion;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colUbi;
        private DevExpress.XtraGrid.Columns.GridColumn coldel;
        private DevExpress.XtraGrid.Columns.GridColumn colPor_lote;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraEditors.SimpleButton btnbuscar;
        private System.Windows.Forms.BindingSource productoPTBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colpt_des;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit grd_date;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_rep;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_rep;
        private DevExpress.XtraGrid.Columns.GridColumn coleditado;
        private System.Windows.Forms.BindingSource presentacionBindingSource;
    }
}