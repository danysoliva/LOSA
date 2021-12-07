
namespace LOSA.TransaccionesMP
{
    partial class frmEntregaTarimaReq_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntregaTarimaReq_3));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.lblRequisicionEncontrada = new DevExpress.XtraEditors.LabelControl();
            this.txtRequisicion = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelNotificacion = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsTransaccionesMP = new LOSA.TransaccionesMP.dsTransaccionesMP();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTarima = new DevExpress.XtraGrid.GridControl();
            this.gvTarima = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtTarima = new DevExpress.XtraEditors.ButtonEdit();
            this.cmdSelectTarima = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.timerLimpiarMensaje = new System.Windows.Forms.Timer();
            this.cmdLiquidos = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPendienteAsignacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tarima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado_tarima = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtRequisicion.Properties)).BeginInit();
            this.panelNotificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTarima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(453, 16);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(175, 48);
            this.cmdHome.TabIndex = 7;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // lblRequisicionEncontrada
            // 
            this.lblRequisicionEncontrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRequisicionEncontrada.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisicionEncontrada.Appearance.Options.UseFont = true;
            this.lblRequisicionEncontrada.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRequisicionEncontrada.Location = new System.Drawing.Point(12, 116);
            this.lblRequisicionEncontrada.Name = "lblRequisicionEncontrada";
            this.lblRequisicionEncontrada.Size = new System.Drawing.Size(258, 37);
            this.lblRequisicionEncontrada.TabIndex = 103;
            this.lblRequisicionEncontrada.Text = "Requisición #";
            // 
            // txtRequisicion
            // 
            this.txtRequisicion.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.txtRequisicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequisicion.EditValue = "";
            this.txtRequisicion.Location = new System.Drawing.Point(182, 66);
            this.txtRequisicion.Name = "txtRequisicion";
            this.txtRequisicion.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequisicion.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.txtRequisicion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtRequisicion.Properties.MaxLength = 20;
            this.txtRequisicion.Properties.NullText = "Escanee o selecciona una tarima";
            this.txtRequisicion.Size = new System.Drawing.Size(257, 44);
            this.txtRequisicion.TabIndex = 101;
            this.txtRequisicion.ToolTip = "Hola";
            this.txtRequisicion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRequisicion_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(3, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(173, 37);
            this.labelControl3.TabIndex = 102;
            this.labelControl3.Text = "Requisición:";
            // 
            // panelNotificacion
            // 
            this.panelNotificacion.BackColor = System.Drawing.Color.White;
            this.panelNotificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNotificacion.Controls.Add(this.lblMensaje);
            this.panelNotificacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNotificacion.Location = new System.Drawing.Point(0, 686);
            this.panelNotificacion.Name = "panelNotificacion";
            this.panelNotificacion.Size = new System.Drawing.Size(638, 71);
            this.panelNotificacion.TabIndex = 104;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(3, 5);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(630, 59);
            this.lblMensaje.TabIndex = 0;
            // 
            // grd_data
            // 
            this.grd_data.DataMember = "viewTarimas";
            this.grd_data.DataSource = this.dsTransaccionesMP;
            this.grd_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_data.Location = new System.Drawing.Point(0, 0);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(620, 245);
            this.grd_data.TabIndex = 105;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsTransaccionesMP
            // 
            this.dsTransaccionesMP.DataSetName = "dsTransaccionesMP";
            this.dsTransaccionesMP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colreq,
            this.colmp,
            this.colcantidad,
            this.colkg,
            this.coltm,
            this.collote});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colreq
            // 
            this.colreq.Caption = "Requisa";
            this.colreq.FieldName = "req";
            this.colreq.Name = "colreq";
            this.colreq.OptionsColumn.AllowEdit = false;
            this.colreq.Visible = true;
            this.colreq.VisibleIndex = 2;
            // 
            // colmp
            // 
            this.colmp.Caption = "Materia Prima";
            this.colmp.FieldName = "mp";
            this.colmp.Name = "colmp";
            this.colmp.OptionsColumn.AllowEdit = false;
            this.colmp.Visible = true;
            this.colmp.VisibleIndex = 3;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 4;
            // 
            // colkg
            // 
            this.colkg.Caption = "Kg.";
            this.colkg.FieldName = "kg";
            this.colkg.Name = "colkg";
            this.colkg.OptionsColumn.AllowEdit = false;
            this.colkg.Visible = true;
            this.colkg.VisibleIndex = 5;
            // 
            // coltm
            // 
            this.coltm.Caption = "Tarima";
            this.coltm.FieldName = "tm";
            this.coltm.Name = "coltm";
            this.coltm.OptionsColumn.AllowEdit = false;
            this.coltm.Visible = true;
            this.coltm.VisibleIndex = 0;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 1;
            // 
            // gcTarima
            // 
            this.gcTarima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTarima.EmbeddedNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.gcTarima.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gcTarima.Location = new System.Drawing.Point(27, 205);
            this.gcTarima.MainView = this.gvTarima;
            this.gcTarima.Name = "gcTarima";
            this.gcTarima.Size = new System.Drawing.Size(558, 193);
            this.gcTarima.TabIndex = 110;
            this.gcTarima.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTarima});
            // 
            // gvTarima
            // 
            this.gvTarima.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvTarima.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gvTarima.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvTarima.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvTarima.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvTarima.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvTarima.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvTarima.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvTarima.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gvTarima.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvTarima.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvTarima.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvTarima.Appearance.Empty.BackColor = System.Drawing.SystemColors.Control;
            this.gvTarima.Appearance.Empty.Options.UseBackColor = true;
            this.gvTarima.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvTarima.Appearance.EvenRow.BackColor2 = System.Drawing.Color.White;
            this.gvTarima.Appearance.EvenRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvTarima.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvTarima.Appearance.EvenRow.Options.UseFont = true;
            this.gvTarima.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvTarima.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvTarima.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gvTarima.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvTarima.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvTarima.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvTarima.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvTarima.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvTarima.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gvTarima.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvTarima.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvTarima.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvTarima.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvTarima.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvTarima.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gvTarima.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvTarima.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gvTarima.Appearance.FocusedCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTarima.Appearance.FocusedCell.Options.UseFont = true;
            this.gvTarima.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvTarima.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent;
            this.gvTarima.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Transparent;
            this.gvTarima.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTarima.Appearance.FocusedRow.Options.UseFont = true;
            this.gvTarima.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvTarima.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvTarima.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvTarima.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvTarima.Appearance.FooterPanel.Options.UseFont = true;
            this.gvTarima.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvTarima.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvTarima.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvTarima.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvTarima.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvTarima.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvTarima.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvTarima.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvTarima.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvTarima.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gvTarima.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTarima.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvTarima.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gvTarima.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvTarima.Appearance.GroupPanel.Options.UseFont = true;
            this.gvTarima.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvTarima.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gvTarima.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvTarima.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvTarima.Appearance.GroupRow.Options.UseFont = true;
            this.gvTarima.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvTarima.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvTarima.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvTarima.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvTarima.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTarima.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvTarima.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.White;
            this.gvTarima.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvTarima.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTarima.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvTarima.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvTarima.Appearance.HorzLine.BackColor = System.Drawing.Color.DarkGray;
            this.gvTarima.Appearance.HorzLine.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvTarima.Appearance.HorzLine.Options.UseFont = true;
            this.gvTarima.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvTarima.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gvTarima.Appearance.OddRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gvTarima.Appearance.OddRow.Options.UseBackColor = true;
            this.gvTarima.Appearance.OddRow.Options.UseFont = true;
            this.gvTarima.Appearance.OddRow.Options.UseForeColor = true;
            this.gvTarima.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gvTarima.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gvTarima.Appearance.Preview.Options.UseBackColor = true;
            this.gvTarima.Appearance.Preview.Options.UseFont = true;
            this.gvTarima.Appearance.Preview.Options.UseForeColor = true;
            this.gvTarima.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvTarima.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvTarima.Appearance.Row.Options.UseBackColor = true;
            this.gvTarima.Appearance.Row.Options.UseFont = true;
            this.gvTarima.Appearance.Row.Options.UseForeColor = true;
            this.gvTarima.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvTarima.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvTarima.Appearance.RowSeparator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvTarima.Appearance.RowSeparator.Options.UseFont = true;
            this.gvTarima.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gvTarima.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvTarima.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvTarima.Appearance.SelectedRow.Options.UseFont = true;
            this.gvTarima.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvTarima.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvTarima.Appearance.TopNewRow.Options.UseFont = true;
            this.gvTarima.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gvTarima.Appearance.VertLine.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarima.Appearance.VertLine.Options.UseBackColor = true;
            this.gvTarima.Appearance.VertLine.Options.UseFont = true;
            this.gvTarima.GridControl = this.gcTarima;
            this.gvTarima.Name = "gvTarima";
            this.gvTarima.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvTarima.OptionsBehavior.Editable = false;
            this.gvTarima.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTarima.OptionsView.EnableAppearanceOddRow = true;
            this.gvTarima.OptionsView.ShowColumnHeaders = false;
            this.gvTarima.OptionsView.ShowGroupPanel = false;
            this.gvTarima.OptionsView.ShowIndicator = false;
            this.gvTarima.PaintStyleName = "Flat";
            // 
            // txtTarima
            // 
            this.txtTarima.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.txtTarima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTarima.EditValue = "";
            this.txtTarima.Location = new System.Drawing.Point(195, 159);
            this.txtTarima.Name = "txtTarima";
            this.txtTarima.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarima.Properties.Appearance.Options.UseFont = true;
            this.txtTarima.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.txtTarima.Properties.MaxLength = 20;
            this.txtTarima.Properties.NullText = "Escanee o selecciona una tarima";
            this.txtTarima.Size = new System.Drawing.Size(257, 44);
            this.txtTarima.TabIndex = 107;
            this.txtTarima.ToolTip = "Hola";
            this.txtTarima.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTarima_KeyDown);
            // 
            // cmdSelectTarima
            // 
            this.cmdSelectTarima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSelectTarima.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelectTarima.Appearance.Options.UseFont = true;
            this.cmdSelectTarima.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSelectTarima.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.cmdSelectTarima.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdSelectTarima.Location = new System.Drawing.Point(458, 159);
            this.cmdSelectTarima.Name = "cmdSelectTarima";
            this.cmdSelectTarima.Size = new System.Drawing.Size(62, 44);
            this.cmdSelectTarima.TabIndex = 108;
            this.cmdSelectTarima.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(67, 166);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 37);
            this.labelControl2.TabIndex = 109;
            this.labelControl2.Text = "Tarima:";
            // 
            // timerLimpiarMensaje
            // 
            this.timerLimpiarMensaje.Interval = 4000;
            this.timerLimpiarMensaje.Tick += new System.EventHandler(this.timerLimpiarMensaje_Tick);
            // 
            // cmdLiquidos
            // 
            this.cmdLiquidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdLiquidos.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdLiquidos.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLiquidos.Appearance.Options.UseBackColor = true;
            this.cmdLiquidos.Appearance.Options.UseFont = true;
            this.cmdLiquidos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdLiquidos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdLiquidos.ImageOptions.Image")));
            this.cmdLiquidos.Location = new System.Drawing.Point(272, 16);
            this.cmdLiquidos.Name = "cmdLiquidos";
            this.cmdLiquidos.Size = new System.Drawing.Size(175, 48);
            this.cmdLiquidos.TabIndex = 111;
            this.cmdLiquidos.Text = "Liquidos";
            this.cmdLiquidos.Visible = false;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.AppearancePage.Header.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(8, 404);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(626, 285);
            this.xtraTabControl1.TabIndex = 112;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.grd_data);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(620, 245);
            this.xtraTabPage1.Text = "MP Entregada";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(620, 245);
            this.xtraTabPage2.Text = "Bines Disponibles";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "bines_disponibles";
            this.gridControl1.DataSource = this.dsTransaccionesMP;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(620, 245);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPendienteAsignacion,
            this.colnombre_comercial,
            this.colcodigo_barra,
            this.colid_tarima,
            this.colid_estado_tarima});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colPendienteAsignacion
            // 
            this.colPendienteAsignacion.Caption = "Pendiente Asignación";
            this.colPendienteAsignacion.FieldName = "PendienteAsignacion";
            this.colPendienteAsignacion.Name = "colPendienteAsignacion";
            this.colPendienteAsignacion.Visible = true;
            this.colPendienteAsignacion.VisibleIndex = 0;
            // 
            // colnombre_comercial
            // 
            this.colnombre_comercial.Caption = "Materia Prima";
            this.colnombre_comercial.FieldName = "nombre_comercial";
            this.colnombre_comercial.Name = "colnombre_comercial";
            this.colnombre_comercial.Visible = true;
            this.colnombre_comercial.VisibleIndex = 1;
            // 
            // colcodigo_barra
            // 
            this.colcodigo_barra.Caption = "Código Barra";
            this.colcodigo_barra.FieldName = "codigo_barra";
            this.colcodigo_barra.Name = "colcodigo_barra";
            this.colcodigo_barra.Visible = true;
            this.colcodigo_barra.VisibleIndex = 2;
            // 
            // colid_tarima
            // 
            this.colid_tarima.Caption = "Id Tarima";
            this.colid_tarima.FieldName = "id_tarima";
            this.colid_tarima.Name = "colid_tarima";
            // 
            // colid_estado_tarima
            // 
            this.colid_estado_tarima.FieldName = "id_estado_tarima";
            this.colid_estado_tarima.Name = "colid_estado_tarima";
            // 
            // frmEntregaTarimaReq_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 757);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.cmdLiquidos);
            this.Controls.Add(this.gcTarima);
            this.Controls.Add(this.txtTarima);
            this.Controls.Add(this.cmdSelectTarima);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelNotificacion);
            this.Controls.Add(this.lblRequisicionEncontrada);
            this.Controls.Add(this.txtRequisicion);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmdHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEntregaTarimaReq_3";
            this.Text = "frmEntregaTarimaReq_3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmEntregaTarimaReq_3_Activated);
            this.Load += new System.EventHandler(this.frmEntregaTarimaReq_3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtRequisicion.Properties)).EndInit();
            this.panelNotificacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTarima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.LabelControl lblRequisicionEncontrada;
        private DevExpress.XtraEditors.ButtonEdit txtRequisicion;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panelNotificacion;
        private System.Windows.Forms.Label lblMensaje;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraGrid.GridControl gcTarima;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTarima;
        private DevExpress.XtraEditors.ButtonEdit txtTarima;
        private DevExpress.XtraEditors.SimpleButton cmdSelectTarima;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Timer timerLimpiarMensaje;
        private dsTransaccionesMP dsTransaccionesMP;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colreq;
        private DevExpress.XtraGrid.Columns.GridColumn colmp;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colkg;
        private DevExpress.XtraGrid.Columns.GridColumn coltm;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraEditors.SimpleButton cmdLiquidos;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPendienteAsignacion;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tarima;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado_tarima;
    }
}