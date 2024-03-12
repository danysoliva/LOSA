using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Calidad.LoteConfConsumo;
using LOSA.Finanzas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOSA.Compras;
using LOSA.Clases;

namespace LOSA.Compras
{
    public partial class frmAddNewItemOC : DevExpress.XtraEditors.XtraForm
    {
        public string ItemCode;
        public string ItemName;
        public string Capitulo;
        public string Partida;
        public decimal Unidades, PrecioUnitario, Total;
        public string CodeISV;

        DataOperations dp = new DataOperations();
        public frmAddNewItemOC()
        {
            InitializeComponent();
            CargarCapitulos();
        }

        private void CargarCapitulos()
        {
            try
            {
                string query = @"[sp_cm_orden_compra_capitulos_codigos]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsExoneracion1.capitulos.Clear();
                adat.Fill(dsExoneracion1.capitulos);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSearchMP frm = new frmSearchMP(frmSearchMP.TipoBusqueda.Items);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ItemCode = frm.ItemSeleccionado.ItemCode;
                ItemName = frm.ItemSeleccionado.ItemName;
                txtItem.Text = frm.ItemSeleccionado.ItemCode + " - " + frm.ItemSeleccionado.ItemName;
            }
        }

        private void gridLookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void CargarPartidasArancelarias(string pCode)
        {
            try
            {
                string query = @"[sp_cm_exoneracion_partida_arancelaria]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Code", pCode.Trim());
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsExoneracion1.partida_arancelaria.Clear();
                adat.Fill(dsExoneracion1.partida_arancelaria);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void txtUd_EditValueChanged(object sender, EventArgs e)
        {
            if (TsExoOExe.IsOn) //Exonerada
            {
                CalcularTotal();
                CalcularSaldos();
            }
            else
            {
                CalcularTotal();
                txtSaldoDisponible.EditValue = 0;
                txtSaldoPorConsumir.EditValue = 0;
                txtNuevoSaldo.EditValue = 0;
            }
            
            
        }

        private void grdCapitulo_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(grdCapitulo.EditValue.ToString()))
            {
                CargarPartidasArancelarias(grdCapitulo.EditValue.ToString());
                dsExoneracion1.partida_arancelaria.AcceptChanges();
                if (grdvPartidas.RowCount == 0) //No Existe Partida Relacionada con Este Capitulo
                {
                    DetalleExoneracion Saldo = new DetalleExoneracion();
                    Saldo.RecuperarSaldoCapitulo(grdCapitulo.EditValue.ToString());
                    txtSaldoDisponible.EditValue = Saldo.SaldoDisponible;
                    txtUdDisponible.EditValue = 0;
                    grdPartidaAranc.Enabled = false;
                }
                else
                {
                    grdPartidaAranc.Enabled = true;
                }
            }
        }

        private void CalcularSaldos()
        {
            if (grdvPartidas.RowCount == 0) //No se toman en cuenta Unidades
            {
                txtSaldoPorConsumir.EditValue = txtTotal.EditValue;
                txtUdporConsumir.EditValue = 0;

                txtNuevoSaldo.EditValue = Convert.ToDecimal(txtSaldoDisponible.EditValue) - Convert.ToDecimal(txtSaldoPorConsumir.EditValue);

                txtUdNueva.EditValue = 0;
            }
            else
            {
                txtSaldoPorConsumir.EditValue = txtTotal.EditValue;
                txtUdporConsumir.EditValue = txtUd.EditValue;

                txtNuevoSaldo.EditValue = Convert.ToDecimal(txtSaldoDisponible.EditValue) - Convert.ToDecimal(txtSaldoPorConsumir.EditValue);

                txtUdNueva.EditValue = Convert.ToDecimal(txtUdDisponible.EditValue) - Convert.ToDecimal(txtUdporConsumir.EditValue);
            }

            

        }

