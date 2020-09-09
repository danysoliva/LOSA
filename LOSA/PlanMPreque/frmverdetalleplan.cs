using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.TransaccionesMP;
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
namespace LOSA.PlanMPreque
{
    public partial class frmverdetalleplan : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        string comentario;
        int IDplan;
        public frmverdetalleplan(int Parid, UserLogin Puser, string comment)
        {
            InitializeComponent();
            IDplan = Parid;
            UsuarioLogeado = Puser;
            comentario = comment;
            LoadDatos();
        }
        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_requisicion_plan_detalle", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_req_header", IDplan);
                dsTransaccionesMP1.requisiciones_d.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTransaccionesMP1.requisiciones_d);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)grDetalleLote.FocusedView;
            var row = (dsTransaccionesMP.requisiciones_dRow)gridView.GetFocusedDataRow();
            frmLote frm = new frmLote(UsuarioLogeado, row.id, row.id_materia_prima, row.solicitada, row.id_unidad_medida, row.unidad);
            frm.WindowState = FormWindowState.Maximized;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDatos();
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea crea la requisicion con este plan?", "Pregunta", MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
                {
                   
                    int id = IDplan;
                    int valor = 0;
                    string Msj = "";
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_insert_in_requisicion_of_plan", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_req_header", id);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        valor = dr.GetInt32(0);
                        Msj = dr.GetString(1);
                    }
                    dr.Close();
                    con.Close();
                    if (valor == 1)
                    {
                        CajaDialogo.Information("Creacion de requisicion exitoso");
                    }
                    else
                    {
                        CajaDialogo.Information(Msj);
                    }

                }
                else
                {
                            
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}