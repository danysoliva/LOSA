
namespace LOSA.RecuentoInventario
{
    partial class frmAddLote
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
            this.grdLote = new DevExpress.XtraGrid.GridControl();
            this.dsCierreMes1 = new LOSA.Logistica.dsCierreMes();
            this.grdvLote = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_unidadmedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCierreMes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvLote)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLote
            // 
            this.grdLote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdLote.DataMember = "lotes_recuento";
            this.grdLote.DataSource = this.dsCierreMes1;
            this.grdLote.Location = new System.Drawing.Point(2, 48);
            this.grdLote.MainView = this.grdvLote;
            this.grdLote.Name = "grdLote";
            this.grdLote.Size = new System.Drawing.Size(527, 267);
            this.grdLote.TabIndex = 0;
            this.grdLote.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvLote});
            // 
            // dsCierreMes1
            // 
            this.dsCierreMes1.DataSetName = "dsCierreMes";
            this.dsCierreMes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdvLote
            // 
            this.grdvLote.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collote,
            this.colid_unidadmedida,
            this.colpresentacion,
            this.colid_mp,
            this.colfecha_vencimiento});
            this.grdvLote.GridControl = this.grdLote;
            this.grdvLote.Name = "grdvLote";
            this.grdvLote.OptionsView.ShowGroupPanel = false;
            this.grdvLote.DoubleClick += new System.EventHandler(this.grdvLote_DoubleClick);
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 0;
            // 
            // colid_unidadmedida
            // 
            this.colid_unidadmedida.FieldName = "id_unidadmedida";
            this.colid_unidadmedida.Name = "colid_unidadmedida";
            this.colid_unidadmedida.OptionsColumn.AllowEdit = false;
            // 
            // colpresentacion
            // 
            this.colpresentacion.Caption = "Presentacion";
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.OptionsColumn.AllowEdit = false;
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 1;
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.Name = "colid_mp";
            this.colid_mp.OptionsColumn.AllowEdit = false;
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.Caption = "Fecha Vencimiento";
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.OptionsColumn.AllowEdit = false;
            this.colfecha_vencimiento.Visible = true;
            this.colfecha_vencimiento.VisibleIndex = 2;
            // 
            // frmAddLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 317);
            this.Controls.Add(this.grdLote);
            this.Name = "frmAddLote";
            this.Text = "Seleccione el Lote";
            ((System.ComponentModel.ISupportInitialize)(this.grdLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCierreMes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvLote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdLote;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvLote;
        private Logistica.dsCierreMes dsCierreMes1;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colid_unidadmedida;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
    }
}