namespace LOSA.MigracionACS.Tickets.EndUser
{
    partial class frmVerSeguimiento
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerSeguimiento));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grd_seguimiento = new DevExpress.XtraGrid.GridControl();
            this.seguimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTickets = new LOSA.MigracionACS.Tickets.EndUser.dsTickets();
            this.grdv_seguimiento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnArchivo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtProyecto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaC = new DevExpress.XtraEditors.DateEdit();
            this.txtComentario2 = new System.Windows.Forms.RichTextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserAsignado = new DevExpress.XtraEditors.TextEdit();
            this.txtEstado = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTitulo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblNumTicket = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserCreador = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lblFormulario = new DevExpress.XtraEditors.LabelControl();
            this.txtNameVentana = new DevExpress.XtraEditors.TextEdit();
            this.btnExaminar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_seguimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_seguimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnArchivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProyecto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaC.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserAsignado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserCreador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameVentana.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_seguimiento
            // 
            this.grd_seguimiento.DataSource = this.seguimientoBindingSource;
            this.grd_seguimiento.Location = new System.Drawing.Point(-1, 410);
            this.grd_seguimiento.MainView = this.grdv_seguimiento;
            this.grd_seguimiento.Name = "grd_seguimiento";
            this.grd_seguimiento.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnArchivo});
            this.grd_seguimiento.Size = new System.Drawing.Size(808, 257);
            this.grd_seguimiento.TabIndex = 1;
            this.grd_seguimiento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_seguimiento});
            // 
            // seguimientoBindingSource
            // 
            this.seguimientoBindingSource.DataMember = "Seguimiento";
            this.seguimientoBindingSource.DataSource = this.dsTickets;
            this.seguimientoBindingSource.CurrentChanged += new System.EventHandler(this.seguimientoBindingSource_CurrentChanged);
            // 
            // dsTickets
            // 
            this.dsTickets.DataSetName = "dsTickets";
            this.dsTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_seguimiento
            // 
            this.grdv_seguimiento.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_seguimiento.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.Preview.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.Row.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_seguimiento.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_seguimiento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcomentario,
            this.colfecha,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.grdv_seguimiento.GridControl = this.grd_seguimiento;
            this.grdv_seguimiento.Name = "grdv_seguimiento";
            this.grdv_seguimiento.OptionsEditForm.PopupEditFormWidth = 686;
            this.grdv_seguimiento.OptionsView.ShowAutoFilterRow = true;
            this.grdv_seguimiento.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 21;
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Width = 177;
            // 
            // colcomentario
            // 
            this.colcomentario.Caption = "Comentario";
            this.colcomentario.FieldName = "comentario";
            this.colcomentario.MinWidth = 21;
            this.colcomentario.Name = "colcomentario";
            this.colcomentario.OptionsColumn.AllowEdit = false;
            this.colcomentario.OptionsFilter.AllowFilter = false;
            this.colcomentario.Visible = true;
            this.colcomentario.VisibleIndex = 1;
            this.colcomentario.Width = 554;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.MinWidth = 21;
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.OptionsFilter.AllowFilter = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
            this.colfecha.Width = 97;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ver";
            this.gridColumn1.ColumnEdit = this.btnArchivo;
            this.gridColumn1.MinWidth = 21;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 65;
            // 
            // btnArchivo
            // 
            this.btnArchivo.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnArchivo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnArchivo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnArchivo_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID Ticket";
            this.gridColumn2.FieldName = "id_ticket";
            this.gridColumn2.MinWidth = 21;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 81;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Usuario";
            this.gridColumn3.FieldName = "usuario_seguimiento";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 78;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(430, 102);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(80, 19);
            this.labelControl8.TabIndex = 64;
            this.labelControl8.Text = "Software:";
            // 
            // txtProyecto
            // 
            this.txtProyecto.Enabled = false;
            this.txtProyecto.Location = new System.Drawing.Point(525, 97);
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProyecto.Properties.Appearance.Options.UseFont = true;
            this.txtProyecto.Size = new System.Drawing.Size(208, 24);
            this.txtProyecto.TabIndex = 63;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(48, 137);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(129, 19);
            this.labelControl7.TabIndex = 62;
            this.labelControl7.Text = "Fecha Creacion:";
            // 
            // dtFechaC
            // 
            this.dtFechaC.EditValue = null;
            this.dtFechaC.Enabled = false;
            this.dtFechaC.Location = new System.Drawing.Point(223, 132);
            this.dtFechaC.Name = "dtFechaC";
            this.dtFechaC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.dtFechaC.Properties.Appearance.Options.UseFont = true;
            this.dtFechaC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaC.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaC.Size = new System.Drawing.Size(118, 24);
            this.dtFechaC.TabIndex = 61;
            // 
            // txtComentario2
            // 
            this.txtComentario2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario2.Location = new System.Drawing.Point(50, 274);
            this.txtComentario2.Name = "txtComentario2";
            this.txtComentario2.ReadOnly = true;
            this.txtComentario2.Size = new System.Drawing.Size(683, 96);
            this.txtComentario2.TabIndex = 60;
            this.txtComentario2.Text = "";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(48, 102);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(148, 19);
            this.labelControl6.TabIndex = 59;
            this.labelControl6.Text = "Usuario Asignado:";
            // 
            // txtUserAsignado
            // 
            this.txtUserAsignado.Enabled = false;
            this.txtUserAsignado.Location = new System.Drawing.Point(223, 97);
            this.txtUserAsignado.Name = "txtUserAsignado";
            this.txtUserAsignado.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAsignado.Properties.Appearance.Options.UseFont = true;
            this.txtUserAsignado.Size = new System.Drawing.Size(118, 24);
            this.txtUserAsignado.TabIndex = 58;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(525, 62);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Properties.Appearance.Options.UseFont = true;
            this.txtEstado.Size = new System.Drawing.Size(208, 24);
            this.txtEstado.TabIndex = 57;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(430, 67);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 19);
            this.labelControl5.TabIndex = 56;
            this.labelControl5.Text = "Estado:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(222, 171);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Properties.Appearance.Options.UseFont = true;
            this.txtTitulo.Properties.MaxLength = 50;
            this.txtTitulo.Properties.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(511, 24);
            this.txtTitulo.TabIndex = 55;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(50, 176);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 19);
            this.labelControl4.TabIndex = 54;
            this.labelControl4.Text = "Titulo:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(50, 241);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(175, 19);
            this.labelControl3.TabIndex = 53;
            this.labelControl3.Text = "Descripcion del ticket";
            // 
            // lblNumTicket
            // 
            this.lblNumTicket.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNumTicket.Appearance.Options.UseFont = true;
            this.lblNumTicket.Location = new System.Drawing.Point(440, 24);
            this.lblNumTicket.Name = "lblNumTicket";
            this.lblNumTicket.Size = new System.Drawing.Size(64, 23);
            this.lblNumTicket.TabIndex = 52;
            this.lblNumTicket.Text = "####";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(48, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(138, 19);
            this.labelControl2.TabIndex = 51;
            this.labelControl2.Text = "Usuario Creador:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(341, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 23);
            this.labelControl1.TabIndex = 50;
            this.labelControl1.Text = "Ticket #";
            // 
            // txtUserCreador
            // 
            this.txtUserCreador.Enabled = false;
            this.txtUserCreador.Location = new System.Drawing.Point(223, 62);
            this.txtUserCreador.Name = "txtUserCreador";
            this.txtUserCreador.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserCreador.Properties.Appearance.Options.UseFont = true;
            this.txtUserCreador.Size = new System.Drawing.Size(118, 24);
            this.txtUserCreador.TabIndex = 49;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(341, 376);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(102, 19);
            this.labelControl9.TabIndex = 65;
            this.labelControl9.Text = "Seguimiento";
            // 
            // lblFormulario
            // 
            this.lblFormulario.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblFormulario.Appearance.Options.UseFont = true;
            this.lblFormulario.Location = new System.Drawing.Point(11, 2);
            this.lblFormulario.Name = "lblFormulario";
            this.lblFormulario.Size = new System.Drawing.Size(128, 16);
            this.lblFormulario.TabIndex = 67;
            this.lblFormulario.Text = "Nombre de la Ventana";
            this.lblFormulario.Visible = false;
            // 
            // txtNameVentana
            // 
            this.txtNameVentana.EditValue = "frmVerSeguimiento";
            this.txtNameVentana.Location = new System.Drawing.Point(148, -2);
            this.txtNameVentana.Name = "txtNameVentana";
            this.txtNameVentana.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtNameVentana.Properties.Appearance.Options.UseFont = true;
            this.txtNameVentana.Properties.ReadOnly = true;
            this.txtNameVentana.Size = new System.Drawing.Size(141, 22);
            this.txtNameVentana.TabIndex = 66;
            this.txtNameVentana.Visible = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnExaminar.Appearance.Options.UseFont = true;
            this.btnExaminar.Appearance.Options.UseForeColor = true;
            this.btnExaminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExaminar.ImageOptions.Image")));
            this.btnExaminar.Location = new System.Drawing.Point(590, 224);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(143, 36);
            this.btnExaminar.TabIndex = 68;
            this.btnExaminar.Text = "Ver Adjuntos";
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // frmVerSeguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 680);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.lblFormulario);
            this.Controls.Add(this.txtNameVentana);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtProyecto);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.dtFechaC);
            this.Controls.Add(this.txtComentario2);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtUserAsignado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblNumTicket);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtUserCreador);
            this.Controls.Add(this.grd_seguimiento);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVerSeguimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Seguimiento";
            this.Load += new System.EventHandler(this.frmVerSeguimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_seguimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_seguimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnArchivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProyecto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaC.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserAsignado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserCreador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameVentana.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_seguimiento;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_seguimiento;
        private System.Windows.Forms.BindingSource seguimientoBindingSource;
        private dsTickets dsTickets;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentario;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnArchivo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtProyecto;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit dtFechaC;
        private System.Windows.Forms.RichTextBox txtComentario2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtUserAsignado;
        private DevExpress.XtraEditors.TextEdit txtEstado;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtTitulo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblNumTicket;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUserCreador;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl lblFormulario;
        private DevExpress.XtraEditors.TextEdit txtNameVentana;
        private DevExpress.XtraEditors.SimpleButton btnExaminar;
    }
}