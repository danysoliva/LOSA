
namespace LOSA.Calidad.Parametros
{
    partial class frmPickParametrs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPickParametrs));
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsParametros = new LOSA.Calidad.Parametros.dsParametros();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colparametro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_rep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(557, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 52);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "parametroToPick";
            this.grd_data.DataSource = this.dsParametros;
            this.grd_data.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_data.Location = new System.Drawing.Point(0, 68);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(679, 582);
            this.grd_data.TabIndex = 3;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsParametros
            // 
            this.dsParametros.DataSetName = "dsParametros";
            this.dsParametros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.Empty.Options.UseFont = true;
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colparametro,
            this.colid_categoria,
            this.coltipo_rep,
            this.coltipos,
            this.colcategoria,
            this.colSelected});
            this.grdv_data.DetailHeight = 284;
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Width = 64;
            // 
            // colparametro
            // 
            this.colparametro.Caption = "Parametros";
            this.colparametro.FieldName = "parametro";
            this.colparametro.Name = "colparametro";
            this.colparametro.OptionsColumn.AllowEdit = false;
            this.colparametro.Visible = true;
            this.colparametro.VisibleIndex = 0;
            this.colparametro.Width = 128;
            // 
            // colid_categoria
            // 
            this.colid_categoria.FieldName = "id_categoria";
            this.colid_categoria.Name = "colid_categoria";
            this.colid_categoria.OptionsColumn.AllowEdit = false;
            this.colid_categoria.Width = 64;
            // 
            // coltipo_rep
            // 
            this.coltipo_rep.FieldName = "tipo_rep";
            this.coltipo_rep.Name = "coltipo_rep";
            this.coltipo_rep.OptionsColumn.AllowEdit = false;
            this.coltipo_rep.Width = 64;
            // 
            // coltipos
            // 
            this.coltipos.Caption = "Tipo de Repuesta";
            this.coltipos.FieldName = "tipos";
            this.coltipos.Name = "coltipos";
            this.coltipos.OptionsColumn.AllowEdit = false;
            this.coltipos.Visible = true;
            this.coltipos.VisibleIndex = 1;
            this.coltipos.Width = 248;
            // 
            // colcategoria
            // 
            this.colcategoria.Caption = "Categoria";
            this.colcategoria.FieldName = "categoria";
            this.colcategoria.Name = "colcategoria";
            this.colcategoria.OptionsColumn.AllowEdit = false;
            this.colcategoria.Visible = true;
            this.colcategoria.VisibleIndex = 2;
            this.colcategoria.Width = 184;
            // 
            // colSelected
            // 
            this.colSelected.Caption = "Seleccionar";
            this.colSelected.FieldName = "Selected";
            this.colSelected.Name = "colSelected";
            this.colSelected.Visible = true;
            this.colSelected.VisibleIndex = 3;
            this.colSelected.Width = 101;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(9, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(112, 52);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Guardar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmPickParametrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 657);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPickParametrs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametros";
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private dsParametros dsParametros;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colparametro;
        private DevExpress.XtraGrid.Columns.GridColumn colid_categoria;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_rep;
        private DevExpress.XtraGrid.Columns.GridColumn coltipos;
        private DevExpress.XtraGrid.Columns.GridColumn colcategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}