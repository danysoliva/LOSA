
namespace LOSA.TransaccionesMP.Liquidos
{
    partial class frmBinesEnPRD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBinesEnPRD));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsTransaccionesMP = new LOSA.TransaccionesMP.dsTransaccionesMP();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPendienteAsignacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tarima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado_tarima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconsumir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnConsumir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colfecha_entrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.AutoConsumirBoton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsumir)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "bines_disponibles";
            this.gridControl1.DataSource = this.dsTransaccionesMP;
            this.gridControl1.Location = new System.Drawing.Point(2, 144);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnConsumir});
            this.gridControl1.Size = new System.Drawing.Size(671, 343);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsTransaccionesMP
            // 
            this.dsTransaccionesMP.DataSetName = "dsTransaccionesMP";
            this.dsTransaccionesMP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPendienteAsignacion,
            this.colnombre_comercial,
            this.colcodigo_barra,
            this.colid_tarima,
            this.colid_estado_tarima,
            this.collote_materia_prima,
            this.colconsumir,
            this.colfecha_entrega});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colPendienteAsignacion
            // 
            this.colPendienteAsignacion.FieldName = "PendienteAsignacion";
            this.colPendienteAsignacion.Name = "colPendienteAsignacion";
            this.colPendienteAsignacion.OptionsColumn.AllowEdit = false;
            this.colPendienteAsignacion.Visible = true;
            this.colPendienteAsignacion.VisibleIndex = 4;
            this.colPendienteAsignacion.Width = 106;
            // 
            // colnombre_comercial
            // 
            this.colnombre_comercial.Caption = "Materia Prima";
            this.colnombre_comercial.FieldName = "nombre_comercial";
            this.colnombre_comercial.Name = "colnombre_comercial";
            this.colnombre_comercial.OptionsColumn.AllowEdit = false;
            this.colnombre_comercial.Visible = true;
            this.colnombre_comercial.VisibleIndex = 1;
            this.colnombre_comercial.Width = 114;
            // 
            // colcodigo_barra
            // 
            this.colcodigo_barra.Caption = "Código Barra";
            this.colcodigo_barra.FieldName = "codigo_barra";
            this.colcodigo_barra.Name = "colcodigo_barra";
            this.colcodigo_barra.OptionsColumn.AllowEdit = false;
            this.colcodigo_barra.Visible = true;
            this.colcodigo_barra.VisibleIndex = 0;
            this.colcodigo_barra.Width = 120;
            // 
            // colid_tarima
            // 
            this.colid_tarima.FieldName = "id_tarima";
            this.colid_tarima.Name = "colid_tarima";
            // 
            // colid_estado_tarima
            // 
            this.colid_estado_tarima.FieldName = "id_estado_tarima";
            this.colid_estado_tarima.Name = "colid_estado_tarima";
            // 
            // collote_materia_prima
            // 
            this.collote_materia_prima.Caption = "Lote";
            this.collote_materia_prima.FieldName = "lote_materia_prima";
            this.collote_materia_prima.Name = "collote_materia_prima";
            this.collote_materia_prima.OptionsColumn.AllowEdit = false;
            this.collote_materia_prima.Visible = true;
            this.collote_materia_prima.VisibleIndex = 3;
            this.collote_materia_prima.Width = 107;
            // 
            // colconsumir
            // 
            this.colconsumir.Caption = "Consumir";
            this.colconsumir.ColumnEdit = this.btnConsumir;
            this.colconsumir.Name = "colconsumir";
            this.colconsumir.Visible = true;
            this.colconsumir.VisibleIndex = 5;
            this.colconsumir.Width = 123;
            // 
            // btnConsumir
            // 
            this.btnConsumir.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnConsumir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnConsumir.Name = "btnConsumir";
            this.btnConsumir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnConsumir.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnConsumir_ButtonClick);
            // 
            // colfecha_entrega
            // 
            this.colfecha_entrega.Caption = "Fecha Entrega";
            this.colfecha_entrega.FieldName = "fecha_entrega";
            this.colfecha_entrega.Name = "colfecha_entrega";
            this.colfecha_entrega.OptionsColumn.AllowEdit = false;
            this.colfecha_entrega.Visible = true;
            this.colfecha_entrega.VisibleIndex = 2;
            this.colfecha_entrega.Width = 83;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(2, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(313, 29);
            this.labelControl3.TabIndex = 103;
            this.labelControl3.Text = "Detalle de MP en Producción";
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
            this.cmdHome.Location = new System.Drawing.Point(498, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(175, 48);
            this.cmdHome.TabIndex = 104;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // AutoConsumirBoton
            // 
            this.AutoConsumirBoton.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoConsumirBoton.Appearance.Options.UseFont = true;
            this.AutoConsumirBoton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AutoConsumirBoton.ImageOptions.Image")));
            this.AutoConsumirBoton.Location = new System.Drawing.Point(12, 86);
            this.AutoConsumirBoton.Name = "AutoConsumirBoton";
            this.AutoConsumirBoton.Size = new System.Drawing.Size(191, 52);
            this.AutoConsumirBoton.TabIndex = 105;
            this.AutoConsumirBoton.Text = "Consumir Pendientes";
            this.AutoConsumirBoton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmBinesEnPRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 489);
            this.Controls.Add(this.AutoConsumirBoton);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmBinesEnPRD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bines En PRD";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsumir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraGrid.Columns.GridColumn colPendienteAsignacion;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tarima;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado_tarima;
        private dsTransaccionesMP dsTransaccionesMP;
        private DevExpress.XtraGrid.Columns.GridColumn collote_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colconsumir;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnConsumir;
        private DevExpress.XtraEditors.SimpleButton AutoConsumirBoton;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_entrega;
    }
}