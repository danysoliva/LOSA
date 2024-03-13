
namespace LOSA.Compras
{
    partial class frmSearchOrdenC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchOrdenC));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdSolicitudes = new DevExpress.XtraGrid.GridControl();
            this.dsCompras1 = new LOSA.Compras.dsCompras();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_h = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colU_TipoOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubido_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposSelected = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSolicitudes
            // 
            this.grdSolicitudes.DataMember = "orden_compra_exo";
            this.grdSolicitudes.DataSource = this.dsCompras1;
            this.grdSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSolicitudes.Location = new System.Drawing.Point(0, 0);
            this.grdSolicitudes.MainView = this.gridView1;
            this.grdSolicitudes.Name = "grdSolicitudes";
            this.grdSolicitudes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposSelected});
            this.grdSolicitudes.Size = new System.Drawing.Size(1021, 421);
            this.grdSolicitudes.TabIndex = 2;
            this.grdSolicitudes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsCompras1
            // 
            this.dsCompras1.DataSetName = "dsCompras";
            this.dsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_h,
            this.colCardCode,
            this.colCardName,
            this.colState,
            this.colDocNum,
            this.colDocDate,
            this.colU_TipoOrden,
            this.colComments,
            this.colDocTotal,
            this.colsubido_sap,
            this.colsubido,
            this.gridColumn1});
            this.gridView1.GridControl = this.grdSolicitudes;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colid_h
            // 
            this.colid_h.FieldName = "id_h";
            this.colid_h.Name = "colid_h";
            this.colid_h.OptionsColumn.AllowEdit = false;
            this.colid_h.Width = 72;
            // 
            // colCardCode
            // 
            this.colCardCode.FieldName = "CardCode";
            this.colCardCode.Name = "colCardCode";
            this.colCardCode.OptionsColumn.AllowEdit = false;
            this.colCardCode.Visible = true;
            this.colCardCode.VisibleIndex = 1;
            this.colCardCode.Width = 91;
            // 
            // colCardName
            // 
            this.colCardName.FieldName = "CardName";
            this.colCardName.Name = "colCardName";
            this.colCardName.OptionsColumn.AllowEdit = false;
            this.colCardName.Visible = true;
            this.colCardName.VisibleIndex = 2;
            this.colCardName.Width = 194;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.AllowEdit = false;
            this.colState.Width = 104;
            // 
            // colDocNum
            // 
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.ReadOnly = true;
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 0;
            this.colDocNum.Width = 82;
            // 
            // colDocDate
            // 
            this.colDocDate.FieldName = "DocDate";
            this.colDocDate.Name = "colDocDate";
            this.colDocDate.OptionsColumn.AllowEdit = false;
            this.colDocDate.Visible = true;
            this.colDocDate.VisibleIndex = 4;
            this.colDocDate.Width = 101;
            // 
            // colU_TipoOrden
            // 
            this.colU_TipoOrden.Caption = "Tipo de Orden";
            this.colU_TipoOrden.FieldName = "U_TipoOrden";
            this.colU_TipoOrden.Name = "colU_TipoOrden";
            this.colU_TipoOrden.OptionsColumn.AllowEdit = false;
            this.colU_TipoOrden.Visible = true;
            this.colU_TipoOrden.VisibleIndex = 5;
            this.colU_TipoOrden.Width = 124;
            // 
            // colComments
            // 
            this.colComments.Caption = "Comentario";
            this.colComments.FieldName = "Comments";
            this.colComments.Name = "colComments";
            this.colComments.OptionsColumn.AllowEdit = false;
            this.colComments.Visible = true;
            this.colComments.VisibleIndex = 6;
            this.colComments.Width = 92;
            // 
            // colDocTotal
            // 
            this.colDocTotal.DisplayFormat.FormatString = "n2";
            this.colDocTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDocTotal.FieldName = "DocTotal";
            this.colDocTotal.Name = "colDocTotal";
            this.colDocTotal.OptionsColumn.AllowEdit = false;
            this.colDocTotal.Visible = true;
            this.colDocTotal.VisibleIndex = 7;
            this.colDocTotal.Width = 92;
            // 
            // colsubido_sap
            // 
            this.colsubido_sap.Caption = "Subido a SAP";
            this.colsubido_sap.FieldName = "subido_sap";
            this.colsubido_sap.Name = "colsubido_sap";
            this.colsubido_sap.OptionsColumn.AllowEdit = false;
            this.colsubido_sap.Visible = true;
            this.colsubido_sap.VisibleIndex = 8;
            this.colsubido_sap.Width = 116;
            // 
            // colsubido
            // 
            this.colsubido.FieldName = "subido";
            this.colsubido.Name = "colsubido";
            this.colsubido.OptionsColumn.AllowEdit = false;
            this.colsubido.Width = 110;
            // 
            // reposSelected
            // 
            this.reposSelected.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.reposSelected.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposSelected.Name = "reposSelected";
            this.reposSelected.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Estado OC";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 104;
            // 
            // frmSearchOrdenC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 421);
            this.Controls.Add(this.grdSolicitudes);
            this.Name = "frmSearchOrdenC";
            this.Text = "Doble Click para Seleccionar Orden de Compra";
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdSolicitudes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposSelected;
        private dsCompras dsCompras1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_h;
        private DevExpress.XtraGrid.Columns.GridColumn colCardCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate;
        private DevExpress.XtraGrid.Columns.GridColumn colU_TipoOrden;
        private DevExpress.XtraGrid.Columns.GridColumn colComments;
        private DevExpress.XtraGrid.Columns.GridColumn colDocTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colsubido_sap;
        private DevExpress.XtraGrid.Columns.GridColumn colsubido;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}