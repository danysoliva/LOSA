namespace LOSA.MigracionACS.Produccion
{
    partial class PRB_Causes_New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRB_Causes_New));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lblIntruc = new DevExpress.XtraEditors.LabelControl();
            this.lblDescrip = new DevExpress.XtraEditors.LabelControl();
            this.grdcausas = new DevExpress.XtraEditors.GridLookUpEdit();
            this.causaMainBindingSource = new System.Windows.Forms.BindingSource();
            this.pRB_DATA = new LOSA.MigracionACS.DataSetx.PRB_DATA();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcausa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblhoras = new DevExpress.XtraEditors.LabelControl();
            this.lblcomentario = new DevExpress.XtraEditors.LabelControl();
            this.btnsave = new DevExpress.XtraEditors.ButtonEdit();
            this.btnclose = new DevExpress.XtraEditors.ButtonEdit();
            this.timehoras = new DevExpress.XtraEditors.TimeSpanEdit();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.gridLookMotivos = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceTipoParos = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcausa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdcausas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.causaMainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRB_DATA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timehoras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookMotivos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoParos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIntruc
            // 
            this.lblIntruc.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntruc.Appearance.Options.UseFont = true;
            this.lblIntruc.Location = new System.Drawing.Point(12, 22);
            this.lblIntruc.Name = "lblIntruc";
            this.lblIntruc.Size = new System.Drawing.Size(296, 14);
            this.lblIntruc.TabIndex = 0;
            this.lblIntruc.Text = "Agregar una nueva causa de retraso en la produccion:";
            // 
            // lblDescrip
            // 
            this.lblDescrip.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrip.Appearance.Options.UseFont = true;
            this.lblDescrip.Location = new System.Drawing.Point(12, 74);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(127, 14);
            this.lblDescrip.TabIndex = 1;
            this.lblDescrip.Text = "Tipo de Paro________";
            // 
            // grdcausas
            // 
            this.grdcausas.EditValue = "1";
            this.grdcausas.Enabled = false;
            this.grdcausas.Location = new System.Drawing.Point(129, 68);
            this.grdcausas.Name = "grdcausas";
            this.grdcausas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdcausas.Properties.Appearance.Options.UseFont = true;
            this.grdcausas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdcausas.Properties.DataSource = this.causaMainBindingSource;
            this.grdcausas.Properties.DisplayMember = "causa";
            this.grdcausas.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdcausas.Properties.ValueMember = "id";
            this.grdcausas.Size = new System.Drawing.Size(233, 20);
            this.grdcausas.TabIndex = 2;
            this.grdcausas.EditValueChanged += new System.EventHandler(this.grdcausas_EditValueChanged);
            // 
            // causaMainBindingSource
            // 
            this.causaMainBindingSource.DataMember = "CausaMain";
            this.causaMainBindingSource.DataSource = this.pRB_DATA;
            // 
            // pRB_DATA
            // 
            this.pRB_DATA.DataSetName = "PRB_DATA";
            this.pRB_DATA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcausa,
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colcausa
            // 
            this.colcausa.Caption = "Causa";
            this.colcausa.FieldName = "causa";
            this.colcausa.Name = "colcausa";
            this.colcausa.Visible = true;
            this.colcausa.VisibleIndex = 0;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            // 
            // lblhoras
            // 
            this.lblhoras.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhoras.Appearance.Options.UseFont = true;
            this.lblhoras.Location = new System.Drawing.Point(12, 104);
            this.lblhoras.Name = "lblhoras";
            this.lblhoras.Size = new System.Drawing.Size(137, 14);
            this.lblhoras.TabIndex = 3;
            this.lblhoras.Text = "Tiempo de Paro_______";
            // 
            // lblcomentario
            // 
            this.lblcomentario.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomentario.Appearance.Options.UseFont = true;
            this.lblcomentario.Location = new System.Drawing.Point(12, 175);
            this.lblcomentario.Name = "lblcomentario";
            this.lblcomentario.Size = new System.Drawing.Size(126, 14);
            this.lblcomentario.TabIndex = 5;
            this.lblcomentario.Text = "Comentario_________";
            this.lblcomentario.Click += new System.EventHandler(this.lblcomentario_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(90, 195);
            this.btnsave.Name = "btnsave";
            this.btnsave.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnsave.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnsave.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnsave.Size = new System.Drawing.Size(100, 30);
            this.btnsave.TabIndex = 8;
            this.btnsave.EditValueChanged += new System.EventHandler(this.btnsave_EditValueChanged);
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(196, 195);
            this.btnclose.Name = "btnclose";
            this.btnclose.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnclose.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnclose.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnclose.Size = new System.Drawing.Size(100, 30);
            this.btnclose.TabIndex = 9;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click_1);
            // 
            // timehoras
            // 
            this.timehoras.EditValue = System.TimeSpan.Parse("00:00:00");
            this.timehoras.Enabled = false;
            this.timehoras.Location = new System.Drawing.Point(129, 94);
            this.timehoras.Name = "timehoras";
            this.timehoras.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timehoras.Properties.Appearance.Options.UseFont = true;
            this.timehoras.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timehoras.Properties.Mask.EditMask = "HH:mm:ss";
            this.timehoras.Size = new System.Drawing.Size(233, 24);
            this.timehoras.TabIndex = 11;
            this.timehoras.EditValueChanged += new System.EventHandler(this.timehoras_EditValueChanged);
            // 
            // txtcomentario
            // 
            this.txtcomentario.Enabled = false;
            this.txtcomentario.Location = new System.Drawing.Point(129, 124);
            this.txtcomentario.Multiline = true;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(233, 65);
            this.txtcomentario.TabIndex = 12;
            // 
            // gridLookMotivos
            // 
            this.gridLookMotivos.EditValue = "";
            this.gridLookMotivos.Location = new System.Drawing.Point(129, 42);
            this.gridLookMotivos.Name = "gridLookMotivos";
            this.gridLookMotivos.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookMotivos.Properties.Appearance.Options.UseFont = true;
            this.gridLookMotivos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookMotivos.Properties.DataSource = this.bindingSourceTipoParos;
            this.gridLookMotivos.Properties.DisplayMember = "causa";
            this.gridLookMotivos.Properties.PopupView = this.gridView1;
            this.gridLookMotivos.Properties.ValueMember = "id";
            this.gridLookMotivos.Size = new System.Drawing.Size(233, 20);
            this.gridLookMotivos.TabIndex = 14;
            this.gridLookMotivos.EditValueChanged += new System.EventHandler(this.gridLookMotivos_EditValueChanged);
            // 
            // bindingSourceTipoParos
            // 
            this.bindingSourceTipoParos.DataMember = "tipos_causas";
            this.bindingSourceTipoParos.DataSource = this.pRB_DATA;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colcausa1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // colcausa1
            // 
            this.colcausa1.Caption = "Motivo de Paro";
            this.colcausa1.FieldName = "causa";
            this.colcausa1.Name = "colcausa1";
            this.colcausa1.Visible = true;
            this.colcausa1.VisibleIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(202, 14);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Motivo de Paro_________________";
            // 
            // PRB_Causes_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 231);
            this.Controls.Add(this.gridLookMotivos);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.timehoras);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblcomentario);
            this.Controls.Add(this.lblhoras);
            this.Controls.Add(this.grdcausas);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.lblIntruc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PRB_Causes_New";
            this.Text = "Agregar nueva causa";
            ((System.ComponentModel.ISupportInitialize)(this.grdcausas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.causaMainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRB_DATA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timehoras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookMotivos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoParos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblIntruc;
        private DevExpress.XtraEditors.LabelControl lblDescrip;
        private DevExpress.XtraEditors.GridLookUpEdit grdcausas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource causaMainBindingSource;
        private DataSetx.PRB_DATA pRB_DATA;
        private DevExpress.XtraEditors.LabelControl lblhoras;
        private DevExpress.XtraEditors.LabelControl lblcomentario;
        private DevExpress.XtraEditors.ButtonEdit btnsave;
        private DevExpress.XtraEditors.ButtonEdit btnclose;
        private DevExpress.XtraEditors.TimeSpanEdit timehoras;
        private System.Windows.Forms.TextBox txtcomentario;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookMotivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bindingSourceTipoParos;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcausa;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colcausa1;
    }
}