
namespace LOSA.Calidad
{
    partial class frmBuscarDatosBascula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarDatosBascula));
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.dsTarima1 = new LOSA.TransaccionesMP.dsTarima();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_in = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTarima1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl3
            // 
            this.gridControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl3.DataMember = "ultimas_cargasSelect";
            this.gridControl3.DataSource = this.dsTarima1;
            this.gridControl3.Location = new System.Drawing.Point(1, 2);
            this.gridControl3.MainView = this.gridView6;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(499, 215);
            this.gridControl3.TabIndex = 89;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            // 
            // dsTarima1
            // 
            this.dsTarima1.DataSetName = "dsTarima";
            this.dsTarima1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion5,
            this.colfecha_in,
            this.colRow});
            this.gridView6.GridControl = this.gridControl3;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsView.ShowAutoFilterRow = true;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            this.gridView6.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView6_RowStyle);
            // 
            // coldescripcion5
            // 
            this.coldescripcion5.Caption = "Descripción";
            this.coldescripcion5.FieldName = "descripcion";
            this.coldescripcion5.Name = "coldescripcion5";
            this.coldescripcion5.OptionsColumn.AllowEdit = false;
            this.coldescripcion5.Visible = true;
            this.coldescripcion5.VisibleIndex = 2;
            this.coldescripcion5.Width = 334;
            // 
            // colfecha_in
            // 
            this.colfecha_in.DisplayFormat.FormatString = "g";
            this.colfecha_in.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_in.FieldName = "fecha_in";
            this.colfecha_in.Name = "colfecha_in";
            this.colfecha_in.OptionsColumn.AllowEdit = false;
            this.colfecha_in.Visible = true;
            this.colfecha_in.VisibleIndex = 1;
            this.colfecha_in.Width = 110;
            // 
            // colRow
            // 
            this.colRow.FieldName = "Row";
            this.colRow.Name = "colRow";
            this.colRow.OptionsColumn.AllowEdit = false;
            this.colRow.Visible = true;
            this.colRow.VisibleIndex = 0;
            this.colRow.Width = 37;
            // 
            // cmdAplicar
            // 
            this.cmdAplicar.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAplicar.Appearance.Options.UseFont = true;
            this.cmdAplicar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAplicar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAplicar.ImageOptions.Image")));
            this.cmdAplicar.Location = new System.Drawing.Point(141, 223);
            this.cmdAplicar.Name = "cmdAplicar";
            this.cmdAplicar.Size = new System.Drawing.Size(106, 41);
            this.cmdAplicar.TabIndex = 90;
            this.cmdAplicar.Text = "Aplicar";
            this.cmdAplicar.Click += new System.EventHandler(this.cmdAplicar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Appearance.Options.UseFont = true;
            this.cmdCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.ImageOptions.Image")));
            this.cmdCancelar.Location = new System.Drawing.Point(253, 223);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(106, 41);
            this.cmdCancelar.TabIndex = 91;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // frmBuscarDatosBascula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 269);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdAplicar);
            this.Controls.Add(this.gridControl3);
            this.Name = "frmBuscarDatosBascula";
            this.Text = "Seleccionar los ultimos 3 ingresos";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTarima1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion5;
        private DevExpress.XtraEditors.SimpleButton cmdAplicar;
        private DevExpress.XtraEditors.SimpleButton cmdCancelar;
        private TransaccionesMP.dsTarima dsTarima1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_in;
        private DevExpress.XtraGrid.Columns.GridColumn colRow;
    }
}