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
        int id_pt;
        string codigo_minmo;
        string codigo_maximo;
        UserLogin UsuarioLogeado;
        public FrmRegistroMuestreo(ArrayList ParametroTarimas, string ParametroLote, UserLogin Puser)
        {
            InitializeComponent();
            Lote = ParametroLote;
            Tarimas = ParametroTarimas;
            load_data();
            load_turno();
            load_parametros_fisicos_cumplo_no_cumple();
            load_parametros_fisicos_min_max();
            load_decision();
            obtener_sacos();
            load_obtenet_rango();
            UsuarioLogeado = Puser;
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
                dsParametros.turno.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsParametros.turno);
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
                dsParametros.decision_values.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsParametros.decision_values);
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
                dsParametros.parametros_decision.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsParametros.parametros_decision);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_parametros_fisicos_min_max()
        {
            string query = @"sp_get_parametros_protuctos_revision_fisica_min_max";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", id_pt);
                dsParametros.decision_minimos.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsParametros.decision_minimos);
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
            if (dtdesde.EditValue == null)
            {
                CajaDialogo.Error("Debe escoger la jornada y la hora de inicio.");
                dtdesde.ShowPopup();
                return;
            }
            if (dthasta.EditValue == null)
            {
                CajaDialogo.Error("Debe escoger la jornada y la hora de final.");
                dtdesde.ShowPopup();
                return;
            }
            bool AsNoCumple = false;
            foreach (dsParametros.parametros_decisionRow row in dsParametros.parametros_decision.Rows)
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
            foreach (dsParametros.decision_minimosRow row in dsParametros.decision_minimos.Rows)
            {
                if (row.resultado == "Pendiente")
                {
                    CajaDialogo.Error("El parametro "+ row.parametro + " Esta vacio. Por favor llenarlo.");
                    return;
                }
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
                string query = @"sp_insert_muestreo_of_product";
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
                    cmd.Parameters.AddWithValue("@id_decision", AsNoCumple ?2 :1 );
                    int id_muestreo = 0;
                    id_muestreo = Convert.ToInt32(cmd.ExecuteScalar());

                    foreach (dsParametros.parametros_decisionRow row in dsParametros.parametros_decision.Rows)
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

                    foreach (dsParametros.decision_minimosRow row in dsParametros.decision_minimos.Rows)
                    {
                        cmd = new SqlCommand("sp_set_insert_muestreo_detalle", cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@bit_tipo", 0);
                        cmd.Parameters.AddWithValue("@id_parametro", row.id_parametro);
                        cmd.Parameters.AddWithValue("@parametro", row.parametro);
                        cmd.Parameters.AddWithValue("@id_decision", row.resultado == "No Cumple" ? 2 : 1  );
                        cmd.Parameters.AddWithValue("@id_muestreo", id_muestreo);
                        cmd.Parameters.AddWithValue("@min_plan", row.valorminimo);
                        cmd.Parameters.AddWithValue("@max_plan", row.valormaximo);
                        cmd.Parameters.AddWithValue("@resultado_porcentaje",row.valor);
                        cmd.ExecuteNonQuery();
                    }
                    foreach (int tm in Tarimas)
                    {
                        cmd = new SqlCommand("sp_set_bit_muestro_in_tarima", cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_tm", tm);
                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }

                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
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
    }
}