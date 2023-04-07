
namespace LOSA.Accesos.GrupoLosa
{
    partial class PrincipalGrupoLosa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalGrupoLosa));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlGruposLosa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Habilitado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botonCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGruposLosa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(823, 548);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlGruposLosa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(23, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 445);
            this.panel1.TabIndex = 0;
            // 
            // gridControlGruposLosa
            // 
            this.gridControlGruposLosa.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridControlGruposLosa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGruposLosa.Location = new System.Drawing.Point(0, 0);
            this.gridControlGruposLosa.MainView = this.gridView1;
            this.gridControlGruposLosa.Name = "gridControlGruposLosa";
            this.gridControlGruposLosa.Size = new System.Drawing.Size(777, 445);
            this.gridControlGruposLosa.TabIndex = 1;
            this.gridControlGruposLosa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Grupo,
            this.Habilitado});
            this.gridView1.GridControl = this.gridControlGruposLosa;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "id";
            this.Id.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Id.ImageOptions.Image")));
            this.Id.Name = "Id";
            this.Id.OptionsColumn.AllowEdit = false;
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            // 
            // Grupo
            // 
            this.Grupo.Caption = "Grupo";
            this.Grupo.FieldName = "grupo";
            this.Grupo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Grupo.ImageOptions.Image")));
            this.Grupo.Name = "Grupo";
            this.Grupo.OptionsColumn.AllowEdit = false;
            this.Grupo.Visible = true;
            this.Grupo.VisibleIndex = 1;
            // 
            // Habilitado
            // 
            this.Habilitado.Caption = "Habilitado";
            this.Habilitado.FieldName = "enable";
            this.Habilitado.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Habilitado.ImageOptions.Image")));
            this.Habilitado.Name = "Habilitado";
            this.Habilitado.OptionsColumn.AllowEdit = false;
            this.Habilitado.Visible = true;
            this.Habilitado.VisibleIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.botonCancelar);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(23, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 71);
            this.panel2.TabIndex = 1;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonCancelar.Appearance.BackColor = System.Drawing.Color.Red;
            this.botonCancelar.Appearance.Options.UseBackColor = true;
            this.botonCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("botonCancelar.ImageOptions.Image")));
            this.botonCancelar.Location = new System.Drawing.Point(671, 3);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(103, 45);
            this.botonCancelar.TabIndex = 5;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(126, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(103, 45);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Editar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(3, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(103, 45);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Crear";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // PrincipalGrupoLosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 548);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PrincipalGrupoLosa";
            this.Text = "Gestion grupos Losa";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGruposLosa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlGruposLosa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Grupo;
        private DevExpress.XtraGrid.Columns.GridColumn Habilitado;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton botonCancelar;
    }
}

