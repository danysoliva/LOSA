using ACS.Classes;
using LOSA.MigracionACS.Produccion.DataSet_;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
using LOSA.Classes;

namespace LOSA.MigracionACS.Produccion.Eficiencia
{
    public partial class frm_new_detail_prd_efi : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp;
        int VaridH;
        int VaridDetalle;
        int LineaId;
        decimal HorasMaquina;
        public bool Jefe;
        public DateTime Jefe_Fdesde;
        public DateTime Jefe_Fhasta;

        public enum TipoOperacion
        {
            Nuevo = 0,
            Edit = 1
        }

        public TipoOperacion TipoOperacionActual;

        public frm_new_detail_prd_efi(int PidH, TipoOperacion pTipo, int pIdLineaPRD, int pIdDetalleRegistro)
        {
            InitializeComponent();
            VaridH = PidH;
            dp = new DataOperations();
            VaridDetalle = pIdDetalleRegistro;
            LineaId = pIdLineaPRD;
            switch (LineaId)
            {
                case 1:
                    txtNombreLinea.Text = "Pellet 1";
                    break;
                case 2:
                    txtNombreLinea.Text = "Pellet 2";
                    break;
                case 3:
                    txtNombreLinea.Text = "Extruder";
                    break;
            }

            //Get Horas Maquina
            //
            APMS_OrderProduction APMS1 = new APMS_OrderProduction();
            HorasMaquina = APMS1.GetHorasMaquinaFromId(LineaId, PidH);
            txtTotalHorasMotor.Text = string.Format("{0:###,##0.00}", HorasMaquina);

            TipoOperacionActual = pTipo;
            LoadPresentacionSacos();
            LoadMotivosParos();
            load_dataCausas();
            LoadTipoReproceso();
            LoadLotes(VaridH, LineaId);
            LoadDetalleParos_(VaridH, LineaId);
            LoadReproceso(VaridH, LineaId);
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
                dsEficiencia1.presentacion_sacos.Clear();
                da.Fill(dsEficiencia1.presentacion_sacos);
            }
            catch (Exception ec)
            {

                CajaDialogo.Error(ec.Message);

            }
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
                //dsEficiencia1.tipo_causa.Clear();
                //da.Fill(dsEficiencia1.tipo_causa);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
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
                dsEficiencia1.causas.Clear();
                da.Fill(dsEficiencia1.causas);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

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
                dsEficiencia1.tipo_reproceso.Clear();
                da.Fill(dsEficiencia1.tipo_reproceso);
                cn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnlote_Click(object sender, EventArgs e)
        {
            //if (pRBdata.reproceso.Rows.Count == 0)
            //{
            //    CajaDialogo.Error("No puede seleccionar los lotes si aun no especifica el reproceso!");
            //    return;
            //}

            try
            {
                string query = @"Select fecha_ini, fecha_fin
                                from ACS.dbo.PRB_Registro_H
                                where id = " + VaridH;
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    DateTime vFechai = DateTime.Now;
                    DateTime vFechaf = DateTime.Now;
                    if (Jefe)
                    {
                        if (Jefe_Fdesde.Year > 2000)
                        {
                            vFechai = Jefe_Fdesde;
                            vFechaf = Jefe_Fhasta;
                        }
                    }
                    else
                    {
                        vFechai = dr.GetDateTime(0);
                        vFechaf = dr.GetDateTime(1);
                    }

                    Funciones fn = new Funciones();
                    decimal horas_asgined = fn.GetHoras_acumuladasLinea(VaridH, LineaId);

                    PRB_Lote_Pick_v4 lote_Pick = new PRB_Lote_Pick_v4(vFechai, vFechaf, VaridH, LineaId, horas_asgined);
                    dr.Close();
                    if (lote_Pick.ShowDialog() == DialogResult.Yes)
                    {
                        int lote = lote_Pick.devolver();

                        ////string b = XtraInputBox.Show("Cantidad de Sacos Producidos","Ingrese la cantidad de sacos producidos: ", "0"); 
                        //string a = "0";
                        //TextEdit textEdit = new TextEdit();
                        //textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

                        //XtraInputBoxArgs args = new XtraInputBoxArgs();
                        //args.Caption = "Ingrese la cantidad de sacos producidos";
                        //args.Prompt = "Cantidad de Sacos Producidos";
                        //args.DefaultButtonIndex = 0;
                        //args.DefaultResponse = "0";
                        //args.Editor = textEdit;

                        //var result = XtraInputBox.Show(args);
                        //if (result != null)
                        //    a = result.ToString();
                        //else
                        //    a = null;
                        //if (a == null)
                        //    return;


                        int IdPresentacionRow = lote_Pick.IdPresentacion;
                        //frmPresentacionLotes frmx = new frmPresentacionLotes();
                        //if (frmx.ShowDialog() == DialogResult.OK)
                        //{
                        //    IdPresentacionRow = frmx.IdPresentacionSeleccionada;
                        //}

                        SqlCommand cmdx = new SqlCommand("sp_set_detalle_lote_registro_prb_v5", cn);
                        cmdx.CommandType = CommandType.StoredProcedure;
                        cmdx.Parameters.AddWithValue("@id_reg_h_prb", VaridH);
                        cmdx.Parameters.AddWithValue("@lote", lote);
                        cmdx.Parameters.AddWithValue("@id_linea", LineaId);
                        cmdx.Parameters.AddWithValue("@codigo", lote_Pick.Code);
                        cmdx.Parameters.AddWithValue("@descripcion", lote_Pick.Descripcion);
                        //cmdx.Parameters.AddWithValue("@cantidad", lote_Pick.spinSacosProducidos.EditValue);
                        cmdx.Parameters.AddWithValue("@fechai", lote_Pick.desde);
                        cmdx.Parameters.AddWithValue("@fechaf", lote_Pick.hasta);
                        cmdx.Parameters.AddWithValue("@horas", lote_Pick.horas);
                        cmdx.Parameters.AddWithValue("@id_dado", lote_Pick.IdDado);
                        cmdx.Parameters.AddWithValue("@cantidad", lote_Pick.cantidad);
                        cmdx.Parameters.AddWithValue("@id_alimentacion", lote_Pick.id_alimentacion);

                        if (IdPresentacionRow == 0)
                            cmdx.Parameters.AddWithValue("@id_presentacion", DBNull.Value);
                        else
                            cmdx.Parameters.AddWithValue("@id_presentacion", IdPresentacionRow);

                       int id_insered = Convert.ToInt32(cmdx.ExecuteScalar());
                        foreach  (DataRow row  in lote_Pick.TmSelecionadas.Rows)
                        {
                            if (lote_Pick.lote == Convert.ToInt32(row["lote"]))
                            {
                                cmdx = new SqlCommand("sp_insert_tarima_registrada_en_prb", cn);
                                cmdx.CommandType = CommandType.StoredProcedure;
                                cmdx.Parameters.AddWithValue("@idtm", row["id_tm"]);
                                cmdx.Parameters.AddWithValue("@id_prb_lote", id_insered);
                                cmdx.ExecuteNonQuery();

                            }
                        }
                        cn.Close();
                        LoadLotes(VaridH, LineaId);
                    }
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadLotes(int varidH, int lineaId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_lotes_reg_prb_eficiencia", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idh", varidH);
                cmd.Parameters.AddWithValue("@linea", lineaId);
                dsEficiencia1.PRB_Detalle_lotes.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsEficiencia1.PRB_Detalle_lotes);

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
                var row = (dsEficiencia.PRB_Detalle_lotesRow)gridView.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_delete_detalle_lotes_reg_prb_v3", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.ExecuteNonQuery();

                con.Close();
                LoadLotes(VaridH, LineaId);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdAgregarCausa_Click(object sender, EventArgs e)
        {
            //if (grdmaquina.EditValue == null || grdmaquina.EditValue == DBNull.Value)
            //{
            //    errorProvider1.SetError(grdmaquina, "Debe seleccionar la Maquina!");
            //    return;
            //}

            if (LineaId <= 0)
            {
                //errorProvider1.SetError(grdmaquina, "Debe seleccionar la Maquina!");
                CajaDialogo.Error("Debe seleccionar la Maquina!");
                return;
            }


            
            PRB_Causes_New frm = new PRB_Causes_New(VaridH, LineaId, VaridDetalle);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDetalleParos_(VaridH, LineaId);
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
                cmd.Parameters.AddWithValue("@idreg", varid);
                cmd.Parameters.AddWithValue("@linea", vIdLinea);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsEficiencia1.causas_transact.Clear();
                da.Fill(dsEficiencia1.causas_transact);
                SumHoras();
            }
            catch (Exception ec)
            {

                MessageBox.Show("Error al cargar los datos, contacte con el administrador. Error: " + ec.Message, "Error");

            }
        }
        private void SumHoras()
        {
            decimal horas = 0;
            decimal min = 0;
            foreach (dsEficiencia.causas_transactRow row in dsEficiencia1.causas_transact.Rows)
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
        private void LoadReproceso(int idh, int idLinea)
        {
            try
            {
                //var gridView = (GridView)gridControlLotes.FocusedView;
                //var row = (PRBdata.PRB_Detalle_lotesRow)gridView.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_reproceso_registro_prb_h", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idh", idh);
                cmd.Parameters.AddWithValue("@idlinea", idLinea);
                dsEficiencia1.reproceso2.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsEficiencia1.reproceso2);

                con.Close();

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void cmdAddReproceso_Click(object sender, EventArgs e)
        {
            if (dsEficiencia1.causas_transact.Rows.Count == 0)
            {
                CajaDialogo.Error("No se permite ingresar reproceso si aun no ha ingresado los motivos de paros!");
                return;
            }

            //int idlinea = Convert.ToInt32(grdmaquina.EditValue);
            PRB_Add_Reproceso frm = new PRB_Add_Reproceso(LineaId, VaridH);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadReproceso(VaridH, LineaId);
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
                var row = (dsEficiencia.reproceso2Row)gridView.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_reproceso_disable_registro_prb_h", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", row.id);
                //cmd.Parameters.AddWithValue("@idlinea", idLinea);
                dsEficiencia1.reproceso.Clear();
                cmd.ExecuteNonQuery();
                LoadReproceso(VaridH, LineaId);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void buttonEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Eliminar row
            DialogResult r = CajaDialogo.Pregunta("Esta seguro de eliminar este registro?");
            if (r != DialogResult.Yes)
                return;

            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsEficiencia.causas_transactRow)gridView.GetFocusedDataRow();
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
                LoadDetalleParos_(VaridH, LineaId);
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            frmPT_Adicional_Eficiencia frm = new frmPT_Adicional_Eficiencia(VaridH, LineaId);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadLotes(VaridH, LineaId);
            }

        }

        private void cmdEditCantidad_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Editar la cantidad
            var gridView = (GridView)gridControlLotes.FocusedView;
            var row = (dsEficiencia.PRB_Detalle_lotesRow)gridView.GetFocusedDataRow();

            frmEditCantidadSacosEficiencia frm = new frmEditCantidadSacosEficiencia(row.cantidad, row.id);
            if(frm.ShowDialog()== DialogResult.OK)
            {
                LoadLotes(VaridH, LineaId);
            }
        }
    }
}