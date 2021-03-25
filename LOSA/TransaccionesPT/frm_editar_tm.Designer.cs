namespace LOSA.TransaccionesPT
{
    partial class frm_editar_tm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_editar_tm));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.dt_ingreso = new DevExpress.XtraEditors.DateEdit();
            this.dt_vencimiento = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtlote = new DevExpress.XtraEditors.TextEdit();
            this.grd_presentacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.presentacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPT = new LOSA.TransaccionesPT.dsPT();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txt_producto = new DevExpress.XtraEditors.TextEdit();
            this.dt_produccion = new DevExpress.XtraEditors.DateEdit();
            this.txt_unidades = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_peso = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfactor = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ingreso.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ingreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_vencimiento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_vencimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_presentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_producto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_produccion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_produccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_unidades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_peso.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.labelControl3.Location = new System.Drawing.Point(118, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(372, 39);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "Editar TM";
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
            this.cmdHome.Location = new System.Drawing.Point(427, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(199, 71);
            this.cmdHome.TabIndex = 34;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // dt_ingreso
            // 
            this.dt_ingreso.EditValue = null;
            this.dt_ingreso.Location = new System.Drawing.Point(218, 94);
            this.dt_ingreso.Name = "dt_ingreso";
            this.dt_ingreso.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ingreso.Properties.Appearance.Options.UseFont = true;
            this.dt_ingreso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ingreso.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ingreso.Size = new System.Drawing.Size(309, 24);
            this.dt_ingreso.TabIndex = 35;
            // 
            // dt_vencimiento
            // 
            this.dt_vencimiento.EditValue = null;
            this.dt_vencimiento.Location = new System.Drawing.Point(218, 124);
            this.dt_vencimiento.Name = "dt_vencimiento";
            this.dt_vencimiento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dt_vencimiento.Properties.Appearance.Options.UseFont = true;
            this.dt_vencimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_vencimiento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_vencimiento.Size = new System.Drawing.Size(309, 24);
            this.dt_vencimiento.TabIndex = 36;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(36, 96);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(129, 21);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "Fecha de Ingreso:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(36, 127);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(163, 21);
            this.labelControl2.TabIndex = 38;
            this.labelControl2.Text = "Fecha de vencimiento:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(36, 248);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 21);
            this.labelControl4.TabIndex = 39;
            this.labelControl4.Text = "Producto:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(36, 188);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 21);
            this.labelControl5.TabIndex = 40;
            this.labelControl5.Text = "Lote: ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(36, 215);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(98, 21);
            this.labelControl6.TabIndex = 41;
            this.labelControl6.Text = "Presentacion:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(36, 157);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(157, 21);
            this.labelControl7.TabIndex = 42;
            this.labelControl7.Text = "Fecha de produccion:";
            // 
            // txtlote
            // 
            this.txtlote.Enabled = false;
            this.txtlote.Location = new System.Drawing.Point(218, 185);
            this.txtlote.Name = "txtlote";
            this.txtlote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtlote.Properties.Appearance.Options.UseFont = true;
            this.txtlote.Size = new System.Drawing.Size(95, 24);
            this.txtlote.TabIndex = 43;
            // 
            // grd_presentacion
            // 
            this.grd_presentacion.Location = new System.Drawing.Point(218, 215);
            this.grd_presentacion.Name = "grd_presentacion";
            this.grd_presentacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grd_presentacion.Properties.Appearance.Options.UseFont = true;
            this.grd_presentacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_presentacion.Properties.DataSource = this.presentacionBindingSource;
            this.grd_presentacion.Properties.DisplayMember = "descripcion";
            this.grd_presentacion.Properties.PopupView = this.gridLookUpEdit1View;
            this.grd_presentacion.Properties.ValueMember = "id";
            this.grd_presentacion.Size = new System.Drawing.Size(309, 24);
            this.grd_presentacion.TabIndex = 44;
            this.grd_presentacion.EditValueChanged += new System.EventHandler(this.grd_presentacion_EditValueChanged);
            // 
            // presentacionBindingSource
            // 
            this.presentacionBindingSource.DataMember = "presentacion";
            this.presentacionBindingSource.DataSource = this.dsPT;
            // 
            // dsPT
            // 
            this.dsPT.DataSetName = "dsPT";
            this.dsPT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.colfactor});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txt_producto
            // 
            this.txt_producto.Enabled = false;
            this.txt_producto.Location = new System.Drawing.Point(218, 245);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_producto.Properties.Appearance.Options.UseFont = true;
            this.txt_producto.Size = new System.Drawing.Size(309, 24);
            this.txt_producto.TabIndex = 45;
            // 
            // dt_produccion
            // 
            this.dt_produccion.EditValue = null;
            this.dt_produccion.Location = new System.Drawing.Point(218, 154);
            this.dt_produccion.Name = "dt_produccion";
            this.dt_produccion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dt_produccion.Properties.Appearance.Options.UseFont = true;
            this.dt_produccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_produccion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_produccion.Size = new System.Drawing.Size(309, 24);
            this.dt_produccion.TabIndex = 46;
            // 
            // txt_unidades
            // 
            this.txt_unidades.Location = new System.Drawing.Point(218, 275);
            this.txt_unidades.Name = "txt_unidades";
            this.txt_unidades.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_unidades.Properties.Appearance.Options.UseFont = true;
            this.txt_unidades.Properties.Mask.EditMask = "d";
            this.txt_unidades.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_unidades.Size = new System.Drawing.Size(95, 24);
            this.txt_unidades.TabIndex = 47;
            this.txt_unidades.EditValueChanged += new System.EventHandler(this.txt_unidades_EditValueChanged);
            this.txt_unidades.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txt_unidades_EditValueChanging);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(36, 278);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(72, 21);
            this.labelControl8.TabIndex = 48;
            this.labelControl8.Text = "Unidades:";
            // 
            // txt_peso
            // 
            this.txt_peso.Enabled = false;
            this.txt_peso.Location = new System.Drawing.Point(218, 305);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_peso.Properties.Appearance.Options.UseFont = true;
            this.txt_peso.Properties.Mask.EditMask = "d";
            this.txt_peso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_peso.Size = new System.Drawing.Size(95, 24);
            this.txt_peso.TabIndex = 49;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(36, 308);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(89, 21);
            this.labelControl9.TabIndex = 50;
            this.labelControl9.Text = "Peso tarima:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(204, 436);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(199, 71);
            this.simpleButton1.TabIndex = 51;
            this.simpleButton1.Text = "Guardar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // colfactor
            // 
            this.colfactor.FieldName = "factor";
            this.colfactor.Name = "colfactor";
            // 
            // frm_editar_tm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txt_unidades);
            this.Controls.Add(this.dt_produccion);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.grd_presentacion);
            this.Controls.Add(this.txtlote);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dt_vencimiento);
            this.Controls.Add(this.dt_ingreso);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_editar_tm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_editar_tm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dt_ingreso.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ingreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_vencimiento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_vencimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_presentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_producto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_produccion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_produccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_unidades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_peso.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.DateEdit dt_ingreso;
        private DevExpress.XtraEditors.DateEdit dt_vencimiento;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtlote;
        private DevExpress.XtraEditors.GridLookUpEdit grd_presentacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txt_producto;
        private DevExpress.XtraEditors.DateEdit dt_produccion;
        private DevExpress.XtraEditors.TextEdit txt_unidades;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txt_peso;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource presentacionBindingSource;
        private dsPT dsPT;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colfactor;
    }
}