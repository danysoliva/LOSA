
namespace LOSA.Liquidos
{
    partial class xfrmLotesPorTanque
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmLotesPorTanque));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grd_boleta = new DevExpress.XtraGrid.GridControl();
            this.lOSAIngresoliquidosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsLiquidos_ = new LOSA.Liquidos.dsLiquidos_();
            this.grdv_boleta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_serie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_prov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_taque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnusar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.lOSAIngresoliquidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_boleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOSAIngresoliquidosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLiquidos_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_boleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnusar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOSAIngresoliquidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_boleta
            // 
            this.grd_boleta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_boleta.DataSource = this.lOSAIngresoliquidosBindingSource1;
            this.grd_boleta.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_boleta.Location = new System.Drawing.Point(1, 86);
            this.grd_boleta.MainView = this.grdv_boleta;
            this.grd_boleta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_boleta.Name = "grd_boleta";
            this.grd_boleta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnusar});
            this.grd_boleta.Size = new System.Drawing.Size(1053, 456);
            this.grd_boleta.TabIndex = 1;
            this.grd_boleta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_boleta});
            // 
            // lOSAIngresoliquidosBindingSource1
            // 
            this.lOSAIngresoliquidosBindingSource1.DataMember = "LOSA_Ingreso_liquidos";
            this.lOSAIngresoliquidosBindingSource1.DataSource = this.dsLiquidos_;
            // 
            // dsLiquidos_
            // 
            this.dsLiquidos_.DataSetName = "dsLiquidos_";
            this.dsLiquidos_.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_boleta
            // 
            this.grdv_boleta.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_boleta.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_boleta.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_boleta.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_boleta.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_boleta.Appearance.Row.Options.UseFont = true;
            this.grdv_boleta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_ingreso,
            this.colkg,
            this.colid_serie,
            this.colproveedor,
            this.colcodigo_prov,
            this.colcodigo_mp,
            this.colmp,
            this.colid_taque});
            this.grdv_boleta.DetailHeight = 284;
            this.grdv_boleta.GridControl = this.grd_boleta;
            this.grdv_boleta.Name = "grdv_boleta";
            this.grdv_boleta.OptionsView.ShowAutoFilterRow = true;
            this.grdv_boleta.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_ingreso
            // 
            this.colid_ingreso.Caption = "ID Ingreso";
            this.colid_ingreso.FieldName = "id_ingreso";
            this.colid_ingreso.Name = "colid_ingreso";
            this.colid_ingreso.OptionsColumn.AllowEdit = false;
            this.colid_ingreso.Visible = true;
            this.colid_ingreso.VisibleIndex = 0;
            this.colid_ingreso.Width = 114;
            // 
            // colkg
            // 
            this.colkg.Caption = "Peso";
            this.colkg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colkg.FieldName = "kg";
            this.colkg.Name = "colkg";
            this.colkg.OptionsColumn.AllowEdit = false;
            this.colkg.Visible = true;
            this.colkg.VisibleIndex = 3;
            this.colkg.Width = 94;
            // 
            // colid_serie
            // 
            this.colid_serie.Caption = "ID Serie";
            this.colid_serie.FieldName = "id_serie";
            this.colid_serie.Name = "colid_serie";
            this.colid_serie.OptionsColumn.AllowEdit = false;
            this.colid_serie.Visible = true;
            this.colid_serie.VisibleIndex = 4;
            this.colid_serie.Width = 119;
            // 
            // colproveedor
            // 
            this.colproveedor.Caption = "Prov.";
            this.colproveedor.FieldName = "proveedor";
            this.colproveedor.Name = "colproveedor";
            this.colproveedor.OptionsColumn.AllowEdit = false;
            this.colproveedor.Visible = true;
            this.colproveedor.VisibleIndex = 6;
            this.colproveedor.Width = 251;
            // 
            // colcodigo_prov
            // 
            this.colcodigo_prov.Caption = "Cod. Prov";
            this.colcodigo_prov.FieldName = "codigo_prov";
            this.colcodigo_prov.Name = "colcodigo_prov";
            this.colcodigo_prov.OptionsColumn.AllowEdit = false;
            this.colcodigo_prov.Visible = true;
            this.colcodigo_prov.VisibleIndex = 5;
            this.colcodigo_prov.Width = 97;
            // 
            // colcodigo_mp
            // 
            this.colcodigo_mp.Caption = "Item Code";
            this.colcodigo_mp.FieldName = "codigo_mp";
            this.colcodigo_mp.Name = "colcodigo_mp";
            this.colcodigo_mp.OptionsColumn.AllowEdit = false;
            this.colcodigo_mp.Visible = true;
            this.colcodigo_mp.VisibleIndex = 1;
            this.colcodigo_mp.Width = 152;
            // 
            // colmp
            // 
            this.colmp.Caption = "MP";
            this.colmp.FieldName = "mp";
            this.colmp.Name = "colmp";
            this.colmp.OptionsColumn.AllowEdit = false;
            this.colmp.Visible = true;
            this.colmp.VisibleIndex = 2;
            this.colmp.Width = 208;
            // 
            // colid_taque
            // 
            this.colid_taque.FieldName = "id_tanque";
            this.colid_taque.Name = "colid_taque";
            // 
            // btnusar
            // 
            this.btnusar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnusar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnusar.Name = "btnusar";
            this.btnusar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // lOSAIngresoliquidosBindingSource
            // 
            this.lOSAIngresoliquidosBindingSource.DataMember = "LOSA_Ingreso_liquidos";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(29, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(117, 55);
            this.simpleButton1.TabIndex = 36;
            this.simpleButton1.Text = "Nuevo";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(905, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(138, 55);
            this.btnAtras.TabIndex = 96;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(191, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(138, 55);
            this.simpleButton2.TabIndex = 97;
            this.simpleButton2.Text = "Actualizar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // xfrmLotesPorTanque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 542);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.grd_boleta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "xfrmLotesPorTanque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xfrmLotesPorTanque";
            ((System.ComponentModel.ISupportInitialize)(this.grd_boleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOSAIngresoliquidosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLiquidos_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_boleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnusar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOSAIngresoliquidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_boleta;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_boleta;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnusar;
        private System.Windows.Forms.BindingSource lOSAIngresoliquidosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colkg;
        private DevExpress.XtraGrid.Columns.GridColumn colid_serie;
        private DevExpress.XtraGrid.Columns.GridColumn colproveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_prov;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colmp;
        private DevExpress.XtraGrid.Columns.GridColumn colid_taque;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private System.Windows.Forms.BindingSource lOSAIngresoliquidosBindingSource1;
        private dsLiquidos_ dsLiquidos_;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}