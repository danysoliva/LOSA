
namespace LOSA.FromAMS
{
    partial class frmVerDetalleSolicitud
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grdSolicitado = new DevExpress.XtraGrid.GridControl();
            this.dsAprobacionDocumentos1 = new LOSA.FromAMS.dsAprobacionDocumentos();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_entregada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grdEntregado = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_me = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_detalle_req = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_entregada1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAprobacionDocumentos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntregado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.grdSolicitado);
            this.groupControl1.Location = new System.Drawing.Point(1, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1149, 301);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Solicitado en Requisa";
            // 
            // grdSolicitado
            // 
            this.grdSolicitado.DataMember = "req_detalle";
            this.grdSolicitado.DataSource = this.dsAprobacionDocumentos1;
            this.grdSolicitado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSolicitado.Location = new System.Drawing.Point(2, 23);
            this.grdSolicitado.MainView = this.gridView1;
            this.grdSolicitado.Name = "grdSolicitado";
            this.grdSolicitado.Size = new System.Drawing.Size(1145, 276);
            this.grdSolicitado.TabIndex = 0;
            this.grdSolicitado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsAprobacionDocumentos1
            // 
            this.dsAprobacionDocumentos1.DataSetName = "dsAprobacionDocumentos";
            this.dsAprobacionDocumentos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colitemcode,
            this.colitemname,
            this.colcantidad,
            this.colactivo,
            this.colexistencia,
            this.collote,
            this.colcantidad_entregada});
            this.gridView1.GridControl = this.grdSolicitado;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "ItemCode";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            // 
            // colitemname
            // 
            this.colitemname.Caption = "ItemName";
            this.colitemname.FieldName = "itemname";
            this.colitemname.Name = "colitemname";
            this.colitemname.Visible = true;
            this.colitemname.VisibleIndex = 1;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.DisplayFormat.FormatString = "n0";
            this.colcantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "SUM={0:0.##}")});
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 2;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.Name = "colactivo";
            // 
            // colexistencia
            // 
            this.colexistencia.FieldName = "existencia";
            this.colexistencia.Name = "colexistencia";
            // 
            // collote
            // 
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            // 
            // colcantidad_entregada
            // 
            this.colcantidad_entregada.FieldName = "cantidad_entregada";
            this.colcantidad_entregada.Name = "colcantidad_entregada";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.grdEntregado);
            this.groupControl2.Location = new System.Drawing.Point(1, 319);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1149, 304);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Entregado en AMS";
            // 
            // grdEntregado
            // 
            this.grdEntregado.DataMember = "detalle_entregado_requisa";
            this.grdEntregado.DataSource = this.dsAprobacionDocumentos1;
            this.grdEntregado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEntregado.Location = new System.Drawing.Point(2, 23);
            this.grdEntregado.MainView = this.gridView2;
            this.grdEntregado.Name = "grdEntregado";
            this.grdEntregado.Size = new System.Drawing.Size(1145, 279);
            this.grdEntregado.TabIndex = 1;
            this.grdEntregado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_me,
            this.colItemName1,
            this.collote1,
            this.colid_detalle_req,
            this.colcantidad_entregada1,
            this.colitemcode1,
            this.colfecha,
            this.colid_usuario,
            this.colusuario});
            this.gridView2.GridControl = this.grdEntregado;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colid_me
            // 
            this.colid_me.FieldName = "id_me";
            this.colid_me.Name = "colid_me";
            // 
            // colItemName1
            // 
            this.colItemName1.FieldName = "ItemName";
            this.colItemName1.Name = "colItemName1";
            this.colItemName1.Visible = true;
            this.colItemName1.VisibleIndex = 1;
            // 
            // collote1
            // 
            this.collote1.Caption = "Lote";
            this.collote1.FieldName = "lote";
            this.collote1.Name = "collote1";
            this.collote1.Visible = true;
            this.collote1.VisibleIndex = 4;
            // 
            // colid_detalle_req
            // 
            this.colid_detalle_req.FieldName = "id_detalle_req";
            this.colid_detalle_req.Name = "colid_detalle_req";
            // 
            // colcantidad_entregada1
            // 
            this.colcantidad_entregada1.Caption = "Cantidad Entregada";
            this.colcantidad_entregada1.DisplayFormat.FormatString = "N0";
            this.colcantidad_entregada1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad_entregada1.FieldName = "cantidad_entregada";
            this.colcantidad_entregada1.Name = "colcantidad_entregada1";
            this.colcantidad_entregada1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad_entregada", "SUM={0:0.##}")});
            this.colcantidad_entregada1.Visible = true;
            this.colcantidad_entregada1.VisibleIndex = 5;
            // 
            // colitemcode1
            // 
            this.colitemcode1.Caption = "ItemCode";
            this.colitemcode1.FieldName = "itemcode";
            this.colitemcode1.Name = "colitemcode1";
            this.colitemcode1.Visible = true;
            this.colitemcode1.VisibleIndex = 0;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 3;
            // 
            // colid_usuario
            // 
            this.colid_usuario.FieldName = "id_usuario";
            this.colid_usuario.Name = "colid_usuario";
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario";
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 2;
            // 
            // frmVerDetalleSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 632);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmVerDetalleSolicitud";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAprobacionDocumentos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEntregado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grdSolicitado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grdEntregado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private dsAprobacionDocumentos dsAprobacionDocumentos1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colitemname;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_entregada;
        private DevExpress.XtraGrid.Columns.GridColumn colid_me;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName1;
        private DevExpress.XtraGrid.Columns.GridColumn collote1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_detalle_req;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_entregada1;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
    }
}