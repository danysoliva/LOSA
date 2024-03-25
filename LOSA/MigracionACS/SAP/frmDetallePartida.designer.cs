namespace LOSA.MigracionACS.SAP
{
    partial class frmDetallePartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetallePartida));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsDataSetSAP1 = new LOSA.MigracionACS.SAP.dsDataSetSAP();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colceco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colceco_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcuenta_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrow_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaccount_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gleListaCuentas = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bindingSourceCuentasContables = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcuenta_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdExcel = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCargarDatos = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataSetSAP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleListaCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCuentasContables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(217, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(426, 23);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Detalle de Partida";
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(839, 5);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(137, 44);
            this.cmdCerrar.TabIndex = 4;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle";
            this.gridControl1.DataSource = this.dsDataSetSAP1;
            this.gridControl1.Location = new System.Drawing.Point(2, 55);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gleListaCuentas});
            this.gridControl1.Size = new System.Drawing.Size(974, 496);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsDataSetSAP1
            // 
            this.dsDataSetSAP1.DataSetName = "dsDataSetSAP";
            this.dsDataSetSAP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colceco,
            this.colceco_code,
            this.colcuenta,
            this.colcuenta_code,
            this.coldebit,
            this.colcredit,
            this.colmoneda,
            this.colref,
            this.colrow_number,
            this.colaccount_id});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colid
            // 
            this.colid.Caption = "Id";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Width = 35;
            // 
            // colname
            // 
            this.colname.Caption = "Regla Salarial Planilla";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 131;
            // 
            // colceco
            // 
            this.colceco.Caption = "CECO";
            this.colceco.FieldName = "ceco";
            this.colceco.Name = "colceco";
            this.colceco.OptionsColumn.ReadOnly = true;
            this.colceco.Visible = true;
            this.colceco.VisibleIndex = 2;
            this.colceco.Width = 126;
            // 
            // colceco_code
            // 
            this.colceco_code.Caption = "CECO Codigo";
            this.colceco_code.FieldName = "ceco_code";
            this.colceco_code.Name = "colceco_code";
            this.colceco_code.OptionsColumn.ReadOnly = true;
            this.colceco_code.Visible = true;
            this.colceco_code.VisibleIndex = 3;
            this.colceco_code.Width = 65;
            // 
            // colcuenta
            // 
            this.colcuenta.Caption = "Cuenta";
            this.colcuenta.FieldName = "cuenta";
            this.colcuenta.Name = "colcuenta";
            this.colcuenta.OptionsColumn.ReadOnly = true;
            this.colcuenta.Visible = true;
            this.colcuenta.VisibleIndex = 5;
            this.colcuenta.Width = 129;
            // 
            // colcuenta_code
            // 
            this.colcuenta_code.Caption = "Codigo Cuenta Contable";
            this.colcuenta_code.FieldName = "cuenta_code";
            this.colcuenta_code.Name = "colcuenta_code";
            this.colcuenta_code.Width = 94;
            // 
            // coldebit
            // 
            this.coldebit.Caption = "Debito";
            this.coldebit.DisplayFormat.FormatString = "n2";
            this.coldebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldebit.FieldName = "debit";
            this.coldebit.Name = "coldebit";
            this.coldebit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "debit", "SUM={0:0.##}")});
            this.coldebit.Visible = true;
            this.coldebit.VisibleIndex = 6;
            this.coldebit.Width = 100;
            // 
            // colcredit
            // 
            this.colcredit.Caption = "Crédito";
            this.colcredit.DisplayFormat.FormatString = "n2";
            this.colcredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcredit.FieldName = "credit";
            this.colcredit.Name = "colcredit";
            this.colcredit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "credit", "SUM={0:0.##}")});
            this.colcredit.Visible = true;
            this.colcredit.VisibleIndex = 7;
            this.colcredit.Width = 98;
            // 
            // colmoneda
            // 
            this.colmoneda.Caption = "Moneda";
            this.colmoneda.FieldName = "moneda";
            this.colmoneda.Name = "colmoneda";
            this.colmoneda.Visible = true;
            this.colmoneda.VisibleIndex = 8;
            this.colmoneda.Width = 80;
            // 
            // colref
            // 
            this.colref.Caption = "Referencia";
            this.colref.FieldName = "ref";
            this.colref.Name = "colref";
            this.colref.Visible = true;
            this.colref.VisibleIndex = 9;
            this.colref.Width = 89;
            // 
            // colrow_number
            // 
            this.colrow_number.FieldName = "row_number";
            this.colrow_number.Name = "colrow_number";
            this.colrow_number.Visible = true;
            this.colrow_number.VisibleIndex = 0;
            this.colrow_number.Width = 37;
            // 
            // colaccount_id
            // 
            this.colaccount_id.Caption = "Codigo Cuenta Contable";
            this.colaccount_id.ColumnEdit = this.gleListaCuentas;
            this.colaccount_id.FieldName = "account_id";
            this.colaccount_id.Name = "colaccount_id";
            this.colaccount_id.Visible = true;
            this.colaccount_id.VisibleIndex = 4;
            this.colaccount_id.Width = 94;
            // 
            // gleListaCuentas
            // 
            this.gleListaCuentas.AutoHeight = false;
            this.gleListaCuentas.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleListaCuentas.DataSource = this.bindingSourceCuentasContables;
            this.gleListaCuentas.DisplayMember = "cuenta_descripcion";
            this.gleListaCuentas.Name = "gleListaCuentas";
            this.gleListaCuentas.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.gleListaCuentas.ValueMember = "id";
            // 
            // bindingSourceCuentasContables
            // 
            this.bindingSourceCuentasContables.DataMember = "cuentas_contables_odoo";
            this.bindingSourceCuentasContables.DataSource = this.dsDataSetSAP1;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colcuenta_descripcion});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // colcuenta_descripcion
            // 
            this.colcuenta_descripcion.FieldName = "cuenta_descripcion";
            this.colcuenta_descripcion.Name = "colcuenta_descripcion";
            this.colcuenta_descripcion.Visible = true;
            this.colcuenta_descripcion.VisibleIndex = 0;
            // 
            // cmdExcel
            // 
            this.cmdExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcel.Appearance.Options.UseFont = true;
            this.cmdExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdExcel.ImageOptions.Image")));
            this.cmdExcel.Location = new System.Drawing.Point(696, 5);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.Size = new System.Drawing.Size(137, 44);
            this.cmdExcel.TabIndex = 7;
            this.cmdExcel.Text = "Excel";
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // cmdCargarDatos
            // 
            this.cmdCargarDatos.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarDatos.Appearance.Options.UseFont = true;
            this.cmdCargarDatos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCargarDatos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCargarDatos.ImageOptions.Image")));
            this.cmdCargarDatos.Location = new System.Drawing.Point(2, 5);
            this.cmdCargarDatos.Name = "cmdCargarDatos";
            this.cmdCargarDatos.Size = new System.Drawing.Size(137, 44);
            this.cmdCargarDatos.TabIndex = 8;
            this.cmdCargarDatos.Text = "Cargar Datos";
            this.cmdCargarDatos.Click += new System.EventHandler(this.cmdCargarDatos_Click);
            // 
            // frmDetallePartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 554);
            this.Controls.Add(this.cmdCargarDatos);
            this.Controls.Add(this.cmdExcel);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdCerrar);
            this.Name = "frmDetallePartida";
            this.Text = "Detalle Partida";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataSetSAP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleListaCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCuentasContables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsDataSetSAP dsDataSetSAP1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colceco;
        private DevExpress.XtraGrid.Columns.GridColumn colcuenta;
        private DevExpress.XtraGrid.Columns.GridColumn coldebit;
        private DevExpress.XtraGrid.Columns.GridColumn colcredit;
        private DevExpress.XtraGrid.Columns.GridColumn colmoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colref;
        private DevExpress.XtraEditors.SimpleButton cmdExcel;
        private DevExpress.XtraGrid.Columns.GridColumn colceco_code;
        private DevExpress.XtraGrid.Columns.GridColumn colcuenta_code;
        private DevExpress.XtraEditors.SimpleButton cmdCargarDatos;
        private DevExpress.XtraGrid.Columns.GridColumn colrow_number;
        private DevExpress.XtraGrid.Columns.GridColumn colaccount_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gleListaCuentas;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource bindingSourceCuentasContables;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colcuenta_descripcion;
    }
}