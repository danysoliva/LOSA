
namespace LOSA.Finanzas
{
    partial class frmExoneracionAQ
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
            this.grdListaExoneracion = new DevExpress.XtraGrid.GridControl();
            this.grdvListaExoneracion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dsExoneracion1 = new LOSA.Finanzas.dsExoneracion();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colanio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_create = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcerrado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaExoneracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListaExoneracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExoneracion1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdListaExoneracion
            // 
            this.grdListaExoneracion.DataMember = "lista_exoneracion";
            this.grdListaExoneracion.DataSource = this.dsExoneracion1;
            this.grdListaExoneracion.Location = new System.Drawing.Point(2, 54);
            this.grdListaExoneracion.MainView = this.grdvListaExoneracion;
            this.grdListaExoneracion.Name = "grdListaExoneracion";
            this.grdListaExoneracion.Size = new System.Drawing.Size(863, 536);
            this.grdListaExoneracion.TabIndex = 0;
            this.grdListaExoneracion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListaExoneracion});
            // 
            // grdvListaExoneracion
            // 
            this.grdvListaExoneracion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colanio,
            this.colinicio,
            this.colfinal,
            this.coluser_create,
            this.coluser_name,
            this.colenable,
            this.colcerrado});
            this.grdvListaExoneracion.GridControl = this.grdListaExoneracion;
            this.grdvListaExoneracion.Name = "grdvListaExoneracion";
            this.grdvListaExoneracion.OptionsBehavior.ReadOnly = true;
            this.grdvListaExoneracion.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(71, 28);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(100, 20);
            this.gridLookUpEdit1.TabIndex = 1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // dsExoneracion1
            // 
            this.dsExoneracion1.DataSetName = "dsExoneracion";
            this.dsExoneracion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colanio
            // 
            this.colanio.FieldName = "anio";
            this.colanio.Name = "colanio";
            this.colanio.Visible = true;
            this.colanio.VisibleIndex = 1;
            // 
            // colinicio
            // 
            this.colinicio.FieldName = "inicio";
            this.colinicio.Name = "colinicio";
            this.colinicio.Visible = true;
            this.colinicio.VisibleIndex = 2;
            // 
            // colfinal
            // 
            this.colfinal.FieldName = "final";
            this.colfinal.Name = "colfinal";
            this.colfinal.Visible = true;
            this.colfinal.VisibleIndex = 3;
            // 
            // coluser_create
            // 
            this.coluser_create.FieldName = "user_create";
            this.coluser_create.Name = "coluser_create";
            this.coluser_create.Visible = true;
            this.coluser_create.VisibleIndex = 4;
            // 
            // coluser_name
            // 
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 5;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.Visible = true;
            this.colenable.VisibleIndex = 6;
            // 
            // colcerrado
            // 
            this.colcerrado.FieldName = "cerrado";
            this.colcerrado.Name = "colcerrado";
            this.colcerrado.Visible = true;
            this.colcerrado.VisibleIndex = 7;
            // 
            // frmExoneracionAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 594);
            this.Controls.Add(this.gridLookUpEdit1);
            this.Controls.Add(this.grdListaExoneracion);
            this.Name = "frmExoneracionAQ";
            ((System.ComponentModel.ISupportInitialize)(this.grdListaExoneracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListaExoneracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExoneracion1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdListaExoneracion;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListaExoneracion;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private dsExoneracion dsExoneracion1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colanio;
        private DevExpress.XtraGrid.Columns.GridColumn colinicio;
        private DevExpress.XtraGrid.Columns.GridColumn colfinal;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_create;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colcerrado;
    }
}