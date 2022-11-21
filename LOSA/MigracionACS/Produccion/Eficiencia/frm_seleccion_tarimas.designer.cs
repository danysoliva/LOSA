
namespace LOSA.MigracionACS.Produccion.Eficiencia
{
    partial class frm_seleccion_tarimas
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_seleccion_tarimas));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdCancelar = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.tarimasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLotePick = new LOSA.MigracionACS.Produccion.Eficiencia.dsLotePick();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodebar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colselecionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtcantidad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chAutoseleccionar = new DevExpress.XtraEditors.CheckEdit();
            this.chtodas = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtlote = new DevExpress.XtraEditors.TextEdit();
            this.txtdisponible = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtselecionada = new DevExpress.XtraEditors.TextEdit();
            this.cmdGuardar = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCancelar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarimasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLotePick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chAutoseleccionar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtodas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdisponible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtselecionada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancelar.EditValue = "Cancelar";
            this.cmdCancelar.Location = new System.Drawing.Point(529, 12);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Properties.Appearance.BackColor = System.Drawing.Color.LightCoral;
            this.cmdCancelar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Properties.Appearance.Options.UseBackColor = true;
            this.cmdCancelar.Properties.Appearance.Options.UseFont = true;
            this.cmdCancelar.Properties.Appearance.Options.UseTextOptions = true;
            this.cmdCancelar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmdCancelar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdCancelar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdCancelar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmdCancelar.Size = new System.Drawing.Size(112, 36);
            this.cmdCancelar.TabIndex = 75;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(382, 21);
            this.labelControl1.TabIndex = 76;
            this.labelControl1.Text = "Selecciona las tarimas que salieron de la produccion:";
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataSource = this.tarimasBindingSource;
            this.grd_data.Location = new System.Drawing.Point(1, 200);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(652, 415);
            this.grd_data.TabIndex = 77;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // tarimasBindingSource
            // 
            this.tarimasBindingSource.DataMember = "tarimas";
            this.tarimasBindingSource.DataSource = this.dsLotePick;
            // 
            // dsLotePick
            // 
            this.dsLotePick.DataSetName = "dsLotePick";
            this.dsLotePick.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grdv_data.Appearance.Empty.Options.UseFont = true;
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcodebar,
            this.collote,
            this.colproducto,
            this.colpresentacion,
            this.colcantidad,
            this.colpeso,
            this.colselecionado});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowFooter = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.grdv_data_RowStyle);
            this.grdv_data.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdv_data_CellValueChanging);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colcodebar
            // 
            this.colcodebar.Caption = "Codigo";
            this.colcodebar.FieldName = "codebar";
            this.colcodebar.Name = "colcodebar";
            this.colcodebar.OptionsColumn.AllowEdit = false;
            this.colcodebar.Visible = true;
            this.colcodebar.VisibleIndex = 0;
            this.colcodebar.Width = 105;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 1;
            this.collote.Width = 64;
            // 
            // colproducto
            // 
            this.colproducto.Caption = "Producto";
            this.colproducto.FieldName = "producto";
            this.colproducto.Name = "colproducto";
            this.colproducto.OptionsColumn.AllowEdit = false;
            this.colproducto.Visible = true;
            this.colproducto.VisibleIndex = 2;
            this.colproducto.Width = 91;
            // 
            // colpresentacion
            // 
            this.colpresentacion.Caption = "Presentacion";
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.OptionsColumn.AllowEdit = false;
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 3;
            this.colpresentacion.Width = 101;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Ud.";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "Suma={0:0.##} Ud.")});
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 4;
            this.colcantidad.Width = 104;
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Peso Kg.";
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.OptionsColumn.AllowEdit = false;
            this.colpeso.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "peso", "Suma ={0:0.##} Kg")});
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 5;
            this.colpeso.Width = 93;
            // 
            // colselecionado
            // 
            this.colselecionado.Caption = "Selecionar";
            this.colselecionado.FieldName = "selecionado";
            this.colselecionado.Name = "colselecionado";
            this.colselecionado.Visible = true;
            this.colselecionado.VisibleIndex = 6;
            this.colselecionado.Width = 76;
            // 
            // txtcantidad
            // 
            this.txtcantidad.EditValue = "0";
            this.txtcantidad.Location = new System.Drawing.Point(179, 105);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtcantidad.Properties.Appearance.Options.UseFont = true;
            this.txtcantidad.Size = new System.Drawing.Size(100, 26);
            this.txtcantidad.TabIndex = 78;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 108);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(172, 21);
            this.labelControl2.TabIndex = 79;
            this.labelControl2.Text = "Cantidad requerida:____";
            // 
            // chAutoseleccionar
            // 
            this.chAutoseleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chAutoseleccionar.Location = new System.Drawing.Point(489, 169);
            this.chAutoseleccionar.Name = "chAutoseleccionar";
            this.chAutoseleccionar.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.chAutoseleccionar.Properties.Appearance.Options.UseFont = true;
            this.chAutoseleccionar.Properties.Caption = "Auto seleccionar";
            this.chAutoseleccionar.Size = new System.Drawing.Size(152, 25);
            this.chAutoseleccionar.TabIndex = 80;
            this.chAutoseleccionar.CheckedChanged += new System.EventHandler(this.chAutoseleccionar_CheckedChanged);
            // 
            // chtodas
            // 
            this.chtodas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chtodas.Location = new System.Drawing.Point(331, 169);
            this.chtodas.Name = "chtodas";
            this.chtodas.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.chtodas.Properties.Appearance.Options.UseFont = true;
            this.chtodas.Properties.Caption = "Seleccionar todas";
            this.chtodas.Size = new System.Drawing.Size(152, 25);
            this.chtodas.TabIndex = 81;
            this.chtodas.CheckedChanged += new System.EventHandler(this.chtodas_CheckedChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 140);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(191, 21);
            this.labelControl3.TabIndex = 82;
            this.labelControl3.Text = "Lote:______________________";
            // 
            // txtlote
            // 
            this.txtlote.Enabled = false;
            this.txtlote.Location = new System.Drawing.Point(179, 137);
            this.txtlote.Name = "txtlote";
            this.txtlote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtlote.Properties.Appearance.Options.UseFont = true;
            this.txtlote.Size = new System.Drawing.Size(100, 26);
            this.txtlote.TabIndex = 83;
            // 
            // txtdisponible
            // 
            this.txtdisponible.Enabled = false;
            this.txtdisponible.Location = new System.Drawing.Point(483, 99);
            this.txtdisponible.Name = "txtdisponible";
            this.txtdisponible.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisponible.Properties.Appearance.Options.UseFont = true;
            this.txtdisponible.Size = new System.Drawing.Size(108, 26);
            this.txtdisponible.TabIndex = 84;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(285, 104);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(220, 21);
            this.labelControl4.TabIndex = 85;
            this.labelControl4.Text = "Cantidad disponible:__________";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(285, 136);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(217, 21);
            this.labelControl5.TabIndex = 87;
            this.labelControl5.Text = "Cantidad Selecionada:________";
            // 
            // txtselecionada
            // 
            this.txtselecionada.EditValue = "0";
            this.txtselecionada.Enabled = false;
            this.txtselecionada.Location = new System.Drawing.Point(483, 131);
            this.txtselecionada.Name = "txtselecionada";
            this.txtselecionada.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtselecionada.Properties.Appearance.Options.UseFont = true;
            this.txtselecionada.Size = new System.Drawing.Size(108, 26);
            this.txtselecionada.TabIndex = 86;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGuardar.EditValue = "Aceptar";
            this.cmdGuardar.Location = new System.Drawing.Point(11, 12);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Properties.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.cmdGuardar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Properties.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Properties.Appearance.Options.UseFont = true;
            this.cmdGuardar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            this.cmdGuardar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdGuardar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmdGuardar.Size = new System.Drawing.Size(112, 36);
            this.cmdGuardar.TabIndex = 88;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // frm_seleccion_tarimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 611);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.txtselecionada);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtdisponible);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtlote);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.chtodas);
            this.Controls.Add(this.chAutoseleccionar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdCancelar);
            this.Name = "frm_seleccion_tarimas";
            this.Text = "Seleccion de tarimas";
            ((System.ComponentModel.ISupportInitialize)(this.cmdCancelar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarimasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLotePick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chAutoseleccionar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtodas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdisponible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtselecionada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGuardar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit cmdCancelar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraEditors.TextEdit txtcantidad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit chAutoseleccionar;
        private DevExpress.XtraEditors.CheckEdit chtodas;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtlote;
        private System.Windows.Forms.BindingSource tarimasBindingSource;
        private dsLotePick dsLotePick;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcodebar;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn colselecionado;
        private DevExpress.XtraEditors.TextEdit txtdisponible;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtselecionada;
        private DevExpress.XtraEditors.ButtonEdit cmdGuardar;
    }
}