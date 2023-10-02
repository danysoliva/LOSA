namespace LOSA.MigracionACS.Produccion.ProductoMedicado
{
    partial class frmAddItemForMedicado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddItemForMedicado));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsMedicado1 = new LOSA.MigracionACS.Produccion.ProductoMedicado.dsMedicado();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcode_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinv_kg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinv_tm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdConfirmar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "seleccionar_item";
            this.gridControl1.DataSource = this.dsMedicado1;
            this.gridControl1.Location = new System.Drawing.Point(3, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(728, 362);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsMedicado1
            // 
            this.dsMedicado1.DataSetName = "dsMedicado";
            this.dsMedicado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcode_sap,
            this.coldescripcion,
            this.colinv_kg,
            this.colinv_tm,
            this.colseleccionado,
            this.collote,
            this.colcantidad});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colcode_sap
            // 
            this.colcode_sap.Caption = "ItemCode";
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.ReadOnly = true;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 0;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "ItemName";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            // 
            // colinv_kg
            // 
            this.colinv_kg.FieldName = "inv_kg";
            this.colinv_kg.Name = "colinv_kg";
            this.colinv_kg.OptionsColumn.ReadOnly = true;
            this.colinv_kg.Visible = true;
            this.colinv_kg.VisibleIndex = 4;
            // 
            // colinv_tm
            // 
            this.colinv_tm.FieldName = "inv_tm";
            this.colinv_tm.Name = "colinv_tm";
            this.colinv_tm.OptionsColumn.ReadOnly = true;
            this.colinv_tm.Visible = true;
            this.colinv_tm.VisibleIndex = 3;
            // 
            // colseleccionado
            // 
            this.colseleccionado.FieldName = "seleccionado";
            this.colseleccionado.Name = "colseleccionado";
            this.colseleccionado.OptionsColumn.ReadOnly = true;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.ReadOnly = true;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 2;
            // 
            // colcantidad
            // 
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 5;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(621, 2);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(110, 36);
            this.cmdCerrar.TabIndex = 15;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(149, 17);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Seleccione los materiales";
            // 
            // cmdConfirmar
            // 
            this.cmdConfirmar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdConfirmar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConfirmar.Appearance.Options.UseBackColor = true;
            this.cmdConfirmar.Appearance.Options.UseFont = true;
            this.cmdConfirmar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdConfirmar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.cmdConfirmar.Location = new System.Drawing.Point(505, 2);
            this.cmdConfirmar.Name = "cmdConfirmar";
            this.cmdConfirmar.Size = new System.Drawing.Size(110, 36);
            this.cmdConfirmar.TabIndex = 17;
            this.cmdConfirmar.Text = "Confirmar";
            this.cmdConfirmar.Click += new System.EventHandler(this.cmdConfirmar_Click);
            // 
            // frmAddItemForMedicado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 404);
            this.Controls.Add(this.cmdConfirmar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmAddItemForMedicado";
            this.Text = "Agregar Material";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colinv_kg;
        private DevExpress.XtraGrid.Columns.GridColumn colinv_tm;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public dsMedicado dsMedicado1;
        private DevExpress.XtraEditors.SimpleButton cmdConfirmar;
    }
}