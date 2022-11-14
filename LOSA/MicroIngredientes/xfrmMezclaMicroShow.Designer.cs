
namespace LOSA.MicroIngredientes
{
    partial class xfrmMezclaMicroShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmMezclaMicroShow));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsReportesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReportes = new LOSA.Reportes.dsReportes();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAMI_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tarima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_sacos_seleccionados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colset_point = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_batch_seleccionados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_ingrediente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_x_batch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltolva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "detalle_rpt_micros";
            this.gridControl1.DataSource = this.dsReportesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1135, 204);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsReportesBindingSource
            // 
            this.dsReportesBindingSource.DataSource = this.dsReportes;
            this.dsReportesBindingSource.Position = 0;
            // 
            // dsReportes
            // 
            this.dsReportes.DataSetName = "dsReportes";
            this.dsReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Empty.Options.UseFont = true;
            this.gridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colAMI_ID,
            this.collote,
            this.colid_tarima,
            this.colcant_sacos_seleccionados,
            this.colset_point,
            this.colcant_batch_seleccionados,
            this.colnombre_ingrediente,
            this.colcant_x_batch,
            this.colfecha_vencimiento,
            this.colnumero_transaccion,
            this.coltolva,
            this.colreal});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colAMI_ID
            // 
            this.colAMI_ID.FieldName = "AMI_ID";
            this.colAMI_ID.Name = "colAMI_ID";
            this.colAMI_ID.Width = 57;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.Visible = true;
            this.collote.VisibleIndex = 2;
            this.collote.Width = 183;
            // 
            // colid_tarima
            // 
            this.colid_tarima.FieldName = "id_tarima";
            this.colid_tarima.Name = "colid_tarima";
            // 
            // colcant_sacos_seleccionados
            // 
            this.colcant_sacos_seleccionados.FieldName = "cant_sacos_seleccionados";
            this.colcant_sacos_seleccionados.Name = "colcant_sacos_seleccionados";
            this.colcant_sacos_seleccionados.Width = 107;
            // 
            // colset_point
            // 
            this.colset_point.Caption = "Kg por Batch";
            this.colset_point.FieldName = "set_point";
            this.colset_point.Name = "colset_point";
            this.colset_point.Visible = true;
            this.colset_point.VisibleIndex = 4;
            this.colset_point.Width = 160;
            // 
            // colcant_batch_seleccionados
            // 
            this.colcant_batch_seleccionados.FieldName = "cant_batch_seleccionados";
            this.colcant_batch_seleccionados.Name = "colcant_batch_seleccionados";
            this.colcant_batch_seleccionados.Width = 40;
            // 
            // colnombre_ingrediente
            // 
            this.colnombre_ingrediente.Caption = "Nombre de Micro";
            this.colnombre_ingrediente.FieldName = "nombre_ingrediente";
            this.colnombre_ingrediente.Name = "colnombre_ingrediente";
            this.colnombre_ingrediente.Visible = true;
            this.colnombre_ingrediente.VisibleIndex = 0;
            this.colnombre_ingrediente.Width = 262;
            // 
            // colcant_x_batch
            // 
            this.colcant_x_batch.FieldName = "cant_x_batch";
            this.colcant_x_batch.Name = "colcant_x_batch";
            this.colcant_x_batch.Width = 40;
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.Caption = "Fecha Vencimiento";
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.Visible = true;
            this.colfecha_vencimiento.VisibleIndex = 3;
            this.colfecha_vencimiento.Width = 219;
            // 
            // colnumero_transaccion
            // 
            this.colnumero_transaccion.Caption = "# Ingreso";
            this.colnumero_transaccion.FieldName = "numero_transaccion";
            this.colnumero_transaccion.Name = "colnumero_transaccion";
            this.colnumero_transaccion.Visible = true;
            this.colnumero_transaccion.VisibleIndex = 1;
            this.colnumero_transaccion.Width = 146;
            // 
            // coltolva
            // 
            this.coltolva.FieldName = "tolva";
            this.coltolva.Name = "coltolva";
            this.coltolva.Width = 40;
            // 
            // colreal
            // 
            this.colreal.Caption = "Total Kg";
            this.colreal.FieldName = "real";
            this.colreal.Name = "colreal";
            this.colreal.Visible = true;
            this.colreal.VisibleIndex = 5;
            this.colreal.Width = 147;
            // 
            // btnSalir
            // 
            this.btnSalir.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Appearance.Options.UseBackColor = true;
            this.btnSalir.Appearance.Options.UseFont = true;
            this.btnSalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSalir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnSalir.Location = new System.Drawing.Point(1022, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 37);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(0, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1135, 25);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mezcla de Micro Ingredientes";
            // 
            // xfrmMezclaMicroShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 247);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfrmMezclaMicroShow";
            this.Text = "Mezcla de Micro Ingrediente";
            this.Load += new System.EventHandler(this.xfrmMezclaMicroShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dsReportesBindingSource;
        private LOSA.Reportes.dsReportes dsReportes;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colAMI_ID;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tarima;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_sacos_seleccionados;
        private DevExpress.XtraGrid.Columns.GridColumn colset_point;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_batch_seleccionados;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_ingrediente;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_x_batch;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn coltolva;
        private DevExpress.XtraGrid.Columns.GridColumn colreal;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}