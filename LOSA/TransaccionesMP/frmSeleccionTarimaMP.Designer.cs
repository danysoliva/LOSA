
namespace LOSA.TransaccionesMP
{
    partial class frmSeleccionTarimaMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionTarimaMP));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.grdtarimas = new DevExpress.XtraGrid.GridControl();
            this.grdvtarimas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dsTransaccionesMP1 = new LOSA.TransaccionesMP.dsTransaccionesMP();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tarima_prd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_venc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso_prd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkg_iniciales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkg_entregados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia_kg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.reposSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdtarimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvtarimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposSeleccionar)).BeginInit();
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
            this.cmdHome.Location = new System.Drawing.Point(703, 3);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(129, 49);
            this.cmdHome.TabIndex = 9;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // grdtarimas
            // 
            this.grdtarimas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdtarimas.DataMember = "detalle_tarima_prd_liqui";
            this.grdtarimas.DataSource = this.dsTransaccionesMP1;
            this.grdtarimas.Location = new System.Drawing.Point(2, 58);
            this.grdtarimas.MainView = this.grdvtarimas;
            this.grdtarimas.Name = "grdtarimas";
            this.grdtarimas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposSeleccionar});
            this.grdtarimas.Size = new System.Drawing.Size(830, 382);
            this.grdtarimas.TabIndex = 10;
            this.grdtarimas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvtarimas});
            // 
            // grdvtarimas
            // 
            this.grdvtarimas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdvtarimas.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdvtarimas.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdvtarimas.Appearance.Row.Options.UseFont = true;
            this.grdvtarimas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_tarima_prd,
            this.colid_mp,
            this.colmp,
            this.colitemcode,
            this.collote,
            this.colfecha_venc,
            this.colfecha_ingreso_prd,
            this.colkg_iniciales,
            this.colkg_entregados,
            this.colexistencia_kg,
            this.colcodigo_barra,
            this.gridColumn1});
            this.grdvtarimas.GridControl = this.grdtarimas;
            this.grdvtarimas.Name = "grdvtarimas";
            this.grdvtarimas.OptionsView.ShowGroupPanel = false;
            // 
            // dsTransaccionesMP1
            // 
            this.dsTransaccionesMP1.DataSetName = "dsTransaccionesMP";
            this.dsTransaccionesMP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_tarima_prd
            // 
            this.colid_tarima_prd.FieldName = "id_tarima_prd";
            this.colid_tarima_prd.Name = "colid_tarima_prd";
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.Name = "colid_mp";
            // 
            // colmp
            // 
            this.colmp.Caption = "Materia Prima";
            this.colmp.FieldName = "mp";
            this.colmp.Name = "colmp";
            this.colmp.OptionsColumn.AllowEdit = false;
            this.colmp.Visible = true;
            this.colmp.VisibleIndex = 1;
            this.colmp.Width = 112;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Cod. SAP";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Width = 100;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 2;
            this.collote.Width = 97;
            // 
            // colfecha_venc
            // 
            this.colfecha_venc.Caption = "Fecha Vencimiento";
            this.colfecha_venc.FieldName = "fecha_venc";
            this.colfecha_venc.Name = "colfecha_venc";
            this.colfecha_venc.OptionsColumn.AllowEdit = false;
            // 
            // colfecha_ingreso_prd
            // 
            this.colfecha_ingreso_prd.Caption = "Fecha Ingreso";
            this.colfecha_ingreso_prd.FieldName = "fecha_ingreso_prd";
            this.colfecha_ingreso_prd.Name = "colfecha_ingreso_prd";
            this.colfecha_ingreso_prd.OptionsColumn.AllowEdit = false;
            this.colfecha_ingreso_prd.Visible = true;
            this.colfecha_ingreso_prd.VisibleIndex = 3;
            this.colfecha_ingreso_prd.Width = 112;
            // 
            // colkg_iniciales
            // 
            this.colkg_iniciales.Caption = "Inicial";
            this.colkg_iniciales.DisplayFormat.FormatString = "n2";
            this.colkg_iniciales.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colkg_iniciales.FieldName = "kg_iniciales";
            this.colkg_iniciales.Name = "colkg_iniciales";
            this.colkg_iniciales.OptionsColumn.AllowEdit = false;
            this.colkg_iniciales.Visible = true;
            this.colkg_iniciales.VisibleIndex = 4;
            this.colkg_iniciales.Width = 88;
            // 
            // colkg_entregados
            // 
            this.colkg_entregados.Caption = "Entregado";
            this.colkg_entregados.DisplayFormat.FormatString = "n2";
            this.colkg_entregados.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colkg_entregados.FieldName = "kg_entregados";
            this.colkg_entregados.Name = "colkg_entregados";
            this.colkg_entregados.OptionsColumn.AllowEdit = false;
            this.colkg_entregados.Visible = true;
            this.colkg_entregados.VisibleIndex = 5;
            this.colkg_entregados.Width = 97;
            // 
            // colexistencia_kg
            // 
            this.colexistencia_kg.Caption = "Existencia ";
            this.colexistencia_kg.DisplayFormat.FormatString = "n2";
            this.colexistencia_kg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia_kg.FieldName = "existencia_kg";
            this.colexistencia_kg.Name = "colexistencia_kg";
            this.colexistencia_kg.OptionsColumn.AllowEdit = false;
            this.colexistencia_kg.Visible = true;
            this.colexistencia_kg.VisibleIndex = 6;
            this.colexistencia_kg.Width = 86;
            // 
            // colcodigo_barra
            // 
            this.colcodigo_barra.Caption = "Cod. Barra";
            this.colcodigo_barra.FieldName = "codigo_barra";
            this.colcodigo_barra.Name = "colcodigo_barra";
            this.colcodigo_barra.OptionsColumn.AllowEdit = false;
            this.colcodigo_barra.Visible = true;
            this.colcodigo_barra.VisibleIndex = 0;
            this.colcodigo_barra.Width = 122;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(274, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(296, 25);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Tarimas en Existencia Produccion";
            // 
            // reposSeleccionar
            // 
            this.reposSeleccionar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.reposSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposSeleccionar.Name = "reposSeleccionar";
            this.reposSeleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposSeleccionar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposSeleccionar_ButtonClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Seleccionar:";
            this.gridColumn1.ColumnEdit = this.reposSeleccionar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 98;
            // 
            // frmSeleccionTarimaMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 442);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.grdtarimas);
            this.Controls.Add(this.cmdHome);
            this.Name = "frmSeleccionTarimaMP";
            ((System.ComponentModel.ISupportInitialize)(this.grdtarimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvtarimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposSeleccionar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraGrid.GridControl grdtarimas;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvtarimas;
        private dsTransaccionesMP dsTransaccionesMP1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tarima_prd;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colmp;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_venc;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso_prd;
        private DevExpress.XtraGrid.Columns.GridColumn colkg_iniciales;
        private DevExpress.XtraGrid.Columns.GridColumn colkg_entregados;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia_kg;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposSeleccionar;
    }
}