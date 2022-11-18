namespace LOSA.MigracionACS.Produccion
{
    partial class PP_Order_Copy_Dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PP_Order_Copy_Dialog));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Paradas = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_KgProduccion = new DevExpress.XtraEditors.SpinEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.btn_Cancel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Accept = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Sacos = new DevExpress.XtraEditors.SpinEdit();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Paradas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KgProduccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sacos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txt_Sacos);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txt_Paradas);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txt_KgProduccion);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 47);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(322, 146);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Indicar Información";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(23, 28);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(114, 16);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "Cantidad Paradas";
            // 
            // txt_Paradas
            // 
            this.txt_Paradas.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_Paradas.Location = new System.Drawing.Point(23, 47);
            this.txt_Paradas.Name = "txt_Paradas";
            this.txt_Paradas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Paradas.Properties.Appearance.Options.UseFont = true;
            this.txt_Paradas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Paradas.Properties.IsFloatValue = false;
            this.txt_Paradas.Properties.Mask.EditMask = "N00";
            this.txt_Paradas.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txt_Paradas.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_Paradas.Size = new System.Drawing.Size(270, 26);
            this.txt_Paradas.TabIndex = 17;
            this.txt_Paradas.ToolTip = "Prioridad de Producción, esta puede ser de 1 a 20 siento 1 la mas importante.";
            this.txt_Paradas.EditValueChanged += new System.EventHandler(this.txt_Paradas_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(23, 79);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(86, 16);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Kg a Producir";
            // 
            // txt_KgProduccion
            // 
            this.txt_KgProduccion.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_KgProduccion.Location = new System.Drawing.Point(23, 98);
            this.txt_KgProduccion.Name = "txt_KgProduccion";
            this.txt_KgProduccion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KgProduccion.Properties.Appearance.Options.UseFont = true;
            this.txt_KgProduccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_KgProduccion.Properties.MaxValue = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txt_KgProduccion.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_KgProduccion.Properties.ReadOnly = true;
            this.txt_KgProduccion.Size = new System.Drawing.Size(136, 26);
            this.txt_KgProduccion.TabIndex = 16;
            this.txt_KgProduccion.ToolTip = "Cantidad en Kg a producir de este producto.";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Accept,
            this.btn_Cancel,
            this.barButtonItem1,
            this.barStaticItem1,
            this.barHeaderItem1});
            this.barManager1.MaxItemId = 5;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_Cancel.Caption = "Cancelar";
            this.btn_Cancel.Glyph = global::LOSA.Properties.Resources.cancel_24x24;
            this.btn_Cancel.Id = 1;
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Cancel_ItemClick);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_Accept.Caption = "Aceptar";
            this.btn_Accept.Glyph = global::LOSA.Properties.Resources.Accept_24x24;
            this.btn_Accept.Id = 0;
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Accept_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(322, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 193);
            this.barDockControlBottom.Size = new System.Drawing.Size(322, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 146);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(322, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 146);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(165, 79);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 16);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Sacos Apróximados";
            // 
            // txt_Sacos
            // 
            this.txt_Sacos.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_Sacos.Location = new System.Drawing.Point(165, 98);
            this.txt_Sacos.Name = "txt_Sacos";
            this.txt_Sacos.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sacos.Properties.Appearance.Options.UseFont = true;
            this.txt_Sacos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Sacos.Properties.MaxValue = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txt_Sacos.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_Sacos.Properties.ReadOnly = true;
            this.txt_Sacos.Size = new System.Drawing.Size(126, 26);
            this.txt_Sacos.TabIndex = 20;
            this.txt_Sacos.ToolTip = "Cantidad de sacos estimados a producir";
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Cancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Accept),
            new DevExpress.XtraBars.LinkPersistInfo(this.barHeaderItem1)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 3";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Cancelar";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Glyph = global::LOSA.Properties.Resources.Logo_x32;
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Copia Orden de Producción";
            this.barHeaderItem1.Id = 4;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // PP_Order_Copy_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 193);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PP_Order_Copy_Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copiar Orden de Producción";
            this.Load += new System.EventHandler(this.PP_Order_Copy_Dialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Paradas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KgProduccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sacos.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SpinEdit txt_Paradas;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SpinEdit txt_KgProduccion;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem btn_Accept;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_Cancel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit txt_Sacos;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
    }
}