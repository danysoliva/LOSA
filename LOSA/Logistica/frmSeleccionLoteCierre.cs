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
        public frmSeleccionLoteCierre(DataTable pdata, UserLogin puserLogin)
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
            string query = @"sp_get_existencia_lote_mp";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_bodega", id_bodega);
                cmd.Parameters.AddWithValue("@id_mp", id_mp);
                dsCierreMes.SeleecionLote.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCierreMes.SeleecionLote);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
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
            var SelectedrOWS = grdv_mps.GetDataRow(e.RowHandle);

            int id = Convert.ToInt32(SelectedrOWS["id_mp"]);
            int id_bodega = Convert.ToInt32(SelectedrOWS["id_bodega"]);
            id_count_selected = Convert.ToInt32(SelectedrOWS["count_id"]);
            NuevaCantidad = Convert.ToDecimal(SelectedrOWS["peso"]);
            sum = 0;
            get_lotes(id, id_bodega);
        }

        private void grdv_existencia_lote_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
               
            try
            {
                if (e.Column.FieldName == "seleccionar")
                {
                    var gridView = (GridView)grd_existencia_lote.FocusedView;
                    var row = (dsCierreMes.SeleecionLoteRow)gridView.GetFocusedDataRow();
                    row.seleccionar = Convert.ToBoolean(e.Value);
                    row.AcceptChanges();
                    var list = dsCierreMes.SeleecionLote.AsEnumerable();
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

                throw;
            }

            
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            var list = dsCierreMes.SeleecionLote.AsEnumerable();
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
                dr["id_bodega"] = id_bodega;
                dr["id_lote_count"] = id_count_selected;
                dsCierreMes.Aceptado_lote.Rows.Add(dr);

                for (int i = 0; i < dsCierreMes.memory_config.Count; i++)
                {
                    //if (dsCierreMes.memory_config.Rows[i].)
                    //{

                    //}
                }

            }


        }

        private void grdv_existencia_lote_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
             
                if (e.Column.FieldName == "utilizado")
                {
                    var gridView = (GridView)grd_existencia_lote.FocusedView;
                    var row = (dsCierreMes.SeleecionLoteRow)gridView.GetFocusedDataRow();

                    if ((sum + row.utilizado) > NuevaCantidad)
                    {
                        CajaDialogo.Error("La cantidad configurada en los lotes es mayor a la nueva cantidad.");
                        return;
                    }
                    var list = dsCierreMes.SeleecionLote.AsEnumerable();
                    sum = list.Sum(x => x.utilizado);


                    
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}