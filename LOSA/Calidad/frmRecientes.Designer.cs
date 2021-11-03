
namespace LOSA.Calidad
{
    partial class frmRecientes
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecientes));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grd_docRecientes = new DevExpress.XtraGrid.GridControl();
            this.dsMantenimientoC = new LOSA.Calidad.dsMantenimientoC();
            this.grdv_recientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfile_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAdjuntar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdjuntar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grd_docRecientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_recientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_docRecientes
            // 
            this.grd_docRecientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_docRecientes.DataMember = "recientes";
            this.grd_docRecientes.DataSource = this.dsMantenimientoC;
            this.grd_docRecientes.Location = new System.Drawing.Point(2, 70);
            this.grd_docRecientes.MainView = this.grdv_recientes;
            this.grd_docRecientes.Name = "grd_docRecientes";
            this.grd_docRecientes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnAdjuntar});
            this.grd_docRecientes.Size = new System.Drawing.Size(589, 550);
            this.grd_docRecientes.TabIndex = 0;
            this.grd_docRecientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_recientes});
            // 
            // dsMantenimientoC
            // 
            this.dsMantenimientoC.DataSetName = "dsMantenimientoC";
            this.dsMantenimientoC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_recientes
            // 
            this.grdv_recientes.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_recientes.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_recientes.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_recientes.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_recientes.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_recientes.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_recientes.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_recientes.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_recientes.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_recientes.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_recientes.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_recientes.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_recientes.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_recientes.Appearance.Preview.Options.UseFont = true;
            this.grdv_recientes.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_recientes.Appearance.Row.Options.UseFont = true;
            this.grdv_recientes.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_recientes.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_recientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.colpath,
            this.colfile_name,
            this.colfecha,
            this.colingreso,
            this.ColAdjuntar});
            this.grdv_recientes.GridControl = this.grd_docRecientes;
            this.grdv_recientes.Name = "grdv_recientes";
            this.grdv_recientes.OptionsView.ShowGroupPanel = false;
            this.grdv_recientes.DoubleClick += new System.EventHandler(this.grdv_recientes_DoubleClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Adjunto";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            // 
            // colpath
            // 
            this.colpath.Caption = "Direccion";
            this.colpath.FieldName = "path";
            this.colpath.Name = "colpath";
            this.colpath.OptionsColumn.AllowEdit = false;
            // 
            // colfile_name
            // 
            this.colfile_name.Caption = "Documento";
            this.colfile_name.FieldName = "file_name";
            this.colfile_name.Name = "colfile_name";
            this.colfile_name.OptionsColumn.AllowEdit = false;
            this.colfile_name.Visible = true;
            this.colfile_name.VisibleIndex = 2;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 3;
            // 
            // colingreso
            // 
            this.colingreso.Caption = "Ingreso";
            this.colingreso.FieldName = "ingreso";
            this.colingreso.Name = "colingreso";
            this.colingreso.OptionsColumn.AllowEdit = false;
            this.colingreso.Visible = true;
            this.colingreso.VisibleIndex = 0;
            // 
            // ColAdjuntar
            // 
            this.ColAdjuntar.Caption = "Reutilizar";
            this.ColAdjuntar.ColumnEdit = this.btnAdjuntar;
            this.ColAdjuntar.Name = "ColAdjuntar";
            this.ColAdjuntar.Visible = true;
            this.ColAdjuntar.VisibleIndex = 4;
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnAdjuntar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCerrar.Appearance.Options.UseFont = true;
            this.btnCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ImageOptions.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(480, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(109, 42);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(334, 30);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Archivo recientemente adjuntados.";
            // 
            // frmRecientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 618);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.grd_docRecientes);
            this.Name = "frmRecientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos Recientes";
            ((System.ComponentModel.ISupportInitialize)(this.grd_docRecientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_recientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_docRecientes;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_recientes;
        private DevExpress.XtraEditors.SimpleButton btnCerrar;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colpath;
        private DevExpress.XtraGrid.Columns.GridColumn colfile_name;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsMantenimientoC dsMantenimientoC;
        private DevExpress.XtraGrid.Columns.GridColumn colingreso;
        private DevExpress.XtraGrid.Columns.GridColumn ColAdjuntar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAdjuntar;
    }
}