namespace LOSA.MigracionACS.Produccion.Eficiencia
{
    partial class frmHorasPorPeriodioMaquinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHorasPorPeriodioMaquinas));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsReportesPRD1 = new LOSA.MigracionACS.Produccion.DataSet_.dsReportesPRD();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaquina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colacs_id_registro_detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdOk = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesPRD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "horas_maquina";
            this.gridControl1.DataSource = this.dsReportesPRD1;
            this.gridControl1.Location = new System.Drawing.Point(1, 77);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(797, 375);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsReportesPRD1
            // 
            this.dsReportesPRD1.DataSetName = "dsReportesPRD";
            this.dsReportesPRD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colfechai,
            this.colhoras,
            this.colestado,
            this.colmaquina,
            this.colacs_id_registro_detalle,
            this.colSeleccionar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colfechai
            // 
            this.colfechai.Caption = "Fecha Inicial";
            this.colfechai.DisplayFormat.FormatString = "g";
            this.colfechai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfechai.FieldName = "fechai";
            this.colfechai.Name = "colfechai";
            this.colfechai.OptionsColumn.AllowEdit = false;
            this.colfechai.Visible = true;
            this.colfechai.VisibleIndex = 1;
            // 
            // colhoras
            // 
            this.colhoras.Caption = "Horas Trabajadas";
            this.colhoras.DisplayFormat.FormatString = "###,##0.00";
            this.colhoras.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colhoras.FieldName = "horas";
            this.colhoras.Name = "colhoras";
            this.colhoras.OptionsColumn.AllowEdit = false;
            this.colhoras.Visible = true;
            this.colhoras.VisibleIndex = 2;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado Periodo";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 3;
            // 
            // colmaquina
            // 
            this.colmaquina.Caption = "Maquina";
            this.colmaquina.FieldName = "maquina";
            this.colmaquina.Name = "colmaquina";
            this.colmaquina.OptionsColumn.AllowEdit = false;
            this.colmaquina.Visible = true;
            this.colmaquina.VisibleIndex = 0;
            // 
            // colacs_id_registro_detalle
            // 
            this.colacs_id_registro_detalle.FieldName = "acs_id_registro_detalle";
            this.colacs_id_registro_detalle.Name = "colacs_id_registro_detalle";
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.Caption = "Seleccionar";
            this.colSeleccionar.FieldName = "colSeleccionar";
            this.colSeleccionar.Name = "colSeleccionar";
            this.colSeleccionar.Visible = true;
            this.colSeleccionar.VisibleIndex = 4;
            // 
            // cmdOk
            // 
            this.cmdOk.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOk.Appearance.Options.UseFont = true;
            this.cmdOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdOk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdOk.ImageOptions.Image")));
            this.cmdOk.Location = new System.Drawing.Point(6, 12);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(197, 59);
            this.cmdOk.TabIndex = 1;
            this.cmdOk.Text = "Seleccionar";
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Appearance.Options.UseFont = true;
            this.cmdCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.ImageOptions.Image")));
            this.cmdCancelar.Location = new System.Drawing.Point(209, 12);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(197, 59);
            this.cmdCancelar.TabIndex = 2;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelectAll.Location = new System.Drawing.Point(662, 51);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(136, 20);
            this.chkSelectAll.TabIndex = 3;
            this.chkSelectAll.Text = "Seleccionar todas";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // frmHorasPorPeriodioMaquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkSelectAll);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmHorasPorPeriodioMaquinas";
            this.Text = "Horas por Periodo por Maquinas";
            this.Load += new System.EventHandler(this.frmHorasPorPeriodioMaquinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesPRD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton cmdOk;
        private DevExpress.XtraEditors.SimpleButton cmdCancelar;
        private DataSet_.dsReportesPRD dsReportesPRD1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colfechai;
        private DevExpress.XtraGrid.Columns.GridColumn colhoras;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colmaquina;
        private DevExpress.XtraGrid.Columns.GridColumn colacs_id_registro_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionar;
        private System.Windows.Forms.CheckBox chkSelectAll;
    }
}