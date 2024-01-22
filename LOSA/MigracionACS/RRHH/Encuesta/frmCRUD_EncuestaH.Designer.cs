using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.RRHH.Encuesta
{
    partial class frmCRUD_EncuestaH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRUD_EncuestaH));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsEncuesta1 = new LOSA.MigracionACS.RRHH.Encuesta.dsEncuesta();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinstrucciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colanio_evaluar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_copiar_desde = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdCopiarDesdeEsta = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnEncuesta = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEncuesta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCopiarDesdeEsta)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "crud_encuesta_h";
            this.gridControl1.DataSource = this.dsEncuesta1;
            this.gridControl1.Location = new System.Drawing.Point(1, 67);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdCopiarDesdeEsta});
            this.gridControl1.Size = new System.Drawing.Size(836, 424);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsEncuesta1
            // 
            this.dsEncuesta1.DataSetName = "dsEncuesta";
            this.dsEncuesta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.colinstrucciones,
            this.colenable,
            this.colestado,
            this.colfecha,
            this.colcodigo,
            this.colanio_evaluar,
            this.colid_user,
            this.colusuario_name,
            this.col_copiar_desde});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 2;
            this.coldescripcion.Width = 300;
            // 
            // colinstrucciones
            // 
            this.colinstrucciones.Caption = "Instrucciones";
            this.colinstrucciones.FieldName = "instrucciones";
            this.colinstrucciones.Name = "colinstrucciones";
            this.colinstrucciones.OptionsColumn.ReadOnly = true;
            this.colinstrucciones.Visible = true;
            this.colinstrucciones.VisibleIndex = 3;
            this.colinstrucciones.Width = 149;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.ReadOnly = true;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.ReadOnly = true;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 4;
            this.colestado.Width = 68;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.DisplayFormat.FormatString = "d";
            this.colfecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 5;
            this.colfecha.Width = 61;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Código";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.ReadOnly = true;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 115;
            // 
            // colanio_evaluar
            // 
            this.colanio_evaluar.Caption = "Año";
            this.colanio_evaluar.FieldName = "anio_evaluar";
            this.colanio_evaluar.Name = "colanio_evaluar";
            this.colanio_evaluar.OptionsColumn.ReadOnly = true;
            this.colanio_evaluar.Visible = true;
            this.colanio_evaluar.VisibleIndex = 1;
            this.colanio_evaluar.Width = 44;
            // 
            // colid_user
            // 
            this.colid_user.FieldName = "id_user";
            this.colid_user.Name = "colid_user";
            this.colid_user.OptionsColumn.ReadOnly = true;
            // 
            // colusuario_name
            // 
            this.colusuario_name.Caption = "Usuario";
            this.colusuario_name.FieldName = "usuario_name";
            this.colusuario_name.Name = "colusuario_name";
            this.colusuario_name.OptionsColumn.ReadOnly = true;
            this.colusuario_name.Visible = true;
            this.colusuario_name.VisibleIndex = 6;
            this.colusuario_name.Width = 74;
            // 
            // col_copiar_desde
            // 
            this.col_copiar_desde.Caption = "Copiar desde aqui";
            this.col_copiar_desde.ColumnEdit = this.cmdCopiarDesdeEsta;
            this.col_copiar_desde.Name = "col_copiar_desde";
            this.col_copiar_desde.Visible = true;
            this.col_copiar_desde.VisibleIndex = 7;
            // 
            // cmdCopiarDesdeEsta
            // 
            this.cmdCopiarDesdeEsta.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdCopiarDesdeEsta.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdCopiarDesdeEsta.Name = "cmdCopiarDesdeEsta";
            this.cmdCopiarDesdeEsta.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdCopiarDesdeEsta.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdCopiarDesdeEsta_ButtonClick);
            // 
            // btnEncuesta
            // 
            this.btnEncuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncuesta.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnEncuesta.Appearance.Options.UseFont = true;
            this.btnEncuesta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnEncuesta.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEncuesta.ImageOptions.SvgImage")));
            this.btnEncuesta.Location = new System.Drawing.Point(1, 12);
            this.btnEncuesta.Name = "btnEncuesta";
            this.btnEncuesta.Size = new System.Drawing.Size(137, 44);
            this.btnEncuesta.TabIndex = 8;
            this.btnEncuesta.Text = "Agregar \r\nEncuesta";
            this.btnEncuesta.Click += new System.EventHandler(this.btnEncuesta_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(309, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(165, 22);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Listado de Encuestas";
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(700, 12);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(137, 44);
            this.cmdCerrar.TabIndex = 10;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // frmCRUD_EncuestaH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 493);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnEncuesta);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmCRUD_EncuestaH";
            this.Text = "Listado de Encuestas";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEncuesta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCopiarDesdeEsta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GridControl gridControl1;
        private GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnEncuesta;
        private LabelControl labelControl1;
        private SimpleButton cmdCerrar;
        private dsEncuesta dsEncuesta1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colinstrucciones;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colanio_evaluar;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_name;
        private DevExpress.XtraGrid.Columns.GridColumn col_copiar_desde;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdCopiarDesdeEsta;
    }
}