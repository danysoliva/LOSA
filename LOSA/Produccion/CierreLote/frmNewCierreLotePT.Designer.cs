
namespace LOSA.Produccion.CierreLote
{
    partial class frmNewCierreLotePT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewCierreLotePT));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridLook_LotePT = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dsCierreLotesPT1 = new LOSA.Produccion.CierreLote.dsCierreLotesPT();
            this.bindingSourceLotesDisponibles = new System.Windows.Forms.BindingSource(this.components);
            this.collote_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridLook_LotePT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCierreLotesPT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLotesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(108, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(113, 25);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Nuevo Cierre";
            // 
            // gridLook_LotePT
            // 
            this.gridLook_LotePT.Location = new System.Drawing.Point(121, 55);
            this.gridLook_LotePT.Name = "gridLook_LotePT";
            this.gridLook_LotePT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLook_LotePT.Properties.Appearance.Options.UseFont = true;
            this.gridLook_LotePT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLook_LotePT.Properties.DataSource = this.bindingSourceLotesDisponibles;
            this.gridLook_LotePT.Properties.DisplayMember = "lote_pt";
            this.gridLook_LotePT.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLook_LotePT.Properties.ValueMember = "lote_pt";
            this.gridLook_LotePT.Size = new System.Drawing.Size(133, 24);
            this.gridLook_LotePT.TabIndex = 3;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collote_pt});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(86, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 17);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Lote:";
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdCerrar.ImageOptions.SvgImage")));
            this.cmdCerrar.Location = new System.Drawing.Point(173, 143);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(137, 39);
            this.cmdCerrar.TabIndex = 5;
            this.cmdCerrar.Text = "Salir";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(30, 143);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(137, 39);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Generar Cierre";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dsCierreLotesPT1
            // 
            this.dsCierreLotesPT1.DataSetName = "dsCierreLotesPT";
            this.dsCierreLotesPT1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceLotesDisponibles
            // 
            this.bindingSourceLotesDisponibles.DataMember = "Lotes_disponibles";
            this.bindingSourceLotesDisponibles.DataSource = this.dsCierreLotesPT1;
            // 
            // collote_pt
            // 
            this.collote_pt.FieldName = "lote_pt";
            this.collote_pt.Name = "collote_pt";
            this.collote_pt.OptionsColumn.ReadOnly = true;
            this.collote_pt.Visible = true;
            this.collote_pt.VisibleIndex = 0;
            // 
            // frmNewCierreLotePT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 194);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gridLook_LotePT);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmNewCierreLotePT";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.gridLook_LotePT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCierreLotesPT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLotesDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsCierreLotesPT dsCierreLotesPT1;
        private System.Windows.Forms.BindingSource bindingSourceLotesDisponibles;
        private DevExpress.XtraEditors.GridLookUpEdit gridLook_LotePT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn collote_pt;
    }
}