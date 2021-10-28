
namespace LOSA.Calidad
{
    partial class frmRespuestasCalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRespuestasCalidad));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.grd_seleccion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.respuestaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimientoC = new LOSA.Calidad.dsMantenimientoC();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrespuesta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.txtmanual = new DevExpress.XtraEditors.TextEdit();
            this.btnSeleccioanr = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_seleccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.respuestaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmanual.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(600, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Seleccion de respuesta de Parametro, seleccione una respuesta que considere conve" +
    "niente.";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(74, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 20);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Seleccion: ";
            // 
            // btnSalir
            // 
            this.btnSalir.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Appearance.Options.UseFont = true;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(651, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 33);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grd_seleccion
            // 
            this.grd_seleccion.Location = new System.Drawing.Point(150, 59);
            this.grd_seleccion.Name = "grd_seleccion";
            this.grd_seleccion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_seleccion.Properties.Appearance.Options.UseFont = true;
            this.grd_seleccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_seleccion.Properties.DataSource = this.respuestaBindingSource;
            this.grd_seleccion.Properties.DisplayMember = "respuesta";
            this.grd_seleccion.Properties.PopupView = this.gridLookUpEdit1View;
            this.grd_seleccion.Properties.ValueMember = "id";
            this.grd_seleccion.Size = new System.Drawing.Size(449, 26);
            this.grd_seleccion.TabIndex = 3;
            this.grd_seleccion.EditValueChanged += new System.EventHandler(this.grd_seleccion_EditValueChanged);
            // 
            // respuestaBindingSource
            // 
            this.respuestaBindingSource.DataMember = "respuesta";
            this.respuestaBindingSource.DataSource = this.dsMantenimientoC;
            // 
            // dsMantenimientoC
            // 
            this.dsMantenimientoC.DataSetName = "dsMantenimientoC";
            this.dsMantenimientoC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.FilterPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridLookUpEdit1View.Appearance.FilterPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.FocusedRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FooterPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridLookUpEdit1View.Appearance.FooterPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridLookUpEdit1View.Appearance.GroupFooter.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridLookUpEdit1View.Appearance.GroupRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridLookUpEdit1View.Appearance.Preview.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.TopNewRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gridLookUpEdit1View.Appearance.TopNewRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colrespuesta});
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
            // colrespuesta
            // 
            this.colrespuesta.Caption = "Resultado";
            this.colrespuesta.FieldName = "respuesta";
            this.colrespuesta.Name = "colrespuesta";
            this.colrespuesta.Visible = true;
            this.colrespuesta.VisibleIndex = 0;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(618, 60);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Manual";
            this.checkEdit1.Size = new System.Drawing.Size(127, 24);
            this.checkEdit1.TabIndex = 4;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // txtmanual
            // 
            this.txtmanual.Location = new System.Drawing.Point(150, 59);
            this.txtmanual.Name = "txtmanual";
            this.txtmanual.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtmanual.Properties.Appearance.Options.UseFont = true;
            this.txtmanual.Size = new System.Drawing.Size(449, 26);
            this.txtmanual.TabIndex = 5;
            this.txtmanual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmanual_KeyDown);
            // 
            // btnSeleccioanr
            // 
            this.btnSeleccioanr.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccioanr.Appearance.Options.UseFont = true;
            this.btnSeleccioanr.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccioanr.ImageOptions.Image")));
            this.btnSeleccioanr.Location = new System.Drawing.Point(299, 123);
            this.btnSeleccioanr.Name = "btnSeleccioanr";
            this.btnSeleccioanr.Size = new System.Drawing.Size(187, 50);
            this.btnSeleccioanr.TabIndex = 6;
            this.btnSeleccioanr.Text = "Seleccionar";
            this.btnSeleccioanr.Click += new System.EventHandler(this.btnSeleccioanr_Click);
            // 
            // frmRespuestasCalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 179);
            this.Controls.Add(this.btnSeleccioanr);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.grd_seleccion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtmanual);
            this.Name = "frmRespuestasCalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Responder a los parametros";
            this.Load += new System.EventHandler(this.frmRespuestasCalidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_seleccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.respuestaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmanual.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.GridLookUpEdit grd_seleccion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.TextEdit txtmanual;
        private DevExpress.XtraEditors.SimpleButton btnSeleccioanr;
        private System.Windows.Forms.BindingSource respuestaBindingSource;
        private dsMantenimientoC dsMantenimientoC;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colrespuesta;
    }
}