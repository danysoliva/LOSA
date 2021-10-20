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
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Threading;
using Huellas;

namespace LOSA.Calidad
{
    public partial class frmMateriaPrimaAjuste : DevExpress.XtraEditors.XtraForm
    {
        public int idmp;
        public string mp;
        public string codigo;
        public UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        public frmMateriaPrimaAjuste(int pidMp, string pmp, UserLogin Puser)
        {
            InitializeComponent();
            idmp = pidMp;
            mp = pmp;
            UsuarioLogeado = Puser;
            txtmp.Text = mp;
            load_data();
            txtcodigo.Text = codigo;
            load_criterios();
            load_data_configurada();
        }

        public void load_criterios()
        {
           

                string Query = @"sp_load_critero_olor";
                try
                {
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dsMantenimientoC.Olor.Clear();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsMantenimientoC.Olor);
                    cn.Close();

                    Query = @"sp_load_critero_color";
                    cn.Open();
                    cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dsMantenimientoC.Color.Clear();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dsMantenimientoC.Color);
                    cn.Close();


                    Query = @"sp_load_critero_textura";
                    cn.Open();
                    cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dsMantenimientoC.textura.Clear();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dsMantenimientoC.textura);
                    cn.Close();


                    Query = @"sp_load_critero_grumos";
                    cn.Open();
                    cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dsMantenimientoC.Grumos.Clear();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dsMantenimientoC.Grumos);
                    cn.Close();

                
               Query = @"sp_load_critero_insectos";
                    cn.Open();
                    cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dsMantenimientoC.insectos.Clear();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dsMantenimientoC.insectos);
                    cn.Close();


                Query = @"sp_load_critero_origen";
                cn.Open();
                cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsMantenimientoC.origen.Clear();
                da = new SqlDataAdapter(cmd);
                da.Fill(dsMantenimientoC.origen);
                cn.Close();
                      }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }

            
        }

        public void load_data()
        {
            string query = @"sp_obtener_codigo_mp";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", idmp);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    codigo = dr.GetString(0);
                }
                dr.Close();
                cn.Close();
                

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_data_configurada()
        {
            string query = @"sp_load_configuracion_mp_calidad";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", idmp);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    grd_olor.EditValue = dr.IsDBNull(0) ? 0 : dr.GetInt32(0);
                    grd_color.EditValue = dr.IsDBNull(1) ? 0 : dr.GetInt32(1);
                    grd_textura.EditValue = dr.IsDBNull(2) ? 0 : dr.GetInt32(2);
                    grd_grumos.EditValue = dr.IsDBNull(3) ? 0 : dr.GetInt32(3);
                    grd_insectos.EditValue = dr.IsDBNull(4) ? 0 : dr.GetInt32(4);
                    grd_origen.EditValue = dr.IsDBNull(5) ? 0 : dr.GetInt32(5);
                }
                dr.Close();
                cn.Close();

                cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                query = @"sp_load_parametros_nir_to_edit";
                cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(@"@idmp", idmp);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsMantenimientoC.Data.Clear();
                da.Fill(dsMantenimientoC.Data);
                cn.Close();



            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void frmMateriaPrimaAjuste_Load(object sender, EventArgs e)
        {

        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDescargarPlantilla_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grd_data.ExportToXlsx(dialog.FileName);
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCargarPlantilla_Click(object sender, EventArgs e)
        {
            try
            {
                string file_name = string.Empty;

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Excel File(.xlsx)| *.xlsx";
                //dialog.InitialDirectory = @"C:\";
                dialog.Title = "Seleccione el archivo importado anteriormente";
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    file_name = @dialog.FileName.ToString();
                    string Connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file_name + "; Extended Properties=\"Excel 12.0 Xml; HDR = YES\"";
                    OleDbConnection con = new OleDbConnection(Connection);
                    OleDbDataAdapter myCommand = new OleDbDataAdapter("select * from [Sheet$]", con);
                    dsMantenimientoC.Data.Clear();

                    SplashForm frmProceso = new SplashForm();
                    try
                    {
                        myCommand.Fill(dsMantenimientoC.Data);
                        dsMantenimientoC.Data.AcceptChanges();
                    }
                    catch (Exception ec)
                    {
                        MessageBox.Show(ec.Message);
                    }
                    int TiempoP = 450;
                    frmProceso.ShowDialog();
                    Thread.Sleep(TiempoP);
                    frmProceso.Close();

                }


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32( grd_olor.EditValue) == 0 || grd_olor.EditValue == null )
            {

                CajaDialogo.Error("Debe seleccionar el criterio de olor de la MP.");
                if (tabPane1.SelectedPageIndex == 0)
                {

                    grd_olor.ShowPopup();
                }
                else
                {
                    tabPane1.SelectedPageIndex = 0;
                    grd_olor.ShowPopup();
                }
                return;
            }
            if (Convert.ToInt32(grd_color.EditValue) == 0 || grd_color.EditValue == null)
            {
                CajaDialogo.Error("Debe seleccionar el criterio de color de la MP.");
                if (tabPane1.SelectedPageIndex == 0)
                {

                    grd_color.ShowPopup();
                }
                else
                {
                    tabPane1.SelectedPageIndex = 0;
                    grd_color.ShowPopup();
                }
                return;
            }
            if (Convert.ToInt32(grd_textura.EditValue) == 0 || grd_textura.EditValue == null)
            {
                CajaDialogo.Error("Debe seleccionar el criterio de textura de la MP.");
                if (tabPane1.SelectedPageIndex == 0)
                {

                    grd_textura.ShowPopup();
                }
                else
                {
                    tabPane1.SelectedPageIndex = 0;
                    grd_textura.ShowPopup();
                }
                return;
            }
            if (Convert.ToInt32(grd_grumos.EditValue) == 0 || grd_grumos.EditValue == null)
            {
                CajaDialogo.Error("Debe seleccionar el criterio de grumos de la MP.");
                if (tabPane1.SelectedPageIndex == 0)
                {

                    grd_grumos.ShowPopup();
                }
                else
                {
                    tabPane1.SelectedPageIndex = 0;
                    grd_grumos.ShowPopup();
                }
                return;
            }
            if (Convert.ToInt32(grd_insectos.EditValue) == 0 || grd_insectos.EditValue == null)
            {
                CajaDialogo.Error("Debe seleccionar el criterio de Plagas de la MP.");
                if (tabPane1.SelectedPageIndex == 0)
                {

                    grd_insectos.ShowPopup();
                }
                else
                {
                    tabPane1.SelectedPageIndex = 0;
                    grd_insectos.ShowPopup();
                }
                return;
            }
            if (Convert.ToInt32(grd_origen.EditValue) == 0 || grd_origen.EditValue == null)
            {
                CajaDialogo.Error("Debe seleccionar el criterio de Origen de la MP.");
                if (tabPane1.SelectedPageIndex == 0)
                {

                    grd_origen.ShowPopup();
                }
                else
                {
                    tabPane1.SelectedPageIndex = 0;
                    grd_origen.ShowPopup();
                }
                return;
            }

            if (dsMantenimientoC.Data.Rows.Count <= 0)
            {

                CajaDialogo.Error("Debe de cargar los parametros de comparacion con las lecturas NIR.");
                if (tabPane1.SelectedPageIndex == 1)
                {

                    
                }
                else
                {
                    tabPane1.SelectedPageIndex = 1;
                }
                return;
            }

            try
            {
                string query = @"sp_insert_into_parametros_calidad_mp";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp",idmp);
                cmd.Parameters.AddWithValue("@id_criterio_color", grd_color.EditValue);
                cmd.Parameters.AddWithValue("@id_criterio_grumos", grd_grumos.EditValue);
                cmd.Parameters.AddWithValue("@id_criterio_insectos", grd_insectos.EditValue);
                cmd.Parameters.AddWithValue("@id_criterio_olor", grd_olor.EditValue);
                cmd.Parameters.AddWithValue("@id_criterio_textura", grd_textura.EditValue);
                cmd.Parameters.AddWithValue("@id_criterio_pais", grd_origen.EditValue);
                cmd.ExecuteNonQuery();


                query = @"sp_delete_all_parametros_nir";
                cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", idmp);
                cmd.ExecuteNonQuery();

                foreach (dsMantenimientoC.DataRow row in dsMantenimientoC.Data.Rows)
                {
                    query = @"sp_insert_new_parametro_validacion";
                    cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_mp", idmp);
                    cmd.Parameters.AddWithValue("@maximo", row.Maximo);
                    cmd.Parameters.AddWithValue("@minimo", row.Minimo);
                    cmd.Parameters.AddWithValue("@id_bromatologia", row.Parametro);
                    cmd.ExecuteNonQuery();
                }

                CajaDialogo.Information("Se ha registrado toda la informacion.");
                this.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                grdv_data.DeleteRow(grdv_data.FocusedRowHandle);
               
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}