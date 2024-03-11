
namespace LOSA.Despachos
{
    partial class frmCrearSolicitudAutorizacionLotePT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearSolicitudAutorizacionLotePT));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.memoComentario = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grdTipoSoli = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdLotePT = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.rdAprobar = new System.Windows.Forms.RadioButton();
            this.rdRechazar = new System.Windows.Forms.RadioButton();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion_notifiacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpt_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lotesptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransaccionesDespacho = new LOSA.Despachos.dsTransaccionesDespacho();
            this.tiposolicitudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.memoComentario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoSoli.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLotePT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesDespacho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposolicitudBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(79, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(563, 50);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Solicitud de Autorizacion para Despacho de Lote PT";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Appearance.Options.UseBackColor = true;
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAgregar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAgregar.ImageOptions.SvgImage")));
            this.btnAgregar.Location = new System.Drawing.Point(219, 402);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 45);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(385, 402);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 45);
            this.simpleButton1.TabIndex = 31;
            this.simpleButton1.Text = "Guardar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // memoComentario
            // 
            this.memoComentario.Location = new System.Drawing.Point(237, 218);
            this.memoComentario.Name = "memoComentario";
            this.memoComentario.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoComentario.Properties.Appearance.Options.UseFont = true;
            this.memoComentario.Size = new System.Drawing.Size(324, 96);
            this.memoComentario.TabIndex = 32;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(70, 292);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(243, 22);
            this.labelControl3.TabIndex = 124;
            this.labelControl3.Text = "Comentario_______________";
            // 
            // grdTipoSoli
            // 
            this.grdTipoSoli.Location = new System.Drawing.Point(237, 96);
            this.grdTipoSoli.Name = "grdTipoSoli";
            this.grdTipoSoli.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.grdTipoSoli.Properties.Appearance.Options.UseFont = true;
            this.grdTipoSoli.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdTipoSoli.Properties.DataSource = this.tiposolicitudBindingSource;
            this.grdTipoSoli.Properties.DisplayMember = "descripcion_notifiacion";
            this.grdTipoSoli.Properties.NullText = "";
            this.grdTipoSoli.Properties.PopupFormSize = new System.Drawing.Size(300, 150);
            this.grdTipoSoli.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdTipoSoli.Properties.ValueMember = "id";
            this.grdTipoSoli.Size = new System.Drawing.Size(391, 28);
            this.grdTipoSoli.TabIndex = 125;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion_notifiacion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(70, 102);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(260, 22);
            this.labelControl1.TabIndex = 126;
            this.labelControl1.Text = "Tipo Solicitud_______________";
            // 
            // grdLotePT
            // 
            this.grdLotePT.Location = new System.Drawing.Point(237, 157);
            this.grdLotePT.Name = "grdLotePT";
            this.grdLotePT.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.grdLotePT.Properties.Appearance.Options.UseFont = true;
            this.grdLotePT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdLotePT.Properties.DataSource = this.lotesptBindingSource;
            this.grdLotePT.Properties.DisplayMember = "concat_";
            this.grdLotePT.Properties.NullText = "";
            this.grdLotePT.Properties.PopupFormSize = new System.Drawing.Size(400, 250);
            this.grdLotePT.Properties.PopupView = this.gridView1;
            this.grdLotePT.Properties.ValueMember = "lote_pt";
            this.grdLotePT.Size = new System.Drawing.Size(391, 28);
            this.grdLotePT.TabIndex = 127;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collote_pt,
            this.colpt_name});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(70, 163);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(215, 22);
            this.labelControl4.TabIndex = 128;
            this.labelControl4.Text = "Lote PT_______________";
            // 
            // rdAprobar
            // 
            this.rdAprobar.AutoSize = true;
            this.rdAprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.rdAprobar.Location = new System.Drawing.Point(227, 354);
            this.rdAprobar.Name = "rdAprobar";
            this.rdAprobar.Size = new System.Drawing.Size(92, 26);
            this.rdAprobar.TabIndex = 130;
            this.rdAprobar.TabStop = true;
            this.rdAprobar.Text = "Aprobar";
            this.rdAprobar.UseVisualStyleBackColor = true;
            this.rdAprobar.Visible = false;
            // 
            // rdRechazar
            // 
            this.rdRechazar.AutoSize = true;
            this.rdRechazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.rdRechazar.Location = new System.Drawing.Point(368, 354);
            this.rdRechazar.Name = "rdRechazar";
            this.rdRechazar.Size = new System.Drawing.Size(104, 26);
            this.rdRechazar.TabIndex = 131;
            this.rdRechazar.TabStop = true;
            this.rdRechazar.Text = "Rechazar";
            this.rdRechazar.UseVisualStyleBackColor = true;
            this.rdRechazar.Visible = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // coldescripcion_notifiacion
            // 
            this.coldescripcion_notifiacion.Caption = "Razon de Solicitud";
            this.coldescripcion_notifiacion.FieldName = "descripcion_notifiacion";
            this.coldescripcion_notifiacion.Name = "coldescripcion_notifiacion";
            this.coldescripcion_notifiacion.OptionsColumn.AllowEdit = false;
            this.coldescripcion_notifiacion.Visible = true;
            this.coldescripcion_notifiacion.VisibleIndex = 0;
            // 
            // collote_pt
            // 
            this.collote_pt.Caption = "Lote PT";
            this.collote_pt.FieldName = "lote_pt";
            this.collote_pt.Name = "collote_pt";
            this.collote_pt.OptionsColumn.AllowEdit = false;
            this.collote_pt.Visible = true;
            this.collote_pt.VisibleIndex = 0;
            this.collote_pt.Width = 168;
            // 
            // colpt_name
            // 
            this.colpt_name.Caption = "Nombre Producto";
            this.colpt_name.FieldName = "pt_name";
            this.colpt_name.Name = "colpt_name";
            this.colpt_name.OptionsColumn.AllowEdit = false;
            this.colpt_name.Visible = true;
            this.colpt_name.VisibleIndex = 1;
            this.colpt_name.Width = 647;
            // 
            // lotesptBindingSource
            // 
            this.lotesptBindingSource.DataMember = "lotes_pt";
            this.lotesptBindingSource.DataSource = this.dsTransaccionesDespacho;
            // 
            // dsTransaccionesDespacho
            // 
            this.dsTransaccionesDespacho.DataSetName = "dsTransaccionesDespacho";
            this.dsTransaccionesDespacho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposolicitudBindingSource
            // 
            this.tiposolicitudBindingSource.DataMember = "tipo_solicitud";
            this.tiposolicitudBindingSource.DataSource = this.dsTransaccionesDespacho;
            // 
            // frmCrearSolicitudAutorizacionLotePT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 465);
            this.Controls.Add(this.rdRechazar);
            this.Controls.Add(this.rdAprobar);
            this.Controls.Add(this.grdLotePT);
            this.Controls.Add(this.grdTipoSoli);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.memoComentario);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl4);
            this.MaximizeBox = false;
            this.Name = "frmCrearSolicitudAutorizacionLotePT";
            ((System.ComponentModel.ISupportInitialize)(this.memoComentario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoSoli.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLotePT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesDespacho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposolicitudBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.MemoEdit memoComentario;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit grdTipoSoli;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit grdLotePT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.BindingSource tiposolicitudBindingSource;
        private dsTransaccionesDespacho dsTransaccionesDespacho;
        private System.Windows.Forms.BindingSource lotesptBindingSource;
        private System.Windows.Forms.RadioButton rdAprobar;
        private System.Windows.Forms.RadioButton rdRechazar;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_notifiacion;
        private DevExpress.XtraGrid.Columns.GridColumn collote_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colpt_name;
    }
}