using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using LOSA.Clases;
using System.Data.SqlClient;
using System.Data;
using ACS.Classes;

namespace LOSA.Produccion
{
    public partial class rptRequisaMaterialEmpaque : DevExpress.XtraReports.UI.XtraReport
    {
        int id_requisa = 0;
        public rptRequisaMaterialEmpaque(int pid_req)
        {

            InitializeComponent();
            id_requisa = pid_req;
            MaterialEmpaque req1 = new MaterialEmpaque();
            req1.RecuperarRequisaH_ME(id_requisa);
            lblComentario.Text = req1.comentario;
            lblCreado.Text = req1.requ_creador;
            lblSolicitado.Text = req1.solicitante_prd;
            xrlbfechaCreacion.Text = req1.date_solicitud.ToString();
            xrlblTurno.Text = req1.turno;
            xrlblNumReq.Text = req1.codigo_barra; 
            cargardetalle(id_requisa);
        }

        private void cargardetalle(int pid_requisa)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAMS);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_rpt_detalle_requisa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_requisa", pid_requisa);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMaterialEmpaque1.requisa_detalle.Clear();
                adat.Fill(dsMaterialEmpaque1.requisa_detalle);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}
