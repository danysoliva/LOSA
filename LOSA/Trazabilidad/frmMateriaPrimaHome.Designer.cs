
namespace LOSA.Trazabilidad
{
    partial class frmMateriaPrimaHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMateriaPrimaHome));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsMantoTrazabilidad1 = new LOSA.Trazabilidad.dsMantoTrazabilidad();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoSAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreación = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreadopor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoAlimentación = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.cmdExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantoTrazabilidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "view_mp";
            this.gridControl1.DataSource = this.dsMantoTrazabilidad1;
            this.gridControl1.Location = new System.Drawing.Point(2, 64);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(997, 531);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsMantoTrazabilidad1
            // 
            this.dsMantoTrazabilidad1.DataSetName = "dsMantoTrazabilidad";
            this.dsMantoTrazabilidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcodigo,
            this.colmaterial,
            this.colNombreComercial,
            this.colTipo,
            this.colTipoF,
            this.colTipoR,
            this.colCodigoSAP,
            this.colFechaCreación,
            this.colCreadopor,
            this.colTipoAlimentación});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Código";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 86;
            // 
            // colmaterial
            // 
            this.colmaterial.Caption = "Nombre";
            this.colmaterial.FieldName = "material";
            this.colmaterial.Name = "colmaterial";
            this.colmaterial.OptionsColumn.AllowEdit = false;
            this.colmaterial.Visible = true;
            this.colmaterial.VisibleIndex = 2;
            this.colmaterial.Width = 150;
            // 
            // colNombreComercial
            // 
            this.colNombreComercial.FieldName = "Nombre Comercial";
            this.colNombreComercial.Name = "colNombreComercial";
            this.colNombreComercial.OptionsColumn.AllowEdit = false;
            this.colNombreComercial.Visible = true;
            this.colNombreComercial.VisibleIndex = 3;
            this.colNombreComercial.Width = 146;
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.OptionsColumn.AllowEdit = false;
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 4;
            this.colTipo.Width = 84;
            // 
            // colTipoF
            // 
            this.colTipoF.FieldName = "Tipo F";
            this.colTipoF.Name = "colTipoF";
            this.colTipoF.OptionsColumn.AllowEdit = false;
            this.colTipoF.Visible = true;
            this.colTipoF.VisibleIndex = 5;
            this.colTipoF.Width = 84;
            // 
            // colTipoR
            // 
            this.colTipoR.FieldName = "Tipo R";
            this.colTipoR.Name = "colTipoR";
            this.colTipoR.OptionsColumn.AllowEdit = false;
            this.colTipoR.Visible = true;
            this.colTipoR.VisibleIndex = 6;
            this.colTipoR.Width = 84;
            // 
            // colCodigoSAP
            // 
            this.colCodigoSAP.FieldName = "Codigo SAP";
            this.colCodigoSAP.Name = "colCodigoSAP";
            this.colCodigoSAP.OptionsColumn.AllowEdit = false;
            this.colCodigoSAP.Visible = true;
            this.colCodigoSAP.VisibleIndex = 1;
            this.colCodigoSAP.Width = 71;
            // 
            // colFechaCreación
            // 
            this.colFechaCreación.FieldName = "Fecha Creación";
            this.colFechaCreación.Name = "colFechaCreación";
            this.colFechaCreación.OptionsColumn.AllowEdit = false;
            this.colFechaCreación.Visible = true;
            this.colFechaCreación.VisibleIndex = 7;
            this.colFechaCreación.Width = 102;
            // 
            // colCreadopor
            // 
            this.colCreadopor.FieldName = "Creado por";
            this.colCreadopor.Name = "colCreadopor";
            this.colCreadopor.OptionsColumn.AllowEdit = false;
            this.colCreadopor.Visible = true;
            this.colCreadopor.VisibleIndex = 8;
            this.colCreadopor.Width = 74;
            // 
            // colTipoAlimentación
            // 
            this.colTipoAlimentación.FieldName = "Tipo Alimentación";
            this.colTipoAlimentación.Name = "colTipoAlimentación";
            this.colTipoAlimentación.OptionsColumn.AllowEdit = false;
            this.colTipoAlimentación.Visible = true;
            this.colTipoAlimentación.VisibleIndex = 9;
            this.colTipoAlimentación.Width = 98;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(364, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(210, 25);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Listado de Materia Prima";
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdHome.ImageOptions.Image")));
            this.cmdHome.Location = new System.Drawing.Point(855, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(144, 41);
            this.cmdHome.TabIndex = 91;
            this.cmdHome.Text = "Home";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // cmdExcel
            // 
            this.cmdExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExcel.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdExcel.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cmdExcel.Appearance.Options.UseBackColor = true;
            this.cmdExcel.Appearance.Options.UseFont = true;
            this.cmdExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdExcel.ImageOptions.Image")));
            this.cmdExcel.Location = new System.Drawing.Point(722, 12);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.Size = new System.Drawing.Size(127, 41);
            this.cmdExcel.TabIndex = 92;
            this.cmdExcel.Text = "Exportar";
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // frmMateriaPrimaHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 596);
            this.Controls.Add(this.cmdExcel);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMateriaPrimaHome";
            this.Text = "Materia Prima Home";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantoTrazabilidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsMantoTrazabilidad dsMantoTrazabilidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colmaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoF;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoR;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoSAP;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreación;
        private DevExpress.XtraGrid.Columns.GridColumn colCreadopor;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoAlimentación;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.SimpleButton cmdExcel;
    }
}