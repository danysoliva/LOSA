
namespace LOSA.TransaccionesPT
{
    partial class frmRevisionDeActivaciondeTm
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
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.loadtmlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPT = new LOSA.TransaccionesPT.dsPT();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigobarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldateprod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colturno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colloteagrupador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colf_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadtmlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT)).BeginInit();
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
            this.cmdHome.Location = new System.Drawing.Point(437, 3);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(199, 71);
            this.cmdHome.TabIndex = 8;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataSource = this.loadtmlBindingSource;
            this.grd_data.Location = new System.Drawing.Point(-1, 106);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(637, 453);
            this.grd_data.TabIndex = 9;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // loadtmlBindingSource
            // 
            this.loadtmlBindingSource.DataMember = "loadtml";
            this.loadtmlBindingSource.DataSource = this.dsPT;
            // 
            // dsPT
            // 
            this.dsPT.DataSetName = "dsPT";
            this.dsPT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcodigobarra,
            this.collote,
            this.coldateprod,
            this.colturno,
            this.colproducto,
            this.colcodigop,
            this.colloteagrupador,
            this.colf_vencimiento,
            this.colcantidad,
            this.colpeso});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.GroupCount = 1;
            this.grdv_data.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", null, "")});
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_data.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowFooter = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colloteagrupador, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colcodigobarra
            // 
            this.colcodigobarra.Caption = "Codigo";
            this.colcodigobarra.FieldName = "codigobarra";
            this.colcodigobarra.Name = "colcodigobarra";
            this.colcodigobarra.OptionsColumn.AllowEdit = false;
            this.colcodigobarra.Visible = true;
            this.colcodigobarra.VisibleIndex = 0;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 1;
            // 
            // coldateprod
            // 
            this.coldateprod.Caption = "F. Produccion";
            this.coldateprod.FieldName = "dateprod";
            this.coldateprod.Name = "coldateprod";
            this.coldateprod.OptionsColumn.AllowEdit = false;
            this.coldateprod.Visible = true;
            this.coldateprod.VisibleIndex = 2;
            // 
            // colturno
            // 
            this.colturno.Caption = "Turno";
            this.colturno.FieldName = "turno";
            this.colturno.Name = "colturno";
            this.colturno.OptionsColumn.AllowEdit = false;
            this.colturno.Visible = true;
            this.colturno.VisibleIndex = 3;
            // 
            // colproducto
            // 
            this.colproducto.Caption = "Producto";
            this.colproducto.FieldName = "producto";
            this.colproducto.Name = "colproducto";
            this.colproducto.OptionsColumn.AllowEdit = false;
            this.colproducto.Visible = true;
            this.colproducto.VisibleIndex = 4;
            // 
            // colcodigop
            // 
            this.colcodigop.Caption = "C. Producto";
            this.colcodigop.FieldName = "codigop";
            this.colcodigop.Name = "colcodigop";
            this.colcodigop.OptionsColumn.AllowEdit = false;
            this.colcodigop.Visible = true;
            this.colcodigop.VisibleIndex = 5;
            // 
            // colloteagrupador
            // 
            this.colloteagrupador.Caption = "Lote";
            this.colloteagrupador.FieldName = "loteagrupador";
            this.colloteagrupador.Name = "colloteagrupador";
            this.colloteagrupador.OptionsColumn.AllowEdit = false;
            this.colloteagrupador.Visible = true;
            this.colloteagrupador.VisibleIndex = 6;
            // 
            // colf_vencimiento
            // 
            this.colf_vencimiento.Caption = "F. Vencimiento";
            this.colf_vencimiento.FieldName = "f_vencimiento";
            this.colf_vencimiento.Name = "colf_vencimiento";
            this.colf_vencimiento.OptionsColumn.AllowEdit = false;
            this.colf_vencimiento.Visible = true;
            this.colf_vencimiento.VisibleIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(12, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(372, 39);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Tarimas Activadas";
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Unidades";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "SUM={0:0.##}")});
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 7;
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Peso Kg.";
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.OptionsColumn.AllowEdit = false;
            this.colpeso.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "peso", "SUM={0:0.##}")});
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 8;
            // 
            // frmRevisionDeActivaciondeTm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.cmdHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRevisionDeActivaciondeTm";
            this.Text = "frmRevisionDeActivaciondeTm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadtmlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource loadtmlBindingSource;
        private dsPT dsPT;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigobarra;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn coldateprod;
        private DevExpress.XtraGrid.Columns.GridColumn colturno;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigop;
        private DevExpress.XtraGrid.Columns.GridColumn colloteagrupador;
        private DevExpress.XtraGrid.Columns.GridColumn colf_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
    }
}