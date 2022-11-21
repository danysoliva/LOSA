using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
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

namespace LOSA.MigracionACS.Produccion.ForecastPRD
{
    public partial class frmFCT_produccion : DevExpress.XtraEditors.XtraForm
    {
        int Mes = 0;
        int Anio = 0;
        UserLogin UsuarioLogeado;
        decimal totalPlaneado;
        decimal totalPrd;
        public frmFCT_produccion(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            Mes = DateTime.Now.Month;
            SetMes();
            comboBoxAnio.Text = DateTime.Now.Year.ToString();
        }
        private void SetMes()
        {
            switch (Mes)
            {
                case 1:
                    comboBoxMes.Text = "Enero";
                    break;
                case 2:
                    comboBoxMes.Text = "Febrero";
                    break;
                case 3:
                    comboBoxMes.Text = "Marzo";
                    break;
                case 4:
                    comboBoxMes.Text = "Abril";
                    break;
                case 5:
                    comboBoxMes.Text = "Mayo";
                    break;
                case 6:
                    comboBoxMes.Text = "Junio";
                    break;
                case 7:
                    comboBoxMes.Text = "Julio";
                    break;
                case 8:
                    comboBoxMes.Text = "Agosto";
                    break;
                case 9:
                    comboBoxMes.Text = "Septiembre";
                    break;
                case 10:
                    comboBoxMes.Text = "Octubre";
                    break;
                case 11:
                    comboBoxMes.Text = "Noviembre";
                    break;
                case 12:
                    comboBoxMes.Text = "Diciembre";
                    break;
                default:
                    Mes = 0;
                    break;
            }
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            if(Mes<=0 || Anio <= 0)
            {
                CajaDialogo.Error("Es necesario definir el mes y el año antes de agregar un producto!");
                return;
            }

            frmAddFCT_produccion frm = new frmAddFCT_produccion(Mes, Anio, radioGroupEspecie.EditValue);
            if(frm.ShowDialog()== DialogResult.OK)
            {
                dsFCT_PRD.new_prodDataTable table = frm.dsFCT_PRD1.new_prod;
                bool recorded = false;
                foreach(dsFCT_PRD.new_prodRow row in table.Rows)
                {
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                        con.Open();

                        SqlCommand cmd = new SqlCommand("sp_insert_fct_prd_detalle", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@id", idBodega);
                        cmd.Parameters.AddWithValue("@id_mes", frm.Mes);
                        cmd.Parameters.AddWithValue("@id_producto", row.idpt);
                        cmd.Parameters.AddWithValue("@tm", row.tm);
                        cmd.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.UserId);
                        cmd.Parameters.AddWithValue("@anio", frm.Anio);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        recorded = true;
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                }
                if (recorded)
                {
                    LoadData();
                }
            }
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMes.Text)
            {
                case "Enero":
                    Mes = 1;
                    break;
                case "Febrero":
                    Mes = 2;
                    break;
                case "Marzo":
                    Mes = 3;
                    break;
                case "Abril":
                    Mes = 4;
                    break;
                case "Mayo":
                    Mes = 5;
                    break;
                case "Junio":
                    Mes = 6;
                    break;
                case "Julio":
                    Mes = 7;
                    break;
                case "Agosto":
                    Mes = 8;
                    break;
                case "Septiembre":
                    Mes = 9;
                    break;
                case "Octubre":
                    Mes = 10;
                    break;
                case "Noviembre":
                    Mes = 11;
                    break;
                case "Diciembre":
                    Mes = 12;
                    break;
                default:
                    Mes = 0;
                    break;
            }
            LoadData();
        }

