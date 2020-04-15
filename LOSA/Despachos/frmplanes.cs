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
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Despachos
{
   
    public partial class frmplanes : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin Uslogin;
        public frmplanes(UserLogin UsuarioLogeado)
        {
            InitializeComponent();
            LoadData();
            Uslogin = UsuarioLogeado;
        }
        public void LoadData()
        {
            string query = @"EXEC [dbo].[sp_get_load_planes_de_despachos]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                 SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.planes_creados.Clear();
                da.Fill(ds_despachos.planes_creados);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_planes.FocusedView;
                var row = (ds_despachos.planes_creadosRow)gridview.GetFocusedDataRow();
                frmplandespacho Frm = new frmplandespacho(row.id_orden_de_venta, Uslogin, row.CardCode,row.CardName, row.DocNum);
                Frm.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnejecutar_Click(object sender, EventArgs e)
        {
            try
            {
                string Mensaje;
                int Idproblema;
                Boolean sepuede; 
                if (MessageBox.Show("Seguro que deseas enviar a cargar este plan?, Al ser cargado no podra modificarse", "Pregunta",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var gridview = (GridView)grd_planes.FocusedView;
                    var row = (ds_despachos.planes_creadosRow)gridview.GetFocusedDataRow();

                    string query = @"EXEC	[dbo].[sp_orden_venta_validacion]
		                            @Idofplan = @idofplan";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    try
                    {
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.Parameters.Add("@idofplan", SqlDbType.Int).Value = row.id;
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            
                            sepuede = Convert.ToBoolean(dr[0].ToString());
                            Idproblema = dr.GetInt32(1);
                            Mensaje = dr.GetString(2);
                            if (sepuede)
                            {

                                dr.Close();
                                cn.Close();
                                SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA);
                                cn.Open();
                                query = @"EXEC [dbo].[sp_insert_en_requesiciones_pt]
		                        @idplan = @idplan,
		                        @iduser = @userid";
                                SqlCommand sqlCommand = new SqlCommand(query, cn);
                                sqlCommand.Parameters.Add("@idplan", SqlDbType.Int).Value = row.id;
                                sqlCommand.Parameters.Add("@userid", SqlDbType.Int).Value = Uslogin.Id;
                                sqlCommand.ExecuteNonQuery();
                                CajaDialogo.Information("Transaccion exitosa!.");
                            }
                            else
                            {
                                CajaDialogo.Error(Mensaje);
                                dr.Close();
                                cn.Close();
                            }
                        }
                        else
                        {
                            CajaDialogo.Error("ha ocurrido un error.. contactar a IT.");
                        }
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                }

            
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}