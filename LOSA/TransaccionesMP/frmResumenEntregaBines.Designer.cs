
namespace LOSA.TransaccionesMP
{
    partial class frmResumenEntregaBines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResumenEntregaBines));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTarimaExistencia = new DevExpress.XtraEditors.ButtonEdit();
            this.lblMPExistencia = new DevExpress.XtraEditors.LabelControl();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.rowid = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rownombreTarima = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rownombreProveedor = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowfecha_ingreso = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rownumero_transaccion = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowlote_materia_prima = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpresentacion = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowtipo_tarima = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowid_boleta = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rownum = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowIsMicro = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowitemcode = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowmp_name = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.txtExistenciaBG018 = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnEntregaPRD = new DevExpress.XtraEditors.SimpleButton();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarimaExistencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistenciaBG018.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 115;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(198, 333);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(225, 24);
            this.labelControl2.TabIndex = 116;
            this.labelControl2.Text = "Existencia en  Produccion:";
            // 
            // txtTarimaExistencia
            // 
            this.txtTarimaExistencia.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.txtTarimaExistencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTarimaExistencia.EditValue = "";
            this.txtTarimaExistencia.Enabled = false;
            this.txtTarimaExistencia.Location = new System.Drawing.Point(425, 271);
            this.txtTarimaExistencia.Name = "txtTarimaExistencia";
            this.txtTarimaExistencia.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarimaExistencia.Properties.Appearance.Options.UseFont = true;
            this.txtTarimaExistencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.txtTarimaExistencia.Properties.MaxLength = 20;
            this.txtTarimaExistencia.Properties.NullText = "Escanee o selecciona una tarima";
            this.txtTarimaExistencia.Size = new System.Drawing.Size(133, 30);
            this.txtTarimaExistencia.TabIndex = 117;
            this.txtTarimaExistencia.ToolTip = "Hola";
            // 
            // lblMPExistencia
            // 
            this.lblMPExistencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMPExistencia.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPExistencia.Appearance.Options.UseFont = true;
            this.lblMPExistencia.Location = new System.Drawing.Point(270, 214);
            this.lblMPExistencia.Name = "lblMPExistencia";
            this.lblMPExistencia.Size = new System.Drawing.Size(133, 24);
            this.lblMPExistencia.TabIndex = 118;
            this.lblMPExistencia.Text = "lblMPExistencia";
            // 
            // vGridControl1
            // 
            this.vGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vGridControl1.Appearance.RecordValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vGridControl1.Appearance.RecordValue.Options.UseFont = true;
            this.vGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.vGridControl1.DataMember = null;
            this.vGridControl1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.vGridControl1.Location = new System.Drawing.Point(3, 5);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RecordWidth = 453;
            this.vGridControl1.RowHeaderWidth = 130;
            this.vGridControl1.RowHeaderWidthChangeStep = 4;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowid,
            this.rownombreTarima,
            this.rownombreProveedor,
            this.rowfecha_ingreso,
            this.rownumero_transaccion,
            this.rowlote_materia_prima,
            this.rowpresentacion,
            this.rowtipo_tarima,
            this.rowid_boleta,
            this.rownum,
            this.rowIsMicro,
            this.rowitemcode,
            this.rowmp_name});
            this.vGridControl1.Size = new System.Drawing.Size(592, 196);
            this.vGridControl1.TabIndex = 119;
            // 
            // rowid
            // 
            this.rowid.Name = "rowid";
            this.rowid.Properties.Caption = "id";
            this.rowid.Properties.FieldName = "id";
            this.rowid.Visible = false;
            // 
            // rownombreTarima
            // 
            this.rownombreTarima.Name = "rownombreTarima";
            this.rownombreTarima.Properties.Caption = "Código Barra";
            this.rownombreTarima.Properties.FieldName = "nombreTarima";
            // 
            // rownombreProveedor
            // 
            this.rownombreProveedor.Name = "rownombreProveedor";
            this.rownombreProveedor.Properties.Caption = "Proveedor";
            this.rownombreProveedor.Properties.FieldName = "nombreProveedor";
            // 
            // rowfecha_ingreso
            // 
            this.rowfecha_ingreso.Name = "rowfecha_ingreso";
            this.rowfecha_ingreso.Properties.Caption = "Fecha Ingreso";
            this.rowfecha_ingreso.Properties.FieldName = "fecha_ingreso";
            // 
            // rownumero_transaccion
            // 
            this.rownumero_transaccion.Appearance.Options.UseTextOptions = true;
            this.rownumero_transaccion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rownumero_transaccion.Name = "rownumero_transaccion";
            this.rownumero_transaccion.Properties.Caption = "# Ingreso";
            this.rownumero_transaccion.Properties.FieldName = "numero_transaccion";
            // 
            // rowlote_materia_prima
            // 
            this.rowlote_materia_prima.Name = "rowlote_materia_prima";
            this.rowlote_materia_prima.Properties.Caption = "Lote";
            this.rowlote_materia_prima.Properties.FieldName = "lote_materia_prima";
            // 
            // rowpresentacion
            // 
            this.rowpresentacion.Name = "rowpresentacion";
            this.rowpresentacion.Properties.Caption = "Presentación";
            this.rowpresentacion.Properties.FieldName = "presentacion";
            // 
            // rowtipo_tarima
            // 
            this.rowtipo_tarima.Name = "rowtipo_tarima";
            this.rowtipo_tarima.Properties.Caption = "tipo_tarima";
            this.rowtipo_tarima.Properties.FieldName = "tipo_tarima";
            this.rowtipo_tarima.Visible = false;
            // 
            // rowid_boleta
            // 
            this.rowid_boleta.Name = "rowid_boleta";
            this.rowid_boleta.Properties.Caption = "id_boleta";
            this.rowid_boleta.Properties.FieldName = "id_boleta";
            this.rowid_boleta.Visible = false;
            // 
            // rownum
            // 
            this.rownum.Name = "rownum";
            this.rownum.Properties.Caption = "num";
            this.rownum.Properties.FieldName = "num";
            this.rownum.Visible = false;
            // 
            // rowIsMicro
            // 
            this.rowIsMicro.Name = "rowIsMicro";
            this.rowIsMicro.Properties.Caption = "Is Micro";
            this.rowIsMicro.Properties.FieldName = "IsMicro";
            this.rowIsMicro.Visible = false;
            // 
            // rowitemcode
            // 
            this.rowitemcode.Name = "rowitemcode";
            this.rowitemcode.Properties.Caption = "ItemCode";
            this.rowitemcode.Properties.FieldName = "itemcode";
            // 
            // rowmp_name
            // 
            this.rowmp_name.Name = "rowmp_name";
            this.rowmp_name.Properties.AllowEdit = false;
            this.rowmp_name.Properties.Caption = "Materia Prima";
            this.rowmp_name.Properties.FieldName = "mp_name";
            // 
            // txtExistenciaBG018
            // 
            this.txtExistenciaBG018.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.txtExistenciaBG018.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExistenciaBG018.EditValue = "";
            this.txtExistenciaBG018.Enabled = false;
            this.txtExistenciaBG018.Location = new System.Drawing.Point(425, 327);
            this.txtExistenciaBG018.Name = "txtExistenciaBG018";
            this.txtExistenciaBG018.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistenciaBG018.Properties.Appearance.Options.UseFont = true;
            this.txtExistenciaBG018.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.txtExistenciaBG018.Properties.MaxLength = 20;
            this.txtExistenciaBG018.Properties.NullText = "Escanee o selecciona una tarima";
            this.txtExistenciaBG018.Size = new System.Drawing.Size(133, 30);
            this.txtExistenciaBG018.TabIndex = 120;
            this.txtExistenciaBG018.ToolTip = "Hola";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(198, 277);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(181, 24);
            this.labelControl1.TabIndex = 121;
            this.labelControl1.Text = "Existencia en Tarima:";
            // 
            // btnEntregaPRD
            // 
            this.btnEntregaPRD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntregaPRD.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEntregaPRD.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntregaPRD.Appearance.Options.UseBackColor = true;
            this.btnEntregaPRD.Appearance.Options.UseFont = true;
            this.btnEntregaPRD.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnEntregaPRD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEntregaPRD.ImageOptions.Image")));
            this.btnEntregaPRD.Location = new System.Drawing.Point(214, 395);
            this.btnEntregaPRD.Name = "btnEntregaPRD";
            this.btnEntregaPRD.Size = new System.Drawing.Size(148, 48);
            this.btnEntregaPRD.TabIndex = 122;
            this.btnEntregaPRD.Text = "Entegar";
            this.btnEntregaPRD.Click += new System.EventHandler(this.btnEntregaPRD_Click);
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(436, 395);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(137, 48);
            this.cmdHome.TabIndex = 123;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(561, 275);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 24);
            this.labelControl3.TabIndex = 124;
            this.labelControl3.Text = "KG.";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(561, 332);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 24);
            this.labelControl4.TabIndex = 125;
            this.labelControl4.Text = "KG.";
            // 
            // frmResumenEntregaBines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 465);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.btnEntregaPRD);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtExistenciaBG018);
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.lblMPExistencia);
            this.Controls.Add(this.txtTarimaExistencia);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmResumenEntregaBines";
            this.Text = "frmResumenEntregaBines";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarimaExistencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistenciaBG018.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ButtonEdit txtTarimaExistencia;
        private DevExpress.XtraEditors.LabelControl lblMPExistencia;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowid;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rownombreTarima;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rownombreProveedor;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowfecha_ingreso;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rownumero_transaccion;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowlote_materia_prima;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowpresentacion;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowtipo_tarima;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowid_boleta;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rownum;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowIsMicro;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowitemcode;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowmp_name;
        private DevExpress.XtraEditors.ButtonEdit txtExistenciaBG018;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnEntregaPRD;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}