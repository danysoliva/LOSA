
namespace LOSA.MigracionACS.RRHH.Liquidaciones
{
    partial class frmLiquidaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLiquidaciones));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dSrrhh1 = new MigracionACS.RRHH.DSrrhh();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_liquidacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colempleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_creacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_egreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colantiguedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user_creador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_creador = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSrrhh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "liquidaciones_h";
            this.gridControl1.DataSource = this.dSrrhh1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1181, 567);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dSrrhh1
            // 
            this.dSrrhh1.DataSetName = "DSrrhh";
            this.dSrrhh1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_liquidacion,
            this.colcodigo,
            this.colid_empleado,
            this.colempleado,
            this.colpuesto,
            this.colfecha_creacion,
            this.colfecha_ingreso,
            this.colfecha_egreso,
            this.colantiguedad,
            this.colid_user_creador,
            this.colusuario_creador});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colid_liquidacion
            // 
            this.colid_liquidacion.FieldName = "id_liquidacion";
            this.colid_liquidacion.Name = "colid_liquidacion";
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 122;
            // 
            // colid_empleado
            // 
            this.colid_empleado.FieldName = "id_empleado";
            this.colid_empleado.Name = "colid_empleado";
            // 
            // colempleado
            // 
            this.colempleado.Caption = "Empleado";
            this.colempleado.FieldName = "empleado";
            this.colempleado.Name = "colempleado";
            this.colempleado.Visible = true;
            this.colempleado.VisibleIndex = 1;
            this.colempleado.Width = 146;
            // 
            // colpuesto
            // 
            this.colpuesto.Caption = "Puesto";
            this.colpuesto.FieldName = "puesto";
            this.colpuesto.Name = "colpuesto";
            this.colpuesto.Visible = true;
            this.colpuesto.VisibleIndex = 2;
            this.colpuesto.Width = 146;
            // 
            // colfecha_creacion
            // 
            this.colfecha_creacion.Caption = "Fecha Creacion";
            this.colfecha_creacion.FieldName = "fecha_creacion";
            this.colfecha_creacion.Name = "colfecha_creacion";
            this.colfecha_creacion.Visible = true;
            this.colfecha_creacion.VisibleIndex = 3;
            this.colfecha_creacion.Width = 119;
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.Caption = "Fecha de Ingreso";
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.Visible = true;
            this.colfecha_ingreso.VisibleIndex = 4;
            this.colfecha_ingreso.Width = 136;
            // 
            // colfecha_egreso
            // 
            this.colfecha_egreso.Caption = "Fech de Egreso";
            this.colfecha_egreso.FieldName = "fecha_egreso";
            this.colfecha_egreso.Name = "colfecha_egreso";
            this.colfecha_egreso.Visible = true;
            this.colfecha_egreso.VisibleIndex = 5;
            this.colfecha_egreso.Width = 123;
            // 
            // colantiguedad
            // 
            this.colantiguedad.Caption = "Antiguedad";
            this.colantiguedad.FieldName = "antiguedad";
            this.colantiguedad.Name = "colantiguedad";
            this.colantiguedad.Visible = true;
            this.colantiguedad.VisibleIndex = 6;
            this.colantiguedad.Width = 208;
            // 
            // colid_user_creador
            // 
            this.colid_user_creador.FieldName = "id_user_creador";
            this.colid_user_creador.Name = "colid_user_creador";
            // 
            // colusuario_creador
            // 
            this.colusuario_creador.Caption = "Usuario Creador";
            this.colusuario_creador.FieldName = "usuario_creador";
            this.colusuario_creador.Name = "colusuario_creador";
            this.colusuario_creador.Visible = true;
            this.colusuario_creador.VisibleIndex = 7;
            this.colusuario_creador.Width = 163;
            // 
            // frmLiquidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 567);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLiquidaciones";
            this.Text = "Liquidaciones Creadas";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSrrhh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSrrhh dSrrhh1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_liquidacion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colempleado;
        private DevExpress.XtraGrid.Columns.GridColumn colpuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_creacion;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_egreso;
        private DevExpress.XtraGrid.Columns.GridColumn colantiguedad;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user_creador;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_creador;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
    }
}