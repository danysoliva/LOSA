namespace LOSA.MigracionACS.Ordenes_Combustible
{
    partial class OC_NewEditPerfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OC_NewEditPerfiles));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lblCrearP = new System.Windows.Forms.Label();
            this.lblEditarP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.checkUserActive = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gridFuel = new DevExpress.XtraGrid.GridControl();
            this.gridConFuelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOrdenesCombustible1 = new MigracionACS.Ordenes_Combustible.dsOrdenesCombustible();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colliters = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltanquelleno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemCheckEstado = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckTanque = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmdAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.gridTipoFuel = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.combustibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridFuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConFuelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrdenesCombustible1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckTanque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipoFuel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustibleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCrearP
            // 
            this.lblCrearP.AutoSize = true;
            this.lblCrearP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearP.Location = new System.Drawing.Point(306, 28);
            this.lblCrearP.Name = "lblCrearP";
            this.lblCrearP.Size = new System.Drawing.Size(103, 19);
            this.lblCrearP.TabIndex = 0;
            this.lblCrearP.Text = "Crear Perfil";
            // 
            // lblEditarP
            // 
            this.lblEditarP.AutoSize = true;
            this.lblEditarP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarP.Location = new System.Drawing.Point(315, 28);
            this.lblEditarP.Name = "lblEditarP";
            this.lblEditarP.Size = new System.Drawing.Size(107, 19);
            this.lblEditarP.TabIndex = 1;
            this.lblEditarP.Text = "Editar Perfil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(171, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // txtCar
            // 
            this.txtCar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCar.Location = new System.Drawing.Point(341, 139);
            this.txtCar.Name = "txtCar";
            this.txtCar.Size = new System.Drawing.Size(186, 27);
            this.txtCar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(171, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vehiculo";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(341, 197);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(186, 27);
            this.txtPlaca.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(171, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero de Placa";
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
            this.cmdCancelar.Location = new System.Drawing.Point(432, 633);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(95, 40);
            this.cmdCancelar.TabIndex = 17;
            this.cmdCancelar.Text = "Salir";
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.BackgroundImage = global::LOSA.Properties.Resources.new_48x48;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(218, 633);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkUserActive
            // 
            this.checkUserActive.AutoSize = true;
            this.checkUserActive.Checked = true;
            this.checkUserActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkUserActive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUserActive.Location = new System.Drawing.Point(319, 285);
            this.checkUserActive.Name = "checkUserActive";
            this.checkUserActive.Size = new System.Drawing.Size(79, 23);
            this.checkUserActive.TabIndex = 5;
            this.checkUserActive.Text = "Activo";
            this.checkUserActive.UseVisualStyleBackColor = true;
            this.checkUserActive.CheckStateChanged += new System.EventHandler(this.checkUserActive_CheckStateChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(341, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 27);
            this.txtName.TabIndex = 1;
            // 
            // gridFuel
            // 
            this.gridFuel.DataMember = "gridConFuel";
            this.gridFuel.DataSource = this.dsOrdenesCombustible1;
            this.gridFuel.Location = new System.Drawing.Point(4, 5);
            this.gridFuel.MainView = this.gridView1;
            this.gridFuel.Name = "gridFuel";
            this.gridFuel.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEstado,
            this.repositoryItemCheckTanque,
            this.repositoryItemDelete});
            this.gridFuel.Size = new System.Drawing.Size(761, 296);
            this.gridFuel.TabIndex = 19;
            this.gridFuel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridConFuelBindingSource
            // 
            this.gridConFuelBindingSource.DataMember = "gridConFuel";
            this.gridConFuelBindingSource.DataSource = this.dsOrdenesCombustible1;
            // 
            // dsOrdenesCombustible1
            // 
            this.dsOrdenesCombustible1.DataSetName = "dsOrdenesCombustible";
            this.dsOrdenesCombustible1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colliters,
            this.coltanquelleno,
            this.gridColumn2,
            this.colenable,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridFuel;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colliters
            // 
            this.colliters.Caption = "Litros";
            this.colliters.FieldName = "liters";
            this.colliters.Name = "colliters";
            this.colliters.Visible = true;
            this.colliters.VisibleIndex = 0;
            this.colliters.Width = 88;
            // 
            // coltanquelleno
            // 
            this.coltanquelleno.Caption = "Tanque Lleno";
            this.coltanquelleno.FieldName = "tanque_lleno";
            this.coltanquelleno.Name = "coltanquelleno";
            this.coltanquelleno.Visible = true;
            this.coltanquelleno.VisibleIndex = 3;
            this.coltanquelleno.Width = 131;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Observaciones";
            this.gridColumn2.FieldName = "obs";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 302;
            // 
            // colenable
            // 
            this.colenable.Caption = "Estado";
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.Visible = true;
            this.colenable.VisibleIndex = 2;
            this.colenable.Width = 115;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Eliminar";
            this.gridColumn1.ColumnEdit = this.repositoryItemDelete;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 107;
            // 
            // repositoryItemDelete
            // 
            this.repositoryItemDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemDelete.Name = "repositoryItemDelete";
            this.repositoryItemDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemDelete_ButtonClick);
            // 
            // repositoryItemCheckEstado
            // 
            this.repositoryItemCheckEstado.AutoHeight = false;
            this.repositoryItemCheckEstado.Name = "repositoryItemCheckEstado";
            // 
            // repositoryItemCheckTanque
            // 
            this.repositoryItemCheckTanque.AutoHeight = false;
            this.repositoryItemCheckTanque.Name = "repositoryItemCheckTanque";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.gridFuel);
            this.panelControl1.Location = new System.Drawing.Point(8, 309);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(770, 306);
            this.panelControl1.TabIndex = 20;
            // 
            // cmdAdd
            // 
            this.cmdAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.cmdAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAdd.ImageOptions.Image")));
            this.cmdAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdAdd.Location = new System.Drawing.Point(8, 273);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(34, 35);
            this.cmdAdd.TabIndex = 21;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(171, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Combustible";
            // 
            // gridTipoFuel
            // 
            this.gridTipoFuel.EditValue = "";
            this.gridTipoFuel.Location = new System.Drawing.Point(341, 254);
            this.gridTipoFuel.Name = "gridTipoFuel";
            this.gridTipoFuel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridTipoFuel.Properties.Appearance.Options.UseFont = true;
            this.gridTipoFuel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridTipoFuel.Properties.DataSource = this.combustibleBindingSource;
            this.gridTipoFuel.Properties.DisplayMember = "description";
            this.gridTipoFuel.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridTipoFuel.Properties.ValueMember = "id";
            this.gridTipoFuel.Size = new System.Drawing.Size(186, 26);
            this.gridTipoFuel.TabIndex = 4;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coldescription});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // coldescription
            // 
            this.coldescription.Caption = "Descripcion";
            this.coldescription.FieldName = "description";
            this.coldescription.Name = "coldescription";
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 0;
            // 
            // combustibleBindingSource
            // 
            this.combustibleBindingSource.DataMember = "combustible";
            this.combustibleBindingSource.DataSource = this.dsOrdenesCombustible1;
            // 
            // OC_NewEditPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 685);
            this.Controls.Add(this.gridTipoFuel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.checkUserActive);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEditarP);
            this.Controls.Add(this.lblCrearP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OC_NewEditPerfiles";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.gridFuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConFuelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrdenesCombustible1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckTanque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTipoFuel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustibleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCrearP;
        private System.Windows.Forms.Label lblEditarP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton cmdCancelar;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.CheckBox checkUserActive;
        private System.Windows.Forms.TextBox txtName;
        private DevExpress.XtraGrid.GridControl gridFuel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colliters;
        private DevExpress.XtraGrid.Columns.GridColumn coltanquelleno;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GridLookUpEdit gridTipoFuel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckTanque;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEstado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private dsOrdenesCombustible dsOrdenesCombustible1;
        private System.Windows.Forms.BindingSource gridConFuelBindingSource;
        private System.Windows.Forms.BindingSource combustibleBindingSource;
    }
}