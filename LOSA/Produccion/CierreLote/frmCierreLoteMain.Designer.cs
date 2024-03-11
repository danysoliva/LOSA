
namespace LOSA.Produccion.CierreLote
{
    partial class frmCierreLoteMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCierreLoteMain));
            this.gridListaMain = new DevExpress.XtraGrid.GridControl();
            this.dsCierreLotesPT1 = new LOSA.Produccion.CierreLote.dsCierreLotesPT();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_cierre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado_cierre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCierreLotesPT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridListaMain
            // 
            this.gridListaMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridListaMain.DataMember = "cierres_main";
            this.gridListaMain.DataSource = this.dsCierreLotesPT1;
            this.gridListaMain.Location = new System.Drawing.Point(3, 76);
            this.gridListaMain.MainView = this.gridView1;
            this.gridListaMain.Name = "gridListaMain";
            this.gridListaMain.Size = new System.Drawing.Size(795, 373);
            this.gridListaMain.TabIndex = 0;
            this.gridListaMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsCierreLotesPT1
            // 
            this.dsCierreLotesPT1.DataSetName = "dsCierreLotesPT";
            this.dsCierreLotesPT1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_cierre,
            this.collote_pt,
            this.colenable,
            this.colfecha,
            this.colid_usuario,
            this.colid_estado_cierre,
            this.colestado_name,
            this.colusuario_name});
            this.gridView1.GridControl = this.gridListaMain;
            this.gridView1.Name = "gridView1";
            // 
            // colid_cierre
            // 
            this.colid_cierre.FieldName = "id_cierre";
            this.colid_cierre.Name = "colid_cierre";
            this.colid_cierre.OptionsColumn.ReadOnly = true;
            this.colid_cierre.Visible = true;
            this.colid_cierre.VisibleIndex = 0;
            // 
            // collote_pt
            // 
            this.collote_pt.FieldName = "lote_pt";
            this.collote_pt.Name = "collote_pt";
            this.collote_pt.OptionsColumn.ReadOnly = true;
            this.collote_pt.Visible = true;
            this.collote_pt.VisibleIndex = 1;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.ReadOnly = true;
            // 
            // colfecha
            // 
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
            // 
            // colid_usuario
            // 
            this.colid_usuario.FieldName = "id_usuario";
            this.colid_usuario.Name = "colid_usuario";
            this.colid_usuario.OptionsColumn.ReadOnly = true;
            // 
            // colid_estado_cierre
            // 
            this.colid_estado_cierre.FieldName = "id_estado_cierre";
            this.colid_estado_cierre.Name = "colid_estado_cierre";
            this.colid_estado_cierre.OptionsColumn.ReadOnly = true;
            // 
            // colestado_name
            // 
            this.colestado_name.FieldName = "estado_name";
            this.colestado_name.Name = "colestado_name";
            this.colestado_name.OptionsColumn.ReadOnly = true;
            this.colestado_name.Visible = true;
            this.colestado_name.VisibleIndex = 3;
            // 
            // colusuario_name
            // 
            this.colusuario_name.FieldName = "usuario_name";
            this.colusuario_name.Name = "colusuario_name";
            this.colusuario_name.OptionsColumn.ReadOnly = true;
            this.colusuario_name.Visible = true;
            this.colusuario_name.VisibleIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(233, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(299, 25);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Cierre de Lote Producto Terminado";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Bisque;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 26);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(116, 39);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Nuevo";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdCerrar.ImageOptions.SvgImage")));
            this.cmdCerrar.Location = new System.Drawing.Point(672, 26);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(116, 39);
            this.cmdCerrar.TabIndex = 3;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // frmCierreLoteMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridListaMain);
            this.Name = "frmCierreLoteMain";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.gridListaMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCierreLotesPT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridListaMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private dsCierreLotesPT dsCierreLotesPT1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cierre;
        private DevExpress.XtraGrid.Columns.GridColumn collote_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado_cierre;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_name;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_name;
    }
}