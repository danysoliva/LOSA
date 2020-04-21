namespace LOSA.Despachos
{
    partial class frmRequisicion_Seleccion_Lote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequisicion_Seleccion_Lote));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSolicitada = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAsignada = new DevExpress.XtraEditors.TextEdit();
            this.chkAutoSelect = new System.Windows.Forms.CheckBox();
            this.lblUnidad = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidadPendiente = new DevExpress.XtraEditors.TextEdit();
            this.txtMP_Name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoMP = new DevExpress.XtraEditors.TextEdit();
            this.grd_lotes = new DevExpress.XtraGrid.GridControl();
            this.grdv_lotes = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ds_despachos = new LOSA.Despachos.ds_despachos();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSolicitada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsignada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadPendiente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMP_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoMP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_lotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_lotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).BeginInit();
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
            this.labelControl1.Location = new System.Drawing.Point(141, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(464, 49);
            this.labelControl1.TabIndex = 38;
            this.labelControl1.Text = "Gestión de Lotes";
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
            this.btnAtras.Location = new System.Drawing.Point(597, 13);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(223, 58);
            this.btnAtras.TabIndex = 39;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(444, 143);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(196, 30);
            this.labelControl6.TabIndex = 63;
            this.labelControl6.Text = "Unidad Medida:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(7, 143);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(183, 29);
            this.labelControl5.TabIndex = 62;
            this.labelControl5.Text = "Cant. Solicitada";
            // 
            // txtSolicitada
            // 
            this.txtSolicitada.EditValue = "0.00";
            this.txtSolicitada.Enabled = false;
            this.txtSolicitada.Location = new System.Drawing.Point(240, 138);
            this.txtSolicitada.Margin = new System.Windows.Forms.Padding(4);
            this.txtSolicitada.Name = "txtSolicitada";
            this.txtSolicitada.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolicitada.Properties.Appearance.Options.UseFont = true;
            this.txtSolicitada.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSolicitada.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSolicitada.Size = new System.Drawing.Size(189, 38);
            this.txtSolicitada.TabIndex = 61;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(7, 191);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(175, 29);
            this.labelControl4.TabIndex = 60;
            this.labelControl4.Text = "Cant. Asignada";
            // 
            // txtAsignada
            // 
            this.txtAsignada.EditValue = "0.00";
            this.txtAsignada.Enabled = false;
            this.txtAsignada.Location = new System.Drawing.Point(240, 186);
            this.txtAsignada.Margin = new System.Windows.Forms.Padding(4);
            this.txtAsignada.Name = "txtAsignada";
            this.txtAsignada.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsignada.Properties.Appearance.Options.UseFont = true;
            this.txtAsignada.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAsignada.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAsignada.Size = new System.Drawing.Size(189, 38);
            this.txtAsignada.TabIndex = 59;
            // 
            // chkAutoSelect
            // 
            this.chkAutoSelect.AutoSize = true;
            this.chkAutoSelect.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAutoSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoSelect.Location = new System.Drawing.Point(466, 196);
            this.chkAutoSelect.Margin = new System.Windows.Forms.Padding(4);
            this.chkAutoSelect.Name = "chkAutoSelect";
            this.chkAutoSelect.Size = new System.Drawing.Size(180, 29);
            this.chkAutoSelect.TabIndex = 58;
            this.chkAutoSelect.Text = "Auto Selección";
            this.chkAutoSelect.UseVisualStyleBackColor = true;
            // 
            // lblUnidad
            // 
            this.lblUnidad.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Appearance.Options.UseFont = true;
            this.lblUnidad.Appearance.Options.UseTextOptions = true;
            this.lblUnidad.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblUnidad.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUnidad.Location = new System.Drawing.Point(644, 143);
            this.lblUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(188, 30);
            this.lblUnidad.TabIndex = 57;
            this.lblUnidad.Text = "Ud";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 238);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(186, 29);
            this.labelControl2.TabIndex = 56;
            this.labelControl2.Text = "Cant. Pendiente";
            // 
            // txtCantidadPendiente
            // 
            this.txtCantidadPendiente.EditValue = "0.00";
            this.txtCantidadPendiente.Enabled = false;
            this.txtCantidadPendiente.Location = new System.Drawing.Point(240, 233);
            this.txtCantidadPendiente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadPendiente.Name = "txtCantidadPendiente";
            this.txtCantidadPendiente.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadPendiente.Properties.Appearance.Options.UseFont = true;
            this.txtCantidadPendiente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantidadPendiente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCantidadPendiente.Size = new System.Drawing.Size(189, 38);
            this.txtCantidadPendiente.TabIndex = 55;
            // 
            // txtMP_Name
            // 
            this.txtMP_Name.EditValue = "";
            this.txtMP_Name.Enabled = false;
            this.txtMP_Name.Location = new System.Drawing.Point(438, 88);
            this.txtMP_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txtMP_Name.Name = "txtMP_Name";
            this.txtMP_Name.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMP_Name.Properties.Appearance.Options.UseFont = true;
            this.txtMP_Name.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMP_Name.Size = new System.Drawing.Size(388, 34);
            this.txtMP_Name.TabIndex = 54;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(7, 88);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(162, 29);
            this.labelControl3.TabIndex = 53;
            this.labelControl3.Text = "Materia Prima";
            // 
            // txtCodigoMP
            // 
            this.txtCodigoMP.EditValue = "";
            this.txtCodigoMP.Enabled = false;
            this.txtCodigoMP.Location = new System.Drawing.Point(240, 88);
            this.txtCodigoMP.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoMP.Name = "txtCodigoMP";
            this.txtCodigoMP.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoMP.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoMP.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoMP.Size = new System.Drawing.Size(189, 34);
            this.txtCodigoMP.TabIndex = 52;
            // 
            // grd_lotes
            // 
            this.grd_lotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_lotes.DataMember = "detalle_lote_mp";
            this.grd_lotes.DataSource = this.ds_despachos;
            this.grd_lotes.Location = new System.Drawing.Point(7, 278);
            this.grd_lotes.MainView = this.grdv_lotes;
            this.grd_lotes.Name = "grd_lotes";
            this.grd_lotes.Size = new System.Drawing.Size(825, 363);
            this.grd_lotes.TabIndex = 64;
            this.grd_lotes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_lotes});
            // 
            // grdv_lotes
            // 
            this.grdv_lotes.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.grdv_lotes.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdv_lotes.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.grdv_lotes.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.grdv_lotes.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_lotes.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdv_lotes.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_lotes.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_lotes.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_lotes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.grdv_lotes.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdv_lotes.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_lotes.Appearance.Row.Options.UseFont = true;
            this.grdv_lotes.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_lotes.Appearance.SelectedRow.Options.UseFont = true;
            this.grdv_lotes.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.grdv_lotes.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grdv_lotes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.grdv_lotes.GridControl = this.grd_lotes;
            this.grdv_lotes.Name = "grdv_lotes";
            this.grdv_lotes.OptionsCustomization.AllowFilter = false;
            this.grdv_lotes.OptionsView.ShowAutoFilterRow = true;
            this.grdv_lotes.OptionsView.ShowFooter = true;
            this.grdv_lotes.OptionsView.ShowGroupPanel = false;
            this.grdv_lotes.RowHeight = 20;
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
            this.collote_mp.Caption = "Lote MP";
            this.collote_mp.FieldName = "lote_mp";
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
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ds_despachos
            // 
            this.ds_despachos.DataSetName = "ds_despachos";
            this.ds_despachos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(7, 7);
            this.cmdGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(223, 58);
            this.cmdGuardar.TabIndex = 65;
            this.cmdGuardar.Text = "Planificar";
            // 
            // frmRequisicion_Seleccion_Lote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 642);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.grd_lotes);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtSolicitada);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtAsignada);
            this.Controls.Add(this.chkAutoSelect);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCantidadPendiente);
            this.Controls.Add(this.txtMP_Name);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtCodigoMP);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRequisicion_Seleccion_Lote";
            this.Text = "frmRequisicion_Seleccion_Lote";
            ((System.ComponentModel.ISupportInitialize)(this.txtSolicitada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsignada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadPendiente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMP_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoMP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_lotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_lotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSolicitada;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtAsignada;
        public System.Windows.Forms.CheckBox chkAutoSelect;
        private DevExpress.XtraEditors.LabelControl lblUnidad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCantidadPendiente;
        private DevExpress.XtraEditors.TextEdit txtMP_Name;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCodigoMP;
        private DevExpress.XtraGrid.GridControl grd_lotes;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_lotes;
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
        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ds_despachos ds_despachos;
        public DevExpress.XtraEditors.SimpleButton cmdGuardar;
    }
}