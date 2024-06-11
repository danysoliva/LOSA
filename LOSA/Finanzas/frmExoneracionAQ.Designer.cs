
namespace LOSA.Finanzas
{
    partial class frmExoneracionAQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExoneracionAQ));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdListaExoneracion = new DevExpress.XtraGrid.GridControl();
            this.dsExoneracion1 = new LOSA.Finanzas.dsExoneracion();
            this.grdvListaExoneracion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colanio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_create = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcerrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposCerrarPeriodo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repostGestionPresupuesto = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaExoneracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExoneracion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListaExoneracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposCerrarPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repostGestionPresupuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // grdListaExoneracion
            // 
            this.grdListaExoneracion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdListaExoneracion.DataMember = "lista_exoneracion";
            this.grdListaExoneracion.DataSource = this.dsExoneracion1;
            this.grdListaExoneracion.Location = new System.Drawing.Point(2, 91);
            this.grdListaExoneracion.MainView = this.grdvListaExoneracion;
            this.grdListaExoneracion.Name = "grdListaExoneracion";
            this.grdListaExoneracion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposCerrarPeriodo,
            this.repostGestionPresupuesto});
            this.grdListaExoneracion.Size = new System.Drawing.Size(1232, 640);
            this.grdListaExoneracion.TabIndex = 0;
            this.grdListaExoneracion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListaExoneracion});
            // 
            // dsExoneracion1
            // 
            this.dsExoneracion1.DataSetName = "dsExoneracion";
            this.dsExoneracion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdvListaExoneracion
            // 
            this.grdvListaExoneracion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colanio,
            this.colinicio,
            this.colfinal,
            this.coluser_create,
            this.coluser_name,
            this.colenable,
            this.colcerrado,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.grdvListaExoneracion.GridControl = this.grdListaExoneracion;
            this.grdvListaExoneracion.Name = "grdvListaExoneracion";
            this.grdvListaExoneracion.OptionsBehavior.ReadOnly = true;
            this.grdvListaExoneracion.OptionsView.ShowAutoFilterRow = true;
            this.grdvListaExoneracion.OptionsView.ShowFooter = true;
            this.grdvListaExoneracion.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colanio
            // 
            this.colanio.Caption = "Año";
            this.colanio.FieldName = "anio";
            this.colanio.Name = "colanio";
            this.colanio.Visible = true;
            this.colanio.VisibleIndex = 0;
            this.colanio.Width = 134;
            // 
            // colinicio
            // 
            this.colinicio.Caption = "F. Inicial";
            this.colinicio.FieldName = "inicio";
            this.colinicio.Name = "colinicio";
            this.colinicio.Visible = true;
            this.colinicio.VisibleIndex = 2;
            this.colinicio.Width = 134;
            // 
            // colfinal
            // 
            this.colfinal.Caption = "F. Final";
            this.colfinal.FieldName = "final";
            this.colfinal.Name = "colfinal";
            this.colfinal.Visible = true;
            this.colfinal.VisibleIndex = 3;
            this.colfinal.Width = 134;
            // 
            // coluser_create
            // 
            this.coluser_create.FieldName = "user_create";
            this.coluser_create.Name = "coluser_create";
            // 
            // coluser_name
            // 
            this.coluser_name.Caption = "Usuario Creador";
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 4;
            this.coluser_name.Width = 134;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            // 
            // colcerrado
            // 
            this.colcerrado.Caption = "Periodo Cerrado";
            this.colcerrado.FieldName = "cerrado";
            this.colcerrado.Name = "colcerrado";
            this.colcerrado.Visible = true;
            this.colcerrado.VisibleIndex = 6;
            this.colcerrado.Width = 126;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cerrar Periodo";
            this.gridColumn1.ColumnEdit = this.reposCerrarPeriodo;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 126;
            // 
            // reposCerrarPeriodo
            // 
            this.reposCerrarPeriodo.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.reposCerrarPeriodo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposCerrarPeriodo.Name = "reposCerrarPeriodo";
            this.reposCerrarPeriodo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposCerrarPeriodo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposCerrarPeriodo_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Detalle de Presupuesto";
            this.gridColumn2.ColumnEdit = this.repostGestionPresupuesto;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            this.gridColumn2.Width = 130;
            // 
            // repostGestionPresupuesto
            // 
            this.repostGestionPresupuesto.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repostGestionPresupuesto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repostGestionPresupuesto.Name = "repostGestionPresupuesto";
            this.repostGestionPresupuesto.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repostGestionPresupuesto.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repostGestionPresupuesto_ButtonClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Resolucion Exonerada";
            this.gridColumn3.FieldName = "resolucion_exonerada";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 134;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Presupuesto Total Exonerado";
            this.gridColumn4.DisplayFormat.FormatString = "{0:##,###,##0.##} Lps.";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "presupuesto_total";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "presupuesto_total", "Total={0:##,###,##0.##} Lps.")});
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 155;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Appearance.Options.UseBackColor = true;
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ImageOptions.Image = global::LOSA.Properties.Resources.plus;
            this.btnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAgregar.Location = new System.Drawing.Point(13, 39);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 45);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar Periodo";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(1094, 42);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(130, 40);
            this.btnAtras.TabIndex = 30;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(481, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(227, 18);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Presupuesto para Exoneracion";
            // 
            // frmExoneracionAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 735);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grdListaExoneracion);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmExoneracionAQ";
            ((System.ComponentModel.ISupportInitialize)(this.grdListaExoneracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExoneracion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListaExoneracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposCerrarPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repostGestionPresupuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdListaExoneracion;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListaExoneracion;
        private dsExoneracion dsExoneracion1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colanio;
        private DevExpress.XtraGrid.Columns.GridColumn colinicio;
        private DevExpress.XtraGrid.Columns.GridColumn colfinal;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_create;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colcerrado;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposCerrarPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repostGestionPresupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}