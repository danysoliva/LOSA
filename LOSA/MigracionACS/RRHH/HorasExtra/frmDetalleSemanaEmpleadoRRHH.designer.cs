
namespace LOSA.MigracionACS.RRHH.HorasExtra
{
    partial class frmDetalleSemanaEmpleadoRRHH
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
            this.dsHorasExtra1 = new MigracionACS.RRHH.HorasExtra.dsHorasExtra();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_emp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBasicHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOvertime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkingTime = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsHorasExtra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsHorasExtra1
            // 
            this.dsHorasExtra1.DataSetName = "dsHorasExtra";
            this.dsHorasExtra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "detalle_semana";
            this.gridControl1.DataSource = this.dsHorasExtra1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1033, 515);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_emp,
            this.colCode,
            this.colName,
            this.colBasicHours,
            this.colOvertime,
            this.gridColumn1,
            this.colStartDate,
            this.colEndDate,
            this.colWorkingTime});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid_emp
            // 
            this.colid_emp.FieldName = "id_emp";
            this.colid_emp.Name = "colid_emp";
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.OptionsColumn.AllowEdit = false;
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 74;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 253;
            // 
            // colBasicHours
            // 
            this.colBasicHours.FieldName = "Basic Hours";
            this.colBasicHours.Name = "colBasicHours";
            this.colBasicHours.OptionsColumn.AllowEdit = false;
            this.colBasicHours.Visible = true;
            this.colBasicHours.VisibleIndex = 2;
            this.colBasicHours.Width = 113;
            // 
            // colOvertime
            // 
            this.colOvertime.FieldName = "Overtime";
            this.colOvertime.Name = "colOvertime";
            this.colOvertime.OptionsColumn.AllowEdit = false;
            this.colOvertime.Visible = true;
            this.colOvertime.VisibleIndex = 3;
            this.colOvertime.Width = 113;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "# Week";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 113;
            // 
            // colStartDate
            // 
            this.colStartDate.DisplayFormat.FormatString = "g";
            this.colStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartDate.FieldName = "Start Date";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.OptionsColumn.AllowEdit = false;
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 5;
            this.colStartDate.Width = 113;
            // 
            // colEndDate
            // 
            this.colEndDate.DisplayFormat.FormatString = "g";
            this.colEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEndDate.FieldName = "End Date";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.OptionsColumn.AllowEdit = false;
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 6;
            this.colEndDate.Width = 113;
            // 
            // colWorkingTime
            // 
            this.colWorkingTime.FieldName = "Working Time";
            this.colWorkingTime.Name = "colWorkingTime";
            this.colWorkingTime.OptionsColumn.AllowEdit = false;
            this.colWorkingTime.Visible = true;
            this.colWorkingTime.VisibleIndex = 7;
            this.colWorkingTime.Width = 123;
            // 
            // frmDetalleSemanaEmpleadoRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 515);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmDetalleSemanaEmpleadoRRHH";
            this.Text = "Detalle Semana Empleado: ";
            ((System.ComponentModel.ISupportInitialize)(this.dsHorasExtra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dsHorasExtra dsHorasExtra1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_emp;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colBasicHours;
        private DevExpress.XtraGrid.Columns.GridColumn colOvertime;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkingTime;
    }
}