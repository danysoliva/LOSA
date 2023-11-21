
namespace LOSA.TransaccionesMP.EntregaMP
{
    partial class frmShowTarimasEnBascula
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
            this.gridDetalle = new DevExpress.XtraGrid.GridControl();
            this.dsTransaccionesMP1 = new LOSA.TransaccionesMP.dsTransaccionesMP();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tarima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_montacarga = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_prd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbascula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDetalle
            // 
            this.gridDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetalle.DataMember = "tarimas_bascula";
            this.gridDetalle.DataSource = this.dsTransaccionesMP1;
            this.gridDetalle.Location = new System.Drawing.Point(3, 2);
            this.gridDetalle.MainView = this.gridView1;
            this.gridDetalle.Name = "gridDetalle";
            this.gridDetalle.Size = new System.Drawing.Size(965, 381);
            this.gridDetalle.TabIndex = 0;
            this.gridDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsTransaccionesMP1
            // 
            this.dsTransaccionesMP1.DataSetName = "dsTransaccionesMP";
            this.dsTransaccionesMP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.gridColumn1,
            this.colid_tarima,
            this.colmp,
            this.colfecha_ingreso,
            this.colusuario_montacarga,
            this.colunidades,
            this.colpeso,
            this.collote,
            this.colpeso_prd,
            this.colestado,
            this.colbascula,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridDetalle;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "# Requisa";
            this.gridColumn1.FieldName = "#requisa";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 68;
            // 
            // colid_tarima
            // 
            this.colid_tarima.FieldName = "id_tarima";
            this.colid_tarima.Name = "colid_tarima";
            this.colid_tarima.OptionsColumn.AllowEdit = false;
            // 
            // colmp
            // 
            this.colmp.Caption = "Materia Prima";
            this.colmp.FieldName = "mp";
            this.colmp.Name = "colmp";
            this.colmp.OptionsColumn.AllowEdit = false;
            this.colmp.Visible = true;
            this.colmp.VisibleIndex = 1;
            this.colmp.Width = 139;
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.Caption = "Fecha Ingreso";
            this.colfecha_ingreso.DisplayFormat.FormatString = "g";
            this.colfecha_ingreso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.OptionsColumn.AllowEdit = false;
            this.colfecha_ingreso.Visible = true;
            this.colfecha_ingreso.VisibleIndex = 2;
            this.colfecha_ingreso.Width = 114;
            // 
            // colusuario_montacarga
            // 
            this.colusuario_montacarga.Caption = "Usuario";
            this.colusuario_montacarga.FieldName = "usuario_montacarga";
            this.colusuario_montacarga.Name = "colusuario_montacarga";
            this.colusuario_montacarga.OptionsColumn.AllowEdit = false;
            this.colusuario_montacarga.Visible = true;
            this.colusuario_montacarga.VisibleIndex = 4;
            this.colusuario_montacarga.Width = 96;
            // 
            // colunidades
            // 
            this.colunidades.Caption = "Unidad";
            this.colunidades.FieldName = "unidades";
            this.colunidades.Name = "colunidades";
            this.colunidades.OptionsColumn.AllowEdit = false;
            this.colunidades.Visible = true;
            this.colunidades.VisibleIndex = 7;
            this.colunidades.Width = 96;
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Peso";
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.OptionsColumn.AllowEdit = false;
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 8;
            this.colpeso.Width = 96;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 5;
            this.collote.Width = 102;
            // 
            // colpeso_prd
            // 
            this.colpeso_prd.Caption = "Peso Bascula";
            this.colpeso_prd.FieldName = "peso_prd";
            this.colpeso_prd.Name = "colpeso_prd";
            this.colpeso_prd.OptionsColumn.AllowEdit = false;
            this.colpeso_prd.Width = 110;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            // 
            // colbascula
            // 
            this.colbascula.Caption = "Bascula";
            this.colbascula.FieldName = "bascula";
            this.colbascula.Name = "colbascula";
            this.colbascula.OptionsColumn.AllowEdit = false;
            this.colbascula.Visible = true;
            this.colbascula.VisibleIndex = 6;
            this.colbascula.Width = 96;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cod Barra";
            this.gridColumn2.FieldName = "codigo_barra";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 87;
            // 
            // frmShowTarimasEnBascula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 385);
            this.Controls.Add(this.gridDetalle);
            this.Name = "frmShowTarimasEnBascula";
            this.Text = "Tarimas En Proceso de Pesaje de Bascula";
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsTransaccionesMP dsTransaccionesMP1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tarima;
        private DevExpress.XtraGrid.Columns.GridColumn colmp;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_montacarga;
        private DevExpress.XtraGrid.Columns.GridColumn colunidades;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_prd;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colbascula;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}