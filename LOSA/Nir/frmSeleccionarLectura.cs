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
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Nir
{
    public partial class frmSeleccionarLectura : DevExpress.XtraEditors.XtraForm
    {
        public int id_lectura;
        public int id_h, numero_transaccion, id_mp;
        public int id_lote;
        public string Lote;
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        public frmSeleccionarLectura(UserLogin Puser,int pnumer_transaccion, int pid_mp, string pLote)
        {
            InitializeComponent();
            dtDesde.EditValue = dp.Now().AddDays(-15);
            dtHasta.EditValue = dp.Now();
            UsuarioLogeado = Puser;
            numero_transaccion = pnumer_transaccion;
            id_mp = pid_mp;
            Lote = pLote;
            //id_lote = pid_lote;
            load_Data();
        }



        public void load_Data() 
        {
            if (tsVerTodos.IsOn)
            {
                try
                {
                    string Query = @"sp_load_lecturas_to_pick";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dsNir.seleccion_lectura.Clear();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsNir.seleccion_lectura);
                    cn.Close();

                    dtDesde.Enabled = false;
                    dtHasta.Enabled = false;
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            else
            {
                string Query = @"sp_load_lecturas_to_pickV2";
                try
                {
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Desde", dtDesde.EditValue);
                    cmd.Parameters.AddWithValue("@Hasta", dtHasta.EditValue);
                    dsNir.seleccion_lectura.Clear();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsNir.seleccion_lectura);
                    cn.Close();

                    dtDesde.Enabled = true;
                    dtHasta.Enabled = true;
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }

        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsNir.seleccion_lecturaRow)gridView.GetFocusedDataRow();
                id_lectura = row.id;
                id_h = row.id_h;
                if (CajaDialogo.Pregunta("Desea ligar esta lectura a este ingreso?") == DialogResult.Yes)
                {
                    string query = @"sp_insert_in_trz_nir_ingreso";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query,cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_lectura", id_lectura);
                    cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                    //cmd.Parameters.AddWithValue("@id_ingreso", id_lote);
                    cmd.Parameters.AddWithValue("@id_h_lectura", id_h);
                    cmd.Parameters.AddWithValue("@num_transaccion", numero_transaccion);
                    cmd.Parameters.AddWithValue("@id_mp", id_mp);
                    cmd.Parameters.AddWithValue("@lote", Lote);
                    cmd.ExecuteNonQuery();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdv_data_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsNir.seleccion_lecturaRow)gridView.GetFocusedDataRow();
                id_lectura = row.id;
                id_h = row.id_h;
                if (CajaDialogo.Pregunta("Desea ligar esta lectura a este ingreso?") == DialogResult.Yes)
                {
                    string query = @"sp_insert_in_trz_nir_ingreso";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_lectura", id_lectura);
                    cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                    //cmd.Parameters.AddWithValue("@id_ingreso", id_lote);
                    cmd.Parameters.AddWithValue("@id_h_lectura", id_h);
                    cmd.Parameters.AddWithValue("@num_transaccion", numero_transaccion);
                    cmd.Parameters.AddWithValue("@id_mp", id_mp);
                    cmd.Parameters.AddWithValue("@lote", Lote);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSubirSeleccionada_Click(object sender, EventArgs e)
        {
            try
            {
                int cant = 0;
                foreach (dsNir.seleccion_lecturaRow row in dsNir.seleccion_lectura.Rows)
                {
                    if (row.selecionada)
                    {
                        cant++;
                    }
                }
                if (cant > 0)
                {
                    if (CajaDialogo.Pregunta("Desea ligar las lecturas selecionadas?") == DialogResult.Yes)
                    {
                        foreach (dsNir.seleccion_lecturaRow row in dsNir.seleccion_lectura.Rows)
                        {
                            if (row.selecionada)
                            {
                                id_lectura = row.id;
                                id_h = row.id_h;
                                string query = @"sp_insert_in_trz_nir_ingreso";
                                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                                cn.Open();

                                SqlCommand cmd = new SqlCommand(query, cn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_lectura", id_lectura);
                                cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                                cmd.Parameters.AddWithValue("@id_h_lectura", id_h);
                                cmd.Parameters.AddWithValue("@num_transaccion",numero_transaccion);
                                cmd.Parameters.AddWithValue("@id_mp", id_mp);
                                cmd.Parameters.AddWithValue("@lote", Lote);
                                cmd.ExecuteNonQuery();
                                cn.Close();
                            }
                        }
                    }
                }
                else
                {
                    CajaDialogo.Error("Debe seleccionar al menos una lectura para ligar.");
                    return;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();

               
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdv_data_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colselecionada")
                {
                    var gridView = (GridView)grd_data.FocusedView;
                    var row = (dsNir.seleccion_lecturaRow)gridView.GetFocusedDataRow();
                    row.selecionada = Convert.ToBoolean(e.Value);
                    row.AcceptChanges();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void chTodas_CheckedChanged(object sender, EventArgs e)
        {
            //Seleccionar lo Filtrado en Grid

            var gridView = (GridView)grd_data.FocusedView;
            int conta = dsNir.seleccion_lectura.Count;

            for (int i = 0; i < conta; i++)
            {
                dsNir.seleccion_lecturaRow row = (dsNir.seleccion_lecturaRow)gridView.GetDataRow(i);
                int r = gridView.GetVisibleRowHandle(i);
                if (r >= 0)
                {
                    if (row != null)
                    {
                        row.selecionada = chTodas.Checked;
                    }
                }
                else
                {
                    if (row != null)
                    {
                        row.selecionada = false;
                    }
                }
            }

            //if (chTodas.Checked)
            //{
            //    foreach (dsNir.seleccion_lecturaRow row in dsNir.seleccion_lectura.Rows)
            //    {
            //        row.selecionada = true;
            //        row.AcceptChanges();
            //    }
            //}
            //else
            //{
            //    foreach (dsNir.seleccion_lecturaRow row in dsNir.seleccion_lectura.Rows)
            //    {
            //        row.selecionada = false;
            //        row.AcceptChanges();
            //    }
            //}

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_Data();
        }

        private void tsVerTodos_Toggled(object sender, EventArgs e)
        {
            load_Data();
        }
    }
}