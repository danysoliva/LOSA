
namespace LOSA.Liquidos
{
    partial class frmTarimasOFLiquidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTarimasOFLiquidos));
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.grd_tarimas = new DevExpress.XtraGrid.GridControl();
            this.tmliquidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLiquidos_ = new LOSA.Liquidos.dsLiquidos_();
            this.grdv_tarimas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigobarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmateriaprima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpesokg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colf_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigoodoo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colf_produccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigosap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grd_tarimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmliquidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLiquidos_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_tarimas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Appearance.Options.UseFont = true;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1005, 7);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(126, 51);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Volver";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grd_tarimas
            // 
            this.grd_tarimas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_tarimas.DataSource = this.tmliquidosBindingSource;
            this.grd_tarimas.Location = new System.Drawing.Point(2, 73);
            this.grd_tarimas.MainView = this.grdv_tarimas;
            this.grd_tarimas.Name = "grd_tarimas";
            this.grd_tarimas.Size = new System.Drawing.Size(1135, 503);
            this.grd_tarimas.TabIndex = 1;
            this.grd_tarimas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_tarimas});
            // 
            // tmliquidosBindingSource
            // 
            this.tmliquidosBindingSource.DataMember = "tm_liquidos";
            this.tmliquidosBindingSource.DataSource = this.dsLiquidos_;
            // 
            // dsLiquidos_
            // 
            this.dsLiquidos_.DataSetName = "dsLiquidos_";
            this.dsLiquidos_.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_tarimas
            // 
            this.grdv_tarimas.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_tarimas.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_tarimas.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_tarimas.Appearance.Empty.Options.UseFont = true;
            this.grdv_tarimas.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_tarimas.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_tarimas.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_tarimas.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_tarimas.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_tarimas.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_tarimas.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_tarimas.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_tarimas.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_tarimas.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_tarimas.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_tarimas.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_tarimas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_tarimas.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_tarimas.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_tarimas.Appearance.Preview.Options.UseFont = true;
            this.grdv_tarimas.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_tarimas.Appearance.Row.Options.UseFont = true;
            this.grdv_tarimas.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_tarimas.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_tarimas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigobarra,
            this.colmateriaprima,
            this.colpesokg,
            this.colunidades,
            this.colf_vencimiento,
            this.colcodigoodoo,
            this.colf_produccion,
            this.colcodigosap,
            this.colingreso,
            this.collote});
            this.grdv_tarimas.GridControl = this.grd_tarimas;
            this.grdv_tarimas.Name = "grdv_tarimas";
            this.grdv_tarimas.OptionsView.ShowAutoFilterRow = true;
            this.grdv_tarimas.OptionsView.ShowGroupPanel = false;
            // 
            // colcodigobarra
            // 
            this.colcodigobarra.Caption = "Barra";
            this.colcodigobarra.FieldName = "codigobarra";
            this.colcodigobarra.Name = "colcodigobarra";
            this.colcodigobarra.OptionsColumn.AllowEdit = false;
            this.colcodigobarra.Visible = true;
            this.colcodigobarra.VisibleIndex = 0;
            this.colcodigobarra.Width = 204;
            // 
            // colmateriaprima
            // 
            this.colmateriaprima.Caption = "MP";
            this.colmateriaprima.FieldName = "materiaprima";
            this.colmateriaprima.Name = "colmateriaprima";
            this.colmateriaprima.OptionsColumn.AllowEdit = false;
            this.colmateriaprima.Visible = true;
            this.colmateriaprima.VisibleIndex = 3;
            this.colmateriaprima.Width = 244;
            // 
            // colpesokg
            // 
            this.colpesokg.Caption = "Peso";
            this.colpesokg.FieldName = "pesokg";
            this.colpesokg.Name = "colpesokg";
            this.colpesokg.OptionsColumn.AllowEdit = false;
            this.colpesokg.Visible = true;
            this.colpesokg.VisibleIndex = 4;
            this.colpesokg.Width = 74;
            // 
            // colunidades
            // 
            this.colunidades.Caption = "Unidades";
            this.colunidades.FieldName = "unidades";
            this.colunidades.Name = "colunidades";
            this.colunidades.OptionsColumn.AllowEdit = false;
            this.colunidades.Visible = true;
            this.colunidades.VisibleIndex = 5;
            this.colunidades.Width = 92;
            // 
            // colf_vencimiento
            // 
            this.colf_vencimiento.Caption = "F. Vencimiento";
            this.colf_vencimiento.FieldName = "f_vencimiento";
            this.colf_vencimiento.Name = "colf_vencimiento";
            this.colf_vencimiento.OptionsColumn.AllowEdit = false;
            this.colf_vencimiento.Visible = true;
            this.colf_vencimiento.VisibleIndex = 6;
            this.colf_vencimiento.Width = 140;
            // 
            // colcodigoodoo
            // 
            this.colcodigoodoo.Caption = "Cod. Produccion";
            this.colcodigoodoo.FieldName = "codigoodoo";
            this.colcodigoodoo.Name = "colcodigoodoo";
            this.colcodigoodoo.OptionsColumn.AllowEdit = false;
            this.colcodigoodoo.Width = 105;
            // 
            // colf_produccion
            // 
            this.colf_produccion.Caption = "F. produccion";
            this.colf_produccion.FieldName = "f_produccion";
            this.colf_produccion.Name = "colf_produccion";
            this.colf_produccion.OptionsColumn.AllowEdit = false;
            this.colf_produccion.Visible = true;
            this.colf_produccion.VisibleIndex = 7;
            this.colf_produccion.Width = 126;
            // 
            // colcodigosap
            // 
            this.colcodigosap.Caption = "Cod. SAP";
            this.colcodigosap.FieldName = "codigosap";
            this.colcodigosap.Name = "colcodigosap";
            this.colcodigosap.OptionsColumn.AllowEdit = false;
            this.colcodigosap.Visible = true;
            this.colcodigosap.VisibleIndex = 2;
            this.colcodigosap.Width = 117;
            // 
            // colingreso
            // 
            this.colingreso.Caption = "Ingreso";
            this.colingreso.FieldName = "ingreso";
            this.colingreso.Name = "colingreso";
            this.colingreso.OptionsColumn.AllowEdit = false;
            this.colingreso.Visible = true;
            this.colingreso.VisibleIndex = 1;
            this.colingreso.Width = 120;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(513, 20);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Lista de tarimas que estan disponibles para poder ser ingresadas a un tanque:";
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 8;
            // 
            // frmTarimasOFLiquidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 578);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grd_tarimas);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmTarimasOFLiquidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarimas en bines";
            this.Load += new System.EventHandler(this.frmTarimasOFLiquidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_tarimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmliquidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLiquidos_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_tarimas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraGrid.GridControl grd_tarimas;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_tarimas;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource tmliquidosBindingSource;
        private dsLiquidos_ dsLiquidos_;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigobarra;
        private DevExpress.XtraGrid.Columns.GridColumn colmateriaprima;
        private DevExpress.XtraGrid.Columns.GridColumn colpesokg;
        private DevExpress.XtraGrid.Columns.GridColumn colunidades;
        private DevExpress.XtraGrid.Columns.GridColumn colf_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colf_produccion;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigoodoo;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigosap;
        private DevExpress.XtraGrid.Columns.GridColumn colingreso;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
    }
}