namespace LOSA.MigracionACS.Ttracer
{
    partial class TT_mship
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TT_mship));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btncancelar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tbship = new System.Windows.Forms.TabControl();
            this.tbnew = new System.Windows.Forms.TabPage();
            this.txtname = new DevExpress.XtraEditors.TextEdit();
            this.btnsave = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtcodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tabedit = new System.Windows.Forms.TabPage();
            this.tggenable = new DevExpress.XtraEditors.ToggleSwitch();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.grdship = new DevExpress.XtraGrid.GridControl();
            this.mshipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSTtracer = new MigracionACS.Ttracer.dSTtracer();
            this.grdvship = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtnameedit = new DevExpress.XtraEditors.TextEdit();
            this.btnsaveconf = new System.Windows.Forms.Button();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtcodeedit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tbship.SuspendLayout();
            this.tbnew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcodigo.Properties)).BeginInit();
            this.tabedit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tggenable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mshipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnameedit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcodeedit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btncancelar});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btncancelar)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // btncancelar
            // 
            this.btncancelar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btncancelar.Caption = "Cancelar";
            this.btncancelar.Id = 1;
            this.btncancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.ImageOptions.Image")));
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncancelar_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1257, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 518);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1257, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 468);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1257, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 468);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tbship);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 50);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1257, 468);
            this.panelControl1.TabIndex = 4;
            // 
            // tbship
            // 
            this.tbship.Controls.Add(this.tbnew);
            this.tbship.Controls.Add(this.tabedit);
            this.tbship.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbship.Location = new System.Drawing.Point(2, 2);
            this.tbship.Margin = new System.Windows.Forms.Padding(4);
            this.tbship.Name = "tbship";
            this.tbship.SelectedIndex = 0;
            this.tbship.Size = new System.Drawing.Size(1253, 464);
            this.tbship.TabIndex = 6;
            this.tbship.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbship_MouseDown);
            // 
            // tbnew
            // 
            this.tbnew.Controls.Add(this.txtname);
            this.tbnew.Controls.Add(this.btnsave);
            this.tbnew.Controls.Add(this.labelControl1);
            this.tbnew.Controls.Add(this.txtcodigo);
            this.tbnew.Controls.Add(this.labelControl2);
            this.tbnew.Location = new System.Drawing.Point(4, 25);
            this.tbnew.Margin = new System.Windows.Forms.Padding(4);
            this.tbnew.Name = "tbnew";
            this.tbnew.Padding = new System.Windows.Forms.Padding(4);
            this.tbnew.Size = new System.Drawing.Size(1245, 435);
            this.tbnew.TabIndex = 0;
            this.tbnew.Text = "Nuevo";
            this.tbnew.UseVisualStyleBackColor = true;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(547, 105);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.MenuManager = this.barManager1;
            this.txtname.Name = "txtname";
            this.txtname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Properties.Appearance.Options.UseFont = true;
            this.txtname.Size = new System.Drawing.Size(332, 30);
            this.txtname.TabIndex = 4;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(371, 156);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(451, 116);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Guardar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(353, 28);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(158, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Codigo generado:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(716, 25);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.MenuManager = this.barManager1;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Properties.Appearance.Options.UseFont = true;
            this.txtcodigo.Size = new System.Drawing.Size(163, 30);
            this.txtcodigo.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(353, 108);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(160, 24);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Nombre de barco:";
            // 
            // tabedit
            // 
            this.tabedit.Controls.Add(this.tggenable);
            this.tabedit.Controls.Add(this.panelControl2);
            this.tabedit.Controls.Add(this.txtnameedit);
            this.tabedit.Controls.Add(this.btnsaveconf);
            this.tabedit.Controls.Add(this.labelControl3);
            this.tabedit.Controls.Add(this.txtcodeedit);
            this.tabedit.Controls.Add(this.labelControl4);
            this.tabedit.Location = new System.Drawing.Point(4, 25);
            this.tabedit.Margin = new System.Windows.Forms.Padding(4);
            this.tabedit.Name = "tabedit";
            this.tabedit.Padding = new System.Windows.Forms.Padding(4);
            this.tabedit.Size = new System.Drawing.Size(1245, 435);
            this.tabedit.TabIndex = 1;
            this.tabedit.Text = "Editar";
            this.tabedit.UseVisualStyleBackColor = true;
            // 
            // tggenable
            // 
            this.tggenable.Location = new System.Drawing.Point(636, 101);
            this.tggenable.Margin = new System.Windows.Forms.Padding(4);
            this.tggenable.MenuManager = this.barManager1;
            this.tggenable.Name = "tggenable";
            this.tggenable.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tggenable.Properties.Appearance.Options.UseFont = true;
            this.tggenable.Properties.OffText = "Deshabilitado";
            this.tggenable.Properties.OnText = "Habilitado";
            this.tggenable.Size = new System.Drawing.Size(525, 35);
            this.tggenable.TabIndex = 12;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.grdship);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(4, 4);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(589, 427);
            this.panelControl2.TabIndex = 11;
            // 
            // grdship
            // 
            this.grdship.DataSource = this.mshipBindingSource;
            this.grdship.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdship.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdship.Location = new System.Drawing.Point(2, 2);
            this.grdship.MainView = this.grdvship;
            this.grdship.Margin = new System.Windows.Forms.Padding(4);
            this.grdship.MenuManager = this.barManager1;
            this.grdship.Name = "grdship";
            this.grdship.Size = new System.Drawing.Size(585, 423);
            this.grdship.TabIndex = 0;
            this.grdship.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvship});
            // 
            // mshipBindingSource
            // 
            this.mshipBindingSource.DataMember = "Mship";
            this.mshipBindingSource.DataSource = this.dSTtracer;
            // 
            // dSTtracer
            // 
            this.dSTtracer.DataSetName = "dSTtracer";
            this.dSTtracer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdvship
            // 
            this.grdvship.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcodigo,
            this.colenable,
            this.coldescripcion});
            this.grdvship.GridControl = this.grdship;
            this.grdvship.Name = "grdvship";
            this.grdvship.OptionsBehavior.Editable = false;
            this.grdvship.OptionsView.ShowAutoFilterRow = true;
            this.grdvship.OptionsView.ShowGroupPanel = false;
            this.grdvship.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 29;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 1;
            this.colcodigo.Width = 128;
            // 
            // colenable
            // 
            this.colenable.Caption = "Habilitado";
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.Visible = true;
            this.colenable.VisibleIndex = 3;
            this.colenable.Width = 135;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 2;
            this.coldescripcion.Width = 128;
            // 
            // txtnameedit
            // 
            this.txtnameedit.Location = new System.Drawing.Point(829, 62);
            this.txtnameedit.Margin = new System.Windows.Forms.Padding(4);
            this.txtnameedit.MenuManager = this.barManager1;
            this.txtnameedit.Name = "txtnameedit";
            this.txtnameedit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnameedit.Properties.Appearance.Options.UseFont = true;
            this.txtnameedit.Size = new System.Drawing.Size(332, 30);
            this.txtnameedit.TabIndex = 9;
            // 
            // btnsaveconf
            // 
            this.btnsaveconf.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveconf.Image = ((System.Drawing.Image)(resources.GetObject("btnsaveconf.Image")));
            this.btnsaveconf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsaveconf.Location = new System.Drawing.Point(637, 167);
            this.btnsaveconf.Margin = new System.Windows.Forms.Padding(4);
            this.btnsaveconf.Name = "btnsaveconf";
            this.btnsaveconf.Size = new System.Drawing.Size(525, 70);
            this.btnsaveconf.TabIndex = 10;
            this.btnsaveconf.Text = "Guardar";
            this.btnsaveconf.UseVisualStyleBackColor = true;
            this.btnsaveconf.Click += new System.EventHandler(this.btnsaveconf_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(636, 26);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(158, 24);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Codigo generado:";
            // 
            // txtcodeedit
            // 
            this.txtcodeedit.Enabled = false;
            this.txtcodeedit.Location = new System.Drawing.Point(999, 22);
            this.txtcodeedit.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodeedit.MenuManager = this.barManager1;
            this.txtcodeedit.Name = "txtcodeedit";
            this.txtcodeedit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodeedit.Properties.Appearance.Options.UseFont = true;
            this.txtcodeedit.Size = new System.Drawing.Size(163, 30);
            this.txtcodeedit.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(636, 65);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(160, 24);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Nombre de barco:";
            // 
            // TT_mship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 543);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TT_mship";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion de barco";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tbship.ResumeLayout(false);
            this.tbnew.ResumeLayout(false);
            this.tbnew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcodigo.Properties)).EndInit();
            this.tabedit.ResumeLayout(false);
            this.tabedit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tggenable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mshipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnameedit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcodeedit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btncancelar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtcodigo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtname;
        private System.Windows.Forms.TabControl tbship;
        private System.Windows.Forms.TabPage tbnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TabPage tabedit;
        private DevExpress.XtraEditors.ToggleSwitch tggenable;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl grdship;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvship;
        private DevExpress.XtraEditors.TextEdit txtnameedit;
        private System.Windows.Forms.Button btnsaveconf;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtcodeedit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.BindingSource mshipBindingSource;
        private dSTtracer dSTtracer;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
    }
}