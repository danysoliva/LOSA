
namespace LOSA.MigracionACS.RRHH
{
    partial class frmSaldosVacacionesRRHH
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsRRHH_B1 = new MigracionACS.RRHH.dsRRHH_B();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasCompletados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasTomados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldoDias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitchVerTodos = new DevExpress.XtraEditors.ToggleSwitch();
            this.cmdExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRRHH_B1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchVerTodos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(2, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(200, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Saldos de Vacaciones";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "saldos_vacaciones";
            this.gridControl1.DataSource = this.dsRRHH_B1;
            this.gridControl1.Location = new System.Drawing.Point(2, 63);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(753, 546);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsRRHH_B1
            // 
            this.dsRRHH_B1.DataSetName = "dsRRHH_B";
            this.dsRRHH_B1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNombre,
            this.colDiasCompletados,
            this.colDiasTomados,
            this.colSaldoDias,
            this.colCodigo,
            this.colDepartamento});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 227;
            // 
            // colDiasCompletados
            // 
            this.colDiasCompletados.FieldName = "Dias Completados";
            this.colDiasCompletados.Name = "colDiasCompletados";
            this.colDiasCompletados.OptionsColumn.AllowEdit = false;
            this.colDiasCompletados.Visible = true;
            this.colDiasCompletados.VisibleIndex = 3;
            this.colDiasCompletados.Width = 111;
            // 
            // colDiasTomados
            // 
            this.colDiasTomados.FieldName = "Dias Tomados";
            this.colDiasTomados.Name = "colDiasTomados";
            this.colDiasTomados.OptionsColumn.AllowEdit = false;
            this.colDiasTomados.Visible = true;
            this.colDiasTomados.VisibleIndex = 4;
            this.colDiasTomados.Width = 87;
            // 
            // colSaldoDias
            // 
            this.colSaldoDias.FieldName = "Saldo Dias";
            this.colSaldoDias.Name = "colSaldoDias";
            this.colSaldoDias.OptionsColumn.AllowEdit = false;
            this.colSaldoDias.Visible = true;
            this.colSaldoDias.VisibleIndex = 5;
            this.colSaldoDias.Width = 96;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.AllowEdit = false;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            this.colCodigo.Width = 51;
            // 
            // colDepartamento
            // 
            this.colDepartamento.FieldName = "Departamento";
            this.colDepartamento.Name = "colDepartamento";
            this.colDepartamento.OptionsColumn.AllowEdit = false;
            this.colDepartamento.Visible = true;
            this.colDepartamento.VisibleIndex = 2;
            this.colDepartamento.Width = 163;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.Location = new System.Drawing.Point(643, 22);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(109, 39);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Refresh";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(248, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(140, 15);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mostrar Desactivados";
            // 
            // toggleSwitchVerTodos
            // 
            this.toggleSwitchVerTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleSwitchVerTodos.Location = new System.Drawing.Point(394, 37);
            this.toggleSwitchVerTodos.Name = "toggleSwitchVerTodos";
            this.toggleSwitchVerTodos.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitchVerTodos.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitchVerTodos.Properties.OffText = "No";
            this.toggleSwitchVerTodos.Properties.OnText = "Yes";
            this.toggleSwitchVerTodos.Size = new System.Drawing.Size(103, 24);
            this.toggleSwitchVerTodos.TabIndex = 4;
            this.toggleSwitchVerTodos.Toggled += new System.EventHandler(this.toggleSwitchVerTodos_Toggled);
            // 
            // cmdExcel
            // 
            this.cmdExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExcel.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcel.Appearance.Options.UseFont = true;
            this.cmdExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdExcel.Location = new System.Drawing.Point(503, 22);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.Size = new System.Drawing.Size(134, 39);
            this.cmdExcel.TabIndex = 5;
            this.cmdExcel.Text = "Export to Excel";
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // frmSaldosVacacionesRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 610);
            this.Controls.Add(this.cmdExcel);
            this.Controls.Add(this.toggleSwitchVerTodos);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmSaldosVacacionesRRHH";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRRHH_B1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchVerTodos.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchVerTodos;
        private dsRRHH_B dsRRHH_B1;
        private DevExpress.XtraEditors.SimpleButton cmdExcel;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasCompletados;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasTomados;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldoDias;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartamento;
    }
}