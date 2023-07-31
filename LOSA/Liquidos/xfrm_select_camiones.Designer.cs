
namespace LOSA.Liquidos
{
    partial class xfrm_select_camiones
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrm_select_camiones));
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.camionesINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLiquidos_ = new LOSA.Liquidos.dsLiquidos_();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colempresaTrans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_entrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colshipid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNBoleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpesoBruto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpesonetoIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresoProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpesoSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconductorin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvehiculo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfurgon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoBoleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipo_boleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSNegocio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ceSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cmdConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camionesINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLiquidos_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSeleccionar)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataSource = this.camionesINBindingSource;
            this.grd_data.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grd_data.Location = new System.Drawing.Point(4, 217);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSeleccionar,
            this.ceSeleccionar});
            this.grd_data.Size = new System.Drawing.Size(3102, 602);
            this.grd_data.TabIndex = 1;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // camionesINBindingSource
            // 
            this.camionesINBindingSource.DataMember = "Camiones_IN";
            this.camionesINBindingSource.DataSource = this.dsLiquidos_;
            // 
            // dsLiquidos_
            // 
            this.dsLiquidos_.DataSetName = "dsLiquidos_";
            this.dsLiquidos_.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcomentarios,
            this.colempresaTrans,
            this.colfecha_entrada,
            this.colfecha_fin,
            this.colshipid,
            this.colbarco,
            this.colNBoleta,
            this.colnumero_factura,
            this.coloperador,
            this.colpesoBruto,
            this.colpesonetoIn,
            this.colpresoProd,
            this.colpesoSalida,
            this.colpeso_factura,
            this.colconductorin,
            this.colvehiculo,
            this.colfurgon,
            this.colTipoBoleta,
            this.colid_tipo_boleta,
            this.colSNegocio,
            this.colProducto,
            this.colitemcode,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.grdv_data.DetailHeight = 673;
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdv_data_CellValueChanged);
            this.grdv_data.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdv_data_CellValueChanging);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 40;
            this.colid.Name = "colid";
            this.colid.Width = 150;
            // 
            // colcomentarios
            // 
            this.colcomentarios.FieldName = "comentarios";
            this.colcomentarios.MinWidth = 40;
            this.colcomentarios.Name = "colcomentarios";
            this.colcomentarios.Width = 360;
            // 
            // colempresaTrans
            // 
            this.colempresaTrans.FieldName = "empresaTrans";
            this.colempresaTrans.MinWidth = 40;
            this.colempresaTrans.Name = "colempresaTrans";
            this.colempresaTrans.Width = 296;
            // 
            // colfecha_entrada
            // 
            this.colfecha_entrada.FieldName = "fechaEntra";
            this.colfecha_entrada.MinWidth = 40;
            this.colfecha_entrada.Name = "colfecha_entrada";
            this.colfecha_entrada.OptionsColumn.AllowEdit = false;
            this.colfecha_entrada.Visible = true;
            this.colfecha_entrada.VisibleIndex = 1;
            this.colfecha_entrada.Width = 178;
            // 
            // colfecha_fin
            // 
            this.colfecha_fin.FieldName = "FechaFin";
            this.colfecha_fin.MinWidth = 40;
            this.colfecha_fin.Name = "colfecha_fin";
            this.colfecha_fin.OptionsColumn.AllowEdit = false;
            this.colfecha_fin.Visible = true;
            this.colfecha_fin.VisibleIndex = 2;
            this.colfecha_fin.Width = 148;
            // 
            // colshipid
            // 
            this.colshipid.FieldName = "shipid";
            this.colshipid.MinWidth = 40;
            this.colshipid.Name = "colshipid";
            this.colshipid.OptionsColumn.AllowEdit = false;
            this.colshipid.Width = 136;
            // 
            // colbarco
            // 
            this.colbarco.FieldName = "barco";
            this.colbarco.MinWidth = 40;
            this.colbarco.Name = "colbarco";
            this.colbarco.Width = 124;
            // 
            // colNBoleta
            // 
            this.colNBoleta.FieldName = "NBoleta";
            this.colNBoleta.MinWidth = 40;
            this.colNBoleta.Name = "colNBoleta";
            this.colNBoleta.OptionsColumn.AllowEdit = false;
            this.colNBoleta.Visible = true;
            this.colNBoleta.VisibleIndex = 0;
            this.colNBoleta.Width = 146;
            // 
            // colnumero_factura
            // 
            this.colnumero_factura.FieldName = "numero_factura";
            this.colnumero_factura.MinWidth = 40;
            this.colnumero_factura.Name = "colnumero_factura";
            this.colnumero_factura.Width = 248;
            // 
            // coloperador
            // 
            this.coloperador.Caption = "Operador";
            this.coloperador.FieldName = "operador";
            this.coloperador.MinWidth = 40;
            this.coloperador.Name = "coloperador";
            this.coloperador.OptionsColumn.AllowEdit = false;
            this.coloperador.Visible = true;
            this.coloperador.VisibleIndex = 4;
            this.coloperador.Width = 174;
            // 
            // colpesoBruto
            // 
            this.colpesoBruto.FieldName = "PesoBruto";
            this.colpesoBruto.MinWidth = 40;
            this.colpesoBruto.Name = "colpesoBruto";
            this.colpesoBruto.OptionsColumn.AllowEdit = false;
            this.colpesoBruto.Visible = true;
            this.colpesoBruto.VisibleIndex = 5;
            this.colpesoBruto.Width = 210;
            // 
            // colpesonetoIn
            // 
            this.colpesonetoIn.FieldName = "PesonetoIn";
            this.colpesonetoIn.MinWidth = 40;
            this.colpesonetoIn.Name = "colpesonetoIn";
            this.colpesonetoIn.OptionsColumn.AllowEdit = false;
            this.colpesonetoIn.Visible = true;
            this.colpesonetoIn.VisibleIndex = 6;
            this.colpesonetoIn.Width = 196;
            // 
            // colpresoProd
            // 
            this.colpresoProd.FieldName = "PesoProd";
            this.colpresoProd.MinWidth = 40;
            this.colpresoProd.Name = "colpresoProd";
            this.colpresoProd.OptionsColumn.AllowEdit = false;
            this.colpresoProd.Visible = true;
            this.colpresoProd.VisibleIndex = 7;
            this.colpresoProd.Width = 200;
            // 
            // colpesoSalida
            // 
            this.colpesoSalida.Caption = "Peso Salida";
            this.colpesoSalida.FieldName = "pesoSalida";
            this.colpesoSalida.MinWidth = 40;
            this.colpesoSalida.Name = "colpesoSalida";
            this.colpesoSalida.OptionsColumn.AllowEdit = false;
            this.colpesoSalida.Visible = true;
            this.colpesoSalida.VisibleIndex = 8;
            this.colpesoSalida.Width = 176;
            // 
            // colpeso_factura
            // 
            this.colpeso_factura.FieldName = "peso_factura";
            this.colpeso_factura.MinWidth = 40;
            this.colpeso_factura.Name = "colpeso_factura";
            this.colpeso_factura.Width = 204;
            // 
            // colconductorin
            // 
            this.colconductorin.FieldName = "conductorin";
            this.colconductorin.MinWidth = 40;
            this.colconductorin.Name = "colconductorin";
            this.colconductorin.OptionsColumn.AllowEdit = false;
            this.colconductorin.Visible = true;
            this.colconductorin.VisibleIndex = 9;
            this.colconductorin.Width = 204;
            // 
            // colvehiculo
            // 
            this.colvehiculo.FieldName = "vehiculo";
            this.colvehiculo.MinWidth = 40;
            this.colvehiculo.Name = "colvehiculo";
            this.colvehiculo.OptionsColumn.AllowEdit = false;
            this.colvehiculo.Visible = true;
            this.colvehiculo.VisibleIndex = 10;
            this.colvehiculo.Width = 134;
            // 
            // colfurgon
            // 
            this.colfurgon.Caption = "Furgón";
            this.colfurgon.FieldName = "furgon";
            this.colfurgon.MinWidth = 40;
            this.colfurgon.Name = "colfurgon";
            this.colfurgon.OptionsColumn.AllowEdit = false;
            this.colfurgon.Visible = true;
            this.colfurgon.VisibleIndex = 11;
            this.colfurgon.Width = 154;
            // 
            // colTipoBoleta
            // 
            this.colTipoBoleta.FieldName = "TipoBoleta";
            this.colTipoBoleta.MinWidth = 40;
            this.colTipoBoleta.Name = "colTipoBoleta";
            this.colTipoBoleta.Width = 122;
            // 
            // colid_tipo_boleta
            // 
            this.colid_tipo_boleta.FieldName = "id_tipo_boleta";
            this.colid_tipo_boleta.MinWidth = 40;
            this.colid_tipo_boleta.Name = "colid_tipo_boleta";
            this.colid_tipo_boleta.Width = 102;
            // 
            // colSNegocio
            // 
            this.colSNegocio.FieldName = "SNegocio";
            this.colSNegocio.MinWidth = 40;
            this.colSNegocio.Name = "colSNegocio";
            this.colSNegocio.OptionsColumn.AllowEdit = false;
            this.colSNegocio.Visible = true;
            this.colSNegocio.VisibleIndex = 12;
            this.colSNegocio.Width = 220;
            // 
            // colProducto
            // 
            this.colProducto.FieldName = "Producto";
            this.colProducto.MinWidth = 40;
            this.colProducto.Name = "colProducto";
            this.colProducto.OptionsColumn.AllowEdit = false;
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 3;
            this.colProducto.Width = 222;
            // 
            // colitemcode
            // 
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.MinWidth = 40;
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.Width = 182;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Selecc.";
            this.gridColumn1.FieldName = "seleccionar";
            this.gridColumn1.MinWidth = 40;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 13;
            this.gridColumn1.Width = 146;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "cardcode";
            this.gridColumn2.MinWidth = 40;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 150;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "cardname";
            this.gridColumn3.MinWidth = 40;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 150;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.tap;
            this.btnSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // ceSeleccionar
            // 
            this.ceSeleccionar.AutoHeight = false;
            this.ceSeleccionar.Name = "ceSeleccionar";
            // 
            // cmdConfirm
            // 
            this.cmdConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdConfirm.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdConfirm.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConfirm.Appearance.Options.UseBackColor = true;
            this.cmdConfirm.Appearance.Options.UseFont = true;
            this.cmdConfirm.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdConfirm.ImageOptions.Image")));
            this.cmdConfirm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdConfirm.Location = new System.Drawing.Point(2480, 83);
            this.cmdConfirm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdConfirm.Name = "cmdConfirm";
            this.cmdConfirm.Size = new System.Drawing.Size(270, 108);
            this.cmdConfirm.TabIndex = 97;
            this.cmdConfirm.Text = "Confirmar";
            this.cmdConfirm.Click += new System.EventHandler(this.cmdConfirm_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(2792, 83);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(270, 108);
            this.simpleButton1.TabIndex = 98;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(4, 83);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(3102, 48);
            this.labelControl1.TabIndex = 99;
            this.labelControl1.Text = "Boletas Líquidos";
            // 
            // xfrm_select_camiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3108, 819);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdConfirm);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "xfrm_select_camiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Camiones";
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camionesINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLiquidos_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSeleccionar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_data;
        private System.Windows.Forms.BindingSource camionesINBindingSource;
        private dsLiquidos_ dsLiquidos_;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentarios;
        private DevExpress.XtraGrid.Columns.GridColumn colempresaTrans;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_entrada;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_fin;
        private DevExpress.XtraGrid.Columns.GridColumn colshipid;
        private DevExpress.XtraGrid.Columns.GridColumn colbarco;
        private DevExpress.XtraGrid.Columns.GridColumn colNBoleta;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_factura;
        private DevExpress.XtraGrid.Columns.GridColumn coloperador;
        private DevExpress.XtraGrid.Columns.GridColumn colpesoBruto;
        private DevExpress.XtraGrid.Columns.GridColumn colpesonetoIn;
        private DevExpress.XtraGrid.Columns.GridColumn colpresoProd;
        private DevExpress.XtraGrid.Columns.GridColumn colpesoSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colconductorin;
        private DevExpress.XtraGrid.Columns.GridColumn colvehiculo;
        private DevExpress.XtraGrid.Columns.GridColumn colfurgon;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoBoleta;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_boleta;
        private DevExpress.XtraGrid.Columns.GridColumn colSNegocio;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSeleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ceSeleccionar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton cmdConfirm;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}