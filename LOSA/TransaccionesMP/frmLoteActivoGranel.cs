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
using ACS.Classes;
using LOSA.Clases;
using LOSA.RecepcionMP;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.TransaccionesMP
{
    
    public partial class frmLoteActivoGranel : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        string ItemCode;
        string Dscripcion;
        int id_ubicacion;
        string CADENA_VACIA = "";
        int DEFAULT_VALUE = 0;

        public frmLoteActivoGranel(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            id_ubicacion = DEFAULT_VALUE;
            ItemCode = CADENA_VACIA;
            load_ubicaciones();
        }

        public class Operacines
        {
            DataOperations dp = new DataOperations();
            public int id_loteActivo;
            public int Prioridad_configurada;
            public int Valor_Maximo = 0;
            public enum Sentidos
            {
                Subir = 1,
                bajar = 0

            }

           public Operacines(int Pidlote, int Pprioridad)
            {
                id_loteActivo = Pidlote;
                Prioridad_configurada = Pprioridad;
            }
            public bool MoverPrioridad(Sentidos Sentido)
            {
                bool Done = false;
                int ParOperacion = 0;
                switch (Sentido)
                {
                    case Sentidos.Subir:
                        if (Prioridad_configurada == Valor_Maximo)
                        {
                            CajaDialogo.Error("No se puede subir mas la prioridad de este lote.");
                            return false;
                        }
                        ParOperacion = 1;
                        break;
                    case Sentidos.bajar:
                        ParOperacion = 0;
                        break;

                }
                string query = @"sp_realizar_movimiento";
                SqlConnection sqlConnection = new SqlConnection(dp.ConnectionStringLOSA);
                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand(query,sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@lote_activo", id_loteActivo);
                    command.Parameters.AddWithValue("@Operacion", ParOperacion);
                    command.ExecuteNonQuery();
                    Done = true;
                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message); ;
                    return false;
                }
                return Done;
            }

           
        }
        public void load_lote_activo()
        {
            string Query = @"sp_get_lote_activo";
            SqlConnection conexion = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(Query, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@itemcode", ItemCode);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                dsGranelLoteactivo.LotesActivos.Clear();
                adapter.Fill(dsGranelLoteactivo.LotesActivos);
                conexion.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_lote_activo_onlySoya()
        {
            string Query = @"sp_get_lote_activo_ONLYSOYA";
            SqlConnection conexion = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(Query, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                dsGranelLoteactivo.LotesActivos.Clear();
                adapter.Fill(dsGranelLoteactivo.LotesActivos);
                conexion.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_ubicaciones()
        {
            string Query = @"sp_obtener_ubicaciones_of_granel";
            SqlConnection conexion = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(Query, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                dsGranelLoteactivo.ListaUbicaciones.Clear();
                adapter.Fill(dsGranelLoteactivo.ListaUbicaciones);
                conexion.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpickMP_Click(object sender, EventArgs e)
        {
            frmMP frm = new frmMP();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ItemCode = frm.ItemCode;
                Dscripcion = frm.MateriaPrima;
                txtMP.Text = Dscripcion;
                if (id_ubicacion == DEFAULT_VALUE)
                {
                    ListadeUbicaciones.ShowPopup();
                    load_lote_activo();
                        
                }
                Cargar_Existencias();
            }
        }

        public void Cargar_Existencias()
        {
            try
            {
                if (ItemCode != CADENA_VACIA  )
                {
                    string Query = @"sp_load_inventario_granel";
                    SqlConnection conexion = new SqlConnection(dp.ConnectionStringLOSA);
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(Query, conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@itemcode", ItemCode);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    dsGranelLoteactivo.ExistenciasGranel.Clear();
                    adapter.Fill(dsGranelLoteactivo.ExistenciasGranel);
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void Cargar_Existencias_onlySoya()
        {
            try
            {
                if (ItemCode != CADENA_VACIA)
                {
                    string Query = @"sp_load_inventario_granel_onlySoya";
                    SqlConnection conexion = new SqlConnection(dp.ConnectionStringLOSA);
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(Query, conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    dsGranelLoteactivo.ExistenciasGranel.Clear();
                    adapter.Fill(dsGranelLoteactivo.ExistenciasGranel);
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void ListadeUbicaciones_EditValueChanged(object sender, EventArgs e)
        {
            id_ubicacion = Convert.ToInt32(ListadeUbicaciones.EditValue);
            if (ItemCode == CADENA_VACIA)
            {
                frmMP frm = new frmMP();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ItemCode = frm.ItemCode;
                    Dscripcion = frm.MateriaPrima;
                    txtMP.Text = Dscripcion;
                    load_lote_activo();
                }
            }
            Cargar_Existencias();
        }
        

        private void btnConsumir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea poder activar este lote? Se colocara con la prioridad mas baja.... ", "Pregunta seria.. ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {    /// Si el brother de verdad quiere activar el lote pues se lo activamos..

                    var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)grd_existencias.FocusedView;
                    var row = (dsGranelLoteactivo.ExistenciasGranelRow)gridView.GetFocusedDataRow();

                    string query = @"sp_insert_in_lote_activo";
                    SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA);
                    connection.Open();
                    SqlCommand command = new SqlCommand(query,connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@lote",row.lote);
                    command.Parameters.AddWithValue("@id_mp", row.id_mp);
                    command.Parameters.AddWithValue("@id_ubicacion", row.id_ubicacion);
                    command.Parameters.AddWithValue("@itemcode", row.code_sap);
                    command.ExecuteNonQuery();
                    connection.Close();

                    if (ItemCode == "MP00001")
                    {

                        load_ordenes_en_transito();
                        load_lote_activo();
                        Cargar_Existencias();
                    }
                    else
                    {

                        load_ordenes_en_transito_onlySoya();
                        Cargar_Existencias_onlySoya();
                        load_lote_activo_onlySoya();
                    }
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }                      
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_lote_activo.FocusedView;
                var row = (dsGranelLoteactivo.LotesActivosRow)gridView.GetFocusedDataRow();
                Operacines op = new Operacines(row.id, row.prioridad);
                if (op.MoverPrioridad(Operacines.Sentidos.Subir))
                {
                    if (ItemCode == "MP00001")
                    {

                        load_lote_activo();
                    }
                    else
                    {

                      
                        load_lote_activo_onlySoya();
                    }
                }
            }
            catch (Exception ex)
            {

            }  
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_lote_activo.FocusedView;
                var row = (dsGranelLoteactivo.LotesActivosRow)gridView.GetFocusedDataRow();
                Operacines op = new Operacines(row.id, row.prioridad);
                if (op.MoverPrioridad(Operacines.Sentidos.bajar))
                {
                    if (ItemCode == "MP00001")
                    {

                        load_lote_activo();
                    }
                    else
                    {

                       
                        load_lote_activo_onlySoya();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void grdv_lote_activo_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_lote_activo.FocusedView;
                var row = (dsGranelLoteactivo.LotesActivosRow)gridView.GetDataRow(e.RowHandle);
                if (e.RowHandle >= 0)
                {

                    if (row.prioridad == 0)
                    {
                        e.Appearance.BackColor = Color.FromArgb(0, 178, 148);

                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void load_ordenes_en_transito()
        {
            string query = @"sp_load_oc_transito";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@itemcode", ItemCode);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReporteAlmacenExterno.comprasTransito.Clear();
                da.Fill(dsReporteAlmacenExterno.comprasTransito);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_ordenes_en_transito_onlySoya()
        {
            string query = @"sp_load_oc_transito_OnlySoya";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReporteAlmacenExterno.comprasTransito.Clear();
                da.Fill(dsReporteAlmacenExterno.comprasTransito);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void btnSoya_Click(object sender, EventArgs e)
        {
            btnTrigo.Appearance.BackColor = Color.FromArgb(235, 236, 239);
            btnSoya.Appearance.BackColor = Color.FromArgb(0, 178, 148);
            ItemCode = "--";
            Dscripcion = "Harina de Soya (Todo)";
            txtMP.Text = Dscripcion;
            load_ordenes_en_transito_onlySoya();
            Cargar_Existencias_onlySoya();
            load_lote_activo_onlySoya();
        }

        private void btnTrigo_Click(object sender, EventArgs e)
        {
            btnSoya.Appearance.BackColor = Color.FromArgb(235, 236, 239);
            btnTrigo.Appearance.BackColor = Color.FromArgb(0, 178, 148);


            ItemCode = "MP00001";
            Dscripcion = "Trigo";
            txtMP.Text = Dscripcion;
            load_ordenes_en_transito();
            load_lote_activo();

            
            Cargar_Existencias();
        }
    }
}