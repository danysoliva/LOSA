
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
            this.txtResolucionEx = new DevExpress.XtraEditors.TextEdit();
            this.txtValorPresupuesto = new DevExpress.XtraEditors.TextEdit();
            this.grdCapitulos = new DevExpress.XtraEditors.GridLookUpEdit();
            this.grdvCapitulos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colU_AQUA_Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcat_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.capitulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsExoneracion1 = new LOSA.Finanzas.dsExoneracion();
            this.partidaarancelariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdPartidasA = new DevExpress.XtraEditors.GridLookUpEdit();
            this.grdvPartidasA = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPartida_arancelaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtResolucionEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorPresupuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCapitulos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvCapitulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExoneracion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaarancelariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartidasA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvPartidasA)).BeginInit();
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
            this.cmdCerrar.Location = new System.Drawing.Point(355, 372);
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
            this.cmdConfirma.Location = new System.Drawing.Point(166, 372);
            this.cmdConfirma.Name = "cmdConfirma";
            this.cmdConfirma.Size = new System.Drawing.Size(145, 46);
            this.cmdConfirma.TabIndex = 7;
            this.cmdConfirma.Text = "Guardar";
            this.cmdConfirma.Click += new System.EventHandler(this.cmdConfirma_Click);
            // 
            // txtResolucionEx
            // 
            this.txtResolucionEx.Enabled = false;
            this.txtResolucionEx.Location = new System.Drawing.Point(251, 90);
            this.txtResolucionEx.Name = "txtResolucionEx";
            this.txtResolucionEx.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResolucionEx.Properties.Appearance.Options.UseFont = true;
            this.txtResolucionEx.Size = new System.Drawing.Size(169, 28);
            this.txtResolucionEx.TabIndex = 9;
            // 
            // txtValorPresupuesto
            // 
            this.txtValorPresupuesto.Location = new System.Drawing.Point(251, 317);
            this.txtValorPresupuesto.Name = "txtValorPresupuesto";
            this.txtValorPresupuesto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtValorPresupuesto.Properties.Appearance.Options.UseFont = true;
            this.txtValorPresupuesto.Properties.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.txtValorPresupuesto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValorPresupuesto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtValorPresupuesto.Properties.MaskSettings.Set("mask", "n");
            this.txtValorPresupuesto.Size = new System.Drawing.Size(147, 28);
            this.txtValorPresupuesto.TabIndex = 10;
            // 
            // grdCapitulos
            // 
            this.grdCapitulos.Location = new System.Drawing.Point(251, 149);
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
            this.grdCapitulos.Size = new System.Drawing.Size(343, 28);
            this.grdCapitulos.TabIndex = 11;
            this.grdCapitulos.EditValueChanged += new System.EventHandler(this.grdCapitulos_EditValueChanged);
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
            this.labelControl2.Location = new System.Drawing.Point(89, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(166, 21);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Resolucion Exonerada__";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(89, 208);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(222, 21);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Partida Arancelaria_____________";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(89, 156);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(191, 21);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Capitulo___________________";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(89, 324);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(172, 21);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Monto__________________";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(251, 262);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCantidad.Properties.Appearance.Options.UseFont = true;
            this.txtCantidad.Properties.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.txtCantidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCantidad.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCantidad.Properties.MaskSettings.Set("mask", "n");
            this.txtCantidad.Size = new System.Drawing.Size(147, 28);
            this.txtCantidad.TabIndex = 18;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(89, 269);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(188, 21);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Cantidad__________________";
            // 
            // capitulosBindingSource
            // 
            this.capitulosBindingSource.DataMember = "capitulos";
            this.capitulosBindingSource.DataSource = this.dsExoneracion1;
            // 
            // dsExoneracion1
            // 
            this.dsExoneracion1.DataSetName = "dsExoneracion";
            this.dsExoneracion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partidaarancelariaBindingSource
            // 
            this.partidaarancelariaBindingSource.DataMember = "partida_arancelaria";
            this.partidaarancelariaBindingSource.DataSource = this.dsExoneracion1;
            // 
            // grdPartidasA
            // 
            this.grdPartidasA.Location = new System.Drawing.Point(251, 204);
            this.grdPartidasA.Name = "grdPartidasA";
            this.grdPartidasA.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdPartidasA.Properties.Appearance.Options.UseFont = true;
            this.grdPartidasA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdPartidasA.Properties.DataSource = this.partidaarancelariaBindingSource;
            this.grdPartidasA.Properties.DisplayMember = "Partida_arancelaria";
            this.grdPartidasA.Properties.NullText = "";
            this.grdPartidasA.Properties.PopupView = this.grdvPartidasA;
            this.grdPartidasA.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
            this.grdPartidasA.Properties.ValueMember = "Partida_arancelaria";
            this.grdPartidasA.Size = new System.Drawing.Size(234, 28);
            this.grdPartidasA.TabIndex = 20;
            // 
            // grdvPartidasA
            // 
            this.grdvPartidasA.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPartida_arancelaria,
            this.colDescripcion});
            this.grdvPartidasA.DetailHeight = 600;
            this.grdvPartidasA.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdvPartidasA.Name = "grdvPartidasA";
            this.grdvPartidasA.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdvPartidasA.OptionsView.ShowGroupPanel = false;
            // 
            // colPartida_arancelaria
            // 
            this.colPartida_arancelaria.Caption = "Partida Arancelaria";
            this.colPartida_arancelaria.FieldName = "Partida_arancelaria";
            this.colPartida_arancelaria.Name = "colPartida_arancelaria";
            this.colPartida_arancelaria.Visible = true;
            this.colPartida_arancelaria.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripcion";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // frmExoneracionOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 443);
            this.Controls.Add(this.grdPartidasA);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtResolucionEx);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtResolucionEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorPresupuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCapitulos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvCapitulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExoneracion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaarancelariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartidasA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvPartidasA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdConfirma;
        private DevExpress.XtraEditors.TextEdit txtResolucionEx;
        private DevExpress.XtraEditors.TextEdit txtValorPresupuesto;
        private DevExpress.XtraEditors.GridLookUpEdit grdCapitulos;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvCapitulos;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private dsExoneracion dsExoneracion1;
        private System.Windows.Forms.BindingSource capitulosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colU_AQUA_Desc;
        private DevExpress.XtraGrid.Columns.GridColumn colconcat_;
        private DevExpress.XtraEditors.TextEdit txtCantidad;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.BindingSource partidaarancelariaBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit grdPartidasA;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvPartidasA;
        private DevExpress.XtraGrid.Columns.GridColumn colPartida_arancelaria;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
    }
}