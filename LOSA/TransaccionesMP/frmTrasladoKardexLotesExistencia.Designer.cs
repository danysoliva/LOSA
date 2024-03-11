
namespace LOSA.TransaccionesMP
{
    partial class frmTrasladoKardexLotesExistencia
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcLoteForKardex = new DevExpress.XtraGrid.GridControl();
            this.dsRecepcionMPx1 = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.gvLoteForKardex = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_unidadmedida1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_mp1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidad_medida1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfactor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposSeleccion = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoteForKardex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoteForKardex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposSeleccion)).BeginInit();
            this.SuspendLayout();
            // 
            // gcLoteForKardex
            // 
            this.gcLoteForKardex.DataMember = "lotes_kardex";
            this.gcLoteForKardex.DataSource = this.dsRecepcionMPx1;
            this.gcLoteForKardex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLoteForKardex.Location = new System.Drawing.Point(0, 0);
            this.gcLoteForKardex.MainView = this.gvLoteForKardex;
            this.gcLoteForKardex.Name = "gcLoteForKardex";
            this.gcLoteForKardex.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposSeleccion});
            this.gcLoteForKardex.Size = new System.Drawing.Size(795, 573);
            this.gcLoteForKardex.TabIndex = 10;
            this.gcLoteForKardex.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLoteForKardex});
            // 
            // dsRecepcionMPx1
            // 
            this.dsRecepcionMPx1.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvLoteForKardex
            // 
            this.gvLoteForKardex.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLoteForKardex.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvLoteForKardex.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLoteForKardex.Appearance.Row.Options.UseFont = true;
            this.gvLoteForKardex.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.collote1,
            this.colid_unidadmedida1,
            this.colid_mp1,
            this.colunidad_medida1,
            this.colfactor});
            this.gvLoteForKardex.GridControl = this.gcLoteForKardex;
            this.gvLoteForKardex.Name = "gvLoteForKardex";
            this.gvLoteForKardex.OptionsView.ShowGroupPanel = false;
            this.gvLoteForKardex.DoubleClick += new System.EventHandler(this.gvLoteForKardex_DoubleClick);
            // 
            // collote1
            // 
            this.collote1.Caption = "Lote MP";
            this.collote1.FieldName = "lote";
            this.collote1.Name = "collote1";
            this.collote1.OptionsColumn.AllowEdit = false;
            this.collote1.Visible = true;
            this.collote1.VisibleIndex = 0;
            // 
            // colid_unidadmedida1
            // 
            this.colid_unidadmedida1.FieldName = "id_unidadmedida";
            this.colid_unidadmedida1.Name = "colid_unidadmedida1";
            this.colid_unidadmedida1.OptionsColumn.AllowEdit = false;
            // 
            // colid_mp1
            // 
            this.colid_mp1.FieldName = "id_mp";
            this.colid_mp1.Name = "colid_mp1";
            this.colid_mp1.OptionsColumn.AllowEdit = false;
            // 
            // colunidad_medida1
            // 
            this.colunidad_medida1.Caption = "Presentacion";
            this.colunidad_medida1.FieldName = "unidad_medida";
            this.colunidad_medida1.Name = "colunidad_medida1";
            this.colunidad_medida1.OptionsColumn.AllowEdit = false;
            this.colunidad_medida1.Visible = true;
            this.colunidad_medida1.VisibleIndex = 1;
            // 
            // colfactor
            // 
            this.colfactor.FieldName = "factor";
            this.colfactor.Name = "colfactor";
            this.colfactor.OptionsColumn.AllowEdit = false;
            // 
            // reposSeleccion
            // 
            this.reposSeleccion.AutoHeight = false;
            editorButtonImageOptions2.Image = global::LOSA.Properties.Resources._click_32X32;
            this.reposSeleccion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposSeleccion.Name = "reposSeleccion";
            this.reposSeleccion.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposSeleccion.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposSeleccion_ButtonClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Seleccionar";
            this.gridColumn1.ColumnEdit = this.reposSeleccion;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // frmTrasladoKardexLotesExistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 573);
            this.Controls.Add(this.gcLoteForKardex);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTrasladoKardexLotesExistencia";
            this.Text = "Lotes en Existencia";
            ((System.ComponentModel.ISupportInitialize)(this.gcLoteForKardex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoteForKardex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposSeleccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcLoteForKardex;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLoteForKardex;
        private DevExpress.XtraGrid.Columns.GridColumn collote1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_unidadmedida1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp1;
        private DevExpress.XtraGrid.Columns.GridColumn colunidad_medida1;
        private DevExpress.XtraGrid.Columns.GridColumn colfactor;
        private RecepcionMP.dsRecepcionMPx dsRecepcionMPx1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposSeleccion;
    }
}