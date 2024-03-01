
namespace LOSA.Calidad
{
    partial class frmListaFabricantes
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaFabricantes));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsTRZ_Reports1 = new LOSA.Calidad.dsTRZ_Reports();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_planta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_gmo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaprobado_asc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdDelete_ = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.txtproveedor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.txtFabricante = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tsAprobadoASC = new DevExpress.XtraEditors.ToggleSwitch();
            this.tsElegible = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtTipo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTRZ_Reports1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDelete_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtproveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAprobadoASC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsElegible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "plantas_por_materia_prima";
            this.gridControl1.DataSource = this.dsTRZ_Reports1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdDelete_,
            this.cmdEditar,
            this.cmdSeleccionar});
            this.gridControl1.Size = new System.Drawing.Size(789, 349);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsTRZ_Reports1
            // 
            this.dsTRZ_Reports1.DataSetName = "dsTRZ_Reports";
            this.dsTRZ_Reports1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_planta,
            this.colnombre,
            this.coldireccion,
            this.coltipo_gmo,
            this.colaprobado_asc,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colid_planta
            // 
            this.colid_planta.FieldName = "id_planta";
            this.colid_planta.Name = "colid_planta";
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre de la Planta";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            // 
            // coldireccion
            // 
            this.coldireccion.Caption = "Direccion";
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.OptionsColumn.AllowEdit = false;
            this.coldireccion.Visible = true;
            this.coldireccion.VisibleIndex = 1;
            // 
            // coltipo_gmo
            // 
            this.coltipo_gmo.Caption = "Tipo";
            this.coltipo_gmo.FieldName = "tipo_gmo";
            this.coltipo_gmo.Name = "coltipo_gmo";
            this.coltipo_gmo.OptionsColumn.AllowEdit = false;
            this.coltipo_gmo.Visible = true;
            this.coltipo_gmo.VisibleIndex = 2;
            // 
            // colaprobado_asc
            // 
            this.colaprobado_asc.Caption = "Aprobado por ASC";
            this.colaprobado_asc.FieldName = "aprobado_asc";
            this.colaprobado_asc.Name = "colaprobado_asc";
            this.colaprobado_asc.OptionsColumn.AllowEdit = false;
            this.colaprobado_asc.Visible = true;
            this.colaprobado_asc.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Seleccionar";
            this.gridColumn1.ColumnEdit = this.cmdSeleccionar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // cmdSeleccionar
            // 
            this.cmdSeleccionar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdSeleccionar.Name = "cmdSeleccionar";
            this.cmdSeleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdSeleccionar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdSeleccionar_ButtonClick);
            // 
            // cmdDelete_
            // 
            this.cmdDelete_.AutoHeight = false;
            this.cmdDelete_.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.cmdDelete_.Name = "cmdDelete_";
            this.cmdDelete_.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // cmdEditar
            // 
            this.cmdEditar.AutoHeight = false;
            this.cmdEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // txtproveedor
            // 
            this.txtproveedor.Enabled = false;
            this.txtproveedor.Location = new System.Drawing.Point(140, 52);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtproveedor.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtproveedor.Properties.Appearance.Options.UseFont = true;
            this.txtproveedor.Properties.Appearance.Options.UseForeColor = true;
            this.txtproveedor.Properties.ReadOnly = true;
            this.txtproveedor.Size = new System.Drawing.Size(332, 24);
            this.txtproveedor.TabIndex = 26;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(4, 55);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(103, 17);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Proveedor Actual:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(287, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(210, 25);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Seleccione un Fabricante";
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(667, 3);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(126, 42);
            this.cmdHome.TabIndex = 28;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.navigationPage1);
            this.navigationFrame1.Controls.Add(this.navigationPage2);
            this.navigationFrame1.Location = new System.Drawing.Point(4, 82);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationFrame1.SelectedPage = this.navigationPage1;
            this.navigationFrame1.Size = new System.Drawing.Size(789, 349);
            this.navigationFrame1.TabIndex = 30;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Controls.Add(this.gridControl1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(789, 349);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Controls.Add(this.txtTipo);
            this.navigationPage2.Controls.Add(this.btnSave);
            this.navigationPage2.Controls.Add(this.tsElegible);
            this.navigationPage2.Controls.Add(this.labelControl6);
            this.navigationPage2.Controls.Add(this.tsAprobadoASC);
            this.navigationPage2.Controls.Add(this.labelControl5);
            this.navigationPage2.Controls.Add(this.labelControl3);
            this.navigationPage2.Controls.Add(this.labelControl2);
            this.navigationPage2.Controls.Add(this.txtFabricante);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(789, 349);
            // 
            // txtFabricante
            // 
            this.txtFabricante.Enabled = false;
            this.txtFabricante.Location = new System.Drawing.Point(309, 51);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFabricante.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtFabricante.Properties.Appearance.Options.UseFont = true;
            this.txtFabricante.Properties.Appearance.Options.UseForeColor = true;
            this.txtFabricante.Properties.ReadOnly = true;
            this.txtFabricante.Size = new System.Drawing.Size(216, 28);
            this.txtFabricante.TabIndex = 27;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(234, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 21);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Planta:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(234, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 21);
            this.labelControl3.TabIndex = 30;
            this.labelControl3.Text = "Tipo:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(234, 180);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(94, 47);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "Aprobado por ASC:";
            // 
            // tsAprobadoASC
            // 
            this.tsAprobadoASC.Enabled = false;
            this.tsAprobadoASC.Location = new System.Drawing.Point(364, 191);
            this.tsAprobadoASC.Name = "tsAprobadoASC";
            this.tsAprobadoASC.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsAprobadoASC.Properties.Appearance.Options.UseFont = true;
            this.tsAprobadoASC.Properties.OffText = "No";
            this.tsAprobadoASC.Properties.OnText = "Si";
            this.tsAprobadoASC.Size = new System.Drawing.Size(161, 26);
            this.tsAprobadoASC.TabIndex = 32;
            // 
            // tsElegible
            // 
            this.tsElegible.EditValue = true;
            this.tsElegible.Location = new System.Drawing.Point(364, 245);
            this.tsElegible.Name = "tsElegible";
            this.tsElegible.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsElegible.Properties.Appearance.Options.UseFont = true;
            this.tsElegible.Properties.OffText = "No es Elegible";
            this.tsElegible.Properties.OnText = "Si es Elegible";
            this.tsElegible.Size = new System.Drawing.Size(173, 26);
            this.tsElegible.TabIndex = 34;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(234, 250);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 21);
            this.labelControl6.TabIndex = 33;
            this.labelControl6.Text = "Es Elegible:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(329, 297);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 42);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Guardar";
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(309, 108);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTipo.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtTipo.Properties.Appearance.Options.UseFont = true;
            this.txtTipo.Properties.Appearance.Options.UseForeColor = true;
            this.txtTipo.Properties.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(216, 28);
            this.txtTipo.TabIndex = 36;
            // 
            // frmListaFabricantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 433);
            this.Controls.Add(this.navigationFrame1);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtproveedor);
            this.Controls.Add(this.labelControl4);
            this.Name = "frmListaFabricantes";
            this.Text = "Seleccione el Fabricante";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTRZ_Reports1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDelete_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtproveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAprobadoASC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsElegible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdDelete_;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditar;
        private dsTRZ_Reports dsTRZ_Reports1;
        private DevExpress.XtraEditors.TextEdit txtproveedor;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdSeleccionar;
        private DevExpress.XtraGrid.Columns.GridColumn colid_planta;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_gmo;
        private DevExpress.XtraGrid.Columns.GridColumn colaprobado_asc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraEditors.TextEdit txtFabricante;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ToggleSwitch tsElegible;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ToggleSwitch tsAprobadoASC;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtTipo;
    }
}