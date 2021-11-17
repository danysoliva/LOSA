
namespace LOSA.MicroIngredientes
{
    partial class xfrmPesajeIndividual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmPesajeIndividual));
            this.lueBascula = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSum10 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.seBatch = new DevExpress.XtraEditors.SpinEdit();
            this.lblMensaje = new DevExpress.XtraEditors.LabelControl();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.btnGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.pesajeBasculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMicros = new LOSA.MicroIngredientes.dsMicros();
            this.Bascula1 = new DevExpress.XtraEditors.SimpleButton();
            this.Bascula2 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdDown = new DevExpress.XtraEditors.SimpleButton();
            this.cmdUp = new DevExpress.XtraEditors.SimpleButton();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lueBascula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seBatch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesajeBasculaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicros)).BeginInit();
            this.SuspendLayout();
            // 
            // lueBascula
            // 
            this.lueBascula.Location = new System.Drawing.Point(446, -1);
            this.lueBascula.Name = "lueBascula";
            this.lueBascula.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.lueBascula.Properties.Appearance.Options.UseFont = true;
            this.lueBascula.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueBascula.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueBascula.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueBascula.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueBascula.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBascula.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Descripción"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("peso", "Peso", 41, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.False)});
            this.lueBascula.Properties.DataSource = this.pesajeBasculaBindingSource;
            this.lueBascula.Properties.DisplayMember = "descripcion";
            this.lueBascula.Properties.NullText = "";
            this.lueBascula.Properties.ValueMember = "id_bascula";
            this.lueBascula.Size = new System.Drawing.Size(173, 30);
            this.lueBascula.TabIndex = 8;
            this.lueBascula.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bascula";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(331, 268);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 44);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "-10";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdSum10
            // 
            this.cmdSum10.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSum10.Appearance.Options.UseFont = true;
            this.cmdSum10.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSum10.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdSum10.Location = new System.Drawing.Point(331, 182);
            this.cmdSum10.Name = "cmdSum10";
            this.cmdSum10.Size = new System.Drawing.Size(75, 44);
            this.cmdSum10.TabIndex = 14;
            this.cmdSum10.Text = "+10";
            this.cmdSum10.Click += new System.EventHandler(this.cmdSum10_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 235);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(220, 19);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Cantidad de Batch a pesar:";
            // 
            // seBatch
            // 
            this.seBatch.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seBatch.Location = new System.Drawing.Point(235, 232);
            this.seBatch.Name = "seBatch";
            this.seBatch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seBatch.Properties.Appearance.Options.UseFont = true;
            this.seBatch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seBatch.Properties.IsFloatValue = false;
            this.seBatch.Properties.Mask.EditMask = "N00";
            this.seBatch.Properties.MaxValue = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.seBatch.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seBatch.Size = new System.Drawing.Size(171, 30);
            this.seBatch.TabIndex = 10;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Appearance.Options.UseFont = true;
            this.lblMensaje.Appearance.Options.UseForeColor = true;
            this.lblMensaje.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblMensaje.Location = new System.Drawing.Point(412, 230);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(178, 36);
            this.lblMensaje.TabIndex = 16;
            this.lblMensaje.Text = "Excede la cantidad de batch planificado";
            this.lblMensaje.Visible = false;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarControl1.Location = new System.Drawing.Point(0, 421);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(631, 18);
            this.progressBarControl1.TabIndex = 18;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Appearance.Options.UseFont = true;
            this.btnGenerar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnGenerar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGenerar.ImageOptions.SvgImage")));
            this.btnGenerar.Location = new System.Drawing.Point(220, 348);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 63);
            this.btnGenerar.TabIndex = 17;
            this.btnGenerar.Text = "Iniciar";
            this.btnGenerar.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // pesajeBasculaBindingSource
            // 
            this.pesajeBasculaBindingSource.DataMember = "Pesaje_Bascula";
            this.pesajeBasculaBindingSource.DataSource = this.dsMicros;
            // 
            // dsMicros
            // 
            this.dsMicros.DataSetName = "dsMicros";
            this.dsMicros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Bascula1
            // 
            this.Bascula1.Appearance.BackColor = System.Drawing.Color.White;
            this.Bascula1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bascula1.Appearance.Options.UseBackColor = true;
            this.Bascula1.Appearance.Options.UseFont = true;
            this.Bascula1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.Bascula1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Bascula1.ImageOptions.Image")));
            this.Bascula1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.Bascula1.Location = new System.Drawing.Point(131, 53);
            this.Bascula1.Name = "Bascula1";
            this.Bascula1.Size = new System.Drawing.Size(164, 103);
            this.Bascula1.TabIndex = 20;
            this.Bascula1.Text = "Bascula 1";
            this.Bascula1.Click += new System.EventHandler(this.Bascula1_Click);
            // 
            // Bascula2
            // 
            this.Bascula2.Appearance.BackColor = System.Drawing.Color.White;
            this.Bascula2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Bascula2.Appearance.Options.UseBackColor = true;
            this.Bascula2.Appearance.Options.UseFont = true;
            this.Bascula2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.Bascula2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Bascula2.ImageOptions.Image")));
            this.Bascula2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.Bascula2.Location = new System.Drawing.Point(331, 53);
            this.Bascula2.Name = "Bascula2";
            this.Bascula2.Size = new System.Drawing.Size(164, 103);
            this.Bascula2.TabIndex = 19;
            this.Bascula2.Text = "Bascula 2";
            this.Bascula2.Click += new System.EventHandler(this.Bascula2_Click);
            // 
            // cmdDown
            // 
            this.cmdDown.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdDown.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdDown.ImageOptions.Image")));
            this.cmdDown.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdDown.Location = new System.Drawing.Point(235, 268);
            this.cmdDown.Name = "cmdDown";
            this.cmdDown.Size = new System.Drawing.Size(75, 44);
            this.cmdDown.TabIndex = 13;
            this.cmdDown.Text = "simpleButton2";
            this.cmdDown.Click += new System.EventHandler(this.cmdDown_Click);
            // 
            // cmdUp
            // 
            this.cmdUp.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdUp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdUp.ImageOptions.Image")));
            this.cmdUp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdUp.Location = new System.Drawing.Point(235, 182);
            this.cmdUp.Name = "cmdUp";
            this.cmdUp.Size = new System.Drawing.Size(75, 44);
            this.cmdUp.TabIndex = 12;
            this.cmdUp.Text = "simpleButton1";
            this.cmdUp.Click += new System.EventHandler(this.cmdUp_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Appearance.Options.UseFont = true;
            this.cmdClose.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdClose.Location = new System.Drawing.Point(331, 348);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 63);
            this.cmdClose.TabIndex = 7;
            this.cmdClose.Text = "Cerrar";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // xfrmPesajeIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 439);
            this.Controls.Add(this.Bascula1);
            this.Controls.Add(this.Bascula2);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdSum10);
            this.Controls.Add(this.cmdDown);
            this.Controls.Add(this.cmdUp);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.seBatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lueBascula);
            this.Controls.Add(this.cmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "xfrmPesajeIndividual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xfrmSelectBascula";
            this.Load += new System.EventHandler(this.xfrmPesajeIndividual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lueBascula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seBatch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesajeBasculaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.LookUpEdit lueBascula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource pesajeBasculaBindingSource;
        private dsMicros dsMicros;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton cmdSum10;
        private DevExpress.XtraEditors.SimpleButton cmdDown;
        private DevExpress.XtraEditors.SimpleButton cmdUp;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit seBatch;
        private DevExpress.XtraEditors.LabelControl lblMensaje;
        private DevExpress.XtraEditors.SimpleButton btnGenerar;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.SimpleButton Bascula2;
        private DevExpress.XtraEditors.SimpleButton Bascula1;
    }
}