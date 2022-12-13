
using LOSA.MigracionACS.RRHH.HorasExtra;

namespace ACS.RRHH.HorasExtra
{
    partial class frmResumenHorasExtra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResumenHorasExtra));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsHorasExtra1 = new LOSA.MigracionACS.RRHH.HorasExtra.dsHorasExtra();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljornada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdVerDetalles = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colextra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotalweek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltrucadas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colweek_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinNumSemana = new DevExpress.XtraEditors.SpinEdit();
            this.txtYear = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditHasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmdBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditDesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.colroll_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartment_name = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHorasExtra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNumSemana.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "horas_extra_user";
            this.gridControl1.DataSource = this.dsHorasExtra1;
            this.gridControl1.Location = new System.Drawing.Point(0, 69);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdVerDetalles});
            this.gridControl1.Size = new System.Drawing.Size(985, 563);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsHorasExtra1
            // 
            this.dsHorasExtra1.DataSetName = "dsHorasExtra";
            this.dsHorasExtra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_empleado,
            this.colcodigo,
            this.coljornada,
            this.colnombre,
            this.colcantidad,
            this.colextra,
            this.coltotalweek,
            this.coltrucadas,
            this.colweek_num,
            this.colroll_name,
            this.coldepartment_name});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid_empleado
            // 
            this.colid_empleado.FieldName = "id_empleado";
            this.colid_empleado.Name = "colid_empleado";
            // 
            // colcodigo
            // 
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 45;
            // 
            // coljornada
            // 
            this.coljornada.FieldName = "jornada";
            this.coljornada.Name = "coljornada";
            this.coljornada.Visible = true;
            this.coljornada.VisibleIndex = 4;
            this.coljornada.Width = 91;
            // 
            // colnombre
            // 
            this.colnombre.ColumnEdit = this.cmdVerDetalles;
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 203;
            // 
            // cmdVerDetalles
            // 
            this.cmdVerDetalles.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.cmdVerDetalles.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdVerDetalles.Name = "cmdVerDetalles";
            this.cmdVerDetalles.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdVerDetalles_ButtonClick);
            // 
            // colcantidad
            // 
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 5;
            this.colcantidad.Width = 94;
            // 
            // colextra
            // 
            this.colextra.FieldName = "extra";
            this.colextra.Name = "colextra";
            this.colextra.OptionsColumn.AllowEdit = false;
            this.colextra.Visible = true;
            this.colextra.VisibleIndex = 6;
            this.colextra.Width = 94;
            // 
            // coltotalweek
            // 
            this.coltotalweek.FieldName = "totalweek";
            this.coltotalweek.Name = "coltotalweek";
            this.coltotalweek.OptionsColumn.AllowEdit = false;
            this.coltotalweek.Visible = true;
            this.coltotalweek.VisibleIndex = 7;
            this.coltotalweek.Width = 94;
            // 
            // coltrucadas
            // 
            this.coltrucadas.FieldName = "trucadas";
            this.coltrucadas.Name = "coltrucadas";
            this.coltrucadas.OptionsColumn.AllowEdit = false;
            this.coltrucadas.Visible = true;
            this.coltrucadas.VisibleIndex = 8;
            this.coltrucadas.Width = 94;
            // 
            // colweek_num
            // 
            this.colweek_num.FieldName = "week_num";
            this.colweek_num.Name = "colweek_num";
            this.colweek_num.OptionsColumn.AllowEdit = false;
            this.colweek_num.Visible = true;
            this.colweek_num.VisibleIndex = 9;
            this.colweek_num.Width = 117;
            // 
            // spinNumSemana
            // 
            this.spinNumSemana.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinNumSemana.Location = new System.Drawing.Point(122, 12);
            this.spinNumSemana.Name = "spinNumSemana";
            this.spinNumSemana.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.spinNumSemana.Properties.Appearance.Options.UseFont = true;
            this.spinNumSemana.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinNumSemana.Properties.IsFloatValue = false;
            this.spinNumSemana.Properties.Mask.EditMask = "N00";
            this.spinNumSemana.Properties.MaxValue = new decimal(new int[] {
            53,
            0,
            0,
            0});
            this.spinNumSemana.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinNumSemana.Size = new System.Drawing.Size(146, 24);
            this.spinNumSemana.TabIndex = 147;
            this.spinNumSemana.EditValueChanged += new System.EventHandler(this.spinNumSemana_EditValueChanged);
            // 
            // txtYear
            // 
            this.txtYear.EditValue = "0";
            this.txtYear.Location = new System.Drawing.Point(122, 39);
            this.txtYear.Name = "txtYear";
            this.txtYear.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Properties.Appearance.Options.UseFont = true;
            this.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtYear.Size = new System.Drawing.Size(146, 24);
            this.txtYear.TabIndex = 145;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(8, 45);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(130, 18);
            this.labelControl4.TabIndex = 146;
            this.labelControl4.Text = "Año_____________";
            // 
            // dateEditHasta
            // 
            this.dateEditHasta.EditValue = null;
            this.dateEditHasta.Location = new System.Drawing.Point(558, 39);
            this.dateEditHasta.Name = "dateEditHasta";
            this.dateEditHasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditHasta.Properties.Appearance.Options.UseFont = true;
            this.dateEditHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditHasta.Size = new System.Drawing.Size(146, 24);
            this.dateEditHasta.TabIndex = 143;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(444, 45);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(147, 18);
            this.labelControl3.TabIndex = 144;
            this.labelControl3.Text = "Fecha Hasta________";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Appearance.Options.UseFont = true;
            this.cmdBuscar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdBuscar.ImageOptions.Image")));
            this.cmdBuscar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.cmdBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdBuscar.Location = new System.Drawing.Point(274, 12);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(117, 51);
            this.cmdBuscar.TabIndex = 142;
            this.cmdBuscar.Text = "Generar";
            this.cmdBuscar.ToolTip = "Generar";
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // dateEditDesde
            // 
            this.dateEditDesde.EditValue = null;
            this.dateEditDesde.Location = new System.Drawing.Point(558, 12);
            this.dateEditDesde.Name = "dateEditDesde";
            this.dateEditDesde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditDesde.Properties.Appearance.Options.UseFont = true;
            this.dateEditDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDesde.Size = new System.Drawing.Size(146, 24);
            this.dateEditDesde.TabIndex = 139;
            this.dateEditDesde.EditValueChanged += new System.EventHandler(this.dateEditDesde_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(444, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(150, 18);
            this.labelControl2.TabIndex = 141;
            this.labelControl2.Text = "Fecha Desde________";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(158, 18);
            this.labelControl1.TabIndex = 140;
            this.labelControl1.Text = "Semana_____________";
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = global::LOSA.Properties.Resources.Excel_2_icon32px1;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(866, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(117, 51);
            this.simpleButton1.TabIndex = 148;
            this.simpleButton1.Text = "Exportar";
            this.simpleButton1.ToolTip = "Generar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // colroll_name
            // 
            this.colroll_name.Caption = "Roll";
            this.colroll_name.FieldName = "roll_name";
            this.colroll_name.Name = "colroll_name";
            this.colroll_name.OptionsColumn.AllowEdit = false;
            this.colroll_name.Visible = true;
            this.colroll_name.VisibleIndex = 3;
            this.colroll_name.Width = 63;
            // 
            // coldepartment_name
            // 
            this.coldepartment_name.Caption = "Department";
            this.coldepartment_name.FieldName = "department_name";
            this.coldepartment_name.Name = "coldepartment_name";
            this.coldepartment_name.OptionsColumn.AllowEdit = false;
            this.coldepartment_name.Visible = true;
            this.coldepartment_name.VisibleIndex = 2;
            this.coldepartment_name.Width = 72;
            // 
            // frmResumenHorasExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 633);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.spinNumSemana);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.dateEditHasta);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.dateEditDesde);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmResumenHorasExtra";
            this.Text = "Resumen Horas Extra";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHorasExtra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNumSemana.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SpinEdit spinNumSemana;
        private DevExpress.XtraEditors.TextEdit txtYear;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dateEditHasta;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton cmdBuscar;
        private DevExpress.XtraEditors.DateEdit dateEditDesde;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private dsHorasExtra dsHorasExtra1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colextra;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalweek;
        private DevExpress.XtraGrid.Columns.GridColumn coltrucadas;
        private DevExpress.XtraGrid.Columns.GridColumn colweek_num;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdVerDetalles;
        private DevExpress.XtraGrid.Columns.GridColumn coljornada;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colroll_name;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartment_name;
    }
}