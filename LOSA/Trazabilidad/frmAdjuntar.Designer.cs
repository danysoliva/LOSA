
namespace LOSA.Trazabilidad
{
    partial class frmAdjuntar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdjuntar));
            this.lblArchivoName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.glePlanta = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsPlantas = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceTipoArchivo = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantoTrazabilidad1 = new LOSA.Trazabilidad.dsMantoTrazabilidad();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glePlanta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlantas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoArchivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantoTrazabilidad1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArchivoName
            // 
            this.lblArchivoName.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivoName.Appearance.Options.UseFont = true;
            this.lblArchivoName.Appearance.Options.UseTextOptions = true;
            this.lblArchivoName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblArchivoName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblArchivoName.Location = new System.Drawing.Point(12, 111);
            this.lblArchivoName.Name = "lblArchivoName";
            this.lblArchivoName.Size = new System.Drawing.Size(527, 21);
            this.lblArchivoName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(527, 36);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Adjuntar Archivo";
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdBrowse.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cmdBrowse.Appearance.Options.UseBackColor = true;
            this.cmdBrowse.Appearance.Options.UseFont = true;
            this.cmdBrowse.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdBrowse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdBrowse.ImageOptions.Image")));
            this.cmdBrowse.Location = new System.Drawing.Point(202, 54);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(142, 51);
            this.cmdBrowse.TabIndex = 11;
            this.cmdBrowse.Text = "Browse...";
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.Location = new System.Drawing.Point(202, 289);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(142, 51);
            this.cmdGuardar.TabIndex = 12;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(91, 138);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.bindingSourceTipoArchivo;
            this.gridLookUpEdit1.Properties.DisplayMember = "descripcion";
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Properties.ValueMember = "id";
            this.gridLookUpEdit1.Size = new System.Drawing.Size(167, 24);
            this.gridLookUpEdit1.TabIndex = 13;
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
            this.coldescripcion.Caption = "Tipo de Archivo";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 141);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 17);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Tipo:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 202);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 17);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(91, 202);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(448, 84);
            this.txtDescripcion.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 171);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 17);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Planta:";
            // 
            // glePlanta
            // 
            this.glePlanta.Location = new System.Drawing.Point(91, 168);
            this.glePlanta.Name = "glePlanta";
            this.glePlanta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glePlanta.Properties.Appearance.Options.UseFont = true;
            this.glePlanta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glePlanta.Properties.DataSource = this.bsPlantas;
            this.glePlanta.Properties.DisplayMember = "descripcion";
            this.glePlanta.Properties.PopupView = this.gridView1;
            this.glePlanta.Properties.ValueMember = "id";
            this.glePlanta.Size = new System.Drawing.Size(167, 24);
            this.glePlanta.TabIndex = 18;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tipo de Archivo";
            this.gridColumn2.FieldName = "descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // bsPlantas
            // 
            this.bsPlantas.DataMember = "plantas_list";
            this.bsPlantas.DataSource = this.dsMantoTrazabilidad1;
            // 
            // bindingSourceTipoArchivo
            // 
            this.bindingSourceTipoArchivo.DataMember = "tipos_archivos_prv";
            this.bindingSourceTipoArchivo.DataSource = this.dsMantoTrazabilidad1;
            // 
            // dsMantoTrazabilidad1
            // 
            this.dsMantoTrazabilidad1.DataSetName = "dsMantoTrazabilidad";
            this.dsMantoTrazabilidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmAdjuntar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 343);
            this.Controls.Add(this.glePlanta);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gridLookUpEdit1);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblArchivoName);
            this.Name = "frmAdjuntar";
            this.Text = "Adjuntar Archivo";
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glePlanta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlantas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoArchivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantoTrazabilidad1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblArchivoName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private dsMantoTrazabilidad dsMantoTrazabilidad1;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource bindingSourceTipoArchivo;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GridLookUpEdit glePlanta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.BindingSource bsPlantas;
    }
}