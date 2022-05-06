
namespace LOSA.Calidad
{
    partial class xfrmTrazabilidadClientesLotes
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmTrazabilidadClientesLotes));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.despachadoClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCalidad = new LOSA.Calidad.dsCalidad();
            this.direccionClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnVer = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gvDespachado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collote_producto_termiado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadDespachado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grDetalle = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.slueCliente = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.despachadoClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDespachado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueCliente.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(7, 55);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 24);
            this.labelControl6.TabIndex = 73;
            this.labelControl6.Text = "Cliente:";
            // 
            // despachadoClientesBindingSource
            // 
            this.despachadoClientesBindingSource.DataMember = "DespachadoClientes";
            this.despachadoClientesBindingSource.DataSource = this.dsCalidad;
            // 
            // dsCalidad
            // 
            this.dsCalidad.DataSetName = "dsCalidad";
            this.dsCalidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // direccionClientesBindingSource
            // 
            this.direccionClientesBindingSource.DataMember = "Direccion_Clientes";
            this.direccionClientesBindingSource.DataSource = this.dsCalidad;
            // 
            // btnVer
            // 
            this.btnVer.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btnVer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnVer.Name = "btnVer";
            this.btnVer.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnVer_ButtonClick);
            // 
            // gvDespachado
            // 
            this.gvDespachado.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDespachado.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDespachado.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDespachado.Appearance.Row.Options.UseFont = true;
            this.gvDespachado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collote_producto_termiado,
            this.colCantidadDespachado,
            this.colkg,
            this.colcode_sap,
            this.colCodigo,
            this.colDescripcion});
            this.gvDespachado.GridControl = this.grDetalle;
            this.gvDespachado.Name = "gvDespachado";
            this.gvDespachado.OptionsView.ShowFooter = true;
            this.gvDespachado.OptionsView.ShowGroupPanel = false;
            // 
            // collote_producto_termiado
            // 
            this.collote_producto_termiado.Caption = "Lote PT";
            this.collote_producto_termiado.ColumnEdit = this.btnVer;
            this.collote_producto_termiado.FieldName = "lote_producto_termiado";
            this.collote_producto_termiado.Name = "collote_producto_termiado";
            this.collote_producto_termiado.Visible = true;
            this.collote_producto_termiado.VisibleIndex = 0;
            // 
            // colCantidadDespachado
            // 
            this.colCantidadDespachado.Caption = "Cant. Despachado";
            this.colCantidadDespachado.FieldName = "CantidadDespachado";
            this.colCantidadDespachado.Name = "colCantidadDespachado";
            this.colCantidadDespachado.Visible = true;
            this.colCantidadDespachado.VisibleIndex = 1;
            // 
            // colkg
            // 
            this.colkg.Caption = "KG";
            this.colkg.FieldName = "kg";
            this.colkg.Name = "colkg";
            this.colkg.Visible = true;
            this.colkg.VisibleIndex = 2;
            // 
            // colcode_sap
            // 
            this.colcode_sap.Caption = "Cod. SAP";
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 3;
            // 
            // colCodigo
            // 
            this.colCodigo.Caption = "Código";
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 4;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 5;
            // 
            // grDetalle
            // 
            this.grDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDetalle.DataSource = this.despachadoClientesBindingSource;
            this.grDetalle.Location = new System.Drawing.Point(2, 112);
            this.grDetalle.MainView = this.gvDespachado;
            this.grDetalle.Name = "grDetalle";
            this.grDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnVer});
            this.grDetalle.Size = new System.Drawing.Size(722, 409);
            this.grDetalle.TabIndex = 77;
            this.grDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDespachado});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 128;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre";
            this.gridColumn2.FieldName = "nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 200;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Pais";
            this.gridColumn3.FieldName = "pais";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 56;
            // 
            // slueCliente
            // 
            this.slueCliente.Location = new System.Drawing.Point(76, 54);
            this.slueCliente.Name = "slueCliente";
            this.slueCliente.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.slueCliente.Properties.Appearance.Options.UseFont = true;
            this.slueCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueCliente.Properties.DataSource = this.direccionClientesBindingSource;
            this.slueCliente.Properties.DisplayMember = "nombre";
            this.slueCliente.Properties.NullText = "";
            this.slueCliente.Properties.PopupView = this.gridView1;
            this.slueCliente.Properties.ValueMember = "id";
            this.slueCliente.Size = new System.Drawing.Size(459, 28);
            this.slueCliente.TabIndex = 78;
            this.slueCliente.EditValueChanged += new System.EventHandler(this.slueCliente_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(174, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(274, 25);
            this.labelControl1.TabIndex = 74;
            this.labelControl1.Text = "Trazabilidad Clientes - Lotes";
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
            this.cmdHome.Location = new System.Drawing.Point(543, 25);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(171, 54);
            this.cmdHome.TabIndex = 79;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // xfrmTrazabilidadClientesLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 521);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.slueCliente);
            this.Controls.Add(this.grDetalle);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl6);
            this.Name = "xfrmTrazabilidadClientesLotes";
            this.Text = "xfrmTrazabilidadClientesLotes";
            ((System.ComponentModel.ISupportInitialize)(this.despachadoClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDespachado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueCliente.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.BindingSource despachadoClientesBindingSource;
        private dsCalidad dsCalidad;
        private System.Windows.Forms.BindingSource direccionClientesBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnVer;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDespachado;
        private DevExpress.XtraGrid.Columns.GridColumn collote_producto_termiado;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadDespachado;
        private DevExpress.XtraGrid.Columns.GridColumn colkg;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.GridControl grDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SearchLookUpEdit slueCliente;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
    }
}