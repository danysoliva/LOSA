
namespace LOSA.Calidad.CertificadoCalidad
{
    partial class frmCertificadoCalidadPTMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCertificadoCalidadPTMain));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsCertificado = new LOSA.Calidad.CertificadoCalidad.dsCertificado();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto_terminado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_analisis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFFIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_produccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_creador_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_creador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImprimir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCertificado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "Certificado_PT_H";
            this.gridControl1.DataSource = this.dsCertificado;
            this.gridControl1.Location = new System.Drawing.Point(-1, 75);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnImprimir,
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(876, 344);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsCertificado
            // 
            this.dsCertificado.DataSetName = "dsCertificado";
            this.dsCertificado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_pt,
            this.colproducto_terminado,
            this.colitemcode,
            this.collote_pt,
            this.colfecha_analisis,
            this.colalimento,
            this.colFFIF,
            this.colfecha_produccion,
            this.colfecha_vencimiento,
            this.colusuario_creador_id,
            this.colusuario_creador,
            this.gridColumn1,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_pt
            // 
            this.colid_pt.FieldName = "id_pt";
            this.colid_pt.Name = "colid_pt";
            // 
            // colproducto_terminado
            // 
            this.colproducto_terminado.Caption = "Producto Terminado";
            this.colproducto_terminado.FieldName = "producto_terminado";
            this.colproducto_terminado.Name = "colproducto_terminado";
            this.colproducto_terminado.OptionsColumn.ReadOnly = true;
            this.colproducto_terminado.OptionsFilter.AllowFilter = false;
            this.colproducto_terminado.Visible = true;
            this.colproducto_terminado.VisibleIndex = 0;
            this.colproducto_terminado.Width = 144;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Código";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.ReadOnly = true;
            this.colitemcode.OptionsFilter.AllowFilter = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 1;
            this.colitemcode.Width = 78;
            // 
            // collote_pt
            // 
            this.collote_pt.Caption = "Lote";
            this.collote_pt.FieldName = "lote_pt";
            this.collote_pt.Name = "collote_pt";
            this.collote_pt.OptionsColumn.ReadOnly = true;
            this.collote_pt.OptionsFilter.AllowFilter = false;
            this.collote_pt.Visible = true;
            this.collote_pt.VisibleIndex = 2;
            this.collote_pt.Width = 78;
            // 
            // colfecha_analisis
            // 
            this.colfecha_analisis.Caption = "Fecha Análisis";
            this.colfecha_analisis.FieldName = "fecha_analisis";
            this.colfecha_analisis.Name = "colfecha_analisis";
            this.colfecha_analisis.OptionsColumn.ReadOnly = true;
            this.colfecha_analisis.OptionsFilter.AllowFilter = false;
            this.colfecha_analisis.Visible = true;
            this.colfecha_analisis.VisibleIndex = 3;
            this.colfecha_analisis.Width = 78;
            // 
            // colalimento
            // 
            this.colalimento.Caption = "Alimento";
            this.colalimento.FieldName = "alimento";
            this.colalimento.Name = "colalimento";
            this.colalimento.OptionsColumn.ReadOnly = true;
            this.colalimento.OptionsFilter.AllowFilter = false;
            this.colalimento.Visible = true;
            this.colalimento.VisibleIndex = 4;
            this.colalimento.Width = 78;
            // 
            // colFFIF
            // 
            this.colFFIF.FieldName = "FFIF";
            this.colFFIF.Name = "colFFIF";
            this.colFFIF.OptionsColumn.ReadOnly = true;
            this.colFFIF.OptionsFilter.AllowFilter = false;
            this.colFFIF.Visible = true;
            this.colFFIF.VisibleIndex = 5;
            this.colFFIF.Width = 78;
            // 
            // colfecha_produccion
            // 
            this.colfecha_produccion.Caption = "Fecha Producción";
            this.colfecha_produccion.FieldName = "fecha_produccion";
            this.colfecha_produccion.Name = "colfecha_produccion";
            this.colfecha_produccion.OptionsColumn.ReadOnly = true;
            this.colfecha_produccion.OptionsFilter.AllowFilter = false;
            this.colfecha_produccion.Visible = true;
            this.colfecha_produccion.VisibleIndex = 6;
            this.colfecha_produccion.Width = 78;
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.Caption = "Fecha Vencimiento";
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.OptionsColumn.ReadOnly = true;
            this.colfecha_vencimiento.OptionsFilter.AllowFilter = false;
            this.colfecha_vencimiento.Visible = true;
            this.colfecha_vencimiento.VisibleIndex = 7;
            this.colfecha_vencimiento.Width = 78;
            // 
            // colusuario_creador_id
            // 
            this.colusuario_creador_id.FieldName = "usuario_creador_id";
            this.colusuario_creador_id.Name = "colusuario_creador_id";
            this.colusuario_creador_id.Width = 78;
            // 
            // colusuario_creador
            // 
            this.colusuario_creador.FieldName = "usuario_creador";
            this.colusuario_creador.Name = "colusuario_creador";
            this.colusuario_creador.Width = 83;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Imprimir";
            this.gridColumn1.ColumnEdit = this.btnImprimir;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnImprimir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnImprimir.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnImprimir_ButtonClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Deshabilitar";
            this.gridColumn3.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 9;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions2.Image = global::LOSA.Properties.Resources.prohibicion_16x161;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonPressed);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.simpleButton1.ImageOptions.Image = global::LOSA.Properties.Resources.certificado_24X24;
            this.simpleButton1.Location = new System.Drawing.Point(32, 22);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(108, 38);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Crear Certificado";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = global::LOSA.Properties.Resources.home_automation_24X24;
            this.simpleButton2.Location = new System.Drawing.Point(733, 22);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(108, 38);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Home";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Deshabilitar";
            this.gridColumn2.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn2.ImageOptions.Image = global::LOSA.Properties.Resources.prohibicion_16x16;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 9;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(160, 22);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(108, 38);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Actualizar";
            // 
            // frmCertificadoCalidadPTMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 419);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmCertificadoCalidadPTMain";
            this.Text = "Creacion de Certificados de PT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCertificado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsCertificado dsCertificado;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto_terminado;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn collote_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_analisis;
        private DevExpress.XtraGrid.Columns.GridColumn colalimento;
        private DevExpress.XtraGrid.Columns.GridColumn colFFIF;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_produccion;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_creador_id;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_creador;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnImprimir;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}