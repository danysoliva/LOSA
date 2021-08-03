
namespace LOSA.Trazabilidad
{
    partial class frmMantoProveedoresMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantoProveedoresMP));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabAdjuntos = new DevExpress.XtraTab.XtraTabPage();
            this.TabPlantas = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreF = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtRTN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmdBuscarProveedores = new DevExpress.XtraEditors.SimpleButton();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigodeProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombredeProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreForaneo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRTN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.TabAdjuntos.SuspendLayout();
            this.TabPlantas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(1, 134);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TabAdjuntos;
            this.xtraTabControl1.Size = new System.Drawing.Size(845, 425);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPlantas,
            this.TabAdjuntos});
            // 
            // TabAdjuntos
            // 
            this.TabAdjuntos.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.TabAdjuntos.Appearance.Header.Options.UseFont = true;
            this.TabAdjuntos.Controls.Add(this.simpleButton1);
            this.TabAdjuntos.Controls.Add(this.gridControl2);
            this.TabAdjuntos.Name = "TabAdjuntos";
            this.TabAdjuntos.Size = new System.Drawing.Size(839, 390);
            this.TabAdjuntos.Text = "Datos Adjuntos";
            // 
            // TabPlantas
            // 
            this.TabPlantas.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPlantas.Appearance.Header.Options.UseFont = true;
            this.TabPlantas.Controls.Add(this.gridControl1);
            this.TabPlantas.Name = "TabPlantas";
            this.TabPlantas.Size = new System.Drawing.Size(839, 390);
            this.TabPlantas.Text = "Plantas";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 20);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(127, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Size = new System.Drawing.Size(344, 26);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(127, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(344, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 20);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Nombre";
            // 
            // txtNombreF
            // 
            this.txtNombreF.Enabled = false;
            this.txtNombreF.Location = new System.Drawing.Point(127, 72);
            this.txtNombreF.Name = "txtNombreF";
            this.txtNombreF.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtNombreF.Properties.Appearance.Options.UseFont = true;
            this.txtNombreF.Size = new System.Drawing.Size(344, 26);
            this.txtNombreF.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(10, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(113, 20);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Nombre Foraneo";
            // 
            // txtRTN
            // 
            this.txtRTN.Enabled = false;
            this.txtRTN.Location = new System.Drawing.Point(127, 104);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtRTN.Properties.Appearance.Options.UseFont = true;
            this.txtRTN.Size = new System.Drawing.Size(344, 26);
            this.txtRTN.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(10, 105);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 20);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "RTN";
            // 
            // cmdBuscarProveedores
            // 
            this.cmdBuscarProveedores.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdBuscarProveedores.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscarProveedores.Appearance.Options.UseBackColor = true;
            this.cmdBuscarProveedores.Appearance.Options.UseFont = true;
            this.cmdBuscarProveedores.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdBuscarProveedores.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdProveedores.ImageOptions.SvgImage")));
            this.cmdBuscarProveedores.Location = new System.Drawing.Point(477, 12);
            this.cmdBuscarProveedores.Name = "cmdBuscarProveedores";
            this.cmdBuscarProveedores.Size = new System.Drawing.Size(142, 51);
            this.cmdBuscarProveedores.TabIndex = 9;
            this.cmdBuscarProveedores.Text = "Buscar";
            this.cmdBuscarProveedores.Click += new System.EventHandler(this.cmdBuscarProveedores_Click);
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(714, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(127, 51);
            this.cmdHome.TabIndex = 10;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "proveedores_master";
            this.gridControl1.Location = new System.Drawing.Point(3, 61);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(833, 326);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigodeProveedor,
            this.colNombredeProveedor,
            this.colNombreForaneo,
            this.colRTN});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // colCodigodeProveedor
            // 
            this.colCodigodeProveedor.FieldName = "Codigo de Proveedor";
            this.colCodigodeProveedor.Name = "colCodigodeProveedor";
            this.colCodigodeProveedor.OptionsColumn.AllowEdit = false;
            this.colCodigodeProveedor.Visible = true;
            this.colCodigodeProveedor.VisibleIndex = 0;
            this.colCodigodeProveedor.Width = 122;
            // 
            // colNombredeProveedor
            // 
            this.colNombredeProveedor.FieldName = "Nombre de Proveedor";
            this.colNombredeProveedor.Name = "colNombredeProveedor";
            this.colNombredeProveedor.OptionsColumn.AllowEdit = false;
            this.colNombredeProveedor.Visible = true;
            this.colNombredeProveedor.VisibleIndex = 1;
            this.colNombredeProveedor.Width = 232;
            // 
            // colNombreForaneo
            // 
            this.colNombreForaneo.FieldName = "Nombre Foraneo";
            this.colNombreForaneo.Name = "colNombreForaneo";
            this.colNombreForaneo.OptionsColumn.AllowEdit = false;
            this.colNombreForaneo.Visible = true;
            this.colNombreForaneo.VisibleIndex = 2;
            this.colNombreForaneo.Width = 305;
            // 
            // colRTN
            // 
            this.colRTN.FieldName = "RTN";
            this.colRTN.Name = "colRTN";
            this.colRTN.OptionsColumn.AllowEdit = false;
            this.colRTN.Visible = true;
            this.colRTN.VisibleIndex = 3;
            this.colRTN.Width = 161;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataMember = "proveedores_master";
            this.gridControl2.Location = new System.Drawing.Point(6, 64);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(833, 326);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Codigo de Proveedor";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 122;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Nombre de Proveedor";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 232;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "Nombre Foraneo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 305;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "RTN";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 161;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(692, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(142, 51);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Nuevo Adjunto";
            // 
            // frmMantoProveedoresMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 560);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.cmdBuscarProveedores);
            this.Controls.Add(this.txtRTN);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtNombreF);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "frmMantoProveedoresMP";
            this.Text = "Master Proveedores MP";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.TabAdjuntos.ResumeLayout(false);
            this.TabPlantas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TabAdjuntos;
        private DevExpress.XtraTab.XtraTabPage TabPlantas;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNombreF;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtRTN;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton cmdBuscarProveedores;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigodeProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colNombredeProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreForaneo;
        private DevExpress.XtraGrid.Columns.GridColumn colRTN;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}