
namespace LOSA.Trazabilidad
{
    partial class frmBuscarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarCliente));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.dsCalidad1 = new LOSA.Calidad.dsCalidad();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_pais1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colciudad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpais1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente_aqua1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colseleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAplicar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataMember = "Direccion_Clientes";
            this.gridControl2.DataSource = this.dsCalidad1;
            this.gridControl2.Location = new System.Drawing.Point(0, 64);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEliminar});
            this.gridControl2.Size = new System.Drawing.Size(782, 337);
            this.gridControl2.TabIndex = 98;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // dsCalidad1
            // 
            this.dsCalidad1.DataSetName = "dsCalidad";
            this.dsCalidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid6,
            this.colcodigo1,
            this.colcodigo_pais1,
            this.coldireccion11,
            this.coldireccion21,
            this.colciudad1,
            this.colpais1,
            this.colcliente_aqua1,
            this.colnombre1,
            this.colEliminar,
            this.colseleccionado});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colid6
            // 
            this.colid6.FieldName = "id";
            this.colid6.Name = "colid6";
            this.colid6.OptionsColumn.AllowEdit = false;
            // 
            // colcodigo1
            // 
            this.colcodigo1.Caption = "Código";
            this.colcodigo1.FieldName = "codigo";
            this.colcodigo1.Name = "colcodigo1";
            this.colcodigo1.OptionsColumn.AllowEdit = false;
            this.colcodigo1.Visible = true;
            this.colcodigo1.VisibleIndex = 1;
            this.colcodigo1.Width = 60;
            // 
            // colcodigo_pais1
            // 
            this.colcodigo_pais1.FieldName = "codigo_pais";
            this.colcodigo_pais1.Name = "colcodigo_pais1";
            this.colcodigo_pais1.OptionsColumn.AllowEdit = false;
            // 
            // coldireccion11
            // 
            this.coldireccion11.Caption = "Dirección";
            this.coldireccion11.FieldName = "direccion1";
            this.coldireccion11.Name = "coldireccion11";
            this.coldireccion11.OptionsColumn.AllowEdit = false;
            this.coldireccion11.Visible = true;
            this.coldireccion11.VisibleIndex = 5;
            this.coldireccion11.Width = 105;
            // 
            // coldireccion21
            // 
            this.coldireccion21.Caption = "Dirección 2";
            this.coldireccion21.FieldName = "direccion2";
            this.coldireccion21.Name = "coldireccion21";
            this.coldireccion21.OptionsColumn.AllowEdit = false;
            this.coldireccion21.Visible = true;
            this.coldireccion21.VisibleIndex = 6;
            this.coldireccion21.Width = 86;
            // 
            // colciudad1
            // 
            this.colciudad1.Caption = "Ciudad";
            this.colciudad1.FieldName = "ciudad";
            this.colciudad1.Name = "colciudad1";
            this.colciudad1.OptionsColumn.AllowEdit = false;
            this.colciudad1.Visible = true;
            this.colciudad1.VisibleIndex = 4;
            this.colciudad1.Width = 100;
            // 
            // colpais1
            // 
            this.colpais1.Caption = "País";
            this.colpais1.FieldName = "pais";
            this.colpais1.Name = "colpais1";
            this.colpais1.OptionsColumn.AllowEdit = false;
            this.colpais1.Visible = true;
            this.colpais1.VisibleIndex = 3;
            this.colpais1.Width = 79;
            // 
            // colcliente_aqua1
            // 
            this.colcliente_aqua1.FieldName = "cliente_aqua";
            this.colcliente_aqua1.Name = "colcliente_aqua1";
            this.colcliente_aqua1.OptionsColumn.AllowEdit = false;
            // 
            // colnombre1
            // 
            this.colnombre1.Caption = "Nombre";
            this.colnombre1.FieldName = "nombre";
            this.colnombre1.Name = "colnombre1";
            this.colnombre1.OptionsColumn.AllowEdit = false;
            this.colnombre1.Visible = true;
            this.colnombre1.VisibleIndex = 2;
            this.colnombre1.Width = 225;
            // 
            // colEliminar
            // 
            this.colEliminar.Caption = "Eliminar";
            this.colEliminar.ColumnEdit = this.cmdEliminar;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Visible = true;
            this.colEliminar.VisibleIndex = 7;
            this.colEliminar.Width = 43;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colseleccionado
            // 
            this.colseleccionado.FieldName = "seleccionado";
            this.colseleccionado.Name = "colseleccionado";
            this.colseleccionado.Visible = true;
            this.colseleccionado.VisibleIndex = 0;
            this.colseleccionado.Width = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "Seleccione uno o varios Clientes";
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(638, 20);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(144, 41);
            this.cmdCerrar.TabIndex = 100;
            this.cmdCerrar.Text = "Cerrar";
            // 
            // cmdAplicar
            // 
            this.cmdAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAplicar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdAplicar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAplicar.Appearance.Options.UseBackColor = true;
            this.cmdAplicar.Appearance.Options.UseFont = true;
            this.cmdAplicar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAplicar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAplicar.ImageOptions.Image")));
            this.cmdAplicar.Location = new System.Drawing.Point(488, 20);
            this.cmdAplicar.Name = "cmdAplicar";
            this.cmdAplicar.Size = new System.Drawing.Size(144, 41);
            this.cmdAplicar.TabIndex = 101;
            this.cmdAplicar.Text = "Aplicar";
            this.cmdAplicar.Click += new System.EventHandler(this.cmdAplicar_Click);
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 401);
            this.Controls.Add(this.cmdAplicar);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl2);
            this.Name = "frmBuscarCliente";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colid6;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo1;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_pais1;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion11;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion21;
        private DevExpress.XtraGrid.Columns.GridColumn colciudad1;
        private DevExpress.XtraGrid.Columns.GridColumn colpais1;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente_aqua1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre1;
        private DevExpress.XtraGrid.Columns.GridColumn colEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEliminar;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdAplicar;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
        public Calidad.dsCalidad dsCalidad1;
    }
}