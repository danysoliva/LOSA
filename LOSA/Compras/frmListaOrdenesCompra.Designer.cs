
namespace LOSA.Compras
{
    partial class frmListaOrdenesCompra
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabAutorizaciones = new DevExpress.XtraTab.XtraTabPage();
            this.TabHistorica = new DevExpress.XtraTab.XtraTabPage();
            this.grdAutorizadas = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.TabAutorizaciones.SuspendLayout();
            this.TabHistorica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAutorizadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TabAutorizaciones;
            this.xtraTabControl1.Size = new System.Drawing.Size(1374, 818);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabAutorizaciones,
            this.TabHistorica});
            // 
            // TabAutorizaciones
            // 
            this.TabAutorizaciones.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabAutorizaciones.Appearance.Header.Options.UseFont = true;
            this.TabAutorizaciones.Appearance.HeaderActive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabAutorizaciones.Appearance.HeaderActive.Options.UseFont = true;
            this.TabAutorizaciones.Controls.Add(this.grdAutorizadas);
            this.TabAutorizaciones.Name = "TabAutorizaciones";
            this.TabAutorizaciones.Size = new System.Drawing.Size(1372, 789);
            this.TabAutorizaciones.Text = "Autorizadas Pendientes de Imprimir";
            // 
            // TabHistorica
            // 
            this.TabHistorica.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabHistorica.Appearance.Header.Options.UseFont = true;
            this.TabHistorica.Appearance.HeaderActive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabHistorica.Appearance.HeaderActive.Options.UseFont = true;
            this.TabHistorica.Controls.Add(this.gridControl2);
            this.TabHistorica.Name = "TabHistorica";
            this.TabHistorica.Size = new System.Drawing.Size(1372, 789);
            this.TabHistorica.Text = "Historial Ordenes de Compra";
            // 
            // grdAutorizadas
            // 
            this.grdAutorizadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAutorizadas.Location = new System.Drawing.Point(3, 68);
            this.grdAutorizadas.MainView = this.gridView1;
            this.grdAutorizadas.Name = "grdAutorizadas";
            this.grdAutorizadas.Size = new System.Drawing.Size(1366, 718);
            this.grdAutorizadas.TabIndex = 0;
            this.grdAutorizadas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdAutorizadas;
            this.gridView1.Name = "gridView1";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(3, 68);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1366, 718);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // frmListaOrdenesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 818);
            this.Controls.Add(this.xtraTabControl1);
            this.IsMdiContainer = true;
            this.Name = "frmListaOrdenesCompra";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.TabAutorizaciones.ResumeLayout(false);
            this.TabHistorica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAutorizadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TabAutorizaciones;
        private DevExpress.XtraGrid.GridControl grdAutorizadas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage TabHistorica;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}