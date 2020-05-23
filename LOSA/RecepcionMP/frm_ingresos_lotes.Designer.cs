namespace LOSA.RecepcionMP
{
    partial class frm_ingresos_lotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ingresos_lotes));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmateriaprima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_boleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDuplicar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdDuplicar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Editar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colnum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dsRecepcionMPx = new LOSA.RecepcionMP.dsRecepcionMPx();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDuplicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(625, 7);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(178, 58);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Appearance.Options.UseBackColor = true;
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAgregar.ImageOptions.Image = global::LOSA.Properties.Resources.plus;
            this.btnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAgregar.Location = new System.Drawing.Point(13, 7);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(180, 58);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar lote";
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
            this.labelControl3.Location = new System.Drawing.Point(247, 21);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(330, 44);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "Resumen de ingreso";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "lista_tarimas";
            this.gridControl1.DataSource = this.dsRecepcionMPx;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(-20, 105);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnPrint,
            this.cmdDuplicar,
            this.btnEditar});
            this.gridControl1.Size = new System.Drawing.Size(833, 491);
            this.gridControl1.TabIndex = 52;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_materia_prima,
            this.colmateriaprima,
            this.colid_proveedor,
            this.colproveedor,
            this.colfecha_ingreso,
            this.colnumero_transaccion,
            this.collote_materia_prima,
            this.colid_boleta,
            this.colPrint,
            this.colDuplicar,
            this.Editar,
            this.colnum});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_materia_prima
            // 
            this.colid_materia_prima.FieldName = "id_materia_prima";
            this.colid_materia_prima.Name = "colid_materia_prima";
            // 
            // colmateriaprima
            // 
            this.colmateriaprima.Caption = "Materia Prima";
            this.colmateriaprima.FieldName = "materiaprima";
            this.colmateriaprima.Name = "colmateriaprima";
            this.colmateriaprima.OptionsColumn.AllowEdit = false;
            this.colmateriaprima.Visible = true;
            this.colmateriaprima.VisibleIndex = 1;
            this.colmateriaprima.Width = 63;
            // 
            // colid_proveedor
            // 
            this.colid_proveedor.FieldName = "id_proveedor";
            this.colid_proveedor.Name = "colid_proveedor";
            // 
            // colproveedor
            // 
            this.colproveedor.Caption = "Proveedor";
            this.colproveedor.FieldName = "proveedor";
            this.colproveedor.Name = "colproveedor";
            this.colproveedor.OptionsColumn.AllowEdit = false;
            this.colproveedor.Visible = true;
            this.colproveedor.VisibleIndex = 2;
            this.colproveedor.Width = 63;
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.Caption = "Fecha Ingreso";
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.OptionsColumn.AllowEdit = false;
            this.colfecha_ingreso.Visible = true;
            this.colfecha_ingreso.VisibleIndex = 3;
            this.colfecha_ingreso.Width = 63;
            // 
            // colnumero_transaccion
            // 
            this.colnumero_transaccion.Caption = "# Ingreso";
            this.colnumero_transaccion.FieldName = "numero_transaccion";
            this.colnumero_transaccion.Name = "colnumero_transaccion";
            this.colnumero_transaccion.OptionsColumn.AllowEdit = false;
            this.colnumero_transaccion.Visible = true;
            this.colnumero_transaccion.VisibleIndex = 4;
            this.colnumero_transaccion.Width = 63;
            // 
            // collote_materia_prima
            // 
            this.collote_materia_prima.Caption = "Lote";
            this.collote_materia_prima.FieldName = "lote_materia_prima";
            this.collote_materia_prima.Name = "collote_materia_prima";
            this.collote_materia_prima.OptionsColumn.AllowEdit = false;
            this.collote_materia_prima.Visible = true;
            this.collote_materia_prima.VisibleIndex = 5;
            this.collote_materia_prima.Width = 63;
            // 
            // colid_boleta
            // 
            this.colid_boleta.Caption = "# Boleta";
            this.colid_boleta.FieldName = "id_boleta";
            this.colid_boleta.Name = "colid_boleta";
            this.colid_boleta.OptionsColumn.AllowEdit = false;
            this.colid_boleta.Visible = true;
            this.colid_boleta.VisibleIndex = 6;
            this.colid_boleta.Width = 63;
            // 
            // colPrint
            // 
            this.colPrint.Caption = "Imprimir";
            this.colPrint.ColumnEdit = this.btnPrint;
            this.colPrint.Name = "colPrint";
            this.colPrint.Visible = true;
            this.colPrint.VisibleIndex = 7;
            this.colPrint.Width = 63;
            // 
            // btnPrint
            // 
            this.btnPrint.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnPrint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // colDuplicar
            // 
            this.colDuplicar.Caption = "Duplicar";
            this.colDuplicar.ColumnEdit = this.cmdDuplicar;
            this.colDuplicar.Name = "colDuplicar";
            this.colDuplicar.Visible = true;
            this.colDuplicar.VisibleIndex = 8;
            this.colDuplicar.Width = 63;
            // 
            // cmdDuplicar
            // 
            this.cmdDuplicar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdDuplicar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.cmdDuplicar.Name = "cmdDuplicar";
            this.cmdDuplicar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdDuplicar.Click += new System.EventHandler(this.cmdDuplicar_Click);
            // 
            // Editar
            // 
            this.Editar.Caption = "Editar";
            this.Editar.ColumnEdit = this.btnEditar;
            this.Editar.Name = "Editar";
            this.Editar.Visible = true;
            this.Editar.VisibleIndex = 9;
            this.Editar.Width = 71;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btnEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions3, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // colnum
            // 
            this.colnum.Caption = "#";
            this.colnum.FieldName = "num";
            this.colnum.Name = "colnum";
            this.colnum.Visible = true;
            this.colnum.VisibleIndex = 0;
            this.colnum.Width = 46;
            // 
            // dsRecepcionMPx
            // 
            this.dsRecepcionMPx.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frm_ingresos_lotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 594);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ingresos_lotes";
            this.Text = "frm_ingresos_lotes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDuplicar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colmateriaprima;
        private DevExpress.XtraGrid.Columns.GridColumn colid_proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colproveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn collote_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colid_boleta;
        private DevExpress.XtraGrid.Columns.GridColumn colPrint;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnPrint;
        private DevExpress.XtraGrid.Columns.GridColumn colDuplicar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdDuplicar;
        private DevExpress.XtraGrid.Columns.GridColumn Editar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditar;
        private DevExpress.XtraGrid.Columns.GridColumn colnum;
        private dsRecepcionMPx dsRecepcionMPx;
    }
}