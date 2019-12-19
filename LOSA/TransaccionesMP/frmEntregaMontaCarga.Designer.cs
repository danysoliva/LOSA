namespace LOSA.TransaccionesMP
{
    partial class frmEntregaMontaCarga
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdDetalleMP = new DevExpress.XtraEditors.SimpleButton();
            this.cmdEntrega = new DevExpress.XtraEditors.SimpleButton();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(372, 438);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(167, 29);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Lista detalle MP";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(81, 438);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(173, 29);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Entregar Tarima";
            // 
            // cmdDetalleMP
            // 
            this.cmdDetalleMP.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDetalleMP.Appearance.Options.UseFont = true;
            this.cmdDetalleMP.Appearance.Options.UseTextOptions = true;
            this.cmdDetalleMP.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmdDetalleMP.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.cmdDetalleMP.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.cmdDetalleMP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdDetalleMP.ImageOptions.Image = global::LOSA.Properties.Resources.Checklist_icon;
            this.cmdDetalleMP.Location = new System.Drawing.Point(323, 101);
            this.cmdDetalleMP.Name = "cmdDetalleMP";
            this.cmdDetalleMP.Size = new System.Drawing.Size(274, 331);
            this.cmdDetalleMP.TabIndex = 15;
            this.cmdDetalleMP.Click += new System.EventHandler(this.cmdDetalleMP_Click);
            // 
            // cmdEntrega
            // 
            this.cmdEntrega.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEntrega.Appearance.Options.UseFont = true;
            this.cmdEntrega.Appearance.Options.UseTextOptions = true;
            this.cmdEntrega.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmdEntrega.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.cmdEntrega.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.cmdEntrega.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdEntrega.ImageOptions.Image = global::LOSA.Properties.Resources.Forklift_icon;
            this.cmdEntrega.Location = new System.Drawing.Point(25, 101);
            this.cmdEntrega.Name = "cmdEntrega";
            this.cmdEntrega.Size = new System.Drawing.Size(274, 331);
            this.cmdEntrega.TabIndex = 14;
            this.cmdEntrega.Click += new System.EventHandler(this.cmdEntrega_Click);
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(411, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(199, 71);
            this.cmdHome.TabIndex = 18;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // frmEntregaMontaCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 521);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdDetalleMP);
            this.Controls.Add(this.cmdEntrega);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEntregaMontaCarga";
            this.Text = "frmEntregaMontaCarga";
            this.Load += new System.EventHandler(this.frmEntregaMontaCarga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdDetalleMP;
        private DevExpress.XtraEditors.SimpleButton cmdEntrega;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
    }
}