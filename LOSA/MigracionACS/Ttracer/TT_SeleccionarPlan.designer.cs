namespace LOSA.MigracionACS.Ttracer
{
    partial class TT_SeleccionarPlan
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TT_SeleccionarPlan));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grd_seleccion = new DevExpress.XtraGrid.GridControl();
            this.planselectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSTtracer = new MigracionACS.Ttracer.dSTtracer();
            this.grdv_seleccion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnseleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btncloseplan = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colclose = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_seleccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planselectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_seleccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnseleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncloseplan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.grd_seleccion);
            this.panelControl1.Location = new System.Drawing.Point(4, 52);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1685, 722);
            this.panelControl1.TabIndex = 0;
            // 
            // grd_seleccion
            // 
            this.grd_seleccion.DataSource = this.planselectBindingSource;
            this.grd_seleccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_seleccion.Location = new System.Drawing.Point(2, 2);
            this.grd_seleccion.MainView = this.grdv_seleccion;
            this.grd_seleccion.Name = "grd_seleccion";
            this.grd_seleccion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnseleccionar,
            this.btncloseplan});
            this.grd_seleccion.Size = new System.Drawing.Size(1681, 718);
            this.grd_seleccion.TabIndex = 0;
            this.grd_seleccion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_seleccion});
            // 
            // planselectBindingSource
            // 
            this.planselectBindingSource.DataMember = "planselect";
            this.planselectBindingSource.DataSource = this.dSTtracer;
            // 
            // dSTtracer
            // 
            this.dSTtracer.DataSetName = "dSTtracer";
            this.dSTtracer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_seleccion
            // 
            this.grdv_seleccion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcodigo,
            this.coldate_inicio,
            this.coldate_fin,
            this.colcomment,
            this.colbarco,
            this.colCantidad,
            this.colseleccionar,
            this.colclose});
            this.grdv_seleccion.GridControl = this.grd_seleccion;
            this.grdv_seleccion.Name = "grdv_seleccion";
            this.grdv_seleccion.DoubleClick += new System.EventHandler(this.grdv_seleccion_DoubleClick);
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 1;
            // 
            // coldate_inicio
            // 
            this.coldate_inicio.Caption = "Fecha inicial";
            this.coldate_inicio.FieldName = "date_inicio";
            this.coldate_inicio.Name = "coldate_inicio";
            this.coldate_inicio.OptionsColumn.AllowEdit = false;
            this.coldate_inicio.Visible = true;
            this.coldate_inicio.VisibleIndex = 2;
            // 
            // coldate_fin
            // 
            this.coldate_fin.Caption = "Fecha final";
            this.coldate_fin.FieldName = "date_fin";
            this.coldate_fin.Name = "coldate_fin";
            this.coldate_fin.OptionsColumn.AllowEdit = false;
            this.coldate_fin.Visible = true;
            this.coldate_fin.VisibleIndex = 3;
            // 
            // colcomment
            // 
            this.colcomment.Caption = "Comentario";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.OptionsColumn.AllowEdit = false;
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 4;
            // 
            // colbarco
            // 
            this.colbarco.Caption = "Barco";
            this.colbarco.FieldName = "barco";
            this.colbarco.Name = "colbarco";
            this.colbarco.OptionsColumn.AllowEdit = false;
            this.colbarco.Visible = true;
            this.colbarco.VisibleIndex = 5;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Detalles asignados";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 6;
            // 
            // colseleccionar
            // 
            this.colseleccionar.Caption = "Seleccionar";
            this.colseleccionar.ColumnEdit = this.btnseleccionar;
            this.colseleccionar.Name = "colseleccionar";
            this.colseleccionar.Visible = true;
            this.colseleccionar.VisibleIndex = 7;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnseleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pictureBox1);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.btnclose);
            this.panelControl2.Controls.Add(this.btnmin);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1688, 48);
            this.panelControl2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LOSA.Properties.Resources.LogoLimp_x32;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(73, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(189, 28);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Seleccione un plan";
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(1639, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(46, 35);
            this.btnclose.TabIndex = 1;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.Image = ((System.Drawing.Image)(resources.GetObject("btnmin.Image")));
            this.btnmin.Location = new System.Drawing.Point(1591, 3);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(46, 35);
            this.btnmin.TabIndex = 0;
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl2);
            this.panelControl3.Controls.Add(this.panelControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1692, 775);
            this.panelControl3.TabIndex = 2;
            // 
            // btncloseplan
            // 
            this.btncloseplan.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btncloseplan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btncloseplan.Name = "btncloseplan";
            this.btncloseplan.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btncloseplan.Click += new System.EventHandler(this.btncloseplan_Click);
            // 
            // colclose
            // 
            this.colclose.Caption = "Cerrar";
            this.colclose.ColumnEdit = this.btncloseplan;
            this.colclose.Name = "colclose";
            this.colclose.Visible = true;
            this.colclose.VisibleIndex = 8;
            // 
            // TT_SeleccionarPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 775);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TT_SeleccionarPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TT_SeleccionarPlan";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_seleccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planselectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_seleccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnseleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncloseplan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grd_seleccion;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_seleccion;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnmin;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.BindingSource planselectBindingSource;
        private dSTtracer dSTtracer;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_fin;
        private DevExpress.XtraGrid.Columns.GridColumn colcomment;
        private DevExpress.XtraGrid.Columns.GridColumn colbarco;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnseleccionar;
        private DevExpress.XtraGrid.Columns.GridColumn colclose;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btncloseplan;
    }
}