
namespace LOSA.TransaccionesMP.Liquidos
{
    partial class frmBinesEnPRD
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
            this.dsTransaccionesMP1 = new LOSA.TransaccionesMP.dsTransaccionesMP();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.colPendienteAsignacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tarima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado_tarima = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsTransaccionesMP1
            // 
            this.dsTransaccionesMP1.DataSetName = "dsTransaccionesMP";
            this.dsTransaccionesMP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "bines_disponibles";
            this.gridControl1.DataSource = this.dsTransaccionesMP1;
            this.gridControl1.Location = new System.Drawing.Point(2, 94);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(671, 393);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPendienteAsignacion,
            this.colnombre_comercial,
            this.colcodigo_barra,
            this.colid_tarima,
            this.colid_estado_tarima});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(2, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(338, 29);
            this.labelControl3.TabIndex = 103;
            this.labelControl3.Text = "Detalle de Bines en Producción";
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(498, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(175, 48);
            this.cmdHome.TabIndex = 104;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // colPendienteAsignacion
            // 
            this.colPendienteAsignacion.FieldName = "PendienteAsignacion";
            this.colPendienteAsignacion.Name = "colPendienteAsignacion";
            this.colPendienteAsignacion.OptionsColumn.AllowEdit = false;
            this.colPendienteAsignacion.Visible = true;
            this.colPendienteAsignacion.VisibleIndex = 0;
            // 
            // colnombre_comercial
            // 
            this.colnombre_comercial.Caption = "Materia Prima";
            this.colnombre_comercial.FieldName = "nombre_comercial";
            this.colnombre_comercial.Name = "colnombre_comercial";
            this.colnombre_comercial.OptionsColumn.AllowEdit = false;
            this.colnombre_comercial.Visible = true;
            this.colnombre_comercial.VisibleIndex = 1;
            // 
            // colcodigo_barra
            // 
            this.colcodigo_barra.Caption = "Código Barra";
            this.colcodigo_barra.FieldName = "codigo_barra";
            this.colcodigo_barra.Name = "colcodigo_barra";
            this.colcodigo_barra.OptionsColumn.AllowEdit = false;
            this.colcodigo_barra.Visible = true;
            this.colcodigo_barra.VisibleIndex = 2;
            // 
            // colid_tarima
            // 
            this.colid_tarima.FieldName = "id_tarima";
            this.colid_tarima.Name = "colid_tarima";
            // 
            // colid_estado_tarima
            // 
            this.colid_estado_tarima.FieldName = "id_estado_tarima";
            this.colid_estado_tarima.Name = "colid_estado_tarima";
            // 
            // frmBinesEnPRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 489);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmBinesEnPRD";
            this.Text = "Bines En PRD";
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsTransaccionesMP dsTransaccionesMP1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraGrid.Columns.GridColumn colPendienteAsignacion;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tarima;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado_tarima;
    }
}