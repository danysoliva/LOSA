using ACS.Classes;
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

namespace LOSA.TransaccionesMP.Liquidos
{
    public partial class frmBinesEnPRD : DevExpress.XtraEditors.XtraForm
    {
        public int Id_requisa;
        public int id_materiaPrima;
        int Default_Value = 0;
        decimal Entregado;
        decimal PorEntregarTarima;
        decimal CantidadPendiente;
        int id_req_detalle;
        public frmBinesEnPRD(int id_req, int id_mp)
        {
            InitializeComponent();
            id_materiaPrima = id_mp;
            Id_requisa = id_req;
            CantidadPendiente = Default_Value;
            id_req_detalle = Default_Value;
            Entregado = Default_Value;
            PorEntregarTarima = Default_Value;
            load_bines_disponibles();
            Obtener_Pendiente();

        }

        private void load_bines_disponibles()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_bines_disponibles_liquidos_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                cmd.Parameters.AddWithValue("@id_mp", id_materiaPrima);
                dsTransaccionesMP.bines_disponibles.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTransaccionesMP.bines_disponibles);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        public void Obtener_Pendiente()
        {
            try
            {
              
                string query = @"sp_obtener_pendiente_rq";
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_req", Id_requisa);
                cmd.Parameters.AddWithValue("@id_mp", id_materiaPrima);



                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    CantidadPendiente = dr.IsDBNull(0) ? Default_Value : dr.GetDecimal(0);
                    id_req_detalle = dr.IsDBNull(1) ? Default_Value : dr.GetInt32(1);
                }

                dr.Close();
                cn.Close();

                if (id_req_detalle == Default_Value)
                {
                    CajaDialogo.Error("Error en la operacion, por favor revisar el procedimiento 'sp_obtener_pendiente_rq' ");
                    return;
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void Entregar_componentes(decimal PendienteAsignacion, int id_tm)
        {
           
            string query;
            DataOperations dp = new DataOperations();
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            SqlCommand cmd;

            PorEntregarTarima = Default_Value;
                if (Entregado != CantidadPendiente)
                {     // Si no se ha entregado todo el material. bueno, entonces vamos a consumir lo pendiente.
                    PorEntregarTarima = Entregado + PendienteAsignacion <= CantidadPendiente ? PendienteAsignacion : CantidadPendiente - Entregado;


                    query = @"sp_consumir_tarimas_pendientes_liquidos";
                    cn.Open();
                    cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_req_detalle", id_req_detalle);
                    cmd.Parameters.AddWithValue("@PorEntregar", PorEntregarTarima);
                    cmd.Parameters.AddWithValue("@id_tarima", id_tm);
                    cmd.ExecuteNonQuery();
                    Entregado = Entregado + PorEntregarTarima;
                    cn.Close();
                }
        }
       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var Bin_pendientes in dsTransaccionesMP.bines_disponibles)
                {
                    Entregar_componentes(Bin_pendientes.PendienteAsignacion, Bin_pendientes.id_tarima);

                }
                load_bines_disponibles();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnConsumir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsTransaccionesMP.bines_disponiblesRow)gridView.GetFocusedDataRow();
            Entregar_componentes(row.PendienteAsignacion, row.id_tarima);
            CajaDialogo.Information("Entregado correctamente.");
            load_bines_disponibles();
         }
    }
}