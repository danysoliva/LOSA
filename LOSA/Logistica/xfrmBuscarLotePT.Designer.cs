
namespace LOSA.Logistica
{
    partial class xfrmBuscarLotePT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmBuscarLotePT));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsLogistica21 = new LOSA.Logistica.dsLogistica2();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFórmula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersión = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrdenFabricaciónCódigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogistica21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "lotes_pt";
            this.gridControl1.DataSource = this.dsLogistica21;
            this.gridControl1.Location = new System.Drawing.Point(1, 50);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(573, 381);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsLogistica21
            // 
            this.dsLogistica21.DataSetName = "dsLogistica2";
            this.dsLogistica21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collote,
            this.colFórmula,
            this.colVersión,
            this.colOrdenFabricaciónCódigo,
            this.colseleccion});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.Visible = true;
            this.collote.VisibleIndex = 0;
            // 
            // colFórmula
            // 
            this.colFórmula.FieldName = "Fórmula";
            this.colFórmula.Name = "colFórmula";
            this.colFórmula.Visible = true;
            this.colFórmula.VisibleIndex = 1;
            // 
            // colVersión
            // 
            this.colVersión.FieldName = "Versión";
            this.colVersión.Name = "colVersión";
            this.colVersión.Visible = true;
            this.colVersión.VisibleIndex = 2;
            // 
            // colOrdenFabricaciónCódigo
            // 
            this.colOrdenFabricaciónCódigo.FieldName = "Orden Fabricación Código";
            this.colOrdenFabricaciónCódigo.Name = "colOrdenFabricaciónCódigo";
            this.colOrdenFabricaciónCódigo.Visible = true;
            this.colOrdenFabricaciónCódigo.VisibleIndex = 3;
            // 
            // colseleccion
            // 
            this.colseleccion.FieldName = "seleccion";
            this.colseleccion.Name = "colseleccion";
            this.colseleccion.Visible = true;
            this.colseleccion.VisibleIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(176, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(215, 21);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Lotes de Producto terminado";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdGuardar.ImageOptions.SvgImage")));
            this.cmdGuardar.Location = new System.Drawing.Point(1, 8);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(141, 40);
            this.cmdGuardar.TabIndex = 117;
            this.cmdGuardar.Text = "Confirmar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
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
            this.btnAtras.Location = new System.Drawing.Point(433, 8);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(141, 40);
            this.btnAtras.TabIndex = 118;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // xfrmBuscarLotePT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 430);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "xfrmBuscarLotePT";
            this.Text = "Lotes PT";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogistica21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsLogistica2 dsLogistica21;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colFórmula;
        private DevExpress.XtraGrid.Columns.GridColumn colVersión;
        private DevExpress.XtraGrid.Columns.GridColumn colOrdenFabricaciónCódigo;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccion;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
    }
}