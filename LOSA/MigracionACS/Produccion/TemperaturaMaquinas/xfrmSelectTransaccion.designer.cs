
namespace LOSA.MigracionACS.Produccion.TemperaturaMaquinas
{
    partial class xfrmSelectTransaccion
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions6 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmSelectTransaccion));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject21 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject22 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject23 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject24 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions5 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject17 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject18 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject19 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject20 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gvTransaccion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemPrint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.dsTemperatura = new LOSA.MigracionACS.Produccion.TemperaturaMaquinas.dsTemperatura();
            this.transaccionalHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorder_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_orden_prd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_producto_terminado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_formula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colversion_formula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransaccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTemperatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionalHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataSource = this.transaccionalHBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(-2, 76);
            this.gridControl2.MainView = this.gvTransaccion;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPrint,
            this.btnSeleccionar});
            this.gridControl2.Size = new System.Drawing.Size(1076, 421);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTransaccion});
            // 
            // gvTransaccion
            // 
            this.gvTransaccion.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTransaccion.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTransaccion.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTransaccion.Appearance.Row.Options.UseFont = true;
            this.gvTransaccion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colorder_id,
            this.colestado,
            this.colnum_orden,
            this.colcod_orden_prd,
            this.collote_producto_terminado,
            this.colproducto,
            this.colcodigo_formula,
            this.colversion_formula,
            this.colid,
            this.gridColumn1});
            this.gvTransaccion.GridControl = this.gridControl2;
            this.gvTransaccion.Name = "gvTransaccion";
            this.gvTransaccion.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemPrint
            // 
            this.repositoryItemPrint.AutoHeight = false;
            editorButtonImageOptions6.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions6.Image")));
            this.repositoryItemPrint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions6, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject21, serializableAppearanceObject22, serializableAppearanceObject23, serializableAppearanceObject24, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemPrint.Name = "repositoryItemPrint";
            this.repositoryItemPrint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoHeight = false;
            editorButtonImageOptions5.Image = global::LOSA.Properties.Resources._click_32X32;
            this.btnSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions5, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject17, serializableAppearanceObject18, serializableAppearanceObject19, serializableAppearanceObject20, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSeleccionar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSeleccionar_ButtonClick);
            // 
            // dsTemperatura
            // 
            this.dsTemperatura.DataSetName = "dsTemperatura";
            this.dsTemperatura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaccionalHBindingSource
            // 
            this.transaccionalHBindingSource.DataMember = "transaccional_H";
            this.transaccionalHBindingSource.DataSource = this.dsTemperatura;
            // 
            // colorder_id
            // 
            this.colorder_id.FieldName = "order_id";
            this.colorder_id.Name = "colorder_id";
            this.colorder_id.Visible = true;
            this.colorder_id.VisibleIndex = 1;
            // 
            // colestado
            // 
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 2;
            // 
            // colnum_orden
            // 
            this.colnum_orden.FieldName = "num_orden";
            this.colnum_orden.Name = "colnum_orden";
            this.colnum_orden.Visible = true;
            this.colnum_orden.VisibleIndex = 3;
            // 
            // colcod_orden_prd
            // 
            this.colcod_orden_prd.FieldName = "cod_orden_prd";
            this.colcod_orden_prd.Name = "colcod_orden_prd";
            this.colcod_orden_prd.Visible = true;
            this.colcod_orden_prd.VisibleIndex = 4;
            // 
            // collote_producto_terminado
            // 
            this.collote_producto_terminado.FieldName = "lote_producto_terminado";
            this.collote_producto_terminado.Name = "collote_producto_terminado";
            this.collote_producto_terminado.Visible = true;
            this.collote_producto_terminado.VisibleIndex = 5;
            // 
            // colproducto
            // 
            this.colproducto.FieldName = "producto";
            this.colproducto.Name = "colproducto";
            this.colproducto.Visible = true;
            this.colproducto.VisibleIndex = 6;
            // 
            // colcodigo_formula
            // 
            this.colcodigo_formula.FieldName = "codigo_formula";
            this.colcodigo_formula.Name = "colcodigo_formula";
            this.colcodigo_formula.Visible = true;
            this.colcodigo_formula.VisibleIndex = 7;
            // 
            // colversion_formula
            // 
            this.colversion_formula.FieldName = "version_formula";
            this.colversion_formula.Name = "colversion_formula";
            this.colversion_formula.Visible = true;
            this.colversion_formula.VisibleIndex = 8;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Seleccionar";
            this.gridColumn1.ColumnEdit = this.btnSeleccionar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 9;
            // 
            // xfrmSelectTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 496);
            this.Controls.Add(this.gridControl2);
            this.Name = "xfrmSelectTransaccion";
            this.Text = "xfrmSelectTransaccion";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransaccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTemperatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionalHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTransaccion;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemPrint;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSeleccionar;
        private DevExpress.XtraGrid.Columns.GridColumn colorder_id;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_orden;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_orden_prd;
        private DevExpress.XtraGrid.Columns.GridColumn collote_producto_terminado;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_formula;
        private DevExpress.XtraGrid.Columns.GridColumn colversion_formula;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private dsTemperatura dsTemperatura;
        private System.Windows.Forms.BindingSource transaccionalHBindingSource;
    }
}