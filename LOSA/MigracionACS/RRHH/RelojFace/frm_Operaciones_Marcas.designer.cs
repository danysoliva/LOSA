
namespace LOSA.MigracionACS.RRHH.RelojFace
{
    partial class frm_Operaciones_Marcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Operaciones_Marcas));
            this.btn_exit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grd_empleados = new DevExpress.XtraEditors.GridLookUpEdit();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFaceReloj = new LOSA.MigracionACS.RRHH.RelojFace.dsFaceReloj();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_desde = new DevExpress.XtraEditors.DateEdit();
            this.dt_hasta = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttrabajadas = new DevExpress.XtraEditors.SpinEdit();
            this.txtextras = new DevExpress.XtraEditors.SpinEdit();
            this.tgg_activo = new DevExpress.XtraEditors.ToggleSwitch();
            this.txtestado = new System.Windows.Forms.Label();
            this.colaqf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grd_empleados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFaceReloj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttrabajadas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtextras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgg_activo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Appearance.Options.UseFont = true;
            this.btn_exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.ImageOptions.Image")));
            this.btn_exit.Location = new System.Drawing.Point(577, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(114, 64);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Cerrar";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(217, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(209, 30);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Huellas de empleados";
            // 
            // grd_empleados
            // 
            this.grd_empleados.Location = new System.Drawing.Point(206, 81);
            this.grd_empleados.Name = "grd_empleados";
            this.grd_empleados.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_empleados.Properties.Appearance.Options.UseFont = true;
            this.grd_empleados.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_empleados.Properties.DataSource = this.empleadosBindingSource;
            this.grd_empleados.Properties.DisplayMember = "nombre";
            this.grd_empleados.Properties.PopupView = this.gridLookUpEdit1View;
            this.grd_empleados.Properties.ValueMember = "aqf";
            this.grd_empleados.Size = new System.Drawing.Size(330, 32);
            this.grd_empleados.TabIndex = 2;
            this.grd_empleados.EditValueChanged += new System.EventHandler(this.grd_empleados_EditValueChanged);
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.dsFaceReloj;
            // 
            // dsFaceReloj
            // 
            this.dsFaceReloj.DataSetName = "dsFaceReloj";
            this.dsFaceReloj.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gridLookUpEdit1View.Appearance.FilterPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gridLookUpEdit1View.Appearance.FocusedRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gridLookUpEdit1View.Appearance.GroupPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gridLookUpEdit1View.Appearance.GroupRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gridLookUpEdit1View.Appearance.Preview.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.TopNewRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colaqf,
            this.colnombre});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.Location = new System.Drawing.Point(100, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Empleado:";
            // 
            // dt_desde
            // 
            this.dt_desde.EditValue = null;
            this.dt_desde.Location = new System.Drawing.Point(206, 133);
            this.dt_desde.Name = "dt_desde";
            this.dt_desde.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.dt_desde.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dt_desde.Properties.Appearance.Options.UseFont = true;
            this.dt_desde.Properties.Appearance.Options.UseForeColor = true;
            this.dt_desde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_desde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dt_desde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_desde.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_desde.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_desde.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_desde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_desde.Properties.Mask.EditMask = "dd MMM yyyy hh:mm tt";
            this.dt_desde.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_desde.Size = new System.Drawing.Size(330, 32);
            this.dt_desde.TabIndex = 4;
            // 
            // dt_hasta
            // 
            this.dt_hasta.EditValue = null;
            this.dt_hasta.Location = new System.Drawing.Point(206, 186);
            this.dt_hasta.Name = "dt_hasta";
            this.dt_hasta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.dt_hasta.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dt_hasta.Properties.Appearance.Options.UseFont = true;
            this.dt_hasta.Properties.Appearance.Options.UseForeColor = true;
            this.dt_hasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_hasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dt_hasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_hasta.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_hasta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_hasta.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_hasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_hasta.Properties.Mask.EditMask = "dd MMM yyyy hh:mm tt";
            this.dt_hasta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_hasta.Size = new System.Drawing.Size(330, 32);
            this.dt_hasta.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label2.Location = new System.Drawing.Point(73, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha entrada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label3.Location = new System.Drawing.Point(89, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha salida:";
            // 
            // btn_save
            // 
            this.btn_save.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.ImageOptions.Image = global::LOSA.Properties.Resources.accept2_48;
            this.btn_save.Location = new System.Drawing.Point(172, 414);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(290, 58);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Guardar";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label4.Location = new System.Drawing.Point(42, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Horas trabajadas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label5.Location = new System.Drawing.Point(80, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Horas Extras:";
            // 
            // txttrabajadas
            // 
            this.txttrabajadas.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txttrabajadas.Location = new System.Drawing.Point(206, 242);
            this.txttrabajadas.Name = "txttrabajadas";
            this.txttrabajadas.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txttrabajadas.Properties.Appearance.Options.UseFont = true;
            this.txttrabajadas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txttrabajadas.Size = new System.Drawing.Size(111, 32);
            this.txttrabajadas.TabIndex = 11;
            // 
            // txtextras
            // 
            this.txtextras.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtextras.Location = new System.Drawing.Point(206, 304);
            this.txtextras.Name = "txtextras";
            this.txtextras.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtextras.Properties.Appearance.Options.UseFont = true;
            this.txtextras.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtextras.Size = new System.Drawing.Size(111, 32);
            this.txtextras.TabIndex = 12;
            // 
            // tgg_activo
            // 
            this.tgg_activo.EditValue = true;
            this.tgg_activo.Location = new System.Drawing.Point(206, 360);
            this.tgg_activo.Name = "tgg_activo";
            this.tgg_activo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tgg_activo.Properties.Appearance.Options.UseFont = true;
            this.tgg_activo.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.tgg_activo.Properties.OffText = "Desactivado";
            this.tgg_activo.Properties.OnText = "Activo";
            this.tgg_activo.Size = new System.Drawing.Size(330, 36);
            this.tgg_activo.TabIndex = 13;
            // 
            // txtestado
            // 
            this.txtestado.AutoSize = true;
            this.txtestado.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtestado.Location = new System.Drawing.Point(80, 365);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(72, 25);
            this.txtestado.TabIndex = 14;
            this.txtestado.Text = "Estado:";
            // 
            // colaqf
            // 
            this.colaqf.FieldName = "aqf";
            this.colaqf.Name = "colaqf";
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            // 
            // frm_Operaciones_Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 513);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.tgg_activo);
            this.Controls.Add(this.txtextras);
            this.Controls.Add(this.txttrabajadas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_hasta);
            this.Controls.Add(this.dt_desde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grd_empleados);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_exit);
            this.Name = "frm_Operaciones_Marcas";
            this.Text = "frm_Operaciones_Marcas";
            ((System.ComponentModel.ISupportInitialize)(this.grd_empleados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFaceReloj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttrabajadas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtextras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgg_activo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_exit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit grd_empleados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dt_desde;
        private DevExpress.XtraEditors.DateEdit dt_hasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private dsFaceReloj dsFaceReloj;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SpinEdit txttrabajadas;
        private DevExpress.XtraEditors.SpinEdit txtextras;
        private DevExpress.XtraEditors.ToggleSwitch tgg_activo;
        private System.Windows.Forms.Label txtestado;
        private DevExpress.XtraGrid.Columns.GridColumn colaqf;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
    }
}