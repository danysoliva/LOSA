namespace LOSA.MigracionACS.Solicitudes
{
    partial class frmAllsolicitudesUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllsolicitudesUser));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnAddSoli = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_soli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_soli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_eliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colotros_acceso_especial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrazon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colacceso_p = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colacceso_t = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colticket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colasignado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colacceso_especial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonImprimir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonAnular = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.dsSolicitudes = new LOSA.MigracionACS.IT.dsSolicitudes();
            this.solicitudesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonAnular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddSoli
            // 
            this.btnAddSoli.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSoli.Appearance.Options.UseFont = true;
            this.btnAddSoli.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAddSoli.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSoli.ImageOptions.Image")));
            this.btnAddSoli.Location = new System.Drawing.Point(27, 32);
            this.btnAddSoli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSoli.Name = "btnAddSoli";
            this.btnAddSoli.Size = new System.Drawing.Size(135, 41);
            this.btnAddSoli.TabIndex = 5;
            this.btnAddSoli.Text = "Crear Solicitud";
            this.btnAddSoli.Click += new System.EventHandler(this.btnAddSoli_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estado de Solicitudes";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.solicitudesBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(0, 93);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonAnular,
            this.repositoryItemButtonImprimir});
            this.gridControl1.Size = new System.Drawing.Size(1173, 458);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnombre_soli,
            this.colnombre_usuario,
            this.colfecha_soli,
            this.colfecha_eliminar,
            this.coldepartamento,
            this.colotros_acceso_especial,
            this.colrazon,
            this.colacceso_p,
            this.colacceso_t,
            this.colticket,
            this.colasignado,
            this.colacceso_especial,
            this.colestado,
            this.gridColumn2,
            this.gridColumn1});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colid.AppearanceHeader.Options.UseFont = true;
            this.colid.Caption = "Codigo ";
            this.colid.FieldName = "id";
            this.colid.MinWidth = 17;
            this.colid.Name = "colid";
            this.colid.Width = 36;
            // 
            // colnombre_soli
            // 
            this.colnombre_soli.Caption = "Solicitado por";
            this.colnombre_soli.FieldName = "nombre_soli";
            this.colnombre_soli.MinWidth = 17;
            this.colnombre_soli.Name = "colnombre_soli";
            this.colnombre_soli.Visible = true;
            this.colnombre_soli.VisibleIndex = 0;
            this.colnombre_soli.Width = 98;
            // 
            // colnombre_usuario
            // 
            this.colnombre_usuario.Caption = "Usuario nuevo";
            this.colnombre_usuario.FieldName = "nombre_usuario";
            this.colnombre_usuario.MinWidth = 17;
            this.colnombre_usuario.Name = "colnombre_usuario";
            this.colnombre_usuario.Visible = true;
            this.colnombre_usuario.VisibleIndex = 1;
            this.colnombre_usuario.Width = 103;
            // 
            // colfecha_soli
            // 
            this.colfecha_soli.Caption = "Fecha de solicitud";
            this.colfecha_soli.FieldName = "fecha_soli";
            this.colfecha_soli.MinWidth = 17;
            this.colfecha_soli.Name = "colfecha_soli";
            this.colfecha_soli.Visible = true;
            this.colfecha_soli.VisibleIndex = 2;
            this.colfecha_soli.Width = 62;
            // 
            // colfecha_eliminar
            // 
            this.colfecha_eliminar.Caption = "Fecha a eliminar";
            this.colfecha_eliminar.FieldName = "fecha_eliminar";
            this.colfecha_eliminar.MinWidth = 17;
            this.colfecha_eliminar.Name = "colfecha_eliminar";
            this.colfecha_eliminar.Visible = true;
            this.colfecha_eliminar.VisibleIndex = 3;
            this.colfecha_eliminar.Width = 59;
            // 
            // coldepartamento
            // 
            this.coldepartamento.Caption = "Departamento";
            this.coldepartamento.FieldName = "departamento";
            this.coldepartamento.MinWidth = 17;
            this.coldepartamento.Name = "coldepartamento";
            this.coldepartamento.Visible = true;
            this.coldepartamento.VisibleIndex = 4;
            this.coldepartamento.Width = 60;
            // 
            // colotros_acceso_especial
            // 
            this.colotros_acceso_especial.Caption = "Otros accesos especiales";
            this.colotros_acceso_especial.FieldName = "otros_acceso_especial";
            this.colotros_acceso_especial.MinWidth = 17;
            this.colotros_acceso_especial.Name = "colotros_acceso_especial";
            this.colotros_acceso_especial.Visible = true;
            this.colotros_acceso_especial.VisibleIndex = 5;
            this.colotros_acceso_especial.Width = 64;
            // 
            // colrazon
            // 
            this.colrazon.FieldName = "razon";
            this.colrazon.MinWidth = 17;
            this.colrazon.Name = "colrazon";
            this.colrazon.Width = 64;
            // 
            // colacceso_p
            // 
            this.colacceso_p.FieldName = "acceso_p";
            this.colacceso_p.MinWidth = 17;
            this.colacceso_p.Name = "colacceso_p";
            this.colacceso_p.Width = 64;
            // 
            // colacceso_t
            // 
            this.colacceso_t.FieldName = "acceso_t";
            this.colacceso_t.MinWidth = 17;
            this.colacceso_t.Name = "colacceso_t";
            this.colacceso_t.Width = 64;
            // 
            // colticket
            // 
            this.colticket.FieldName = "ticket";
            this.colticket.MinWidth = 17;
            this.colticket.Name = "colticket";
            this.colticket.Width = 64;
            // 
            // colasignado
            // 
            this.colasignado.FieldName = "asignado";
            this.colasignado.MinWidth = 17;
            this.colasignado.Name = "colasignado";
            this.colasignado.Width = 64;
            // 
            // colacceso_especial
            // 
            this.colacceso_especial.FieldName = "acceso_especial";
            this.colacceso_especial.MinWidth = 17;
            this.colacceso_especial.Name = "colacceso_especial";
            this.colacceso_especial.Width = 64;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado ";
            this.colestado.FieldName = "estado";
            this.colestado.MinWidth = 17;
            this.colestado.Name = "colestado";
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 6;
            this.colestado.Width = 64;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Imprimir";
            this.gridColumn2.ColumnEdit = this.repositoryItemButtonImprimir;
            this.gridColumn2.MinWidth = 17;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 64;
            // 
            // repositoryItemButtonImprimir
            // 
            this.repositoryItemButtonImprimir.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.repositoryItemButtonImprimir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonImprimir.Name = "repositoryItemButtonImprimir";
            this.repositoryItemButtonImprimir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Anular";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonAnular;
            this.gridColumn1.MinWidth = 17;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 64;
            // 
            // repositoryItemButtonAnular
            // 
            this.repositoryItemButtonAnular.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            serializableAppearanceObject13.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serializableAppearanceObject13.Options.UseFont = true;
            serializableAppearanceObject14.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serializableAppearanceObject14.Options.UseFont = true;
            serializableAppearanceObject15.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serializableAppearanceObject15.Options.UseFont = true;
            serializableAppearanceObject16.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serializableAppearanceObject16.Options.UseFont = true;
            this.repositoryItemButtonAnular.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonAnular.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.repositoryItemButtonAnular.Name = "repositoryItemButtonAnular";
            this.repositoryItemButtonAnular.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Appearance.Options.UseFont = true;
            this.btnSalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1012, 32);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 41);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dsSolicitudes
            // 
            this.dsSolicitudes.DataSetName = "dsSolicitudes";
            this.dsSolicitudes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // solicitudesBindingSource
            // 
            this.solicitudesBindingSource.DataMember = "solicitudes";
            this.solicitudesBindingSource.DataSource = this.dsSolicitudes;
            // 
            // frmAllsolicitudesUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 551);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAddSoli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAllsolicitudesUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonAnular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAddSoli;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_soli;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_soli;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_eliminar;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colotros_acceso_especial;
        private DevExpress.XtraGrid.Columns.GridColumn colrazon;
        private DevExpress.XtraGrid.Columns.GridColumn colacceso_p;
        private DevExpress.XtraGrid.Columns.GridColumn colacceso_t;
        private DevExpress.XtraGrid.Columns.GridColumn colticket;
        private DevExpress.XtraGrid.Columns.GridColumn colasignado;
        private DevExpress.XtraGrid.Columns.GridColumn colacceso_especial;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonImprimir;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonAnular;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private System.Windows.Forms.BindingSource solicitudesBindingSource;
        private IT.dsSolicitudes dsSolicitudes;
    }
}