
namespace LOSA.MigracionACS.Produccion.ForecastPRD
{
    partial class frmAddFCT_produccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddFCT_produccion));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsFCT_PRD1 = new LOSA.MigracionACS.Produccion.ForecastPRD.dsFCT_PRD();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodesap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodeodoo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidpt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFCT_PRD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "new_prodmast";
            this.gridControl1.DataSource = this.dsFCT_PRD1;
            this.gridControl1.Location = new System.Drawing.Point(3, 67);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(481, 436);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsFCT_PRD1
            // 
            this.dsFCT_PRD1.DataSetName = "dsFCT_PRD";
            this.dsFCT_PRD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodesap,
            this.colcodeodoo,
            this.colname,
            this.colidpt,
            this.coltm});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colcodesap
            // 
            this.colcodesap.Caption = "Item Code";
            this.colcodesap.FieldName = "codesap";
            this.colcodesap.Name = "colcodesap";
            this.colcodesap.OptionsColumn.AllowEdit = false;
            this.colcodesap.Visible = true;
            this.colcodesap.VisibleIndex = 0;
            this.colcodesap.Width = 68;
            // 
            // colcodeodoo
            // 
            this.colcodeodoo.Caption = "Code";
            this.colcodeodoo.FieldName = "codeodoo";
            this.colcodeodoo.Name = "colcodeodoo";
            this.colcodeodoo.OptionsColumn.AllowEdit = false;
            this.colcodeodoo.Visible = true;
            this.colcodeodoo.VisibleIndex = 1;
            this.colcodeodoo.Width = 91;
            // 
            // colname
            // 
            this.colname.Caption = "Name";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 2;
            this.colname.Width = 228;
            // 
            // colidpt
            // 
            this.colidpt.FieldName = "idpt";
            this.colidpt.Name = "colidpt";
            // 
            // coltm
            // 
            this.coltm.Caption = "TM";
            this.coltm.FieldName = "tm";
            this.coltm.Name = "coltm";
            this.coltm.Visible = true;
            this.coltm.VisibleIndex = 3;
            this.coltm.Width = 76;
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "new_prod";
            this.gridControl2.DataSource = this.dsFCT_PRD1;
            this.gridControl2.Location = new System.Drawing.Point(505, 67);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(489, 436);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Item Code";
            this.gridColumn1.FieldName = "codesap";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 68;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Code";
            this.gridColumn2.FieldName = "codeodoo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 91;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Name";
            this.gridColumn3.FieldName = "name";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 228;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "idpt";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "TM";
            this.gridColumn5.FieldName = "tm";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 76;
            // 
            // cmdAplicar
            // 
            this.cmdAplicar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAplicar.Appearance.Options.UseFont = true;
            this.cmdAplicar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAplicar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAplicar.ImageOptions.Image")));
            this.cmdAplicar.Location = new System.Drawing.Point(505, 12);
            this.cmdAplicar.Name = "cmdAplicar";
            this.cmdAplicar.Size = new System.Drawing.Size(114, 49);
            this.cmdAplicar.TabIndex = 2;
            this.cmdAplicar.Text = "Aplicar";
            this.cmdAplicar.Click += new System.EventHandler(this.cmdAplicar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.comboBox1.Location = new System.Drawing.Point(683, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(683, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(19, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Mes";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(838, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(19, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Año";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029"});
            this.comboBox2.Location = new System.Drawing.Point(838, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // frmAddFCT_produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 503);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmdAplicar);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmAddFCT_produccion";
            this.Text = "Add";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFCT_PRD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colcodesap;
        private DevExpress.XtraGrid.Columns.GridColumn colcodeodoo;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colidpt;
        private DevExpress.XtraGrid.Columns.GridColumn coltm;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton cmdAplicar;
        public dsFCT_PRD dsFCT_PRD1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}