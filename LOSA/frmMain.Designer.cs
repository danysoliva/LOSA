using DevExpress.XtraEditors;

namespace LOSA
{
    partial class frmMain
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
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtClave = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmdButtonSaltarLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.Location = new System.Drawing.Point(433, 281);
            this.cmdCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(265, 87);
            this.cmdCerrar.TabIndex = 3;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdLogin
            // 
            this.cmdLogin.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdLogin.Appearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.cmdLogin.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.Appearance.Options.UseBackColor = true;
            this.cmdLogin.Appearance.Options.UseBorderColor = true;
            this.cmdLogin.Appearance.Options.UseFont = true;
            this.cmdLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdLogin.Location = new System.Drawing.Point(160, 281);
            this.cmdLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(265, 87);
            this.cmdLogin.TabIndex = 2;
            this.cmdLogin.Text = "Ingresar";
            this.cmdLogin.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(252, 203);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtClave.Properties.Appearance.Options.UseFont = true;
            this.txtClave.Properties.ContextImageOptions.Image = global::LOSA.Properties.Resources.key;
            this.txtClave.Properties.UseSystemPasswordChar = true;
            this.txtClave.Size = new System.Drawing.Size(296, 36);
            this.txtClave.TabIndex = 1;
            this.txtClave.Enter += new System.EventHandler(this.txtClave_Enter);
            this.txtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClave_KeyDown);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(252, 132);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.txtUsuario.Properties.ContextImageOptions.Image = global::LOSA.Properties.Resources.user;
            this.txtUsuario.Size = new System.Drawing.Size(296, 36);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(159, 135);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 29);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Usuario";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(163, 207);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 29);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Clave";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // cmdButtonSaltarLogin
            // 
            this.cmdButtonSaltarLogin.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.cmdButtonSaltarLogin.Appearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.cmdButtonSaltarLogin.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdButtonSaltarLogin.Appearance.Options.UseBackColor = true;
            this.cmdButtonSaltarLogin.Appearance.Options.UseBorderColor = true;
            this.cmdButtonSaltarLogin.Appearance.Options.UseFont = true;
            this.cmdButtonSaltarLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdButtonSaltarLogin.Location = new System.Drawing.Point(299, 389);
            this.cmdButtonSaltarLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdButtonSaltarLogin.Name = "cmdButtonSaltarLogin";
            this.cmdButtonSaltarLogin.Size = new System.Drawing.Size(265, 87);
            this.cmdButtonSaltarLogin.TabIndex = 11;
            this.cmdButtonSaltarLogin.Text = "Montacarga";
            this.cmdButtonSaltarLogin.Click += new System.EventHandler(this.cmdButtonSaltarLogin_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(163, 76);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(536, 33);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Bienvenido";
            this.labelControl3.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LOSA.Properties.Resources.Users_Group_icon64px;
            this.pictureBox1.Location = new System.Drawing.Point(567, 124);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(146, 493);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(61, 17);
            this.lblVersion.TabIndex = 13;
            this.lblVersion.Text = "Ninguna";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 689);
            this.ControlBox = false;
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmdButtonSaltarLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.cmdCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Click += new System.EventHandler(this.frmMain_Click);
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdLogin;
        private DevExpress.XtraEditors.TextEdit txtClave;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton cmdButtonSaltarLogin;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Label lblVersion;
    }
}

