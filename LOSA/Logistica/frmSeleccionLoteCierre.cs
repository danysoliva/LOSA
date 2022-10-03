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
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Logistica
{
    public partial class frmSeleccionLoteCierre : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        DataTable MpList;
        decimal NuevaCantidad = 0;
        int id_count_selected;
        decimal sum = 0;
        int bodega;
        int IdMpSelected = 0;
        public frmSeleccionLoteCierre(UserLogin puserLogin, DataTable pdata)
        {
            InitializeComponent();
            UsuarioLogeado = puserLogin;
            MpList = pdata;
            get_bodegas();
            enumerar_rows();
            grd_mps.DataSource = pdata;


        }

        public void enumerar_rows()
        {
            int enumerador = 0;
            foreach (DataRow row in MpList.Rows)
            {
                row["count_id"] = enumerador;
               
                enumerador++;
            }

            MpList.AcceptChanges();
        }

        public void get_lotes(int id_mp, int id_bodega )
        {

            dsCierreMes.SeleccionLote.Clear();

            if (dsCierreMes.memory_config.Count(x => x.id_lote_count == id_count_selected)==0)
            {

                string query = @"sp_get_existencia_lote_mp";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_bodega", id_bodega);
                    cmd.Parameters.AddWithValue("@id_mp", id_mp);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsCierreMes.SeleccionLote);
                    cn.Close();

                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            else
            {
                foreach (dsCierreMes.SeleccionLoteRow row in dsCierreMes.SeleccionLote.Rows)
                {
                    foreach (dsCierreMes.memory_configRow rows in dsCierreMes.memory_config.Rows)
                    {
                        if (row.lote== rows.lote)
                        {

                        }
                    }
                }
            }
        }
        public void get_bodegas()
        {
            string query = @"sp_get_bodegas_id_descripcion";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsCierreMes.bodegas.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCierreMes.bodegas);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void splitterControl1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void grdv_mps_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                var SelectedrOWS = grdv_mps.GetDataRow(e.RowHandle);

                IdMpSelected = Convert.ToInt32(SelectedrOWS["id_mp"]);
                bodega = Convert.ToInt32(SelectedrOWS["id_bodega"]);
                id_count_selected = Convert.ToInt32(SelectedrOWS["count_id"]);
                NuevaCantidad = Convert.ToDecimal(SelectedrOWS["peso"]);
                sum = 0;
                get_lotes(IdMpSelected, bodega);
            }
            catch (Exception)
            {
            }
        }

        private void grdv_existencia_lote_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
               
            try
            {
                if (e.Column.FieldName == "seleccionar")
                {
                    var gridView = (GridView)grd_existencia_lote.FocusedView;
                    var row = (dsCierreMes.SeleccionLoteRow)gridView.GetFocusedDataRow();
                    row.seleccionar = Convert.ToBoolean(e.Value);
                    row.AcceptChanges();
                    var list = dsCierreMes.SeleccionLote.AsEnumerable();
                    if (list.Count(p => p.seleccionar == true) > 0)
                    {
                        btnDerecha.Enabled = true;
                    }
                    else
                    {
                        btnDerecha.Enabled = false;
                    }
                }



                
            }
            catch (Exception)
            {

            }

            
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            var list = dsCierreMes.SeleccionLote.AsEnumerable();
            if (list.Count(p => p.seleccionar == true && p.utilizado == 0) > 0)
            {
                CajaDialogo.Error("Hay lotes seleccionado sin configurar la cantidad a utilizar.");
                return;
            }
            var Row = from row in list
                      where row.seleccionar == true
                      select row;
            foreach (var recorrido in Row)
            {
                DataRow dr = dsCierreMes.Aceptado_lote.NewRow();
                dr["id_mp"] = recorrido.id_mp;
                dr["descripcion"] = recorrido.descripcion;
                dr["ExistenciaAprox"] = recorrido.ExistenciaAprox;
                dr["lote"] = recorrido.lote;
                dr["seleccionar"] = false;
                dr["utilizado"] = recorrido.utilizado;
                dr["id_lote_alosy"] = recorrido.id_lote_alosy;
                dr["id_bodega"] = bodega;
                dr["id_lote_count"] = id_count_selected;

                dsCierreMes.Aceptado_lote.Rows.Add(dr);
                DataRow drw = dsCierreMes.memory_config.NewRow();
                drw["id_mp"] = recorrido.id_mp;
                drw["descripcion"] = recorrido.descripcion;
                drw["ExistenciaAprox"] = recorrido.ExistenciaAprox;
                drw["lote"] = recorrido.lote;
                drw["seleccionar"] = false;
                drw["utilizado"] = recorrido.utilizado;
                drw["id_lote_alosy"] = recorrido.id_lote_alosy;
                drw["id_bodega"] = bodega;
                drw["id_lote_count"] = id_count_selected;
                dsCierreMes.memory_config.Rows.Add(drw);
                btnDerecha.Enabled = false;
                // +

            }


        }

        private void grdv_existencia_lote_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "utilizado")
                {
                    var gridView = (GridView)grd_existencia_lote.FocusedView;
                    var row = (dsCierreMes.SeleccionLoteRow)gridView.GetFocusedDataRow();
                    if ((sum + row.utilizado) > NuevaCantidad)
                    {
                        CajaDialogo.Error("La cantidad configurada en los lotes es mayor a la nueva cantidad.");
                        return;
                    }
                    var list = dsCierreMes.SeleccionLote.AsEnumerable();
                    sum = list.Sum(x => x.utilizado);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void chauto_CheckedChanged(object sender, EventArgs e)
        {
            if (chauto.Checked == true)
            {
                decimal Auxiliar = NuevaCantidad;
                decimal operador = 0;
                foreach (dsCierreMes.SeleccionLoteRow row in dsCierreMes.SeleccionLote.Rows)
                {
                    operador = 0;
                    if (Auxiliar != 0)
                    {
                        if (row.ExistenciaAprox <= Auxiliar)
                        {
                            operador = operador + row.ExistenciaAprox;
                            Auxiliar = Auxiliar - operador;
                        }
                        else
                        {
                            operador = operador + Auxiliar;
                            Auxiliar = 0;
                        }

                        row.utilizado = operador;
                        row.seleccionar = true;
                       
                    }

                }
                dsCierreMes.SeleccionLote.AcceptChanges();
                btnDerecha.Enabled = true;
            }
            else
            {
                foreach (dsCierreMes.SeleccionLoteRow row in dsCierreMes.SeleccionLote.Rows)
                {
                    row.utilizado = 0;
                    row.seleccionar = false;
                }
                dsCierreMes.SeleccionLote.AcceptChanges();
                btnDerecha.Enabled = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}