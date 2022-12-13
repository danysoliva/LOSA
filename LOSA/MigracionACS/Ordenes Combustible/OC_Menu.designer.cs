namespace LOSA.MigracionACS.Ordenes_Combustible
{
    partial class OC_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OC_Menu));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmdPrintAll = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdReimpresion = new DevExpress.XtraEditors.SimpleButton();
            this.cmdPerfiles = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.dsOrdenesCombustible1 = new MigracionACS.Ordenes_Combustible.dsOrdenesCombustible();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_order = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusercreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfuel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colliters = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprintState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPrint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrdenesCombustible1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(774, 441);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.cmdPrintAll);
            this.panelControl1.Controls.Add(this.cmdCancelar);
            this.panelControl1.Controls.Add(this.cmdReimpresion);
            this.panelControl1.Controls.Add(this.cmdPerfiles);
            this.panelControl1.Controls.Add(this.cmdGenerar);
            this.panelControl1.Location = new System.Drawing.Point(4, 6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1037, 112);
            this.panelControl1.TabIndex = 0;
            // 
            // cmdPrintAll
            // 
            this.cmdPrintAll.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrintAll.Appearance.Options.UseFont = true;
            this.cmdPrintAll.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdPrintAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrintAll.ImageOptions.Image")));
            this.cmdPrintAll.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdPrintAll.Location = new System.Drawing.Point(709, 25);
            this.cmdPrintAll.Name = "cmdPrintAll";
            this.cmdPrintAll.Size = new System.Drawing.Size(170, 57);
            this.cmdPrintAll.TabIndex = 19;
            this.cmdPrintAll.Text = "Imprimir todas las ordenes";
            this.cmdPrintAll.Click += new System.EventHandler(this.cmdPrintAll_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancelar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Appearance.Options.UseBackColor = true;
            this.cmdCancelar.Appearance.Options.UseFont = true;
            this.cmdCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.ImageOptions.Image")));
            this.cmdCancelar.Location = new System.Drawing.Point(921, 25);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(111, 57);
            this.cmdCancelar.TabIndex = 18;
            this.cmdCancelar.Text = "Salir";
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdReimpresion
            // 
            this.cmdReimpresion.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdReimpresion.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdReimpresion.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdReimpresion.ImageOptions.SvgImage")));
            this.cmdReimpresion.Location = new System.Drawing.Point(311, 25);
            this.cmdReimpresion.Name = "cmdReimpresion";
            this.cmdReimpresion.Size = new System.Drawing.Size(95, 57);
            this.cmdReimpresion.TabIndex = 2;
            this.cmdReimpresion.Text = "Reimpresion";
            this.cmdReimpresion.Click += new System.EventHandler(this.cmdReimpresion_Click);
            // 
            // cmdPerfiles
            // 
            this.cmdPerfiles.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdPerfiles.ImageOptions.Image = global::LOSA.Properties.Resources.usergroup_32x32;
            this.cmdPerfiles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdPerfiles.Location = new System.Drawing.Point(183, 25);
            this.cmdPerfiles.Name = "cmdPerfiles";
            this.cmdPerfiles.Size = new System.Drawing.Size(95, 57);
            this.cmdPerfiles.TabIndex = 1;
            this.cmdPerfiles.Text = "Gestion de Perfiles";
            this.cmdPerfiles.Click += new System.EventHandler(this.cmdPerfiles_Click);
            // 
            // cmdGenerar
            // 
            this.cmdGenerar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGenerar.Appearance.Options.UseFont = true;
            this.cmdGenerar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGenerar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGenerar.ImageOptions.Image")));
            this.cmdGenerar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdGenerar.Location = new System.Drawing.Point(36, 25);
            this.cmdGenerar.Name = "cmdGenerar";
            this.cmdGenerar.Size = new System.Drawing.Size(125, 57);
            this.cmdGenerar.TabIndex = 0;
            this.cmdGenerar.Text = "Oferta de Ordenes";
            this.cmdGenerar.Click += new System.EventHandler(this.cmdGenerar_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataMember = "cargarordenes";
            this.gridControl2.DataSource = this.dsOrdenesCombustible1;
            this.gridControl2.Location = new System.Drawing.Point(4, 124);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPrint});
            this.gridControl2.Size = new System.Drawing.Size(1037, 480);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // dsOrdenesCombustible1
            // 
            this.dsOrdenesCombustible1.DataSetName = "dsOrdenesCombustible";
            this.dsOrdenesCombustible1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colnum_order,
            this.colstatus,
            this.colusercreate,
            this.coldate,
            this.colfuel,
            this.colliters,
            this.colprintState,
            this.gridColumn1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colname
            // 
            this.colname.Caption = "Nombre";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            // 
            // colnum_order
            // 
            this.colnum_order.Caption = "# Orden";
            this.colnum_order.FieldName = "num_order";
            this.colnum_order.Name = "colnum_order";
            this.colnum_order.OptionsColumn.AllowEdit = false;
            this.colnum_order.Visible = true;
            this.colnum_order.VisibleIndex = 0;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.OptionsColumn.AllowEdit = false;
            // 
            // colusercreate
            // 
            this.colusercreate.Caption = "Creador";
            this.colusercreate.FieldName = "usercreate";
            this.colusercreate.Name = "colusercreate";
            this.colusercreate.OptionsColumn.AllowEdit = false;
            this.colusercreate.Visible = true;
            this.colusercreate.VisibleIndex = 2;
            // 
            // coldate
            // 
            this.coldate.Caption = "Fecha de Creacion";
            this.coldate.FieldName = "date";
            this.coldate.Name = "coldate";
            this.coldate.OptionsColumn.AllowEdit = false;
            this.coldate.Visible = true;
            this.coldate.VisibleIndex = 3;
            // 
            // colfuel
            // 
            this.colfuel.Caption = "Combustible";
            this.colfuel.FieldName = "fuel";
            this.colfuel.Name = "colfuel";
            this.colfuel.OptionsColumn.AllowEdit = false;
            this.colfuel.Visible = true;
            this.colfuel.VisibleIndex = 4;
            // 
            // colliters
            // 
            this.colliters.Caption = "Litros";
            this.colliters.FieldName = "liters";
            this.colliters.Name = "colliters";
            this.colliters.OptionsColumn.AllowEdit = false;
            this.colliters.Visible = true;
            this.colliters.VisibleIndex = 5;
            // 
            // colprintState
            // 
            this.colprintState.FieldName = "printState";
            this.colprintState.Name = "colprintState";
            this.colprintState.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Imprimir";
            this.gridColumn1.ColumnEdit = this.repositoryItemPrint;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            // 
            // repositoryItemPrint
            // 
            this.repositoryItemPrint.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemPrint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemPrint.Name = "repositoryItemPrint";
            this.repositoryItemPrint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemPrint.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemPrint_ButtonClick);
            // 
            // OC_Menu
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 606);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "OC_Menu";
            this.Text = "Ordenes de Combustible";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrdenesCombustible1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdReimpresion;
        private DevExpress.XtraEditors.SimpleButton cmdPerfiles;
        private DevExpress.XtraEditors.SimpleButton cmdGenerar;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton cmdCancelar;
        private dsOrdenesCombustible dsOrdenesCombustible1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_order;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colusercreate;
        private DevExpress.XtraGrid.Columns.GridColumn coldate;
        private DevExpress.XtraGrid.Columns.GridColumn colfuel;
        private DevExpress.XtraGrid.Columns.GridColumn colliters;
        private DevExpress.XtraGrid.Columns.GridColumn colprintState;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemPrint;
        private DevExpress.XtraEditors.SimpleButton cmdPrintAll;
    }
}