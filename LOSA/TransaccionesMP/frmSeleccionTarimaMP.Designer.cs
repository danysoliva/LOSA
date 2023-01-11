
namespace LOSA.TransaccionesMP
{
    partial class frmSeleccionTarimaMP
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
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.grdtarimas = new DevExpress.XtraGrid.GridControl();
            this.grdvtarimas = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdtarimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvtarimas)).BeginInit();
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
            this.cmdHome.Location = new System.Drawing.Point(659, 3);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(129, 49);
            this.cmdHome.TabIndex = 9;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // grdtarimas
            // 
            this.grdtarimas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdtarimas.Location = new System.Drawing.Point(2, 81);
            this.grdtarimas.MainView = this.grdvtarimas;
            this.grdtarimas.Name = "grdtarimas";
            this.grdtarimas.Size = new System.Drawing.Size(786, 292);
            this.grdtarimas.TabIndex = 10;
            this.grdtarimas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvtarimas});
            // 
            // grdvtarimas
            // 
            this.grdvtarimas.GridControl = this.grdtarimas;
            this.grdvtarimas.Name = "grdvtarimas";
            this.grdvtarimas.OptionsView.ShowGroupPanel = false;
            // 
            // frmSeleccionTarimaMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 375);
            this.ControlBox = false;
            this.Controls.Add(this.grdtarimas);
            this.Controls.Add(this.cmdHome);
            this.Name = "frmSeleccionTarimaMP";
            ((System.ComponentModel.ISupportInitialize)(this.grdtarimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvtarimas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraGrid.GridControl grdtarimas;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvtarimas;
    }
}