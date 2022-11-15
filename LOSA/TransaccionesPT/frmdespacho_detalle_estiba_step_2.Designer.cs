
namespace LOSA.TransaccionesPT
{
    partial class frmdespacho_detalle_estiba_step_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdespacho_detalle_estiba_step_2));
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tsTipo = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grdPresentacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmdImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grdDestinos = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dsProductos = new LOSA.TransaccionesPT.dsProductos();
            this.presentacionfilasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conffilasdestinosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_fila1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsacos_por_fila = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestiba_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldestino_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_fila = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tsTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPresentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDestinos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionfilasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conffilasdestinosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(122, 63);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 21);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Tipo Estiba:";
            // 
            // tsTipo
            // 
            this.tsTipo.EditValue = true;
            this.tsTipo.Location = new System.Drawing.Point(206, 58);
            this.tsTipo.Name = "tsTipo";
            this.tsTipo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsTipo.Properties.Appearance.Options.UseFont = true;
            this.tsTipo.Properties.OffText = "Granel";
            this.tsTipo.Properties.OnText = "Embalado";
            this.tsTipo.Size = new System.Drawing.Size(260, 32);
            this.tsTipo.TabIndex = 25;
            this.tsTipo.Toggled += new System.EventHandler(this.tsTipo_Toggled);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(108, 23);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 21);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Presentacion:";
            // 
            // grdPresentacion
            // 
            this.grdPresentacion.EditValue = "";
            this.grdPresentacion.Enabled = false;
            this.grdPresentacion.Location = new System.Drawing.Point(206, 20);
            this.grdPresentacion.Name = "grdPresentacion";
            this.grdPresentacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdPresentacion.Properties.Appearance.Options.UseFont = true;
            this.grdPresentacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdPresentacion.Properties.DataSource = this.presentacionfilasBindingSource;
            this.grdPresentacion.Properties.DisplayMember = "presentacion";
            this.grdPresentacion.Properties.PopupView = this.gridView1;
            this.grdPresentacion.Properties.ValueMember = "id_presentacion";
            this.grdPresentacion.Size = new System.Drawing.Size(260, 28);
            this.grdPresentacion.TabIndex = 23;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_presentacion,
            this.colpresentacion,
            this.colcant_fila});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdImprimir.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimir.Appearance.Options.UseFont = true;
            this.cmdImprimir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdImprimir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdImprimir.ImageOptions.SvgImage")));
            this.cmdImprimir.Location = new System.Drawing.Point(166, 154);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(104, 35);
            this.cmdImprimir.TabIndex = 22;
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(312, 154);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 35);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "Cerrar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(144, 105);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 21);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Destino:";
            // 
            // grdDestinos
            // 
            this.grdDestinos.EditValue = "";
            this.grdDestinos.Location = new System.Drawing.Point(205, 102);
            this.grdDestinos.Name = "grdDestinos";
            this.grdDestinos.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdDestinos.Properties.Appearance.Options.UseFont = true;
            this.grdDestinos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdDestinos.Properties.DataSource = this.conffilasdestinosBindingSource;
            this.grdDestinos.Properties.DisplayMember = "destino";
            this.grdDestinos.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdDestinos.Properties.ValueMember = "destino_id";
            this.grdDestinos.Size = new System.Drawing.Size(261, 28);
            this.grdDestinos.TabIndex = 19;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldestino,
            this.colcant_fila1,
            this.colsacos_por_fila,
            this.colestiba_id,
            this.colenable,
            this.coldestino_id});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // dsProductos
            // 
            this.dsProductos.DataSetName = "dsProductos";
            this.dsProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // presentacionfilasBindingSource
            // 
            this.presentacionfilasBindingSource.DataMember = "presentacion_filas";
            this.presentacionfilasBindingSource.DataSource = this.dsProductos;
            // 
            // conffilasdestinosBindingSource
            // 
            this.conffilasdestinosBindingSource.DataMember = "conf_filas_destinos";
            this.conffilasdestinosBindingSource.DataSource = this.dsProductos;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // coldestino
            // 
            this.coldestino.FieldName = "destino";
            this.coldestino.Name = "coldestino";
            this.coldestino.Visible = true;
            this.coldestino.VisibleIndex = 1;
            // 
            // colcant_fila1
            // 
            this.colcant_fila1.FieldName = "cant_fila";
            this.colcant_fila1.Name = "colcant_fila1";
            this.colcant_fila1.Visible = true;
            this.colcant_fila1.VisibleIndex = 2;
            // 
            // colsacos_por_fila
            // 
            this.colsacos_por_fila.FieldName = "sacos_por_fila";
            this.colsacos_por_fila.Name = "colsacos_por_fila";
            this.colsacos_por_fila.Visible = true;
            this.colsacos_por_fila.VisibleIndex = 3;
            // 
            // colestiba_id
            // 
            this.colestiba_id.FieldName = "estiba_id";
            this.colestiba_id.Name = "colestiba_id";
            this.colestiba_id.Visible = true;
            this.colestiba_id.VisibleIndex = 4;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.Visible = true;
            this.colenable.VisibleIndex = 5;
            // 
            // coldestino_id
            // 
            this.coldestino_id.FieldName = "destino_id";
            this.coldestino_id.Name = "coldestino_id";
            this.coldestino_id.Visible = true;
            this.coldestino_id.VisibleIndex = 6;
            // 
            // colid_presentacion
            // 
            this.colid_presentacion.FieldName = "id_presentacion";
            this.colid_presentacion.Name = "colid_presentacion";
            this.colid_presentacion.Visible = true;
            this.colid_presentacion.VisibleIndex = 0;
            // 
            // colpresentacion
            // 
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 1;
            // 
            // colcant_fila
            // 
            this.colcant_fila.FieldName = "cant_fila";
            this.colcant_fila.Name = "colcant_fila";
            this.colcant_fila.Visible = true;
            this.colcant_fila.VisibleIndex = 2;
            // 
            // frmdespacho_detalle_estiba_step_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 209);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.tsTipo);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.grdPresentacion);
            this.Controls.Add(this.cmdImprimir);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.grdDestinos);
            this.Name = "frmdespacho_detalle_estiba_step_2";
            this.Text = "frmdespacho_detalle_estiba_step_2";
            ((System.ComponentModel.ISupportInitialize)(this.tsTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPresentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDestinos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionfilasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conffilasdestinosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ToggleSwitch tsTipo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit grdPresentacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton cmdImprimir;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit grdDestinos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource presentacionfilasBindingSource;
        private dsProductos dsProductos;
        private DevExpress.XtraGrid.Columns.GridColumn colid_presentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_fila;
        private System.Windows.Forms.BindingSource conffilasdestinosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldestino;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_fila1;
        private DevExpress.XtraGrid.Columns.GridColumn colsacos_por_fila;
        private DevExpress.XtraGrid.Columns.GridColumn colestiba_id;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn coldestino_id;
    }
}