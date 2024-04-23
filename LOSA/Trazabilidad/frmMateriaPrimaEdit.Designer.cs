
namespace LOSA.Trazabilidad
{
    partial class frmMateriaPrimaEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMateriaPrimaEdit));
            this.txtNombreComercial = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoSAP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTipoMP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtUniteId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.grdTipoOrigen = new DevExpress.XtraEditors.GridLookUpEdit();
            this.origenMPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantoTrazabilidad1 = new LOSA.Trazabilidad.dsMantoTrazabilidad();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tsGestionLoteVen = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoSAP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoMP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUniteId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoOrigen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenMPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantoTrazabilidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsGestionLoteVen.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.Enabled = false;
            this.txtNombreComercial.Location = new System.Drawing.Point(234, 63);
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtNombreComercial.Properties.Appearance.Options.UseFont = true;
            this.txtNombreComercial.Size = new System.Drawing.Size(236, 26);
            this.txtNombreComercial.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(72, 69);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(129, 20);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Nombre Comercial:";
            // 
            // txtCodigoSAP
            // 
            this.txtCodigoSAP.Enabled = false;
            this.txtCodigoSAP.Location = new System.Drawing.Point(234, 31);
            this.txtCodigoSAP.Name = "txtCodigoSAP";
            this.txtCodigoSAP.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtCodigoSAP.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoSAP.Size = new System.Drawing.Size(150, 26);
            this.txtCodigoSAP.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(72, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 20);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Código SAP:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(72, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(151, 20);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Tipo de Materia Prima:";
            // 
            // txtTipoMP
            // 
            this.txtTipoMP.Enabled = false;
            this.txtTipoMP.Location = new System.Drawing.Point(234, 93);
            this.txtTipoMP.Name = "txtTipoMP";
            this.txtTipoMP.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtTipoMP.Properties.Appearance.Options.UseFont = true;
            this.txtTipoMP.Size = new System.Drawing.Size(236, 26);
            this.txtTipoMP.TabIndex = 14;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(73, 29);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(57, 20);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Unite ID:";
            // 
            // txtUniteId
            // 
            this.txtUniteId.Location = new System.Drawing.Point(227, 26);
            this.txtUniteId.Name = "txtUniteId";
            this.txtUniteId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtUniteId.Properties.Appearance.Options.UseFont = true;
            this.txtUniteId.Size = new System.Drawing.Size(216, 26);
            this.txtUniteId.TabIndex = 16;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(71, 79);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(145, 20);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Origen Materia Prima:";
            // 
            // grdTipoOrigen
            // 
            this.grdTipoOrigen.Location = new System.Drawing.Point(227, 75);
            this.grdTipoOrigen.Name = "grdTipoOrigen";
            this.grdTipoOrigen.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.grdTipoOrigen.Properties.Appearance.Options.UseFont = true;
            this.grdTipoOrigen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdTipoOrigen.Properties.DataSource = this.origenMPBindingSource;
            this.grdTipoOrigen.Properties.DisplayMember = "descripcion";
            this.grdTipoOrigen.Properties.NullText = "";
            this.grdTipoOrigen.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdTipoOrigen.Properties.ValueMember = "id";
            this.grdTipoOrigen.Size = new System.Drawing.Size(216, 26);
            this.grdTipoOrigen.TabIndex = 17;
            // 
            // origenMPBindingSource
            // 
            this.origenMPBindingSource.DataMember = "OrigenMP";
            this.origenMPBindingSource.DataSource = this.dsMantoTrazabilidad1;
            // 
            // dsMantoTrazabilidad1
            // 
            this.dsMantoTrazabilidad1.DataSetName = "dsMantoTrazabilidad";
            this.dsMantoTrazabilidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Origen";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // tsGestionLoteVen
            // 
            this.tsGestionLoteVen.Location = new System.Drawing.Point(301, 125);
            this.tsGestionLoteVen.Name = "tsGestionLoteVen";
            this.tsGestionLoteVen.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.tsGestionLoteVen.Properties.Appearance.Options.UseFont = true;
            this.tsGestionLoteVen.Properties.OffText = "No";
            this.tsGestionLoteVen.Properties.OnText = "Si";
            this.tsGestionLoteVen.Size = new System.Drawing.Size(104, 24);
            this.tsGestionLoteVen.TabIndex = 18;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(125, 127);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(170, 20);
            this.labelControl8.TabIndex = 21;
            this.labelControl8.Text = "Gestion Lote Vencimiento";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtUniteId);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.tsGestionLoteVen);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.grdTipoOrigen);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 180);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calidad";
            // 
            // cmdAplicar
            // 
            this.cmdAplicar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdAplicar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAplicar.Appearance.Options.UseBackColor = true;
            this.cmdAplicar.Appearance.Options.UseFont = true;
            this.cmdAplicar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAplicar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAplicar.ImageOptions.Image")));
            this.cmdAplicar.Location = new System.Drawing.Point(161, 340);
            this.cmdAplicar.Name = "cmdAplicar";
            this.cmdAplicar.Size = new System.Drawing.Size(101, 41);
            this.cmdAplicar.TabIndex = 19;
            this.cmdAplicar.Text = "Guardar";
            this.cmdAplicar.Click += new System.EventHandler(this.cmdAplicar_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(331, 340);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(101, 41);
            this.cmdCerrar.TabIndex = 20;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // frmMateriaPrimaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 409);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdAplicar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTipoMP);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtNombreComercial);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtCodigoSAP);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmMateriaPrimaEdit";
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoSAP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoMP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUniteId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoOrigen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenMPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantoTrazabilidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsGestionLoteVen.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNombreComercial;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCodigoSAP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTipoMP;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtUniteId;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GridLookUpEdit grdTipoOrigen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.ToggleSwitch tsGestionLoteVen;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton cmdAplicar;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private System.Windows.Forms.BindingSource origenMPBindingSource;
        private dsMantoTrazabilidad dsMantoTrazabilidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
    }
}