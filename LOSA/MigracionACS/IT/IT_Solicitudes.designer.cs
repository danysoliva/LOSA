namespace LOSA.MigracionACS.IT
{
    partial class IT_Solicitudes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IT_Solicitudes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdSolicitud = new DevExpress.XtraEditors.GridLookUpEdit();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSolicitudes = new LOSA.MigracionACS.IT.dsSolicitudes();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.accesoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdDepartamento = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgrupo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtSolicitud = new System.Windows.Forms.DateTimePicker();
            this.cmdImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOacceso = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.labeldt = new System.Windows.Forms.Label();
            this.dtEliminar = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.txtAsignado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.boxEspecial = new System.Windows.Forms.CheckBox();
            this.colnombre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkall = new System.Windows.Forms.CheckBox();
            this.radioPerma = new System.Windows.Forms.RadioButton();
            this.radioTempo = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.grdEstado = new DevExpress.XtraEditors.GridLookUpEdit();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitud.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accesoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitud de control de accesos";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Solicitado por:";
            // 
            // grdSolicitud
            // 
            this.grdSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdSolicitud.EditValue = "";
            this.grdSolicitud.Location = new System.Drawing.Point(259, 77);
            this.grdSolicitud.Name = "grdSolicitud";
            this.grdSolicitud.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdSolicitud.Properties.Appearance.Options.UseFont = true;
            this.grdSolicitud.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdSolicitud.Properties.DataSource = this.usuariosBindingSource;
            this.grdSolicitud.Properties.DisplayMember = "nombre";
            this.grdSolicitud.Properties.ValueMember = "id";
            this.grdSolicitud.Properties.View = this.gridLookUpEdit1View;
            this.grdSolicitud.Size = new System.Drawing.Size(337, 28);
            this.grdSolicitud.TabIndex = 2;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.dsSolicitudes;
            // 
            // dsSolicitudes
            // 
            this.dsSolicitudes.DataSetName = "dsSolicitudes";
            this.dsSolicitudes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Codigo,
            this.colnombre});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Codigo
            // 
            this.Codigo.FieldName = "id";
            this.Codigo.Name = "Codigo";
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre completo del usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(259, 120);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(337, 28);
            this.txtUsuario.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Accesos a:";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.accesoBindingSource;
            this.gridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(12, 269);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(955, 230);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // accesoBindingSource
            // 
            this.accesoBindingSource.DataMember = "acceso";
            this.accesoBindingSource.DataSource = this.dsSolicitudes;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupButton.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.SelectedRow.BorderColor = System.Drawing.Color.White;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre2,
            this.colDataColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            // 
            // colnombre2
            // 
            this.colnombre2.Caption = "Herramientas/Sistemas";
            this.colnombre2.FieldName = "nombre";
            this.colnombre2.Name = "colnombre2";
            this.colnombre2.Visible = true;
            this.colnombre2.VisibleIndex = 0;
            // 
            // colDataColumn1
            // 
            this.colDataColumn1.Caption = "Seleccione:";
            this.colDataColumn1.FieldName = "checkcolumn";
            this.colDataColumn1.Name = "colDataColumn1";
            this.colDataColumn1.Visible = true;
            this.colDataColumn1.VisibleIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Departamento:";
            // 
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataMember = "departamentos";
            this.departamentosBindingSource.DataSource = this.dsSolicitudes;
            // 
            // grdDepartamento
            // 
            this.grdDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdDepartamento.EditValue = "";
            this.grdDepartamento.Location = new System.Drawing.Point(259, 163);
            this.grdDepartamento.Name = "grdDepartamento";
            this.grdDepartamento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdDepartamento.Properties.Appearance.Options.UseFont = true;
            this.grdDepartamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdDepartamento.Properties.DataSource = this.departamentosBindingSource;
            this.grdDepartamento.Properties.DisplayMember = "grupo";
            this.grdDepartamento.Properties.ValueMember = "id";
            this.grdDepartamento.Properties.View = this.gridView3;
            this.grdDepartamento.Size = new System.Drawing.Size(249, 28);
            this.grdDepartamento.TabIndex = 4;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colgrupo1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // colgrupo1
            // 
            this.colgrupo1.Caption = "Grupo";
            this.colgrupo1.FieldName = "grupo";
            this.colgrupo1.Name = "colgrupo1";
            this.colgrupo1.Visible = true;
            this.colgrupo1.VisibleIndex = 0;
            // 
            // dtSolicitud
            // 
            this.dtSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtSolicitud.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSolicitud.Location = new System.Drawing.Point(259, 206);
            this.dtSolicitud.Name = "dtSolicitud";
            this.dtSolicitud.Size = new System.Drawing.Size(156, 28);
            this.dtSolicitud.TabIndex = 6;
            this.dtSolicitud.Value = new System.DateTime(2019, 3, 27, 0, 0, 0, 0);
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(154)))), ((int)(((byte)(236)))));
            this.cmdImprimir.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimir.Appearance.Options.UseBackColor = true;
            this.cmdImprimir.Appearance.Options.UseFont = true;
            this.cmdImprimir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdImprimir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdImprimir.ImageOptions.Image")));
            this.cmdImprimir.Location = new System.Drawing.Point(40, 731);
            this.cmdImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(139, 62);
            this.cmdImprimir.TabIndex = 37;
            this.cmdImprimir.Text = "Enviar";
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Appearance.Options.UseBackColor = true;
            this.cmdCancelar.Appearance.Options.UseFont = true;
            this.cmdCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.ImageOptions.Image")));
            this.cmdCancelar.Location = new System.Drawing.Point(828, 731);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(139, 62);
            this.cmdCancelar.TabIndex = 36;
            this.cmdCancelar.Text = "Salir";
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 21);
            this.label8.TabIndex = 38;
            this.label8.Text = "Fecha de Solicitud:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 575);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "Campos Opcionales:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 612);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 21);
            this.label10.TabIndex = 40;
            this.label10.Text = "Otros accesos especiales:";
            // 
            // txtOacceso
            // 
            this.txtOacceso.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOacceso.Location = new System.Drawing.Point(229, 613);
            this.txtOacceso.Multiline = true;
            this.txtOacceso.Name = "txtOacceso";
            this.txtOacceso.Size = new System.Drawing.Size(305, 52);
            this.txtOacceso.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(594, 613);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 21);
            this.label11.TabIndex = 42;
            this.label11.Text = "Razon:";
            // 
            // txtRazon
            // 
            this.txtRazon.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazon.Location = new System.Drawing.Point(662, 613);
            this.txtRazon.Multiline = true;
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(305, 52);
            this.txtRazon.TabIndex = 12;
            // 
            // labeldt
            // 
            this.labeldt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labeldt.AutoSize = true;
            this.labeldt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldt.Location = new System.Drawing.Point(241, 544);
            this.labeldt.Name = "labeldt";
            this.labeldt.Size = new System.Drawing.Size(197, 21);
            this.labeldt.TabIndex = 45;
            this.labeldt.Text = "Fecha a Eliminar Acceso:";
            // 
            // dtEliminar
            // 
            this.dtEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtEliminar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEliminar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEliminar.Location = new System.Drawing.Point(444, 538);
            this.dtEliminar.Name = "dtEliminar";
            this.dtEliminar.Size = new System.Drawing.Size(177, 28);
            this.dtEliminar.TabIndex = 10;
            this.dtEliminar.Value = new System.DateTime(2019, 3, 28, 0, 0, 0, 0);
            this.dtEliminar.ValueChanged += new System.EventHandler(this.dtEliminar_ValueChanged);
            this.dtEliminar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtEliminar_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 683);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 21);
            this.label13.TabIndex = 47;
            this.label13.Text = "Ticket#:";
            // 
            // txtTicket
            // 
            this.txtTicket.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket.Location = new System.Drawing.Point(93, 681);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(110, 28);
            this.txtTicket.TabIndex = 13;
            // 
            // txtAsignado
            // 
            this.txtAsignado.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsignado.Location = new System.Drawing.Point(324, 680);
            this.txtAsignado.Name = "txtAsignado";
            this.txtAsignado.Size = new System.Drawing.Size(110, 28);
            this.txtAsignado.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(220, 683);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 21);
            this.label14.TabIndex = 49;
            this.label14.Text = "Asignado a:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(618, 680);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(365, 21);
            this.label15.TabIndex = 54;
            this.label15.Text = "* Se necesitara aprobacion de Gerencia General";
            // 
            // boxEspecial
            // 
            this.boxEspecial.AutoSize = true;
            this.boxEspecial.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxEspecial.Location = new System.Drawing.Point(470, 679);
            this.boxEspecial.Name = "boxEspecial";
            this.boxEspecial.Size = new System.Drawing.Size(151, 25);
            this.boxEspecial.TabIndex = 53;
            this.boxEspecial.Text = "Acceso Especial";
            this.boxEspecial.UseVisualStyleBackColor = true;
            // 
            // colnombre1
            // 
            this.colnombre1.FieldName = "nombre";
            this.colnombre1.Name = "colnombre1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // checkall
            // 
            this.checkall.AutoSize = true;
            this.checkall.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkall.Location = new System.Drawing.Point(725, 242);
            this.checkall.Name = "checkall";
            this.checkall.Size = new System.Drawing.Size(77, 25);
            this.checkall.TabIndex = 55;
            this.checkall.Text = "Todos";
            this.checkall.UseVisualStyleBackColor = true;
            this.checkall.CheckedChanged += new System.EventHandler(this.checkall_CheckedChanged);
            // 
            // radioPerma
            // 
            this.radioPerma.AutoSize = true;
            this.radioPerma.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPerma.Location = new System.Drawing.Point(18, 512);
            this.radioPerma.Name = "radioPerma";
            this.radioPerma.Size = new System.Drawing.Size(178, 25);
            this.radioPerma.TabIndex = 57;
            this.radioPerma.TabStop = true;
            this.radioPerma.Text = "Acceso Permanente";
            this.radioPerma.UseVisualStyleBackColor = true;
            this.radioPerma.CheckedChanged += new System.EventHandler(this.radioPerma_CheckedChanged);
            this.radioPerma.Click += new System.EventHandler(this.radioPerma_Click);
            // 
            // radioTempo
            // 
            this.radioTempo.AutoSize = true;
            this.radioTempo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTempo.Location = new System.Drawing.Point(18, 538);
            this.radioTempo.Name = "radioTempo";
            this.radioTempo.Size = new System.Drawing.Size(159, 25);
            this.radioTempo.TabIndex = 58;
            this.radioTempo.TabStop = true;
            this.radioTempo.Text = "Acceso Temporal";
            this.radioTempo.UseVisualStyleBackColor = true;
            this.radioTempo.CheckedChanged += new System.EventHandler(this.radioTempo_CheckedChanged);
            this.radioTempo.Click += new System.EventHandler(this.radioTempo_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(807, 49);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(151, 21);
            this.lblEstado.TabIndex = 61;
            this.lblEstado.Text = "Estado de Solicitud";
            // 
            // grdEstado
            // 
            this.grdEstado.EditValue = "";
            this.grdEstado.Location = new System.Drawing.Point(802, 73);
            this.grdEstado.Name = "grdEstado";
            this.grdEstado.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdEstado.Properties.Appearance.Options.UseFont = true;
            this.grdEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdEstado.Properties.DataSource = this.estadoBindingSource;
            this.grdEstado.Properties.DisplayMember = "descripcion";
            this.grdEstado.Properties.ValueMember = "id";
            this.grdEstado.Properties.View = this.gridView2;
            this.grdEstado.Size = new System.Drawing.Size(165, 28);
            this.grdEstado.TabIndex = 62;
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "estado";
            this.estadoBindingSource.DataSource = this.dsSolicitudes;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid2,
            this.coldescripcion});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colid2
            // 
            this.colid2.Caption = "Codigo";
            this.colid2.FieldName = "id";
            this.colid2.Name = "colid2";
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Estado";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // IT_Solicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 802);
            this.Controls.Add(this.grdEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.radioTempo);
            this.Controls.Add(this.radioPerma);
            this.Controls.Add(this.checkall);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.boxEspecial);
            this.Controls.Add(this.txtAsignado);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labeldt);
            this.Controls.Add(this.dtEliminar);
            this.Controls.Add(this.txtRazon);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtOacceso);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdImprimir);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.dtSolicitud);
            this.Controls.Add(this.grdDepartamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grdSolicitud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IT_Solicitudes";
            this.Load += new System.EventHandler(this.IT_Solicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitud.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accesoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GridLookUpEdit grdSolicitud;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.GridLookUpEdit grdDepartamento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.DateTimePicker dtSolicitud;
        private DevExpress.XtraEditors.SimpleButton cmdImprimir;
        private DevExpress.XtraEditors.SimpleButton cmdCancelar;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private dsSolicitudes dsSolicitudes;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colgrupo1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOacceso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label labeldt;
        private System.Windows.Forms.DateTimePicker dtEliminar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.TextBox txtAsignado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox boxEspecial;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private System.Windows.Forms.BindingSource accesoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre2;
        private DevExpress.XtraGrid.Columns.GridColumn colDataColumn1;
        private System.Windows.Forms.CheckBox checkall;
        private System.Windows.Forms.RadioButton radioPerma;
        private System.Windows.Forms.RadioButton radioTempo;
        private System.Windows.Forms.Label lblEstado;
        private DevExpress.XtraEditors.GridLookUpEdit grdEstado;
        private System.Windows.Forms.BindingSource estadoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colid2;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
    }
}