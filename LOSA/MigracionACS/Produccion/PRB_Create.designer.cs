namespace LOSA.MigracionACS.Produccion
{
    partial class PRB_Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRB_Create));
            this.lblhorasdis = new DevExpress.XtraEditors.LabelControl();
            this.lblfecha_ini = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtIni = new DevExpress.XtraEditors.DateEdit();
            this.dtFin = new DevExpress.XtraEditors.DateEdit();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Turno = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.turnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRBdata = new LOSA.MigracionACS.DataSetx.PRBdata();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colturno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.gridLookUpHorarios = new DevExpress.XtraEditors.GridLookUpEdit();
            this.HorariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridHorasDisponible = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceHorasDisp = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtIni.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRBdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpHorarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHorasDisponible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHorasDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblhorasdis
            // 
            this.lblhorasdis.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhorasdis.Appearance.Options.UseFont = true;
            this.lblhorasdis.Location = new System.Drawing.Point(18, 94);
            this.lblhorasdis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblhorasdis.Name = "lblhorasdis";
            this.lblhorasdis.Size = new System.Drawing.Size(207, 16);
            this.lblhorasdis.TabIndex = 0;
            this.lblhorasdis.Text = "Horas disponibles por turno_______";
            // 
            // lblfecha_ini
            // 
            this.lblfecha_ini.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha_ini.Appearance.Options.UseFont = true;
            this.lblfecha_ini.Location = new System.Drawing.Point(18, 151);
            this.lblfecha_ini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblfecha_ini.Name = "lblfecha_ini";
            this.lblfecha_ini.Size = new System.Drawing.Size(223, 16);
            this.lblfecha_ini.TabIndex = 1;
            this.lblfecha_ini.Text = "Fecha de Inicio de turno____________";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 185);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(195, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Fecha final del turno___________";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 12);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(381, 32);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Creación de nuevo registro, para el control de la producción según \r\nturno. Por f" +
    "avor llenar la informacion requerida.\r\n";
            // 
            // dtIni
            // 
            this.dtIni.EditValue = null;
            this.dtIni.Enabled = false;
            this.dtIni.Location = new System.Drawing.Point(210, 144);
            this.dtIni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtIni.Name = "dtIni";
            this.dtIni.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtIni.Properties.Appearance.Options.UseFont = true;
            this.dtIni.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtIni.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtIni.Size = new System.Drawing.Size(182, 22);
            this.dtIni.TabIndex = 6;
            this.dtIni.EditValueChanged += new System.EventHandler(this.dtIni_EditValueChanged);
            // 
            // dtFin
            // 
            this.dtFin.EditValue = null;
            this.dtFin.Enabled = false;
            this.dtFin.Location = new System.Drawing.Point(210, 179);
            this.dtFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFin.Name = "dtFin";
            this.dtFin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFin.Properties.Appearance.Options.UseFont = true;
            this.dtFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFin.Size = new System.Drawing.Size(182, 22);
            this.dtFin.TabIndex = 7;
            this.dtFin.EditValueChanged += new System.EventHandler(this.dtFin_EditValueChanged);
            // 
            // btn_create
            // 
            this.btn_create.Image = global::LOSA.Properties.Resources.accept2_32;
            this.btn_create.Location = new System.Drawing.Point(77, 284);
            this.btn_create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(126, 44);
            this.btn_create.TabIndex = 9;
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Image = global::LOSA.Properties.Resources.cancel2_32;
            this.btn_Cancel.Location = new System.Drawing.Point(209, 284);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(126, 44);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 248);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(193, 16);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Comentario__________________";
            // 
            // Turno
            // 
            this.Turno.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turno.Appearance.Options.UseFont = true;
            this.Turno.Location = new System.Drawing.Point(19, 67);
            this.Turno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Turno.Name = "Turno";
            this.Turno.Size = new System.Drawing.Size(245, 16);
            this.Turno.TabIndex = 13;
            this.Turno.Text = "Turno______________________________";
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.EditValue = "";
            this.gridLookUpEdit1.Location = new System.Drawing.Point(210, 62);
            this.gridLookUpEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.turnoBindingSource;
            this.gridLookUpEdit1.Properties.DisplayMember = "descripcion";
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Properties.ValueMember = "id";
            this.gridLookUpEdit1.Size = new System.Drawing.Size(182, 20);
            this.gridLookUpEdit1.TabIndex = 14;
            this.gridLookUpEdit1.EditValueChanged += new System.EventHandler(this.gridLookUpEdit1_EditValueChanged);
            // 
            // turnoBindingSource
            // 
            this.turnoBindingSource.DataMember = "Turno";
            this.turnoBindingSource.DataSource = this.pRBdata;
            // 
            // pRBdata
            // 
            this.pRBdata.DataSetName = "PRBdata";
            this.pRBdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colturno,
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colturno
            // 
            this.colturno.FieldName = "turno";
            this.colturno.Name = "colturno";
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(19, 123);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(200, 14);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Horario_______________________";
            // 
            // txtComentario
            // 
            this.txtComentario.Enabled = false;
            this.txtComentario.Location = new System.Drawing.Point(209, 206);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(2);
            this.txtComentario.MaxLength = 100;
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(183, 57);
            this.txtComentario.TabIndex = 17;
            // 
            // gridLookUpHorarios
            // 
            this.gridLookUpHorarios.EditValue = "";
            this.gridLookUpHorarios.Enabled = false;
            this.gridLookUpHorarios.Location = new System.Drawing.Point(210, 117);
            this.gridLookUpHorarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridLookUpHorarios.Name = "gridLookUpHorarios";
            this.gridLookUpHorarios.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpHorarios.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpHorarios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpHorarios.Properties.DataSource = this.HorariosBindingSource;
            this.gridLookUpHorarios.Properties.DisplayMember = "descripcion";
            this.gridLookUpHorarios.Properties.PopupView = this.gridView1;
            this.gridLookUpHorarios.Properties.ValueMember = "id";
            this.gridLookUpHorarios.Size = new System.Drawing.Size(182, 20);
            this.gridLookUpHorarios.TabIndex = 18;
            this.gridLookUpHorarios.EditValueChanged += new System.EventHandler(this.gridLookUpHorarios_EditValueChanged);
            this.gridLookUpHorarios.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.gridLookUpHorarios_EditValueChanging);
            // 
            // HorariosBindingSource
            // 
            this.HorariosBindingSource.DataMember = "horas";
            this.HorariosBindingSource.DataSource = this.pRBdata;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.Caption = "Horario";
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
            // 
            // gridHorasDisponible
            // 
            this.gridHorasDisponible.EditValue = "";
            this.gridHorasDisponible.Enabled = false;
            this.gridHorasDisponible.Location = new System.Drawing.Point(210, 90);
            this.gridHorasDisponible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridHorasDisponible.Name = "gridHorasDisponible";
            this.gridHorasDisponible.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridHorasDisponible.Properties.Appearance.Options.UseFont = true;
            this.gridHorasDisponible.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridHorasDisponible.Properties.DataSource = this.bindingSourceHorasDisp;
            this.gridHorasDisponible.Properties.DisplayMember = "valor";
            this.gridHorasDisponible.Properties.PopupView = this.gridView2;
            this.gridHorasDisponible.Properties.ValueMember = "id";
            this.gridHorasDisponible.Size = new System.Drawing.Size(182, 20);
            this.gridHorasDisponible.TabIndex = 19;
            this.gridHorasDisponible.EditValueChanged += new System.EventHandler(this.gridHorasDisponible_EditValueChanged);
            // 
            // bindingSourceHorasDisp
            // 
            this.bindingSourceHorasDisp.DataMember = "horas_disponibles";
            this.bindingSourceHorasDisp.DataSource = this.pRBdata;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colvalor});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // colvalor
            // 
            this.colvalor.Caption = "Horas";
            this.colvalor.FieldName = "valor";
            this.colvalor.Name = "colvalor";
            this.colvalor.Visible = true;
            this.colvalor.VisibleIndex = 0;
            // 
            // PRB_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 347);
            this.ControlBox = false;
            this.Controls.Add(this.gridHorasDisponible);
            this.Controls.Add(this.gridLookUpHorarios);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.gridLookUpEdit1);
            this.Controls.Add(this.Turno);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.dtIni);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblfecha_ini);
            this.Controls.Add(this.lblhorasdis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PRB_Create";
            this.Text = "Nuevo Registro";
            this.Load += new System.EventHandler(this.PRB_Create_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtIni.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRBdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpHorarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHorasDisponible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHorasDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblhorasdis;
        private DevExpress.XtraEditors.LabelControl lblfecha_ini;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtIni;
        private DevExpress.XtraEditors.DateEdit dtFin;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_Cancel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl Turno;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource turnoBindingSource;
        private DataSetx.PRBdata pRBdata;
        private DevExpress.XtraGrid.Columns.GridColumn colturno;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtComentario;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpHorarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource HorariosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraEditors.GridLookUpEdit gridHorasDisponible;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource bindingSourceHorasDisp;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor;
    }
}