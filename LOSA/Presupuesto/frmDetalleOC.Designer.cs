
namespace LOSA.Presupuesto
{
    partial class frmDetalleOC
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_orden_h = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcapitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpartida_arancelaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion_articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio_por_unidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colindicador_impuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_detalle_presupuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresupuesto_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsPresupuesto1 = new LOSA.Presupuesto.dsPresupuesto();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_h = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colU_TipoOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubido_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreadopor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colU_AquaExoneracion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dsCompras1 = new LOSA.Compras.dsCompras();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_orden_h,
            this.colcapitulo,
            this.colpartida_arancelaria,
            this.colitemcode,
            this.coldescripcion_articulo,
            this.colcantidad,
            this.colprecio_por_unidad,
            this.colindicador_impuesto,
            this.coltotal,
            this.colisv,
            this.colid_detalle_presupuesto,
            this.colpresupuesto_descripcion});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colid_orden_h
            // 
            this.colid_orden_h.FieldName = "id_orden_h";
            this.colid_orden_h.Name = "colid_orden_h";
            this.colid_orden_h.OptionsColumn.AllowEdit = false;
            this.colid_orden_h.OptionsColumn.ReadOnly = true;
            // 
            // colcapitulo
            // 
            this.colcapitulo.Caption = "Capitulo";
            this.colcapitulo.FieldName = "capitulo";
            this.colcapitulo.Name = "colcapitulo";
            this.colcapitulo.OptionsColumn.AllowEdit = false;
            this.colcapitulo.OptionsColumn.ReadOnly = true;
            this.colcapitulo.Visible = true;
            this.colcapitulo.VisibleIndex = 2;
            // 
            // colpartida_arancelaria
            // 
            this.colpartida_arancelaria.Caption = "Partida Arancelaria";
            this.colpartida_arancelaria.FieldName = "partida_arancelaria";
            this.colpartida_arancelaria.Name = "colpartida_arancelaria";
            this.colpartida_arancelaria.OptionsColumn.AllowEdit = false;
            this.colpartida_arancelaria.OptionsColumn.ReadOnly = true;
            this.colpartida_arancelaria.Visible = true;
            this.colpartida_arancelaria.VisibleIndex = 3;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "ItemCode";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.OptionsColumn.ReadOnly = true;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            // 
            // coldescripcion_articulo
            // 
            this.coldescripcion_articulo.Caption = "Descripcion del Articulo";
            this.coldescripcion_articulo.FieldName = "descripcion_articulo";
            this.coldescripcion_articulo.Name = "coldescripcion_articulo";
            this.coldescripcion_articulo.OptionsColumn.AllowEdit = false;
            this.coldescripcion_articulo.OptionsColumn.ReadOnly = true;
            this.coldescripcion_articulo.Visible = true;
            this.coldescripcion_articulo.VisibleIndex = 1;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colcantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.OptionsColumn.ReadOnly = true;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 5;
            // 
            // colprecio_por_unidad
            // 
            this.colprecio_por_unidad.Caption = "Precio";
            this.colprecio_por_unidad.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colprecio_por_unidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprecio_por_unidad.FieldName = "precio_por_unidad";
            this.colprecio_por_unidad.Name = "colprecio_por_unidad";
            this.colprecio_por_unidad.OptionsColumn.AllowEdit = false;
            this.colprecio_por_unidad.OptionsColumn.ReadOnly = true;
            this.colprecio_por_unidad.Visible = true;
            this.colprecio_por_unidad.VisibleIndex = 6;
            // 
            // colindicador_impuesto
            // 
            this.colindicador_impuesto.Caption = "Indicador";
            this.colindicador_impuesto.FieldName = "indicador_impuesto";
            this.colindicador_impuesto.Name = "colindicador_impuesto";
            this.colindicador_impuesto.OptionsColumn.AllowEdit = false;
            this.colindicador_impuesto.OptionsColumn.ReadOnly = true;
            this.colindicador_impuesto.Visible = true;
            this.colindicador_impuesto.VisibleIndex = 4;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total Linea";
            this.coltotal.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowEdit = false;
            this.coltotal.OptionsColumn.ReadOnly = true;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 8;
            // 
            // colisv
            // 
            this.colisv.Caption = "Isv";
            this.colisv.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colisv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colisv.FieldName = "isv";
            this.colisv.Name = "colisv";
            this.colisv.OptionsColumn.AllowEdit = false;
            this.colisv.OptionsColumn.ReadOnly = true;
            this.colisv.Visible = true;
            this.colisv.VisibleIndex = 7;
            // 
            // colid_detalle_presupuesto
            // 
            this.colid_detalle_presupuesto.FieldName = "id_detalle_presupuesto";
            this.colid_detalle_presupuesto.Name = "colid_detalle_presupuesto";
            this.colid_detalle_presupuesto.OptionsColumn.AllowEdit = false;
            this.colid_detalle_presupuesto.OptionsColumn.ReadOnly = true;
            // 
            // colpresupuesto_descripcion
            // 
            this.colpresupuesto_descripcion.FieldName = "presupuesto_descripcion";
            this.colpresupuesto_descripcion.Name = "colpresupuesto_descripcion";
            this.colpresupuesto_descripcion.OptionsColumn.AllowEdit = false;
            this.colpresupuesto_descripcion.OptionsColumn.ReadOnly = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "ordenes_autorizadas";
            this.gridControl1.DataSource = this.dsPresupuesto1;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "FK_ordenes_autorizadas_oc_detalle_exonerada";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(4, 44);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1475, 471);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // dsPresupuesto1
            // 
            this.dsPresupuesto1.DataSetName = "dsPresupuesto";
            this.dsPresupuesto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_h,
            this.colCardCode,
            this.colCardName,
            this.colDocNum,
            this.colDocDate,
            this.colU_TipoOrden,
            this.colComments,
            this.colDocTotal,
            this.colsubido_sap,
            this.colestado_name,
            this.colid_estado,
            this.colcreadopor,
            this.colmoneda,
            this.colU_AquaExoneracion});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_h
            // 
            this.colid_h.FieldName = "id_h";
            this.colid_h.Name = "colid_h";
            this.colid_h.OptionsColumn.ReadOnly = true;
            // 
            // colCardCode
            // 
            this.colCardCode.FieldName = "CardCode";
            this.colCardCode.Name = "colCardCode";
            this.colCardCode.OptionsColumn.ReadOnly = true;
            this.colCardCode.Visible = true;
            this.colCardCode.VisibleIndex = 1;
            this.colCardCode.Width = 85;
            // 
            // colCardName
            // 
            this.colCardName.FieldName = "CardName";
            this.colCardName.Name = "colCardName";
            this.colCardName.OptionsColumn.ReadOnly = true;
            this.colCardName.Visible = true;
            this.colCardName.VisibleIndex = 2;
            this.colCardName.Width = 255;
            // 
            // colDocNum
            // 
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.ReadOnly = true;
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 0;
            this.colDocNum.Width = 63;
            // 
            // colDocDate
            // 
            this.colDocDate.FieldName = "DocDate";
            this.colDocDate.Name = "colDocDate";
            this.colDocDate.OptionsColumn.ReadOnly = true;
            this.colDocDate.Visible = true;
            this.colDocDate.VisibleIndex = 3;
            this.colDocDate.Width = 67;
            // 
            // colU_TipoOrden
            // 
            this.colU_TipoOrden.Caption = "Tipo Orden";
            this.colU_TipoOrden.FieldName = "U_TipoOrden";
            this.colU_TipoOrden.Name = "colU_TipoOrden";
            this.colU_TipoOrden.OptionsColumn.ReadOnly = true;
            this.colU_TipoOrden.Visible = true;
            this.colU_TipoOrden.VisibleIndex = 4;
            this.colU_TipoOrden.Width = 121;
            // 
            // colComments
            // 
            this.colComments.Caption = "Comentario";
            this.colComments.FieldName = "Comments";
            this.colComments.Name = "colComments";
            this.colComments.OptionsColumn.ReadOnly = true;
            this.colComments.Visible = true;
            this.colComments.VisibleIndex = 5;
            this.colComments.Width = 283;
            // 
            // colDocTotal
            // 
            this.colDocTotal.Caption = "Total OC";
            this.colDocTotal.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colDocTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDocTotal.FieldName = "DocTotal";
            this.colDocTotal.Name = "colDocTotal";
            this.colDocTotal.OptionsColumn.AllowEdit = false;
            this.colDocTotal.OptionsColumn.ReadOnly = true;
            this.colDocTotal.Visible = true;
            this.colDocTotal.VisibleIndex = 9;
            this.colDocTotal.Width = 69;
            // 
            // colsubido_sap
            // 
            this.colsubido_sap.Caption = "Subido";
            this.colsubido_sap.FieldName = "subido_sap";
            this.colsubido_sap.Name = "colsubido_sap";
            this.colsubido_sap.OptionsColumn.ReadOnly = true;
            // 
            // colestado_name
            // 
            this.colestado_name.Caption = "Estado OC";
            this.colestado_name.FieldName = "estado_name";
            this.colestado_name.Name = "colestado_name";
            this.colestado_name.OptionsColumn.ReadOnly = true;
            this.colestado_name.Visible = true;
            this.colestado_name.VisibleIndex = 6;
            this.colestado_name.Width = 110;
            // 
            // colid_estado
            // 
            this.colid_estado.FieldName = "id_estado";
            this.colid_estado.Name = "colid_estado";
            this.colid_estado.OptionsColumn.ReadOnly = true;
            // 
            // colcreadopor
            // 
            this.colcreadopor.FieldName = "creadopor";
            this.colcreadopor.Name = "colcreadopor";
            this.colcreadopor.OptionsColumn.ReadOnly = true;
            // 
            // colmoneda
            // 
            this.colmoneda.Caption = "Moneda";
            this.colmoneda.FieldName = "moneda";
            this.colmoneda.Name = "colmoneda";
            this.colmoneda.OptionsColumn.ReadOnly = true;
            this.colmoneda.Visible = true;
            this.colmoneda.VisibleIndex = 8;
            this.colmoneda.Width = 81;
            // 
            // colU_AquaExoneracion
            // 
            this.colU_AquaExoneracion.Caption = "Regist. Exonerado";
            this.colU_AquaExoneracion.FieldName = "U_AquaExoneracion";
            this.colU_AquaExoneracion.Name = "colU_AquaExoneracion";
            this.colU_AquaExoneracion.OptionsColumn.ReadOnly = true;
            this.colU_AquaExoneracion.Visible = true;
            this.colU_AquaExoneracion.VisibleIndex = 7;
            this.colU_AquaExoneracion.Width = 110;
            // 
            // dsCompras1
            // 
            this.dsCompras1.DataSetName = "dsCompras";
            this.dsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmDetalleOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 519);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmDetalleOC";
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsPresupuesto dsPresupuesto1;
        private Compras.dsCompras dsCompras1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colid_h;
        private DevExpress.XtraGrid.Columns.GridColumn colCardCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate;
        private DevExpress.XtraGrid.Columns.GridColumn colU_TipoOrden;
        private DevExpress.XtraGrid.Columns.GridColumn colComments;
        private DevExpress.XtraGrid.Columns.GridColumn colDocTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colsubido_sap;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_name;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colcreadopor;
        private DevExpress.XtraGrid.Columns.GridColumn colmoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colU_AquaExoneracion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_orden_h;
        private DevExpress.XtraGrid.Columns.GridColumn colcapitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colpartida_arancelaria;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_articulo;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio_por_unidad;
        private DevExpress.XtraGrid.Columns.GridColumn colindicador_impuesto;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colisv;
        private DevExpress.XtraGrid.Columns.GridColumn colid_detalle_presupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colpresupuesto_descripcion;
    }
}