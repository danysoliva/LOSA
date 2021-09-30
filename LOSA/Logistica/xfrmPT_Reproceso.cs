using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace LOSA.Logistica
{
    public partial class xfrmPT_Reproceso : DevExpress.XtraEditors.XtraForm
    {
        UserLogin userLogin;

        public xfrmPT_Reproceso(UserLogin pUser)
        {
            InitializeComponent();
            userLogin = pUser;
            LoadData();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            xfrmMP_Reproceso_Tarimas frm = new xfrmMP_Reproceso_Tarimas(userLogin);

            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
            //frm.Show();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            //if (dtFechaDesde.EditValue != null && dtFechaHasta.EditValue != null)
            //{

                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();
                    SqlCommand cmm2 = new SqlCommand("dbo.sp_get_kardex_PT_reproceso", con);
                    cmm2.CommandType = CommandType.StoredProcedure;
                    //cmm2.Parameters.AddWithValue("@fdesde", dtFechaDesde.EditValue);
                    //cmm2.Parameters.AddWithValue("@fhasta", dtFechaHasta.EditValue);

                    dsLogistica2.PT_Reproceso_Creado .Clear();
                    SqlDataAdapter adat = new SqlDataAdapter(cmm2);
                    adat.Fill(dsLogistica2.PT_Reproceso_Creado);
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            //}
        }
    }
}