namespace LOSA.MigracionACS.Ttracer
{
    partial class TT_LoadOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TT_LoadOrder));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnmin = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.grd_order = new DevExpress.XtraGrid.GridControl();
            this.dSTtracer = new MigracionACS.Ttracer.dSTtracer();
            this.grdv_order = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpurchase_order_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreate_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpartner_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpartner_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colamount_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurrency_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colx_dei = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colx_printed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_order = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldefault_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldefault_code_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colERP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGranel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colline = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colselecionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btndisone = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colCanttimes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPesoesperado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndisone)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnmin);
            this.panelControl1.Controls.Add(this.btnclose);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1885, 43);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl1_MouseDown);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.Image = ((System.Drawing.Image)(resources.GetObject("btnmin.Image")));
            this.btnmin.Location = new System.Drawing.Point(1795, 2);
            this.btnmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(44, 41);
            this.btnmin.TabIndex = 3;
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(1837, 2);
            this.btnclose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(44, 41);
            this.btnclose.TabIndex = 2;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(55, 7);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(258, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Seleccionar orden de compra";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LOSA.Properties.Resources.LogoLimp_x32;
            this.pictureBox1.Location = new System.Drawing.Point(9, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.grd_order);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 43);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1885, 932);
            this.panelControl2.TabIndex = 1;
            // 
            // grd_order
            // 
            this.grd_order.DataMember = "ordercompra";
            this.grd_order.DataSource = this.dSTtracer;
            this.grd_order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_order.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_order.Location = new System.Drawing.Point(2, 2);
            this.grd_order.MainView = this.grdv_order;
            this.grd_order.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_order.Name = "grd_order";
            this.grd_order.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btndisone});
            this.grd_order.Size = new System.Drawing.Size(1881, 928);
            this.grd_order.TabIndex = 0;
            this.grd_order.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_order});
            this.grd_order.Click += new System.EventHandler(this.grd_order_Click);
            // 
            // dSTtracer
            // 
            this.dSTtracer.DataSetName = "dSTtracer";
            this.dSTtracer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_order
            // 
            this.grdv_order.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpurchase_order_id,
            this.coloc_num,
            this.colcreate_date,
            this.colpartner_id,
            this.colpartner_name,
            this.colnotes,
            this.colamount_total,
            this.colcurrency_name,
            this.colx_dei,
            this.colx_printed,
            this.colstate,
            this.coldate_order,
            this.coldefault_code,
            this.coldefault_code_name,
            this.colERP,
            this.colTipo,
            this.colGranel,
            this.colquantity,
            this.colline,
            this.colselecionar,
            this.colCanttimes,
            this.colPesoesperado});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Borrado";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            formatConditionRuleValue1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            formatConditionRuleValue1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Expression;
            formatConditionRuleValue1.Expression = "[borrar] = \'S\'";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Procesado";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.NotEqual;
            formatConditionRuleValue2.Expression = "[arrival_processed] <> \'null\'";
            gridFormatRule2.Rule = formatConditionRuleValue2;
            this.grdv_order.FormatRules.Add(gridFormatRule1);
            this.grdv_order.FormatRules.Add(gridFormatRule2);
            this.grdv_order.GridControl = this.grd_order;
            this.grdv_order.GroupCount = 1;
            this.grdv_order.Name = "grdv_order";
            this.grdv_order.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_order.OptionsView.ShowAutoFilterRow = true;
            this.grdv_order.OptionsView.ShowFooter = true;
            this.grdv_order.OptionsView.ShowGroupPanelColumnsAsSingleRow = true;
            this.grdv_order.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTipo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grdv_order.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdv_order_CellValueChanged);
            this.grdv_order.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdv_order_CellValueChanging);
            // 
            // colpurchase_order_id
            // 
            this.colpurchase_order_id.Caption = "ID";
            this.colpurchase_order_id.FieldName = "purchase_order_id";
            this.colpurchase_order_id.Name = "colpurchase_order_id";
            this.colpurchase_order_id.OptionsColumn.AllowEdit = false;
            this.colpurchase_order_id.Width = 97;
            // 
            // coloc_num
            // 
            this.coloc_num.Caption = "N° SAP";
            this.coloc_num.FieldName = "oc_num";
            this.coloc_num.Name = "coloc_num";
            this.coloc_num.OptionsColumn.AllowEdit = false;
            this.coloc_num.Visible = true;
            this.coloc_num.VisibleIndex = 0;
            this.coloc_num.Width = 94;
            // 
            // colcreate_date
            // 
            this.colcreate_date.Caption = "Fecha de creacion";
            this.colcreate_date.FieldName = "create_date";
            this.colcreate_date.Name = "colcreate_date";
            this.colcreate_date.OptionsColumn.AllowEdit = false;
            this.colcreate_date.Width = 81;
            // 
            // colpartner_id
            // 
            this.colpartner_id.Caption = "Codigo Prov.";
            this.colpartner_id.FieldName = "partner_id";
            this.colpartner_id.Name = "colpartner_id";
            this.colpartner_id.OptionsColumn.AllowEdit = false;
            this.colpartner_id.Visible = true;
            this.colpartner_id.VisibleIndex = 1;
            this.colpartner_id.Width = 104;
            // 
            // colpartner_name
            // 
            this.colpartner_name.Caption = "Nombre de Prov.";
            this.colpartner_name.FieldName = "partner_name";
            this.colpartner_name.Name = "colpartner_name";
            this.colpartner_name.OptionsColumn.AllowEdit = false;
            this.colpartner_name.Visible = true;
            this.colpartner_name.VisibleIndex = 2;
            this.colpartner_name.Width = 331;
            // 
            // colnotes
            // 
            this.colnotes.Caption = "Observaciones";
            this.colnotes.FieldName = "notes";
            this.colnotes.Name = "colnotes";
            this.colnotes.OptionsColumn.AllowEdit = false;
            this.colnotes.Width = 188;
            // 
            // colamount_total
            // 
            this.colamount_total.FieldName = "amount_total";
            this.colamount_total.Name = "colamount_total";
            this.colamount_total.OptionsColumn.AllowEdit = false;
            this.colamount_total.Width = 97;
            // 
            // colcurrency_name
            // 
            this.colcurrency_name.FieldName = "currency_name";
            this.colcurrency_name.Name = "colcurrency_name";
            this.colcurrency_name.OptionsColumn.AllowEdit = false;
            this.colcurrency_name.Width = 97;
            // 
            // colx_dei
            // 
            this.colx_dei.Caption = "DEI";
            this.colx_dei.FieldName = "x_dei";
            this.colx_dei.Name = "colx_dei";
            this.colx_dei.OptionsColumn.AllowEdit = false;
            this.colx_dei.Width = 32;
            // 
            // colx_printed
            // 
            this.colx_printed.FieldName = "x_printed";
            this.colx_printed.Name = "colx_printed";
            this.colx_printed.OptionsColumn.AllowEdit = false;
            this.colx_printed.Width = 97;
            // 
            // colstate
            // 
            this.colstate.Caption = "Estado";
            this.colstate.FieldName = "state";
            this.colstate.Name = "colstate";
            this.colstate.OptionsColumn.AllowEdit = false;
            this.colstate.Width = 51;
            // 
            // coldate_order
            // 
            this.coldate_order.Caption = "Fecha de la orden";
            this.coldate_order.FieldName = "date_order";
            this.coldate_order.Name = "coldate_order";
            this.coldate_order.OptionsColumn.AllowEdit = false;
            this.coldate_order.Width = 84;
            // 
            // coldefault_code
            // 
            this.coldefault_code.Caption = "Codigo";
            this.coldefault_code.FieldName = "default_code";
            this.coldefault_code.Name = "coldefault_code";
            this.coldefault_code.OptionsColumn.AllowEdit = false;
            this.coldefault_code.Visible = true;
            this.coldefault_code.VisibleIndex = 3;
            this.coldefault_code.Width = 128;
            // 
            // coldefault_code_name
            // 
            this.coldefault_code_name.Caption = "Descripcion de Items";
            this.coldefault_code_name.FieldName = "default_code_name";
            this.coldefault_code_name.Name = "coldefault_code_name";
            this.coldefault_code_name.OptionsColumn.AllowEdit = false;
            this.coldefault_code_name.Visible = true;
            this.coldefault_code_name.VisibleIndex = 4;
            this.coldefault_code_name.Width = 361;
            // 
            // colERP
            // 
            this.colERP.FieldName = "ERP";
            this.colERP.Name = "colERP";
            this.colERP.OptionsColumn.AllowEdit = false;
            this.colERP.Width = 97;
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.OptionsColumn.AllowEdit = false;
            // 
            // colGranel
            // 
            this.colGranel.FieldName = "Granel";
            this.colGranel.Name = "colGranel";
            this.colGranel.Visible = true;
            this.colGranel.VisibleIndex = 5;
            this.colGranel.Width = 119;
            // 
            // colquantity
            // 
            this.colquantity.Caption = "Peso(Cantidad)";
            this.colquantity.FieldName = "quantity";
            this.colquantity.Name = "colquantity";
            this.colquantity.OptionsColumn.AllowEdit = false;
            this.colquantity.Width = 115;
            // 
            // colline
            // 
            this.colline.Caption = "Linea";
            this.colline.FieldName = "line";
            this.colline.Name = "colline";
            this.colline.OptionsColumn.AllowEdit = false;
            this.colline.Width = 42;
            // 
            // colselecionar
            // 
            this.colselecionar.Caption = "Agregar";
            this.colselecionar.ColumnEdit = this.btndisone;
            this.colselecionar.Name = "colselecionar";
            this.colselecionar.Visible = true;
            this.colselecionar.VisibleIndex = 8;
            this.colselecionar.Width = 308;
            // 
            // btndisone
            // 
            this.btndisone.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btndisone.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btndisone.Name = "btndisone";
            this.btndisone.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btndisone.Click += new System.EventHandler(this.btndisone_Click);
            // 
            // colCanttimes
            // 
            this.colCanttimes.Caption = "N. Camiones";
            this.colCanttimes.FieldName = "Canttimes";
            this.colCanttimes.Name = "colCanttimes";
            this.colCanttimes.Visible = true;
            this.colCanttimes.VisibleIndex = 7;
            this.colCanttimes.Width = 188;
            // 
            // colPesoesperado
            // 
            this.colPesoesperado.Caption = "Peso x Camion";
            this.colPesoesperado.FieldName = "Pesoesperado";
            this.colPesoesperado.Name = "colPesoesperado";
            this.colPesoesperado.Visible = true;
            this.colPesoesperado.VisibleIndex = 6;
            this.colPesoesperado.Width = 228;
            // 
            // TT_LoadOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1885, 975);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TT_LoadOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TT_LoadOrder";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndisone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btnclose;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.GridControl grd_order;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_order;
        private dSTtracer dSTtracer;
        private DevExpress.XtraGrid.Columns.GridColumn colpurchase_order_id;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_num;
        private DevExpress.XtraGrid.Columns.GridColumn colcreate_date;
        private DevExpress.XtraGrid.Columns.GridColumn colpartner_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpartner_name;
        private DevExpress.XtraGrid.Columns.GridColumn colnotes;
        private DevExpress.XtraGrid.Columns.GridColumn colamount_total;
        private DevExpress.XtraGrid.Columns.GridColumn colcurrency_name;
        private DevExpress.XtraGrid.Columns.GridColumn colx_dei;
        private DevExpress.XtraGrid.Columns.GridColumn colx_printed;
        private DevExpress.XtraGrid.Columns.GridColumn colstate;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_order;
        private DevExpress.XtraGrid.Columns.GridColumn coldefault_code;
        private DevExpress.XtraGrid.Columns.GridColumn coldefault_code_name;
        private DevExpress.XtraGrid.Columns.GridColumn colERP;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colGranel;
        private DevExpress.XtraGrid.Columns.GridColumn colquantity;
        private DevExpress.XtraGrid.Columns.GridColumn colline;
        private DevExpress.XtraGrid.Columns.GridColumn colselecionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btndisone;
        private DevExpress.XtraGrid.Columns.GridColumn colCanttimes;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoesperado;
    }
}