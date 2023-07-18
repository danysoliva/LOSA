using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ACS.Classes;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace LOSA.MigracionACS.IT
{
    public partial class SolcitudIT : DevExpress.XtraReports.UI.XtraReport
    {
        public SolcitudIT(string pnombre_soli, string pnombre_usuario, DateTime pfecha_soli, DateTime pfecha_eliminar, string pdepartamento
                         ,string potros_accesos, string prazon, int pticket, bool pacceso_p, bool pacceso_t, string pasignado_a, bool pacceso_especial, int pid)
        {
            InitializeComponent();
            lblUsuario.Text = pnombre_usuario;
            
            lblSolicitado.Text = pnombre_soli;
            //if (pfecha_eliminar)
            //{
                    
            //}

            lblFechaS.Text = String.Format("{0:dd/MM/yyyy}",pfecha_soli);
            if (pfecha_eliminar.Year >1)
            {
                lblFechaE.Text = String.Format("{0:dd/MM/yyyy}",pfecha_eliminar);
            }
            else
            {
                lblFechaE.Visible = false;
            }

            //lblFechaE.Text = Convert.ToString(pfecha_eliminar);
            lblDepartamento.Text = pdepartamento;
            lblAcceso.Text = potros_accesos;
            if (pticket == 0)
            {
                lblTicket.Visible = false;
            }
            else
            {
                lblTicket.Text = Convert.ToString(pticket);
            }
            

            lblRazon.Text = prazon;
            checkPermanente.Checked = pacceso_p;
            checkTemporal.Checked = pacceso_t;

            //lblArea.Text = pdepartamento;
            lblAsginado.Text = pasignado_a;
            checkEspecial.Checked = pacceso_especial;
            LoadAccesosConferidos(pid);
        }
        private void LoadAccesosConferidos(int pid)
        {
            try
            {
                string sql = @"SELECT aa.[id]
	                          ,aa.[nombre]
                              ,(select case when count(*) > 0 then 1 else 0 end
		                        from [dbo].[IT_Solicitud_acceso] 
		                        where [id_soli] = @pid and [id_acceso] = aa.id)as checkcolumn
                    FROM [dbo].[IT_Acceso] as aa
                    where [enable] = 1";
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@pid", SqlDbType.Int).Value = pid;
                dsSolicitudes1.acceso.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsSolicitudes1.acceso);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

    }
}
