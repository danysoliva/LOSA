
namespace LOSA.TransaccionesMP
{
    partial class frmWizardSelectGranel_Liqu
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWizardSelectGranel_Liqu));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridDetalleRequisa = new DevExpress.XtraGrid.GridControl();
            this.dsTransaccionesMP1 = new LOSA.TransaccionesMP.dsTransaccionesMP();
            this.gridvDetalleRequisa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsolicitada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprogramada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentregada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_unidad_medida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colasignado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coludenvidas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUdRestante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconsumo_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconsumo_without_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositemEntregar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtBarCodeRequisa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtLotePT = new DevExpress.XtraEditors.TextEdit();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleRequisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvDetalleRequisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositemEntregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarCodeRequisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLotePT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(54, 102);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 21);
            this.labelControl1.TabIndex = 2;
            // 
            // gridDetalleRequisa
            // 
            this.gridDetalleRequisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetalleRequisa.DataMember = "requisiciones_d";
            this.gridDetalleRequisa.DataSource = this.dsTransaccionesMP1;
            this.gridDetalleRequisa.Location = new System.Drawing.Point(2, 73);
            this.gridDetalleRequisa.MainView = this.gridvDetalleRequisa;
            this.gridDetalleRequisa.Name = "gridDetalleRequisa";
            this.gridDetalleRequisa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositemEntregar});
            this.gridDetalleRequisa.Size = new System.Drawing.Size(747, 450);
            this.gridDetalleRequisa.TabIndex = 3;
            this.gridDetalleRequisa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridvDetalleRequisa});
            // 
            // dsTransaccionesMP1
            // 
            this.dsTransaccionesMP1.DataSetName = "dsTransaccionesMP";
            this.dsTransaccionesMP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colprogramada,
            this.colentregada,
            this.colpendiente,
            this.colenable,
            this.colid_unidad_medida,
            this.colunidad,
            this.colcode_sap,
            this.colasignado,
            this.coludenvidas,
            this.colUdRestante,
            this.colconsumo_inv,
            this.colconsumo_without_inv,
            this.gridColumn1});
            this.gridvDetalleRequisa.GridControl = this.gridDetalleRequisa;
            this.gridvDetalleRequisa.Name = "gridvDetalleRequisa";
            this.gridvDetalleRequisa.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colid_materia_prima
            // 
            this.colid_materia_prima.FieldName = "id_materia_prima";
            this.colid_materia_prima.Name = "colid_materia_prima";
            this.colid_materia_prima.OptionsColumn.AllowEdit = false;
            // 
            // colmp
            // 
            this.colmp.Caption = "Materia Prima";
            this.colmp.FieldName = "mp";
            this.colmp.Name = "colmp";
            this.colmp.OptionsColumn.AllowEdit = false;
            this.colmp.Visible = true;
            this.colmp.VisibleIndex = 1;
            this.colmp.Width = 155;
            // 
            // colsolicitada
            // 
            this.colsolicitada.Caption = "Cant. Solicitada";
            this.colsolicitada.DisplayFormat.FormatString = "n2";
            this.colsolicitada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsolicitada.FieldName = "solicitada";
            this.colsolicitada.Name = "colsolicitada";
            this.colsolicitada.OptionsColumn.AllowEdit = false;
            this.colsolicitada.Visible = true;
            this.colsolicitada.VisibleIndex = 2;
            this.colsolicitada.Width = 134;
            // 
            // colprogramada
            // 
            this.colprogramada.FieldName = "programada";
            this.colprogramada.Name = "colprogramada";
            this.colprogramada.OptionsColumn.AllowEdit = false;
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
            this.colentregada.Width = 135;
            // 
            // colpendiente
            // 
            this.colpendiente.FieldName = "pendiente";
            this.colpendiente.Name = "colpendiente";
            this.colpendiente.OptionsColumn.AllowEdit = false;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.AllowEdit = false;
            // 
            // colid_unidad_medida
            // 
            this.colid_unidad_medida.FieldName = "id_unidad_medida";
            this.colid_unidad_medida.Name = "colid_unidad_medida";
            this.colid_unidad_medida.OptionsColumn.AllowEdit = false;
            // 
            // colunidad
            // 
            this.colunidad.FieldName = "unidad";
            this.colunidad.Name = "colunidad";
            this.colunidad.OptionsColumn.AllowEdit = false;
            // 
            // colcode_sap
            // 
            this.colcode_sap.Caption = "Cod. SAP";
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.AllowEdit = false;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 0;
            this.colcode_sap.Width = 78;
            // 
            // colasignado
            // 
            this.colasignado.FieldName = "asignado";
            this.colasignado.Name = "colasignado";
            this.colasignado.OptionsColumn.AllowEdit = false;
            // 
            // coludenvidas
            // 
            this.coludenvidas.FieldName = "udenvidas";
            this.coludenvidas.Name = "coludenvidas";
            this.coludenvidas.OptionsColumn.AllowEdit = false;
            // 
            // colUdRestante
            // 
            this.colUdRestante.FieldName = "UdRestante";
            this.colUdRestante.Name = "colUdRestante";
            this.colUdRestante.OptionsColumn.AllowEdit = false;
            // 
            // colconsumo_inv
            // 
            this.colconsumo_inv.FieldName = "consumo_inv";
            this.colconsumo_inv.Name = "colconsumo_inv";
            this.colconsumo_inv.OptionsColumn.AllowEdit = false;
            // 
            // colconsumo_without_inv
            // 
            this.colconsumo_without_inv.FieldName = "consumo_without_inv";
            this.colconsumo_without_inv.Name = "colconsumo_without_inv";
            this.colconsumo_without_inv.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Entregar a Produccion";
            this.gridColumn1.ColumnEdit = this.repositemEntregar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 165;
            // 
            // repositemEntregar
            // 
            this.repositemEntregar.AutoHeight = false;
            editorButtonImageOptions3.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions3.SvgImage")));
            this.repositemEntregar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositemEntregar.Name = "repositemEntregar";
            this.repositemEntregar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositemEntregar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositemEntregar_ButtonClick);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 21);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Requisa";
            // 
            // txtBarCodeRequisa
            // 
            this.txtBarCodeRequisa.Enabled = false;
            this.txtBarCodeRequisa.Location = new System.Drawing.Point(75, 22);
            this.txtBarCodeRequisa.Name = "txtBarCodeRequisa";
            this.txtBarCodeRequisa.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtBarCodeRequisa.Properties.Appearance.Options.UseFont = true;
            this.txtBarCodeRequisa.Size = new System.Drawing.Size(163, 28);
            this.txtBarCodeRequisa.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(263, 25);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 21);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Lote PT";
            // 
            // txtLotePT
            // 
            this.txtLotePT.Enabled = false;
            this.txtLotePT.Location = new System.Drawing.Point(324, 22);
            this.txtLotePT.Name = "txtLotePT";
            this.txtLotePT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtLotePT.Properties.Appearance.Options.UseFont = true;
            this.txtLotePT.Size = new System.Drawing.Size(163, 28);
            this.txtLotePT.TabIndex = 7;
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
            this.cmdHome.Location = new System.Drawing.Point(595, 9);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(149, 48);
            this.cmdHome.TabIndex = 8;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // frmWizardSelectGranel_Liqu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 525);
            this.ControlBox = false;
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.txtLotePT);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtBarCodeRequisa);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gridDetalleRequisa);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmWizardSelectGranel_Liqu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Materias Primas en Requisa";
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleRequisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvDetalleRequisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositemEntregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarCodeRequisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLotePT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridDetalleRequisa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridvDetalleRequisa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtBarCodeRequisa;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtLotePT;
        private dsTransaccionesMP dsTransaccionesMP1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colmp;
        private DevExpress.XtraGrid.Columns.GridColumn colsolicitada;
        private DevExpress.XtraGrid.Columns.GridColumn colprogramada;
        private DevExpress.XtraGrid.Columns.GridColumn colentregada;
        private DevExpress.XtraGrid.Columns.GridColumn colpendiente;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colid_unidad_medida;
        private DevExpress.XtraGrid.Columns.GridColumn colunidad;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap;
        private DevExpress.XtraGrid.Columns.GridColumn colasignado;
        private DevExpress.XtraGrid.Columns.GridColumn coludenvidas;
        private DevExpress.XtraGrid.Columns.GridColumn colUdRestante;
        private DevExpress.XtraGrid.Columns.GridColumn colconsumo_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colconsumo_without_inv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositemEntregar;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
    }
}