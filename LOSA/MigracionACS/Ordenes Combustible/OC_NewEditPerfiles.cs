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
using LOSA.MigracionACS.Ordenes_Combustible;
using LOSA.MigracionACS.Classes;

namespace LOSA.MigracionACS.Ordenes_Combustible
{
    public partial class OC_NewEditPerfiles : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int id;
        public enum tipotrans
        {
            insert = 1,
            update = 2
        }
        tipotrans vtipotrans;
        string operacion = "";


        public OC_NewEditPerfiles()
        {
            InitializeComponent();
            vtipotrans = tipotrans.insert;
            lblEditarP.Visible = false;
            lblCrearP.Visible = true;
            //LoadUsuarios();
            LoadFuel();
        }

        public OC_NewEditPerfiles(int pid)
        {
            InitializeComponent();
            OrdenesCombustible OC = new OrdenesCombustible();
            vtipotrans = tipotrans.update;
            OC.RecuperarRegistos(pid);
            id = pid;
            lblEditarP.Visible = true;
            lblCrearP.Visible = false;
            LoadFuel();
            LoadConfFuel(pid);
            //LoadUsuarios();
            
            txtName.Text = OC.name;
            txtPlaca.Text = OC.license_plate;
            txtCar.Text = OC.car;
            checkUserActive.Checked = OC.enable;
            gridTipoFuel.EditValue = OC.fuel;
        }

