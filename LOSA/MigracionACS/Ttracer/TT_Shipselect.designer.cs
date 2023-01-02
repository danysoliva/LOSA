namespace LOSA.MigracionACS.Ttracer
{
    partial class TT_Shipselect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TT_Shipselect));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.pn1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grd_ship = new DevExpress.XtraGrid.GridControl();
            this.dSTtracer = new MigracionACS.Ttracer.dSTtracer();
            this.grdv_ship = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidplan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNbarco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldtini = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldtfin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbtnview = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnshow = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colselect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnselect = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colCntxCamion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCamiones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_ship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnselect)).BeginInit();
            this.SuspendLayout();
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.button1);
            this.pn1.Controls.Add(this.panelControl1);
            this.pn1.Controls.Add(this.label1);
            this.pn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn1.Location = new System.Drawing.Point(0, 0);
            this.pn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(1213, 625);
            this.pn1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1072, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(137, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.grd_ship);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 86);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1213, 539);
            this.panelControl1.TabIndex = 2;
            // 
            // grd_ship
            // 
            this.grd_ship.DataMember = "shipArrib";
            this.grd_ship.DataSource = this.dSTtracer;
            this.grd_ship.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_ship.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grd_ship.Location = new System.Drawing.Point(2, 2);
            this.grd_ship.MainView = this.grdv_ship;
            this.grd_ship.Margin = new System.Windows.Forms.Padding(4);
            this.grd_ship.Name = "grd_ship";
            this.grd_ship.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnshow,
            this.btnselect});
            this.grd_ship.Size = new System.Drawing.Size(1209, 535);
            this.grd_ship.TabIndex = 1;
            this.grd_ship.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_ship});
            // 
            // dSTtracer
            // 
            this.dSTtracer.DataSetName = "dSTtracer";
            this.dSTtracer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_ship
            // 
            this.grdv_ship.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidplan,
            this.colNbarco,
            this.colCodigoB,
            this.coldtini,
            this.coldtfin,
            this.colbtnview,
            this.colselect,
            this.colCntxCamion,
            this.colCamiones,
            this.colpeso});
            this.grdv_ship.GridControl = this.grd_ship;
            this.grdv_ship.Name = "grdv_ship";
            this.grdv_ship.OptionsView.ShowAutoFilterRow = true;
            // 
            // colidplan
            // 
            this.colidplan.Caption = "Numero de Plan";
            this.colidplan.FieldName = "idplan";
            this.colidplan.Name = "colidplan";
            this.colidplan.OptionsColumn.AllowEdit = false;
            this.colidplan.Visible = true;
            this.colidplan.VisibleIndex = 0;
            this.colidplan.Width = 93;
            // 
            // colNbarco
            // 
            this.colNbarco.Caption = "Barco";
            this.colNbarco.FieldName = "Nbarco";
            this.colNbarco.Name = "colNbarco";
            this.colNbarco.OptionsColumn.AllowEdit = false;
            this.colNbarco.Visible = true;
            this.colNbarco.VisibleIndex = 1;
            this.colNbarco.Width = 142;
            // 
            // colCodigoB
            // 
            this.colCodigoB.Caption = "Codigo de barco";
            this.colCodigoB.FieldName = "CodigoB";
            this.colCodigoB.Name = "colCodigoB";
            this.colCodigoB.OptionsColumn.AllowEdit = false;
            this.colCodigoB.Visible = true;
            this.colCodigoB.VisibleIndex = 2;
            this.colCodigoB.Width = 142;
            // 
            // coldtini
            // 
            this.coldtini.Caption = "fecha de inicio";
            this.coldtini.FieldName = "dtini";
            this.coldtini.Name = "coldtini";
            this.coldtini.OptionsColumn.AllowEdit = false;
            this.coldtini.Visible = true;
            this.coldtini.VisibleIndex = 3;
            this.coldtini.Width = 142;
            // 
            // coldtfin
            // 
            this.coldtfin.Caption = "fecha final";
            this.coldtfin.FieldName = "dtfin";
            this.coldtfin.Name = "coldtfin";
            this.coldtfin.OptionsColumn.AllowEdit = false;
            this.coldtfin.Visible = true;
            this.coldtfin.VisibleIndex = 6;
            this.coldtfin.Width = 149;
            // 
            // colbtnview
            // 
            this.colbtnview.Caption = "Ver detalle";
            this.colbtnview.ColumnEdit = this.btnshow;
            this.colbtnview.Name = "colbtnview";
            this.colbtnview.Visible = true;
            this.colbtnview.VisibleIndex = 7;
            // 
            // btnshow
            // 
            this.btnshow.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnshow.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnshow.Name = "btnshow";
            this.btnshow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // colselect
            // 
            this.colselect.Caption = "Seleccionar";
            this.colselect.ColumnEdit = this.btnselect;
            this.colselect.Name = "colselect";
            this.colselect.Visible = true;
            this.colselect.VisibleIndex = 8;
            // 
            // btnselect
            // 
            this.btnselect.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnselect.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnselect.Name = "btnselect";
            this.btnselect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // colCntxCamion
            // 
            this.colCntxCamion.Caption = "Cantidad por camion";
            this.colCntxCamion.FieldName = "CntxCamion";
            this.colCntxCamion.Name = "colCntxCamion";
            this.colCntxCamion.OptionsColumn.AllowEdit = false;
            this.colCntxCamion.Visible = true;
            this.colCntxCamion.VisibleIndex = 4;
            // 
            // colCamiones
            // 
            this.colCamiones.Caption = "Camiones";
            this.colCamiones.FieldName = "Camiones";
            this.colCamiones.Name = "colCamiones";
            this.colCamiones.Visible = true;
            this.colCamiones.VisibleIndex = 5;
            // 
            // colpeso
            // 
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el nombre del barco disponible.";
            // 
            // TT_Shipselect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 625);
            this.Controls.Add(this.pn1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TT_Shipselect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TT_Shipselect";
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_ship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnselect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grd_ship;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_ship;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colidplan;
        private DevExpress.XtraGrid.Columns.GridColumn colNbarco;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoB;
        private DevExpress.XtraGrid.Columns.GridColumn coldtini;
        private DevExpress.XtraGrid.Columns.GridColumn coldtfin;
        private dSTtracer dSTtracer;
        private DevExpress.XtraGrid.Columns.GridColumn colbtnview;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnshow;
        private DevExpress.XtraGrid.Columns.GridColumn colselect;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnselect;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn colCntxCamion;
        private DevExpress.XtraGrid.Columns.GridColumn colCamiones;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
    }
}