using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.Logistica.Models;
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

namespace LOSA.Logistica
{
    public partial class xfrmMP_Reproceso_Tarimas : DevExpress.XtraEditors.XtraForm
    {
        UserLogin userLogin = new UserLogin();
        public xfrmMP_Reproceso_Tarimas(UserLogin pUser)
        {
            InitializeComponent();
            userLogin = pUser;

            dtFechaDesde.DateTime = DateTime.Now.AddDays(-1); ;
            dtFechaHasta.DateTime = DateTime.Now;
            LoadData();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            if (dtFechaDesde.EditValue != null && dtFechaHasta.EditValue != null)
            {

                productoTerminado_List = new List<Producto_Terminado>();
                labelControl1.Text = "Seleccionado(s): " + productoTerminado_List.Count();
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();
                    SqlCommand cmm2 = new SqlCommand("dbo.sp_get_pt_tarima_reproceso", con);
                    cmm2.CommandType = CommandType.StoredProcedure;
                    cmm2.Parameters.AddWithValue("@fdesde", dtFechaDesde.EditValue);
                    cmm2.Parameters.AddWithValue("@fhasta", dtFechaHasta.EditValue);

                    dsLogistica2.PT_Reproceso.Clear();
                    SqlDataAdapter adat = new SqlDataAdapter(cmm2);
                    adat.Fill(dsLogistica2.PT_Reproceso);
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }

        List< Producto_Terminado> productoTerminado_List = new List<Producto_Terminado>();
        private void gvPT_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "seleccionar")
                {
                    var row = (dsLogistica2.PT_ReprocesoRow)gvPT.GetFocusedDataRow();
                    Producto_Terminado productoTerminado = new Producto_Terminado();
                    productoTerminado.ID = row.id;
                    productoTerminado.TarimaID = row.id_tarima;
                    productoTerminado.CodigoBarra = row.codigo_barra;

                    if (row.seleccionar == true)
                    {
                        //Se agrega elemento a la clase
                        productoTerminado_List.Add(productoTerminado);
                        gvPT.UpdateCurrentRow();
                        labelControl1.Text = "Seleccionado(s): " + productoTerminado_List.Count();
                        gvPT.PostEditor();
                    }
                    else
                    {
                        //count--;

                        var item = productoTerminado_List.Single(x => x.ID == row.id);
                        productoTerminado_List.Remove(item);
                        labelControl1.Text = "Seleccionado(s): " + productoTerminado_List.Count();
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gvPT_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        private void ceSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            //hace refresh del grid despues que cambia el valor de la celda
            gvPT.PostEditor();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void dtFechaDesde_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtFechaHasta_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

         SqlTransaction transaction;
        private void cmdGuardar_Click(object sender, EventArgs e)
        {

            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection conexion = new SqlConnection(dp.ConnectionStringLOSA);

                conexion.Open();

                transaction = conexion.BeginTransaction();

                    SqlCommand cmd = new SqlCommand("dbo.sp_insert_kardex_PT_reproceso", transaction.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaction;

                    cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value=DateTime.Now;
                    cmd.Parameters.Add("@user_id", SqlDbType.Int).Value=userLogin.Id;

                   int id_inserted= Convert.ToInt32( cmd.ExecuteScalar());

                foreach (var item in productoTerminado_List)
                {
                    SqlCommand cmd2 = new SqlCommand("dbo.sp_insert_kardex_PT_reproceso_d", transaction.Connection);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Transaction = transaction;

                    cmd2.Parameters.Add("@id_h", SqlDbType.Int).Value = id_inserted;
                    cmd2.Parameters.Add("@id_tarima", SqlDbType.Int).Value = item.TarimaID;

                    cmd2.ExecuteNonQuery();

                }

                transaction.Commit();

                CajaDialogo.Information("DATOS GUARDADOS");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaction.Rollback();
            }
        }

        private void xfrmMP_Reproceso_Tarimas_Load(object sender, EventArgs e)
        {

        }
    }
} 