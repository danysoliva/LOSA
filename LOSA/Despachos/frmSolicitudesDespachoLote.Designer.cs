
namespace LOSA.Despachos
{
    partial class frmSolicitudesDespachoLote
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitudesDespachoLote));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tsFiltro = new DevExpress.XtraEditors.ToggleSwitch();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsTransaccionesDespacho1 = new LOSA.Despachos.dsTransaccionesDespacho();
            this.grd_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario_solicitante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_cre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_creacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_autoriza_calidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colautorizado_calidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_autorizacion_calidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusaurio_autoriza_finanzas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colautorizado_finanzas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_autorizacion_finanzas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_solicitud_despacho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGestionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddSolicitud = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tsFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesDespacho1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGestionar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(-4, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(1281, 21);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Autorizaciones de Lotes de Producto Terminado";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(171, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 17);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Mostrar Todas";
            // 
            // tsFiltro
            // 
            this.tsFiltro.Location = new System.Drawing.Point(264, 42);
            this.tsFiltro.Name = "tsFiltro";
            this.tsFiltro.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsFiltro.Properties.Appearance.Options.UseFont = true;
            this.tsFiltro.Properties.OffText = "No";
            this.tsFiltro.Properties.OnText = "Si";
            this.tsFiltro.Size = new System.Drawing.Size(107, 22);
            this.tsFiltro.TabIndex = 5;
            this.tsFiltro.Toggled += new System.EventHandler(this.tsFiltro_Toggled);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "solicitudes_lote_despachos";
            this.gridControl1.DataSource = this.dsTransaccionesDespacho1;
            this.gridControl1.Location = new System.Drawing.Point(4, 66);
            this.gridControl1.MainView = this.grd_data;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnGestionar});
            this.gridControl1.Size = new System.Drawing.Size(1269, 441);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_data});
            // 
            // dsTransaccionesDespacho1
            // 
            this.dsTransaccionesDespacho1.DataSetName = "dsTransaccionesDespacho";
            this.dsTransaccionesDespacho1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grd_data
            // 
            this.grd_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_usuario_solicitante,
            this.colusuario_cre,
            this.colcomentario,
            this.colfecha_creacion,
            this.colestado,
            this.colusuario_autoriza_calidad,
            this.colautorizado_calidad,
            this.colfecha_autorizacion_calidad,
            this.colusaurio_autoriza_finanzas,
            this.colautorizado_finanzas,
            this.colfecha_autorizacion_finanzas,
            this.collote_pt,
            this.coltipo_solicitud_despacho,
            this.gridColumn1});
            this.grd_data.GridControl = this.gridControl1;
            this.grd_data.Name = "grd_data";
            this.grd_data.OptionsView.ShowAutoFilterRow = true;
            this.grd_data.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colid_usuario_solicitante
            // 
            this.colid_usuario_solicitante.FieldName = "id_usuario_solicitante";
            this.colid_usuario_solicitante.Name = "colid_usuario_solicitante";
            this.colid_usuario_solicitante.OptionsColumn.ReadOnly = true;
            // 
            // colusuario_cre
            // 
            this.colusuario_cre.Caption = "Solicitado Por:";
            this.colusuario_cre.FieldName = "usuario_cre";
            this.colusuario_cre.Name = "colusuario_cre";
            this.colusuario_cre.OptionsColumn.ReadOnly = true;
            this.colusuario_cre.Visible = true;
            this.colusuario_cre.VisibleIndex = 0;
            this.colusuario_cre.Width = 90;
            // 
            // colcomentario
            // 
            this.colcomentario.Caption = "Comentario";
            this.colcomentario.FieldName = "comentario";
            this.colcomentario.Name = "colcomentario";
            this.colcomentario.OptionsColumn.ReadOnly = true;
            this.colcomentario.Visible = true;
            this.colcomentario.VisibleIndex = 2;
            this.colcomentario.Width = 109;
            // 
            // colfecha_creacion
            // 
            this.colfecha_creacion.Caption = "Fecha Solicitud";
            this.colfecha_creacion.DisplayFormat.FormatString = "g";
            this.colfecha_creacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_creacion.FieldName = "fecha_creacion";
            this.colfecha_creacion.Name = "colfecha_creacion";
            this.colfecha_creacion.OptionsColumn.ReadOnly = true;
            this.colfecha_creacion.Visible = true;
            this.colfecha_creacion.VisibleIndex = 3;
            this.colfecha_creacion.Width = 109;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado Solicitud";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.ReadOnly = true;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 5;
            this.colestado.Width = 122;
            // 
            // colusuario_autoriza_calidad
            // 
            this.colusuario_autoriza_calidad.FieldName = "usuario_autoriza_calidad";
            this.colusuario_autoriza_calidad.Name = "colusuario_autoriza_calidad";
            this.colusuario_autoriza_calidad.OptionsColumn.ReadOnly = true;
            // 
            // colautorizado_calidad
            // 
            this.colautorizado_calidad.Caption = "Calidad - Autorizado por:";
            this.colautorizado_calidad.FieldName = "autorizado_calidad";
            this.colautorizado_calidad.Name = "colautorizado_calidad";
            this.colautorizado_calidad.OptionsColumn.ReadOnly = true;
            this.colautorizado_calidad.Visible = true;
            this.colautorizado_calidad.VisibleIndex = 6;
            this.colautorizado_calidad.Width = 126;
            // 
            // colfecha_autorizacion_calidad
            // 
            this.colfecha_autorizacion_calidad.Caption = "Fecha Autorizado";
            this.colfecha_autorizacion_calidad.DisplayFormat.FormatString = "g";
            this.colfecha_autorizacion_calidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_autorizacion_calidad.FieldName = "fecha_autorizacion_calidad";
            this.colfecha_autorizacion_calidad.Name = "colfecha_autorizacion_calidad";
            this.colfecha_autorizacion_calidad.OptionsColumn.ReadOnly = true;
            this.colfecha_autorizacion_calidad.Visible = true;
            this.colfecha_autorizacion_calidad.VisibleIndex = 7;
            this.colfecha_autorizacion_calidad.Width = 103;
            // 
            // colusaurio_autoriza_finanzas
            // 
            this.colusaurio_autoriza_finanzas.FieldName = "usaurio_autoriza_finanzas";
            this.colusaurio_autoriza_finanzas.Name = "colusaurio_autoriza_finanzas";
            this.colusaurio_autoriza_finanzas.OptionsColumn.ReadOnly = true;
            // 
            // colautorizado_finanzas
            // 
            this.colautorizado_finanzas.Caption = "Finanzas - Autorizado por:";
            this.colautorizado_finanzas.FieldName = "autorizado_finanzas";
            this.colautorizado_finanzas.Name = "colautorizado_finanzas";
            this.colautorizado_finanzas.OptionsColumn.ReadOnly = true;
            this.colautorizado_finanzas.Width = 146;
            // 
            // colfecha_autorizacion_finanzas
            // 
            this.colfecha_autorizacion_finanzas.Caption = "Fecha Autorizado";
            this.colfecha_autorizacion_finanzas.DisplayFormat.FormatString = "g";
            this.colfecha_autorizacion_finanzas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_autorizacion_finanzas.FieldName = "fecha_autorizacion_finanzas";
            this.colfecha_autorizacion_finanzas.Name = "colfecha_autorizacion_finanzas";
            this.colfecha_autorizacion_finanzas.OptionsColumn.ReadOnly = true;
            this.colfecha_autorizacion_finanzas.Width = 99;
            // 
            // collote_pt
            // 
            this.collote_pt.Caption = "Lote PT";
            this.collote_pt.FieldName = "lote_pt";
            this.collote_pt.Name = "collote_pt";
            this.collote_pt.OptionsColumn.ReadOnly = true;
            this.collote_pt.Visible = true;
            this.collote_pt.VisibleIndex = 4;
            this.collote_pt.Width = 89;
            // 
            // coltipo_solicitud_despacho
            // 
            this.coltipo_solicitud_despacho.Caption = "Razon Solicitud";
            this.coltipo_solicitud_despacho.FieldName = "tipo_solicitud_despacho";
            this.coltipo_solicitud_despacho.Name = "coltipo_solicitud_despacho";
            this.coltipo_solicitud_despacho.OptionsColumn.ReadOnly = true;
            this.coltipo_solicitud_despacho.Visible = true;
            this.coltipo_solicitud_despacho.VisibleIndex = 1;
            this.coltipo_solicitud_despacho.Width = 154;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Gestionar";
            this.gridColumn1.ColumnEdit = this.btnGestionar;
            this.gridColumn1.FieldName = "Gestionar";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 97;
            // 
            // btnGestionar
            // 
            this.btnGestionar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnGestionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnGestionar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnGestionar_ButtonClick);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRefresh.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cmdRefresh.Appearance.Options.UseFont = true;
            this.cmdRefresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdRefresh.ImageOptions.SvgImage")));
            this.cmdRefresh.Location = new System.Drawing.Point(946, 12);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(145, 44);
            this.cmdRefresh.TabIndex = 53;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(1120, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(145, 44);
            this.btnAtras.TabIndex = 54;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAddSolicitud
            // 
            this.btnAddSolicitud.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSolicitud.Appearance.Options.UseFont = true;
            this.btnAddSolicitud.Appearance.Options.UseTextOptions = true;
            this.btnAddSolicitud.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnAddSolicitud.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAddSolicitud.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddSolicitud.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddSolicitud.ImageOptions.SvgImage")));
            this.btnAddSolicitud.Location = new System.Drawing.Point(12, 12);
            this.btnAddSolicitud.Name = "btnAddSolicitud";
            this.btnAddSolicitud.Size = new System.Drawing.Size(145, 44);
            this.btnAddSolicitud.TabIndex = 55;
            this.btnAddSolicitud.Text = "Crear Solicitud";
            this.btnAddSolicitud.Visible = false;
            this.btnAddSolicitud.Click += new System.EventHandler(this.btnAddSolicitud_Click);
            // 
            // frmSolicitudesDespachoLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 510);
            this.Controls.Add(this.btnAddSolicitud);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tsFiltro);
            this.Controls.Add(this.labelControl2);
            this.Name = "frmSolicitudesDespachoLote";
            ((System.ComponentModel.ISupportInitialize)(this.tsFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesDespacho1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGestionar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ToggleSwitch tsFiltro;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_data;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnGestionar;
        private DevExpress.XtraEditors.SimpleButton cmdRefresh;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private dsTransaccionesDespacho dsTransaccionesDespacho1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario_solicitante;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_cre;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentario;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_creacion;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_autoriza_calidad;
        private DevExpress.XtraGrid.Columns.GridColumn colautorizado_calidad;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_autorizacion_calidad;
        private DevExpress.XtraGrid.Columns.GridColumn colusaurio_autoriza_finanzas;
        private DevExpress.XtraGrid.Columns.GridColumn colautorizado_finanzas;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_autorizacion_finanzas;
        private DevExpress.XtraGrid.Columns.GridColumn collote_pt;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_solicitud_despacho;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton btnAddSolicitud;
    }
}