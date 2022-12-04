namespace LOSA.MigracionACS.OIL
{
    partial class frmDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalle));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dsAceites1 = new MigracionACS.OIL.dsAceites();
            this.colsolicitada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldosificada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collong_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_hora = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAceites1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "detalles_req";
            this.gridControl1.DataSource = this.dsAceites1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(683, 218);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsolicitada,
            this.coldosificada,
            this.collong_name,
            this.colfecha_hora});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // dsAceites1
            // 
            this.dsAceites1.DataSetName = "dsAceites";
            this.dsAceites1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colsolicitada
            // 
            this.colsolicitada.Caption = "Cant. Solicitada";
            this.colsolicitada.FieldName = "solicitada";
            this.colsolicitada.Name = "colsolicitada";
            this.colsolicitada.OptionsColumn.AllowEdit = false;
            this.colsolicitada.Visible = true;
            this.colsolicitada.VisibleIndex = 0;
            // 
            // coldosificada
            // 
            this.coldosificada.Caption = "Cant. Dosificada";
            this.coldosificada.FieldName = "dosificada";
            this.coldosificada.Name = "coldosificada";
            this.coldosificada.OptionsColumn.AllowEdit = false;
            this.coldosificada.Visible = true;
            this.coldosificada.VisibleIndex = 1;
            // 
            // collong_name
            // 
            this.collong_name.Caption = "Materia Prima";
            this.collong_name.FieldName = "long_name";
            this.collong_name.Name = "collong_name";
            this.collong_name.OptionsColumn.AllowEdit = false;
            this.collong_name.Visible = true;
            this.collong_name.VisibleIndex = 2;
            // 
            // colfecha_hora
            // 
            this.colfecha_hora.Caption = "Fecha Hora";
            this.colfecha_hora.FieldName = "fecha_hora";
            this.colfecha_hora.Name = "colfecha_hora";
            this.colfecha_hora.OptionsColumn.AllowEdit = false;
            this.colfecha_hora.Visible = true;
            this.colfecha_hora.VisibleIndex = 3;
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 218);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDetalle";
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.frmDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAceites1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsAceites dsAceites1;
        private DevExpress.XtraGrid.Columns.GridColumn colsolicitada;
        private DevExpress.XtraGrid.Columns.GridColumn coldosificada;
        private DevExpress.XtraGrid.Columns.GridColumn collong_name;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_hora;
    }
}