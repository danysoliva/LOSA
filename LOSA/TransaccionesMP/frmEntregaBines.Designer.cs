
namespace LOSA.TransaccionesMP
{
    partial class frmEntregaBines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntregaBines));
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.txtRequisicion = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtMP1 = new DevExpress.XtraEditors.TextEdit();
            this.txtMP2 = new DevExpress.XtraEditors.TextEdit();
            this.txtMP3 = new DevExpress.XtraEditors.TextEdit();
            this.txtMP4 = new DevExpress.XtraEditors.TextEdit();
            this.lblMP1 = new DevExpress.XtraEditors.LabelControl();
            this.lblMP2 = new DevExpress.XtraEditors.LabelControl();
            this.lblMP3 = new DevExpress.XtraEditors.LabelControl();
            this.lblMP4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtRequisicion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMP1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMP2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMP3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMP4.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.cmdHome.Location = new System.Drawing.Point(617, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(129, 49);
            this.cmdHome.TabIndex = 8;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // txtRequisicion
            // 
            this.txtRequisicion.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.txtRequisicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequisicion.EditValue = "";
            this.txtRequisicion.Location = new System.Drawing.Point(195, 45);
            this.txtRequisicion.Name = "txtRequisicion";
            this.txtRequisicion.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequisicion.Properties.Appearance.Options.UseFont = true;
            this.txtRequisicion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.txtRequisicion.Properties.MaxLength = 20;
            this.txtRequisicion.Properties.NullText = "Escanee o selecciona una tarima";
            this.txtRequisicion.Size = new System.Drawing.Size(356, 44);
            this.txtRequisicion.TabIndex = 103;
            this.txtRequisicion.ToolTip = "Hola";
            this.txtRequisicion.Visible = false;
            this.txtRequisicion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRequisicion_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 48);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(173, 37);
            this.labelControl3.TabIndex = 104;
            this.labelControl3.Text = "Requisición:";
            this.labelControl3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(472, 145);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 106;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(53, 352);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(185, 155);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 107;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(472, 352);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(185, 155);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 108;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(53, 555);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(185, 155);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 109;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(472, 555);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(185, 155);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 110;
            this.pictureBox6.TabStop = false;
            // 
            // txtMP1
            // 
            this.txtMP1.Enabled = false;
            this.txtMP1.Location = new System.Drawing.Point(93, 150);
            this.txtMP1.Name = "txtMP1";
            this.txtMP1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMP1.Properties.Appearance.Options.UseFont = true;
            this.txtMP1.Properties.DisplayFormat.FormatString = "n2";
            this.txtMP1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMP1.Size = new System.Drawing.Size(107, 28);
            this.txtMP1.TabIndex = 111;
            // 
            // txtMP2
            // 
            this.txtMP2.Enabled = false;
            this.txtMP2.Location = new System.Drawing.Point(513, 150);
            this.txtMP2.Name = "txtMP2";
            this.txtMP2.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMP2.Properties.Appearance.Options.UseFont = true;
            this.txtMP2.Properties.Mask.EditMask = "n2";
            this.txtMP2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMP2.Size = new System.Drawing.Size(107, 28);
            this.txtMP2.TabIndex = 112;
            // 
            // txtMP3
            // 
            this.txtMP3.Enabled = false;
            this.txtMP3.Location = new System.Drawing.Point(93, 356);
            this.txtMP3.Name = "txtMP3";
            this.txtMP3.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMP3.Properties.Appearance.Options.UseFont = true;
            this.txtMP3.Size = new System.Drawing.Size(107, 28);
            this.txtMP3.TabIndex = 113;
            // 
            // txtMP4
            // 
            this.txtMP4.Enabled = false;
            this.txtMP4.Location = new System.Drawing.Point(513, 356);
            this.txtMP4.Name = "txtMP4";
            this.txtMP4.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMP4.Properties.Appearance.Options.UseFont = true;
            this.txtMP4.Size = new System.Drawing.Size(107, 28);
            this.txtMP4.TabIndex = 114;
            // 
            // lblMP1
            // 
            this.lblMP1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMP1.Appearance.Options.UseFont = true;
            this.lblMP1.Location = new System.Drawing.Point(53, 306);
            this.lblMP1.Name = "lblMP1";
            this.lblMP1.Size = new System.Drawing.Size(59, 25);
            this.lblMP1.TabIndex = 115;
            this.lblMP1.Text = "lblMP1";
            // 
            // lblMP2
            // 
            this.lblMP2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMP2.Appearance.Options.UseFont = true;
            this.lblMP2.Location = new System.Drawing.Point(472, 306);
            this.lblMP2.Name = "lblMP2";
            this.lblMP2.Size = new System.Drawing.Size(59, 25);
            this.lblMP2.TabIndex = 116;
            this.lblMP2.Text = "lblMP2";
            // 
            // lblMP3
            // 
            this.lblMP3.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMP3.Appearance.Options.UseFont = true;
            this.lblMP3.Location = new System.Drawing.Point(53, 513);
            this.lblMP3.Name = "lblMP3";
            this.lblMP3.Size = new System.Drawing.Size(59, 25);
            this.lblMP3.TabIndex = 117;
            this.lblMP3.Text = "lblMP3";
            // 
            // lblMP4
            // 
            this.lblMP4.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMP4.Appearance.Options.UseFont = true;
            this.lblMP4.Location = new System.Drawing.Point(472, 513);
            this.lblMP4.Name = "lblMP4";
            this.lblMP4.Size = new System.Drawing.Size(59, 25);
            this.lblMP4.TabIndex = 118;
            this.lblMP4.Text = "lblMP4";
            // 
            // frmEntregaBines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 757);
            this.Controls.Add(this.lblMP4);
            this.Controls.Add(this.lblMP3);
            this.Controls.Add(this.lblMP2);
            this.Controls.Add(this.lblMP1);
            this.Controls.Add(this.txtMP4);
            this.Controls.Add(this.txtMP3);
            this.Controls.Add(this.txtMP2);
            this.Controls.Add(this.txtMP1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtRequisicion);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmdHome);
            this.MaximizeBox = false;
            this.Name = "frmEntregaBines";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.txtRequisicion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMP1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMP2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMP3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMP4.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.ButtonEdit txtRequisicion;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.TextEdit txtMP1;
        private DevExpress.XtraEditors.TextEdit txtMP2;
        private DevExpress.XtraEditors.TextEdit txtMP3;
        private DevExpress.XtraEditors.TextEdit txtMP4;
        private DevExpress.XtraEditors.LabelControl lblMP1;
        private DevExpress.XtraEditors.LabelControl lblMP2;
        private DevExpress.XtraEditors.LabelControl lblMP3;
        private DevExpress.XtraEditors.LabelControl lblMP4;
    }
}