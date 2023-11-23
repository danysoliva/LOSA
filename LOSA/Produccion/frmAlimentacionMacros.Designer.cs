
namespace LOSA.Produccion
{
    partial class frmAlimentacionMacros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlimentacionMacros));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdSelectTarima = new DevExpress.XtraEditors.SimpleButton();
            this.lblValorBascula1 = new DevExpress.XtraEditors.LabelControl();
            this.lblBascula1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblValorBascula2 = new DevExpress.XtraEditors.LabelControl();
            this.btnBascula1ON = new DevExpress.XtraEditors.SimpleButton();
            this.btnBascula2ON = new DevExpress.XtraEditors.SimpleButton();
            this.btnBascula1Off = new DevExpress.XtraEditors.SimpleButton();
            this.btnBascula2Off = new DevExpress.XtraEditors.SimpleButton();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.dsProduccion1 = new LOSA.Produccion.dsProduccion();
            this.row_requisa = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowmp = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowunidades = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowlote = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso_bruto = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso_tara = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso_prd = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowbascula = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowcodigo_barra = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.vGridControl2 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.row_requisa1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowmp1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowunidades1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowlote1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso_bruto1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso_tara1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso_prd1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowbascula1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowcodigo_barra1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.timerBascula = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(534, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(230, 25);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Seleccion de Tarima:";
            // 
            // cmdSelectTarima
            // 
            this.cmdSelectTarima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSelectTarima.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelectTarima.Appearance.Options.UseFont = true;
            this.cmdSelectTarima.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSelectTarima.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.cmdSelectTarima.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdSelectTarima.Location = new System.Drawing.Point(730, 19);
            this.cmdSelectTarima.Name = "cmdSelectTarima";
            this.cmdSelectTarima.Size = new System.Drawing.Size(62, 44);
            this.cmdSelectTarima.TabIndex = 109;
            this.cmdSelectTarima.Visible = false;
            this.cmdSelectTarima.Click += new System.EventHandler(this.cmdSelectTarima_Click);
            // 
            // lblValorBascula1
            // 
            this.lblValorBascula1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBascula1.Appearance.Options.UseFont = true;
            this.lblValorBascula1.Appearance.Options.UseTextOptions = true;
            this.lblValorBascula1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblValorBascula1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblValorBascula1.Location = new System.Drawing.Point(135, 153);
            this.lblValorBascula1.Name = "lblValorBascula1";
            this.lblValorBascula1.Size = new System.Drawing.Size(389, 30);
            this.lblValorBascula1.TabIndex = 110;
            this.lblValorBascula1.Text = "Valor en Báscula: 0.00 Kg";
            // 
            // lblBascula1
            // 
            this.lblBascula1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBascula1.Appearance.Options.UseFont = true;
            this.lblBascula1.Appearance.Options.UseTextOptions = true;
            this.lblBascula1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBascula1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBascula1.Location = new System.Drawing.Point(135, 118);
            this.lblBascula1.Name = "lblBascula1";
            this.lblBascula1.Size = new System.Drawing.Size(389, 29);
            this.lblBascula1.TabIndex = 111;
            this.lblBascula1.Text = "Báscula 1";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(814, 118);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(389, 29);
            this.labelControl2.TabIndex = 112;
            this.labelControl2.Text = "Báscula 2";
            // 
            // lblValorBascula2
            // 
            this.lblValorBascula2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorBascula2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBascula2.Appearance.Options.UseFont = true;
            this.lblValorBascula2.Appearance.Options.UseTextOptions = true;
            this.lblValorBascula2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblValorBascula2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblValorBascula2.Location = new System.Drawing.Point(814, 153);
            this.lblValorBascula2.Name = "lblValorBascula2";
            this.lblValorBascula2.Size = new System.Drawing.Size(389, 30);
            this.lblValorBascula2.TabIndex = 113;
            this.lblValorBascula2.Text = "Valor en Báscula: 0.00 Kg";
            // 
            // btnBascula1ON
            // 
            this.btnBascula1ON.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBascula1ON.Appearance.Options.UseFont = true;
            this.btnBascula1ON.Enabled = false;
            this.btnBascula1ON.ImageOptions.Image = global::LOSA.Properties.Resources.bascula_x32;
            this.btnBascula1ON.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBascula1ON.Location = new System.Drawing.Point(272, 215);
            this.btnBascula1ON.Name = "btnBascula1ON";
            this.btnBascula1ON.Size = new System.Drawing.Size(104, 74);
            this.btnBascula1ON.TabIndex = 114;
            this.btnBascula1ON.Text = "Acumular";
            this.btnBascula1ON.Click += new System.EventHandler(this.btnBascula1ON_Click);
            // 
            // btnBascula2ON
            // 
            this.btnBascula2ON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBascula2ON.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBascula2ON.Appearance.Options.UseFont = true;
            this.btnBascula2ON.Enabled = false;
            this.btnBascula2ON.ImageOptions.Image = global::LOSA.Properties.Resources.bascula_x32;
            this.btnBascula2ON.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBascula2ON.Location = new System.Drawing.Point(955, 215);
            this.btnBascula2ON.Name = "btnBascula2ON";
            this.btnBascula2ON.Size = new System.Drawing.Size(104, 74);
            this.btnBascula2ON.TabIndex = 115;
            this.btnBascula2ON.Text = "Acumular";
            this.btnBascula2ON.Click += new System.EventHandler(this.btnBascula2ON_Click);
            // 
            // btnBascula1Off
            // 
            this.btnBascula1Off.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBascula1Off.Appearance.Options.UseFont = true;
            this.btnBascula1Off.Enabled = false;
            this.btnBascula1Off.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBascula1Off.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBascula1.ImageOptions.SvgImage")));
            this.btnBascula1Off.Location = new System.Drawing.Point(272, 527);
            this.btnBascula1Off.Name = "btnBascula1Off";
            this.btnBascula1Off.Size = new System.Drawing.Size(104, 74);
            this.btnBascula1Off.TabIndex = 116;
            this.btnBascula1Off.Text = "Guardar";
            // 
            // btnBascula2Off
            // 
            this.btnBascula2Off.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBascula2Off.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBascula2Off.Appearance.Options.UseFont = true;
            this.btnBascula2Off.Enabled = false;
            this.btnBascula2Off.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBascula2Off.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBascula2.ImageOptions.SvgImage")));
            this.btnBascula2Off.Location = new System.Drawing.Point(955, 527);
            this.btnBascula2Off.Name = "btnBascula2Off";
            this.btnBascula2Off.Size = new System.Drawing.Size(104, 74);
            this.btnBascula2Off.TabIndex = 117;
            this.btnBascula2Off.Text = "Guardar";
            // 
            // vGridControl1
            // 
            this.vGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.vGridControl1.DataMember = "Bascula1";
            this.vGridControl1.DataSource = this.dsProduccion1;
            this.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl1.Location = new System.Drawing.Point(135, 311);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RecordWidth = 115;
            this.vGridControl1.RowHeaderWidth = 85;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.row_requisa,
            this.rowmp,
            this.rowunidades,
            this.rowpeso,
            this.rowlote,
            this.rowpeso_bruto,
            this.rowpeso_tara,
            this.rowpeso_prd,
            this.rowbascula,
            this.rowcodigo_barra});
            this.vGridControl1.Size = new System.Drawing.Size(389, 200);
            this.vGridControl1.TabIndex = 118;
            // 
            // dsProduccion1
            // 
            this.dsProduccion1.DataSetName = "dsProduccion";
            this.dsProduccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // row_requisa
            // 
            this.row_requisa.Name = "row_requisa";
            this.row_requisa.Properties.AllowEdit = false;
            this.row_requisa.Properties.Caption = "#requisa";
            this.row_requisa.Properties.FieldName = "#requisa";
            // 
            // rowmp
            // 
            this.rowmp.Name = "rowmp";
            this.rowmp.Properties.AllowEdit = false;
            this.rowmp.Properties.Caption = "mp";
            this.rowmp.Properties.FieldName = "mp";
            // 
            // rowunidades
            // 
            this.rowunidades.Name = "rowunidades";
            this.rowunidades.Properties.AllowEdit = false;
            this.rowunidades.Properties.Caption = "unidades";
            this.rowunidades.Properties.FieldName = "unidades";
            // 
            // rowpeso
            // 
            this.rowpeso.Name = "rowpeso";
            this.rowpeso.Properties.AllowEdit = false;
            this.rowpeso.Properties.Caption = "peso";
            this.rowpeso.Properties.FieldName = "peso";
            // 
            // rowlote
            // 
            this.rowlote.Name = "rowlote";
            this.rowlote.Properties.AllowEdit = false;
            this.rowlote.Properties.Caption = "lote";
            this.rowlote.Properties.FieldName = "lote";
            // 
            // rowpeso_bruto
            // 
            this.rowpeso_bruto.Name = "rowpeso_bruto";
            this.rowpeso_bruto.Properties.AllowEdit = false;
            this.rowpeso_bruto.Properties.Caption = "peso_bruto";
            this.rowpeso_bruto.Properties.FieldName = "peso_bruto";
            // 
            // rowpeso_tara
            // 
            this.rowpeso_tara.Name = "rowpeso_tara";
            this.rowpeso_tara.Properties.AllowEdit = false;
            this.rowpeso_tara.Properties.Caption = "peso_tara";
            this.rowpeso_tara.Properties.FieldName = "peso_tara";
            // 
            // rowpeso_prd
            // 
            this.rowpeso_prd.Name = "rowpeso_prd";
            this.rowpeso_prd.Properties.AllowEdit = false;
            this.rowpeso_prd.Properties.Caption = "peso_prd";
            this.rowpeso_prd.Properties.FieldName = "peso_prd";
            // 
            // rowbascula
            // 
            this.rowbascula.Name = "rowbascula";
            this.rowbascula.Properties.AllowEdit = false;
            this.rowbascula.Properties.Caption = "bascula";
            this.rowbascula.Properties.FieldName = "bascula";
            // 
            // rowcodigo_barra
            // 
            this.rowcodigo_barra.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowcodigo_barra.AppearanceCell.Options.UseFont = true;
            this.rowcodigo_barra.Name = "rowcodigo_barra";
            this.rowcodigo_barra.Properties.AllowEdit = false;
            this.rowcodigo_barra.Properties.Caption = "codigo_barra";
            this.rowcodigo_barra.Properties.FieldName = "codigo_barra";
            // 
            // vGridControl2
            // 
            this.vGridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vGridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.vGridControl2.DataMember = "Bascula2";
            this.vGridControl2.DataSource = this.dsProduccion1;
            this.vGridControl2.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl2.Location = new System.Drawing.Point(814, 311);
            this.vGridControl2.Name = "vGridControl2";
            this.vGridControl2.RecordWidth = 115;
            this.vGridControl2.RowHeaderWidth = 85;
            this.vGridControl2.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.row_requisa1,
            this.rowmp1,
            this.rowunidades1,
            this.rowpeso1,
            this.rowlote1,
            this.rowpeso_bruto1,
            this.rowpeso_tara1,
            this.rowpeso_prd1,
            this.rowbascula1,
            this.rowcodigo_barra1});
            this.vGridControl2.Size = new System.Drawing.Size(389, 200);
            this.vGridControl2.TabIndex = 119;
            // 
            // row_requisa1
            // 
            this.row_requisa1.Name = "row_requisa1";
            this.row_requisa1.Properties.AllowEdit = false;
            this.row_requisa1.Properties.Caption = "#requisa";
            this.row_requisa1.Properties.FieldName = "#requisa";
            // 
            // rowmp1
            // 
            this.rowmp1.Name = "rowmp1";
            this.rowmp1.Properties.AllowEdit = false;
            this.rowmp1.Properties.Caption = "mp";
            this.rowmp1.Properties.FieldName = "mp";
            // 
            // rowunidades1
            // 
            this.rowunidades1.Name = "rowunidades1";
            this.rowunidades1.Properties.AllowEdit = false;
            this.rowunidades1.Properties.Caption = "unidades";
            this.rowunidades1.Properties.FieldName = "unidades";
            // 
            // rowpeso1
            // 
            this.rowpeso1.Name = "rowpeso1";
            this.rowpeso1.Properties.AllowEdit = false;
            this.rowpeso1.Properties.Caption = "peso";
            this.rowpeso1.Properties.FieldName = "peso";
            // 
            // rowlote1
            // 
            this.rowlote1.Name = "rowlote1";
            this.rowlote1.Properties.AllowEdit = false;
            this.rowlote1.Properties.Caption = "lote";
            this.rowlote1.Properties.FieldName = "lote";
            // 
            // rowpeso_bruto1
            // 
            this.rowpeso_bruto1.Name = "rowpeso_bruto1";
            this.rowpeso_bruto1.Properties.AllowEdit = false;
            this.rowpeso_bruto1.Properties.Caption = "peso_bruto";
            this.rowpeso_bruto1.Properties.FieldName = "peso_bruto";
            // 
            // rowpeso_tara1
            // 
            this.rowpeso_tara1.Name = "rowpeso_tara1";
            this.rowpeso_tara1.Properties.AllowEdit = false;
            this.rowpeso_tara1.Properties.Caption = "peso_tara";
            this.rowpeso_tara1.Properties.FieldName = "peso_tara";
            // 
            // rowpeso_prd1
            // 
            this.rowpeso_prd1.Name = "rowpeso_prd1";
            this.rowpeso_prd1.Properties.AllowEdit = false;
            this.rowpeso_prd1.Properties.Caption = "peso_prd";
            this.rowpeso_prd1.Properties.FieldName = "peso_prd";
            // 
            // rowbascula1
            // 
            this.rowbascula1.Name = "rowbascula1";
            this.rowbascula1.Properties.AllowEdit = false;
            this.rowbascula1.Properties.Caption = "bascula";
            this.rowbascula1.Properties.FieldName = "bascula";
            // 
            // rowcodigo_barra1
            // 
            this.rowcodigo_barra1.Name = "rowcodigo_barra1";
            this.rowcodigo_barra1.Properties.AllowEdit = false;
            this.rowcodigo_barra1.Properties.Caption = "codigo_barra";
            this.rowcodigo_barra1.Properties.FieldName = "codigo_barra";
            // 
            // timerBascula
            // 
            this.timerBascula.Interval = 650;
            this.timerBascula.Tick += new System.EventHandler(this.timerBascula_Tick);
            // 
            // frmAlimentacionMacros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 765);
            this.Controls.Add(this.vGridControl2);
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.btnBascula2Off);
            this.Controls.Add(this.btnBascula1Off);
            this.Controls.Add(this.btnBascula2ON);
            this.Controls.Add(this.btnBascula1ON);
            this.Controls.Add(this.lblValorBascula2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblBascula1);
            this.Controls.Add(this.lblValorBascula1);
            this.Controls.Add(this.cmdSelectTarima);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmAlimentacionMacros";
            this.Text = "Alimentacion de MacroIngredientes";
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdSelectTarima;
        private DevExpress.XtraEditors.LabelControl lblValorBascula1;
        private DevExpress.XtraEditors.LabelControl lblBascula1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblValorBascula2;
        private DevExpress.XtraEditors.SimpleButton btnBascula1ON;
        private DevExpress.XtraEditors.SimpleButton btnBascula2ON;
        private DevExpress.XtraEditors.SimpleButton btnBascula1Off;
        private DevExpress.XtraEditors.SimpleButton btnBascula2Off;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl2;
        private dsProduccion dsProduccion1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row_requisa;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowmp;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowunidades;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowpeso;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowlote;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowpeso_bruto;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowpeso_tara;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowpeso_prd;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowbascula;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowcodigo_barra;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row_requisa1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowmp1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowunidades1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowpeso1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowlote1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowpeso_bruto1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowpeso_tara1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowpeso_prd1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowbascula1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowcodigo_barra1;
        private System.Windows.Forms.Timer timerBascula;
    }
}