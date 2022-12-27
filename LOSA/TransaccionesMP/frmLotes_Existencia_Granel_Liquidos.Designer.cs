
namespace LOSA.TransaccionesMP
{
    partial class frmLotes_Existencia_Granel_Liquidos
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLotes_Existencia_Granel_Liquidos));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdLoteExist = new DevExpress.XtraGrid.GridControl();
            this.dsTransaccionesMP1 = new LOSA.TransaccionesMP.dsTransaccionesMP();
            this.grdvLoteExist = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia_kg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reportItem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colwhs_equivalente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdLoteExist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvLoteExist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportItem)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLoteExist
            // 
            this.grdLoteExist.DataMember = "detalle_lote_granel_liquidos";
            this.grdLoteExist.DataSource = this.dsTransaccionesMP1;
            this.grdLoteExist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdLoteExist.Location = new System.Drawing.Point(0, 54);
            this.grdLoteExist.MainView = this.grdvLoteExist;
            this.grdLoteExist.Name = "grdLoteExist";
            this.grdLoteExist.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reportItem});
            this.grdLoteExist.Size = new System.Drawing.Size(937, 308);
            this.grdLoteExist.TabIndex = 1;
            this.grdLoteExist.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvLoteExist});
            // 
            // dsTransaccionesMP1
            // 
            this.dsTransaccionesMP1.DataSetName = "dsTransaccionesMP";
            this.dsTransaccionesMP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdvLoteExist
            // 
            this.grdvLoteExist.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdvLoteExist.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdvLoteExist.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdvLoteExist.Appearance.Row.Options.UseFont = true;
            this.grdvLoteExist.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre_comercial,
            this.collote_mp,
            this.colexistencia_kg,
            this.colfecha_ingreso,
            this.colfecha_vencimiento,
            this.colenable,
            this.colseleccionar,
            this.colwhs_equivalente});
            this.grdvLoteExist.GridControl = this.grdLoteExist;
            this.grdvLoteExist.Name = "grdvLoteExist";
            this.grdvLoteExist.OptionsView.ShowGroupPanel = false;
            // 
            // colnombre_comercial
            // 
            this.colnombre_comercial.Caption = "Materia Prima";
            this.colnombre_comercial.FieldName = "nombre_comercial";
            this.colnombre_comercial.Name = "colnombre_comercial";
            this.colnombre_comercial.OptionsColumn.AllowEdit = false;
            this.colnombre_comercial.Visible = true;
            this.colnombre_comercial.VisibleIndex = 0;
            this.colnombre_comercial.Width = 142;
            // 
            // collote_mp
            // 
            this.collote_mp.Caption = "Lote ";
            this.collote_mp.FieldName = "lote_mp";
            this.collote_mp.Name = "collote_mp";
            this.collote_mp.OptionsColumn.AllowEdit = false;
            this.collote_mp.Visible = true;
            this.collote_mp.VisibleIndex = 1;
            this.collote_mp.Width = 169;
            // 
            // colexistencia_kg
            // 
            this.colexistencia_kg.Caption = "Existencia";
            this.colexistencia_kg.DisplayFormat.FormatString = "n2";
            this.colexistencia_kg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia_kg.FieldName = "existencia_kg";
            this.colexistencia_kg.Name = "colexistencia_kg";
            this.colexistencia_kg.OptionsColumn.AllowEdit = false;
            this.colexistencia_kg.Visible = true;
            this.colexistencia_kg.VisibleIndex = 3;
            this.colexistencia_kg.Width = 200;
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.OptionsColumn.AllowEdit = false;
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.OptionsColumn.AllowEdit = false;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.AllowEdit = false;
            // 
            // colseleccionar
            // 
            this.colseleccionar.Caption = "Seleccionar:";
            this.colseleccionar.ColumnEdit = this.reportItem;
            this.colseleccionar.FieldName = "seleccionar";
            this.colseleccionar.Name = "colseleccionar";
            this.colseleccionar.Visible = true;
            this.colseleccionar.VisibleIndex = 4;
            this.colseleccionar.Width = 208;
            // 
            // reportItem
            // 
            this.reportItem.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.reportItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reportItem.Name = "reportItem";
            this.reportItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reportItem.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reportItem_ButtonClick);
            // 
            // colwhs_equivalente
            // 
            this.colwhs_equivalente.Caption = "Bodega";
            this.colwhs_equivalente.FieldName = "whs_equivalente";
            this.colwhs_equivalente.Name = "colwhs_equivalente";
            this.colwhs_equivalente.OptionsColumn.AllowEdit = false;
            this.colwhs_equivalente.Visible = true;
            this.colwhs_equivalente.VisibleIndex = 2;
            this.colwhs_equivalente.Width = 200;
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(787, 1);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(149, 48);
            this.cmdHome.TabIndex = 9;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(378, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(157, 25);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Seleccione el Lote";
            // 
            // frmLotes_Existencia_Granel_Liquidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 362);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.grdLoteExist);
            this.Name = "frmLotes_Existencia_Granel_Liquidos";
            ((System.ComponentModel.ISupportInitialize)(this.grdLoteExist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvLoteExist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdLoteExist;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvLoteExist;
        private dsTransaccionesMP dsTransaccionesMP1;
        private DevExpress.XtraGrid.Columns.GridColumn collote_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia_kg;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reportItem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn colwhs_equivalente;
    }
}