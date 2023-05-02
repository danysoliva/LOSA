
namespace LOSA.Liquidos
{
    partial class xfrmTrasladoTanqueExt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmTrasladoTanqueExt));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblSalida = new DevExpress.XtraEditors.LabelControl();
            this.lblEntrada = new DevExpress.XtraEditors.LabelControl();
            this.grdTanqueSalida = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tanqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLiquidos_1 = new LOSA.Liquidos.dsLiquidos_();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdTanqueEntrada = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.txtCantidaSalida = new DevExpress.XtraEditors.TextEdit();
            this.txtCantidadEntrada = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTanqueSalida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLiquidos_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTanqueEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidaSalida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadEntrada.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::LOSA.Properties.Resources.CCT_2000C_SQ_800x800;
            this.pictureEdit1.Location = new System.Drawing.Point(173, 208);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(144, 143);
            this.pictureEdit1.TabIndex = 30;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = global::LOSA.Properties.Resources.CCT_2000C_SQ_800x800;
            this.pictureEdit2.Location = new System.Drawing.Point(546, 208);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit2.Size = new System.Drawing.Size(144, 143);
            this.pictureEdit2.TabIndex = 31;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(272, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(346, 25);
            this.labelControl1.TabIndex = 53;
            this.labelControl1.Text = "Traslado Entre Tanques Externos";
            // 
            // lblSalida
            // 
            this.lblSalida.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.Appearance.Options.UseFont = true;
            this.lblSalida.Location = new System.Drawing.Point(104, 161);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(77, 25);
            this.lblSalida.TabIndex = 100;
            this.lblSalida.Text = "Tanque";
            // 
            // lblEntrada
            // 
            this.lblEntrada.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Appearance.Options.UseFont = true;
            this.lblEntrada.Location = new System.Drawing.Point(496, 161);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(77, 25);
            this.lblEntrada.TabIndex = 101;
            this.lblEntrada.Text = "Tanque";
            // 
            // grdTanqueSalida
            // 
            this.grdTanqueSalida.EditValue = "";
            this.grdTanqueSalida.Location = new System.Drawing.Point(173, 375);
            this.grdTanqueSalida.Name = "grdTanqueSalida";
            this.grdTanqueSalida.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdTanqueSalida.Properties.Appearance.Options.UseFont = true;
            this.grdTanqueSalida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdTanqueSalida.Properties.DataSource = this.tanqueBindingSource;
            this.grdTanqueSalida.Properties.DisplayMember = "descripcion";
            this.grdTanqueSalida.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdTanqueSalida.Properties.ValueMember = "id";
            this.grdTanqueSalida.Size = new System.Drawing.Size(144, 28);
            this.grdTanqueSalida.TabIndex = 102;
            this.grdTanqueSalida.EditValueChanged += new System.EventHandler(this.grdTanqueSalida_EditValueChanged);
            // 
            // tanqueBindingSource
            // 
            this.tanqueBindingSource.DataMember = "Tanque";
            this.tanqueBindingSource.DataSource = this.dsLiquidos_1;
            // 
            // dsLiquidos_1
            // 
            this.dsLiquidos_1.DataSetName = "dsLiquidos_";
            this.dsLiquidos_1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // grdTanqueEntrada
            // 
            this.grdTanqueEntrada.EditValue = "";
            this.grdTanqueEntrada.Location = new System.Drawing.Point(546, 375);
            this.grdTanqueEntrada.Name = "grdTanqueEntrada";
            this.grdTanqueEntrada.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdTanqueEntrada.Properties.Appearance.Options.UseFont = true;
            this.grdTanqueEntrada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdTanqueEntrada.Properties.DataSource = this.tanqueBindingSource;
            this.grdTanqueEntrada.Properties.DisplayMember = "descripcion";
            this.grdTanqueEntrada.Properties.PopupView = this.gridLookUpEdit2View;
            this.grdTanqueEntrada.Properties.ValueMember = "id";
            this.grdTanqueEntrada.Size = new System.Drawing.Size(144, 28);
            this.grdTanqueEntrada.TabIndex = 103;
            this.grdTanqueEntrada.EditValueChanged += new System.EventHandler(this.grdTanqueEntrada_EditValueChanged);
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnGuardar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Appearance.Options.UseBackColor = true;
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.Appearance.Options.UseForeColor = true;
            this.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuardar.ImageOptions.SvgImage")));
            this.btnGuardar.Location = new System.Drawing.Point(359, 502);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 55);
            this.btnGuardar.TabIndex = 104;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnAtras.Location = new System.Drawing.Point(763, 37);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(123, 47);
            this.btnAtras.TabIndex = 105;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtCantidaSalida
            // 
            this.txtCantidaSalida.EditValue = "0";
            this.txtCantidaSalida.Enabled = false;
            this.txtCantidaSalida.Location = new System.Drawing.Point(173, 419);
            this.txtCantidaSalida.Name = "txtCantidaSalida";
            this.txtCantidaSalida.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCantidaSalida.Properties.Appearance.Options.UseFont = true;
            this.txtCantidaSalida.Size = new System.Drawing.Size(144, 28);
            this.txtCantidaSalida.TabIndex = 106;
            // 
            // txtCantidadEntrada
            // 
            this.txtCantidadEntrada.EditValue = "0";
            this.txtCantidadEntrada.Enabled = false;
            this.txtCantidadEntrada.Location = new System.Drawing.Point(546, 419);
            this.txtCantidadEntrada.Name = "txtCantidadEntrada";
            this.txtCantidadEntrada.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCantidadEntrada.Properties.Appearance.Options.UseFont = true;
            this.txtCantidadEntrada.Size = new System.Drawing.Size(144, 28);
            this.txtCantidadEntrada.TabIndex = 107;
            // 
            // xfrmTrasladoTanqueExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 629);
            this.Controls.Add(this.txtCantidadEntrada);
            this.Controls.Add(this.txtCantidaSalida);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grdTanqueEntrada);
            this.Controls.Add(this.grdTanqueSalida);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit1);
            this.Name = "xfrmTrasladoTanqueExt";
            this.Text = "xfrmTrasladoTanqueExt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTanqueSalida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLiquidos_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTanqueEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidaSalida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadEntrada.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblSalida;
        private DevExpress.XtraEditors.LabelControl lblEntrada;
        private DevExpress.XtraEditors.GridLookUpEdit grdTanqueSalida;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit grdTanqueEntrada;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.TextEdit txtCantidaSalida;
        private DevExpress.XtraEditors.TextEdit txtCantidadEntrada;
        private dsLiquidos_ dsLiquidos_1;
        private System.Windows.Forms.BindingSource tanqueBindingSource;
    }
}