
namespace LOSA.TransaccionesMP
{
    partial class frmResumenToDevolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResumenToDevolucion));
            this.btnUP = new DevExpress.XtraEditors.SimpleButton();
            this.lblTotalUd_en_tarima = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnDown = new DevExpress.XtraEditors.SimpleButton();
            this.txtPorEnviar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtKgAEnviar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPresentacion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.dsProduccion1 = new LOSA.Produccion.dsProduccion();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.row_requisa = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowLotePT = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowmp = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowlote = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowcodigo_barra = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowunidades = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowPresentacion = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso_bruto = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso_tara = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso_prd = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowbascula = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorEnviar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKgAEnviar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPresentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUP
            // 
            this.btnUP.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnUP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUP.ImageOptions.SvgImage")));
            this.btnUP.Location = new System.Drawing.Point(458, 218);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(74, 65);
            this.btnUP.TabIndex = 118;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // lblTotalUd_en_tarima
            // 
            this.lblTotalUd_en_tarima.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUd_en_tarima.Appearance.Options.UseFont = true;
            this.lblTotalUd_en_tarima.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalUd_en_tarima.Location = new System.Drawing.Point(393, 232);
            this.lblTotalUd_en_tarima.Name = "lblTotalUd_en_tarima";
            this.lblTotalUd_en_tarima.Size = new System.Drawing.Size(115, 30);
            this.lblTotalUd_en_tarima.TabIndex = 121;
            this.lblTotalUd_en_tarima.Text = "0 Ud";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(382, 232);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(10, 30);
            this.labelControl7.TabIndex = 120;
            this.labelControl7.Text = "/";
            // 
            // btnDown
            // 
            this.btnDown.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDown.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDown.ImageOptions.SvgImage")));
            this.btnDown.Location = new System.Drawing.Point(550, 218);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(76, 65);
            this.btnDown.TabIndex = 119;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // txtPorEnviar
            // 
            this.txtPorEnviar.Enabled = false;
            this.txtPorEnviar.Location = new System.Drawing.Point(321, 229);
            this.txtPorEnviar.Name = "txtPorEnviar";
            this.txtPorEnviar.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtPorEnviar.Properties.Appearance.Options.UseFont = true;
            this.txtPorEnviar.Size = new System.Drawing.Size(59, 36);
            this.txtPorEnviar.TabIndex = 117;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(27, 232);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(288, 30);
            this.labelControl3.TabIndex = 116;
            this.labelControl3.Text = "Enviado de esta Tarima (Ud.):";
            // 
            // txtKgAEnviar
            // 
            this.txtKgAEnviar.Enabled = false;
            this.txtKgAEnviar.Location = new System.Drawing.Point(338, 343);
            this.txtKgAEnviar.Name = "txtKgAEnviar";
            this.txtKgAEnviar.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtKgAEnviar.Properties.Appearance.Options.UseFont = true;
            this.txtKgAEnviar.Size = new System.Drawing.Size(198, 36);
            this.txtKgAEnviar.TabIndex = 123;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(51, 346);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(281, 30);
            this.labelControl5.TabIndex = 122;
            this.labelControl5.Text = "Enviado de esta Tarima (Kg):";
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.Enabled = false;
            this.txtPresentacion.Location = new System.Drawing.Point(338, 296);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtPresentacion.Properties.Appearance.Options.UseFont = true;
            this.txtPresentacion.Size = new System.Drawing.Size(198, 36);
            this.txtPresentacion.TabIndex = 124;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(200, 299);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(132, 30);
            this.labelControl1.TabIndex = 125;
            this.labelControl1.Text = "Presentacion:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseBackColor = true;
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnGuardar.Location = new System.Drawing.Point(140, 400);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(143, 48);
            this.btnGuardar.TabIndex = 126;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdHome.ImageOptions.SvgImage")));
            this.cmdHome.Location = new System.Drawing.Point(343, 400);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(143, 48);
            this.cmdHome.TabIndex = 127;
            this.cmdHome.Text = "Cancelar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // dsProduccion1
            // 
            this.dsProduccion1.DataSetName = "dsProduccion";
            this.dsProduccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vGridControl1
            // 
            this.vGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.vGridControl1.DataMember = "Bascula1";
            this.vGridControl1.DataSource = this.dsProduccion1;
            this.vGridControl1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl1.Location = new System.Drawing.Point(27, 7);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RecordWidth = 133;
            this.vGridControl1.RowHeaderWidth = 67;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.row_requisa,
            this.rowLotePT,
            this.rowmp,
            this.rowlote,
            this.rowcodigo_barra,
            this.rowunidades,
            this.rowPresentacion,
            this.rowpeso,
            this.rowpeso_bruto,
            this.rowpeso_prd,
            this.rowbascula,
            this.rowID});
            this.vGridControl1.Size = new System.Drawing.Size(583, 205);
            this.vGridControl1.TabIndex = 128;
            // 
            // row_requisa
            // 
            this.row_requisa.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row_requisa.AppearanceCell.Options.UseFont = true;
            this.row_requisa.Name = "row_requisa";
            this.row_requisa.Properties.AllowEdit = false;
            this.row_requisa.Properties.Caption = "# Requisa";
            this.row_requisa.Properties.FieldName = "#requisa";
            // 
            // rowLotePT
            // 
            this.rowLotePT.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.rowLotePT.AppearanceCell.Options.UseFont = true;
            this.rowLotePT.Name = "rowLotePT";
            this.rowLotePT.Properties.AllowEdit = false;
            this.rowLotePT.Properties.Caption = "Lote PT";
            this.rowLotePT.Properties.FieldName = "lote_pt";
            // 
            // rowmp
            // 
            this.rowmp.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.rowmp.AppearanceCell.Options.UseFont = true;
            this.rowmp.Name = "rowmp";
            this.rowmp.Properties.AllowEdit = false;
            this.rowmp.Properties.Caption = "Materia Prima";
            this.rowmp.Properties.FieldName = "mp";
            // 
            // rowlote
            // 
            this.rowlote.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.rowlote.AppearanceCell.Options.UseFont = true;
            this.rowlote.Name = "rowlote";
            this.rowlote.Properties.AllowEdit = false;
            this.rowlote.Properties.Caption = "Lote MP";
            this.rowlote.Properties.FieldName = "lote";
            // 
            // rowcodigo_barra
            // 
            this.rowcodigo_barra.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowcodigo_barra.AppearanceCell.Options.UseFont = true;
            this.rowcodigo_barra.Name = "rowcodigo_barra";
            this.rowcodigo_barra.Properties.AllowEdit = false;
            this.rowcodigo_barra.Properties.Caption = "Codigo de Barra";
            this.rowcodigo_barra.Properties.FieldName = "codigo_barra";
            this.rowcodigo_barra.Visible = false;
            // 
            // rowunidades
            // 
            this.rowunidades.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.rowunidades.AppearanceCell.Options.UseFont = true;
            this.rowunidades.Name = "rowunidades";
            this.rowunidades.Properties.AllowEdit = false;
            this.rowunidades.Properties.Caption = "Unidades";
            this.rowunidades.Properties.FieldName = "unidades";
            // 
            // rowPresentacion
            // 
            this.rowPresentacion.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rowPresentacion.AppearanceCell.Options.UseFont = true;
            this.rowPresentacion.Name = "rowPresentacion";
            this.rowPresentacion.Properties.AllowEdit = false;
            this.rowPresentacion.Properties.Caption = "Presentacion Saco";
            this.rowPresentacion.Properties.FieldName = "presentacion";
            this.rowPresentacion.Visible = false;
            // 
            // rowpeso
            // 
            this.rowpeso.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.rowpeso.AppearanceCell.Options.UseFont = true;
            this.rowpeso.Name = "rowpeso";
            this.rowpeso.Properties.AllowEdit = false;
            this.rowpeso.Properties.Caption = "Requerido en Requisa";
            this.rowpeso.Properties.FieldName = "peso";
            // 
            // rowpeso_bruto
            // 
            this.rowpeso_bruto.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.rowpeso_bruto.AppearanceCell.Options.UseFont = true;
            this.rowpeso_bruto.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowpeso_tara});
            this.rowpeso_bruto.Name = "rowpeso_bruto";
            this.rowpeso_bruto.Properties.AllowEdit = false;
            this.rowpeso_bruto.Properties.Caption = "Peso Inicial Bascula";
            this.rowpeso_bruto.Properties.FieldName = "peso_bruto";
            // 
            // rowpeso_tara
            // 
            this.rowpeso_tara.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rowpeso_tara.AppearanceCell.Options.UseFont = true;
            this.rowpeso_tara.Name = "rowpeso_tara";
            this.rowpeso_tara.Properties.AllowEdit = false;
            this.rowpeso_tara.Properties.Caption = "peso_tara";
            this.rowpeso_tara.Properties.FieldName = "peso_tara";
            this.rowpeso_tara.Visible = false;
            // 
            // rowpeso_prd
            // 
            this.rowpeso_prd.Name = "rowpeso_prd";
            this.rowpeso_prd.Properties.AllowEdit = false;
            this.rowpeso_prd.Properties.Caption = "peso_prd";
            this.rowpeso_prd.Properties.FieldName = "peso_prd";
            this.rowpeso_prd.Visible = false;
            // 
            // rowbascula
            // 
            this.rowbascula.Name = "rowbascula";
            this.rowbascula.Properties.AllowEdit = false;
            this.rowbascula.Properties.Caption = "Bascula #";
            this.rowbascula.Properties.FieldName = "bascula";
            this.rowbascula.Visible = false;
            // 
            // rowID
            // 
            this.rowID.Name = "rowID";
            this.rowID.Properties.Caption = "rowId";
            this.rowID.Properties.FieldName = "id_registro";
            this.rowID.Visible = false;
            // 
            // frmResumenToDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 457);
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtPresentacion);
            this.Controls.Add(this.txtKgAEnviar);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.lblTotalUd_en_tarima);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.txtPorEnviar);
            this.Controls.Add(this.labelControl3);
            this.Name = "frmResumenToDevolucion";
            this.Text = "Devolucion MacroIngredientes";
            ((System.ComponentModel.ISupportInitialize)(this.txtPorEnviar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKgAEnviar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPresentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnUP;
        private DevExpress.XtraEditors.LabelControl lblTotalUd_en_tarima;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnDown;
        private DevExpress.XtraEditors.TextEdit txtPorEnviar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtKgAEnviar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtPresentacion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private Produccion.dsProduccion dsProduccion1;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row_requisa;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowLotePT;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowmp;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowlote;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowcodigo_barra;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowunidades;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPresentacion;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowpeso;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowpeso_bruto;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowpeso_tara;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowpeso_prd;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowbascula;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowID;
    }
}