        private void LoadUsuarios()
        {
            try
            {
                string sql = @"SELECT [id]
                                      ,[nombre]
                                  FROM [dbo].[conf_usuarios]
                                  where activo = 1
                                    order by 2 asc";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsOrdenesCombustible1.usuarios.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsOrdenesCombustible1.usuarios);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadConfFuel(int pid)
        {
            try
            {
                string sql = @"SELECT  [id]
                                      ,[liters]
                                      ,[tanque_lleno]
                                      ,[enable]
                                      ,[obs]
                                  FROM [dbo].[FuelOrders_ConfFuel]
	                                where [id_perfil] = " + pid;
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsOrdenesCombustible1.gridConFuel.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsOrdenesCombustible1.gridConFuel);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
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

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
            if (string.IsNullOrEmpty(gridTipoFuel.Text))
            {
                CajaDialogo.Error("No puede quedar este espacio vacio");
                gridTipoFuel.Focus();
                return;
            }

            //Validar detalle
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
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

                //if (row[3] != null)
                //{
                //    if (string.IsNullOrEmpty(row[3].ToString()))
                //    {
                //        CajaDialogo.Error("No se permite grabar Cantidades en blanco!");
                //        return;
                //    }
                //}
                //else
                //{
                //    CajaDialogo.Error("No se permite grabar cantidades en blanco!");
                //    return;
                //}

                //if (row[4] != null)
                //{
                //    if (string.IsNullOrEmpty(row[4].ToString()))
                //    {
                //        CajaDialogo.Error("No se permite grabar precios en blanco!");
                //        return;
                //    }
                //}
                //else
                //{
                //    CajaDialogo.Error("No se permite grabar precios en blanco!");
                //    return;
                //}
            }

            switch (vtipotrans)
            {
                case tipotrans.insert:
                    //insertar un nuevo perfil
                    try
                    {
                        //operacion = "insert";

                        DataOperations dp = new DataOperations();
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("FuelOrderInsertHeaderPerfil", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@car", txtCar.Text);
                        cmd.Parameters.AddWithValue("@license_plate", txtPlaca.Text);
                        cmd.Parameters.AddWithValue("@userActive", checkUserActive.Checked);
                        cmd.Parameters.AddWithValue("@fuel", gridTipoFuel.EditValue);
                        //cmd.ExecuteNonQuery();
                        //conn.Close();

                        int lastID = Convert.ToInt32(cmd.ExecuteScalar());
                        conn.Close();

                        for (int i = 0; i < gridView1.DataRowCount; i++)
                        {
                            cmd.Parameters.Clear();
                            DataRow row = gridView1.GetDataRow(i);

                            SqlConnection conn2 = new SqlConnection(dp.ConnectionStringCostos);
                            conn2.Open();
                            SqlCommand cmd2 = new SqlCommand("FuelOrderInserDetailPerfil", conn2);
                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.AddWithValue("@id_perfil", lastID);
                            cmd2.Parameters.AddWithValue("@liters", Convert.ToDecimal(row["liters"]));
                            cmd2.Parameters.AddWithValue("@tanque_lleno", Convert.ToByte(row["tanque_lleno"]));
                            cmd2.Parameters.AddWithValue("@enable", Convert.ToByte(row["enable"]));
                            cmd2.Parameters.AddWithValue("@obs", Convert.ToString(row["obs"]));
                            cmd2.ExecuteNonQuery();
                            conn2.Close();
                        }

                        this.DialogResult = DialogResult.OK;
                        this.Close();

                        CajaDialogo.Information("Perfil creado exitosamente!");
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }

                    break;
                case tipotrans.update:
                    //Actualizar Registro
                    OrdenesCombustible OC = new OrdenesCombustible();
                    OC.RecuperarRegistos(id);
                    OC.name = txtName.Text;
                    OC.car = txtCar.Text;
                    OC.license_plate = txtPlaca.Text;
                    OC.enable = checkUserActive.Checked;
                    OC.fuel = Convert.ToInt32(gridTipoFuel.EditValue);
                    OC.ActualizarsiRegistros(id);

                    for (int i = 0; i < gridView1.DataRowCount; i++)
                    {
                        DataRow row1 = gridView1.GetDataRow(i);

                        SqlConnection conn2 = new SqlConnection(dp.ConnectionStringCostos);
                        conn2.Open();
                        SqlCommand cmd2 = new SqlCommand("FuelOrderInserDetailPerfil", conn2);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@id_perfil", id);
                        cmd2.Parameters.AddWithValue("@liters", Convert.ToDecimal(row1["liters"]));
                        cmd2.Parameters.AddWithValue("@tanque_lleno", Convert.ToByte(row1["tanque_lleno"]));
                        cmd2.Parameters.AddWithValue("@enable", Convert.ToByte(row1["enable"]));
                        cmd2.Parameters.AddWithValue("@obs", Convert.ToString(row1["obs"]));
                        cmd2.ExecuteNonQuery();
                        conn2.Close();
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                    CajaDialogo.Information("Perfil Actualizado Existosmente");
                    break;
                default:
                    CajaDialogo.Error("No se definio una operacion de transaccion (INSERT-UPDATE) para este formulario");
                    break;
            }
        }

        private void checkUserActive_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkUserActive.Checked)
            {
                checkUserActive.Text = "Activo";
            }
            else
            {
                checkUserActive.Text = "Inactivo";
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            dsOrdenesCombustible.gridConFuelRow row1 = dsOrdenesCombustible1.gridConFuel.NewgridConFuelRow();

            row1.liters = Convert.ToDecimal("0");
            row1.tanque_lleno = false;
            row1.enable = true;

            dsOrdenesCombustible1.gridConFuel.AddgridConFuelRow(row1);
            dsOrdenesCombustible1.AcceptChanges();
        }

        private void repositoryItemDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Desea eliminar esta configuracion de la orden?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            var gridView1 = (GridView)gridFuel.FocusedView;
            var row = (dsOrdenesCombustible.gridConFuelRow)gridView1.GetFocusedDataRow();

            try
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
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
                var gridview = (GridView)gridFuel.FocusedView;
                var row = (dsOrdenesCombustible.gridConFuelRow)gridview.GetFocusedDataRow();

                if (e.Column.FieldName == "tanque_lleno")
                {
                    if (Convert.ToBoolean(e.Value) == true)
                    {
                        row.liters = 0;
                        var gridview1 = (GridView)gridFuel.FocusedView;
                        var row2 = (dsOrdenesCombustible.gridConFuelRow)gridview1.GetDataRow(e.RowHandle);

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

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "liters")
            {
                var gridview = (GridView)gridFuel.FocusedView;
                var row = (dsOrdenesCombustible.gridConFuelRow)gridview.GetFocusedDataRow();

                if (row.tanque_lleno == true)
                {
                    row.liters = 0;
                }
                else
                {
                    row.obs = "";
                }

                dsOrdenesCombustible1.AcceptChanges();
            }
        }
    }
}