namespace LOSA.MigracionACS.PT
{
    partial class PT_AgregarGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PT_AgregarGasto));
            this.cmb_grupo = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_NuevoGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_NuevoGasto = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_detalle = new DevExpress.XtraEditors.LookUpEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btn_cancel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Aceptar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_costo = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_grupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_detalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_costo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_grupo
            // 
            this.cmb_grupo.Location = new System.Drawing.Point(5, 24);
            this.cmb_grupo.Name = "cmb_grupo";
            this.cmb_grupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_grupo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Grupo")});
            this.cmb_grupo.Properties.DisplayMember = "Descripcion";
            this.cmb_grupo.Properties.ValueMember = "id";
            this.cmb_grupo.Size = new System.Drawing.Size(177, 20);
            this.cmb_grupo.TabIndex = 0;
            this.cmb_grupo.EditValueChanged += new System.EventHandler(this.cmb_grupo_EditValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_NuevoGrupo);
            this.groupControl1.Controls.Add(this.cmb_grupo);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(215, 53);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Grupo Costo";
            // 
            // btn_NuevoGrupo
            // 
            this.btn_NuevoGrupo.Image = global::LOSA.Properties.Resources.add_16x16;
            this.btn_NuevoGrupo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_NuevoGrupo.Location = new System.Drawing.Point(188, 23);
            this.btn_NuevoGrupo.Name = "btn_NuevoGrupo";
            this.btn_NuevoGrupo.Size = new System.Drawing.Size(22, 21);
            this.btn_NuevoGrupo.TabIndex = 9;
            this.btn_NuevoGrupo.Tag = "Agregar Gasto";
            this.btn_NuevoGrupo.Click += new System.EventHandler(this.btn_NuevoGrupo_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_NuevoGasto);
            this.groupControl2.Controls.Add(this.cmb_detalle);
            this.groupControl2.Location = new System.Drawing.Point(12, 71);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(215, 53);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Detalle";
            // 
            // btn_NuevoGasto
            // 
            this.btn_NuevoGasto.Image = global::LOSA.Properties.Resources.add_16x16;
            this.btn_NuevoGasto.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_NuevoGasto.Location = new System.Drawing.Point(188, 23);
            this.btn_NuevoGasto.Name = "btn_NuevoGasto";
            this.btn_NuevoGasto.Size = new System.Drawing.Size(22, 21);
            this.btn_NuevoGasto.TabIndex = 10;
            this.btn_NuevoGasto.Tag = "Agregar Gasto";
            this.btn_NuevoGasto.Click += new System.EventHandler(this.btn_NuevoGasto_Click);
            // 
            // cmb_detalle
            // 
            this.cmb_detalle.Location = new System.Drawing.Point(5, 24);
            this.cmb_detalle.Name = "cmb_detalle";
            this.cmb_detalle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_detalle.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Detalle")});
            this.cmb_detalle.Properties.DisplayMember = "Descripcion";
            this.cmb_detalle.Properties.ValueMember = "id";
            this.cmb_detalle.Size = new System.Drawing.Size(177, 20);
            this.cmb_detalle.TabIndex = 0;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Aceptar,
            this.btn_cancel});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_cancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Aceptar)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_cancel.Caption = "Cancelar";
            this.btn_cancel.Glyph = global::LOSA.Properties.Resources.cancel_24x24;
            this.btn_cancel.Id = 1;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_cancel_ItemClick);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_Aceptar.Caption = "Aceptar";
            this.btn_Aceptar.Glyph = global::LOSA.Properties.Resources.Accept_24x24;
            this.btn_Aceptar.Id = 0;
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Aceptar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(239, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 191);
            this.barDockControlBottom.Size = new System.Drawing.Size(239, 35);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 191);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(239, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 191);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.txt_costo);
            this.groupControl3.Location = new System.Drawing.Point(12, 130);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(215, 53);
            this.groupControl3.TabIndex = 11;
            this.groupControl3.Text = "Costo";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Location = new System.Drawing.Point(197, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(9, 19);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "$";
            // 
            // txt_costo
            // 
            this.txt_costo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_costo.Location = new System.Drawing.Point(5, 24);
            this.txt_costo.MenuManager = this.barManager1;
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txt_costo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_costo.Properties.NullText = "Campo Requerido";
            this.txt_costo.Size = new System.Drawing.Size(190, 20);
            this.txt_costo.TabIndex = 11;
            // 
            // PT_AgregarGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 226);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PT_AgregarGasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Gasto";
            this.Load += new System.EventHandler(this.PT_AgregarGasto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_grupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_detalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_costo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cmb_grupo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LookUpEdit cmb_detalle;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btn_cancel;
        private DevExpress.XtraBars.BarButtonItem btn_Aceptar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton btn_NuevoGrupo;
        private DevExpress.XtraEditors.SimpleButton btn_NuevoGasto;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit txt_costo;
    }
}