namespace LOSA.Produccion
{
    partial class frmAddTarimaPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTarimaPT));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumTransaccion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaProduccion = new DevExpress.XtraEditors.DateEdit();
            this.dtFechaVence = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtDias = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtLote = new DevExpress.XtraEditors.TextEdit();
            this.txtPesoKg = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnidades = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidadTarimasTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductoName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPresentacion = new DevExpress.XtraEditors.TextEdit();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumTransaccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaProduccion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaProduccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVence.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVence.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesoKg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadTarimasTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductoName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPresentacion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(0, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(801, 40);
            this.labelControl1.TabIndex = 32;
            this.labelControl1.Text = "Registro de Tarima #Lote PT";
            // 
            // txtNumTransaccion
            // 
            this.txtNumTransaccion.EditValue = "";
            this.txtNumTransaccion.Location = new System.Drawing.Point(221, 117);
            this.txtNumTransaccion.Name = "txtNumTransaccion";
            this.txtNumTransaccion.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTransaccion.Properties.Appearance.Options.UseFont = true;
            this.txtNumTransaccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumTransaccion.Properties.ReadOnly = true;
            this.txtNumTransaccion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumTransaccion.Size = new System.Drawing.Size(170, 36);
            this.txtNumTransaccion.TabIndex = 43;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 124);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(151, 29);
            this.labelControl6.TabIndex = 42;
            this.labelControl6.Text = "# Transacción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "Fecha Producción";
            // 
            // dtFechaProduccion
            // 
            this.dtFechaProduccion.EditValue = null;
            this.dtFechaProduccion.Location = new System.Drawing.Point(221, 170);
            this.dtFechaProduccion.Name = "dtFechaProduccion";
            this.dtFechaProduccion.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaProduccion.Properties.Appearance.Options.UseFont = true;
            this.dtFechaProduccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaProduccion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaProduccion.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaProduccion.Properties.MinValue = new System.DateTime(2019, 11, 1, 0, 0, 0, 0);
            this.dtFechaProduccion.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaProduccion.Size = new System.Drawing.Size(170, 36);
            this.dtFechaProduccion.TabIndex = 45;
            // 
            // dtFechaVence
            // 
            this.dtFechaVence.EditValue = null;
            this.dtFechaVence.Location = new System.Drawing.Point(221, 268);
            this.dtFechaVence.Name = "dtFechaVence";
            this.dtFechaVence.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaVence.Properties.Appearance.Options.UseFont = true;
            this.dtFechaVence.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaVence.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaVence.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaVence.Properties.MinValue = new System.DateTime(2019, 11, 1, 0, 0, 0, 0);
            this.dtFechaVence.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaVence.Size = new System.Drawing.Size(170, 36);
            this.dtFechaVence.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 29);
            this.label2.TabIndex = 46;
            this.label2.Text = "Fecha Vencimiento";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(12, 223);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(181, 29);
            this.labelControl7.TabIndex = 49;
            this.labelControl7.Text = "Dias de duración";
            // 
            // txtDias
            // 
            this.txtDias.EditValue = "49";
            this.txtDias.Location = new System.Drawing.Point(221, 220);
            this.txtDias.Name = "txtDias";
            this.txtDias.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.Properties.Appearance.Options.UseFont = true;
            this.txtDias.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDias.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDias.Size = new System.Drawing.Size(170, 36);
            this.txtDias.TabIndex = 48;
            this.txtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDias_KeyPress);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(438, 271);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(110, 29);
            this.labelControl10.TabIndex = 51;
            this.labelControl10.Text = " # Lote PT";
            this.labelControl10.Click += new System.EventHandler(this.labelControl10_Click);
            // 
            // txtLote
            // 
            this.txtLote.EditValue = "";
            this.txtLote.Location = new System.Drawing.Point(554, 268);
            this.txtLote.Name = "txtLote";
            this.txtLote.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Properties.Appearance.Options.UseFont = true;
            this.txtLote.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLote.Size = new System.Drawing.Size(238, 36);
            this.txtLote.TabIndex = 50;
            // 
            // txtPesoKg
            // 
            this.txtPesoKg.EditValue = "0";
            this.txtPesoKg.Enabled = false;
            this.txtPesoKg.Location = new System.Drawing.Point(554, 224);
            this.txtPesoKg.Name = "txtPesoKg";
            this.txtPesoKg.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoKg.Properties.Appearance.Options.UseFont = true;
            this.txtPesoKg.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesoKg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPesoKg.Size = new System.Drawing.Size(238, 36);
            this.txtPesoKg.TabIndex = 58;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(438, 227);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(92, 29);
            this.labelControl12.TabIndex = 57;
            this.labelControl12.Text = "Peso Kg";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(438, 173);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 29);
            this.labelControl2.TabIndex = 56;
            this.labelControl2.Text = "Unidades";
            // 
            // txtUnidades
            // 
            this.txtUnidades.EditValue = "0";
            this.txtUnidades.Location = new System.Drawing.Point(554, 170);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidades.Properties.Appearance.Options.UseFont = true;
            this.txtUnidades.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUnidades.Size = new System.Drawing.Size(238, 36);
            this.txtUnidades.TabIndex = 55;
            this.txtUnidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnidades_KeyPress);
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Location = new System.Drawing.Point(430, 411);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(251, 31);
            this.labelControl13.TabIndex = 60;
            this.labelControl13.Text = "Cantidad de Tarimas";
            // 
            // txtCantidadTarimasTotal
            // 
            this.txtCantidadTarimasTotal.EditValue = "1";
            this.txtCantidadTarimasTotal.Location = new System.Drawing.Point(687, 408);
            this.txtCantidadTarimasTotal.Name = "txtCantidadTarimasTotal";
            this.txtCantidadTarimasTotal.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadTarimasTotal.Properties.Appearance.Options.UseFont = true;
            this.txtCantidadTarimasTotal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantidadTarimasTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCantidadTarimasTotal.Size = new System.Drawing.Size(102, 38);
            this.txtCantidadTarimasTotal.TabIndex = 59;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 324);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(97, 29);
            this.labelControl3.TabIndex = 62;
            this.labelControl3.Text = "Producto";
            // 
            // txtProductoName
            // 
            this.txtProductoName.EditValue = "";
            this.txtProductoName.Location = new System.Drawing.Point(115, 321);
            this.txtProductoName.Name = "txtProductoName";
            this.txtProductoName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtProductoName.Properties.Appearance.Options.UseFont = true;
            this.txtProductoName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProductoName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductoName.Size = new System.Drawing.Size(276, 36);
            this.txtProductoName.TabIndex = 61;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(407, 324);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(141, 29);
            this.labelControl4.TabIndex = 64;
            this.labelControl4.Text = "Presentación";
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.EditValue = "";
            this.txtPresentacion.Location = new System.Drawing.Point(554, 321);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresentacion.Properties.Appearance.Options.UseFont = true;
            this.txtPresentacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPresentacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPresentacion.Size = new System.Drawing.Size(238, 36);
            this.txtPresentacion.TabIndex = 63;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(185, 48);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(167, 47);
            this.cmdGuardar.TabIndex = 29;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(12, 48);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(167, 47);
            this.btnAtras.TabIndex = 30;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmAddTarimaPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 560);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtPresentacion);
            this.Controls.Add(this.dtFechaVence);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtProductoName);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.txtCantidadTarimasTotal);
            this.Controls.Add(this.txtPesoKg);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFechaProduccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumTransaccion);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddTarimaPT";
            this.Text = "frmAddTarimaPT";
            ((System.ComponentModel.ISupportInitialize)(this.txtNumTransaccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaProduccion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaProduccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVence.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVence.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesoKg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadTarimasTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductoName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPresentacion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.TextEdit txtNumTransaccion;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dtFechaProduccion;
        private DevExpress.XtraEditors.DateEdit dtFechaVence;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtDias;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtLote;
        private DevExpress.XtraEditors.TextEdit txtPesoKg;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtUnidades;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtCantidadTarimasTotal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtProductoName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtPresentacion;
    }
}