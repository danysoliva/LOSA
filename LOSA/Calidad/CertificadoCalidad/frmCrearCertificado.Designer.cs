
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCertificar = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCertificado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
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
            this.gridControl1.Size = new System.Drawing.Size(505, 195);
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
            this.colResultado.OptionsColumn.ReadOnly = true;
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
            this.lueLote.Size = new System.Drawing.Size(150, 24);
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
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Lote";
            this.gridColumn1.FieldName = "lote_producto_terminado";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
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
            // frmCrearCertificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 297);
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
    }
}