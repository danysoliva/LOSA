
namespace LOSA.Finanzas
{
    partial class frmExoneracionDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExoneracionDetalle));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdDetalle = new DevExpress.XtraGrid.GridControl();
            this.dsExoneracion1 = new LOSA.Finanzas.dsExoneracion();
            this.grdvDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcapitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_presupuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repostEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.col_rubeo_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExoneracion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repostEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDetalle
            // 
            this.grdDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDetalle.DataMember = "detalle_exoneracion";
            this.grdDetalle.DataSource = this.dsExoneracion1;
            this.grdDetalle.Location = new System.Drawing.Point(0, 70);
            this.grdDetalle.MainView = this.grdvDetalle;
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repostEditar});
            this.grdDetalle.Size = new System.Drawing.Size(1277, 645);
            this.grdDetalle.TabIndex = 0;
            this.grdDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvDetalle});
            // 
            // dsExoneracion1
            // 
            this.dsExoneracion1.DataSetName = "dsExoneracion";
            this.dsExoneracion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdvDetalle
            // 
            this.grdvDetalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdvDetalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdvDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcapitulo,
            this.colrubro,
            this.col_rubeo_descripcion,
            this.colid_presupuesto,
            this.colenable,
            this.colmonto,
            this.gridColumn1});
            this.grdvDetalle.GridControl = this.grdDetalle;
            this.grdvDetalle.Name = "grdvDetalle";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colcapitulo
            // 
            this.colcapitulo.Caption = "Capitulo";
            this.colcapitulo.FieldName = "capitulo";
            this.colcapitulo.Name = "colcapitulo";
            this.colcapitulo.OptionsColumn.ReadOnly = true;
            this.colcapitulo.Visible = true;
            this.colcapitulo.VisibleIndex = 0;
            this.colcapitulo.Width = 239;
            // 
            // colrubro
            // 
            this.colrubro.FieldName = "rubro";
            this.colrubro.Name = "colrubro";
            this.colrubro.OptionsColumn.ReadOnly = true;
            // 
            // colid_presupuesto
            // 
            this.colid_presupuesto.FieldName = "id_presupuesto";
            this.colid_presupuesto.Name = "colid_presupuesto";
            this.colid_presupuesto.OptionsColumn.ReadOnly = true;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.ReadOnly = true;
            // 
            // colmonto
            // 
            this.colmonto.Caption = "Presupuesto";
            this.colmonto.FieldName = "monto";
            this.colmonto.Name = "colmonto";
            this.colmonto.OptionsColumn.ReadOnly = true;
            this.colmonto.Visible = true;
            this.colmonto.VisibleIndex = 2;
            this.colmonto.Width = 362;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.repostEditar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 192;
            // 
            // repostEditar
            // 
            this.repostEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repostEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repostEditar.Name = "repostEditar";
            this.repostEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Appearance.Options.UseBackColor = true;
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ImageOptions.Image = global::LOSA.Properties.Resources.plus;
            this.btnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAgregar.Location = new System.Drawing.Point(13, 18);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 45);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "Agregar Detalle";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // col_rubeo_descripcion
            // 
            this.col_rubeo_descripcion.Caption = "Rubro";
            this.col_rubeo_descripcion.FieldName = "rubro_descripcion";
            this.col_rubeo_descripcion.Name = "col_rubeo_descripcion";
            this.col_rubeo_descripcion.Visible = true;
            this.col_rubeo_descripcion.VisibleIndex = 1;
            this.col_rubeo_descripcion.Width = 459;
            // 
            // frmExoneracionDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 715);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grdDetalle);
            this.Name = "frmExoneracionDetalle";
            this.Text = "frmExoneracionDetalle";
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExoneracion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repostEditar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvDetalle;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private dsExoneracion dsExoneracion1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcapitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colrubro;
        private DevExpress.XtraGrid.Columns.GridColumn colid_presupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repostEditar;
        private DevExpress.XtraGrid.Columns.GridColumn col_rubeo_descripcion;
    }
}