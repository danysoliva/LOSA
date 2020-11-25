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
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using Huellas;
using System.Threading;

namespace LOSA.RecuentoInventario
{
    public partial class frmRecuentoInventario : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmRecuentoInventario()
        {
            InitializeComponent();
            cargarMateriaPrima();
        }

        private void cargarMateriaPrima()
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL = @"[dbo].[sp_get_list_MP_by_tarima_id_mp]";

                dsRecuento.materia_prima.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);

                adat.Fill(dsRecuento.materia_prima);
                cn.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public void load_tarimas()
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL = @"sp_load_tarimas_to_edit";

                dsRecuento.tarimas.Clear();
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", cbMateriaPrima.EditValue);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);

                adat.Fill(dsRecuento.tarimas);
                cn.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }
        private void cbMateriaPrima_EditValueChanged(object sender, EventArgs e)
        {
            load_tarimas();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
           
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            int TiempoP = 2000;
            SplashForm frmProceso = new SplashForm();
            try
            {
                cn.Open();
               
                foreach (dsRecuento.tarimasRow row in dsRecuento.tarimas)
                {
                    if (row.eliminar)
                    {
                        string query = @"sp_eliminar_tarima";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_tarima", row.id);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                    }
                    else
                    {
                        string query = @"sp_update_tarima_recuento";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ingreso", row.ingreso);
                        cmd.Parameters.AddWithValue("@id_tarima", row.id);
                        cmd.Parameters.AddWithValue("@lote_materia_prima", row.lote_materia_prima);
                        cmd.Parameters.AddWithValue("@cantidad", row.cantidad);  
                        cmd.Parameters.AddWithValue("@peso", row.peso);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    

                }
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            frmProceso.ShowDialog();
            Thread.Sleep(TiempoP);
            frmProceso.Close();
            load_tarimas();

        }

        private void grdv_data_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsRecuento.tarimasRow)gridView.GetFocusedDataRow();
                switch (e.Column.Name)
                {
                    case "colEIngreso":
                        bool ingreso = row.EIngreso;
                        row.EIngreso = Convert.ToBoolean(e.Value); 
                        foreach (dsRecuento.tarimasRow item in dsRecuento.tarimas.Rows)
                        {
                            if (row.ingreso == item.ingreso)
                            {
                                item.EIngreso = Convert.ToBoolean(e.Value);
                                item.eliminar = Convert.ToBoolean(e.Value);    
                                if (Convert.ToBoolean(e.Value))
                                {
                                    
                                    item.peso = 0;
                                    item.cantidad = 0;
                                }
                                else
                                {
                                    item.cantidad = item.CantidadSave;
                                    item.peso = item.cantidad * item.factor;
                                }
                                item.AcceptChanges();
                            }
                        }
                        break;
                      case "colELote" :    
                        row.ELote = Convert.ToBoolean(e.Value);
                        foreach (dsRecuento.tarimasRow item in dsRecuento.tarimas.Rows)
                        {
                            if (row.lote_materia_prima == item.lote_materia_prima && row.ingreso == item.ingreso)
                            {
                                item.ELote = Convert.ToBoolean(e.Value);
                                item.eliminar = Convert.ToBoolean(e.Value);
                                
                                if (Convert.ToBoolean(e.Value))
                                {

                                    item.peso = 0;
                                    item.cantidad = 0;
                                }
                                else
                                {
                                    item.cantidad = item.CantidadSave;
                                    item.peso = item.cantidad * item.factor;
                                }
                                item.AcceptChanges();
                            }
                        }
                        break;
                    case "coleliminar":

                        if (Convert.ToBoolean(e.Value))
                        {
                            
                            row.eliminar = Convert.ToBoolean(e.Value);  
                            row.peso = 0;
                            row.cantidad = 0;
                        }
                        else
                        {
                            row.EIngreso = Convert.ToBoolean(e.Value);
                            row.ELote = Convert.ToBoolean(e.Value);
                            row.eliminar = Convert.ToBoolean(e.Value);
                            row.cantidad = row.CantidadSave;
                            row.peso = row.cantidad * row.factor;
                        }
                        break;
                    case "colcantidad":
                        row.cantidad = Convert.ToDecimal(e.Value);
                        row.peso = row.cantidad * row.factor;


                        break;
                    default:
                        break;
                }


            }
            catch (Exception ex)
            {

                
            }
        }
    }
}