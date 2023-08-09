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
using LOSA.MigracionACS.Classes;

namespace LOSA.MigracionACS.Ordenes_Combustible
{
    public partial class OC_OrdenManual : DevExpress.XtraEditors.XtraForm
    {
        int id_perfil;
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        public OC_OrdenManual(UserLogin pUserC, int pid)
        {
            InitializeComponent();
            id_perfil = pid;
            UsuarioLogeado = pUserC;
            OrdenesCombustible OC = new OrdenesCombustible();
            OC.RecuperarRegistos(id_perfil);
            txtName.Text = OC.name;
            txtCar.Text = OC.car;
            txtPlaca.Text = OC.license_plate;
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

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            dsOrdenesCombustible.OrdenManualRow row = dsOrdenesCombustible1.OrdenManual.NewOrdenManualRow();

            row.liters = 0;
            row.bit_tanquelleno = false;

            dsOrdenesCombustible1.OrdenManual.AddOrdenManualRow(row);
            dsOrdenesCombustible1.AcceptChanges();

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //int contador;

            if (gridView1.DataRowCount == 0)
            {
                CajaDialogo.Error("Debe agregar el detalle de la Orden!");
                return;
            }

            if (string.IsNullOrEmpty(txtName.Text))
            {
                CajaDialogo.Error("No puede quedar este espacio vacio");
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtCar.Text))
            {
                CajaDialogo.Error("No puede quedar este espacio vacio");
                txtCar.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPlaca.Text))
            {
                CajaDialogo.Error("No puede quedar este espacio vacio");
                txtPlaca.Focus();
                return;
            }

            //Validar detalle
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                if (row[0] != null)
                {
                    if (string.IsNullOrEmpty(row[0].ToString()))
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

                //if (row[1] != null)
                //{
                //    if (string.IsNullOrEmpty(row[1].ToString()))
                //    {
                //        CajaDialogo.Error("No se permite grabar descripciones en blanco!");
                //        return;
                //    }
                //}
                //else
                //{
                //    CajaDialogo.Error("No se permite grabar descripciones en blanco!");
                //    return;
                //}

                if (row[2] != null)
                {
                    if (string.IsNullOrEmpty(row[2].ToString()))
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

                if (row[3] != null)
                {
                    if (string.IsNullOrEmpty(row[3].ToString()))
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

            try
            {
                //INSERT ORDEN MANUAL 

                DataOperations dp = new DataOperations();
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                //conn.Open();
                //SqlCommand cmd = new SqlCommand("FuelOrderManualOrder", conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idperfil", id_perfil);
                //cmd.Parameters.AddWithValue("@id_usercreate", UsuarioLogeado.UserId);
                //cmd.ExecuteNonQuery();
                //conn.Close

                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    //cmd.Parameters.Clear();
                    DataRow row = gridView1.GetDataRow(i);

                    SqlConnection conn2 = new SqlConnection(dp.ConnectionStringCostos);
                    conn2.Open();
                    SqlCommand cmd2 = new SqlCommand("FuelOrderManualOrder", conn2);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@idperfil", id_perfil);
                    cmd2.Parameters.AddWithValue("@id_usercreate", UsuarioLogeado.UserId);
                    cmd2.Parameters.AddWithValue("@liters", Convert.ToDecimal(row["liters"]));
                    cmd2.Parameters.AddWithValue("@tanque_lleno", Convert.ToBoolean(row["bit_tanquelleno"]));
                    cmd2.Parameters.AddWithValue("@obs", Convert.ToString(row["obs"]));
                    cmd2.Parameters.AddWithValue("@fuel_id", Convert.ToInt32(row["id_fuel"]));
                    cmd2.ExecuteNonQuery();
                    conn2.Close();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();

                CajaDialogo.Information("Orden Creada Exitosamente!");
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var gridview = (GridView)gridFuelManual.FocusedView;
                var row = (dsOrdenesCombustible.OrdenManualRow)gridview.GetFocusedDataRow();

                if (e.Column.FieldName == "tanque_lleno")
                {
                    if (Convert.ToBoolean(e.Value) == true)
                    {
                        row.liters = 0;
                        var gridview1 = (GridView)gridFuelManual.FocusedView;
                        var row2 = (dsOrdenesCombustible.OrdenManualRow)gridview1.GetDataRow(e.RowHandle);

                        //gridview1.Columns["coliters"].;
                    }
                    else
                    {
                        row.obs = "";
                    }
                    dsOrdenesCombustible1.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}