
namespace LOSA.Finanzas
{
    partial class frmExoneracionAQ_OP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExoneracionAQ_OP));
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdConfirma = new DevExpress.XtraEditors.SimpleButton();
            this.lblTipoOp = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAnio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaInicio = new DevExpress.XtraEditors.DateEdit();
            this.dtFechaFin = new DevExpress.XtraEditors.DateEdit();
            this.txtResolucion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResolucion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.Salmon;
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdCerrar.ImageOptions.SvgImage")));
            this.cmdCerrar.Location = new System.Drawing.Point(260, 314);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(145, 46);
            this.cmdCerrar.TabIndex = 10;
            this.cmdCerrar.Text = "Cerrar";
            // 
            // cmdConfirma
            // 
            this.cmdConfirma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdConfirma.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.cmdConfirma.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConfirma.Appearance.Options.UseBackColor = true;
            this.cmdConfirma.Appearance.Options.UseFont = true;
            this.cmdConfirma.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdConfirma.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdConfirma.ImageOptions.SvgImage")));
            this.cmdConfirma.Location = new System.Drawing.Point(64, 314);
            this.cmdConfirma.Name = "cmdConfirma";
            this.cmdConfirma.Size = new System.Drawing.Size(145, 46);
            this.cmdConfirma.TabIndex = 9;
            this.cmdConfirma.Text = "Guardar";
            this.cmdConfirma.Click += new System.EventHandler(this.cmdConfirma_Click);
            // 
            // lblTipoOp
            // 
            this.lblTipoOp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipoOp.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoOp.Appearance.Options.UseFont = true;
            this.lblTipoOp.Location = new System.Drawing.Point(101, 12);
            this.lblTipoOp.Name = "lblTipoOp";
            this.lblTipoOp.Size = new System.Drawing.Size(246, 25);
            this.lblTipoOp.TabIndex = 14;
            this.lblTipoOp.Text = "Creacion Exoneracion Fiscal";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(101, 138);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(126, 21);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Año______________";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(198, 135);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAnio.Properties.Appearance.Options.UseFont = true;
            this.txtAnio.Size = new System.Drawing.Size(106, 28);
            this.txtAnio.TabIndex = 16;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(101, 197);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(109, 21);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Fecha Inicio____";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(100, 253);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(105, 21);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Fecha Final____";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.EditValue = null;
            this.dtFechaInicio.Location = new System.Drawing.Point(198, 194);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtFechaInicio.Properties.Appearance.Options.UseFont = true;
            this.dtFechaInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaInicio.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dtFechaInicio.Properties.DisplayFormat.FormatString = "";
            this.dtFechaInicio.Properties.EditFormat.FormatString = "";
            this.dtFechaInicio.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.dtFechaInicio.Properties.MaskSettings.Set("mask", "d");
            this.dtFechaInicio.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.dtFechaInicio.Properties.UseMaskAsDisplayFormat = true;
            this.dtFechaInicio.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaInicio.Size = new System.Drawing.Size(149, 28);
            this.dtFechaInicio.TabIndex = 21;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.EditValue = null;
            this.dtFechaFin.Location = new System.Drawing.Point(198, 250);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtFechaFin.Properties.Appearance.Options.UseFont = true;
            this.dtFechaFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaFin.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dtFechaFin.Properties.DisplayFormat.FormatString = "";
            this.dtFechaFin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFechaFin.Properties.EditFormat.FormatString = "";
            this.dtFechaFin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFechaFin.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.dtFechaFin.Properties.MaskSettings.Set("mask", "d");
            this.dtFechaFin.Properties.UseMaskAsDisplayFormat = true;
            this.dtFechaFin.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaFin.Size = new System.Drawing.Size(149, 28);
            this.dtFechaFin.TabIndex = 22;
            // 
            // txtResolucion
            // 
            this.txtResolucion.Location = new System.Drawing.Point(198, 80);
            this.txtResolucion.Name = "txtResolucion";
            this.txtResolucion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtResolucion.Properties.Appearance.Options.UseFont = true;
            this.txtResolucion.Size = new System.Drawing.Size(149, 28);
            this.txtResolucion.TabIndex = 23;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(100, 83);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(174, 21);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "Resolucion______________";
            // 
            // frmExoneracionAQ_OP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 383);
            this.Controls.Add(this.txtResolucion);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.dtFechaInicio);
            this.Controls.Add(this.dtFechaFin);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblTipoOp);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdConfirma);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExoneracionAQ_OP";
            ((System.ComponentModel.ISupportInitialize)(this.txtAnio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResolucion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdConfirma;
        private DevExpress.XtraEditors.LabelControl lblTipoOp;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtAnio;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dtFechaInicio;
        private DevExpress.XtraEditors.DateEdit dtFechaFin;
        private DevExpress.XtraEditors.TextEdit txtResolucion;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}