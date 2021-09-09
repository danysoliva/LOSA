
namespace LOSA.MicroIngredientes
{
    partial class frmSelectLotePesaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectLotePesaje));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcLotesSeleccionados = new DevExpress.XtraGrid.GridControl();
            this.lotesseleccionBindingSource = new System.Windows.Forms.BindingSource();
            this.dsMicro = new LOSA.Micro.dsMicro();
            this.gvLotesSeleccionados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colunidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_kg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNavegacionLote = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colnumero_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_entrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechav = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.cmdUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.ceSeleccion = new DevExpress.XtraEditors.CheckEdit();
            this.lblPesoDisponible = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcLotesSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesseleccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotesSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNavegacionLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSeleccion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcLotesSeleccionados
            // 
            this.gcLotesSeleccionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcLotesSeleccionados.DataSource = this.lotesseleccionBindingSource;
            this.gcLotesSeleccionados.Location = new System.Drawing.Point(2, 136);
            this.gcLotesSeleccionados.MainView = this.gvLotesSeleccionados;
            this.gcLotesSeleccionados.Name = "gcLotesSeleccionados";
            this.gcLotesSeleccionados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnNavegacionLote,
            this.repositoryItemCheckEdit1});
            this.gcLotesSeleccionados.Size = new System.Drawing.Size(1218, 521);
            this.gcLotesSeleccionados.TabIndex = 1;
            this.gcLotesSeleccionados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLotesSeleccionados});
            // 
            // lotesseleccionBindingSource
            // 
            this.lotesseleccionBindingSource.DataMember = "lotes_seleccion";
            this.lotesseleccionBindingSource.DataSource = this.dsMicro;
            // 
            // dsMicro
            // 
            this.dsMicro.DataSetName = "dsMicro";
            this.dsMicro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvLotesSeleccionados
            // 
            this.gvLotesSeleccionados.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLotesSeleccionados.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvLotesSeleccionados.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLotesSeleccionados.Appearance.Row.Options.UseFont = true;
            this.gvLotesSeleccionados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colunidades,
            this.colpeso_kg,
            this.colid_materia_prima,
            this.colnombre_comercial,
            this.collote_materia_prima,
            this.colnumero_ingreso,
            this.colfecha_entrega,
            this.colcode_sap,
            this.colfechav,
            this.colpv,
            this.colseleccion,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvLotesSeleccionados.GridControl = this.gcLotesSeleccionados;
            this.gvLotesSeleccionados.Name = "gvLotesSeleccionados";
            this.gvLotesSeleccionados.OptionsView.ShowAutoFilterRow = true;
            this.gvLotesSeleccionados.OptionsView.ShowGroupPanel = false;
            // 
            // colunidades
            // 
            this.colunidades.Caption = "Unidades";
            this.colunidades.DisplayFormat.FormatString = "{0:N2}";
            this.colunidades.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colunidades.FieldName = "unidades";
            this.colunidades.Name = "colunidades";
            this.colunidades.OptionsColumn.AllowEdit = false;
            this.colunidades.OptionsFilter.AllowFilter = false;
            this.colunidades.Visible = true;
            this.colunidades.VisibleIndex = 0;
            // 
            // colpeso_kg
            // 
            this.colpeso_kg.Caption = "Kg";
            this.colpeso_kg.FieldName = "peso_kg";
            this.colpeso_kg.Name = "colpeso_kg";
            this.colpeso_kg.OptionsColumn.AllowEdit = false;
            this.colpeso_kg.OptionsFilter.AllowFilter = false;
            this.colpeso_kg.Visible = true;
            this.colpeso_kg.VisibleIndex = 2;
            this.colpeso_kg.Width = 83;
            // 
            // colid_materia_prima
            // 
            this.colid_materia_prima.FieldName = "id_materia_prima";
            this.colid_materia_prima.Name = "colid_materia_prima";
            this.colid_materia_prima.OptionsColumn.AllowEdit = false;
            // 
            // colnombre_comercial
            // 
            this.colnombre_comercial.Caption = "Nombre";
            this.colnombre_comercial.FieldName = "nombre_comercial";
            this.colnombre_comercial.Name = "colnombre_comercial";
            this.colnombre_comercial.OptionsColumn.AllowEdit = false;
            this.colnombre_comercial.OptionsFilter.AllowFilter = false;
            this.colnombre_comercial.Visible = true;
            this.colnombre_comercial.VisibleIndex = 5;
            this.colnombre_comercial.Width = 209;
            // 
            // collote_materia_prima
            // 
            this.collote_materia_prima.Caption = "Lote";
            this.collote_materia_prima.ColumnEdit = this.btnNavegacionLote;
            this.collote_materia_prima.FieldName = "lote_materia_prima";
            this.collote_materia_prima.Name = "collote_materia_prima";
            this.collote_materia_prima.OptionsFilter.AllowFilter = false;
            this.collote_materia_prima.Visible = true;
            this.collote_materia_prima.VisibleIndex = 6;
            this.collote_materia_prima.Width = 89;
            // 
            // btnNavegacionLote
            // 
            this.btnNavegacionLote.AutoHeight = false;
            editorButtonImageOptions1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnNavegacionLote.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnNavegacionLote.Name = "btnNavegacionLote";
            this.btnNavegacionLote.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colnumero_ingreso
            // 
            this.colnumero_ingreso.Caption = "Num. Ingreso";
            this.colnumero_ingreso.FieldName = "numero_ingreso";
            this.colnumero_ingreso.Name = "colnumero_ingreso";
            this.colnumero_ingreso.OptionsColumn.AllowEdit = false;
            this.colnumero_ingreso.OptionsFilter.AllowFilter = false;
            this.colnumero_ingreso.Visible = true;
            this.colnumero_ingreso.VisibleIndex = 7;
            this.colnumero_ingreso.Width = 81;
            // 
            // colfecha_entrega
            // 
            this.colfecha_entrega.Caption = "Fecha";
            this.colfecha_entrega.DisplayFormat.FormatString = "g";
            this.colfecha_entrega.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_entrega.FieldName = "fecha_entrega";
            this.colfecha_entrega.Name = "colfecha_entrega";
            this.colfecha_entrega.OptionsColumn.AllowEdit = false;
            this.colfecha_entrega.OptionsFilter.AllowFilter = false;
            this.colfecha_entrega.Width = 77;
            // 
            // colcode_sap
            // 
            this.colcode_sap.Caption = "Codigo SAP";
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.AllowEdit = false;
            this.colcode_sap.OptionsFilter.AllowFilter = false;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 4;
            this.colcode_sap.Width = 86;
            // 
            // colfechav
            // 
            this.colfechav.Caption = "Fecha Vencimiento";
            this.colfechav.DisplayFormat.FormatString = "d";
            this.colfechav.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfechav.FieldName = "fechav";
            this.colfechav.Name = "colfechav";
            this.colfechav.OptionsFilter.AllowFilter = false;
            this.colfechav.Width = 96;
            // 
            // colpv
            // 
            this.colpv.Caption = "Proveedor";
            this.colpv.FieldName = "pv";
            this.colpv.Name = "colpv";
            this.colpv.OptionsColumn.AllowEdit = false;
            this.colpv.OptionsFilter.AllowFilter = false;
            this.colpv.Visible = true;
            this.colpv.VisibleIndex = 8;
            this.colpv.Width = 97;
            // 
            // colseleccion
            // 
            this.colseleccion.Caption = "Selecc.";
            this.colseleccion.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colseleccion.FieldName = "seleccion";
            this.colseleccion.Name = "colseleccion";
            this.colseleccion.OptionsFilter.AllowFilter = false;
            this.colseleccion.Visible = true;
            this.colseleccion.VisibleIndex = 9;
            this.colseleccion.Width = 61;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.EditValueChanged += new System.EventHandler(this.repositoryItemCheckEdit1_EditValueChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "cant_restante";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Width = 60;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.BackColor = System.Drawing.Color.AliceBlue;
            this.gridColumn2.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn2.Caption = "KG Seleccionados";
            this.gridColumn2.DisplayFormat.FormatString = "{N:2}";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "cant_seleccionada";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 117;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.BackColor = System.Drawing.Color.AliceBlue;
            this.gridColumn3.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn3.Caption = "Unid. Seleccionadas";
            this.gridColumn3.DisplayFormat.FormatString = "{N:2}";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "unidades_seleccionadas";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 129;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "unidades_restantes";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "presentacion_factor";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "id_tarima";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Appearance.Options.UseFont = true;
            this.cmdClose.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdClose.Location = new System.Drawing.Point(1134, 12);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 63);
            this.cmdClose.TabIndex = 6;
            this.cmdClose.Text = "Cerrar";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdUpdate.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmdUpdate.Appearance.Options.UseFont = true;
            this.cmdUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdUpdate.ImageOptions.Image")));
            this.cmdUpdate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdUpdate.Location = new System.Drawing.Point(1053, 12);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(75, 63);
            this.cmdUpdate.TabIndex = 5;
            this.cmdUpdate.Text = "Recargar";
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(972, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 63);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Aplicar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Appearance.Options.UseTextOptions = true;
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitulo.Location = new System.Drawing.Point(300, 76);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(561, 34);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Seleccion de Lote";
            // 
            // ceSeleccion
            // 
            this.ceSeleccion.Location = new System.Drawing.Point(12, 110);
            this.ceSeleccion.Name = "ceSeleccion";
            this.ceSeleccion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceSeleccion.Properties.Appearance.Options.UseFont = true;
            this.ceSeleccion.Properties.Caption = "Selección Automática";
            this.ceSeleccion.Size = new System.Drawing.Size(144, 20);
            this.ceSeleccion.TabIndex = 9;
            this.ceSeleccion.CheckedChanged += new System.EventHandler(this.ceSeleccion_CheckedChanged);
            // 
            // lblPesoDisponible
            // 
            this.lblPesoDisponible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPesoDisponible.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoDisponible.Appearance.Options.UseFont = true;
            this.lblPesoDisponible.Appearance.Options.UseTextOptions = true;
            this.lblPesoDisponible.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblPesoDisponible.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPesoDisponible.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopRight;
            this.lblPesoDisponible.Location = new System.Drawing.Point(873, 81);
            this.lblPesoDisponible.Name = "lblPesoDisponible";
            this.lblPesoDisponible.Size = new System.Drawing.Size(332, 34);
            this.lblPesoDisponible.TabIndex = 10;
            this.lblPesoDisponible.Text = "Peso disponible";
            this.lblPesoDisponible.Click += new System.EventHandler(this.lblPesoDisponible_Click);
            // 
            // frmSelectLotePesaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 659);
            this.Controls.Add(this.lblPesoDisponible);
            this.Controls.Add(this.ceSeleccion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.gcLotesSeleccionados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSelectLotePesaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotes Disponibles";
            ((System.ComponentModel.ISupportInitialize)(this.gcLotesSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesseleccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotesSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNavegacionLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSeleccion.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcLotesSeleccionados;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLotesSeleccionados;
        private DevExpress.XtraGrid.Columns.GridColumn colunidades;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_kg;
        private DevExpress.XtraGrid.Columns.GridColumn colid_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn collote_materia_prima;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnNavegacionLote;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_entrega;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap;
        private DevExpress.XtraGrid.Columns.GridColumn colfechav;
        private DevExpress.XtraGrid.Columns.GridColumn colpv;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.SimpleButton cmdUpdate;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl lblTitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccion;
        private DevExpress.XtraEditors.CheckEdit ceSeleccion;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.LabelControl lblPesoDisponible;
        private System.Windows.Forms.BindingSource lotesseleccionBindingSource;
        public Micro.dsMicro dsMicro;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}