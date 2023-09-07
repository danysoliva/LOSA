
namespace LOSA.Finanzas
{
    partial class frmExoneracionOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExoneracionOP));
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdConfirma = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.txtValorPresupuesto = new DevExpress.XtraEditors.TextEdit();
            this.grdCapitulos = new DevExpress.XtraEditors.GridLookUpEdit();
            this.grdvCapitulos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colU_AQUA_Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcat_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdRubros = new DevExpress.XtraEditors.GridLookUpEdit();
            this.grdvRubros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.rubrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsExoneracion1 = new LOSA.Finanzas.dsExoneracion();
            this.capitulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcat_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorPresupuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCapitulos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvCapitulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRubros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvRubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExoneracion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitulosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.Salmon;
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdCerrar.ImageOptions.SvgImage")));
            this.cmdCerrar.Location = new System.Drawing.Point(378, 353);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(145, 46);
            this.cmdCerrar.TabIndex = 8;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdConfirma
            // 
            this.cmdConfirma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdConfirma.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.cmdConfirma.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConfirma.Appearance.Options.UseBackColor = true;
            this.cmdConfirma.Appearance.Options.UseFont = true;
            this.cmdConfirma.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdConfirma.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdConfirma.ImageOptions.SvgImage")));
            this.cmdConfirma.Location = new System.Drawing.Point(135, 353);
            this.cmdConfirma.Name = "cmdConfirma";
            this.cmdConfirma.Size = new System.Drawing.Size(145, 46);
            this.cmdConfirma.TabIndex = 7;
            this.cmdConfirma.Text = "Guardar";
            this.cmdConfirma.Click += new System.EventHandler(this.cmdConfirma_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(251, 79);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(169, 28);
            this.textEdit1.TabIndex = 9;
            // 
            // txtValorPresupuesto
            // 
            this.txtValorPresupuesto.Location = new System.Drawing.Point(251, 264);
            this.txtValorPresupuesto.Name = "txtValorPresupuesto";
            this.txtValorPresupuesto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtValorPresupuesto.Properties.Appearance.Options.UseFont = true;
            this.txtValorPresupuesto.Properties.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.txtValorPresupuesto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValorPresupuesto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtValorPresupuesto.Properties.MaskSettings.Set("mask", "n");
            this.txtValorPresupuesto.Size = new System.Drawing.Size(125, 28);
            this.txtValorPresupuesto.TabIndex = 10;
            // 
            // grdCapitulos
            // 
            this.grdCapitulos.Location = new System.Drawing.Point(251, 198);
            this.grdCapitulos.Name = "grdCapitulos";
            this.grdCapitulos.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdCapitulos.Properties.Appearance.Options.UseFont = true;
            this.grdCapitulos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdCapitulos.Properties.DataSource = this.capitulosBindingSource;
            this.grdCapitulos.Properties.DisplayMember = "concat_";
            this.grdCapitulos.Properties.NullText = "";
            this.grdCapitulos.Properties.PopupView = this.grdvCapitulos;
            this.grdCapitulos.Properties.ValueMember = "Code";
            this.grdCapitulos.Size = new System.Drawing.Size(308, 28);
            this.grdCapitulos.TabIndex = 11;
            // 
            // grdvCapitulos
            // 
            this.grdvCapitulos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode1,
            this.colU_AQUA_Desc,
            this.colconcat_});
            this.grdvCapitulos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdvCapitulos.Name = "grdvCapitulos";
            this.grdvCapitulos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdvCapitulos.OptionsView.ShowAutoFilterRow = true;
            this.grdvCapitulos.OptionsView.ShowGroupPanel = false;
            // 
            // colCode1
            // 
            this.colCode1.FieldName = "Code";
            this.colCode1.Name = "colCode1";
            // 
            // colU_AQUA_Desc
            // 
            this.colU_AQUA_Desc.FieldName = "U_AQUA_Desc";
            this.colU_AQUA_Desc.Name = "colU_AQUA_Desc";
            // 
            // colconcat_
            // 
            this.colconcat_.Caption = "Capitulo";
            this.colconcat_.FieldName = "concat_";
            this.colconcat_.Name = "colconcat_";
            this.colconcat_.Visible = true;
            this.colconcat_.VisibleIndex = 0;
            // 
            // grdRubros
            // 
            this.grdRubros.Location = new System.Drawing.Point(251, 140);
            this.grdRubros.Name = "grdRubros";
            this.grdRubros.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdRubros.Properties.Appearance.Options.UseFont = true;
            this.grdRubros.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdRubros.Properties.DataSource = this.rubrosBindingSource;
            this.grdRubros.Properties.DisplayMember = "concat_";
            this.grdRubros.Properties.NullText = "";
            this.grdRubros.Properties.PopupView = this.grdvRubros;
            this.grdRubros.Properties.ValueMember = "Code";
            this.grdRubros.Size = new System.Drawing.Size(308, 28);
            this.grdRubros.TabIndex = 12;
            // 
            // grdvRubros
            // 
            this.grdvRubros.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colName,
            this.colconcat_1});
            this.grdvRubros.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdvRubros.Name = "grdvRubros";
            this.grdvRubros.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdvRubros.OptionsView.ShowAutoFilterRow = true;
            this.grdvRubros.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(231, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(229, 25);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Detalle Exoneracion Fiscal";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(89, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(166, 21);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Resolucion Exonerada__";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(89, 143);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(211, 21);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Rubro________________________";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(89, 205);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(191, 21);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Capitulo___________________";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(89, 271);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(172, 21);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Monto__________________";
            // 
            // rubrosBindingSource
            // 
            this.rubrosBindingSource.DataMember = "rubros";
            this.rubrosBindingSource.DataSource = this.dsExoneracion1;
            // 
            // dsExoneracion1
            // 
            this.dsExoneracion1.DataSetName = "dsExoneracion";
            this.dsExoneracion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // capitulosBindingSource
            // 
            this.capitulosBindingSource.DataMember = "capitulos";
            this.capitulosBindingSource.DataSource = this.dsExoneracion1;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            // 
            // colconcat_1
            // 
            this.colconcat_1.Caption = "Rubros";
            this.colconcat_1.FieldName = "concat_";
            this.colconcat_1.Name = "colconcat_1";
            this.colconcat_1.Visible = true;
            this.colconcat_1.VisibleIndex = 0;
            // 
            // frmExoneracionOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 443);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grdRubros);
            this.Controls.Add(this.grdCapitulos);
            this.Controls.Add(this.txtValorPresupuesto);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdConfirma);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExoneracionOP";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorPresupuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCapitulos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvCapitulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRubros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvRubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExoneracion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitulosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdConfirma;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit txtValorPresupuesto;
        private DevExpress.XtraEditors.GridLookUpEdit grdCapitulos;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvCapitulos;
        private DevExpress.XtraEditors.GridLookUpEdit grdRubros;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvRubros;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.BindingSource rubrosBindingSource;
        private dsExoneracion dsExoneracion1;
        private System.Windows.Forms.BindingSource capitulosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colU_AQUA_Desc;
        private DevExpress.XtraGrid.Columns.GridColumn colconcat_;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colconcat_1;
    }
}