        private void LoadData()
        {
            if (!string.IsNullOrEmpty(comboBoxMes.Text) && !string.IsNullOrEmpty(comboBoxAnio.Text))
            {
                //Mes = Convert.ToInt32(comboBoxMes.Text);
                Anio = Convert.ToInt32(comboBoxAnio.Text);
                if (Mes > 0)
                {
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                        con.Open();

                        SqlCommand cmd = new SqlCommand("sp_load_fct_prd_detalle_v2", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@id", idBodega);
                        cmd.Parameters.AddWithValue("@id_mes", Mes);
                        cmd.Parameters.AddWithValue("@anio", comboBoxAnio.Text);
                        cmd.Parameters.AddWithValue("@especie", radioGroupEspecie.EditValue);
                        //set dataset
                        dsFCT_PRD1.fct_prd.Clear();
                        SqlDataAdapter adat = new SqlDataAdapter(cmd);
                        adat.Fill(dsFCT_PRD1.fct_prd);
                        con.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                }
            }
            CalcularTotales();
        }

        private void CalcularTotales()
        {
            totalPlaneado = 0 ;
            totalPrd = 0;
            foreach (dsFCT_PRD.fct_prdRow row in dsFCT_PRD1.fct_prd.Rows)
            {
                totalPlaneado += row.tm;
                totalPrd += row.prod;
            }

            decimal porcentaje_cumplimiento = 0;
            if (totalPlaneado > 0)
            {
                porcentaje_cumplimiento = (totalPrd / totalPlaneado) * 100;
            }
            lblCumplimientoTotal.Text = string.Format("{0:00.0}%", porcentaje_cumplimiento);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "tm")
            {
                try
                {
                    var gridView = (GridView)gridControl1.FocusedView;
                    var row = (dsFCT_PRD.fct_prdRow)gridView.GetFocusedDataRow();

                    if (row.id > 0)
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                        con.Open();

                        SqlCommand cmd = new SqlCommand("sp_update_fct_prd", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@id", idBodega);
                        cmd.Parameters.AddWithValue("@tm", row.tm);
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.ExecuteNonQuery();
                        if (row.tm > 0)
                        {
                            row.percent = row.prod / row.tm * 100;
                        }
                        con.Close();
                    }
                    else
                    {
                        //Insertar el id pt para que se puedan digitar y guardar las TM
                        try
                        {
                            DataOperations dp = new DataOperations();
                            SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                            con.Open();

                            SqlCommand cmd = new SqlCommand("sp_insert_fct_prd_detalle", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            //cmd.Parameters.AddWithValue("@id", idBodega);
                            cmd.Parameters.AddWithValue("@id_mes", Mes);
                            cmd.Parameters.AddWithValue("@id_producto", row.idpt);
                            cmd.Parameters.AddWithValue("@tm", row.tm);
                            cmd.Parameters.AddWithValue("@id_user", this.UsuarioLogeado);
                            cmd.Parameters.AddWithValue("@anio", Anio);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (Exception ec)
                        {
                            CajaDialogo.Error(ec.Message);
                        }
                    }
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }

            if (e.Column.FieldName == "codeodoo")
            {
                string CodePasted = "";
                try
                {
                    CodePasted = e.Value.ToString();
                }
                catch {}

                if (!string.IsNullOrEmpty(CodePasted))
                {
                    DataOperations dp = new DataOperations();
                    ProductoTerminado pt = new ProductoTerminado(dp.ConnectionStringCostos);
                    if (pt.Recuperar_producto(CodePasted))
                    {
                        if (!CodigoDuplicado(CodePasted))
                        {
                            var gridView = (GridView)gridControl1.FocusedView;
                            var row = (dsFCT_PRD.fct_prdRow)gridView.GetDataRow(e.RowHandle);

                            row.codesap = pt.codesap;
                            row.name = pt.descripcion;
                            dsFCT_PRD1.fct_prd.Addfct_prdRow(row);
                            dsFCT_PRD1.AcceptChanges();

                            try
                            {
                                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                                con.Open();

                                SqlCommand cmd = new SqlCommand("sp_insert_fct_prd_detalle", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                //cmd.Parameters.AddWithValue("@id", idBodega);
                                cmd.Parameters.AddWithValue("@id_mes",Mes);
                                cmd.Parameters.AddWithValue("@id_producto", row.idpt);
                                cmd.Parameters.AddWithValue("@tm", row.tm);
                                cmd.Parameters.AddWithValue("@id_user", this.UsuarioLogeado);
                                cmd.Parameters.AddWithValue("@anio", Anio);
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                            catch (Exception ec)
                            {
                                CajaDialogo.Error(ec.Message);
                            }
                        }
                        else
                        {
                            //Borrar los que no tienen descripcion
                            BorrarRowsSinDescripcion();
                        }
                    }

                }
            }

            if (e.Column.FieldName == "codesap")
            {
                string CodePasted = "";
                try
                {
                    CodePasted = e.Value.ToString();
                }
                catch { }

                if (!string.IsNullOrEmpty(CodePasted))
                {
                    DataOperations dp = new DataOperations();
                    ProductoTerminado pt = new ProductoTerminado(dp.ConnectionStringCostos);
                    if (pt.Recuperar_productoFromSapCode(CodePasted))
                    {
                        if (!CodigoDuplicado(CodePasted))
                        {
                            var gridView = (GridView)gridControl1.FocusedView;
                            var row = (dsFCT_PRD.fct_prdRow)gridView.GetDataRow(e.RowHandle);

                            row.codeodoo = pt.codigo;
                            row.name = pt.descripcion;
                            dsFCT_PRD1.fct_prd.Addfct_prdRow(row);
                            dsFCT_PRD1.AcceptChanges();
                            try
                            {
                                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                                con.Open();

                                SqlCommand cmd = new SqlCommand("sp_insert_fct_prd_detalle", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                //cmd.Parameters.AddWithValue("@id", idBodega);
                                cmd.Parameters.AddWithValue("@id_mes", Mes);
                                cmd.Parameters.AddWithValue("@id_producto", row.idpt);
                                cmd.Parameters.AddWithValue("@tm", row.tm);
                                cmd.Parameters.AddWithValue("@id_user", this.UsuarioLogeado);
                                cmd.Parameters.AddWithValue("@anio", Anio);
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                            catch (Exception ec)
                            {
                                CajaDialogo.Error(ec.Message);
                            }
                        }
                        else
                        {
                            //Borrar los que no tienen descripcion
                            BorrarRowsSinDescripcion();
                        }
                    }

                }
            }
        }

        private void BorrarRowsSinDescripcion()
        {
            try
            {
                int rowHandler = 0;
                foreach (dsFCT_PRD.fct_prdRow row in dsFCT_PRD1.fct_prd.Rows)
                {
                    string nombre = "";
                    try
                    {
                        nombre = row.name;
                    }
                    catch { }

                    if (string.IsNullOrEmpty(nombre))
                    {
                        gridView1.DeleteRow(rowHandler);
                    }
                    rowHandler++;
                }
            }
            catch { }
        }

        private bool CodigoDuplicado(string codePasted)
        {
            bool duplicado = false;
            try
            {
                foreach(dsFCT_PRD.fct_prdRow row in dsFCT_PRD1.fct_prd.Rows)
                {
                    if(row.codeodoo == codePasted || row.codesap == codePasted)
                    {
                        duplicado = true;
                        break;
                    }
                }
            }
            catch{}
            return duplicado;
        }

        private void cmdDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Esta seguro de eliminar este registro?");
            if (r != DialogResult.Yes)
                return;

            try
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsFCT_PRD.fct_prdRow)gridView.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_update_fct_prd_disable", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id", idBodega);
                //cmd.Parameters.AddWithValue("@tm", row.tm);
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.ExecuteNonQuery();
                row.Delete();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void radioGroupEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}