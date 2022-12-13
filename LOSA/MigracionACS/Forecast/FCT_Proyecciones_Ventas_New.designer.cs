using LOSA.MigracionACS.Forecast;

namespace ACS.Forecast
{
    partial class FCT_Proyecciones_Ventas_New
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.txt_Descripcion = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridLookUpTipoProyeccion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsForecast_1 = new LOSA.MigracionACS.Forecast.dsForecast_();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.spinEditAnio = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Descripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpTipoProyeccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForecast_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAnio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(79, 32);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txt_Descripcion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.Properties.Appearance.Options.UseBackColor = true;
            this.txt_Descripcion.Properties.Appearance.Options.UseFont = true;
            this.txt_Descripcion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txt_Descripcion.Properties.MaxLength = 80;
            this.txt_Descripcion.Size = new System.Drawing.Size(288, 24);
            this.txt_Descripcion.TabIndex = 1;
            this.txt_Descripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Descripcion_KeyDown);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.gridLookUpTipoProyeccion);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.comboBox1);
            this.groupControl1.Controls.Add(this.txt_Descripcion);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.spinEditAnio);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.cmdCancelar);
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(372, 215);
            this.groupControl1.TabIndex = 2;
            // 
            // gridLookUpTipoProyeccion
            // 
            this.gridLookUpTipoProyeccion.EditValue = "sdf";
            this.gridLookUpTipoProyeccion.Location = new System.Drawing.Point(79, 141);
            this.gridLookUpTipoProyeccion.Name = "gridLookUpTipoProyeccion";
            this.gridLookUpTipoProyeccion.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gridLookUpTipoProyeccion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.gridLookUpTipoProyeccion.Properties.Appearance.Options.UseBackColor = true;
            this.gridLookUpTipoProyeccion.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpTipoProyeccion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.gridLookUpTipoProyeccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, true, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.gridLookUpTipoProyeccion.Properties.DataSource = this.bindingSource1;
            this.gridLookUpTipoProyeccion.Properties.DisplayMember = "descripcion";
            this.gridLookUpTipoProyeccion.Properties.NullText = "[Indique el tipo de Proyección]";
            this.gridLookUpTipoProyeccion.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpTipoProyeccion.Properties.ValueMember = "id";
            this.gridLookUpTipoProyeccion.Size = new System.Drawing.Size(288, 24);
            this.gridLookUpTipoProyeccion.TabIndex = 10;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tipos_proyeccion";
            this.bindingSource1.DataSource = this.dsForecast_1;
            // 
            // dsForecast_1
            // 
            this.dsForecast_1.DataSetName = "dsForecast_";
            this.dsForecast_1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Elija el tipo";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(6, 147);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 16);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Tipo_______";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 - Regal",
            "2 - PROMIX"});
            this.comboBox1.Location = new System.Drawing.Point(79, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(6, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(94, 16);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Descripción____";
            // 
            // spinEditAnio
            // 
            this.spinEditAnio.EditValue = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.spinEditAnio.Location = new System.Drawing.Point(79, 104);
            this.spinEditAnio.Name = "spinEditAnio";
            this.spinEditAnio.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.spinEditAnio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.spinEditAnio.Properties.Appearance.Options.UseBackColor = true;
            this.spinEditAnio.Properties.Appearance.Options.UseFont = true;
            this.spinEditAnio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.spinEditAnio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditAnio.Properties.IsFloatValue = false;
            this.spinEditAnio.Properties.Mask.EditMask = "N00";
            this.spinEditAnio.Properties.MaxValue = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.spinEditAnio.Properties.MinValue = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.spinEditAnio.Size = new System.Drawing.Size(288, 24);
            this.spinEditAnio.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 113);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Para el año_____";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Image = global::LOSA.Properties.Resources.cancel2_24;
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(192, 171);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(87, 41);
            this.cmdCancelar.TabIndex = 5;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // button1
            // 
            this.button1.Image = global::LOSA.Properties.Resources.saveChanges_24x24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(99, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 75);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Cliente_______";
            // 
            // FCT_Proyecciones_Ventas_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 215);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FCT_Proyecciones_Ventas_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Proyección de Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.txt_Descripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpTipoProyeccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForecast_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAnio.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_Descripcion;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit spinEditAnio;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpTipoProyeccion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private dsForecast_ dsForecast_1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
    }
}