namespace LOSA.Despachos
{
    partial class frmplandespacho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmplandespacho));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btncancel = new DevExpress.XtraEditors.SimpleButton();
            this.grd_detalle = new DevExpress.XtraGrid.GridControl();
            this.ds_despachos = new LOSA.Despachos.ds_despachos();
            this.grdv_detalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidventa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDsCription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityTm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityKg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colU_Sacos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colU_Peso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnlotes = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtcliente = new DevExpress.XtraEditors.TextEdit();
            this.txtdocnum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dtfechaplan = new DevExpress.XtraEditors.DateEdit();
            this.btnatras = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdocnum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechaplan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechaplan.Properties)).BeginInit();
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
            this.labelControl1.Location = new System.Drawing.Point(253, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(464, 49);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Planificacion de Despacho";
            // 
            // btncancel
            // 
            this.btncancel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btncancel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Appearance.Options.UseBackColor = true;
            this.btncancel.Appearance.Options.UseFont = true;
            this.btncancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btncancel.Enabled = false;
            this.btncancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.ImageOptions.Image")));
            this.btncancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btncancel.Location = new System.Drawing.Point(157, 8);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(118, 54);
            this.btncancel.TabIndex = 37;
            this.btncancel.Text = "Cancelar";
            this.btncancel.Visible = false;
            this.btncancel.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // grd_detalle
            // 
            this.grd_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_detalle.DataMember = "plan_despacho";
            this.grd_detalle.DataSource = this.ds_despachos;
            this.grd_detalle.Location = new System.Drawing.Point(0, 211);
            this.grd_detalle.MainView = this.grdv_detalle;
            this.grd_detalle.Name = "grd_detalle";
            this.grd_detalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnlotes});
            this.grd_detalle.Size = new System.Drawing.Size(847, 479);
            this.grd_detalle.TabIndex = 38;
            this.grd_detalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_detalle});
            // 
            // ds_despachos
            // 
            this.ds_despachos.DataSetName = "ds_despachos";
            this.ds_despachos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_detalle
            // 
            this.grdv_detalle.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_detalle.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_detalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_detalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_detalle.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_detalle.Appearance.Row.Options.UseFont = true;
            this.grdv_detalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colidventa,
            this.colCardCode,
            this.colCardName,
            this.colDocNum,
            this.colItemCode,
            this.colDsCription,
            this.colQuantityTm,
            this.colQuantityKg,
            this.colU_Sacos,
            this.colU_Peso,
            this.collotes});
            this.grdv_detalle.GridControl = this.grd_detalle;
            this.grdv_detalle.Name = "grdv_detalle";
            this.grdv_detalle.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colidventa
            // 
            this.colidventa.FieldName = "idventa";
            this.colidventa.Name = "colidventa";
            this.colidventa.OptionsColumn.AllowEdit = false;
            // 
            // colCardCode
            // 
            this.colCardCode.Caption = "Cod. Cliente";
            this.colCardCode.FieldName = "CardCode";
            this.colCardCode.Name = "colCardCode";
            this.colCardCode.OptionsColumn.AllowEdit = false;
            // 
            // colCardName
            // 
            this.colCardName.Caption = "CLiente";
            this.colCardName.FieldName = "CardName";
            this.colCardName.Name = "colCardName";
            this.colCardName.OptionsColumn.AllowEdit = false;
            // 
            // colDocNum
            // 
            this.colDocNum.Caption = "SAP Num";
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.AllowEdit = false;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Cod. Producto";
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.AllowEdit = false;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 102;
            // 
            // colDsCription
            // 
            this.colDsCription.Caption = "Producto";
            this.colDsCription.FieldName = "Dscription";
            this.colDsCription.Name = "colDsCription";
            this.colDsCription.OptionsColumn.AllowEdit = false;
            this.colDsCription.Visible = true;
            this.colDsCription.VisibleIndex = 1;
            this.colDsCription.Width = 207;
            // 
            // colQuantityTm
            // 
            this.colQuantityTm.Caption = "Cantidad (TM)";
            this.colQuantityTm.FieldName = "QuantityTm";
            this.colQuantityTm.Name = "colQuantityTm";
            this.colQuantityTm.OptionsColumn.AllowEdit = false;
            this.colQuantityTm.Visible = true;
            this.colQuantityTm.VisibleIndex = 2;
            this.colQuantityTm.Width = 148;
            // 
            // colQuantityKg
            // 
            this.colQuantityKg.Caption = "Cantidad (Kg.)";
            this.colQuantityKg.FieldName = "QuantityKg";
            this.colQuantityKg.Name = "colQuantityKg";
            this.colQuantityKg.OptionsColumn.AllowEdit = false;
            this.colQuantityKg.Visible = true;
            this.colQuantityKg.VisibleIndex = 3;
            this.colQuantityKg.Width = 138;
            // 
            // colU_Sacos
            // 
            this.colU_Sacos.Caption = "Unidades";
            this.colU_Sacos.FieldName = "U_Sacos";
            this.colU_Sacos.Name = "colU_Sacos";
            this.colU_Sacos.OptionsColumn.AllowEdit = false;
            this.colU_Sacos.Visible = true;
            this.colU_Sacos.VisibleIndex = 4;
            this.colU_Sacos.Width = 106;
            // 
            // colU_Peso
            // 
            this.colU_Peso.Caption = "Presentacion";
            this.colU_Peso.FieldName = "U_Peso";
            this.colU_Peso.Name = "colU_Peso";
            this.colU_Peso.OptionsColumn.AllowEdit = false;
            this.colU_Peso.Visible = true;
            this.colU_Peso.VisibleIndex = 5;
            this.colU_Peso.Width = 126;
            // 
            // collotes
            // 
            this.collotes.Caption = "Lotes";
            this.collotes.ColumnEdit = this.btnlotes;
            this.collotes.Name = "collotes";
            this.collotes.Visible = true;
            this.collotes.VisibleIndex = 6;
            // 
            // btnlotes
            // 
            this.btnlotes.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnlotes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnlotes.Name = "btnlotes";
            this.btnlotes.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnlotes.Click += new System.EventHandler(this.btnlotes_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(22, 120);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 28);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Cliente:";
            // 
            // txtcliente
            // 
            this.txtcliente.EditValue = "";
            this.txtcliente.Enabled = false;
            this.txtcliente.Location = new System.Drawing.Point(214, 117);
            this.txtcliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliente.Properties.Appearance.Options.UseFont = true;
            this.txtcliente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcliente.Size = new System.Drawing.Size(503, 34);
            this.txtcliente.TabIndex = 40;
            // 
            // txtdocnum
            // 
            this.txtdocnum.EditValue = "";
            this.txtdocnum.Enabled = false;
            this.txtdocnum.Location = new System.Drawing.Point(214, 75);
            this.txtdocnum.Margin = new System.Windows.Forms.Padding(4);
            this.txtdocnum.Name = "txtdocnum";
            this.txtdocnum.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocnum.Properties.Appearance.Options.UseFont = true;
            this.txtdocnum.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdocnum.Size = new System.Drawing.Size(503, 34);
            this.txtdocnum.TabIndex = 42;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(23, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(171, 28);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "Documento SAP:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(22, 167);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(150, 28);
            this.labelControl4.TabIndex = 43;
            this.labelControl4.Text = "Fecha de plan:";
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
            this.simpleButton1.Location = new System.Drawing.Point(729, 12);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(118, 55);
            this.simpleButton1.TabIndex = 44;
            this.simpleButton1.Text = "Guardar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dtfechaplan
            // 
            this.dtfechaplan.EditValue = null;
            this.dtfechaplan.Location = new System.Drawing.Point(214, 163);
            this.dtfechaplan.Margin = new System.Windows.Forms.Padding(4);
            this.dtfechaplan.Name = "dtfechaplan";
            this.dtfechaplan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfechaplan.Properties.Appearance.Options.UseFont = true;
            this.dtfechaplan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfechaplan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfechaplan.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtfechaplan.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtfechaplan.Size = new System.Drawing.Size(503, 36);
            this.dtfechaplan.TabIndex = 45;
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
            this.btnatras.Location = new System.Drawing.Point(13, 9);
            this.btnatras.Margin = new System.Windows.Forms.Padding(4);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(127, 54);
            this.btnatras.TabIndex = 46;
            this.btnatras.Text = "Atras";
            this.btnatras.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmplandespacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 689);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.dtfechaplan);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtdocnum);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.grd_detalle);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmplandespacho";
            this.Text = "frmplandespacho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdocnum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechaplan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechaplan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btncancel;
        private DevExpress.XtraGrid.GridControl grd_detalle;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_detalle;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtcliente;
        private DevExpress.XtraEditors.TextEdit txtdocnum;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private ds_despachos ds_despachos;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colidventa;
        private DevExpress.XtraGrid.Columns.GridColumn colCardCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDsCription;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityTm;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityKg;
        private DevExpress.XtraGrid.Columns.GridColumn colU_Sacos;
        private DevExpress.XtraGrid.Columns.GridColumn colU_Peso;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit dtfechaplan;
        private DevExpress.XtraGrid.Columns.GridColumn collotes;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnlotes;
        private DevExpress.XtraEditors.SimpleButton btnatras;
    }
}