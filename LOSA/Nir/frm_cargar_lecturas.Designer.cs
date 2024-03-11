
namespace LOSA.Nir
{
    partial class frm_cargar_lecturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cargar_lecturas));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.btnDescargarPlantilla = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsNIR_PRD1 = new LOSA.Nir.dsNIR_PRD();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_h = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collectura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coln_curva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_bromatologia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbroma_porcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEliminarLectura = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtcomentario = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNIR_PRD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarLectura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcomentario.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.cmdHome.Location = new System.Drawing.Point(978, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(142, 41);
            this.cmdHome.TabIndex = 8;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // btnDescargarPlantilla
            // 
            this.btnDescargarPlantilla.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarPlantilla.Appearance.Options.UseFont = true;
            this.btnDescargarPlantilla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargarPlantilla.ImageOptions.Image")));
            this.btnDescargarPlantilla.Location = new System.Drawing.Point(12, 75);
            this.btnDescargarPlantilla.Name = "btnDescargarPlantilla";
            this.btnDescargarPlantilla.Size = new System.Drawing.Size(177, 41);
            this.btnDescargarPlantilla.TabIndex = 9;
            this.btnDescargarPlantilla.Text = "Descargar Plantilla";
            this.btnDescargarPlantilla.Click += new System.EventHandler(this.btnDescargarPlantilla_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Appearance.Options.UseFont = true;
            this.btnupdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.ImageOptions.Image")));
            this.btnupdate.Location = new System.Drawing.Point(195, 75);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(142, 41);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Subir lecturas";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "Nir_lecturas";
            this.grd_data.DataSource = this.dsNIR_PRD1;
            this.grd_data.Location = new System.Drawing.Point(0, 143);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEliminarLectura});
            this.grd_data.Size = new System.Drawing.Size(1120, 417);
            this.grd_data.TabIndex = 11;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsNIR_PRD1
            // 
            this.dsNIR_PRD1.DataSetName = "dsNIR_PRD";
            this.dsNIR_PRD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_h,
            this.collectura,
            this.colfecha,
            this.colcurva,
            this.coln_curva,
            this.colid_bromatologia,
            this.colbroma_porcentaje,
            this.colGH,
            this.colNB,
            this.colTS,
            this.colcomentario,
            this.colnombre_producto,
            this.collote,
            this.colenable,
            this.col});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.LevelIndent = 0;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsEditForm.PopupEditFormWidth = 400;
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.PreviewIndent = 0;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_h
            // 
            this.colid_h.FieldName = "id_h";
            this.colid_h.Name = "colid_h";
            // 
            // collectura
            // 
            this.collectura.Caption = "#Lectura";
            this.collectura.FieldName = "#Lectura";
            this.collectura.Name = "collectura";
            this.collectura.OptionsColumn.AllowEdit = false;
            this.collectura.Visible = true;
            this.collectura.VisibleIndex = 0;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha/Hora de Analisis";
            this.colfecha.FieldName = "Fecha/Hora de Analisis";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 1;
            // 
            // colcurva
            // 
            this.colcurva.Caption = "#Curva";
            this.colcurva.FieldName = "#Curva";
            this.colcurva.Name = "colcurva";
            this.colcurva.OptionsColumn.AllowEdit = false;
            this.colcurva.Visible = true;
            this.colcurva.VisibleIndex = 2;
            // 
            // coln_curva
            // 
            this.coln_curva.Caption = "Nombre de la Curva";
            this.coln_curva.FieldName = "Nombre de la Curva";
            this.coln_curva.Name = "coln_curva";
            this.coln_curva.OptionsColumn.AllowEdit = false;
            this.coln_curva.Visible = true;
            this.coln_curva.VisibleIndex = 3;
            // 
            // colid_bromatologia
            // 
            this.colid_bromatologia.Caption = "ID Bromatologia";
            this.colid_bromatologia.FieldName = "ID Bromatologia";
            this.colid_bromatologia.Name = "colid_bromatologia";
            this.colid_bromatologia.OptionsColumn.AllowEdit = false;
            this.colid_bromatologia.Visible = true;
            this.colid_bromatologia.VisibleIndex = 4;
            // 
            // colbroma_porcentaje
            // 
            this.colbroma_porcentaje.Caption = "%Bromatologia";
            this.colbroma_porcentaje.FieldName = "%Bromatologia";
            this.colbroma_porcentaje.Name = "colbroma_porcentaje";
            this.colbroma_porcentaje.OptionsColumn.AllowEdit = false;
            this.colbroma_porcentaje.Visible = true;
            this.colbroma_porcentaje.VisibleIndex = 5;
            // 
            // colGH
            // 
            this.colGH.Caption = "GH";
            this.colGH.FieldName = "GH";
            this.colGH.Name = "colGH";
            this.colGH.OptionsColumn.AllowEdit = false;
            this.colGH.Visible = true;
            this.colGH.VisibleIndex = 6;
            // 
            // colNB
            // 
            this.colNB.Caption = "NB";
            this.colNB.FieldName = "NB";
            this.colNB.Name = "colNB";
            this.colNB.OptionsColumn.AllowEdit = false;
            this.colNB.Visible = true;
            this.colNB.VisibleIndex = 7;
            // 
            // colTS
            // 
            this.colTS.Caption = "TS";
            this.colTS.FieldName = "TS";
            this.colTS.Name = "colTS";
            this.colTS.OptionsColumn.AllowEdit = false;
            this.colTS.Visible = true;
            this.colTS.VisibleIndex = 8;
            // 
            // colcomentario
            // 
            this.colcomentario.Caption = "Comentario";
            this.colcomentario.FieldName = "Comentario";
            this.colcomentario.Name = "colcomentario";
            this.colcomentario.OptionsColumn.AllowEdit = false;
            this.colcomentario.Visible = true;
            this.colcomentario.VisibleIndex = 9;
            // 
            // colnombre_producto
            // 
            this.colnombre_producto.Caption = "Nombre de Producto";
            this.colnombre_producto.FieldName = "Nombre de Producto";
            this.colnombre_producto.Name = "colnombre_producto";
            this.colnombre_producto.OptionsColumn.AllowEdit = false;
            this.colnombre_producto.Visible = true;
            this.colnombre_producto.VisibleIndex = 10;
            // 
            // collote
            // 
            this.collote.Caption = "#Lote";
            this.collote.FieldName = "#Lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 11;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            // 
            // col
            // 
            this.col.Caption = "Eliminar";
            this.col.ColumnEdit = this.btnEliminarLectura;
            this.col.Name = "col";
            this.col.Visible = true;
            this.col.VisibleIndex = 12;
            // 
            // btnEliminarLectura
            // 
            this.btnEliminarLectura.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.btnEliminarLectura.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEliminarLectura.Name = "btnEliminarLectura";
            this.btnEliminarLectura.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEliminarLectura.Click += new System.EventHandler(this.btnEliminarLectura_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 597);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 21);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Comentario:";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(343, 75);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 41);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtcomentario
            // 
            this.txtcomentario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcomentario.Location = new System.Drawing.Point(112, 595);
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomentario.Properties.Appearance.Options.UseFont = true;
            this.txtcomentario.Properties.MaxLength = 350;
            this.txtcomentario.Size = new System.Drawing.Size(709, 116);
            this.txtcomentario.TabIndex = 14;
            // 
            // frm_cargar_lecturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 741);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnDescargarPlantilla);
            this.Controls.Add(this.cmdHome);
            this.Name = "frm_cargar_lecturas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNIR_PRD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarLectura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcomentario.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.SimpleButton btnDescargarPlantilla;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.MemoEdit txtcomentario;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_h;
        private DevExpress.XtraGrid.Columns.GridColumn collectura;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcurva;
        private DevExpress.XtraGrid.Columns.GridColumn coln_curva;
        private DevExpress.XtraGrid.Columns.GridColumn colid_bromatologia;
        private DevExpress.XtraGrid.Columns.GridColumn colbroma_porcentaje;
        private DevExpress.XtraGrid.Columns.GridColumn colGH;
        private DevExpress.XtraGrid.Columns.GridColumn colNB;
        private DevExpress.XtraGrid.Columns.GridColumn colTS;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentario;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_producto;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn col;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEliminarLectura;
        private dsNIR_PRD dsNIR_PRD1;
    }
}