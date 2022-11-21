using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;
using LOSA.MigracionACS.DataSetx;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.MigracionACS.Produccion.Eficiencia;

namespace LOSA.MigracionACS.Produccion
{
    public partial class PRB_New_Details : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp;
        int Varid;
        int VaridDetalle;
        int LineaId;
        int type;
        int idregis;
        Boolean yaguardado;
        public bool Jefe;
        public DateTime Jefe_Fdesde;
        public DateTime Jefe_Fhasta;

        public enum TipoOperacion
        {
            Nuevo = 0,
            Edit = 1
        }

        public TipoOperacion TipoOperacionActual;

        public PRB_New_Details(int Parid, TipoOperacion pTipo, int pIdLineaPRD, int pIdDetalleRegistro)
        {//Constructor para nuevo registro
            InitializeComponent();
            Jefe = false;
            TipoOperacionActual = pTipo;
            LineaId = pIdLineaPRD;
            dp = new DataOperations();
            Varid = Parid;
            VaridDetalle = pIdDetalleRegistro;
            lblid.Text = Varid.ToString();
            
            LoadPresentacionSacos();
            type = 1;
            LoadMotivosParos();
            //

            load_dataCausas();
            LoadTipoReproceso();
            

            switch (TipoOperacionActual)
            {
                case TipoOperacion.Nuevo:
                    load_line();
                    break;
                case TipoOperacion.Edit:
                    LoadDetalleParos_(Parid, pIdLineaPRD);
                    load_linesALL();
                    grdmaquina.EditValue = pIdLineaPRD;
                    grdmaquina.Enabled = false;
                    LoadLotes(Varid, pIdLineaPRD);
                    LoadReproceso(Varid, pIdLineaPRD);
                    break;
            }
            LoadDetalles(Varid, Convert.ToInt32(grdmaquina.EditValue));
            LoadPresentacionLotes();
        }

        private void LoadPresentacionLotes()
        {
            try
            {
                string query = @"sp_get_presentaciones_from_lote_prb_reporte";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRBdata.presentacion_lote.Clear();
                da.Fill(pRBdata.presentacion_lote);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar los datos, contacte con el administrador", "Error");

            }
        }

        private void LoadTipoReproceso()
        {
            try
            {
                string query = @"SELECT [id]
                                      ,[descripcion]
                                  FROM [dbo].[PRB_Registro_tipo_Reproceso]
                                  where id_linea = @idlinea
	                                    and enable = 1";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@idlinea", LineaId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRBdata.tipo_reproceso.Clear();
                da.Fill(pRBdata.tipo_reproceso);
                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos, contacte con el administrador", "Error");
            }
        }

