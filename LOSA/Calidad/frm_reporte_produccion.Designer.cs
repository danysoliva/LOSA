
namespace LOSA.Calidad
{
    partial class frm_reporte_produccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reporte_produccion));
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.productoptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCalidad = new LOSA.Calidad.dsCalidad();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsap_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkg_produccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_create = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_tm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colud_esperadas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidades_recibidas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm_impresas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(427, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(199, 80);
            this.cmdHome.TabIndex = 7;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataSource = this.productoptBindingSource;
            this.grd_data.Location = new System.Drawing.Point(1, 121);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(636, 438);
            this.grd_data.TabIndex = 8;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // productoptBindingSource
            // 
            this.productoptBindingSource.DataMember = "producto_pt";
            this.productoptBindingSource.DataSource = this.dsCalidad;
            // 
            // dsCalidad
            // 
            this.dsCalidad.DataSetName = "dsCalidad";
            this.dsCalidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colsap_code,
            this.colkg_produccion,
            this.collote_pt,
            this.coldate_create,
            this.colcant_tm,
            this.colTm,
            this.colud_esperadas,
            this.colproducto,
            this.colunidades_recibidas,
            this.coltm_impresas,
            this.colDiferencia});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colsap_code
            // 
            this.colsap_code.FieldName = "sap_code";
            this.colsap_code.Name = "colsap_code";
            this.colsap_code.OptionsColumn.AllowEdit = false;
            // 
            // colkg_produccion
            // 
            this.colkg_produccion.Caption = "Kg Planificado";
            this.colkg_produccion.FieldName = "kg_produccion";
            this.colkg_produccion.Name = "colkg_produccion";
            this.colkg_produccion.OptionsColumn.AllowEdit = false;
            this.colkg_produccion.Visible = true;
            this.colkg_produccion.VisibleIndex = 3;
            // 
            // collote_pt
            // 
            this.collote_pt.Caption = "Lote";
            this.collote_pt.FieldName = "lote_pt";
            this.collote_pt.Name = "collote_pt";
            this.collote_pt.OptionsColumn.AllowEdit = false;
            this.collote_pt.Visible = true;
            this.collote_pt.VisibleIndex = 1;
            // 
            // coldate_create
            // 
            this.coldate_create.Caption = "F. Planificacion";
            this.coldate_create.FieldName = "date_create";
            this.coldate_create.Name = "coldate_create";
            this.coldate_create.OptionsColumn.AllowEdit = false;
            this.coldate_create.Visible = true;
            this.coldate_create.VisibleIndex = 2;
            // 
            // colcant_tm
            // 
            this.colcant_tm.Caption = "Tarimas Planificadas";
            this.colcant_tm.FieldName = "cant_tm";
            this.colcant_tm.Name = "colcant_tm";
            this.colcant_tm.OptionsColumn.AllowEdit = false;
            this.colcant_tm.Visible = true;
            this.colcant_tm.VisibleIndex = 4;
            // 
            // colTm
            // 
            this.colTm.Caption = "Tarimas Activadas";
            this.colTm.FieldName = "Tm";
            this.colTm.Name = "colTm";
            this.colTm.OptionsColumn.AllowEdit = false;
            this.colTm.Visible = true;
            this.colTm.VisibleIndex = 5;
            // 
            // colud_esperadas
            // 
            this.colud_esperadas.Caption = "Ud. Planificadas";
            this.colud_esperadas.FieldName = "ud_esperadas";
            this.colud_esperadas.Name = "colud_esperadas";
            this.colud_esperadas.OptionsColumn.AllowEdit = false;
            this.colud_esperadas.Visible = true;
            this.colud_esperadas.VisibleIndex = 6;
            // 
            // colproducto
            // 
            this.colproducto.Caption = "Producto";
            this.colproducto.FieldName = "producto";
            this.colproducto.Name = "colproducto";
            this.colproducto.OptionsColumn.AllowEdit = false;
            this.colproducto.Visible = true;
            this.colproducto.VisibleIndex = 0;
            // 
            // colunidades_recibidas
            // 
            this.colunidades_recibidas.Caption = "Ud. Activadas";
            this.colunidades_recibidas.FieldName = "unidades_recibidas";
            this.colunidades_recibidas.Name = "colunidades_recibidas";
            this.colunidades_recibidas.OptionsColumn.AllowEdit = false;
            this.colunidades_recibidas.Visible = true;
            this.colunidades_recibidas.VisibleIndex = 7;
            // 
            // coltm_impresas
            // 
            this.coltm_impresas.Caption = "Ud. Generadas";
            this.coltm_impresas.FieldName = "tm_impresas";
            this.coltm_impresas.Name = "coltm_impresas";
            this.coltm_impresas.OptionsColumn.AllowEdit = false;
            this.coltm_impresas.Visible = true;
            this.coltm_impresas.VisibleIndex = 8;
            // 
            // colDiferencia
            // 
            this.colDiferencia.Caption = "Pendientes de Activar";
            this.colDiferencia.FieldName = "colDiferencia";
            this.colDiferencia.Name = "colDiferencia";
            this.colDiferencia.OptionsColumn.AllowEdit = false;
            this.colDiferencia.UnboundExpression = "[tm_impresas] - [unidades_recibidas]";
            this.colDiferencia.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colDiferencia.Visible = true;
            this.colDiferencia.VisibleIndex = 9;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(199, 37);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Exportar Excel ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(12, 55);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(199, 37);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "Actualizar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frm_reporte_produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.cmdHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_reporte_produccion";
            this.Text = "frm_reporte_produccion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_reporte_produccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private System.Windows.Forms.BindingSource productoptBindingSource;
        private dsCalidad dsCalidad;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colsap_code;
        private DevExpress.XtraGrid.Columns.GridColumn colkg_produccion;
        private DevExpress.XtraGrid.Columns.GridColumn collote_pt;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_create;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_tm;
        private DevExpress.XtraGrid.Columns.GridColumn colTm;
        private DevExpress.XtraGrid.Columns.GridColumn colud_esperadas;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto;
        private DevExpress.XtraGrid.Columns.GridColumn colunidades_recibidas;
        private DevExpress.XtraGrid.Columns.GridColumn coltm_impresas;
        private DevExpress.XtraGrid.Columns.GridColumn colDiferencia;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}