
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
            this.dsMicro1 = new LOSA.Micro.dsMicro();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.cmdUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.colseleccion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNavegacionLote)).BeginInit();
            this.SuspendLayout();
            // 
            // dsMicro1
            // 
            this.dsMicro1.DataSetName = "dsMicro";
            this.dsMicro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "lotes_seleccion";
            this.gridControl1.DataSource = this.dsMicro1;
            this.gridControl1.Location = new System.Drawing.Point(2, 116);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnNavegacionLote});
            this.gridControl1.Size = new System.Drawing.Size(991, 465);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.colseleccion});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colunidades
            // 
            this.colunidades.Caption = "Unidades";
            this.colunidades.DisplayFormat.FormatString = "###";
            this.colunidades.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colunidades.FieldName = "unidades";
            this.colunidades.Name = "colunidades";
            this.colunidades.OptionsColumn.AllowEdit = false;
            this.colunidades.Visible = true;
            this.colunidades.VisibleIndex = 0;
            this.colunidades.Width = 66;
            // 
            // colpeso_kg
            // 
            this.colpeso_kg.Caption = "Kg";
            this.colpeso_kg.FieldName = "peso_kg";
            this.colpeso_kg.Name = "colpeso_kg";
            this.colpeso_kg.OptionsColumn.AllowEdit = false;
            this.colpeso_kg.Visible = true;
            this.colpeso_kg.VisibleIndex = 1;
            this.colpeso_kg.Width = 70;
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
            this.colnombre_comercial.Visible = true;
            this.colnombre_comercial.VisibleIndex = 3;
            this.colnombre_comercial.Width = 232;
            // 
            // collote_materia_prima
            // 
            this.collote_materia_prima.Caption = "Lote";
            this.collote_materia_prima.ColumnEdit = this.btnNavegacionLote;
            this.collote_materia_prima.FieldName = "lote_materia_prima";
            this.collote_materia_prima.Name = "collote_materia_prima";
            this.collote_materia_prima.Visible = true;
            this.collote_materia_prima.VisibleIndex = 4;
            this.collote_materia_prima.Width = 119;
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
            this.colnumero_ingreso.Visible = true;
            this.colnumero_ingreso.VisibleIndex = 5;
            this.colnumero_ingreso.Width = 88;
            // 
            // colfecha_entrega
            // 
            this.colfecha_entrega.Caption = "Fecha";
            this.colfecha_entrega.DisplayFormat.FormatString = "g";
            this.colfecha_entrega.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_entrega.FieldName = "fecha_entrega";
            this.colfecha_entrega.Name = "colfecha_entrega";
            this.colfecha_entrega.OptionsColumn.AllowEdit = false;
            this.colfecha_entrega.Visible = true;
            this.colfecha_entrega.VisibleIndex = 6;
            this.colfecha_entrega.Width = 109;
            // 
            // colcode_sap
            // 
            this.colcode_sap.Caption = "Codigo SAP";
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.AllowEdit = false;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 2;
            this.colcode_sap.Width = 86;
            // 
            // colfechav
            // 
            this.colfechav.Caption = "Fecha Vencimiento";
            this.colfechav.DisplayFormat.FormatString = "d";
            this.colfechav.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfechav.FieldName = "fechav";
            this.colfechav.Name = "colfechav";
            this.colfechav.Visible = true;
            this.colfechav.VisibleIndex = 7;
            this.colfechav.Width = 79;
            // 
            // colpv
            // 
            this.colpv.Caption = "Proveedor";
            this.colpv.FieldName = "pv";
            this.colpv.Name = "colpv";
            this.colpv.Visible = true;
            this.colpv.VisibleIndex = 8;
            this.colpv.Width = 134;
            // 
            // cmdClose
            // 
            this.cmdClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Appearance.Options.UseFont = true;
            this.cmdClose.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdClose.Location = new System.Drawing.Point(907, 47);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 63);
            this.cmdClose.TabIndex = 6;
            this.cmdClose.Text = "Cerrar";
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmdUpdate.Appearance.Options.UseFont = true;
            this.cmdUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdUpdate.ImageOptions.Image")));
            this.cmdUpdate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdUpdate.Location = new System.Drawing.Point(826, 47);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(75, 63);
            this.cmdUpdate.TabIndex = 5;
            this.cmdUpdate.Text = "Recargar";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(745, 47);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 63);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Aplicar";
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
            this.lblTitulo.Size = new System.Drawing.Size(334, 34);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Seleccion de Lote";
            // 
            // colseleccion
            // 
            this.colseleccion.Caption = "Seleccionar";
            this.colseleccion.FieldName = "seleccion";
            this.colseleccion.Name = "colseleccion";
            this.colseleccion.Visible = true;
            this.colseleccion.VisibleIndex = 9;
            // 
            // frmSelectLotePesaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 583);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmSelectLotePesaje";
            this.Text = "Lotes Disponibles";
            ((System.ComponentModel.ISupportInitialize)(this.dsMicro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNavegacionLote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Micro.dsMicro dsMicro1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
    }
}