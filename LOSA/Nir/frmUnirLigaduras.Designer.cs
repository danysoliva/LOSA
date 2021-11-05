
namespace LOSA.Nir
{
    partial class frmUnirLigaduras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnirLigaduras));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.lbMP = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtodoo = new DevExpress.XtraEditors.TextEdit();
            this.txtsap = new DevExpress.XtraEditors.TextEdit();
            this.txtmp = new DevExpress.XtraEditors.TextEdit();
            this.txtlote = new DevExpress.XtraEditors.TextEdit();
            this.txtingreso = new DevExpress.XtraEditors.TextEdit();
            this.grd_lecturas = new DevExpress.XtraGrid.GridControl();
            this.dsNir = new LOSA.Nir.dsNir();
            this.grdv_lecturas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDesvincular = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnUnir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtodoo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtingreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_lecturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_lecturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesvincular)).BeginInit();
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
            this.cmdHome.Location = new System.Drawing.Point(794, 5);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(199, 54);
            this.cmdHome.TabIndex = 9;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // lbMP
            // 
            this.lbMP.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMP.Appearance.Options.UseFont = true;
            this.lbMP.Location = new System.Drawing.Point(14, 121);
            this.lbMP.Name = "lbMP";
            this.lbMP.Size = new System.Drawing.Size(112, 21);
            this.lbMP.TabIndex = 10;
            this.lbMP.Text = "Materia Prima:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 155);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 21);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Lote:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(14, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(173, 21);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Codigo de produccion:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(14, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 21);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Codigo SAP:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(14, 189);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(128, 21);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Numero Ingreso:";
            // 
            // txtodoo
            // 
            this.txtodoo.Enabled = false;
            this.txtodoo.Location = new System.Drawing.Point(204, 48);
            this.txtodoo.Name = "txtodoo";
            this.txtodoo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtodoo.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtodoo.Properties.Appearance.Options.UseFont = true;
            this.txtodoo.Properties.Appearance.Options.UseForeColor = true;
            this.txtodoo.Size = new System.Drawing.Size(448, 28);
            this.txtodoo.TabIndex = 15;
            // 
            // txtsap
            // 
            this.txtsap.Enabled = false;
            this.txtsap.Location = new System.Drawing.Point(204, 81);
            this.txtsap.Name = "txtsap";
            this.txtsap.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtsap.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtsap.Properties.Appearance.Options.UseFont = true;
            this.txtsap.Properties.Appearance.Options.UseForeColor = true;
            this.txtsap.Size = new System.Drawing.Size(448, 28);
            this.txtsap.TabIndex = 16;
            // 
            // txtmp
            // 
            this.txtmp.Enabled = false;
            this.txtmp.Location = new System.Drawing.Point(204, 114);
            this.txtmp.Name = "txtmp";
            this.txtmp.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtmp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtmp.Properties.Appearance.Options.UseFont = true;
            this.txtmp.Properties.Appearance.Options.UseForeColor = true;
            this.txtmp.Size = new System.Drawing.Size(448, 28);
            this.txtmp.TabIndex = 17;
            // 
            // txtlote
            // 
            this.txtlote.Enabled = false;
            this.txtlote.Location = new System.Drawing.Point(204, 148);
            this.txtlote.Name = "txtlote";
            this.txtlote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtlote.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtlote.Properties.Appearance.Options.UseFont = true;
            this.txtlote.Properties.Appearance.Options.UseForeColor = true;
            this.txtlote.Size = new System.Drawing.Size(448, 28);
            this.txtlote.TabIndex = 18;
            // 
            // txtingreso
            // 
            this.txtingreso.Enabled = false;
            this.txtingreso.Location = new System.Drawing.Point(204, 182);
            this.txtingreso.Name = "txtingreso";
            this.txtingreso.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtingreso.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtingreso.Properties.Appearance.Options.UseFont = true;
            this.txtingreso.Properties.Appearance.Options.UseForeColor = true;
            this.txtingreso.Size = new System.Drawing.Size(448, 28);
            this.txtingreso.TabIndex = 19;
            // 
            // grd_lecturas
            // 
            this.grd_lecturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_lecturas.DataMember = "lecturas_ingreso";
            this.grd_lecturas.DataSource = this.dsNir;
            this.grd_lecturas.Location = new System.Drawing.Point(0, 270);
            this.grd_lecturas.MainView = this.grdv_lecturas;
            this.grd_lecturas.Name = "grd_lecturas";
            this.grd_lecturas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDesvincular});
            this.grd_lecturas.Size = new System.Drawing.Size(1003, 360);
            this.grd_lecturas.TabIndex = 20;
            this.grd_lecturas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_lecturas});
            // 
            // dsNir
            // 
            this.dsNir.DataSetName = "dsNir";
            this.dsNir.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_lecturas
            // 
            this.grdv_lecturas.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_lecturas.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_lecturas.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_lecturas.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_lecturas.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_lecturas.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_lecturas.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_lecturas.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_lecturas.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_lecturas.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_lecturas.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_lecturas.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_lecturas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_lecturas.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_lecturas.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_lecturas.Appearance.Preview.Options.UseFont = true;
            this.grdv_lecturas.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_lecturas.Appearance.Row.Options.UseFont = true;
            this.grdv_lecturas.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_lecturas.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_lecturas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnombre,
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
            this.collote,
            this.colnombre_producto,
            this.colactivo,
            this.colEliminar});
            this.grdv_lecturas.GridControl = this.grd_lecturas;
            this.grdv_lecturas.GroupCount = 1;
            this.grdv_lecturas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "broma_porcentaje", this.colbroma_porcentaje, "(BP: AVG={0:0.##})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "GH", this.colGH, "(GH: AVG={0:0.##})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "NB", this.colNB, "(NB: AVG={0:0.##})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "TS", this.colTS, "(TS: AVG={0:0.##})")});
            this.grdv_lecturas.Name = "grdv_lecturas";
            this.grdv_lecturas.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_lecturas.OptionsView.ShowAutoFilterRow = true;
            this.grdv_lecturas.OptionsView.ShowFooter = true;
            this.grdv_lecturas.OptionsView.ShowGroupPanel = false;
            this.grdv_lecturas.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colid_bromatologia, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Usuario link";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            // 
            // collectura
            // 
            this.collectura.Caption = "Lectura";
            this.collectura.FieldName = "lectura";
            this.collectura.Name = "collectura";
            this.collectura.OptionsColumn.AllowEdit = false;
            this.collectura.Visible = true;
            this.collectura.VisibleIndex = 1;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
            // 
            // colcurva
            // 
            this.colcurva.Caption = "Curva";
            this.colcurva.FieldName = "curva";
            this.colcurva.Name = "colcurva";
            this.colcurva.OptionsColumn.AllowEdit = false;
            this.colcurva.Visible = true;
            this.colcurva.VisibleIndex = 3;
            // 
            // coln_curva
            // 
            this.coln_curva.Caption = "Numero de Curva";
            this.coln_curva.FieldName = "n_curva";
            this.coln_curva.Name = "coln_curva";
            this.coln_curva.OptionsColumn.AllowEdit = false;
            this.coln_curva.Visible = true;
            this.coln_curva.VisibleIndex = 4;
            // 
            // colid_bromatologia
            // 
            this.colid_bromatologia.FieldName = "id_bromatologia";
            this.colid_bromatologia.Name = "colid_bromatologia";
            this.colid_bromatologia.OptionsColumn.AllowEdit = false;
            this.colid_bromatologia.Visible = true;
            this.colid_bromatologia.VisibleIndex = 5;
            // 
            // colbroma_porcentaje
            // 
            this.colbroma_porcentaje.Caption = "% Bromatologica";
            this.colbroma_porcentaje.FieldName = "broma_porcentaje";
            this.colbroma_porcentaje.Name = "colbroma_porcentaje";
            this.colbroma_porcentaje.OptionsColumn.AllowEdit = false;
            this.colbroma_porcentaje.Visible = true;
            this.colbroma_porcentaje.VisibleIndex = 5;
            // 
            // colGH
            // 
            this.colGH.FieldName = "GH";
            this.colGH.Name = "colGH";
            this.colGH.OptionsColumn.AllowEdit = false;
            // 
            // colNB
            // 
            this.colNB.FieldName = "NB";
            this.colNB.Name = "colNB";
            this.colNB.OptionsColumn.AllowEdit = false;
            // 
            // colTS
            // 
            this.colTS.FieldName = "TS";
            this.colTS.Name = "colTS";
            this.colTS.OptionsColumn.AllowEdit = false;
            // 
            // colcomentario
            // 
            this.colcomentario.FieldName = "comentario";
            this.colcomentario.Name = "colcomentario";
            this.colcomentario.OptionsColumn.AllowEdit = false;
            this.colcomentario.Visible = true;
            this.colcomentario.VisibleIndex = 6;
            // 
            // collote
            // 
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 7;
            // 
            // colnombre_producto
            // 
            this.colnombre_producto.Caption = "Producto";
            this.colnombre_producto.FieldName = "nombre_producto";
            this.colnombre_producto.Name = "colnombre_producto";
            this.colnombre_producto.OptionsColumn.AllowEdit = false;
            this.colnombre_producto.Visible = true;
            this.colnombre_producto.VisibleIndex = 8;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.Name = "colactivo";
            this.colactivo.OptionsColumn.AllowEdit = false;
            // 
            // colEliminar
            // 
            this.colEliminar.Caption = "Desvincular";
            this.colEliminar.ColumnEdit = this.btnDesvincular;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Visible = true;
            this.colEliminar.VisibleIndex = 9;
            // 
            // btnDesvincular
            // 
            this.btnDesvincular.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnDesvincular.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDesvincular.Name = "btnDesvincular";
            this.btnDesvincular.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDesvincular.Click += new System.EventHandler(this.btnDesvincular_Click);
            // 
            // btnUnir
            // 
            this.btnUnir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnir.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnir.Appearance.Options.UseFont = true;
            this.btnUnir.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.btnUnir.Location = new System.Drawing.Point(788, 216);
            this.btnUnir.Name = "btnUnir";
            this.btnUnir.Size = new System.Drawing.Size(201, 48);
            this.btnUnir.TabIndex = 21;
            this.btnUnir.Text = "Seleccionar Lectura";
            this.btnUnir.Click += new System.EventHandler(this.btnUnir_Click);
            // 
            // frmUnirLigaduras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 631);
            this.Controls.Add(this.btnUnir);
            this.Controls.Add(this.grd_lecturas);
            this.Controls.Add(this.txtingreso);
            this.Controls.Add(this.txtlote);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lbMP);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.txtmp);
            this.Controls.Add(this.txtsap);
            this.Controls.Add(this.txtodoo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUnirLigaduras";
            this.Text = "Unir Lecturas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.txtodoo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtingreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_lecturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_lecturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesvincular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.LabelControl lbMP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtodoo;
        private DevExpress.XtraEditors.TextEdit txtsap;
        private DevExpress.XtraEditors.TextEdit txtmp;
        private DevExpress.XtraEditors.TextEdit txtlote;
        private DevExpress.XtraEditors.TextEdit txtingreso;
        private DevExpress.XtraGrid.GridControl grd_lecturas;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_lecturas;
        private DevExpress.XtraEditors.SimpleButton btnUnir;
        private dsNir dsNir;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
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
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_producto;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraGrid.Columns.GridColumn colEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDesvincular;
    }
}