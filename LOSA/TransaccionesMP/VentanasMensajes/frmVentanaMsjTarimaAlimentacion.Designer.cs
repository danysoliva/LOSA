
namespace LOSA.TransaccionesMP.VentanasMensajes
{
    partial class frmVentanaMsjTarimaAlimentacion
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
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dsMensajesTransaccionMP1 = new LOSA.TransaccionesMP.VentanasMensajes.dsMensajesTransaccionMP();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.lblMensaje = new DevExpress.XtraEditors.LabelControl();
            this.rowid = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowRequisición = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowItemCode = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowid_materia_prima = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowMateria_Prima_Nombre = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowMP_Lote = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowUsuario = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowFecha_Consumo = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCantidad = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowPeso = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowEstado_Calidad = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowid_tarima = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowConsumido = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowFecha_Entrega = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowEstado_Tarima = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowLote_PT = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowPresentacion = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowFecha_Vencimiento = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowFecha_Ingreso = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowProveedor_Name = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCardCode = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowNum_Ingreso = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCodigo_Barra = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMensajesTransaccionMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // vGridControl1
            // 
            this.vGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.vGridControl1.DataMember = "tarima_alimentacion_tarimas";
            this.vGridControl1.DataSource = this.dsMensajesTransaccionMP1;
            this.vGridControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vGridControl1.Location = new System.Drawing.Point(12, 168);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RowHeaderWidth = 142;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowid,
            this.rowRequisición,
            this.rowItemCode,
            this.rowid_materia_prima,
            this.rowMateria_Prima_Nombre,
            this.rowMP_Lote,
            this.rowUsuario,
            this.rowFecha_Consumo,
            this.rowCantidad,
            this.rowPeso,
            this.rowEstado_Calidad,
            this.rowid_tarima,
            this.rowConsumido,
            this.rowFecha_Entrega,
            this.rowEstado_Tarima,
            this.rowLote_PT,
            this.rowPresentacion,
            this.rowFecha_Vencimiento,
            this.rowFecha_Ingreso,
            this.rowProveedor_Name,
            this.rowCardCode,
            this.rowNum_Ingreso,
            this.rowCodigo_Barra});
            this.vGridControl1.Size = new System.Drawing.Size(463, 356);
            this.vGridControl1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(208, 25);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mensaje:";
            // 
            // dsMensajesTransaccionMP1
            // 
            this.dsMensajesTransaccionMP1.DataSetName = "dsMensajesTransaccionMP";
            this.dsMensajesTransaccionMP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::LOSA.Properties.Resources.Alerta64px;
            this.pictureEdit1.Location = new System.Drawing.Point(387, -3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 3;
            this.pictureEdit1.EditValueChanged += new System.EventHandler(this.pictureEdit1_EditValueChanged);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.Location = new System.Drawing.Point(126, 530);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(170, 63);
            this.cmdCerrar.TabIndex = 4;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Appearance.Options.UseFont = true;
            this.lblMensaje.Appearance.Options.UseTextOptions = true;
            this.lblMensaje.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblMensaje.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblMensaje.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMensaje.Location = new System.Drawing.Point(13, 76);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(462, 86);
            this.lblMensaje.TabIndex = 5;
            // 
            // rowid
            // 
            this.rowid.Name = "rowid";
            this.rowid.Properties.Caption = "id";
            this.rowid.Properties.FieldName = "id";
            this.rowid.Visible = false;
            // 
            // rowRequisición
            // 
            this.rowRequisición.Name = "rowRequisición";
            this.rowRequisición.Properties.Caption = "Requisición";
            this.rowRequisición.Properties.FieldName = "Requisición";
            // 
            // rowItemCode
            // 
            this.rowItemCode.Name = "rowItemCode";
            this.rowItemCode.Properties.Caption = "Item Code";
            this.rowItemCode.Properties.FieldName = "ItemCode";
            // 
            // rowid_materia_prima
            // 
            this.rowid_materia_prima.Name = "rowid_materia_prima";
            this.rowid_materia_prima.Properties.Caption = "id_materia_prima";
            this.rowid_materia_prima.Properties.FieldName = "id_materia_prima";
            this.rowid_materia_prima.Visible = false;
            // 
            // rowMateria_Prima_Nombre
            // 
            this.rowMateria_Prima_Nombre.Name = "rowMateria_Prima_Nombre";
            this.rowMateria_Prima_Nombre.Properties.Caption = "Materia Prima Nombre";
            this.rowMateria_Prima_Nombre.Properties.FieldName = "Materia Prima Nombre";
            // 
            // rowMP_Lote
            // 
            this.rowMP_Lote.Height = 16;
            this.rowMP_Lote.Name = "rowMP_Lote";
            this.rowMP_Lote.Properties.Caption = "MP Lote";
            this.rowMP_Lote.Properties.FieldName = "MP Lote";
            // 
            // rowUsuario
            // 
            this.rowUsuario.Name = "rowUsuario";
            this.rowUsuario.Properties.Caption = "Usuario";
            this.rowUsuario.Properties.FieldName = "Usuario";
            // 
            // rowFecha_Consumo
            // 
            this.rowFecha_Consumo.Name = "rowFecha_Consumo";
            this.rowFecha_Consumo.Properties.Caption = "Fecha Consumo";
            this.rowFecha_Consumo.Properties.FieldName = "Fecha Consumo";
            this.rowFecha_Consumo.Properties.Format.FormatString = "g";
            this.rowFecha_Consumo.Properties.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // rowCantidad
            // 
            this.rowCantidad.Name = "rowCantidad";
            this.rowCantidad.Properties.Caption = "Cantidad";
            this.rowCantidad.Properties.FieldName = "Cantidad";
            // 
            // rowPeso
            // 
            this.rowPeso.Name = "rowPeso";
            this.rowPeso.Properties.Caption = "Peso";
            this.rowPeso.Properties.FieldName = "Peso";
            // 
            // rowEstado_Calidad
            // 
            this.rowEstado_Calidad.Name = "rowEstado_Calidad";
            this.rowEstado_Calidad.Properties.Caption = "Estado Calidad";
            this.rowEstado_Calidad.Properties.FieldName = "Estado Calidad";
            // 
            // rowid_tarima
            // 
            this.rowid_tarima.Name = "rowid_tarima";
            this.rowid_tarima.Properties.Caption = "id_tarima";
            this.rowid_tarima.Properties.FieldName = "id_tarima";
            this.rowid_tarima.Visible = false;
            // 
            // rowConsumido
            // 
            this.rowConsumido.Name = "rowConsumido";
            this.rowConsumido.Properties.Caption = "Consumido";
            this.rowConsumido.Properties.FieldName = "Consumido";
            // 
            // rowFecha_Entrega
            // 
            this.rowFecha_Entrega.Height = 18;
            this.rowFecha_Entrega.Name = "rowFecha_Entrega";
            this.rowFecha_Entrega.Properties.Caption = "Fecha Entrega";
            this.rowFecha_Entrega.Properties.FieldName = "Fecha Entrega";
            this.rowFecha_Entrega.Properties.Format.FormatString = "g";
            this.rowFecha_Entrega.Properties.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // rowEstado_Tarima
            // 
            this.rowEstado_Tarima.Name = "rowEstado_Tarima";
            this.rowEstado_Tarima.Properties.Caption = "Estado Tarima";
            this.rowEstado_Tarima.Properties.FieldName = "Estado Tarima";
            // 
            // rowLote_PT
            // 
            this.rowLote_PT.Height = 16;
            this.rowLote_PT.Name = "rowLote_PT";
            this.rowLote_PT.Properties.AllowEdit = false;
            this.rowLote_PT.Properties.Caption = "Lote PT";
            this.rowLote_PT.Properties.FieldName = "Lote PT";
            // 
            // rowPresentacion
            // 
            this.rowPresentacion.Name = "rowPresentacion";
            this.rowPresentacion.Properties.Caption = "Presentacion";
            this.rowPresentacion.Properties.FieldName = "Presentacion";
            // 
            // rowFecha_Vencimiento
            // 
            this.rowFecha_Vencimiento.Name = "rowFecha_Vencimiento";
            this.rowFecha_Vencimiento.Properties.Caption = "Fecha Vencimiento";
            this.rowFecha_Vencimiento.Properties.FieldName = "Fecha Vencimiento";
            // 
            // rowFecha_Ingreso
            // 
            this.rowFecha_Ingreso.Name = "rowFecha_Ingreso";
            this.rowFecha_Ingreso.Properties.Caption = "Fecha Ingreso";
            this.rowFecha_Ingreso.Properties.FieldName = "Fecha Ingreso";
            // 
            // rowProveedor_Name
            // 
            this.rowProveedor_Name.Name = "rowProveedor_Name";
            this.rowProveedor_Name.Properties.Caption = "Proveedor Name";
            this.rowProveedor_Name.Properties.FieldName = "Proveedor Name";
            // 
            // rowCardCode
            // 
            this.rowCardCode.Name = "rowCardCode";
            this.rowCardCode.Properties.Caption = "Card Code";
            this.rowCardCode.Properties.FieldName = "CardCode";
            // 
            // rowNum_Ingreso
            // 
            this.rowNum_Ingreso.Name = "rowNum_Ingreso";
            this.rowNum_Ingreso.Properties.Caption = "Num Ingreso";
            this.rowNum_Ingreso.Properties.FieldName = "Num Ingreso";
            // 
            // rowCodigo_Barra
            // 
            this.rowCodigo_Barra.Name = "rowCodigo_Barra";
            this.rowCodigo_Barra.Properties.Caption = "Codigo Barra";
            this.rowCodigo_Barra.Properties.FieldName = "Codigo Barra";
            // 
            // frmVentanaMsjTarimaAlimentacion
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 598);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.vGridControl1);
            this.Name = "frmVentanaMsjTarimaAlimentacion";
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMensajesTransaccionMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private dsMensajesTransaccionMP dsMensajesTransaccionMP1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.LabelControl lblMensaje;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowid;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRequisición;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowItemCode;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowid_materia_prima;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMateria_Prima_Nombre;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMP_Lote;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowUsuario;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowFecha_Consumo;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCantidad;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPeso;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowEstado_Calidad;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowid_tarima;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowConsumido;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowFecha_Entrega;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowEstado_Tarima;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowLote_PT;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPresentacion;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowFecha_Vencimiento;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowFecha_Ingreso;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowProveedor_Name;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCardCode;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowNum_Ingreso;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCodigo_Barra;
    }
}