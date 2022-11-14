
namespace LOSA.TransaccionesPT
{
    partial class frmdespacho_tipo_detalle_carga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdespacho_tipo_detalle_carga));
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPageSeleccion = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.navigationSeleccionEmbalaje = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.cmdImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grdDestinos = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintNormal = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintEmbalaje = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.grdPresentacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.conffilasdestinosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProductos = new LOSA.TransaccionesPT.dsProductos();
            this.presentacionsacosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfactor = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.navigationPageSeleccion.SuspendLayout();
            this.navigationSeleccionEmbalaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDestinos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPresentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conffilasdestinosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionsacosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigationFrame1.Controls.Add(this.navigationPageSeleccion);
            this.navigationFrame1.Controls.Add(this.navigationSeleccionEmbalaje);
            this.navigationFrame1.Location = new System.Drawing.Point(4, 4);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPageSeleccion,
            this.navigationSeleccionEmbalaje});
            this.navigationFrame1.SelectedPage = this.navigationSeleccionEmbalaje;
            this.navigationFrame1.Size = new System.Drawing.Size(568, 202);
            this.navigationFrame1.TabIndex = 12;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // navigationPageSeleccion
            // 
            this.navigationPageSeleccion.Caption = "navigationPage1";
            this.navigationPageSeleccion.Controls.Add(this.btnclose);
            this.navigationPageSeleccion.Controls.Add(this.labelControl1);
            this.navigationPageSeleccion.Controls.Add(this.btnPrintNormal);
            this.navigationPageSeleccion.Controls.Add(this.btnPrintEmbalaje);
            this.navigationPageSeleccion.Name = "navigationPageSeleccion";
            this.navigationPageSeleccion.Size = new System.Drawing.Size(568, 202);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(146, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(222, 21);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Seleccione el tipo de Reporte";
            // 
            // navigationSeleccionEmbalaje
            // 
            this.navigationSeleccionEmbalaje.Controls.Add(this.labelControl3);
            this.navigationSeleccionEmbalaje.Controls.Add(this.grdPresentacion);
            this.navigationSeleccionEmbalaje.Controls.Add(this.cmdImprimir);
            this.navigationSeleccionEmbalaje.Controls.Add(this.simpleButton1);
            this.navigationSeleccionEmbalaje.Controls.Add(this.labelControl2);
            this.navigationSeleccionEmbalaje.Controls.Add(this.grdDestinos);
            this.navigationSeleccionEmbalaje.Name = "navigationSeleccionEmbalaje";
            this.navigationSeleccionEmbalaje.Size = new System.Drawing.Size(568, 202);
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdImprimir.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimir.Appearance.Options.UseFont = true;
            this.cmdImprimir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdImprimir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAplicar.ImageOptions.SvgImage")));
            this.cmdImprimir.Location = new System.Drawing.Point(149, 144);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(104, 35);
            this.cmdImprimir.TabIndex = 14;
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(125, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 21);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Destino:";
            // 
            // grdDestinos
            // 
            this.grdDestinos.EditValue = "";
            this.grdDestinos.Location = new System.Drawing.Point(189, 29);
            this.grdDestinos.Name = "grdDestinos";
            this.grdDestinos.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdDestinos.Properties.Appearance.Options.UseFont = true;
            this.grdDestinos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdDestinos.Properties.DataSource = this.conffilasdestinosBindingSource;
            this.grdDestinos.Properties.DisplayMember = "descripcion";
            this.grdDestinos.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdDestinos.Properties.ValueMember = "id";
            this.grdDestinos.Size = new System.Drawing.Size(260, 28);
            this.grdDestinos.TabIndex = 0;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.colenable});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Appearance.Options.UseFont = true;
            this.btnclose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnclose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.ImageOptions.Image")));
            this.btnclose.Location = new System.Drawing.Point(460, 8);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(99, 47);
            this.btnclose.TabIndex = 15;
            this.btnclose.Text = "Cerrar";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnPrintNormal
            // 
            this.btnPrintNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintNormal.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintNormal.Appearance.Options.UseFont = true;
            this.btnPrintNormal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnPrintNormal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintNormal.ImageOptions.Image")));
            this.btnPrintNormal.Location = new System.Drawing.Point(26, 92);
            this.btnPrintNormal.Name = "btnPrintNormal";
            this.btnPrintNormal.Size = new System.Drawing.Size(248, 47);
            this.btnPrintNormal.TabIndex = 13;
            this.btnPrintNormal.Text = "Detalle de Carga";
            this.btnPrintNormal.Click += new System.EventHandler(this.btnPrintNormal_Click);
            // 
            // btnPrintEmbalaje
            // 
            this.btnPrintEmbalaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintEmbalaje.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrintEmbalaje.Appearance.Options.UseFont = true;
            this.btnPrintEmbalaje.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnPrintEmbalaje.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintEmbalaje.ImageOptions.Image")));
            this.btnPrintEmbalaje.Location = new System.Drawing.Point(299, 92);
            this.btnPrintEmbalaje.Name = "btnPrintEmbalaje";
            this.btnPrintEmbalaje.Size = new System.Drawing.Size(248, 47);
            this.btnPrintEmbalaje.TabIndex = 12;
            this.btnPrintEmbalaje.Text = "Detalle de Carga con Embalaje";
            this.btnPrintEmbalaje.Click += new System.EventHandler(this.btnPrintEmbalaje_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(295, 144);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 35);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "Cerrar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // grdPresentacion
            // 
            this.grdPresentacion.EditValue = "";
            this.grdPresentacion.Location = new System.Drawing.Point(189, 80);
            this.grdPresentacion.Name = "grdPresentacion";
            this.grdPresentacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdPresentacion.Properties.Appearance.Options.UseFont = true;
            this.grdPresentacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdPresentacion.Properties.DataSource = this.presentacionsacosBindingSource;
            this.grdPresentacion.Properties.DisplayMember = "descripcion";
            this.grdPresentacion.Properties.PopupView = this.gridView1;
            this.grdPresentacion.Properties.ValueMember = "id";
            this.grdPresentacion.Size = new System.Drawing.Size(260, 28);
            this.grdPresentacion.TabIndex = 15;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion1,
            this.colid1,
            this.colfactor});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(89, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 21);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Presentacion:";
            // 
            // conffilasdestinosBindingSource
            // 
            this.conffilasdestinosBindingSource.DataMember = "conf_filas_destinos";
            this.conffilasdestinosBindingSource.DataSource = this.dsProductos;
            // 
            // dsProductos
            // 
            this.dsProductos.DataSetName = "dsProductos";
            this.dsProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // presentacionsacosBindingSource
            // 
            this.presentacionsacosBindingSource.DataMember = "presentacion_sacos";
            this.presentacionsacosBindingSource.DataSource = this.dsProductos;
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.Caption = "Presentacion";
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.OptionsColumn.AllowEdit = false;
            // 
            // colfactor
            // 
            this.colfactor.FieldName = "factor";
            this.colfactor.Name = "colfactor";
            // 
            // frmdespacho_tipo_detalle_carga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 209);
            this.ControlBox = false;
            this.Controls.Add(this.navigationFrame1);
            this.Name = "frmdespacho_tipo_detalle_carga";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.navigationPageSeleccion.ResumeLayout(false);
            this.navigationPageSeleccion.PerformLayout();
            this.navigationSeleccionEmbalaje.ResumeLayout(false);
            this.navigationSeleccionEmbalaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDestinos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPresentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conffilasdestinosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionsacosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageSeleccion;
        private DevExpress.XtraEditors.SimpleButton btnPrintNormal;
        private DevExpress.XtraEditors.SimpleButton btnPrintEmbalaje;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationSeleccionEmbalaje;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnclose;
        private DevExpress.XtraEditors.GridLookUpEdit grdDestinos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton cmdImprimir;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource conffilasdestinosBindingSource;
        private dsProductos dsProductos;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit grdPresentacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource presentacionsacosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colfactor;
    }
}