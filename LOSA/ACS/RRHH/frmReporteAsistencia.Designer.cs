
namespace LOSA.ACS.RRHH
{
    partial class frmReporteAsistencia
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsRRHH_reportes1 = new LOSA.ACS.RRHH.dsRRHH_reportes();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_emp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colturno_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colturno_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldesde = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhasta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsemana = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_lunes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_lunes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_martes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_martes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_miercoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_miercoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_jueves = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_jueves = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_viernes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_viernes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_sabado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_sabado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_domingo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_domingo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRRHH_reportes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "resumen_asistencia";
            this.gridControl1.DataSource = this.dsRRHH_reportes1;
            this.gridControl1.Location = new System.Drawing.Point(2, 101);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1126, 352);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsRRHH_reportes1
            // 
            this.dsRRHH_reportes1.DataSetName = "dsRRHH_reportes";
            this.dsRRHH_reportes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_marca,
            this.colid_emp,
            this.colcodigo,
            this.colnombre,
            this.colturno_id,
            this.colturno_name,
            this.coldesde,
            this.colhasta,
            this.colsemana,
            this.colentrada_lunes,
            this.colsalida_lunes,
            this.colentrada_martes,
            this.colsalida_martes,
            this.colentrada_miercoles,
            this.colsalida_miercoles,
            this.colentrada_jueves,
            this.colsalida_jueves,
            this.colentrada_viernes,
            this.colsalida_viernes,
            this.colentrada_sabado,
            this.colsalida_sabado,
            this.colentrada_domingo,
            this.colsalida_domingo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid_marca
            // 
            this.colid_marca.FieldName = "id_marca";
            this.colid_marca.Name = "colid_marca";
            // 
            // colid_emp
            // 
            this.colid_emp.FieldName = "id_emp";
            this.colid_emp.Name = "colid_emp";
            // 
            // colcodigo
            // 
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 41;
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 148;
            // 
            // colturno_id
            // 
            this.colturno_id.FieldName = "turno_id";
            this.colturno_id.Name = "colturno_id";
            // 
            // colturno_name
            // 
            this.colturno_name.FieldName = "turno_name";
            this.colturno_name.Name = "colturno_name";
            this.colturno_name.Visible = true;
            this.colturno_name.VisibleIndex = 2;
            this.colturno_name.Width = 42;
            // 
            // coldesde
            // 
            this.coldesde.DisplayFormat.FormatString = "d";
            this.coldesde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldesde.FieldName = "desde";
            this.coldesde.Name = "coldesde";
            this.coldesde.Visible = true;
            this.coldesde.VisibleIndex = 3;
            this.coldesde.Width = 66;
            // 
            // colhasta
            // 
            this.colhasta.DisplayFormat.FormatString = "d";
            this.colhasta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colhasta.FieldName = "hasta";
            this.colhasta.Name = "colhasta";
            this.colhasta.Visible = true;
            this.colhasta.VisibleIndex = 4;
            this.colhasta.Width = 60;
            // 
            // colsemana
            // 
            this.colsemana.FieldName = "semana";
            this.colsemana.Name = "colsemana";
            this.colsemana.Width = 26;
            // 
            // colentrada_lunes
            // 
            this.colentrada_lunes.DisplayFormat.FormatString = "t";
            this.colentrada_lunes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colentrada_lunes.FieldName = "entrada_lunes";
            this.colentrada_lunes.Name = "colentrada_lunes";
            this.colentrada_lunes.Visible = true;
            this.colentrada_lunes.VisibleIndex = 5;
            this.colentrada_lunes.Width = 54;
            // 
            // colsalida_lunes
            // 
            this.colsalida_lunes.DisplayFormat.FormatString = "t";
            this.colsalida_lunes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colsalida_lunes.FieldName = "salida_lunes";
            this.colsalida_lunes.Name = "colsalida_lunes";
            this.colsalida_lunes.Visible = true;
            this.colsalida_lunes.VisibleIndex = 6;
            this.colsalida_lunes.Width = 49;
            // 
            // colentrada_martes
            // 
            this.colentrada_martes.DisplayFormat.FormatString = "t";
            this.colentrada_martes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colentrada_martes.FieldName = "entrada_martes";
            this.colentrada_martes.Name = "colentrada_martes";
            this.colentrada_martes.Visible = true;
            this.colentrada_martes.VisibleIndex = 7;
            this.colentrada_martes.Width = 51;
            // 
            // colsalida_martes
            // 
            this.colsalida_martes.DisplayFormat.FormatString = "t";
            this.colsalida_martes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colsalida_martes.FieldName = "salida_martes";
            this.colsalida_martes.Name = "colsalida_martes";
            this.colsalida_martes.Visible = true;
            this.colsalida_martes.VisibleIndex = 8;
            this.colsalida_martes.Width = 49;
            // 
            // colentrada_miercoles
            // 
            this.colentrada_miercoles.DisplayFormat.FormatString = "t";
            this.colentrada_miercoles.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colentrada_miercoles.FieldName = "entrada_miercoles";
            this.colentrada_miercoles.Name = "colentrada_miercoles";
            this.colentrada_miercoles.Visible = true;
            this.colentrada_miercoles.VisibleIndex = 9;
            this.colentrada_miercoles.Width = 48;
            // 
            // colsalida_miercoles
            // 
            this.colsalida_miercoles.DisplayFormat.FormatString = "t";
            this.colsalida_miercoles.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colsalida_miercoles.FieldName = "salida_miercoles";
            this.colsalida_miercoles.Name = "colsalida_miercoles";
            this.colsalida_miercoles.Visible = true;
            this.colsalida_miercoles.VisibleIndex = 10;
            this.colsalida_miercoles.Width = 60;
            // 
            // colentrada_jueves
            // 
            this.colentrada_jueves.DisplayFormat.FormatString = "t";
            this.colentrada_jueves.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colentrada_jueves.FieldName = "entrada_jueves";
            this.colentrada_jueves.Name = "colentrada_jueves";
            this.colentrada_jueves.Visible = true;
            this.colentrada_jueves.VisibleIndex = 11;
            this.colentrada_jueves.Width = 58;
            // 
            // colsalida_jueves
            // 
            this.colsalida_jueves.DisplayFormat.FormatString = "t";
            this.colsalida_jueves.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colsalida_jueves.FieldName = "salida_jueves";
            this.colsalida_jueves.Name = "colsalida_jueves";
            this.colsalida_jueves.Visible = true;
            this.colsalida_jueves.VisibleIndex = 12;
            this.colsalida_jueves.Width = 61;
            // 
            // colentrada_viernes
            // 
            this.colentrada_viernes.DisplayFormat.FormatString = "t";
            this.colentrada_viernes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colentrada_viernes.FieldName = "entrada_viernes";
            this.colentrada_viernes.Name = "colentrada_viernes";
            this.colentrada_viernes.Visible = true;
            this.colentrada_viernes.VisibleIndex = 13;
            this.colentrada_viernes.Width = 58;
            // 
            // colsalida_viernes
            // 
            this.colsalida_viernes.DisplayFormat.FormatString = "t";
            this.colsalida_viernes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colsalida_viernes.FieldName = "salida_viernes";
            this.colsalida_viernes.Name = "colsalida_viernes";
            this.colsalida_viernes.Visible = true;
            this.colsalida_viernes.VisibleIndex = 14;
            this.colsalida_viernes.Width = 51;
            // 
            // colentrada_sabado
            // 
            this.colentrada_sabado.DisplayFormat.FormatString = "t";
            this.colentrada_sabado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colentrada_sabado.FieldName = "entrada_sabado";
            this.colentrada_sabado.Name = "colentrada_sabado";
            this.colentrada_sabado.Visible = true;
            this.colentrada_sabado.VisibleIndex = 15;
            this.colentrada_sabado.Width = 48;
            // 
            // colsalida_sabado
            // 
            this.colsalida_sabado.DisplayFormat.FormatString = "t";
            this.colsalida_sabado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colsalida_sabado.FieldName = "salida_sabado";
            this.colsalida_sabado.Name = "colsalida_sabado";
            this.colsalida_sabado.Visible = true;
            this.colsalida_sabado.VisibleIndex = 16;
            this.colsalida_sabado.Width = 52;
            // 
            // colentrada_domingo
            // 
            this.colentrada_domingo.DisplayFormat.FormatString = "t";
            this.colentrada_domingo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colentrada_domingo.FieldName = "entrada_domingo";
            this.colentrada_domingo.Name = "colentrada_domingo";
            this.colentrada_domingo.Visible = true;
            this.colentrada_domingo.VisibleIndex = 17;
            this.colentrada_domingo.Width = 57;
            // 
            // colsalida_domingo
            // 
            this.colsalida_domingo.DisplayFormat.FormatString = "t";
            this.colsalida_domingo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colsalida_domingo.FieldName = "salida_domingo";
            this.colsalida_domingo.Name = "colsalida_domingo";
            this.colsalida_domingo.Visible = true;
            this.colsalida_domingo.VisibleIndex = 18;
            this.colsalida_domingo.Width = 55;
            // 
            // frmReporteAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 514);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmReporteAsistencia";
            this.Text = "Resumen Asistencia";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRRHH_reportes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsRRHH_reportes dsRRHH_reportes1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_marca;
        private DevExpress.XtraGrid.Columns.GridColumn colid_emp;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colturno_id;
        private DevExpress.XtraGrid.Columns.GridColumn colturno_name;
        private DevExpress.XtraGrid.Columns.GridColumn colsemana;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_lunes;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_lunes;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_martes;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_martes;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_miercoles;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_miercoles;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_jueves;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_jueves;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_viernes;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_viernes;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_sabado;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_sabado;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_domingo;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_domingo;
        private DevExpress.XtraGrid.Columns.GridColumn coldesde;
        private DevExpress.XtraGrid.Columns.GridColumn colhasta;
    }
}