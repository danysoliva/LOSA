namespace LOSA.Reportes
{
    partial class frmreporteUbicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmreporteUbicacion));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.beUbicacion = new DevExpress.XtraEditors.ButtonEdit();
            this.cmdSelectTarima = new DevExpress.XtraEditors.SimpleButton();
            this.grd_ubicacion = new DevExpress.XtraGrid.GridControl();
            this.dsReportes = new LOSA.Reportes.dsReportes();
            this.grdv_ubicacio = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.beUbicacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ubicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_ubicacio)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(115, 13);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(496, 48);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Reporte de Ubicacion";
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
            this.cmdHome.Location = new System.Drawing.Point(573, 13);
            this.cmdHome.Margin = new System.Windows.Forms.Padding(4);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(265, 62);
            this.cmdHome.TabIndex = 33;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(9, 88);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(133, 48);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "Ubicacion: ";
            // 
            // beUbicacion
            // 
            this.beUbicacion.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.beUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beUbicacion.EditValue = "";
            this.beUbicacion.Location = new System.Drawing.Point(163, 88);
            this.beUbicacion.Margin = new System.Windows.Forms.Padding(4);
            this.beUbicacion.Name = "beUbicacion";
            this.beUbicacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beUbicacion.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.beUbicacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.beUbicacion.Properties.MaxLength = 20;
            this.beUbicacion.Properties.NullText = "Escanee o selecciona una tarima";
            this.beUbicacion.Size = new System.Drawing.Size(436, 44);
            this.beUbicacion.TabIndex = 35;
            this.beUbicacion.ToolTip = "Hola";
            this.beUbicacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.beUbicacion_KeyDown);
            // 
            // cmdSelectTarima
            // 
            this.cmdSelectTarima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSelectTarima.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelectTarima.Appearance.Options.UseFont = true;
            this.cmdSelectTarima.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSelectTarima.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.cmdSelectTarima.Location = new System.Drawing.Point(619, 83);
            this.cmdSelectTarima.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSelectTarima.Name = "cmdSelectTarima";
            this.cmdSelectTarima.Size = new System.Drawing.Size(56, 49);
            this.cmdSelectTarima.TabIndex = 36;
            this.cmdSelectTarima.Visible = false;
            this.cmdSelectTarima.Click += new System.EventHandler(this.cmdSelectTarima_Click);
            // 
            // grd_ubicacion
            // 
            this.grd_ubicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_ubicacion.DataMember = "Tarimas";
            this.grd_ubicacion.DataSource = this.dsReportes;
            gridLevelNode1.RelationName = "Level1";
            this.grd_ubicacion.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grd_ubicacion.Location = new System.Drawing.Point(-1, 156);
            this.grd_ubicacion.MainView = this.grdv_ubicacio;
            this.grd_ubicacion.Name = "grd_ubicacion";
            this.grd_ubicacion.Size = new System.Drawing.Size(852, 532);
            this.grd_ubicacion.TabIndex = 37;
            this.grd_ubicacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_ubicacio});
            this.grd_ubicacion.Click += new System.EventHandler(this.grd_ubicacion_Click);
            // 
            // dsReportes
            // 
            this.dsReportes.DataSetName = "dsReportes";
            this.dsReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_ubicacio
            // 
            this.grdv_ubicacio.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.grdv_ubicacio.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_ubicacio.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.grdv_ubicacio.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_ubicacio.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.grdv_ubicacio.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_ubicacio.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.grdv_ubicacio.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_ubicacio.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_ubicacio.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_ubicacio.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.grdv_ubicacio.Appearance.Row.Options.UseFont = true;
            this.grdv_ubicacio.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.grdv_ubicacio.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_ubicacio.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigo_barra,
            this.colmaterial,
            this.colfecha_ingreso,
            this.colfecha_vencimiento,
            this.colcantidad,
            this.colnumero_transaccion,
            this.colpeso,
            this.collote});
            this.grdv_ubicacio.GridControl = this.grd_ubicacion;
            this.grdv_ubicacio.Name = "grdv_ubicacio";
            this.grdv_ubicacio.OptionsView.ShowGroupPanel = false;
            // 
            // colcodigo_barra
            // 
            this.colcodigo_barra.Caption = "Codigo";
            this.colcodigo_barra.FieldName = "codigo_barra";
            this.colcodigo_barra.Name = "colcodigo_barra";
            this.colcodigo_barra.OptionsColumn.AllowEdit = false;
            this.colcodigo_barra.Visible = true;
            this.colcodigo_barra.VisibleIndex = 2;
            this.colcodigo_barra.Width = 115;
            // 
            // colmaterial
            // 
            this.colmaterial.Caption = "Producto";
            this.colmaterial.FieldName = "material";
            this.colmaterial.Name = "colmaterial";
            this.colmaterial.OptionsColumn.AllowEdit = false;
            this.colmaterial.Visible = true;
            this.colmaterial.VisibleIndex = 3;
            this.colmaterial.Width = 128;
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.Caption = "Fecha Ingreso";
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.OptionsColumn.AllowEdit = false;
            this.colfecha_ingreso.Visible = true;
            this.colfecha_ingreso.VisibleIndex = 4;
            this.colfecha_ingreso.Width = 167;
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.Caption = "Fecha Vencimiento";
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.OptionsColumn.AllowEdit = false;
            this.colfecha_vencimiento.Visible = true;
            this.colfecha_vencimiento.VisibleIndex = 5;
            this.colfecha_vencimiento.Width = 209;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Unidades";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 6;
            this.colcantidad.Width = 103;
            // 
            // colnumero_transaccion
            // 
            this.colnumero_transaccion.Caption = "# Ingreso";
            this.colnumero_transaccion.FieldName = "ingreso";
            this.colnumero_transaccion.MinWidth = 25;
            this.colnumero_transaccion.Name = "colnumero_transaccion";
            this.colnumero_transaccion.Visible = true;
            this.colnumero_transaccion.VisibleIndex = 0;
            this.colnumero_transaccion.Width = 94;
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Kg totales";
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.OptionsColumn.AllowEdit = false;
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 7;
            this.colpeso.Width = 110;
            // 
            // collote
            // 
            this.collote.Caption = "# Lote";
            this.collote.FieldName = "lote";
            this.collote.MinWidth = 25;
            this.collote.Name = "collote";
            this.collote.Visible = true;
            this.collote.VisibleIndex = 1;
            this.collote.Width = 94;
            // 
            // frmreporteUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 689);
            this.Controls.Add(this.grd_ubicacion);
            this.Controls.Add(this.cmdSelectTarima);
            this.Controls.Add(this.beUbicacion);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmreporteUbicacion";
            this.Text = "frmreporteUbicacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmreporteUbicacion_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.beUbicacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ubicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_ubicacio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit beUbicacion;
        private DevExpress.XtraEditors.SimpleButton cmdSelectTarima;
        private DevExpress.XtraGrid.GridControl grd_ubicacion;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_ubicacio;
        private dsReportes dsReportes;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra;
        private DevExpress.XtraGrid.Columns.GridColumn colmaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
    }
}