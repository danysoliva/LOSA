namespace LOSA.Produccion
{
    partial class frmGenerarTarimas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerarTarimas));
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_producto = new DevExpress.XtraEditors.TextEdit();
            this.grdv_data = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProduccion = new LOSA.Produccion.dsProduccion();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_unidades = new DevExpress.XtraEditors.TextEdit();
            this.txtkg = new DevExpress.XtraEditors.TextEdit();
            this.txtlote = new DevExpress.XtraEditors.TextEdit();
            this.btn_uddown = new DevExpress.XtraEditors.SimpleButton();
            this.btn_udup = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dt_fechaFabricaion = new DevExpress.XtraEditors.DateEdit();
            this.dt_fechaVencimiento = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_print25 = new DevExpress.XtraEditors.SimpleButton();
            this.timerPrintMulti = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txt_producto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_unidades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_fechaFabricaion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_fechaFabricaion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_fechaVencimiento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_fechaVencimiento.Properties)).BeginInit();
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
            this.cmdHome.Location = new System.Drawing.Point(474, 2);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(161, 51);
            this.cmdHome.TabIndex = 37;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
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
            this.labelControl3.Location = new System.Drawing.Point(107, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(372, 39);
            this.labelControl3.TabIndex = 38;
            this.labelControl3.Text = "Generar Tarimas";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(34, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 23);
            this.labelControl1.TabIndex = 39;
            this.labelControl1.Text = "Producto:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(34, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(113, 23);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "Presentacion:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(34, 130);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(84, 23);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "Unidades:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(34, 173);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 23);
            this.labelControl5.TabIndex = 42;
            this.labelControl5.Text = "Total Kg:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(34, 208);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 23);
            this.labelControl6.TabIndex = 43;
            this.labelControl6.Text = "Lote:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(34, 252);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(124, 23);
            this.labelControl7.TabIndex = 44;
            this.labelControl7.Text = "F. Fabricacion:";
            // 
            // txt_producto
            // 
            this.txt_producto.Enabled = false;
            this.txt_producto.Location = new System.Drawing.Point(181, 64);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_producto.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txt_producto.Properties.Appearance.Options.UseFont = true;
            this.txt_producto.Properties.Appearance.Options.UseForeColor = true;
            this.txt_producto.Size = new System.Drawing.Size(343, 26);
            this.txt_producto.TabIndex = 45;
            // 
            // grdv_data
            // 
            this.grdv_data.Location = new System.Drawing.Point(181, 96);
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.grdv_data.Properties.Appearance.Options.UseFont = true;
            this.grdv_data.Properties.Appearance.Options.UseForeColor = true;
            this.grdv_data.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdv_data.Properties.DataSource = this.bagsBindingSource;
            this.grdv_data.Properties.DisplayMember = "description";
            this.grdv_data.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdv_data.Properties.ValueMember = "equi";
            this.grdv_data.Size = new System.Drawing.Size(343, 28);
            this.grdv_data.TabIndex = 46;
            this.grdv_data.EditValueChanged += new System.EventHandler(this.grdv_data_EditValueChanged);
            // 
            // bagsBindingSource
            // 
            this.bagsBindingSource.DataMember = "bags";
            this.bagsBindingSource.DataSource = this.dsProduccion;
            // 
            // dsProduccion
            // 
            this.dsProduccion.DataSetName = "dsProduccion";
            this.dsProduccion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.FilterPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.FocusedRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.FooterPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.GroupPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.GroupRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.Preview.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.TopNewRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescription,
            this.colnet});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescription
            // 
            this.coldescription.Caption = "Presentacion";
            this.coldescription.FieldName = "description";
            this.coldescription.Name = "coldescription";
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 0;
            // 
            // colnet
            // 
            this.colnet.FieldName = "net";
            this.colnet.Name = "colnet";
            // 
            // txt_unidades
            // 
            this.txt_unidades.Enabled = false;
            this.txt_unidades.Location = new System.Drawing.Point(181, 130);
            this.txt_unidades.Name = "txt_unidades";
            this.txt_unidades.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_unidades.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txt_unidades.Properties.Appearance.Options.UseFont = true;
            this.txt_unidades.Properties.Appearance.Options.UseForeColor = true;
            this.txt_unidades.Size = new System.Drawing.Size(119, 26);
            this.txt_unidades.TabIndex = 47;
            // 
            // txtkg
            // 
            this.txtkg.Enabled = false;
            this.txtkg.Location = new System.Drawing.Point(181, 170);
            this.txtkg.Name = "txtkg";
            this.txtkg.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtkg.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtkg.Properties.Appearance.Options.UseFont = true;
            this.txtkg.Properties.Appearance.Options.UseForeColor = true;
            this.txtkg.Size = new System.Drawing.Size(119, 26);
            this.txtkg.TabIndex = 48;
            // 
            // txtlote
            // 
            this.txtlote.Enabled = false;
            this.txtlote.Location = new System.Drawing.Point(181, 205);
            this.txtlote.Name = "txtlote";
            this.txtlote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtlote.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtlote.Properties.Appearance.Options.UseFont = true;
            this.txtlote.Properties.Appearance.Options.UseForeColor = true;
            this.txtlote.Size = new System.Drawing.Size(119, 26);
            this.txtlote.TabIndex = 49;
            // 
            // btn_uddown
            // 
            this.btn_uddown.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_uddown.ImageOptions.Image")));
            this.btn_uddown.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_uddown.Location = new System.Drawing.Point(381, 125);
            this.btn_uddown.Name = "btn_uddown";
            this.btn_uddown.Size = new System.Drawing.Size(69, 39);
            this.btn_uddown.TabIndex = 50;
            this.btn_uddown.Click += new System.EventHandler(this.btn_uddown_Click);
            // 
            // btn_udup
            // 
            this.btn_udup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_udup.ImageOptions.Image")));
            this.btn_udup.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_udup.Location = new System.Drawing.Point(306, 125);
            this.btn_udup.Name = "btn_udup";
            this.btn_udup.Size = new System.Drawing.Size(69, 39);
            this.btn_udup.TabIndex = 51;
            this.btn_udup.Click += new System.EventHandler(this.btn_udup_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(34, 296);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(131, 23);
            this.labelControl8.TabIndex = 52;
            this.labelControl8.Text = "F. Vencimiento:";
            // 
            // dt_fechaFabricaion
            // 
            this.dt_fechaFabricaion.EditValue = null;
            this.dt_fechaFabricaion.Enabled = false;
            this.dt_fechaFabricaion.Location = new System.Drawing.Point(181, 252);
            this.dt_fechaFabricaion.Name = "dt_fechaFabricaion";
            this.dt_fechaFabricaion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dt_fechaFabricaion.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.dt_fechaFabricaion.Properties.Appearance.Options.UseFont = true;
            this.dt_fechaFabricaion.Properties.Appearance.Options.UseForeColor = true;
            this.dt_fechaFabricaion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_fechaFabricaion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_fechaFabricaion.Size = new System.Drawing.Size(269, 26);
            this.dt_fechaFabricaion.TabIndex = 53;
            // 
            // dt_fechaVencimiento
            // 
            this.dt_fechaVencimiento.EditValue = null;
            this.dt_fechaVencimiento.Enabled = false;
            this.dt_fechaVencimiento.Location = new System.Drawing.Point(181, 293);
            this.dt_fechaVencimiento.Name = "dt_fechaVencimiento";
            this.dt_fechaVencimiento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dt_fechaVencimiento.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.dt_fechaVencimiento.Properties.Appearance.Options.UseFont = true;
            this.dt_fechaVencimiento.Properties.Appearance.Options.UseForeColor = true;
            this.dt_fechaVencimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_fechaVencimiento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_fechaVencimiento.Size = new System.Drawing.Size(269, 26);
            this.dt_fechaVencimiento.TabIndex = 54;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(129, 437);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(174, 98);
            this.simpleButton1.TabIndex = 55;
            this.simpleButton1.Text = "Imprimir 1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_print25
            // 
            this.btn_print25.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_print25.Appearance.Options.UseFont = true;
            this.btn_print25.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_print25.ImageOptions.Image")));
            this.btn_print25.Location = new System.Drawing.Point(327, 437);
            this.btn_print25.Name = "btn_print25";
            this.btn_print25.Size = new System.Drawing.Size(174, 98);
            this.btn_print25.TabIndex = 56;
            this.btn_print25.Text = "Imprimir 25";
            this.btn_print25.Click += new System.EventHandler(this.btn_print25_Click);
            // 
            // timerPrintMulti
            // 
            this.timerPrintMulti.Interval = 3000;
            this.timerPrintMulti.Tick += new System.EventHandler(this.timerPrintMulti_Tick);
            // 
            // frmGenerarTarimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.btn_print25);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dt_fechaVencimiento);
            this.Controls.Add(this.dt_fechaFabricaion);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.btn_udup);
            this.Controls.Add(this.btn_uddown);
            this.Controls.Add(this.txtlote);
            this.Controls.Add(this.txtkg);
            this.Controls.Add(this.txt_unidades);
            this.Controls.Add(this.grdv_data);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGenerarTarimas";
            this.Text = "frmGenerarTarimas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.txt_producto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_unidades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_fechaFabricaion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_fechaFabricaion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_fechaVencimiento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_fechaVencimiento.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_producto;
        private DevExpress.XtraEditors.GridLookUpEdit grdv_data;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txt_unidades;
        private DevExpress.XtraEditors.TextEdit txtkg;
        private DevExpress.XtraEditors.TextEdit txtlote;
        private DevExpress.XtraEditors.SimpleButton btn_uddown;
        private DevExpress.XtraEditors.SimpleButton btn_udup;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.DateEdit dt_fechaFabricaion;
        private DevExpress.XtraEditors.DateEdit dt_fechaVencimiento;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_print25;
        private System.Windows.Forms.BindingSource bagsBindingSource;
        private dsProduccion dsProduccion;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraGrid.Columns.GridColumn colnet;
        private System.Windows.Forms.Timer timerPrintMulti;
    }
}