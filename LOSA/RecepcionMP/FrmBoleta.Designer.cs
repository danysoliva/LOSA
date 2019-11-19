namespace LOSA.RecepcionMP
{
    partial class FrmBoleta
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.basculaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsRecepcionMP = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.gvBascula = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNBoleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidtipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestadoDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.basculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basculaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBascula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basculaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.basculaBindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(0, 103);
            this.gridControl1.MainView = this.gvBascula;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSeleccionar});
            this.gridControl1.Size = new System.Drawing.Size(622, 418);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBascula});
            // 
            // basculaBindingSource1
            // 
            this.basculaBindingSource1.DataMember = "Bascula";
            this.basculaBindingSource1.DataSource = this.dsRecepcionMP;
            // 
            // dsRecepcionMP
            // 
            this.dsRecepcionMP.DataSetName = "dsRecepcionMP";
            this.dsRecepcionMP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvBascula
            // 
            this.gvBascula.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gvBascula.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvBascula.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvBascula.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gvBascula.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvBascula.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvBascula.Appearance.FocusedRow.Options.UseFont = true;
            this.gvBascula.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvBascula.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvBascula.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvBascula.Appearance.Row.Options.UseFont = true;
            this.gvBascula.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvBascula.Appearance.SelectedRow.Options.UseFont = true;
            this.gvBascula.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvBascula.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvBascula.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDSerie,
            this.colNBoleta,
            this.colDescripcion,
            this.colidtipo,
            this.colestado,
            this.colestadoDescripcion,
            this.colSeleccionar});
            this.gvBascula.GridControl = this.gridControl1;
            this.gvBascula.Name = "gvBascula";
            this.gvBascula.OptionsView.ShowAutoFilterRow = true;
            this.gvBascula.OptionsView.ShowGroupPanel = false;
            this.gvBascula.DoubleClick += new System.EventHandler(this.gvBascula_DoubleClick);
            // 
            // colIDSerie
            // 
            this.colIDSerie.FieldName = "IDSerie";
            this.colIDSerie.Name = "colIDSerie";
            // 
            // colNBoleta
            // 
            this.colNBoleta.Caption = "Num. Boleta";
            this.colNBoleta.FieldName = "NBoleta";
            this.colNBoleta.Name = "colNBoleta";
            this.colNBoleta.OptionsColumn.AllowEdit = false;
            this.colNBoleta.Visible = true;
            this.colNBoleta.VisibleIndex = 0;
            this.colNBoleta.Width = 115;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            this.colDescripcion.Width = 140;
            // 
            // colidtipo
            // 
            this.colidtipo.FieldName = "idtipo";
            this.colidtipo.Name = "colidtipo";
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 2;
            this.colestado.Width = 140;
            // 
            // colestadoDescripcion
            // 
            this.colestadoDescripcion.Caption = "Descrip. Estado";
            this.colestadoDescripcion.FieldName = "estadoDescripcion";
            this.colestadoDescripcion.Name = "colestadoDescripcion";
            this.colestadoDescripcion.OptionsColumn.AllowEdit = false;
            this.colestadoDescripcion.Visible = true;
            this.colestadoDescripcion.VisibleIndex = 3;
            this.colestadoDescripcion.Width = 142;
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.Caption = "Seleccionar";
            this.colSeleccionar.ColumnEdit = this.btnSeleccionar;
            this.colSeleccionar.FieldName = "seleccionar";
            this.colSeleccionar.Name = "colSeleccionar";
            this.colSeleccionar.Width = 67;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoHeight = false;
            this.btnSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // basculaBindingSource
            // 
            this.basculaBindingSource.DataMember = "Bascula";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.simpleButton1.Location = new System.Drawing.Point(411, 26);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(199, 71);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // FrmBoleta
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 521);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBoleta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmBascula";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basculaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBascula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basculaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBascula;
        private System.Windows.Forms.BindingSource basculaBindingSource;
     
        private DevExpress.XtraGrid.Columns.GridColumn colIDSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colNBoleta;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colidtipo;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colestadoDescripcion;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSeleccionar;
        private System.Windows.Forms.BindingSource basculaBindingSource1;
        private RecepcionMP.dsRecepcionMPx dsRecepcionMP;
    }
}