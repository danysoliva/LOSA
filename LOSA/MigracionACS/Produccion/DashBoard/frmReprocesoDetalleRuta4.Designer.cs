
namespace LOSA.MigracionACS.Produccion.DashBoard
{
    partial class frmReprocesoDetalleRuta4
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidturno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfml_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfml_version = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorder_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorder_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_sacos_prd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dsDashBoard1 = new LOSA.MigracionACS.Produccion.DashBoard.dsDashBoard();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDashBoard1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_reproceso_lote";
            this.gridControl1.DataSource = this.dsDashBoard1;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1015, 558);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfecha,
            this.colcodigo,
            this.coldescripcion,
            this.colidturno,
            this.colfml_code,
            this.colfml_version,
            this.collote,
            this.colorder_number,
            this.colorder_code,
            this.colcantidad_sacos_prd,
            this.colpresentacion,
            this.coltm,
            this.colid_linea,
            this.colLinea,
            this.colHoras,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.DisplayFormat.FormatString = "d";
            this.colfecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 0;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Código";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 1;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 2;
            // 
            // colidturno
            // 
            this.colidturno.Caption = "Turno";
            this.colidturno.FieldName = "idturno";
            this.colidturno.Name = "colidturno";
            this.colidturno.Visible = true;
            this.colidturno.VisibleIndex = 3;
            // 
            // colfml_code
            // 
            this.colfml_code.Caption = "Formula";
            this.colfml_code.FieldName = "fml_code";
            this.colfml_code.Name = "colfml_code";
            this.colfml_code.Visible = true;
            this.colfml_code.VisibleIndex = 4;
            // 
            // colfml_version
            // 
            this.colfml_version.Caption = "Versión";
            this.colfml_version.FieldName = "fml_version";
            this.colfml_version.Name = "colfml_version";
            this.colfml_version.Visible = true;
            this.colfml_version.VisibleIndex = 5;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.Visible = true;
            this.collote.VisibleIndex = 6;
            // 
            // colorder_number
            // 
            this.colorder_number.Caption = "# Orden Prd.";
            this.colorder_number.FieldName = "order_number";
            this.colorder_number.Name = "colorder_number";
            this.colorder_number.Visible = true;
            this.colorder_number.VisibleIndex = 7;
            // 
            // colorder_code
            // 
            this.colorder_code.Caption = "Codigo Orden Prd";
            this.colorder_code.FieldName = "order_code";
            this.colorder_code.Name = "colorder_code";
            this.colorder_code.Visible = true;
            this.colorder_code.VisibleIndex = 8;
            // 
            // colcantidad_sacos_prd
            // 
            this.colcantidad_sacos_prd.Caption = "Cant. Sacos";
            this.colcantidad_sacos_prd.DisplayFormat.FormatString = "###,##0";
            this.colcantidad_sacos_prd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad_sacos_prd.FieldName = "cantidad_sacos_prd";
            this.colcantidad_sacos_prd.Name = "colcantidad_sacos_prd";
            this.colcantidad_sacos_prd.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad_sacos_prd", "Sacos Total={0:###,##0}")});
            this.colcantidad_sacos_prd.Visible = true;
            this.colcantidad_sacos_prd.VisibleIndex = 9;
            // 
            // colpresentacion
            // 
            this.colpresentacion.Caption = "Presentación";
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 10;
            // 
            // coltm
            // 
            this.coltm.Caption = "TM";
            this.coltm.DisplayFormat.FormatString = "###,##0.00";
            this.coltm.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltm.FieldName = "tm";
            this.coltm.Name = "coltm";
            this.coltm.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tm", "Total TM={0:###,##0.00}")});
            this.coltm.Visible = true;
            this.coltm.VisibleIndex = 11;
            // 
            // colid_linea
            // 
            this.colid_linea.FieldName = "id_linea";
            this.colid_linea.Name = "colid_linea";
            // 
            // colLinea
            // 
            this.colLinea.FieldName = "Linea";
            this.colLinea.Name = "colLinea";
            this.colLinea.OptionsColumn.ReadOnly = true;
            this.colLinea.Visible = true;
            this.colLinea.VisibleIndex = 12;
            // 
            // colHoras
            // 
            this.colHoras.DisplayFormat.FormatString = "n2";
            this.colHoras.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHoras.FieldName = "Horas";
            this.colHoras.Name = "colHoras";
            this.colHoras.OptionsColumn.ReadOnly = true;
            this.colHoras.Visible = true;
            this.colHoras.VisibleIndex = 13;
            // 
            // gridColumn1
            // 
            this.gridColumn1.DisplayFormat.FormatString = "n2";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "TM/h";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 14;
            // 
            // dsDashBoard1
            // 
            this.dsDashBoard1.DataSetName = "dsDashBoard";
            this.dsDashBoard1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmReprocesoDetalleRuta4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 561);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmReprocesoDetalleRuta4";
            this.Text = "Reproceso Detalle";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDashBoard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colidturno;
        private DevExpress.XtraGrid.Columns.GridColumn colfml_code;
        private DevExpress.XtraGrid.Columns.GridColumn colfml_version;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colorder_number;
        private DevExpress.XtraGrid.Columns.GridColumn colorder_code;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_sacos_prd;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn coltm;
        private DevExpress.XtraGrid.Columns.GridColumn colid_linea;
        private DevExpress.XtraGrid.Columns.GridColumn colLinea;
        private DevExpress.XtraGrid.Columns.GridColumn colHoras;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private dsDashBoard dsDashBoard1;
    }
}