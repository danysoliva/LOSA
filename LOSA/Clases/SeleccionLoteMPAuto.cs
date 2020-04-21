using ACS.Classes;
using LOSA.TransaccionesMP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
    public class SeleccionLoteMPAuto
    {
        public SeleccionLoteMPAuto(int pIdMP_ACS, int pIdReqDetlle, decimal pCantidadRequerida, int pIdusuario)
        {
            dsTransaccionesMP2 = new dsTransaccionesMP();
            IdMP_ACS = pIdMP_ACS;
            IdReqDetlle = pIdReqDetlle;
            CantidadPendiente = pCantidadRequerida;
            idUsuario = pIdusuario;
            LoadDetalleLotes();
            AutoSelect();
        }

        #region Miembros
        dsTransaccionesMP dsTransaccionesMP2;
        int IdMP_ACS, IdReqDetlle, idUsuario;
        decimal CantidadPendiente;
        #endregion







        public bool Guardar_SeleccionLoteAuto()
        {
            bool result = false;
            int Seleccionados = 0;
            foreach (dsTransaccionesMP.detalle_lote_mpRow row in dsTransaccionesMP2.detalle_lote_mp.Rows)
            {
                if (row.seleccionado)
                {
                    Seleccionados++;
                    break;
                }
            }

            if (Seleccionados <= 0)
                return false;
            

            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd1 = new SqlCommand("sp_set_delete_seleccion_lote_mp", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@id_detalle_req", IdReqDetlle);
                cmd1.ExecuteNonQuery();

                foreach (dsTransaccionesMP.detalle_lote_mpRow row in dsTransaccionesMP2.detalle_lote_mp.Rows)
                {
                    if (row.seleccionado)
                    {
                        SqlCommand cmd = new SqlCommand("sp_get_insert_lotes_req_mp", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@lote_mp", row.lote_mp);
                        cmd.Parameters.AddWithValue("@id_detalle_req", IdReqDetlle);
                        cmd.Parameters.AddWithValue("@cantidad", row.cants);
                        cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                        cmd.Parameters.AddWithValue("@id_tarima", row.id);
                        cmd.ExecuteNonQuery();
                    }
                }
                result = true;
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("Error en la clase SeleccionLoteMPAuto. Error: "+ ec.Message);
                result = false;
            }


            return result;
        }











        private void LoadDetalleLotes()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_lotes_mp_req", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idmp", IdMP_ACS);
                cmd.Parameters.AddWithValue("@id_detalle_req", IdMP_ACS);

                dsTransaccionesMP2.detalle_lote_mp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTransaccionesMP2.detalle_lote_mp);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        ///Genera la autoseleccion de los lotes
        private void AutoSelect()
        {
            decimal total_solicitado = CantidadPendiente;
            decimal cantidaPendiente = CantidadPendiente;

            foreach (dsTransaccionesMP.detalle_lote_mpRow row in dsTransaccionesMP2.detalle_lote_mp.Rows)
            {
                if (row.peso_total == cantidaPendiente)
                {
                    row.seleccionado = true;
                    cantidaPendiente = 0;
                    row.cants = row.peso_total;
                    break;
                }
                if (row.peso_total > cantidaPendiente && cantidaPendiente > 0)
                {
                    if (row.peso_total > cantidaPendiente)
                        row.cants = cantidaPendiente;
                    else
                        row.cants = total_solicitado - cantidaPendiente;

                    //row.cants = row.peso_total - cantidaPendiente;
                    cantidaPendiente -= row.cants;
                    row.seleccionado = true;
                    break;
                }
                else
                {
                    //en el row tenemos un valor menor que el solicitado
                    //Necesitaremos mas de un row para satisfaser la cantidad requerida.
                    if (row.peso_total < cantidaPendiente && cantidaPendiente > 0)
                    {
                        if (row.peso_total > 0)
                        {
                            //seleccionamos la cantidad total del row para acumular el valor solictado.
                            row.cants = row.peso_total;

                            //Restamos la cantidad conseguida o asignada.
                            cantidaPendiente -= row.cants;

                            //Marcamos el row seleccionado porque se utilizaria dicho lote para la requisicion.
                            row.seleccionado = true;
                        }
                    }
                }
                //end block foreach
            }

        }










    }
}
