namespace LOSA.MigracionACS.RRHH.Encuesta
{
    partial class frmGestionAccesosEncuesta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionAccesosEncuesta));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsEncuesta1 = new LOSA.MigracionACS.RRHH.Encuesta.dsEncuesta();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colasignado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfinish = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colanio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.chkTodos = new DevExpress.XtraEditors.CheckEdit();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.btnEncuesta = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEncuesta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "codigos";
            this.gridControl1.DataSource = this.dsEncuesta1;
            this.gridControl1.Location = new System.Drawing.Point(2, 96);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdDelete});
            this.gridControl1.Size = new System.Drawing.Size(848, 422);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsEncuesta1
            // 
            this.dsEncuesta1.DataSetName = "dsEncuesta";
            this.dsEncuesta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigo,
            this.colasignado,
            this.colenable,
            this.colfecha,
            this.colfinish,
            this.colanio,
            this.colseleccionado,
            this.coldelete,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Código";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 1;
            // 
            // colasignado
            // 
            this.colasignado.Caption = "Asignado";
            this.colasignado.FieldName = "asignado";
            this.colasignado.Name = "colasignado";
            this.colasignado.OptionsColumn.AllowEdit = false;
            this.colasignado.Visible = true;
            this.colasignado.VisibleIndex = 2;
            // 
            // colenable
            // 
            this.colenable.Caption = "Activo";
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.AllowEdit = false;
            this.colenable.Visible = true;
            this.colenable.VisibleIndex = 3;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 4;
            // 
            // colfinish
            // 
            this.colfinish.Caption = "Completado";
            this.colfinish.FieldName = "finish";
            this.colfinish.Name = "colfinish";
            this.colfinish.OptionsColumn.AllowEdit = false;
            this.colfinish.Visible = true;
            this.colfinish.VisibleIndex = 5;
            // 
            // colanio
            // 
            this.colanio.FieldName = "anio";
            this.colanio.Name = "colanio";
            this.colanio.OptionsColumn.AllowEdit = false;
            // 
            // colseleccionado
            // 
            this.colseleccionado.Caption = "Seleccionado";
            this.colseleccionado.CustomizationCaption = "Seleccionado";
            this.colseleccionado.FieldName = "seleccionado";
            this.colseleccionado.Name = "colseleccionado";
            this.colseleccionado.Visible = true;
            this.colseleccionado.VisibleIndex = 6;
            // 
            // coldelete
            // 
            this.coldelete.Caption = "Eliminar";
            this.coldelete.ColumnEdit = this.cmdDelete;
            this.coldelete.FieldName = "delete";
            this.coldelete.Name = "coldelete";
            this.coldelete.Visible = true;
            this.coldelete.VisibleIndex = 7;
            // 
            // cmdDelete
            // 
            this.cmdDelete.AutoHeight = false;
            this.cmdDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdDelete_ButtonClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Encuesta";
            this.gridColumn1.FieldName = "encuesta";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "encuesta", "Total {0}")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(710, 12);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(137, 44);
            this.cmdCerrar.TabIndex = 3;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevo.Appearance.Options.UseFont = true;
            this.cmdNuevo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevo.ImageOptions.Image")));
            this.cmdNuevo.Location = new System.Drawing.Point(2, 12);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(163, 44);
            this.cmdNuevo.TabIndex = 2;
            this.cmdNuevo.Text = "Nuevo Código";
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(567, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(137, 44);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Imprimir";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTodos.Location = new System.Drawing.Point(725, 71);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Properties.Caption = "Seleccionar Todos";
            this.chkTodos.Size = new System.Drawing.Size(112, 20);
            this.chkTodos.TabIndex = 5;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(171, 12);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Columns = 1;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Ver Todos"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Ver solo Disponibles")});
            this.radioGroup1.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Column;
            this.radioGroup1.Size = new System.Drawing.Size(174, 44);
            this.radioGroup1.TabIndex = 6;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // btnEncuesta
            // 
            this.btnEncuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncuesta.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnEncuesta.Appearance.Options.UseFont = true;
            this.btnEncuesta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnEncuesta.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEncuesta.ImageOptions.SvgImage")));
            this.btnEncuesta.Location = new System.Drawing.Point(424, 12);
            this.btnEncuesta.Name = "btnEncuesta";
            this.btnEncuesta.Size = new System.Drawing.Size(137, 44);
            this.btnEncuesta.TabIndex = 7;
            this.btnEncuesta.Text = "Gestión de \r\nEncuesta";
            this.btnEncuesta.Click += new System.EventHandler(this.btnEncuesta_Click);
            // 
            // frmGestionAccesosEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 520);
            this.Controls.Add(this.btnEncuesta);
            this.Controls.Add(this.radioGroup1);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmGestionAccesosEncuesta";
            this.Text = "Gestión Accesos Encuesta";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEncuesta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdNuevo;
        private dsEncuesta dsEncuesta1;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colasignado;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colfinish;
        private DevExpress.XtraGrid.Columns.GridColumn colanio;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
        private DevExpress.XtraEditors.CheckEdit chkTodos;
        private DevExpress.XtraGrid.Columns.GridColumn coldelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdDelete;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.SimpleButton btnEncuesta;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}