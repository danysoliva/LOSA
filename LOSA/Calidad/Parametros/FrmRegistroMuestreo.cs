using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Calidad.Parametros
{
    public partial class FrmRegistroMuestreo : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        string Lote;
        ArrayList Tarimas;
        int id_pt, IdMuestreo;
        string codigo_minmo;
        string codigo_maximo;
        UserLogin UsuarioLogeado;
        bool ChkCalidad;
      
        public FrmRegistroMuestreo(ArrayList ParametroTarimas, string ParametroLote, UserLogin Puser)
        {
            InitializeComponent();
            Lote = ParametroLote;
            Tarimas = ParametroTarimas;
            UsuarioLogeado = Puser;
            btnSeleccionarPRD.ReadOnly = true;

            switch (Puser.GrupoUsuario.GrupoUsuarioActivo)
            {
              
                case GrupoUser.GrupoUsuario.Calidad:
                    ChkCalidad = true;
                    break;
                case GrupoUser.GrupoUsuario.Administradores:
                    ChkCalidad = true;
                    break;
                //case GrupoUser.GrupoUsuario.Produccion:
                //    break;
                case GrupoUser.GrupoUsuario.ProduccionV2:
                    ChkCalidad = false;
                    break;
                default:
                    break;
            }

            load_data();
            load_turno();
            load_parametros_fisicos_cumplo_no_cumple();
            load_parametros_fisicos_min_max();
            
            load_decision();
            obtener_sacos();
            load_obtenet_rango();
            load_jornadas();
            
            load_data_ultimo_muestreo(Convert.ToInt32(Lote));
        }

        public FrmRegistroMuestreo(ArrayList ParametroTarimas, string ParametroLote, UserLogin Puser, int pIdMuestreo)
        {
            InitializeComponent();

            Lote = ParametroLote;
            Tarimas = ParametroTarimas;
            UsuarioLogeado = Puser;
            IdMuestreo = pIdMuestreo;
            btnSeleccionarPRD.Enabled = false;

            switch (Puser.GrupoUsuario.GrupoUsuarioActivo)
            {

                case GrupoUser.GrupoUsuario.Calidad:
                    ChkCalidad = true;
                    break;
                case GrupoUser.GrupoUsuario.Administradores:
                    ChkCalidad = true;
                    break;
                //case GrupoUser.GrupoUsuario.Produccion:
                //    break;
                case GrupoUser.GrupoUsuario.ProduccionV2:
                    ChkCalidad = false;
                    break;
                default:
                    break;
            }

            load_turno();
            load_decision();
            load_jornadas();
            //obtener_sacos();
            if (IdMuestreo > 0)
            {
                LoadDataForIdMuestreo(IdMuestreo);
                grd_turno_inicial.Enabled = false;
                grd_turno_fin.Enabled = false;
                txtcomentarios.Enabled = false;

            }
            else 
            {
                load_parametros_fisicos_cumplo_no_cumple();
                load_parametros_fisicos_min_max();
                obtener_sacos();
                load_obtenet_rango();
                load_data_ultimo_muestreo(Convert.ToInt32(Lote));

            }
            
            
            



        }

        private void LoadDataForIdMuestreo(int pIdMuestreo)
        {

            try
            {
                //Header
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmdHeader = new SqlCommand("sp_get_data_header_muestreo", conn);
                cmdHeader.CommandType = CommandType.StoredProcedure;
                cmdHeader.Parameters.AddWithValue("@id_muestreo", pIdMuestreo);
                SqlDataReader dr = cmdHeader.ExecuteReader();
                if (dr.Read())
                {
                    txtnombre.Text = dr.IsDBNull(0) ? "" : dr.GetString(0);
                    txtlote.Text = dr.IsDBNull(1) ? 0.ToString() : dr.GetInt32(1).ToString();
                    id_pt = dr.IsDBNull(2) ? 0 : dr.GetInt32(2);
                    txtformula.Text = dr.IsDBNull(3) ? "" : dr.GetString(3);
                    txtCandidadSacos.EditValue = dr.GetDecimal(4);
                    txtRango.Text = dr.GetString(5);
                    btnSeleccionarPRD.EditValue = dr.GetInt32(6);
                    if (btnSeleccionarPRD.Text == "0")
                        btnSeleccionarPRD.Clear();
                    dt_fecharegistro.EditValue = dp.Now();
                    
                    dr.Close();
                }

                SqlCommand cmdHeaderTurnos = new SqlCommand("[sp_get_last_parametro_por_lote]", conn);
                cmdHeaderTurnos.CommandType = CommandType.StoredProcedure;
                cmdHeaderTurnos.Parameters.AddWithValue("@lote_pt", Lote);
                SqlDataReader drTurnos = cmdHeaderTurnos.ExecuteReader();
                if (drTurnos.Read())
                {
                    grd_turno_inicial.EditValue = drTurnos.GetInt32(1);
                    grd_turno_fin.EditValue = drTurnos.GetInt32(2);
                    dtdesde.EditValue = drTurnos.GetDateTime(3);
                    dtdesdeJornada.EditValue = drTurnos.GetString(4);
                    dthasta.EditValue = drTurnos.GetDateTime(5);
                    dthastaJornada.EditValue = drTurnos.GetString(6);
                    txtcomentarios.Text = drTurnos.GetString(7);

                    if (dtdesdeJornada.EditValue.ToString() == "07:00 - 19:00")
                        dtdesdeJornada.EditValue = 1;
                    else
                        dtdesdeJornada.EditValue = 2;

                    if (dthastaJornada.EditValue.ToString() == "07:00 - 19:00")
                        dthastaJornada.EditValue = 1;
                    else
                        dthastaJornada.EditValue = 2;

                    drTurnos.Close();
                }

                //Detalle Revision Fisica
                SqlCommand cmdDFisicos = new SqlCommand("sp_get_parametros_revision_fisica_por_muestreo", conn);
                cmdDFisicos.CommandType = CommandType.StoredProcedure;
                cmdDFisicos.Parameters.AddWithValue("@id_muestreo", pIdMuestreo);
                SqlDataAdapter adatDFisicos = new SqlDataAdapter(cmdDFisicos);
                dsParametros1.parametros_decision.Clear();
                adatDFisicos.Fill(dsParametros1.parametros_decision);

                //Detalles Valores Maximos y Minimos
                SqlCommand cmdDValorMaximos = new SqlCommand("sp_get_muestreo_pt_for_id_muestreo", conn);
                cmdDValorMaximos.CommandType = CommandType.StoredProcedure;
                cmdDValorMaximos.Parameters.AddWithValue("@id_muestreo", pIdMuestreo);
                cmdDValorMaximos.Parameters.AddWithValue("@id_pt",id_pt);
                SqlDataAdapter adatDMaximos = new SqlDataAdapter(cmdDValorMaximos);
                dsParametros1.decision_minimos.Clear();
                adatDMaximos.Fill(dsParametros1.decision_minimos);

                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void load_data_ultimo_muestreo(int plote)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_last_parametro_por_lote", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote_pt", plote);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    grd_turno_inicial.EditValue = dr.GetInt32(1);
                    grd_turno_fin.EditValue = dr.GetInt32(2);
                    dtdesde.EditValue = dr.GetDateTime(3);
                    dtdesdeJornada.Text = dr.GetString(4);
                    dthasta.EditValue = dr.GetDateTime(5);
                    dthastaJornada.Text = dr.GetString(6);
                    txtcomentarios.Text = dr.GetString(7);
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void load_jornadas()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_jornada_laboral_horas", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsParametros1.jornada.Clear();
                adat.Fill(dsParametros1.jornada);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_obtenet_rango()
        {
            int Maximo = 0;
            int minimo = 0;
            foreach (int item in Tarimas)
            {
                if (Maximo == 0)
                {
                    Maximo = item;
                }
                else
                {
                    if (Maximo <= item)
                    {
                        Maximo = item;
                    }
                }

                if (minimo == 0)
                {
                    minimo = item;
                }
                else
                {
                    if (minimo >= item)
                    {
                        minimo = item;
                    }
                }
            }

            string query = @"sp_get_rango_codigo_tarima_by_id";
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@minimo", minimo);
                cmd.Parameters.AddWithValue("@maximo", Maximo);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    codigo_minmo = dr.GetString(0);
                    codigo_maximo = dr.GetString(1);
                }
                dr.Close();
                cn.Close();
                txtRango.Text = codigo_minmo + " - " + codigo_maximo;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
                     
                     
        }
        

        public void obtener_sacos()
        {
            string Query = @"Select Sum(A.cantidad)
                            from dbo.LOSA_tarimas A ";
            try
            {
                string where = @" Where A.id in (";
                foreach (int row in Tarimas)
                {
                    where = where + row.ToString() + ", ";
                }
                where = where + "0 )";
                Query = Query + where;
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtCandidadSacos.Text = dr.IsDBNull(0) ? "" : dr.GetDecimal(0).ToString();
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        public void load_turno()
        {
            string query = @"sp_load_turnos";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsParametros1.turno.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsParametros1.turno);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_decision()
        {
            string query = @"sp_get_decision_values";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsParametros1.decision_values.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsParametros1.decision_values);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }



        public void load_parametros_fisicos_cumplo_no_cumple()
        {
            string query = @"sp_get_parametros_protuctos_revision_fisica";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", id_pt);
                dsParametros1.parametros_decision.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsParametros1.parametros_decision);
                cn.Close();




            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_parametros_fisicos_min_max()
        {
            string query = @"sp_get_parametros_protuctos_revision_fisica_min_maxV2";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", id_pt);
                dsParametros1.decision_minimos.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsParametros1.decision_minimos);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_data()
        {
            string Query = @"sp_get_orden_informacion_lot_by_tarima_id";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_lote", Lote);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtnombre.Text = dr.IsDBNull(0) ? "" : dr.GetString(0);
                    txtlote.Text = dr.IsDBNull(1) ? 0.ToString() : dr.GetInt32(1).ToString();
                    txtformula.Text = dr.IsDBNull(2) ? "" : dr.GetString(2);
                    dt_fecharegistro.EditValue = DateTime.Now;
                    id_pt = dr.IsDBNull(4) ? 0 : dr.GetInt32(4);
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRegistroMuestreo_Load(object sender, EventArgs e)
        {

        }

        private void grdv_rangos_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            
            
           

        }

        private void grdv_decision_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                
            }
        }

        private void grdv_rangos_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void grd_decesion_EditValueChanged(object sender, EventArgs e)
        {
          
        }

        private void grdv_rangos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
            //    var gridView = (GridView)grd_rangos.FocusedView;
            //    var row = (dsParametros.parametros_decisionRow)gridView.GetFocusedDataRow();

            //    row.id_decision = Convert.ToInt32(e.Value);
            //    row.AcceptChanges();

            }
            catch (Exception ex)
            {

            }
        }

        private void btn_respuestas_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)grd_rangos.FocusedView;
            var row = (dsParametros.parametros_decisionRow)gridView.GetFocusedDataRow();
            frmRespuestasCalidad frm = new frmRespuestasCalidad(false);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.id_respuesta != 0)
                {
                    row.id_decision = frm.id_respuesta;
                    row.Decision = frm.Respuesta;
                }
                row.AcceptChanges();
            }
        }

        private void grdv_decision_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_decision.FocusedView;
                var row = (dsParametros.decision_minimosRow)gridView.GetFocusedDataRow();
                row.valor = Convert.ToDecimal(e.Value);
                row.AcceptChanges();
                if (row.valorminimo == -1)
                {// Si no hay minimo
                    if (row.valormaximo >= row.valor)
                    { //Cumple
                        row.resultado = "Cumple";
                    }
                    else
                    {
                        row.resultado = "No Cumple";
                    }
                }
                else
                {
                    if (row.valormaximo == -1)
                    {
                        if (row.valorminimo <= row.valor)
                        {
                            row.resultado = "Cumple";
                        }
                        else
                        {
                            row.resultado = "No Cumple";
                        }
                    }
                    else
                    {

                        if ((row.valorminimo <= row.valor) && (row.valor <= row.valormaximo))
                        {
                            row.resultado = "Cumple";
                        }
                        else
                        {
                            row.resultado = "No Cumple";
                        }
                    }
                }
                


                row.AcceptChanges();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void txtcomentarios_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtcomentarios_Click(object sender, EventArgs e)
        {
            if (ActiveControl.Name != "txtcomentarios" && txtcomentarios.Text == "Escribe algunas observaciones sobre el producto....")
            {
                txtcomentarios.SelectAll();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            switch (UsuarioLogeado.GrupoUsuario.GrupoUsuarioActivo)
            {
                case GrupoUser.GrupoUsuario.ProduccionV2:

                    if (btnSeleccionarPRD.Text == "")
                    {
                        CajaDialogo.Error("Los Analistas deben Seleccionar un Registro de Control de Produccion!");
                        return;
                    }

                    break;
                default:
                    break;
            }


            if (grd_turno_inicial.EditValue == null)
            {
                CajaDialogo.Error("El turno no puede quedar vacio.");
                grd_turno_inicial.ShowPopup();
                return;
            }
            if (grd_turno_fin.EditValue == null)
            {
                CajaDialogo.Error("El turno no puede quedar vacio.");
                grd_turno_fin.ShowPopup();
                return;
            }
            if (dtdesde.EditValue == null )
            {
                CajaDialogo.Error("Debe escoger la Jornada - Fecha Inicio.");
                dtdesde.ShowPopup();
                return;
            }

            if (dtdesdeJornada.EditValue == null)
            {
                CajaDialogo.Error("Debe escoger la Hora de Inicio.");
                dtdesde.ShowPopup();
                return;
            }

            if (dthasta.EditValue == null)
            {
                CajaDialogo.Error("Debe escoger la Jornada - Fecha Final.");
                dtdesde.ShowPopup();
                return;
            }

            if (dthastaJornada.EditValue == null)
            {
                CajaDialogo.Error("Debe escoger la Hora de Final.");
                dtdesde.ShowPopup();
                return;
            }

            bool AsNoCumple = false;
            foreach (dsParametros.parametros_decisionRow row in dsParametros1.parametros_decision.Rows)
            {
                if (row.id_decision == 0)
                {
                    CajaDialogo.Error("Hay parametros que se estan dejando en vacio.");
                    return;
                }
                if (row.id_decision ==2 )
                {
                    AsNoCumple = true;
                }
            }
            foreach (dsParametros.decision_minimosRow row in dsParametros1.decision_minimos.Rows)
            {
                //if (row.resultado == "Pendiente")
                //{
                //    CajaDialogo.Error("El parametro "+ row.parametro + " Esta vacio. Por favor llenarlo.");
                //    return;
                //}
                if (row.resultado == "No Cumple")
                {
                    AsNoCumple = true;
                }
            }
            bool Save = true;
            if (AsNoCumple)
            {//Si no cumple algun parametro se manda a Rechazado
                if (MessageBox.Show("Esta guardando el Muestreo con parametros que no cumplen. Desea continuar y rechazar la muestra?","Confirmacion de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Save = true;
                }
                else
                {
                    Save = false;
                }
            }
            else
            {//Si cumple guardamos
                if (MessageBox.Show("Desea guardar este registro y liberar este rango de tarimas?", "Confirmacion de guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Save = true;
                }
                else
                {
                    Save = false;
                }
            }

            if (Save)
            {
                if (IdMuestreo > 0)
                {
                    #region Codigo con Transaction

                    SqlTransaction transaction = null;

                    SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                    //bool Guardar = false;

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "[sp_update_muestreo]";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_decision", AsNoCumple ? 2 : 1);
                        cmd.Parameters.AddWithValue("@jornada_hora_inicial", dtdesde.EditValue);
                        cmd.Parameters.AddWithValue("@jornada_hora_final", dthasta.EditValue);
                        cmd.Parameters.AddWithValue("@id_muestreo", IdMuestreo);
                        cmd.ExecuteNonQuery();

                        foreach (dsParametros.parametros_decisionRow row in dsParametros1.parametros_decision.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "sp_update_or_insert_parametros_decision";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@bit_tipo", 1);
                            cmd.Parameters.AddWithValue("@id_muestreo", IdMuestreo);
                            cmd.Parameters.AddWithValue("@id_parametro", row.id_parametro);
                            cmd.Parameters.AddWithValue("@parametro", row.parametro);
                            cmd.Parameters.AddWithValue("@id_decision", row.id_decision);
                            cmd.Parameters.AddWithValue("@min_plan", 0);
                            cmd.Parameters.AddWithValue("@max_plan", 0);
                            cmd.Parameters.AddWithValue("@resultado_porcentaje", 0);
                            cmd.ExecuteNonQuery();
                        }

                        foreach (dsParametros.decision_minimosRow row in dsParametros1.decision_minimos.Rows)
                        {
                            bool Guardar = false;
                            if (row.resultado == "Pendiente")
                                Guardar = false;
                            else
                                Guardar = true;

                            if (Guardar)
                            {
                                cmd.Parameters.Clear();
                                cmd.CommandText = "sp_update_or_insert_parametros";
                                cmd.Connection = conn;
                                cmd.Transaction = transaction;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@bit_tipo", 0);
                                cmd.Parameters.AddWithValue("@id_muestreo", IdMuestreo);
                                cmd.Parameters.AddWithValue("@id_parametro", row.id_parametro);
                                cmd.Parameters.AddWithValue("@parametro", row.parametro);
                                cmd.Parameters.AddWithValue("@id_decision", row.resultado == "No Cumple" ? 2 : 1);
                                cmd.Parameters.AddWithValue("@min_plan", row.valorminimo);
                                cmd.Parameters.AddWithValue("@max_plan", row.valormaximo);
                                cmd.Parameters.AddWithValue("@resultado_porcentaje", row.valor);
                                cmd.ExecuteNonQuery();
                            }


                        }

                        foreach (int tm in Tarimas)
                        {

                            cmd.Parameters.Clear();
                            cmd.CommandText = "sp_set_bit_muestro_in_tarimaV2";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_tm", tm);
                            cmd.Parameters.AddWithValue("@id_muestreo", IdMuestreo);
                            cmd.Parameters.AddWithValue("@chkCalidad", ChkCalidad);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();


                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);

                    }

                    #endregion
                }
                else
                {
                    string query = @"[sp_insert_muestreo_of_productV2]";
                    try
                    {
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_pt", id_pt);
                        cmd.Parameters.AddWithValue("@lote_pt", Lote);
                        cmd.Parameters.AddWithValue("@fecha_creacion", dt_fecharegistro.EditValue);
                        cmd.Parameters.AddWithValue("@id_turno_inicial", grd_turno_inicial.EditValue);
                        cmd.Parameters.AddWithValue("@id_turno_final", grd_turno_fin.EditValue);
                        cmd.Parameters.AddWithValue("@user_creador", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@jornada_inicial", dtdesde.EditValue);
                        cmd.Parameters.AddWithValue("@jornada_final", dthasta.EditValue);
                        cmd.Parameters.AddWithValue("@cant_sacos", txtCandidadSacos.Text);
                        cmd.Parameters.AddWithValue("@rango_inicial", codigo_minmo);
                        cmd.Parameters.AddWithValue("@rango_final", codigo_maximo);
                        cmd.Parameters.AddWithValue("@id_decision", AsNoCumple ? 2 : 1);
                        cmd.Parameters.AddWithValue("@jornada_hora_inicial", dtdesdeJornada.Text);
                        cmd.Parameters.AddWithValue("@jornada_hora_final", dthastaJornada.Text);
                        cmd.Parameters.AddWithValue("@comentario", txtcomentarios.Text);
                        if (string.IsNullOrEmpty(btnSeleccionarPRD.Text))
                            cmd.Parameters.AddWithValue("@id_control_produccion", 0);
                        else
                            cmd.Parameters.AddWithValue("@id_control_produccion", btnSeleccionarPRD.EditValue);

                        int id_muestreo = 0;
                        id_muestreo = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsParametros.parametros_decisionRow row in dsParametros1.parametros_decision.Rows)
                        {
                            cmd = new SqlCommand("sp_set_insert_muestreo_detalle", cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@bit_tipo", 1);
                            cmd.Parameters.AddWithValue("@id_parametro", row.id_parametro);
                            cmd.Parameters.AddWithValue("@parametro", row.parametro);
                            cmd.Parameters.AddWithValue("@id_decision", row.id_decision);
                            cmd.Parameters.AddWithValue("@id_muestreo", id_muestreo);
                            cmd.Parameters.AddWithValue("@min_plan", 0);
                            cmd.Parameters.AddWithValue("@max_plan", 0);
                            cmd.Parameters.AddWithValue("@resultado_porcentaje", 0);
                            cmd.ExecuteNonQuery();
                        }

                        foreach (dsParametros.decision_minimosRow row in dsParametros1.decision_minimos.Rows)
                        {
                            bool Guardar;
                            if (row.resultado == "Pendiente")
                                Guardar = false;
                            else
                                Guardar = true;

                            if (Guardar == true)
                            {
                                cmd = new SqlCommand("sp_set_insert_muestreo_detalle", cn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@bit_tipo", 0);
                                cmd.Parameters.AddWithValue("@id_parametro", row.id_parametro);
                                cmd.Parameters.AddWithValue("@parametro", row.parametro);
                                cmd.Parameters.AddWithValue("@id_decision", row.resultado == "No Cumple" ? 2 : 1);
                                cmd.Parameters.AddWithValue("@id_muestreo", id_muestreo);
                                cmd.Parameters.AddWithValue("@min_plan", row.valorminimo);
                                cmd.Parameters.AddWithValue("@max_plan", row.valormaximo);
                                cmd.Parameters.AddWithValue("@resultado_porcentaje", row.valor);
                                cmd.ExecuteNonQuery();
                            }

                        }


                        foreach (int tm in Tarimas)
                        {
                            cmd = new SqlCommand("sp_set_bit_muestro_in_tarimaV2", cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_tm", tm);
                            cmd.Parameters.AddWithValue("@id_muestreo", id_muestreo);
                            cmd.Parameters.AddWithValue("@chkCalidad", ChkCalidad);
                            cmd.ExecuteNonQuery();
                        }
                        cn.Close();
                    }

                    catch (Exception ex)
                    {

                        CajaDialogo.Error(ex.Message);
                    }
                }
                


                if (AsNoCumple)
                {
                    this.DialogResult = DialogResult.No;
                }
                else
                {
                    this.DialogResult = DialogResult.Yes;
                }
            }
        }

        private void btnSeleccionarPRD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmSeleccionarRegistroProduccion frm = new FrmSeleccionarRegistroProduccion();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //IdRegistroControlPRD = frm.pIdRowPRB_H;
                btnSeleccionarPRD.EditValue = frm.pIdRowPRB_H;
            }
        }
    }
}