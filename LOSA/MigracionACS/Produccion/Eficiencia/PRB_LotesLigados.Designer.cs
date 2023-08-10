
namespace LOSA.MigracionACS.Produccion.Eficiencia
{
    partial class PRB_LotesLigados
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRB_LotesLigados));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdSacosProducidos = new DevExpress.XtraGrid.GridControl();
            this.dsLotePick1 = new LOSA.MigracionACS.Produccion.Eficiencia.dsLotePick();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_reg_h_prb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_sacos_prd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_posteo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnRefresh = new DevExpress.XtraEditors.ButtonEdit();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.lblmaquina = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdSacosProducidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLotePick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSacosProducidos
            // 
            this.grdSacosProducidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSacosProducidos.DataMember = "lotes_registrados";
            this.grdSacosProducidos.DataSource = this.dsLotePick1;
            this.grdSacosProducidos.Location = new System.Drawing.Point(0, 99);
            this.grdSacosProducidos.MainView = this.gridView1;
            this.grdSacosProducidos.Name = "grdSacosProducidos";
            this.grdSacosProducidos.Size = new System.Drawing.Size(1101, 627);
            this.grdSacosProducidos.TabIndex = 0;
            this.grdSacosProducidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsLotePick1
            // 
            this.dsLotePick1.DataSetName = "dsLotePick";
            this.dsLotePick1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collote,
            this.colid_linea,
            this.collinea,
            this.colid_reg_h_prb,
            this.colcodigo,
            this.coldescripcion,
            this.colcantidad_sacos_prd,
            this.colid_presentacion,
            this.colfechai,
            this.colfechaf,
            this.colhoras,
            this.colfecha_posteo});
            this.gridView1.GridControl = this.grdSacosProducidos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // collote
            // 
            this.collote.Caption = "Lote PT";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.ReadOnly = true;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 0;
            // 
            // colid_linea
            // 
            this.colid_linea.FieldName = "id_linea";
            this.colid_linea.Name = "colid_linea";
            this.colid_linea.OptionsColumn.ReadOnly = true;
            // 
            // collinea
            // 
            this.collinea.Caption = "Linea";
            this.collinea.FieldName = "linea";
            this.collinea.Name = "collinea";
            this.collinea.OptionsColumn.ReadOnly = true;
            this.collinea.Visible = true;
            this.collinea.VisibleIndex = 1;
            // 
            // colid_reg_h_prb
            // 
            this.colid_reg_h_prb.FieldName = "id_reg_h_prb";
            this.colid_reg_h_prb.Name = "colid_reg_h_prb";
            this.colid_reg_h_prb.OptionsColumn.ReadOnly = true;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.ReadOnly = true;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 2;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Producto";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 3;
            // 
            // colcantidad_sacos_prd
            // 
            this.colcantidad_sacos_prd.Caption = "Sacos Producidos";
            this.colcantidad_sacos_prd.FieldName = "cantidad_sacos_prd";
            this.colcantidad_sacos_prd.Name = "colcantidad_sacos_prd";
            this.colcantidad_sacos_prd.OptionsColumn.ReadOnly = true;
            this.colcantidad_sacos_prd.Visible = true;
            this.colcantidad_sacos_prd.VisibleIndex = 4;
            // 
            // colid_presentacion
            // 
            this.colid_presentacion.FieldName = "id_presentacion";
            this.colid_presentacion.Name = "colid_presentacion";
            this.colid_presentacion.OptionsColumn.ReadOnly = true;
            // 
            // colfechai
            // 
            this.colfechai.Caption = "Fecha Inicial";
            this.colfechai.FieldName = "fechai";
            this.colfechai.Name = "colfechai";
            this.colfechai.OptionsColumn.ReadOnly = true;
            this.colfechai.Visible = true;
            this.colfechai.VisibleIndex = 5;
            // 
            // colfechaf
            // 
            this.colfechaf.Caption = "Fecha Final";
            this.colfechaf.FieldName = "fechaf";
            this.colfechaf.Name = "colfechaf";
            this.colfechaf.OptionsColumn.ReadOnly = true;
            this.colfechaf.Visible = true;
            this.colfechaf.VisibleIndex = 6;
            // 
            // colhoras
            // 
            this.colhoras.Caption = "Horas";
            this.colhoras.FieldName = "horas";
            this.colhoras.Name = "colhoras";
            this.colhoras.OptionsColumn.ReadOnly = true;
            this.colhoras.Visible = true;
            this.colhoras.VisibleIndex = 7;
            // 
            // colfecha_posteo
            // 
            this.colfecha_posteo.Caption = "Fecha Posteo";
            this.colfecha_posteo.FieldName = "fecha_posteo";
            this.colfecha_posteo.Name = "colfecha_posteo";
            this.colfecha_posteo.OptionsColumn.ReadOnly = true;
            this.colfecha_posteo.Visible = true;
            this.colfecha_posteo.VisibleIndex = 8;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Controls.Add(this.dtHasta);
            this.panelControl1.Controls.Add(this.dtDesde);
            this.panelControl1.Controls.Add(this.lblmaquina);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(0, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1101, 88);
            this.panelControl1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRefresh.EditValue = "Cargar";
            this.btnRefresh.Location = new System.Drawing.Point(305, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRefresh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Properties.Appearance.Options.UseBackColor = true;
            this.btnRefresh.Properties.Appearance.Options.UseFont = true;
            this.btnRefresh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.btnRefresh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnRefresh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnRefresh.Size = new System.Drawing.Size(112, 38);
            this.btnRefresh.TabIndex = 74;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(114, 59);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Size = new System.Drawing.Size(151, 24);
            this.dtHasta.TabIndex = 1;
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(114, 17);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Size = new System.Drawing.Size(151, 24);
            this.dtDesde.TabIndex = 0;
            // 
            // lblmaquina
            // 
            this.lblmaquina.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaquina.Appearance.Options.UseFont = true;
            this.lblmaquina.Location = new System.Drawing.Point(58, 20);
            this.lblmaquina.Name = "lblmaquina";
            this.lblmaquina.Size = new System.Drawing.Size(207, 18);
            this.lblmaquina.TabIndex = 75;
            this.lblmaquina.Text = "Desde:____________________";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(61, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(204, 18);
            this.labelControl1.TabIndex = 76;
            this.labelControl1.Text = "Hasta:____________________";
            // 
            // PRB_LotesLigados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 726);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.grdSacosProducidos);
            this.MaximizeBox = false;
            this.Name = "PRB_LotesLigados";
            this.Text = "Sacos Producidos Agregados a Reporte de Produccion";
            ((System.ComponentModel.ISupportInitialize)(this.grdSacosProducidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLotePick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdSacosProducidos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsLotePick dsLotePick1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colid_linea;
        private DevExpress.XtraGrid.Columns.GridColumn collinea;
        private DevExpress.XtraGrid.Columns.GridColumn colid_reg_h_prb;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_sacos_prd;
        private DevExpress.XtraGrid.Columns.GridColumn colid_presentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colfechai;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaf;
        private DevExpress.XtraGrid.Columns.GridColumn colhoras;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_posteo;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.ButtonEdit btnRefresh;
        private DevExpress.XtraEditors.LabelControl lblmaquina;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}