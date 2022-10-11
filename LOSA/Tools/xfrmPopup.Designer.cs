
namespace LOSA.Tools
{
    partial class xfrmPopup
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
            this.tpLeidas = new DevExpress.XtraBars.Navigation.TabPane();
            this.tnpSinLeer = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tnpLeidas = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.tpLeidas)).BeginInit();
            this.tpLeidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpLeidas
            // 
            this.tpLeidas.Controls.Add(this.tnpSinLeer);
            this.tpLeidas.Controls.Add(this.tnpLeidas);
            this.tpLeidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpLeidas.Location = new System.Drawing.Point(0, 0);
            this.tpLeidas.Name = "tpLeidas";
            this.tpLeidas.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tnpSinLeer,
            this.tnpLeidas});
            this.tpLeidas.RegularSize = new System.Drawing.Size(565, 291);
            this.tpLeidas.SelectedPage = this.tnpLeidas;
            this.tpLeidas.Size = new System.Drawing.Size(565, 291);
            this.tpLeidas.TabIndex = 0;
            this.tpLeidas.Text = "tabPane1";
            // 
            // tnpSinLeer
            // 
            this.tnpSinLeer.Caption = "Sin Leer";
            this.tnpSinLeer.Name = "tnpSinLeer";
            this.tnpSinLeer.Size = new System.Drawing.Size(565, 264);
            // 
            // tnpLeidas
            // 
            this.tnpLeidas.Caption = "Leidas";
            this.tnpLeidas.Name = "tnpLeidas";
            this.tnpLeidas.Size = new System.Drawing.Size(565, 264);
            // 
            // xfrmPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 291);
            this.Controls.Add(this.tpLeidas);
            this.Name = "xfrmPopup";
            this.Text = "xfrmPopup";
            ((System.ComponentModel.ISupportInitialize)(this.tpLeidas)).EndInit();
            this.tpLeidas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tpLeidas;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpSinLeer;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpLeidas;
    }
}