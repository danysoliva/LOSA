
namespace LOSA.Calidad
{
    partial class frmVerHistorialEstadoTarima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerHistorialEstadoTarima));
            this.gridHistorialTarima = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.dsCalidad1 = new LOSA.Calidad.dsCalidad();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tarima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado_old = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_old = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado_new = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_new = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_modificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistorialTarima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalidad1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridHistorialTarima
            // 
            this.gridHistorialTarima.DataMember = "historialestados";
            this.gridHistorialTarima.DataSource = this.dsCalidad1;
            this.gridHistorialTarima.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridHistorialTarima.Location = new System.Drawing.Point(0, 86);
            this.gridHistorialTarima.MainView = this.gridView1;
            this.gridHistorialTarima.Name = "gridHistorialTarima";
            this.gridHistorialTarima.Size = new System.Drawing.Size(756, 389);
            this.gridHistorialTarima.TabIndex = 0;
            this.gridHistorialTarima.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_tarima,
            this.colid_estado_old,
            this.colestado_old,
            this.colid_estado_new,
            this.colestado_new,
            this.colfecha_modificacion,
            this.coluser_id,
            this.colusuario});
            this.gridView1.GridControl = this.gridHistorialTarima;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(624, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(120, 46);
            this.btnAtras.TabIndex = 116;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // dsCalidad1
            // 
            this.dsCalidad1.DataSetName = "dsCalidad";
            this.dsCalidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colid_tarima
            // 
            this.colid_tarima.FieldName = "id_tarima";
            this.colid_tarima.Name = "colid_tarima";
            this.colid_tarima.OptionsColumn.AllowEdit = false;
            // 
            // colid_estado_old
            // 
            this.colid_estado_old.FieldName = "id_estado_old";
            this.colid_estado_old.Name = "colid_estado_old";
            this.colid_estado_old.OptionsColumn.AllowEdit = false;
            // 
            // colestado_old
            // 
            this.colestado_old.FieldName = "estado_old";
            this.colestado_old.Name = "colestado_old";
            this.colestado_old.OptionsColumn.AllowEdit = false;
            this.colestado_old.Visible = true;
            this.colestado_old.VisibleIndex = 0;
            // 
            // colid_estado_new
            // 
            this.colid_estado_new.FieldName = "id_estado_new";
            this.colid_estado_new.Name = "colid_estado_new";
            this.colid_estado_new.OptionsColumn.AllowEdit = false;
            // 
            // colestado_new
            // 
            this.colestado_new.FieldName = "estado_new";
            this.colestado_new.Name = "colestado_new";
            this.colestado_new.OptionsColumn.AllowEdit = false;
            this.colestado_new.Visible = true;
            this.colestado_new.VisibleIndex = 1;
            // 
            // colfecha_modificacion
            // 
            this.colfecha_modificacion.DisplayFormat.FormatString = "f";
            this.colfecha_modificacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_modificacion.FieldName = "fecha_modificacion";
            this.colfecha_modificacion.Name = "colfecha_modificacion";
            this.colfecha_modificacion.OptionsColumn.AllowEdit = false;
            this.colfecha_modificacion.Visible = true;
            this.colfecha_modificacion.VisibleIndex = 2;
            // 
            // coluser_id
            // 
            this.coluser_id.FieldName = "user_id";
            this.coluser_id.Name = "coluser_id";
            this.coluser_id.OptionsColumn.AllowEdit = false;
            // 
            // colusuario
            // 
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.OptionsColumn.AllowEdit = false;
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 3;
            // 
            // frmVerHistorialEstadoTarima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 475);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gridHistorialTarima);
            this.Name = "frmVerHistorialEstadoTarima";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.gridHistorialTarima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalidad1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridHistorialTarima;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private dsCalidad dsCalidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tarima;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado_old;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_old;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado_new;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_new;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_modificacion;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_id;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
    }
}