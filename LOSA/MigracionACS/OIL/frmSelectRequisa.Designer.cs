
namespace LOSA.MigracionACS.OIL
{
    partial class frmSelectRequisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectRequisa));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.grdRequisas = new DevExpress.XtraGrid.GridControl();
            this.dsTransaccionesMP1 = new LOSA.TransaccionesMP.dsTransaccionesMP();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_requisa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_solicitada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_a_producir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfinalizado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_solicitada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_entregada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposSelectRequ = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRequisas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposSelectRequ)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(1044, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(124, 45);
            this.btnAtras.TabIndex = 34;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // grdRequisas
            // 
            this.grdRequisas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRequisas.DataMember = "requisiciones_aceites";
            this.grdRequisas.DataSource = this.dsTransaccionesMP1;
            this.grdRequisas.Location = new System.Drawing.Point(3, 63);
            this.grdRequisas.MainView = this.gridView1;
            this.grdRequisas.Name = "grdRequisas";
            this.grdRequisas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposSelectRequ});
            this.grdRequisas.Size = new System.Drawing.Size(1175, 526);
            this.grdRequisas.TabIndex = 35;
            this.grdRequisas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsTransaccionesMP1
            // 
            this.dsTransaccionesMP1.DataSetName = "dsTransaccionesMP";
            this.dsTransaccionesMP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_requisa,
            this.coluser_,
            this.colfecha_solicitada,
            this.colfecha_a_producir,
            this.colestado,
            this.colnombre_comercial,
            this.colfinalizado,
            this.colLote,
            this.colcantidad_solicitada,
            this.colcantidad_entregada,
            this.colpendiente,
            this.gridColumn1});
            this.gridView1.GridControl = this.grdRequisas;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colid_requisa
            // 
            this.colid_requisa.Caption = "# Requisa";
            this.colid_requisa.FieldName = "id_requisa";
            this.colid_requisa.Name = "colid_requisa";
            this.colid_requisa.Visible = true;
            this.colid_requisa.VisibleIndex = 0;
            this.colid_requisa.Width = 102;
            // 
            // coluser_
            // 
            this.coluser_.Caption = "Usuario";
            this.coluser_.FieldName = "user_";
            this.coluser_.Name = "coluser_";
            this.coluser_.Width = 97;
            // 
            // colfecha_solicitada
            // 
            this.colfecha_solicitada.Caption = "Fecha Solicitud";
            this.colfecha_solicitada.FieldName = "fecha_solicitada";
            this.colfecha_solicitada.Name = "colfecha_solicitada";
            this.colfecha_solicitada.Visible = true;
            this.colfecha_solicitada.VisibleIndex = 1;
            this.colfecha_solicitada.Width = 134;
            // 
            // colfecha_a_producir
            // 
            this.colfecha_a_producir.Caption = "Fecha Producir";
            this.colfecha_a_producir.FieldName = "fecha_a_producir";
            this.colfecha_a_producir.Name = "colfecha_a_producir";
            this.colfecha_a_producir.Visible = true;
            this.colfecha_a_producir.VisibleIndex = 2;
            this.colfecha_a_producir.Width = 112;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado Requisa";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 3;
            this.colestado.Width = 150;
            // 
            // colnombre_comercial
            // 
            this.colnombre_comercial.Caption = "MP";
            this.colnombre_comercial.FieldName = "nombre_comercial";
            this.colnombre_comercial.Name = "colnombre_comercial";
            this.colnombre_comercial.Visible = true;
            this.colnombre_comercial.VisibleIndex = 4;
            this.colnombre_comercial.Width = 163;
            // 
            // colfinalizado
            // 
            this.colfinalizado.FieldName = "finalizado";
            this.colfinalizado.Name = "colfinalizado";
            // 
            // colLote
            // 
            this.colLote.Caption = "Lote PT";
            this.colLote.FieldName = "Lote";
            this.colLote.Name = "colLote";
            this.colLote.Visible = true;
            this.colLote.VisibleIndex = 5;
            this.colLote.Width = 94;
            // 
            // colcantidad_solicitada
            // 
            this.colcantidad_solicitada.Caption = "Solicitado Requisa";
            this.colcantidad_solicitada.FieldName = "cantidad_solicitada";
            this.colcantidad_solicitada.Name = "colcantidad_solicitada";
            this.colcantidad_solicitada.Visible = true;
            this.colcantidad_solicitada.VisibleIndex = 6;
            this.colcantidad_solicitada.Width = 99;
            // 
            // colcantidad_entregada
            // 
            this.colcantidad_entregada.Caption = "Entregado en Requisa";
            this.colcantidad_entregada.FieldName = "cantidad_entregada";
            this.colcantidad_entregada.Name = "colcantidad_entregada";
            this.colcantidad_entregada.Visible = true;
            this.colcantidad_entregada.VisibleIndex = 7;
            this.colcantidad_entregada.Width = 100;
            // 
            // colpendiente
            // 
            this.colpendiente.Caption = "Pendiente ";
            this.colpendiente.FieldName = "pendiente";
            this.colpendiente.Name = "colpendiente";
            this.colpendiente.Visible = true;
            this.colpendiente.VisibleIndex = 8;
            this.colpendiente.Width = 108;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Seleccione";
            this.gridColumn1.ColumnEdit = this.reposSelectRequ;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 9;
            this.gridColumn1.Width = 95;
            // 
            // reposSelectRequ
            // 
            this.reposSelectRequ.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.reposSelectRequ.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposSelectRequ.Name = "reposSelectRequ";
            this.reposSelectRequ.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposSelectRequ.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposSelectRequ_ButtonClick);
            // 
            // frmSelectRequisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 591);
            this.Controls.Add(this.grdRequisas);
            this.Controls.Add(this.btnAtras);
            this.Name = "frmSelectRequisa";
            this.Text = "Seleccione una Requisa";
            ((System.ComponentModel.ISupportInitialize)(this.grdRequisas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposSelectRequ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.GridControl grdRequisas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private TransaccionesMP.dsTransaccionesMP dsTransaccionesMP1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposSelectRequ;
        private DevExpress.XtraGrid.Columns.GridColumn colid_requisa;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_solicitada;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_a_producir;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn colfinalizado;
        private DevExpress.XtraGrid.Columns.GridColumn colLote;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_solicitada;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_entregada;
        private DevExpress.XtraGrid.Columns.GridColumn colpendiente;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}