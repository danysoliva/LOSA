namespace LOSA.Logistica
{
    partial class frmTrazabilidadLote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrazabilidadLote));
            this.gcEventos = new DevExpress.XtraGrid.GridControl();
            this.eventosLoteBindingSource = new System.Windows.Forms.BindingSource();
            this.dsLogistica2 = new LOSA.Logistica.dsLogistica2();
            this.gvEventos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colevento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.teLote = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosLoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogistica2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLote.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcEventos
            // 
            this.gcEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcEventos.DataSource = this.eventosLoteBindingSource;
            this.gcEventos.Location = new System.Drawing.Point(0, 115);
            this.gcEventos.MainView = this.gvEventos;
            this.gcEventos.Name = "gcEventos";
            this.gcEventos.Size = new System.Drawing.Size(638, 445);
            this.gcEventos.TabIndex = 1;
            this.gcEventos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEventos});
            // 
            // eventosLoteBindingSource
            // 
            this.eventosLoteBindingSource.DataMember = "EventosLote";
            this.eventosLoteBindingSource.DataSource = this.dsLogistica2;
            // 
            // dsLogistica2
            // 
            this.dsLogistica2.DataSetName = "dsLogistica2";
            this.dsLogistica2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvEventos
            // 
            this.gvEventos.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gvEventos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvEventos.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvEventos.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gvEventos.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvEventos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvEventos.Appearance.FocusedRow.Options.UseFont = true;
            this.gvEventos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gvEventos.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvEventos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvEventos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvEventos.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvEventos.Appearance.Row.Options.UseFont = true;
            this.gvEventos.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvEventos.Appearance.SelectedRow.Options.UseFont = true;
            this.gvEventos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvEventos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvEventos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colevento,
            this.colfecha,
            this.collote_materia_prima,
            this.colusuario,
            this.colcantidad,
            this.colnum});
            this.gvEventos.GridControl = this.gcEventos;
            this.gvEventos.Name = "gvEventos";
            this.gvEventos.OptionsView.ShowGroupPanel = false;
            // 
            // colevento
            // 
            this.colevento.Caption = "Evento";
            this.colevento.FieldName = "evento";
            this.colevento.Name = "colevento";
            this.colevento.OptionsColumn.AllowEdit = false;
            this.colevento.OptionsColumn.AllowMove = false;
            this.colevento.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colevento.OptionsFilter.AllowFilter = false;
            this.colevento.Visible = true;
            this.colevento.VisibleIndex = 0;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.DisplayFormat.FormatString = "g";
            this.colfecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.OptionsColumn.AllowMove = false;
            this.colfecha.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colfecha.OptionsFilter.AllowFilter = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 1;
            // 
            // collote_materia_prima
            // 
            this.collote_materia_prima.Caption = "Lote Materia Prima";
            this.collote_materia_prima.FieldName = "lote_materia_prima";
            this.collote_materia_prima.Name = "collote_materia_prima";
            this.collote_materia_prima.OptionsColumn.AllowEdit = false;
            this.collote_materia_prima.OptionsColumn.AllowMove = false;
            this.collote_materia_prima.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.collote_materia_prima.OptionsFilter.AllowFilter = false;
            this.collote_materia_prima.Visible = true;
            this.collote_materia_prima.VisibleIndex = 2;
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario";
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.OptionsColumn.AllowEdit = false;
            this.colusuario.OptionsColumn.AllowMove = false;
            this.colusuario.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colusuario.OptionsFilter.AllowAutoFilter = false;
            this.colusuario.OptionsFilter.AllowFilter = false;
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 3;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.OptionsColumn.AllowMove = false;
            this.colcantidad.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colcantidad.OptionsFilter.AllowAutoFilter = false;
            this.colcantidad.OptionsFilter.AllowFilter = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 4;
            // 
            // colnum
            // 
            this.colnum.Caption = "# Tarima";
            this.colnum.FieldName = "num";
            this.colnum.Name = "colnum";
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
            this.btnAtras.Location = new System.Drawing.Point(481, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(145, 47);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // teLote
            // 
            this.teLote.Location = new System.Drawing.Point(67, 77);
            this.teLote.Name = "teLote";
            this.teLote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teLote.Properties.Appearance.Options.UseFont = true;
            this.teLote.Size = new System.Drawing.Size(359, 32);
            this.teLote.TabIndex = 0;
            this.teLote.EditValueChanged += new System.EventHandler(this.teLote_EditValueChanged);
            this.teLote.Enter += new System.EventHandler(this.teLote_Enter);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(17, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 25);
            this.labelControl2.TabIndex = 103;
            this.labelControl2.Text = "Lote:";
            // 
            // frmTrazabilidadLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.teLote);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gcEventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTrazabilidadLote";
            this.Text = "frmEventosTarima";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTrazabilidadLote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosLoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogistica2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLote.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcEventos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEventos;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private System.Windows.Forms.BindingSource eventosLoteBindingSource;
        private dsLogistica2 dsLogistica2;
        private DevExpress.XtraGrid.Columns.GridColumn colevento;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn collote_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraEditors.TextEdit teLote;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colnum;
    }
}