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
using LOSA.Clases;

namespace LOSA.MigracionACS.Ordenes_Combustible
{
    public partial class OC_PreVisualizacionesOrdenes : DevExpress.XtraEditors.XtraForm
    {
        string operacion = "preorden";
        UserLogin UsuarioLogeado;
        public OC_PreVisualizacionesOrdenes(UserLogin pUserC)
        {
            InitializeComponent();
            UsuarioLogeado = pUserC;
            LoadOrdenes();
            LoadFuel();
        }

        private void LoadFuel()
        {
            try
            {
                string query = @"SELECT [id]
                                       ,[description]
                                    FROM [dbo].[FuelOrders_Fuel]
                                        where enable = 1";
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                dsOrdenesCombustible1.combustible.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsOrdenesCombustible1.combustible);
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadOrdenes()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("FuelOrderOfferOrders", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_usercreate", UsuarioLogeado.UserId);
                dsOrdenesCombustible1.tempo_ordenes.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsOrdenesCombustible1.tempo_ordenes);
                con.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void repositoryItemEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //var gridView1 = (GridView)grPerfiles.FocusedView;
            //var row = (dsReemplazo.grPerfilesRow)gridView1.GetFocusedDataRow();
            //OC_NewEditPerfiles ordenes = new OC_NewEditPerfiles(row.id);
            //if (ordenes.ShowDialog() == DialogResult.OK)
            //{
            //    LoadPerfiles();
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Desea generar el lote de ordenes seleccionados?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;
            int contador = 0;

            //validar al menos uno seleccionado
            foreach (DataRow roww in dsOrdenesCombustible1.tempo_ordenes.Rows)
            {
                if (roww["seleccionar"].ToString() == "True")
                {
                    contador = contador + 1;
                    break;
                }
            }

            //Validar Detalle
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                //Validar detalle null
                DataRow row = gridView1.GetDataRow(i);
                if (row[7] != null)
                {
                    if (string.IsNullOrEmpty(row[7].ToString()))
                    {
                        CajaDialogo.Error("No se permite grabar descripciones en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permite grabar descripciones en blanco!");
                    return;
                }

                if (row[9] != null)
                {
                    if (string.IsNullOrEmpty(row[9].ToString()))
                    {
                        CajaDialogo.Error("No se permite grabar descripciones en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permite grabar descripciones en blanco!");
                    return;
                }

                if (row[10] != null)
                {
                    if (string.IsNullOrEmpty(row[10].ToString()))
                    {
                        CajaDialogo.Error("No se permite grabar descripciones en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permite grabar descripciones en blanco!");
                    return;
                }


                if (row[14] != null)
                {
                    if (string.IsNullOrEmpty(row[14].ToString()))
                    {
                        CajaDialogo.Error("No se permite grabar descripciones en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permite grabar descripciones en blanco!");
                    return;
                }


                if (row[15] != null)
                {
                    if (string.IsNullOrEmpty(row[15].ToString()))
                    {
                        CajaDialogo.Error("No se permite grabar descripciones en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permite grabar descripciones en blanco!");
                    return;
                }


                if (row[16] != null)
                {
                    if (string.IsNullOrEmpty(row[16].ToString()))
                    {
                        CajaDialogo.Error("No se permite grabar descripciones en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permite grabar descripciones en blanco!");
                    return;
                }
            }

            //Si el contador es mayor de 0
            if (contador > 0)
            {
                try
                {
                    foreach (DataRow row1 in dsOrdenesCombustible1.tempo_ordenes.Rows)
                    {
                        if (Convert.ToBoolean(row1["seleccionar"]) == true)
                        {
                            DataOperations dp = new DataOperations();
                            SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                            con.Open();

                            SqlCommand cmd = new SqlCommand("FuelOrderCreateOrderV2", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@usercreate", UsuarioLogeado.UserId);
                            cmd.Parameters.AddWithValue("@num_order", Convert.ToString(row1["num_order"]));
                            cmd.Parameters.AddWithValue("@id_perfil", Convert.ToInt32(row1["id_perfil"]));
                            cmd.Parameters.AddWithValue("@fuelid", Convert.ToInt32(row1["fuelid"]));
                            cmd.Parameters.AddWithValue("@liters", Convert.ToDecimal(row1["liters"]));
                            cmd.Parameters.AddWithValue("@bit_tanquelleno", Convert.ToBoolean(row1["bit_tanquelleno"]));
                            cmd.Parameters.AddWithValue("@obs", Convert.ToString(row1["obs"]));
                            cmd.Parameters.AddWithValue("@semana", Convert.ToInt32(row1["semana"]));
                            cmd.Parameters.AddWithValue("@car", Convert.ToString(row1["car"]));
                            cmd.Parameters.AddWithValue("@license_plate", Convert.ToString(row1["license_plate"]));
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    CajaDialogo.Information("Ordenes creadas exitosamente!");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
            else
            {
                CajaDialogo.Error("");
            }

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridview = (GridView)grPerfiles.FocusedView;
            var row = (dsOrdenesCombustible.tempo_ordenesRow)gridview.GetFocusedDataRow();

            if (e.Column.FieldName == "liters")
            {
                if (row.bit_tanquelleno == true)
                {
                    row.liters = 0;
                }
                dsOrdenesCombustible1.AcceptChanges();
            }
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridview = (GridView)grPerfiles.FocusedView;
            var row = (dsOrdenesCombustible.tempo_ordenesRow)gridview.GetFocusedDataRow();

            foreach (dsOrdenesCombustible.tempo_ordenesRow tab in dsOrdenesCombustible1.tempo_ordenes.Rows)
            {

                if (tab.id == row.id)
                {
                    if (e.Column.FieldName == "seleccionar")
                    {
                        if (Convert.ToBoolean(e.Value))
                        {
                            tab.num_order = 0;
                            
                        }
                        tab.seleccionar = Convert.ToBoolean(e.Value);
                        reorganizar();
                    }
                }

            }
            dsOrdenesCombustible1.tempo_ordenes.AcceptChanges();

            if (e.Column.FieldName == "bit_tanquelleno")
            {
                if (Convert.ToBoolean(e.Value) == true)
                {
                    row.liters = 0;
                }
                dsOrdenesCombustible1.AcceptChanges();
            }

            if (e.Column.FieldName == "liters")
            {
                if (row.bit_tanquelleno == true)
                {
                    row.liters = 0;
                }
                dsOrdenesCombustible1.AcceptChanges();
            }
        }

        public void reorganizar()
        {
            int Salvar = 0;
            string query = @"SELECT [siguiente] as sig
							FROM[dbo].[conf_tables_id]
							where id = 12";
            DataOperations dp = new DataOperations();
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                Salvar = Convert.ToInt32(cmd.ExecuteScalar());
                foreach (dsOrdenesCombustible.tempo_ordenesRow tab in dsOrdenesCombustible1.tempo_ordenes.Rows)
                {
                    if (tab.seleccionar)
                    {
                        tab.num_order = Salvar;
                        Salvar++;

                    }
                    else
                    {
                        tab.num_order = 0;
                    }
                }
                dsOrdenesCombustible1.tempo_ordenes.AcceptChanges();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }

        private void dtAllDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime FechaOrdenes = dtAllDate.Value;

            try
            {
                foreach (dsOrdenesCombustible.tempo_ordenesRow row in dsOrdenesCombustible1.tempo_ordenes.Rows)
                {
                    row.date = FechaOrdenes.Date;
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
   
}