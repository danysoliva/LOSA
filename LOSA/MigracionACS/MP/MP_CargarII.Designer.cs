namespace ACS.MP
{
    partial class MP_CargarII
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MP_CargarII));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdAnularLineasInv = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnBajarPlantilla = new DevExpress.XtraEditors.SimpleButton();
            this.btnCargar = new DevExpress.XtraEditors.SimpleButton();
            this.grdDetalle = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColValorUsd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColValorHNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdConsumo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdInv_fisico_kgs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdPlantilla = new DevExpress.XtraGrid.GridControl();
            this.grdPlantillaView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnBajarXPeriodo = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_Period = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlantilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlantillaView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Period.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barCheckItem1});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(719, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 474);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(719, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 474);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(719, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 474);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 1;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdAnularLineasInv);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnBajarPlantilla);
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 59);
            this.panel1.TabIndex = 4;
            // 
            // cmdAnularLineasInv
            // 
            this.cmdAnularLineasInv.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAnularLineasInv.ImageOptions.SvgImage")));
            this.cmdAnularLineasInv.Location = new System.Drawing.Point(257, 3);
            this.cmdAnularLineasInv.Name = "cmdAnularLineasInv";
            this.cmdAnularLineasInv.Size = new System.Drawing.Size(121, 53);
            this.cmdAnularLineasInv.TabIndex = 3;
            this.cmdAnularLineasInv.Text = "Anular Lineas \r\nde Inventario";
            this.cmdAnularLineasInv.Click += new System.EventHandler(this.cmdAnularLineasInv_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_32x32;
            this.btnCancelar.Location = new System.Drawing.Point(384, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 53);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnBajarPlantilla
            // 
            this.btnBajarPlantilla.ImageOptions.Image = global::LOSA.Properties.Resources.detail_32x32;
            this.btnBajarPlantilla.Location = new System.Drawing.Point(130, 3);
            this.btnBajarPlantilla.Name = "btnBajarPlantilla";
            this.btnBajarPlantilla.Size = new System.Drawing.Size(121, 53);
            this.btnBajarPlantilla.TabIndex = 1;
            this.btnBajarPlantilla.Text = "Plantilla";
            this.btnBajarPlantilla.Click += new System.EventHandler(this.btnBajarPlantilla_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.ImageOptions.Image = global::LOSA.Properties.Resources.Upload_32x32;
            this.btnCargar.Location = new System.Drawing.Point(3, 3);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(121, 53);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.ToolTip = "Cargar datos en Kilogramos.";
            this.btnCargar.Click += new System.EventHandler(this.btnCargarII_Click);
            // 
            // grdDetalle
            // 
            this.grdDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDetalle.Location = new System.Drawing.Point(0, 89);
            this.grdDetalle.MainView = this.gridView1;
            this.grdDetalle.MenuManager = this.barManager1;
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.Size = new System.Drawing.Size(719, 385);
            this.grdDetalle.TabIndex = 10;
            this.grdDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColCodigo,
            this.grdColMaterial,
            this.grdColCantidad,
            this.grdColValorUsd,
            this.grdColValorHNL,
            this.grdConsumo,
            this.grdInv_fisico_kgs});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(564, 453, 210, 172);
            this.gridView1.GridControl = this.grdDetalle;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // grdColCodigo
            // 
            this.grdColCodigo.Caption = "Codigo";
            this.grdColCodigo.FieldName = "codigo";
            this.grdColCodigo.Name = "grdColCodigo";
            this.grdColCodigo.OptionsColumn.AllowEdit = false;
            this.grdColCodigo.OptionsColumn.AllowFocus = false;
            this.grdColCodigo.OptionsColumn.FixedWidth = true;
            this.grdColCodigo.OptionsColumn.ReadOnly = true;
            this.grdColCodigo.Visible = true;
            this.grdColCodigo.VisibleIndex = 0;
            this.grdColCodigo.Width = 100;
            // 
            // grdColMaterial
            // 
            this.grdColMaterial.Caption = "Material";
            this.grdColMaterial.FieldName = "material";
            this.grdColMaterial.Name = "grdColMaterial";
            this.grdColMaterial.OptionsColumn.AllowEdit = false;
            this.grdColMaterial.OptionsColumn.ReadOnly = true;
            this.grdColMaterial.Visible = true;
            this.grdColMaterial.VisibleIndex = 1;
            this.grdColMaterial.Width = 250;
            // 
            // grdColCantidad
            // 
            this.grdColCantidad.Caption = "Cantidad";
            this.grdColCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.grdColCantidad.FieldName = "quantity";
            this.grdColCantidad.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.grdColCantidad.Name = "grdColCantidad";
            this.grdColCantidad.OptionsColumn.AllowEdit = false;
            this.grdColCantidad.OptionsColumn.ReadOnly = true;
            this.grdColCantidad.Visible = true;
            this.grdColCantidad.VisibleIndex = 2;
            this.grdColCantidad.Width = 60;
            // 
            // grdColValorUsd
            // 
            this.grdColValorUsd.Caption = "Valor_USD";
            this.grdColValorUsd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.grdColValorUsd.FieldName = "value_usd";
            this.grdColValorUsd.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.grdColValorUsd.Name = "grdColValorUsd";
            this.grdColValorUsd.OptionsColumn.AllowEdit = false;
            this.grdColValorUsd.OptionsColumn.ReadOnly = true;
            this.grdColValorUsd.Visible = true;
            this.grdColValorUsd.VisibleIndex = 3;
            this.grdColValorUsd.Width = 140;
            // 
            // grdColValorHNL
            // 
            this.grdColValorHNL.Caption = "Valor_HNL";
            this.grdColValorHNL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.grdColValorHNL.FieldName = "value_hnl";
            this.grdColValorHNL.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.grdColValorHNL.Name = "grdColValorHNL";
            this.grdColValorHNL.OptionsColumn.AllowEdit = false;
            this.grdColValorHNL.OptionsColumn.ReadOnly = true;
            this.grdColValorHNL.Visible = true;
            this.grdColValorHNL.VisibleIndex = 4;
            this.grdColValorHNL.Width = 152;
            // 
            // grdConsumo
            // 
            this.grdConsumo.Caption = "Consumo Kgs";
            this.grdConsumo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.grdConsumo.FieldName = "consumo_kgs";
            this.grdConsumo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.grdConsumo.Name = "grdConsumo";
            this.grdConsumo.OptionsColumn.AllowEdit = false;
            this.grdConsumo.Visible = true;
            this.grdConsumo.VisibleIndex = 5;
            // 
            // grdInv_fisico_kgs
            // 
            this.grdInv_fisico_kgs.Caption = "Inv_Fisico Kgs";
            this.grdInv_fisico_kgs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.grdInv_fisico_kgs.FieldName = "inv_fisico_kgs";
            this.grdInv_fisico_kgs.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.grdInv_fisico_kgs.Name = "grdInv_fisico_kgs";
            this.grdInv_fisico_kgs.OptionsColumn.AllowEdit = false;
            this.grdInv_fisico_kgs.Visible = true;
            this.grdInv_fisico_kgs.VisibleIndex = 6;
            // 
            // grdPlantilla
            // 
            this.grdPlantilla.Location = new System.Drawing.Point(38, 211);
            this.grdPlantilla.MainView = this.grdPlantillaView;
            this.grdPlantilla.MenuManager = this.barManager1;
            this.grdPlantilla.Name = "grdPlantilla";
            this.grdPlantilla.Size = new System.Drawing.Size(325, 189);
            this.grdPlantilla.TabIndex = 15;
            this.grdPlantilla.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdPlantillaView});
            this.grdPlantilla.Visible = false;
            // 
            // grdPlantillaView
            // 
            this.grdPlantillaView.GridControl = this.grdPlantilla;
            this.grdPlantillaView.Name = "grdPlantillaView";
            // 
            // btnBajarXPeriodo
            // 
            this.btnBajarXPeriodo.ImageOptions.Image = global::LOSA.Properties.Resources.excel_24x24;
            this.btnBajarXPeriodo.Location = new System.Drawing.Point(274, 4);
            this.btnBajarXPeriodo.Name = "btnBajarXPeriodo";
            this.btnBajarXPeriodo.Size = new System.Drawing.Size(89, 23);
            this.btnBajarXPeriodo.TabIndex = 4;
            this.btnBajarXPeriodo.Text = "Bajar ";
            this.btnBajarXPeriodo.Click += new System.EventHandler(this.btnBajarXPeriodo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelControl7);
            this.panel2.Controls.Add(this.cmb_Period);
            this.panel2.Controls.Add(this.btnBajarXPeriodo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 415);
            this.panel2.TabIndex = 9;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(6, 9);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 13);
            this.labelControl7.TabIndex = 33;
            this.labelControl7.Text = "Periodo";
            // 
            // cmb_Period
            // 
            this.cmb_Period.Location = new System.Drawing.Point(47, 6);
            this.cmb_Period.Name = "cmb_Period";
            this.cmb_Period.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Period.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("period", "Periodo")});
            this.cmb_Period.Properties.DisplayMember = "period";
            this.cmb_Period.Properties.ValueMember = "id";
            this.cmb_Period.Size = new System.Drawing.Size(221, 20);
            this.cmb_Period.TabIndex = 32;
            this.cmb_Period.EditValueChanged += new System.EventHandler(this.cmb_Period_EditValueChanged);
            this.cmb_Period.EnabledChanged += new System.EventHandler(this.cmb_Period_EnabledChanged);
            // 
            // MP_CargarII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 474);
            this.Controls.Add(this.grdPlantilla);
            this.Controls.Add(this.grdDetalle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MP_CargarII.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MP_CargarII";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga Inventario Inicial (Kg)";
            this.Load += new System.EventHandler(this.MP_CargarII_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlantilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlantillaView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Period.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnCargar;
        private DevExpress.XtraEditors.SimpleButton btnBajarPlantilla;
        private DevExpress.XtraGrid.GridControl grdDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grdColCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn grdColMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn grdColCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn grdColValorUsd;
        private DevExpress.XtraGrid.Columns.GridColumn grdColValorHNL;
        private DevExpress.XtraGrid.GridControl grdPlantilla;
        private DevExpress.XtraGrid.Views.Grid.GridView grdPlantillaView;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnBajarXPeriodo;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit cmb_Period;
        private DevExpress.XtraGrid.Columns.GridColumn grdConsumo;
        private DevExpress.XtraGrid.Columns.GridColumn grdInv_fisico_kgs;
        private DevExpress.XtraEditors.SimpleButton cmdAnularLineasInv;
    }
}