
namespace LOSA.Produccion
{
    partial class frmAlimentacionConBasculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlimentacionConBasculas));
            this.lblBascula1 = new DevExpress.XtraEditors.LabelControl();
            this.lblValorBascula1 = new DevExpress.XtraEditors.LabelControl();
            this.lblValorBascula2 = new DevExpress.XtraEditors.LabelControl();
            this.lblBascula2 = new DevExpress.XtraEditors.LabelControl();
            this.btnBascula1ON = new DevExpress.XtraEditors.SimpleButton();
            this.btnBascula2ON = new DevExpress.XtraEditors.SimpleButton();
            this.btnBasc1OFF = new DevExpress.XtraEditors.SimpleButton();
            this.txtUnidadesBasc2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnBasc2OFF = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnSelectedTarimas = new DevExpress.XtraEditors.SimpleButton();
            this.timerBasculas = new System.Windows.Forms.Timer(this.components);
            this.vGrid2 = new DevExpress.XtraVerticalGrid.VGridControl();
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
            this.vGrid1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.dsProduccion2 = new LOSA.MigracionACS.DataSetx.dsProduccion();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidadesBasc2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBascula1
            // 
            this.lblBascula1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBascula1.Appearance.Options.UseFont = true;
            this.lblBascula1.Appearance.Options.UseTextOptions = true;
            this.lblBascula1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBascula1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBascula1.Location = new System.Drawing.Point(102, 104);
            this.lblBascula1.Name = "lblBascula1";
            this.lblBascula1.Size = new System.Drawing.Size(377, 19);
            this.lblBascula1.TabIndex = 21;
            this.lblBascula1.Text = "Báscula 1:";
            // 
            // lblValorBascula1
            // 
            this.lblValorBascula1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBascula1.Appearance.Options.UseFont = true;
            this.lblValorBascula1.Appearance.Options.UseTextOptions = true;
            this.lblValorBascula1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblValorBascula1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblValorBascula1.Location = new System.Drawing.Point(102, 129);
            this.lblValorBascula1.Name = "lblValorBascula1";
            this.lblValorBascula1.Size = new System.Drawing.Size(377, 30);
            this.lblValorBascula1.TabIndex = 22;
            this.lblValorBascula1.Text = "Valor en Báscula: 0.00 Kg";
            // 
            // lblValorBascula2
            // 
            this.lblValorBascula2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBascula2.Appearance.Options.UseFont = true;
            this.lblValorBascula2.Appearance.Options.UseTextOptions = true;
            this.lblValorBascula2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblValorBascula2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblValorBascula2.Location = new System.Drawing.Point(645, 129);
            this.lblValorBascula2.Name = "lblValorBascula2";
            this.lblValorBascula2.Size = new System.Drawing.Size(359, 30);
            this.lblValorBascula2.TabIndex = 33;
            this.lblValorBascula2.Text = "Valor en Báscula: 0.00 Kg";
            // 
            // lblBascula2
            // 
            this.lblBascula2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBascula2.Appearance.Options.UseFont = true;
            this.lblBascula2.Appearance.Options.UseTextOptions = true;
            this.lblBascula2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBascula2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBascula2.Location = new System.Drawing.Point(696, 104);
            this.lblBascula2.Name = "lblBascula2";
            this.lblBascula2.Size = new System.Drawing.Size(308, 19);
            this.lblBascula2.TabIndex = 32;
            this.lblBascula2.Text = "Báscula 2:";
            // 
            // btnBascula1ON
            // 
            this.btnBascula1ON.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBascula1ON.Appearance.Options.UseFont = true;
            this.btnBascula1ON.Enabled = false;
            this.btnBascula1ON.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBascula1.ImageOptions.Image")));
            this.btnBascula1ON.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBascula1ON.Location = new System.Drawing.Point(203, 183);
            this.btnBascula1ON.Name = "btnBascula1ON";
            this.btnBascula1ON.Size = new System.Drawing.Size(159, 74);
            this.btnBascula1ON.TabIndex = 34;
            this.btnBascula1ON.Text = "Empezar Pesaje";
            // 
            // btnBascula2ON
            // 
            this.btnBascula2ON.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBascula2ON.Appearance.Options.UseFont = true;
            this.btnBascula2ON.Enabled = false;
            this.btnBascula2ON.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBascula2.ImageOptions.Image")));
            this.btnBascula2ON.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBascula2ON.Location = new System.Drawing.Point(762, 183);
            this.btnBascula2ON.Name = "btnBascula2ON";
            this.btnBascula2ON.Size = new System.Drawing.Size(159, 74);
            this.btnBascula2ON.TabIndex = 35;
            this.btnBascula2ON.Text = "Empezar Pesaje";
            // 
            // btnBasc1OFF
            // 
            this.btnBasc1OFF.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasc1OFF.Appearance.Options.UseFont = true;
            this.btnBasc1OFF.Enabled = false;
            this.btnBasc1OFF.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBasc1OFF.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBasc1Guardar.ImageOptions.SvgImage")));
            this.btnBasc1OFF.Location = new System.Drawing.Point(203, 493);
            this.btnBasc1OFF.Name = "btnBasc1OFF";
            this.btnBasc1OFF.Size = new System.Drawing.Size(159, 74);
            this.btnBasc1OFF.TabIndex = 36;
            this.btnBasc1OFF.Text = "Guardar Pesaje";
            // 
            // txtUnidadesBasc2
            // 
            this.txtUnidadesBasc2.Enabled = false;
            this.txtUnidadesBasc2.Location = new System.Drawing.Point(879, 583);
            this.txtUnidadesBasc2.Name = "txtUnidadesBasc2";
            this.txtUnidadesBasc2.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidadesBasc2.Properties.Appearance.Options.UseFont = true;
            this.txtUnidadesBasc2.Size = new System.Drawing.Size(135, 26);
            this.txtUnidadesBasc2.TabIndex = 39;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(626, 580);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(251, 28);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "Unidades a Descargar:";
            // 
            // btnBasc2OFF
            // 
            this.btnBasc2OFF.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasc2OFF.Appearance.Options.UseFont = true;
            this.btnBasc2OFF.Enabled = false;
            this.btnBasc2OFF.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBasc2OFF.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBasc2Guardar.ImageOptions.SvgImage")));
            this.btnBasc2OFF.Location = new System.Drawing.Point(762, 493);
            this.btnBasc2OFF.Name = "btnBasc2OFF";
            this.btnBasc2OFF.Size = new System.Drawing.Size(159, 74);
            this.btnBasc2OFF.TabIndex = 41;
            this.btnBasc2OFF.Text = "Guardar Pesaje";
            // 
            // textEdit2
            // 
            this.textEdit2.Enabled = false;
            this.textEdit2.Location = new System.Drawing.Point(879, 545);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Size = new System.Drawing.Size(212, 26);
            this.textEdit2.TabIndex = 45;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(631, 543);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(211, 28);
            this.labelControl4.TabIndex = 44;
            this.labelControl4.Text = "Materia Prima:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(318, 18);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(367, 30);
            this.labelControl5.TabIndex = 46;
            this.labelControl5.Text = "Seleccione la Tarima:";
            // 
            // btnSelectedTarimas
            // 
            this.btnSelectedTarimas.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectedTarimas.Appearance.Options.UseFont = true;
            this.btnSelectedTarimas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectedTarimas.ImageOptions.Image")));
            this.btnSelectedTarimas.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSelectedTarimas.Location = new System.Drawing.Point(628, 3);
            this.btnSelectedTarimas.Name = "btnSelectedTarimas";
            this.btnSelectedTarimas.Size = new System.Drawing.Size(153, 65);
            this.btnSelectedTarimas.TabIndex = 47;
            this.btnSelectedTarimas.Text = "Tarimas";
            this.btnSelectedTarimas.Click += new System.EventHandler(this.btnSelectedTarimas_Click);
            // 
            // vGrid2
            // 
            this.vGrid2.Cursor = System.Windows.Forms.Cursors.Default;
            this.vGrid2.DataMember = "Bascula2";
            this.vGrid2.DataSource = this.dsProduccion1;
            this.vGrid2.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGrid2.Location = new System.Drawing.Point(645, 263);
            this.vGrid2.Name = "vGrid2";
            this.vGrid2.RecordWidth = 130;
            this.vGrid2.RowHeaderWidth = 70;
            this.vGrid2.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
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
            this.vGrid2.Size = new System.Drawing.Size(395, 222);
            this.vGrid2.TabIndex = 49;
            // 
            // dsProduccion1
            // 
            this.dsProduccion1.DataSetName = "dsProduccion";
            this.dsProduccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // row_requisa
            // 
            this.row_requisa.Name = "row_requisa";
            this.row_requisa.Properties.Caption = "#requisa";
            this.row_requisa.Properties.FieldName = "#requisa";
            // 
            // rowmp
            // 
            this.rowmp.Name = "rowmp";
            this.rowmp.Properties.Caption = "mp";
            this.rowmp.Properties.FieldName = "mp";
            // 
            // rowunidades
            // 
            this.rowunidades.Name = "rowunidades";
            this.rowunidades.Properties.Caption = "unidades";
            this.rowunidades.Properties.FieldName = "unidades";
            // 
            // rowpeso
            // 
            this.rowpeso.Name = "rowpeso";
            this.rowpeso.Properties.Caption = "peso";
            this.rowpeso.Properties.FieldName = "peso";
            // 
            // rowlote
            // 
            this.rowlote.Name = "rowlote";
            this.rowlote.Properties.Caption = "lote";
            this.rowlote.Properties.FieldName = "lote";
            // 
            // rowpeso_bruto
            // 
            this.rowpeso_bruto.Name = "rowpeso_bruto";
            this.rowpeso_bruto.Properties.Caption = "peso_bruto";
            this.rowpeso_bruto.Properties.FieldName = "peso_bruto";
            // 
            // rowpeso_tara
            // 
            this.rowpeso_tara.Name = "rowpeso_tara";
            this.rowpeso_tara.Properties.Caption = "peso_tara";
            this.rowpeso_tara.Properties.FieldName = "peso_tara";
            // 
            // rowpeso_prd
            // 
            this.rowpeso_prd.Name = "rowpeso_prd";
            this.rowpeso_prd.Properties.Caption = "peso_prd";
            this.rowpeso_prd.Properties.FieldName = "peso_prd";
            // 
            // rowbascula
            // 
            this.rowbascula.Name = "rowbascula";
            this.rowbascula.Properties.Caption = "bascula";
            this.rowbascula.Properties.FieldName = "bascula";
            // 
            // rowcodigo_barra
            // 
            this.rowcodigo_barra.Name = "rowcodigo_barra";
            this.rowcodigo_barra.Properties.Caption = "codigo_barra";
            this.rowcodigo_barra.Properties.FieldName = "codigo_barra";
            // 
            // vGrid1
            // 
            this.vGrid1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.vGrid1.Cursor = System.Windows.Forms.Cursors.Default;
            this.vGrid1.CustomizationFormBounds = new System.Drawing.Rectangle(457, 176, 214, 258);
            this.vGrid1.DataMember = null;
            this.vGrid1.DataSource = this.dsProduccion1;
            this.vGrid1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGrid1.Location = new System.Drawing.Point(102, 263);
            this.vGrid1.Name = "vGrid1";
            this.vGrid1.RecordWidth = 158;
            this.vGrid1.RowHeaderWidth = 42;
            this.vGrid1.Size = new System.Drawing.Size(409, 222);
            this.vGrid1.TabIndex = 48;
            // 
            // dsProduccion2
            // 
            this.dsProduccion2.DataSetName = "dsProduccion";
            this.dsProduccion2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmAlimentacionConBasculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 635);
            this.Controls.Add(this.vGrid2);
            this.Controls.Add(this.vGrid1);
            this.Controls.Add(this.btnSelectedTarimas);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnBasc2OFF);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtUnidadesBasc2);
            this.Controls.Add(this.btnBasc1OFF);
            this.Controls.Add(this.btnBascula2ON);
            this.Controls.Add(this.btnBascula1ON);
            this.Controls.Add(this.lblValorBascula2);
            this.Controls.Add(this.lblBascula2);
            this.Controls.Add(this.lblValorBascula1);
            this.Controls.Add(this.lblBascula1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmAlimentacionConBasculas.IconOptions.Image")));
            this.Name = "frmAlimentacionConBasculas";
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidadesBasc2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBascula1;
        private DevExpress.XtraEditors.LabelControl lblValorBascula1;
        private DevExpress.XtraEditors.LabelControl lblValorBascula2;
        private DevExpress.XtraEditors.LabelControl lblBascula2;
        private DevExpress.XtraEditors.SimpleButton btnBascula1ON;
        private DevExpress.XtraEditors.SimpleButton btnBascula2ON;
        private DevExpress.XtraEditors.SimpleButton btnBasc1OFF;
        private DevExpress.XtraEditors.TextEdit txtUnidadesBasc2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnBasc2OFF;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnSelectedTarimas;
        private DevExpress.XtraVerticalGrid.VGridControl vGrid1;
        private dsProduccion dsProduccion1;
        private System.Windows.Forms.Timer timerBasculas;
        private MigracionACS.DataSetx.dsProduccion dsProduccion2;
        private DevExpress.XtraVerticalGrid.VGridControl vGrid2;
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
    }
}