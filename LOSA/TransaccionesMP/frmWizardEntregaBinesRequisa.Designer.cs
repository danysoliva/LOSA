
namespace LOSA.TransaccionesMP
{
    partial class frmWizardEntregaBinesRequisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWizardEntregaBinesRequisa));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dsTransaccionesMP1 = new LOSA.TransaccionesMP.dsTransaccionesMP();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.panelNotificacion = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtLotePT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtBarCodeRequisa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridDetalleRequisa = new DevExpress.XtraGrid.GridControl();
            this.gridvDetalleRequisa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsolicitada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentregada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_unidad_medida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositemEntregar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.timerLimpiarMensaje = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).BeginInit();
            this.panelNotificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLotePT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarCodeRequisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleRequisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvDetalleRequisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositemEntregar)).BeginInit();
            this.SuspendLayout();
            // 
            // dsTransaccionesMP1
            // 
            this.dsTransaccionesMP1.DataSetName = "dsTransaccionesMP";
            this.dsTransaccionesMP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.cmdHome.Location = new System.Drawing.Point(614, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(149, 48);
            this.cmdHome.TabIndex = 9;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // panelNotificacion
            // 
            this.panelNotificacion.BackColor = System.Drawing.Color.White;
            this.panelNotificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNotificacion.Controls.Add(this.lblMensaje);
            this.panelNotificacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNotificacion.Location = new System.Drawing.Point(0, 472);
            this.panelNotificacion.Name = "panelNotificacion";
            this.panelNotificacion.Size = new System.Drawing.Size(769, 71);
            this.panelNotificacion.TabIndex = 106;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(3, 6);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(763, 55);
            this.lblMensaje.TabIndex = 9;
            // 
            // txtLotePT
            // 
            this.txtLotePT.Enabled = false;
            this.txtLotePT.Location = new System.Drawing.Point(320, 25);
            this.txtLotePT.Name = "txtLotePT";
            this.txtLotePT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtLotePT.Properties.Appearance.Options.UseFont = true;
            this.txtLotePT.Size = new System.Drawing.Size(163, 28);
            this.txtLotePT.TabIndex = 110;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(259, 28);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 21);
            this.labelControl3.TabIndex = 109;
            this.labelControl3.Text = "Lote PT";
            // 
            // txtBarCodeRequisa
            // 
            this.txtBarCodeRequisa.Enabled = false;
            this.txtBarCodeRequisa.Location = new System.Drawing.Point(71, 25);
            this.txtBarCodeRequisa.Name = "txtBarCodeRequisa";
            this.txtBarCodeRequisa.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtBarCodeRequisa.Properties.Appearance.Options.UseFont = true;
            this.txtBarCodeRequisa.Size = new System.Drawing.Size(163, 28);
            this.txtBarCodeRequisa.TabIndex = 108;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(8, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 21);
            this.labelControl2.TabIndex = 107;
            this.labelControl2.Text = "Requisa";
            // 
            // gridDetalleRequisa
            // 
            this.gridDetalleRequisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetalleRequisa.DataMember = "detalle_requisa_liquidos_en_tarimas";
            this.gridDetalleRequisa.DataSource = this.dsTransaccionesMP1;
            this.gridDetalleRequisa.Location = new System.Drawing.Point(6, 69);
            this.gridDetalleRequisa.MainView = this.gridvDetalleRequisa;
            this.gridDetalleRequisa.Name = "gridDetalleRequisa";
            this.gridDetalleRequisa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositemEntregar});
            this.gridDetalleRequisa.Size = new System.Drawing.Size(757, 404);
            this.gridDetalleRequisa.TabIndex = 111;
            this.gridDetalleRequisa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridvDetalleRequisa});
            // 
            // gridvDetalleRequisa
            // 
            this.gridvDetalleRequisa.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridvDetalleRequisa.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridvDetalleRequisa.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridvDetalleRequisa.Appearance.Row.Options.UseFont = true;
            this.gridvDetalleRequisa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_materia_prima,
            this.colmp,
            this.colsolicitada,
            this.colentregada,
            this.colid_unidad_medida,
            this.colunidad,
            this.colcode_sap,
            this.gridColumn1});
            this.gridvDetalleRequisa.GridControl = this.gridDetalleRequisa;
            this.gridvDetalleRequisa.Name = "gridvDetalleRequisa";
            this.gridvDetalleRequisa.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_materia_prima
            // 
            this.colid_materia_prima.FieldName = "id_materia_prima";
            this.colid_materia_prima.Name = "colid_materia_prima";
            // 
            // colmp
            // 
            this.colmp.Caption = "Materia Prima";
            this.colmp.FieldName = "mp";
            this.colmp.Name = "colmp";
            this.colmp.OptionsColumn.AllowEdit = false;
            this.colmp.Visible = true;
            this.colmp.VisibleIndex = 1;
            // 
            // colsolicitada
            // 
            this.colsolicitada.Caption = "Cant. Solicitado";
            this.colsolicitada.DisplayFormat.FormatString = "n2";
            this.colsolicitada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsolicitada.FieldName = "solicitada";
            this.colsolicitada.Name = "colsolicitada";
            this.colsolicitada.OptionsColumn.AllowEdit = false;
            this.colsolicitada.Visible = true;
            this.colsolicitada.VisibleIndex = 2;
            // 
            // colentregada
            // 
            this.colentregada.Caption = "Cant. Entregada";
            this.colentregada.DisplayFormat.FormatString = "n2";
            this.colentregada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colentregada.FieldName = "entregada";
            this.colentregada.Name = "colentregada";
            this.colentregada.OptionsColumn.AllowEdit = false;
            this.colentregada.Visible = true;
            this.colentregada.VisibleIndex = 3;
            // 
            // colid_unidad_medida
            // 
            this.colid_unidad_medida.FieldName = "id_unidad_medida";
            this.colid_unidad_medida.Name = "colid_unidad_medida";
            // 
            // colunidad
            // 
            this.colunidad.FieldName = "unidad";
            this.colunidad.Name = "colunidad";
            // 
            // colcode_sap
            // 
            this.colcode_sap.Caption = "Cod. SAP";
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.AllowEdit = false;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Entrega a Requisa";
            this.gridColumn1.ColumnEdit = this.repositemEntregar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // repositemEntregar
            // 
            this.repositemEntregar.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.repositemEntregar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositemEntregar.Name = "repositemEntregar";
            this.repositemEntregar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositemEntregar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositemEntregar_ButtonClick);
            // 
            // timerLimpiarMensaje
            // 
            this.timerLimpiarMensaje.Interval = 5500;
            this.timerLimpiarMensaje.Tick += new System.EventHandler(this.timerLimpiarMensaje_Tick);
            // 
            // frmWizardEntregaBinesRequisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 543);
            this.ControlBox = false;
            this.Controls.Add(this.gridDetalleRequisa);
            this.Controls.Add(this.txtLotePT);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtBarCodeRequisa);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelNotificacion);
            this.Controls.Add(this.cmdHome);
            this.Name = "frmWizardEntregaBinesRequisa";
            this.Text = "Materia Prima Solicitada en Requisa";
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).EndInit();
            this.panelNotificacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtLotePT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarCodeRequisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleRequisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvDetalleRequisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositemEntregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private System.Windows.Forms.Panel panelNotificacion;
        private System.Windows.Forms.Label lblMensaje;
        private DevExpress.XtraEditors.TextEdit txtLotePT;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtBarCodeRequisa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private dsTransaccionesMP dsTransaccionesMP1;
        private DevExpress.XtraGrid.GridControl gridDetalleRequisa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridvDetalleRequisa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositemEntregar;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colmp;
        private DevExpress.XtraGrid.Columns.GridColumn colsolicitada;
        private DevExpress.XtraGrid.Columns.GridColumn colentregada;
        private DevExpress.XtraGrid.Columns.GridColumn colid_unidad_medida;
        private DevExpress.XtraGrid.Columns.GridColumn colunidad;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Timer timerLimpiarMensaje;
    }
}