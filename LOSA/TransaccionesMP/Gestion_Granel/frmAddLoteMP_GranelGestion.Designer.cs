
namespace LOSA.TransaccionesMP.Gestion_Granel
{
    partial class frmAddLoteMP_GranelGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddLoteMP_GranelGestion));
            this.dsGestionGranel1 = new LOSA.TransaccionesMP.Gestion_Granel.dsGestionGranel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colexistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia_ud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia_tm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colwhs_equivalente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdConfirma = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dsGestionGranel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsGestionGranel1
            // 
            this.dsGestionGranel1.DataSetName = "dsGestionGranel";
            this.dsGestionGranel1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "seleccion_lote";
            this.gridControl1.DataSource = this.dsGestionGranel1;
            this.gridControl1.Location = new System.Drawing.Point(3, 109);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1482, 781);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colexistencia,
            this.colexistencia_ud,
            this.colexistencia_tm,
            this.colnombre_comercial,
            this.colid_mp,
            this.colcode_sap,
            this.colwhs_equivalente,
            this.collote,
            this.colid_bodega,
            this.colSeleccionado});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            // 
            // colexistencia
            // 
            this.colexistencia.FieldName = "existencia";
            this.colexistencia.MinWidth = 40;
            this.colexistencia.Name = "colexistencia";
            this.colexistencia.OptionsColumn.ReadOnly = true;
            this.colexistencia.Visible = true;
            this.colexistencia.VisibleIndex = 0;
            this.colexistencia.Width = 150;
            // 
            // colexistencia_ud
            // 
            this.colexistencia_ud.FieldName = "existencia_ud";
            this.colexistencia_ud.MinWidth = 40;
            this.colexistencia_ud.Name = "colexistencia_ud";
            this.colexistencia_ud.OptionsColumn.ReadOnly = true;
            this.colexistencia_ud.Visible = true;
            this.colexistencia_ud.VisibleIndex = 1;
            this.colexistencia_ud.Width = 150;
            // 
            // colexistencia_tm
            // 
            this.colexistencia_tm.FieldName = "existencia_tm";
            this.colexistencia_tm.MinWidth = 40;
            this.colexistencia_tm.Name = "colexistencia_tm";
            this.colexistencia_tm.OptionsColumn.ReadOnly = true;
            this.colexistencia_tm.Visible = true;
            this.colexistencia_tm.VisibleIndex = 2;
            this.colexistencia_tm.Width = 150;
            // 
            // colnombre_comercial
            // 
            this.colnombre_comercial.FieldName = "nombre_comercial";
            this.colnombre_comercial.MinWidth = 40;
            this.colnombre_comercial.Name = "colnombre_comercial";
            this.colnombre_comercial.OptionsColumn.ReadOnly = true;
            this.colnombre_comercial.Visible = true;
            this.colnombre_comercial.VisibleIndex = 3;
            this.colnombre_comercial.Width = 150;
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.MinWidth = 40;
            this.colid_mp.Name = "colid_mp";
            this.colid_mp.OptionsColumn.ReadOnly = true;
            this.colid_mp.Width = 150;
            // 
            // colcode_sap
            // 
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.MinWidth = 40;
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.ReadOnly = true;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 4;
            this.colcode_sap.Width = 150;
            // 
            // colwhs_equivalente
            // 
            this.colwhs_equivalente.FieldName = "whs_equivalente";
            this.colwhs_equivalente.MinWidth = 40;
            this.colwhs_equivalente.Name = "colwhs_equivalente";
            this.colwhs_equivalente.OptionsColumn.ReadOnly = true;
            this.colwhs_equivalente.Visible = true;
            this.colwhs_equivalente.VisibleIndex = 5;
            this.colwhs_equivalente.Width = 150;
            // 
            // collote
            // 
            this.collote.FieldName = "lote";
            this.collote.MinWidth = 40;
            this.collote.Name = "collote";
            this.collote.OptionsColumn.ReadOnly = true;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 6;
            this.collote.Width = 150;
            // 
            // colid_bodega
            // 
            this.colid_bodega.FieldName = "id_bodega";
            this.colid_bodega.MinWidth = 40;
            this.colid_bodega.Name = "colid_bodega";
            this.colid_bodega.OptionsColumn.ReadOnly = true;
            this.colid_bodega.Width = 150;
            // 
            // colSeleccionado
            // 
            this.colSeleccionado.FieldName = "Seleccionado";
            this.colSeleccionado.MinWidth = 40;
            this.colSeleccionado.Name = "colSeleccionado";
            this.colSeleccionado.Visible = true;
            this.colSeleccionado.VisibleIndex = 7;
            this.colSeleccionado.Width = 150;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(519, 40);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Seleccione el lote para agregar a la cola";
            // 
            // cmdConfirma
            // 
            this.cmdConfirma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdConfirma.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConfirma.Appearance.Options.UseFont = true;
            this.cmdConfirma.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdConfirma.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdConfirma.ImageOptions.SvgImage")));
            this.cmdConfirma.Location = new System.Drawing.Point(893, 15);
            this.cmdConfirma.Margin = new System.Windows.Forms.Padding(6);
            this.cmdConfirma.Name = "cmdConfirma";
            this.cmdConfirma.Size = new System.Drawing.Size(290, 88);
            this.cmdConfirma.TabIndex = 5;
            this.cmdConfirma.Text = "Confirmar";
            this.cmdConfirma.Click += new System.EventHandler(this.cmdConfirma_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdCerrar.ImageOptions.SvgImage")));
            this.cmdCerrar.Location = new System.Drawing.Point(1195, 15);
            this.cmdCerrar.Margin = new System.Windows.Forms.Padding(6);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(290, 88);
            this.cmdCerrar.TabIndex = 6;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // frmAddLoteMP_GranelGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 896);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdConfirma);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmAddLoteMP_GranelGestion";
            this.Text = "Adicionar Lote MP Granel";
            ((System.ComponentModel.ISupportInitialize)(this.dsGestionGranel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsGestionGranel dsGestionGranel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia_ud;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia_tm;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap;
        private DevExpress.XtraGrid.Columns.GridColumn colwhs_equivalente;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colid_bodega;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionado;
        private DevExpress.XtraEditors.SimpleButton cmdConfirma;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
    }
}