
namespace LOSA.Reportes
{
    partial class frmVerTarimasVirtuales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerTarimasVirtuales));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.grdTarimasV = new DevExpress.XtraGrid.GridControl();
            this.grdvTarimasV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.reposbuttonVerVirtuales = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.dSReportes1 = new LOSA.Requisiciones.dSReportes();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_produccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_producto_termiado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_tarima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colturno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_alimentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.btnPrintSeleccionados = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdTarimasV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvTarimasV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposbuttonVerVirtuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReportes1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdHome.ImageOptions.SvgImage")));
            this.cmdHome.Location = new System.Drawing.Point(1089, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(129, 45);
            this.cmdHome.TabIndex = 44;
            this.cmdHome.Text = "Atras";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // grdTarimasV
            // 
            this.grdTarimasV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTarimasV.DataMember = "vertarimasv";
            this.grdTarimasV.DataSource = this.dSReportes1;
            this.grdTarimasV.Location = new System.Drawing.Point(2, 71);
            this.grdTarimasV.MainView = this.grdvTarimasV;
            this.grdTarimasV.Name = "grdTarimasV";
            this.grdTarimasV.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposbuttonVerVirtuales});
            this.grdTarimasV.Size = new System.Drawing.Size(1227, 692);
            this.grdTarimasV.TabIndex = 45;
            this.grdTarimasV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvTarimasV});
            // 
            // grdvTarimasV
            // 
            this.grdvTarimasV.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdvTarimasV.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdvTarimasV.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdvTarimasV.Appearance.Row.Options.UseFont = true;
            this.grdvTarimasV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colitemcode,
            this.colproducto,
            this.colfecha_ingreso,
            this.colfecha_produccion,
            this.colfecha_vencimiento,
            this.collote_pt,
            this.colid_presentacion,
            this.colpresentacion,
            this.colid_producto_termiado,
            this.colcodigo_barra,
            this.colestado_tarima,
            this.colcantidad,
            this.colpeso,
            this.colturno,
            this.colid_alimentacion,
            this.colseleccion});
            this.grdvTarimasV.GridControl = this.grdTarimasV;
            this.grdvTarimasV.Name = "grdvTarimasV";
            this.grdvTarimasV.OptionsView.ShowFooter = true;
            this.grdvTarimasV.OptionsView.ShowGroupPanel = false;
            // 
            // reposbuttonVerVirtuales
            // 
            this.reposbuttonVerVirtuales.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.reposbuttonVerVirtuales.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposbuttonVerVirtuales.Name = "reposbuttonVerVirtuales";
            this.reposbuttonVerVirtuales.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // dSReportes1
            // 
            this.dSReportes1.DataSetName = "dSReportes";
            this.dSReportes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Cod SAP";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            this.colitemcode.Width = 93;
            // 
            // colproducto
            // 
            this.colproducto.Caption = "Producto";
            this.colproducto.FieldName = "producto";
            this.colproducto.Name = "colproducto";
            this.colproducto.OptionsColumn.AllowEdit = false;
            this.colproducto.Visible = true;
            this.colproducto.VisibleIndex = 1;
            this.colproducto.Width = 93;
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.Caption = "F. Ingreso";
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.OptionsColumn.AllowEdit = false;
            this.colfecha_ingreso.Visible = true;
            this.colfecha_ingreso.VisibleIndex = 2;
            this.colfecha_ingreso.Width = 93;
            // 
            // colfecha_produccion
            // 
            this.colfecha_produccion.Caption = "F. Produccion";
            this.colfecha_produccion.DisplayFormat.FormatString = "g";
            this.colfecha_produccion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_produccion.FieldName = "fecha_produccion";
            this.colfecha_produccion.Name = "colfecha_produccion";
            this.colfecha_produccion.OptionsColumn.AllowEdit = false;
            this.colfecha_produccion.Visible = true;
            this.colfecha_produccion.VisibleIndex = 3;
            this.colfecha_produccion.Width = 104;
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.Caption = "F. Vencimiento";
            this.colfecha_vencimiento.DisplayFormat.FormatString = "g";
            this.colfecha_vencimiento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.OptionsColumn.AllowEdit = false;
            this.colfecha_vencimiento.Visible = true;
            this.colfecha_vencimiento.VisibleIndex = 4;
            this.colfecha_vencimiento.Width = 112;
            // 
            // collote_pt
            // 
            this.collote_pt.Caption = "Lote PT";
            this.collote_pt.FieldName = "lote_pt";
            this.collote_pt.Name = "collote_pt";
            this.collote_pt.OptionsColumn.AllowEdit = false;
            this.collote_pt.Visible = true;
            this.collote_pt.VisibleIndex = 5;
            this.collote_pt.Width = 87;
            // 
            // colid_presentacion
            // 
            this.colid_presentacion.FieldName = "id_presentacion";
            this.colid_presentacion.Name = "colid_presentacion";
            this.colid_presentacion.OptionsColumn.AllowEdit = false;
            // 
            // colpresentacion
            // 
            this.colpresentacion.Caption = "Presentacion";
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.OptionsColumn.AllowEdit = false;
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 6;
            this.colpresentacion.Width = 100;
            // 
            // colid_producto_termiado
            // 
            this.colid_producto_termiado.FieldName = "id_producto_termiado";
            this.colid_producto_termiado.Name = "colid_producto_termiado";
            this.colid_producto_termiado.OptionsColumn.AllowEdit = false;
            // 
            // colcodigo_barra
            // 
            this.colcodigo_barra.Caption = "Codigo de Barra";
            this.colcodigo_barra.FieldName = "codigo_barra";
            this.colcodigo_barra.Name = "colcodigo_barra";
            this.colcodigo_barra.OptionsColumn.AllowEdit = false;
            this.colcodigo_barra.Visible = true;
            this.colcodigo_barra.VisibleIndex = 7;
            this.colcodigo_barra.Width = 136;
            // 
            // colestado_tarima
            // 
            this.colestado_tarima.Caption = "Estado";
            this.colestado_tarima.FieldName = "estado_tarima";
            this.colestado_tarima.Name = "colestado_tarima";
            this.colestado_tarima.OptionsColumn.AllowEdit = false;
            this.colestado_tarima.Visible = true;
            this.colestado_tarima.VisibleIndex = 8;
            this.colestado_tarima.Width = 81;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 9;
            this.colcantidad.Width = 81;
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Peso";
            this.colpeso.DisplayFormat.FormatString = "n2";
            this.colpeso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.OptionsColumn.AllowEdit = false;
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 10;
            this.colpeso.Width = 80;
            // 
            // colturno
            // 
            this.colturno.Caption = "Turno";
            this.colturno.FieldName = "turno";
            this.colturno.Name = "colturno";
            this.colturno.OptionsColumn.AllowEdit = false;
            this.colturno.Visible = true;
            this.colturno.VisibleIndex = 11;
            this.colturno.Width = 55;
            // 
            // colid_alimentacion
            // 
            this.colid_alimentacion.FieldName = "id_alimentacion";
            this.colid_alimentacion.Name = "colid_alimentacion";
            this.colid_alimentacion.OptionsColumn.AllowEdit = false;
            // 
            // colseleccion
            // 
            this.colseleccion.Caption = "Seleccionar";
            this.colseleccion.FieldName = "seleccion";
            this.colseleccion.Name = "colseleccion";
            this.colseleccion.Visible = true;
            this.colseleccion.VisibleIndex = 12;
            this.colseleccion.Width = 94;
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(729, 40);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(112, 17);
            this.checkBoxSelectAll.TabIndex = 68;
            this.checkBoxSelectAll.Text = "Seleccionar Todas";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
            // 
            // btnPrintSeleccionados
            // 
            this.btnPrintSeleccionados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintSeleccionados.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrintSeleccionados.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSeleccionados.Appearance.Options.UseBackColor = true;
            this.btnPrintSeleccionados.Appearance.Options.UseFont = true;
            this.btnPrintSeleccionados.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnPrintSeleccionados.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPrintSeleccionados.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrintSeleccionados.ImageOptions.SvgImage")));
            this.btnPrintSeleccionados.Location = new System.Drawing.Point(847, 12);
            this.btnPrintSeleccionados.Name = "btnPrintSeleccionados";
            this.btnPrintSeleccionados.Size = new System.Drawing.Size(187, 45);
            this.btnPrintSeleccionados.TabIndex = 67;
            this.btnPrintSeleccionados.Text = "Imprimir Seleccionado";
            this.btnPrintSeleccionados.Click += new System.EventHandler(this.btnPrintSeleccionados_Click);
            // 
            // frmVerTarimasVirtuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 764);
            this.Controls.Add(this.checkBoxSelectAll);
            this.Controls.Add(this.btnPrintSeleccionados);
            this.Controls.Add(this.grdTarimasV);
            this.Controls.Add(this.cmdHome);
            this.Name = "frmVerTarimasVirtuales";
            this.Text = "frmVerTarimasVirtuales";
            ((System.ComponentModel.ISupportInitialize)(this.grdTarimasV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvTarimasV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposbuttonVerVirtuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReportes1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraGrid.GridControl grdTarimasV;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvTarimasV;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposbuttonVerVirtuales;
        private Requisiciones.dSReportes dSReportes1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_produccion;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn collote_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colid_presentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_producto_termiado;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_tarima;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn colturno;
        private DevExpress.XtraGrid.Columns.GridColumn colid_alimentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccion;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private DevExpress.XtraEditors.SimpleButton btnPrintSeleccionados;
    }
}