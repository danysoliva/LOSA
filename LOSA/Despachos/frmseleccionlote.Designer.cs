namespace LOSA.Despachos
{
    partial class frmseleccionlote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmseleccionlote));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grd_lote = new DevExpress.XtraGrid.GridControl();
            this.ds_despachos = new LOSA.Despachos.ds_despachos();
            this.grdv_lote = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcants = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtitem = new DevExpress.XtraEditors.TextEdit();
            this.txtunidades = new DevExpress.XtraEditors.TextEdit();
            this.txtAsignadas = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.btnatras = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_lote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_lote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtitem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtunidades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsignadas.Properties)).BeginInit();
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
            this.labelControl1.Location = new System.Drawing.Point(179, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(464, 49);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "Planificacion de Despacho";
            // 
            // grd_lote
            // 
            this.grd_lote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_lote.DataMember = "detalle_lote_pt";
            this.grd_lote.DataSource = this.ds_despachos;
            this.grd_lote.Location = new System.Drawing.Point(0, 201);
            this.grd_lote.MainView = this.grdv_lote;
            this.grd_lote.Name = "grd_lote";
            this.grd_lote.Size = new System.Drawing.Size(851, 488);
            this.grd_lote.TabIndex = 38;
            this.grd_lote.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_lote});
            // 
            // ds_despachos
            // 
            this.ds_despachos.DataSetName = "ds_despachos";
            this.ds_despachos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_lote
            // 
            this.grdv_lote.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.grdv_lote.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdv_lote.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.grdv_lote.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.grdv_lote.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_lote.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdv_lote.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_lote.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_lote.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_lote.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.grdv_lote.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdv_lote.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_lote.Appearance.Row.Options.UseFont = true;
            this.grdv_lote.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_lote.Appearance.SelectedRow.Options.UseFont = true;
            this.grdv_lote.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.grdv_lote.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grdv_lote.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_proveedor,
            this.colNombre,
            this.colingreso,
            this.colvence,
            this.collote_mp,
            this.colpresentacion,
            this.colcantidad,
            this.colunidad,
            this.colpeso_total,
            this.colseleccionado,
            this.colcants});
            this.grdv_lote.GridControl = this.grd_lote;
            this.grdv_lote.Name = "grdv_lote";
            this.grdv_lote.OptionsCustomization.AllowFilter = false;
            this.grdv_lote.OptionsView.ShowAutoFilterRow = true;
            this.grdv_lote.OptionsView.ShowFooter = true;
            this.grdv_lote.OptionsView.ShowGroupPanel = false;
            this.grdv_lote.RowHeight = 20;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_proveedor
            // 
            this.colid_proveedor.FieldName = "id_proveedor";
            this.colid_proveedor.Name = "colid_proveedor";
            this.colid_proveedor.Visible = true;
            this.colid_proveedor.VisibleIndex = 10;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Proveedor";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            // 
            // colingreso
            // 
            this.colingreso.Caption = "Fecha Ingreso";
            this.colingreso.FieldName = "ingreso";
            this.colingreso.Name = "colingreso";
            this.colingreso.OptionsColumn.AllowEdit = false;
            this.colingreso.Visible = true;
            this.colingreso.VisibleIndex = 1;
            // 
            // colvence
            // 
            this.colvence.Caption = "Fecha Vence";
            this.colvence.FieldName = "vence";
            this.colvence.Name = "colvence";
            this.colvence.OptionsColumn.AllowEdit = false;
            this.colvence.Visible = true;
            this.colvence.VisibleIndex = 2;
            // 
            // collote_mp
            // 
            this.collote_mp.Caption = "Lote PM";
            this.collote_mp.FieldName = "lote_pt";
            this.collote_mp.Name = "collote_mp";
            this.collote_mp.OptionsColumn.AllowEdit = false;
            this.collote_mp.Visible = true;
            this.collote_mp.VisibleIndex = 3;
            // 
            // colpresentacion
            // 
            this.colpresentacion.Caption = "Presentación";
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.OptionsColumn.AllowEdit = false;
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 4;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Unidades";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 5;
            // 
            // colunidad
            // 
            this.colunidad.Caption = "Unidad Medida";
            this.colunidad.FieldName = "unidad";
            this.colunidad.Name = "colunidad";
            this.colunidad.OptionsColumn.AllowEdit = false;
            this.colunidad.Visible = true;
            this.colunidad.VisibleIndex = 6;
            // 
            // colpeso_total
            // 
            this.colpeso_total.Caption = "Peso por tarima";
            this.colpeso_total.FieldName = "peso_total";
            this.colpeso_total.Name = "colpeso_total";
            this.colpeso_total.OptionsColumn.AllowEdit = false;
            this.colpeso_total.Visible = true;
            this.colpeso_total.VisibleIndex = 7;
            // 
            // colseleccionado
            // 
            this.colseleccionado.Caption = "Seleccionar";
            this.colseleccionado.FieldName = "seleccionado";
            this.colseleccionado.Name = "colseleccionado";
            this.colseleccionado.Visible = true;
            this.colseleccionado.VisibleIndex = 8;
            // 
            // colcants
            // 
            this.colcants.Caption = "Cantidad a Enviar";
            this.colcants.FieldName = "cants";
            this.colcants.Name = "colcants";
            this.colcants.Visible = true;
            this.colcants.VisibleIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(42, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(187, 24);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Producto Terminado:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(42, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(156, 24);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "Unidades totales:";
            // 
            // txtitem
            // 
            this.txtitem.Enabled = false;
            this.txtitem.Location = new System.Drawing.Point(251, 73);
            this.txtitem.Name = "txtitem";
            this.txtitem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitem.Properties.Appearance.Options.UseFont = true;
            this.txtitem.Size = new System.Drawing.Size(443, 30);
            this.txtitem.TabIndex = 41;
            // 
            // txtunidades
            // 
            this.txtunidades.Enabled = false;
            this.txtunidades.Location = new System.Drawing.Point(251, 116);
            this.txtunidades.Name = "txtunidades";
            this.txtunidades.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtunidades.Properties.Appearance.Options.UseFont = true;
            this.txtunidades.Size = new System.Drawing.Size(100, 30);
            this.txtunidades.TabIndex = 42;
            // 
            // txtAsignadas
            // 
            this.txtAsignadas.Enabled = false;
            this.txtAsignadas.Location = new System.Drawing.Point(593, 116);
            this.txtAsignadas.Name = "txtAsignadas";
            this.txtAsignadas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsignadas.Properties.Appearance.Options.UseFont = true;
            this.txtAsignadas.Size = new System.Drawing.Size(100, 30);
            this.txtAsignadas.TabIndex = 44;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(357, 119);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(218, 24);
            this.labelControl4.TabIndex = 43;
            this.labelControl4.Text = "Unidades seleccionadas:";
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodos.Location = new System.Drawing.Point(24, 165);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(4);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(174, 29);
            this.chkTodos.TabIndex = 46;
            this.chkTodos.Text = "Autoseleccionar";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // btnatras
            // 
            this.btnatras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnatras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatras.Appearance.Options.UseBackColor = true;
            this.btnatras.Appearance.Options.UseFont = true;
            this.btnatras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnatras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnatras.ImageOptions.Image")));
            this.btnatras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnatras.Location = new System.Drawing.Point(13, 11);
            this.btnatras.Margin = new System.Windows.Forms.Padding(4);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(118, 54);
            this.btnatras.TabIndex = 47;
            this.btnatras.Text = "Atras";
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.Location = new System.Drawing.Point(690, 7);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(118, 55);
            this.simpleButton1.TabIndex = 48;
            this.simpleButton1.Text = "Guardar";
            // 
            // frmseleccionlote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 689);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.txtAsignadas);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtunidades);
            this.Controls.Add(this.txtitem);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.grd_lote);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmseleccionlote";
            this.Text = "frmseleccionlote";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_lote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_lote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtitem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtunidades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsignadas.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grd_lote;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_lote;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtitem;
        private DevExpress.XtraEditors.TextEdit txtunidades;
        private DevExpress.XtraEditors.TextEdit txtAsignadas;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.CheckBox chkTodos;
        private ds_despachos ds_despachos;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colvence;
        private DevExpress.XtraGrid.Columns.GridColumn collote_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colunidad;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_total;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colcants;
        private DevExpress.XtraEditors.SimpleButton btnatras;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}