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
using System.Data.OleDb;
using Huellas;
using System.Threading;

namespace LOSA.Nir
{
    public partial class frm_cargar_lecturas : DevExpress.XtraEditors.XtraForm
    {

        DataOperations dp = new DataOperations();
        int id_lectura;
        UserLogin UsuarioLogeado;
        int tipo = 0;
        public frm_cargar_lecturas(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            tipo = 0;

            if (UsuarioLogeado.GrupoUsuario.GrupoUsuarioActivo == GrupoUser.GrupoUsuario.Administradores)
                txtVentana.Visible = true;
            else
                txtVentana.Visible = false;
        }

        public frm_cargar_lecturas(UserLogin Puser, int id)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            id_lectura = id;
            tipo = 1;//editar
            Load_lecturas();
            if (tipo == 1 )
            {
                //btnupdate.Visible = false;
                //btnSave.Visible = false;
            }
        }

        public void Load_lecturas()
        {
            string query = @"sp_load_lecturas_nir_to_edit";
            SqlConnection CN = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand(query,CN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id_lectura);
                dsNIR_PRD1.Nir_lecturas.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsNIR_PRD1.Nir_lecturas);
                CN.Close();
                query = "sp_load_titulo_de_lectura_h";

                CN.Open();
                cmd = new SqlCommand(query, CN);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",id_lectura);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtcomentario.Text = dr.IsDBNull(0) ? "" : dr.GetString(0);
                }
                dr.Close();
                CN.Close();
                


            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDescargarPlantilla_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_data.ExportToXlsx(dialog.FileName);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
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
                    dsNIR_PRD1.Nir_lecturas.Clear();

                    SplashForm frmProceso = new SplashForm();
                    try
                    {
                        myCommand.Fill(dsNIR_PRD1.Nir_lecturas);
                        dsNIR_PRD1.Nir_lecturas.AcceptChanges();
                    }
                    catch (Exception ec)
                    {
                        MessageBox.Show(ec.Message);
                    }
                    int TiempoP = 450;
                    frmProceso.ShowDialog();
                    Thread.Sleep(TiempoP);
                    frmProceso.Close();

                    txtcomentario.Focus();
                }


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnEliminarLectura_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea eliminar esa fila?", "Desea eliminar esa fila?", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK )
                {
                    grdv_data.DeleteRow(grdv_data.FocusedRowHandle);
                    dsNIR_PRD1.AcceptChanges();
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtcomentario.Text == "")
            {
                CajaDialogo.Error("No debe de quedar la caja de comentarios vacia.");
                return;
            }
            if (dsNIR_PRD1.Nir_lecturas.Rows.Count == 0)
            {
                CajaDialogo.Error("Debe de cargar por lo menos una lectora del Nir.");
                return;
            }
            if (tipo == 0) //nuevo
            {
                string query = @"sp_insert_header_lectura_nir";
                try
                {
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query,cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                    cmd.Parameters.AddWithValue("@comentario", txtcomentario.Text);
                    int Id_header = Convert.ToInt32(cmd.ExecuteScalar());
                    cn.Close();

                    query = @"sp_insert_lectura_nir_detalle";
                    foreach (dsNIR_PRD.Nir_lecturasRow row in dsNIR_PRD1.Nir_lecturas.Rows)
                    { 
                        cn.Open();
                        cmd = new SqlCommand(query,cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_h", Id_header);
                        cmd.Parameters.AddWithValue("@lote", row.__Lote == null ? " " : row.__Lote);
                        cmd.Parameters.AddWithValue("@nombre_producto", row.Nombre_de_Producto == null ? " " : row.Nombre_de_Producto);
                        cmd.Parameters.AddWithValue("@comentario", row.Comentario == null ? " " : row.Comentario);
                        cmd.Parameters.AddWithValue("@TS", row.TS == -99 ? (object)DBNull.Value : row.TS);
                        cmd.Parameters.AddWithValue("@NB", row.NB == -99 ? (object)DBNull.Value : row.NB);
                        cmd.Parameters.AddWithValue("@GH", row.GH == -99 ? (object)DBNull.Value : row.GH );
                        cmd.Parameters.AddWithValue("@broma_porcentaje", row.__Bromatologia);
                        cmd.Parameters.AddWithValue("@id_bromatologia", row.ID_Bromatologia);
                        cmd.Parameters.AddWithValue("@n_curva", row.Nombre_de_la_Curva);
                        cmd.Parameters.AddWithValue("@curva", row.__Curva);
                        cmd.Parameters.AddWithValue("@date", row._Fecha_Hora_de_Analisis);
                        cmd.Parameters.AddWithValue("@lectura", row.__Lectura);
                        cmd.ExecuteNonQuery();
                        cn.Close();               
                    }
                    CajaDialogo.Information("Se ha cargado correctamente la plantilla");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }

               
            }
            else
            {       //editar

                string query = @"sp_update_titulo_de_leccturas";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id_lectura);
                cmd.Parameters.AddWithValue("@comentario", txtcomentario.Text);
                cmd.ExecuteNonQuery();
                CajaDialogo.Information("Se ha cambiado correctamente el nombre de la plantilla");
                this.DialogResult = DialogResult.OK;
            }
            
        }
    }
}