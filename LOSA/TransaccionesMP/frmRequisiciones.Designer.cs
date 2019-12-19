namespace LOSA.TransaccionesMP
{
    partial class frmRequisiciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequisiciones));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grRequisicoinesMP = new DevExpress.XtraGrid.GridControl();
            this.dsTransaccionesMP1 = new LOSA.TransaccionesMP.dsTransaccionesMP();
            this.gvTarimas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_solicitada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_a_producir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocEntry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnVerD = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colcomentario = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grRequisicoinesMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(4, 3);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(167, 47);
            this.btnAtras.TabIndex = 33;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(172, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(348, 40);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Requisiciones MP";
            // 
            // grRequisicoinesMP
            // 
            this.grRequisicoinesMP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grRequisicoinesMP.DataMember = "requisiciones_h";
            this.grRequisicoinesMP.DataSource = this.dsTransaccionesMP1;
            this.grRequisicoinesMP.Location = new System.Drawing.Point(2, 56);
            this.grRequisicoinesMP.MainView = this.gvTarimas;
            this.grRequisicoinesMP.Name = "grRequisicoinesMP";
            this.grRequisicoinesMP.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnVerD});
            this.grRequisicoinesMP.Size = new System.Drawing.Size(635, 502);
            this.grRequisicoinesMP.TabIndex = 34;
            this.grRequisicoinesMP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTarimas});
            // 
            // dsTransaccionesMP1
            // 
            this.dsTransaccionesMP1.DataSetName = "dsTransaccionesMP";
            this.dsTransaccionesMP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colid_usuario,
            this.coluser_,
            this.colid_orden,
            this.colfecha_solicitada,
            this.colfecha_a_producir,
            this.colid_estado,
            this.colestado,
            this.colDocEntry,
            this.gridColumn1,
            this.colcomentario});
            this.gvTarimas.GridControl = this.grRequisicoinesMP;
            this.gvTarimas.Name = "gvTarimas";
            this.gvTarimas.OptionsCustomization.AllowFilter = false;
            this.gvTarimas.OptionsView.ShowAutoFilterRow = true;
            this.gvTarimas.OptionsView.ShowFooter = true;
            this.gvTarimas.OptionsView.ShowGroupPanel = false;
            this.gvTarimas.RowHeight = 20;
            // 
            // colid
            // 
            this.colid.Caption = "Num.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 65;
            // 
            // colid_usuario
            // 
            this.colid_usuario.FieldName = "id_usuario";
            this.colid_usuario.Name = "colid_usuario";
            this.colid_usuario.OptionsColumn.AllowEdit = false;
            // 
            // coluser_
            // 
            this.coluser_.Caption = "Usuario";
            this.coluser_.FieldName = "user_";
            this.coluser_.Name = "coluser_";
            this.coluser_.OptionsColumn.AllowEdit = false;
            this.coluser_.Visible = true;
            this.coluser_.VisibleIndex = 1;
            this.coluser_.Width = 85;
            // 
            // colid_orden
            // 
            this.colid_orden.FieldName = "id_orden";
            this.colid_orden.Name = "colid_orden";
            // 
            // colfecha_solicitada
            // 
            this.colfecha_solicitada.Caption = "Fecha";
            this.colfecha_solicitada.FieldName = "fecha_solicitada";
            this.colfecha_solicitada.Name = "colfecha_solicitada";
            this.colfecha_solicitada.OptionsColumn.AllowEdit = false;
            this.colfecha_solicitada.Visible = true;
            this.colfecha_solicitada.VisibleIndex = 2;
            this.colfecha_solicitada.Width = 85;
            // 
            // colfecha_a_producir
            // 
            this.colfecha_a_producir.Caption = "Fecha a Producir";
            this.colfecha_a_producir.FieldName = "fecha_a_producir";
            this.colfecha_a_producir.Name = "colfecha_a_producir";
            this.colfecha_a_producir.Visible = true;
            this.colfecha_a_producir.VisibleIndex = 3;
            this.colfecha_a_producir.Width = 85;
            // 
            // colid_estado
            // 
            this.colid_estado.FieldName = "id_estado";
            this.colid_estado.Name = "colid_estado";
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 4;
            this.colestado.Width = 85;
            // 
            // colDocEntry
            // 
            this.colDocEntry.Caption = "DocEntry SAP";
            this.colDocEntry.FieldName = "DocEntry";
            this.colDocEntry.Name = "colDocEntry";
            this.colDocEntry.OptionsColumn.AllowEdit = false;
            this.colDocEntry.Visible = true;
            this.colDocEntry.VisibleIndex = 5;
            this.colDocEntry.Width = 90;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ver";
            this.gridColumn1.ColumnEdit = this.btnVerD;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 43;
            // 
            // btnVerD
            // 
            this.btnVerD.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnVerD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnVerD.Name = "btnVerD";
            this.btnVerD.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnVerD.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnVerD_ButtonClick);
            // 
            // colcomentario
            // 
            this.colcomentario.Caption = "Comentario";
            this.colcomentario.FieldName = "comentario";
            this.colcomentario.Name = "colcomentario";
            this.colcomentario.OptionsColumn.AllowEdit = false;
            this.colcomentario.Visible = true;
            this.colcomentario.VisibleIndex = 6;
            this.colcomentario.Width = 79;
            // 
            // frmRequisiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.ControlBox = false;
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grRequisicoinesMP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRequisiciones";
            this.Text = "frmRequisiciones";
            ((System.ComponentModel.ISupportInitialize)(this.grRequisicoinesMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grRequisicoinesMP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTarimas;
        private dsTransaccionesMP dsTransaccionesMP1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_;
        private DevExpress.XtraGrid.Columns.GridColumn colid_orden;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_solicitada;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_a_producir;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colDocEntry;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnVerD;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentario;
    }
}