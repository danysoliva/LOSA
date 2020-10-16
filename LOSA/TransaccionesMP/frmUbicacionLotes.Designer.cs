namespace LOSA.TransaccionesMP
{
    partial class frmUbicacionLotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUbicacionLotes));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.beIdTarima = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.grd_ubicaciones = new DevExpress.XtraGrid.GridControl();
            this.dsTransaccionesMP = new LOSA.TransaccionesMP.dsTransaccionesMP();
            this.grdv_ubicaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUbiCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrack = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.beIdTarima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ubicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_ubicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // beIdTarima
            // 
            this.beIdTarima.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.beIdTarima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beIdTarima.EditValue = "";
            this.beIdTarima.Location = new System.Drawing.Point(165, 28);
            this.beIdTarima.Margin = new System.Windows.Forms.Padding(4);
            this.beIdTarima.Name = "beIdTarima";
            this.beIdTarima.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beIdTarima.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.beIdTarima.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.beIdTarima.Properties.MaxLength = 20;
            this.beIdTarima.Properties.NullText = "Escanee o selecciona una tarima";
            this.beIdTarima.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beIdTarima_Properties_ButtonClick);
            this.beIdTarima.Size = new System.Drawing.Size(411, 52);
            this.beIdTarima.TabIndex = 37;
            this.beIdTarima.ToolTip = "Hola";
            this.beIdTarima.KeyDown += new System.Windows.Forms.KeyEventHandler(this.beIdTarima_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 34);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(134, 46);
            this.labelControl1.TabIndex = 38;
            this.labelControl1.Text = "Tarima:";
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
            this.cmdHome.Location = new System.Drawing.Point(605, 13);
            this.cmdHome.Margin = new System.Windows.Forms.Padding(4);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(233, 87);
            this.cmdHome.TabIndex = 39;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // grd_ubicaciones
            // 
            this.grd_ubicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_ubicaciones.DataMember = "UbicacionesLote";
            this.grd_ubicaciones.DataSource = this.dsTransaccionesMP;
            this.grd_ubicaciones.Location = new System.Drawing.Point(-1, 115);
            this.grd_ubicaciones.MainView = this.grdv_ubicaciones;
            this.grd_ubicaciones.Name = "grd_ubicaciones";
            this.grd_ubicaciones.Size = new System.Drawing.Size(851, 574);
            this.grd_ubicaciones.TabIndex = 40;
            this.grd_ubicaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_ubicaciones});
            // 
            // dsTransaccionesMP
            // 
            this.dsTransaccionesMP.DataSetName = "dsTransaccionesMP";
            this.dsTransaccionesMP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_ubicaciones
            // 
            this.grdv_ubicaciones.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grdv_ubicaciones.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grdv_ubicaciones.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grdv_ubicaciones.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_ubicaciones.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdv_ubicaciones.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.grdv_ubicaciones.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_ubicaciones.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_ubicaciones.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_ubicaciones.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_ubicaciones.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_ubicaciones.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_ubicaciones.Appearance.Preview.Options.UseFont = true;
            this.grdv_ubicaciones.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_ubicaciones.Appearance.Row.Options.UseFont = true;
            this.grdv_ubicaciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigo_barra,
            this.colMP,
            this.collote_materia_prima,
            this.colUbiCode,
            this.colrack,
            this.colnumero_transaccion,
            this.colid});
            this.grdv_ubicaciones.GridControl = this.grd_ubicaciones;
            this.grdv_ubicaciones.Name = "grdv_ubicaciones";
            this.grdv_ubicaciones.OptionsView.ShowGroupPanel = false;
            // 
            // colcodigo_barra
            // 
            this.colcodigo_barra.Caption = "Codigo Tarima";
            this.colcodigo_barra.FieldName = "codigo_barra";
            this.colcodigo_barra.MinWidth = 25;
            this.colcodigo_barra.Name = "colcodigo_barra";
            this.colcodigo_barra.OptionsColumn.AllowEdit = false;
            this.colcodigo_barra.Visible = true;
            this.colcodigo_barra.VisibleIndex = 0;
            this.colcodigo_barra.Width = 94;
            // 
            // colMP
            // 
            this.colMP.Caption = "MP";
            this.colMP.FieldName = "MP";
            this.colMP.MinWidth = 25;
            this.colMP.Name = "colMP";
            this.colMP.OptionsColumn.AllowEdit = false;
            this.colMP.Visible = true;
            this.colMP.VisibleIndex = 4;
            this.colMP.Width = 94;
            // 
            // collote_materia_prima
            // 
            this.collote_materia_prima.Caption = "Lote";
            this.collote_materia_prima.FieldName = "lote_materia_prima";
            this.collote_materia_prima.MinWidth = 25;
            this.collote_materia_prima.Name = "collote_materia_prima";
            this.collote_materia_prima.OptionsColumn.AllowEdit = false;
            this.collote_materia_prima.Visible = true;
            this.collote_materia_prima.VisibleIndex = 5;
            this.collote_materia_prima.Width = 94;
            // 
            // colUbiCode
            // 
            this.colUbiCode.Caption = "Codigo Ubicacion";
            this.colUbiCode.FieldName = "UbiCode";
            this.colUbiCode.MinWidth = 25;
            this.colUbiCode.Name = "colUbiCode";
            this.colUbiCode.OptionsColumn.AllowEdit = false;
            this.colUbiCode.Visible = true;
            this.colUbiCode.VisibleIndex = 1;
            this.colUbiCode.Width = 94;
            // 
            // colrack
            // 
            this.colrack.Caption = "Rack";
            this.colrack.FieldName = "rack";
            this.colrack.MinWidth = 25;
            this.colrack.Name = "colrack";
            this.colrack.OptionsColumn.AllowEdit = false;
            this.colrack.Visible = true;
            this.colrack.VisibleIndex = 2;
            this.colrack.Width = 94;
            // 
            // colnumero_transaccion
            // 
            this.colnumero_transaccion.AppearanceCell.Options.UseTextOptions = true;
            this.colnumero_transaccion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnumero_transaccion.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colnumero_transaccion.AppearanceHeader.Options.UseTextOptions = true;
            this.colnumero_transaccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnumero_transaccion.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colnumero_transaccion.Caption = "Ingreso";
            this.colnumero_transaccion.FieldName = "numero_transaccion";
            this.colnumero_transaccion.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.colnumero_transaccion.MinWidth = 25;
            this.colnumero_transaccion.Name = "colnumero_transaccion";
            this.colnumero_transaccion.OptionsColumn.AllowEdit = false;
            this.colnumero_transaccion.Visible = true;
            this.colnumero_transaccion.VisibleIndex = 3;
            this.colnumero_transaccion.Width = 94;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 25;
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Width = 94;
            // 
            // frmUbicacionLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 689);
            this.Controls.Add(this.grd_ubicaciones);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.beIdTarima);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUbicacionLotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUbicacionLotes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.beIdTarima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ubicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_ubicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit beIdTarima;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraGrid.GridControl grd_ubicaciones;
        private dsTransaccionesMP dsTransaccionesMP;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_ubicaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra;
        private DevExpress.XtraGrid.Columns.GridColumn colMP;
        private DevExpress.XtraGrid.Columns.GridColumn collote_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colUbiCode;
        private DevExpress.XtraGrid.Columns.GridColumn colrack;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
    }
}