        private void grdPartidaAranc_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(grdPartidaAranc.Text))
            {
                DetalleExoneracion dSaldo = new DetalleExoneracion();
                dSaldo.RecuperarSaldoCapituloPartida(grdCapitulo.EditValue.ToString(), grdPartidaAranc.EditValue.ToString());
                txtSaldoDisponible.EditValue = dSaldo.SaldoDisponible;
                txtUdDisponible.EditValue = dSaldo.UnidadesDisponible;

                CalcularSaldos();
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItem.Text))
            {
                CajaDialogo.Error("Debe Seleccionar un Item!");
                btnAdd.Focus();
                return;
            }

            if (TsExoOExe.IsOn) //Exonerada
            {
                if (string.IsNullOrEmpty(grdCapitulo.Text))
                {
                    CajaDialogo.Error("En Ordenes Exoneradas debe seleccionar un Capitulo!");
                    return;
                }

                if (Convert.ToDecimal(txtSaldoDisponible.EditValue) == 0)
                {
                    CajaDialogo.Error("No existe Saldo Disponible en esta combinacion de Capitulos-Partida!");
                    return;
                }

                if (grdvPartidas.RowCount > 0)
                {
                    if (string.IsNullOrEmpty(grdPartidaAranc.Text))
                    {
                        CajaDialogo.Error("Debe seleccionar un Partida Arancelaria!");
                        return;
                    }

                    if (Convert.ToDecimal(txtUdDisponible.EditValue) <= 0)
                    {
                        CajaDialogo.Error("No hay Unidades Disponibles en esta Partida Arancelaria!");
                        return;
                    }
                }
            }
            else
            {
                grdCapitulo.EditValue = 0;
                grdCapitulo.EditValue = 0;
            }
           
            

            if (Convert.ToDecimal(txtUd.EditValue) <= 0)
            {
                CajaDialogo.Error("Debe colorar al menos una unidad(1)");
                return;
            }

            if (Convert.ToDecimal(txtUnitPrice.EditValue) <= 0)
            {
                CajaDialogo.Error("Debe colocar una Precio Unitario!");
                return;
            }

            Capitulo = grdCapitulo.EditValue.ToString();
            Partida = grdCapitulo.EditValue.ToString();
            Unidades = Convert.ToDecimal(txtUd.EditValue);
            PrecioUnitario = Convert.ToDecimal(txtUnitPrice.EditValue);

            if (TsExoOExe.IsOn)
                CodeISV = "EXO";
            else
                CodeISV = "EXE";

            Total = Convert.ToDecimal(txtTotal.EditValue);

            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        //private void InitializeComponent()
        //{
        //    this.components = new System.ComponentModel.Container();
        //    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewItemOC));
        //    this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
        //    this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
        //    this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
        //    this.grdCapitulo = new DevExpress.XtraEditors.GridLookUpEdit();
        //    this.capitulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
        //    this.dsExoneracion1 = new LOSA.Finanzas.dsExoneracion();
        //    this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
        //    this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
        //    this.colU_AQUA_Desc = new DevExpress.XtraGrid.Columns.GridColumn();
        //    this.colconcat_ = new DevExpress.XtraGrid.Columns.GridColumn();
        //    this.grdPartidaAranc = new DevExpress.XtraEditors.GridLookUpEdit();
        //    this.partidaarancelariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
        //    this.grdvPartidas = new DevExpress.XtraGrid.Views.Grid.GridView();
        //    this.colPartida_arancelaria = new DevExpress.XtraGrid.Columns.GridColumn();
        //    this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
        //    this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
        //    this.txtUnitPrice = new DevExpress.XtraEditors.SpinEdit();
        //    this.txtUd = new DevExpress.XtraEditors.SpinEdit();
        //    this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
        //    this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
        //    this.txtItem = new DevExpress.XtraEditors.TextEdit();
        //    this.txtTotal = new DevExpress.XtraEditors.SpinEdit();
        //    this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
        //    this.dsCompras1 = new LOSA.Compras.dsCompras();
        //    this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
        //    this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
        //    this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
        //    this.txtNuevoSaldo = new DevExpress.XtraEditors.SpinEdit();
        //    this.txtSaldoDisponible = new DevExpress.XtraEditors.SpinEdit();
        //    this.txtSaldoPorConsumir = new DevExpress.XtraEditors.SpinEdit();
        //    this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
        //    this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
        //    this.txtUdNueva = new DevExpress.XtraEditors.SpinEdit();
        //    this.txtUdDisponible = new DevExpress.XtraEditors.SpinEdit();
        //    this.txtUdporConsumir = new DevExpress.XtraEditors.SpinEdit();
        //    this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
        //    this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
        //    this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
        //    this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
        //    this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
        //    this.TsExoOExe = new DevExpress.XtraEditors.ToggleSwitch();
        //    this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
        //    ((System.ComponentModel.ISupportInitialize)(this.grdCapitulo.Properties)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.capitulosBindingSource)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.dsExoneracion1)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.grdPartidaAranc.Properties)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.partidaarancelariaBindingSource)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.grdvPartidas)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice.Properties)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtUd.Properties)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtItem.Properties)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtNuevoSaldo.Properties)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtSaldoDisponible.Properties)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtSaldoPorConsumir.Properties)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtUdNueva.Properties)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtUdDisponible.Properties)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtUdporConsumir.Properties)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.TsExoOExe.Properties)).BeginInit();
        //    this.SuspendLayout();
        //    // 
        //    // labelControl16
        //    // 
        //    this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.labelControl16.Appearance.Options.UseFont = true;
        //    this.labelControl16.Location = new System.Drawing.Point(31, 47);
        //    this.labelControl16.Name = "labelControl16";
        //    this.labelControl16.Size = new System.Drawing.Size(35, 18);
        //    this.labelControl16.TabIndex = 94;
        //    this.labelControl16.Text = "Item";
        //    // 
        //    // btnAdd
        //    // 
        //    this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
        //    this.btnAdd.Location = new System.Drawing.Point(548, 32);
        //    this.btnAdd.Name = "btnAdd";
        //    this.btnAdd.Size = new System.Drawing.Size(42, 43);
        //    this.btnAdd.TabIndex = 1;
        //    this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
        //    // 
        //    // labelControl1
        //    // 
        //    this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.labelControl1.Appearance.Options.UseFont = true;
        //    this.labelControl1.Location = new System.Drawing.Point(31, 129);
        //    this.labelControl1.Name = "labelControl1";
        //    this.labelControl1.Size = new System.Drawing.Size(62, 18);
        //    this.labelControl1.TabIndex = 96;
        //    this.labelControl1.Text = "Capitulo";
        //    // 
        //    // grdCapitulo
        //    // 
        //    this.grdCapitulo.Location = new System.Drawing.Point(186, 124);
        //    this.grdCapitulo.Name = "grdCapitulo";
        //    this.grdCapitulo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.grdCapitulo.Properties.Appearance.Options.UseFont = true;
        //    this.grdCapitulo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
        //    new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
        //    this.grdCapitulo.Properties.DataSource = this.capitulosBindingSource;
        //    this.grdCapitulo.Properties.DisplayMember = "concat_";
        //    this.grdCapitulo.Properties.NullText = "";
        //    this.grdCapitulo.Properties.PopupFormSize = new System.Drawing.Size(500, 400);
        //    this.grdCapitulo.Properties.PopupView = this.gridLookUpEdit1View;
        //    this.grdCapitulo.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
        //    this.grdCapitulo.Properties.ValueMember = "Code";
        //    this.grdCapitulo.Properties.EditValueChanged += new System.EventHandler(this.gridLookUpEdit1_Properties_EditValueChanged);
        //    this.grdCapitulo.Size = new System.Drawing.Size(365, 28);
        //    this.grdCapitulo.TabIndex = 2;
        //    this.grdCapitulo.EditValueChanged += new System.EventHandler(this.grdCapitulo_EditValueChanged);
        //    // 
        //    // capitulosBindingSource
        //    // 
        //    this.capitulosBindingSource.DataMember = "capitulos";
        //    this.capitulosBindingSource.DataSource = this.dsExoneracion1;
        //    // 
        //    // dsExoneracion1
        //    // 
        //    this.dsExoneracion1.DataSetName = "dsExoneracion";
        //    this.dsExoneracion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        //    // 
        //    // gridLookUpEdit1View
        //    // 
        //    this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
        //    this.colCode,
        //    this.colU_AQUA_Desc,
        //    this.colconcat_});
        //    this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
        //    this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
        //    this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
        //    this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
        //    this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
        //    // 
        //    // colCode
        //    // 
        //    this.colCode.FieldName = "Code";
        //    this.colCode.Name = "colCode";
        //    // 
        //    // colU_AQUA_Desc
        //    // 
        //    this.colU_AQUA_Desc.FieldName = "U_AQUA_Desc";
        //    this.colU_AQUA_Desc.Name = "colU_AQUA_Desc";
        //    // 
        //    // colconcat_
        //    // 
        //    this.colconcat_.Caption = "Capitulo";
        //    this.colconcat_.FieldName = "concat_";
        //    this.colconcat_.Name = "colconcat_";
        //    this.colconcat_.Visible = true;
        //    this.colconcat_.VisibleIndex = 0;
        //    // 
        //    // grdPartidaAranc
        //    // 
        //    this.grdPartidaAranc.Location = new System.Drawing.Point(186, 168);
        //    this.grdPartidaAranc.Name = "grdPartidaAranc";
        //    this.grdPartidaAranc.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.grdPartidaAranc.Properties.Appearance.Options.UseFont = true;
        //    this.grdPartidaAranc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
        //    new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
        //    this.grdPartidaAranc.Properties.DataSource = this.partidaarancelariaBindingSource;
        //    this.grdPartidaAranc.Properties.DisplayMember = "Partida_arancelaria";
        //    this.grdPartidaAranc.Properties.NullText = "";
        //    this.grdPartidaAranc.Properties.PopupFormSize = new System.Drawing.Size(500, 120);
        //    this.grdPartidaAranc.Properties.PopupView = this.grdvPartidas;
        //    this.grdPartidaAranc.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
        //    this.grdPartidaAranc.Properties.ValueMember = "Partida_arancelaria";
        //    this.grdPartidaAranc.Size = new System.Drawing.Size(345, 28);
        //    this.grdPartidaAranc.TabIndex = 3;
        //    this.grdPartidaAranc.EditValueChanged += new System.EventHandler(this.grdPartidaAranc_EditValueChanged);
        //    // 
        //    // partidaarancelariaBindingSource
        //    // 
        //    this.partidaarancelariaBindingSource.DataMember = "partida_arancelaria";
        //    this.partidaarancelariaBindingSource.DataSource = this.dsExoneracion1;
        //    // 
        //    // grdvPartidas
        //    // 
        //    this.grdvPartidas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
        //    this.colPartida_arancelaria,
        //    this.colDescripcion});
        //    this.grdvPartidas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
        //    this.grdvPartidas.Name = "grdvPartidas";
        //    this.grdvPartidas.OptionsEditForm.PopupEditFormWidth = 1200;
        //    this.grdvPartidas.OptionsSelection.EnableAppearanceFocusedCell = false;
        //    this.grdvPartidas.OptionsView.ShowGroupPanel = false;
        //    // 
        //    // colPartida_arancelaria
        //    // 
        //    this.colPartida_arancelaria.Caption = "Partida";
        //    this.colPartida_arancelaria.FieldName = "Partida_arancelaria";
        //    this.colPartida_arancelaria.Name = "colPartida_arancelaria";
        //    this.colPartida_arancelaria.Visible = true;
        //    this.colPartida_arancelaria.VisibleIndex = 0;
        //    // 
        //    // colDescripcion
        //    // 
        //    this.colDescripcion.Caption = "Descripcion";
        //    this.colDescripcion.FieldName = "Descripcion";
        //    this.colDescripcion.Name = "colDescripcion";
        //    this.colDescripcion.Visible = true;
        //    this.colDescripcion.VisibleIndex = 1;
        //    // 
        //    // labelControl2
        //    // 
        //    this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.labelControl2.Appearance.Options.UseFont = true;
        //    this.labelControl2.Location = new System.Drawing.Point(31, 173);
        //    this.labelControl2.Name = "labelControl2";
        //    this.labelControl2.Size = new System.Drawing.Size(128, 18);
        //    this.labelControl2.TabIndex = 98;
        //    this.labelControl2.Text = "Part. Arancelaria";
        //    // 
        //    // txtUnitPrice
        //    // 
        //    this.txtUnitPrice.EditValue = new decimal(new int[] {
        //    0,
        //    0,
        //    0,
        //    0});
        //    this.txtUnitPrice.Location = new System.Drawing.Point(289, 293);
        //    this.txtUnitPrice.Name = "txtUnitPrice";
        //    this.txtUnitPrice.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
        //    this.txtUnitPrice.Properties.Appearance.Options.UseFont = true;
        //    this.txtUnitPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
        //    new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
        //    this.txtUnitPrice.Properties.MaskSettings.Set("mask", "n");
        //    this.txtUnitPrice.Size = new System.Drawing.Size(147, 28);
        //    this.txtUnitPrice.TabIndex = 5;
        //    this.txtUnitPrice.EditValueChanged += new System.EventHandler(this.txtUnitPrice_EditValueChanged);
        //    // 
        //    // txtUd
        //    // 
        //    this.txtUd.EditValue = new decimal(new int[] {
        //    1,
        //    0,
        //    0,
        //    0});
        //    this.txtUd.Location = new System.Drawing.Point(289, 237);
        //    this.txtUd.Name = "txtUd";
        //    this.txtUd.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
        //    this.txtUd.Properties.Appearance.Options.UseFont = true;
        //    this.txtUd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
        //    new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
        //    this.txtUd.Properties.MaskSettings.Set("mask", "d");
        //    this.txtUd.Size = new System.Drawing.Size(147, 28);
        //    this.txtUd.TabIndex = 4;
        //    this.txtUd.EditValueChanged += new System.EventHandler(this.txtUd_EditValueChanged);
        //    // 
        //    // labelControl3
        //    // 
        //    this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.labelControl3.Appearance.Options.UseFont = true;
        //    this.labelControl3.Location = new System.Drawing.Point(155, 242);
        //    this.labelControl3.Name = "labelControl3";
        //    this.labelControl3.Size = new System.Drawing.Size(66, 18);
        //    this.labelControl3.TabIndex = 102;
        //    this.labelControl3.Text = "Cantidad";
        //    // 
        //    // labelControl4
        //    // 
        //    this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.labelControl4.Appearance.Options.UseFont = true;
        //    this.labelControl4.Location = new System.Drawing.Point(155, 298);
        //    this.labelControl4.Name = "labelControl4";
        //    this.labelControl4.Size = new System.Drawing.Size(113, 18);
        //    this.labelControl4.TabIndex = 103;
        //    this.labelControl4.Text = "Precio Unitario";
        //    // 
        //    // txtItem
        //    // 
        //    this.txtItem.Enabled = false;
        //    this.txtItem.Location = new System.Drawing.Point(177, 42);
        //    this.txtItem.Name = "txtItem";
        //    this.txtItem.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.txtItem.Properties.Appearance.Options.UseFont = true;
        //    this.txtItem.Size = new System.Drawing.Size(365, 28);
        //    this.txtItem.TabIndex = 104;
        //    // 
        //    // txtTotal
        //    // 
        //    this.txtTotal.EditValue = new decimal(new int[] {
        //    0,
        //    0,
        //    0,
        //    0});
        //    this.txtTotal.Enabled = false;
        //    this.txtTotal.Location = new System.Drawing.Point(289, 352);
        //    this.txtTotal.Name = "txtTotal";
        //    this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
        //    this.txtTotal.Properties.Appearance.Options.UseFont = true;
        //    this.txtTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
        //    new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
        //    this.txtTotal.Properties.MaskSettings.Set("mask", "n");
        //    this.txtTotal.Size = new System.Drawing.Size(147, 28);
        //    this.txtTotal.TabIndex = 106;
        //    // 
        //    // labelControl5
        //    // 
        //    this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.labelControl5.Appearance.Options.UseFont = true;
        //    this.labelControl5.Location = new System.Drawing.Point(155, 357);
        //    this.labelControl5.Name = "labelControl5";
        //    this.labelControl5.Size = new System.Drawing.Size(38, 18);
        //    this.labelControl5.TabIndex = 107;
        //    this.labelControl5.Text = "Total";
        //    // 
        //    // dsCompras1
        //    // 
        //    this.dsCompras1.DataSetName = "dsCompras";
        //    this.dsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        //    // 
        //    // labelControl6
        //    // 
        //    this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.labelControl6.Appearance.Options.UseFont = true;
        //    this.labelControl6.Location = new System.Drawing.Point(30, 582);
        //    this.labelControl6.Name = "labelControl6";
        //    this.labelControl6.Size = new System.Drawing.Size(94, 18);
        //    this.labelControl6.TabIndex = 110;
        //    this.labelControl6.Text = "Nuevo Saldo";
        //    // 
        //    // labelControl7
        //    // 
        //    this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.labelControl7.Appearance.Options.UseFont = true;
        //    this.labelControl7.Location = new System.Drawing.Point(30, 539);
        //    this.labelControl7.Name = "labelControl7";
        //    this.labelControl7.Size = new System.Drawing.Size(100, 18);
        //    this.labelControl7.TabIndex = 109;
        //    this.labelControl7.Text = "Por Consumir";
        //    // 
        //    // labelControl8
        //    // 
        //    this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.labelControl8.Appearance.Options.UseFont = true;
        //    this.labelControl8.Location = new System.Drawing.Point(30, 496);
        //    this.labelControl8.Name = "labelControl8";
        //    this.labelControl8.Size = new System.Drawing.Size(125, 18);
        //    this.labelControl8.TabIndex = 108;
        //    this.labelControl8.Text = "Saldo Disponible";
        //    // 
        //    // txtNuevoSaldo
        //    // 
        //    this.txtNuevoSaldo.EditValue = new decimal(new int[] {
        //    0,
        //    0,
        //    0,
        //    0});
        //    this.txtNuevoSaldo.Enabled = false;
        //    this.txtNuevoSaldo.Location = new System.Drawing.Point(164, 577);
        //    this.txtNuevoSaldo.Name = "txtNuevoSaldo";
        //    this.txtNuevoSaldo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
        //    this.txtNuevoSaldo.Properties.Appearance.Options.UseFont = true;
        //    this.txtNuevoSaldo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
        //    new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
        //    this.txtNuevoSaldo.Properties.MaskSettings.Set("mask", "n");
        //    this.txtNuevoSaldo.Size = new System.Drawing.Size(147, 28);
        //    this.txtNuevoSaldo.TabIndex = 113;
        //    // 
        //    // txtSaldoDisponible
        //    // 
        //    this.txtSaldoDisponible.EditValue = new decimal(new int[] {
        //    0,
        //    0,
        //    0,
        //    0});
        //    this.txtSaldoDisponible.Enabled = false;
        //    this.txtSaldoDisponible.Location = new System.Drawing.Point(164, 491);
        //    this.txtSaldoDisponible.Name = "txtSaldoDisponible";
        //    this.txtSaldoDisponible.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
        //    this.txtSaldoDisponible.Properties.Appearance.Options.UseFont = true;
        //    this.txtSaldoDisponible.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
        //    new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
        //    this.txtSaldoDisponible.Properties.MaskSettings.Set("mask", "f");
        //    this.txtSaldoDisponible.Size = new System.Drawing.Size(147, 28);
        //    this.txtSaldoDisponible.TabIndex = 112;
        //    // 
        //    // txtSaldoPorConsumir
        //    // 
        //    this.txtSaldoPorConsumir.EditValue = new decimal(new int[] {
        //    0,
        //    0,
        //    0,
        //    0});
        //    this.txtSaldoPorConsumir.Enabled = false;
        //    this.txtSaldoPorConsumir.Location = new System.Drawing.Point(164, 534);
        //    this.txtSaldoPorConsumir.Name = "txtSaldoPorConsumir";
        //    this.txtSaldoPorConsumir.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
        //    this.txtSaldoPorConsumir.Properties.Appearance.Options.UseFont = true;
        //    this.txtSaldoPorConsumir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
        //    new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
        //    this.txtSaldoPorConsumir.Properties.MaskSettings.Set("mask", "n");
        //    this.txtSaldoPorConsumir.Size = new System.Drawing.Size(147, 28);
        //    this.txtSaldoPorConsumir.TabIndex = 111;
        //    // 
        //    // separatorControl1
        //    // 
        //    this.separatorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        //    | System.Windows.Forms.AnchorStyles.Right)));
        //    this.separatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
        //    this.separatorControl1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        //    this.separatorControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
        //    this.separatorControl1.Location = new System.Drawing.Point(0, 449);
        //    this.separatorControl1.Name = "separatorControl1";
        //    this.separatorControl1.Size = new System.Drawing.Size(710, 21);
        //    this.separatorControl1.TabIndex = 114;
        //    // 
        //    // labelControl9
        //    // 
        //    this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.labelControl9.Appearance.Options.UseFont = true;
        //    this.labelControl9.Location = new System.Drawing.Point(273, 467);
        //    this.labelControl9.Name = "labelControl9";
        //    this.labelControl9.Size = new System.Drawing.Size(136, 18);
        //    this.labelControl9.TabIndex = 115;
        //    this.labelControl9.Text = "Resumen de Saldo";
        //    // 
        //    // txtUdNueva
        //    // 
        //    this.txtUdNueva.EditValue = new decimal(new int[] {
        //    0,
        //    0,
        //    0,
        //    0});
        //    this.txtUdNueva.Enabled = false;
        //    this.txtUdNueva.Location = new System.Drawing.Point(483, 577);
        //    this.txtUdNueva.Name = "txtUdNueva";
        //    this.txtUdNueva.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
        //    this.txtUdNueva.Properties.Appearance.Options.UseFont = true;
        //    this.txtUdNueva.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
        //    new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
        //    this.txtUdNueva.Properties.MaskSettings.Set("mask", "d");
        //    this.txtUdNueva.Size = new System.Drawing.Size(116, 28);
        //    this.txtUdNueva.TabIndex = 121;
        //    // 
        //    // txtUdDisponible
        //    // 
        //    this.txtUdDisponible.EditValue = new decimal(new int[] {
        //    0,
        //    0,
        //    0,
        //    0});
        //    this.txtUdDisponible.Enabled = false;
        //    this.txtUdDisponible.Location = new System.Drawing.Point(483, 491);
        //    this.txtUdDisponible.Name = "txtUdDisponible";
        //    this.txtUdDisponible.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
        //    this.txtUdDisponible.Properties.Appearance.Options.UseFont = true;
        //    this.txtUdDisponible.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
        //    new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
        //    this.txtUdDisponible.Properties.MaskSettings.Set("mask", "d");
        //    this.txtUdDisponible.Size = new System.Drawing.Size(116, 28);
        //    this.txtUdDisponible.TabIndex = 120;
        //    // 
        //    // txtUdporConsumir
        //    // 
        //    this.txtUdporConsumir.EditValue = new decimal(new int[] {
        //    0,
        //    0,
        //    0,
        //    0});
        //    this.txtUdporConsumir.Enabled = false;
        //    this.txtUdporConsumir.Location = new System.Drawing.Point(483, 534);
        //    this.txtUdporConsumir.Name = "txtUdporConsumir";
        //    this.txtUdporConsumir.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
        //    this.txtUdporConsumir.Properties.Appearance.Options.UseFont = true;
        //    this.txtUdporConsumir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
        //    new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
        //    this.txtUdporConsumir.Properties.MaskSettings.Set("mask", "d");
        //    this.txtUdporConsumir.Size = new System.Drawing.Size(116, 28);
        //    this.txtUdporConsumir.TabIndex = 119;
        //    // 
        //    // labelControl10
        //    // 
        //    this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.labelControl10.Appearance.Options.UseFont = true;
        //    this.labelControl10.Location = new System.Drawing.Point(351, 582);
        //    this.labelControl10.Name = "labelControl10";
        //    this.labelControl10.Size = new System.Drawing.Size(94, 18);
        //    this.labelControl10.TabIndex = 118;
        //    this.labelControl10.Text = "Nuevo Saldo";
        //    // 
        //    // labelControl11
        //    // 
        //    this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.labelControl11.Appearance.Options.UseFont = true;
        //    this.labelControl11.Location = new System.Drawing.Point(351, 539);
        //    this.labelControl11.Name = "labelControl11";
        //    this.labelControl11.Size = new System.Drawing.Size(100, 18);
        //    this.labelControl11.TabIndex = 117;
        //    this.labelControl11.Text = "Por Consumir";
        //    // 
        //    // labelControl12
        //    // 
        //    this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.labelControl12.Appearance.Options.UseFont = true;
        //    this.labelControl12.Location = new System.Drawing.Point(351, 496);
        //    this.labelControl12.Name = "labelControl12";
        //    this.labelControl12.Size = new System.Drawing.Size(116, 18);
        //    this.labelControl12.TabIndex = 116;
        //    this.labelControl12.Text = "Ud. Disponibles";
        //    // 
        //    // cmdClose
        //    // 
        //    this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        //    this.cmdClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.ImageOptions.Image")));
        //    this.cmdClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        //    this.cmdClose.Location = new System.Drawing.Point(399, 410);
        //    this.cmdClose.Name = "cmdClose";
        //    this.cmdClose.Size = new System.Drawing.Size(88, 33);
        //    this.cmdClose.TabIndex = 122;
        //    this.cmdClose.ToolTip = "Cerrar Ventana";
        //    this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
        //    // 
        //    // cmdGuardar
        //    // 
        //    this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
        //    this.cmdGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        //    this.cmdGuardar.Location = new System.Drawing.Point(222, 410);
        //    this.cmdGuardar.Name = "cmdGuardar";
        //    this.cmdGuardar.Size = new System.Drawing.Size(89, 33);
        //    this.cmdGuardar.TabIndex = 6;
        //    this.cmdGuardar.Text = "Guardar";
        //    this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
        //    // 
        //    // TsExoOExe
        //    // 
        //    this.TsExoOExe.EditValue = true;
        //    this.TsExoOExe.Location = new System.Drawing.Point(273, 85);
        //    this.TsExoOExe.Name = "TsExoOExe";
        //    this.TsExoOExe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
        //    this.TsExoOExe.Properties.Appearance.Options.UseFont = true;
        //    this.TsExoOExe.Properties.OffText = "Exenta";
        //    this.TsExoOExe.Properties.OnText = "Exonerada";
        //    this.TsExoOExe.Size = new System.Drawing.Size(189, 23);
        //    this.TsExoOExe.TabIndex = 123;
        //    this.TsExoOExe.Toggled += new System.EventHandler(this.TsExoOExe_Toggled);
        //    // 
        //    // labelControl13
        //    // 
        //    this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.labelControl13.Appearance.Options.UseFont = true;
        //    this.labelControl13.Location = new System.Drawing.Point(31, 87);
        //    this.labelControl13.Name = "labelControl13";
        //    this.labelControl13.Size = new System.Drawing.Size(129, 18);
        //    this.labelControl13.TabIndex = 124;
        //    this.labelControl13.Text = "Orden de Compra";
        //    // 
        //    // frmAddNewItemOC
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(709, 660);
        //    this.Controls.Add(this.labelControl13);
        //    this.Controls.Add(this.TsExoOExe);
        //    this.Controls.Add(this.cmdGuardar);
        //    this.Controls.Add(this.cmdClose);
        //    this.Controls.Add(this.txtUdNueva);
        //    this.Controls.Add(this.txtUdDisponible);
        //    this.Controls.Add(this.txtUdporConsumir);
        //    this.Controls.Add(this.labelControl10);
        //    this.Controls.Add(this.labelControl11);
        //    this.Controls.Add(this.labelControl12);
        //    this.Controls.Add(this.labelControl9);
        //    this.Controls.Add(this.separatorControl1);
        //    this.Controls.Add(this.txtNuevoSaldo);
        //    this.Controls.Add(this.txtSaldoDisponible);
        //    this.Controls.Add(this.txtSaldoPorConsumir);
        //    this.Controls.Add(this.labelControl6);
        //    this.Controls.Add(this.labelControl7);
        //    this.Controls.Add(this.labelControl8);
        //    this.Controls.Add(this.labelControl5);
        //    this.Controls.Add(this.txtTotal);
        //    this.Controls.Add(this.txtItem);
        //    this.Controls.Add(this.labelControl4);
        //    this.Controls.Add(this.labelControl3);
        //    this.Controls.Add(this.txtUd);
        //    this.Controls.Add(this.txtUnitPrice);
        //    this.Controls.Add(this.grdPartidaAranc);
        //    this.Controls.Add(this.labelControl2);
        //    this.Controls.Add(this.grdCapitulo);
        //    this.Controls.Add(this.labelControl1);
        //    this.Controls.Add(this.btnAdd);
        //    this.Controls.Add(this.labelControl16);
        //    this.Name = "frmAddNewItemOC";
        //    ((System.ComponentModel.ISupportInitialize)(this.grdCapitulo.Properties)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.capitulosBindingSource)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.dsExoneracion1)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.grdPartidaAranc.Properties)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.partidaarancelariaBindingSource)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.grdvPartidas)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice.Properties)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtUd.Properties)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtItem.Properties)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtNuevoSaldo.Properties)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtSaldoDisponible.Properties)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtSaldoPorConsumir.Properties)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtUdNueva.Properties)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtUdDisponible.Properties)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.txtUdporConsumir.Properties)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.TsExoOExe.Properties)).EndInit();
        //    this.ResumeLayout(false);
        //    this.PerformLayout();

        //}

        private void TsExoOExe_Toggled(object sender, EventArgs e)
        {
            if(TsExoOExe.IsOn)
            {
                grdCapitulo.Enabled = true;
                grdPartidaAranc.Enabled = true;
            }
            else
            {
                grdCapitulo.Enabled = false;
                grdPartidaAranc.Enabled = false;
                grdCapitulo.Text = "";
                grdPartidaAranc.Text = "";

            }
        }

        private void CalcularTotal()
        {
            decimal Total = Convert.ToDecimal(txtTotal.EditValue);
            decimal Unidades = Convert.ToDecimal(txtUd.EditValue);
            decimal PrecioUnitario = Convert.ToDecimal(txtUnitPrice.EditValue); 

            Total = (Unidades * PrecioUnitario);

            txtUd.EditValue = Unidades;
            txtUnitPrice.EditValue = PrecioUnitario;
            txtTotal.EditValue = Total;

        }

        private void txtUnitPrice_EditValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
            CalcularSaldos();
        }
    }
}