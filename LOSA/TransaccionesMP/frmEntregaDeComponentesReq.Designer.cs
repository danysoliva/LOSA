namespace LOSA.TransaccionesMP
{
    partial class frmEntregaDeComponentesReq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntregaDeComponentesReq));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.beIdTarima = new DevExpress.XtraEditors.ButtonEdit();
            this.cmdSelectTarima = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gvTarimas = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colasignado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grDetalleLote = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.beIdTarima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalleLote)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(459, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(175, 71);
            this.cmdHome.TabIndex = 8;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // beIdTarima
            // 
            this.beIdTarima.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.beIdTarima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beIdTarima.EditValue = "";
            this.beIdTarima.Location = new System.Drawing.Point(120, 36);
            this.beIdTarima.Name = "beIdTarima";
            this.beIdTarima.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beIdTarima.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.beIdTarima.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.beIdTarima.Properties.MaxLength = 20;
            this.beIdTarima.Properties.NullText = "Escanee o selecciona una tarima";
            this.beIdTarima.Size = new System.Drawing.Size(257, 44);
            this.beIdTarima.TabIndex = 38;
            this.beIdTarima.ToolTip = "Hola";
            // 
            // cmdSelectTarima
            // 
            this.cmdSelectTarima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSelectTarima.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelectTarima.Appearance.Options.UseFont = true;
            this.cmdSelectTarima.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSelectTarima.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.cmdSelectTarima.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdSelectTarima.Location = new System.Drawing.Point(383, 12);
            this.cmdSelectTarima.Name = "cmdSelectTarima";
            this.cmdSelectTarima.Size = new System.Drawing.Size(62, 69);
            this.cmdSelectTarima.TabIndex = 37;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(4, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 37);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Tarima:";
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gvTarimas
            // 
            this.gvTarimas.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gvTarimas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTarimas.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvTarimas.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gvTarimas.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTarimas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTarimas.Appearance.FocusedRow.Options.UseFont = true;
            this.gvTarimas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gvTarimas.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTarimas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvTarimas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTarimas.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTarimas.Appearance.Row.Options.UseFont = true;
            this.gvTarimas.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTarimas.Appearance.SelectedRow.Options.UseFont = true;
            this.gvTarimas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTarimas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTarimas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gridColumn1,
            this.colasignado});
            this.gvTarimas.GridControl = this.grDetalleLote;
            this.gvTarimas.Name = "gvTarimas";
            this.gvTarimas.OptionsCustomization.AllowFilter = false;
            this.gvTarimas.OptionsView.ShowAutoFilterRow = true;
            this.gvTarimas.OptionsView.ShowFooter = true;
            this.gvTarimas.OptionsView.ShowGroupPanel = false;
            this.gvTarimas.RowHeight = 20;
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
            this.colmp.Caption = "MP";
            this.colmp.FieldName = "mp";
            this.colmp.Name = "colmp";
            this.colmp.OptionsColumn.AllowEdit = false;
            this.colmp.Visible = true;
            this.colmp.VisibleIndex = 0;
            // 
            // colsolicitada
            // 
            this.colsolicitada.Caption = "Solicitada";
            this.colsolicitada.FieldName = "solicitada";
            this.colsolicitada.Name = "colsolicitada";
            this.colsolicitada.OptionsColumn.AllowEdit = false;
            this.colsolicitada.Visible = true;
            this.colsolicitada.VisibleIndex = 1;
            // 
            // colprogramada
            // 
            this.colprogramada.FieldName = "programada";
            this.colprogramada.Name = "colprogramada";
            // 
            // colentregada
            // 
            this.colentregada.Caption = "Entregada";
            this.colentregada.FieldName = "entregada";
            this.colentregada.Name = "colentregada";
            this.colentregada.OptionsColumn.AllowEdit = false;
            this.colentregada.Visible = true;
            this.colentregada.VisibleIndex = 3;
            // 
            // colpendiente
            // 
            this.colpendiente.Caption = "Pendiente";
            this.colpendiente.FieldName = "pendiente";
            this.colpendiente.Name = "colpendiente";
            this.colpendiente.OptionsColumn.AllowEdit = false;
            this.colpendiente.Visible = true;
            this.colpendiente.VisibleIndex = 4;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            // 
            // colid_unidad_medida
            // 
            this.colid_unidad_medida.FieldName = "id_unidad_medida";
            this.colid_unidad_medida.Name = "colid_unidad_medida";
            // 
            // colunidad
            // 
            this.colunidad.Caption = "Unidad Medida";
            this.colunidad.FieldName = "unidad";
            this.colunidad.Name = "colunidad";
            this.colunidad.OptionsColumn.AllowEdit = false;
            this.colunidad.Visible = true;
            this.colunidad.VisibleIndex = 5;
            // 
            // colcode_sap
            // 
            this.colcode_sap.Caption = "Cod. MP SAP";
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.AllowEdit = false;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 6;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.btnEdit;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            // 
            // colasignado
            // 
            this.colasignado.Caption = "Cant. Asignada";
            this.colasignado.FieldName = "asignado";
            this.colasignado.Name = "colasignado";
            this.colasignado.Visible = true;
            this.colasignado.VisibleIndex = 2;
            // 
            // grDetalleLote
            // 
            this.grDetalleLote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDetalleLote.DataMember = "requisiciones_d";
            this.grDetalleLote.Location = new System.Drawing.Point(4, 89);
            this.grDetalleLote.MainView = this.gvTarimas;
            this.grDetalleLote.Name = "grDetalleLote";
            this.grDetalleLote.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit});
            this.grDetalleLote.Size = new System.Drawing.Size(629, 467);
            this.grDetalleLote.TabIndex = 35;
            this.grDetalleLote.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTarimas});
            // 
            // frmEntregaDeComponentesReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.beIdTarima);
            this.Controls.Add(this.cmdSelectTarima);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grDetalleLote);
            this.Controls.Add(this.cmdHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEntregaDeComponentesReq";
            this.Text = "frmEntregaDeComponentesReq";
            ((System.ComponentModel.ISupportInitialize)(this.beIdTarima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalleLote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.ButtonEdit beIdTarima;
        private DevExpress.XtraEditors.SimpleButton cmdSelectTarima;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTarimas;
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colasignado;
        private DevExpress.XtraGrid.GridControl grDetalleLote;
    }
}