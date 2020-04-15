namespace LOSA.Despachos
{
    partial class frmplanesdecarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmplanesdecarga));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.ds_despachos = new LOSA.Despachos.ds_despachos();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_tarima_s = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colubicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.beIdTarima = new DevExpress.XtraEditors.ButtonEdit();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beIdTarima.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(31, 55);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(167, 49);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "Tarimas:";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "entregacomp";
            this.gridControl1.DataSource = this.ds_despachos;
            this.gridControl1.Location = new System.Drawing.Point(1, 144);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(830, 499);
            this.gridControl1.TabIndex = 38;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ds_despachos
            // 
            this.ds_despachos.DataSetName = "ds_despachos";
            this.ds_despachos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_tarima_s,
            this.colid_materia_prima,
            this.colmp,
            this.collote_mp,
            this.colubicacion,
            this.colcantidad,
            this.colbarcode,
            this.colproc});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 20;
            // 
            // colid_tarima_s
            // 
            this.colid_tarima_s.FieldName = "id_tarima_s";
            this.colid_tarima_s.Name = "colid_tarima_s";
            // 
            // colid_materia_prima
            // 
            this.colid_materia_prima.FieldName = "idpt";
            this.colid_materia_prima.Name = "colid_materia_prima";
            // 
            // colmp
            // 
            this.colmp.Caption = "Materia Prima";
            this.colmp.FieldName = "pt";
            this.colmp.Name = "colmp";
            this.colmp.OptionsColumn.AllowEdit = false;
            this.colmp.Visible = true;
            this.colmp.VisibleIndex = 0;
            // 
            // collote_mp
            // 
            this.collote_mp.Caption = "Lote MP";
            this.collote_mp.FieldName = "lote_pt";
            this.collote_mp.Name = "collote_mp";
            this.collote_mp.OptionsColumn.AllowEdit = false;
            this.collote_mp.Visible = true;
            this.collote_mp.VisibleIndex = 1;
            // 
            // colubicacion
            // 
            this.colubicacion.Caption = "Ubicación";
            this.colubicacion.FieldName = "ubicacion";
            this.colubicacion.Name = "colubicacion";
            this.colubicacion.OptionsColumn.AllowEdit = false;
            this.colubicacion.Visible = true;
            this.colubicacion.VisibleIndex = 2;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 3;
            // 
            // colbarcode
            // 
            this.colbarcode.Caption = "Cod. Barra";
            this.colbarcode.FieldName = "barcode";
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.OptionsColumn.AllowEdit = false;
            this.colbarcode.Visible = true;
            this.colbarcode.VisibleIndex = 4;
            // 
            // colproc
            // 
            this.colproc.FieldName = "proc";
            this.colproc.Name = "colproc";
            // 
            // beIdTarima
            // 
            this.beIdTarima.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.beIdTarima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beIdTarima.EditValue = "";
            this.beIdTarima.Location = new System.Drawing.Point(181, 62);
            this.beIdTarima.Margin = new System.Windows.Forms.Padding(4);
            this.beIdTarima.Name = "beIdTarima";
            this.beIdTarima.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beIdTarima.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.beIdTarima.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.beIdTarima.Properties.MaxLength = 20;
            this.beIdTarima.Properties.NullText = "Escanee o selecciona una tarima";
            this.beIdTarima.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beIdTarima_Properties_ButtonClick);
            this.beIdTarima.Size = new System.Drawing.Size(411, 52);
            this.beIdTarima.TabIndex = 39;
            this.beIdTarima.ToolTip = "Ingresa el Cod. de Barra de tarima";
            this.beIdTarima.KeyDown += new System.Windows.Forms.KeyEventHandler(this.beIdTarima_KeyDown);
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
            this.cmdHome.Location = new System.Drawing.Point(600, 27);
            this.cmdHome.Margin = new System.Windows.Forms.Padding(4);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(233, 87);
            this.cmdHome.TabIndex = 40;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // frmplanesdecarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 642);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.beIdTarima);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmplanesdecarga";
            this.Text = "frmplanesdecarga";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beIdTarima.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tarima_s;
        private DevExpress.XtraGrid.Columns.GridColumn colid_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colmp;
        private DevExpress.XtraGrid.Columns.GridColumn collote_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colubicacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colbarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colproc;
        private DevExpress.XtraEditors.ButtonEdit beIdTarima;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private ds_despachos ds_despachos;
    }
}