        private void LoadDetalles(int pIdh, int pIdlinea)
        {
            try
            {
                string query = @"SELECT coalesce([bag_prod],0)
                                      ,coalesce([flushing],0)
                                      ,[id_pres_flushing]
                                      ,[id_pres_sacos_prd]
                                  FROM [dbo].[PRB_Registro_D]
                                  where id_h = @idh
                                        and idMaqui = @idlinea";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@idh",pIdh);
                cmd.Parameters.AddWithValue("@idlinea", pIdlinea);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //txtbag.Value = dr.GetInt32(0);
                    //txtflushing.Value = dr.GetInt32(1);
                    //object obg = dr.GetInt32(2);
                    //if (!dr.IsDBNull(dr.GetOrdinal("id_pres_flushing")))
                    //    gridLookUpFlushing_Presentacion.EditValue = obg.ToString();

                    //if (!dr.IsDBNull(dr.GetOrdinal("id_pres_sacos_prd")))
                    //    gridLookUpPresentacionSacosProd.EditValue = dr.GetInt32(3);
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);

            }
        }

        private void LoadPresentacionSacos()
        {
            try
            {
                string query = @"sp_get_persentacions_from_prb_reporte";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRBdata.presentacion_sacos.Clear();
                da.Fill(pRBdata.presentacion_sacos);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar los datos, contacte con el administrador", "Error");

            }
        }

        public PRB_New_Details(int Parid, int idregis)
        {//Constructor para editar registros
            InitializeComponent();
            dp = new DataOperations();
            Varid = Parid;
            lblid.Text = Varid.ToString();
            load_line();
            load_inf(idregis);
            type = 2;
            this.idregis = idregis;
            grdmaquina.Enabled = false;

        }
        public void load_inf(int idregis)
        {
            try
            {
                lbltext.Text = "Edición de Registro";
                string Query = @"SELECT		
                                  coalesce(a.[mix1],0) as mix1
                                  ,coalesce(a.[mix2],0) as mix2
                                  ,coalesce(a.[reproceso],0) as reproceso
                                  ,coalesce(a.[lote], 0) as lote
                                  ,coalesce(a.[bag_prod],0) as bag_prod
                                  ,coalesce(a.[bag_conf],0) as bag_conf
                                  ,coalesce(a.[prod_noconf],0) as prod_noconf
                                  ,coalesce(a.[prod_arran],0) as prod_arran
                                  ,coalesce(a.[flushing],0) as flushing
                                  ,coalesce(a.[humedad],0) as humedad
                                  ,coalesce(a.[Ton_produc], 0) as Ton_produc
                                  ,coalesce(a.[rendimiento], 0) as rendimiento
                                  ,coalesce(a.[horasMa], '0') as horasMa
                                  ,a.[idMaqui]
                                  ,b.name
                                  ,a.[enable]
                                  ,a.[horassave]
                                  ,coalesce(a.[mix1],0) as mix1
                                ,coalesce(a.[mix2],0) as  mix2
                              FROM [dbo].[PRB_Registro_D] a join
							  ACS.dbo.PP_Production_Lines b on
							  a.idMaqui = b.id
                              where  enable = 1 and a.id = " + idregis;
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRBdata.PRB_Detalle_edit.Clear();
                da.Fill(pRBdata.PRB_Detalle_edit);
                //=============================== Cargado===================
                foreach (DataRow row in pRBdata.PRB_Detalle_edit.Rows)
                {
                    //grdmaquina.EditValue = Convert.ToInt32(row["idMaqui"].ToString());
                    //txtlote.Text = row["lote"].ToString();
                    //txtflushing.Text = row["flushing"].ToString();
                    //txtreproceso.Text = row["reproceso"].ToString();
                    //txtbag.Text = row["bag_prod"].ToString();
                    //txtarran.Text = row["prod_arran"].ToString();
                    //txthora.Text = row["horasMa"].ToString();
                    //if (row["horassave"] == DBNull.Value)
                    //{
                    //    yaguardado = false;
                    //}
                    //else
                    //{
                    //    yaguardado = Convert.ToBoolean(row["horassave"].ToString());
                    //}
                    //txtmix1.Text = row["mix1"].ToString();
                    //txtmix2.Text = row["mix2"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
            }

        }
        public void load_line()
        {
            try
            {
                string query = @"SELECT [id]
                                  ,[apms_id]
                                  ,[name]
                              FROM [dbo].[PP_Production_Lines]
                              where id not in (SELECT [idMaqui] 
                                              FROM [dbo].[PRB_Registro_D]
                                              where enable = 1
		                                            and id_h = " + Varid + ")";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRBdata.Maquina.Clear();
                da.Fill(pRBdata.Maquina);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar los datos, contacte con el administrador", "Error");

            }
            
        }

        public void load_linesALL()
        {
            try
            {
                string query = @"SELECT [id]
                                  ,[apms_id]
                                  ,[name]
                              FROM [dbo].[PP_Production_Lines]";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRBdata.Maquina.Clear();
                da.Fill(pRBdata.Maquina);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar los datos, contacte con el administrador", "Error");

            }

        }

        private void lbllote_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }

        private void btnminimizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void txtlote_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtflushing_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsSeparator(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
        }

        private void txtreproceso_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsSeparator(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
        }

        private void txtbag_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsSeparator(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
        }

        private void txtarran_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnlote_Click(object sender, EventArgs e)
        {
            if(pRBdata.reproceso.Rows.Count == 0)
            {
                CajaDialogo.Error("No puede seleccionar los lotes si aun no especifica el reproceso!");
                return;
            }

            try
            {
                string query = @"Select fecha_ini, fecha_fin
                        from ACS.dbo.PRB_Registro_H
                        where id = " + Varid;
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {


                    DateTime vFechai;
                    DateTime vFechaf;
                    if (Jefe)
                    {
                        vFechai = Jefe_Fdesde;
                        vFechaf = Jefe_Fhasta;
                    }
                    else
                    {
                        vFechai = dr.GetDateTime(0);
                        vFechaf = dr.GetDateTime(1);
                    }

                    PRB_Lote_Pick lote_Pick = new PRB_Lote_Pick(vFechai,vFechaf, Varid, Convert.ToInt32(grdmaquina.EditValue));
                    dr.Close();
                    if (lote_Pick.ShowDialog() == DialogResult.Yes)
                    {
                        int lote = lote_Pick.devolver();

                        //string b = XtraInputBox.Show("Cantidad de Sacos Producidos","Ingrese la cantidad de sacos producidos: ", "0"); 
                        string a = "0";
                        TextEdit textEdit = new TextEdit();
                        textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

                        XtraInputBoxArgs args = new XtraInputBoxArgs();
                        args.Caption = "Ingrese la cantidad de sacos producidos";
                        args.Prompt = "Cantidad de Sacos Producidos";
                        args.DefaultButtonIndex = 0;
                        args.DefaultResponse = "0";
                        args.Editor = textEdit;

                        var result = XtraInputBox.Show(args);
                        if (result != null)
                            a = result.ToString();
                        else
                            a = null;

                        if (a == null)
                            return;


                        int IdPresentacionRow = 0;
                        frmPresentacionLotes frmx = new frmPresentacionLotes();
                        if(frmx.ShowDialog() == DialogResult.OK)
                        {
                            IdPresentacionRow = frmx.IdPresentacionSeleccionada;
                        }

                        SqlCommand cmdx = new SqlCommand("sp_set_detalle_lote_registro_prb", cn);
                        cmdx.CommandType = CommandType.StoredProcedure;
                        cmdx.Parameters.AddWithValue("@id_reg_h_prb", Varid);
                        cmdx.Parameters.AddWithValue("@lote", lote);
                        cmdx.Parameters.AddWithValue("@id_linea", grdmaquina.EditValue);
                        cmdx.Parameters.AddWithValue("@codigo", lote_Pick.Code);
                        cmdx.Parameters.AddWithValue("@descripcion", lote_Pick.Descripcion);
                        cmdx.Parameters.AddWithValue("@cantidad", a);

                        if (IdPresentacionRow == 0)
                            cmdx.Parameters.AddWithValue("@id_presentacion", DBNull.Value);
                        else
                            cmdx.Parameters.AddWithValue("@id_presentacion", IdPresentacionRow);

                        cmdx.ExecuteNonQuery();

                        cn.Close();
                        LoadLotes(Varid, Convert.ToInt32(grdmaquina.EditValue));
                    }
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadLotes(int varid, int vIdLinea)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_lotes_reg_prb", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idlinea", vIdLinea);
                cmd.Parameters.AddWithValue("@idh", varid);

                pRBdata.PRB_Detalle_lotes.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(pRBdata.PRB_Detalle_lotes);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grdmaquina_EditValueChanged(object sender, EventArgs e)
        {
            if(grdmaquina.EditValue != DBNull.Value || grdmaquina.EditValue != null)
            {
                //btnlote.Enabled = txtlote.Enabled = true;
                errorProvider1.Clear();
                //txtlote.Focus();
                LineaId = Convert.ToInt32(grdmaquina.EditValue);
                LoadTipoReproceso();
            }
        }

        private void txtlote_EditValueChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtlote.Text))
            //{
            //    txtKgTotalFlusing.Enabled = gridLookUpE_Presentacion.Enabled = txtflushing.Enabled = true;
            //    errorProvider1.Clear();
            //    txtflushing.Focus();
            //}
        }

        private void txtflushing_EditValueChanged(object sender, EventArgs e)
        {
            //Conversion del text para validar el decimal
            //decimal val = 0;
            //try
            //{
            //    val = Convert.ToDecimal(txtflushing.Text);
            //}
            //catch
            //{
            //    return;
            //}

            //decimal valor = (val * Convert.ToDecimal(gridLookUpFlushing_Presentacion.EditValue));
            //txtKgTotalFlusing.Text = string.Format("{0:0,0.0 Kg}", valor);
        }

        private void txtreproceso_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtbag_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void txtmix1_EditValueChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtmix1.Text))
            //{
            //    txtmix2.Enabled = true;
            //    txtmix2.Focus();
            //}
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtflushing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }

        private void gridLookUpE_Presentacion_EditValueChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtflushing.Text))
            //    txtflushing.Text = "0";

            //decimal valor = (Convert.ToDecimal(txtflushing.Text) * Convert.ToDecimal(gridLookUpE_Presentacion.EditValue));
            //txtKgTotalFlusing.Text = string.Format("{0:0,0.0 Kg}", valor);
            //if (string.IsNullOrEmpty(txtflushing.Text))
            //    txtflushing.Text = "0";

            //if (gridLookUpFlushing_Presentacion.EditValue != null && !string.IsNullOrEmpty(gridLookUpFlushing_Presentacion.EditValue.ToString()))
            //{
            //    decimal valor = (Convert.ToDecimal(txtflushing.Text) * Convert.ToDecimal(gridLookUpFlushing_Presentacion.Text));
            //    txtKgTotalFlusing.Text = string.Format("{0:##,##0.00 Kg}", valor);
            //}
            //else
            //{
            //    txtKgTotalFlusing.Text = "00.00";
            //}
        }

        private void txtKgTotalFlusing_EditValueChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtKgTotalFlusing.Text))
            //{
            //    //if (Convert.ToDecimal(txtflushing.Text) > 0)
            //    //{
            //        //txtreproceso.Enabled = gridLookUpEditReproceso.Enabled = txtKgTotalReproceso.Enabled = true;
            //        //txtreproceso.Focus();
            //    //}
            //}
        }

        private void txtKgTotalReproceso_EditValueChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtKgTotalReproceso.Text))
            //{
            //    //if (Convert.ToDecimal(txtreproceso.Text) > 0)
            //    //{
            //        txtbag.Enabled = gridLookUpPresentacionSacosProd.Enabled = txtKgTotalSacosProducidos.Enabled = true;
            //        txtbag.Focus();
            //    //}
            //}
        }

        private void txtKgTotalSacosProducidos_EditValueChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtbag.Text))
            //{
               
            //        txtmix1.Enabled = true;
            //        txtmix1.Focus();
                
            //}
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtreproceso.Text))
            //    txtreproceso.Text = "0";

            //decimal valor = (Convert.ToDecimal(txtreproceso.Text) * Convert.ToDecimal(gridLookUpEditReproceso.EditValue));
            //txtKgTotalReproceso.Text = string.Format("{0:0,0.0 Kg}", valor);
            //if (string.IsNullOrEmpty(txtreproceso.Text))
            //    txtreproceso.Text = "0";

            //if (gridLookUpEditReproceso.EditValue != null && !string.IsNullOrEmpty(gridLookUpEditReproceso.EditValue.ToString()))
            //{
            //    decimal valor = (Convert.ToDecimal(txtreproceso.Text) * Convert.ToDecimal(gridLookUpEditReproceso.EditValue));
            //    txtKgTotalReproceso.Text = string.Format("{0:##,##0.00 Kg}", valor);
            //}
            //else
            //{
            //    txtKgTotalReproceso.Text = "00.00";
            //}
        }

        private void gridLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtbag.Text))
            //    txtbag.Text = "0";

            //decimal valor = (Convert.ToDecimal(txtbag.Text) * Convert.ToDecimal(gridLookUpPresentacionSacosProd.EditValue));
            //txtKgTotalSacosProducidos.Text = string.Format("{0:0,0.0 Kg}", valor);
            //if (string.IsNullOrEmpty(txtbag.Text))
            //    txtbag.Text = "0";

            //if (gridLookUpPresentacionSacosProd.EditValue != null && !string.IsNullOrEmpty(gridLookUpPresentacionSacosProd.EditValue.ToString()))
            //{
            //    decimal valor = (Convert.ToDecimal(txtbag.Text) * Convert.ToDecimal(gridLookUpPresentacionSacosProd.Text));
            //    txtKgTotalSacosProducidos.Text = string.Format("{0:##,##0.00 Kg}", valor);
            //}
            //else
            //{
            //    txtKgTotalSacosProducidos.Text = "00.00";
            //}
        }

        private void cmdAgregarCausa_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cmdAgregarCausa_Click(object sender, EventArgs e)
        {
            if (grdmaquina.EditValue == null || grdmaquina.EditValue == DBNull.Value)
            {
                errorProvider1.SetError(grdmaquina, "Debe seleccionar la Maquina!");
                return;
            }

            if (grdmaquina.EditValue.ToString() == "0")
            {
                errorProvider1.SetError(grdmaquina, "Debe seleccionar la Maquina!");
                return;
            }


            int idLinea = Convert.ToInt32(grdmaquina.EditValue);
            PRB_Causes_New frm = new PRB_Causes_New(Varid, idLinea, VaridDetalle);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDetalleParos_(Varid, idLinea);
                VaridDetalle = frm.VaridDetalle;
            }
        }

        private void LoadDetalleParos_(int varid, int vIdLinea)
        {
            try
            {
                string query = @"[sp_get_lista_transaccion_causas_tipo_paro_PRB]";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idreg", Varid);
                cmd.Parameters.AddWithValue("@linea", vIdLinea);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRBdata.causas_transact.Clear();
                da.Fill(pRBdata.causas_transact);
                SumHoras();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar los datos, contacte con el administrador", "Error");

            }
        }

        private void SumHoras()
        {
            decimal horas = 0;
            decimal min = 0;
            foreach(PRBdata.causas_transactRow row in pRBdata.causas_transact.Rows)
            {
                horas += row.horacausa.Hours;
                min += row.horacausa.Minutes;
            }

            if (min >= 60)
            {
                int H_deminutos = Convert.ToInt32((min / 60));
                horas += H_deminutos;
                decimal min_res = ((min / 60) - H_deminutos);
                min = min_res * 60;
                
            }

            string h = horas.ToString();
            string m = min.ToString();
            if (h.Length == 1)
                h = "0" + h;

            if (m.Length == 1)
                m = "0" + m;

            txtTotalHoras.Text = h + ":" + m + ":00 horas";
        }

        private void LoadMotivosParos()
        {
            try
            {
                string query = @"sp_get_lista_causas_tipo_paro_PRB";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRBdata.tipo_causa.Clear();
                da.Fill(pRBdata.tipo_causa);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos, contacte con el administrador", "Error");
            }
        }

        public void load_dataCausas()
        {
            try
            {
                string Query;
                Query = @"Select id
                            ,causa
                            ,descripcion
                    From [dbo].[PRB_Causa]
                    where enable = 1";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRBdata.causas.Clear();
                da.Fill(pRBdata.causas);
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void buttonEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Eliminar row
            DialogResult r = CajaDialogo.Pregunta("Esta seguro de eliminar este registro?");
            if (r != DialogResult.Yes)
                return;

            var gridView = (GridView)gridControl1.FocusedView;
            var row = (PRBdata.causas_transactRow)gridView.GetFocusedDataRow();
            //sp_set_disable_row_prb_transaction_causes
            try
            {
                string Query;
                Query = @"sp_set_disable_row_prb_transaction_causes";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.ExecuteNonQuery();
                LoadDetalleParos_(Varid, Convert.ToInt32(grdmaquina.EditValue));
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txtflushing_EditValueChanged_1(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtflushing.Text))
            //    txtflushing.Text = "0";

            //if (gridLookUpFlushing_Presentacion.EditValue != null && !string.IsNullOrEmpty(gridLookUpFlushing_Presentacion.EditValue.ToString()))
            //{
            //    decimal valor = (Convert.ToDecimal(txtflushing.Text) * Convert.ToDecimal(gridLookUpFlushing_Presentacion.Text));
            //    txtKgTotalFlusing.Text = string.Format("{0:##,##0.00 Kg}", valor);
            //}
            //else
            //{
            //    txtKgTotalFlusing.Text = "00.00";
            //}
        }

        private void txtreproceso_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txtbag_EditValueChanged_1(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtbag.Text))
            //    txtbag.Text = "0";

            //if (gridLookUpPresentacionSacosProd.EditValue != null && !string.IsNullOrEmpty(gridLookUpPresentacionSacosProd.EditValue.ToString()))
            //{
            //    decimal valor = (Convert.ToDecimal(txtbag.Text) * Convert.ToDecimal(gridLookUpPresentacionSacosProd.Text));
            //    txtKgTotalSacosProducidos.Text = string.Format("{0:##,##0.00 Kg}", valor);
            //}
            //else
            //{
            //    txtKgTotalSacosProducidos.Text = "00.00";
            //}
        }

        private void cmdDelete1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Eliminar Lote
            DialogResult r = CajaDialogo.Pregunta("Confirma que desea eliminar este lote?");
            if (r != DialogResult.Yes)
                return;

            try
            {
                var gridView = (GridView)gridControlLotes.FocusedView;
                var row = (PRBdata.PRB_Detalle_lotesRow)gridView.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_delete_detalle_lotes_reg_prb", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.ExecuteNonQuery();

                con.Close();
                LoadLotes(Varid, Convert.ToInt32(grdmaquina.EditValue)); 
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdAddReproceso_Click(object sender, EventArgs e)
        {
            if (pRBdata.causas_transact.Rows.Count == 0)
            {
                CajaDialogo.Error("No se permite ingresar reproceso si aun no ha ingresado los motivos de paros!");
                return;
            }

            int idlinea = Convert.ToInt32(grdmaquina.EditValue);
            PRB_Add_Reproceso frm = new PRB_Add_Reproceso(idlinea, Varid);
            if(frm.ShowDialog()== DialogResult.OK)
            {
                LoadReproceso(Varid, idlinea);
            }
        }

        private void LoadReproceso(int idh, int idLinea)
        {
            try
            {
                var gridView = (GridView)gridControlLotes.FocusedView;
                var row = (PRBdata.PRB_Detalle_lotesRow)gridView.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_reproceso_registro_prb_h", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idh", idh);
                cmd.Parameters.AddWithValue("@idlinea", idLinea);
                pRBdata.reproceso.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(pRBdata.reproceso);

                con.Close();
                
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdEliminar2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Eliminar reproceso
            DialogResult r = CajaDialogo.Pregunta("Esta seguro de eliminar este registro de reproceso?");
            if (r != DialogResult.Yes)
                return;
            try
            {
                var gridView = (GridView)gridControlReproceso.FocusedView;
                var row = (PRBdata.reprocesoRow)gridView.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_reproceso_disable_registro_prb_h", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", row.id);
                //cmd.Parameters.AddWithValue("@idlinea", idLinea);
                pRBdata.reproceso.Clear();
                cmd.ExecuteNonQuery();
                LoadReproceso(Varid, Convert.ToInt32(grdmaquina.EditValue));
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }

        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void GridLookUpEditPresentacion_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                GridLookUpEdit grLook = (GridLookUpEdit)sender;
                object a = grLook.EditValue;
                var gridView = (GridView)gridControlLotes.FocusedView;
                var row = (PRBdata.PRB_Detalle_lotesRow)gridView.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_detalle_lotes_presentacion_reg_prb", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idrow", row.id);
                cmd.Parameters.AddWithValue("@idp", a);


                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdAddReproceso_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}