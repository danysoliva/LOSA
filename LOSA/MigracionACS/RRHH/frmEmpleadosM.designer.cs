namespace LOSA.MigracionACS.RRHH
{
    partial class frmEmpleadosM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleadosM));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreEmpleado = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCodigoEmpleado = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.cmdSearch = new DevExpress.XtraEditors.SimpleButton();
            this.dtin = new System.Windows.Forms.DateTimePicker();
            this.dtout = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.grdturno = new DevExpress.XtraEditors.GridLookUpEdit();
            this.typedayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSrrhh = new MigracionACS.RRHH.DSrrhh();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoTarjeta = new System.Windows.Forms.TextBox();
            this.tggTipoHorario = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdturno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typedayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSrrhh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggTipoHorario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(77, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nombre:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(217, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(356, 25);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mantenimiento de Datos de Empleado";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(265, 74);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.Properties.Appearance.Options.UseFont = true;
            this.txtNombreEmpleado.Properties.ReadOnly = true;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(375, 26);
            this.txtNombreEmpleado.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(162, 74);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(97, 26);
            this.txtCodigo.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCodigoEmpleado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 486);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCodigoEmpleado
            // 
            this.toolStripStatusLabelCodigoEmpleado.Name = "toolStripStatusLabelCodigoEmpleado";
            this.toolStripStatusLabelCodigoEmpleado.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabelCodigoEmpleado.Text = "None";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Appearance.Options.UseBackColor = true;
            this.cmdCancelar.Appearance.Options.UseFont = true;
            this.cmdCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.ImageOptions.Image")));
            this.cmdCancelar.Location = new System.Drawing.Point(406, 430);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(131, 45);
            this.cmdCancelar.TabIndex = 7;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(121)))), ((int)(((byte)(232)))));
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.Location = new System.Drawing.Point(254, 430);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(131, 45);
            this.cmdGuardar.TabIndex = 6;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdBrowse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdBrowse.ImageOptions.Image")));
            this.cmdBrowse.Location = new System.Drawing.Point(674, 135);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(84, 32);
            this.cmdBrowse.TabIndex = 5;
            this.cmdBrowse.Text = "Explorar";
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Image = global::LOSA.Properties.Resources.image_not_available;
            this.pictureBoxProfile.Location = new System.Drawing.Point(333, 135);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(307, 271);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 4;
            this.pictureBoxProfile.TabStop = false;
            // 
            // cmdSearch
            // 
            this.cmdSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSearch.ImageOptions.Image")));
            this.cmdSearch.Location = new System.Drawing.Point(644, 68);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(43, 41);
            this.cmdSearch.TabIndex = 3;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // dtin
            // 
            this.dtin.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtin.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtin.Location = new System.Drawing.Point(190, 114);
            this.dtin.Margin = new System.Windows.Forms.Padding(2);
            this.dtin.Name = "dtin";
            this.dtin.ShowUpDown = true;
            this.dtin.Size = new System.Drawing.Size(115, 27);
            this.dtin.TabIndex = 10;
            // 
            // dtout
            // 
            this.dtout.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtout.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtout.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtout.Location = new System.Drawing.Point(190, 153);
            this.dtout.Margin = new System.Windows.Forms.Padding(2);
            this.dtout.Name = "dtout";
            this.dtout.ShowUpDown = true;
            this.dtout.Size = new System.Drawing.Size(115, 27);
            this.dtout.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(38, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(145, 23);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Hora de entrada:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(52, 153);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(130, 23);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Hora de Salida:";
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(123, 197);
            this.checkEdit1.Margin = new System.Windows.Forms.Padding(2);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Aplica para marca:";
            this.checkEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style4;
            this.checkEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.checkEdit1.Properties.CheckedChanged += new System.EventHandler(this.checkEdit1_Properties_CheckedChanged);
            this.checkEdit1.Size = new System.Drawing.Size(182, 26);
            this.checkEdit1.TabIndex = 14;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(16, 292);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(139, 23);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Turno Asignado:";
            // 
            // grdturno
            // 
            this.grdturno.Location = new System.Drawing.Point(52, 320);
            this.grdturno.Margin = new System.Windows.Forms.Padding(2);
            this.grdturno.Name = "grdturno";
            this.grdturno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdturno.Properties.Appearance.Options.UseFont = true;
            this.grdturno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdturno.Properties.DataSource = this.typedayBindingSource;
            this.grdturno.Properties.DisplayMember = "descripcion";
            this.grdturno.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdturno.Properties.ValueMember = "id";
            this.grdturno.Size = new System.Drawing.Size(252, 24);
            this.grdturno.TabIndex = 17;
            // 
            // typedayBindingSource
            // 
            this.typedayBindingSource.DataMember = "typeday";
            this.typedayBindingSource.DataSource = this.dSrrhh;
            // 
            // dSrrhh
            // 
            this.dSrrhh.DataSetName = "DSrrhh";
            this.dSrrhh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 366);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(145, 23);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Tarjeta Asociada:";
            // 
            // txtCodigoTarjeta
            // 
            this.txtCodigoTarjeta.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCodigoTarjeta.Location = new System.Drawing.Point(52, 389);
            this.txtCodigoTarjeta.Name = "txtCodigoTarjeta";
            this.txtCodigoTarjeta.Size = new System.Drawing.Size(252, 27);
            this.txtCodigoTarjeta.TabIndex = 19;
            this.txtCodigoTarjeta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoTarjeta_KeyDown);
            // 
            // tggTipoHorario
            // 
            this.tggTipoHorario.Location = new System.Drawing.Point(112, 245);
            this.tggTipoHorario.Name = "tggTipoHorario";
            this.tggTipoHorario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tggTipoHorario.Properties.Appearance.Options.UseFont = true;
            this.tggTipoHorario.Properties.OffText = "Turnos";
            this.tggTipoHorario.Properties.OnText = "Administración";
            this.tggTipoHorario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tggTipoHorario.Size = new System.Drawing.Size(193, 26);
            this.tggTipoHorario.TabIndex = 20;
            this.tggTipoHorario.Toggled += new System.EventHandler(this.tggTipoHorario_Toggled);
            // 
            // frmEmpleadosM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.tggTipoHorario);
            this.Controls.Add(this.txtCodigoTarjeta);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.grdturno);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dtout);
            this.Controls.Add(this.dtin);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmpleadosM";
            this.Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdturno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typedayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSrrhh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggTipoHorario.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNombreEmpleado;
        private DevExpress.XtraEditors.SimpleButton cmdSearch;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private DevExpress.XtraEditors.SimpleButton cmdBrowse;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdCancelar;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCodigoEmpleado;
        private System.Windows.Forms.DateTimePicker dtin;
        private System.Windows.Forms.DateTimePicker dtout;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GridLookUpEdit grdturno;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource typedayBindingSource;
        private DSrrhh dSrrhh;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtCodigoTarjeta;
        private DevExpress.XtraEditors.ToggleSwitch tggTipoHorario;
    }
}