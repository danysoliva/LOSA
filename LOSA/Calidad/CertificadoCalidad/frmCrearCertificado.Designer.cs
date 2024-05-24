
namespace LOSA.Calidad.CertificadoCalidad
{
    partial class frmCrearCertificado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearCertificado));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsCertificado = new LOSA.Calidad.CertificadoCalidad.dsCertificado();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResultado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueLote = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.lotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCertificar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_parametro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_h = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colparametro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmin_plan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmax_plan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colresultaod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colespecificaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCertificado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "Certificado_Preview";
            this.gridControl1.DataSource = this.dsCertificado;
            this.gridControl1.Location = new System.Drawing.Point(-1, 101);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(505, 198);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsCertificado
            // 
            this.dsCertificado.DataSetName = "dsCertificado";
            this.dsCertificado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.TopNewRow.BorderColor = System.Drawing.Color.White;
            this.gridView1.Appearance.TopNewRow.Options.UseBorderColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDato,
            this.colResultado});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            // 
            // colDato
            // 
            this.colDato.FieldName = "Dato";
            this.colDato.Name = "colDato";
            this.colDato.OptionsColumn.AllowMove = false;
            this.colDato.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDato.OptionsColumn.ReadOnly = true;
            this.colDato.OptionsFilter.AllowFilter = false;
            this.colDato.Visible = true;
            this.colDato.VisibleIndex = 0;
            this.colDato.Width = 210;
            // 
            // colResultado
            // 
            this.colResultado.FieldName = "Resultado";
            this.colResultado.Name = "colResultado";
            this.colResultado.OptionsColumn.AllowMove = false;
            this.colResultado.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colResultado.OptionsFilter.AllowFilter = false;
            this.colResultado.Visible = true;
            this.colResultado.VisibleIndex = 1;
            this.colResultado.Width = 236;
            // 
            // lueLote
            // 
            this.lueLote.Location = new System.Drawing.Point(58, 56);
            this.lueLote.Name = "lueLote";
            this.lueLote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueLote.Properties.Appearance.Options.UseFont = true;
            this.lueLote.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLote.Properties.DataSource = this.lotesBindingSource;
            this.lueLote.Properties.DisplayMember = "lote_producto_terminado";
            this.lueLote.Properties.NullText = "";
            this.lueLote.Properties.PopupView = this.searchLookUpEdit1View;
            this.lueLote.Properties.ValueMember = "lote_producto_terminado";
            this.lueLote.Size = new System.Drawing.Size(173, 24);
            this.lueLote.TabIndex = 1;
            this.lueLote.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // lotesBindingSource
            // 
            this.lotesBindingSource.DataMember = "Lotes";
            this.lotesBindingSource.DataSource = this.dsCertificado;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Lote";
            this.gridColumn1.FieldName = "lote_producto_terminado";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Lote:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseBackColor = true;
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(396, 44);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 47);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCertificar
            // 
            this.btnCertificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCertificar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCertificar.Appearance.Options.UseFont = true;
            this.btnCertificar.ImageOptions.Image = global::LOSA.Properties.Resources.certificado_24X24;
            this.btnCertificar.Location = new System.Drawing.Point(287, 44);
            this.btnCertificar.Name = "btnCertificar";
            this.btnCertificar.Size = new System.Drawing.Size(94, 47);
            this.btnCertificar.TabIndex = 4;
            this.btnCertificar.Text = "Certificar";
            this.btnCertificar.Click += new System.EventHandler(this.btnCertificar_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(180, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(128, 21);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Crear Certificado";
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataMember = "Certificado_PT_D";
            this.gridControl2.DataSource = this.dsCertificado;
            this.gridControl2.Location = new System.Drawing.Point(0, 341);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(505, 224);
            this.gridControl2.TabIndex = 6;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.TopNewRow.BorderColor = System.Drawing.Color.White;
            this.gridView2.Appearance.TopNewRow.Options.UseBorderColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_parametro,
            this.colid,
            this.colid_h,
            this.colparametro,
            this.colmin_plan,
            this.colmax_plan,
            this.colresultaod,
            this.colespecificaciones});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanged);
            // 
            // colid_parametro
            // 
            this.colid_parametro.FieldName = "id_parametro";
            this.colid_parametro.Name = "colid_parametro";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_h
            // 
            this.colid_h.FieldName = "id_h";
            this.colid_h.Name = "colid_h";
            // 
            // colparametro
            // 
            this.colparametro.Caption = "Parámetro";
            this.colparametro.FieldName = "parametro";
            this.colparametro.Name = "colparametro";
            this.colparametro.OptionsColumn.ReadOnly = true;
            this.colparametro.OptionsFilter.AllowFilter = false;
            this.colparametro.Visible = true;
            this.colparametro.VisibleIndex = 0;
            // 
            // colmin_plan
            // 
            this.colmin_plan.Caption = "Min. Plan";
            this.colmin_plan.FieldName = "min_plan";
            this.colmin_plan.Name = "colmin_plan";
            this.colmin_plan.OptionsColumn.ReadOnly = true;
            this.colmin_plan.OptionsFilter.AllowFilter = false;
            this.colmin_plan.Visible = true;
            this.colmin_plan.VisibleIndex = 1;
            // 
            // colmax_plan
            // 
            this.colmax_plan.Caption = "Max Plan";
            this.colmax_plan.FieldName = "max_plan";
            this.colmax_plan.Name = "colmax_plan";
            this.colmax_plan.OptionsColumn.ReadOnly = true;
            this.colmax_plan.OptionsFilter.AllowFilter = false;
            this.colmax_plan.Visible = true;
            this.colmax_plan.VisibleIndex = 2;
            // 
            // colresultaod
            // 
            this.colresultaod.Caption = "Resultado";
            this.colresultaod.FieldName = "resultaod";
            this.colresultaod.Name = "colresultaod";
            this.colresultaod.OptionsFilter.AllowFilter = false;
            this.colresultaod.Visible = true;
            this.colresultaod.VisibleIndex = 3;
            // 
            // colespecificaciones
            // 
            this.colespecificaciones.Caption = "Especificaciones";
            this.colespecificaciones.FieldName = "especificaciones";
            this.colespecificaciones.Name = "colespecificaciones";
            this.colespecificaciones.OptionsColumn.ReadOnly = true;
            this.colespecificaciones.OptionsFilter.AllowFilter = false;
            this.colespecificaciones.Visible = true;
            this.colespecificaciones.VisibleIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(0, 315);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(505, 17);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Detalle";
            // 
            // frmCrearCertificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 564);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnCertificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lueLote);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCrearCertificado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Certificado";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCertificado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private dsCertificado dsCertificado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDato;
        private DevExpress.XtraGrid.Columns.GridColumn colResultado;
        private DevExpress.XtraEditors.SearchLookUpEdit lueLote;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnCertificar;
        private System.Windows.Forms.BindingSource lotesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colid_parametro;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_h;
        private DevExpress.XtraGrid.Columns.GridColumn colparametro;
        private DevExpress.XtraGrid.Columns.GridColumn colmin_plan;
        private DevExpress.XtraGrid.Columns.GridColumn colmax_plan;
        private DevExpress.XtraGrid.Columns.GridColumn colresultaod;
        private DevExpress.XtraGrid.Columns.GridColumn colespecificaciones;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}